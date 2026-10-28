using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Protocols;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Writers.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source for a restXml error-response (exception) unmarshaller: an
/// <c>IXmlErrorResponseUnmarshaller</c> that builds the exception from the parsed <c>ErrorResponse</c>
/// envelope and reads any extra modeled error members out of the XML body (and response headers).
/// Shared by restXml and awsQuery. The single-argument <c>Unmarshall(context)</c> is never called (errors
/// are dispatched through the <c>(context, errorResponse)</c> overload) but is public API, so its body
/// follows each protocol's C2J template: restXml throws, awsQuery delegates with an empty envelope.
/// </summary>
public sealed class XmlExceptionUnmarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(StructureShape structure, CancellationToken cancellationToken = default)
    {
        var exceptionName = ExceptionWriter.ToExceptionName(context.ToDotNetName(structure.Id));
        var unmarshallerClassName = $"{exceptionName}Unmarshaller";

        // message is deserialized into the base exception; every other member is read from the body
        // (or headers), as on the JSON path.
        var serialized = ExceptionWriter.ResolveSerializedMembers(structure, context);
        var bindings = JsonResponseUnmarshallerWriter.PartitionByBinding(structure, serialized, context.UsesHttpBindings, bindStatusCode: false);
        if (bindings.PayloadMember is not null)
        {
            throw new GeneratorException($"@httpPayload on error member '{bindings.PayloadMember.PropertyName}' of '{exceptionName}' is not supported.");
        }

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Exception Unmarshaller for {exceptionName}");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {unmarshallerClassName} : IXmlErrorResponseUnmarshaller<{exceptionName}, XmlUnmarshallerContext>", () =>
            {
                WriteSingleArgUnmarshallMethod(writer, exceptionName, context.Protocol);
                writer.WriteLine("");
                WriteMainUnmarshallMethod(writer, exceptionName, structure, bindings, context.Protocol);
                writer.WriteLine("");
                MarshallerCommon.WriteUnmarshallerSingleton(writer, unmarshallerClassName);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    // The single-argument overload the base IXmlUnmarshaller contract requires. Error dispatch always
    // goes through the (context, errorResponse) overload, so nothing in generated code calls this — but
    // the class is public API, so each protocol keeps the body its C2J template shipped rather than the
    // one that happens to be convenient: restXml throws (RestXmlExceptionUnmarshaller.tt), awsQuery
    // delegates with an empty envelope (AWSQueryExceptionUnmarshaller.tt), which returns a non-null
    // exception with null Message/Code/RequestId.
    private static void WriteSingleArgUnmarshallMethod(CodeWriter writer, string exceptionName, AWSProtocol protocol)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshaller error response to exception.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public {exceptionName} Unmarshall(XmlUnmarshallerContext context)", () =>
        {
            if (protocol == AWSProtocol.AwsQuery)
            {
                writer.WriteLine("return this.Unmarshall(context, new Amazon.Runtime.Internal.ErrorResponse());");
            }
            else
            {
                writer.WriteLine("throw new NotImplementedException();");
            }
        });
    }

    private static void WriteMainUnmarshallMethod(CodeWriter writer, string exceptionName, StructureShape structure, JsonResponseUnmarshallerWriter.PartitionedMembers bindings, AWSProtocol protocol)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshaller error response to exception.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public {exceptionName} Unmarshall(XmlUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse)", () =>
        {
            writer.WriteLine($"{exceptionName} unmarshalledObject = new {exceptionName}(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);");

            // Extra modeled error members are read from the body. The two C2J templates differ and each is
            // kept: restXml matches on the element suffix at any depth (RestXmlExceptionUnmarshaller.tt),
            // awsQuery pins the match to the member depth (AWSQueryExceptionUnmarshaller.tt) so an envelope
            // element at another depth — <RequestId> at 2, <Type>/<Code> at 3 — can't be read into a member
            // that happens to share its name.
            if (protocol == AWSProtocol.AwsQuery)
            {
                WriteDepthQualifiedBodyLoop(writer, structure, bindings.BodyMembers, protocol);
            }
            else
            {
                writer.OpenBlock("while (context.Read())", () =>
                {
                    writer.OpenBlock("if (context.IsStartElement || context.IsAttribute)", () =>
                    {
                        if (bindings.BodyMembers.Count > 0)
                        {
                            XmlBodyMemberUnmarshaller.WriteMemberBlocks(writer, structure, bindings.BodyMembers, depthExpr: null, protocol);
                        }
                    });
                });
            }

            JsonResponseUnmarshallerWriter.WriteHeaderUnmarshallers(writer, bindings.HeaderMembers);
            if (bindings.PrefixHeadersMember is { } prefixHeaders)
            {
                JsonResponseUnmarshallerWriter.WritePrefixHeadersUnmarshaller(writer, prefixHeaders.Member, prefixHeaders.Prefix);
            }

            writer.WriteLine("return unmarshalledObject;");
        });
    }

    // The awsQuery error body loop (AWSQueryExceptionUnmarshaller.tt): reading is bounded to the current
    // subtree by ReadAtDepth, and each member matched at targetDepth. On a fresh context positioned at the
    // start of the body, originalDepth is 0 and targetDepth resolves to 3 — the depth of an error member
    // under <ErrorResponse><Error>.
    private static void WriteDepthQualifiedBodyLoop(CodeWriter writer, StructureShape structure, List<Member> bodyMembers, AWSProtocol protocol)
    {
        writer.WriteLine("int originalDepth = context.CurrentDepth;");
        writer.WriteLine("int targetDepth = originalDepth + 1;");
        writer.OpenBlock("if (context.IsStartOfDocument)", () =>
        {
            writer.WriteLine("targetDepth += 2;");
        });
        writer.WriteLine("");
        writer.OpenBlock("while (context.ReadAtDepth(originalDepth))", () =>
        {
            writer.OpenBlock("if (context.IsStartElement || context.IsAttribute)", () =>
            {
                if (bodyMembers.Count > 0)
                {
                    XmlBodyMemberUnmarshaller.WriteMemberBlocks(writer, structure, bodyMembers, "targetDepth", protocol);
                }
            });
        });
    }

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.ExceptionUnmarshallerUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
        writer.WriteLine("using Amazon.Runtime;");
        writer.WriteLine("using Amazon.Runtime.Internal;");
        FileHeader.WriteUsings(writer, FileHeader.MarshallerUsings, false);
        writer.WriteLine("using Amazon.Util;");
    }
}
