using SmithyDotNet.Generator.Model.Traits;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Model;

[Collection(nameof(CloudTrailModelCollection))]
public class AWSTraitTests(CloudTrailModelFixture fixture)
{
    [Fact]
    public void IsRestJson1_ReturnsTrueForCloudTrailService()
    {
        var shape = fixture.DeserializeShape("com.amazonaws.cloudtraildata#CloudTrailDataService");
        Assert.True(shape.IsRestJson1());
    }

    [Fact]
    public void IsRestJson1_ReturnsFalseForNonServiceShape()
    {
        var shape = fixture.DeserializeShape("com.amazonaws.cloudtraildata#AuditEvent");
        Assert.False(shape.IsRestJson1());
    }

    [Fact]
    public void GetAWSService_ReturnsSdkIdAndEndpointPrefix()
    {
        var shape = fixture.DeserializeShape("com.amazonaws.cloudtraildata#CloudTrailDataService");
        var service = shape.GetAWSService();
        Assert.NotNull(service);
        Assert.Equal("CloudTrail Data", service.SdkId);
        Assert.Equal("cloudtrail-data", service.EndpointPrefix);
    }

    [Fact]
    public void GetSigV4_ReturnsSigningName()
    {
        var shape = fixture.DeserializeShape("com.amazonaws.cloudtraildata#CloudTrailDataService");
        var sigv4 = shape.GetSigV4();
        Assert.NotNull(sigv4);
        Assert.Equal("cloudtrail-data", sigv4.SigningName);
    }

    [Fact]
    public void HasEndpointRuleSet_ReturnsTrueForServiceWithRuleSet()
    {
        var shape = fixture.DeserializeShape("com.amazonaws.cloudtraildata#CloudTrailDataService");
        Assert.True(shape.HasEndpointRuleSet());
    }

    [Fact]
    public void HasEndpointRuleSet_ReturnsFalseForShapeWithoutRuleSet()
    {
        var shape = fixture.DeserializeShape("com.amazonaws.cloudtraildata#AuditEvent");
        Assert.False(shape.HasEndpointRuleSet());
    }
}
