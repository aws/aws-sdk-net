using System.Text.Json.Serialization;

namespace SmithyDotNet.Generator.Generation.Customizations;

/// <summary>
/// The Smithy-only <c>service</c> section: what hand-written code supplies instead of the generator, where C2J
/// branched on <c>ServiceId == "S3"</c>. Allowed in one customizations file per service.
/// </summary>
public sealed record ServiceCustomizations
{
    /// <summary><c>clientContextParams</c> whose config properties are hand-written (S3, S3 Control).</summary>
    [JsonPropertyName("skipClientContextParams")]
    public List<string> SkipClientContextParams { get; init; } = [];

    /// <summary>No doc samples from <c>smithy.api#examples</c>; S3's are hand-written.</summary>
    [JsonPropertyName("skipDocSamples")]
    public bool SkipDocSamples { get; init; }

    /// <summary>Replaces <c>Amazon{BaseName}Request</c> as the request base; S3's partials declare <c>AmazonWebServiceRequest</c>.</summary>
    [JsonPropertyName("requestBaseClass")]
    public string? RequestBaseClass { get; init; }

    /// <summary>Base for a response with a <c>@streaming</c> blob; the member is dropped and the unmarshaller assigns the base's <c>ResponseStream</c> (S3's <c>StreamResponse</c>).</summary>
    [JsonPropertyName("streamingResponseBaseClass")]
    public string? StreamingResponseBaseClass { get; init; }

    /// <summary>
    /// Hand-written error handling; the generated service exception is skipped (S3's <c>AmazonS3Exception</c> is
    /// hand-written). The parts only work together, so each is required.
    /// </summary>
    [JsonPropertyName("customErrorHandling")]
    public CustomErrorHandling? CustomErrorHandling { get; init; }

    /// <summary>
    /// Instance method the client's <c>Dispose(bool)</c> calls when <c>disposing</c>, before the base call
    /// (S3's <c>DisposeS3ExpressCredentialProvider</c>). Unlike the model-keyed hooks, a stale name here can't be
    /// validated — it resolves against hand-written code, so a typo surfaces as a compile error in the SDK.
    /// </summary>
    [JsonPropertyName("clientDisposeMethod")]
    public string? ClientDisposeMethod { get; init; }

    /// <summary>Emit <c>Amazon{BaseName}RetryPolicy</c> with the <c>RequestsWith200Error</c> list; only S3 consumes this today.</summary>
    [JsonPropertyName("retryPolicyRequestList")]
    public bool RetryPolicyRequestList { get; init; }

    /// <summary>
    /// Emit an empty <c>Generated/PropertyValueRules.xml</c> and also embed <c>Custom/PropertyValueRules.xml</c>
    /// in the code-analysis project (S3's rules are hand-maintained).
    /// </summary>
    [JsonPropertyName("customPropertyValueRules")]
    public bool CustomPropertyValueRules { get; init; }

    /// <summary>
    /// Emit the endpoint resolver as <c>partial</c> with two hooks the hand-written half must implement:
    /// <c>BeforeInjectHostPrefix</c> (S3's SigV2/KMS tweaks) and <c>TryMapNonGeneratedRequest</c>, which maps
    /// requests with no generated marshaller (S3's presigned URL/POST and ACL requests) and returns early.
    /// </summary>
    [JsonPropertyName("endpointResolverPartial")]
    public bool EndpointResolverPartial { get; init; }

    /// <summary>
    /// An <c>@httpLabel</c> the endpoint resolver adds to the URL (S3's <c>Bucket</c>). It is removed from
    /// <c>ResourcePath</c> and gets no <c>AddPathResource</c>; its required check stays.
    /// </summary>
    [JsonPropertyName("endpointResolvedLabel")]
    public string? EndpointResolvedLabel { get; init; }

    /// <summary>A greedy label's value is sent as is, so an S3 key can start with <c>/</c>; otherwise the leading <c>/</c> is trimmed.</summary>
    [JsonPropertyName("keepGreedyLabelLeadingSlash")]
    public bool KeepGreedyLabelLeadingSlash { get; init; }

    /// <summary>When set, an unset string label throws <c>ArgumentException</c>, as S3's C2J marshallers do; the listed operations keep the service exception.</summary>
    [JsonPropertyName("requiredLabelServiceExceptionOperations")]
    public List<string>? RequiredLabelServiceExceptionOperations { get; init; }
}

/// <summary>The <c>service.customErrorHandling</c> hook. Read by the restXml writers today.</summary>
public sealed record CustomErrorHandling
{
    /// <summary>
    /// Base for response unmarshallers (S3's <c>S3ReponseUnmarshaller</c>, sic: the shipped name). It unmarshalls the
    /// errors an operation doesn't model, so only an operation with modeled errors overrides <c>UnmarshallException</c>.
    /// </summary>
    [JsonPropertyName("responseUnmarshallerBaseClass")]
    public required string ResponseUnmarshallerBaseClass { get; init; }

    /// <summary>
    /// Error response parsed by its <c>{type}Unmarshaller</c> (S3's <c>S3ErrorResponse</c>); exceptions also take its
    /// <c>Id2</c> and <c>AmzCfId</c>, which the hand-written service exception accepts.
    /// </summary>
    [JsonPropertyName("errorResponseType")]
    public required string ErrorResponseType { get; init; }

    /// <summary>The base unmarshaller's method that builds the exception for an unmodeled error code (S3's <c>ConstructS3Exception</c>).</summary>
    [JsonPropertyName("exceptionFactory")]
    public required string ExceptionFactory { get; init; }
}
