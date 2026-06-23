using SmithyDotNet.Generator.Model.Shapes;
using static SmithyDotNet.Generator.Model.Traits.TraitHelpers;

namespace SmithyDotNet.Generator.Model.Traits;

/// <summary>
/// Extension methods for the service traits the generator reads: the <c>aws.*</c> traits plus the
/// <c>smithy.rules#endpointRuleSet</c> trait.
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

    /// <summary>
    /// Whether the service shape carries a Smithy endpoint rule set. The config writer emits the
    /// endpoint resolver field, <c>EndpointProvider</c> wiring, and <c>DetermineServiceOperationEndpoint</c>
    /// override only when this is true. Reports trait presence only, not rule-set evaluation.
    /// </summary>
    /// <remarks><see href="https://smithy.io/2.0/additional-specs/rules-engine/specification.html#smithy-rules-endpointruleset-trait" /></remarks>
    public static bool HasEndpointRuleSet(this Shape shape) => shape.Traits.ContainsKey("smithy.rules#endpointRuleSet");

    #endregion
}
