using SmithyDotNet.Generator.Generation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmithyDotNet.Generator.Writers.CodeAnalysis;

public class NullCollectionInitializerAnalyzerWriter(GenerationContext context, string modelFileName)
{
    public string Write(CancellationToken cancellationToken = default)
    {
        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        WriteUsings(writer);
        writer.OpenNamespace($"{context.Namespace}.CodeAnalysis", () =>
        {
            writer.WriteLine("[DiagnosticAnalyzer(LanguageNames.CSharp)]");
            writer.OpenBlock("public class NullCollectionInitializerAnalyzer : AbstractNullCollectionInitializerAnalyzer", () =>
            {
                writer.WriteLine($"""protected override string GetModelNamespace() => "{context.Namespace}.Model";""");
            });
        });
        return writer.ToFormattedString();
    }

    private void WriteUsings(CodeWriter writer)
    {
        FileHeader.WriteUsings(writer, FileHeader.NullCollectionInitializerAnalyzerUsings);
    }
}
