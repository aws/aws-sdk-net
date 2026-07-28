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
/// A resource groups lifecycle and instance operations under an identifier. The generator
/// flattens resources: their operations are collected into the service's operation list and
/// the resource itself is never emitted.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/service-types.html#resource" /></remarks>
public record ResourceShape : Shape
{
    public override string Type => "resource";

    [JsonPropertyName("operations")]
    [JsonConverter(typeof(ShapeTargetListConverter))]
    public List<ShapeId> Operations { get; init; } = [];

    [JsonPropertyName("collectionOperations")]
    [JsonConverter(typeof(ShapeTargetListConverter))]
    public List<ShapeId> CollectionOperations { get; init; } = [];

    [JsonPropertyName("create")]
    [JsonConverter(typeof(ShapeTargetConverter))]
    public ShapeId? Create { get; init; }

    [JsonPropertyName("put")]
    [JsonConverter(typeof(ShapeTargetConverter))]
    public ShapeId? Put { get; init; }

    [JsonPropertyName("read")]
    [JsonConverter(typeof(ShapeTargetConverter))]
    public ShapeId? Read { get; init; }

    [JsonPropertyName("update")]
    [JsonConverter(typeof(ShapeTargetConverter))]
    public ShapeId? Update { get; init; }

    [JsonPropertyName("delete")]
    [JsonConverter(typeof(ShapeTargetConverter))]
    public ShapeId? Delete { get; init; }

    [JsonPropertyName("list")]
    [JsonConverter(typeof(ShapeTargetConverter))]
    public ShapeId? List { get; init; }

    [JsonPropertyName("resources")]
    [JsonConverter(typeof(ShapeTargetListConverter))]
    public List<ShapeId> Resources { get; init; } = [];

    /// <summary>
    /// Every operation the resource contributes, in the order: <see cref="Operations"/>,
    /// <see cref="CollectionOperations"/>, then the lifecycle operations (create, put, read,
    /// update, delete, list). Nested <see cref="Resources"/> are walked by the caller.
    /// </summary>
    public IEnumerable<ShapeId> AllOperations()
    {
        foreach (var id in Operations)
        {
            yield return id;
        }

        foreach (var id in CollectionOperations)
        {
            yield return id;
        }

        foreach (var id in new[] { Create, Put, Read, Update, Delete, List })
        {
            if (id is not null)
            {
                yield return id;
            }
        }
    }
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
