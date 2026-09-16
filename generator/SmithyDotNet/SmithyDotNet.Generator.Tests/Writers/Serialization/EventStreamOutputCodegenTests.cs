using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Writers.Serialization;
using SmithyDotNet.Generator.Writers.EventStreams;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

// Covers the response event-stream member: the @streaming union targeted by an operation output member.
// The response unmarshaller hands the raw stream to the generated EnumerableEventOutputStream subclass,
// which EventStreamOutputWriter emits (mirroring C2J's EventStreamOutputGenerator).
public class EventStreamOutputCodegenTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private readonly GenerationContext _context;
    private readonly string _eventStreamClass;
    private readonly string _responseUnmarshaller;

    public EventStreamOutputCodegenTests()
    {
        _context = TestModels.Context("Codegen/event-stream-output-model.json");

        var union = (StructureShape)_context.Resolve(ShapeId.Parse("com.example#ConverseStreamOutput"));
        _eventStreamClass = new EventStreamOutputWriter(_context, ModelFileName)
            .Write(union, ShapeId.Parse("com.example#ConverseStreamOutput"), TestContext.Current.CancellationToken);

        var operation = _context.Operations.Single(o => o.Name == "ConverseStream");
        _responseUnmarshaller = new JsonResponseUnmarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void ResponseUnmarshaller_AssignsEventStreamMember_FromResponseStream()
    {
        // The event-stream member IS the body: assigned a new instance of the union class wrapping the
        // raw response stream, not read from the JSON reader. A sibling header still unmarshals after.
        Assert.Contains("unmarshalledObject.Stream = new ConverseStreamOutput(context.Stream);", _responseUnmarshaller);
        Assert.DoesNotContain("StreamingUtf8JsonReader", _responseUnmarshaller.Split("UnmarshallException")[0]);
        Assert.Contains("""if (context.ResponseData.IsHeaderPresent("x-session-id"))""", _responseUnmarshaller);
    }

    [Fact]
    public void EventStreamClass_HasSignatureAndSuppressions()
    {
        Assert.Contains($"public sealed class ConverseStreamOutput : EnumerableEventOutputStream<RuntimeEvent, {_context.BaseName}EventStreamException>", _eventStreamClass);
        Assert.Contains("""[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "ConverseStreamOutputCollection is not descriptive")]""", _eventStreamClass);
        Assert.Contains("""[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063", Justification = "IDisposable is a transient interface from IEventOutputStream. Users need to be able to call Dispose.")]""", _eventStreamClass);
    }

    [Fact]
    public void EventStreamClass_EventMapping_HasInitialResponseAndEvents()
    {
        Assert.Contains("protected override IDictionary<string, EventFactory> EventMapping { get; } = new Dictionary<string, EventFactory>(StringComparer.OrdinalIgnoreCase)", _eventStreamClass);
        Assert.Contains("using EventFactory = System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, Amazon.Runtime.EventStreams.IEventStreamEvent>;", _eventStreamClass);
        // A union named EventStream yields a same-namespace IEventStreamEvent marker that would shadow the runtime's.
        Assert.Contains("using RuntimeEvent = Amazon.Runtime.EventStreams.IEventStreamEvent;", _eventStreamClass);
        Assert.DoesNotContain(" IEventStreamEvent", _eventStreamClass.Replace("Amazon.Runtime.EventStreams.IEventStreamEvent", ""));
        Assert.Contains("""{"Initial-Response",payload=>newInitialResponseEvent(payload)},""", Collapse(_eventStreamClass));
        Assert.Contains("""{"contentBlockDelta",payload=>""", Collapse(_eventStreamClass));
        Assert.Contains("return new ContentBlockDeltaEventUnmarshaller().Unmarshall(context, ref reader);", _eventStreamClass);
        Assert.Contains("""{"metadata",payload=>""", Collapse(_eventStreamClass));
        Assert.Contains("return new ConverseStreamMetadataEventUnmarshaller().Unmarshall(context, ref reader);", _eventStreamClass);
        // Each block-lambda entry closes both the lambda and the dictionary element: `}` then `},`.
        Assert.Contains("refreader);}},", Collapse(_eventStreamClass));
    }

    [Fact]
    public void EventStreamClass_ExceptionMapping_UsesErrorMembers()
    {
        Assert.Contains("protected override IDictionary<string, ExceptionFactory> ExceptionMapping { get; } = new Dictionary<string, ExceptionFactory>(StringComparer.OrdinalIgnoreCase)", _eventStreamClass);
        Assert.Contains($"using ExceptionFactory = System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, {_context.Namespace}.{_context.BaseName}EventStreamException>;", _eventStreamClass);
        Assert.Contains("""{"validationException",payload=>""", Collapse(_eventStreamClass));
        Assert.Contains($"return new {_context.BaseName}EventStreamException(Encoding.UTF8.GetString(payload.Payload), new ValidationExceptionUnmarshaller().Unmarshall(context, ref reader));", _eventStreamClass);
        // The exception ctor closes its own paren, then the lambda `}` and the dictionary element `},`.
        Assert.Contains("refreader));}},", Collapse(_eventStreamClass));
    }

    [Fact]
    public void EventStreamClass_EmitsPerEventHandlers_ButNotForExceptions()
    {
        Assert.Contains("public event EventHandler<EventStreamEventReceivedArgs<InitialResponseEvent>> InitialResponseReceived;", _eventStreamClass);
        Assert.Contains("public event EventHandler<EventStreamEventReceivedArgs<ContentBlockDeltaEvent>> ContentBlockDeltaReceived;", _eventStreamClass);
        Assert.Contains("public event EventHandler<EventStreamEventReceivedArgs<ConverseStreamMetadataEvent>> MetadataReceived;", _eventStreamClass);
        // An error member only feeds ExceptionMapping — it gets no strongly-typed event handler.
        Assert.DoesNotContain("ValidationExceptionReceived", _eventStreamClass);
    }

    [Fact]
    public void EventStreamClass_DispatchChain_StartsWithInitialResponseThenEvents()
    {
        Assert.Contains("RaiseEvent(InitialResponseReceived, ev) ||", _eventStreamClass);
        Assert.Contains("RaiseEvent(ContentBlockDeltaReceived, ev) ||", _eventStreamClass);
        Assert.Contains("RaiseEvent(MetadataReceived, ev);", _eventStreamClass);
    }

    [Fact]
    public void EventStreamClass_HasBothConstructors()
    {
        Assert.Contains("public ConverseStreamOutput(Stream stream) : this(stream, null)", _eventStreamClass);
        Assert.Contains("public ConverseStreamOutput(Stream stream, IEventStreamDecoder eventStreamDecoder) : base(stream, eventStreamDecoder)", _eventStreamClass);
    }

    // Strips all whitespace so brace-close assertions don't depend on the formatter's line breaks/indent.
    private static string Collapse(string source) =>
        System.Text.RegularExpressions.Regex.Replace(source, @"\s+", "");
}
