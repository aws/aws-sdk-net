using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Model.Traits;

// Typed records for Smithy trait values.

/// <summary>
/// Base record for trait values deserialized from JSON objects.
/// Captures unknown properties for forward compatibility.
/// </summary>
public abstract record TraitRecord
{
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? UnmappedProperties { get; init; }
}

/// <remarks><see href="https://smithy.io/2.0/spec/type-refinement-traits.html#error-trait" /></remarks>
public record ErrorTrait(string Value);

/// <remarks><see href="https://smithy.io/2.0/spec/http-bindings.html#http-trait" /></remarks>
public record HttpTrait : TraitRecord
{
    [JsonPropertyName("method")]
    public required string Method { get; init; }

    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonPropertyName("code")]
    public int Code { get; init; } = 200;
}

/// <remarks><see href="https://smithy.io/2.0/spec/constraint-traits.html#length-trait" /></remarks>
public record LengthTrait : TraitRecord
{
    [JsonPropertyName("min")]
    public long? Min { get; init; }

    [JsonPropertyName("max")]
    public long? Max { get; init; }
}
