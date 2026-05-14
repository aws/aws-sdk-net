using System.Text.Json;
using System.Text.Json.Serialization;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Model.Converters;

/// <summary>
/// Deserializes a Smithy shape from the JSON AST by dispatching on the <c>type</c> field.
/// Unknown type values return <c>null</c> with a warning for forward compatibility.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/json-ast.html#ast-shape" /></remarks>
public class ShapeConverter : JsonConverter<Shape>
{
    public override Shape? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var type = root.GetProperty("type").GetString();

        return type switch
        {
            "blob" => root.Deserialize<BlobShape>(options),
            "boolean" => root.Deserialize<BooleanShape>(options),
            "string" => root.Deserialize<StringShape>(options),
            "byte" => root.Deserialize<ByteShape>(options),
            "short" => root.Deserialize<ShortShape>(options),
            "integer" => root.Deserialize<IntegerShape>(options),
            "long" => root.Deserialize<LongShape>(options),
            "float" => root.Deserialize<FloatShape>(options),
            "double" => root.Deserialize<DoubleShape>(options),
            "bigInteger" => root.Deserialize<BigIntegerShape>(options),
            "bigDecimal" => root.Deserialize<BigDecimalShape>(options),
            "timestamp" => root.Deserialize<TimestampShape>(options),
            "document" => root.Deserialize<DocumentShape>(options),

            "list" => root.Deserialize<ListShape>(options),
            "map" => root.Deserialize<MapShape>(options),
            "structure" => root.Deserialize<StructureShape>(options),
            // "union" => root.Deserialize<UnionShape>(options),
            // "enum" => root.Deserialize<EnumShape>(options),
            // "intEnum" => root.Deserialize<IntEnumShape>(options),
            "service" => root.Deserialize<ServiceShape>(options),
            "operation" => root.Deserialize<OperationShape>(options),
            // "resource" => root.Deserialize<ResourceShape>(options),

            _ => WarnUnknown(type),
        };
    }

    public override void Write(Utf8JsonWriter writer, Shape value, JsonSerializerOptions options) => throw new NotSupportedException();

    private static Shape? WarnUnknown(string? type)
    {
        // TODO: replace with proper logging once the generator has a logging abstraction
        Console.Error.WriteLine($"Warning: skipping unknown shape type '{type}'");
        return null;
    }
}
