using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Generation.Protocols;

/// <summary>
/// The wire protocol used by an AWS service.
/// </summary>
public enum AWSProtocol { RestJson1, AwsJson1_0, AwsJson1_1 }

/// <summary>
/// Resolves the service's wire protocol from its protocol traits the way the legacy generator does:
/// highest-priority trait, less any per-service skip.
/// </summary>
public static class ProtocolResolver
{
    // AWS protocol trait IDs in the legacy generator's resolution priority
    // (smithy-rpc-v2-cbor > json > rest-json > rest-xml > query > ec2). A service that models several
    // resolves to the highest-priority one; awsJson1_0/1_1 share C2J's single "json" slot.
    private static readonly string[] ProtocolPriority =
    [
        "smithy.protocols#rpcv2Cbor",
        "aws.protocols#awsJson1_0",
        "aws.protocols#awsJson1_1",
        "aws.protocols#restJson1",
        "aws.protocols#restXml",
        "aws.protocols#awsQuery",
        "aws.protocols#ec2Query",
    ];

    // Per-service protocol skips, mirroring the legacy generator: ARC Region switch models CBOR but
    // must resolve to its awsJson protocol. Keyed by sdkId (the raw aws.api#service value).
    private static readonly Dictionary<string, string> SkipProtocolForService = new()
    {
        ["ARC Region switch"] = "smithy.protocols#rpcv2Cbor",
    };

    // Resolves the service's protocol the way the legacy generator does — highest-priority trait,
    // less any per-service skip — then fails loudly unless it is one of the implemented protocols.
    public static AWSProtocol Resolve(ServiceShape service, string sdkId)
    {
        var resolved = ResolveTraitId(service.Traits.Keys, sdkId) ?? throw new GeneratorException("Service shape has no recognized AWS protocol trait.");
        return resolved switch
        {
            "aws.protocols#restJson1" => AWSProtocol.RestJson1,
            "aws.protocols#awsJson1_0" => AWSProtocol.AwsJson1_0,
            "aws.protocols#awsJson1_1" => AWSProtocol.AwsJson1_1,
            _ => throw new GeneratorException($"Resolved protocol '{resolved}' is not supported yet."),
        };
    }

    // The highest-priority protocol trait the service carries, less any per-service skip, or null when
    // it models none.
    public static string? ResolveTraitId(IReadOnlyCollection<string> traitIds, string sdkId)
    {
        var skip = SkipProtocolForService.GetValueOrDefault(sdkId);
        return ProtocolPriority.FirstOrDefault(id => id != skip && traitIds.Contains(id));
    }
}
