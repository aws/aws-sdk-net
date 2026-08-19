using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers;

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
        var members = TypeMapper.ResolveMembers(operation.Output, context);
        var (headerMembers, bodyMembers) = PartitionByBinding(operation.Output, members);

        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            WriteClassDocumentation(writer, operation.Name);
            writer.OpenBlock($"public partial class {unmarshallerClassName} : JsonResponseUnmarshaller", () =>
            {
                WriteUnmarshallMethod(writer, className, headerMembers, bodyMembers);
                writer.WriteLine("");
                WriteUnmarshallExceptionMethod(writer, operation);
                writer.WriteLine("");
                WriteSingleton(writer, unmarshallerClassName);
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

    private static void WriteUnmarshallMethod(
        CodeWriter writer,
        string className,
        List<(Member Member, string HeaderName)> headerMembers,
        List<Member> bodyMembers)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshaller the response from the service to the response class.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)", () =>
        {
            writer.WriteLine($"{className} response = new {className}();");

            // Only body members are read from the JSON payload, so a response with only header (or no)
            // members emits no reader/loop.
            if (bodyMembers.Count > 0)
            {
                writer.WriteLine("StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);");
                writer.WriteLine();
                writer.WriteLine("context.Read(ref reader);");
                writer.WriteLine("int targetDepth = context.CurrentDepth;");
                writer.OpenBlock("while (context.ReadAtDepth(targetDepth, ref reader))", () =>
                {
                    WriteMemberUnmarshallers(writer, bodyMembers);
                });
            }
            WriteHeaderUnmarshallers(writer, headerMembers, "response");

            writer.WriteLine("");
            writer.WriteLine("return response;");
        });
    }

    private static void WriteMemberUnmarshallers(CodeWriter writer, List<Member> members)
    {
        for (int i = 0; i < members.Count; i++)
        {
            var member = members[i];
            var wireName = member.JsonName ?? member.ModeledName;

            writer.OpenBlock($"""if (context.TestExpression("{wireName}", targetDepth, ref reader))""", () =>
            {
                WriteMemberUnmarshall(writer, member, "response");
                writer.WriteLine("continue;");
            });

            if (i < members.Count - 1)
            {
                writer.WriteLine();
            }
        }
    }

    /// <summary>
    /// The runtime <c>Amazon.Runtime.Internal.Transform</c> unmarshaller type for a member's
    /// <see cref="Member.MarshalType"/> (the .NET type for plain scalars; <c>string</c> for enums, so an
    /// enum member unmarshals via <c>StringUnmarshaller</c> and the implicit string-to-ConstantClass
    /// conversion), or null when the type is not a supported scalar. Timestamps follow the JSON-protocol
    /// default (epoch seconds via the nullable <c>DateTime</c> unmarshaller).
    /// </summary>
    internal static string? ScalarUnmarshaller(string marshalType) => marshalType switch
    {
        "string" => "StringUnmarshaller",
        "bool?" => "NullableBoolUnmarshaller",
        "int?" => "NullableIntUnmarshaller",
        "long?" => "NullableLongUnmarshaller",
        "float?" => "NullableFloatUnmarshaller",
        "double?" => "NullableDoubleUnmarshaller",
        "DateTime?" => "NullableDateTimeUnmarshaller",
        _ => null,
    };

    // Scalar / list-of-structure / structure dispatch shared with the exception unmarshaller;
    // <paramref name="target"/> is the local being populated ("response" or "unmarshalledObject").
    // Only types used by CloudTrailData and the supported scalars are handled for now.
    internal static void WriteMemberUnmarshall(CodeWriter writer, Member member, string target)
    {
        if (ScalarUnmarshaller(member.MarshalType) is string scalarUnmarshaller)
        {
            writer.WriteLine($"var unmarshaller = {scalarUnmarshaller}.Instance;");
            writer.WriteLine($"{target}.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
        }
        else if (member.IsCollection && member.IsElementStructure)
        {
            var elementType = member.ElementType ?? throw new GeneratorException($"List member '{member.PropertyName}' has no element type.");
            var unmarshallerType = $"{elementType}Unmarshaller";
            writer.WriteLine($"var unmarshaller = new JsonListUnmarshaller<{elementType}, {unmarshallerType}>({unmarshallerType}.Instance);");
            writer.WriteLine($"{target}.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
        }
        else if (member.IsStructure)
        {
            var unmarshallerType = $"{member.DotNetType}Unmarshaller";
            writer.WriteLine($"var unmarshaller = {unmarshallerType}.Instance;");
            writer.WriteLine($"{target}.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
        }
        else
        {
            throw new GeneratorException($"Unsupported member type '{member.DotNetType}' for member '{member.PropertyName}'.");
        }
    }

    /// <summary>
    /// Splits members into those bound to a response header (<c>@httpHeader</c>, paired with the header
    /// name) and those read from the JSON body. Header members are populated from
    /// <c>context.ResponseData</c> rather than the body reader. Shared with the exception unmarshaller.
    /// </summary>
    internal static (List<(Member Member, string HeaderName)> HeaderMembers, List<Member> BodyMembers) PartitionByBinding(
        StructureShape structure, List<Member> members)
    {
        var headerMembers = new List<(Member, string)>();
        var bodyMembers = new List<Member>();
        foreach (var member in members)
        {
            if (structure.Members[member.ModeledName].GetHttpHeader() is string headerName)
            {
                headerMembers.Add((member, headerName));
            }
            else
            {
                bodyMembers.Add(member);
            }
        }

        return (headerMembers, bodyMembers);
    }

    // Emits `if (context.ResponseData.IsHeaderPresent("name")) target.Property = <conversion>;` per
    // header member. Shared with the exception unmarshaller; <paramref name="target"/> is the local
    // being populated ("response" or "unmarshalledObject").
    internal static void WriteHeaderUnmarshallers(CodeWriter writer, List<(Member Member, string HeaderName)> headerMembers, string target)
    {
        foreach (var (member, headerName) in headerMembers)
        {
            var conversion = HeaderValueConversion(member, $"""context.ResponseData.GetHeaderValue("{headerName}")""");
            writer.OpenBlock($"""if (context.ResponseData.IsHeaderPresent("{headerName}"))""", () =>
            {
                writer.WriteLine($"{target}.{member.PropertyName} = {conversion};");
            });
        }
    }

    /// <summary>
    /// The right-hand side that reads a scalar member from the header value <paramref name="value"/>
    /// (e.g. <c>context.ResponseData.GetHeaderValue("x-foo")</c>). A string/enum takes the value
    /// directly; <c>bool</c> parses without a culture (its two literals are culture-invariant); numeric
    /// scalars parse with the invariant culture; a timestamp parses per its resolved
    /// <c>@timestampFormat</c>. Dispatch is on <see cref="Member.MarshalType"/> so an enum rides the
    /// string path (implicit ConstantClass conversion).
    /// </summary>
    internal static string HeaderValueConversion(Member member, string value)
    {
        // A timestamp needs a second axis — its resolved @timestampFormat — so it is handled before the
        // scalar switch. restJson1's header default when unset (null) is http-date; epoch-seconds is an
        // integer count fed to the Unix-epoch helper, while date-time and http-date both parse via
        // DateTime.Parse (the wire forms differ but the parser handles both).
        // https://smithy.io/2.0/aws/protocols/aws-restjson1-protocol.html
        if (member.MarshalType == "DateTime?")
        {
            return member.TimestampFormat switch
            {
                "epoch-seconds" => $"Amazon.Util.AWSSDKUtils.ConvertFromUnixEpochSeconds(int.Parse({value}, CultureInfo.InvariantCulture))",
                "date-time" or "http-date" or null => $"DateTime.Parse({value}, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal)",
                _ => throw new GeneratorException($"Unsupported @timestampFormat '{member.TimestampFormat}'."),
            };
        }

        return member.MarshalType switch
        {
            "string" => value,
            "bool?" => $"bool.Parse({value})",
            "int?" => $"int.Parse({value}, CultureInfo.InvariantCulture)",
            "long?" => $"long.Parse({value}, CultureInfo.InvariantCulture)",
            "float?" => $"float.Parse({value}, CultureInfo.InvariantCulture)",
            "double?" => $"double.Parse({value}, CultureInfo.InvariantCulture)",
            // TODO: a list/set bound to @httpHeader (a multi-value header) has a List<T> MarshalType and
            // falls through here. C2J parses these via MultiValueHeaderParser (ToStringList /
            // ToValueTypeList<T> / ToDateTimeList).
            _ => throw new GeneratorException($"Unsupported header member type '{member.DotNetType}' (member: {member.PropertyName})."),
        };
    }

    private void WriteUnmarshallExceptionMethod(CodeWriter writer, Operation operation)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshall error response to exception.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)", () =>
        {
            writer.WriteLine("StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);");
            writer.WriteLine("var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);");
            writer.WriteLine();
            writer.WriteLine("errorResponse.InnerException = innerException;");
            writer.WriteLine("errorResponse.StatusCode = statusCode;");
            writer.WriteLine("");
            writer.WriteLine("var responseBodyBytes = context.GetResponseBodyBytes();");
            writer.WriteLine("");

            writer.OpenBlock("using (var streamCopy = new MemoryStream(responseBodyBytes))", "}", () =>
            {
                writer.OpenBlock("using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))", "}", () =>
                {
                    writer.WriteLine("StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);");

                    foreach (var error in operation.Errors)
                    {
                        var errorShapeName = error.Id.Name;
                        var exceptionClassName = ExceptionWriter.ToExceptionName(errorShapeName);
                        writer.OpenBlock($"""if (errorResponse.Code != null && errorResponse.Code.Equals("{errorShapeName}"))""", () =>
                        {
                            writer.WriteLine($"return {exceptionClassName}Unmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);");
                        });
                    }
                });
            });

            writer.WriteLine($"return new Amazon{context.ServiceName}Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);");
        });
    }

    private static void WriteSingleton(CodeWriter writer, string unmarshallerClassName)
    {
        writer.WriteLine($"private static {unmarshallerClassName} _instance = new {unmarshallerClassName}();");
        writer.WriteLine("");
        writer.WriteLine($"internal static {unmarshallerClassName} GetInstance() => _instance;");
        writer.WriteLine("");
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Gets the singleton.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public static {unmarshallerClassName} Instance => _instance;");
    }
}
