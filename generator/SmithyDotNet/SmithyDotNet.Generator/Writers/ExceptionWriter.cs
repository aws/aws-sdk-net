using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for Smithy error shapes (exception classes) and the service-level
/// exception base class.
/// </summary>
public sealed class ExceptionWriter(GenerationContext context, string modelFileName)
{
    private static readonly string[] BaseExceptionUsings =
    [
        "System",
        "System.Collections.Generic",
        "System.Net",
        "System.Text",
        "Amazon.Runtime",
    ];

    /// <summary>
    /// Emits the service-level exception base class (e.g. <c>AmazonCloudTrailDataException</c>).
    /// </summary>
    public string WriteServiceException(CancellationToken cancellationToken = default)
    {
        var className = $"{context.ClientName}Exception";

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, BaseExceptionUsings);
        writer.OpenNamespace(context.Namespace, () =>
        {
            writer.WriteLine("///<summary>");
            writer.WriteLine($"/// Common exception for the {context.ServiceName} service.");
            writer.WriteLine("/// </summary>");
            WriteSerializableAttribute(writer);
            writer.OpenBlock($"public partial class {className} : AmazonServiceException", () =>
            {
                WriteConstructors(writer, className);
                writer.WriteLine();
                WriteSerializationBlock(writer, className, includeGetObjectData: false);
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    /// <summary>
    /// Emits a per-operation exception class (e.g. <c>ChannelNotFoundException</c>).
    /// </summary>
    public string WriteException(StructureShape errorShape, ShapeId shapeId, CancellationToken cancellationToken = default)
    {
        var className = ToExceptionName(shapeId.Name);
        var baseClassName = $"{context.ClientName}Exception";

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.ModelUsings);
        FileHeader.WritePragma(writer, FileHeader.ModelWarnings);
        writer.OpenNamespace($"{context.Namespace}.Model", () =>
        {
            WriteClassDocumentation(writer, errorShape);
            WriteSerializableAttribute(writer);
            writer.OpenBlock($"public partial class {className} : {baseClassName}", () =>
            {
                WriteConstructors(writer, className);
                writer.WriteLine();
                // TODO: emit additional members (with [AWSProperty] and IsSet) when an exception
                // shape carries fields beyond "message". CloudTrail Data has none.
                WriteSerializationBlock(writer, className, includeGetObjectData: true);
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private static void WriteClassDocumentation(CodeWriter writer, StructureShape errorShape)
    {
        var cleaned = DocumentationFormatter.Cleanup(errorShape.GetDocumentation());
        if (cleaned.Length == 0)
        {
            return;
        }

        writer.WriteLine("/// <summary>");
        DocumentationFormatter.WriteCommentBlock(writer, cleaned);
        writer.WriteLine("/// </summary>");
    }

    private static void WriteSerializableAttribute(CodeWriter writer)
    {
        writer.WriteLine("#if !NETSTANDARD");
        writer.WriteLine("[Serializable]");
        writer.WriteLine("#endif");
    }

    private static void WriteConstructors(CodeWriter writer, string className)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Default constructor for {className}");
        writer.WriteLine("/// message.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public {className}() : base() {{ }}");
        writer.WriteLine();

        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Constructs a new {className} with the specified error");
        writer.WriteLine("/// message.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("/// <param name=\"message\">");
        writer.WriteLine("/// Describes the error encountered.");
        writer.WriteLine("/// </param>");
        writer.WriteLine($"public {className}(string message) : base(message) {{ }}");
        writer.WriteLine();

        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Construct instance of {className}");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public {className}(string message, Exception innerException) : base(message, innerException) {{ }}");
        writer.WriteLine();

        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Construct instance of {className}");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public {className}(Exception innerException) : base(innerException) {{ }}");
        writer.WriteLine();

        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Construct instance of {className}");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public {className}(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) {{ }}");
        writer.WriteLine();

        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Construct instance of {className}");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public {className}(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) {{ }}");
    }

    private static void WriteSerializationBlock(CodeWriter writer, string className, bool includeGetObjectData)
    {
        writer.WriteLine("#if !NETSTANDARD");
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// Constructs a new instance of the {className} class with serialized data.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("/// <param name=\"info\">The <see cref=\"T:System.Runtime.Serialization.SerializationInfo\" /> that holds the serialized object data about the exception being thrown.</param>");
        writer.WriteLine("/// <param name=\"context\">The <see cref=\"T:System.Runtime.Serialization.StreamingContext\" /> that contains contextual information about the source or destination.</param>");
        writer.WriteLine("/// <exception cref=\"T:System.ArgumentNullException\">The <paramref name=\"info\" /> parameter is null. </exception>");
        writer.WriteLine("/// <exception cref=\"T:System.Runtime.Serialization.SerializationException\">The class name is null or <see cref=\"P:System.Exception.HResult\" /> is zero (0). </exception>");
        writer.WriteLine($"protected {className}(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)");
        writer.WriteLine("    : base(info, context)");
        writer.WriteLine("{");
        // TODO: for exceptions with members beyond "message", emit info.GetValue per member.
        writer.WriteLine("}");

        if (includeGetObjectData)
        {
            writer.WriteLine();
            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// Sets the <see cref=\"T:System.Runtime.Serialization.SerializationInfo\" /> with information about the exception.");
            writer.WriteLine("/// </summary>");
            writer.WriteLine("/// <param name=\"info\">The <see cref=\"T:System.Runtime.Serialization.SerializationInfo\" /> that holds the serialized object data about the exception being thrown.</param>");
            writer.WriteLine("/// <param name=\"context\">The <see cref=\"T:System.Runtime.Serialization.StreamingContext\" /> that contains contextual information about the source or destination.</param>");
            writer.WriteLine("/// <exception cref=\"T:System.ArgumentNullException\">The <paramref name=\"info\" /> parameter is a null reference (Nothing in Visual Basic). </exception>");
            writer.WriteLine("[System.Security.SecurityCritical]");
            writer.OpenBlock("public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)", () =>
            {
                writer.WriteLine("base.GetObjectData(info, context);");
                // TODO: for exceptions with members beyond "message", emit info.AddValue per member.
            });
        }

        writer.WriteLine("#endif");
    }

    /// <summary>
    /// Applies the exception-suffix naming rule: append "Exception" unless already present,
    /// or replace "Fault" with "Exception".
    /// </summary>
    public static string ToExceptionName(string shapeName)
    {
        if (shapeName.EndsWith("Exception", StringComparison.Ordinal))
        {
            return shapeName;
        }

        if (shapeName.EndsWith("Fault", StringComparison.Ordinal))
        {
            // Strip the trailing "Fault" suffix only (not mid-string occurrences).
            var trimmed = shapeName[..^"Fault".Length];
            return trimmed + "Exception";
        }

        return shapeName + "Exception";
    }
}
