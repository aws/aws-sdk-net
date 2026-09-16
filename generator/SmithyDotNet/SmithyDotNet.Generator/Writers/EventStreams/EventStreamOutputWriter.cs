using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers.Shapes;

namespace SmithyDotNet.Generator.Writers.EventStreams;

/// <summary>
/// Emits the C# source for a response event-stream class — the <c>@streaming</c> union targeted by an
/// operation output member. The class derives from <c>EnumerableEventOutputStream</c> and lazily decodes
/// the response stream into strongly-typed events; matches the public API surface produced by C2J's
/// <c>EventStreamOutputGenerator</c>.
/// <para />
/// A union member targeting an <c>@error</c> shape becomes an entry in <c>ExceptionMapping</c>; every
/// other member is an event in <c>EventMapping</c>, with a matching <c>{Name}Received</c> handler and a
/// slot in the dispatch chain. The always-present <c>Initial-Response</c> entry carries the operation's
/// initial (non-event) response.
/// </summary>
public sealed class EventStreamOutputWriter(GenerationContext context, string modelFileName)
{
    // An event message maps a wire name to the event class and its unmarshaller; an exception message maps
    // a wire name to the generated exception class and its unmarshaller. `WireName` is the union member
    // name verbatim — the `:event-type`/`:exception-type` header value the service sends (per the event-
    // stream SEP). `HandlerName` is that name upper-cased for the C# `{HandlerName}Received` member.
    private readonly record struct Entry(string WireName, string HandlerName, string TypeName, string Unmarshaller);

    private const string ReaderLine =
        "var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);";

    public string Write(StructureShape eventStream, ShapeId shapeId, CancellationToken cancellationToken = default)
    {
        var className = context.ToDotNetName(shapeId);
        var exceptionType = $"{context.BaseName}EventStreamException";

        var events = new List<Entry>();
        var exceptions = new List<Entry>();
        foreach (var (memberName, member) in eventStream.Members)
        {
            // The wire event name is the member name verbatim; the C# handler is its PascalCase form.
            var handlerName = SdkNaming.ToUpperFirstCharacter(memberName);
            if (context.Resolve(member.Target).IsError())
            {
                // An error member unmarshals to the generated exception class (ToExceptionName), wrapped
                // in the service's event-stream exception.
                var exClass = ExceptionWriter.ToExceptionName(member.Target.Name);
                exceptions.Add(new Entry(memberName, handlerName, exClass, $"{exClass}Unmarshaller"));
            }
            else
            {
                var eventType = context.ToDotNetName(member.Target);
                events.Add(new Entry(memberName, handlerName, eventType, $"{eventType}Unmarshaller"));
            }
        }

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
        FileHeader.WritePragma(writer, FileHeader.ModelWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model", () =>
        {
            DocumentationFormatter.WriteClassSummary(writer, DocumentationFormatter.Cleanup(eventStream.GetDocumentation()));
            WriteSuppressions(writer, className);
            // IEventStreamEvent is always fully qualified: a union named EventStream (the protocol test client)
            // gets an I{Union}Event marker of the same name in this namespace, which would shadow the runtime's.
            writer.OpenBlock($"public sealed class {className} : EnumerableEventOutputStream<RuntimeEvent, {exceptionType}>", () =>
            {
                WriteEventMapping(writer, events);
                writer.WriteLine();
                WriteExceptionMapping(writer, exceptions, exceptionType);
                writer.WriteLine();
                WriteProcessingFlag(writer);
                writer.WriteLine();
                WriteEvents(writer, exceptionType, events);
                WriteConstructors(writer, className, events);
                writer.WriteLine();
                WriteRaiseEvent(writer);
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        FileHeader.WriteUsings(writer, FileHeader.EventStreamOutputUsings, emitTrailingNewLine: false);
        writer.WriteLine($"using {context.Namespace}.Model.Internal.MarshallTransformations;");
        // A union named EventStream (the protocol test client) yields an I{Union}Event marker in this very
        // namespace that shadows the runtime's IEventStreamEvent, so refer to it through an alias no shape name can hit.
        writer.WriteLine("using RuntimeEvent = Amazon.Runtime.EventStreams.IEventStreamEvent;");
        writer.WriteLine("using EventFactory = System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, Amazon.Runtime.EventStreams.IEventStreamEvent>;");
        writer.WriteLine($"using ExceptionFactory = System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, {context.Namespace}.{context.BaseName}EventStreamException>;");
    }

    // CA1710 fires because the base type name ends in "Stream", not "Collection"; CA1063 fires on the
    // Dispose surface inherited via IEventOutputStream. Both are suppressed verbatim as C2J does.
    private static void WriteSuppressions(CodeWriter writer, string className)
    {
        writer.WriteLine($"""[System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "{className}Collection is not descriptive")]""");
        writer.WriteLine("""[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063", Justification = "IDisposable is a transient interface from IEventOutputStream. Users need to be able to call Dispose.")]""");
    }

    private static void WriteEventMapping(CodeWriter writer, List<Entry> events)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// The mapping of event message to a generator function to construct the matching EventStream event.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("protected override IDictionary<string, EventFactory> EventMapping { get; } = new Dictionary<string, EventFactory>(StringComparer.OrdinalIgnoreCase)", "};", () =>
        {
            // The initial (non-event) response is always present; its lambda is a single expression.
            writer.WriteLine("{");
            writer.Indent(() =>
            {
                writer.WriteLine($"{CodeWriter.Literal("Initial-Response")}, payload => new InitialResponseEvent(payload)");
            });
            writer.WriteLine("},");
            foreach (var ev in events)
            {
                WriteMessageEntry(writer, ev.WireName, $"return new {ev.Unmarshaller}().Unmarshall(context, ref reader);");
            }
        });
    }

    private static void WriteExceptionMapping(CodeWriter writer, List<Entry> exceptions, string exceptionType)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// The mapping of event message to a generator function to construct the matching EventStream Exception");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("protected override IDictionary<string, ExceptionFactory> ExceptionMapping { get; } = new Dictionary<string, ExceptionFactory>(StringComparer.OrdinalIgnoreCase)", "};", () =>
        {
            foreach (var ex in exceptions)
            {
                WriteMessageEntry(writer, ex.WireName, $"return new {exceptionType}(Encoding.UTF8.GetString(payload.Payload), new {ex.Unmarshaller}().Unmarshall(context, ref reader));");
            }
        });
    }

    // One dictionary element: the element's own `{ }` wraps `"name", payload => { <body> }`, and the
    // element is closed with `},`. The lambda gets its own block because the body is multi-statement.
    private static void WriteMessageEntry(CodeWriter writer, string name, string returnStatement)
    {
        writer.WriteLine("{");
        writer.Indent(() =>
        {
            writer.OpenBlock($"{CodeWriter.Literal(name)}, payload =>", () =>
            {
                writer.WriteLine("var context = EventStreamUtils.ConvertMessageToJsonContext(payload);");
                writer.WriteLine(ReaderLine);
                writer.WriteLine(returnStatement);
            });
        });
        writer.WriteLine("},");
    }

    private static void WriteProcessingFlag(CodeWriter writer)
    {
        writer.WriteLine("// Backing by a volatile bool. The flag only changes one way, so no need for a lock.");
        writer.WriteLine("// This is located in the subclass to be CLS compliant.");
        writer.WriteLine("private volatile bool _isProcessing;");
        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Whether the background processing loop is running.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("protected override bool IsProcessing", () =>
        {
            writer.WriteLine("get { return _isProcessing; }");
            writer.WriteLine("set { _isProcessing = value; }");
        });
    }

    private static void WriteEvents(CodeWriter writer, string exceptionType, List<Entry> events)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Event that encompasses all events.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("public override event EventHandler<EventStreamEventReceivedArgs<RuntimeEvent>> EventReceived;");
        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Event that encompasses exceptions.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public override event EventHandler<EventStreamExceptionReceivedArgs<{exceptionType}>> ExceptionReceived;");
        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Event for the initial response.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("public event EventHandler<EventStreamEventReceivedArgs<InitialResponseEvent>> InitialResponseReceived;");
        writer.WriteLine();
        foreach (var ev in events)
        {
            writer.WriteLine("///<summary>");
            writer.WriteLine($"///Raised when an {ev.HandlerName} event is received");
            writer.WriteLine("///</summary>");
            writer.WriteLine($"public event EventHandler<EventStreamEventReceivedArgs<{ev.TypeName}>> {ev.HandlerName}Received;");
            writer.WriteLine();
        }
    }

    private static void WriteConstructors(CodeWriter writer, string className, List<Entry> events)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Construct an instance");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public {className}(Stream stream) : this (stream, null)", () => { });
        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Construct an instance");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public {className}(Stream stream, IEventStreamDecoder eventStreamDecoder) : base(stream, eventStreamDecoder)", () =>
        {
            writer.WriteLine("base.EventReceived += (sender,args) => EventReceived?.Invoke(this, args);");
            writer.WriteLine("base.ExceptionReceived += (sender,args) => ExceptionReceived?.Invoke(this, args);");
            writer.WriteLine();
            writer.WriteLine("//Mapping the generic Event to more specific Events");
            writer.OpenBlock("Decoder.MessageReceived += (sender, args) =>", "};", () =>
            {
                writer.WriteLine("RuntimeEvent ev;");
                writer.OpenBlock("try", () =>
                {
                    writer.WriteLine("ev = ConvertMessageToEvent(args.Message);");
                });
                writer.OpenBlock("catch (UnknownEventStreamException)", () =>
                {
                    writer.WriteLine("""throw new UnknownEventStreamException("Received an unknown event stream type");""");
                });
                writer.WriteLine("EventReceived?.Invoke(this, new EventStreamEventReceivedArgs<RuntimeEvent>(ev));");
                writer.WriteLine();
                writer.WriteLine("// Call RaiseEvent until it returns true or all calls complete. This way only a subset of casts are performed");
                writer.WriteLine("// and we can avoid a cascade of nested if else statements. The result is thrown away");

                // The chain always starts with the initial response, then each event in model order.
                var chain = new List<string> { "RaiseEvent(InitialResponseReceived, ev)" };
                chain.AddRange(events.Select(ev => $"RaiseEvent({ev.HandlerName}Received,ev)"));
                writer.WriteLine("var _ =");
                for (var i = 0; i < chain.Count; i++)
                {
                    var suffix = i == chain.Count - 1 ? ";" : " ||";
                    writer.WriteLine($"{chain[i]}{suffix}");
                }
            });
        });
    }

    private static void WriteRaiseEvent(CodeWriter writer)
    {
        writer.OpenBlock("private bool RaiseEvent<T>(EventHandler<EventStreamEventReceivedArgs<T>> eventHandler, RuntimeEvent ev) where T : class, RuntimeEvent", () =>
        {
            writer.WriteLine("var convertedEvent = ev as T;");
            writer.OpenBlock("if (convertedEvent != null)", () =>
            {
                writer.WriteLine("eventHandler?.Invoke(this, new EventStreamEventReceivedArgs<T>(convertedEvent));");
                writer.WriteLine("return true;");
            });
            writer.WriteLine();
            writer.WriteLine("return false;");
        });
    }
}
