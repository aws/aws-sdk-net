using System.Text.Json;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Model.Traits;

/// <summary>
/// Shared helpers for safely reading values from trait JSON elements.
/// </summary>
internal static class TraitHelpers
{
    /// <summary>
    /// Looks up a trait by ID on a shape and returns its value as a string,
    /// or <c>null</c> if the trait is absent or not a string.
    /// </summary>
    internal static string? GetStringTrait(Shape shape, string traitId) =>
        shape.Traits.TryGetValue(traitId, out var value) && value.ValueKind == JsonValueKind.String
            ? value.GetString()
            : null;

    /// <summary>
    /// Looks up a trait by ID on a shape and deserializes its value into <typeparamref name="T"/>,
    /// or returns <c>null</c> if the trait is absent.
    /// </summary>
    internal static T? DeserializeTrait<T>(Shape shape, string traitId) where T : class =>
        shape.Traits.TryGetValue(traitId, out var value)
            ? value.Deserialize<T>()
            : null;
}
