using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source for a JSON structure unmarshaller matching the public API surface
/// of the existing AWS SDK for .NET.
/// <para />
/// Member codegen is shared with the operation response body via
/// <see cref="JsonBodyMemberUnmarshaller.WriteMemberUnmarshallers"/>: scalars, nested structures,
/// and lists of strings or structures. A map member throws a <see cref="GeneratorException"/>.
/// <para />
/// An event structure (a member of a <c>@streaming</c> union) classifies each member by binding,
/// symmetric with the marshaller: a <c>@eventPayload</c> member is the raw message payload (blob → the
/// <c>MemoryStream</c>, string → the stream read to end, structure → its own unmarshaller off the reader),
/// a <c>@eventHeader</c> member is read from an event-message header, and any remaining unbound member is
/// read from the JSON body. The three partitions are disjoint and independent: an event can carry headers
/// with no explicit payload (the unbound members are still the JSON body), or headers only.
/// </summary>
public sealed class JsonStructureUnmarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(StructureShape structure, ShapeId shapeId, CancellationToken cancellationToken = default)
    {
        var className = context.ToDotNetName(shapeId);
        var members = TypeMapper.ResolveMembers(structure, context);
        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            WriteClassDocumentation(writer, className);
            writer.OpenBlock($"public partial class {className}Unmarshaller : IJsonUnmarshaller<{className}, JsonUnmarshallerContext>", () =>
            {
                WriteUnmarshallMethod(writer, className, structure, members);
                writer.WriteLine("");
                WriteSingleton(writer, className);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
        FileHeader.WriteUsings(writer, FileHeader.MarshallerUsings, false);
        writer.WriteLine("using System.Text.Json;");
    }

    private static void WriteClassDocumentation(CodeWriter writer, string className)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Response Unmarshaller for {className} Object");
        writer.WriteLine("/// </summary>");
    }

    private void WriteUnmarshallMethod(CodeWriter writer, string className, StructureShape structure, List<Member> members)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Unmarshall the response from the service to the response class.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("/// <returns>The unmarshalled object</returns>");
        writer.OpenBlock($"public {className} Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)", () =>
        {
            writer.WriteLine($"var unmarshalledObject = new {className}();");
            writer.WriteLine("if (context.IsEmptyResponse) return null;");
            writer.WriteLine();

            // Classify each member by binding, symmetric with the marshaller: @eventPayload → raw stream,
            // @eventHeader → message header, unbound → JSON body. A member carries at most one event trait
            // (Smithy forbids both), so the partitions are disjoint. An event can carry @eventHeader members
            // without an @eventPayload member; those are still read from headers, not the JSON body — the
            // absence of @eventPayload does not mean the absence of headers.
            var payloadMember = members.SingleOrDefault(m => m.IsEventPayload);
            var headerMembers = members.Where(m => m.IsEventHeader).ToList();
            var bodyMembers = members.Where(m => !m.IsEventPayload && !m.IsEventHeader).ToList();

            // Payload first: an explicit structure payload advances the JSON reader, so it runs before the
            // body loop (which the SEP guarantees is empty when a payload exists) and the header reads.
            if (payloadMember is not null)
            {
                WritePayloadMember(writer, payloadMember);
            }
            foreach (var member in headerMembers)
            {
                WriteHeaderMember(writer, structure, member);
            }
            if (bodyMembers.Count > 0)
            {
                WriteBodyUnmarshall(writer, bodyMembers);
            }

            writer.WriteLine("return unmarshalledObject;");
        });
    }

    private static void WriteBodyUnmarshall(CodeWriter writer, List<Member> members)
    {
        writer.WriteLine("context.Read(ref reader);");
        writer.WriteLine("if (context.CurrentTokenType == JsonTokenType.Null) return null;");
        writer.WriteLine("");
        writer.WriteLine("int targetDepth = context.CurrentDepth;");
        writer.OpenBlock("while (context.ReadAtDepth(targetDepth, ref reader))", () =>
        {
            JsonBodyMemberUnmarshaller.WriteMemberUnmarshallers(writer, members);
        });
    }

    // The @eventPayload member IS the message payload: a blob is the raw MemoryStream, a string is the
    // stream read to end, a structure is deserialized by its own unmarshaller off the JSON reader.
    private static void WritePayloadMember(CodeWriter writer, Member member)
    {
        if (member.Type.IsString)
        {
            writer.OpenBlock("using (var sr = new StreamReader(context.Stream))", () =>
            {
                writer.WriteLine($"unmarshalledObject.{member.PropertyName} = sr.ReadToEnd();");
            });
        }
        else if (member.Type.IsStructure)
        {
            writer.WriteLine($"unmarshalledObject.{member.PropertyName} = {member.Type.DotNetType}Unmarshaller.Instance.Unmarshall(context, ref reader);");
        }
        else if (member.Type.IsBlob)
        {
            writer.WriteLine($"unmarshalledObject.{member.PropertyName} = context.Stream as MemoryStream;");
        }
        else
        {
            throw new GeneratorException($"@eventPayload member '{member.PropertyName}' must target a blob, string, or structure shape, but was '{member.Type.DotNetType}'.");
        }
    }

    // A @eventHeader member is read from the event-message header via context.ResponseData. The accessor is
    // chosen by the target shape, symmetric with JsonStructureMarshallerWriter.WriteEventHeader (an enum
    // rides AsString via its implicit conversion).
    private void WriteHeaderMember(CodeWriter writer, StructureShape structure, Member member)
    {
        var target = context.Resolve(structure.Members[member.ModeledName].Target);
        var header = $"""context.ResponseData.GetEventStreamHeader("{member.ModeledName}")""";
        var value = target switch
        {
            StringShape or EnumShape => $"{header}.AsString()",
            BooleanShape => $"{header}.AsBool()",
            IntegerShape or IntEnumShape => $"{header}.AsInt32()",
            LongShape => $"{header}.AsInt64()",
            TimestampShape => $"{header}.AsTimestamp()",
            BlobShape => $"new MemoryStream({header}.AsByteBuf())",
            ShortShape => $"{header}.AsInt16()",
            var other => throw new GeneratorException($"Unsupported @eventHeader type '{other.Type}' on member '{member.ModeledName}'."),
        };

        writer.OpenBlock($"""if (context.ResponseData.IsEventHeaderPresent("{member.ModeledName}"))""", () =>
        {
            writer.WriteLine($"unmarshalledObject.{member.PropertyName} = {value};");
        });
    }

    private static void WriteSingleton(CodeWriter writer, string className)
    {
        writer.WriteLine($"private static {className}Unmarshaller _instance = new {className}Unmarshaller();");
        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Gets the singleton.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public static {className}Unmarshaller Instance => _instance;");
    }
}
