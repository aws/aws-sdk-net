using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Model.Traits;

/// <summary>
/// Extension methods for Smithy annotation traits — structure traits with no members
/// whose value is always <c>{}</c>. These are simple presence checks.
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/model.html#annotation-trait" /></remarks>
public static class AnnotationTraits
{
    /// <remarks><see href="https://smithy.io/2.0/spec/type-refinement-traits.html#required-trait" /></remarks>
    public static bool IsRequired(this Shape shape) => shape.Traits.ContainsKey("smithy.api#required");

    /// <remarks><see href="https://smithy.io/2.0/spec/type-refinement-traits.html#input-trait" /></remarks>
    public static bool IsInput(this Shape shape) => shape.Traits.ContainsKey("smithy.api#input");

    /// <remarks><see href="https://smithy.io/2.0/spec/type-refinement-traits.html#output-trait" /></remarks>
    public static bool IsOutput(this Shape shape) => shape.Traits.ContainsKey("smithy.api#output");

    /// <remarks><see href="https://smithy.io/2.0/spec/type-refinement-traits.html#error-trait" /></remarks>
    public static bool IsError(this Shape shape) => shape.Traits.ContainsKey("smithy.api#error");

    /// <remarks><see href="https://smithy.io/2.0/spec/http-bindings.html#httplabel-trait" /></remarks>
    public static bool IsHttpLabel(this Shape shape) => shape.Traits.ContainsKey("smithy.api#httpLabel");

    /// <remarks><see href="https://smithy.io/2.0/spec/http-bindings.html#httppayload-trait" /></remarks>
    public static bool IsHttpPayload(this Shape shape) => shape.Traits.ContainsKey("smithy.api#httpPayload");
}
