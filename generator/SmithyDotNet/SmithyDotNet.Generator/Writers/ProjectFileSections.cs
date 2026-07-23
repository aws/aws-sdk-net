namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// MSBuild condition expressions and sections shared by the project file writers
/// (<see cref="ServiceProjectFileWriter"/> and <see cref="UnitTestProjectFileWriter"/>).
/// </summary>
internal static class ProjectFileSections
{
    // Framework-identifier comparisons rather than hardcoded TFM names, so conditions adapt to any
    // current or future target automatically.
    internal const string IsNetFramework = "$([MSBuild]::GetTargetFrameworkIdentifier('$(TargetFramework)')) == '.NETFramework'";
    internal const string IsNotNetFramework = "$([MSBuild]::GetTargetFrameworkIdentifier('$(TargetFramework)')) != '.NETFramework'";
    internal const string IsNet8OrGreater = "$([MSBuild]::GetTargetFrameworkIdentifier('$(TargetFramework)')) == '.NETCoreApp' And $([MSBuild]::VersionGreaterThanOrEquals($([MSBuild]::GetTargetFrameworkVersion('$(TargetFramework)')), '8.0'))";

    // Runs each section, separating them with a single blank line and leaving none trailing.
    internal static void WriteSections(CodeWriter writer, IReadOnlyList<Action<CodeWriter>> sections)
    {
        for (var i = 0; i < sections.Count; i++)
        {
            if (i > 0)
            {
                writer.WriteLine();
            }

            sections[i](writer);
        }
    }

    /// <summary>Signs with the repo key at <paramref name="keyFilePath"/> unless <c>$(AWSKeyFile)</c> overrides it.</summary>
    internal static void WriteSigningChoose(CodeWriter writer, string keyFilePath)
    {
        writer.OpenXmlBlock("Choose", () =>
        {
            writer.WriteXmlBlock("""<When Condition=" '$(AWSKeyFile)' == '' ">""", "When", () =>
            {
                writer.OpenXmlBlock("PropertyGroup", () =>
                {
                    writer.WriteLine($"<AssemblyOriginatorKeyFile>{keyFilePath}</AssemblyOriginatorKeyFile>");
                });
            });
            writer.OpenXmlBlock("Otherwise", () =>
            {
                writer.OpenXmlBlock("PropertyGroup", () =>
                {
                    writer.WriteLine("<AssemblyOriginatorKeyFile>$(AWSKeyFile)</AssemblyOriginatorKeyFile>");
                });
            });
        });
    }

    internal static void WriteCompileExcludes(CodeWriter writer)
    {
        writer.OpenXmlBlock("ItemGroup", () =>
        {
            writer.WriteLine("""<Compile Remove="**/obj/**"/>""");
            writer.WriteLine("""<None Remove="**/obj/**" />""");
        });
    }

    internal static void WriteGenerateAssemblyAttributeSuppressions(CodeWriter writer)
    {
        writer.WriteLine("<GenerateAssemblyTitleAttribute>false</GenerateAssemblyTitleAttribute>");
        writer.WriteLine("<GenerateAssemblyConfigurationAttribute>false</GenerateAssemblyConfigurationAttribute>");
        writer.WriteLine("<GenerateAssemblyProductAttribute>false</GenerateAssemblyProductAttribute>");
        writer.WriteLine("<GenerateAssemblyCompanyAttribute>false</GenerateAssemblyCompanyAttribute>");
        writer.WriteLine("<GenerateAssemblyCopyrightAttribute>false</GenerateAssemblyCopyrightAttribute>");
        writer.WriteLine("<GenerateAssemblyVersionAttribute>false</GenerateAssemblyVersionAttribute>");
        writer.WriteLine("<GenerateAssemblyFileVersionAttribute>false</GenerateAssemblyFileVersionAttribute>");
        writer.WriteLine("<GenerateAssemblyDescriptionAttribute>false</GenerateAssemblyDescriptionAttribute>");
    }
}
