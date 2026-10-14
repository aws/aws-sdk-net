using System.Collections.Concurrent;
using System.Runtime.ExceptionServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Generation.ProjectFiles;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Converters;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// The deserialized <c>_smithy-migrated-services.json</c> control file: the SDK service names
/// (ServiceFolderName, e.g. <c>CloudTrailData</c>) the Smithy generator owns. The C2J generator
/// reads the same file to skip them.
/// </summary>
public sealed record MigratedServicesFile
{
    [JsonPropertyName("services")]
    public IReadOnlyList<string> Services { get; init; } = [];
}

/// <summary>
/// Generates every service listed in <c>generator/ServiceModels/_smithy-migrated-services.json</c>
/// into the real SDK tree, then removes whatever else was left in each service's generated trees so
/// leftover C2J output (plain <c>.cs</c> names, <c>_bcl/</c>/<c>_netstandard/</c>) can't collide with
/// the <c>.g.cs</c> output as duplicate types.
/// </summary>
public sealed class BatchGenerator(string repoRoot)
{
    private static readonly JsonSerializerOptions ModelOptions = new()
    {
        Converters = { new ShapeConverter() },
    };

    private readonly string _modelsRoot = SdkTreeLayout.ModelsRoot(repoRoot);
    private readonly string _testModelsRoot = SdkTreeLayout.TestModelsRoot(repoRoot);
    private readonly string _sdkRoot = SdkTreeLayout.SdkRoot(repoRoot);

    // A case-insensitive volume treats the old-cased entry of a renamed file as the written file; compare paths like it does.
    private readonly StringComparer _pathComparer = Directory.Exists(SdkTreeLayout.SdkRoot(repoRoot).ToUpperInvariant()) ? StringComparer.OrdinalIgnoreCase : StringComparer.Ordinal;

    /// <summary>
    /// Runs the batch generation. Returns the generated ServiceFolderNames (empty when the control
    /// file is missing or lists no services — a clean no-op so CI is unaffected until a service is
    /// listed). Throws <see cref="GeneratorException"/> on configuration errors.
    /// </summary>
    public IReadOnlyList<string> Run(CancellationToken ct = default)
    {
        var controlFilePath = Path.Combine(_modelsRoot, SdkTreeLayout.MigratedServicesFileName);
        var migrated = LoadControlFile(controlFilePath);
        if (migrated.Count == 0)
        {
            Log.Info($"No services listed in '{controlFilePath}'; nothing to generate.");
            return [];
        }

        // Per-service lines below log repo-relative paths; the root is logged once here.
        Log.Info($"Generating migrated services under '{repoRoot}'.");

        var versionManifest = SdkVersionManifest.Load(SdkTreeLayout.VersionManifestPath(repoRoot));
        var defaultConfigurationModes = DefaultConfigurationManifest.Load(Path.Combine(_sdkRoot, "src", "Core", "sdk-default-configuration.json"));
        TargetPlatforms.Initialize(_sdkRoot);

        var discovered = DiscoverModels(ct);
        var matched = MatchListedServices(migrated, discovered);

        // Each service writes to its own roots (and its own files in the shared doc-samples tree) and
        // ServiceGenerator's trackers are concurrent, so no shared state needs guarding.
        var generated = new ConcurrentBag<string>();
        ForEachParallel(matched, ct, service =>
        {
            GenerateService(service, versionManifest, defaultConfigurationModes, ct);
            generated.Add(service.Name);
        });

        return generated.ToList();
    }

    // The work is CPU-bound (mostly the Roslyn formatter), so one worker per core: at two per core the threads
    // mostly contended on Roslyn's trivia cache lock. Parallel.ForEach wraps worker exceptions; the first is
    // rethrown with its original stack trace so Program's catch filter reports a clean error instead of an
    // unhandled AggregateException.
    private static void ForEachParallel<T>(IEnumerable<T> items, CancellationToken ct, Action<T> body)
    {
        try
        {
            Parallel.ForEach(items, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount, CancellationToken = ct }, body);
        }
        catch (AggregateException ex)
        {
            ExceptionDispatchInfo.Throw(ex.InnerExceptions[0]);
        }
    }

    private static IReadOnlyList<string> LoadControlFile(string path)
    {
        if (!File.Exists(path))
        {
            Log.Info($"Control file '{path}' not found; nothing to generate.");
            return [];
        }

        using var stream = File.OpenRead(path);
        var file = JsonSerializer.Deserialize<MigratedServicesFile>(stream) ?? throw new GeneratorException($"'{path}' deserialized to null.");
        return file.Services;
    }

    private sealed record DiscoveredModel(string Name, string ModelPath, SmithyModel Model, ServiceMetadata Metadata)
    {
        /// <summary>Test services (metadata.json <c>test-service</c>) generate into sdk/test/Services/{Name} and skip the shipping artifacts.</summary>
        public bool IsTestService => Metadata.TestService;
    }

    // Scans generator/ServiceModels/*/ and generator/TestServiceModels/*/ for the single
    // all-inclusive Smithy model each migrated service carries at a fixed name, smithy.json (unlike
    // C2J's versioned api/docs/endpoints split). A model has to be parsed to learn its name, so a
    // model this generator can't yet handle is skipped here rather than aborting the batch;
    // MatchListedServices below still fails loudly if that model belongs to a service actually
    // listed in the control file. The models are parsed in parallel: there are more of them than
    // listed services, and sequentially they took ~4 s before the first service could start.
    private IReadOnlyDictionary<string, DiscoveredModel> DiscoverModels(CancellationToken ct)
    {
        if (!Directory.Exists(_modelsRoot))
        {
            throw new GeneratorException($"Service models directory not found: '{_modelsRoot}'.");
        }

        var modelDirectories = Directory.EnumerateDirectories(_modelsRoot);
        if (Directory.Exists(_testModelsRoot))
        {
            modelDirectories = modelDirectories.Concat(Directory.EnumerateDirectories(_testModelsRoot));
        }

        var discovered = new ConcurrentDictionary<string, DiscoveredModel>(StringComparer.OrdinalIgnoreCase);
        ForEachParallel(modelDirectories, ct, directory =>
        {
            var modelPath = Path.Combine(directory, SdkTreeLayout.SmithyModelFileName);
            if (!File.Exists(modelPath))
            {
                return;
            }

            SmithyModel model;
            try
            {
                model = LoadModel(modelPath);
            }
            catch (Exception ex) when (ex is not OperationCanceledException)
            {
                Log.Warn($"Skipping '{modelPath}': failed to load ({ex.Message}).");
                return;
            }

            // Past parsing, a failure is a repo error, not a model this generator can't handle
            // yet — fail the batch, don't demote to a skip. Validate guaranteed one service shape.
            var service = model.Shapes.Values.OfType<ServiceShape>().Single();
            var serviceTrait = service.GetAWSService() ?? throw new GeneratorException($"'{modelPath}': service shape is missing the aws.api#service trait.");

            // Every service in ServiceModels has a metadata.json; its base-name/namespace overrides feed
            // the service name below, so it loads at discovery rather than at generation.
            // TODO: a generic Smithy model won't carry one; relax the throw when that becomes real.
            var metadataPath = Path.Combine(directory, "metadata.json");
            if (!File.Exists(metadataPath))
            {
                throw new GeneratorException($"'{metadataPath}' not found.");
            }

            var metadata = ServiceMetadata.Load(metadataPath);
            var name = GenerationContext.ResolveServiceName(serviceTrait.SdkId, metadata);

            if (!discovered.TryAdd(name, new DiscoveredModel(name, modelPath, model, metadata)))
            {
                throw new GeneratorException($"Service '{name}' resolves from both '{discovered[name].ModelPath}' and '{modelPath}'.");
            }
        });

        return discovered;
    }

    internal static SmithyModel LoadModel(string modelPath)
    {
        using var stream = File.OpenRead(modelPath);
        var model = JsonSerializer.Deserialize<SmithyModel>(stream, ModelOptions) ?? throw new GeneratorException($"'{modelPath}' deserialized to null.");
        ModelValidator.Validate(model);

        return model;
    }

    // Every listed service must resolve to exactly one discovered model (mirroring the C2J
    // generator's typo guard). A discovered model that isn't listed is informational only — C2J
    // still owns that service.
    private static List<DiscoveredModel> MatchListedServices(IReadOnlyList<string> listed, IReadOnlyDictionary<string, DiscoveredModel> discovered)
    {
        var unmatched = listed.Where(name => !discovered.ContainsKey(name)).ToList();
        if (unmatched.Count > 0)
        {
            throw new GeneratorException(
                $"No Smithy model found for listed service(s): {string.Join(", ", unmatched)}. " +
                $"Check {SdkTreeLayout.MigratedServicesFileName} for typos (names are SDK ServiceFolderNames, e.g. 'CloudTrailData')."
            );
        }

        // Deduplicate: a repeated or case-variant entry resolves to the same model, which would
        // otherwise generate that service twice against the same output dirs concurrently.
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        return listed.Where(name => seen.Add(name)).Select(name => discovered[name]).ToList();
    }

    private void GenerateService(DiscoveredModel service, SdkVersionManifest versionManifest, IReadOnlyList<ResolvedDefaultConfigurationMode> defaultConfigurationModes, CancellationToken ct)
    {
        var codeAnalysisRoot = SdkTreeLayout.ServiceCodeAnalysisRoot(repoRoot, service.Name);
        var testsRoot = SdkTreeLayout.ServiceTestsRoot(repoRoot, service.Name);
        var sourceRoot = service.IsTestService ? testsRoot : SdkTreeLayout.ServiceSourceRoot(repoRoot, service.Name);

        try
        {
            // Customizations merge into the model before the index is built. The glob mirrors C2J's
            // CustomizationCompiler, which combines all *.customizations*.json siblings.
            var modelDirectory = Path.GetDirectoryName(service.ModelPath) ?? throw new GeneratorException($"'{service.ModelPath}' has no parent directory.");
            var customizationFiles = Directory.EnumerateFiles(modelDirectory, "*.customizations*.json").OrderBy(file => file, StringComparer.Ordinal);
            var customizations = CustomizationsModel.Load(customizationFiles);
            CustomizationTransform.Apply(service.Model, customizations);
            CustomizationTransform.Validate(service.Model, customizations);

            var index = new ServiceIndex(service.Model);

            // Everything that can fail without writing a file happens before any file is touched.
            var context = new GenerationContext(index, versionManifest, service.Metadata, customizations);
            UnsupportedTraitValidator.Validate(index, context.Protocol);

            var serviceFileVersion = versionManifest.GetServiceVersion(context.ServiceName);
            var generator = new ServiceGenerator(context, Path.GetFileName(service.ModelPath), serviceFileVersion, defaultConfigurationModes);

            // Built first so a bad example fails the service before anything is written, but written only once
            // the service's code has generated. Test services never ship samples.
            IReadOnlyList<(string Path, string Contents)> docSamples = service.IsTestService ? [] : generator.BuildDocSamples();

            var generatedTrees = GeneratedTrees(sourceRoot, codeAnalysisRoot, testsRoot, service.IsTestService);
            var stale = generatedTrees.Where(Directory.Exists).SelectMany(tree => Directory.EnumerateFiles(tree, "*", SearchOption.AllDirectories)).ToHashSet(_pathComparer);

            var written = generator.Generate(sourceRoot, codeAnalysisRoot, testsRoot, ct);
            Log.Info($"Generated {written.Count} files for {service.Name} under '{Relative(sourceRoot)}'.");

            var docSamplesRoot = SdkTreeLayout.DocSamplesRoot(repoRoot);
            foreach (var (path, contents) in docSamples)
            {
                // Never formatted: the samples .cs holds placeholders like <binary data> the formatter would mangle.
                ServiceGenerator.WriteFile(Path.Combine(docSamplesRoot, path), contents, format: false, ct);
            }

            if (docSamples.Count > 0)
            {
                Log.Info($"Generated {docSamples.Count} doc sample files for {service.Name} under '{Relative(docSamplesRoot)}'.");
            }

            stale.ExceptWith(generator.WrittenFiles);
            RemoveStaleOutput(service.Name, sourceRoot, generatedTrees, stale);
        }
        catch (GeneratorException ex)
        {
            // Services generate in parallel, so the message has to name the one that failed.
            throw new GeneratorException($"[{service.Name}] {ex.Message}", ex);
        }
    }

    // The trees this generator owns outright: anything in them it didn't just generate is stale. Test services
    // have no code-analysis tree (and sourceRoot == testsRoot), so only the two under the test root.
    private static string[] GeneratedTrees(string sourceRoot, string codeAnalysisRoot, string testsRoot, bool isTestService) => isTestService
        ?
        [
            Path.Combine(testsRoot, "Generated"),
            Path.Combine(testsRoot, "UnitTests", "Generated"),
        ]
        :
        [
            Path.Combine(sourceRoot, "Generated"),
            Path.Combine(codeAnalysisRoot, "Generated"),
            Path.Combine(testsRoot, "UnitTests", "Generated"),
        ];

    // Deletion is the destructive step, so it runs only after the service generated, and what is removed is
    // logged. Only the generated trees and the superseded C2J solution file are touched — never Custom/ or
    // anything hand-written.
    private void RemoveStaleOutput(string serviceName, string sourceRoot, string[] generatedTrees, HashSet<string> stale)
    {
        foreach (var file in stale)
        {
            File.Delete(file);
        }

        if (stale.Count > 0)
        {
            Log.Info($"[{serviceName}] Deleted {stale.Count} stale generated file(s).");
        }

        foreach (var tree in generatedTrees.Where(Directory.Exists))
        {
            DeleteEmptyDirectories(tree);
        }

        // The solution writer emits {Name}.slnx, which never overwrites the differently-named C2J
        // {Name}.sln — and C2J's orphan cleanup skips migrated services, so without this the folder
        // keeps both files forever.
        var staleSolution = Path.Combine(sourceRoot, $"{serviceName}.sln");
        if (File.Exists(staleSolution))
        {
            File.Delete(staleSolution);
            Log.Info($"[{serviceName}] Deleted stale C2J solution '{Relative(staleSolution)}'.");
        }
    }

    // Directories a stale C2J layout left behind (_bcl/, _netstandard/) empty out once their files go.
    private static void DeleteEmptyDirectories(string directory)
    {
        foreach (var child in Directory.EnumerateDirectories(directory))
        {
            DeleteEmptyDirectories(child);
        }

        if (!Directory.EnumerateFileSystemEntries(directory).Any())
        {
            Directory.Delete(directory);
        }
    }

    // Logged paths are repo-relative to keep the (possibly very verbose) root out of every line;
    // Run logs the root once up front.
    private string Relative(string path) => Path.GetRelativePath(repoRoot, path);
}
