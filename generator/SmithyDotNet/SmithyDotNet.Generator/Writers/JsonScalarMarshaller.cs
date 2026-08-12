namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the <c>Utf8JsonWriter</c> calls that serialize a scalar <see cref="Member"/> into a JSON
/// body. Shared by the request and structure marshaller writers (and reusable by a future awsJson
/// writer). HTTP query/header/label conversions are a separate, request-only concern.
/// </summary>
public static class JsonScalarMarshaller
{
    // restJson1/awsJson body timestamps default to epoch seconds when @timestampFormat is unset.
    private const string BodyTimestampDefault = "epoch-seconds";

    /// <summary>
    /// Emits the writer call(s) for <paramref name="expression"/> (a scalar value). Nullable value
    /// types unwrap with <c>.Value</c>; the caller guards each with an <c>IsSet</c> check. Float and
    /// double branch through <c>StringUtils.IsSpecial*Value</c> so NaN/±Infinity serialize as strings
    /// (<c>WriteNumberValue</c> rejects them). Timestamps honor <c>@timestampFormat</c>.
    /// </summary>
    public static void WriteScalar(CodeWriter writer, Member member, string expression)
    {
        switch (member.DotNetType)
        {
            case "string":
                writer.WriteLine($"context.Writer.WriteStringValue({expression});");
                break;
            case "bool?":
                writer.WriteLine($"context.Writer.WriteBooleanValue({expression}.Value);");
                break;
            case "int?" or "long?":
                writer.WriteLine($"context.Writer.WriteNumberValue({expression}.Value);");
                break;
            case "float?" or "double?":
                WriteSpecialNumeric(writer, member.DotNetType, expression);
                break;
            case "DateTime?":
                WriteTimestamp(writer, member.TimestampFormat ?? BodyTimestampDefault, expression);
                break;
            default:
                throw new GeneratorException($"'{member.DotNetType}' is not a body scalar (member: {member.PropertyName}).");
        }
    }

    private static void WriteSpecialNumeric(CodeWriter writer, string dotNetType, string expression)
    {
        var suffix = dotNetType == "float?" ? "Float" : "Double";
        writer.OpenBlock($"if (StringUtils.IsSpecial{suffix}Value({expression}.Value))", () =>
        {
            writer.WriteLine($"context.Writer.WriteStringValue(StringUtils.FromSpecial{suffix}Value({expression}.Value));");
        });
        writer.OpenBlock("else", () =>
        {
            writer.WriteLine($"context.Writer.WriteNumberValue({expression}.Value);");
        });
    }

    private static void WriteTimestamp(CodeWriter writer, string format, string expression)
    {
        // String formats use the DateTime? overload directly; epoch seconds unwraps with .Value.
        // System.Convert is fully qualified because the structure marshaller's usings omit System.
        writer.WriteLine(format switch
        {
            "date-time" => $"context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs({expression}));",
            "http-date" => $"context.Writer.WriteStringValue(StringUtils.FromDateTimeToRFC822({expression}));",
            "epoch-seconds" => $"context.Writer.WriteNumberValue(System.Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp({expression}.Value)));",
            _ => throw new GeneratorException($"Unsupported @timestampFormat '{format}'."),
        });
    }
}
