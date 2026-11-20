using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>A <c>runtimePipelineOverride</c> entry: its <c>overrides</c> are applied in order.</summary>
public sealed record RuntimePipelineOverride
{
    // Nullable because "overrides": null deserializes fine; the loader rejects it.
    [JsonPropertyName("overrides")]
    public List<PipelineOverride>? Overrides { get; init; }
}

/// <summary>Adds a <see cref="NewType"/> handler before or after the pipeline's <see cref="TargetType"/> handler, or replaces it.</summary>
public sealed record PipelineOverride
{
    public const string AddBefore = "addBefore";
    public const string AddAfter = "addAfter";
    public const string Replace = "replace";

    /// <summary><see cref="AddBefore"/>, <see cref="AddAfter"/> or <see cref="Replace"/>; the loader rejects anything else.</summary>
    // TODO: C2J also has add and remove; no service uses them, so the loader rejects them.
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    [JsonPropertyName("targetType")]
    public required string TargetType { get; init; }

    [JsonPropertyName("newType")]
    public required string NewType { get; init; }

    /// <summary>C# arguments for the <see cref="NewType"/> constructor, emitted verbatim (e.g. <c>this.Config</c>).</summary>
    [JsonPropertyName("constructorInput")]
    public string? ConstructorInput { get; init; }

    /// <summary>A C# condition the override runs under, emitted verbatim (e.g. <c>this.Config.RetryMode == RequestRetryMode.Standard</c>).</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; init; }
}
