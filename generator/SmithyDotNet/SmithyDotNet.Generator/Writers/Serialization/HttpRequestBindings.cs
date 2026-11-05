using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// The HTTP binding half of a request marshaller — <c>@httpQuery</c>/<c>@httpQueryParams</c>,
/// <c>@httpHeader</c>/<c>@httpPrefixHeaders</c>, and <c>@httpLabel</c> path members — shared by the
/// restJson1 (<see cref="JsonRequestMarshallerWriter"/>) and restXml (<see cref="XmlRequestMarshallerWriter"/>)
/// marshallers. The protocols differ only in how the body is serialized.
/// </summary>
public sealed class HttpRequestBindings(GenerationContext context)
{
    // HTTP-binding @timestampFormat defaults when unset: http-date on a header, date-time on a
    // query/label. Shared by both protocols (body members default differently — epoch-seconds for JSON,
    // date-time for XML — and that default stays at the body call site).
    // https://smithy.io/2.0/aws/protocols/aws-restjson1-protocol.html
    public const string HeaderTimestampDefault = "http-date";
    public const string QueryLabelTimestampDefault = "date-time";

    /// <summary>
    /// The <c>StringUtils</c> conversion for a scalar member in a query/header/label position, or
    /// null when the type has no string form (structures, collections). Nullable value types are
    /// unwrapped with <c>.Value</c> (timestamps keep the nullable overload); the caller guards each
    /// with an <c>IsSet</c> check first. <paramref name="timestampDefault"/> is the binding's
    /// <c>@timestampFormat</c> default, used when the member carries no explicit format.
    /// Dispatch is on <see cref="TypeDescriptor.Target"/>; an enum marshals as a <c>string</c>.
    /// </summary>
    internal static string? StringConversion(Member member, string expression, string timestampDefault) => member.Type.MarshallerOverride is { } marshaller
        ? $"{marshaller}({expression})"
        : member.Type.Target switch
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
    public void WriteQueryStringMembers(CodeWriter writer, List<(Member Member, string QueryName)> queryMembers)
    {
        // TODO: handle customizations, such as exclusions in marshalling
        foreach (var (member, queryName) in queryMembers)
        {
            // An idempotency token is auto-populated, so it is never "required from the customer".
            if (member.IsRequired && !member.IsIdempotencyToken)
            {
                // Strings and enums are checked for empty: C2J models an enum as a string shape, and a
                // ConstantClass converts implicitly to string. Anything else (a list, a reference type, a
                // member converted by its dataTypeSwap marshaller, whose type may not be a string) is checked for null.
                var guard = member.Type.MarshalsAsString && member.Type.MarshallerOverride is null
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
    public void WriteQueryParamsMember(CodeWriter writer, Member member)
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
    public void WritePrefixHeadersMember(CodeWriter writer, Member member, string prefix)
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
    public void WriteHeaderMembers(CodeWriter writer, List<(Member Member, string HeaderName)> headerMembers)
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
                if (member.Type.MarshallerOverride is { } marshaller)
                {
                    writer.WriteLine($"""request.Headers["{headerName}"] = {marshaller}(publicRequest.{member.PropertyName});""");
                }
                else if (member.Type.ListElement is { } element)
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
    public void WriteResourcePath(CodeWriter writer, HttpTrait httpTrait, List<Member> labelMembers)
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
            var pathTemplate = greedy ? "{" + member.ModeledName + "+}" : "{" + member.ModeledName + "}";

            if (context.Customizations.SkipUriPropertyValidation.Contains(member.PropertyName))
            {
                // skipUriPropertyValidation: no required check — an unset label sends an empty segment (C2J parity).
                writer.WriteLine($"""request.AddPathResource("{pathTemplate}", publicRequest.IsSet{member.PropertyName}() ? {conversion} : string.Empty);""");
            }
            else
            {
                writer.OpenBlock($"if (!publicRequest.IsSet{member.PropertyName}())", () =>
                {
                    writer.WriteLine($"""throw new Amazon{context.BaseName}Exception("Request object does not have required field {member.PropertyName} set");""");
                });

                writer.WriteLine($"""request.AddPathResource("{pathTemplate}", {conversion});""");
            }
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

    // With httpBindings false (awsJson1.x) every member is a body member and the binding traits are
    // ignored, as the protocol requires; @hostLabel is not an HTTP binding and still applies. An input
    // event stream is the payload on either protocol.
    public static PartitionedMembers PartitionMembers(StructureShape input, List<Member> members, bool httpBindings)
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

            if (member.Type.IsEventStream)
            {
                // Anywhere else the publisher is never wired and the body path emits a marshaller that doesn't exist.
                if (httpBindings && !memberShape.IsHttpPayload())
                {
                    throw new GeneratorException($"Event stream member '{member.PropertyName}' must be bound with @httpPayload.");
                }
            }

            if (!httpBindings)
            {
                if (member.Type.IsEventStream)
                {
                    payloadMember = member;
                }
                else
                {
                    bodyMembers.Add(member);
                }
            }
            else if (httpQuery is not null)
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

        // On HTTP protocols, @httpPayload excludes other body members. On awsJson the stream is the
        // payload and its siblings are serialized into the initial-request message.
        if (httpBindings && payloadMember is not null && bodyMembers.Count > 0)
        {
            var names = string.Join(", ", bodyMembers.Select(m => m.PropertyName));
            throw new GeneratorException($"@httpPayload member '{payloadMember.PropertyName}' cannot coexist with unbound body members ({names}); every other member must be bound to a header, query, or label.");
        }

        return new PartitionedMembers(queryMembers, headerMembers, labelMembers, bodyMembers, hostLabelMembers, payloadMember, queryParamsMember, prefixHeadersMember);
    }
}

/// <summary>
/// A request structure's members grouped by HTTP binding bucket. Shared by the restJson1 and restXml
/// request marshallers.
/// </summary>
public record PartitionedMembers(
    List<(Member Member, string QueryName)> QueryMembers,
    List<(Member Member, string HeaderName)> HeaderMembers,
    List<Member> LabelMembers,
    List<Member> BodyMembers,
    List<Member> HostLabelMembers,
    Member? PayloadMember,
    Member? QueryParamsMember,
    (Member Member, string Prefix)? PrefixHeadersMember);
