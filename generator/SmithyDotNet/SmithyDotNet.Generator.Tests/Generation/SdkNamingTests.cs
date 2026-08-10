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

    [Theory]
    [InlineData("MyService", "example-arn", "example-signing", "example-signing")] // sigv4 name wins
    [InlineData("MyService", "example-arn", null, "example-arn")]                  // falls back to arnNamespace
    [InlineData("MyService", null, null, "myservice")]                             // last resort: lowercase shape name
    [InlineData("MyService", "execute-api", "example-signing", "execute-api")]     // execute-api overrides sigv4 name
    public void ResolveSigningName_FollowsPrecedence(string shapeName, string? arnNamespace, string? sigV4Name, string expected)
    {
        Assert.Equal(expected, SdkNaming.ResolveSigningName(shapeName, arnNamespace, sigV4Name));
    }
}
