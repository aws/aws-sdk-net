using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Model.Converters;

/// <summary>
/// Converts an array of shape reference wrappers (e.g. <c>[{"target": "..."}, ...]</c>) to a list of <see cref="ShapeId"/>.
/// Used for <c>ServiceShape.Operations</c>, <c>OperationShape.Errors</c>, etc.
/// </summary>
public class ShapeTargetListConverter : JsonConverter<List<ShapeId>>
{
    public override List<ShapeId> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var ids = new List<ShapeId>();
        foreach (var element in doc.RootElement.EnumerateArray())
        {
            var target = element.GetProperty("target").GetString() ?? throw new InvalidOperationException("Expected a non-null 'target' string in shape reference array element.");
            ids.Add(ShapeId.Parse(target));
        }
        return ids;
    }

    public override void Write(Utf8JsonWriter writer, List<ShapeId> value, JsonSerializerOptions options) => throw new NotSupportedException();
}
