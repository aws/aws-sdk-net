using System.Text.Json;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Model;

[Collection(nameof(CloudTrailModelCollection))]
public class ShapeConverterTests(CloudTrailModelFixture fixture)
{
    [Theory]
    [InlineData("""{"type": "string", "traits": {"smithy.api#pattern": "^[a-z]+$"}}""", typeof(StringShape), "string")]
    [InlineData("""{"type": "boolean"}""", typeof(BooleanShape), "boolean")]
    [InlineData("""{"type": "integer"}""", typeof(IntegerShape), "integer")]
    [InlineData("""{"type": "long"}""", typeof(LongShape), "long")]
    [InlineData("""{"type": "double"}""", typeof(DoubleShape), "double")]
    [InlineData("""{"type": "blob"}""", typeof(BlobShape), "blob")]
    [InlineData("""{"type": "timestamp"}""", typeof(TimestampShape), "timestamp")]
    [InlineData("""{"type": "enum", "members": {}}""", typeof(EnumShape), "enum")]
    [InlineData("""{"type": "intEnum", "members": {}}""", typeof(IntEnumShape), "intEnum")]
    [InlineData("""{"type": "union", "members": {}}""", typeof(UnionShape), "union")]
    public void Deserialize_ScalarShapes(string json, Type expectedType, string expectedTypeField)
    {
        var shape = JsonSerializer.Deserialize<Shape>(json, TestModels.Options);
        Assert.NotNull(shape);
        Assert.IsType(expectedType, shape);
        Assert.Equal(expectedTypeField, shape.Type);
    }

    [Fact]
    public void Deserialize_MapShape()
    {
        var json = """{ "type": "map", "key": { "target": "smithy.api#String" }, "value": { "target": "smithy.api#Integer" } }""";
        var map = Assert.IsType<MapShape>(JsonSerializer.Deserialize<Shape>(json, TestModels.Options));
        Assert.Equal("String", map.Key.Target.Name);
        Assert.Equal("Integer", map.Value.Target.Name);
    }

    [Fact]
    public void Deserialize_UnknownType_ReturnsNull()
    {
        var json = """{"type": "someFutureType"}""";
        var shape = JsonSerializer.Deserialize<Shape>(json, TestModels.Options);
        Assert.Null(shape);
    }

    // A pre-IDL-2.0 enum (string + smithy.api#enum trait) normalizes to an EnumShape so the
    // writers emit the same ConstantClass C2J does — SupportApp's AccountType is the shape that
    // slipped through as a plain string in #1462. One entry carries an explicit name (keys the
    // member), the other keys by its value; the consumed legacy trait must not survive.
    [Fact]
    public void Deserialize_LegacyEnumTraitString_BecomesEnumShape()
    {
        var json = """{"type": "string", "traits": {"smithy.api#enum": [{"value": "management", "name": "MANAGEMENT"}, {"value": "member"}]}}""";
        var shape = Assert.IsType<EnumShape>(JsonSerializer.Deserialize<Shape>(json, TestModels.Options));

        Assert.Equal(["management", "member"], shape.Members.Values.Select(m => m.GetEnumValue()));
        Assert.Equal(["MANAGEMENT", "member"], shape.Members.Keys);
        Assert.False(shape.Traits.ContainsKey("smithy.api#enum"));
    }

    // Colliding member names (one entry's name equals another entry's value) must fail loudly:
    // a silent overwrite would drop a constant.
    [Fact]
    public void Deserialize_LegacyEnumTrait_CollidingNamesThrow()
    {
        var json = """
            {"type": "string", "traits": {"smithy.api#enum": [
                {"value": "foo"},
                {"value": "bar", "name": "foo"}
            ]}}
            """;
        var ex = Assert.Throws<GeneratorException>(() => JsonSerializer.Deserialize<Shape>(json, TestModels.Options));
        Assert.Contains("collide", ex.Message);
    }

    [Fact]
    public void Deserialize_CloudTrailDataScalarShapes()
    {
        var uuid = Assert.IsType<StringShape>(fixture.DeserializeShape("com.amazonaws.cloudtraildata#Uuid"));
        Assert.True(uuid.Traits.ContainsKey("smithy.api#length"));
        Assert.True(uuid.Traits.ContainsKey("smithy.api#pattern"));
    }

    [Fact]
    public void Deserialize_CloudTrailDataListShape()
    {
        var auditEvents = Assert.IsType<ListShape>(fixture.DeserializeShape("com.amazonaws.cloudtraildata#AuditEvents"));

        Assert.Equal("com.amazonaws.cloudtraildata", auditEvents.Member.Target.Namespace);
        Assert.Equal("AuditEvent", auditEvents.Member.Target.Name);
        Assert.True(auditEvents.Traits.ContainsKey("smithy.api#length"));
    }

    [Fact]
    public void Deserialize_CloudTrailDataStructureShape()
    {
        var auditEvent = Assert.IsType<StructureShape>(fixture.DeserializeShape("com.amazonaws.cloudtraildata#AuditEvent"));

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
        var putAuditEvents = Assert.IsType<OperationShape>(fixture.DeserializeShape("com.amazonaws.cloudtraildata#PutAuditEvents"));

        Assert.Equal("com.amazonaws.cloudtraildata", putAuditEvents.Input.Namespace);
        Assert.Equal("PutAuditEventsRequest", putAuditEvents.Input.Name);
        Assert.Equal("com.amazonaws.cloudtraildata", putAuditEvents.Output.Namespace);
        Assert.Equal("PutAuditEventsResponse", putAuditEvents.Output.Name);
        Assert.Equal(6, putAuditEvents.Errors.Count);
    }

    [Fact]
    public void Deserialize_CloudTrailDataServiceShape()
    {
        var service = Assert.IsType<ServiceShape>(fixture.DeserializeShape("com.amazonaws.cloudtraildata#CloudTrailDataService"));

        Assert.Equal("2021-08-11", service.ApiVersion);
        Assert.Single(service.Operations);
        Assert.Equal("PutAuditEvents", service.Operations[0].Name);
        Assert.True(service.Traits.ContainsKey("aws.api#service"));
        Assert.True(service.Traits.ContainsKey("aws.protocols#restJson1"));
    }

    [Fact]
    public void Deserialize_FullCloudTrailDataModel()
    {
        var model = TestModels.Load("cloudtrail-data-model.json");

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
