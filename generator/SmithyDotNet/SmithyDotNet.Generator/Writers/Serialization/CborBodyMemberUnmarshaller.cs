using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the CBOR map read loop filling the in-scope <c>unmarshalledObject</c> from <c>reader</c>/<c>context</c>.
/// </summary>
public static class CborBodyMemberUnmarshaller
{
    // Keys are member names (@jsonName is ignored); unknown keys are skipped.
    internal static void WriteMapReadLoop(CodeWriter writer, List<Member> members)
    {
        writer.WriteLine("reader.ReadStartMap();");
        writer.OpenBlock("while (reader.PeekState() != CborReaderState.EndMap)", () =>
        {
            writer.WriteLine("var propertyName = reader.ReadTextString();");
            writer.OpenBlock("switch (propertyName)", () =>
            {
                // The path segments feed CurrentPath in the runtime's unmarshalling exception.
                foreach (var member in members)
                {
                    writer.WriteLine($"""case "{member.ModeledName}":""");
                    writer.Indent(() =>
                    {
                        writer.WriteLine($"""context.AddPathSegment("{member.PropertyName}");""");
                        writer.WriteLine($"unmarshalledObject.{member.PropertyName} = {Unmarshaller(member.Type).Instance}.Unmarshall(context);");
                        writer.WriteLine("context.PopPathSegment();");
                        writer.WriteLine("break;");
                    });
                    writer.WriteLine();
                }
                writer.WriteLine("default:");
                writer.Indent(() =>
                {
                    writer.WriteLine("reader.SkipValue();");
                    writer.WriteLine("break;");
                });
            });
        });
        writer.WriteLine("reader.ReadEndMap();");
    }

    // The runtime unmarshaller type and an instance expression, recursing through lists and maps. A
    // nullable position (member, @sparse element) takes the CborNullable* variant. Map keys are strings.
    private static (string Type, string Instance) Unmarshaller(TypeDescriptor type)
    {
        if (type.UnmarshallerOverride is { } swapUnmarshaller)
        {
            // The wire type stays the modeled one, and every CBOR runtime unmarshaller reads the CBOR item of its
            // own type; none parses a text string into another type.
            if (type.Target is StringShape or EnumShape)
            {
                throw new GeneratorException($"dataTypeSwap unmarshaller '{swapUnmarshaller}' is not supported on rpcv2Cbor: no runtime unmarshaller parses a CBOR text string into another type.");
            }

            // The swap names a Core scalar unmarshaller; the CBOR runtime has a Cbor-prefixed one for each, in
            // its own namespace, so only a simple name can be prefixed.
            if (swapUnmarshaller.Contains('.'))
            {
                throw new GeneratorException($"dataTypeSwap unmarshaller '{swapUnmarshaller}' is not supported on rpcv2Cbor; name the runtime unmarshaller without its namespace.");
            }

            return ($"Cbor{swapUnmarshaller}", $"Cbor{swapUnmarshaller}.Instance");
        }

        if (type.UnmarshallerName is { } unmarshaller)
        {
            return (unmarshaller, $"{unmarshaller}.Instance");
        }

        if (type.IsBlob)
        {
            return ("CborMemoryStreamUnmarshaller", "CborMemoryStreamUnmarshaller.Instance");
        }

        if (type.ListElement is { } element)
        {
            var inner = Unmarshaller(element);
            var list = $"CborListUnmarshaller<{element.DotNetType}, {inner.Type}>";
            return (list, $"new {list}({inner.Instance})");
        }

        if (type.MapValue is { } mapValue)
        {
            var inner = Unmarshaller(mapValue);
            var map = $"CborDictionaryUnmarshaller<string, {mapValue.DotNetType}, CborStringUnmarshaller, {inner.Type}>";
            return (map, $"new {map}(CborStringUnmarshaller.Instance, {inner.Instance})");
        }

        var name = type.Target switch
        {
            StringShape or EnumShape => "String",
            BooleanShape => "Bool",
            IntegerShape or IntEnumShape => "Int",
            LongShape => "Long",
            ByteShape => "SByte",
            ShortShape => "Short",
            BigIntegerShape => "BigInteger",
            BigDecimalShape => "BigDecimal",
            FloatShape => "Float",
            DoubleShape => "Double",
            TimestampShape => "DateTime",
            _ => throw new GeneratorException($"Unsupported rpcv2Cbor body type '{type.DotNetType}'."),
        };

        var scalar = type.IsNullableValueType ? $"CborNullable{name}Unmarshaller" : $"Cbor{name}Unmarshaller";
        return (scalar, $"{scalar}.Instance");
    }
}
