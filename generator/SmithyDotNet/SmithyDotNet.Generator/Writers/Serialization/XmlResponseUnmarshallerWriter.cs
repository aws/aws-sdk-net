using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source for a restXml response unmarshaller (an <c>XmlResponseUnmarshaller</c>): the body
/// read through a <c>UnmarshallResult</c> loop, response headers / <c>@httpResponseCode</c> populated from
/// <c>context.ResponseData</c>, and errors dispatched on <c>errorResponse.Code</c> after
/// <c>XmlErrorResponseUnmarshaller</c> parses the <c>ErrorResponse/Error/Code</c> envelope. Header reads are
/// shared with restJson1 (<see cref="JsonResponseUnmarshallerWriter"/>); the body is XML.
/// </summary>
public sealed class XmlResponseUnmarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Response";
        var unmarshallerClassName = $"{className}Unmarshaller";
        var resolvedMembers = TypeMapper.ResolveMembers(operation.Output, context);
        var members = JsonResponseUnmarshallerWriter.PartitionByBinding(operation.Output, resolvedMembers, context.UsesHttpBindings);

        if (members.EventStreamMember is not null)
        {
            throw new GeneratorException($"Operation '{operation.Name}' has an output event stream, which restXml does not support yet.");
        }

        // A structure/union @httpPayload is read like a body member matched by its element name (C2J
        // UnmarshallResult), not a raw-stream read — only string/blob/streaming payloads read the stream.
        var structurePayload = members.PayloadMember is { Type.IsStructure: true } ? members.PayloadMember : null;
        var loopMembers = structurePayload is not null ? new List<Member> { structurePayload } : members.BodyMembers;
        var hasBodyLoop = (structurePayload is not null || members.PayloadMember is null) && loopMembers.Count > 0;
        var allowEmptyResult = context.Customizations.AllowsEmptyResult(operation.Name);

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
                WriteUnmarshallMethod(writer, className, members, structurePayload, hasBodyLoop, allowEmptyResult);
                writer.WriteLine("");
                if (hasBodyLoop)
                {
                    WriteUnmarshallResult(writer, className, operation, members.BodyMembers, structurePayload);
                    writer.WriteLine("");
                }
                WriteUnmarshallExceptionMethod(writer, operation);
                writer.WriteLine("");
                writer.WriteLine($"partial void PostUnmarshallCustomization(XmlUnmarshallerContext context, {className} unmarshalledObject);");
                if (members.PayloadMember is { Type.IsStreaming: true })
                {
                    MarshallerCommon.WriteHasStreamingProperty(writer);
                    writer.WriteLine("");
                }
                MarshallerCommon.WriteResponseUnmarshallerSingleton(writer, unmarshallerClassName);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteUnmarshallMethod(CodeWriter writer, string className, JsonResponseUnmarshallerWriter.PartitionedMembers members, Member? structurePayload, bool hasBodyLoop, bool allowEmptyResult)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshaller the response from the service to the response class.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)", () =>
        {
            writer.WriteLine($"{className} unmarshalledObject = new {className}();");

            if (allowEmptyResult)
            {
                // s3control: a successful empty body returns without parsing (the result loop would throw).
                writer.OpenBlock("if (context.ResponseData.IsSuccessStatusCode && context.ResponseData.ContentLength == 0)", () =>
                {
                    writer.WriteLine("return unmarshalledObject;");
                });
            }

            // A string/blob/streaming payload reads the raw stream; a structure/union payload and ordinary
            // body members both go through the UnmarshallResult element loop.
            if (members.PayloadMember is { } payload && structurePayload is null)
            {
                MarshallerCommon.WritePayloadUnmarshall(writer, payload, context.Protocol);
            }
            else if (hasBodyLoop)
            {
                writer.WriteLine("UnmarshallResult(context, unmarshalledObject);");
            }

            WriteHeaderReads(writer, members);
            if (members.StatusCodeMember is { } statusCode)
            {
                writer.WriteLine($"unmarshalledObject.{statusCode.PropertyName} = (int)context.ResponseData.StatusCode;");
            }

            writer.WriteLine("");
            writer.WriteLine("PostUnmarshallCustomization(context, unmarshalledObject);");
            writer.WriteLine("return unmarshalledObject;");
        });
    }

    // The body read loop over the response's unbound members (or the single structure/union payload),
    // matching C2J's UnmarshallResult.
    private void WriteUnmarshallResult(CodeWriter writer, string className, Operation operation, List<Member> bodyMembers, Member? structurePayload)
    {
        writer.OpenBlock($"private static void UnmarshallResult(XmlUnmarshallerContext context, {className} unmarshalledObject)", () =>
        {
            writer.WriteLine("int originalDepth = context.CurrentDepth;");
            writer.WriteLine("int targetDepth = originalDepth + 1;");
            // For ordinary body members the response wrapper element has not been descended past at the
            // document root, so the match depth is one deeper. A structure/union payload IS the root element
            // (no wrapper), so it stays at originalDepth + 1 — C2J omits this bump when a payload exists.
            if (structurePayload is null)
            {
                writer.OpenBlock("if (context.IsStartOfDocument)", () =>
                {
                    writer.WriteLine("targetDepth += 1;");
                });
            }
            writer.OpenBlock("if (context.IsEmptyResponse)", () =>
            {
                writer.WriteLine("return;");
            });
            writer.OpenBlock("while (context.Read())", () =>
            {
                writer.OpenBlock("if (context.IsStartElement || context.IsAttribute)", () =>
                {
                    if (structurePayload is { } payload)
                    {
                        WritePayloadMatch(writer, operation, payload);
                    }
                    else
                    {
                        XmlBodyMemberUnmarshaller.WriteMemberBlocks(writer, operation.Output, bodyMembers, "targetDepth", context.Protocol);
                    }
                });
                writer.OpenBlock("else if (context.IsEndElement && context.CurrentDepth < originalDepth)", () =>
                {
                    writer.WriteLine("return;");
                });
            });
            writer.WriteLine("return;");
        });
    }

    // A structure/union payload is matched by its root element name — the member's @xmlName, else the
    // target shape's @xmlName, else the shape name — exactly as the request marshaller writes that root.
    private void WritePayloadMatch(CodeWriter writer, Operation operation, Member payload)
    {
        var payloadShape = (StructureShape)payload.Type.Target;
        var memberShape = operation.Output.Members[payload.ModeledName];
        var rootName = memberShape.GetXmlName() ?? payloadShape.GetXmlName() ?? payloadShape.Id.Name;
        var unmarshaller = payload.Type.UnmarshallerName ?? throw new GeneratorException($"Payload structure '{payload.Type.DotNetType}' has no unmarshaller name.");

        writer.OpenBlock($"""if (context.TestExpression("{rootName}", targetDepth))""", () =>
        {
            writer.WriteLine($"var unmarshaller = {unmarshaller}.Instance;");
            writer.WriteLine($"unmarshalledObject.{payload.PropertyName} = unmarshaller.Unmarshall(context);");
            writer.WriteLine("continue;");
        });
    }

    // Header and prefix-header reads are protocol-agnostic (they read from context.ResponseData), so the
    // restJson1 emitters are reused verbatim; both write into the in-scope `unmarshalledObject` local.
    private static void WriteHeaderReads(CodeWriter writer, JsonResponseUnmarshallerWriter.PartitionedMembers members)
    {
        JsonResponseUnmarshallerWriter.WriteHeaderUnmarshallers(writer, members.HeaderMembers);
        if (members.PrefixHeadersMember is { } prefixHeaders)
        {
            JsonResponseUnmarshallerWriter.WritePrefixHeadersUnmarshaller(writer, prefixHeaders.Member, prefixHeaders.Prefix);
        }
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
                        writer.OpenBlock($"""if (errorResponse.Code != null && errorResponse.Code.Equals("{error.Id.Name}"))""", () =>
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
        writer.WriteLine("using System.Globalization;");
        writer.WriteLine("using Amazon.Util;");
    }
}
