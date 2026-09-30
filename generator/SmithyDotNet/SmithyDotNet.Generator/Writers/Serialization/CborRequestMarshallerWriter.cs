using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// rpcv2Cbor request marshaller: <c>POST service/{Service}/operation/{Operation}</c> with a CBOR map
/// body, HTTP binding traits ignored (https://smithy.io/2.0/additional-specs/protocols/smithy-rpc-v2-cbor.html#requests).
/// </summary>
public sealed class CborRequestMarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Request";
        var members = TypeMapper.ResolveMembers(operation.Input, context);
        var compressionEncoding = MarshallerCommon.CompressionEncoding(operation);

        // @hostLabel is not an HTTP binding, so it still applies.
        var hostLabelMembers = new List<Member>();
        foreach (var member in members)
        {
            if (operation.Input.Members[member.ModeledName].IsHostLabel())
            {
                hostLabelMembers.Add(member);
            }
        }

        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
        FileHeader.WriteUsings(writer, FileHeader.MarshallerUsings, false);
        FileHeader.WriteUsings(writer, FileHeader.CborMarshallerUsings);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// {operation.Name} Request Marshaller");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {className}Marshaller : IMarshaller<IRequest, {className}>, IMarshaller<IRequest, AmazonWebServiceRequest>", () =>
            {
                MarshallerCommon.WriteBaseMarshallMethod(writer, className);
                writer.WriteLine("");
                WriteTypedMarshallMethod(writer, className, operation, members, hostLabelMembers, compressionEncoding);
                writer.WriteLine("");
                MarshallerCommon.WriteRequestMarshallerSingleton(writer, className);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteTypedMarshallMethod(
        CodeWriter writer,
        string className,
        Operation operation,
        List<Member> members,
        List<Member> hostLabelMembers,
        string? compressionEncoding)
    {
        // A Unit input sends no body and no Content-Type; an empty input structure still sends an empty map.
        var hasBody = operation.Shape.Input != ShapeId.Unit;
        var hostPrefix = operation.Shape.GetEndpoint()?.HostPrefix;

        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Marshall the request object to the HTTP request.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public IRequest Marshall({className} publicRequest)", () =>
        {
            writer.WriteLine($"""IRequest request = new DefaultRequest(publicRequest, "{context.Namespace}");""");
            writer.WriteLine("""request.Headers["smithy-protocol"] = "rpc-v2-cbor";""");
            if (hasBody)
            {
                writer.WriteLine("""request.Headers["Content-Type"] = "application/cbor";""");
            }
            // TODO: an operation with a response event stream accepts application/vnd.amazon.eventstream instead.
            writer.WriteLine("""request.Headers["Accept"] = "application/cbor";""");

            AwsQueryCompatibleMarshalling.WriteQueryModeHeader(writer, context);

            if (compressionEncoding is not null)
            {
                writer.WriteLine($"CompressionAlgorithmUtils.SetCompressionAlgorithm(request, CompressionEncodingAlgorithm.{compressionEncoding});");
            }
            writer.WriteLine($"""request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "{context.ApiVersion}";""");
            writer.WriteLine("""request.HttpMethod = "POST";""");
            if (operation.RequiresHttp2)
            {
                writer.WriteLine("#if NET8_0_OR_GREATER");
                writer.WriteLine("request.HttpProtocolVersion = System.Net.HttpVersion.Version20;");
                writer.WriteLine("#endif");
            }
            writer.WriteLine("");

            writer.WriteLine($"""request.ResourcePath = "service/{context.ServiceShapeName}/operation/{operation.Name}";""");
            if (hasBody)
            {
                WriteBody(writer, members);

                // The checksum covers the body, so it follows serialization.
                if (operation.Shape.RequiresHttpChecksum())
                {
                    writer.WriteLine("ChecksumUtils.SetChecksumData(request);");
                }
            }
            if (operation.Shape.HasUnsignedPayload())
            {
                writer.WriteLine("request.DisablePayloadSigning = true;");
            }
            writer.WriteLine("");

            if (!string.IsNullOrEmpty(hostPrefix))
            {
                MarshallerCommon.WriteHostPrefix(writer, context.BaseName, hostPrefix, hostLabelMembers);
                writer.WriteLine("");
            }

            writer.WriteLine("return request;");
        });
    }

    private static void WriteBody(CodeWriter writer, List<Member> members)
    {
        writer.WriteLine("var writer = CborWriterPool.Rent();");
        writer.OpenBlock("try", () =>
        {
            writer.WriteLine("writer.WriteStartMap(null);");
            writer.WriteLine("var context = new CborMarshallerContext(request, writer);");
            foreach (var member in members)
            {
                CborBodyMemberMarshaller.WriteBodyMember(writer, member, "publicRequest");
            }
            writer.WriteLine("writer.WriteEndMap();");

            writer.WriteLine("#if !NETFRAMEWORK");
            writer.WriteLine("var encodedLength = writer.BytesWritten;");
            writer.WriteLine("request.ContentStream = new PooledContentStream(encodedLength);");
            writer.WriteLine("var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;");
            writer.WriteLine("var span = bufferWriter.GetSpan(encodedLength);");
            writer.WriteLine("var bytesWritten = writer.Encode(span);");
            writer.WriteLine("bufferWriter.Advance(bytesWritten);");
            writer.WriteLine("#else");
            writer.WriteLine("request.Content = writer.Encode();");
            writer.WriteLine("#endif");
        });
        writer.OpenBlock("finally", () =>
        {
            writer.WriteLine("CborWriterPool.Return(writer);");
        });
    }
}
