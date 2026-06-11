using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for the public service interface (e.g. <c>IAmazonCloudTrailData</c>),
/// matching the public API surface of the existing AWS SDK for .NET.
/// <para />
/// Phase 1 scope: a synchronous and asynchronous method pair per operation, with doc comments.
/// Protocol marshalling and the <c>DetermineServiceOperationEndpoint</c> member are deferred, as
/// are the <c>NET8_0_OR_GREATER</c> static-factory members (<c>CreateDefaultClientConfig</c> /
/// <c>CreateDefaultServiceClient</c>) that the base <see cref="Amazon.Runtime.IAmazonService"/>
/// declares as <c>static abstract</c> — these construct the concrete client/config and land with
/// the client writer.
/// </summary>
public sealed class ClientInterfaceWriter(GenerationContext context, string modelFileName)
{
    // Built once per writer rather than per Write() call. Instance (not static like
    // FileHeader.ModelUsings) because the service Model namespace is the only service-specific entry.
    private readonly IReadOnlyList<string> _usings =
    [
        "System",
        "System.Threading",
        "System.Threading.Tasks",
        "System.Collections.Generic",
        "Amazon.Runtime",
        $"{context.Namespace}.Model",
    ];

    /// <summary>
    /// Emits the complete formatted interface source for the service.
    /// </summary>
    public string Write(CancellationToken cancellationToken = default)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, _usings);
        FileHeader.WritePragma(writer, ["CS1570"]);
        writer.OpenNamespace(context.Namespace, () =>
        {
            WriteInterfaceDocumentation(writer);
            writer.OpenBlock($"public partial interface I{context.ClientName} : IAmazonService, IDisposable", () =>
            {
                foreach (var operation in context.Operations)
                {
                    WriteOperation(writer, operation);
                }
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteInterfaceDocumentation(CodeWriter writer)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// <para>Interface for accessing {context.ServiceName}</para>");

        var cleaned = DocumentationFormatter.Cleanup(context.ServiceDocumentation);
        if (cleaned.Length > 0)
        {
            writer.WriteLine("///");
            DocumentationFormatter.WriteCommentBlock(writer, cleaned);
        }

        writer.WriteLine("/// </summary>");
    }

    private void WriteOperation(CodeWriter writer, Operation operation)
    {
        var responseType = $"{operation.Name}Response";
        var requestType = $"{operation.Name}Request";

        // Synchronous overload. The synchronous API surface exists only on .NET Framework (the C2J
        // generator emits it in the _bcl file, which is excluded from the netstandard/net builds), so
        // guard it with #if NETFRAMEWORK in this single-file output.
        writer.WriteLine("#if NETFRAMEWORK");
        WriteOperationDocumentation(writer, operation, isAsync: false);
        writer.WriteLine($"{responseType} {operation.Name}({requestType} request);");
        writer.WriteLine("#endif");
        writer.WriteLine();

        // Asynchronous overload.
        WriteOperationDocumentation(writer, operation, isAsync: true);
        writer.WriteLine($"Task<{responseType}> {operation.Name}Async({requestType} request, CancellationToken cancellationToken = default(CancellationToken));");
        writer.WriteLine();
    }

    private void WriteOperationDocumentation(CodeWriter writer, Operation operation, bool isAsync)
    {
        var cleaned = DocumentationFormatter.Cleanup(operation.Shape.GetDocumentation());
        writer.WriteLine("/// <summary>");
        if (cleaned.Length > 0)
        {
            DocumentationFormatter.WriteCommentBlock(writer, cleaned);
        }

        writer.WriteLine("/// </summary>");
        writer.WriteLine($"/// <param name=\"request\">Container for the necessary parameters to execute the {operation.Name} service method.</param>");

        if (isAsync)
        {
            writer.WriteLine("/// <param name=\"cancellationToken\">");
            writer.WriteLine("///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.");
            writer.WriteLine("/// </param>");
        }

        writer.WriteLine($"/// <returns>The response from the {operation.Name} service method, as returned by {context.ServiceName}.</returns>");

        foreach (var error in operation.Errors)
        {
            WriteExceptionTag(writer, error);
        }

        writer.WriteLine($"/// <seealso href=\"http://docs.aws.amazon.com/goto/WebAPI/{context.EndpointPrefix}-{context.ApiVersion}/{operation.Name}\">REST API Reference for {operation.Name} Operation</seealso>");
    }

    private void WriteExceptionTag(CodeWriter writer, OperationError error)
    {
        var exceptionName = ExceptionWriter.ToExceptionName(error.Id.Name);
        writer.WriteLine($"/// <exception cref=\"{context.Namespace}.Model.{exceptionName}\">");

        var cleaned = DocumentationFormatter.Cleanup(error.Shape.GetDocumentation());
        if (cleaned.Length > 0)
        {
            DocumentationFormatter.WriteCommentBlock(writer, cleaned);
        }

        writer.WriteLine("/// </exception>");
    }
}
