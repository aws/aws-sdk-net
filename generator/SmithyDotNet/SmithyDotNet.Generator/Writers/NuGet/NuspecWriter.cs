using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Generation.ProjectFiles;

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
            writer.WriteLine($"<id>{context.AssemblyName}</id>");
            writer.WriteLine($"<title>AWSSDK - {context.ServiceName}</title>");
            writer.WriteLine($"<version>{context.Manifest.GetPackageVersion(context.ServiceName)}</version>");
            writer.WriteLine("<authors>Amazon Web Services</authors>");
            writer.WriteLine($"<description>{System.Security.SecurityElement.Escape(context.Metadata?.Synopsis)}</description>");
            writer.WriteLine("<language>en-US</language>");
            writer.WriteLine("<readme>nuget-readme.md</readme>");
            writer.WriteLine("""<license type="expression">Apache-2.0</license>""");
            writer.WriteLine("<projectUrl>https://github.com/aws/aws-sdk-net/</projectUrl>");
            string tags = context.Metadata is { Tags.Count: > 0 } metadata ? " " + string.Join(" ", metadata.Tags) : string.Empty;
            writer.WriteLine($"<tags>AWS Amazon cloud {context.BaseName} aws-sdk-v4{System.Security.SecurityElement.Escape(tags)}</tags>");
            writer.WriteLine("""<icon>images\AWSLogo.png</icon>""");

            if (!string.IsNullOrEmpty(context.Metadata?.LicenseUrl))
            {
                writer.WriteLine("<requireLicenseAcceptance>true</requireLicenseAcceptance>");
            }

            writer.OpenXmlBlock("dependencies", () =>
            {
                var packagesByTarget = NugetPackagesByTarget();
                if (packagesByTarget.Count == 0)
                {
                    writer.OpenXmlBlock("group", () => WriteAwsDependencies(writer));
                    return;
                }

                // NuGet uses only the group matching the consumer's framework; the untargeted group is a fallback,
                // never merged in. So once one package is framework-specific, every shipped framework gets a group
                // with the AWS dependencies too. C2J leaves them in the untargeted group, so its Signin package
                // doesn't bring in AWSSDK.Core.
                var tfms = TargetPlatforms.FrameworkPlatforms
                    .Concat(context.Metadata?.NetStandardSupport ?? true ? TargetPlatforms.NetPlatforms : [])
                    .Select(platform => platform.Tfm)
                    .ToList();
                if (packagesByTarget.Select(group => group.Key).FirstOrDefault(target => !tfms.Contains(target)) is { } unshipped)
                {
                    throw new GeneratorException($"A nuget-dependency targets '{unshipped}', which {context.ServiceName} doesn't build for.");
                }

                foreach (var tfm in tfms)
                {
                    writer.WriteXmlBlock($"""<group targetFramework="{tfm}">""", "group", () =>
                    {
                        WriteAwsDependencies(writer);
                        foreach (var package in packagesByTarget[tfm])
                        {
                            writer.WriteLine($"""<dependency id="{package.Name}" version="{package.Version}" />""");
                        }
                    });
                }
            });
        });
    }

    private ILookup<string, NugetDependency> NugetPackagesByTarget()
    {
        var dependencies = context.Metadata?.NugetDependencies;
        return ByTarget(dependencies?.NetStandard, TargetPlatforms.NetPlatforms)
            .Concat(ByTarget(dependencies?.NetFramework, TargetPlatforms.FrameworkPlatforms))
            .ToLookup(pair => pair.target, pair => pair.dependency);

        // A package that lists no targets applies to its whole family, as its csproj ItemGroup has no condition.
        static IEnumerable<(string target, NugetDependency dependency)> ByTarget(IReadOnlyList<NugetDependency>? family, IReadOnlyList<TargetPlatform> familyPlatforms) =>
            (family ?? []).SelectMany(dependency => (dependency.Targets.Count > 0 ? dependency.Targets : familyPlatforms.Select(platform => platform.Tfm))
                .Select(target => (target, dependency)));
    }

    private void WriteAwsDependencies(CodeWriter writer)
    {
        foreach (var dependency in context.Metadata?.Dependencies ?? [])
        {
            writer.WriteLine($"""<dependency id="AWSSDK.{dependency}" version="{context.Manifest.GetServiceDependencyRange(context.ServiceName, dependency)}" />""");
        }

        foreach (var extension in context.ExtensionDependencies)
        {
            writer.WriteLine($"""<dependency id="{extension.PackageId}" version="{context.Manifest.GetExtensionRange(extension.Name)}" />""");
        }

        writer.WriteLine($"""<dependency id="AWSSDK.Core" version="{context.Manifest.GetCoreRange()}" />""");
    }

    private void WriteFiles(CodeWriter writer)
    {
        writer.OpenXmlBlock("files", () =>
        {
            writer.WriteLine("""<file src="nuget-readme.md" target="" />""");
            writer.WriteLine("""<file src="..\..\..\nuget-content\AWSLogo.png" target="images\" />""");

            writer.WriteLine($"""<file src="..\..\..\code-analysis\ServiceAnalysis\{context.ServiceName}\bin\Release\*.dll" target="analyzers\dotnet\cs" exclude="**\Microsoft.CodeAnalysis.*;**\System.Collections.Immutable.*;**\System.Reflection.Metadata.*;**\System.Composition.*" />""");
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
