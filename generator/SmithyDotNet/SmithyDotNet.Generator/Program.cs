using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator;

/// <summary>
/// Placeholder Smithy model record
/// For scaffolding we only need enough to round-trip the "smithy" version field
/// and count top-level shape entries.
/// </summary>
internal sealed record SmithyModel(
    [property: JsonPropertyName("smithy")] string Version,
    [property: JsonPropertyName("shapes")] Dictionary<string, JsonElement>? Shapes,
    [property: JsonPropertyName("metadata")] Dictionary<string, JsonElement>? Metadata
);

public static class Program
{
    public static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.Error.WriteLine("Error: expected a path to a Smithy model.json as the first argument.");
            Console.Error.WriteLine("Usage: dotnet run --project SmithyDotNet.Generator/SmithyDotNet.Generator.csproj -- <path-to-model.json>");
            return 1;
        }

        var modelPath = args[0];
        if (!File.Exists(modelPath))
        {
            Console.Error.WriteLine($"Error: model file not found: {modelPath}");
            return 1;
        }

        SmithyModel? model;
        try
        {
            using var stream = File.OpenRead(modelPath);
            model = JsonSerializer.Deserialize<SmithyModel>(stream);
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

        var shapeCount = model.Shapes?.Count ?? 0;
        Console.WriteLine($"Smithy version: {model.Version}");
        Console.WriteLine($"Found {shapeCount} shapes.");
        return 0;
    }
}
