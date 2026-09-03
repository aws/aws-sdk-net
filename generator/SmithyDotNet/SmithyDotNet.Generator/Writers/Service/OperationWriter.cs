using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Service;

/// <summary>
/// Emits the C# source for operation request and response classes.
/// </summary>
public sealed class OperationWriter(GenerationContext context, string modelFileName)
{
    /// <summary>
    /// Emits the service-level request base class (e.g. <c>AmazonCloudTrailDataRequest</c>),
    /// which all operation request classes extend.
    /// </summary>
    public string WriteServiceRequest(CancellationToken cancellationToken = default)
    {
        var className = $"Amazon{context.ServiceName}Request";

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, ["Amazon.Runtime"]);
        writer.OpenNamespace(context.Namespace, () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Base class for {context.ServiceName} operation requests.");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {className} : AmazonWebServiceRequest", () => { });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    /// <summary>
    /// Emits the request class for an operation.
    /// </summary>
    public string WriteRequest(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Request";
        var baseClass = $"Amazon{context.ServiceName}Request";

        // Cleanup the operation doc on its own first so its leading <p> wrapper is stripped,
        // then prepend the request preface so it reads as a single paragraph.
        var cleanedOperationDoc = DocumentationFormatter.Cleanup(operation.Shape.GetDocumentation());
        var doc = $"Container for the parameters to the {operation.Name} operation. {cleanedOperationDoc}";

        var members = TypeMapper.ResolveMembers(operation.Input, context);
        return WriteClass(new OperationRecord(className, baseClass, doc, members), cancellationToken);
    }

    /// <summary>
    /// Emits the response class for an operation.
    /// </summary>
    public string WriteResponse(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Response";
        var members = TypeMapper.ResolveMembers(operation.Output, context);

        // A response member named ContentLength is omitted rather than shadowed with `new`:
        // AmazonWebServiceResponse already declares it, and the unmarshaller assigns the inherited property.
        members.RemoveAll(m => m.PropertyName == "ContentLength");

        // A @streaming output member hands back the raw response stream the caller must dispose.
        // The trait lives on the target blob shape, so detect it via the resolved member type.
        var streamingMembers = members.Where(m => m.Type.IsStreaming).ToList();
        var baseClass = "AmazonWebServiceResponse";
        if (streamingMembers.Count > 0)
        {
            baseClass = baseClass + ", IDisposable";
        }
        var doc = $"This is the response object from the {operation.Name} operation.";

        return WriteClass(new OperationRecord(className, baseClass, doc, members, streamingMembers), cancellationToken);
    }

    /// <summary>
    /// Describes an operation request or response class to emit: its name, base type, documentation,
    /// members, and any <c>@streaming</c> members whose streams the class must dispose.
    /// </summary>
    private sealed record OperationRecord(
        string ClassName,
        string BaseClass,
        string Doc,
        List<Member> Members,
        List<Member>? StreamingMembers = null);

    private string WriteClass(OperationRecord opRecord, CancellationToken cancellationToken)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        FileHeader.WritePragma(writer, FileHeader.ModelWarnings);
        writer.OpenNamespace($"{context.Namespace}.Model", () =>
        {
            writer.WriteLine("/// <summary>");
            DocumentationFormatter.WriteCommentBlock(writer, DocumentationFormatter.Cleanup(opRecord.Doc));
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {opRecord.ClassName} : {opRecord.BaseClass}", () =>
            {
                MemberWriter.WriteMembers(writer, opRecord.Members);
                if (opRecord.StreamingMembers is { Count: > 0 } streamingMembers)
                {
                    WriteDisposePattern(writer, streamingMembers);
                }
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    /// <summary>
    /// Emits the standard <see cref="IDisposable"/> region that releases each streaming member's stream.
    /// </summary>
    private static void WriteDisposePattern(CodeWriter writer, List<Member> streamingMembers)
    {
        writer.WriteLine();
        writer.WriteLine("#region Dispose Pattern");
        writer.WriteLine();
        writer.WriteLine("private bool _disposed;");
        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Disposes of all managed and unmanaged resources.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public void Dispose()", () =>
        {
            writer.WriteLine("Dispose(true);");
            writer.WriteLine("GC.SuppressFinalize(this);");
        });
        writer.WriteLine();
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Disposes of all managed and unmanaged resources.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("protected virtual void Dispose(bool disposing)", () =>
        {
            writer.OpenBlock("if (_disposed)", () => writer.WriteLine("return;"));
            writer.WriteLine();
            writer.OpenBlock("if (disposing)", () =>
            {
                foreach (var member in streamingMembers)
                {
                    writer.WriteLine($"this.{member.PropertyName}?.Dispose();");
                    writer.WriteLine($"this.{member.PropertyName} = null;");
                }
            });
            writer.WriteLine();
            writer.WriteLine("this._disposed = true;");
        });
        writer.WriteLine();
        writer.WriteLine("#endregion");
    }
}
