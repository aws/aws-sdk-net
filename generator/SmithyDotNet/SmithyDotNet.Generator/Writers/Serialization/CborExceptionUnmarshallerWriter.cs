using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Writers.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// rpcv2Cbor exception unmarshaller.
/// </summary>
public sealed class CborExceptionUnmarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(StructureShape structure, CancellationToken cancellationToken = default)
    {
        var exceptionName = ExceptionWriter.ToExceptionName(context.ToDotNetName(structure.Id));
        var unmarshallerClassName = $"{exceptionName}Unmarshaller";
        var members = ExceptionWriter.ResolveSerializedMembers(structure, context);
        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        CborResponseUnmarshallerWriter.WriteUsings(writer, context);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Exception Unmarshaller for {exceptionName}");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {unmarshallerClassName} : ICborErrorResponseUnmarshaller<{exceptionName}, CborUnmarshallerContext>", () =>
            {
                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// Unmarshall the exception from the service to the appropriate exception class");
                writer.WriteLine("/// </summary>");
                writer.OpenBlock($"public {exceptionName} Unmarshall(CborUnmarshallerContext context)", () =>
                {
                    writer.WriteLine("return this.Unmarshall(context, new Amazon.Runtime.Internal.ErrorResponse());");
                });
                writer.WriteLine("");
                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// Unmarshall the exception from the service to the appropriate exception class");
                writer.WriteLine("/// </summary>");
                writer.OpenBlock($"public {exceptionName} Unmarshall(CborUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse)", () =>
                {
                    writer.WriteLine($"var unmarshalledObject = new {exceptionName}(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);");
                    if (members.Count > 0)
                    {
                        writer.WriteLine();
                        writer.WriteLine("var reader = context.Reader;");
                        writer.WriteLine($"""context.AddPathSegment("{exceptionName}");""");
                        CborBodyMemberUnmarshaller.WriteMapReadLoop(writer, members);
                        writer.WriteLine("context.PopPathSegment();");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("return unmarshalledObject;");
                });
                writer.WriteLine("");
                MarshallerCommon.WriteUnmarshallerSingleton(writer, unmarshallerClassName);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }
}
