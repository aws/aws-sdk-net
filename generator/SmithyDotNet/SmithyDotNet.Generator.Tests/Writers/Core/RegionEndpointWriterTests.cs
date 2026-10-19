using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Writers.Core;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Core;

public class RegionEndpointWriterTests
{
    private static readonly string Output = new RegionEndpointWriter(PartitionsManifest.Load("TestData/partitions.json")).Write();

    [Fact]
    public void EmitsAConstantPerRegion()
    {
        Assert.Contains("/// The Asia Pacific (Singapore) endpoint.", Output);
        Assert.Contains("""public static readonly RegionEndpoint APSoutheast1 = GetRegionEndpoint("ap-southeast-1", "Asia Pacific (Singapore)", "aws", "amazonaws.com", @"^(us|eu|ap)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");""", Output);
    }

    // The same cases C2J's TestEndpointNameConstruction pins.
    [Theory]
    [InlineData("us-east-1", "USEast1")]
    [InlineData("cn-northwest-1", "CNNorthWest1")]
    [InlineData("ap-southeast-1", "APSoutheast1")]
    [InlineData("us-gov-east-1", "USGovCloudEast1")]
    public void NamesTheConstantAsTheSdkAlwaysHas(string regionCode, string expectedName)
    {
        Assert.Contains($"""public static readonly RegionEndpoint {expectedName} = GetRegionEndpoint("{regionCode}", """, Output);
    }

    [Fact]
    public void SkipsGlobalPseudoRegions()
    {
        Assert.DoesNotContain("aws-global", Output);
    }

    [Fact]
    public void KeepsThePrivateUsEast1RegionalConstantBeforeUsEast1()
    {
        var regional = Output.IndexOf("""private static readonly RegionEndpoint USEast1Regional = GetRegionEndpoint("us-east-1-regional", "US East (Virginia) regional", "aws", """, StringComparison.Ordinal);
        var usEast1 = Output.IndexOf("public static readonly RegionEndpoint USEast1 =", StringComparison.Ordinal);

        Assert.True(0 <= regional && regional < usEast1);
    }

    // C2J's template output has no final newline, so neither does the committed file.
    [Fact]
    public void EndsWithoutAFinalNewline()
    {
        Assert.EndsWith("}", Output);
    }
}
