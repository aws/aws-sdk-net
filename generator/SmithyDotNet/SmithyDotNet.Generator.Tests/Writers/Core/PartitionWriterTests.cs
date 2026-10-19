using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Writers.Core;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Core;

public class PartitionWriterTests
{
    private static readonly string Output = new PartitionWriter(PartitionsManifest.Load("TestData/partitions.json")).Write();

    // implicitGlobalRegion is last, so it takes no trailing comma.
    [Theory]
    [InlineData("aws_cn", "aws-cn", "amazonaws.com.cn", "api.amazonwebservices.com.cn", "true", "false", "cn-northwest-1", """^cn\-\w+\-\d+$""")]
    [InlineData("aws_us_gov", "aws-us-gov", "amazonaws.com", "api.aws", "false", "true", "us-gov-west-1", """^us\-gov\-\w+\-\d+$""")]
    public void EmitsEachPartitionsAttributes(string variable, string name, string dnsSuffix, string dualStackDnsSuffix, string supportsFips, string supportsDualStack, string implicitGlobalRegion, string regionRegex)
    {
        var block = AttributesBlock(variable);

        Assert.Contains($"name = \"{name}\",", block);
        Assert.Contains($"dnsSuffix = \"{dnsSuffix}\",", block);
        Assert.Contains($"dualStackDnsSuffix = \"{dualStackDnsSuffix}\",", block);
        Assert.Contains($"supportsFIPS = {supportsFips},", block);
        Assert.Contains($"supportsDualStack = {supportsDualStack},", block);
        Assert.EndsWith($"implicitGlobalRegion = \"{implicitGlobalRegion}\"", block.TrimEnd());
        Assert.Contains($"""_partitionsByRegex.Add((new Regex(@"{regionRegex}", RegexOptions.Compiled), {variable}));""", Output);
    }

    // Unlike RegionEndpoint, the lookup table keeps the *-global pseudo-regions.
    [Fact]
    public void MapsEveryRegionToItsPartition()
    {
        Assert.Contains("""_partitionsByRegionName.Add("aws-global", aws);""", Output);
        Assert.Contains("""_partitionsByRegionName.Add("us-gov-east-1", aws_us_gov);""", Output);
    }

    [Fact]
    public void DefaultsToTheAwsPartition()
    {
        Assert.Contains("_defaultPartition = aws;", Output);
    }

    // C2J's template output has no final newline, so neither does the committed file.
    [Fact]
    public void EndsWithoutAFinalNewline()
    {
        Assert.EndsWith("}", Output);
    }

    private static string AttributesBlock(string variable)
    {
        var start = Output.IndexOf($"var {variable} = new PartitionAttributesShape", StringComparison.Ordinal);
        Assert.True(start >= 0, $"No attributes block for {variable}.");
        var end = Output.IndexOf("};", start, StringComparison.Ordinal);
        Assert.True(end > start, $"The attributes block for {variable} isn't closed with '}};'.");
        return Output[start..end];
    }
}
