using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// A <c>dataTypeSwap</c> entry: overrides a member's generated .NET type and optionally names the marshaller
/// method and unmarshaller instance the generated code calls for it; an omitted one keeps the modeled conversion.
/// </summary>
public sealed record DataTypeSwap
{
    [JsonPropertyName("Type")]
    public required string Type { get; init; }

    [JsonPropertyName("Marshaller")]
    public string? Marshaller { get; init; }

    /// <summary>Read for a body member on any protocol; ignored on a response header, as in C2J.</summary>
    [JsonPropertyName("Unmarshaller")]
    public string? Unmarshaller { get; init; }

    /// <summary>
    /// restXml-only: a path (S3's <c>ErrorDocument/Key</c>) the unmarshaller reads the member from. A one-segment
    /// name is rejected: the model's <c>@xmlName</c> says it.
    /// </summary>
    [JsonPropertyName("alternateLocationName")]
    public string? AlternateLocationName { get; init; }
}
