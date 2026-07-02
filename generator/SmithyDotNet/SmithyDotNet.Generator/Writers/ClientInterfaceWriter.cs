using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for the public service interface (e.g. <c>IAmazonCloudTrailData</c>),
/// matching the public API surface of the existing AWS SDK for .NET. The interface declares a
/// synchronous and asynchronous method pair per operation, with doc comments.
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
                for (var i = 0; i < context.Operations.Count; i++)
                {
                    if (i > 0)
                    {
                        writer.WriteLine();
                    }

                    WriteOperation(writer, context.Operations[i]);
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
        DocumentationFormatter.WriteOperationDocumentation(writer, context, operation, isAsync: false);
        writer.WriteLine($"{responseType} {operation.Name}({requestType} request);");
        writer.WriteLine("#endif");
        writer.WriteLine();

        // Asynchronous overload.
        DocumentationFormatter.WriteOperationDocumentation(writer, context, operation, isAsync: true);
        writer.WriteLine($"Task<{responseType}> {operation.Name}Async({requestType} request, CancellationToken cancellationToken = default(CancellationToken));");
    }

}
