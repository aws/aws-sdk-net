using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

// Covers the event structure unmarshaller's @eventPayload/@eventHeader split. An event with an explicit
// payload member reads that member from the raw stream and every other member (which the SEP requires to
// carry @eventHeader) from an event-message header, bypassing the JSON body reader entirely. An event with
// no explicit payload member unmarshals like any other structure. Mirrors C2J's JsonRPCStructureUnmarshaller.
public class EventStructureUnmarshallTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private readonly GenerationContext _context;
    private readonly JsonStructureUnmarshallerWriter _writer;

    public EventStructureUnmarshallTests()
    {
        _context = TestModels.Context("Codegen/event-structure-unmarshall-payload-model.json");
        _writer = new JsonStructureUnmarshallerWriter(_context, ModelFileName);
    }

    private string Unmarshaller(string shapeName)
    {
        var shapeId = ShapeId.Parse($"com.example#{shapeName}");
        return _writer.Write(_context.Structures[shapeId], shapeId, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void BlobPayload_AssignsRawMemoryStream_AndReadsAllHeaderKinds()
    {
        var source = Unmarshaller("BlobPayloadEvent");

        // The @eventPayload blob is the raw stream, not read through the JSON reader.
        Assert.Contains("unmarshalledObject.Bytes = context.Stream as MemoryStream;", source);
        Assert.DoesNotContain("StreamingUtf8JsonReader reader))", source); // no while-read loop
        Assert.DoesNotContain("context.TestExpression", source);

        // Each header member is guarded by IsEventHeaderPresent and read with its typed accessor. Accessor
        // names match the runtime EventStreamHeader (AsInt32/AsInt64), symmetric with the marshaller.
        Assert.Contains("""if (context.ResponseData.IsEventHeaderPresent("DataType"))""", source);
        Assert.Contains("""unmarshalledObject.DataType = context.ResponseData.GetEventStreamHeader("DataType").AsString();""", source);
        Assert.Contains("""unmarshalledObject.Count = context.ResponseData.GetEventStreamHeader("Count").AsInt32();""", source);
        Assert.Contains("""unmarshalledObject.Total = context.ResponseData.GetEventStreamHeader("Total").AsInt64();""", source);
        Assert.Contains("""unmarshalledObject.Final = context.ResponseData.GetEventStreamHeader("Final").AsBool();""", source);
        Assert.Contains("""unmarshalledObject.At = context.ResponseData.GetEventStreamHeader("At").AsTimestamp();""", source);
    }

    [Fact]
    public void BlobHeader_WrapsByteBufInMemoryStream()
    {
        var source = Unmarshaller("BlobPayloadEvent");
        Assert.Contains("""unmarshalledObject.Raw = new MemoryStream(context.ResponseData.GetEventStreamHeader("Raw").AsByteBuf());""", source);
    }

    [Fact]
    public void StringPayload_ReadsStreamToEnd()
    {
        var source = Unmarshaller("StringPayloadEvent");
        Assert.Contains("using (var sr = new StreamReader(context.Stream))", source);
        Assert.Contains("unmarshalledObject.Message = sr.ReadToEnd();", source);
    }

    [Fact]
    public void StructPayload_DispatchesToNestedUnmarshaller()
    {
        var source = Unmarshaller("StructPayloadEvent");
        Assert.Contains("unmarshalledObject.Body = DetailUnmarshaller.Instance.Unmarshall(context, ref reader);", source);
    }

    [Fact]
    public void NoPayload_UnmarshalsAsOrdinaryStructure()
    {
        var source = Unmarshaller("NoPayloadEvent");
        // No @eventPayload member: the whole message body is the payload, read via the JSON reader loop.
        Assert.Contains("while (context.ReadAtDepth(targetDepth, ref reader))", source);
        Assert.Contains("""if (context.TestExpression("value", targetDepth, ref reader))""", source);
        Assert.DoesNotContain("IsEventHeaderPresent", source);
    }

    [Fact]
    public void HeadersOnly_ReadsHeaders_WithNoJsonBodyLoop()
    {
        var source = Unmarshaller("HeadersOnlyEvent");
        // No @eventPayload and no unbound members: only header reads, never a JSON body loop.
        Assert.Contains("""unmarshalledObject.DataType = context.ResponseData.GetEventStreamHeader("DataType").AsString();""", source);
        Assert.Contains("""unmarshalledObject.Count = context.ResponseData.GetEventStreamHeader("Count").AsInt32();""", source);
        Assert.DoesNotContain("while (context.ReadAtDepth(targetDepth, ref reader))", source);
        Assert.DoesNotContain("context.TestExpression", source);
    }

    [Fact]
    public void EmptyOrdinaryStructure_StillReadsJsonBody()
    {
        var source = Unmarshaller("Marker");
        // A member-less structure is not an event: the loop must still consume its {} tokens so the reader
        // lands after the object, otherwise the parent structure's remaining members are misread.
        Assert.Contains("context.Read(ref reader);", source);
        Assert.Contains("if (context.CurrentTokenType == JsonTokenType.Null) return null;", source);
        Assert.Contains("while (context.ReadAtDepth(targetDepth, ref reader))", source);
        Assert.DoesNotContain("IsEventHeaderPresent", source);
    }

    [Fact]
    public void HeadersAndImplicitPayload_ReadsEveryHeaderKindFromHeaders()
    {
        var source = Unmarshaller("HeadersAndImplicitPayloadEvent");
        // Without an @eventPayload member, each @eventHeader still reads from the message header, one per kind.
        Assert.Contains("""unmarshalledObject.DataType = context.ResponseData.GetEventStreamHeader("DataType").AsString();""", source);
        Assert.Contains("""unmarshalledObject.SeqNum = context.ResponseData.GetEventStreamHeader("SeqNum").AsInt64();""", source);
        Assert.Contains("""unmarshalledObject.Final = context.ResponseData.GetEventStreamHeader("Final").AsBool();""", source);
        Assert.Contains("""unmarshalledObject.At = context.ResponseData.GetEventStreamHeader("At").AsTimestamp();""", source);
        Assert.Contains("""unmarshalledObject.Checksum = new MemoryStream(context.ResponseData.GetEventStreamHeader("Checksum").AsByteBuf());""", source);
    }

    [Fact]
    public void HeadersAndImplicitPayload_ReadsEveryUnboundMemberFromJsonBody()
    {
        var source = Unmarshaller("HeadersAndImplicitPayloadEvent");
        // The unbound members (scalar and nested structure) are the JSON body, read through the reader loop.
        Assert.Contains("while (context.ReadAtDepth(targetDepth, ref reader))", source);
        Assert.Contains("""if (context.TestExpression("value", targetDepth, ref reader))""", source);
        Assert.Contains("""if (context.TestExpression("count", targetDepth, ref reader))""", source);
        Assert.Contains("""if (context.TestExpression("detail", targetDepth, ref reader))""", source);
        Assert.Contains("var unmarshaller = DetailUnmarshaller.Instance;", source);
    }

    [Fact]
    public void HeadersAndImplicitPayload_KeepsHeaderAndBodyMembersDisjoint()
    {
        var source = Unmarshaller("HeadersAndImplicitPayloadEvent");
        // A header member is never read from the JSON body, and a body member is never looked up as a header.
        Assert.DoesNotContain("""context.TestExpression("DataType", targetDepth, ref reader)""", source);
        Assert.DoesNotContain("""context.TestExpression("SeqNum", targetDepth, ref reader)""", source);
        Assert.DoesNotContain("""context.TestExpression("Checksum", targetDepth, ref reader)""", source);
        Assert.DoesNotContain("""IsEventHeaderPresent("value")""", source);
        Assert.DoesNotContain("""IsEventHeaderPresent("count")""", source);
        Assert.DoesNotContain("""IsEventHeaderPresent("detail")""", source);
    }
}
