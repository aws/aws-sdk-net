using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Generation.Protocols;
using SmithyDotNet.Generator.Model.Shapes;
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
/// <para/>
/// ec2Query has no <c>Result</c> element and no <c>ResponseMetadata</c>: the output members sit directly under
/// the <c>{Operation}Response</c> root, read by an <c>EC2ResponseUnmarshaller</c> (which takes the request id),
/// and a modeled error is constructed straight from the error envelope. Mirrors C2J's
/// <c>AWSQueryEC2ResponseUnmarshaller.tt</c>.
/// </summary>
public sealed class QueryResponseUnmarshallerWriter(GenerationContext context, string modelFileName)
{
    private const string ErrorEnvelopeArguments = "errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode";

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
            var isEc2 = context.Protocol == AWSProtocol.Ec2Query;
            writer.OpenBlock($"public partial class {unmarshallerClassName} : {(isEc2 ? "EC2ResponseUnmarshaller" : "XmlResponseUnmarshaller")}", () =>
            {
                if (isEc2)
                {
                    WriteUnmarshallResult(writer, className, operation, members);
                    writer.WriteLine("");
                    WriteEc2UnmarshallExceptionMethod(writer, operation);
                }
                else
                {
                    WriteUnmarshallMethod(writer, className, operation);
                    writer.WriteLine("");
                    WriteUnmarshallResult(writer, className, operation, members);
                    writer.WriteLine("");
                    WriteUnmarshallExceptionMethod(writer, operation);
                }
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

    // The output members, read with the shared XML body-member machinery into the in-scope `unmarshalledObject`
    // local (the name WriteMemberBlocks writes to). awsQuery reads them in UnmarshallResult, entered inside the
    // {Operation}Result element; ec2Query has no Result element, so its Unmarshall override reads them under the root.
    private void WriteUnmarshallResult(CodeWriter writer, string className, Operation operation, List<Member> members)
    {
        var isEc2 = context.Protocol == AWSProtocol.Ec2Query;
        if (isEc2)
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// Unmarshaller the response from the service to the response class.");
            writer.WriteLine("/// </summary>");
        }
        else if (members.Count == 0)
        {
            // An output with no members still gets the method and the dispatch to it (C2J parity): the Result
            // element is then consumed by this loop rather than the caller's. Its object parameter goes unused,
            // so the analyzer is suppressed exactly as C2J does.
            writer.WriteLine("""[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "unmarshalledObject")]""");
        }

        var signature = isEc2
            ? "public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)"
            : $"private static void UnmarshallResult(XmlUnmarshallerContext context, {className} unmarshalledObject)";
        writer.OpenBlock(signature, () =>
        {
            if (isEc2)
            {
                writer.WriteLine($"{className} unmarshalledObject = new {className}();");
                writer.WriteLine("");
            }
            writer.WriteLine("int originalDepth = context.CurrentDepth;");
            writer.WriteLine("int targetDepth = originalDepth + 1;");
            // From the document root, ec2Query members sit at depth 2 (under the Response root) and awsQuery
            // members two elements further down (under the Response wrapper and the Result element). awsQuery
            // enters UnmarshallResult already inside the Result element, so there this never fires; C2J emits
            // it unconditionally and each protocol keeps its C2J line.
            writer.OpenBlock("if (context.IsStartOfDocument)", () =>
            {
                writer.WriteLine(isEc2 ? "targetDepth = 2;" : "targetDepth += 2;");
            });
            writer.WriteLine("");
            // ReadAtDepth bounds the loop to the current element's subtree: on awsQuery it stops as soon as the
            // reader rises above the Result element, so the sibling <ResponseMetadata> is left for the outer loop.
            writer.OpenBlock("while (context.ReadAtDepth(originalDepth))", () =>
            {
                writer.OpenBlock("if (context.IsStartElement || context.IsAttribute)", () =>
                {
                    if (context.Customizations.WrapsOutput(operation.Name))
                    {
                        // A wrapped output reads its single member from the whole body (".").
                        var wrapped = members.Single();
                        writer.OpenBlock("""if (context.TestExpression(".", targetDepth))""", () =>
                        {
                            writer.WriteLine($"unmarshalledObject.{wrapped.PropertyName} = {wrapped.Type.UnmarshallerName}.Instance.Unmarshall(context);");
                            writer.WriteLine("continue;");
                        });
                    }
                    else
                    {
                        XmlBodyMemberUnmarshaller.WriteMemberBlocks(writer, operation.Output, members, "targetDepth", context.Protocol);
                    }
                });
            });
            writer.WriteLine("");
            writer.WriteLine(isEc2 ? "return unmarshalledObject;" : "return;");
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
                        writer.OpenBlock($"""if (errorResponse.Code != null && errorResponse.Code.Equals("{DispatchCode(error)}"))""", () =>
                        {
                            writer.WriteLine($"return {exceptionClassName}Unmarshaller.Instance.Unmarshall(contextCopy, errorResponse);");
                        });
                    }
                });
            });
            writer.WriteLine($"return new Amazon{context.BaseName}Exception({ErrorEnvelopeArguments});");
        });
    }

    private void WriteEc2UnmarshallExceptionMethod(CodeWriter writer, Operation operation)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshall error response to exception.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)", () =>
        {
            writer.WriteLine("ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);");
            foreach (var error in operation.Errors)
            {
                var exceptionClassName = ExceptionWriter.ToExceptionName(context.ToDotNetName(error.Id));
                writer.OpenBlock($"""if (errorResponse.Code != null && errorResponse.Code.Equals("{DispatchCode(error)}"))""", () =>
                {
                    writer.WriteLine($"return new {exceptionClassName}({ErrorEnvelopeArguments});");
                });
            }
            writer.WriteLine($"return new Amazon{context.BaseName}Exception({ErrorEnvelopeArguments});");
        });
    }

    // @awsQueryError overrides the wire Code the client dispatches on (else the shape name).
    private static string DispatchCode(StructureShape error) => error.GetAwsQueryError()?.Code ?? error.Id.Name;

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
        FileHeader.WriteUsings(writer, FileHeader.MarshallerUsings, false);
    }
}
