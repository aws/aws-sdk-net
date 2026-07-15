using SmithyDotNet.Generator.Generation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmithyDotNet.Generator.Writers.CodeAnalysis;

public class PropertyValueAssignmentAnalyzerWriter(GenerationContext context, string modelFileName)
{
    public string Write(CancellationToken cancellationToken = default)
    {
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
