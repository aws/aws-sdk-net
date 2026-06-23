using System.Text.Json;
using System.Text.Json.Nodes;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Converters;
using SmithyDotNet.Generator.Model.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests;

public class CloudTrailModelFixture
{
    public static readonly JsonSerializerOptions Options = new()
    {
        Converters = { new ShapeConverter() },
    };

    private static readonly byte[] ModelBytes = File.ReadAllBytes("TestData/cloudtrail-data-model.json");

    public JsonDocument Document { get; } = JsonDocument.Parse(ModelBytes);

    public SmithyModel Model { get; } = JsonSerializer.Deserialize<SmithyModel>(ModelBytes, Options)
        ?? throw new InvalidOperationException("Failed to deserialize SmithyModel.");

    public ServiceIndex Index { get; }

    public GenerationContext Context { get; }

    public CloudTrailModelFixture()
    {
        Index = new ServiceIndex(Model);
        Context = new GenerationContext(Index);
    }

    public Shape DeserializeShape(string shapeId)
    {
        var shape = Document
            .RootElement
            .GetProperty("shapes")
            .GetProperty(shapeId)
            .Deserialize<Shape>(Options);
        return shape is null ? throw new InvalidOperationException($"Shape '{shapeId}' deserialized to null.") : shape;
    }

    /// <summary>
    /// Builds a <see cref="GenerationContext"/> from the model with the service's
    /// <c>smithy.rules#endpointRuleSet</c> trait removed, so writers can be exercised against a
    /// service that has no endpoint rule set (the false branch of <c>HasEndpointRuleSet</c>).
    /// </summary>
    public static GenerationContext ContextWithoutEndpointRuleSet()
    {
        var root = JsonNode.Parse(ModelBytes) ?? throw new InvalidOperationException("Failed to parse model.");
        foreach (var shape in root["shapes"]!.AsObject())
        {
            if (shape.Value?["type"]?.GetValue<string>() == "service")
            {
                shape.Value["traits"]?.AsObject().Remove("smithy.rules#endpointRuleSet");
            }
        }

        var model = JsonSerializer.Deserialize<SmithyModel>(root.ToJsonString(), Options)
            ?? throw new InvalidOperationException("Failed to deserialize the modified SmithyModel.");
        return new GenerationContext(new ServiceIndex(model));
    }
}

[CollectionDefinition(nameof(CloudTrailModelCollection))]
public class CloudTrailModelCollection : ICollectionFixture<CloudTrailModelFixture>;
