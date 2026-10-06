using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits one body member (key, then value) into the in-scope <c>context.Writer</c>, recursing through
/// lists, maps and structures. <c>objectVar</c> is "publicRequest" or "requestObject".
/// </summary>
public static class CborBodyMemberMarshaller
{
    // rpcv2Cbor keys by the member name; @jsonName is ignored.
    internal static void WriteBodyMember(CodeWriter writer, Member member, string objectVar)
    {
        writer.OpenBlock($"if ({objectVar}.IsSet{member.PropertyName}())", () =>
        {
            writer.WriteLine($"""context.Writer.WriteTextString("{member.ModeledName}");""");
            WriteValue(writer, member.Type, $"{objectVar}.{member.PropertyName}", $"{objectVar}{member.PropertyName}");
        });
        if (member.IsIdempotencyToken)
        {
            writer.OpenBlock("else", () =>
            {
                writer.WriteLine($"""context.Writer.WriteTextString("{member.ModeledName}");""");
                writer.WriteLine("context.Writer.WriteTextString(Guid.NewGuid().ToString());");
            });
        }
    }

    // A @sparse element is nullable and a null writes CBOR null; every other position is either
    // IsSet-guarded (a member) or non-nullable (a dense element), so it writes bare.
    private static void WriteValue(CodeWriter writer, TypeDescriptor type, string value, string baseName)
    {
        if (!type.IsSparse)
        {
            WriteNonNullValue(writer, type, value, baseName);
            return;
        }

        writer.OpenBlock($"if ({value} == null)", () =>
        {
            writer.WriteLine("context.Writer.WriteNull();");
        });
        writer.OpenBlock("else", () =>
        {
            WriteNonNullValue(writer, type, value, baseName);
        });
    }

    // Timestamps are always tag 1 (WriteDateTime); rpcv2Cbor has no @timestampFormat. baseName seeds
    // the loop variables so nested loops don't collide.
    private static void WriteNonNullValue(CodeWriter writer, TypeDescriptor type, string value, string baseName)
    {
        if (type.IsStructure)
        {
            writer.WriteLine("context.Writer.WriteStartMap(null);");
            writer.WriteLine("");
            writer.WriteLine($"var marshaller = {type.MarshallerName}.Instance;");
            writer.WriteLine($"marshaller.Marshall({value}, context);");
            writer.WriteLine("");
            writer.WriteLine("context.Writer.WriteEndMap();");
            return;
        }

        if (type.ListElement is { } element)
        {
            var loopVar = $"{baseName}ListValue";
            writer.WriteLine($"context.Writer.WriteStartArray({value}.Count);");
            writer.OpenBlock($"foreach (var {loopVar} in {value})", () =>
            {
                WriteValue(writer, element, loopVar, loopVar);
            });
            writer.WriteLine("context.Writer.WriteEndArray();");
            return;
        }

        if (type.MapValue is { } mapValue)
        {
            var kvpVar = $"{baseName}Kvp";
            var valueVar = $"{baseName}Value";
            writer.WriteLine("context.Writer.WriteStartMap(null);");
            writer.OpenBlock($"foreach (var {kvpVar} in {value})", () =>
            {
                writer.WriteLine($"context.Writer.WriteTextString({kvpVar}.Key);");
                writer.WriteLine($"var {valueVar} = {kvpVar}.Value;");
                WriteValue(writer, mapValue, valueVar, valueVar);
            });
            writer.WriteLine("context.Writer.WriteEndMap();");
            return;
        }

        if (type.IsBlob)
        {
            writer.WriteLine($"context.Writer.WriteByteString({value});");
            return;
        }

        var scalar = type.IsNullableValueType ? $"{value}.Value" : value;
        writer.WriteLine(type.Target switch
        {
            StringShape or EnumShape => $"context.Writer.WriteTextString({value});",
            BooleanShape => $"context.Writer.WriteBoolean({scalar});",
            IntegerShape or IntEnumShape => $"context.Writer.WriteInt32({scalar});",
            LongShape => $"context.Writer.WriteInt64({scalar});",
            FloatShape or DoubleShape => $"context.Writer.WriteOptimizedNumber({scalar});",
            TimestampShape => $"context.Writer.WriteDateTime({scalar});",
            _ => throw new GeneratorException($"Unsupported rpcv2Cbor body type '{type.DotNetType}' ('{value}')."),
        });
    }
}
