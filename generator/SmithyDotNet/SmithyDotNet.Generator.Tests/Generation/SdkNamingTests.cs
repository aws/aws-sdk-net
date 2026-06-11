using SmithyDotNet.Generator.Generation;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

public class SdkNamingTests
{
    [Theory]
    [InlineData("AWS Elemental MediaPackage", "ElementalMediaPackage")]
    [InlineData("AWS IoT 1-Click Projects", "IoT1ClickProjects")]
    [InlineData("Amazon Pinpoint", "Pinpoint")]
    [InlineData("Amazon RDS", "RDS")]
    [InlineData("Config Service", "ConfigService")]
    [InlineData("synthetics", "Synthetics")]
    [InlineData("CloudTrail Data", "CloudTrailData")]
    public void NormalizeSdkId_ProducesExpectedClassName(string sdkId, string expected)
    {
        Assert.Equal(expected, SdkNaming.NormalizeSdkId(sdkId));
    }
}
