using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class UnitTestProjectFileWriterTests
{
    private readonly CloudTrailModelFixture _fixture;
    private readonly string _project;

    public UnitTestProjectFileWriterTests(CloudTrailModelFixture fixture)
    {
        _fixture = fixture;
        _project = new UnitTestProjectFileWriter(fixture.Context).Write();
    }

    [Fact]
    public void MultiTargetsEveryShippedTfm()
    {
        Assert.Contains("<TargetFrameworks>net472;netstandard2.0;netcoreapp3.1;net8.0</TargetFrameworks>", _project);
    }

    // The reference set from the legacy unit-test project: Core, CrtIntegration, and the service's
    // runtime project per target framework family.
    [Fact]
    public void ReferencesRuntimeProjectsPerFrameworkFamily()
    {
        Assert.Contains("../../../../src/Core/AWSSDK.Core.NetFramework.csproj", _project);
        Assert.Contains("../../../../src/Core/AWSSDK.Core.NetStandard.csproj", _project);
        Assert.Contains("../../../../../extensions/src/AWSSDK.Extensions.CrtIntegration/AWSSDK.Extensions.CrtIntegration.NetFramework.csproj", _project);
        Assert.Contains("../../../../../extensions/src/AWSSDK.Extensions.CrtIntegration/AWSSDK.Extensions.CrtIntegration.NetStandard.csproj", _project);
        Assert.Contains("../../../../src/Services/CloudTrailData/AWSSDK.CloudTrailData.NetFramework.csproj", _project);
        Assert.Contains("../../../../src/Services/CloudTrailData/AWSSDK.CloudTrailData.NetStandard.csproj", _project);
    }

    [Fact]
    public void ReferencesSharedTestProjects()
    {
        Assert.Contains("../../../Common/AWSSDK.CommonTest.csproj", _project);
        Assert.Contains("../../../UnitTests/Custom/AWSSDK.UnitTestUtilities.csproj", _project);
    }

    // The generated endpoint tests are MSTest, so the test framework packages are load-bearing.
    [Fact]
    public void ReferencesTestPackages()
    {
        Assert.Contains("""<PackageReference Include="MSTest.TestAdapter" Version="3.11.1"/>""", _project);
        Assert.Contains("""<PackageReference Include="MSTest.TestFramework" Version="3.11.1"/>""", _project);
        Assert.Contains("""<PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.13.0"/>""", _project);
        Assert.Contains("""<PackageReference Include="Moq" Version="4.18.4"/>""", _project);
        Assert.Contains("""<PackageReference Include="AutoFixture" Version="4.18.1"/>""", _project);
        Assert.Contains("""<PackageReference Include="AutoFixture.AutoMoq" Version="4.18.1"/>""", _project);
    }

    // Per-TFM conditions use framework-identifier comparisons, never literal TFM names.
    [Theory]
    [InlineData("net472")]
    [InlineData("netstandard2.0")]
    [InlineData("netcoreapp3.1")]
    [InlineData("net8.0")]
    public void DoesNotHardcodeTfmNamesInConditions(string tfm)
    {
        Assert.DoesNotContain($"'$(TargetFramework)' == '{tfm}'", _project);
        Assert.DoesNotContain($"'$(TargetFramework)' != '{tfm}'", _project);
    }

    // A service that opts out of NetStandard gets a net472-only test project.
    [Fact]
    public void TargetsFrameworkOnlyWhenNetStandardUnsupported()
    {
        var metadata = new ServiceMetadata { NetStandardSupport = false };
        var context = new GenerationContext(_fixture.Index, _fixture.Context.Manifest, metadata);
        var project = new UnitTestProjectFileWriter(context).Write();

        Assert.Contains("<TargetFramework>net472</TargetFramework>", project);
        Assert.DoesNotContain("AWSSDK.Core.NetStandard.csproj", project);
        Assert.DoesNotContain("AWSSDK.CloudTrailData.NetStandard.csproj", project);
        Assert.DoesNotContain("AWS_ASYNC_ENUMERABLES_API", project);
        Assert.DoesNotContain("NETSTANDARD20", project);
    }

    [Fact]
    public void NoBlankLineBeforeClosingProjectTag()
    {
        Assert.DoesNotContain("\n\n</Project>", _project.Replace("\r\n", "\n"));
    }
}
