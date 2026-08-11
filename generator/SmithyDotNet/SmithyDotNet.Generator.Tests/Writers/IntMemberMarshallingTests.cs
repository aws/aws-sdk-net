using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

/// <summary>
/// Exercises int? (Smithy integer) support across the four JSON marshalling writers. The shared
/// CloudTrailData fixture is all-string, so these tests synthesize structures/operations carrying
/// integer members and assert the emitted marshal/unmarshal code matches the existing SDK's
/// patterns (WriteNumberValue with .Value, NullableIntUnmarshaller, StringUtils.FromInt).
/// </summary>
[Collection(nameof(CloudTrailModelCollection))]
public class IntMemberMarshallingTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";
    private const string Namespace = "com.amazonaws.cloudtraildata";

    private readonly GenerationContext _context;

    public IntMemberMarshallingTests(CloudTrailModelFixture fixture)
    {
        _context = fixture.Context;
    }

    [Fact]
    public void StructureMarshaller_IntMember_WritesNumberValueWithDotValue()
    {
        var structure = StructureWith(("count", Integer(), false));
        var output = new JsonStructureMarshallerWriter(_context, ModelFileName)
            .Write(structure, ShapeId.Parse($"{Namespace}#Widget"), TestContext.Current.CancellationToken);

        Assert.Contains("if (requestObject.IsSetCount())", output);
        Assert.Contains("context.Writer.WritePropertyName(\"count\");", output);
        Assert.Contains("context.Writer.WriteNumberValue(requestObject.Count.Value);", output);
    }

    [Fact]
    public void StructureUnmarshaller_IntMember_UsesNullableIntUnmarshaller()
    {
        var structure = StructureWith(("count", Integer(), false));
        var output = new JsonStructureUnmarshallerWriter(_context, ModelFileName)
            .Write(structure, ShapeId.Parse($"{Namespace}#Widget"), TestContext.Current.CancellationToken);

        Assert.Contains("if (context.TestExpression(\"count\", targetDepth, ref reader))", output);
        Assert.Contains("var unmarshaller = NullableIntUnmarshaller.Instance;", output);
        Assert.Contains("unmarshalledObject.Count = unmarshaller.Unmarshall(context, ref reader);", output);
    }

    [Fact]
    public void ResponseUnmarshaller_IntMember_UsesNullableIntUnmarshaller()
    {
        var operation = OperationWith(output: StructureWith(("count", Integer(), false)));
        var source = new JsonResponseUnmarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);

        Assert.Contains("if (context.TestExpression(\"count\", targetDepth, ref reader))", source);
        Assert.Contains("var unmarshaller = NullableIntUnmarshaller.Instance;", source);
        Assert.Contains("response.Count = unmarshaller.Unmarshall(context, ref reader);", source);
    }

    [Fact]
    public void RequestMarshaller_IntBodyMember_WritesNumberValueWithDotValue()
    {
        var operation = OperationWith(input: StructureWith(("count", Integer(), false)));
        var source = WriteRequest(operation);

        Assert.Contains("if (publicRequest.IsSetCount())", source);
        Assert.Contains("context.Writer.WritePropertyName(\"count\");", source);
        Assert.Contains("context.Writer.WriteNumberValue(publicRequest.Count.Value);", source);
    }

    [Fact]
    public void RequestMarshaller_IntQueryMember_UsesFromIntWithoutDotValue()
    {
        var member = Integer(("smithy.api#httpQuery", "maxResults"));
        var operation = OperationWith(input: StructureWith(("maxResults", member, false)));
        var source = WriteRequest(operation);

        Assert.Contains("if (publicRequest.IsSetMaxResults())", source);
        Assert.Contains("request.Parameters.Add(\"maxResults\", StringUtils.FromInt(publicRequest.MaxResults));", source);
        Assert.DoesNotContain("publicRequest.MaxResults.Value", source);
    }

    [Fact]
    public void RequestMarshaller_RequiredIntQueryMember_GuardsWithIsSetNotIsNullOrEmpty()
    {
        var member = Integer(("smithy.api#httpQuery", "maxResults"), ("smithy.api#required", null));
        var operation = OperationWith(input: StructureWith(("maxResults", member, true)));
        var source = WriteRequest(operation);

        Assert.Contains("if (!publicRequest.IsSetMaxResults())", source);
        Assert.DoesNotContain("string.IsNullOrEmpty(publicRequest.MaxResults)", source);
        Assert.Contains("Request object does not have required field MaxResults set", source);
    }

    [Fact]
    public void RequestMarshaller_IntHeaderMember_ConvertsThroughFromInt()
    {
        var member = Integer(("smithy.api#httpHeader", "Max-Results"));
        var operation = OperationWith(input: StructureWith(("maxResults", member, false)));
        var source = WriteRequest(operation);

        Assert.Contains("if (publicRequest.IsSetMaxResults())", source);
        Assert.Contains("request.Headers[\"Max-Results\"] = StringUtils.FromInt(publicRequest.MaxResults);", source);
    }

    [Fact]
    public void RequestMarshaller_IntLabelMember_UsesFromIntInPathResource()
    {
        var member = Integer(("smithy.api#httpLabel", null));
        var operation = OperationWith(
            input: StructureWith(("id", member, true)),
            uri: "/widgets/{id}");
        var source = WriteRequest(operation);

        Assert.Contains("if (!publicRequest.IsSetId())", source);
        Assert.Contains("request.AddPathResource(\"{id}\", StringUtils.FromInt(publicRequest.Id));", source);
    }

    private string WriteRequest(Operation operation) =>
        new JsonRequestMarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);

    // --- Synthetic model builders ------------------------------------------------------------

    private static readonly JsonSerializerOptions Options = CloudTrailModelFixture.Options;

    // An integer member shape targeting the smithy.api#Integer prelude shape, carrying the given
    // traits (value null -> annotation trait "{}", otherwise a JSON string value).
    private static MemberShape Integer(params (string Trait, string? Value)[] traits)
    {
        var traitJson = string.Join(", ", traits.Select(t =>
            t.Value is null ? $"\"{t.Trait}\": {{}}" : $"\"{t.Trait}\": \"{t.Value}\""));
        var json = $$"""{ "target": "smithy.api#Integer", "traits": { {{traitJson}} } }""";
        return Deserialize<MemberShape>(json);
    }

    private static StructureShape StructureWith(params (string Name, MemberShape Member, bool Required)[] members)
    {
        var structure = new StructureShape();
        foreach (var (name, member, required) in members)
        {
            structure.Members[name] = required ? WithRequired(member) : member;
        }

        return structure;
    }

    // @required lives on the structure member reference, not the target; re-emit the member with the
    // trait added so IsRequired() and the AWSProperty resolution see it.
    private static MemberShape WithRequired(MemberShape member)
    {
        var traits = new Dictionary<string, JsonElement>(member.Traits)
        {
            ["smithy.api#required"] = JsonDocument.Parse("{}").RootElement,
        };
        return member with { Traits = traits };
    }

    private Operation OperationWith(StructureShape? input = null, StructureShape? output = null, string uri = "/widgets")
    {
        var http = Deserialize<OperationShape>(
            $$"""{ "type": "operation", "traits": { "smithy.api#http": { "method": "POST", "uri": "{{uri}}", "code": 200 } } }""");
        return new Operation("DoThing", http, input ?? new StructureShape(), output ?? new StructureShape(), []);
    }

    // Deserialize the concrete T directly, not via Shape: ShapeConverter dispatches on a "type"
    // field, which member shapes (target + traits, no type) don't carry. The converter matches only
    // typeof(Shape), so a concrete T bypasses it and uses reflection-based deserialization.
    private static T Deserialize<T>(string json) where T : Shape =>
        JsonSerializer.Deserialize<T>(json, Options)
        ?? throw new InvalidOperationException($"'{json}' deserialized to null.");
}
