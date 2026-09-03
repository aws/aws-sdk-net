using System.Text;
using System.Text.RegularExpressions;

namespace SmithyDotNet.Generator.Generation;

/// <summary>
/// String transforms for deriving .NET SDK names from Smithy names.
/// </summary>
public static partial class SdkNaming
{
    // C2J splits an enum wire value on these separators, then capitalizes each token (SimpleModels.cs).
    // The first is an EN DASH (U+2013), not an ASCII hyphen; underscore is deliberately absent, so
    // 'SIGN_UP' stays a single token.
    private static readonly char[] EnumMemberSeparators =
        ['–', '-', '/', '.', ' ', ':', ',', '+', '&', '*'];

    /// <summary>
    /// Reproduces the C2J enum member-name munging (<c>SimpleModels.cs</c> <c>EnumEntry.PropertyName</c>):
    /// split the wire value on <see cref="EnumMemberSeparators"/> (dropping empty tokens), uppercase the
    /// first character of each token while preserving the remainder verbatim, then strip parentheses.
    /// <para />
    /// Examples: <c>amazon-web-services</c> → <c>AmazonWebServices</c>, <c>t2.micro</c> → <c>T2Micro</c>,
    /// <c>ec2 (deprecated)</c> → <c>Ec2deprecated</c>, <c>SIGN_UP</c> → <c>SIGN_UP</c>.
    /// </summary>
    public static string ToEnumMemberName(string wireValue)
    {
        var builder = new StringBuilder(wireValue.Length);
        foreach (var token in wireValue.Split(EnumMemberSeparators, StringSplitOptions.RemoveEmptyEntries))
        {
            builder.Append(char.ToUpperInvariant(token[0]));
            if (token.Length > 1)
            {
                builder.Append(token[1..]);
            }
        }

        return builder.Replace("(", string.Empty).Replace(")", string.Empty).ToString();
    }

    /// <summary>
    /// Reproduces C2J's <c>SanitizeStringForClassName</c>: removes every "AWS" and "Amazon"
    /// occurrence, removes non-alphanumeric chars, capitalizes the first char.
    /// </summary>
    public static string SanitizeClassName(string name)
    {
        var sanitized = name.Replace("AWS", string.Empty).Replace("Amazon", string.Empty);
        return ToUpperFirstCharacter(AlphaNumericOnlyRegex().Replace(sanitized, string.Empty));
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

    /// <summary>
    /// Resolves the service signing name: the <c>aws.auth#sigv4</c> name, falling back to the
    /// <c>aws.api#service</c> <c>arnNamespace</c>, then the lowercase service shape name. The
    /// <c>execute-api</c> arnNamespace takes precedence over the sigv4 name to preserve API Gateway
    /// signing.
    /// </summary>
    public static string ResolveSigningName(string shapeName, string? arnNamespace, string? sigV4Name)
    {
        if (arnNamespace == "execute-api")
        {
            return arnNamespace;
        }

        return sigV4Name ?? arnNamespace ?? shapeName.ToLowerInvariant();
    }

    [GeneratedRegex("[^a-zA-Z0-9]")]
    private static partial Regex AlphaNumericOnlyRegex();
}
