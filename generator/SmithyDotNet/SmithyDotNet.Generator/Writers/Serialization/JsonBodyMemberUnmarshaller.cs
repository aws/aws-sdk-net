using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source that unmarshals one JSON body member from a <c>StreamingUtf8JsonReader</c>,
/// writing into an in-scope <c>unmarshalledObject</c> local. Shared by any writer that reads a
/// structure's members out of a JSON body — the operation response
/// (<see cref="JsonResponseUnmarshallerWriter"/>), the exception unmarshaller
/// (<see cref="JsonExceptionUnmarshallerWriter"/>), and a nested structure's own unmarshaller
/// (<see cref="JsonStructureUnmarshallerWriter"/>) all name that local the same way, so no
/// parameterization is needed here (contrast <see cref="JsonBodyMemberMarshaller"/>, whose callers
/// disagree on the object variable name).
/// </summary>
public static class JsonBodyMemberUnmarshaller
{
    // Emits the per-member `if (context.TestExpression(...)) { <dispatch>; continue; }` blocks for a
    // JSON body reader loop.
    internal static void WriteMemberUnmarshallers(CodeWriter writer, List<Member> members)
    {
        for (int i = 0; i < members.Count; i++)
        {
            var member = members[i];
            var wireName = member.JsonName ?? member.ModeledName;

            writer.OpenBlock($"""if (context.TestExpression("{wireName}", targetDepth, ref reader))""", () =>
            {
                WriteMemberUnmarshall(writer, member);
                writer.WriteLine("continue;");
            });

            if (i < members.Count - 1)
            {
                writer.WriteLine();
            }
        }
    }

    /// <summary>
    /// The runtime <c>Amazon.Runtime.Internal.Transform</c> unmarshaller type for a scalar, or null when
    /// the type is not a supported scalar. <see cref="TypeDescriptor.IsNullableValueType"/> selects the
    /// <c>Nullable*</c> variant, so this one map serves both a standalone member (<c>int?</c> →
    /// <c>NullableIntUnmarshaller</c>) and a non-sparse collection element (<c>int</c> → <c>IntUnmarshaller</c>).
    /// Enums ride the string path (implicit string-to-ConstantClass conversion); timestamps auto-detect
    /// the wire format.
    /// </summary>
    internal static string? ScalarUnmarshaller(TypeDescriptor type)
    {
        var name = type.Target switch
        {
            StringShape or EnumShape => "String",
            BooleanShape => "Bool",
            IntegerShape or IntEnumShape => "Int",
            LongShape => "Long",
            FloatShape => "Float",
            DoubleShape => "Double",
            TimestampShape => "DateTime",
            _ => null,
        };

        if (name is null)
        {
            return null;
        }

        return type.IsNullableValueType ? $"Nullable{name}Unmarshaller" : $"{name}Unmarshaller";
    }

    // A scalar member uses a runtime scalar unmarshaller; a blob member uses MemoryStreamUnmarshaller
    // (base64 JSON string -> MemoryStream, matching C2J - see Kinesis's RecordUnmarshaller);
    // string/structure/document/list/map members (nested to any depth) resolve recursively via
    // CollectionUnmarshaller. Writes into the `unmarshalledObject` local.
    internal static void WriteMemberUnmarshall(CodeWriter writer, Member member)
    {
        var instance = member.Type.IsBlob
            ? "MemoryStreamUnmarshaller.Instance"
            : ScalarUnmarshaller(member.Type) is string scalarUnmarshaller
                ? $"{scalarUnmarshaller}.Instance"
                : CollectionUnmarshaller(member.Type).Instance;
        writer.WriteLine($"var unmarshaller = {instance};");
        writer.WriteLine($"unmarshalledObject.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
    }

    // The runtime unmarshaller type name and an instance expression for a scalar, structure, document,
    // blob, list, or map type - recursing for nested collections. Scalar leaves resolve via ScalarUnmarshaller
    // (non-nullable for a non-sparse element, e.g. IntUnmarshaller); an enum leaf is already a string here (see TypeMapper) so it uses StringUnmarshaller; a blob leaf
    // uses MemoryStreamUnmarshaller. Map keys are always strings (see TypeMapper.MapType), so the key
    // unmarshaller is StringUnmarshaller. Only @streaming blob leaves are rejected in TypeMapper.
    private static (string Type, string Instance) CollectionUnmarshaller(TypeDescriptor type)
    {
        if (ScalarUnmarshaller(type) is string scalar)
        {
            return (scalar, $"{scalar}.Instance");
        }
        if (type.IsBlob)
        {
            // A non-streaming blob element reads a base64 JSON string into a MemoryStream, exactly like a
            // blob body member (a @streaming blob leaf is rejected in TypeMapper).
            return ("MemoryStreamUnmarshaller", "MemoryStreamUnmarshaller.Instance");
        }
        if (type.IsDocument)
        {
            // Fully qualified to match C2J's emitted code; one branch covers a document member, a
            // list-of-documents element, and a map-of-documents value.
            const string unmarshaller = "Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller";
            return (unmarshaller, $"{unmarshaller}.Instance");
        }
        if (type.IsStructure)
        {
            var unmarshaller = $"{type.DotNetType}Unmarshaller";
            return (unmarshaller, $"{unmarshaller}.Instance");
        }
        if (type.ListElement is { } element)
        {
            var inner = CollectionUnmarshaller(element);
            var unmarshaller = $"JsonListUnmarshaller<{element.DotNetType}, {inner.Type}>";
            return (unmarshaller, $"new {unmarshaller}({inner.Instance})");
        }
        if (type.MapValue is { } mapValue)
        {
            var inner = CollectionUnmarshaller(mapValue);
            var unmarshaller = $"JsonDictionaryUnmarshaller<string, {mapValue.DotNetType}, StringUnmarshaller, {inner.Type}>";
            return (unmarshaller, $"new {unmarshaller}(StringUnmarshaller.Instance, {inner.Instance})");
        }
        throw new GeneratorException($"Unsupported collection value type '{type.DotNetType}'.");
    }
}
