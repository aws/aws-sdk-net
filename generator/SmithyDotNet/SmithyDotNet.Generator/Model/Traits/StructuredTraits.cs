using System.Text.Json;
using SmithyDotNet.Generator.Model.Shapes;

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
        if (!shape.Traits.TryGetValue("smithy.api#error", out var traitValue))
        {
            return null;
        }

        if (traitValue.ValueKind != JsonValueKind.String)
        {
            return null;
        }

        if (traitValue.GetString() is not string error)
        {
            return null;
        }

        return new ErrorTrait(error);
    }

    /// <remarks><see href="https://smithy.io/2.0/spec/http-bindings.html#http-trait" /></remarks>
    public static HttpTrait? GetHttp(this Shape shape)
    {
        if (!shape.Traits.TryGetValue("smithy.api#http", out var traitValue))
        {
            return null;
        }

        if (traitValue.ValueKind != JsonValueKind.Object)
        {
            return null;
        }

        if (GetString(traitValue, "method") is not string method)
        {
            return null;
        }

        if (GetString(traitValue, "uri") is not string uri)
        {
            return null;
        }

        var code = GetInt(traitValue, "code") ?? 200;
        return new HttpTrait(method, uri, code);
    }

    /// <remarks><see href="https://smithy.io/2.0/spec/constraint-traits.html#length-trait" /></remarks>
    public static LengthTrait? GetLength(this Shape shape)
    {
        if (!shape.Traits.TryGetValue("smithy.api#length", out var traitValue))
        {
            return null;
        }

        if (traitValue.ValueKind != JsonValueKind.Object)
        {
            return null;
        }

        var min = GetLong(traitValue, "min");
        var max = GetLong(traitValue, "max");
        return new LengthTrait(min, max);
    }

    /// <summary>
    /// Reads a string property from a JSON object, returning <c>null</c> if the property
    /// is missing or not a string.
    /// </summary>
    private static string? GetString(JsonElement parent, string property) =>
        parent.TryGetProperty(property, out var value) && value.ValueKind == JsonValueKind.String
            ? value.GetString()
            : null;

    /// <summary>
    /// Reads an integer property from a JSON object, returning <c>null</c> if the property
    /// is missing or not a number.
    /// </summary>
    private static int? GetInt(JsonElement parent, string property) =>
        parent.TryGetProperty(property, out var value) && value.TryGetInt32(out var result)
            ? result
            : null;

    /// <summary>
    /// Reads a long property from a JSON object, returning <c>null</c> if the property
    /// is missing or not a number.
    /// </summary>
    private static long? GetLong(JsonElement parent, string property) =>
        parent.TryGetProperty(property, out var value) && value.TryGetInt64(out var result)
            ? result
            : null;
}
