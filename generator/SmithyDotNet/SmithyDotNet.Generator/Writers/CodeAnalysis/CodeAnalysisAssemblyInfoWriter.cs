using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers.CodeAnalysis;

public class CodeAnalysisAssemblyInfoWriter(GenerationContext context)
{
    public string Write()
    {
        var writer = new CodeWriter();
        FileHeader.WriteUsings(writer, FileHeader.CodeAnalysisAssemblyInfoUsings);

        var assemblyVersion = context.Manifest.GetServiceAssemblyVersion(context.ServiceName);
        var fileVersion = context.Manifest.GetServiceVersion(context.ServiceName);

        FileHeader.WriteAssemblyInfoBody(
            writer,
            context.AssemblyName,
            w => w.WriteLine($"""[assembly: AssemblyDescription("Code analysis project file for AWSSDK.{context.ServiceName}")]"""),
            assemblyVersion,
            fileVersion);

        return writer.ToRawString();
    }
}
