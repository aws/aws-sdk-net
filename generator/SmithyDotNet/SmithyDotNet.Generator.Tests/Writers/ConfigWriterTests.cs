using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class ConfigWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";

    // The package build version is not in the Smithy AST (C2J _sdk-versions.json: CloudTrailData ->
    // "4.0.1.29"), so it is passed as a constructor argument.
    private const string ServiceFileVersion = "4.0.1.29";

    private readonly string _output;

    public ConfigWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new ConfigWriter(fixture.Context, ModelFileName, ServiceFileVersion);
        _output = writer.Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void EmitsLicenseAndGenerationNotice()
    {
        Assert.Contains("Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.", _output);
        Assert.Contains($"This file is generated from the {ModelFileName} service model.", _output);
    }

    [Fact]
    public void EmitsServiceNamespaceNotModelNamespace()
    {
        // Config sits in the service-level namespace, NOT the .Model namespace.
        Assert.Contains("namespace Amazon.CloudTrailData", _output);
        Assert.DoesNotContain("namespace Amazon.CloudTrailData.Model", _output);
    }

    [Fact]
    public void EmitsInternalUsing()
    {
        // The config references the service's .Internal types (EndpointResolver/Provider, DefaultConfiguration).
        Assert.Contains("using Amazon.CloudTrailData.Internal;", _output);
    }

    [Fact]
    public void EmitsClassDoc_UsingNormalizedServiceName()
    {
        // The class doc uses the normalized ServiceName (CloudTrailData), not the sdkId ("CloudTrail Data").
        Assert.Contains("/// Configuration for accessing Amazon CloudTrailData service", _output);
    }

    [Fact]
    public void EmitsPartialClassExtendingClientConfig()
    {
        Assert.Contains("public partial class AmazonCloudTrailDataConfig : ClientConfig", _output);
    }

    [Fact]
    public void EmitsUserAgentString_WithRawSdkIdAndExternalPackageVersion()
    {
        // First arg is the sdkId; second is the package version.
        Assert.Contains("InternalSDKUtils.BuildUserAgentString(\"CloudTrail Data\", \"4.0.1.29\")", _output);
    }

    [Fact]
    public void EmitsEndpointResolverField_WhenServiceHasEndpointRuleSet()
    {
        // CloudTrailData carries smithy.rules#endpointRuleSet, so the resolver field + provider wiring
        // are emitted.
        Assert.Contains("private static readonly AmazonCloudTrailDataEndpointResolver EndpointResolver =", _output);
        Assert.Contains("new AmazonCloudTrailDataEndpointResolver();", _output);
    }

    [Fact]
    public void EmitsUserAgentBackingField()
    {
        Assert.Contains("private string _userAgent = UserAgentString;", _output);
    }

    [Fact]
    public void EmitsStaticNewServiceId_ReturningRawSdkId()
    {
        // Static ServiceId is the sdkId ("CloudTrail Data"), not the normalized class name.
        Assert.Contains("public static new string ServiceId => \"CloudTrail Data\";", _output);
        Assert.DoesNotContain("\"CloudTrailData\";", _output);
    }

    [Fact]
    public void EmitsDefaultConstructor_WithDefaultConfigurationProviderBaseCall()
    {
        Assert.Contains("public AmazonCloudTrailDataConfig()", _output);
        Assert.Contains(": base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonCloudTrailDataDefaultConfiguration.GetAllConfigurations()))", _output);
    }

    [Fact]
    public void EmitsConstructorBody_SettingServiceIdAuthNameAndEndpointProvider()
    {
        Assert.Contains("base.ServiceId = \"CloudTrail Data\";", _output);
        // AuthenticationServiceName = sigv4.name ?? endpointPrefix => "cloudtrail-data".
        Assert.Contains("this.AuthenticationServiceName = \"cloudtrail-data\";", _output);
        // EndpointProvider wiring is part of the endpointRuleSet branch.
        Assert.Contains("this.EndpointProvider = new AmazonCloudTrailDataEndpointProvider();", _output);
    }

    [Fact]
    public void EmitsRegionEndpointServiceName_ReturningEndpointPrefix()
    {
        Assert.Contains("public override string RegionEndpointServiceName => \"cloudtrail-data\";", _output);
    }

    [Fact]
    public void EmitsServiceVersion_ReturningApiVersion()
    {
        Assert.Contains("public override string ServiceVersion => \"2021-08-11\";", _output);
    }

    [Fact]
    public void EmitsUserAgentProperty()
    {
        Assert.Contains("public override string UserAgent => _userAgent;", _output);
    }

    [Fact]
    public void EmitsDetermineServiceOperationEndpoint_WhenServiceHasEndpointRuleSet()
    {
        // The endpointRuleSet branch also emits the DetermineServiceOperationEndpoint override that
        // routes through the EndpointResolver.
        Assert.Contains("public override Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters)", _output);
        Assert.Contains("var requestContext = new RequestContext(false)", _output);
        Assert.Contains("return EndpointResolver.GetEndpoint(executionContext);", _output);
    }
}
