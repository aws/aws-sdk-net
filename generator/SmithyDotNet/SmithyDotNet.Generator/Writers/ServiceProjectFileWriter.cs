using SmithyDotNet.Generator.Generation;
using static SmithyDotNet.Generator.Writers.ProjectFileSections;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Emits the service's <c>.csproj</c> files:
/// <list type="bullet">
///   <item><c>AWSSDK.{Service}.NetFramework.csproj</c> — unconditional</item>
///   <item><c>AWSSDK.{Service}.NetStandard.csproj</c> — gated on <see cref="ServiceMetadata.NetStandardSupport"/></item>
///   <item><c>AWSSDK.{Service}.csproj</c> — unified multi-targeting project (available via <see cref="WriteUnified"/>, not emitted automatically)</item>
/// </list>
/// The generated source uses <c>#if NETFRAMEWORK</c> directives rather than <c>_bcl</c>/<c>_netstandard</c>
/// folders, so no folder excludes are emitted. Values that vary by service or variant (TFM properties,
/// paths, defines, package references) come from <see cref="ServiceProjectConfiguration"/>; properties
/// common to every service (signing, warnings-as-errors, debug type, package metadata) are inline.
/// </summary>
public sealed class ServiceProjectFileWriter(GenerationContext context)
{
    /// <summary>Writes <c>AWSSDK.{Service}.NetFramework.csproj</c>.</summary>
    public string WriteNetFramework()
    {
        return WriteProject(ServiceProjectConfigurations.NetFramework);
    }

    /// <summary>Writes <c>AWSSDK.{Service}.NetStandard.csproj</c>.</summary>
    public string WriteNetStandard()
    {
        return WriteProject(ServiceProjectConfigurations.NetStandard);
    }

    /// <summary>
    /// Writes the unified <c>AWSSDK.{Service}.csproj</c> that multi-targets all TFMs. It is the
    /// intended future replacement for the two-csproj + nuspec trio, but ServiceGenerator does not
    /// emit it yet: nothing consumes it, and the build system still assumes the
    /// NetFramework/NetStandard pair.
    /// </summary>
    public string WriteUnified()
    {
        var fw = ServiceProjectConfigurations.NetFramework;
        var ns = ServiceProjectConfigurations.NetStandard;
        var netStandardSupport = context.Metadata?.NetStandardSupport ?? true;

        var sections = new List<Action<CodeWriter>>
        {
            w => WriteUnifiedMainPropertyGroup(w, netStandardSupport),
        };

        if (netStandardSupport)
        {
            sections.Add(WriteIsTrimmablePropertyGroup);
        }

        sections.Add(w => WriteRuleSetProperties(w, ns));
        sections.Add(w => WriteSigningChoose(w, ns.KeyFilePath));
        sections.Add(w => WriteAnalyzerItems(w, ns));
        sections.Add(WriteCompileExcludes);
        sections.Add(WriteReadmePackaging);
        sections.Add(w => WriteConditionalCoreReferences(w, fw, ns, netStandardSupport));
        sections.Add(w => WriteAnalyzerPackageReferences(w, ns));

        // net472 needs the same framework references the NetFramework variant carries.
        if (fw.FrameworkReferences.Count > 0)
        {
            sections.Add(w => WriteConditionalFrameworkReferences(w, fw));
        }

        var writer = new CodeWriter();
        writer.WriteXmlBlock("""<Project Sdk="Microsoft.NET.Sdk">""", "Project", () => WriteSections(writer, sections));
        return writer.ToRawString();
    }

    private void WriteUnifiedMainPropertyGroup(CodeWriter writer, bool netStandardSupport)
    {
        var fw = ServiceProjectConfigurations.NetFramework;
        var ns = ServiceProjectConfigurations.NetStandard;

        var targetFrameworks = netStandardSupport
            ? $"{fw.TargetFrameworksProperty};{ns.TargetFrameworksProperty}"
            : fw.TargetFrameworksProperty;

        writer.OpenXmlBlock("PropertyGroup", () =>
        {
            writer.WriteLine("""<RunAnalyzersDuringBuild Condition="'$(RunAnalyzersDuringBuild)'==''">true</RunAnalyzersDuringBuild>""");
            writer.WriteLine($"<TargetFrameworks>{targetFrameworks}</TargetFrameworks>");
            if (netStandardSupport)
            {
                writer.WriteLine($"""<DefineConstants Condition="{IsNotNetFramework}">$(DefineConstants);AWS_ASYNC_ENUMERABLES_API</DefineConstants>""");
            }
            writer.WriteLine("<DebugType>portable</DebugType>");
            writer.WriteLine("<GenerateDocumentationFile>true</GenerateDocumentationFile>");
            writer.WriteLine($"<AssemblyName>{context.AssemblyName}</AssemblyName>");
            writer.WriteLine("<SignAssembly>true</SignAssembly>");
            writer.WriteLine("<TreatWarningsAsErrors>true</TreatWarningsAsErrors>");
            writer.WriteLine($"<NoWarn>{ns.NoWarn}</NoWarn>");
            writer.WriteLine();
            WriteGenerateAssemblyAttributeSuppressions(writer);
            writer.WriteLine();
            WritePackagingProperties(writer);
        });
    }

    // Package metadata that lives in the .nuspec today. On the unified project it moves onto the
    // csproj so `dotnet pack` produces a complete package without a separate nuspec.
    private void WritePackagingProperties(CodeWriter writer)
    {
        writer.WriteLine($"<PackageId>{context.AssemblyName}</PackageId>");
        writer.WriteLine($"<Version>{context.Manifest.GetServiceVersion(context.ServiceName)}</Version>");
        writer.WriteLine($"<Title>AWSSDK - {context.ServiceName}</Title>");
        writer.WriteLine("<Authors>Amazon Web Services</Authors>");
        if (context.Metadata?.Synopsis is { Length: > 0 } synopsis)
        {
            writer.WriteLine($"<Description>{System.Security.SecurityElement.Escape(synopsis)}</Description>");
        }

        var extraTags = context.Metadata is { Tags.Count: > 0 } metadata ? " " + string.Join(" ", metadata.Tags) : string.Empty;
        writer.WriteLine($"<PackageTags>AWS;Amazon;cloud;{context.ServiceName};aws-sdk-v4{System.Security.SecurityElement.Escape(extraTags.Replace(' ', ';'))}</PackageTags>");
        writer.WriteLine("<PackageProjectUrl>https://github.com/aws/aws-sdk-net/</PackageProjectUrl>");
        writer.WriteLine("<PackageLicenseExpression>Apache-2.0</PackageLicenseExpression>");
        writer.WriteLine("<PackageReadmeFile>nuget-readme.md</PackageReadmeFile>");
    }

    private static void WriteReadmePackaging(CodeWriter writer)
    {
        writer.OpenXmlBlock("ItemGroup", () =>
        {
            writer.WriteLine("""<None Include="nuget-readme.md" Pack="true" PackagePath="\" />""");
        });
    }

    private static void WriteConditionalFrameworkReferences(CodeWriter writer, ServiceProjectConfiguration frameworkConfig)
    {
        writer.WriteXmlBlock($"""<ItemGroup Condition="{IsNetFramework}">""", "ItemGroup", () =>
        {
            foreach (var reference in frameworkConfig.FrameworkReferences)
            {
                writer.WriteLine($"""<Reference Include="{reference}"/>""");
            }
        });
    }

    private string WriteProject(ServiceProjectConfiguration config)
    {
        var sections = new List<Action<CodeWriter>>
        {
            w => WriteMainPropertyGroup(w, config),
        };

        if (config.HasTrimmableTarget)
        {
            sections.Add(WriteIsTrimmablePropertyGroup);
        }

        sections.Add(w => WriteRuleSetProperties(w, config));
        sections.Add(w => WriteSigningChoose(w, config.KeyFilePath));
        sections.Add(w => WriteAnalyzerItems(w, config));
        sections.Add(WriteCompileExcludes);
        sections.Add(w => WriteCoreReference(w, config));

        if (config.PackageReferences.Count > 0)
        {
            sections.Add(w => WriteAnalyzerPackageReferences(w, config));
        }

        if (config.FrameworkReferences.Count > 0)
        {
            sections.Add(w => WriteFrameworkReferences(w, config));
        }

        var writer = new CodeWriter();
        writer.WriteXmlBlock("""<Project Sdk="Microsoft.NET.Sdk">""", "Project", () => WriteSections(writer, sections));
        return writer.ToRawString();
    }

    private void WriteMainPropertyGroup(CodeWriter writer, ServiceProjectConfiguration config)
    {
        writer.OpenXmlBlock("PropertyGroup", () =>
        {
            writer.WriteLine("""<RunAnalyzersDuringBuild Condition="'$(RunAnalyzersDuringBuild)'==''">true</RunAnalyzersDuringBuild>""");
            writer.WriteLine($"<TargetFrameworks>{config.TargetFrameworksProperty}</TargetFrameworks>");
            writer.WriteLine($"<DefineConstants>$(DefineConstants);{string.Join(";", config.DefineConstants)}</DefineConstants>");
            writer.WriteLine("<DebugType>portable</DebugType>");
            writer.WriteLine("<GenerateDocumentationFile>true</GenerateDocumentationFile>");
            writer.WriteLine($"<AssemblyName>{context.AssemblyName}</AssemblyName>");
            writer.WriteLine($"<PackageId>{context.AssemblyName}</PackageId>");
            writer.WriteLine();
            WriteGenerateAssemblyAttributeSuppressions(writer);
            writer.WriteLine("<SignAssembly>true</SignAssembly>");
            writer.WriteLine("<TreatWarningsAsErrors>true</TreatWarningsAsErrors>");
            writer.WriteLine();
            writer.WriteLine($"<NoWarn>{config.NoWarn}</NoWarn>");
        });
    }

    private static void WriteCoreReference(CodeWriter writer, ServiceProjectConfiguration config)
    {
        writer.OpenXmlBlock("ItemGroup", () =>
        {
            writer.WriteLine($"""<ProjectReference Include="{config.CoreProjectReference}"/>""");
        });
    }

    private static void WriteFrameworkReferences(CodeWriter writer, ServiceProjectConfiguration config)
    {
        writer.OpenXmlBlock("ItemGroup", () =>
        {
            foreach (var reference in config.FrameworkReferences)
            {
                writer.WriteLine($"""<Reference Include="{reference}"/>""");
            }
        });
    }

    private static void WriteIsTrimmablePropertyGroup(CodeWriter writer)
    {
        writer.WriteXmlBlock($"""<PropertyGroup Condition="{IsNet8OrGreater}">""", "PropertyGroup", () =>
        {
            writer.WriteLine("<IsTrimmable>true</IsTrimmable>");
        });
    }

    private static void WriteConditionalCoreReferences(CodeWriter writer, ServiceProjectConfiguration fw, ServiceProjectConfiguration ns, bool netStandardSupport)
    {
        writer.WriteXmlBlock($"""<ItemGroup Condition="{IsNetFramework}">""", "ItemGroup", () =>
        {
            writer.WriteLine($"""<ProjectReference Include="{fw.CoreProjectReference}"/>""");
        });

        if (netStandardSupport)
        {
            writer.WriteXmlBlock($"""<ItemGroup Condition="{IsNotNetFramework}">""", "ItemGroup", () =>
            {
                writer.WriteLine($"""<ProjectReference Include="{ns.CoreProjectReference}"/>""");
            });
        }
    }

    private static void WriteRuleSetProperties(CodeWriter writer, ServiceProjectConfiguration config)
    {
        writer.WriteXmlBlock(
            """<PropertyGroup Condition=" '$(RuleSetFileForBuild)' == 'false' Or '$(RuleSetFileForBuild)' == '' ">""",
            "PropertyGroup", () =>
        {
            writer.WriteLine($"<CodeAnalysisRuleSet>{config.RuleSetFilePath}</CodeAnalysisRuleSet>");
        });
        writer.WriteXmlBlock(
            """<PropertyGroup Condition=" '$(RuleSetFileForBuild)' == 'true' ">""",
            "PropertyGroup", () =>
        {
            writer.WriteLine($"<CodeAnalysisRuleSet>{config.RuleSetFilePathForBuild}</CodeAnalysisRuleSet>");
        });
    }

    private static void WriteAnalyzerItems(CodeWriter writer, ServiceProjectConfiguration config)
    {
        writer.WriteXmlBlock("""<ItemGroup Condition="$(RunAnalyzersDuringBuild)">""", "ItemGroup", () =>
        {
            writer.WriteLine($"""<Analyzer Include= "{config.AnalyzersPath}" />""");
        });
    }

    private static void WriteAnalyzerPackageReferences(CodeWriter writer, ServiceProjectConfiguration config)
    {
        writer.WriteXmlBlock("""<ItemGroup Condition="$(RunAnalyzersDuringBuild)">""", "ItemGroup", () =>
        {
            foreach (var pkg in config.PackageReferences)
            {
                writer.WriteXmlBlock($"""<PackageReference Include="{pkg.Id}" Version="{pkg.Version}">""", "PackageReference", () =>
                {
                    writer.WriteLine("<PrivateAssets>all</PrivateAssets>");
                });
            }
        });
    }
}
