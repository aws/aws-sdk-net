using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers.NuGet;

public sealed class NuspecWriter(GenerationContext context)
{
    public string Write()
    {
        var writer = new CodeWriter();
        writer.WriteLine("""<?xml version="1.0" encoding="utf-8"?>""");
        writer.OpenXmlBlock("package", () =>
        {
            WriteMetadata(writer);
            WriteFiles(writer);
        });
        return writer.ToRawString();
    }

    private void WriteMetadata(CodeWriter writer)
    {
        writer.OpenXmlBlock("metadata", () =>
        {
            // in current generator the AssemblyTitle comes from the Namespace + ClassName, which accounts for metadata.json and custom overrides
            // let's keep it simple for now
            writer.WriteLine($"<id>{context.AssemblyName}</id>");
            writer.WriteLine($"<title>AWSSDK - {context.ServiceName}</title>");
            writer.WriteLine($"<version>{context.Manifest.GetServiceVersion(context.ServiceName)}</version>");
            writer.WriteLine("<authors>Amazon Web Services</authors>");
            writer.WriteLine($"<description>{System.Security.SecurityElement.Escape(context.Metadata?.Synopsis)}</description>");
            writer.WriteLine("<language>en-US</language>");
            writer.WriteLine("""<license type="expression">Apache-2.0</license>""");
            writer.WriteLine("<projectUrl>https://github.com/aws/aws-sdk-net/</projectUrl>");
            string tags = context.Metadata is { Tags.Count: > 0 } metadata ? " " + string.Join(" ", metadata.Tags) : string.Empty;
            writer.WriteLine($"<tags>AWS Amazon cloud {context.ServiceName} aws-sdk-v4{System.Security.SecurityElement.Escape(tags)}</tags>");
            writer.WriteLine("""<icon>images\AWSLogo.png</icon>""");

            if (!string.IsNullOrEmpty(context.Metadata?.LicenseUrl))
            {
                writer.WriteLine("<requireLicenseAcceptance>true</requireLicenseAcceptance>");
            }

            // for now just handle the core dependency since cloudtrail-data only depends on core
            writer.OpenXmlBlock("dependencies", () =>
            {
                writer.OpenXmlBlock("group", () =>
                {
                    var coreVersion = context.Manifest.CoreVersion ?? throw new GeneratorException($"'{context.Manifest.SourcePath}' has no 'CoreVersion' field.");
                    writer.WriteLine($"""<dependency id="AWSSDK.Core" version="[{coreVersion}, 5.0)" />""");
                });
            });
        });
    }

    private void WriteFiles(CodeWriter writer)
    {
        writer.OpenXmlBlock("files", () =>
        {
            writer.WriteLine("""<file src="..\..\..\nuget-content\AWSLogo.png" target="images\" />""");

            // TODO: incorporate namespace (From metadata) overloads or customization overloads.
            var codeAnalysisServiceFolder = context.ServiceName.Replace("Amazon.", "");
            writer.WriteLine($"""<file src="..\..\..\code-analysis\ServiceAnalysis\{codeAnalysisServiceFolder}\bin\Release\*.dll" target="analyzers\dotnet\cs" exclude="**\Microsoft.CodeAnalysis.*;**\System.Collections.Immutable.*;**\System.Reflection.Metadata.*;**\System.Composition.*" />""");
            writer.WriteLine("""<file src="..\..\..\code-analysis\NuGetInstallScripts\*.ps1" target="tools\" />""");
            writer.WriteLine();

            WriteLibFiles(writer, TargetPlatforms.FrameworkPlatforms, first: true);

            // The netstandard-family targets are emitted only when the service supports netstandard
            // (currently false only for MobileAnalytics). Defaults to true when no metadata is present.
            if (context.Metadata?.NetStandardSupport ?? true)
            {
                WriteLibFiles(writer, TargetPlatforms.NetPlatforms, first: false);
            }
        });
    }

    // Emits the assembly, XML docs, and symbols for each target framework into its lib folder,
    // with a blank line between frameworks.
    private void WriteLibFiles(CodeWriter writer, IReadOnlyList<TargetPlatform> platforms, bool first)
    {
        foreach (var platform in platforms)
        {
            if (!first)
            {
                writer.WriteLine();
            }
            first = false;

            var tfm = platform.Tfm;
            writer.WriteLine($"""<file src=".\bin\Release\{tfm}\{context.AssemblyName}.dll" target="lib\{tfm}" />""");
            writer.WriteLine($"""<file src=".\bin\Release\{tfm}\{context.AssemblyName}.xml" target="lib\{tfm}" />""");
            writer.WriteLine($"""<file src=".\bin\Release\{tfm}\{context.AssemblyName}.pdb" target="lib\{tfm}" />""");
        }
    }
}
