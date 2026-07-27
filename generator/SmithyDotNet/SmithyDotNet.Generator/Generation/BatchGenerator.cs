using System.Runtime.ExceptionServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Converters;
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
/// into the real SDK tree, wiping each service's stale generated trees first so leftover C2J output
/// (plain <c>.cs</c> names, <c>_bcl/</c>/<c>_netstandard/</c>) can't collide with the <c>.g.cs</c>
/// output as duplicate types.
/// </summary>
public sealed class BatchGenerator(string repoRoot)
{
    private static readonly JsonSerializerOptions ModelOptions = new()
    {
        Converters = { new ShapeConverter() },
    };

    private readonly string _modelsRoot = SdkTreeLayout.ModelsRoot(repoRoot);
    private readonly string _sdkRoot = SdkTreeLayout.SdkRoot(repoRoot);

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

        var generated = new List<string>(matched.Count);
        try
        {
            // Mirrors the C2J generator's parallelism. Each service writes to disjoint roots and
            // ServiceGenerator's trackers are concurrent, so no shared state needs guarding.
            Parallel.ForEach(
                matched,
                new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount * 2, CancellationToken = ct },
                service =>
                {
                    GenerateService(service, versionManifest, defaultConfigurationModes, ct);
                    lock (generated)
                    {
                        generated.Add(service.Name);
                    }
                });
        }
        catch (AggregateException ex)
        {
            // Parallel.ForEach wraps worker exceptions; rethrow the first (preserving its original
            // stack trace) so Program's catch filter reports it as a clean error instead of an
            // unhandled AggregateException.
            ExceptionDispatchInfo.Throw(ex.InnerExceptions[0]);
        }

        return generated;
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

    private sealed record DiscoveredModel(string Name, string ModelPath, ServiceIndex Index, string ModelDirectory);

    // Scans generator/ServiceModels/*/ for the single all-inclusive Smithy model each migrated
    // service carries at a fixed name, smithy.json (unlike C2J's versioned api/docs/endpoints split).
    private Dictionary<string, DiscoveredModel> DiscoverModels(CancellationToken ct)
    {
        if (!Directory.Exists(_modelsRoot))
        {
            throw new GeneratorException($"Service models directory not found: '{_modelsRoot}'.");
        }

        var discovered = new Dictionary<string, DiscoveredModel>(StringComparer.OrdinalIgnoreCase);
        foreach (var directory in Directory.EnumerateDirectories(_modelsRoot))
        {
            ct.ThrowIfCancellationRequested();

            var modelPath = Path.Combine(directory, SdkTreeLayout.SmithyModelFileName);
            if (!File.Exists(modelPath))
            {
                continue;
            }

            using var stream = File.OpenRead(modelPath);
            var model = JsonSerializer.Deserialize<SmithyModel>(stream, ModelOptions) ?? throw new GeneratorException($"'{modelPath}' deserialized to null.");
            ModelValidator.Validate(model);

            var index = new ServiceIndex(model);
            var serviceTrait = index.Service.GetAWSService() ?? throw new GeneratorException($"'{modelPath}': service shape is missing the aws.api#service trait.");
            var name = SdkNaming.NormalizeSdkId(serviceTrait.SdkId);

            if (!discovered.TryAdd(name, new DiscoveredModel(name, modelPath, index, directory)))
            {
                throw new GeneratorException($"Service '{name}' resolves from both '{discovered[name].ModelPath}' and '{modelPath}'.");
            }
        }

        return discovered;
    }

    // Every listed service must resolve to exactly one discovered model (mirroring the C2J
    // generator's typo guard). A discovered model that isn't listed is informational only — C2J
    // still owns that service.
    private static List<DiscoveredModel> MatchListedServices(IReadOnlyList<string> listed, Dictionary<string, DiscoveredModel> discovered)
    {
        var unmatched = listed.Where(name => !discovered.ContainsKey(name)).ToList();
        if (unmatched.Count > 0)
        {
            throw new GeneratorException(
                $"No Smithy model found for listed service(s): {string.Join(", ", unmatched)}. " +
                $"Check {SdkTreeLayout.MigratedServicesFileName} for typos (names are SDK ServiceFolderNames, e.g. 'CloudTrailData')."
            );
        }

        var listedSet = new HashSet<string>(listed, StringComparer.OrdinalIgnoreCase);
        foreach (var model in discovered.Values.Where(m => !listedSet.Contains(m.Name)).OrderBy(m => m.Name, StringComparer.Ordinal))
        {
            Log.Info($"Skipping '{model.Name}' ({model.ModelPath}): not listed in {SdkTreeLayout.MigratedServicesFileName}, C2J still owns it.");
        }

        // Deduplicate: a repeated or case-variant entry resolves to the same model, which would
        // otherwise generate that service twice against the same output dirs concurrently.
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        return listed.Where(name => seen.Add(name)).Select(name => discovered[name]).ToList();
    }

    private void GenerateService(DiscoveredModel service, SdkVersionManifest versionManifest, IReadOnlyList<ResolvedDefaultConfigurationMode> defaultConfigurationModes, CancellationToken ct)
    {
        var sourceRoot = SdkTreeLayout.ServiceSourceRoot(repoRoot, service.Name);
        var codeAnalysisRoot = SdkTreeLayout.ServiceCodeAnalysisRoot(repoRoot, service.Name);
        var testsRoot = SdkTreeLayout.ServiceTestsRoot(repoRoot, service.Name);

        // Everything that can fail without writing a file happens before the wipe, so a bad
        // metadata.json or a missing version entry can't leave a service wiped-but-not-regenerated.
        // metadata.json is an optional sidecar next to the model; ServiceMetadata.Load throws on a
        // missing file, so the Exists guard is what makes it optional.
        var metadataPath = Path.Combine(service.ModelDirectory, "metadata.json");
        var metadata = File.Exists(metadataPath) ? ServiceMetadata.Load(metadataPath) : null;

        var context = new GenerationContext(service.Index, versionManifest, metadata);
        var serviceFileVersion = versionManifest.GetServiceVersion(context.ServiceName);
        var generator = new ServiceGenerator(context, Path.GetFileName(service.ModelPath), serviceFileVersion, defaultConfigurationModes);

        WipeStaleOutput(service.Name, sourceRoot, codeAnalysisRoot, testsRoot);

        IReadOnlyList<string> written;
        try
        {
            written = generator.Generate(sourceRoot, codeAnalysisRoot, testsRoot, ct);
        }
        catch (GeneratorException ex)
        {
            // Services generate in parallel, so the message has to name the one that failed.
            throw new GeneratorException($"[{service.Name}] {ex.Message}", ex);
        }

        Log.Info($"Generated {written.Count} files for {service.Name} under '{Relative(sourceRoot)}'.");
    }

    // Deletion is the destructive step, so every tree/file actually removed is logged. Only the
    // generated trees and the superseded C2J solution file are touched — never Custom/ or anything
    // hand-written.
    private void WipeStaleOutput(string serviceName, string sourceRoot, string codeAnalysisRoot, string testsRoot)
    {
        string[] staleTrees =
        [
            Path.Combine(sourceRoot, "Generated"),
            Path.Combine(codeAnalysisRoot, "Generated"),
            Path.Combine(testsRoot, "UnitTests", "Generated"),
        ];

        foreach (var tree in staleTrees)
        {
            if (Directory.Exists(tree))
            {
                Directory.Delete(tree, recursive: true);
                Log.Info($"[{serviceName}] Deleted stale tree '{Relative(tree)}'.");
            }
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

    // Logged paths are repo-relative to keep the (possibly very verbose) root out of every line;
    // Run logs the root once up front.
    private string Relative(string path) => Path.GetRelativePath(repoRoot, path);
}
