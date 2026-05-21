using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Model.Converters;

/// <summary>
/// Converts a plain JSON string (e.g. <c>"com.foo#Bar"</c>) to a <see cref="ShapeId"/>.
/// Used for <see cref="MemberShape.Target"/> where the value is a direct string.
/// </summary>
public class ShapeIdConverter : JsonConverter<ShapeId>
{
    public override ShapeId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString() ?? throw new InvalidOperationException("Expected a string value for ShapeId.");
        return ShapeId.Parse(value);
    }

    public override void Write(Utf8JsonWriter writer, ShapeId value, JsonSerializerOptions options) => throw new NotSupportedException();
}
