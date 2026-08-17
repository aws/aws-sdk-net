using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers.Paginators;

/// <summary>
/// Emits <c>I{Service}PaginatorFactory.cs</c> — the public interface declaring a factory
/// method per paginated operation, each annotated with <c>[AWSPaginator]</c>.
/// </summary>
public sealed class PaginatorFactoryInterfaceWriter(GenerationContext context, string modelFileName)
{
    public string Write(CancellationToken cancellationToken = default)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.PaginatorUsings);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);
        writer.OpenNamespace($"{context.Namespace}.Model", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Paginators for the {context.ServiceName} service");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public interface I{context.ServiceName}PaginatorFactory", () =>
            {
                for (var i = 0; i < context.PaginatedOperations.Count; i++)
                {
                    if (i > 0)
                    {
                        writer.WriteLine();
                    }

                    WritePaginatorMethod(writer, context.PaginatedOperations[i]);
                }
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private static void WritePaginatorMethod(CodeWriter writer, PaginatedOperation paginatedOp)
    {
        var opName = paginatedOp.Operation.Name;

        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Paginator for {opName} operation");
        writer.WriteLine("/// </summary>");

        if (paginatedOp.PageSizeProperty is not null)
        {
            writer.WriteLine($"""[AWSPaginator(InputToken = ["{paginatedOp.InputTokenProperty}"], LimitKey = "{paginatedOp.PageSizeProperty}", OutputToken = ["{paginatedOp.OutputTokenProperty}"])]""");
        }
        else
        {
            writer.WriteLine($"""[AWSPaginator(InputToken = ["{paginatedOp.InputTokenProperty}"], OutputToken = ["{paginatedOp.OutputTokenProperty}"])]""");
        }
        writer.WriteLine($"I{opName}Paginator {opName}({opName}Request request);");
    }
}
