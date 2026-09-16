using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.EventStreams;

/// <summary>
/// Emits the publisher marshaller for a request (input) event stream — the <c>@streaming</c> union
/// targeted by an operation input member. <c>NextEventAsync</c> pulls the next event from the
/// consumer-supplied publisher, marshals it with the event's own marshaller, and returns the wire
/// <c>IEventStreamMessage</c>. Matches the public API surface produced by C2J's
/// <c>EventStreamPublisherMarshaller</c>.
/// </summary>
public sealed class EventStreamPublisherMarshallerWriter(GenerationContext context, string modelFileName)
{
    // A union member that isn't an @error is an event: its wire name (the :event-type header) is the
    // member name verbatim, its marshaller is {EventClass}Marshaller, and its payload kind picks the
    // wire :content-type.
    private readonly record struct Event(string WireName, string EventClass, PayloadKind Payload);

    // The event's wire :content-type and payload source. A blob/string @eventPayload is the raw body the
    // event marshaller wrote to context.Request.Content; anything else (a structure payload or an implicit
    // body) is the JSON the marshaller wrote through the writer.
    private enum PayloadKind { Json, Blob, String }

    public string Write(RequestEventStream stream, CancellationToken cancellationToken = default)
    {
        var union = (UnionShape)context.Resolve(stream.Id);

        // The marshaller class and Func interface derive from the union name, matching RequestEventStream.InterfaceName.
        var streamName = stream.Id.Name;
        // Ordered by wire name so the branch order is deterministic and matches RequestEventStream.Events.
        // Branch order is behaviorally irrelevant (the checks are mutually exclusive), so this is safe.
        var events = union.Members
            .Where(member => !context.Resolve(member.Value.Target).IsError())
            .OrderBy(member => member.Key, StringComparer.Ordinal)
            .Select(member => new Event(member.Key, context.ToDotNetName(member.Value.Target), PayloadOf(member.Value.Target)))
            .ToList();

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.EventStreamPublisherUsings);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// Marshals the service events for the event stream to the low level IEventStreamMessage.");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {streamName}PublisherMarshaller : EventStreamPublisher", () =>
            {
                writer.WriteLine($"Func<Task<I{streamName}Event>> _publisher;");
                writer.WriteLine();
                WriteConstructor(writer, streamName);
                writer.WriteLine();
                WriteNextEvent(writer, events);
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private static void WriteConstructor(CodeWriter writer, string streamName)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Creates instance of {streamName}PublisherMarshaller");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("""/// <param name="publisher">The service event publisher provided by the consumer of the SDK.</param>""");
        writer.OpenBlock($"public {streamName}PublisherMarshaller(Func<Task<I{streamName}Event>> publisher)", () =>
        {
            writer.WriteLine("_publisher = publisher;");
        });
    }

    private static void WriteNextEvent(CodeWriter writer, List<Event> events)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Gets the next service event provided by the consumer of the SDK and converts it to a IEventStreamMessage.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("/// <returns></returns>");
        writer.WriteLine("""/// <exception cref="Amazon.Runtime.AmazonClientException">If the type of the event is unknown.</exception>""");
        writer.OpenBlock("public override async Task<IEventStreamMessage> NextEventAsync()", () =>
        {
            writer.WriteLine("var evnt = await _publisher().ConfigureAwait(false);");
            writer.OpenBlock("if (evnt == null)", () => writer.WriteLine("return null;"));
            writer.WriteLine();
            writer.WriteLine("byte[] eventPayload;");
            writer.WriteLine("string contentType;");
            writer.WriteLine("string eventType;");
            writer.WriteLine("IList<EventStreamHeader> eventHeaders;");

            for (var i = 0; i < events.Count; i++)
            {
                var keyword = i == 0 ? "if" : "else if";
                WriteEventBranch(writer, keyword, events[i]);
            }

            writer.OpenBlock("else", () =>
            {
                writer.WriteLine("""throw new Amazon.Runtime.AmazonClientException($"Type {evnt.GetType().FullName} is not a known event type for this streaming operation");""");
            });
            writer.WriteLine();
            writer.WriteLine("return CreateEventStreamMessage(eventType: eventType, contentType: contentType, marshalledEventHeaders: eventHeaders, eventPayload: eventPayload);");
        });
    }

    // The JSON writer block runs for every event (matching C2J) so @eventHeader members land in
    // context.Request.EventHeaders; the payload source is then chosen by kind. CBOR is not handled — the
    // generator is restJson1 only.
    private static void WriteEventBranch(CodeWriter writer, string keyword, Event evnt)
    {
        writer.OpenBlock($"{keyword} (evnt is {evnt.EventClass})", () =>
        {
            writer.WriteLine("var memoryStream = new MemoryStream();");
            writer.WriteLine("var context = CreateJsonMarshallerContext(memoryStream);");
            writer.WriteLine("context.Writer.WriteStartObject();");
            writer.WriteLine($"{evnt.EventClass}Marshaller.Instance.Marshall(({evnt.EventClass})evnt, context);");
            writer.WriteLine("eventHeaders = context.Request.EventHeaders;");
            writer.WriteLine("context.Writer.WriteEndObject();");
            writer.WriteLine("context.Writer.Flush();");
            writer.WriteLine();
            writer.WriteLine($"eventType = {CodeWriter.Literal(evnt.WireName)};");
            WritePayload(writer, evnt.Payload);
        });
    }

    // Blob/string payloads are the raw body the event marshaller placed in context.Request.Content; the JSON
    // memoryStream is discarded for them (it holds only the empty {} the writer block emitted). A structure
    // payload or an implicit body is the JSON itself.
    private static void WritePayload(CodeWriter writer, PayloadKind payload)
    {
        switch (payload)
        {
            case PayloadKind.Blob:
                writer.WriteLine("""contentType = "application/octet-stream";""");
                writer.WriteLine("eventPayload = context.Request.Content;");
                break;
            case PayloadKind.String:
                writer.WriteLine("""contentType = "text/plain";""");
                writer.WriteLine("eventPayload = context.Request.Content;");
                break;
            default:
                writer.WriteLine("""contentType = "application/json";""");
                writer.WriteLine("eventPayload = memoryStream.ToArray();");
                break;
        }
    }

    // The wire :content-type follows the event's explicit @eventPayload member. Only blob and string are sent
    // as a raw body (octet-stream / text/plain); a structure payload and the no-payload (implicit body) case
    // stay JSON. Mirrors C2J, except C2J's dead text/plain branch for a structure payload — no service models
    // one — is kept as JSON here to match what the event marshaller actually writes.
    private PayloadKind PayloadOf(ShapeId eventId)
    {
        var eventStructure = (StructureShape)context.Resolve(eventId);
        var payload = eventStructure.Members.Values.FirstOrDefault(member => member.IsEventPayload());
        if (payload is null)
        {
            return PayloadKind.Json;
        }

        return context.Resolve(payload.Target) switch
        {
            BlobShape => PayloadKind.Blob,
            StringShape or EnumShape => PayloadKind.String,
            _ => PayloadKind.Json,
        };
    }
}
