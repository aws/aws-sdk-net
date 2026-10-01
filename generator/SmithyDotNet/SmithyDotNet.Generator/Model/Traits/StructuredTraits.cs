using System.Text.Json;
using System.Text.Json.Serialization;
using SmithyDotNet.Generator.Model.Shapes;
using static SmithyDotNet.Generator.Model.Traits.TraitHelpers;

namespace SmithyDotNet.Generator.Model.Traits;

/// <summary>
/// Extension methods for Smithy traits that return a typed record.
/// Each accessor returns a record, or <c>null</c> if the trait is not present.
/// </summary>
public static class StructuredTraits
{
    private static readonly JsonSerializerOptions DeprecatedWriteOptions = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };

    /// <remarks><see href="https://smithy.io/2.0/spec/type-refinement-traits.html#error-trait" /></remarks>
    public static ErrorTrait? GetError(this Shape shape)
    {
        if (GetStringTrait(shape, "smithy.api#error") is not string error)
        {
            return null;
        }

        return new ErrorTrait(error);
    }

    /// <remarks><see href="https://smithy.io/2.0/spec/http-bindings.html#http-trait" /></remarks>
    public static HttpTrait? GetHttp(this Shape shape) => DeserializeTrait<HttpTrait>(shape, "smithy.api#http");

    /// <remarks><see href="https://smithy.io/2.0/spec/endpoint-traits.html#endpoint-trait" /></remarks>
    public static EndpointTrait? GetEndpoint(this Shape shape) => DeserializeTrait<EndpointTrait>(shape, "smithy.api#endpoint");

    /// <remarks><see href="https://smithy.io/2.0/spec/constraint-traits.html#length-trait" /></remarks>
    public static LengthTrait? GetLength(this Shape shape) => DeserializeTrait<LengthTrait>(shape, "smithy.api#length");

    /// <remarks><see href="https://smithy.io/2.0/spec/constraint-traits.html#range-trait" /></remarks>
    public static RangeTrait? GetRange(this Shape shape) => DeserializeTrait<RangeTrait>(shape, "smithy.api#range");

    /// <remarks><see href="https://smithy.io/2.0/spec/documentation-traits.html#deprecated-trait" /></remarks>
    public static DeprecatedTrait? GetDeprecated(this Shape shape) => DeserializeTrait<DeprecatedTrait>(shape, "smithy.api#deprecated");

    /// <summary>
    /// Sets the <c>@deprecated</c> message from the C2J <c>deprecatedMessage</c> customization so the
    /// writers emit <c>[Obsolete]</c> unaware of it, preserving an existing <c>since</c>. C2J gates
    /// <c>[Obsolete]</c> on the model's deprecated flag and uses the customization only for the text, so
    /// a message on a shape that is not already <c>@deprecated</c> is dead there - this no-ops rather
    /// than creating a deprecation C2J never emits.
    /// </summary>
    public static void SetDeprecatedMessage(this Shape shape, string message)
    {
        if (shape.GetDeprecated() is not { } deprecated)
        {
            return;
        }

        shape.Traits["smithy.api#deprecated"] = JsonSerializer.SerializeToElement(deprecated with { Message = message }, DeprecatedWriteOptions);
    }

    /// <remarks><see href="https://smithy.io/2.0/spec/behavior-traits.html#retryable-trait" /></remarks>
    public static RetryableTrait? GetRetryable(this Shape shape) => DeserializeTrait<RetryableTrait>(shape, "smithy.api#retryable");

    /// <remarks><see href="https://smithy.io/2.0/spec/behavior-traits.html#paginated-trait" /></remarks>
    public static PaginatedTrait? GetPaginated(this Shape shape) => DeserializeTrait<PaginatedTrait>(shape, "smithy.api#paginated");

    /// <remarks><see href="https://smithy.io/2.0/spec/behavior-traits.html#requestcompression-trait" /></remarks>
    public static RequestCompressionTrait? GetRequestCompression(this Shape shape) =>
        DeserializeTrait<RequestCompressionTrait>(shape, "smithy.api#requestCompression");
}
