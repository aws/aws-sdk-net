using System.Text.Json;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Converters;

namespace SmithyDotNet.Generator;

public static class Program
{
    private static readonly JsonSerializerOptions Options = new()
    {
        Converters = { new ShapeConverter() },
    };

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
        }
        catch (GeneratorException ex)
        {
            Console.Error.WriteLine($"Error: {ex.Message}");
            return 1;
        }

        var index = new ServiceIndex(model);
        Console.WriteLine($"Smithy version: {model.Version}");
        Console.WriteLine($"Service API version: {index.Service.ApiVersion}");
        Console.WriteLine($"Operations: {index.Operations.Count}");
        Console.WriteLine($"Reachable shapes: {index.Shapes.Count}");
        return 0;
    }
}
