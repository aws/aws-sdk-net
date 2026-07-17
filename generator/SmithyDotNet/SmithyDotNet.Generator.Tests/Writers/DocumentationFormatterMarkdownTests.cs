using System.Text.RegularExpressions;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

/// <summary>
/// Covers <see cref="DocumentationFormatter.ToMarkdown"/> for the closed set of tags that appear in
/// AWS service <c>@documentation</c> (p, a, code, b/strong, i/em, ul/ol/li, and the structural
/// wrappers fullname/note/important/dl/dt/dd/pre).
/// </summary>
public class DocumentationFormatterMarkdownTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void EmptyInputReturnsEmpty(string? input)
    {
        Assert.Equal(string.Empty, DocumentationFormatter.ToMarkdown(input));
    }

    [Fact]
    public void ConvertsInlineCode()
    {
        Assert.Equal("Call `PutAuditEvents` now.", DocumentationFormatter.ToMarkdown("Call <code>PutAuditEvents</code> now."));
    }

    [Fact]
    public void ConvertsBoldAndItalic()
    {
        Assert.Equal("**bold** and *italic*", DocumentationFormatter.ToMarkdown("<b>bold</b> and <i>italic</i>"));
        Assert.Equal("**strong** and *em*", DocumentationFormatter.ToMarkdown("<strong>strong</strong> and <em>em</em>"));
    }

    [Fact]
    public void ConvertsAnchorToMarkdownLink()
    {
        Assert.Equal(
            "See [the guide](https://docs.aws.amazon.com/).",
            DocumentationFormatter.ToMarkdown("""See <a href="https://docs.aws.amazon.com/">the guide</a>."""));
    }

    [Fact]
    public void ConvertsParagraphsToBlankLineSeparated()
    {
        Assert.Equal("First.\n\nSecond.", DocumentationFormatter.ToMarkdown("<p>First.</p><p>Second.</p>"));
    }

    [Fact]
    public void ConvertsListItemsToBullets()
    {
        var result = DocumentationFormatter.ToMarkdown("<ul><li>One</li><li>Two</li></ul>");
        Assert.Contains("- One", result);
        Assert.Contains("- Two", result);
    }

    [Fact]
    public void ConvertsListItemsWithoutClosingTags()
    {
        var result = DocumentationFormatter.ToMarkdown("<ul><li>One<li>Two</ul>");
        Assert.Contains("- One", result);
        Assert.Contains("- Two", result);
    }

    [Fact]
    public void FlattensBlockTagsNestedInListItems()
    {
        // Item text is commonly wrapped in <p>; the marker must stay on the same line as its text.
        var result = DocumentationFormatter.ToMarkdown("<ul><li><p>one</p></li><li><p>two</p></li></ul>");
        Assert.Equal("- one\n- two", result);
    }

    [Fact]
    public void UnwrapsStructuralTagsKeepingText()
    {
        Assert.Equal("Amazon Service", DocumentationFormatter.ToMarkdown("<fullname>Amazon Service</fullname>"));
        Assert.Equal("Heads up.", DocumentationFormatter.ToMarkdown("<note>Heads up.</note>"));
        Assert.Equal("Careful.", DocumentationFormatter.ToMarkdown("<important>Careful.</important>"));
    }

    [Fact]
    public void DecodesHtmlEntities()
    {
        Assert.Equal("a & b < c", DocumentationFormatter.ToMarkdown("a &amp; b &lt; c"));
    }

    [Fact]
    public void PreservesUnknownTagsAsLiteralText()
    {
        // An unrecognized tag is content, not markup — it must survive, not be stripped with its text.
        Assert.Equal("Use the <region> placeholder.", DocumentationFormatter.ToMarkdown("Use the <region> placeholder."));
    }

    [Fact]
    public void PreservesEncodedPlaceholdersInsideCode()
    {
        // Network Firewall docs embed a literal <region> placeholder as &lt;region&gt; inside <code>.
        // The reader should see the angle brackets; they are content, not markup.
        var result = DocumentationFormatter.ToMarkdown("<code>https://network-firewall.&lt;region&gt;.amazonaws.com</code>");
        Assert.Equal("`https://network-firewall.<region>.amazonaws.com`", result);
    }

    [Fact]
    public void RealisticServiceDocLeavesNoResidualTags()
    {
        // Mirrors the shape of an actual service description (CloudTrail Data), exercising p, code,
        // a, and nested inline tags together.
        const string doc =
            "<p>The CloudTrail Data Service lets you ingest events into CloudTrail from any source. " +
            "After you run <code>PutAuditEvents</code>, see the " +
            """<a href="https://docs.aws.amazon.com/">CloudTrail Lake</a> docs for <b>details</b>.</p>""";

        var result = DocumentationFormatter.ToMarkdown(doc);

        Assert.DoesNotMatch(new Regex("</?[a-zA-Z][^>]*>"), result);
        Assert.Contains("`PutAuditEvents`", result);
        Assert.Contains("[CloudTrail Lake](https://docs.aws.amazon.com/)", result);
        Assert.Contains("**details**", result);
    }
}
