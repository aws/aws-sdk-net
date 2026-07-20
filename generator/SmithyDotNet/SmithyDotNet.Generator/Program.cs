using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Converters;

namespace SmithyDotNet.Generator;

public static class Program
{
    private static readonly string ManifestRelativePath = Path.Combine("generator", "ServiceModels", "_sdk-versions.json");
    private static readonly string DefaultConfigurationRelativePath = Path.Combine("sdk", "src", "Core", "sdk-default-configuration.json");

    private const string MetadataFileName = "metadata.json";

    private static readonly JsonSerializerOptions Options = new()
    {
        Converters = { new ShapeConverter() },
    };

    public static int Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.Error.WriteLine("Error: expected a Smithy model path and an output directory.");
            Console.Error.WriteLine("Usage: dotnet run --project SmithyDotNet.Generator/SmithyDotNet.Generator.csproj -- <path-to-model.json> <output-dir> [tests-output-dir] [path-to-_sdk-versions.json] [path-to-metadata.json]");
            return 1;
        }

        var modelPath = args[0];
        var outputPath = args[1];
        var testsOutputPath = args.Length >= 3 ? args[2] : null;
        if (!File.Exists(modelPath))
        {
            Console.Error.WriteLine($"Error: model file not found: {modelPath}");
            return 1;
        }

        SmithyModel? model;
        try
        {
            using var stream = File.OpenRead(modelPath);
            model = JsonSerializer.Deserialize<SmithyModel>(stream, Options);
        }
        catch (JsonException ex)
        {
            Console.Error.WriteLine($"Error: failed to parse Smithy model JSON: {ex.Message}");
            return 1;
        }

        if (model is null)
        {
            Console.Error.WriteLine("Error: Smithy model deserialized to null.");
            return 1;
        }

        try
        {
            ModelValidator.Validate(model);

            // metadata.json is an optional sidecar next to the model; the fifth argument overrides the
            // default lookup. When neither is present the context runs without metadata.
            var metadataPath = args.Length >= 5 ? args[4] : FindMetadata(modelPath);
            var metadata = metadataPath is not null ? ServiceMetadata.Load(metadataPath) : null;

            var index = new ServiceIndex(model);

            var manifestPath = args.Length >= 4 ? args[3] : FindRepoFile(modelPath, ManifestRelativePath);
            if (manifestPath is null)
            {
                Console.Error.WriteLine($"Error: could not locate '{ManifestRelativePath}'. Pass its path as the fourth argument.");
                return 1;
            }

            var manifest = SdkVersionManifest.Load(manifestPath);
            var context = new GenerationContext(index, manifest, metadata);
            var serviceFileVersion = manifest.GetServiceVersion(context.ServiceName);

            // The default-configuration file lives in the same repo as the version manifest, so a
            // caller who passed the manifest path explicitly doesn't need another argument.
            var defaultConfigurationPath = FindRepoFile(manifestPath, DefaultConfigurationRelativePath);
            if (defaultConfigurationPath is null)
            {
                Console.Error.WriteLine($"Error: could not locate '{DefaultConfigurationRelativePath}' relative to '{manifestPath}'.");
                return 1;
            }

            var defaultConfigurationModes = DefaultConfigurationManifest.Load(defaultConfigurationPath);
            var modelFileName = Path.GetFileName(modelPath);

            var generator = new ServiceGenerator(context, modelFileName, serviceFileVersion, defaultConfigurationModes);
            var written = generator.Generate(outputPath, testsOutputPath);

            Console.WriteLine($"Generated {written.Count} files for {context.ServiceName} under '{Path.GetFullPath(outputPath)}'.");
            if (testsOutputPath is not null)
            {
                Console.WriteLine($"Generated unit test files for {context.ServiceName} under '{Path.GetFullPath(testsOutputPath)}'.");
            }

            return 0;
        }
        catch (Exception ex) when (ex is GeneratorException or IOException or UnauthorizedAccessException or JsonException)
        {
            // GeneratorException: validation/lookup failures. IO/UnauthorizedAccess: reading the
            // version manifest or writing output files. JsonException: a malformed manifest.
            Console.Error.WriteLine($"Error: {ex.Message}");
            return 1;
        }
    }

    // Walks up from startPath's directory looking for a repo file (e.g. _sdk-versions.json) so the
    // two-argument invocation works when run inside the repo. Returns null if not found.
    private static string? FindRepoFile(string startPath, string relativePath)
    {
        var directory = new DirectoryInfo(Path.GetDirectoryName(Path.GetFullPath(startPath)) ?? ".");
        while (directory is not null)
        {
            var candidate = Path.Combine(directory.FullName, relativePath);
            if (File.Exists(candidate))
            {
                return candidate;
            }

            directory = directory.Parent;
        }

        return null;
    }

    // metadata.json sits in the same directory as the model file. Returns null if absent so the
    // generator can still run without it.
    private static string? FindMetadata(string modelPath)
    {
        var directory = Path.GetDirectoryName(Path.GetFullPath(modelPath));
        if (directory is null)
        {
            return null;
        }

        var candidate = Path.Combine(directory, MetadataFileName);
        return File.Exists(candidate) ? candidate : null;
    }
}
