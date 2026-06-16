using System.Text.Json.Serialization;
using SmithyDotNet.Generator.Model.Converters;

namespace SmithyDotNet.Generator.Model.Shapes;

/// <summary>
/// Entry point for a Smithy service model. Defines the API version, operations, and resources.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/service-types.html#service" /></remarks>
public record ServiceShape : Shape
{
    public override string Type => "service";

    [JsonPropertyName("version")]
    public required string ApiVersion { get; init; }

    [JsonPropertyName("operations")]
    [JsonConverter(typeof(ShapeTargetListConverter))]
    public List<ShapeId> Operations { get; init; } = [];

    [JsonPropertyName("resources")]
    [JsonConverter(typeof(ShapeTargetListConverter))]
    public List<ShapeId> Resources { get; init; } = [];

    [JsonPropertyName("errors")]
    [JsonConverter(typeof(ShapeTargetListConverter))]
    public List<ShapeId> Errors { get; init; } = [];
}

/// <summary>
/// A single API operation with input, output, and error shapes.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/service-types.html#operation" /></remarks>
public record OperationShape : Shape
{
    public override string Type => "operation";

    [JsonPropertyName("input")]
    [JsonConverter(typeof(ShapeTargetConverter))]
    public ShapeId Input { get; init; } = ShapeId.Unit;

    [JsonPropertyName("output")]
    [JsonConverter(typeof(ShapeTargetConverter))]
    public ShapeId Output { get; init; } = ShapeId.Unit;

    [JsonPropertyName("errors")]
    [JsonConverter(typeof(ShapeTargetListConverter))]
    public List<ShapeId> Errors { get; init; } = [];
}
