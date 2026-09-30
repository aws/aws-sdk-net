using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// The protocol-neutral parts of the marshaller and unmarshaller classes, shared by the JSON and CBOR writers (for now).
/// TODO: Event stream logic could also be moved here once it's added for protocols other than JSON.
/// </summary>
public static class MarshallerCommon
{
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

    internal static void WriteStructureMarshallerSingleton(CodeWriter writer, string className)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Singleton Marshaller");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public readonly static {className}Marshaller Instance = new {className}Marshaller();");
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

    // Structure and exception unmarshallers.
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
