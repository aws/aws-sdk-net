namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source that marshals one JSON body member into a <c>Utf8JsonWriter</c>. Shared by
/// any writer that serializes a structure's members into a JSON body — the top-level operation body
/// (<see cref="JsonRequestMarshallerWriter"/>) and a nested structure's own marshaller
/// (<see cref="JsonStructureMarshallerWriter"/>) both call in here; the object variable name is the
/// only thing that differs between them ("publicRequest" vs. "requestObject"). Handles scalars,
/// nested structures, and collections (lists/maps of strings, structures, or nested collections),
/// so a structure recurses through those member kinds at any depth.
/// </summary>
public static class JsonBodyMemberMarshaller
{
    // The marshalName can be overridden via https://smithy.io/2.0/spec/protocol-traits.html#jsonname-trait
    internal static void WriteBodyMember(CodeWriter writer, Member member, string objectVar)
    {
        if (member.Type.IsScalar)
        {
            writer.OpenBlock($"if ({objectVar}.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"""context.Writer.WritePropertyName("{member.JsonName ?? member.ModeledName}");""");
                JsonScalarMarshaller.WriteScalar(writer, member, $"{objectVar}.{member.PropertyName}");
            });
            if (member.IsIdempotencyToken)
            {
                writer.OpenBlock("else", () =>
                {
                    writer.WriteLine($"""context.Writer.WritePropertyName("{member.JsonName ?? member.ModeledName}");""");
                    writer.WriteLine("context.Writer.WriteStringValue(Guid.NewGuid().ToString());");
                });
            }
        }
        else if (member.Type.IsStructure)
        {
            writer.OpenBlock($"if ({objectVar}.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"""context.Writer.WritePropertyName("{member.JsonName ?? member.ModeledName}");""");
                writer.WriteLine("context.Writer.WriteStartObject();");
                writer.WriteLine("");
                writer.WriteLine($"var marshaller = {member.Type.DotNetType}Marshaller.Instance;");
                writer.WriteLine($"marshaller.Marshall({objectVar}.{member.PropertyName}, context);");
                writer.WriteLine("");
                writer.WriteLine("context.Writer.WriteEndObject();");
            });
        }
        else if (member.Type.IsCollection)
        {
            writer.OpenBlock($"if ({objectVar}.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"""context.Writer.WritePropertyName("{member.JsonName ?? member.ModeledName}");""");
                WriteCollectionValue(writer, member.Type, $"{objectVar}.{member.PropertyName}", $"{objectVar}{member.PropertyName}");
            });
        }
        else
        {
            throw new GeneratorException($"Unsupported body member type '{member.Type.DotNetType}' (member: {member.PropertyName}).");
        }
    }

    // Writes one JSON value: a list element, a map value, or a collection member's own value - recursing
    // for nested lists/maps. A list becomes a JSON array, a map a JSON object keyed by kvp.Key (map keys
    // are always strings - see TypeMapper.MapType). baseName seeds the loop-variable names so nested loops
    // don't collide. Value-type/enum leaf values are rejected in TypeMapper (deferred to the value-type
    // (un)marshaller work).
    private static void WriteCollectionValue(CodeWriter writer, TypeDescriptor type, string valueExpr, string baseName)
    {
        if (type.IsString)
        {
            writer.WriteLine($"context.Writer.WriteStringValue({valueExpr});");
        }
        else if (type.IsStructure)
        {
            writer.WriteLine("context.Writer.WriteStartObject();");
            writer.WriteLine("");
            writer.WriteLine($"var marshaller = {type.DotNetType}Marshaller.Instance;");
            writer.WriteLine($"marshaller.Marshall({valueExpr}, context);");
            writer.WriteLine("");
            writer.WriteLine("context.Writer.WriteEndObject();");
        }
        else if (type.ListElement is { } element)
        {
            writer.WriteLine("context.Writer.WriteStartArray();");
            var loopVar = $"{baseName}ListValue";
            writer.OpenBlock($"foreach (var {loopVar} in {valueExpr})", () =>
            {
                WriteCollectionValue(writer, element, loopVar, loopVar);
            });
            writer.WriteLine("context.Writer.WriteEndArray();");
        }
        else if (type.MapValue is { } mapValue)
        {
            writer.WriteLine("context.Writer.WriteStartObject();");
            var kvpVar = $"{baseName}Kvp";
            writer.OpenBlock($"foreach (var {kvpVar} in {valueExpr})", () =>
            {
                writer.WriteLine($"context.Writer.WritePropertyName({kvpVar}.Key);");
                var valueVar = $"{baseName}Value";
                writer.WriteLine($"var {valueVar} = {kvpVar}.Value;");
                WriteCollectionValue(writer, mapValue, valueVar, valueVar);
            });
            writer.WriteLine("context.Writer.WriteEndObject();");
        }
        else
        {
            throw new GeneratorException($"Unsupported collection value type '{type.DotNetType}'.");
        }
    }
}
