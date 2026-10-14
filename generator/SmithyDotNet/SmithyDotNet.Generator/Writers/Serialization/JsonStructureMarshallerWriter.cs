using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;

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
/// <c>JsonRPCStructureMarshaller</c>); see <see cref="MarshallerCommon.WriteEventPayload"/>.
/// </summary>
/// <param name="context"></param>
/// <param name="modelFileName"></param>
public sealed class JsonStructureMarshallerWriter(GenerationContext context, string modelFileName)
{
    public string Write(StructureShape structure, CancellationToken cancellationToken = default)
    {
        var className = context.ToDotNetName(structure.Id);
        var marshallerClassName = context.StructureMarshallerName(structure.Id);
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
            writer.OpenBlock($"public partial class {marshallerClassName} : IRequestMarshaller<{className}, JsonMarshallerContext>", () =>
            {
                WriteMarshallMethod(members, writer, className);
                writer.WriteLine("");
                MarshallerCommon.WriteStructureMarshallerSingleton(writer, marshallerClassName);
            });
        });
        return writer.ToFormattedString(cancellationToken);
    }

    private static void WriteMarshallMethod(List<Member> members, CodeWriter writer, string className)
    {
        WriteMarshallMethodDocumentation(writer);
        writer.OpenBlock($"public void Marshall({className} requestObject, JsonMarshallerContext context)", () =>
        {
            writer.WriteLine("if (requestObject == null) return;");
            writer.WriteLine("");
            WriteMemberMarshallers(writer, members);
        });
    }

    private static void WriteMemberMarshallers(CodeWriter writer, List<Member> members)
    {
        for (int i = 0; i < members.Count; i++)
        {
            var member = members[i];
            if (member.IsEventPayload)
            {
                MarshallerCommon.WriteEventPayload(writer, member);
            }
            else if (member.IsEventHeader)
            {
                MarshallerCommon.WriteEventHeader(writer, member);
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

