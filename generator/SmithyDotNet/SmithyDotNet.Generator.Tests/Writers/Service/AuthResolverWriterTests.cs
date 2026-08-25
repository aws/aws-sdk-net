using SmithyDotNet.Generator.Writers.Service;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Service;

// Each service exercises a distinct auth-config shape: KMS (service default only), Cognito Identity
// (per-operation no-auth overrides), Bedrock (an inline multi-scheme default), CodeCatalyst (bearer
// only, no Region), Dual Signing (a synthetic service with a derived multi-scheme default — no
// explicit auth list), Dual Signing Explicit (the same schemes carried as an explicit auth list),
// and Empty Auth (an explicitly empty auth list, normalized to noAuth).
public class AuthResolverWriterTests
{
    private static string Write(string modelFile, string modelFileName)
    {
        var context = TestModels.Context(Path.Combine("Auth", modelFile));
        return new AuthResolverWriter(context, modelFileName).Write(CancellationToken.None);
    }

    // Each model's resolver is written once and asserted across the tests below.
    private static readonly string KmsOutput = Write("kms-model.json", "kms-2014-11-01.normal.json");
    private static readonly string CognitoOutput = Write("cognito-identity-model.json", "cognito-identity-2014-06-30.normal.json");
    private static readonly string BedrockOutput = Write("bedrock-model.json", "bedrock-2023-04-20.normal.json");
    private static readonly string CodeCatalystOutput = Write("codecatalyst-model.json", "codecatalyst-2022-09-28.normal.json");
    private static readonly string DualSigningOutput = Write("dual-signing-model.json", "dual-signing-2024-01-01.normal.json");
    private static readonly string DualSigningExplicitOutput = Write("dual-signing-explicit-model.json", "dual-signing-explicit-2024-01-01.normal.json");
    private static readonly string EmptyAuthOutput = Write("empty-auth-model.json", "empty-auth-2024-01-01.normal.json");

    private static readonly string[] CognitoNoAuthRequestNames =
    [
        "GetCredentialsForIdentityRequest",
        "GetIdRequest",
        "GetOpenIdTokenRequest",
        "UnlinkIdentityRequest",
    ];

    [Fact]
    public void Kms_EmitsThreeAuthSchemeClasses()
    {
        Assert.Contains("public class AmazonKeyManagementServiceAuthSchemeParameters : IAuthSchemeParameters", KmsOutput);
        Assert.Contains("public class AmazonKeyManagementServiceAuthSchemeHandler : BaseAuthResolverHandler", KmsOutput);
        Assert.Contains("public class AmazonKeyManagementServiceAuthSchemeResolver : IAuthSchemeResolver<AmazonKeyManagementServiceAuthSchemeParameters>", KmsOutput);
    }

    [Fact]
    public void Kms_EmitsInternalNamespaceAndFixedUsings()
    {
        Assert.Contains("namespace Amazon.KeyManagementService.Internal", KmsOutput);
        Assert.Contains("using Amazon.Runtime;", KmsOutput);
        Assert.Contains("using Amazon.Runtime.Credentials.Internal;", KmsOutput);
        Assert.Contains("using Amazon.Runtime.Internal.Auth;", KmsOutput);
        Assert.Contains("using Amazon.Runtime.Identity;", KmsOutput);
        Assert.Contains("using System.Collections.Generic;", KmsOutput);
    }

    [Fact]
    public void Kms_EmitsRegionParameter_BecauseServiceSupportsSigV4()
    {
        Assert.Contains("public string Region { get; set; }", KmsOutput);
        Assert.Contains("Region = requestContext.ClientConfig.RegionEndpoint?.SystemName,", KmsOutput);
    }

    [Fact]
    public void Kms_HandlerMapsRequestContextAndDelegatesToResolver()
    {
        Assert.Contains("public AmazonKeyManagementServiceAuthSchemeResolver AuthSchemeResolver { get; } = new();", KmsOutput);
        Assert.Contains("protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext)", KmsOutput);
        Assert.Contains("Operation = requestContext.Request.RequestName,", KmsOutput);
        Assert.Contains("return AuthSchemeResolver.ResolveAuthScheme(mappedParameters);", KmsOutput);
    }

    [Fact]
    public void Kms_ResolverSwitchHasOnlyServiceDefaultArm()
    {
        Assert.Contains("public List<IAuthSchemeOption> ResolveAuthScheme(AmazonKeyManagementServiceAuthSchemeParameters authParameters) =>", KmsOutput);
        Assert.Contains("authParameters.Operation switch", KmsOutput);
        // No operation models its own auth, so the switch carries only the service-default discard arm.
        Assert.DoesNotContain("""Request" =>""", KmsOutput);
        Assert.Contains("_ => AuthSchemeOption.DEFAULT_SIGV4,", KmsOutput);
        Assert.DoesNotContain("DEFAULT_NOAUTH", KmsOutput);
    }

    [Fact]
    public void CognitoIdentity_EmitsNoAuthArmForEachModeledOperation()
    {
        // Each operation modeling smithy.api#auth: [noAuth] becomes a DEFAULT_NOAUTH arm keyed by the
        // {Operation}Request name.
        foreach (var requestName in CognitoNoAuthRequestNames)
        {
            Assert.Contains($"""
                "{requestName}" => AuthSchemeOption.DEFAULT_NOAUTH,
                """, CognitoOutput);
        }
    }

    [Fact]
    public void CognitoIdentity_ArmsAreOrderedByRequestName()
    {
        var indices = CognitoNoAuthRequestNames
            .Select(requestName => CognitoOutput.IndexOf($"""
                "{requestName}" =>
                """, StringComparison.Ordinal))
            .ToArray();
        Assert.All(indices, i => Assert.True(i >= 0));
        for (var i = 1; i < indices.Length; i++)
        {
            Assert.True(indices[i - 1] < indices[i], "Switch arms must be ordered by request name.");
        }
    }

    [Fact]
    public void CognitoIdentity_OperationWithoutAuthOverrideHasNoArm()
    {
        // DescribeIdentityPool models no auth override, so it falls through to the service default.
        Assert.DoesNotContain("""
            "DescribeIdentityPoolRequest" =>
            """, CognitoOutput);
    }

    [Fact]
    public void CognitoIdentity_ServiceDefaultRemainsSigV4()
    {
        Assert.Contains("_ => AuthSchemeOption.DEFAULT_SIGV4,", CognitoOutput);
    }

    [Fact]
    public void Bedrock_ServiceDefaultIsInlineSigV4AndBearerList()
    {
        // [sigv4, httpBearerAuth] is not a known DEFAULT_* list, so the default arm emits an inline
        // List<IAuthSchemeOption> with one entry per scheme rather than a constant.
        Assert.Contains("_ => new List<IAuthSchemeOption>", BedrockOutput);
        Assert.Contains("""new AuthSchemeOption { SchemeId = "aws.auth#sigv4" },""", BedrockOutput);
        Assert.Contains("""new AuthSchemeOption { SchemeId = "smithy.api#httpBearerAuth" },""", BedrockOutput);
        Assert.DoesNotContain("AuthSchemeOption.DEFAULT_", BedrockOutput);
    }

    [Fact]
    public void CodeCatalyst_ServiceDefaultIsBearerConstant()
    {
        Assert.Contains("_ => AuthSchemeOption.DEFAULT_BEARER,", CodeCatalystOutput);
    }

    [Fact]
    public void CodeCatalyst_OmitsRegion_BecauseServiceDoesNotSupportSigV4()
    {
        // A bearer-only service has no SigV4 in its auth list, so the Region parameter and its handler
        // mapping line are both omitted.
        Assert.DoesNotContain("public string Region { get; set; }", CodeCatalystOutput);
        Assert.DoesNotContain("Region = requestContext.ClientConfig.RegionEndpoint?.SystemName,", CodeCatalystOutput);
    }

    [Fact]
    public void DerivedSigV4SigV4A_ServiceDefaultEmitsCombinedConstant()
    {
        // The service models aws.auth#sigv4 + aws.auth#sigv4a with no smithy.api#auth — spec-valid:
        // omitting @auth means every applied auth-scheme trait applies. ServiceSchemes derives
        // [sigv4, sigv4a], which maps to the DEFAULT_SIGV4_SIGV4A constant. This is the only fixture
        // that exercises the derived multi-scheme path.
        Assert.Contains("_ => AuthSchemeOption.DEFAULT_SIGV4_SIGV4A,", DualSigningOutput);
        Assert.DoesNotContain("new List<IAuthSchemeOption>", DualSigningOutput);
    }

    [Fact]
    public void CarriedSigV4SigV4A_ServiceDefaultEmitsCombinedConstant()
    {
        // The explicit smithy.api#auth list — the shape real dual-signing services like STS model — is
        // carried verbatim and maps to the same DEFAULT_SIGV4_SIGV4A constant, so output is identical to
        // the derived fixture; the two differ only in which ModeledAuth.ServiceSchemes branch produces it.
        Assert.Contains("_ => AuthSchemeOption.DEFAULT_SIGV4_SIGV4A,", DualSigningExplicitOutput);
        Assert.DoesNotContain("new List<IAuthSchemeOption>", DualSigningExplicitOutput);
    }

    [Fact]
    public void EmptyAuthList_NormalizesToNoAuthConstant_NotAnEmptyList()
    {
        // The service models smithy.api#auth: [] (which wins over its aws.auth#sigv4 trait), and GetItem
        // models its own smithy.api#auth: []. Both normalize to [noAuth] -> DEFAULT_NOAUTH rather than an
        // empty list, which BaseAuthResolverHandler would reject at runtime.
        Assert.Contains("""
            "GetItemRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
            """, EmptyAuthOutput);
        Assert.Contains("_ => AuthSchemeOption.DEFAULT_NOAUTH,", EmptyAuthOutput);
        Assert.DoesNotContain("new List<IAuthSchemeOption>", EmptyAuthOutput);
    }
}
