using System.Xml.Linq;

using Xunit;

using SDKDocGenerator;

namespace SDKDocGenerator.UnitTests
{
    // <summary>/<para> map to <div class="doc-para"> (block) rather than <p>, because their
    // content may include block-level <note>/<important> noteblocks — a <div> inside a <p> is
    // invalid HTML and browsers auto-close the <p>, leaving stray empty paragraphs. The
    // "doc-para" class restores paragraph spacing. These expectations track that mapping
    // (see NdocToHtmlElementMapping / NdocToHtmlClassMapping in NDocUtilities).
    public class NDocUtilitiesHtmlTests
    {
        private static string TransformSummary(string innerXml)
        {
            var xml = $"<doc><summary>{innerXml}</summary></doc>";
            var element = XElement.Parse(xml);
            return NDocUtilities.TransformDocumentationToHTML(element, "summary", null, FrameworkVersion.DotNet472);
        }

        [Fact]
        public void ImportantTag_RendersAsWarningNoteblock()
        {
            var result = TransformSummary("<important><para>text</para></important>");

            Assert.Equal(
                "<div class=\"doc-para\"><div class=\"noteblock noteblock-warning\"><div class=\"doc-para\">text</div></div></div>",
                result);
        }

        [Fact]
        public void NoteTag_RendersAsNoteblock()
        {
            var result = TransformSummary("<note><para>text</para></note>");

            Assert.Equal(
                "<div class=\"doc-para\"><div class=\"noteblock\"><div class=\"doc-para\">text</div></div></div>",
                result);
        }

        [Fact]
        public void ParaTag_RendersAsDocParaBlock()
        {
            var result = TransformSummary("<para>text</para>");

            Assert.Equal("<div class=\"doc-para\"><div class=\"doc-para\">text</div></div>", result);
        }

        [Fact]
        public void SelfClosingImportantTag_ProducesEmptyWarningNoteblock()
        {
            var result = TransformSummary("<important />");

            // Empty elements must emit a full end tag (<div></div>), not the XML
            // self-closing form (<div/>) — an HTML parser treats <div/> as an unclosed
            // start tag that swallows following siblings. See NDocUtilities self-closing
            // branch (WriteFullEndElement).
            Assert.Equal(
                "<div class=\"doc-para\"><div class=\"noteblock noteblock-warning\"></div></div>",
                result);
        }

        [Fact]
        public void EmptyPara_EmitsFullEndTagNotSelfClosingDiv()
        {
            // An empty <para/> is extremely common in the SDK doc XML. It must render as
            // <div class="doc-para"></div> (full end tag), never the XML self-closing
            // <div class="doc-para" /> — an HTML parser treats <div/> as an unclosed tag
            // that swallows following siblings, mis-nesting the rest of the block.
            var result = TransformSummary("<para/>");

            Assert.Equal(
                "<div class=\"doc-para\"><div class=\"doc-para\"></div></div>",
                result);
            Assert.DoesNotContain("/>", result);
        }

        [Fact]
        public void EmptyParaWithEndTag_EmitsFullEndTagNotSelfClosingDiv()
        {
            // <para></para> (empty but NOT self-closing) also collapses to <div/> via
            // XmlWriter.WriteEndElement unless forced to a full end tag. This is the form
            // that actually appears in the SDK XML (e.g. an empty <para></para> after a list).
            var result = TransformSummary("<para></para>");

            Assert.Equal(
                "<div class=\"doc-para\"><div class=\"doc-para\"></div></div>",
                result);
            Assert.DoesNotContain("/>", result);
        }

        [Fact]
        public void AnchorWithNameOnly_IsPreservedAsAnchorBookmark()
        {
            // <a name="foo"> is an in-page bookmark target; keep it as <a> (a `name`
            // attribute only creates a fragment target on an anchor, not on a <span>).
            var result = TransformSummary("<a name=\"foo\">bookmark</a>");

            Assert.Equal(
                "<div class=\"doc-para\"><a name=\"foo\">bookmark</a></div>",
                result);
        }

        [Fact]
        public void AnchorWithNeitherHrefNorName_BecomesSpan()
        {
            // A bare <a> with no cref, href, or name is not a real link — render as <span>
            // so nothing looks clickable but dead.
            var result = TransformSummary("<a>text</a>");

            Assert.Equal(
                "<div class=\"doc-para\"><span>text</span></div>",
                result);
        }

        [Fact]
        public void ImportantTagWithInnerMarkup_PreservesNestedElements()
        {
            var result = TransformSummary("<important><para>Use <c>X</c> instead.</para></important>");

            Assert.Equal(
                "<div class=\"doc-para\"><div class=\"noteblock noteblock-warning\"><div class=\"doc-para\">Use <c>X</c> instead.</div></div></div>",
                result);
        }

        [Fact]
        public void NoteTagWithTypeAttribute_PreservesAttribute()
        {
            var result = TransformSummary("<note type=\"caution\"><para>Be careful.</para></note>");

            Assert.Equal(
                "<div class=\"doc-para\"><div class=\"noteblock\" type=\"caution\"><div class=\"doc-para\">Be careful.</div></div></div>",
                result);
        }

        [Fact]
        public void BulletList_RendersAsUnorderedList()
        {
            var result = TransformSummary("<list type=\"bullet\"><item><description>text</description></item></list>");

            Assert.Equal(
                "<div class=\"doc-para\"><ul><li><span>text</span></li></ul></div>",
                result);
        }

        [Fact]
        public void NumberedList_RendersAsOrderedList()
        {
            var result = TransformSummary("<list type=\"number\"><item><description>first</description></item></list>");

            Assert.Equal(
                "<div class=\"doc-para\"><ol><li><span>first</span></li></ol></div>",
                result);
        }

        [Fact]
        public void ListWithTermAndDescription_RendersBoth()
        {
            var result = TransformSummary("<list type=\"bullet\"><item><term>T</term><description>D</description></item></list>");

            Assert.Equal(
                "<div class=\"doc-para\"><ul><li><span>T</span><span>D</span></li></ul></div>",
                result);
        }

        [Fact]
        public void ListDefaultsToUnorderedList()
        {
            var result = TransformSummary("<list><item><description>text</description></item></list>");

            Assert.Equal(
                "<div class=\"doc-para\"><ul><li><span>text</span></li></ul></div>",
                result);
        }
    }
}
