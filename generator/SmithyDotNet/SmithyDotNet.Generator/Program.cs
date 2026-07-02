using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Converters;

namespace SmithyDotNet.Generator;

public static class Program
{
    private static readonly string ManifestRelativePath = Path.Combine("generator", "ServiceModels", "_sdk-versions.json");

    private static readonly JsonSerializerOptions Options = new()
    {
        Converters = { new ShapeConverter() },
    };

    public static int Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.Error.WriteLine("Error: expected a Smithy model path and an output directory.");
            Console.Error.WriteLine("Usage: dotnet run --project SmithyDotNet.Generator/SmithyDotNet.Generator.csproj -- <path-to-model.json> <output-dir> [path-to-_sdk-versions.json]");
            return 1;
        }

        var modelPath = args[0];
        var outputPath = args[1];
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

            var index = new ServiceIndex(model);
            var context = new GenerationContext(index);

            var manifestPath = args.Length >= 3 ? args[2] : FindVersionManifest(modelPath);
            if (manifestPath is null)
            {
                Console.Error.WriteLine($"Error: could not locate '{ManifestRelativePath}'. Pass its path as the third argument.");
                return 1;
            }

            var serviceFileVersion = SdkVersionManifest.Lookup(manifestPath, context.ServiceName);
            var modelFileName = Path.GetFileName(modelPath);

            var generator = new ServiceGenerator(context, modelFileName, serviceFileVersion);
            var written = generator.Generate(outputPath);

            Console.WriteLine($"Generated {written.Count} files for {context.ServiceName} under '{Path.GetFullPath(outputPath)}'.");
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

    // Walks up from the model file's directory looking for the repo's _sdk-versions.json so the
    // two-argument invocation works when run inside the repo. Returns null if not found.
    private static string? FindVersionManifest(string modelPath)
    {
        var directory = new DirectoryInfo(Path.GetDirectoryName(Path.GetFullPath(modelPath)) ?? ".");
        while (directory is not null)
        {
            var candidate = Path.Combine(directory.FullName, ManifestRelativePath);
            if (File.Exists(candidate))
            {
                return candidate;
            }

            directory = directory.Parent;
        }

        return null;
    }
}
