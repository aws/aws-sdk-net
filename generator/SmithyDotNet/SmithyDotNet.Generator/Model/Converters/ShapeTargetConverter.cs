using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Model.Converters;

/// <summary>
/// Converts a shape reference wrapper object (e.g. <c>{"target": "com.foo#Bar"}</c>) to a <see cref="ShapeId"/>.
/// Used for <c>OperationShape.Input</c>, <c>OperationShape.Output</c>, etc.
/// </summary>
public class ShapeTargetConverter : JsonConverter<ShapeId>
{
    public override ShapeId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var target = doc.RootElement.GetProperty("target").GetString() ?? throw new InvalidOperationException("Expected a non-null 'target' string in shape reference.");
        return ShapeId.Parse(target);
    }

    public override void Write(Utf8JsonWriter writer, ShapeId value, JsonSerializerOptions options) => throw new NotSupportedException();
}
