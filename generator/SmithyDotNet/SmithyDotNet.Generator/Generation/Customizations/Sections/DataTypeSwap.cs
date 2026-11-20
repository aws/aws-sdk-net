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

    [JsonPropertyName("Unmarshaller")]
    public string? Unmarshaller { get; init; }

    /// <summary>XML-only: marks a swapped collection as flattened. Rejected until an XML protocol is supported.</summary>
    [JsonPropertyName("isFlattened")]
    public bool? IsFlattened { get; init; }

    /// <summary>XML-only: overrides the member's XML element name. Rejected until an XML protocol is supported.</summary>
    [JsonPropertyName("alternateLocationName")]
    public string? AlternateLocationName { get; init; }
}
