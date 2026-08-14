using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for a JSON structure unmarshaller matching the public API surface
/// of the existing AWS SDK for .NET.
/// <para />
/// Phase 1 scope: Structures whose members all resolve to <c>string</c>. Any other member type
/// throws a <see cref="GeneratorException"/>.
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
            writer.WriteLine($"{className} unmarshalledObject = new {className}();");
            writer.WriteLine("if (context.IsEmptyResponse) return null;");
            writer.WriteLine();
            writer.WriteLine("context.Read(ref reader);");
            writer.WriteLine("if (context.CurrentTokenType == JsonTokenType.Null) return null;");
            writer.WriteLine("");
            writer.WriteLine("int targetDepth = context.CurrentDepth;");
            writer.OpenBlock("while (context.ReadAtDepth(targetDepth, ref reader))", () =>
            {
                WriteMemberUnmarshallers(writer, members);
            });
            writer.WriteLine("return unmarshalledObject;");
        });
    }

    private static void WriteMemberUnmarshallers(CodeWriter writer, List<Member> members)
    {
        for (int i = 0; i < members.Count; i++)
        {
            var member = members[i];
            var scalarUnmarshaller = JsonResponseUnmarshallerWriter.ScalarUnmarshaller(member.MarshalType)
                ?? throw new GeneratorException($"Only scalar members are handled currently. Member '{member.ModeledName}' resolved to '{member.DotNetType}'.");

            var wireName = member.JsonName ?? member.ModeledName;
            writer.OpenBlock($"""if (context.TestExpression("{wireName}", targetDepth, ref reader))""", () =>
            {
                writer.WriteLine($"var unmarshaller = {scalarUnmarshaller}.Instance;");
                writer.WriteLine($"unmarshalledObject.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
                writer.WriteLine("continue;");
            });

            if (i < members.Count - 1)
            {
                writer.WriteLine();
            }
        }
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
