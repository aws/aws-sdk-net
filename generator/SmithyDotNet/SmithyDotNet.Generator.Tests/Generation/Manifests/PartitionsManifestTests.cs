using SmithyDotNet.Generator.Generation.Manifests;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation.Manifests;

public class PartitionsManifestTests
{
    [Fact]
    public void Load_KeepsTheFileOrder()
    {
        var partitions = PartitionsManifest.Load("TestData/partitions.json");

        // Neither list is alphabetical, so a sort would show.
        Assert.Equal(["aws", "aws-us-gov", "aws-cn"], partitions.Select(partition => partition.Id));
        Assert.Equal(["us-east-1", "aws-global", "ap-southeast-1"], partitions[0].Regions.Select(region => region.Code));
        Assert.Equal(new AwsRegion("cn-northwest-1", "China (Ningxia)"), Assert.Single(partitions[2].Regions));
    }

    [Fact]
    public void Load_ReadsThePartitionAttributes()
    {
        var partition = PartitionsManifest.Load("TestData/partitions.json").Single(partition => partition.Id == "aws-cn");

        Assert.Equal(
            ("aws-cn", "amazonaws.com.cn", "api.amazonwebservices.com.cn", true, false, "cn-northwest-1", """^cn\-\w+\-\d+$"""),
            (partition.Name, partition.DnsSuffix, partition.DualStackDnsSuffix, partition.SupportsFips, partition.SupportsDualStack, partition.ImplicitGlobalRegion, partition.RegionRegex));
    }

    [Theory]
    [InlineData("""{ "version": "1.1" }""", "is missing 'partitions'")]
    [InlineData("""{ "partitions": [{ "id": "aws", "regionRegex": "x", "regions": {} }] }""", "aws is missing 'outputs'")]
    public void Load_Invalid_Throws(string json, string expectedInMessage)
    {
        var directory = Directory.CreateTempSubdirectory("partitions-");
        try
        {
            var path = Path.Combine(directory.FullName, "partitions.json");
            File.WriteAllText(path, json);

            var ex = Assert.Throws<GeneratorException>(() => PartitionsManifest.Load(path));
            Assert.Contains(expectedInMessage, ex.Message);
        }
        finally
        {
            directory.Delete(recursive: true);
        }
    }
}
