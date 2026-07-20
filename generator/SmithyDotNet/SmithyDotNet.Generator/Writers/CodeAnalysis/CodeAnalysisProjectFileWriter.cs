using SmithyDotNet.Generator.Generation;

namespace SmithyDotNet.Generator.Writers.CodeAnalysis;

/// <summary>
/// Emits the service's CodeAnalysis project file (<c>AWSSDK.{Service}.CodeAnalysis.csproj</c>).
/// Ported from the legacy generator's <c>CodeAnalysisProjectFile</c> template and
/// <c>CodeAnalysisProjectCreator.SetupProjectFile</c>.
/// </summary>
public sealed class CodeAnalysisProjectFileWriter(GenerationContext context)
{
    /// <summary>
    /// Writes the csproj. <paramref name="projectFilePath"/> is the path the file will be written to;
    /// when a project already exists there its <c>&lt;ProjectGuid&gt;</c> is preserved, otherwise a new
    /// one is generated — matching the legacy generator, which never churns an existing GUID.
    /// </summary>
    public string Write(string projectFilePath)
    {
        var projectGuid = Utils.GetProjectGuid(projectFilePath);
        var rootNamespace = $"{context.Namespace}.CodeAnalysis";
        var assemblyName = $"{context.AssemblyName}.CodeAnalysis";

        var writer = new CodeWriter();
        writer.OpenXmlBlock("Project Sdk=\"Microsoft.NET.Sdk\"", "Project", () =>
        {
            writer.OpenXmlBlock("PropertyGroup", () =>
            {
                writer.WriteLine("<TargetFramework>netstandard2.0</TargetFramework>");
                writer.WriteLine("<EnforceExtendedAnalyzerRules>true</EnforceExtendedAnalyzerRules>");
                writer.WriteLine("<AppendTargetFrameworkToOutputPath>false</AppendTargetFrameworkToOutputPath>");
                writer.WriteLine($"<ProjectGuid>{projectGuid}</ProjectGuid>");
                writer.WriteLine($"<RootNamespace>{rootNamespace}</RootNamespace>");
                writer.WriteLine($"<AssemblyName>{assemblyName}</AssemblyName>");
                writer.WriteLine();
                writer.WriteLine("<GenerateAssemblyTitleAttribute>false</GenerateAssemblyTitleAttribute>");
                writer.WriteLine("<GenerateAssemblyConfigurationAttribute>false</GenerateAssemblyConfigurationAttribute>");
                writer.WriteLine("<GenerateAssemblyDescriptionAttribute>false</GenerateAssemblyDescriptionAttribute>");
                writer.WriteLine("<GenerateAssemblyProductAttribute>false</GenerateAssemblyProductAttribute>");
                writer.WriteLine("<GenerateAssemblyCompanyAttribute>false</GenerateAssemblyCompanyAttribute>");
                writer.WriteLine("<GenerateAssemblyCopyrightAttribute>false</GenerateAssemblyCopyrightAttribute>");
                writer.WriteLine("<GenerateAssemblyVersionAttribute>false</GenerateAssemblyVersionAttribute>");
                writer.WriteLine("<GenerateAssemblyFileVersionAttribute>false</GenerateAssemblyFileVersionAttribute>");
            });
            writer.WriteLine();
            writer.OpenXmlBlock("ItemGroup", () =>
            {
                writer.WriteLine("""<PackageReference Include="Microsoft.CodeAnalysis.Analyzers" Version="2.9.8" />""");
                writer.WriteLine("""<PackageReference Include="Microsoft.CodeAnalysis.CSharp" Version="3.3.1" />""");
            });
            writer.WriteLine();
            // TODO: the legacy generator also embeds any *.xml under a service's /Custom folder. No
            // service is onboarded with custom analyzer resources yet, so only the always-present
            // PropertyValueRules.xml is emitted.
            writer.OpenXmlBlock("ItemGroup", () =>
            {
                writer.OpenXmlBlock("EmbeddedResource Include=\"Generated/PropertyValueRules.xml\"", "EmbeddedResource", () =>
                {
                    writer.WriteLine("<CopyToOutputDirectory>Always</CopyToOutputDirectory>");
                });
            });
            writer.WriteLine();
            writer.OpenXmlBlock("ItemGroup", () =>
            {
                writer.WriteLine($"""<ProjectReference Include="{Utils.PathCombineAlt("..", "..", "SharedAnalysisCode", "SharedAnalysisCode.csproj")}" />""");
            });
        });

        return writer.ToRawString();
    }
}
