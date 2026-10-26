using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Generation.Protocols;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source for a JSON response unmarshaller matching the public API surface
/// of the existing AWS SDK for .NET.
/// </summary>
public sealed class JsonResponseUnmarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Response";
        var unmarshallerClassName = $"{className}Unmarshaller";
        var resolvedMembers = TypeMapper.ResolveMembers(operation.Output, context);
        var members = PartitionByBinding(operation.Output, resolvedMembers, context.UsesHttpBindings);
        if (context.Customizations.WrapsOutput(operation.Name))
        {
            // A wrapped output's single member is the whole body.
            members = members with { BodyMembers = [], PayloadMember = members.BodyMembers.Single() };
        }

        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            WriteClassDocumentation(writer, operation.Name);
            writer.OpenBlock($"public partial class {unmarshallerClassName} : JsonResponseUnmarshaller", () =>
            {
                WriteUnmarshallMethod(writer, className, members, context.Protocol);
                if (members.EventStreamMember is not null && members.BodyMembers.Count > 0)
                {
                    writer.WriteLine("");
                    WriteInitialResponseUnmarshaller(writer, className, members.BodyMembers);
                }
                writer.WriteLine("");
                WriteUnmarshallExceptionMethod(writer, operation);
                writer.WriteLine("");

                if (members.PayloadMember is { Type.IsStreaming: true } || members.EventStreamMember is not null)
                {
                    MarshallerCommon.WriteHasStreamingProperty(writer);
                    writer.WriteLine("");
                }

                if (members.EventStreamMember is not null)
                {
                    MarshallerCommon.WriteShouldReadEntireResponse(writer);
                    writer.WriteLine("");
                }

                MarshallerCommon.WriteResponseUnmarshallerSingleton(writer, unmarshallerClassName);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
        FileHeader.WriteUsings(writer, FileHeader.MarshallerUsings, false);
        writer.WriteLine("using System.Text.Json;");
        writer.WriteLine("using System.Globalization;");
        writer.WriteLine("using Amazon.Util;");
    }

    private static void WriteClassDocumentation(CodeWriter writer, string operationName)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Response Unmarshaller for {operationName} operation.");
        writer.WriteLine("/// </summary>");
    }

    private static void WriteUnmarshallMethod(CodeWriter writer, string className, PartitionedMembers members, AWSProtocol protocol)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshaller the response from the service to the response class.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)", () =>
        {
            writer.WriteLine($"var unmarshalledObject = new {className}();");

            if (members.EventStreamMember is { } eventStream)
            {
                MarshallerCommon.WriteEventStreamMember(writer, eventStream);
                if (members.BodyMembers.Count > 0)
                {
                    writer.WriteLine($"unmarshalledObject.{eventStream.PropertyName}.InitialResponseReceived += (sender, args) => UnmarshallInitialResponse(unmarshalledObject, args.EventStreamEvent);");
                }
            }
            // A @httpPayload member IS the whole body (it replaces normal body members); otherwise the
            // body members are read from the JSON payload. A response with only header (or no) members
            // emits no reader/loop.
            else if (members.PayloadMember is { } payload)
            {
                MarshallerCommon.WritePayloadUnmarshall(writer, payload, protocol);
            }
            else if (members.BodyMembers.Count > 0)
            {
                writer.WriteLine("var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);");
                writer.WriteLine();
                WriteBodyReadLoop(writer, members.BodyMembers);
            }
            WriteHeaderUnmarshallers(writer, members.HeaderMembers);

            if (members.PrefixHeadersMember is { } prefixHeaders)
            {
                WritePrefixHeadersUnmarshaller(writer, prefixHeaders.Member, prefixHeaders.Prefix);
            }

            // A @httpResponseCode member is populated from the HTTP status code itself, not read from
            // the body or a header. The member's property name is whatever the model named it.
            if (members.StatusCodeMember is { } statusCode)
            {
                writer.WriteLine($"unmarshalledObject.{statusCode.PropertyName} = (int)context.ResponseData.StatusCode;");
            }

            writer.WriteLine("");
            writer.WriteLine("return unmarshalledObject;");
        });
    }

    private static void WriteInitialResponseUnmarshaller(CodeWriter writer, string className, List<Member> members)
    {
        writer.OpenBlock($"private static void UnmarshallInitialResponse({className} unmarshalledObject, Amazon.Runtime.EventStreams.Internal.InitialResponseEvent initialResponse)", () =>
        {
            writer.WriteLine("var context = new JsonUnmarshallerContext(initialResponse.Payload, false, null);");
            writer.WriteLine("var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);");
            writer.WriteLine();
            WriteBodyReadLoop(writer, members);
        });
    }

    // The JSON body reader loop over the in-scope `reader`, shared by the response and exception
    // unmarshallers. The caller sets `reader` up first — the response constructs its own, the exception
    // uses the passed `ref reader` guarded on stream length — which is the only part that differs.
    internal static void WriteBodyReadLoop(CodeWriter writer, List<Member> bodyMembers)
    {
        writer.WriteLine("context.Read(ref reader);");
        writer.WriteLine("int targetDepth = context.CurrentDepth;");
        writer.OpenBlock("while (context.ReadAtDepth(targetDepth, ref reader))", () =>
        {
            JsonBodyMemberUnmarshaller.WriteMemberUnmarshallers(writer, bodyMembers);
        });
    }

    /// <summary>
    /// Splits members into those bound to a response header (<c>@httpHeader</c>, paired with the header
    /// name), the single <c>@httpPayload</c> member (if any), the single <c>@httpResponseCode</c> member
    /// (if any), the single <c>@httpPrefixHeaders</c> member (if any, paired with its prefix), and those
    /// read from the JSON body. Header and prefix-header members are populated from
    /// <c>context.ResponseData</c>; a payload member is the entire body; a response-code member is set
    /// from the HTTP status code. Shared with the exception unmarshaller.
    ///
    /// <para><c>@httpResponseCode</c> is only meaningful on an operation's output; on an error it "is
    /// simply ignored" per the Smithy spec, so the exception unmarshaller passes
    /// <paramref name="bindStatusCode"/> <c>false</c> and the member falls through to the body.</para>
    ///
    /// <para>With <paramref name="httpBindings"/> <c>false</c> (awsJson1.x) the binding traits are ignored,
    /// as that protocol requires, and every member except an event stream is a body member; the stream's
    /// siblings come from the initial-response message. With HTTP bindings the stream is the whole body, so
    /// body siblings fail loud.</para>
    /// </summary>
    internal static PartitionedMembers PartitionByBinding(
        StructureShape structure, List<Member> members, bool httpBindings, bool bindStatusCode = true)
    {
        var headerMembers = new List<(Member, string)>();
        var bodyMembers = new List<Member>();
        Member? payloadMember = null;
        Member? statusCodeMember = null;
        Member? eventStreamMember = null;
        (Member Member, string Prefix)? prefixHeadersMember = null;
        foreach (var member in members)
        {
            var memberShape = structure.Members[member.ModeledName];
            if (member.Type.IsEventStream)
            {
                // A @streaming union/structure member is the event stream — it IS the body (like a
                // payload): the unmarshaller hands the raw response stream to the generated
                // EnumerableEventOutputStream subclass rather than reading JSON.
                if (eventStreamMember is not null)
                {
                    throw new GeneratorException($"Structure has more than one event-stream member ('{eventStreamMember.PropertyName}' and '{member.PropertyName}'); the Smithy spec permits at most one.");
                }

                eventStreamMember = member;
            }
            else if (!httpBindings)
            {
                bodyMembers.Add(member);
            }
            else if (memberShape.GetHttpHeader() is string headerName)
            {
                headerMembers.Add((member, headerName));
            }
            else if (memberShape.GetHttpPrefixHeaders() is string prefix)
            {
                // @httpPrefixHeaders is structurally exclusive — at most one member per structure.
                if (prefixHeadersMember is not null)
                {
                    throw new GeneratorException($"Structure has more than one @httpPrefixHeaders member ('{prefixHeadersMember.Value.Member.PropertyName}' and '{member.PropertyName}'); the Smithy spec permits at most one.");
                }

                prefixHeadersMember = (member, prefix);
            }
            else if (memberShape.IsHttpPayload())
            {
                if (payloadMember is not null)
                {
                    throw new GeneratorException($"Structure has more than one @httpPayload member ('{payloadMember.PropertyName}' and '{member.PropertyName}'); the Smithy spec permits at most one.");
                }

                payloadMember = member;
            }
            else if (bindStatusCode && memberShape.IsHttpResponseCode())
            {
                if (statusCodeMember is not null)
                {
                    throw new GeneratorException($"Structure has more than one @httpResponseCode member ('{statusCodeMember.PropertyName}' and '{member.PropertyName}'); the Smithy spec permits at most one.");
                }

                statusCodeMember = member;
            }
            else
            {
                bodyMembers.Add(member);
            }
        }

        // When a @httpPayload member is present it IS the body, so no other member may be in the body
        // (all others must be header-bound). Fail loud if that spec rule is violated.
        if (payloadMember is not null && bodyMembers.Count > 0)
        {
            var names = string.Join(", ", bodyMembers.Select(m => m.PropertyName));
            throw new GeneratorException($"@httpPayload member '{payloadMember.PropertyName}' cannot coexist with body members ({names}); every other member must be bound to a header.");
        }

        // REST protocols bind initial-response members outside the HTTP body. RPC protocols carry them
        // in the event stream's initial-response message.
        if (httpBindings && eventStreamMember is not null && bodyMembers.Count > 0)
        {
            var names = string.Join(", ", bodyMembers.Select(m => m.PropertyName));
            throw new GeneratorException($"Event stream member '{eventStreamMember.PropertyName}' cannot coexist with body members ({names}); every other member must be bound to a header.");
        }

        return new PartitionedMembers(headerMembers, bodyMembers, payloadMember, statusCodeMember, prefixHeadersMember, eventStreamMember);
    }

    /// <summary>
    /// An output or error structure's members grouped by HTTP binding: header members (with their
    /// header names), unbound body members, the single <c>@httpPayload</c> member (if any), the single
    /// <c>@httpResponseCode</c> member (if any), and the single <c>@httpPrefixHeaders</c> member (if any).
    /// Mirrors the request side's partition record.
    /// </summary>
    internal sealed record PartitionedMembers(
        List<(Member Member, string HeaderName)> HeaderMembers,
        List<Member> BodyMembers,
        Member? PayloadMember,
        Member? StatusCodeMember,
        (Member Member, string Prefix)? PrefixHeadersMember,
        Member? EventStreamMember);

    // Emits `if (context.ResponseData.IsHeaderPresent("name")) unmarshalledObject.Property = <conversion>;`
    // per header member, into the in-scope `unmarshalledObject` local. Shared with the exception
    // unmarshaller and the restXml response/exception unmarshallers.
    internal static void WriteHeaderUnmarshallers(CodeWriter writer, List<(Member Member, string HeaderName)> headerMembers)
    {
        foreach (var (member, headerName) in headerMembers)
        {
            // TODO: no service names an unmarshaller for a response header swap yet; the header conversion would need it.
            if (member.Type.UnmarshallerOverride is not null)
            {
                throw new GeneratorException($"dataTypeSwap on response header member '{member.PropertyName}' is not supported yet.");
            }

            writer.OpenBlock($"""if (context.ResponseData.IsHeaderPresent("{headerName}"))""", () =>
            {
                // A @mediaType string header is base64 on the wire.
                if (member.Type is { IsString: true, MediaType: not null })
                {
                    writer.WriteLine($"""var headerBytes = Convert.FromBase64String(context.ResponseData.GetHeaderValue("{headerName}"));""");
                    writer.WriteLine($"unmarshalledObject.{member.PropertyName} = System.Text.Encoding.UTF8.GetString(headerBytes, 0, headerBytes.Length);");
                }
                else
                {
                    var conversion = HeaderValueConversion(member, $"""context.ResponseData.GetHeaderValue("{headerName}")""");
                    writer.WriteLine($"unmarshalledObject.{member.PropertyName} = {conversion};");
                }
            });
        }
    }

    // https://smithy.io/2.0/spec/http-bindings.html#httpprefixheaders-trait
    // Collects every response header whose name starts with the member's prefix into a
    // map<string, string>, stripping the prefix from each key. An empty prefix (the ".Length > 0"
    // guard is false) collects all headers. Shared with the exception and restXml unmarshallers (all use the
    // `unmarshalledObject` local). Smithy restricts the map value to a string; a non-string value fails
    // loud. Only assigned when non-empty, matching C2J.
    internal static void WritePrefixHeadersUnmarshaller(CodeWriter writer, Member member, string prefix)
    {
        var value = member.Type.MapValue
            ?? throw new GeneratorException($"@httpPrefixHeaders member '{member.PropertyName}' must target a map; got '{member.Type.DotNetType}'.");
        if (!value.IsString)
        {
            throw new GeneratorException($"@httpPrefixHeaders member '{member.PropertyName}' must target a map of string; got a map value of '{value.DotNetType}'.");
        }

        // Local name matches C2J's `headersFor{Property}` so the generated marshaller lines up with the
        // legacy output when cross-referencing.
        var local = $"headersFor{member.PropertyName}";
        writer.WriteLine($"var {local} = new Dictionary<string, string>();");
        writer.OpenBlock("foreach (var headerName in context.ResponseData.GetHeaderNames())", () =>
        {
            writer.WriteLine("var keyToUse = headerName;");
            writer.OpenBlock($$"""if ("{{prefix}}".Length > 0 && keyToUse.StartsWith("{{prefix}}"))""", () =>
            {
                writer.WriteLine($$"""keyToUse = keyToUse.Substring("{{prefix}}".Length);""");
            });
            writer.OpenBlock($$"""if (context.ResponseData.IsHeaderPresent($"{{prefix}}{keyToUse}"))""", () =>
            {
                writer.WriteLine($$"""{{local}}.Add(keyToUse, context.ResponseData.GetHeaderValue($"{{prefix}}{keyToUse}"));""");
            });
        });
        writer.OpenBlock($"if ({local}.Count > 0)", () =>
        {
            writer.WriteLine($"unmarshalledObject.{member.PropertyName} = {local};");
        });
    }

    /// <summary>
    /// The right-hand side that reads a scalar member from the header value <paramref name="value"/>
    /// (e.g. <c>context.ResponseData.GetHeaderValue("x-foo")</c>). A string/enum takes the value
    /// directly; <c>bool</c> parses without a culture (its two literals are culture-invariant); numeric
    /// scalars parse with the invariant culture; a timestamp parses per its resolved
    /// <c>@timestampFormat</c>. Dispatch is on <see cref="TypeDescriptor.Target"/>; an enum reads as a
    /// <c>string</c> (implicit ConstantClass conversion).
    /// </summary>
    internal static string HeaderValueConversion(Member member, string value)
    {
        // A list<T> @httpHeader is a multi-value header parsed by MultiValueHeaderParser (matches C2J):
        // strings/enums via ToStringList, timestamps via ToDateTimeList with the C2J format name,
        // other value types via the generic ToValueTypeList<T>. Handled before the scalar switch.
        if (member.Type.ListElement is { } element)
        {
            return MultiValueHeaderConversion(member, element, value);
        }

        // A timestamp needs a second axis — its resolved @timestampFormat — so it is handled before the
        // scalar switch. restJson1's header default when unset (null) is http-date; epoch-seconds is an
        // integer count fed to the Unix-epoch helper, while date-time and http-date both parse via
        // DateTime.Parse (the wire forms differ but the parser handles both).
        // https://smithy.io/2.0/aws/protocols/aws-restjson1-protocol.html
        if (member.Type.IsTimestamp)
        {
            return member.TimestampFormat switch
            {
                "epoch-seconds" => $"Amazon.Util.AWSSDKUtils.ConvertFromUnixEpochSeconds(int.Parse({value}, CultureInfo.InvariantCulture))",
                "date-time" or "http-date" or null => $"DateTime.Parse({value}, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal)",
                _ => throw new GeneratorException($"Unsupported @timestampFormat '{member.TimestampFormat}'."),
            };
        }

        return member.Type.Target switch
        {
            StringShape or EnumShape => value,
            BooleanShape => $"bool.Parse({value})",
            IntegerShape or IntEnumShape => $"int.Parse({value}, CultureInfo.InvariantCulture)",
            LongShape => $"long.Parse({value}, CultureInfo.InvariantCulture)",
            FloatShape => $"float.Parse({value}, CultureInfo.InvariantCulture)",
            DoubleShape => $"double.Parse({value}, CultureInfo.InvariantCulture)",
            _ => throw new GeneratorException($"Unsupported header member type '{member.Type.DotNetType}' (member: {member.PropertyName})."),
        };
    }

    /// <summary>
    /// The right-hand side that reads a <c>list&lt;T&gt;</c> multi-value header from
    /// <paramref name="value"/> via <c>MultiValueHeaderParser</c> (matches C2J). A string/enum element
    /// uses <c>ToStringList</c>; a timestamp element uses <c>ToDateTimeList</c> with the C2J format name
    /// (header default RFC822 when unset); another value type uses the generic <c>ToValueTypeList&lt;T&gt;</c>
    /// over the non-nullable element type. A non-scalar element (blob, structure, nested collection) fails loud.
    /// </summary>
    private static string MultiValueHeaderConversion(Member member, TypeDescriptor element, string value)
    {
        if (element.MarshalsAsString)
        {
            return $"MultiValueHeaderParser.ToStringList({value})";
        }
        if (element is { IsTimestamp: true, IsSparse: false })
        {
            // A header timestamp list defaults to http-date when the element carries no @timestampFormat
            // (restJson1's header binding default); the shared helper maps it to the runtime parser's name.
            var format = HttpBindingConversions.TimestampFormatName(element.TimestampFormat ?? "http-date");
            return $"""MultiValueHeaderParser.ToDateTimeList({value}, "{format}")""";
        }
        if (element is { IsScalar: true, IsSparse: false })
        {
            return $"MultiValueHeaderParser.ToValueTypeList<{element.DotNetType}>({value})";
        }
        throw new GeneratorException($"Unsupported header list element type '{element.DotNetType}' (member: {member.PropertyName}).");
    }

    private void WriteUnmarshallExceptionMethod(CodeWriter writer, Operation operation)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshall error response to exception.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)", () =>
        {
            writer.WriteLine("var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);");
            writer.WriteLine("var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);");
            writer.WriteLine();
            writer.WriteLine("errorResponse.InnerException = innerException;");
            writer.WriteLine("errorResponse.StatusCode = statusCode;");
            writer.WriteLine("");
            writer.WriteLine("var responseBodyBytes = context.GetResponseBodyBytes();");
            writer.WriteLine("");

            writer.OpenBlock("using (var streamCopy = new MemoryStream(responseBodyBytes))", "}", () =>
            {
                writer.OpenBlock($"using (var contextCopy = new JsonUnmarshallerContext(streamCopy, {AwsQueryCompatibleMarshalling.MaintainResponseBody(context)}, context.ResponseData))", "}", () =>
                {
                    writer.WriteLine("var readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);");
                    var errorCode = AwsQueryCompatibleMarshalling.WriteErrorCodeSource(writer, context);

                    foreach (var error in operation.Errors)
                    {
                        // The wire code is the shape name even when the service renames the shape.
                        var exceptionClassName = ExceptionWriter.ToExceptionName(context.ToDotNetName(error.Id));
                        writer.OpenBlock($"""if ({errorCode} != null && {errorCode}.Equals("{error.Id.Name}"))""", () =>
                        {
                            writer.WriteLine($"return {exceptionClassName}Unmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);");
                        });
                    }
                });
            });

            writer.WriteLine($"return new Amazon{context.BaseName}Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);");
        });
    }

}
