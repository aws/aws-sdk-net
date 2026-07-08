using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

// Each service exercises a distinct auth-config shape: KMS (service default only), Cognito Identity
// (per-operation no-auth overrides), Bedrock (an inline multi-scheme default), CodeCatalyst (bearer
// only, no Region), Dual Signing (a synthetic service with a derived multi-scheme default — no
// explicit auth list), Dual Signing Explicit (the same schemes carried as an explicit auth list).
public class AuthResolverWriterTests
{
    private static string Write(string modelFile, string modelFileName)
    {
        var context = Load(modelFile);
        return new AuthResolverWriter(context, modelFileName).Write(TestContext.Current.CancellationToken);
    }

    // Loads a Smithy model from TestData and builds its GenerationContext (inlined from the former
    // AuthModelLoader, whose only other caller was the deleted compile test).
    private static GenerationContext Load(string testDataFileName)
    {
        var bytes = File.ReadAllBytes(Path.Combine("TestData", testDataFileName));
        var model = JsonSerializer.Deserialize<SmithyModel>(bytes, CloudTrailModelFixture.Options)
            ?? throw new InvalidOperationException($"Failed to deserialize '{testDataFileName}'.");
        return new GenerationContext(new ServiceIndex(model));
    }

    // --- KMS: a plain service-default service (no per-operation auth overrides) ---

    [Fact]
    public void Kms_EmitsThreeAuthSchemeClasses()
    {
        var output = Write("kms-model.json", "kms-2014-11-01.normal.json");

        Assert.Contains("public class AmazonKeyManagementServiceAuthSchemeParameters : IAuthSchemeParameters", output);
        Assert.Contains("public class AmazonKeyManagementServiceAuthSchemeHandler : BaseAuthResolverHandler", output);
        Assert.Contains("public class AmazonKeyManagementServiceAuthSchemeResolver : IAuthSchemeResolver<AmazonKeyManagementServiceAuthSchemeParameters>", output);
    }

    [Fact]
    public void Kms_EmitsInternalNamespaceAndFixedUsings()
    {
        var output = Write("kms-model.json", "kms-2014-11-01.normal.json");

        Assert.Contains("namespace Amazon.KeyManagementService.Internal", output);
        Assert.Contains("using Amazon.Runtime;", output);
        Assert.Contains("using Amazon.Runtime.Credentials.Internal;", output);
        Assert.Contains("using Amazon.Runtime.Internal.Auth;", output);
        Assert.Contains("using Amazon.Runtime.Identity;", output);
        Assert.Contains("using System.Collections.Generic;", output);
    }

    [Fact]
    public void Kms_EmitsRegionParameter_BecauseServiceSupportsSigV4()
    {
        var output = Write("kms-model.json", "kms-2014-11-01.normal.json");

        Assert.Contains("public string Region { get; set; }", output);
        Assert.Contains("Region = requestContext.ClientConfig.RegionEndpoint?.SystemName,", output);
    }

    [Fact]
    public void Kms_HandlerMapsRequestContextAndDelegatesToResolver()
    {
        var output = Write("kms-model.json", "kms-2014-11-01.normal.json");

        Assert.Contains("public AmazonKeyManagementServiceAuthSchemeResolver AuthSchemeResolver { get; } = new();", output);
        Assert.Contains("protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext)", output);
        Assert.Contains("Operation = requestContext.Request.RequestName,", output);
        Assert.Contains("return AuthSchemeResolver.ResolveAuthScheme(mappedParameters);", output);
    }

    [Fact]
    public void Kms_ResolverSwitchHasOnlyServiceDefaultArm()
    {
        var output = Write("kms-model.json", "kms-2014-11-01.normal.json");

        Assert.Contains("public List<IAuthSchemeOption> ResolveAuthScheme(AmazonKeyManagementServiceAuthSchemeParameters authParameters) =>", output);
        Assert.Contains("authParameters.Operation switch", output);
        // No operation models its own auth, so the switch carries only the service-default discard arm.
        Assert.DoesNotContain("Request\" =>", output);
        Assert.Contains("_ => AuthSchemeOption.DEFAULT_SIGV4,", output);
        Assert.DoesNotContain("DEFAULT_NOAUTH", output);
    }

    // --- Cognito Identity: 4 no-auth operation overrides + a SigV4 service default ---

    [Fact]
    public void CognitoIdentity_EmitsNoAuthArmForEachModeledOperation()
    {
        var output = Write("cognito-identity-model.json", "cognito-identity-2014-06-30.normal.json");

        // Each operation modeling smithy.api#auth: [noAuth] becomes a DEFAULT_NOAUTH arm keyed by the
        // {Operation}Request name.
        Assert.Contains("\"GetCredentialsForIdentityRequest\" => AuthSchemeOption.DEFAULT_NOAUTH,", output);
        Assert.Contains("\"GetIdRequest\" => AuthSchemeOption.DEFAULT_NOAUTH,", output);
        Assert.Contains("\"GetOpenIdTokenRequest\" => AuthSchemeOption.DEFAULT_NOAUTH,", output);
        Assert.Contains("\"UnlinkIdentityRequest\" => AuthSchemeOption.DEFAULT_NOAUTH,", output);
    }

    [Fact]
    public void CognitoIdentity_ArmsAreOrderedByRequestName()
    {
        var output = Write("cognito-identity-model.json", "cognito-identity-2014-06-30.normal.json");

        var order = new[]
        {
            "\"GetCredentialsForIdentityRequest\" =>",
            "\"GetIdRequest\" =>",
            "\"GetOpenIdTokenRequest\" =>",
            "\"UnlinkIdentityRequest\" =>",
        };
        var indices = order.Select(arm => output.IndexOf(arm, StringComparison.Ordinal)).ToArray();
        Assert.All(indices, i => Assert.True(i >= 0));
        for (var i = 1; i < indices.Length; i++)
        {
            Assert.True(indices[i - 1] < indices[i], "Switch arms must be ordered by request name.");
        }
    }

    [Fact]
    public void CognitoIdentity_OperationWithoutAuthOverrideHasNoArm()
    {
        var output = Write("cognito-identity-model.json", "cognito-identity-2014-06-30.normal.json");

        // DescribeIdentityPool models no auth override, so it falls through to the service default.
        Assert.DoesNotContain("\"DescribeIdentityPoolRequest\" =>", output);
    }

    [Fact]
    public void CognitoIdentity_ServiceDefaultRemainsSigV4()
    {
        var output = Write("cognito-identity-model.json", "cognito-identity-2014-06-30.normal.json");

        Assert.Contains("_ => AuthSchemeOption.DEFAULT_SIGV4,", output);
    }

    // --- Bedrock: SigV4 + httpBearerAuth service default, emitted inline (no single DEFAULT_* constant) ---

    [Fact]
    public void Bedrock_ServiceDefaultIsInlineSigV4AndBearerList()
    {
        var output = Write("bedrock-model.json", "bedrock-2023-04-20.normal.json");

        // [sigv4, httpBearerAuth] is not a known DEFAULT_* list, so the default arm emits an inline
        // List<IAuthSchemeOption> with one entry per scheme rather than a constant.
        Assert.Contains("_ => new List<IAuthSchemeOption>", output);
        Assert.Contains("new AuthSchemeOption { SchemeId = \"aws.auth#sigv4\" },", output);
        Assert.Contains("new AuthSchemeOption { SchemeId = \"smithy.api#httpBearerAuth\" },", output);
        Assert.DoesNotContain("AuthSchemeOption.DEFAULT_", output);
    }

    // --- CodeCatalyst: bearer-only service that does not support SigV4, so emits no Region ---

    [Fact]
    public void CodeCatalyst_ServiceDefaultIsBearerConstant()
    {
        var output = Write("codecatalyst-model.json", "codecatalyst-2022-09-28.normal.json");

        Assert.Contains("_ => AuthSchemeOption.DEFAULT_BEARER,", output);
    }

    [Fact]
    public void CodeCatalyst_OmitsRegion_BecauseServiceDoesNotSupportSigV4()
    {
        var output = Write("codecatalyst-model.json", "codecatalyst-2022-09-28.normal.json");

        // A bearer-only service has no SigV4 in its auth list, so the Region parameter and its handler
        // mapping line are both omitted.
        Assert.DoesNotContain("public string Region { get; set; }", output);
        Assert.DoesNotContain("Region = requestContext.ClientConfig.RegionEndpoint?.SystemName,", output);
    }

    // --- Dual Signing (a synthetic test service): no explicit smithy.api#auth, so the [sigv4, sigv4a]
    // default is DERIVED from the service's auth traits. Per the Smithy spec (authentication-traits.html),
    // a service that omits @auth supports every applied auth-scheme trait, ordered alphabetically by shape
    // ID — so aws.auth#sigv4 + aws.auth#sigv4a with no @auth is a spec-valid model equivalent to
    // [sigv4, sigv4a]. Real AWS services carry the explicit list (see DualSigningExplicit below); this
    // fixture is the only one exercising the trait-derivation branch (ModeledAuth.ServiceSchemes). ---

    [Fact]
    public void DerivedSigV4SigV4A_ServiceDefaultEmitsCombinedConstant()
    {
        var output = Write("dual-signing-model.json", "dual-signing-2024-01-01.normal.json");

        // The service models aws.auth#sigv4 + aws.auth#sigv4a with no smithy.api#auth, so ServiceSchemes
        // derives [sigv4, sigv4a] (rather than carrying an explicit list), which maps to the
        // DEFAULT_SIGV4_SIGV4A constant. This is the only fixture that exercises the derived multi-scheme path.
        Assert.Contains("_ => AuthSchemeOption.DEFAULT_SIGV4_SIGV4A,", output);
        Assert.DoesNotContain("new List<IAuthSchemeOption>", output);
    }

    // --- Dual Signing Explicit (a synthetic test service mirroring the real STS shape): carries an
    // explicit smithy.api#auth: [sigv4, sigv4a] alongside the aws.auth# traits. Exercises the CARRIED
    // multi-scheme branch, the shape every shipping AWS dual-signing service actually uses. ---

    [Fact]
    public void CarriedSigV4SigV4A_ServiceDefaultEmitsCombinedConstant()
    {
        var output = Write("dual-signing-explicit-model.json", "dual-signing-explicit-2024-01-01.normal.json");

        // The explicit smithy.api#auth list is carried verbatim (rather than derived from traits) and maps
        // to the same DEFAULT_SIGV4_SIGV4A constant, so output is identical to the derived fixture — the
        // two fixtures differ only in which ModeledAuth.ServiceSchemes branch produces the list.
        Assert.Contains("_ => AuthSchemeOption.DEFAULT_SIGV4_SIGV4A,", output);
        Assert.DoesNotContain("new List<IAuthSchemeOption>", output);
    }

    // --- Empty Auth (a synthetic test service): an explicitly modeled empty smithy.api#auth: [] means
    // "no auth" but resolves to DEFAULT_NOAUTH — an empty options list would throw in the runtime handler ---

    [Fact]
    public void EmptyAuthList_NormalizesToNoAuthConstant_NotAnEmptyList()
    {
        var output = Write("empty-auth-model.json", "empty-auth-2024-01-01.normal.json");

        // The service models smithy.api#auth: [] (which wins over its aws.auth#sigv4 trait), and GetItem
        // models its own smithy.api#auth: []. Both normalize to [noAuth] -> DEFAULT_NOAUTH rather than an
        // empty list, which BaseAuthResolverHandler would reject at runtime.
        Assert.Contains("\"GetItemRequest\" => AuthSchemeOption.DEFAULT_NOAUTH,", output);
        Assert.Contains("_ => AuthSchemeOption.DEFAULT_NOAUTH,", output);
        Assert.DoesNotContain("new List<IAuthSchemeOption>", output);
    }
}
