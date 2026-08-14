using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for a JSON error-response (exception) unmarshaller matching the public
/// API surface of the existing AWS SDK for .NET.
/// </summary>
public sealed class JsonExceptionUnmarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(StructureShape structure, ShapeId shapeId, CancellationToken cancellationToken = default)
    {
        var exceptionName = ExceptionWriter.ToExceptionName(shapeId.Name);
        var unmarshallerClassName = $"{exceptionName}Unmarshaller";

        // message is deserialized by JsonErrorResponseUnmarshaller into the base Exception.Message,
        // so it is excluded here; every other member — including base-owned RequestId/ErrorCode — is
        // unmarshalled from the error body.
        var members = ExceptionWriter.ResolveSerializedMembers(structure, context);

        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            WriteClassDocumentation(writer, exceptionName);
            writer.OpenBlock($"public partial class {unmarshallerClassName} : IJsonErrorResponseUnmarshaller<{exceptionName}, JsonUnmarshallerContext>", () =>
            {
                WriteUnmarshallMethod(writer, exceptionName);
                writer.WriteLine("");
                WriteMainUnmarshallMethod(writer, exceptionName, members);
                writer.WriteLine("");
                WriteSingleton(writer, unmarshallerClassName);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.ExceptionUnmarshallerUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
        writer.WriteLine("using Amazon.Runtime;");
        writer.WriteLine("using Amazon.Runtime.Internal;");
        FileHeader.WriteUsings(writer, FileHeader.MarshallerUsings, false);
        writer.WriteLine("using System.Text.Json;");
        writer.WriteLine("using Amazon.Util;");
    }

    private static void WriteClassDocumentation(CodeWriter writer, string exceptionName)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Exception Unmarshaller for {exceptionName}");
        writer.WriteLine("/// </summary>");
    }

    private static void WriteUnmarshallMethod(CodeWriter writer, string exceptionName)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshall the exception from the service to the appropriate exception class");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public {exceptionName} Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)", () =>
        {
            writer.WriteLine("return this.Unmarshall(context, new Amazon.Runtime.Internal.ErrorResponse(), ref reader);");
        });
    }

    private static void WriteMainUnmarshallMethod(CodeWriter writer, string exceptionName, List<Member> members)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshall the exception from the service to the appropriate exception class");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public {exceptionName} Unmarshall(JsonUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse, ref StreamingUtf8JsonReader reader)", () =>
        {
            writer.OpenBlock("if (context.Stream.Length > 0)", () =>
            {
                writer.WriteLine("context.Read(ref reader);");
            });
            writer.WriteLine();
            writer.WriteLine($"{exceptionName} unmarshalledObject = new {exceptionName}(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);");
            writer.WriteLine();
            writer.WriteLine("int targetDepth = context.CurrentDepth;");
            writer.OpenBlock("if (context.Stream.Length > 0)", () =>
            {
                writer.OpenBlock("while (context.ReadAtDepth(targetDepth, ref reader))", () =>
                {
                    foreach (var member in members)
                    {
                        WriteMemberUnmarshaller(writer, member);
                    }
                });
            });
            writer.WriteLine();
            writer.WriteLine("return unmarshalledObject;");
        });
    }

    // Reuses JsonResponseUnmarshallerWriter's member dispatch, writing into unmarshalledObject. Each
    // arm ends in `continue;` so the read loop advances to the next field, matching the legacy template.
    private static void WriteMemberUnmarshaller(CodeWriter writer, Member member)
    {
        var wireName = member.JsonName ?? member.ModeledName;
        writer.OpenBlock($"""if (context.TestExpression("{wireName}", targetDepth, ref reader))""", () =>
        {
            JsonResponseUnmarshallerWriter.WriteMemberUnmarshall(writer, member, "unmarshalledObject");
            writer.WriteLine("continue;");
        });
    }

    private static void WriteSingleton(CodeWriter writer, string unmarshallerClassName)
    {
        writer.WriteLine($"private static {unmarshallerClassName} _instance = new {unmarshallerClassName}();");
        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Gets the singleton.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public static {unmarshallerClassName} Instance => _instance;");
    }
}
