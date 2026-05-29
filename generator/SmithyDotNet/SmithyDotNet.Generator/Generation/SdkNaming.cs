using System.Text.RegularExpressions;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// Pure string transforms for deriving .NET SDK names from Smithy sdkId values.
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
        if (result.Length > 0)
        {
            result = char.ToUpperInvariant(result[0]) + result[1..];
        }

        return result;
    }

    [GeneratedRegex("[^a-zA-Z0-9]")]
    private static partial Regex AlphaNumericOnlyRegex();
}
