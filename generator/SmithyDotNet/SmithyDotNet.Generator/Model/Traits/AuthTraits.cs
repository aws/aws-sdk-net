using System.Text.Json;
using SmithyDotNet.Generator.Model.Shapes;

namespace SmithyDotNet.Generator.Model.Traits;

/// <summary>
/// Reads the modeled authentication schemes a shape declares. A service shape lists the schemes
/// supported across the API; an operation shape may override that list for itself. The values are
/// Smithy auth-scheme shape IDs in declared order (e.g. <c>aws.auth#sigv4</c>, <c>smithy.api#noAuth</c>).
/// </summary>
/// <remarks><see href="https://smithy.io/2.0/spec/authentication-traits.html#smithy-api-auth-trait" /></remarks>
public static class AuthTraits
{
    /// <summary>
    /// Returns the auth-scheme shape IDs from the shape's <c>smithy.api#auth</c> trait in declared
    /// order, or <c>null</c> when the trait is absent. An empty array (the modeled form of "no auth")
    /// yields an empty list, distinct from <c>null</c> ("not modeled").
    /// </summary>
    public static IReadOnlyList<string>? GetAuthSchemes(this Shape shape)
    {
        if (!shape.Traits.TryGetValue("smithy.api#auth", out var value) || value.ValueKind != JsonValueKind.Array)
        {
            return null;
        }

        var schemes = new List<string>(value.GetArrayLength());
        foreach (var element in value.EnumerateArray())
        {
            if (element.ValueKind == JsonValueKind.String && element.GetString() is { } scheme)
            {
                schemes.Add(scheme);
            }
        }

        return schemes;
    }
}
