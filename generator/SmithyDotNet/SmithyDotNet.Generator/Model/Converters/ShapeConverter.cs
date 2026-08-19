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
            "string" => ReadString(root, options),
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
            "union" => root.Deserialize<UnionShape>(options),
            "enum" => root.Deserialize<EnumShape>(options),
            "intEnum" => root.Deserialize<IntEnumShape>(options),
            "service" => root.Deserialize<ServiceShape>(options),
            "operation" => root.Deserialize<OperationShape>(options),
            "resource" => root.Deserialize<ResourceShape>(options),

            _ => WarnUnknown(type),
        };
    }

    public override void Write(Utf8JsonWriter writer, Shape value, JsonSerializerOptions options) => throw new NotSupportedException();

    // A pre-IDL-2.0 enum is a string shape carrying a smithy.api#enum trait; C2J emits a
    // ConstantClass from it, so it must read as an EnumShape rather than a plain string
    // (SupportApp's AccountType/NotificationSeverityLevel). Deserializing the StringShape first
    // means its traits are already detached element copies, so each entry's `value` is the
    // JsonElement the enumValue trait needs by reference — no re-serialization or cloning.
    private static Shape? ReadString(JsonElement root, JsonSerializerOptions options)
    {
        var shape = root.Deserialize<StringShape>(options);
        if (shape is null || !shape.Traits.TryGetValue("smithy.api#enum", out var legacyEnum))
        {
            return shape;
        }

        var members = new Dictionary<string, MemberShape>();
        foreach (var entry in legacyEnum.EnumerateArray())
        {
            if (!entry.TryGetProperty("value", out var value) || value.ValueKind != JsonValueKind.String)
            {
                throw new GeneratorException("A smithy.api#enum entry has no string 'value'.");
            }

            // The entry's explicit name when present, else the value: the emitted constant name
            // derives from the wire value either way (ServiceEnumerationsWriter.ResolveMembers),
            // so the member key only needs to be unique.
            var name = (entry.TryGetProperty("name", out var n) ? n.GetString() : null) ?? value.GetString()
                ?? throw new GeneratorException("A smithy.api#enum entry has no string 'value'.");

            var member = new MemberShape
            {
                Target = ShapeId.Parse("smithy.api#Unit"),
                Traits = { ["smithy.api#enumValue"] = value },
            };
            if (!members.TryAdd(name, member))
            {
                // Silent overwrite would drop a constant — the same failure class this
                // normalization exists to prevent. A model this malformed must fail the build.
                throw new GeneratorException($"Legacy smithy.api#enum entries collide on member name '{name}'.");
            }
        }

        // The trait is consumed here; downstream must only ever see the modern shape.
        shape.Traits.Remove("smithy.api#enum");
        return new EnumShape { Members = members, Traits = shape.Traits };
    }

    private static Shape? WarnUnknown(string? type)
    {
        Log.Warn($"skipping unknown shape type '{type}'");
        return null;
    }
}
