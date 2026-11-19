using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source for a JSON structure unmarshaller matching the public API surface
/// of the existing AWS SDK for .NET.
/// <para />
/// Member codegen is shared with the operation response body via
/// <see cref="JsonBodyMemberUnmarshaller.WriteMemberUnmarshallers"/>: scalars, nested structures,
/// and lists of strings or structures. A map member throws a <see cref="GeneratorException"/>.
/// <para />
/// An event structure (a member of a <c>@streaming</c> union) classifies each member by binding,
/// symmetric with the marshaller: a <c>@eventPayload</c> member is the raw message payload (blob → the
/// <c>MemoryStream</c>, string → the stream read to end, structure → its own unmarshaller off the reader),
/// a <c>@eventHeader</c> member is read from an event-message header, and any remaining unbound member is
/// read from the JSON body. The three partitions are disjoint and independent: an event can carry headers
/// with no explicit payload (the unbound members are still the JSON body), or headers only.
/// </summary>
public sealed class JsonStructureUnmarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(StructureShape structure, CancellationToken cancellationToken = default)
    {
        var className = context.ToDotNetName(structure.Id);
        var unmarshallerClassName = context.StructureUnmarshallerName(structure.Id);
        var members = TypeMapper.ResolveMembers(structure, context);
        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            WriteClassDocumentation(writer, className);
            writer.OpenBlock($"public partial class {unmarshallerClassName} : IJsonUnmarshaller<{className}, JsonUnmarshallerContext>", () =>
            {
                WriteUnmarshallMethod(writer, className, structure, members);
                writer.WriteLine("");
                MarshallerCommon.WriteUnmarshallerSingleton(writer, unmarshallerClassName);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
        FileHeader.WriteUsings(writer, FileHeader.MarshallerUsings, false);
        writer.WriteLine("using System.Text.Json;");
    }

    private static void WriteClassDocumentation(CodeWriter writer, string className)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Response Unmarshaller for {className} Object");
        writer.WriteLine("/// </summary>");
    }

    private void WriteUnmarshallMethod(CodeWriter writer, string className, StructureShape structure, List<Member> members)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshall the response from the service to the response class.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("/// <returns>The unmarshalled object</returns>");
        writer.OpenBlock($"public {className} Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)", () =>
        {
            writer.WriteLine($"var unmarshalledObject = new {className}();");
            writer.WriteLine("if (context.IsEmptyResponse) return null;");
            writer.WriteLine();

            // Classify each member by binding, symmetric with the marshaller: @eventPayload → raw stream,
            // @eventHeader → message header, unbound → JSON body. A member carries at most one event trait
            // (Smithy forbids both), so the partitions are disjoint. An event can carry @eventHeader members
            // without an @eventPayload member; those are still read from headers, not the JSON body — the
            // absence of @eventPayload does not mean the absence of headers.
            var isEvent = context.ResponseEventStreams.Any(stream => stream.Events.Contains(structure.Id));
            var payloadMember = members.SingleOrDefault(m => m.IsEventPayload);
            var headerMembers = members.Where(m => m.IsEventHeader).ToList();
            var bodyMembers = members.Where(m => !m.IsEventPayload && !m.IsEventHeader).ToList();

            // Payload first: an explicit structure payload advances the JSON reader, so it runs before the
            // body loop (which the SEP guarantees is empty when a payload exists) and the header reads.
            if (payloadMember is not null)
            {
                MarshallerCommon.WriteEventPayloadMember(writer, payloadMember, "context, ref reader", "!(context.Stream is MemoryStream { Length: 0 })");
            }
            foreach (var member in headerMembers)
            {
                MarshallerCommon.WriteEventHeaderUnmarshall(writer, member);
            }

            // Only an event skips the body loop (explicit payload, or headers alone). A member-less ordinary
            // structure still runs it to consume its {} tokens so the reader lands after the object.
            if (payloadMember is null && (!isEvent || headerMembers.Count == 0 || bodyMembers.Count > 0))
            {
                // An event with no body members may arrive with an empty payload; it is the empty structure.
                if (isEvent && bodyMembers.Count == 0)
                {
                    writer.WriteLine("if (context.Stream is MemoryStream { Length: 0 }) return unmarshalledObject;");
                }
                WriteBodyUnmarshall(writer, bodyMembers);
            }

            writer.WriteLine("return unmarshalledObject;");
        });
    }

    private static void WriteBodyUnmarshall(CodeWriter writer, List<Member> members)
    {
        writer.WriteLine("context.Read(ref reader);");
        writer.WriteLine("if (context.CurrentTokenType == JsonTokenType.Null) return null;");
        writer.WriteLine("");
        writer.WriteLine("int targetDepth = context.CurrentDepth;");
        writer.OpenBlock("while (context.ReadAtDepth(targetDepth, ref reader))", () =>
        {
            JsonBodyMemberUnmarshaller.WriteMemberUnmarshallers(writer, members);
        });
    }

}
