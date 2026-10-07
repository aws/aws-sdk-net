using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Paginators;

namespace SmithyDotNet.Generator.Writers.Paginators;

/// <summary>
/// Emits <c>I{Op}Paginator.cs</c> — the public interface exposing <c>Responses</c> and
/// optional result-key properties for a single paginated operation.
/// </summary>
public sealed class PaginatorInterfaceWriter(GenerationContext context, string modelFileName)
{
    public string Write(PaginatedOperation paginatedOp, CancellationToken cancellationToken = default)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.PaginatorUsings);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);
        writer.OpenNamespace($"{context.Namespace}.Model", () =>
        {
            var opName = paginatedOp.Operation.Name;
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Paginator for the {opName} operation");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public interface I{opName}Paginator", () =>
            {
                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// Enumerable containing all full responses for the operation");
                writer.WriteLine("/// </summary>");
                writer.WriteLine($"IPaginatedEnumerable<{opName}Response> Responses {{ get; }}");

                foreach (var resultKey in paginatedOp.ResultKeys)
                {
                    writer.WriteLine();
                    writer.WriteLine("/// <summary>");
                    writer.WriteLine($"/// Enumerable containing all of the {resultKey.Property}");
                    writer.WriteLine("/// </summary>");
                    writer.WriteLine($"IPaginatedEnumerable<{resultKey.ElementType}> {resultKey.Property} {{ get; }}");
                }
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }
}
