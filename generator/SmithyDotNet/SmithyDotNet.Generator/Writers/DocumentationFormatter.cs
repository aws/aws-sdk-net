using System.Text;
using System.Text.RegularExpressions;

namespace SmithyDotNet.Generator.Writers;

/// <summary>
/// Transforms a Smithy <c>@documentation</c> HTML string into the XML-doc body text the
/// AWS SDK for .NET emits. 
/// <para />
/// Port of the existing C2J generator's <c>CleanupDocumentation</c> / <c>RemoveSnippets</c> / 
/// <c>WriteCommentBlock</c> (<c>ServiceClientGeneratorLib/Generators/BaseGenerator.cs</c>) so
/// doc-comment content matches the current SDK.
/// </summary>
public static partial class DocumentationFormatter
{
    /// <summary>
    /// Removes unnecessary tags from the documentation and formats paragraph tags correctly.
    /// Returns the cleaned body with embedded <c>\n</c> line separators (NOT prefixed with
    /// <c>/// </c>), or <see cref="string.Empty"/> for null/empty input.
    /// </summary>
    public static string Cleanup(string? documentation)
    {
        if (string.IsNullOrEmpty(documentation))
        {
            return string.Empty;
        }

        // Collapse authoring whitespace (newlines + indentation in the source doc) to single
        // spaces. The meaningful line breaks (<para> blocks) are inserted further down, after
        // this runs.
        documentation = WhitespaceRegex().Replace(documentation, " ");

        // The "<code>" tag means something different in XML docs (multiple lines); replace with "<c>".
        documentation = documentation
            .Replace("<code>", "<c>")
            .Replace("</code>", "</c>");

        documentation = documentation
            .Replace("<br>", "")
            .Replace("<p>", "\n<para>\n")
            .Replace("</p>", "\n</para>\n")
            .Replace("<fullname>", "")
            .Replace("</fullname>", "")
            .Replace("<function>", "")
            .Replace("</function>", "")
            .Replace("<p/>", "")
            .Trim();

        documentation = PTagRegex().Replace(documentation, "\n<para>\n");
        documentation = TagsRegex().Replace(documentation, "");

        // Remove examples because these will be wire protocol examples.
        documentation = RemoveSnippets(documentation, "<examples>", "</examples>");

        // Remove commented out documentation.
        documentation = RemoveSnippets(documentation, "<!--", "-->");
        documentation = RemoveSnippets(documentation, "<!--", "-->");

        // Remove the first para tags since it is just the first paragraph in the summary.
        // This also cleans up documentation that only contains one para block.
        if (documentation.StartsWith("<para>", StringComparison.Ordinal))
        {
            var closePos = documentation.IndexOf("</para>", StringComparison.Ordinal);
            if (closePos < 0)
            {
                throw new GeneratorException($"Documentation is missing closing tag (ie </p> or </para>): {documentation}");
            }

            var firstParaContent = documentation["<para>".Length..closePos];
            documentation = firstParaContent + documentation[(closePos + "</para>".Length)..];
        }

        // Insert line breaks around 80 character line length.
        var sb = new StringBuilder();
        var currentLineLength = 0;
        foreach (var c in documentation)
        {
            if (c == '\n')
            {
                currentLineLength = 0;
                sb.Append(c);
            }
            else if (c == ' ' && currentLineLength > 80)
            {
                currentLineLength = 0;
                sb.Append('\n');
            }
            else
            {
                currentLineLength++;
                sb.Append(c);
            }
        }

        return sb.ToString().Trim();
    }

    /// <summary>
    /// Writes each line of a cleaned documentation block as a <c>/// {line}</c> comment.
    /// Indentation is supplied by the writer's current block depth.
    /// </summary>
    public static void WriteCommentBlock(CodeWriter writer, string cleanedBlock)
    {
        foreach (var line in cleanedBlock.Split('\n'))
        {
            writer.WriteLine($"/// {line}");
        }
    }

    private static string RemoveSnippets(string documentation, string startToken, string endToken)
    {
        var startPos = documentation.IndexOf(startToken, StringComparison.Ordinal);
        while (startPos != -1)
        {
            var closePos = documentation.IndexOf(endToken, startPos, StringComparison.Ordinal);
            documentation = documentation[..startPos] + documentation[(closePos + endToken.Length)..];
            startPos = documentation.IndexOf(startToken, StringComparison.Ordinal);
        }

        return documentation;
    }

    // Matches runs of whitespace (incl. the source doc's newlines and indentation).
    [GeneratedRegex(@"\s+")]
    private static partial Regex WhitespaceRegex();

    // "<p [^>]*>" matches a <p> tag carrying extra attributes (e.g. <p class='title'>).
    [GeneratedRegex("<p [^>]*>")]
    private static partial Regex PTagRegex();

    // Strips <fullname>, <function>, and <br> tags that carry attributes (the .Replace calls above only match the bare forms).
    [GeneratedRegex("<fullname [^>]*>|<function [^>]*>|<br [^>]*>")]
    private static partial Regex TagsRegex();
}
