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
        if (type.IsStructure)
        {
            return ($"{type.DotNetType}Unmarshaller", $"{type.DotNetType}Unmarshaller.Instance");
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
            FloatShape => "Float",
            DoubleShape => "Double",
            TimestampShape => "DateTime",
            _ => throw new GeneratorException($"Unsupported rpcv2Cbor body type '{type.DotNetType}'."),
        };

        var scalar = type.IsNullableValueType ? $"CborNullable{name}Unmarshaller" : $"Cbor{name}Unmarshaller";
        return (scalar, $"{scalar}.Instance");
    }
}
