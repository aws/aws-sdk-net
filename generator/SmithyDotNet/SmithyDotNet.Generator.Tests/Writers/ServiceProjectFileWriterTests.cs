using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class ServiceProjectFileWriterTests
{
    private readonly CloudTrailModelFixture _fixture;
    private readonly string _netFramework;
    private readonly string _netStandard;
    private readonly string _unified;

    public ServiceProjectFileWriterTests(CloudTrailModelFixture fixture)
    {
        _fixture = fixture;
        var writer = new ServiceProjectFileWriter(fixture.Context);
        _netFramework = writer.WriteNetFramework();
        _netStandard = writer.WriteNetStandard();
        _unified = writer.WriteUnified();
    }

    // The NetFramework and NetStandard variants differ only by their configuration: TFM property,
    // Core reference, defines, and framework references.
    [Fact]
    public void VariantsUseTheirConfiguration()
    {
        Assert.Contains("<TargetFrameworks>$(SdkNetFrameworkTargets)</TargetFrameworks>", _netFramework);
        Assert.Contains("../../Core/AWSSDK.Core.NetFramework.csproj", _netFramework);
        Assert.Contains("System.Configuration", _netFramework);

        Assert.Contains("<TargetFrameworks>$(SdkNetTargets)</TargetFrameworks>", _netStandard);
        Assert.Contains("../../Core/AWSSDK.Core.NetStandard.csproj", _netStandard);
        Assert.DoesNotContain("System.Configuration", _netStandard);
    }

    // The generated source is single-file (#if NETFRAMEWORK), so no platform folder excludes.
    [Fact]
    public void DoesNotExcludePlatformFolders()
    {
        Assert.DoesNotContain("_netstandard", _netFramework);
        Assert.DoesNotContain("_bcl", _netStandard);
    }

    // Per-TFM conditions use framework-identifier comparisons, never literal TFM names.
    [Theory]
    [InlineData("net472")]
    [InlineData("net8.0")]
    [InlineData("netstandard2.0")]
    public void DoesNotHardcodeTfmNames(string tfm)
    {
        Assert.DoesNotContain($"'$(TargetFramework)' == '{tfm}'", _netFramework);
        Assert.DoesNotContain($"'$(TargetFramework)' == '{tfm}'", _netStandard);
        Assert.DoesNotContain($"'$(TargetFramework)' == '{tfm}'", _unified);
    }

    [Theory]
    [InlineData("NetFramework")]
    [InlineData("NetStandard")]
    [InlineData("Unified")]
    public void NoBlankLineBeforeClosingProjectTag(string variant)
    {
        var content = variant switch
        {
            "NetFramework" => _netFramework,
            "NetStandard" => _netStandard,
            _ => _unified,
        };

        Assert.DoesNotContain("\r\n\r\n</Project>", content);
    }

    // The unified project must be buildable (signs, so needs a key; warnings-as-errors, so needs
    // NoWarn; runs analyzers, so needs the ruleset and analyzer references) and packable (carries the
    // package metadata that otherwise lives in the nuspec, and references the README).
    [Fact]
    public void UnifiedIsBuildableAndPackable()
    {
        Assert.Contains("<AssemblyOriginatorKeyFile>", _unified);
        Assert.Contains("<NoWarn>CA1822</NoWarn>", _unified);
        Assert.Contains("AWSDotNetSDK.ruleset", _unified);
        Assert.Contains("Microsoft.CodeAnalysis.FxCopAnalyzers", _unified);

        Assert.Contains("<PackageId>AWSSDK.CloudTrailData</PackageId>", _unified);
        Assert.Contains("<Version>", _unified);
        Assert.Contains("<PackageLicenseExpression>Apache-2.0</PackageLicenseExpression>", _unified);
        Assert.Contains("<PackageReadmeFile>nuget-readme.md</PackageReadmeFile>", _unified);
    }

    // Both target families are present, each with the Core reference scoped by framework identifier.
    [Fact]
    public void UnifiedMultiTargetsWithConditionalCoreReferences()
    {
        Assert.Contains("<TargetFrameworks>$(SdkNetFrameworkTargets);$(SdkNetTargets)</TargetFrameworks>", _unified);
        Assert.Contains("AWSSDK.Core.NetFramework.csproj", _unified);
        Assert.Contains("AWSSDK.Core.NetStandard.csproj", _unified);
    }

    // A service that opts out of NetStandard drops the non-Framework target, define, and Core reference.
    [Fact]
    public void UnifiedIsFrameworkOnlyWhenNetStandardUnsupported()
    {
        var metadata = new ServiceMetadata { NetStandardSupport = false };
        var context = new GenerationContext(_fixture.Index, _fixture.Context.Manifest, metadata);
        var unified = new ServiceProjectFileWriter(context).WriteUnified();

        Assert.Contains("<TargetFrameworks>$(SdkNetFrameworkTargets)</TargetFrameworks>", unified);
        Assert.DoesNotContain("$(SdkNetTargets)", unified);
        Assert.DoesNotContain("AWSSDK.Core.NetStandard.csproj", unified);
        Assert.DoesNotContain("AWS_ASYNC_ENUMERABLES_API", unified);
        Assert.DoesNotContain("<IsTrimmable>", unified);
    }
}
