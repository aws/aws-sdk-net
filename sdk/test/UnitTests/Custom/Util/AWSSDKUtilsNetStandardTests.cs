#if !NETFRAMEWORK
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdParty.RuntimeBackports;

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("Core")]
    public class AWSSDKUtilsNetStandardTests
    {
        [TestMethod]
        public void GetParametersAsString()
        {
            var parameters = new ParameterCollection
            {
                { "key1", "value1" },
                { "key2", "value2" },
                { "key3", new List<string> { "value3", "value4" } },
                { "key4", new List<double> { 1.1, 2.1 } }
            };

            var parametersString = AWSSDKUtils.GetParametersAsString(parameters);

            Assert.AreEqual("key1=value1&key2=value2&key3=value3&key3=value4&key4=1.1&key4=2.1", parametersString);
        }

        [TestMethod]
        public void GetParametersAsString_ProducesCorrectlySortedOutput()
        {
            var parameters = new ParameterCollection
            {
                { "key3", "value3" },
                { "key1", "value1" },
                { "key2", "value2" },
            };

            var result = AWSSDKUtils.GetParametersAsString(parameters);
            Assert.AreEqual("key1=value1&key2=value2&key3=value3", result);
        }

        [TestMethod]
        public void GetParametersAsStringWithStringListParameterValueCorrectlySortsOutput()
        {
            var parameters = new ParameterCollection
            {
                {"key4", new List<string> { "value5", "value4" } },
                {"key1", new List<string>{"value1", "value2"} }
            };
            var result = AWSSDKUtils.GetParametersAsString(parameters);
            Assert.AreEqual("key1=value1&key1=value2&key4=value4&key4=value5", result);
        }

        [TestMethod]
        [DataRow("https://s3.amazonaws.com", "s3")]
        [DataRow("sqs.us-west-2.amazonaws.com", "sqs")]
        [DataRow("queue.amazonaws.com", "sqs")]
        [DataRow("https://sns.us-west-2.amazonaws.com", "sns")]
        [DataRow("https://s3-external-1.amazonaws.com", "s3")]
        public void DetermineService(string url, string expectedService)
        {
            var service = AWSSDKUtils.DetermineService(url);
            Assert.AreEqual(expectedService, service);
        }

        [TestMethod]
        [DataRow("value, with special chars!", "value%2C%20with%20special%20chars%21")]
        [DataRow("value, with special chars and path {/+:}", "value%2C%20with%20special%20chars%20and%20path%20%7B%2F%2B%3A%7D")]
        [DataRow("紙_一般_児童手当等の受給資格及び児童手当の額についての認定請求公金非対応", "%E7%B4%99_%E4%B8%80%E8%88%AC_%E5%85%90%E7%AB%A5%E6%89%8B%E5%BD%93%E7%AD%89%E3%81%AE%E5%8F%97%E7%B5%A6%E8%B3%87%E6%A0%BC%E5%8F%8A%E3%81%B3%E5%85%90%E7%AB%A5%E6%89%8B%E5%BD%93%E3%81%AE%E9%A1%8D%E3%81%AB%E3%81%A4%E3%81%84%E3%81%A6%E3%81%AE%E8%AA%8D%E5%AE%9A%E8%AB%8B%E6%B1%82%E5%85%AC%E9%87%91%E9%9D%9E%E5%AF%BE%E5%BF%9C")]
        public void UrlEncodeWithoutPath(string input, string expected)
        {
            var encoded = AWSSDKUtils.UrlEncode(input, path: false);
            Assert.AreEqual(expected, encoded);
        }

        [TestMethod]
        [DataRow("😂 value, with special chars!", "%F0%9F%98%82%20value,%20with%20special%20chars!")]
        [DataRow("value, with special chars!", "value,%20with%20special%20chars!")]
        [DataRow("value, with special chars and path {/+:}", "value,%20with%20special%20chars%20and%20path%20%7B/+%3A%7D")]
        [DataRow("紙_一般_児童手当等の受給資格及び児童手当の額についての認定請求公金非対応", "%E7%B4%99_%E4%B8%80%E8%88%AC_%E5%85%90%E7%AB%A5%E6%89%8B%E5%BD%93%E7%AD%89%E3%81%AE%E5%8F%97%E7%B5%A6%E8%B3%87%E6%A0%BC%E5%8F%8A%E3%81%B3%E5%85%90%E7%AB%A5%E6%89%8B%E5%BD%93%E3%81%AE%E9%A1%8D%E3%81%AB%E3%81%A4%E3%81%84%E3%81%A6%E3%81%AE%E8%AA%8D%E5%AE%9A%E8%AB%8B%E6%B1%82%E5%85%AC%E9%87%91%E9%9D%9E%E5%AF%BE%E5%BF%9C")]
        public void UrlEncodeWithPath(string input, string expected)
        {
            var encoded = AWSSDKUtils.UrlEncode(input, path: true);
            Assert.AreEqual(expected, encoded);
        }

        [TestMethod]
        [DataRow("", true)]
        [DataRow("Hello, AWS SDK!", true)]
        [DataRow("{\"key\": \"value\"}", true)]
        [DataRow("", false)]
        [DataRow("Hello, AWS SDK!", false)]
        [DataRow("{\"key\": \"value\"}", false)]
        public void WriteBase64StringValue_MatchesFromMemoryStream(string data, bool writable)
        {
            var bytes = Encoding.UTF8.GetBytes(data);
            using (var stream = new MemoryStream(bytes, writable))
            {
                var expected = WriteJsonUsingFromMemoryStream(stream);
                var actual = WriteJsonUsingWriteBase64StringValue(stream);
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        [DataRow(new byte[] { 0x42 }, true)]
        [DataRow(new byte[] { 0x42 }, false)]
        [DataRow(new byte[] { 0x00, 0x01, 0x02, 0xFF, 0xFE, 0xFD }, true)]
        [DataRow(new byte[] { 0x00, 0x01, 0x02, 0xFF, 0xFE, 0xFD }, false)]
        [DataRow(new byte[0], true)]
        [DataRow(new byte[0], false)]
        public void WriteBase64StringValue_BinaryData_MatchesFromMemoryStream(byte[] data, bool writable)
        {
            using (var stream = new MemoryStream(data, writable))
            {
                var expected = WriteJsonUsingFromMemoryStream(stream);
                var actual = WriteJsonUsingWriteBase64StringValue(stream);
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("simple")]
        [DataRow("value, with special chars!")]
        [DataRow("path {/+:} chars")]
        [DataRow("😂 emoji and 世界 cjk")]
        [DataRow("a_b.c-d~e")]
        [DataRow("mixed-safe-prefix then space here")]
        public void UrlEncodeToBuffer_MatchesStringOverloadBytes(string input)
        {
            var expected = Encoding.UTF8.GetBytes(AWSSDKUtils.UrlEncode(3986, input, false));

            using var writer = new ArrayPoolBufferWriter<byte>(64);
            AWSSDKUtils.UrlEncodeToBuffer(3986, writer, input, false);
            var actual = writer.WrittenSpan.ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(3986, false, 0)]
        [DataRow(3986, false, 300)]
        [DataRow(3986, true, 300)]
        [DataRow(1738, false, 300)]
        [DataRow(3986, false, -1)]
        [DataRow(3986, true, -1)]
        [DataRow(1738, false, -1)]
        [DataRow(3986, false, 27)]
        [DataRow(3986, false, 28)]
        public void UrlEncodeToBuffer_MatchesStringOverload_AcrossRfcPathAndLength(int rfc, bool path, int lengthCode)
        {
            // lengthCode >= 0: that many safe 'a' chars (passthrough). lengthCode == -1: 300 spaces (every byte encoded).
            var input = lengthCode >= 0 ? new string('a', lengthCode) : new string(' ', 300);

            var expected = Encoding.UTF8.GetBytes(AWSSDKUtils.UrlEncode(rfc, input, path));

            using var writer = new ArrayPoolBufferWriter<byte>(64);
            AWSSDKUtils.UrlEncodeToBuffer(rfc, writer, input, path);
            var actual = writer.WrittenSpan.ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetParametersAsBytes_MatchesStringPath()
        {
            var pc = BuildRepresentativeParameters();

            var expected = Encoding.UTF8.GetBytes(AWSSDKUtils.GetParametersAsString(pc));
            var actual = AWSSDKUtils.GetParametersAsBytes(pc);

            Assert.AreEqual(expected.Length, actual.Length, "Body byte length differs (e.g. trailing '&').");
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WriteParametersToPooledStream_MatchesStringPath()
        {
            var pc = BuildRepresentativeParameters();
            var request = new DefaultRequest(new MockAmazonWebServiceRequest(), "TestService");
            foreach (var kvp in pc)
                request.ParameterCollection.Add(kvp.Key, kvp.Value);

            var expected = Encoding.UTF8.GetBytes(AWSSDKUtils.GetParametersAsString(pc));

            using var stream = AWSSDKUtils.WriteParametersToPooledStream(request);
            var actual = stream.Content.ToArray();

            Assert.AreEqual(expected.Length, actual.Length, "Body byte length differs (e.g. trailing '&').");
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetParametersAsBytes_SkipsNullValuesAndEmptyStrings_LikeStringPath()
        {
            // A collection that exercises: null value (skipped), empty-string value (key=), a value
            // needing encoding, sorted string list, and a double list.
            var pc = new ParameterCollection
            {
                { "a_empty", "" },
                { "b_plain", "value" },
                { "c_encode", "needs encoding & = chars" },
                { "d_list", new List<string> { "z", "a" } },
                { "e_doubles", new List<double> { 2.5, 1.1 } },
                { "f_null", new StringParameterValue(null) },
            };

            var expected = Encoding.UTF8.GetBytes(AWSSDKUtils.GetParametersAsString(pc));
            var actual = AWSSDKUtils.GetParametersAsBytes(pc);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetParametersAsBytes_EmptyCollection_ReturnsEmpty()
        {
            var pc = new ParameterCollection();

            var actual = AWSSDKUtils.GetParametersAsBytes(pc);

            Assert.AreEqual(0, actual.Length);
            CollectionAssert.AreEqual(Encoding.UTF8.GetBytes(AWSSDKUtils.GetParametersAsString(pc)), actual);
        }

        [TestMethod]
        public void WriteParametersToPooledStream_ContentHash_MatchesLegacyBytePath()
        {
            var pc = BuildRepresentativeParameters();

            var contentStreamRequest = new DefaultRequest(new MockAmazonWebServiceRequest(), "TestService");
            var contentRequest = new DefaultRequest(new MockAmazonWebServiceRequest(), "TestService");
            foreach (var kvp in pc)
            {
                contentStreamRequest.ParameterCollection.Add(kvp.Key, kvp.Value);
                contentRequest.ParameterCollection.Add(kvp.Key, kvp.Value);
            }
            contentStreamRequest.ContentStream = AWSSDKUtils.WriteParametersToPooledStream(contentStreamRequest);
            contentRequest.Content = AWSSDKUtils.GetRequestPayloadBytes(contentRequest);

            // ComputeContentStreamHash() only hashes ContentStream, so hash the byte[] path the way the
            // signer does: SHA256 over request.Content, hex-encoded.
            var contentStreamRequestHash = contentStreamRequest.ComputeContentStreamHash();
            var contentRequestHash = AWSSDKUtils.ToHex(
                CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(contentRequest.Content), true);

            Assert.AreEqual(contentRequestHash, contentStreamRequestHash);

            contentStreamRequest.ContentStream.Dispose();
        }

        private static ParameterCollection BuildRepresentativeParameters()
        {
            return new ParameterCollection
            {
                { "Action", "PutMetricData" },
                { "Version", "2010-08-01" },
                { "Namespace", "AWS/Benchmark with spaces" },
                { "MetricData.member.1.MetricName", "cpu/util%" },
                { "MetricData.member.1.Value", "42.5" },
                { "Dimensions.member.1", new List<string> { "b-zone", "a-zone" } },
                { "Values", new List<double> { 3.3, 1.0, 2.2 } },
            };
        }

        private static string WriteJsonUsingFromMemoryStream(MemoryStream stream)
        {
            using (var outputStream = new MemoryStream())
            {
                using (var writer = new Utf8JsonWriter(outputStream))
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("Data");
                    writer.WriteStringValue(StringUtils.FromMemoryStream(stream));
                    writer.WriteEndObject();
                }
                return Encoding.UTF8.GetString(outputStream.ToArray());
            }
        }

        private static string WriteJsonUsingWriteBase64StringValue(MemoryStream stream)
        {
            using (var outputStream = new MemoryStream())
            {
                using (var writer = new Utf8JsonWriter(outputStream))
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("Data");
                    StringUtils.WriteBase64StringValue(writer, stream);
                    writer.WriteEndObject();
                }
                return Encoding.UTF8.GetString(outputStream.ToArray());
            }
        }
    }
}
#endif
