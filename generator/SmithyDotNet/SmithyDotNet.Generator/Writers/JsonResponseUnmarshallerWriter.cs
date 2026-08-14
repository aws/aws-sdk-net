using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for a JSON response unmarshaller matching the public API surface
/// of the existing AWS SDK for .NET.
/// </summary>
public sealed class JsonResponseUnmarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Response";
        var unmarshallerClassName = $"{className}Unmarshaller";
        var members = TypeMapper.ResolveMembers(operation.Output, context);

        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            WriteClassDocumentation(writer, operation.Name);
            writer.OpenBlock($"public partial class {unmarshallerClassName} : JsonResponseUnmarshaller", () =>
            {
                WriteUnmarshallMethod(writer, className, members);
                writer.WriteLine("");
                WriteUnmarshallExceptionMethod(writer, operation);
                writer.WriteLine("");
                WriteSingleton(writer, unmarshallerClassName);
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
        writer.WriteLine("using Amazon.Util;");
    }

    private static void WriteClassDocumentation(CodeWriter writer, string operationName)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Response Unmarshaller for {operationName} operation.");
        writer.WriteLine("/// </summary>");
    }

    private static void WriteUnmarshallMethod(CodeWriter writer, string className, List<Member> members)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshaller the response from the service to the response class.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)", () =>
        {
            writer.WriteLine($"{className} response = new {className}();");
            writer.WriteLine("StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);");
            writer.WriteLine();
            writer.WriteLine("context.Read(ref reader);");
            writer.WriteLine("int targetDepth = context.CurrentDepth;");
            writer.OpenBlock("while (context.ReadAtDepth(targetDepth, ref reader))", () =>
            {
                WriteMemberUnmarshallers(writer, members);
            });
            writer.WriteLine("");
            writer.WriteLine("return response;");
        });
    }

    private static void WriteMemberUnmarshallers(CodeWriter writer, List<Member> members)
    {
        for (int i = 0; i < members.Count; i++)
        {
            var member = members[i];
            var wireName = member.JsonName ?? member.ModeledName;

            writer.OpenBlock($"""if (context.TestExpression("{wireName}", targetDepth, ref reader))""", () =>
            {
                WriteMemberUnmarshall(writer, member, "response");
                writer.WriteLine("continue;");
            });

            if (i < members.Count - 1)
            {
                writer.WriteLine();
            }
        }
    }

    /// <summary>
    /// The runtime <c>Amazon.Runtime.Internal.Transform</c> unmarshaller type for a member's
    /// <see cref="Member.MarshalType"/> (the .NET type for plain scalars; <c>string</c> for enums, so an
    /// enum member unmarshals via <c>StringUnmarshaller</c> and the implicit string-to-ConstantClass
    /// conversion), or null when the type is not a supported scalar. Timestamps follow the JSON-protocol
    /// default (epoch seconds via the nullable <c>DateTime</c> unmarshaller).
    /// </summary>
    internal static string? ScalarUnmarshaller(string marshalType) => marshalType switch
    {
        "string" => "StringUnmarshaller",
        "bool?" => "NullableBoolUnmarshaller",
        "int?" => "NullableIntUnmarshaller",
        "long?" => "NullableLongUnmarshaller",
        "float?" => "NullableFloatUnmarshaller",
        "double?" => "NullableDoubleUnmarshaller",
        "DateTime?" => "NullableDateTimeUnmarshaller",
        _ => null,
    };

    // Scalar / list-of-structure / structure dispatch shared with the exception unmarshaller;
    // <paramref name="target"/> is the local being populated ("response" or "unmarshalledObject").
    // Only types used by CloudTrailData and the supported scalars are handled for now.
    internal static void WriteMemberUnmarshall(CodeWriter writer, Member member, string target)
    {
        if (ScalarUnmarshaller(member.MarshalType) is string scalarUnmarshaller)
        {
            writer.WriteLine($"var unmarshaller = {scalarUnmarshaller}.Instance;");
            writer.WriteLine($"{target}.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
        }
        else if (member.IsCollection && member.IsElementStructure)
        {
            var elementType = member.ElementType ?? throw new GeneratorException($"List member '{member.PropertyName}' has no element type.");
            var unmarshallerType = $"{elementType}Unmarshaller";
            writer.WriteLine($"var unmarshaller = new JsonListUnmarshaller<{elementType}, {unmarshallerType}>({unmarshallerType}.Instance);");
            writer.WriteLine($"{target}.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
        }
        else if (member.IsStructure)
        {
            var unmarshallerType = $"{member.DotNetType}Unmarshaller";
            writer.WriteLine($"var unmarshaller = {unmarshallerType}.Instance;");
            writer.WriteLine($"{target}.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
        }
        else
        {
            throw new GeneratorException($"Unsupported member type '{member.DotNetType}' for member '{member.PropertyName}'.");
        }
    }

    private void WriteUnmarshallExceptionMethod(CodeWriter writer, Operation operation)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshall error response to exception.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)", () =>
        {
            writer.WriteLine("StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);");
            writer.WriteLine("var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);");
            writer.WriteLine();
            writer.WriteLine("errorResponse.InnerException = innerException;");
            writer.WriteLine("errorResponse.StatusCode = statusCode;");
            writer.WriteLine("");
            writer.WriteLine("var responseBodyBytes = context.GetResponseBodyBytes();");
            writer.WriteLine("");

            writer.OpenBlock("using (var streamCopy = new MemoryStream(responseBodyBytes))", "}", () =>
            {
                writer.OpenBlock("using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))", "}", () =>
                {
                    writer.WriteLine("StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);");

                    foreach (var error in operation.Errors)
                    {
                        var errorShapeName = error.Id.Name;
                        var exceptionClassName = ExceptionWriter.ToExceptionName(errorShapeName);
                        writer.OpenBlock($"""if (errorResponse.Code != null && errorResponse.Code.Equals("{errorShapeName}"))""", () =>
                        {
                            writer.WriteLine($"return {exceptionClassName}Unmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);");
                        });
                    }
                });
            });

            writer.WriteLine($"return new Amazon{context.ServiceName}Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);");
        });
    }

    private static void WriteSingleton(CodeWriter writer, string unmarshallerClassName)
    {
        writer.WriteLine($"private static {unmarshallerClassName} _instance = new {unmarshallerClassName}();");
        writer.WriteLine("");
        writer.WriteLine($"internal static {unmarshallerClassName} GetInstance() => _instance;");
        writer.WriteLine("");
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Gets the singleton.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public static {unmarshallerClassName} Instance => _instance;");
    }
}
