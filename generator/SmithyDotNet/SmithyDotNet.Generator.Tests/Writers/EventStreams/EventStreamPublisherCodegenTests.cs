using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.EventStreams;
using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Writers.EventStreams;
using SmithyDotNet.Generator.Writers.Serialization;
using SmithyDotNet.Generator.Writers.Service;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.EventStreams;

// Covers the request (input) event stream: the @streaming union targeted by an operation input member.
// The consumer publishes events through a Func property; the publisher marshaller turns each into a wire
// message. Mirrors C2J's EventStreamPublisherMarshaller / EventCollectionInterface. The Send operation of
// the model streams an InputStream union of two events (chunk -> ChunkEvent, flush -> FlushEvent).
public sealed class EventStreamPublisherCodegenTests : IDisposable
{
    private const string ModelFileName = "example-2023-01-01.normal.json";
    private static readonly string Marshalling = Path.Combine("Generated", "Model", "Internal", "MarshallTransformations");
    private static readonly string Model = Path.Combine("Generated", "Model");

    private readonly GenerationContext _context;
    private readonly RequestEventStream _stream;
    private readonly List<string> _tempDirs = [];

    public EventStreamPublisherCodegenTests()
    {
        _context = TestModels.Context("Codegen/EventStreams/event-stream-input-model.json");
        _stream = _context.RequestEventStreams.Single();
    }

    public void Dispose()
    {
        foreach (var dir in _tempDirs.Where(Directory.Exists))
        {
            Directory.Delete(dir, recursive: true);
        }
    }

    [Fact]
    public void PublisherMarshaller_MarshallsEachEventWithItsWireName()
    {
        var source = new EventStreamPublisherMarshallerWriter(_context, ModelFileName).Write(_stream, TestContext.Current.CancellationToken);

        Assert.Contains("public partial class InputStreamPublisherMarshaller : EventStreamPublisher", source);
        Assert.Contains("Func<Task<IInputStreamEvent>> _publisher;", source);
        Assert.Contains("public InputStreamPublisherMarshaller(Func<Task<IInputStreamEvent>> publisher)", source);

        Assert.Contains("if (evnt is ChunkEvent)", source);
        Assert.Contains("ChunkEventMarshaller.Instance.Marshall((ChunkEvent)evnt, context);", source);
        Assert.Contains("""eventType = "chunk";""", source);

        // The second event is an else-if, and its wire name is the union member name, not the shape name.
        Assert.Contains("else if (evnt is FlushEvent)", source);
        Assert.Contains("""eventType = "flush";""", source);

        Assert.Contains("is not a known event type for this streaming operation", source);
        Assert.Contains("return CreateEventStreamMessage(eventType: eventType, contentType: contentType, marshalledEventHeaders: eventHeaders, eventPayload: eventPayload);", source);
    }

    // The wire :content-type follows each event's @eventPayload member. ChatStream carries all kinds: a blob
    // payload (AudioEvent) -> octet-stream, a string payload (TextEvent) -> text/plain, and an implicit body
    // (ImplicitPayloadEvent) plus a structure payload (ExplicitPayloadEvent) -> JSON. The @error member is
    // not an event branch. Blob/string read the raw body the event marshaller wrote to Request.Content.
    [Fact]
    public void PublisherMarshaller_PicksContentTypePerPayloadKind()
    {
        var context = TestModels.Context("Codegen/EventStreams/request-event-stream-model.json");
        var stream = context.RequestEventStreams.Single(candidate => candidate.Id.Name == "ChatStream");
        var source = new EventStreamPublisherMarshallerWriter(context, ModelFileName).Write(stream, TestContext.Current.CancellationToken);

        // eventType -> content-type -> payload are emitted contiguously per branch, so binding them together
        // catches a swapped or mis-associated mapping that three independent Contains checks would miss.
        // Whitespace is normalized so indentation changes don't make the assertion brittle.
        AssertBranch(source, wireName: "audio", contentType: "application/octet-stream", payload: "context.Request.Content");
        AssertBranch(source, wireName: "text", contentType: "text/plain", payload: "context.Request.Content");
        AssertBranch(source, wireName: "implicit", contentType: "application/json", payload: "memoryStream.ToArray()");
        // A structure @eventPayload stays JSON (the event marshaller writes it through the JSON writer).
        AssertBranch(source, wireName: "explicit", contentType: "application/json", payload: "memoryStream.ToArray()");

        // The @error union member is filtered out — it is not a publishable event.
        Assert.DoesNotContain("evnt is ChatError", source);
    }

    // The class and Func interface follow the union's renamed name; the request marshaller already
    // references `new {Renamed}PublisherMarshaller`, so the raw name would not compile.
    [Fact]
    public void PublisherMarshaller_HonorsServiceRename()
    {
        // The fixture renames com.example#EventStream to RenamedStream.
        var context = TestModels.Context("Codegen/EventStreams/event-stream-input-only-model.json");
        var source = new EventStreamPublisherMarshallerWriter(context, ModelFileName).Write(context.RequestEventStreams.Single(), TestContext.Current.CancellationToken);

        Assert.Contains("public partial class RenamedStreamPublisherMarshaller : EventStreamPublisher", source);
        Assert.Contains("Func<Task<IRenamedStreamEvent>> _publisher;", source);
        Assert.DoesNotContain("EventStreamPublisherMarshaller", source);
    }

    // A member named "equals" sets HidesBaseMember (it shadows object.Equals). After the "Publisher" rename
    // it no longer shadows anything, so the flag must be cleared — otherwise MemberWriter emits `new` (CS0109).
    [Fact]
    public void PublisherProperty_FromEqualsMember_DropsTheNewModifier()
    {
        var context = TestModels.Context("Codegen/EventStreams/event-stream-equals-member-model.json");
        var send = context.Operations.Single(operation => operation.Name == "Send");
        var source = new OperationWriter(context, ModelFileName).WriteRequest(send, TestContext.Current.CancellationToken);

        Assert.Contains("public Func<System.Threading.Tasks.Task<IInputStreamEvent>> EqualsPublisher { get; set; }", source);
        Assert.DoesNotContain("new Func<", source);
    }

    private static void AssertBranch(string source, string wireName, string contentType, string payload)
    {
        var expected = $"""eventType = "{wireName}"; contentType = "{contentType}"; eventPayload = {payload};""";
        Assert.Contains(expected, Normalize(source));
    }

    private static string Normalize(string source) => System.Text.RegularExpressions.Regex.Replace(source, @"\s+", " ");

    [Fact]
    public void RequestClass_EmitsPublisherProperty_WithNoIsSet()
    {
        var send = _context.Operations.Single(operation => operation.Name == "Send");
        var source = new OperationWriter(_context, ModelFileName).WriteRequest(send, TestContext.Current.CancellationToken);

        Assert.Contains("public Func<System.Threading.Tasks.Task<IInputStreamEvent>> StreamPublisher { get; set; }", source);
        Assert.Contains("The streaming input for the Send API.", source);
        Assert.Contains("implementing the IInputStreamEvent", source);
        // A publisher property is a consumer-supplied Func, so it carries no IsSet method.
        Assert.DoesNotContain("IsSetStreamPublisher", source);
        // Modeled attributes are retained, matching C2J: the @required stream keeps its [AWSProperty].
        Assert.Contains("[AWSProperty(Required = true)]", source);
    }

    [Fact]
    public void RequestMarshaller_WiresThePublisher_InsteadOfSerializing()
    {
        var send = _context.Operations.Single(operation => operation.Name == "Send");
        var source = new JsonRequestMarshallerWriter(_context, ModelFileName).Write(send, TestContext.Current.CancellationToken);

        Assert.Contains("""request.Headers["Content-Type"] = "application/vnd.amazon.eventstream";""", source);
        Assert.Contains("request.EventStreamPublisher = new InputStreamPublisherMarshaller(publicRequest.StreamPublisher);", source);
        // The union is never serialized as a body structure, and the JSON body Content-Type is skipped.
        Assert.DoesNotContain("InputStreamMarshaller", source);
        Assert.DoesNotContain("application/json", source);
    }

    [Fact]
    public void Generation_EmitsInputStreamFiles_AndExcludesTheUnionClass()
    {
        var written = Generate("Codegen/EventStreams/event-stream-input-model.json");

        Assert.Contains(Path.Combine(Marshalling, "InputStreamPublisherMarshaller.g.cs"), written);
        Assert.Contains(Path.Combine(Model, "IInputStreamEvent.g.cs"), written);
        Assert.Contains(Path.Combine(Model, "ChunkEvent.IInputStreamEvent.g.cs"), written);
        Assert.Contains(Path.Combine(Model, "FlushEvent.IInputStreamEvent.g.cs"), written);

        // Each event still gets a marshaller (the publisher calls it); the union itself gets neither a
        // plain model class nor a marshaller.
        Assert.Contains(Path.Combine(Marshalling, "ChunkEventMarshaller.g.cs"), written);
        Assert.Contains(Path.Combine(Marshalling, "FlushEventMarshaller.g.cs"), written);
        Assert.DoesNotContain(Path.Combine(Model, "InputStream.g.cs"), written);
        Assert.DoesNotContain(Path.Combine(Marshalling, "InputStreamMarshaller.g.cs"), written);
    }

    private IReadOnlyList<string> Generate(string model)
    {
        var generator = new ServiceGenerator(
            TestModels.Context(model),
            ModelFileName,
            "4.0.0.0",
            DefaultConfigurationManifest.Load("TestData/sdk-default-configuration.json"));

        return generator.Generate(TempDir(), TempDir(), testsOutputPath: null, TestContext.Current.CancellationToken);
    }

    private string TempDir()
    {
        var dir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");
        _tempDirs.Add(dir);
        return dir;
    }
}
