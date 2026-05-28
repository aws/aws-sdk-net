using System.Text.Json;
using System.Text.Json.Serialization;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Model;

/// <summary>
/// Top-level Smithy JSON AST model containing version, shapes, and metadata.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/json-ast.html" /></remarks>
public record SmithyModel
{
    [JsonPropertyName("smithy")]
    public required string Version { get; init; }

    [JsonPropertyName("shapes")]
    public required Dictionary<string, Shape?> Shapes { get; init; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, JsonElement> Metadata { get; init; } = [];
}
