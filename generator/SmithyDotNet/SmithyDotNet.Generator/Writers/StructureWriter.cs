using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for a plain Smithy structure shape (a model class with no base type),
/// matching the public API surface of the existing AWS SDK for .NET.
/// <para />
/// Phase 1 scope: structures whose members all resolve to <c>string</c>. Any other member
/// type throws a <see cref="GeneratorException"/>. Request, response, exception, and
/// collection handling are deferred to later writers.
/// </summary>
public sealed class StructureWriter(GenerationContext context, string modelFileName)
{
    /// <summary>
    /// Emits the complete formatted source file for one structure. The <paramref name="shapeId"/>
    /// supplies the class name (via <see cref="GenerationContext.ToDotNetName"/>) because a
    /// <see cref="StructureShape"/> does not carry its own ID.
    /// </summary>
    public string Write(StructureShape structure, ShapeId shapeId, CancellationToken cancellationToken = default)
    {
        var className = context.ToDotNetName(shapeId);
        var members = TypeMapper.ResolveMembers(structure, context);

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        FileHeader.WritePragma(writer, FileHeader.ModelWarnings);
        writer.OpenNamespace($"{context.Namespace}.Model", () =>
        {
            WriteClassDocumentation(writer, structure);
            writer.OpenBlock($"public partial class {className}", () => MemberWriter.WriteMembers(writer, members));
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private static void WriteClassDocumentation(CodeWriter writer, StructureShape structure)
    {
        var cleaned = DocumentationFormatter.Cleanup(structure.GetDocumentation());
        if (cleaned.Length == 0)
        {
            return;
        }

        writer.WriteLine("/// <summary>");
        DocumentationFormatter.WriteCommentBlock(writer, cleaned);
        writer.WriteLine("/// </summary>");
    }
}
