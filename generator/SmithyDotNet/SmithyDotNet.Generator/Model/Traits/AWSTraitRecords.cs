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
}

/// <remarks><see href="https://smithy.io/2.0/aws/aws-auth.html#aws-auth-sigv4-trait" /></remarks>
public record SigV4Trait : TraitRecord
{
    [JsonPropertyName("name")]
    public required string SigningName { get; init; }
}
