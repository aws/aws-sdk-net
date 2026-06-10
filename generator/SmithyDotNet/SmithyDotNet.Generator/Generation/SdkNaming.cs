using System.Text.RegularExpressions;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// String transforms for deriving .NET SDK names from Smithy names.
/// </summary>
public static partial class SdkNaming
{
    /// <summary>
    /// Normalizes an sdkId to a .NET class name component.
    /// Strips "AWS"/"Amazon" prefix, removes non-alphanumeric chars, capitalizes first char.
    /// </summary>
    public static string NormalizeSdkId(string sdkId)
    {
        var stripped = sdkId;
        if (stripped.StartsWith("AWS", StringComparison.Ordinal))
        {
            stripped = stripped[3..];
        }
        else if (stripped.StartsWith("Amazon", StringComparison.Ordinal))
        {
            stripped = stripped[6..];
        }

        var result = AlphaNumericOnlyRegex().Replace(stripped, string.Empty);
        return ToUpperFirstCharacter(result);
    }

    /// <summary>
    /// Returns the PascalCase .NET property name for a Smithy member name by uppercasing
    /// only the first character and preserving the remainder verbatim:
    /// <c>eventID</c> → <c>EventID</c>, <c>id</c> → <c>Id</c>, <c>eventData</c> → <c>EventData</c>.
    /// </summary>
    public static string ToUpperFirstCharacter(string name)
    {
        if (name.Length == 0)
        {
            return name;
        }

        return char.ToUpperInvariant(name[0]) + name[1..];
    }

    [GeneratedRegex("[^a-zA-Z0-9]")]
    private static partial Regex AlphaNumericOnlyRegex();
}
