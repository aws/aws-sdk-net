using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Converters;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Tests;

/// <summary>
/// Loads test models from <c>TestData</c>. Every model lives in its own file there: real service
/// extracts at the root, auth-scenario models under <c>Auth/</c>, models driving codegen tests
/// under <c>Codegen/</c>, and models driving model-loading/resolution tests under <c>Model/</c>.
/// </summary>
internal static class TestModels
{
    public static readonly JsonSerializerOptions Options = new()
    {
        Converters = { new ShapeConverter() },
    };

    public static SmithyModel Load(string relativePath)
    {
        var bytes = File.ReadAllBytes(Path.Combine("TestData", relativePath));
        return JsonSerializer.Deserialize<SmithyModel>(bytes, Options)
            ?? throw new InvalidOperationException($"Model '{relativePath}' deserialized to null.");
    }

    public static GenerationContext Context(string relativePath) => Context(Load(relativePath));

    public static GenerationContext Context(SmithyModel model) =>
        new(new ServiceIndex(model), TestManifests.Example());

    public static Shape DeserializeShape(string json) =>
        JsonSerializer.Deserialize<Shape>(json, Options)
        ?? throw new InvalidOperationException("Shape deserialized to null.");
}
