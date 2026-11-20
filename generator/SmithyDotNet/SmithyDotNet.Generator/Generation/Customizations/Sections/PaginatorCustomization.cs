using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// A <c>paginators</c> entry, spelled like <c>@paginated</c>. It supplies what the model lacks: <c>items</c> (dotted paths
/// allowed, one enumerable each) are added to the modeled one, and a field the trait already has fails generation.
/// The tokens are arrays because some operations page on several members at once (Route 53 ListResourceRecordSets).
/// </summary>
public sealed record PaginatorCustomization
{
    [JsonPropertyName("inputToken")]
    public List<string>? InputToken { get; init; }

    [JsonPropertyName("outputToken")]
    public List<string>? OutputToken { get; init; }

    [JsonPropertyName("pageSize")]
    public string? PageSize { get; init; }

    [JsonPropertyName("items")]
    public List<string>? Items { get; init; }
}
