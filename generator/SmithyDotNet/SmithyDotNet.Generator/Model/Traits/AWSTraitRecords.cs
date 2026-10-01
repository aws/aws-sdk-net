using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Model.Traits;

// Typed records for AWS trait values.

/// <remarks><see href="https://smithy.io/2.0/aws/aws-core.html#aws-api-service-trait" /></remarks>
public record AWSServiceTrait : TraitRecord
{
    [JsonPropertyName("sdkId")]
    public required string SdkId { get; init; }

    [JsonPropertyName("arnNamespace")]
    public string? ArnNamespace { get; init; }

    [JsonPropertyName("cloudFormationName")]
    public string? CloudFormationName { get; init; }

    [JsonPropertyName("endpointPrefix")]
    public string? EndpointPrefix { get; init; }

    [JsonPropertyName("abbreviatedName")]
    public string? AbbreviatedName { get; init; }

    [JsonPropertyName("docId")]
    public string? DocId { get; init; }
}

/// <remarks><see href="https://smithy.io/2.0/aws/aws-auth.html#aws-auth-sigv4-trait" /></remarks>
public record SigV4Trait : TraitRecord
{
    [JsonPropertyName("name")]
    public required string SigningName { get; init; }
}

/// <summary>
/// The value of the protocol traits (such as restJson1 or awsJson1_0), which all carry
/// the same HTTP version members.
/// </summary>
public record ProtocolTrait : TraitRecord
{
    // Priority-ordered HTTP versions for normal / event-stream operations. eventStreamHttp is a subset of http.
    [JsonPropertyName("http")]
    public IReadOnlyList<string>? Http { get; init; }

    [JsonPropertyName("eventStreamHttp")]
    public IReadOnlyList<string>? EventStreamHttp { get; init; }
}
