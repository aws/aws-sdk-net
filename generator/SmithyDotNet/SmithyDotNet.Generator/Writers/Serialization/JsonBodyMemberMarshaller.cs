namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source that marshals one JSON body member into a <c>Utf8JsonWriter</c>. Shared by
/// any writer that serializes a structure's members into a JSON body — the top-level operation body
/// (<see cref="JsonRequestMarshallerWriter"/>) and a nested structure's own marshaller
/// (<see cref="JsonStructureMarshallerWriter"/>) both call in here; the object variable name is the
/// only thing that differs between them ("publicRequest" vs. "requestObject"). Handles scalars,
/// nested structures, and lists of strings or structures, so a structure recurses through those
/// member kinds at any depth. A map member throws.
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
        // Only a list has Element set (ResolveType), so this is the list case; a map falls through.
        else if (member.Type.Element is { } element)
        {
            writer.OpenBlock($"if ({objectVar}.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"""context.Writer.WritePropertyName("{member.JsonName ?? member.ModeledName}");""");
                writer.WriteLine("context.Writer.WriteStartArray();");
                var loopVar = $"{objectVar}{member.PropertyName}ListValue";
                writer.OpenBlock($"foreach (var {loopVar} in {objectVar}.{member.PropertyName})", () =>
                {
                    WriteListElement(writer, element, loopVar);
                });
                writer.WriteLine("context.Writer.WriteEndArray();");
            });
        }
        else
        {
            throw new GeneratorException($"Unsupported body member type '{member.Type.DotNetType}' (member: {member.PropertyName}).");
        }
    }

    private static void WriteListElement(CodeWriter writer, TypeDescriptor element, string loopVar)
    {
        if (element.IsString)
        {
            writer.WriteLine($"context.Writer.WriteStringValue({loopVar});");
        }
        else if (element.IsStructure)
        {
            writer.WriteLine("context.Writer.WriteStartObject();");
            writer.WriteLine("");
            writer.WriteLine($"var marshaller = {element.DotNetType}Marshaller.Instance;");
            writer.WriteLine($"marshaller.Marshall({loopVar}, context);");
            writer.WriteLine("");
            writer.WriteLine("context.Writer.WriteEndObject();");
        }
        else
        {
            throw new GeneratorException("Only strings and structure list element types are handled right now!");
        }
    }
}
