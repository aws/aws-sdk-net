using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using System.Collections.Generic;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for a JSON structure marshaller matching the public API surface
/// of the existing AWS SDK for .Net.
/// <para />
/// Phase 1 scope: Structures whose members all resolve to <c>string</c>. Any other member type
/// throws a <see cref="GeneratorException"/>. 
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
        FileHeader.WriteUsings(writer, [$"{context.Namespace}.Model"]);
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
            WriteMemberMarshallers(writer, members);
        });
    }

    // The marshalName can be overridden via https://smithy.io/2.0/spec/protocol-traits.html#jsonname-trait, but we won't handle that for now.
    private void WriteMemberMarshallers(CodeWriter writer, List<Member> members)
    {
        for (int i = 0; i< members.Count; i++)
        {
            if (members[i].DotNetType == "string")
            {
                writer.OpenBlock($"if (requestObject.IsSet{members[i].PropertyName}())", () =>
                {
                    writer.WriteLine($"context.Writer.WritePropertyName(\"{members[i].ModeledName}\");");
                    writer.WriteLine($"context.Writer.WriteStringValue(requestObject.{members[i].PropertyName});");
                });
            }
            else
            {
                throw new GeneratorException("Only string members are handled currently");
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

