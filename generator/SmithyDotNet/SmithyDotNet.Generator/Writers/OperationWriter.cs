using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers;

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

        return WriteClass(operation.Input, className, baseClass, doc, cancellationToken);
    }

    /// <summary>
    /// Emits the response class for an operation.
    /// </summary>
    public string WriteResponse(Operation operation, CancellationToken cancellationToken = default)
    {
        var className = $"{operation.Name}Response";
        var baseClass = "AmazonWebServiceResponse";
        var doc = $"This is the response object from the {operation.Name} operation.";

        return WriteClass(operation.Output, className, baseClass, doc, cancellationToken);
    }

    private string WriteClass(StructureShape structure, string className, string baseClass, string doc, CancellationToken cancellationToken)
    {
        var members = TypeMapper.ResolveMembers(structure, context);

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        FileHeader.WritePragma(writer, FileHeader.ModelWarnings);
        writer.OpenNamespace($"{context.Namespace}.Model", () =>
        {
            writer.WriteLine("/// <summary>");
            DocumentationFormatter.WriteCommentBlock(writer, DocumentationFormatter.Cleanup(doc));
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {className} : {baseClass}", () => MemberWriter.WriteMembers(writer, members));
        });

        return writer.ToFormattedString(cancellationToken);
    }
}
