using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// The protocol-neutral parts of the marshaller and unmarshaller classes, shared by the JSON and CBOR writers.
/// </summary>
public static class MarshallerCommon
{
    // A dataTypeSwap names the method to call but not whether it returns a number or a string, which picks
    // the wire token. C2J hardcodes this one method as the number case (JsonRPCStructureMarshaller.tt).
    private const string EpochMillisecondsMarshaller = "Amazon.Util.AWSSDKUtils.ConvertToUnixEpochMilliseconds";

    internal static bool IsEpochMilliseconds(string marshaller) => string.Equals(marshaller, EpochMillisecondsMarshaller, StringComparison.OrdinalIgnoreCase);

    // .Value when the modeled type is a value type (as C2J does; every swappable target but string/enum is)
    // and the swapped type is nullable, so a swap to a reference type still compiles.
    internal static string SwapArgument(TypeDescriptor type, string expression) =>
        type.Target is not (StringShape or EnumShape) && type.IsNullableValueType ? $"{expression}.Value" : expression;

    // The client takes the first encoding it supports, so unsupported entries are skipped rather
    // than rejected. gzip is the whole supported set: it's emitted verbatim as an enum member and
    // CompressionEncodingAlgorithm has only NONE and gzip.
    internal static string? CompressionEncoding(Operation operation)
    {
        var compression = operation.Shape.GetRequestCompression();
        var compressionEncoding = compression?.Encodings.FirstOrDefault(encoding => encoding == "gzip");
        if (compression is not null && compressionEncoding is null)
        {
            throw new GeneratorException($"Operation '{operation.Name}' requests compression encodings '{string.Join(", ", compression.Encodings)}'; only 'gzip' is supported.");
        }
        return compressionEncoding;
    }

    internal static void WriteBaseMarshallMethod(CodeWriter writer, string className)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Marshall the request object to the HTTP request.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock($"public IRequest Marshall(AmazonWebServiceRequest input)", () =>
        {
            writer.WriteLine($"return this.Marshall(({className})input);");
        });
    }

    internal static void WriteHostPrefix(CodeWriter writer, string baseName, string hostPrefix, List<Member> hostLabelMembers)
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
                    writer.WriteLine($"""throw new Amazon{baseName}Exception("{member.ModeledName} can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");""");
                });
            }
            writer.WriteLine("");
        }

        // {label} -> {hostPrefixLabels.label}; a prefix with no labels stays literal.
        var interpolated = hostPrefix.Replace("{", "{hostPrefixLabels.");
        writer.WriteLine($"""request.HostPrefix = $"{interpolated}";""");
    }

    internal static void WriteRequestMarshallerSingleton(CodeWriter writer, string className)
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

    internal static void WriteStructureMarshallerSingleton(CodeWriter writer, string marshallerClassName)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Singleton Marshaller");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public readonly static {marshallerClassName} Instance = new {marshallerClassName}();");
    }

    internal static void WriteResponseUnmarshallerSingleton(CodeWriter writer, string unmarshallerClassName)
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

    // An event-stream member IS the whole body: hand the raw response stream to the generated
    // EnumerableEventOutputStream subclass (the union's own class), which decodes the frames
    // lazily as the caller enumerates. Matches C2J.
    internal static void WriteEventStreamMember(CodeWriter writer, Member eventStream)
    {
        writer.WriteLine($"unmarshalledObject.{eventStream.PropertyName} = new {eventStream.Type.DotNetType}(context.Stream);");
    }

    // An event's explicit @eventPayload. Blob/string are the raw bytes the publisher sends as octet-stream/text-plain;
    // a structure/union writes its members into the object the publisher opened (the protocol tests expect the bare
    // structure). The publisher marshaller picks the payload source and :content-type per event
    // (EventStreamPublisherMarshallerWriter).
    internal static void WriteEventPayload(CodeWriter writer, Member member)
    {
        writer.OpenBlock($"if (requestObject.IsSet{member.PropertyName}())", () =>
        {
            if (member.Type.IsBlob)
            {
                writer.WriteLine($"context.Request.Content = requestObject.{member.PropertyName}.ToArray();");
            }
            else if (member.Type.MarshalsAsString)
            {
                writer.WriteLine($"context.Request.Content = Encoding.UTF8.GetBytes(requestObject.{member.PropertyName});");
            }
            else if (member.Type.IsStructure)
            {
                writer.WriteLine($"{member.Type.MarshallerName}.Instance.Marshall(requestObject.{member.PropertyName}, context);");
            }
            else
            {
                throw new GeneratorException($"Unsupported @eventPayload type '{member.Type.DotNetType}' on member '{member.ModeledName}'.");
            }
        });
    }

    // The @eventPayload member IS the message payload: a blob is the raw MemoryStream, a string is the stream
    // read to end, a structure is the whole body decoded by its own unmarshaller.
    internal static void WriteEventPayloadMember(CodeWriter writer, Member member, string unmarshallArguments)
    {
        if (member.Type.MarshalsAsString)
        {
            writer.OpenBlock("using (var sr = new StreamReader(context.Stream))", () =>
            {
                writer.WriteLine($"unmarshalledObject.{member.PropertyName} = sr.ReadToEnd();");
            });
        }
        else if (member.Type.UnmarshallerName is { } unmarshaller)
        {
            writer.WriteLine($"unmarshalledObject.{member.PropertyName} = {unmarshaller}.Instance.Unmarshall({unmarshallArguments});");
        }
        else if (member.Type.IsBlob)
        {
            writer.WriteLine($"unmarshalledObject.{member.PropertyName} = context.Stream as MemoryStream;");
        }
        else
        {
            throw new GeneratorException($"@eventPayload member '{member.PropertyName}' must target a blob, string, or structure shape, but was '{member.Type.DotNetType}'.");
        }
    }

    // An event's @eventHeader goes to the message headers, not the body. Header name is the member name, never
    // @jsonName. An enum rides SetString via its implicit conversion.
    internal static void WriteEventHeader(CodeWriter writer, Member member)
    {
        var value = $"requestObject.{member.PropertyName}";
        var setter = member.Type.Target switch
        {
            StringShape or EnumShape => $"SetString({value})",
            BooleanShape => $"SetBool({value}.Value)",
            IntegerShape or IntEnumShape => $"SetInt32({value}.Value)",
            LongShape => $"SetInt64({value}.Value)",
            TimestampShape => $"SetTimestamp({value}.Value)",
            BlobShape => $"SetByteBuf({value}.ToArray())",
            var other => throw new GeneratorException($"Unsupported @eventHeader type '{other.Type}' on member '{member.ModeledName}'."),
        };

        writer.OpenBlock($"if (requestObject.IsSet{member.PropertyName}())", () =>
        {
            writer.WriteLine($"""var header = new Amazon.Runtime.EventStreams.EventStreamHeader("{member.ModeledName}");""");
            writer.WriteLine($"header.{setter};");
            writer.WriteLine("context.Request.EventHeaders.Add(header);");
        });
    }

    // Emitted when the response's @httpPayload is a @streaming blob or an event stream: the runtime
    // checks this to hand the caller the live response stream rather than buffering the body. Matches C2J.
    internal static void WriteHasStreamingProperty(CodeWriter writer)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Overriden to return true indicating the response contains streaming data.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("public override bool HasStreamingProperty => true;");
    }

    // Response logging asks Core to buffer the whole body, which never ends for an event stream.
    internal static void WriteShouldReadEntireResponse(CodeWriter writer)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Return false for reading the entire response");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("protected override bool ShouldReadEntireResponse(IWebResponseData response, bool readEntireResponse) => false;");
    }

    // Structure and exception unmarshallers, and endpoint discovery marshallers.
    internal static void WriteUnmarshallerSingleton(CodeWriter writer, string unmarshallerClassName)
    {
        writer.WriteLine($"private static {unmarshallerClassName} _instance = new {unmarshallerClassName}();");
        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Gets the singleton.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public static {unmarshallerClassName} Instance => _instance;");
    }
}
