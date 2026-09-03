using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source for a JSON structure unmarshaller matching the public API surface
/// of the existing AWS SDK for .NET.
/// <para />
/// Member codegen is shared with the operation response body via
/// <see cref="JsonBodyMemberUnmarshaller.WriteMemberUnmarshallers"/>: scalars, nested structures,
/// and lists of strings or structures. A map member throws a <see cref="GeneratorException"/>.
/// </summary>
public sealed class JsonStructureUnmarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(StructureShape structure, ShapeId shapeId, CancellationToken cancellationToken = default)
    {
        var className = context.ToDotNetName(shapeId);
        var members = TypeMapper.ResolveMembers(structure, context);
        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            WriteClassDocumentation(writer, className);
            writer.OpenBlock($"public partial class {className}Unmarshaller : IJsonUnmarshaller<{className}, JsonUnmarshallerContext>", () =>
            {
                WriteUnmarshallMethod(writer, className, members);
                writer.WriteLine("");
                WriteSingleton(writer, className);
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

    private static void WriteUnmarshallMethod(CodeWriter writer, string className, List<Member> members)
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
            writer.WriteLine("context.Read(ref reader);");
            writer.WriteLine("if (context.CurrentTokenType == JsonTokenType.Null) return null;");
            writer.WriteLine("");
            writer.WriteLine("int targetDepth = context.CurrentDepth;");
            writer.OpenBlock("while (context.ReadAtDepth(targetDepth, ref reader))", () =>
            {
                JsonBodyMemberUnmarshaller.WriteMemberUnmarshallers(writer, members);
            });
            writer.WriteLine("return unmarshalledObject;");
        });
    }

    private static void WriteSingleton(CodeWriter writer, string className)
    {
        writer.WriteLine($"private static {className}Unmarshaller _instance = new {className}Unmarshaller();");
        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Gets the singleton.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public static {className}Unmarshaller Instance => _instance;");
    }
}
