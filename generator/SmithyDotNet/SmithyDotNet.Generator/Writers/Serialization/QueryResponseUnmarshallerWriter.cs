using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Generation.Protocols;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source for an awsQuery response unmarshaller (an <c>XmlResponseUnmarshaller</c>). The
/// response XML nests a <c>{Operation}Result</c> element and a sibling <c>ResponseMetadata</c> (holding
/// <c>RequestId</c>) inside a <c>{Operation}Response</c> root, so the outer loop matches those two at
/// depth 2 — descending into the result to read the output members, and handing <c>ResponseMetadata</c>
/// to <c>ResponseMetadataUnmarshaller</c>. The member body read and the
/// error dispatch are the same XML machinery as restXml (<see cref="XmlBodyMemberUnmarshaller"/>,
/// <c>XmlErrorResponseUnmarshaller</c>); there are no HTTP binding reads. Mirrors C2J's
/// <c>AWSQueryResponseUnmarshaller.tt</c>.
/// </summary>
public sealed class QueryResponseUnmarshallerWriter(GenerationContext context, string modelFileName)
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
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Response Unmarshaller for {operation.Name} operation.");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {unmarshallerClassName} : XmlResponseUnmarshaller", () =>
            {
                WriteUnmarshallMethod(writer, className, operation);
                writer.WriteLine("");
                WriteUnmarshallResult(writer, className, operation, members);
                writer.WriteLine("");
                WriteUnmarshallExceptionMethod(writer, operation);
                writer.WriteLine("");
                MarshallerCommon.WriteResponseUnmarshallerSingleton(writer, unmarshallerClassName);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private static void WriteUnmarshallMethod(CodeWriter writer, string className, Operation operation)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshaller the response from the service to the response class.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)", () =>
        {
            writer.WriteLine($"{className} response = new {className}();");
            writer.WriteLine("");
            writer.WriteLine("context.Read();");
            writer.WriteLine("int targetDepth = context.CurrentDepth;");
            writer.OpenBlock("while (context.ReadAtDepth(targetDepth))", () =>
            {
                writer.OpenBlock("if (context.IsStartElement)", () =>
                {
                    writer.OpenBlock($"""if (context.TestExpression("{operation.Name}Result", 2))""", () =>
                    {
                        writer.WriteLine("UnmarshallResult(context, response);");
                        writer.WriteLine("continue;");
                    });
                    writer.WriteLine("");

                    writer.OpenBlock("""if (context.TestExpression("ResponseMetadata", 2))""", () =>
                    {
                        writer.WriteLine("response.ResponseMetadata = ResponseMetadataUnmarshaller.Instance.Unmarshall(context);");
                    });
                });
            });
            writer.WriteLine("");
            writer.WriteLine("return response;");
        });
    }

    // The {Operation}Result element's members, read with the shared XML body-member machinery into the
    // in-scope `unmarshalledObject` local (the name WriteMemberBlocks writes to). Depth handling matches
    // C2J: a result read from the document root sits two elements below it (the Response wrapper and the
    // Result element), hence targetDepth += 2 at the start of the document.
    private static void WriteUnmarshallResult(CodeWriter writer, string className, Operation operation, List<Member> members)
    {
        // An output with no members still gets the method and the dispatch to it (C2J parity): the Result
        // element is then consumed by this loop rather than the caller's. Its object parameter goes unused,
        // so the analyzer is suppressed exactly as C2J does.
        if (members.Count == 0)
        {
            writer.WriteLine("""[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "unmarshalledObject")]""");
        }
        writer.OpenBlock($"private static void UnmarshallResult(XmlUnmarshallerContext context, {className} unmarshalledObject)", () =>
        {
            writer.WriteLine("int originalDepth = context.CurrentDepth;");
            writer.WriteLine("int targetDepth = originalDepth + 1;");
            // A result read from the document root sits two elements below it (the Response wrapper and the
            // Result element). In the normal flow UnmarshallResult is entered already inside the Result
            // element, so this never fires; C2J emits it unconditionally and it is kept for parity.
            writer.OpenBlock("if (context.IsStartOfDocument)", () =>
            {
                writer.WriteLine("targetDepth += 2;");
            });
            writer.WriteLine("");
            // ReadAtDepth bounds the loop to the Result element's subtree: it stops as soon as the reader
            // rises above originalDepth, so the sibling <ResponseMetadata> is left for the outer loop.
            writer.OpenBlock("while (context.ReadAtDepth(originalDepth))", () =>
            {
                writer.OpenBlock("if (context.IsStartElement || context.IsAttribute)", () =>
                {
                    XmlBodyMemberUnmarshaller.WriteMemberBlocks(writer, operation.Output, members, "targetDepth", AWSProtocol.AwsQuery);
                });
            });
            writer.WriteLine("");
            writer.WriteLine("return;");
        });
    }

    private void WriteUnmarshallExceptionMethod(CodeWriter writer, Operation operation)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshall error response to exception.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)", () =>
        {
            writer.WriteLine("ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);");
            writer.WriteLine("errorResponse.InnerException = innerException;");
            writer.WriteLine("errorResponse.StatusCode = statusCode;");
            writer.WriteLine("");
            writer.WriteLine("var responseBodyBytes = context.GetResponseBodyBytes();");
            writer.WriteLine("");
            writer.OpenBlock("using (var streamCopy = new MemoryStream(responseBodyBytes))", "}", () =>
            {
                writer.OpenBlock("using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, context.ResponseData))", "}", () =>
                {
                    foreach (var error in operation.Errors)
                    {
                        var exceptionClassName = ExceptionWriter.ToExceptionName(context.ToDotNetName(error.Id));
                        // @awsQueryError overrides the wire Code the client dispatches on (else the shape name).
                        var dispatchCode = error.GetAwsQueryError()?.Code ?? error.Id.Name;
                        writer.OpenBlock($"""if (errorResponse.Code != null && errorResponse.Code.Equals("{dispatchCode}"))""", () =>
                        {
                            writer.WriteLine($"return {exceptionClassName}Unmarshaller.Instance.Unmarshall(contextCopy, errorResponse);");
                        });
                    }
                });
            });
            writer.WriteLine($"return new Amazon{context.BaseName}Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);");
        });
    }

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
        FileHeader.WriteUsings(writer, FileHeader.MarshallerUsings, false);
    }
}
