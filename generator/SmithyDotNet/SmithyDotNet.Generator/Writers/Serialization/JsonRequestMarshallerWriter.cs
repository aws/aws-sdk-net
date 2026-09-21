using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source for a JSON request marshaller matching the public API surface
/// of the existing AWS SDK for .NET.
/// <para />
/// restJson1 only. Handles @httpQuery/@httpHeader/@httpLabel/body scalar members (string, enum,
/// bool, numeric, timestamp), list @httpQuery/@httpHeader (string, enum, and value-type elements), an @httpQueryParams map
/// (map&lt;string,string&gt; or map&lt;string,list&lt;string&gt;&gt;), an @httpPrefixHeaders
/// map&lt;string,string&gt;, body lists of strings or
/// structures, an @httpPayload string/structure/blob body, and the operation's @endpoint host
/// prefix with its @hostLabel members. Unsupported member shapes throw a <see cref="GeneratorException"/>.
/// </summary>
public sealed class JsonRequestMarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Request";
        var httpTrait = operation.Shape.GetHttp() ?? throw new GeneratorException($"Operation '{operation.Name}' is missing the @http trait.");
        var hostPrefix = operation.Shape.GetEndpoint()?.HostPrefix;
        var members = TypeMapper.ResolveMembers(operation.Input, context);

        var partitioned = PartitionMembers(operation.Input, members);

        // The client takes the first encoding it supports, so unsupported entries are skipped rather
        // than rejected. gzip is the whole supported set: it's emitted verbatim as an enum member and
        // CompressionEncodingAlgorithm has only NONE and gzip.
        var compression = operation.Shape.GetRequestCompression();
        var compressionEncoding = compression?.Encodings.FirstOrDefault(encoding => encoding == "gzip");
        if (compression is not null && compressionEncoding is null)
        {
            throw new GeneratorException($"Operation '{operation.Name}' requests compression encodings '{string.Join(", ", compression.Encodings)}'; only 'gzip' is supported.");
        }

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
                WriteBaseMarshallMethod(writer, className);
                writer.WriteLine("");
                WriteTypedMarshallMethod(writer, className, httpTrait, partitioned, hostPrefix, operation.Shape.HasUnsignedPayload(), compressionEncoding, operation.Shape.RequiresHttpChecksum(), operation.RequiresHttp2);
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
        PartitionedMembers partitioned,
        string? hostPrefix,
        bool unsignedPayload,
        string? compressionEncoding,
        bool requiresChecksum,
        bool requiresHttp2)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Marshall the request object to the HTTP request.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public IRequest Marshall({className} publicRequest)", () =>
        {
            writer.WriteLine($"""IRequest request = new DefaultRequest(publicRequest, "{context.Namespace}");""");
            if (requiresHttp2)
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
            var blobContentTypeEmitted = WriteContentType(writer, httpTrait, partitioned, modeledContentType);
            writer.WriteLine($"""request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "{context.ApiVersion}";""");
            writer.WriteLine($"""request.HttpMethod = "{httpTrait.Method}";""");
            writer.WriteLine("");

            WriteQueryStringMembers(writer, partitioned.QueryMembers);
            // Emitted after the explicit @httpQuery members so those win on a key collision (Smithy
            // precedence), which the map loop enforces by skipping keys already present.
            if (partitioned.QueryParamsMember is { } queryParams)
            {
                WriteQueryParamsMember(writer, queryParams);
            }
            // Emitted before the explicit @httpHeader members so those win on a header-name collision
            // (only possible with an empty prefix, which the Smithy spec resolves in @httpHeader's favor):
            // a later `request.Headers[name] = ...` assignment overwrites the prefix-header value.
            if (partitioned.PrefixHeadersMember is { } prefixHeaders)
            {
                WritePrefixHeadersMember(writer, prefixHeaders.Member, prefixHeaders.Prefix);
            }
            WriteHeaderMembers(writer, partitioned.HeaderMembers);
            WriteResourcePath(writer, httpTrait, partitioned.LabelMembers);

            // A @httpPayload member IS the whole body, so it replaces (never coexists with) normal
            // JSON body members. A @streaming union payload is an input event stream: the body is the
            // consumer's event publisher, wired here instead of serialized.
            if (partitioned.PayloadMember is { Type.IsEventStream: true } eventStreamPayload)
            {
                WriteEventStreamPublisher(writer, eventStreamPayload);
            }
            else if (partitioned.PayloadMember is { } payload)
            {
                WritePayloadSerialization(writer, payload, unsignedPayload, blobContentTypeEmitted);
            }
            else if (partitioned.BodyMembers.Count > 0)
            {
                WriteBodySerialization(writer, partitioned.BodyMembers);
            }

            // The checksum covers the body, so it has to follow serialization (same spot as C2J).
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
                WriteHostPrefix(writer, hostPrefix, partitioned.HostLabelMembers);
                writer.WriteLine("");
            }

            writer.WriteLine("return request;");
        });
    }

    private void WriteHostPrefix(CodeWriter writer, string hostPrefix, List<Member> hostLabelMembers)
    {
        if (hostLabelMembers.Count > 0)
        {
            writer.OpenBlock("var hostPrefixLabels = new", "};", () =>
            {
                foreach (var member in hostLabelMembers)
                {
                    writer.WriteLine($"{member.ModeledName} = StringUtils.FromString(publicRequest.{member.PropertyName}),");
                }
            });
            writer.WriteLine("");

            foreach (var member in hostLabelMembers)
            {
                writer.OpenBlock($"if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.{member.ModeledName}))", () =>
                {
                    writer.WriteLine($"""throw new Amazon{context.BaseName}Exception("{member.ModeledName} can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");""");
                });
            }
            writer.WriteLine("");
        }

        // {label} -> {hostPrefixLabels.label}; a prefix with no labels stays literal.
        var interpolated = hostPrefix.Replace("{", "{hostPrefixLabels.");
        writer.WriteLine($"""request.HostPrefix = $"{interpolated}";""");
    }

    // Omitted for GET/DELETE and for body-less operations, matching C2J. A blob payload is the
    // exception: its block always sets Content-Type, so when a modeled Content-Type header must win
    // the blob default is emitted here, ahead of the header, on every method. Returns whether that
    // happened (see WriteBlobPayloadSerialization). TODO: customization OverrideContentType and
    // non-restJson (application/x-amz-json) are not handled yet.
    private static bool WriteContentType(CodeWriter writer, HttpTrait httpTrait, PartitionedMembers partitioned, bool modeledContentType)
    {
        // An input event stream sets its own application/vnd.amazon.eventstream Content-Type (see
        // WriteEventStreamPublisher), so the normal body Content-Type is skipped.
        if (partitioned.PayloadMember is { Type.IsEventStream: true })
        {
            return false;
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

    // restJson1 @timestampFormat defaults for HTTP bindings when unset: http-date on a header,
    // date-time on a query/label. https://smithy.io/2.0/aws/protocols/aws-restjson1-protocol.html
    // (Body members default to epoch-seconds; see JsonBodyMemberMarshaller.)
    private const string HeaderTimestampDefault = "http-date";
    private const string QueryLabelTimestampDefault = "date-time";

    /// <summary>
    /// The <c>StringUtils</c> conversion for a scalar member in a query/header/label position, or
    /// null when the type has no string form (structures, collections). Nullable value types are
    /// unwrapped with <c>.Value</c> (timestamps keep the nullable overload); the caller guards each
    /// with an <c>IsSet</c> check first. <paramref name="timestampDefault"/> is the binding's
    /// <c>@timestampFormat</c> default, used when the member carries no explicit format.
    /// Dispatch is on <see cref="TypeDescriptor.Target"/>; an enum marshals as a <c>string</c>.
    /// </summary>
    internal static string? StringConversion(Member member, string expression, string timestampDefault) => member.Type.Target switch
    {
        StringShape or EnumShape => $"StringUtils.FromString({expression})",
        BooleanShape => $"StringUtils.FromBool({expression}.Value)",
        IntegerShape or IntEnumShape => $"StringUtils.FromInt({expression}.Value)",
        LongShape => $"StringUtils.FromLong({expression}.Value)",
        FloatShape => $"StringUtils.FromFloat({expression}.Value)",
        DoubleShape => $"StringUtils.FromDouble({expression}.Value)",
        TimestampShape => HttpBindingConversions.TimestampStringConversion(member.TimestampFormat ?? timestampDefault, expression),
        _ => null,
    };

    // The bare StringUtils.From* method name (no argument) for a non-nullable value-type collection
    // element, or null when the element has no scalar string form or is a @sparse (nullable) element.
    // Used as the lambda body in a query ConvertAll<string>(item => X(item)); elements are non-nullable
    // (List<int>), so no .Value. Timestamps use the query/label default (ISO8601) unless the element
    // carries an explicit format.
    private static string? QueryElementConverter(TypeDescriptor element)
    {
        if (element.IsNullableValueType)
        {
            return null;
        }

        return element.Target switch
        {
            BooleanShape => "StringUtils.FromBool",
            IntegerShape or IntEnumShape => "StringUtils.FromInt",
            LongShape => "StringUtils.FromLong",
            FloatShape => "StringUtils.FromFloat",
            DoubleShape => "StringUtils.FromDouble",
            TimestampShape => HttpBindingConversions.TimestampConverter(element.TimestampFormat ?? QueryLabelTimestampDefault),
            _ => null,
        };
    }

    // A list<string>/list<enum> adds its List<string> to the typed ParameterCollection directly; a
    // value-type list converts each element to a string via ConvertAll (repeated params, matching C2J).
    // A non-scalar element (blob, structure, nested collection) fails loud as it's not supported according to smithy spec
    // https://smithy.io/2.0/spec/http-bindings.html#httpquery-trait
    private void WriteQueryListMember(CodeWriter writer, Member member, string queryName, TypeDescriptor element)
    {
        if (element.MarshalsAsString)
        {
            writer.WriteLine($"""request.ParameterCollection.Add("{queryName}", publicRequest.{member.PropertyName});""");
            return;
        }

        var converter = QueryElementConverter(element)
            ?? throw new GeneratorException($"Unsupported query list element type '{element.DotNetType}' (member: {member.PropertyName}).");
        writer.WriteLine($"""request.ParameterCollection.Add("{queryName}", publicRequest.{member.PropertyName}.ConvertAll<string>(item => {converter}(item)));""");
    }

    //https://smithy.io/2.0/spec/http-bindings.html#httpquery-trait
    private void WriteQueryStringMembers(CodeWriter writer, List<(Member Member, string QueryName)> queryMembers)
    {
        // TODO: handle customizations, such as exclusions in marshalling
        foreach (var (member, queryName) in queryMembers)
        {
            // An idempotency token is auto-populated, so it is never "required from the customer".
            if (member.IsRequired && !member.IsIdempotencyToken)
            {
                // Strings and enums are checked for empty: C2J models an enum as a string shape, and a
                // ConstantClass converts implicitly to string. Anything else (a list, a reference type)
                // is checked for null.
                var guard = member.Type.MarshalsAsString
                    ? $"string.IsNullOrEmpty(publicRequest.{member.PropertyName})"
                    : $"publicRequest.{member.PropertyName} == null";
                writer.OpenBlock($"if ({guard})", () =>
                {
                    writer.WriteLine($"""throw new Amazon{context.BaseName}Exception("Request object does not have required field {member.PropertyName} set");""");
                });
                writer.WriteLine("");
            }

            writer.OpenBlock($"if (publicRequest.IsSet{member.PropertyName}())", () =>
            {
                // A list adds repeated params via the typed ParameterCollection overload;
                // request.Parameters is a string-only IDictionary facade over the same collection and
                // cannot take a List<string>. Scalars stay on StringConversion, which still throws for
                // any unsupported type.
                if (member.Type.ListElement is { } element)
                {
                    WriteQueryListMember(writer, member, queryName, element);
                }
                else
                {
                    var conversion = StringConversion(member, $"publicRequest.{member.PropertyName}", QueryLabelTimestampDefault)
                        ?? throw new GeneratorException($"Unsupported query member type '{member.Type.DotNetType}' (member: {member.PropertyName}).");
                    writer.WriteLine($"""request.Parameters.Add("{queryName}", {conversion});""");
                }
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

    // https://smithy.io/2.0/spec/http-bindings.html#httpqueryparams-trait
    // A map bound to @httpQueryParams adds each entry to the query string: map<string, string> is one
    // param per entry; map<string, list<string>> repeats the key per element (matching @httpQuery lists).
    // The ContainsKey guard skips any key an explicit @httpQuery member already set, so @httpQuery wins.
    private void WriteQueryParamsMember(CodeWriter writer, Member member)
    {
        var value = member.Type.MapValue
            ?? throw new GeneratorException($"@httpQueryParams member '{member.PropertyName}' must target a map; got '{member.Type.DotNetType}'.");

        // Smithy restricts the value to string or list<string>. A list<string> value uses the typed
        // ParameterCollection (repeated params); a string value uses the string-only Parameters facade.
        var isListValue = value.ListElement is { IsString: true };
        if (!isListValue && !value.IsString)
        {
            throw new GeneratorException($"@httpQueryParams member '{member.PropertyName}' must target a map of string or map of list of string; got a map value of '{value.DotNetType}'.");
        }

        var collection = isListValue ? "request.ParameterCollection" : "request.Parameters";
        var addValue = isListValue ? "kvp.Value" : "StringUtils.FromString(kvp.Value)";

        writer.OpenBlock($"if (publicRequest.IsSet{member.PropertyName}())", () =>
        {
            writer.OpenBlock($"foreach (var kvp in publicRequest.{member.PropertyName})", () =>
            {
                writer.OpenBlock($"if (!{collection}.ContainsKey(kvp.Key))", () =>
                {
                    writer.WriteLine($"{collection}.Add(kvp.Key, {addValue});");
                });
            });
        });
        writer.WriteLine("");
    }

    // https://smithy.io/2.0/spec/http-bindings.html#httpprefixheaders-trait
    // A map<string, string> bound to @httpPrefixHeaders emits one header per entry, named
    // {prefix}{key}. Smithy restricts the value to a string; a non-string value fails loud.
    private void WritePrefixHeadersMember(CodeWriter writer, Member member, string prefix)
    {
        var value = member.Type.MapValue
            ?? throw new GeneratorException($"@httpPrefixHeaders member '{member.PropertyName}' must target a map; got '{member.Type.DotNetType}'.");
        if (!value.IsString)
        {
            throw new GeneratorException($"@httpPrefixHeaders member '{member.PropertyName}' must target a map of string; got a map value of '{value.DotNetType}'.");
        }

        writer.OpenBlock($"if (publicRequest.IsSet{member.PropertyName}())", () =>
        {
            writer.OpenBlock($"foreach (var kvp in publicRequest.{member.PropertyName})", () =>
            {
                writer.WriteLine($$"""request.Headers[$"{{prefix}}{kvp.Key}"] = kvp.Value;""");
            });
        });
        writer.WriteLine("");
    }

    // https://smithy.io/2.0/spec/http-bindings.html#httpheader-trait
    private void WriteHeaderMembers(CodeWriter writer, List<(Member Member, string HeaderName)> headerMembers)
    {
        foreach (var (member, headerName) in headerMembers)
        {
            writer.OpenBlock($"if (publicRequest.IsSet{member.PropertyName}())", () =>
            {
                // A list header joins to one value: a list<string>/list<enum> via StringUtils.FromList
                // (RFC-7230 quoting), a value-type list via StringUtils.FromValueTypeList (bool
                // lowercased, DateTime forced to RFC822). A non-scalar element fails loud. A string/enum
                // scalar header is assigned directly (an enum's ConstantClass converts implicitly to
                // string). Other scalars go through StringUtils; an unsupported type throws.
                if (member.Type.ListElement is { } element)
                {
                    WriteHeaderListMember(writer, member, headerName, element);
                }
                else if (member.Type is { IsString: true, MediaType: not null })
                {
                    // A @mediaType string bound to a header is base64 on the wire; body-bound ones are plain.
                    writer.WriteLine($"""request.Headers["{headerName}"] = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(publicRequest.{member.PropertyName}));""");
                }
                else if (member.Type.MarshalsAsString)
                {
                    writer.WriteLine($"""request.Headers["{headerName}"] = publicRequest.{member.PropertyName};""");
                }
                else
                {
                    var conversion = StringConversion(member, $"publicRequest.{member.PropertyName}", HeaderTimestampDefault)
                        ?? throw new GeneratorException($"Unsupported header member type '{member.Type.DotNetType}' (member: {member.PropertyName}).");
                    writer.WriteLine($"""request.Headers["{headerName}"] = {conversion};""");
                }
            });
            writer.WriteLine("");
        }
    }

    // A list<string>/list<enum> comma-joins via StringUtils.FromList; a value-type list (int, long,
    // bool, double, timestamp, ...) via StringUtils.FromValueTypeList, whose List<T> overload lowercases
    // bool and forces DateTime to RFC822 (matching C2J's untyped call — the element type is inferred). A
    // non-scalar element (blob, structure, nested collection) fails loud.
    private void WriteHeaderListMember(CodeWriter writer, Member member, string headerName, TypeDescriptor element)
    {
        if (element.MarshalsAsString)
        {
            writer.WriteLine($"""request.Headers["{headerName}"] = StringUtils.FromList(publicRequest.{member.PropertyName});""");
            return;
        }
        if (!element.IsScalar || element.IsSparse)
        {
            throw new GeneratorException($"Unsupported header list element type '{element.DotNetType}' (member: {member.PropertyName}).");
        }
        // FromValueTypeList always emits RFC822 for DateTime, which matches the http-date header default.
        // An element with an explicit @timestampFormat other than http-date would be silently sent as
        // RFC822, so fail loud rather than send the wrong value (no AWS service binds such a list today).
        if (element.IsTimestamp && element.TimestampFormat is { } format && format != "http-date")
        {
            throw new GeneratorException($"@httpHeader list of timestamps with @timestampFormat '{format}' is not supported (StringUtils.FromValueTypeList always emits RFC822); member: {member.PropertyName}.");
        }
        writer.WriteLine($"""request.Headers["{headerName}"] = StringUtils.FromValueTypeList(publicRequest.{member.PropertyName});""");
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
            // A greedy label ({name+}) spans multiple path segments; C2J strips a leading '/' from the
            // value and keeps the '+' in both the AddPathResource key and ResourcePath so the runtime
            // substitution matches. https://smithy.io/2.0/spec/http-bindings.html#greedy-labels
            var greedy = httpTrait.Uri.Contains("{" + member.ModeledName + "+}");
            var valueExpr = greedy ? $"publicRequest.{member.PropertyName}.TrimStart('/')" : $"publicRequest.{member.PropertyName}";
            var conversion = StringConversion(member, valueExpr, QueryLabelTimestampDefault) ?? throw new GeneratorException($"Unsupported label member type '{member.Type.DotNetType}' (member: {member.PropertyName}).");

            writer.OpenBlock($"if (!publicRequest.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"""throw new Amazon{context.BaseName}Exception("Request object does not have required field {member.PropertyName} set");""");
            });

            var pathTemplate = greedy ? "{" + member.ModeledName + "+}" : "{" + member.ModeledName + "}";
            writer.WriteLine($"""request.AddPathResource("{pathTemplate}", {conversion});""");
            writer.WriteLine("");
        }

        if (uriParts.Length > 1)
        {
            foreach (var pair in uriParts[1].Split('&'))
            {
                // Split on the first '=' only, so a value containing '=' is preserved intact.
                var nameValue = pair.Split('=', 2);
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
                JsonBodyMemberMarshaller.WriteBodyMember(writer, member, "publicRequest");
            }

            writer.WriteLine("");
            writer.WriteLine("writer.WriteEndObject();");
        });
    }

    // A @httpPayload member is serialized as the ENTIRE request body, with no wrapping JSON object or
    // property name. A structure payload writes its own object braces around the target's marshaller;
    // a document payload delegates the whole body to the runtime DocumentMarshaller (no braces — the
    // document IS the complete JSON value); a string/enum payload is the raw UTF-8 body (text/plain; an
    // enum is a string shape in C2J and its ConstantClass converts implicitly to string); a blob payload
    // is the raw octet-stream body. Matches C2J output where one exists. A union is a structure (structure
    // path); a list/map payload fails loud below.
    // The member's .NET type is the union class name, so it names the {Stream}PublisherMarshaller; the
    // request property carries the "Publisher" suffix (see OperationWriter.ApplyEventStreamPublisher).
    private static void WriteEventStreamPublisher(CodeWriter writer, Member payload)
    {
        writer.WriteLine("""request.Headers["Content-Type"] = "application/vnd.amazon.eventstream";""");
        writer.WriteLine($"request.EventStreamPublisher = new {payload.Type.DotNetType}PublisherMarshaller(publicRequest.{payload.PropertyName}Publisher);");
    }

    private void WritePayloadSerialization(CodeWriter writer, Member payload, bool unsignedPayload, bool blobContentTypeEmitted)
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

    private static PartitionedMembers PartitionMembers(StructureShape input, List<Member> members)
    {
        var queryMembers = new List<(Member Member, string QueryName)>();
        var headerMembers = new List<(Member Member, string HeaderName)>();
        var labelMembers = new List<Member>();
        var bodyMembers = new List<Member>();
        var hostLabelMembers = new List<Member>();
        Member? payloadMember = null;
        Member? queryParamsMember = null;
        (Member Member, string Prefix)? prefixHeadersMember = null;

        foreach (var member in members)
        {
            var memberShape = input.Members[member.ModeledName];
            var httpQuery = memberShape.GetHttpQuery();
            var httpHeader = memberShape.GetHttpHeader();
            var httpPrefixHeaders = memberShape.GetHttpPrefixHeaders();

            // Anywhere else the publisher is never wired and the body path emits a marshaller that doesn't exist.
            if (member.Type.IsEventStream && !memberShape.IsHttpPayload())
            {
                throw new GeneratorException($"Event stream member '{member.PropertyName}' must be bound with @httpPayload.");
            }

            if (httpQuery is not null)
            {
                queryMembers.Add((member, httpQuery));
            }
            else if (httpHeader is not null)
            {
                headerMembers.Add((member, httpHeader));
            }
            else if (httpPrefixHeaders is not null)
            {
                // @httpPrefixHeaders is structurally exclusive — at most one member per structure.
                if (prefixHeadersMember is not null)
                {
                    throw new GeneratorException($"Operation input has more than one @httpPrefixHeaders member ('{prefixHeadersMember.Value.Member.PropertyName}' and '{member.PropertyName}'); the Smithy spec permits at most one.");
                }

                prefixHeadersMember = (member, httpPrefixHeaders);
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
            else if (memberShape.IsHttpQueryParams())
            {
                // @httpQueryParams is structurally exclusive — at most one member per structure.
                if (queryParamsMember is not null)
                {
                    throw new GeneratorException($"Operation input has more than one @httpQueryParams member ('{queryParamsMember.PropertyName}' and '{member.PropertyName}'); the Smithy spec permits at most one.");
                }

                queryParamsMember = member;
            }
            else
            {
                bodyMembers.Add(member);
            }

            // @hostLabel is additive: a member can be bound to a bucket above AND contribute to the
            // endpoint host prefix, so it is collected independently rather than in the else-if chain.
            if (memberShape.IsHostLabel())
            {
                hostLabelMembers.Add(member);
            }
        }

        // Per the Smithy spec, when a member is bound with @httpPayload every other member must be
        // bound to a header/query/label — nothing else goes in the body. Fail loud if that is violated.
        if (payloadMember is not null && bodyMembers.Count > 0)
        {
            var names = string.Join(", ", bodyMembers.Select(m => m.PropertyName));
            throw new GeneratorException($"@httpPayload member '{payloadMember.PropertyName}' cannot coexist with unbound body members ({names}); every other member must be bound to a header, query, or label.");
        }

        return new PartitionedMembers(queryMembers, headerMembers, labelMembers, bodyMembers, hostLabelMembers, payloadMember, queryParamsMember, prefixHeadersMember);
    }

    private record PartitionedMembers(
        List<(Member Member, string QueryName)> QueryMembers,
        List<(Member Member, string HeaderName)> HeaderMembers,
        List<Member> LabelMembers,
        List<Member> BodyMembers,
        List<Member> HostLabelMembers,
        Member? PayloadMember,
        Member? QueryParamsMember,
        (Member Member, string Prefix)? PrefixHeadersMember);

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
