using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Writers.Core;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Core;

public class DefaultConfigurationModeWriterTests
{
    private static readonly string Output = new DefaultConfigurationModeWriter(DefaultConfigurationManifest.Load("TestData/sdk-default-configuration.json")).Write();

    [Fact]
    public void EmitsAMemberPerModeInTheFilesOrder()
    {
        var members = new[] { "Standard,", "InRegion,", "CrossRegion,", "Mobile,", "Auto" }.Select(member => Output.IndexOf($"        {member}", StringComparison.Ordinal)).ToList();

        Assert.DoesNotContain(-1, members);
        Assert.Equal(members.Order(), members);
    }

    [Fact]
    public void EndsTheEnumWithoutATrailingComma()
    {
        Assert.DoesNotContain("Auto,", Output);
    }

    [Fact]
    public void DocumentsEachMode()
    {
        Assert.Contains("/// <p>The STANDARD mode provides the latest recommended default values", Output);
    }
}
