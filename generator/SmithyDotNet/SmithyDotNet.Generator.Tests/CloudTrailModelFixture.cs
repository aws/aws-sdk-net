using System.Text.Json;
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

    public JsonDocument Document { get; } = JsonDocument.Parse(File.ReadAllBytes("TestData/cloudtrail-data-model.json"));

    public Shape DeserializeShape(string shapeId)
    {
        var shape = Document
            .RootElement
            .GetProperty("shapes")
            .GetProperty(shapeId)
            .Deserialize<Shape>(Options);
        return shape is null ? throw new InvalidOperationException($"Shape '{shapeId}' deserialized to null.") : shape;
    }
}

[CollectionDefinition(nameof(CloudTrailModelCollection))]
public class CloudTrailModelCollection : ICollectionFixture<CloudTrailModelFixture>;
