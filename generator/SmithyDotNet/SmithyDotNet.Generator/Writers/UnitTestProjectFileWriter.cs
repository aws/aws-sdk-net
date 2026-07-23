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
        // Reference the centralized MSBuild target-framework properties from sdk/Directory.Build.props
        // rather than restating TFMs. The MSTest test targets exclude netstandard2.0 (a test project is
        // an executable and can't run on it), so a netstandard-supporting service uses
        // SdkMSTestAllTestTargets; a net-framework-only service uses SdkNetFrameworkTargets.
        var targetFrameworksProperty = netStandardSupport ? "$(SdkMSTestAllTestTargets)" : "$(SdkNetFrameworkTargets)";

        writer.OpenXmlBlock("PropertyGroup", () =>
        {
            writer.WriteLine("""<RunAnalyzersDuringBuild Condition="'$(RunAnalyzersDuringBuild)'==''">true</RunAnalyzersDuringBuild>""");
            writer.WriteLine($"<TargetFrameworks>{targetFrameworksProperty}</TargetFrameworks>");
            if (netStandardSupport)
            {
                writer.WriteLine($"""<DefineConstants Condition="{IsNotNetFramework}">$(DefineConstants);AWS_ASYNC_ENUMERABLES_API</DefineConstants>""");
            }
            writer.WriteLine("<DebugType>portable</DebugType>");
            writer.WriteLine("<GenerateDocumentationFile>true</GenerateDocumentationFile>");
            writer.WriteLine($"<AssemblyName>AWSSDK.UnitTests.{context.ServiceName}</AssemblyName>");
            writer.WriteLine($"<PackageId>AWSSDK.UnitTests.{context.ServiceName}</PackageId>");
            writer.WriteLine();
            WriteGenerateAssemblyAttributeSuppressions(writer);
            writer.WriteLine("<SignAssembly>true</SignAssembly>");
            writer.WriteLine("<TreatWarningsAsErrors>true</TreatWarningsAsErrors>");
            writer.WriteLine();
            writer.WriteLine("<NoWarn>CS1591,CS0612,CS0618</NoWarn>");
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
