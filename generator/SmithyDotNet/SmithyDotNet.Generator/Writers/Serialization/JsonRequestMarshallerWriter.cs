using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Generation.Protocols;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source for a JSON request marshaller matching the public API surface
/// of the existing AWS SDK for .NET.
/// <para />
/// Handles @httpQuery/@httpHeader/@httpLabel/body scalar members (string, enum,
/// bool, numeric, timestamp), list @httpQuery/@httpHeader (string, enum, and value-type elements), an @httpQueryParams map
/// (map&lt;string,string&gt; or map&lt;string,list&lt;string&gt;&gt;), an @httpPrefixHeaders
/// map&lt;string,string&gt;, body lists of strings or
/// structures, an @httpPayload string/structure/blob body, and the operation's @endpoint host
/// prefix with its @hostLabel members. Unsupported member shapes throw a <see cref="GeneratorException"/>.
/// </summary>
public sealed class JsonRequestMarshallerWriter(GenerationContext context, string modelFileName)
{
    private readonly HttpRequestBindings _bindings = new(context);

    public string Write(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Request";

        // awsJson1.x sends every operation as POST / and ignores @http and the member binding traits when
        // present (https://smithy.io/2.0/aws/protocols/aws-json-1_1-protocol.html#protocol-behaviors).
        var httpBindings = context.UsesHttpBindings;
        var httpTrait = httpBindings
            ? operation.Shape.GetHttp() ?? throw new GeneratorException($"Operation '{operation.Name}' is missing the @http trait.")
            : new HttpTrait { Method = "POST", Uri = "/" };
        var hostPrefix = operation.Shape.GetEndpoint()?.HostPrefix;
        var members = TypeMapper.ResolveMembers(operation.Input, context);

        var partitioned = HttpRequestBindings.PartitionMembers(operation.Input, members, httpBindings);
        var compressionEncoding = MarshallerCommon.CompressionEncoding(operation);

        // Smithy forbids the combination: the compressed length isn't known until the whole stream
        // has been read, which is exactly what @requiresLength rules out.
        if (compressionEncoding is not null && partitioned.PayloadMember is { Type: { IsStreaming: true, RequiresLength: true } })
        {
            throw new GeneratorException($"Operation '{operation.Name}' combines @requestCompression with a @streaming @requiresLength payload.");
        }

        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            WriteMarshallerDocumentation(writer, operation.Name);
            writer.OpenBlock($"public partial class {className}Marshaller : IMarshaller<IRequest, {className}>, IMarshaller<IRequest, AmazonWebServiceRequest>", () =>
            {
                MarshallerCommon.WriteBaseMarshallMethod(writer, className);
                writer.WriteLine("");
                WriteTypedMarshallMethod(writer, className, operation, httpTrait, partitioned, hostPrefix, compressionEncoding);
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

            // A modeled @httpHeader("Content-Type") is emitted between the default Content-Type and the
            // blob payload block, so the block's trailing Content-Type override must not clobber it.
            var modeledContentType = partitioned.HeaderMembers.Any(h => h.HeaderName.Equals("Content-Type", StringComparison.OrdinalIgnoreCase));
            var blobContentTypeEmitted = false;

            if (context.UsesHttpBindings)
            {
                blobContentTypeEmitted = WriteContentType(writer, httpTrait, partitioned, modeledContentType);
            }
            else
            {
                // awsJson1.x routes on X-Amz-Target and always sends a JSON body (see below) unless an input
                // event stream replaces it, in which case WriteEventStreamPublisher sets the Content-Type.
                // Same two-statement shape as C2J.
                writer.WriteLine($"""string target = "{context.ServiceShapeName}.{operation.Name}";""");
                writer.WriteLine("""request.Headers["X-Amz-Target"] = target;""");
                if (partitioned.PayloadMember is not { Type.IsEventStream: true })
                {
                    var contentType = string.IsNullOrEmpty(context.Customizations.OverrideContentType)
                        ? $"application/x-amz-json-{JsonVersion(context.Protocol)}"
                        : context.Customizations.OverrideContentType;
                    writer.WriteLine($"""request.Headers["Content-Type"] = "{contentType}";""");
                }
            }

            writer.WriteLine($"""request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "{context.ApiVersion}";""");
            writer.WriteLine($"""request.HttpMethod = "{httpTrait.Method}";""");
            writer.WriteLine("");

            _bindings.WriteQueryStringMembers(writer, partitioned.QueryMembers);
            // Emitted after the explicit @httpQuery members so those win on a key collision (Smithy
            // precedence), which the map loop enforces by skipping keys already present.
            if (partitioned.QueryParamsMember is { } queryParams)
            {
                _bindings.WriteQueryParamsMember(writer, queryParams);
            }
            // Emitted before the explicit @httpHeader members so those win on a header-name collision
            // (only possible with an empty prefix, which the Smithy spec resolves in @httpHeader's favor):
            // a later `request.Headers[name] = ...` assignment overwrites the prefix-header value.
            if (partitioned.PrefixHeadersMember is { } prefixHeaders)
            {
                _bindings.WritePrefixHeadersMember(writer, prefixHeaders.Member, prefixHeaders.Prefix);
            }
            _bindings.WriteHeaderMembers(writer, partitioned.HeaderMembers);
            AwsQueryCompatibleMarshalling.WriteQueryModeHeader(writer, context);
            _bindings.WriteResourcePath(writer, httpTrait, partitioned.LabelMembers);

            // A @httpPayload member replaces the body members. An event stream payload becomes the publisher;
            // on awsJson its siblings become the initial-request.
            if (partitioned.PayloadMember is { Type.IsEventStream: true } eventStreamPayload)
            {
                WriteEventStreamPublisher(writer, eventStreamPayload, partitioned.BodyMembers);
            }
            else if (partitioned.PayloadMember is { } payload)
            {
                WritePayloadSerialization(writer, payload, unsignedPayload, blobContentTypeEmitted);
            }
            else if (partitioned.BodyMembers.Count > 0)
            {
                WriteBodySerialization(writer, partitioned.BodyMembers);
            }
            else if (!context.UsesHttpBindings)
            {
                // awsJson1.x: "a client MUST send an empty JSON object ({}) as the request body" when the
                // operation has no input members.
                writer.WriteLine("""var content = "{}";""");
                writer.WriteLine("request.Content = System.Text.Encoding.UTF8.GetBytes(content);");
            }

            // The checksum covers the body, so it has to follow serialization (same spot as C2J).
            // TODO: flexible checksums (aws.protocols#httpChecksum, rejected by UnsupportedTraitValidator for now) need the
            // algorithm member / header name / isRequestChecksumRequired handling from BaseMarshaller.tt GenerateRequestChecksumHandling;
            // Once more protocols support it, the logic should be extracted to helper used by the request marshaller writers.
            if (requiresChecksum)
            {
                writer.WriteLine("ChecksumUtils.SetChecksumData(request);");
            }

            // @unsignedPayload disables SigV4 body signing regardless of body kind (matches C2J).
            if (unsignedPayload)
            {
                writer.WriteLine("request.DisablePayloadSigning = true;");
            }

            writer.WriteLine("");

            if (partitioned.QueryMembers.Count > 0 || partitioned.QueryParamsMember is not null)
            {
                writer.WriteLine("request.UseQueryString = true;");
                writer.WriteLine("");
            }

            if (!string.IsNullOrEmpty(hostPrefix))
            {
                MarshallerCommon.WriteHostPrefix(writer, context.BaseName, hostPrefix, partitioned.HostLabelMembers);
                writer.WriteLine("");
            }

            writer.WriteLine("return request;");
        });
    }

    private static string JsonVersion(AWSProtocol protocol) => protocol switch
    {
        AWSProtocol.AwsJson1_0 => "1.0",
        AWSProtocol.AwsJson1_1 => "1.1",
        _ => throw new GeneratorException($"Protocol '{protocol}' has no awsJson version."),
    };

    // restJson1 only. Omitted for GET/DELETE and for body-less operations, matching C2J. A blob payload
    // is the exception: its block always sets Content-Type, so when a modeled Content-Type header must
    // win the blob default is emitted here, ahead of the header, on every method. Returns whether that
    // happened (see WriteBlobPayloadSerialization). The OverrideContentType customization replaces the
    // value on every non-GET/DELETE method, body or not.
    private bool WriteContentType(CodeWriter writer, HttpTrait httpTrait, PartitionedMembers partitioned, bool modeledContentType)
    {
        // An input event stream sets its own application/vnd.amazon.eventstream Content-Type (see
        // WriteEventStreamPublisher), so the normal body Content-Type is skipped.
        if (partitioned.PayloadMember is { Type.IsEventStream: true })
        {
            return false;
        }

        var overrideContentType = context.Customizations.OverrideContentType;
        if (!string.IsNullOrEmpty(overrideContentType) && httpTrait.Method is not ("GET" or "DELETE"))
        {
            writer.WriteLine($"""request.Headers["Content-Type"] = "{overrideContentType}";""");
            return true;
        }

        if (modeledContentType && partitioned.PayloadMember is { Type.IsBlob: true } blob)
        {
            writer.WriteLine($"""request.Headers["Content-Type"] = "{blob.Type.MediaType ?? "application/octet-stream"}";""");
            return true;
        }

        var hasBody = partitioned.PayloadMember is not null || partitioned.BodyMembers.Count > 0;
        if (httpTrait.Method is "GET" or "DELETE" || !hasBody)
        {
            return false;
        }

        var contentType = "application/json";
        if (partitioned.PayloadMember is { Type.MarshalsAsString: true } payload)
        {
            contentType = payload.Type.MediaType ?? "text/plain";
        }
        writer.WriteLine($"""request.Headers["Content-Type"] = "{contentType}";""");
        return false;
    }

    private void WriteBodySerialization(CodeWriter writer, List<Member> bodyMembers)
    {
        WriteBodyScaffolding(writer, () => WriteBodyMembers(writer, bodyMembers));
    }

    // The member's .NET type is the union class name, so it names the {Stream}PublisherMarshaller; the
    // request property carries the "Publisher" suffix (see OperationWriter.ApplyEventStreamPublisher).
    // On awsJson the stream's siblings are serialized as the initial-request payload.
    private static void WriteEventStreamPublisher(CodeWriter writer, Member payload, List<Member> initialRequestMembers)
    {
        writer.WriteLine("""request.Headers["Content-Type"] = "application/vnd.amazon.eventstream";""");
        if (initialRequestMembers.Count == 0)
        {
            writer.WriteLine($"request.EventStreamPublisher = new {payload.Type.DotNetType}PublisherMarshaller(publicRequest.{payload.PropertyName}Publisher);");
            return;
        }

        WriteBodyScaffolding(writer, () => WriteBodyMembers(writer, initialRequestMembers), "initialRequest");
        writer.WriteLine($"request.EventStreamPublisher = new {payload.Type.DotNetType}PublisherMarshaller(publicRequest.{payload.PropertyName}Publisher, initialRequest);");
    }

    private static void WriteBodyMembers(CodeWriter writer, List<Member> members)
    {
        writer.WriteLine("writer.WriteStartObject();");
        writer.WriteLine("var context = new JsonMarshallerContext(request, writer);");

        foreach (var member in members)
        {
            JsonBodyMemberMarshaller.WriteBodyMember(writer, member, "publicRequest");
        }

        writer.WriteLine("");
        writer.WriteLine("writer.WriteEndObject();");
    }

    // A @httpPayload member is serialized as the ENTIRE request body, with no wrapping JSON object or
    // property name. A structure payload writes its own object braces around the target's marshaller;
    // a document payload delegates the whole body to the runtime DocumentMarshaller (no braces — the
    // document IS the complete JSON value); a string/enum payload is the raw UTF-8 body (text/plain; an
    // enum is a string shape in C2J and its ConstantClass converts implicitly to string); a blob payload
    // is the raw octet-stream body. Matches C2J output where one exists. A union is a structure (structure
    // path); a list/map payload fails loud below.
    private void WritePayloadSerialization(CodeWriter writer, Member payload, bool unsignedPayload, bool blobContentTypeEmitted)
    {
        if (payload.Type.MarshalsAsString)
        {
            // Diverges from C2J, which leaves this unguarded: GetBytes throws on null, so an unset
            // optional payload must send an empty body instead of failing before the request is sent.
            writer.OpenBlock($"if (publicRequest.IsSet{payload.PropertyName}())", () =>
            {
                writer.WriteLine($"request.Content = System.Text.Encoding.UTF8.GetBytes(publicRequest.{payload.PropertyName});");
            });
            return;
        }

        if (payload.Type.IsStructure)
        {
            WriteBodyScaffolding(writer, () =>
            {
                writer.WriteLine("var context = new JsonMarshallerContext(request, writer);");
                writer.WriteLine("context.Writer.WriteStartObject();");
                writer.WriteLine("");
                writer.WriteLine($"var marshaller = {payload.Type.MarshallerName}.Instance;");
                writer.WriteLine($"marshaller.Marshall(publicRequest.{payload.PropertyName}, context);");
                writer.WriteLine("");
                writer.WriteLine("context.Writer.WriteEndObject();");
            });
            return;
        }

        if (payload.Type.IsDocument)
        {
            // No C2J precedent — C2J represents a document as a structure and no model binds one to
            // @httpPayload. The runtime DocumentMarshaller writes the whole JSON value itself (object,
            // array, or scalar), so unlike the structure path there is no WriteStartObject/WriteEndObject
            // wrapping; it mirrors the document body-member marshaller (JsonBodyMemberMarshaller) over
            // the shared body scaffold. Content-Type stays application/json (WriteContentType).
            WriteBodyScaffolding(writer, () =>
            {
                writer.WriteLine($"Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(writer, publicRequest.{payload.PropertyName});");
            });
            return;
        }

        if (payload.Type.IsBlob)
        {
            WriteBlobPayloadSerialization(writer, payload, unsignedPayload, blobContentTypeEmitted);
            return;
        }

        throw new GeneratorException($"Unsupported @httpPayload member type '{payload.Type.DotNetType}' (member: {payload.PropertyName}).");
    }

    // A blob payload is the raw body stream; the final Content-Type overrides the one set earlier,
    // unless WriteContentType already emitted the blob's type up front (it does so when a modeled
    // Content-Type header sits between them, so the modeled header still wins when set).
    // A non-seekable stream can only fall back to chunked transfer when the body is unsigned and
    // no length is required; @requiresLength makes Content-Length mandatory, so it throws instead.
    private static void WriteBlobPayloadSerialization(CodeWriter writer, Member payload, bool unsignedPayload, bool blobContentTypeEmitted)
    {
        var streaming = payload.Type.IsStreaming;
        var requiresLength = payload.Type.RequiresLength;

        writer.WriteLine($"request.ContentStream = publicRequest.{payload.PropertyName} ?? new MemoryStream();");

        if (streaming && unsignedPayload && !requiresLength)
        {
            writer.OpenBlock("if (request.ContentStream.CanSeek)", () =>
            {
                writer.WriteLine("request.ContentStream.Seek(0, SeekOrigin.Begin);");
                writer.WriteLine("request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] = request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);");
            });
            writer.OpenBlock("else", () =>
            {
                writer.WriteLine("""request.Headers[Amazon.Util.HeaderKeys.TransferEncodingHeader] = "chunked";""");
            });
        }
        else
        {
            if (streaming && requiresLength)
            {
                writer.OpenBlock("if (!request.ContentStream.CanSeek)", () =>
                {
                    writer.WriteLine("""throw new System.InvalidOperationException("Cannot determine stream length for the payload when content-length is required.");""");
                });
            }
            writer.OpenBlock("if (request.ContentStream.CanSeek)", () =>
            {
                writer.WriteLine("request.ContentStream.Seek(0, SeekOrigin.Begin);");
            });
            writer.WriteLine("request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] = request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);");
        }

        if (!blobContentTypeEmitted)
        {
            writer.WriteLine($"""request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "{payload.Type.MediaType ?? "application/octet-stream"}";""");
        }
    }

    // Normal bodies write to the request; initial messages always need a byte array.
    private static void WriteBodyScaffolding(CodeWriter writer, Action writeContents, string? resultVariable = null)
    {
        if (resultVariable is null)
        {
            writer.WriteLine("#if !NETFRAMEWORK");
            writer.WriteLine("request.ContentStream = new PooledContentStream();");
            writer.WriteLine("using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);");
            writer.WriteLine("#else");
            writer.WriteLine("using var memoryStream = new MemoryStream();");
            writer.WriteLine("using var writer = new Utf8JsonWriter(memoryStream);");
            writer.WriteLine("#endif");
        }
        else
        {
            writer.WriteLine("using var memoryStream = new MemoryStream();");
            writer.WriteLine("using var writer = new Utf8JsonWriter(memoryStream);");
        }

        writeContents();

        writer.WriteLine("writer.Flush();");
        if (resultVariable is null)
        {
            writer.WriteLine("#if NETFRAMEWORK");
            writer.WriteLine("request.Content = memoryStream.ToArray();");
            writer.WriteLine("#endif");
        }
        else
        {
            writer.WriteLine($"var {resultVariable} = memoryStream.ToArray();");
        }
    }

    private static void WriteMarshallerDocumentation(CodeWriter writer, string operationName)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// {operationName} Request Marshaller");
        writer.WriteLine("/// </summary>");
    }

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.JsonRequestMarshallerUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
        writer.WriteLine("using System.Globalization;");
        writer.WriteLine("#if !NETFRAMEWORK");
        writer.WriteLine("using ThirdParty.RuntimeBackports;");
        writer.WriteLine("#endif");
    }
}
