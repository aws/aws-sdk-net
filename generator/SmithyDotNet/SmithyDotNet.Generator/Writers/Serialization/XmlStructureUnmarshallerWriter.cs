using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source for a restXml structure unmarshaller — an <c>IXmlUnmarshaller</c> that reads a
/// nested shape out of the response XML with a <c>while (context.Read())</c> loop. Protocol-neutral XML
/// (the awsQuery task reuses it). Member dispatch is shared with the response and exception unmarshallers
/// via <see cref="XmlBodyMemberUnmarshaller"/>.
/// </summary>
public sealed class XmlStructureUnmarshallerWriter(GenerationContext context, string modelFileName)
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
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Response Unmarshaller for {className} Object");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {unmarshallerClassName} : IXmlUnmarshaller<{className}, XmlUnmarshallerContext>", () =>
            {
                WriteUnmarshallMethod(writer, className, structure, members);
                writer.WriteLine("");
                MarshallerCommon.WriteUnmarshallerSingleton(writer, unmarshallerClassName);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private static void WriteUnmarshallMethod(CodeWriter writer, string className, StructureShape structure, List<Member> members)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshall the response from the service to the response class.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("/// <returns>The unmarshalled object</returns>");
        writer.OpenBlock($"public {className} Unmarshall(XmlUnmarshallerContext context)", () =>
        {
            writer.WriteLine($"{className} unmarshalledObject = new {className}();");
            writer.WriteLine("int originalDepth = context.CurrentDepth;");
            writer.WriteLine("int targetDepth = originalDepth + 1;");
            // A nested structure read from the document root sits two elements below it (the response
            // wrapper and the member element), so the match depth is two deeper there. C2J parity.
            writer.OpenBlock("if (context.IsStartOfDocument)", () =>
            {
                writer.WriteLine("targetDepth += 2;");
            });
            writer.WriteLine("");
            writer.OpenBlock("while (context.Read())", () =>
            {
                writer.OpenBlock("if (context.IsStartElement || context.IsAttribute)", () =>
                {
                    if (members.Count > 0)
                    {
                        XmlBodyMemberUnmarshaller.WriteMemberBlocks(writer, structure, members, "targetDepth");
                    }
                });
                writer.OpenBlock("else if (context.IsEndElement && context.CurrentDepth < originalDepth)", () =>
                {
                    writer.WriteLine("return unmarshalledObject;");
                });
            });
            writer.WriteLine("");
            writer.WriteLine("return unmarshalledObject;");
        });
    }

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
        FileHeader.WriteUsings(writer, FileHeader.MarshallerUsings, false);
    }
}
