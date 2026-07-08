using SmithyDotNet.Generator.Model.Shapes;
using static SmithyDotNet.Generator.Model.Traits.TraitHelpers;

namespace SmithyDotNet.Generator.Model.Traits;

/// <summary>
/// Extension methods for the service traits the generator reads: the <c>aws.*</c> traits, the
/// <c>smithy.api#httpBearerAuth</c> auth trait, plus the <c>smithy.rules#endpointRuleSet</c> trait.
/// </summary>
public static class AWSTraits
{
    #region Protocol annotation traits

    /// <remarks><see href="https://smithy.io/2.0/aws/protocols/aws-restjson1-protocol.html" /></remarks>
    public static bool IsRestJson1(this Shape shape) => shape.Traits.ContainsKey("aws.protocols#restJson1");

    #endregion

    #region Structured traits

    /// <remarks><see href="https://smithy.io/2.0/aws/aws-core.html#aws-api-service-trait" /></remarks>
    public static AWSServiceTrait? GetAWSService(this Shape shape) => DeserializeTrait<AWSServiceTrait>(shape, "aws.api#service");

    /// <remarks><see href="https://smithy.io/2.0/aws/aws-auth.html#aws-auth-sigv4-trait" /></remarks>
    public static SigV4Trait? GetSigV4(this Shape shape) => DeserializeTrait<SigV4Trait>(shape, "aws.auth#sigv4");

    /// <summary>Whether the shape carries the <c>aws.auth#sigv4a</c> trait.</summary>
    /// <remarks><see href="https://smithy.io/2.0/aws/aws-auth.html#aws-auth-sigv4a-trait" /></remarks>
    public static bool HasSigV4A(this Shape shape) => shape.Traits.ContainsKey("aws.auth#sigv4a");

    /// <summary>Whether the shape carries the <c>smithy.api#httpBearerAuth</c> trait.</summary>
    /// <remarks><see href="https://smithy.io/2.0/spec/authentication-traits.html#httpbearerauth-trait" /></remarks>
    public static bool HasHttpBearerAuth(this Shape shape) => shape.Traits.ContainsKey("smithy.api#httpBearerAuth");

    /// <summary>
    /// Whether the service shape carries a Smithy endpoint rule set. The config writer emits the
    /// endpoint resolver field, <c>EndpointProvider</c> wiring, and <c>DetermineServiceOperationEndpoint</c>
    /// override only when this is true. Reports trait presence only, not rule-set evaluation.
    /// </summary>
    /// <remarks><see href="https://smithy.io/2.0/additional-specs/rules-engine/specification.html#smithy-rules-endpointruleset-trait" /></remarks>
    public static bool HasEndpointRuleSet(this Shape shape) => shape.Traits.ContainsKey("smithy.rules#endpointRuleSet");

    /// <summary>
    /// The service's endpoint rule set, or <c>null</c> when the trait is absent. The endpoint
    /// writers compile this into the parameters class and the endpoint provider.
    /// </summary>
    /// <remarks><see href="https://smithy.io/2.0/additional-specs/rules-engine/specification.html#smithy-rules-endpointruleset-trait" /></remarks>
    public static EndpointRuleSet? GetEndpointRuleSet(this Shape shape) => DeserializeTrait<EndpointRuleSet>(shape, "smithy.rules#endpointRuleSet");

    /// <summary>
    /// Whether the shape carries an endpoint context-parameter trait: <c>clientContextParams</c>
    /// (service), <c>staticContextParams</c> (operation), or <c>contextParam</c> (member). These feed
    /// per-operation endpoint parameter assignment, which the resolver writer doesn't emit yet, so it
    /// fails loud when one is present.
    /// </summary>
    /// <remarks><see href="https://smithy.io/2.0/additional-specs/rules-engine/parameters.html" /></remarks>
    public static bool HasEndpointContextParams(this Shape shape) =>
        shape.Traits.ContainsKey("smithy.rules#clientContextParams")
        || shape.Traits.ContainsKey("smithy.rules#staticContextParams")
        || shape.Traits.ContainsKey("smithy.rules#contextParam");

    /// <summary>
    /// Whether the service shape carries Smithy endpoint tests. The endpoint provider tests writer
    /// emits one <c>[TestMethod]</c> per case only when this is true.
    /// </summary>
    /// <remarks><see href="https://smithy.io/2.0/additional-specs/rules-engine/specification.html#smithy-rules-endpointtests-trait" /></remarks>
    public static bool HasEndpointTests(this Shape shape) => shape.Traits.ContainsKey("smithy.rules#endpointTests");

    /// <summary>
    /// The service's endpoint test suite, or <c>null</c> when the trait is absent.
    /// </summary>
    /// <remarks><see href="https://smithy.io/2.0/additional-specs/rules-engine/specification.html#smithy-rules-endpointtests-trait" /></remarks>
    public static EndpointTestSuite? GetEndpointTests(this Shape shape) => DeserializeTrait<EndpointTestSuite>(shape, "smithy.rules#endpointTests");

    #endregion
}
