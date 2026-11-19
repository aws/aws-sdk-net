using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers.CodeAnalysis;

public class DeprecatedTargetFrameworkAnalyzerWriter(GenerationContext context, string modelFileName)
{
    public string Write(CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
        writer.OpenNamespace($"{context.Namespace}.CodeAnalysis", () =>
        {
            writer.WriteLine("[DiagnosticAnalyzer(LanguageNames.CSharp)]");
            writer.OpenBlock("public class DeprecatedTargetFrameworkAnalyzer : AbstractDeprecatedTargetFrameworkAnalyzer", () =>
            {
            });
        });
        return writer.ToFormattedString();
    }

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.NullCollectionInitializerAnalyzerUsings);
    }
}
