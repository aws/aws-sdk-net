using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers.Paginators;

/// <summary>
/// Emits <c>{Op}Paginator.cs</c> — the internal sealed class implementing
/// <c>IPaginator&lt;TResponse&gt;</c> and <c>I{Op}Paginator</c>.
/// </summary>
public sealed class PaginatorClassWriter(GenerationContext context, string modelFileName)
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
            var responseType = $"{opName}Response";
            var requestType = $"{opName}Request";
            var clientInterface = $"I{context.ClientName}";

            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Paginator for the {opName} operation");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"internal sealed partial class {opName}Paginator : IPaginator<{responseType}>, I{opName}Paginator", () =>
            {
                writer.WriteLine($"private readonly {clientInterface} _client;");
                writer.WriteLine($"private readonly {requestType} _request;");
                writer.WriteLine("private int _isPaginatorInUse = 0;");
                writer.WriteLine();

                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// Enumerable containing all full responses for the operation");
                writer.WriteLine("/// </summary>");
                writer.WriteLine($"public IPaginatedEnumerable<{responseType}> Responses => new PaginatedResponse<{responseType}>(this);");

                if (paginatedOp.ItemsProperty is not null)
                {
                    writer.WriteLine();
                    writer.WriteLine("/// <summary>");
                    writer.WriteLine($"/// Enumerable containing all of the {paginatedOp.ItemsProperty}");
                    writer.WriteLine("/// </summary>");
                    writer.WriteLine($"public IPaginatedEnumerable<{paginatedOp.ItemsElementType}> {paginatedOp.ItemsProperty} =>");
                    writer.WriteLine($"    new PaginatedResultKeyResponse<{responseType}, {paginatedOp.ItemsElementType}>(this, (i) => i.{paginatedOp.ItemsPath} ?? new List<{paginatedOp.ItemsElementType}>());");
                }

                writer.WriteLine();
                writer.OpenBlock($"internal {opName}Paginator({clientInterface} client, {requestType} request)", () =>
                {
                    writer.WriteLine("this._client = client;");
                    writer.WriteLine("this._request = request;");
                });

                WriteSyncPaginate(writer, paginatedOp);
                WriteAsyncPaginate(writer, paginatedOp);
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private static void WriteSyncPaginate(CodeWriter writer, PaginatedOperation paginatedOp)
    {
        var opName = paginatedOp.Operation.Name;
        var responseType = $"{opName}Response";

        writer.WriteLine("#if NETFRAMEWORK");
        writer.OpenBlock($"IEnumerable<{responseType}> IPaginator<{responseType}>.Paginate()", () =>
        {
            writer.OpenBlock("if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)", () =>
            {
                writer.WriteLine("""throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");""");
            });
            writer.WriteLine("PaginatorUtils.SetUserAgentAdditionOnRequest(_request);");
            writer.WriteLine($"var nextToken = _request.{paginatedOp.InputTokenProperty};");
            writer.WriteLine($"{responseType} response;");
            writer.OpenBlock("do", () =>
            {
                writer.WriteLine($"_request.{paginatedOp.InputTokenProperty} = nextToken;");
                writer.WriteLine($"response = _client.{opName}(_request);");
                writer.WriteLine($"nextToken = response.{paginatedOp.OutputTokenProperty};");
                writer.WriteLine("yield return response;");
            });
            writer.WriteLine("while (!string.IsNullOrEmpty(nextToken));");
        });
        writer.WriteLine("#endif");
    }

    private static void WriteAsyncPaginate(CodeWriter writer, PaginatedOperation paginatedOp)
    {
        var opName = paginatedOp.Operation.Name;
        var responseType = $"{opName}Response";

        writer.WriteLine("#if AWS_ASYNC_ENUMERABLES_API");
        writer.OpenBlock($"async IAsyncEnumerable<{responseType}> IPaginator<{responseType}>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)", () =>
        {
            writer.OpenBlock("if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)", () =>
            {
                writer.WriteLine("""throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");""");
            });
            writer.WriteLine("PaginatorUtils.SetUserAgentAdditionOnRequest(_request);");
            writer.WriteLine($"var nextToken = _request.{paginatedOp.InputTokenProperty};");
            writer.WriteLine($"{responseType} response;");
            writer.OpenBlock("do", () =>
            {
                writer.WriteLine($"_request.{paginatedOp.InputTokenProperty} = nextToken;");
                writer.WriteLine($"response = await _client.{opName}Async(_request, cancellationToken).ConfigureAwait(false);");
                writer.WriteLine($"nextToken = response.{paginatedOp.OutputTokenProperty};");
                writer.WriteLine("cancellationToken.ThrowIfCancellationRequested();");
                writer.WriteLine("yield return response;");
            });
            writer.WriteLine("while (!string.IsNullOrEmpty(nextToken));");
        });
        writer.WriteLine("#endif");
    }
}
