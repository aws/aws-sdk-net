/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests for the byte, short and bigInteger types from the Full Numeric Type Support SEP.
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class NumericTypeMarshallingTests
    {
        // 50 digits, well beyond long and decimal.
        private const string HugePositive = "12345678901234567890123456789012345678901234567890";
        private const string HugeNegative = "-98765432109876543210987654321098765432109876543210";

        [TestMethod]
        [DataRow("0", (sbyte)0)]
        [DataRow("-128", sbyte.MinValue)]
        [DataRow("127", sbyte.MaxValue)]
        [DataRow("\"-5\"", (sbyte)-5)]
        public void JsonSByteInRange(string json, sbyte expected)
        {
            Assert.AreEqual(expected, UnmarshallJson(SByteUnmarshaller.Instance, json));
            Assert.AreEqual(expected, UnmarshallJson(NullableSByteUnmarshaller.Instance, json));
        }

        [TestMethod]
        [DataRow("128")]
        [DataRow("-129")]
        [DataRow("255")]
        [DataRow("\"128\"")]
        public void JsonSByteOutOfRangeThrows(string json)
        {
            Assert.ThrowsExactly<OverflowException>(() => UnmarshallJson(SByteUnmarshaller.Instance, json));
            Assert.ThrowsExactly<OverflowException>(() => UnmarshallJson(NullableSByteUnmarshaller.Instance, json));
        }

        [TestMethod]
        [DataRow("0", (short)0)]
        [DataRow("-32768", short.MinValue)]
        [DataRow("32767", short.MaxValue)]
        [DataRow("\"-5\"", (short)-5)]
        public void JsonShortInRange(string json, short expected)
        {
            Assert.AreEqual(expected, UnmarshallJson(ShortUnmarshaller.Instance, json));
            Assert.AreEqual(expected, UnmarshallJson(NullableShortUnmarshaller.Instance, json));
        }

        [TestMethod]
        [DataRow("32768")]
        [DataRow("-32769")]
        [DataRow("65535")]
        [DataRow("\"32768\"")]
        public void JsonShortOutOfRangeThrows(string json)
        {
            Assert.ThrowsExactly<OverflowException>(() => UnmarshallJson(ShortUnmarshaller.Instance, json));
            Assert.ThrowsExactly<OverflowException>(() => UnmarshallJson(NullableShortUnmarshaller.Instance, json));
        }

        [TestMethod]
        public void JsonNullValues()
        {
            Assert.IsNull(UnmarshallJson(NullableSByteUnmarshaller.Instance, "null"));
            Assert.IsNull(UnmarshallJson(NullableShortUnmarshaller.Instance, "null"));
            Assert.IsNull(UnmarshallJson(NullableBigIntegerUnmarshaller.Instance, "null"));
            Assert.AreEqual(BigInteger.Zero, UnmarshallJson(BigIntegerUnmarshaller.Instance, "null"));
        }

        [TestMethod]
        [DataRow("1.5")]
        [DataRow("1e2")]
        public void JsonFractionalOrExponentRejectedForIntegerTypes(string json)
        {
            Assert.ThrowsExactly<FormatException>(() => UnmarshallJson(SByteUnmarshaller.Instance, json));
            Assert.ThrowsExactly<FormatException>(() => UnmarshallJson(ShortUnmarshaller.Instance, json));
            Assert.ThrowsExactly<FormatException>(() => UnmarshallJson(BigIntegerUnmarshaller.Instance, json));
        }

        [TestMethod]
        [DataRow("0")]
        [DataRow("-1")]
        [DataRow(HugePositive)]
        [DataRow(HugeNegative)]
        // 2^53 + 1 is the first integer a double cannot represent.
        [DataRow("9007199254740993")]
        // One past ulong.MaxValue.
        [DataRow("18446744073709551616")]
        public void JsonBigIntegerKeepsAllDigits(string text)
        {
            var expected = BigInteger.Parse(text, CultureInfo.InvariantCulture);
            Assert.AreEqual(expected, UnmarshallJson(BigIntegerUnmarshaller.Instance, text));
            Assert.AreEqual(expected, UnmarshallJson(NullableBigIntegerUnmarshaller.Instance, text));
            Assert.AreEqual(expected, UnmarshallJson(BigIntegerUnmarshaller.Instance, "\"" + text + "\""));
            Assert.AreEqual(text, UnmarshallJson(BigIntegerUnmarshaller.Instance, text).ToString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        public void JsonBigIntegerWithHundredsOfDigits()
        {
            var text = "-" + new string('9', 400);
            Assert.AreEqual(text, UnmarshallJson(BigIntegerUnmarshaller.Instance, text).ToString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        public void XmlValuesInRange()
        {
            Assert.AreEqual(sbyte.MinValue, UnmarshallXml(SByteUnmarshaller.Instance, "-128"));
            Assert.AreEqual(sbyte.MaxValue, UnmarshallXml(SByteUnmarshaller.Instance, "127"));
            Assert.AreEqual(short.MinValue, UnmarshallXml(ShortUnmarshaller.Instance, "-32768"));
            Assert.AreEqual(short.MaxValue, UnmarshallXml(ShortUnmarshaller.Instance, "32767"));
            Assert.AreEqual(BigInteger.Parse(HugePositive, CultureInfo.InvariantCulture), UnmarshallXml(BigIntegerUnmarshaller.Instance, HugePositive));
            Assert.AreEqual(BigInteger.Parse(HugeNegative, CultureInfo.InvariantCulture), UnmarshallXml(BigIntegerUnmarshaller.Instance, HugeNegative));
        }

        [TestMethod]
        public void XmlOutOfRangeThrows()
        {
            Assert.ThrowsExactly<OverflowException>(() => UnmarshallXml(SByteUnmarshaller.Instance, "128"));
            Assert.ThrowsExactly<OverflowException>(() => UnmarshallXml(SByteUnmarshaller.Instance, "-129"));
            Assert.ThrowsExactly<OverflowException>(() => UnmarshallXml(ShortUnmarshaller.Instance, "32768"));
            Assert.ThrowsExactly<OverflowException>(() => UnmarshallXml(ShortUnmarshaller.Instance, "-32769"));
        }

        [TestMethod]
        public void XmlNullableUnmarshallersMatchNullableInt()
        {
            // The nullable XML unmarshallers follow the NullableIntUnmarshaller pattern, so they must read the same value.
            const string xml = "<R><V>12</V><W>34</W></R>";
            var expected = UnmarshallXml(NullableIntUnmarshaller.Instance, xml, "/R");
            Assert.AreEqual(expected, (int?)UnmarshallXml(NullableSByteUnmarshaller.Instance, xml, "/R"));
            Assert.AreEqual(expected, (int?)UnmarshallXml(NullableShortUnmarshaller.Instance, xml, "/R"));
            Assert.AreEqual(expected, (int?)UnmarshallXml(NullableBigIntegerUnmarshaller.Instance, xml, "/R"));
        }

        [TestMethod]
        public void StringUtilsFromNumericTypes()
        {
            Assert.AreEqual("-128", StringUtils.FromSByte(sbyte.MinValue));
            Assert.AreEqual("127", StringUtils.FromSByte((sbyte?)127));
            Assert.IsNull(StringUtils.FromSByte((sbyte?)null));
            Assert.AreEqual("-32768", StringUtils.FromShort(short.MinValue));
            Assert.AreEqual("32767", StringUtils.FromShort((short?)32767));
            Assert.IsNull(StringUtils.FromShort((short?)null));
            Assert.AreEqual(HugeNegative, StringUtils.FromBigInteger(BigInteger.Parse(HugeNegative, CultureInfo.InvariantCulture)));
            Assert.AreEqual(HugePositive, StringUtils.FromBigInteger((BigInteger?)BigInteger.Parse(HugePositive, CultureInfo.InvariantCulture)));
            Assert.IsNull(StringUtils.FromBigInteger((BigInteger?)null));
        }

        [TestMethod]
        public void WriteBigIntegerValueWritesJsonNumber()
        {
            var value = BigInteger.Parse(HugeNegative, CultureInfo.InvariantCulture);
            using (var stream = new MemoryStream())
            {
                using (var writer = new Utf8JsonWriter(stream))
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("v");
                    StringUtils.WriteBigIntegerValue(writer, value);
                    writer.WriteEndObject();
                }

                var json = Encoding.UTF8.GetString(stream.ToArray());
                Assert.AreEqual("{\"v\":" + HugeNegative + "}", json);

                using (var document = JsonDocument.Parse(json))
                {
                    var element = document.RootElement.GetProperty("v");
                    Assert.AreEqual(JsonValueKind.Number, element.ValueKind);
                    Assert.AreEqual(HugeNegative, element.GetRawText());
                }
            }
        }

        [TestMethod]
        public void InvariantCultureIsUsedUnderOtherCultures()
        {
            // nb-NO uses U+2212 as its negative sign on ICU-based runtimes; de-DE uses a comma decimal separator.
            foreach (var cultureName in new[] { "nb-NO", "sv-SE", "de-DE", "ar-SA" })
            {
                RunInCulture(cultureName, () =>
                {
                    Assert.AreEqual("-5", StringUtils.FromSByte((sbyte)-5));
                    Assert.AreEqual("-5", StringUtils.FromShort((short)-5));
                    Assert.AreEqual("-5", StringUtils.FromBigInteger(new BigInteger(-5)));
                    Assert.AreEqual("-5,-6", StringUtils.FromValueTypeList(new List<short> { -5, -6 }, CultureInfo.InvariantCulture));
                    Assert.AreEqual("-1,2", StringUtils.FromValueTypeList(new List<BigInteger> { -1, 2 }, CultureInfo.InvariantCulture));
                    Assert.AreEqual((sbyte)-5, UnmarshallJson(SByteUnmarshaller.Instance, "\"-5\""));
                    Assert.AreEqual((short)-5, UnmarshallXml(ShortUnmarshaller.Instance, "-5"));
                    Assert.AreEqual(new BigInteger(-5), UnmarshallJson(BigIntegerUnmarshaller.Instance, "\"-5\""));
                });
            }
        }

        [TestMethod]
        public void MultiValueHeaderParserWithParseFunction()
        {
            var shorts = MultiValueHeaderParser.ToValueTypeList("1, -2,3", s => short.Parse(s, CultureInfo.InvariantCulture));
            CollectionAssert.AreEqual(new List<short> { 1, -2, 3 }, shorts);

            var bigs = MultiValueHeaderParser.ToValueTypeList(HugePositive + "," + HugeNegative, s => BigInteger.Parse(s, CultureInfo.InvariantCulture));
            CollectionAssert.AreEqual(new List<BigInteger>
            {
                BigInteger.Parse(HugePositive, CultureInfo.InvariantCulture),
                BigInteger.Parse(HugeNegative, CultureInfo.InvariantCulture)
            }, bigs);

            Assert.AreEqual(0, MultiValueHeaderParser.ToValueTypeList<short>("", s => short.Parse(s, CultureInfo.InvariantCulture)).Count);
            Assert.AreEqual(0, MultiValueHeaderParser.ToValueTypeList<short>(null, s => short.Parse(s, CultureInfo.InvariantCulture)).Count);
            Assert.ThrowsExactly<ArgumentNullException>(() => MultiValueHeaderParser.ToValueTypeList<short>("1", null));
            Assert.ThrowsExactly<OverflowException>(() => MultiValueHeaderParser.ToValueTypeList("128", s => sbyte.Parse(s, CultureInfo.InvariantCulture)));
        }

        [TestMethod]
        public void FromValueTypeListWithProviderMatchesExistingOutputForInvariantValues()
        {
            Assert.AreEqual("", StringUtils.FromValueTypeList((List<short>)null, CultureInfo.InvariantCulture));
            Assert.AreEqual("", StringUtils.FromValueTypeList(new List<short>(), CultureInfo.InvariantCulture));
            Assert.AreEqual(
                StringUtils.FromValueTypeList(new List<int> { 1, 2, 3 }),
                StringUtils.FromValueTypeList(new List<int> { 1, 2, 3 }, CultureInfo.InvariantCulture));
        }

        private static void RunInCulture(string cultureName, Action action)
        {
            var original = Thread.CurrentThread.CurrentCulture;
            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureName);
                action();
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = original;
            }
        }

        private static T UnmarshallJson<T>(IJsonUnmarshaller<T, JsonUnmarshallerContext> unmarshaller, string json)
        {
            var stream = Utils.CreateStreamFromString("[" + json + "]");
            var context = new JsonUnmarshallerContext(stream, false, null);
            var reader = new StreamingUtf8JsonReader(stream);
            context.Read(ref reader);
            return unmarshaller.Unmarshall(context, ref reader);
        }

        /// <summary>
        /// Unmarshalls the text of a single element the way generated XML unmarshallers do:
        /// the context is positioned on the element's start tag before the unmarshaller runs.
        /// </summary>
        private static T UnmarshallXml<T>(IXmlUnmarshaller<T, XmlUnmarshallerContext> unmarshaller, string text)
        {
            return UnmarshallXml(unmarshaller, "<R><V>" + text + "</V></R>", "/R/V");
        }

        private static T UnmarshallXml<T>(IXmlUnmarshaller<T, XmlUnmarshallerContext> unmarshaller, string xml, string path)
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
            using (var context = new XmlUnmarshallerContext(stream, false, null))
            {
                while (context.Read())
                {
                    if (context.IsStartElement && context.CurrentPath == path)
                    {
                        return unmarshaller.Unmarshall(context);
                    }
                }
            }

            throw new InvalidOperationException($"Element {path} not found in {xml}");
        }
    }
}
