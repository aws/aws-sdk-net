using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Paginators;

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

                foreach (var resultKey in paginatedOp.ResultKeys)
                {
                    writer.WriteLine();
                    writer.WriteLine("/// <summary>");
                    writer.WriteLine($"/// Enumerable containing all of the {resultKey.Property}");
                    writer.WriteLine("/// </summary>");
                    writer.WriteLine($"public IPaginatedEnumerable<{resultKey.ElementType}> {resultKey.Property} =>");
                    writer.WriteLine($"    new PaginatedResultKeyResponse<{responseType}, {resultKey.ElementType}>(this, (i) => i.{resultKey.Path} ?? new List<{resultKey.ElementType}>());");
                }

                writer.WriteLine();
                writer.OpenBlock($"internal {opName}Paginator({clientInterface} client, {requestType} request)", () =>
                {
                    writer.WriteLine("this._client = client;");
                    writer.WriteLine("this._request = request;");
                });

                WritePaginate(writer, paginatedOp, async: false);
                WritePaginate(writer, paginatedOp, async: true);
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private static void WritePaginate(CodeWriter writer, PaginatedOperation paginatedOp, bool async)
    {
        var opName = paginatedOp.Operation.Name;
        var responseType = $"{opName}Response";
        var tokens = TokenVariables(paginatedOp);
        var signature = async
            ? $"async IAsyncEnumerable<{responseType}> IPaginator<{responseType}>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)"
            : $"IEnumerable<{responseType}> IPaginator<{responseType}>.Paginate()";
        var call = async
            ? $"response = await _client.{opName}Async(_request, cancellationToken).ConfigureAwait(false);"
            : $"response = _client.{opName}(_request);";

        writer.WriteLine(async ? "#if AWS_ASYNC_ENUMERABLES_API" : "#if NETFRAMEWORK");
        writer.OpenBlock(signature, () =>
        {
            writer.OpenBlock("if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)", () =>
            {
                writer.WriteLine("""throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");""");
            });
            writer.WriteLine("PaginatorUtils.SetUserAgentAdditionOnRequest(_request);");
            for (var i = 0; i < tokens.Count; i++)
            {
                writer.WriteLine($"var {tokens[i]} = _request.{paginatedOp.InputTokenProperties[i]};");
            }
            writer.WriteLine($"{responseType} response;");
            writer.OpenBlock("do", () =>
            {
                for (var i = 0; i < tokens.Count; i++)
                {
                    writer.WriteLine($"_request.{paginatedOp.InputTokenProperties[i]} = {tokens[i]};");
                }
                writer.WriteLine(call);
                for (var i = 0; i < tokens.Count; i++)
                {
                    writer.WriteLine($"{tokens[i]} = response.{paginatedOp.OutputTokenProperties[i]};");
                }
                if (async)
                {
                    writer.WriteLine("cancellationToken.ThrowIfCancellationRequested();");
                }
                writer.WriteLine("yield return response;");
            });
            writer.WriteLine(LoopCondition(paginatedOp, tokens[0]));
        });
        writer.WriteLine("#endif");
    }

    // The usual single token is "nextToken"; several are named after the request members
    // (Route 53: startRecordName, startRecordType, startRecordIdentifier).
    private static List<string> TokenVariables(PaginatedOperation paginatedOp)
    {
        if (paginatedOp.InputTokenProperties.Count == 1)
        {
            return ["nextToken"];
        }

        var variables = new List<string>();
        foreach (var property in paginatedOp.InputTokenProperties)
        {
            variables.Add(SdkNaming.ToParameterName(property));
        }
        return variables;
    }

    // The first token decides whether to continue, as in C2J's multi-token paginators.
    private static string LoopCondition(PaginatedOperation paginatedOp, string token)
    {
        if (paginatedOp.TokensAreMaps)
        {
            return $"while ({token}?.Count > 0);";
        }
        if (paginatedOp.StopOnSameToken)
        {
            return $"while ({token} != _request.{paginatedOp.InputTokenProperties[0]});";
        }

        return $"while (!string.IsNullOrEmpty({token}));";
    }
}
