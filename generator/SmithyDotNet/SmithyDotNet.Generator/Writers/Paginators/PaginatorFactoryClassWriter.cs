using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers.Paginators;

/// <summary>
/// Emits <c>{Service}PaginatorFactory.cs</c> — the concrete factory that creates paginator
/// instances for each paginated operation.
/// </summary>
public sealed class PaginatorFactoryClassWriter(GenerationContext context, string modelFileName)
{
    public string Write(CancellationToken cancellationToken = default)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WritePragma(writer, FileHeader.MarshallerWarnings);
        writer.OpenNamespace($"{context.Namespace}.Model", () =>
        {
            var clientInterface = $"I{context.ClientName}";

            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Paginators for the {context.ServiceName} service");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public class {context.ServiceName}PaginatorFactory : I{context.ServiceName}PaginatorFactory", () =>
            {
                writer.WriteLine($"private readonly {clientInterface} client;");
                writer.WriteLine();
                writer.OpenBlock($"internal {context.ServiceName}PaginatorFactory({clientInterface} client)", () =>
                {
                    writer.WriteLine("this.client = client;");
                });

                foreach (var paginatedOp in context.PaginatedOperations)
                {
                    writer.WriteLine();
                    var opName = paginatedOp.Operation.Name;
                    writer.WriteLine("/// <summary>");
                    writer.WriteLine($"/// Paginator for {opName} operation");
                    writer.WriteLine("/// </summary>");
                    writer.OpenBlock($"public I{opName}Paginator {opName}({opName}Request request)", () =>
                    {
                        writer.WriteLine($"return new {opName}Paginator(this.client, request);");
                    });
                }
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }
}
