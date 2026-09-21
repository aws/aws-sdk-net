using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

// Request event-stream event marshaller (DOTNET-8814):
// - @eventHeader -> message headers;
// - Explicit @eventPayload -> raw payload;
// - Everything else -> JSON body.
public class EventMarshallerCodegenTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private readonly GenerationContext _context = TestModels.Context("Codegen/EventStreams/request-event-stream-model.json");

    private string Write(string shapeName)
    {
        var shapeId = ShapeId.Parse($"com.example#{shapeName}");
        return new JsonStructureMarshallerWriter(_context, ModelFileName).Write(_context.Structures[shapeId], shapeId, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void BlobPayload_IsRawContent_AndHeadersUseTypedSetters()
    {
        var source = Write("AudioEvent");

        Assert.Contains("public partial class AudioEventMarshaller : IRequestMarshaller<AudioEvent, JsonMarshallerContext>", source);
        Assert.Contains("if (requestObject.IsSetChunk())", source);
        Assert.Contains("context.Request.Content = requestObject.Chunk.ToArray();", source);

        Assert.Contains("if (requestObject.IsSetContentType())", source);
        Assert.Contains("""var header = new Amazon.Runtime.EventStreams.EventStreamHeader("contentType");""", source);
        Assert.Contains("header.SetString(requestObject.ContentType);", source);
        Assert.Contains("context.Request.EventHeaders.Add(header);", source);
        // An enum is a ConstantClass; its implicit string conversion rides SetString.
        Assert.Contains("header.SetString(requestObject.Codec);", source);
        Assert.Contains("header.SetInt32(requestObject.Sequence.Value);", source);
        Assert.Contains("header.SetInt64(requestObject.Offset.Value);", source);
        Assert.Contains("header.SetBool(requestObject.Final.Value);", source);
        Assert.Contains("header.SetTimestamp(requestObject.SentAt.Value);", source);
        Assert.Contains("header.SetByteBuf(requestObject.Checksum.ToArray());", source);

        // Nothing is written to the JSON body: no property names, no base64 blob.
        Assert.DoesNotContain("context.Writer.", source);
    }

    [Fact]
    public void StringPayload_IsUtf8Content()
    {
        var source = Write("TextEvent");

        Assert.Contains("if (requestObject.IsSetText())", source);
        Assert.Contains("context.Request.Content = Encoding.UTF8.GetBytes(requestObject.Text);", source);
        Assert.DoesNotContain("context.Writer.", source);
    }

    [Fact]
    public void StructurePayload_WritesItsMembersIntoTheOpenObject()
    {
        var source = Write("ExplicitPayloadEvent");

        // The publisher already opened the JSON object, so the payload structure's members are written
        // directly into it - no property name, no nested WriteStartObject.
        Assert.Contains("if (requestObject.IsSetPayload())", source);
        Assert.Contains("ExplicitPayloadMarshaller.Instance.Marshall(requestObject.Payload, context);", source);
        Assert.DoesNotContain("""WritePropertyName("payload")""", source);
        Assert.DoesNotContain("WriteStartObject", source);
        Assert.Contains("""var header = new Amazon.Runtime.EventStreams.EventStreamHeader("header");""", source);
    }

    [Theory]
    [InlineData("""{ "type": "structure", "members": { "bad": { "target": "smithy.api#Double", "traits": { "smithy.api#eventHeader": {} }}}}""")]
    [InlineData("""{ "type": "structure", "members": { "bad": { "target": "smithy.api#Document", "traits": { "smithy.api#eventPayload": {} }}}}""")]
    public void UnsupportedTargetType_FailsLoud(string shapeJson)
    {
        var shape = Assert.IsType<StructureShape>(TestModels.DeserializeShape(shapeJson));
        Assert.Throws<GeneratorException>(() => new JsonStructureMarshallerWriter(_context, ModelFileName).Write(shape, ShapeId.Parse("com.example#BadEvent"), TestContext.Current.CancellationToken));
    }

    [Fact]
    public void ImplicitPayload_UnboundMembersStayInTheJsonBody()
    {
        var source = Write("ImplicitPayloadEvent");

        Assert.Contains("""var header = new Amazon.Runtime.EventStreams.EventStreamHeader("header");""", source);
        Assert.Contains("header.SetString(requestObject.Header);", source);
        Assert.DoesNotContain("""WritePropertyName("header")""", source);
        Assert.DoesNotContain("context.Request.Content", source);

        Assert.Contains("""context.Writer.WritePropertyName("payloadMember1");""", source);
        Assert.Contains("context.Writer.WriteStringValue(requestObject.PayloadMember1);", source);
        Assert.Contains("""context.Writer.WritePropertyName("payloadMember2");""", source);
    }
}
