using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for a JSON request marshaller matching the public API surface
/// of the existing AWS SDK for .NET.
/// <para />
/// restJson1 only. Handles @httpQuery/@httpHeader/@httpLabel/body scalar members (string, enum,
/// bool, numeric, timestamp), body lists of strings or structures, and an @httpPayload
/// string/structure/blob body. Unsupported member shapes throw a <see cref="GeneratorException"/>.
/// </summary>
public sealed class JsonRequestMarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Request";
        var httpTrait = operation.Shape.GetHttp() ?? throw new GeneratorException($"Operation '{operation.Name}' is missing the @http trait.");
        var members = TypeMapper.ResolveMembers(operation.Input, context);

        var partitioned = PartitionMembers(operation.Input, members);

        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            WriteMarshallerDocumentation(writer, operation.Name);
            writer.OpenBlock($"public partial class {className}Marshaller : IMarshaller<IRequest, {className}>, IMarshaller<IRequest, AmazonWebServiceRequest>", () =>
            {
                WriteBaseMarshallMethod(writer, className);
                writer.WriteLine("");
                WriteTypedMarshallMethod(writer, className, httpTrait, partitioned);
                writer.WriteLine("");
                WriteSingleton(writer, className);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteBaseMarshallMethod(CodeWriter writer, string className)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Marshall the request object to the HTTP request.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public IRequest Marshall(AmazonWebServiceRequest input)", () =>
        {
            writer.WriteLine($"return this.Marshall(({className})input);");
        });
    }

    private void WriteTypedMarshallMethod(
        CodeWriter writer,
        string className,
        HttpTrait httpTrait,
        PartitionedMembers partitioned)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Marshall the request object to the HTTP request.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public IRequest Marshall({className} publicRequest)", () =>
        {
            writer.WriteLine($"""IRequest request = new DefaultRequest(publicRequest, "{context.Namespace}");""");
            WriteContentType(writer, httpTrait, partitioned);
            writer.WriteLine($"""request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "{context.ApiVersion}";""");
            writer.WriteLine($"""request.HttpMethod = "{httpTrait.Method}";""");
            writer.WriteLine("");

            WriteQueryStringMembers(writer, partitioned.QueryMembers);
            WriteHeaderMembers(writer, partitioned.HeaderMembers);
            WriteResourcePath(writer, httpTrait, partitioned.LabelMembers);

            // A @httpPayload member IS the whole body, so it replaces (never coexists with) normal
            // JSON body members.
            if (partitioned.PayloadMember is { } payload)
            {
                WritePayloadSerialization(writer, payload);
            }
            else if (partitioned.BodyMembers.Count > 0)
            {
                WriteBodySerialization(writer, partitioned.BodyMembers);
            }

            writer.WriteLine("");

            if (partitioned.QueryMembers.Count > 0)
            {
                writer.WriteLine("request.UseQueryString = true;");
                writer.WriteLine("");
            }

            writer.WriteLine("return request;");
        });
    }

    // Content-Type mirrors C2J: omitted for GET/DELETE and for body-less operations. Otherwise a
    // string/enum @httpPayload body is text/plain and everything else (structure/blob payload or a
    // normal JSON body) is application/json — a blob payload later overrides it with
    // application/octet-stream. TODO: customization OverrideContentType and non-restJson
    // (application/x-amz-json) are not handled yet.
    private static void WriteContentType(CodeWriter writer, HttpTrait httpTrait, PartitionedMembers partitioned)
    {
        var hasBody = partitioned.PayloadMember is not null || partitioned.BodyMembers.Count > 0;
        if (httpTrait.Method is "GET" or "DELETE" || !hasBody)
        {
            return;
        }

        var contentType = partitioned.PayloadMember is { Type.MarshalsAsString: true } ? "text/plain" : "application/json";
        writer.WriteLine($"""request.Headers["Content-Type"] = "{contentType}";""");
    }

    // restJson1 @timestampFormat defaults for HTTP bindings when unset: http-date on a header,
    // date-time on a query/label. https://smithy.io/2.0/aws/protocols/aws-restjson1-protocol.html
    // (Body members default to epoch-seconds; see JsonScalarMarshaller.)
    private const string HeaderTimestampDefault = "http-date";
    private const string QueryLabelTimestampDefault = "date-time";

    /// <summary>
    /// The <c>StringUtils</c> conversion for a scalar member in a query/header/label position, or
    /// null when the type has no string form (structures, collections). Nullable value types are
    /// unwrapped with <c>.Value</c> (timestamps keep the nullable overload); the caller guards each
    /// with an <c>IsSet</c> check first. <paramref name="timestampDefault"/> is the binding's
    /// <c>@timestampFormat</c> default, used when the member carries no explicit format.
    /// Dispatch is on <see cref="TypeDescriptor.MarshalType"/> so an enum marshals as a <c>string</c>.
    /// </summary>
    internal static string? StringConversion(Member member, string expression, string timestampDefault) => member.Type.MarshalType switch
    {
        "string" => $"StringUtils.FromString({expression})",
        "bool?" => $"StringUtils.FromBool({expression}.Value)",
        "int?" => $"StringUtils.FromInt({expression}.Value)",
        "long?" => $"StringUtils.FromLong({expression}.Value)",
        "float?" => $"StringUtils.FromFloat({expression}.Value)",
        "double?" => $"StringUtils.FromDouble({expression}.Value)",
        "DateTime?" => TimestampStringConversion(member.TimestampFormat ?? timestampDefault, expression),
        _ => null,
    };

    // The StringUtils call that renders a timestamp as a string for a header/query/label position.
    private static string TimestampStringConversion(string format, string expression) => format switch
    {
        "date-time" => $"StringUtils.FromDateTimeToISO8601WithOptionalMs({expression})",
        "http-date" => $"StringUtils.FromDateTimeToRFC822({expression})",
        "epoch-seconds" => $"StringUtils.FromDateTimeToUnixTimestamp({expression})",
        _ => throw new GeneratorException($"Unsupported @timestampFormat '{format}'."),
    };

    //https://smithy.io/2.0/spec/http-bindings.html#httpquery-trait
    private void WriteQueryStringMembers(CodeWriter writer, List<(Member Member, string QueryName)> queryMembers)
    {
        foreach (var (member, queryName) in queryMembers)
        {
            var conversion = StringConversion(member, $"publicRequest.{member.PropertyName}", QueryLabelTimestampDefault)
                ?? throw new GeneratorException($"Unsupported query member type '{member.Type.DotNetType}' (member: {member.PropertyName}).");

            // An idempotency token is auto-populated, so it is never "required from the customer".
            if (member.IsRequired && !member.IsIdempotencyToken)
            {
                // A real string is checked for empty; anything else (including an enum's
                // ConstantClass, a reference type) is checked for null.
                var guard = member.Type.IsString
                    ? $"string.IsNullOrEmpty(publicRequest.{member.PropertyName})"
                    : $"publicRequest.{member.PropertyName} == null";
                writer.OpenBlock($"if ({guard})", () =>
                {
                    writer.WriteLine($"""throw new Amazon{context.ServiceName}Exception("Request object does not have required field {member.PropertyName} set");""");
                });
                writer.WriteLine("");
            }

            writer.OpenBlock($"if (publicRequest.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"""request.Parameters.Add("{queryName}", {conversion});""");
            });
            if (member.IsIdempotencyToken)
            {
                writer.OpenBlock("else", () =>
                {
                    writer.WriteLine($"""request.Parameters.Add("{queryName}", Guid.NewGuid().ToString());""");
                });
            }
            writer.WriteLine("");
        }
    }

    // https://smithy.io/2.0/spec/http-bindings.html#httpheader-trait
    private void WriteHeaderMembers(CodeWriter writer, List<(Member Member, string HeaderName)> headerMembers)
    {
        foreach (var (member, headerName) in headerMembers)
        {
            var conversion = StringConversion(member, $"publicRequest.{member.PropertyName}", HeaderTimestampDefault)
                ?? throw new GeneratorException($"Unsupported header member type '{member.Type.DotNetType}' (member: {member.PropertyName}).");
            writer.OpenBlock($"if (publicRequest.IsSet{member.PropertyName}())", () =>
            {
                // A string header is assigned directly; scalars go through StringUtils. An enum marshals
                // as a string too (implicit ConstantClass->string), so it is assigned directly as well.
                writer.WriteLine(member.Type.MarshalsAsString
                    ? $"""request.Headers["{headerName}"] = publicRequest.{member.PropertyName};"""
                    : $"""request.Headers["{headerName}"] = {conversion};""");
            });
            writer.WriteLine("");
        }
    }

    // https://smithy.io/2.0/spec/http-bindings.html#httplabel-trait
    private void WriteResourcePath(CodeWriter writer, HttpTrait httpTrait, List<Member> labelMembers)
    {
        // Split off any static query literal (e.g. "/token?aws_iam=t"): the path becomes ResourcePath,
        // each query pair becomes a sub-resource. Left in ResourcePath, the runtime percent-encodes the
        // '?' and drops the query, silently changing the request.
        var uriParts = httpTrait.Uri.Split('?');
        var path = uriParts[0];

        foreach (var member in labelMembers)
        {
            var conversion = StringConversion(member, $"publicRequest.{member.PropertyName}", QueryLabelTimestampDefault)
                ?? throw new GeneratorException($"Unsupported label member type '{member.Type.DotNetType}' (member: {member.PropertyName}).");
            writer.OpenBlock($"if (!publicRequest.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"""throw new Amazon{context.ServiceName}Exception("Request object does not have required field {member.PropertyName} set");""");
            });
            var pathTemplate = "{" + member.ModeledName + "}";
            writer.WriteLine($"""request.AddPathResource("{pathTemplate}", {conversion});""");
            writer.WriteLine("");
        }

        if (uriParts.Length > 1)
        {
            foreach (var pair in uriParts[1].Split('&'))
            {
                var nameValue = pair.Split('=');
                if (nameValue.Length == 1)
                {
                    writer.WriteLine($"""request.AddSubResource("{nameValue[0]}");""");
                }
                else
                {
                    writer.WriteLine($"""request.AddSubResource("{nameValue[0]}", "{nameValue[1]}");""");
                }
            }
        }
        writer.WriteLine($"""request.ResourcePath = "{path}";""");
    }

    private void WriteBodySerialization(CodeWriter writer, List<Member> bodyMembers)
    {
        WriteBodyScaffolding(writer, () =>
        {
            writer.WriteLine("writer.WriteStartObject();");
            writer.WriteLine("var context = new JsonMarshallerContext(request, writer);");

            foreach (var member in bodyMembers)
            {
                WriteBodyMember(writer, member);
            }

            writer.WriteLine("");
            writer.WriteLine("writer.WriteEndObject();");
        });
    }

    // A @httpPayload member is serialized as the ENTIRE request body, with no wrapping JSON object or
    // property name. A structure payload writes its own object braces around the target's marshaller;
    // a string/enum payload is the raw UTF-8 body (text/plain; an enum is a string shape in C2J and its
    // ConstantClass converts implicitly to string); a blob payload is the raw octet-stream body. Matches
    // C2J output. document/union throw earlier in TypeMapper; a list/map payload fails loud below.
    private void WritePayloadSerialization(CodeWriter writer, Member payload)
    {
        if (payload.Type.MarshalsAsString)
        {
            writer.WriteLine($"request.Content = System.Text.Encoding.UTF8.GetBytes(publicRequest.{payload.PropertyName});");
            return;
        }

        if (payload.Type.IsStructure)
        {
            WriteBodyScaffolding(writer, () =>
            {
                writer.WriteLine("var context = new JsonMarshallerContext(request, writer);");
                writer.WriteLine("context.Writer.WriteStartObject();");
                writer.WriteLine("");
                writer.WriteLine($"var marshaller = {payload.Type.DotNetType}Marshaller.Instance;");
                writer.WriteLine($"marshaller.Marshall(publicRequest.{payload.PropertyName}, context);");
                writer.WriteLine("");
                writer.WriteLine("context.Writer.WriteEndObject();");
            });
            return;
        }

        if (payload.Type.IsBlob)
        {
            // A blob payload is the raw body stream (Content-Type application/octet-stream overrides the
            // application/json set above). @streaming is denied, so the stream is always seekable here and
            // the content length is known; no chunked/unsigned-body handling is needed. Matches C2J.
            writer.WriteLine($"request.ContentStream = publicRequest.{payload.PropertyName} ?? new MemoryStream();");
            writer.OpenBlock("if (request.ContentStream.CanSeek)", () =>
            {
                writer.WriteLine("request.ContentStream.Seek(0, SeekOrigin.Begin);");
            });
            writer.WriteLine("request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] = request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);");
            writer.WriteLine("""request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "application/octet-stream";""");
            return;
        }

        throw new GeneratorException($"Unsupported @httpPayload member type '{payload.Type.DotNetType}' (member: {payload.PropertyName}); only string, structure, and blob payloads are handled.");
    }

    // The Utf8JsonWriter + Content/ContentStream scaffold shared by the normal JSON body and the
    // structure-payload body. Non-NETFRAMEWORK streams straight into a PooledContentStream; NETFRAMEWORK
    // buffers in a MemoryStream and copies to request.Content. The caller fills in the object/members.
    private static void WriteBodyScaffolding(CodeWriter writer, Action writeContents)
    {
        writer.WriteLine("#if !NETFRAMEWORK");
        writer.WriteLine("request.ContentStream = new PooledContentStream();");
        writer.WriteLine("using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);");
        writer.WriteLine("#else");
        writer.WriteLine("using var memoryStream = new MemoryStream();");
        writer.WriteLine("using var writer = new Utf8JsonWriter(memoryStream);");
        writer.WriteLine("#endif");

        writeContents();

        writer.WriteLine("writer.Flush();");
        writer.WriteLine("#if NETFRAMEWORK");
        writer.WriteLine("request.Content = memoryStream.ToArray();");
        writer.WriteLine("#endif");
    }

    private void WriteBodyMember(CodeWriter writer, Member member)
    {
        if (member.Type.IsScalar)
        {
            writer.OpenBlock($"if (publicRequest.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"""context.Writer.WritePropertyName("{member.JsonName ?? member.ModeledName}");""");
                JsonScalarMarshaller.WriteScalar(writer, member, $"publicRequest.{member.PropertyName}");
            });
            if (member.IsIdempotencyToken)
            {
                writer.OpenBlock("else", () =>
                {
                    writer.WriteLine($"""context.Writer.WritePropertyName("{member.JsonName ?? member.ModeledName}");""");
                    writer.WriteLine("context.Writer.WriteStringValue(Guid.NewGuid().ToString());");
                });
            }
        }
        // Only a list has Element set (ResolveType), so this is the list case; a map falls through.
        else if (member.Type.Element is { } element)
        {
            writer.OpenBlock($"if (publicRequest.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"""context.Writer.WritePropertyName("{member.JsonName ?? member.ModeledName}");""");
                writer.WriteLine("context.Writer.WriteStartArray();");
                writer.OpenBlock($"foreach (var publicRequest{member.PropertyName}ListValue in publicRequest.{member.PropertyName})", () =>
                {
                    WriteListElement(writer, member, element);
                });
                writer.WriteLine("context.Writer.WriteEndArray();");
            });
        }
        else
        {
            throw new GeneratorException($"Unsupported body member type '{member.Type.DotNetType}' (member: {member.PropertyName}).");
        }
    }

    private void WriteListElement(CodeWriter writer, Member member, TypeDescriptor element)
    {
        if (element.IsString)
        {
            writer.WriteLine($"context.Writer.WriteStringValue(publicRequest{member.PropertyName}ListValue);");
        }
        else if (element.IsStructure)
        {
            writer.WriteLine("context.Writer.WriteStartObject();");
            writer.WriteLine("");
            writer.WriteLine($"var marshaller = {element.DotNetType}Marshaller.Instance;");
            writer.WriteLine($"marshaller.Marshall(publicRequest{member.PropertyName}ListValue, context);");
            writer.WriteLine("");
            writer.WriteLine("context.Writer.WriteEndObject();");
        }
        else
        {
            throw new GeneratorException("Only strings and structure list element types are handled right now!");
        }
    }

    private static PartitionedMembers PartitionMembers(StructureShape input, List<Member> members)
    {
        var queryMembers = new List<(Member Member, string QueryName)>();
        var headerMembers = new List<(Member Member, string HeaderName)>();
        var labelMembers = new List<Member>();
        var bodyMembers = new List<Member>();
        Member? payloadMember = null;

        foreach (var member in members)
        {
            var memberShape = input.Members[member.ModeledName];
            var httpQuery = memberShape.GetHttpQuery();
            var httpHeader = memberShape.GetHttpHeader();

            if (httpQuery is not null)
            {
                queryMembers.Add((member, httpQuery));
            }
            else if (httpHeader is not null)
            {
                headerMembers.Add((member, httpHeader));
            }
            else if (memberShape.IsHttpLabel())
            {
                labelMembers.Add(member);
            }
            else if (memberShape.IsHttpPayload())
            {
                if (payloadMember is not null)
                {
                    throw new GeneratorException($"Operation input has more than one @httpPayload member ('{payloadMember.PropertyName}' and '{member.PropertyName}'); the Smithy spec permits at most one.");
                }

                payloadMember = member;
            }
            else
            {
                bodyMembers.Add(member);
            }
        }

        // Per the Smithy spec, when a member is bound with @httpPayload every other member must be
        // bound to a header/query/label — nothing else goes in the body. Fail loud if that is violated.
        if (payloadMember is not null && bodyMembers.Count > 0)
        {
            var names = string.Join(", ", bodyMembers.Select(m => m.PropertyName));
            throw new GeneratorException($"@httpPayload member '{payloadMember.PropertyName}' cannot coexist with unbound body members ({names}); every other member must be bound to a header, query, or label.");
        }

        return new PartitionedMembers(queryMembers, headerMembers, labelMembers, bodyMembers, payloadMember);
    }

    private record PartitionedMembers(
        List<(Member Member, string QueryName)> QueryMembers,
        List<(Member Member, string HeaderName)> HeaderMembers,
        List<Member> LabelMembers,
        List<Member> BodyMembers,
        Member? PayloadMember);

    private static void WriteMarshallerDocumentation(CodeWriter writer, string operationName)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// {operationName} Request Marshaller");
        writer.WriteLine("/// </summary>");
    }

    private static void WriteSingleton(CodeWriter writer, string className)
    {
        writer.WriteLine($"private static readonly {className}Marshaller _instance = new();");
        writer.WriteLine("");
        writer.WriteLine($"internal static {className}Marshaller GetInstance() => _instance;");
        writer.WriteLine("");
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Gets the singleton.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public static {className}Marshaller Instance => _instance;");
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
