namespace SmithyDotNet.Generator.Writers;

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

    // Scalar / list-of-structure / list-of-string / structure dispatch, writing into the
    // `unmarshalledObject` local.
    internal static void WriteMemberUnmarshall(CodeWriter writer, Member member)
    {
        if (ScalarUnmarshaller(member.Type.MarshalType) is string scalarUnmarshaller)
        {
            writer.WriteLine($"var unmarshaller = {scalarUnmarshaller}.Instance;");
            writer.WriteLine($"unmarshalledObject.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
        }
        else if (member.Type.Element is { IsStructure: true } element)
        {
            var unmarshallerType = $"{element.DotNetType}Unmarshaller";
            writer.WriteLine($"var unmarshaller = new JsonListUnmarshaller<{element.DotNetType}, {unmarshallerType}>({unmarshallerType}.Instance);");
            writer.WriteLine($"unmarshalledObject.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
        }
        else if (member.Type.Element is { IsString: true })
        {
            writer.WriteLine("var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);");
            writer.WriteLine($"unmarshalledObject.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
        }
        else if (member.Type.IsStructure)
        {
            var unmarshallerType = $"{member.Type.DotNetType}Unmarshaller";
            writer.WriteLine($"var unmarshaller = {unmarshallerType}.Instance;");
            writer.WriteLine($"unmarshalledObject.{member.PropertyName} = unmarshaller.Unmarshall(context, ref reader);");
        }
        else
        {
            throw new GeneratorException($"Unsupported member type '{member.Type.DotNetType}' for member '{member.PropertyName}'.");
        }
    }
}
