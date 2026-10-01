using SmithyDotNet.Generator.Generation.Protocols;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation.Protocols;

public class ProtocolResolverTests
{
    [Theory]
    // Highest-priority trait wins over lower ones, regardless of the order they appear in the model.
    [InlineData("aws.protocols#restJson1", "smithy.protocols#rpcv2Cbor", "smithy.protocols#rpcv2Cbor")]
    [InlineData("aws.protocols#awsJson1_0", "aws.protocols#restJson1", "aws.protocols#awsJson1_0")]
    [InlineData("aws.protocols#awsQuery", "aws.protocols#restXml", "aws.protocols#restXml")]
    [InlineData("aws.protocols#ec2Query", "aws.protocols#awsQuery", "aws.protocols#awsQuery")]
    public void ResolveTraitId_PicksHighestPriority(string a, string b, string expected)
    {
        Assert.Equal(expected, ProtocolResolver.ResolveTraitId([a, b], "Example"));
    }

    [Fact]
    public void ResolveTraitId_AppliesArcRegionSwitchSkip()
    {
        // ARC Region switch models CBOR but must skip it; the next-priority protocol wins.
        Assert.Equal("aws.protocols#awsJson1_0", ProtocolResolver.ResolveTraitId(["smithy.protocols#rpcv2Cbor", "aws.protocols#awsJson1_0"], "ARC Region switch"));
    }

    [Fact]
    public void ResolveTraitId_ReturnsNullWhenNoProtocolTrait()
    {
        Assert.Null(ProtocolResolver.ResolveTraitId(["aws.api#service"], "Example"));
    }
}
