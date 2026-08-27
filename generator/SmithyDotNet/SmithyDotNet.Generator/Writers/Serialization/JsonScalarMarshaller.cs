namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the <c>Utf8JsonWriter</c> calls that serialize a scalar into a JSON body — either a standalone
/// <see cref="Member"/> (nullable value types) or a non-sparse collection element/value (non-nullable).
/// Shared by the request/structure marshaller writers and the collection marshaller (and reusable by a
/// future awsJson writer). HTTP query/header/label conversions are a separate, request-only concern.
/// </summary>
public static class JsonScalarMarshaller
{
    /// <summary>
    /// Emits the writer call(s) for <paramref name="expression"/> (a scalar value of <paramref name="type"/>).
    /// Dispatch is on <see cref="TypeDescriptor.MarshalType"/>, whose nullability selects the shape: a
    /// nullable value type (a standalone member, guarded by the caller's <c>IsSet</c>) unwraps with
    /// <c>.Value</c> and, for float/double, branches through <c>StringUtils.IsSpecial*Value</c> so
    /// NaN/±Infinity serialize as strings; a non-nullable value type (a non-sparse collection leaf) writes
    /// the bare value with no unwrap and no special guard, matching C2J's collection path. An enum
    /// marshals as a <c>string</c> (implicit ConstantClass to string). A timestamp uses its explicit
    /// <c>@timestampFormat</c>, else <paramref name="timestampDefault"/> (the caller's binding default);
    /// this mirrors <see cref="JsonRequestMarshallerWriter.StringConversion"/>, keeping protocol/binding
    /// defaults out of this writer.
    /// </summary>
    public static void WriteScalar(CodeWriter writer, TypeDescriptor type, string expression, string timestampDefault)
    {
        switch (type.MarshalType)
        {
            case "string":
                writer.WriteLine($"context.Writer.WriteStringValue({expression});");
                break;
            case "bool":
                writer.WriteLine($"context.Writer.WriteBooleanValue({expression});");
                break;
            case "bool?":
                writer.WriteLine($"context.Writer.WriteBooleanValue({expression}.Value);");
                break;
            case "int" or "long" or "float" or "double":
                writer.WriteLine($"context.Writer.WriteNumberValue({expression});");
                break;
            case "int?" or "long?":
                writer.WriteLine($"context.Writer.WriteNumberValue({expression}.Value);");
                break;
            case "float?" or "double?":
                WriteSpecialNumeric(writer, type.DotNetType, expression);
                break;
            case "DateTime":
                WriteTimestamp(writer, type.TimestampFormat ?? timestampDefault, expression, nullable: false);
                break;
            case "DateTime?":
                WriteTimestamp(writer, type.TimestampFormat ?? timestampDefault, expression, nullable: true);
                break;
            default:
                throw new GeneratorException($"'{type.DotNetType}' is not a body scalar.");
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

    // The string forms take a DateTime? (a non-nullable DateTime converts implicitly), so only the epoch
    // form differs by nullability - a nullable member unwraps with .Value, a non-nullable leaf does not.
    private static void WriteTimestamp(CodeWriter writer, string format, string expression, bool nullable)
    {
        var epochValue = nullable ? $"{expression}.Value" : expression;
        writer.WriteLine(format switch
        {
            "date-time" => $"context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs({expression}));",
            "http-date" => $"context.Writer.WriteStringValue(StringUtils.FromDateTimeToRFC822({expression}));",
            "epoch-seconds" => $"context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp({epochValue})));",
            _ => throw new GeneratorException($"Unsupported @timestampFormat '{format}'."),
        });
    }
}
