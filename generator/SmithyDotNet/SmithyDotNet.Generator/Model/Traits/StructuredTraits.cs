using SmithyDotNet.Generator.Model.Shapes;
using static SmithyDotNet.Generator.Model.Traits.TraitHelpers;

namespace SmithyDotNet.Generator.Model.Traits;

/// <summary>
/// Extension methods for Smithy traits that return a typed record.
/// Each accessor returns a record, or <c>null</c> if the trait is not present.
/// </summary>
public static class StructuredTraits
{
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

    /// <remarks><see href="https://smithy.io/2.0/spec/constraint-traits.html#length-trait" /></remarks>
    public static LengthTrait? GetLength(this Shape shape) => DeserializeTrait<LengthTrait>(shape, "smithy.api#length");
}
