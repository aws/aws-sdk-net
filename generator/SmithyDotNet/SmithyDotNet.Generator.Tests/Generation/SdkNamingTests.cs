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

    // Exhaustive coverage of the enum member-name munging. Each row exercises a distinct case; the
    // expected values are the C2J generator's output for the same wire value (SimpleModels.cs).
    [Theory]
    // Single token, already capitalized -> unchanged.
    [InlineData("ACTIVE", "ACTIVE")]
    // Underscore is NOT a separator, so an underscored value stays one token (rest preserved verbatim).
    [InlineData("SIGN_UP", "SIGN_UP")]
    [InlineData("GENERAL_PURPOSE_SSD", "GENERAL_PURPOSE_SSD")]
    // Hyphen separator; each token's first char uppercased, remainder verbatim.
    [InlineData("amazon-web-services", "AmazonWebServices")]
    // Dot separator; digits preserved in the remainder.
    [InlineData("t2.micro", "T2Micro")]
    [InlineData("m4.large", "M4Large")]
    // Slash / colon / comma / plus / ampersand / asterisk separators.
    [InlineData("read/write", "ReadWrite")]
    [InlineData("a:b", "AB")]
    [InlineData("a,b", "AB")]
    [InlineData("a+b", "AB")]
    [InlineData("a&b", "AB")]
    [InlineData("a*b", "AB")]
    // EN DASH (U+2013) is the first separator in C2J's set.
    [InlineData("a–b", "AB")]
    // RemoveEmptyEntries drops empty tokens from leading/trailing/doubled separators.
    [InlineData("-foo--bar-", "FooBar")]
    // Only the first character is uppercased; internal capitalization is preserved verbatim.
    [InlineData("IPv4", "IPv4")]
    [InlineData("us-east-1", "UsEast1")]
    // Parentheses are stripped after capitalization (the token's first char was '(', so the following
    // letter is not uppercased before removal).
    [InlineData("foo(bar)", "Foobar")]
    // Collides with object.Equals (drives the `new` keyword in emission).
    [InlineData("Equals", "Equals")]
    public void ToEnumMemberName_ReproducesC2jMunging(string wireValue, string expected)
    {
        Assert.Equal(expected, SdkNaming.ToEnumMemberName(wireValue));
    }
}
