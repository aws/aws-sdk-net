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
    /// The runtime <c>Amazon.Runtime.Internal.Transform</c> unmarshaller type for a member's
    /// <see cref="TypeDescriptor.MarshalType"/> (the .NET type for plain scalars; <c>string</c> for enums, so an
    /// enum member unmarshals via <c>StringUnmarshaller</c> and the implicit string-to-ConstantClass
    /// conversion), or null when the type is not a supported scalar. Timestamps follow the JSON-protocol
    /// default (epoch seconds via the nullable <c>DateTime</c> unmarshaller).
    /// </summary>
    internal static string? ScalarUnmarshaller(string marshalType) => marshalType switch
    {
        "string" => "StringUnmarshaller",
        "bool?" => "NullableBoolUnmarshaller",
        "int?" => "NullableIntUnmarshaller",
        "long?" => "NullableLongUnmarshaller",
        "float?" => "NullableFloatUnmarshaller",
        "double?" => "NullableDoubleUnmarshaller",
        "DateTime?" => "NullableDateTimeUnmarshaller",
        _ => null,
    };

    // A scalar member uses a runtime scalar unmarshaller; string/structure/list/map members (nested to
    // any depth) resolve recursively via CollectionUnmarshaller. Writes into the `unmarshalledObject` local.
    internal static void WriteMemberUnmarshall(CodeWriter writer, Member member)
    {
        var instance = ScalarUnmarshaller(member.Type.MarshalType) is string scalarUnmarshaller
            ? $"{scalarUnmarshaller}.Instance"
            : CollectionUnmarshaller(member.Type).Instance;
        writer.WriteLine($"var unmarshaller = {instance};");
        writer.WriteLine($"unmarshalledObject.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
    }

    // The runtime unmarshaller type name and an instance expression for a string, structure, list, or map
    // type - recursing for nested collections. Map keys are always strings (see TypeMapper.MapType), so the
    // key unmarshaller is StringUnmarshaller. Value-type/enum leaf values are rejected in TypeMapper
    // (deferred to the value-type (un)marshaller work).
    private static (string Type, string Instance) CollectionUnmarshaller(TypeDescriptor type)
    {
        if (type.IsString)
        {
            return ("StringUnmarshaller", "StringUnmarshaller.Instance");
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
