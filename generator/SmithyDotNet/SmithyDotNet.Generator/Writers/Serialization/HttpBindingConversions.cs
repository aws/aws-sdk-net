namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Protocol-agnostic value-to-string conversions for HTTP binding positions (<c>@httpHeader</c>,
/// <c>@httpQuery</c>, <c>@httpLabel</c>), where a member is a string on the wire regardless of
/// protocol. Shared by every protocol's request marshaller so a given conversion (e.g. the
/// <c>StringUtils</c> call for a <c>@timestampFormat</c>) lives in one place.
/// </summary>
// TODO: these only cover the three formats the HTTP bindings use today (date-time, http-date,
// epoch-seconds). The JSON body path (JsonScalarMarshaller.WriteTimestamp) and the scalar response-header
// read path (JsonResponseUnmarshallerWriter.HeaderValueConversion) still carry their own copies of the
// per-format mapping. Consolidate those here so a new protocol has one source of truth for timestamp
// formats. Callers resolve the binding's default format (e.g. http-date on a header) before calling in —
// those defaults are protocol-specific and stay at the call site.
internal static class HttpBindingConversions
{
    /// <summary>
    /// The full <c>StringUtils</c> call that renders a timestamp as a string for a header/query/label
    /// position, e.g. <c>StringUtils.FromDateTimeToRFC822(expression)</c>.
    /// </summary>
    public static string TimestampStringConversion(string format, string expression) =>
        $"{TimestampConverter(format)}({expression})";

    /// <summary>
    /// The bare <c>StringUtils.FromDateTimeTo*</c> method name for a header/query/label timestamp
    /// format, used both as a full call (wrapped by <see cref="TimestampStringConversion"/>) and bare
    /// as the per-element converter in a query <c>ConvertAll</c> lambda.
    /// </summary>
    public static string TimestampConverter(string format) => format switch
    {
        "date-time" => "StringUtils.FromDateTimeToISO8601WithOptionalMs",
        "http-date" => "StringUtils.FromDateTimeToRFC822",
        "epoch-seconds" => "StringUtils.FromDateTimeToUnixTimestamp",
        _ => throw new GeneratorException($"Unsupported @timestampFormat '{format}'."),
    };

    /// <summary>
    /// The C2J <c>TimestampFormat</c> enum name (<c>RFC822</c>/<c>ISO8601</c>/<c>UnixTimestamp</c>) for a
    /// resolved Smithy <c>@timestampFormat</c>, as the runtime multi-value header parser
    /// (<c>MultiValueHeaderParser.ToDateTimeList</c>) expects it on the read side.
    /// </summary>
    public static string TimestampFormatName(string format) => format switch
    {
        "date-time" => "ISO8601",
        "http-date" => "RFC822",
        "epoch-seconds" => "UnixTimestamp",
        _ => throw new GeneratorException($"Unsupported @timestampFormat '{format}'."),
    };
}
