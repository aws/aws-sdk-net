using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers.CodeAnalysis;

public class PropertyValueAssignmentAnalyzerWriter(GenerationContext context, string modelFileName)
{
    public string Write(CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer, FileHeader.PropertyValueAssignmentAnalyzerUsings);
        writer.OpenNamespace($"{context.Namespace}.CodeAnalysis", () =>
        {
            writer.WriteLine("[DiagnosticAnalyzer(LanguageNames.CSharp)]");
            writer.OpenBlock("public class PropertyValueAssignmentAnalyzer : AbstractPropertyValueAssignmentAnalyzer", () =>
            {
                writer.WriteLine($"""public override string GetServiceName() => "{context.ServiceName}";""");
            });
        });
        return writer.ToFormattedString();
    }
}
