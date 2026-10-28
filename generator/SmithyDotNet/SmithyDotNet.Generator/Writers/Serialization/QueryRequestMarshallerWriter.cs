using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source for an awsQuery request marshaller. Every operation is a <c>POST /</c> whose body is
/// a URL-encoded form: <c>Action={OperationName}</c> and <c>Version={apiVersion}</c>, then the input's
/// members serialized into <c>request.Parameters</c> by <see cref="QueryBodyMemberMarshaller"/> (inline and
/// recursive — awsQuery has no per-structure marshaller class). The runtime writes the parameters to the
/// request body. There are no HTTP binding traits, no XML body, and no per-operation Content-Type (the
/// runtime sets <c>application/x-www-form-urlencoded</c>). Mirrors C2J's <c>AWSQueryRequestMarshaller.tt</c>.
/// </summary>
public sealed class QueryRequestMarshallerWriter(GenerationContext context, string modelFileName)
{
    private readonly QueryBodyMemberMarshaller _body = new(context);

    public string Write(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Request";
        var hostPrefix = operation.Shape.GetEndpoint()?.HostPrefix;
        var members = TypeMapper.ResolveMembers(operation.Input, context);
        var partitioned = HttpRequestBindings.PartitionMembers(operation.Input, members, httpBindings: false);
        var compressionEncoding = MarshallerCommon.CompressionEncoding(operation);

        if (partitioned.PayloadMember is { Type.IsEventStream: true })
        {
            throw new GeneratorException($"Operation '{operation.Name}' has an event-stream member, which awsQuery does not support.");
        }

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
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
                WriteTypedMarshallMethod(writer, className, operation, partitioned, hostPrefix, compressionEncoding);
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
        PartitionedMembers partitioned,
        string? hostPrefix,
        string? compressionEncoding)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Marshall the request object to the HTTP request.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public IRequest Marshall({className} publicRequest)", () =>
        {
            writer.WriteLine($"""IRequest request = new DefaultRequest(publicRequest, "{context.Namespace}");""");
            if (operation.RequiresHttp2)
            {
                writer.WriteLine("#if NET8_0_OR_GREATER");
                writer.WriteLine("request.HttpProtocolVersion = System.Net.HttpVersion.Version20;");
                writer.WriteLine("#endif");
            }
            if (compressionEncoding is not null)
            {
                writer.WriteLine($"CompressionAlgorithmUtils.SetCompressionAlgorithm(request, CompressionEncodingAlgorithm.{compressionEncoding});");
            }
            writer.WriteLine("""request.HttpMethod = "POST";""");
            writer.WriteLine($"""request.Parameters.Add("Action", "{operation.Name}");""");
            writer.WriteLine($"""request.Parameters.Add("Version", "{context.ApiVersion}");""");
            writer.WriteLine("");

            _body.WriteStructureBody(writer, operation.Input, partitioned.BodyMembers, "publicRequest", prefix: null, depth: 0);
            writer.WriteLine("");

            // Cache the URL-encoded body up front (the runtime signs and sends it). C2J skips this for v2
            // signing, whose signer appends SecurityToken to Parameters after marshalling.
            // TODO: SimpleDB still signs with the v2 QueryStringSigner; skip this precompute for it when that
            // service migrates.
            writer.WriteLine("#if !NETFRAMEWORK");
            writer.WriteLine("request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);");
            writer.WriteLine("#else");
            writer.WriteLine("request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);");
            writer.WriteLine("#endif");

            if (!string.IsNullOrEmpty(hostPrefix))
            {
                writer.WriteLine("");
                MarshallerCommon.WriteHostPrefix(writer, context.BaseName, hostPrefix, partitioned.HostLabelMembers);
            }

            writer.WriteLine("");
            writer.WriteLine("return request;");
        });
    }

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.QueryRequestMarshallerUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
    }
}
