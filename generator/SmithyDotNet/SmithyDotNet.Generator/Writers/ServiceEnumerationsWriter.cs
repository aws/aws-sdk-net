using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits <c>Generated/ServiceEnumerations.g.cs</c>. Enum and <c>ConstantClass</c> generation is
/// not implemented yet; the empty file is still emitted so the generated file set matches the
/// shipping SDK's.
/// </summary>
public sealed class ServiceEnumerationsWriter(GenerationContext context, string modelFileName)
{
    /// <summary>
    /// Emits the complete formatted enumerations source for the service.
    /// </summary>
    public string Write(CancellationToken cancellationToken = default)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.ServiceEnumerationsUsings);
        writer.OpenNamespace(context.Namespace, () => { });
        return writer.ToFormattedString(cancellationToken);
    }
}
