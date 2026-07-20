using SmithyDotNet.Generator.Generation;
using static SmithyDotNet.Generator.Writers.ProjectFileSections;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the service's unit-test project file (<c>AWSSDK.UnitTests.{Service}.csproj</c>): a single
/// csproj that multi-targets every shipped TFM and compiles everything under
/// <c>sdk/test/Services/{Service}/UnitTests/</c> — the generated endpoint provider tests today,
/// hand-written tests as they are added. References Core, CrtIntegration, and the service's runtime
/// project per target framework family, plus the shared CommonTest and UnitTestUtilities projects.
/// Ported from the legacy generator's <c>UnitTestProjectFileCreator</c>; package versions, NoWarn,
/// and framework references match <c>_manifest.json</c>'s <c>unittestprojects</c> entry.
/// </summary>
public sealed class UnitTestProjectFileWriter(GenerationContext context)
{
    // Unit-test csprojs live at sdk/test/Services/{Service}/UnitTests/ — three levels below
    // sdk/test/ and four below sdk/.
    private const string TestRoot = "../../..";
    private const string SdkRoot = "../../../..";

    private static readonly IReadOnlyList<PackageRef> TestPackages =
    [
        new("Moq", "4.18.4"),
        new("MSTest.TestAdapter", "3.11.1"),
        new("Microsoft.NET.Test.Sdk", "17.13.0"),
        new("MSTest.TestFramework", "3.11.1"),
        new("AutoFixture", "4.18.1"),
        new("AutoFixture.AutoMoq", "4.18.1"),
    ];

    /// <summary>Writes <c>AWSSDK.UnitTests.{Service}.csproj</c>.</summary>
    public string Write()
    {
        var netStandardSupport = context.Metadata?.NetStandardSupport ?? true;

        var sections = new List<Action<CodeWriter>>
        {
            w => WriteMainPropertyGroup(w, netStandardSupport),
        };

        if (netStandardSupport)
        {
            sections.Add(WriteLangVersionOverride);
        }

        sections.Add(w => WriteSigningChoose(w, $"{SdkRoot}/awssdk.dll.snk"));
        sections.Add(WriteCompileExcludes);
        sections.Add(w => WritePlatformFolderExcludes(w, netStandardSupport));
        sections.Add(WriteSharedTestProjectReferences);
        sections.Add(w => WriteRuntimeProjectReferences(w, netStandardSupport));
        sections.Add(WritePackageReferences);
        sections.Add(w => WriteSystemConfigurationReference(w, netStandardSupport));

        var writer = new CodeWriter();
        writer.WriteXmlBlock("""<Project Sdk="Microsoft.NET.Sdk">""", "Project", () => WriteSections(writer, sections));
        return writer.ToRawString();
    }

    private void WriteMainPropertyGroup(CodeWriter writer, bool netStandardSupport)
    {
        var platforms = netStandardSupport ? TargetPlatforms.Platforms : TargetPlatforms.FrameworkPlatforms;
        var tfms = platforms.Select(platform => platform.Tfm).ToList();

        writer.OpenXmlBlock("PropertyGroup", () =>
        {
            writer.WriteLine("""<RunAnalyzersDuringBuild Condition="'$(RunAnalyzersDuringBuild)'==''">true</RunAnalyzersDuringBuild>""");
            writer.WriteLine(tfms.Count == 1
                ? $"<TargetFramework>{tfms[0]}</TargetFramework>"
                : $"<TargetFrameworks>{string.Join(";", tfms)}</TargetFrameworks>");
            if (netStandardSupport)
            {
                writer.WriteLine($"""<DefineConstants Condition="{IsNetStandard}">$(DefineConstants);NETSTANDARD20</DefineConstants>""");
                writer.WriteLine($"""<DefineConstants Condition="{IsNotNetFramework}">$(DefineConstants);AWS_ASYNC_ENUMERABLES_API</DefineConstants>""");
            }
            writer.WriteLine("<DebugType>portable</DebugType>");
            writer.WriteLine("<GenerateDocumentationFile>true</GenerateDocumentationFile>");
            writer.WriteLine($"<AssemblyName>AWSSDK.UnitTests.{context.ServiceName}</AssemblyName>");
            writer.WriteLine($"<PackageId>AWSSDK.UnitTests.{context.ServiceName}</PackageId>");
            writer.WriteLine("<LangVersion>9.0</LangVersion>");
            writer.WriteLine();
            WriteGenerateAssemblyAttributeSuppressions(writer);
            writer.WriteLine("<SignAssembly>true</SignAssembly>");
            writer.WriteLine("<TreatWarningsAsErrors>true</TreatWarningsAsErrors>");
            writer.WriteLine();
            if (platforms.Any(platform => platform.Tfm == "netcoreapp3.1"))
            {
                // netcoreapp3.1 is out of support; suppress the targeting warning so it doesn't
                // fail the warnings-as-errors build. Keyed off the shipped TFM set so the line
                // disappears once netcoreapp3.1 is retired.
                writer.WriteLine("<SuppressTfmSupportBuildWarnings>true</SuppressTfmSupportBuildWarnings>");
            }
            writer.WriteLine("<NoWarn>CS1591,CS0612,CS0618</NoWarn>");
            // net472 test hosts resolve dependencies through generated binding redirects.
            writer.WriteLine("<GenerateBindingRedirectsOutputType>true</GenerateBindingRedirectsOutputType>");
        });
    }

    // .NET 8 gets C# 11 for static interface members (the service interface factory method used by
    // AWSSDK.Extensions.NETCore.Setup); everything older stays on 9.0.
    private static void WriteLangVersionOverride(CodeWriter writer)
    {
        writer.WriteXmlBlock($"""<PropertyGroup Condition="{IsNet8OrGreater}">""", "PropertyGroup", () =>
        {
            writer.WriteLine("<LangVersion>11.0</LangVersion>");
        });
    }

    // Hand-written tests use the _bcl/_netstandard platform-folder convention of the existing
    // sdk/test/Services/*/UnitTests projects, so the per-family excludes stay (generated test
    // source is single-file and doesn't need them).
    private static void WritePlatformFolderExcludes(CodeWriter writer, bool netStandardSupport)
    {
        WriteFrameworkSplitItemGroups(writer, netStandardSupport,
            w => w.WriteLine("""<Compile Remove="**/_netstandard/**"/>"""),
            w => w.WriteLine("""<Compile Remove="**/_bcl/**"/>"""));
    }

    private static void WriteSharedTestProjectReferences(CodeWriter writer)
    {
        writer.OpenXmlBlock("ItemGroup", () =>
        {
            writer.WriteLine($"""<ProjectReference Include="{TestRoot}/Common/{ProjectFileNames.CommonTest}"/>""");
            writer.WriteLine($"""<ProjectReference Include="{TestRoot}/UnitTests/Custom/{ProjectFileNames.UnitTestUtility}"/>""");
        });
    }

    private void WriteRuntimeProjectReferences(CodeWriter writer, bool netStandardSupport)
    {
        WriteFrameworkSplitItemGroups(writer, netStandardSupport,
            w => WriteRuntimeReferences(w, "NetFramework"),
            w => WriteRuntimeReferences(w, "NetStandard"));
    }

    private void WriteRuntimeReferences(CodeWriter writer, string variant)
    {
        writer.WriteLine($"""<ProjectReference Include="{SdkRoot}/src/Core/AWSSDK.Core.{variant}.csproj"/>""");
        writer.WriteLine($"""<ProjectReference Include="{SdkRoot}/../extensions/src/AWSSDK.Extensions.CrtIntegration/AWSSDK.Extensions.CrtIntegration.{variant}.csproj"/>""");
        writer.WriteLine($"""<ProjectReference Include="{SdkRoot}/src/Services/{context.ServiceName}/{context.AssemblyName}.{variant}.csproj"/>""");
    }

    private static void WritePackageReferences(CodeWriter writer)
    {
        writer.OpenXmlBlock("ItemGroup", () =>
        {
            foreach (var package in TestPackages)
            {
                writer.WriteLine($"""<PackageReference Include="{package.Id}" Version="{package.Version}"/>""");
            }
        });
    }

    // Hand-written net472 tests read app configuration through System.Configuration.
    private static void WriteSystemConfigurationReference(CodeWriter writer, bool netStandardSupport)
    {
        WriteFrameworkSplitItemGroups(writer, netStandardSupport,
            w => w.WriteLine("""<Reference Include="System.Configuration"/>"""));
    }

    // Emits the .NETFramework item group (unconditional when net472 is the only target) and, when
    // NetStandard targets are present, the conditioned non-Framework group.
    private static void WriteFrameworkSplitItemGroups(CodeWriter writer, bool netStandardSupport, Action<CodeWriter> netFramework, Action<CodeWriter>? notNetFramework = null)
    {
        if (!netStandardSupport)
        {
            writer.OpenXmlBlock("ItemGroup", () => netFramework(writer));
            return;
        }

        writer.WriteXmlBlock($"""<ItemGroup Condition="{IsNetFramework}">""", "ItemGroup", () => netFramework(writer));
        if (notNetFramework is not null)
        {
            writer.WriteXmlBlock($"""<ItemGroup Condition="{IsNotNetFramework}">""", "ItemGroup", () => notNetFramework(writer));
        }
    }
}
