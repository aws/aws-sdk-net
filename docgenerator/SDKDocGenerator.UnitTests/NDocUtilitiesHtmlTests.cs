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
        public void ImportantTag_RendersAsWarningNoteblock()
        {
            var result = TransformSummary("<important><para>text</para></important>");

            Assert.Equal(
                "<p><div class=\"noteblock noteblock-warning\"><p>text</p></div></p>",
                result);
        }

        [Fact]
        public void NoteTag_RendersAsNoteblock()
        {
            var result = TransformSummary("<note><para>text</para></note>");

            Assert.Equal(
                "<p><div class=\"noteblock\"><p>text</p></div></p>",
                result);
        }

        [Fact]
        public void ParaTag_StillRendersAsParagraph()
        {
            var result = TransformSummary("<para>text</para>");

            Assert.Equal("<p><p>text</p></p>", result);
        }

        [Fact]
        public void SelfClosingImportantTag_ProducesEmptyWarningNoteblock()
        {
            var result = TransformSummary("<important />");

            Assert.Equal(
                "<p><div class=\"noteblock noteblock-warning\" /></p>",
                result);
        }

        [Fact]
        public void ImportantTagWithInnerMarkup_PreservesNestedElements()
        {
            var result = TransformSummary("<important><para>Use <c>X</c> instead.</para></important>");

            Assert.Equal(
                "<p><div class=\"noteblock noteblock-warning\"><p>Use <c>X</c> instead.</p></div></p>",
                result);
        }

        [Fact]
        public void NoteTagWithTypeAttribute_PreservesAttribute()
        {
            var result = TransformSummary("<note type=\"caution\"><para>Be careful.</para></note>");

            Assert.Equal(
                "<p><div class=\"noteblock\" type=\"caution\"><p>Be careful.</p></div></p>",
                result);
        }

        [Fact]
        public void BulletList_RendersAsUnorderedList()
        {
            var result = TransformSummary("<list type=\"bullet\"><item><description>text</description></item></list>");

            Assert.Equal(
                "<p><ul><li><span>text</span></li></ul></p>",
                result);
        }

        [Fact]
        public void NumberedList_RendersAsOrderedList()
        {
            var result = TransformSummary("<list type=\"number\"><item><description>first</description></item></list>");

            Assert.Equal(
                "<p><ol><li><span>first</span></li></ol></p>",
                result);
        }

        [Fact]
        public void ListWithTermAndDescription_RendersBoth()
        {
            var result = TransformSummary("<list type=\"bullet\"><item><term>T</term><description>D</description></item></list>");

            Assert.Equal(
                "<p><ul><li><span>T</span><span>D</span></li></ul></p>",
                result);
        }

        [Fact]
        public void ListDefaultsToUnorderedList()
        {
            var result = TransformSummary("<list><item><description>text</description></item></list>");

            Assert.Equal(
                "<p><ul><li><span>text</span></li></ul></p>",
                result);
        }
    }
}
