using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Writers.Shapes;

namespace SmithyDotNet.Generator.Writers.EventStreams;

/// <summary>
/// Emits the per-service event stream exception (e.g. <c>AmazonIoTSiteWiseEventStreamException</c>).
/// An output event stream wraps every error it carries in this one type, so consumers subscribe to a
/// single exception rather than one per modeled error. One file per service, emitted only when the
/// service has an output event stream.
/// </summary>
public sealed class EventStreamExceptionWriter(GenerationContext context, string modelFileName)
{
    private static readonly string[] Usings =
    [
        "System",
        "Amazon.Runtime.EventStreams.Internal",
    ];

    public string Write(CancellationToken cancellationToken = default)
    {
        var className = $"{context.BaseName}EventStreamException";

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, Usings);
        writer.OpenNamespace(context.Namespace, () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// Modeled Exception that either comes over the stream from the service model, or wraps other exceptions for the purpose of raising events. If it is");
            writer.WriteLine("/// modelled, it will be a subclass.");
            writer.WriteLine("/// </summary>");
            ExceptionWriter.WriteSerializableAttribute(writer);
            writer.OpenBlock($"public partial class {className} : EventStreamException", () =>
            {
                WriteConstructors(writer, className);
                writer.WriteLine();
                ExceptionWriter.WriteSerializationBlock(writer, className, [], includeGetObjectData: false);
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private static void WriteConstructors(CodeWriter writer, string className)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Creates a new {className}");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public {className}() : base() {{ }}");
        writer.WriteLine();

        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Creates a new {className}");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public {className}(string message) : base(message) {{ }}");
        writer.WriteLine();

        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Creates a new {className}");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public {className}(string message, Exception innerException) : base(message, innerException) {{ }}");
    }
}
