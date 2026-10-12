using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// rpcv2Cbor structure unmarshaller: a null check, then the map read loop. An event (a member of a
/// <c>@streaming</c> union) partitions its members as the JSON writer does: an explicit <c>@eventPayload</c> is
/// the raw message payload and the remaining members are the CBOR body.
/// </summary>
public sealed class CborStructureUnmarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(StructureShape structure, CancellationToken cancellationToken = default)
    {
        var className = context.ToDotNetName(structure.Id);
        var unmarshallerClassName = context.StructureUnmarshallerName(structure.Id);
        var members = TypeMapper.ResolveMembers(structure, context);

        // A CBOR event is decoded without its message headers, so an @eventHeader has nothing to read from.
        if (members.Any(member => member.IsEventHeader))
        {
            throw new GeneratorException($"@eventHeader on '{className}' is not supported on rpcv2Cbor.");
        }
        var payloadMember = members.SingleOrDefault(member => member.IsEventPayload);

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
                        MarshallerCommon.WriteEventPayloadMember(writer, payloadMember, "context");
                    }
                    else
                    {
                        writer.WriteLine("var reader = context.Reader;");
                        writer.OpenBlock("if (reader.PeekState() == CborReaderState.Null)", () =>
                        {
                            writer.WriteLine("reader.ReadNull();");
                            writer.WriteLine("return null;");
                        });
                        writer.WriteLine("");

                        // Always read the map, even with no members, so the value is consumed for the enclosing loop.
                        CborBodyMemberUnmarshaller.WriteMapReadLoop(writer, members);
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
