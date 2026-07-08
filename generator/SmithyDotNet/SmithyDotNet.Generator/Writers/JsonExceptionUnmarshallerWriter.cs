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

        var members = TypeMapper.ResolveMembers(structure, context);

        // message doesn't need its own deserialization because it is deserialized by JsonErrorResponseUnmarshaller already. All the error shapes 
        // today that have a message member do not deserialize it, so we skip that member and pass in all other members.
        var nonMessageMembers = members
            .Where(m => !m.ModeledName.Equals("message", StringComparison.OrdinalIgnoreCase))
            .ToList();
        if (nonMessageMembers.Count > 0)
        {
            var names = string.Join(", ", nonMessageMembers.Select(m => m.ModeledName));
            throw new GeneratorException($"Exception '{shapeId.Name}' carries members beyond 'message' ({names}), which are not yet supported by {nameof(JsonExceptionUnmarshallerWriter)}.");
        }

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
                WriteMainUnmarshallMethod(writer, exceptionName, nonMessageMembers);
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

    // members currently holds only "message" (Write rejects anything else); it is threaded through
    // so member unmarshallers can be emitted inside the read loop once extra fields are supported.
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

    // only support what the JsonResponseUnmarshaller supports for now, and fail loudly for any other types.
    private static void WriteMemberUnmarshaller(CodeWriter writer, Member member)
    {
        writer.OpenBlock($"if (context.TestExpression(\"{member.ModeledName}\", targetDepth, ref reader))", () =>
        {
            if (member.DotNetType == "string")
            {
                writer.WriteLine("var unmarshaller = StringUnmarshaller.Instance;");
                writer.WriteLine($"unmarshalledObject.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
                writer.WriteLine("continue;");
            }
            else if (member.IsCollection && member.IsElementStructure)
            {
                var elementType = member.ElementType ?? throw new GeneratorException($"List member '{member.PropertyName}' has no element type.");
                var unmarshallerType = $"{elementType}Unmarshaller";
                writer.WriteLine($"var unmarshaller = new JsonListUnmarshaller<{elementType}, {unmarshallerType}>({unmarshallerType}.Instance);");
                writer.WriteLine($"unmarshalledObject.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
            }
            else if (member.IsStructure)
            {
                var unmarshallerType = $"{member.DotNetType}Unmarshaller";
                writer.WriteLine($"var unmarshaller = {unmarshallerType}.Instance;");
                writer.WriteLine($"unmarshalledObject.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
            }
            else
            {
                throw new GeneratorException($"Unsupported response member type '{member.DotNetType}' for member '{member.PropertyName}'.");
            }
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
