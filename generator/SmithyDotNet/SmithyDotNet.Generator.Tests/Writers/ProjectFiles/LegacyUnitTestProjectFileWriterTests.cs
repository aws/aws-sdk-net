using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Generation.ProjectFiles;
using SmithyDotNet.Generator.Writers.ProjectFiles;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.ProjectFiles;

public class LegacyUnitTestProjectFileWriterTests
{
    private static readonly LegacyUnitTestProjectFileWriter Writer = new(UnitTestProjectManifest.Load("TestData/_manifest.json"));

    [Theory]
    [InlineData("NetFramework", "$(SdkNetFrameworkTargets)", "_netstandard")]
    [InlineData("NetStandard", "$(SdkMSTestNetTestTargets)", "_bcl")]
    public void TargetsAndReferencesItsVariant(string variant, string targetFrameworks, string excludedFolder)
    {
        var output = Writer.Write(variant == "NetFramework" ? ServiceProjectConfigurations.NetFramework : ServiceProjectConfigurations.NetStandard);

        Assert.Contains($"<TargetFrameworks>{targetFrameworks}</TargetFrameworks>", output);
        Assert.Contains($"""<Compile Remove="**/{excludedFolder}/**"/>""", output);
        Assert.Contains($"""<ProjectReference Include="../../src/Services/*/*.{variant}.csproj"/>""", output);
    }

    // MobileAnalytics ships only for .NET Framework.
    [Fact]
    public void ExcludesMobileAnalyticsTestsFromNetStandardOnly()
    {
        const string mobileAnalytics = """<Compile Remove="../Services/MobileAnalytics/UnitTests/**/*.cs"/>""";

        Assert.Contains(mobileAnalytics, Writer.Write(ServiceProjectConfigurations.NetStandard));
        Assert.DoesNotContain(mobileAnalytics, Writer.Write(ServiceProjectConfigurations.NetFramework));
    }

    // The fixture manifest's Moq version and NoWarn code are made up, so they show the manifest is read.
    [Fact]
    public void TakesItsSettingsFromTheManifest()
    {
        var output = Writer.Write(ServiceProjectConfigurations.NetFramework);

        Assert.Contains("""<PackageReference Include="Moq" Version="9.9.9"/>""", output);
        Assert.Contains("""<ItemGroup Condition="'$(TargetFramework)' == 'net472'">""", output);
        // The fixture lists System.Net.Http's targets unsorted; C2J sorts them.
        Assert.Contains("""<ItemGroup Condition="'$(TargetFramework)' == 'net472' Or '$(TargetFramework)' == 'net8.0'">""", output);
        Assert.Contains("""<EmbeddedResource Include="Custom\TestTools\ComparerTest.json"/>""", output);
        Assert.Contains("<NoWarn>CS1591,CS0612,CS0618,CS9999</NoWarn>", output);
    }
}
