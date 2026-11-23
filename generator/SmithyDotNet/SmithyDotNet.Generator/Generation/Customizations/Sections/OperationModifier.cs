using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>An <c>operationModifiers</c> entry, keyed by operation name.</summary>
public sealed record OperationModifier
{
    /// <summary>
    /// The operation's C# name: client methods, request/response classes and marshallers. restXml and restJson1 only, as
    /// their wire carries no operation name. <c>simpleMethods</c>, <c>noArgOverloads</c> and <c>simpleConstructors</c> key the
    /// operation by this name, as C2J does; every other hook keys the modeled one.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>The operation's <c>@documentation</c> instead of the modeled one (S3's GetBucketReplication).</summary>
    [JsonPropertyName("documentation")]
    public string? Documentation { get; init; }

    /// <summary>The <c>[Obsolete]</c> message for the operation's client methods; applied only when the operation is already <c>@deprecated</c>.</summary>
    [JsonPropertyName("deprecatedMessage")]
    public string? DeprecatedMessage { get; init; }

    /// <summary>
    /// Stop paginating when the response's token equals the token sent, instead of when it is empty. CloudWatch Logs
    /// GetLogEvents never returns an empty <c>nextForwardToken</c>: at the end of the stream it repeats the one sent.
    /// </summary>
    [JsonPropertyName("stopPaginationOnSameToken")]
    public bool StopPaginationOnSameToken { get; init; }

    /// <summary>Drops the operation, and with it the structures only it uses.</summary>
    [JsonPropertyName("exclude")]
    public bool Exclude { get; init; }

    /// <summary>
    /// Emits only the operation's client methods; its request/response classes, marshallers and the structures only it
    /// uses are hand-written (S3 <c>SelectObjectContent</c>). C2J: <c>S3ExcludeListOperations</c>.
    /// </summary>
    [JsonPropertyName("clientMethodOnly")]
    public bool ClientMethodOnly { get; init; }

    /// <summary>
    /// The response exposes the output, <c>wrappedResultShape</c>, as a single <c>wrappedResultMember</c> property
    /// instead of flattening its members.
    /// </summary>
    [JsonPropertyName("useWrappingResult")]
    public bool UseWrappingResult { get; init; }

    /// <summary>The name of the operation's output shape that <c>useWrappingResult</c> wraps.</summary>
    [JsonPropertyName("wrappedResultShape")]
    public string? WrappedResultShape { get; init; }

    /// <summary>The name of the response's single property that holds the wrapped output.</summary>
    [JsonPropertyName("wrappedResultMember")]
    public string? WrappedResultMember { get; init; }

    /// <summary>
    /// restXml-only (s3control): a successful empty-body response returns the response object without
    /// parsing the body, instead of running the XML result loop (which an empty body would make throw).
    /// </summary>
    [JsonPropertyName("allowEmptyResult")]
    public bool AllowEmptyResult { get; init; }

    /// <summary>
    /// The request marshaller sets no checksum data for the operation's modeled checksum; the service's hand-written
    /// code does (S3 PutObject and UploadPart).
    /// </summary>
    [JsonPropertyName("skipChecksumDuringMarshalling")]
    public bool SkipChecksumDuringMarshalling { get; init; }

    /// <summary>
    /// ec2Query-only: wire names for this operation's request, keyed by shape name then property name; they take
    /// precedence over every other naming rule.
    /// </summary>
    [JsonPropertyName("marshallNameOverrides")]
    public List<Dictionary<string, Dictionary<string, MarshallNameOverride>>> MarshallNameOverrides { get; init; } = [];
}

/// <summary>A <c>marshallNameOverrides</c> entry; C2J's <c>marshallLocationName</c> is rejected as no service uses it.</summary>
public sealed record MarshallNameOverride
{
    [JsonPropertyName("marshallName")]
    public required string MarshallName { get; init; }
}
