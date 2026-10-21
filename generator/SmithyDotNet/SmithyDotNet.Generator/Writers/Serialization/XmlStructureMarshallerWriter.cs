using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source for a restXml structure marshaller: an <c>IRequestMarshaller</c> over
/// <c>XmlMarshallerContext</c> that writes one nested structure's members into the open XML element.
/// Member codegen is shared with the operation request body via
/// <see cref="XmlBodyMemberMarshaller.WriteStructureBody"/>; a nested structure member dispatches to its
/// own <c>{Shape}Marshaller.Instance</c>, so the tree is assembled from one marshaller per structure
/// (parallel to the JSON/CBOR writers) rather than inlined.
/// </summary>
public sealed class XmlStructureMarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(StructureShape structure, CancellationToken cancellationToken = default)
    {
        var className = context.ToDotNetName(structure.Id);
        var marshallerClassName = context.StructureMarshallerName(structure.Id);
        var members = TypeMapper.ResolveMembers(structure, context);
        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// {className} Marshaller");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {marshallerClassName} : IRequestMarshaller<{className}, XmlMarshallerContext>", () =>
            {
                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// Marshall the structure from the request object to the service");
                writer.WriteLine("/// </summary>");
                writer.OpenBlock($"public void Marshall({className} requestObject, XmlMarshallerContext context)", () =>
                {
                    writer.WriteLine("if (requestObject == null) return;");
                    writer.WriteLine("");
                    XmlBodyMemberMarshaller.WriteStructureBody(writer, structure, members, "requestObject");
                });
                writer.WriteLine("");
                MarshallerCommon.WriteStructureMarshallerSingleton(writer, marshallerClassName);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.XmlRequestMarshallerUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
    }
}
