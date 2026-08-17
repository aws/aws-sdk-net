using System.Text.Json;
using System.Text.Json.Serialization;
using SmithyDotNet.Generator.Model.Converters;

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

/// <remarks><see href="https://smithy.io/2.0/spec/constraint-traits.html#range-trait" /></remarks>
public record RangeTrait : TraitRecord
{
    // Bounds are bigDecimal in the AST but AWSPropertyAttribute.Min/Max are long; the converter
    // reproduces the c2j generator's parse (non-integral bounds like 0.01 are skipped, not errors).
    [JsonPropertyName("min")]
    [JsonConverter(typeof(RangeBoundConverter))]
    public long? Min { get; init; }

    [JsonPropertyName("max")]
    [JsonConverter(typeof(RangeBoundConverter))]
    public long? Max { get; init; }
}

/// <remarks><see href="https://smithy.io/2.0/spec/documentation-traits.html#deprecated-trait" /></remarks>
public record DeprecatedTrait : TraitRecord
{
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonPropertyName("since")]
    public string? Since { get; init; }
}

/// <remarks><see href="https://smithy.io/2.0/spec/behavior-traits.html#retryable-trait" /></remarks>
public record RetryableTrait : TraitRecord
{
    // Optional in the model; an empty @retryable ({}) leaves this false — retryable but not throttling.
    [JsonPropertyName("throttling")]
    public bool Throttling { get; init; }
}

/// <remarks><see href="https://smithy.io/2.0/spec/behavior-traits.html#paginated-trait" /></remarks>
public record PaginatedTrait : TraitRecord
{
    [JsonPropertyName("inputToken")]
    public string? InputToken { get; init; }

    [JsonPropertyName("outputToken")]
    public string? OutputToken { get; init; }

    [JsonPropertyName("items")]
    public string? Items { get; init; }

    [JsonPropertyName("pageSize")]
    public string? PageSize { get; init; }
}
