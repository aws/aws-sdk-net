using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// rpcv2Cbor structure unmarshaller: a null check, then the map read loop.
/// </summary>
public sealed class CborStructureUnmarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(StructureShape structure, CancellationToken cancellationToken = default)
    {
        var className = context.ToDotNetName(structure.Id);
        var members = TypeMapper.ResolveMembers(structure, context);
        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        CborResponseUnmarshallerWriter.WriteUsings(writer, context);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Response Unmarshaller for {className} Object");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {className}Unmarshaller : ICborUnmarshaller<{className}, CborUnmarshallerContext>", () =>
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
                    writer.WriteLine("var reader = context.Reader;");
                    writer.OpenBlock("if (reader.PeekState() == CborReaderState.Null)", () =>
                    {
                        writer.WriteLine("reader.ReadNull();");
                        writer.WriteLine("return null;");
                    });
                    writer.WriteLine("");

                    // Always read the map, even with no members, so the value is consumed for the enclosing loop.
                    CborBodyMemberUnmarshaller.WriteMapReadLoop(writer, members);
                    writer.WriteLine("return unmarshalledObject;");
                });
                writer.WriteLine("");
                MarshallerCommon.WriteUnmarshallerSingleton(writer, $"{className}Unmarshaller");
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }
}
