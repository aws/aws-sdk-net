using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class ConfigWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";

    // The package build version is NOT in the Smithy AST; it comes from the C2J _sdk-versions.json
    // (CloudTrailData -> "4.0.1.29"). It is threaded in as a constructor argument, the same way the
    // model file name is, so the writer stays a pure projection of its inputs.
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
        // The class doc uses the normalized service name (ClassName), not the raw sdkId, matching the
        // legacy ServiceConfig.tt: "Configuration for accessing Amazon {ClassName} service".
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
        // First arg is the RAW sdkId ("CloudTrail Data"); second is the external package version.
        Assert.Contains("InternalSDKUtils.BuildUserAgentString(\"CloudTrail Data\", \"4.0.1.29\")", _output);
    }

    [Fact]
    public void EmitsDynamicStringLiterals_FullyEscaped_ForCompilableOutput()
    {
        // Dynamic string values (sdkId, signing name, version) are emitted via
        // SymbolDisplay.FormatLiteral so a value containing a quote or backslash still produces valid
        // C#. CloudTrail Data carries no such character, so the guard is: nothing produced an unescaped
        // run like  ""  (an empty/broken literal) and the known values landed quoted exactly once.
        // sdkId "CloudTrail Data" is emitted exactly 3 times: the user-agent arg, the static ServiceId
        // getter, and base.ServiceId in the constructor (matching the oracle's three occurrences).
        Assert.DoesNotContain("\"\"", _output);
        Assert.Equal(3, System.Text.RegularExpressions.Regex.Count(_output, "\"CloudTrail Data\""));
    }

    [Fact]
    public void EmitsEndpointResolverField_WhenServiceHasEndpointRuleSet()
    {
        // CloudTrailData carries smithy.rules#endpointRuleSet, so the resolver field + provider wiring
        // are emitted (the EndpointsRuleSet != null branch of the legacy template).
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
        // The static ServiceId returns the verbatim sdkId ("CloudTrail Data"), NOT the normalized class
        // name. Expression-bodied per the writer-family idiom; the literal is FormatLiteral-escaped.
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
