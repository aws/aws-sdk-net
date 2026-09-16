using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Serialization;

/// <summary>
/// Emits the C# source for a JSON structure marshaller matching the public API surface
/// of the existing AWS SDK for .Net.
/// <para />
/// Member codegen is shared with the top-level operation body via
/// <see cref="JsonBodyMemberMarshaller.WriteBodyMember"/>: scalars, nested structures, and lists
/// of strings or structures. A map member throws a <see cref="GeneratorException"/>.
/// <para />
/// A request event-stream event uses the same class. Its publisher marshaller calls it with the JSON
/// object already open, so <c>@eventHeader</c> members go to <c>context.Request.EventHeaders</c> and an
/// explicit <c>@eventPayload</c> to <c>context.Request.Content</c>, not the body (C2J
/// <c>JsonRPCStructureMarshaller</c>).
/// </summary>
/// <param name="context"></param>
/// <param name="modelFileName"></param>
public sealed class JsonStructureMarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(StructureShape structure, ShapeId shapeId, CancellationToken cancellationToken = default)
    {
        var className = context.ToDotNetName(shapeId);
        var members = TypeMapper.ResolveMembers(structure, context);
        var writer = new CodeWriter();

        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        writer.WriteLine($"using {context.Namespace}.Model;");
        FileHeader.WriteUsings(writer, FileHeader.MarshallerUsings);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);

        writer.OpenNamespace($"{context.Namespace}.Model.Internal.MarshallTransformations", () =>
        {
            WriteMarshallerDocumentation(writer, className);
            writer.OpenBlock($"public partial class {className}Marshaller : IRequestMarshaller<{className}, JsonMarshallerContext>", () =>
            {
                WriteMarshallMethod(structure, members, writer, className);
                writer.WriteLine("");
                WriteSingletonMarshaller(writer, className);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteSingletonMarshaller(CodeWriter writer, string className)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Singleton Marshaller");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public readonly static {className}Marshaller Instance = new {className}Marshaller();");
    }

    private void WriteMarshallMethod(StructureShape structure, List<Member> members, CodeWriter writer, string className)
    {
        WriteMarshallMethodDocumentation(writer);
        writer.OpenBlock($"public void Marshall({className} requestObject, JsonMarshallerContext context)", () =>
        {
            writer.WriteLine($"if (requestObject== null) return;");
            writer.WriteLine("");
            WriteMemberMarshallers(writer, structure, members);
        });
    }

    private void WriteMemberMarshallers(CodeWriter writer, StructureShape structure, List<Member> members)
    {
        for (int i = 0; i < members.Count; i++)
        {
            var member = members[i];
            var memberShape = structure.Members[member.ModeledName];
            if (memberShape.IsEventPayload())
            {
                WriteEventPayload(writer, member);
            }
            else if (memberShape.IsEventHeader())
            {
                WriteEventHeader(writer, member, memberShape);
            }
            else
            {
                JsonBodyMemberMarshaller.WriteBodyMember(writer, member, "requestObject");
            }

            if (i < members.Count - 1)
            {
                writer.WriteLine("");
            }
        }
    }

    // Blob/string are the raw bytes the publisher sends as octet-stream/text-plain; a structure/union writes
    // its members into the object the publisher opened (the protocol tests expect the bare structure).
    // TODO (publisher task): {Union}PublisherMarshaller must pick the payload source and :content-type per
    // event - Request.Content for blob/string, the JSON writer's stream otherwise - instead of always JSON.
    private static void WriteEventPayload(CodeWriter writer, Member member)
    {
        writer.OpenBlock($"if (requestObject.IsSet{member.PropertyName}())", () =>
        {
            if (member.Type.IsBlob)
            {
                writer.WriteLine($"context.Request.Content = requestObject.{member.PropertyName}.ToArray();");
            }
            else if (member.Type.MarshalsAsString)
            {
                writer.WriteLine($"context.Request.Content = Encoding.UTF8.GetBytes(requestObject.{member.PropertyName});");
            }
            else if (member.Type.IsStructure)
            {
                writer.WriteLine($"{member.Type.DotNetType}Marshaller.Instance.Marshall(requestObject.{member.PropertyName}, context);");
            }
            else
            {
                throw new GeneratorException($"Unsupported @eventPayload type '{member.Type.DotNetType}' on member '{member.ModeledName}'.");
            }
        });
    }

    // Header name is the member name, never @jsonName. An enum rides SetString via its implicit conversion.
    private void WriteEventHeader(CodeWriter writer, Member member, MemberShape memberShape)
    {
        var value = $"requestObject.{member.PropertyName}";
        var setter = context.Resolve(memberShape.Target) switch
        {
            StringShape or EnumShape => $"SetString({value})",
            BooleanShape => $"SetBool({value}.Value)",
            IntegerShape or IntEnumShape => $"SetInt32({value}.Value)",
            LongShape => $"SetInt64({value}.Value)",
            TimestampShape => $"SetTimestamp({value}.Value)",
            BlobShape => $"SetByteBuf({value}.ToArray())",
            var other => throw new GeneratorException($"Unsupported @eventHeader type '{other.Type}' on member '{member.ModeledName}'."),
        };

        writer.OpenBlock($"if (requestObject.IsSet{member.PropertyName}())", () =>
        {
            writer.WriteLine($"""var header = new Amazon.Runtime.EventStreams.EventStreamHeader("{member.ModeledName}");""");
            writer.WriteLine($"header.{setter};");
            writer.WriteLine("context.Request.EventHeaders.Add(header);");
        });
    }

    private static void WriteMarshallerDocumentation(CodeWriter writer, string className)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// {className} Marshaller");
        writer.WriteLine("/// </summary>");
    }

    private static void WriteMarshallMethodDocumentation(CodeWriter writer)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Marshall the structure from the request object to the service");
        writer.WriteLine("/// </summary>");
    }
}

