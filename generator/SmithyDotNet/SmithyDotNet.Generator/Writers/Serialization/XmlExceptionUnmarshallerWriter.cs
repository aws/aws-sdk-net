using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Writers.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source for a restXml error-response (exception) unmarshaller: an
/// <c>IXmlErrorResponseUnmarshaller</c> that builds the exception from the parsed <c>ErrorResponse</c>
/// envelope and reads any extra modeled error members out of the XML body (and response headers).
/// Protocol-neutral XML; the awsQuery task reuses it. The parameterless <c>Unmarshall(context)</c> is never
/// called (errors are dispatched through the <c>(context, errorResponse)</c> overload) and throws.
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
                WriteUnusedUnmarshallMethod(writer, exceptionName);
                writer.WriteLine("");
                WriteMainUnmarshallMethod(writer, exceptionName, structure, bindings);
                writer.WriteLine("");
                MarshallerCommon.WriteUnmarshallerSingleton(writer, unmarshallerClassName);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private static void WriteUnusedUnmarshallMethod(CodeWriter writer, string exceptionName)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshaller error response to exception.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public {exceptionName} Unmarshall(XmlUnmarshallerContext context)", () =>
        {
            writer.WriteLine("throw new NotImplementedException();");
        });
    }

    private static void WriteMainUnmarshallMethod(CodeWriter writer, string exceptionName, StructureShape structure, JsonResponseUnmarshallerWriter.PartitionedMembers bindings)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshaller error response to exception.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public {exceptionName} Unmarshall(XmlUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse)", () =>
        {
            writer.WriteLine($"{exceptionName} unmarshalledObject = new {exceptionName}(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);");

            // Extra modeled error members are read from the body; the match is on the element suffix
            // alone (no depth), matching C2J's exception loop.
            writer.OpenBlock("while (context.Read())", () =>
            {
                writer.OpenBlock("if (context.IsStartElement || context.IsAttribute)", () =>
                {
                    if (bindings.BodyMembers.Count > 0)
                    {
                        XmlBodyMemberUnmarshaller.WriteMemberBlocks(writer, structure, bindings.BodyMembers, depthExpr: null);
                    }
                });
            });

            JsonResponseUnmarshallerWriter.WriteHeaderUnmarshallers(writer, bindings.HeaderMembers);
            if (bindings.PrefixHeadersMember is { } prefixHeaders)
            {
                JsonResponseUnmarshallerWriter.WritePrefixHeadersUnmarshaller(writer, prefixHeaders.Member, prefixHeaders.Prefix);
            }

            writer.WriteLine("return unmarshalledObject;");
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
