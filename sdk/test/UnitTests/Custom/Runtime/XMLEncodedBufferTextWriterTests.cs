#if !NETFRAMEWORK
using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdParty.RuntimeBackports;

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class XMLEncodedBufferTextWriterTests
    {
        [TestMethod]
        public void SimpleXml_ProducesSameBytes()
        {
            AssertBothXmlWritersProduceSameBytes(writer =>
            {
                writer.WriteStartElement("Root");
                writer.WriteElementString("Name", "hello");
                writer.WriteElementString("Value", "world");
                writer.WriteEndElement();
            });
        }

        [TestMethod]
        public void NewlineCharacter_IsEscaped()
        {
            var actual = AssertBothXmlWritersProduceSameBytes(writer =>
            {
                writer.WriteStartElement("Root");
                writer.WriteElementString("Text", "line1\nline2");
                writer.WriteEndElement();
            });

            var xml = Encoding.UTF8.GetString(actual);
            Assert.IsTrue(xml.Contains("&#xA;"), "Expected \\n to be escaped as &#xA;");
            Assert.IsFalse(xml.Contains("\n"), "Raw newline should not appear in output");
        }

        [TestMethod]
        public void NextLineCharacter_IsEscaped()
        {
            var actual = AssertBothXmlWritersProduceSameBytes(writer =>
            {
                writer.WriteStartElement("Root");
                writer.WriteElementString("Text", "before\u0085after");
                writer.WriteEndElement();
            });

            var xml = Encoding.UTF8.GetString(actual);
            Assert.IsTrue(xml.Contains("&#x85;"), "Expected \\u0085 to be escaped as &#x85;");
        }

        [TestMethod]
        public void LineSeparatorCharacter_IsEscaped()
        {
            var actual = AssertBothXmlWritersProduceSameBytes(writer =>
            {
                writer.WriteStartElement("Root");
                writer.WriteElementString("Text", "before\u2028after");
                writer.WriteEndElement();
            });

            var xml = Encoding.UTF8.GetString(actual);
            Assert.IsTrue(xml.Contains("&#x2028;"), "Expected \\u2028 to be escaped as &#x2028;");
        }

        [TestMethod]
        public void CarriageReturn_IsHandledByXmlWriter()
        {
            var actual = AssertBothXmlWritersProduceSameBytes(writer =>
            {
                writer.WriteStartElement("Root");
                writer.WriteElementString("Text", "before\rafter");
                writer.WriteEndElement();
            });

            var xml = Encoding.UTF8.GetString(actual);
            Assert.IsTrue(xml.Contains("&#xD;"), "Expected \\r to be escaped as &#xD; by XmlWriter");
        }

        [TestMethod]
        public void MultiByte_CJKCharacters_EncodeCorrectly()
        {
            AssertBothXmlWritersProduceSameBytes(writer =>
            {
                writer.WriteStartElement("Root");
                writer.WriteElementString("Name", "世界"); // 世界
                writer.WriteEndElement();
            });
        }

        [TestMethod]
        public void SurrogatePair_Emoji_EncodesCorrectly()
        {
            // U+1F389 (🎉) is encoded as surrogate pair 🎉
            var emoji = "🎉";
            var actual = AssertBothXmlWritersProduceSameBytes(writer =>
            {
                writer.WriteStartElement("Root");
                writer.WriteElementString("Emoji", emoji);
                writer.WriteEndElement();
            });

            // Verify the 4-byte UTF-8 sequence is present (F0 9F 8E 89)
            bool found = false;
            for (int i = 0; i < actual.Length - 3; i++)
            {
                if (actual[i] == 0xF0 && actual[i + 1] == 0x9F && actual[i + 2] == 0x8E && actual[i + 3] == 0x89)
                {
                    found = true;
                    break;
                }
            }
            Assert.IsTrue(found, "Expected 4-byte UTF-8 encoding of U+1F389");
        }

        [TestMethod]
        public void MixedContent_AllSpecialChars_MatchesStringWriter()
        {
            var text = "hello\nworld\r\u0085test\u2028end🎉";
            AssertBothXmlWritersProduceSameBytes(writer =>
            {
                writer.WriteStartElement("Root");
                writer.WriteElementString("Mixed", text);
                writer.WriteEndElement();
            });
        }

        [TestMethod]
        public void XmlAttributes_MatchStringWriter()
        {
            AssertBothXmlWritersProduceSameBytes(writer =>
            {
                writer.WriteStartElement("Root", "http://example.com/ns");
                writer.WriteAttributeString("id", "123");
                writer.WriteElementString("Child", "value");
                writer.WriteEndElement();
            });
        }

        [TestMethod]
        public void NestedElements_MatchStringWriter()
        {
            AssertBothXmlWritersProduceSameBytes(writer =>
            {
                writer.WriteStartElement("Delete", "http://s3.amazonaws.com/doc/2006-03-01/");
                for (int i = 0; i < 10; i++)
                {
                    writer.WriteStartElement("Object");
                    writer.WriteElementString("Key", $"path/to/object-{i:D4}.txt");
                    writer.WriteElementString("VersionId", $"ver-{i}");
                    writer.WriteEndElement();
                }
                writer.WriteElementString("Quiet", "true");
                writer.WriteEndElement();
            });
        }

        [TestMethod]
        public void EmptyElements_MatchStringWriter()
        {
            AssertBothXmlWritersProduceSameBytes(writer =>
            {
                writer.WriteStartElement("Root");
                writer.WriteElementString("Empty", "");
                writer.WriteStartElement("SelfClosing");
                writer.WriteEndElement();
                writer.WriteEndElement();
            });
        }

        [TestMethod]
        public void XmlSpecialCharacters_AmpLtGt_MatchStringWriter()
        {
            AssertBothXmlWritersProduceSameBytes(writer =>
            {
                writer.WriteStartElement("Root");
                writer.WriteElementString("Text", "a < b & c > d \"quoted\"");
                writer.WriteEndElement();
            });
        }

        [TestMethod]
        public void LargePayload_MatchesStringWriter()
        {
            var largeValue = new string('A', 100_000);

            AssertBothXmlWritersProduceSameBytes(writer =>
            {
                writer.WriteStartElement("Root");
                writer.WriteElementString("Data", largeValue);
                writer.WriteEndElement();
            });
        }

        private static byte[] AssertBothXmlWritersProduceSameBytes(Action<XmlWriter> writeAction)
        {
            var expected = SerializeViaStringWriter(writeAction);
            var actual = SerializeViaBufferWriter(writeAction);
            CollectionAssert.AreEqual(expected, actual);
            return actual;
        }

        private static XmlWriterSettings CreateSettings()
        {
            return new XmlWriterSettings
            {
                Encoding = Encoding.UTF8,
                OmitXmlDeclaration = true,
                NewLineHandling = NewLineHandling.Entitize
            };
        }

        private static byte[] SerializeViaStringWriter(Action<XmlWriter> writeAction)
        {
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, CreateSettings()))
            {
                writeAction(xmlWriter);
            }
            return Encoding.UTF8.GetBytes(stringWriter.ToString());
        }

        private static byte[] SerializeViaBufferWriter(Action<XmlWriter> writeAction)
        {
            var bufferWriter = new ArrayPoolBufferWriter<byte>();
            var textWriter = new XMLEncodedBufferTextWriter(bufferWriter);
            using (var xmlWriter = XmlWriter.Create(textWriter, CreateSettings()))
            {
                writeAction(xmlWriter);
            }
            var result = bufferWriter.WrittenMemory.ToArray();
            bufferWriter.Dispose();
            return result;
        }
    }
}
#endif
