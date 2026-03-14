using System.Xml.Linq;

using Xunit;

using SDKDocGenerator;

namespace SDKDocGenerator.UnitTests
{
    public class NDocUtilitiesHtmlTests
    {
        private static string TransformSummary(string innerXml)
        {
            var xml = $"<doc><summary>{innerXml}</summary></doc>";
            var element = XElement.Parse(xml);
            return NDocUtilities.TransformDocumentationToHTML(element, "summary", null, FrameworkVersion.DotNet472);
        }

        [Fact]
        public void ImportantTag_RendersAsNoteblock()
        {
            var result = TransformSummary("<important><para>text</para></important>");

            Assert.Equal(
                "<p><div class=\"noteblock\"><div class=\"noteheader\">Important:</div><p>text</p></div></p>",
                result);
        }

        [Fact]
        public void NoteTag_RendersAsNoteblock()
        {
            var result = TransformSummary("<note><para>text</para></note>");

            Assert.Equal(
                "<p><div class=\"noteblock\"><div class=\"noteheader\">Note:</div><p>text</p></div></p>",
                result);
        }

        [Fact]
        public void ParaTag_StillRendersAsParagraph()
        {
            var result = TransformSummary("<para>text</para>");

            Assert.Equal("<p><p>text</p></p>", result);
        }

        [Fact]
        public void SelfClosingImportantTag_ProducesEmptyNoteblock()
        {
            var result = TransformSummary("<important />");

            Assert.Equal(
                "<p><div class=\"noteblock\"><div class=\"noteheader\">Important:</div></div></p>",
                result);
        }

        [Fact]
        public void ImportantTagWithInnerMarkup_PreservesNestedElements()
        {
            var result = TransformSummary("<important><para>Use <c>X</c> instead.</para></important>");

            Assert.Equal(
                "<p><div class=\"noteblock\"><div class=\"noteheader\">Important:</div><p>Use <c>X</c> instead.</p></div></p>",
                result);
        }
    }
}
