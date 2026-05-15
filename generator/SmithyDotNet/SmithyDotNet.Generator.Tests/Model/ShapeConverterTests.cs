using System.Text.Json;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Converters;
using SmithyDotNet.Generator.Model.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Model;

public class ShapeConverterTests
{
    private static readonly JsonSerializerOptions Options = new()
    {
        Converters = { new ShapeConverter() },
    };

    private static readonly JsonDocument ModelDoc = JsonDocument.Parse(File.ReadAllBytes("TestData/cloudtrail-data-model.json"));

    private static Shape? DeserializeShape(string shapeId) => ModelDoc
        .RootElement
        .GetProperty("shapes")
        .GetProperty(shapeId)
        .Deserialize<Shape>(Options);

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
    public void Deserialize_MapShape()
    {
        var json = """{ "type": "map", "key": { "target": "smithy.api#String" }, "value": { "target": "smithy.api#Integer" } }""";
        var map = Assert.IsType<MapShape>(JsonSerializer.Deserialize<Shape>(json, Options));
        Assert.Equal("String", map.Key.Target.Name);
        Assert.Equal("Integer", map.Value.Target.Name);
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
        var uuid = Assert.IsType<StringShape>(DeserializeShape("com.amazonaws.cloudtraildata#Uuid"));
        Assert.True(uuid.Traits.ContainsKey("smithy.api#length"));
        Assert.True(uuid.Traits.ContainsKey("smithy.api#pattern"));
    }

    [Fact]
    public void Deserialize_CloudTrailDataListShape()
    {
        var auditEvents = Assert.IsType<ListShape>(DeserializeShape("com.amazonaws.cloudtraildata#AuditEvents"));

        Assert.Equal("com.amazonaws.cloudtraildata", auditEvents.Member.Target.Namespace);
        Assert.Equal("AuditEvent", auditEvents.Member.Target.Name);
        Assert.True(auditEvents.Traits.ContainsKey("smithy.api#length"));
    }

    [Fact]
    public void Deserialize_CloudTrailDataStructureShape()
    {
        var auditEvent = Assert.IsType<StructureShape>(DeserializeShape("com.amazonaws.cloudtraildata#AuditEvent"));

        Assert.Equal(3, auditEvent.Members.Count);
        Assert.Contains("id", auditEvent.Members);
        Assert.Contains("eventData", auditEvent.Members);
        Assert.Contains("eventDataChecksum", auditEvent.Members);

        var idMember = auditEvent.Members["id"];
        Assert.Equal("com.amazonaws.cloudtraildata", idMember.Target.Namespace);
        Assert.Equal("Uuid", idMember.Target.Name);
        Assert.True(idMember.Traits.ContainsKey("smithy.api#required"));
    }

    [Fact]
    public void Deserialize_CloudTrailDataOperationShape()
    {
        var putAuditEvents = Assert.IsType<OperationShape>(DeserializeShape("com.amazonaws.cloudtraildata#PutAuditEvents"));

        Assert.Equal("com.amazonaws.cloudtraildata", putAuditEvents.Input.Namespace);
        Assert.Equal("PutAuditEventsRequest", putAuditEvents.Input.Name);
        Assert.Equal("com.amazonaws.cloudtraildata", putAuditEvents.Output.Namespace);
        Assert.Equal("PutAuditEventsResponse", putAuditEvents.Output.Name);
        Assert.Equal(6, putAuditEvents.Errors.Count);
    }

    [Fact]
    public void Deserialize_CloudTrailDataServiceShape()
    {
        var service = Assert.IsType<ServiceShape>(DeserializeShape("com.amazonaws.cloudtraildata#CloudTrailDataService"));

        Assert.Equal("2021-08-11", service.ApiVersion);
        Assert.Single(service.Operations);
        Assert.Equal("PutAuditEvents", service.Operations[0].Name);
        Assert.True(service.Traits.ContainsKey("aws.api#service"));
        Assert.True(service.Traits.ContainsKey("aws.protocols#restJson1"));
    }

    [Fact]
    public void Deserialize_FullCloudTrailDataModel()
    {
        var model = JsonSerializer.Deserialize<SmithyModel>(File.ReadAllBytes("TestData/cloudtrail-data-model.json"), Options);

        Assert.NotNull(model);
        Assert.Equal("2.0", model.Version);
        Assert.Equal(21, model.Shapes.Count);
        Assert.Single(model.Shapes.Values.OfType<ServiceShape>());
        Assert.Single(model.Shapes.Values.OfType<OperationShape>());
        Assert.Equal(11, model.Shapes.Values.OfType<StructureShape>().Count());
        Assert.Equal(3, model.Shapes.Values.OfType<ListShape>().Count());
        Assert.Equal(5, model.Shapes.Values.OfType<StringShape>().Count());
    }
}
