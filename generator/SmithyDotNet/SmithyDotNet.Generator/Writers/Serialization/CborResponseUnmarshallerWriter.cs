using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Writers.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// rpcv2Cbor response unmarshaller: the output read as a CBOR map, errors dispatched on the shape name.
/// </summary>
public sealed class CborResponseUnmarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Response";
        var unmarshallerClassName = $"{className}Unmarshaller";
        var members = TypeMapper.ResolveMembers(operation.Output, context);
        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer, context);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Response Unmarshaller for {operation.Name} operation.");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {unmarshallerClassName} : CborResponseUnmarshaller", () =>
            {
                WriteUnmarshallMethod(writer, className, operation.Name, members);
                writer.WriteLine("");
                WriteUnmarshallExceptionMethod(writer, operation);
                writer.WriteLine("");
                MarshallerCommon.WriteResponseUnmarshallerSingleton(writer, unmarshallerClassName);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    internal static void WriteUsings(CodeWriter writer, GenerationContext context)
    {
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
        FileHeader.WriteUsings(writer, FileHeader.MarshallerUsings, false);
        FileHeader.WriteUsings(writer, FileHeader.CborUnmarshallerUsings);
    }

    // A response with no members (Unit output included) reads nothing.
    // TODO: a response event stream is assigned with MarshallerCommon.WriteEventStreamMember and the class overrides
    // HasStreamingProperty/ShouldReadEntireResponse, as the JSON writer does.
    private static void WriteUnmarshallMethod(CodeWriter writer, string className, string operationName, List<Member> members)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshaller the response from the service to the response class.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)", () =>
        {
            writer.WriteLine($"var unmarshalledObject = new {className}();");
            if (members.Count > 0)
            {
                writer.WriteLine("var reader = context.Reader;");
                writer.WriteLine();
                writer.WriteLine($"""context.AddPathSegment("{operationName}");""");
                CborBodyMemberUnmarshaller.WriteMapReadLoop(writer, members);
                writer.WriteLine("context.PopPathSegment();");
            }
            writer.WriteLine("");
            writer.WriteLine("return unmarshalledObject;");
        });
    }

    private void WriteUnmarshallExceptionMethod(CodeWriter writer, Operation operation)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshall error response to exception.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public override AmazonServiceException UnmarshallException(CborUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)", () =>
        {
            writer.WriteLine("var errorResponse = CborErrorResponseUnmarshaller.GetInstance().Unmarshall(context);");
            writer.WriteLine("errorResponse.InnerException = innerException;");
            writer.WriteLine("errorResponse.StatusCode = statusCode;");
            writer.WriteLine("");
            writer.WriteLine("var responseBodyBytes = context.GetResponseBodyBytes();");
            writer.WriteLine("");
            writer.OpenBlock("using (var streamCopy = new MemoryStream(responseBodyBytes))", "}", () =>
            {
                writer.OpenBlock($"using (var contextCopy = new CborUnmarshallerContext(streamCopy, {AwsQueryCompatibleMarshalling.MaintainResponseBody(context)}, context.ResponseData))", "}", () =>
                {
                    var errorCode = AwsQueryCompatibleMarshalling.WriteErrorCodeSource(writer, context);
                    foreach (var error in operation.Errors)
                    {
                        // The wire code is the shape name even when the service renames the shape.
                        var exceptionClassName = ExceptionWriter.ToExceptionName(context.ToDotNetName(error.Id));
                        writer.OpenBlock($"""if ({errorCode} != null && {errorCode}.Equals("{error.Id.Name}"))""", () =>
                        {
                            writer.WriteLine($"return {exceptionClassName}Unmarshaller.Instance.Unmarshall(contextCopy, errorResponse);");
                        });
                    }
                });
            });
            writer.WriteLine($"return new Amazon{context.BaseName}Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);");
        });
    }
}
