using SmithyDotNet.Generator.Model.Shapes;
using static SmithyDotNet.Generator.Model.Traits.TraitHelpers;

namespace SmithyDotNet.Generator.Model.Traits;

/// <summary>
/// Extension methods for Smithy traits that carry a single scalar value (string, int, etc.).
/// </summary>
public static class ScalarTraits
{
    /// <remarks><see href="https://smithy.io/2.0/spec/documentation-traits.html#documentation-trait" /></remarks>
    public static string? GetDocumentation(this Shape shape) => GetStringTrait(shape, "smithy.api#documentation");

    /// <remarks><see href="https://smithy.io/2.0/spec/documentation-traits.html#title-trait" /></remarks>
    public static string? GetTitle(this Shape shape) => GetStringTrait(shape, "smithy.api#title");

    /// <remarks><see href="https://smithy.io/2.0/spec/http-bindings.html#httpquery-trait" /></remarks>
    public static string? GetHttpQuery(this Shape shape) => GetStringTrait(shape, "smithy.api#httpQuery");

    /// <remarks><see href="https://smithy.io/2.0/spec/constraint-traits.html#pattern-trait" /></remarks>
    public static string? GetPattern(this Shape shape) => GetStringTrait(shape, "smithy.api#pattern");
}
