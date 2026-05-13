using System.Text.Json;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Converters;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Model;

public class ShapeConverterTests
{
    private static readonly JsonSerializerOptions Options = new()
    {
        Converters = { new ShapeConverter() },
    };

    [Theory]
    [InlineData("""{"type": "string", "traits": {"smithy.api#pattern": "^[a-z]+$"}}""", typeof(StringShape), "string")]
    [InlineData("""{"type": "boolean"}""", typeof(BooleanShape), "boolean")]
    [InlineData("""{"type": "integer"}""", typeof(IntegerShape), "integer")]
    [InlineData("""{"type": "long"}""", typeof(LongShape), "long")]
    [InlineData("""{"type": "double"}""", typeof(DoubleShape), "double")]
    [InlineData("""{"type": "blob"}""", typeof(BlobShape), "blob")]
    [InlineData("""{"type": "timestamp"}""", typeof(TimestampShape), "timestamp")]
    public void Deserialize_ScalarShapes(string json, Type expectedType, string expectedTypeField)
    {
        var shape = JsonSerializer.Deserialize<Shape>(json, Options);
        Assert.NotNull(shape);
        Assert.IsType(expectedType, shape);
        Assert.Equal(expectedTypeField, shape.Type);
    }

    [Fact]
    public void Deserialize_UnknownType_ReturnsNull()
    {
        var json = """{"type": "someFutureType"}""";
        var shape = JsonSerializer.Deserialize<Shape>(json, Options);
        Assert.Null(shape);
    }

    [Fact]
    public void Deserialize_CloudTrailDataScalarShapes()
    {
        using var stream = File.OpenRead("TestData/cloudtrail-data-model.json");
        var doc = JsonDocument.Parse(stream);
        var shapes = doc.RootElement.GetProperty("shapes");

        // Pick a random string scalar shape from the test model.
        var uuidJson = shapes.GetProperty("com.amazonaws.cloudtraildata#Uuid");
        var uuid = Assert.IsType<StringShape>(uuidJson.Deserialize<Shape>(Options));
        Assert.True(uuid.Traits.ContainsKey("smithy.api#length"));
        Assert.True(uuid.Traits.ContainsKey("smithy.api#pattern"));
    }
}
