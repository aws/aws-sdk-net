using Microsoft.CodeAnalysis.CSharp;
using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the C# source for the internal service metadata class (e.g.
/// <c>AmazonCloudTrailDataMetadata</c>), which implements <c>IServiceMetadata</c> and exposes the
/// service's ServiceId and its renamed-operation mapping. Written under the service's
/// <c>.Internal</c> namespace, matching the existing AWS SDK for .NET layout.
/// </summary>
public sealed class MetadataWriter(GenerationContext context, string modelFileName)
{
    private static readonly string[] Usings = ["System.Collections.Generic", "Amazon.Runtime.Internal"];

    /// <summary>
    /// Emits the complete formatted metadata source for the service.
    /// </summary>
    public string Write(CancellationToken cancellationToken = default)
    {
        var className = $"{context.ClientName}Metadata";

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, Usings);
        writer.OpenNamespace($"{context.Namespace}.Internal", () =>
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// Service metadata for Amazon {context.ServiceName} service");
            writer.WriteLine("/// </summary>");
            writer.OpenBlock($"public partial class {className} : IServiceMetadata", () =>
            {
                WriteServiceId(writer);
                writer.WriteLine();
                WriteOperationNameMapping(writer);
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    private void WriteServiceId(CodeWriter writer)
    {
        // The metadata ServiceId is the verbatim sdkId (e.g. "CloudTrail Data"), not the normalized
        // class-name component (context.ServiceName), so it is sourced from context.SdkId. The value
        // is escaped through Roslyn so an sdkId containing quotes or backslashes still emits valid C#.
        var serviceId = SymbolDisplay.FormatLiteral(context.SdkId, quote: true);
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Gets the value of the Service Id.");
        writer.WriteLine("/// </summary>");
        writer.WriteLine($"public string ServiceId => {serviceId};");
    }

    private static void WriteOperationNameMapping(CodeWriter writer)
    {
        // Phase 1 has no customization rename map, so the mapping is empty. When operation renames
        // are layered into GenerationContext, this emits one entry per renamed operation.
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Gets the dictionary that gives mapping of renamed operations");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("public IDictionary<string, string> OperationNameMapping => new Dictionary<string, string>(0);");
    }
}
