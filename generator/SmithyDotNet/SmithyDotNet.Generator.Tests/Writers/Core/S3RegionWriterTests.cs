using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Writers.Core;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Core;

public class S3RegionWriterTests
{
    private static readonly string Output = new S3RegionWriter(PartitionsManifest.Load("TestData/partitions.json")).Write();

    [Fact]
    public void EmitsAConstantPerRegionValuedByItsCode()
    {
        Assert.Contains("/// Specifies that the S3 Bucket should use the ap-southeast-1 locality.", Output);
        Assert.Contains("""public static readonly S3Region APSoutheast1 = new S3Region("ap-southeast-1");""", Output);
        Assert.Contains("""public static readonly S3Region CNNorthWest1 = new S3Region("cn-northwest-1");""", Output);
    }

    // S3's two oldest locations keep the values S3Region has always had.
    [Theory]
    [InlineData("USEast1", "")]
    [InlineData("EUWest1", "EU")]
    public void KeepsTheLegacyBucketRegionValues(string name, string value)
    {
        Assert.Contains($"""public static readonly S3Region {name} = new S3Region("{value}");""", Output);
    }

    // C2J lists the regions in partitions.json order, which the fixture keeps unsorted.
    [Fact]
    public void KeepsThePartitionsOrder()
    {
        var usEast1 = Output.IndexOf("S3Region USEast1 =", StringComparison.Ordinal);
        var apSoutheast1 = Output.IndexOf("S3Region APSoutheast1 =", StringComparison.Ordinal);
        var euWest1 = Output.IndexOf("S3Region EUWest1 =", StringComparison.Ordinal);

        Assert.True(0 <= usEast1 && usEast1 < apSoutheast1 && apSoutheast1 < euWest1);
    }

    [Fact]
    public void SkipsGlobalPseudoRegions()
    {
        Assert.DoesNotContain("aws-global", Output);
    }

    // C2J's template output has no final newline, so neither does the committed file.
    [Fact]
    public void EndsWithoutAFinalNewline()
    {
        Assert.EndsWith("}", Output);
    }
}
