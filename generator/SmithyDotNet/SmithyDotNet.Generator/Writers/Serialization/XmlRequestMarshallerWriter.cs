using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source for a restXml request marshaller. HTTP bindings (query/header/label/path) are
/// shared with restJson1 via <see cref="HttpRequestBindings"/>; the body is an XML document written with
/// <c>XmlWriter</c>. The input's own members are written inline by <see cref="XmlBodyMemberMarshaller"/>,
/// which delegates each nested structure to its generated marshaller (<see cref="XmlStructureMarshallerWriter"/>);
/// a structure <c>@httpPayload</c> is marshalled by that structure's marshaller directly into the root element.
/// The body's root element is the input shape (or the <c>@httpPayload</c> structure) carrying the service's
/// <c>@xmlNamespace</c>; Content-Type is <c>application/xml</c> and the service's API version rides
/// <c>x-amz-api-version</c>, both only when there is an XML body.
/// </summary>
public sealed class XmlRequestMarshallerWriter(GenerationContext context, string modelFileName)
{
    private readonly HttpRequestBindings _bindings = new(context);

    public string Write(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Request";
        var httpTrait = operation.Shape.GetHttp() ?? throw new GeneratorException($"Operation '{operation.Name}' is missing the @http trait.");
        var hostPrefix = operation.Shape.GetEndpoint()?.HostPrefix;
        var members = TypeMapper.ResolveMembers(operation.Input, context);
        var partitioned = HttpRequestBindings.PartitionMembers(operation.Input, members, httpBindings: true);
        var compressionEncoding = MarshallerCommon.CompressionEncoding(operation);

        if (compressionEncoding is not null && partitioned.PayloadMember is { Type: { IsStreaming: true, RequiresLength: true } })
        {
            throw new GeneratorException($"Operation '{operation.Name}' combines @requestCompression with a @streaming @requiresLength payload.");
        }
        if (partitioned.PayloadMember is { Type.IsEventStream: true })
        {
            throw new GeneratorException($"Operation '{operation.Name}' has an event-stream payload, which restXml does not support yet.");
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
                WriteTypedMarshallMethod(writer, className, operation, httpTrait, partitioned, hostPrefix, compressionEncoding);
                writer.WriteLine("");
                MarshallerCommon.WriteRequestMarshallerSingleton(writer, className);
                writer.WriteLine("");
                writer.WriteLine($"partial void PostMarshallCustomization(DefaultRequest defaultRequest, {className} publicRequest);");
                writer.WriteLine($"partial void PreMarshallCustomization(DefaultRequest defaultRequest, {className} publicRequest);");
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteTypedMarshallMethod(
        CodeWriter writer,
        string className,
        Operation operation,
        HttpTrait httpTrait,
        PartitionedMembers partitioned,
        string? hostPrefix,
        string? compressionEncoding)
    {
        var unsignedPayload = operation.Shape.HasUnsignedPayload();
        var requiresChecksum = operation.Shape.RequiresHttpChecksum();

        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Marshall the request object to the HTTP request.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public IRequest Marshall({className} publicRequest)", () =>
        {
            writer.WriteLine($"""var request = new DefaultRequest(publicRequest, "{context.Namespace}");""");
            writer.WriteLine("PreMarshallCustomization(request, publicRequest);");
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
            writer.WriteLine($"""request.HttpMethod = "{httpTrait.Method}";""");
            writer.WriteLine("");

            if (partitioned.PrefixHeadersMember is { } prefixHeaders)
            {
                _bindings.WritePrefixHeadersMember(writer, prefixHeaders.Member, prefixHeaders.Prefix);
            }
            _bindings.WriteHeaderMembers(writer, partitioned.HeaderMembers);
            AwsQueryCompatibleMarshalling.WriteQueryModeHeader(writer, context);
            _bindings.WriteResourcePath(writer, httpTrait, partitioned.LabelMembers);
            writer.WriteLine("");
            _bindings.WriteQueryStringMembers(writer, partitioned.QueryMembers);
            if (partitioned.QueryParamsMember is { } queryParams)
            {
                _bindings.WriteQueryParamsMember(writer, queryParams);
            }

            if (partitioned.PayloadMember is { Type.IsStructure: true } structurePayload)
            {
                // The payload structure's own marshaller writes its members into the root element. An unset
                // structure/union payload sends an empty body (as C2J and the JSON writer do), not <Root />.
                var marshaller = structurePayload.Type.MarshallerName ?? throw new GeneratorException($"Payload structure '{structurePayload.Type.DotNetType}' has no marshaller name.");
                writer.OpenBlock($"if (publicRequest.IsSet{structurePayload.PropertyName}())", () =>
                {
                    WriteXmlBody(writer, requiresChecksum, StructurePayloadRoot(operation, structurePayload),
                        () => writer.WriteLine($"{marshaller}.Instance.Marshall(publicRequest.{structurePayload.PropertyName}, context);"));
                });
            }
            else if (partitioned.PayloadMember is { } payload)
            {
                WriteNonStructurePayload(writer, payload);
            }
            else if (partitioned.BodyMembers.Count > 0)
            {
                WriteXmlBody(writer, requiresChecksum, InputRoot(operation),
                    () => XmlBodyMemberMarshaller.WriteStructureBody(writer, operation.Input, partitioned.BodyMembers, "publicRequest"));
            }

            if (unsignedPayload)
            {
                writer.WriteLine("request.DisablePayloadSigning = true;");
            }
            writer.WriteLine("");
            writer.WriteLine("PostMarshallCustomization(request, publicRequest);");
            if (partitioned.QueryMembers.Count > 0 || partitioned.QueryParamsMember is not null)
            {
                writer.WriteLine("request.UseQueryString = true;");
                writer.WriteLine("");
            }

            if (!string.IsNullOrEmpty(hostPrefix) && !HostPrefixConsumedByEndpointRules(operation, partitioned.HostLabelMembers))
            {
                MarshallerCommon.WriteHostPrefix(writer, context.BaseName, hostPrefix, partitioned.HostLabelMembers);
                writer.WriteLine("");
            }

            writer.WriteLine("return request;");
        });
    }

    // The XmlWriter body: a PooledContentStream (or MemoryStream on .NET Framework), a root element with
    // the service @xmlNamespace, the body written by <paramref name="writeBody"/> (the input's members
    // inline, or the payload structure's marshaller), then Content-Type/checksum/api-version set in a try
    // that maps an XML encoder failure to an AmazonServiceException (C2J restXml).
    private void WriteXmlBody(CodeWriter writer, bool requiresChecksum, (string Name, XmlNamespaceTrait? Namespace) root, Action writeBody)
    {
        writer.WriteLine("#if !NETFRAMEWORK");
        writer.WriteLine("request.ContentStream = new PooledContentStream();");
        writer.WriteLine("var bufferTextWriter = new XMLEncodedBufferTextWriter(((PooledContentStream)request.ContentStream).BufferWriter);");
        writer.WriteLine("using (var xmlWriter = XmlWriter.Create(bufferTextWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))");
        writer.WriteLine("{");
        writer.WriteLine("#else");
        writer.WriteLine("var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);");
        writer.WriteLine("using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))");
        writer.WriteLine("{");
        writer.WriteLine("#endif");
        writer.Indent(() =>
        {
            writer.WriteLine("var context = new XmlMarshallerContext(request, xmlWriter);");
            XmlBodyMemberMarshaller.OpenElement(writer, root.Name, root.Namespace);
            writeBody();
            writer.WriteLine("context.Writer.WriteEndElement();");
        });
        writer.WriteLine("}");

        writer.OpenBlock("try", () =>
        {
            writer.WriteLine("#if NETFRAMEWORK");
            writer.WriteLine("string content = stringWriter.ToString();");
            writer.WriteLine("request.Content = System.Text.Encoding.UTF8.GetBytes(content);");
            writer.WriteLine("#endif");
            writer.WriteLine("""request.Headers["Content-Type"] = "application/xml";""");
            if (requiresChecksum)
            {
                writer.WriteLine("ChecksumUtils.SetChecksumData(request);");
            }
            writer.WriteLine($"""request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "{context.ApiVersion}";""");
        });
        writer.OpenBlock("catch (EncoderFallbackException e)", () =>
        {
            writer.WriteLine("""throw new AmazonServiceException("Unable to marshall request to XML", e);""");
        });
    }

    // A @httpPayload that is not a structure: a string is UTF-8 bytes with text/plain; a blob is the raw
    // stream with application/octet-stream (or the target's @mediaType). C2J ProcessNonStructurePayload.
    private void WriteNonStructurePayload(CodeWriter writer, Member payload)
    {
        if (payload.Type.MarshalsAsString)
        {
            var contentType = payload.Type.MediaType ?? "text/plain";
            writer.OpenBlock($"if (publicRequest.IsSet{payload.PropertyName}())", () =>
            {
                writer.WriteLine($"request.Content = System.Text.Encoding.UTF8.GetBytes(StringUtils.FromString(publicRequest.{payload.PropertyName}));");
            });
            writer.WriteLine($"""request.Headers["Content-Type"] = "{contentType}";""");
            return;
        }

        if (payload.Type.IsBlob)
        {
            var contentType = payload.Type.MediaType ?? "application/octet-stream";
            writer.WriteLine($"request.ContentStream = publicRequest.{payload.PropertyName} ?? new MemoryStream();");
            writer.WriteLine($"""request.Headers["Content-Type"] = "{contentType}";""");
            return;
        }

        throw new GeneratorException($"Unsupported restXml @httpPayload member type '{payload.Type.DotNetType}' (member: {payload.PropertyName}).");
    }

    // C2J skips the @endpoint host prefix when the endpoint ruleset already consumes a @hostLabel member
    // (it binds a @contextParam, so the resolver has put the value in the host); emitting it here would
    // duplicate the label. All 92 S3 Control operations use hostPrefix "{AccountId}." with AccountId also a
    // @contextParam, and only S3 Control matches today — derived from the model rather than hard-coded.
    private bool HostPrefixConsumedByEndpointRules(Operation operation, List<Member> hostLabelMembers) =>
        hostLabelMembers.Any(m => operation.Input.Members[m.ModeledName].GetContextParam() is not null);

    private (string Name, XmlNamespaceTrait? Namespace) InputRoot(Operation operation)
    {
        var name = operation.Input.GetXmlName() ?? operation.Input.Id.Name;
        return (name, operation.Input.GetXmlNamespace() ?? context.XmlNamespace);
    }

    private (string Name, XmlNamespaceTrait? Namespace) StructurePayloadRoot(Operation operation, Member payload)
    {
        var payloadStruct = (StructureShape)payload.Type.Target;
        var memberShape = operation.Input.Members[payload.ModeledName];
        var name = memberShape.GetXmlName() ?? payloadStruct.GetXmlName() ?? payloadStruct.Id.Name;
        // The payload root namespace follows the member, then the payload shape, then the service default.
        var ns = memberShape.GetXmlNamespace() ?? payloadStruct.GetXmlNamespace() ?? context.XmlNamespace;
        return (name, ns);
    }

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.XmlRequestMarshallerUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
    }
}
