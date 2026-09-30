using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// rpcv2Cbor structure marshaller: writes the members into the map the caller opened.
/// </summary>
public sealed class CborStructureMarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(StructureShape structure, CancellationToken cancellationToken = default)
    {
        var className = context.ToDotNetName(structure.Id);
        var members = TypeMapper.ResolveMembers(structure, context);
        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
        FileHeader.WriteUsings(writer, FileHeader.MarshallerUsings, false);
        FileHeader.WriteUsings(writer, FileHeader.CborMarshallerUsings);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// {className} Marshaller");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {className}Marshaller : IRequestMarshaller<{className}, CborMarshallerContext>", () =>
            {
                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// Marshall the structure from the request object to the service");
                writer.WriteLine("/// </summary>");
                writer.OpenBlock($"public void Marshall({className} requestObject, CborMarshallerContext context)", () =>
                {
                    writer.WriteLine("if (requestObject == null) return;");
                    writer.WriteLine("");
                    for (int i = 0; i < members.Count; i++)
                    {
                        CborBodyMemberMarshaller.WriteBodyMember(writer, members[i], "requestObject");
                        if (i < members.Count - 1)
                        {
                            writer.WriteLine("");
                        }
                    }
                });
                writer.WriteLine("");
                MarshallerCommon.WriteStructureMarshallerSingleton(writer, className);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }
}
