namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source that marshals one JSON body member into a <c>Utf8JsonWriter</c>. Shared by
/// any writer that serializes a structure's members into a JSON body — the top-level operation body
/// (<see cref="JsonRequestMarshallerWriter"/>) and a nested structure's own marshaller
/// (<see cref="JsonStructureMarshallerWriter"/>) both call in here; the object variable name is the
/// only thing that differs between them ("publicRequest" vs. "requestObject"). Handles scalars,
/// nested structures, documents, blobs (base64 string on the wire), and collections (lists/maps of
/// strings, structures, documents, or nested collections), so a structure recurses through those
/// member kinds at any depth.
/// </summary>
public static class JsonBodyMemberMarshaller
{
    // restJson1/awsJson body timestamps default to epoch seconds when @timestampFormat is unset (the
    // header/query/label binding defaults live with JsonRequestMarshallerWriter, next to their bindings).
    private const string BodyTimestampDefault = "epoch-seconds";

    // The marshalName can be overridden via https://smithy.io/2.0/spec/protocol-traits.html#jsonname-trait
    internal static void WriteBodyMember(CodeWriter writer, Member member, string objectVar)
    {
        if (member.Type.IsScalar)
        {
            writer.OpenBlock($"if ({objectVar}.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"""context.Writer.WritePropertyName("{member.JsonName ?? member.ModeledName}");""");
                JsonScalarMarshaller.WriteScalar(writer, member.Type, $"{objectVar}.{member.PropertyName}", BodyTimestampDefault);
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
        else if (member.Type.IsDocument)
        {
            writer.OpenBlock($"if ({objectVar}.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"""context.Writer.WritePropertyName("{member.JsonName ?? member.ModeledName}");""");
                writer.WriteLine($"Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, {objectVar}.{member.PropertyName});");
            });
        }
        else if (member.Type.IsBlob)
        {
            // A blob body member base64-encodes into the JSON string, matching C2J (see Textract's
            // DocumentMarshaller). A blob list element or map value never reaches here - TypeMapper
            // rejects it during member resolution.
            writer.OpenBlock($"if ({objectVar}.IsSet{member.PropertyName}())", () =>
            {
                writer.WriteLine($"""context.Writer.WritePropertyName("{member.JsonName ?? member.ModeledName}");""");
                writer.WriteLine($"StringUtils.WriteBase64StringValue(context.Writer, {objectVar}.{member.PropertyName});");
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
    // don't collide. A scalar leaf is non-nullable (List<int>, not List<int?>); JsonScalarMarshaller keys
    // on that to skip the .Value unwrap and NaN guard. An enum leaf is already a string here (see
    // TypeMapper) and marshals as one; only blob leaves are rejected in TypeMapper.
    private static void WriteCollectionValue(CodeWriter writer, TypeDescriptor type, string valueExpr, string baseName)
    {
        if (type.IsScalar)
        {
            JsonScalarMarshaller.WriteScalar(writer, type, valueExpr, BodyTimestampDefault);
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
        else if (type.IsDocument)
        {
            // A document value delegates wholesale to the runtime document transform — bare write, no
            // object wrapping (unlike a structure value), matching C2J's emitted collection elements.
            writer.WriteLine($"Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, {valueExpr});");
        }
        else if (type.ListElement is { } element)
        {
            writer.WriteLine("context.Writer.WriteStartArray();");
            var loopVar = $"{baseName}ListValue";
            writer.OpenBlock($"foreach (var {loopVar} in {valueExpr})", () =>
            {
                // A @sparse list null-guards only value-type elements: a null string already writes
                // JSON null and a null structure writes {} (C2J parity).
                if (element.IsSparse && IsValueTypeScalar(element))
                {
                    writer.OpenBlock($"if ({loopVar} != null)", () =>
                    {
                        JsonScalarMarshaller.WriteNonNullScalar(writer, element, loopVar, BodyTimestampDefault);
                    });
                    writer.OpenBlock("else", () =>
                    {
                        writer.WriteLine("context.Writer.WriteNullValue();");
                    });
                }
                else
                {
                    WriteCollectionValue(writer, element, loopVar, loopVar);
                }
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

                // A @sparse map null-guards every value kind, unlike the list path (C2J parity).
                if (mapValue.IsSparse)
                {
                    writer.OpenBlock($"if ({valueVar} == null)", () =>
                    {
                        writer.WriteLine("context.Writer.WriteNullValue();");
                    });
                    writer.OpenBlock("else", () =>
                    {
                        if (IsValueTypeScalar(mapValue))
                        {
                            JsonScalarMarshaller.WriteNonNullScalar(writer, mapValue, valueVar, BodyTimestampDefault);
                        }
                        else
                        {
                            WriteCollectionValue(writer, mapValue, valueVar, valueVar);
                        }
                    });
                }
                else
                {
                    WriteCollectionValue(writer, mapValue, valueVar, valueVar);
                }
            });
            writer.WriteLine("context.Writer.WriteEndObject();");
        }
        else
        {
            throw new GeneratorException($"Unsupported collection value type '{type.DotNetType}'.");
        }
    }

    // A non-string/enum scalar leaf is a value type - the only kind needing an explicit null guard.
    private static bool IsValueTypeScalar(TypeDescriptor type) => type.IsScalar && !type.MarshalsAsString;
}
