using System.Buffers;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Model.Converters;

/// <summary>
/// Reads a Smithy <c>@range</c> bound (a bigDecimal in smithy) as a <see cref="long"/>. 
/// <c>AWSPropertyAttribute.Min/Max</c> are <see cref="long"/>, so a bound that can't be represented
/// as one (e.g. 0.01 on a float shape) is skipped — emitted as <c>null</c>, never throwing.
/// </summary>
public class RangeBoundConverter : JsonConverter<long?>
{
    public override long? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        var raw = Encoding.UTF8.GetString(reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan);

        var text = raw;
        if (raw.IndexOfAny(['.', 'e', 'E']) != -1 &&
            double.TryParse(raw, NumberStyles.Float, CultureInfo.InvariantCulture, out var d))
        {
            text = d.ToString(CultureInfo.InvariantCulture);
        }

        if (long.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out var value))
        {
            return value;
        }

        return null;
    }

    public override void Write(Utf8JsonWriter writer, long? value, JsonSerializerOptions options) => throw new NotSupportedException();
}
