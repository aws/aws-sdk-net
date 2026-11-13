using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// rpcv2Cbor structure unmarshaller: a null check, then the map read loop. An event (a member of a
/// <c>@streaming</c> union) partitions its members as the JSON writer does: an explicit <c>@eventPayload</c> is
/// the raw message payload, <c>@eventHeader</c> members come from the message headers and the rest is the CBOR body.
/// </summary>
public sealed class CborStructureUnmarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(StructureShape structure, CancellationToken cancellationToken = default)
    {
        var className = context.ToDotNetName(structure.Id);
        var unmarshallerClassName = context.StructureUnmarshallerName(structure.Id);
        var members = TypeMapper.ResolveMembers(structure, context);

        var isEvent = context.ResponseEventStreams.Any(stream => stream.Events.Contains(structure.Id));
        var payloadMember = members.SingleOrDefault(member => member.IsEventPayload);
        var headerMembers = members.Where(member => member.IsEventHeader).ToList();
        var bodyMembers = members.Where(member => !member.IsEventPayload && !member.IsEventHeader).ToList();

        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        CborResponseUnmarshallerWriter.WriteUsings(writer, context);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Response Unmarshaller for {className} Object");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {unmarshallerClassName} : ICborUnmarshaller<{className}, CborUnmarshallerContext>", () =>
            {
                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// Unmarshall the response from the service to the response class.");
                writer.WriteLine("/// </summary>");
                writer.WriteLine("/// <returns>The unmarshalled object</returns>");
                writer.OpenBlock($"public {className} Unmarshall(CborUnmarshallerContext context)", () =>
                {
                    writer.WriteLine($"var unmarshalledObject = new {className}();");
                    writer.WriteLine("if (context.IsEmptyResponse) return null;");
                    writer.WriteLine();

                    if (payloadMember is not null)
                    {
                        MarshallerCommon.WriteEventPayloadMember(writer, payloadMember, "context", "context.Reader.PeekState() != CborReaderState.Finished");
                    }

                    foreach (var member in headerMembers)
                    {
                        MarshallerCommon.WriteEventHeaderUnmarshall(writer, member);
                    }

                    // Only an event skips the map read (explicit payload, or headers alone). A member-less ordinary
                    // structure still reads its map so the value is consumed for the enclosing loop.
                    if (payloadMember is null && (!isEvent || headerMembers.Count == 0 || bodyMembers.Count > 0))
                    {
                        writer.WriteLine("var reader = context.Reader;");
                        // An event with no body members may arrive with an empty payload; it is the empty structure.
                        if (isEvent && bodyMembers.Count == 0)
                        {
                            writer.WriteLine("if (reader.PeekState() == CborReaderState.Finished) return unmarshalledObject;");
                        }
                        writer.OpenBlock("if (reader.PeekState() == CborReaderState.Null)", () =>
                        {
                            writer.WriteLine("reader.ReadNull();");
                            writer.WriteLine("return null;");
                        });
                        writer.WriteLine("");

                        CborBodyMemberUnmarshaller.WriteMapReadLoop(writer, bodyMembers);
                    }
                    writer.WriteLine("return unmarshalledObject;");
                });
                writer.WriteLine("");
                MarshallerCommon.WriteUnmarshallerSingleton(writer, unmarshallerClassName);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }
}
