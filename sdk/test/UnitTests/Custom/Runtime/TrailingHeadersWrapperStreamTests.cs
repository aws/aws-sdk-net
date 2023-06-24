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
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests for the trailing header stream wrapper
    /// </summary>
    [TestClass]
    public class TrailingHeadersWrapperStreamTests
    {
        private const string expectedSHA1Content =
                "B\r\n" +
                "Hello world\r\n" +
                "0\r\n" +
                "x-amz-checksum-sha1:e1AsOh9IyGCa4hLN+2Od7jlnP14=\r\n" +
                "\r\n";
        private const string expectedSHA256Content = 
                "B\r\n" + 
                "Hello world\r\n" + 
                "0\r\n" + 
                "x-amz-checksum-sha256:ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=\r\n" +
                "\r\n";
        private const string expectedCRC32Content =
                "B\r\n" +
                "Hello world\r\n" +
                "0\r\n" +
                "x-amz-checksum-crc32:i9aeUg==\r\n" +
                "\r\n";
        private const string expectedCRC32CContent =
                "B\r\n" +
                "Hello world\r\n" +
                "0\r\n" +
                "x-amz-checksum-crc32c:crUfeA==\r\n" +
                "\r\n";

        /// <summary>
        /// Tests a given trailing checksum for an unsigned stream
        /// </summary>
        [DataTestMethod]
        [DataRow("x-amz-checksum-sha1", CoreChecksumAlgorithm.SHA1, expectedSHA1Content)]
        [DataRow("x-amz-checksum-sha256", CoreChecksumAlgorithm.SHA256, expectedSHA256Content)]
        [DataRow("x-amz-checksum-crc32", CoreChecksumAlgorithm.CRC32, expectedCRC32Content)]
        [DataRow("x-amz-checksum-crc32c", CoreChecksumAlgorithm.CRC32C, expectedCRC32CContent)]
        public void TestTrailingChecksum(string checksumKey, CoreChecksumAlgorithm algorithm, string expectedContent)
        {
            var contentStream = new MemoryStream(Encoding.Default.GetBytes("Hello world"));
            var trailingHeaders = new Dictionary<string, string>
            {
                {checksumKey, "" }  // checksum will be calculated as the stream is read then replaced at the end
            };
            var wrappedStream = new TrailingHeadersWrapperStream(contentStream, trailingHeaders, algorithm);

            var actualContent = new StreamReader(wrappedStream).ReadToEnd();

            Assert.AreEqual(expectedContent.Length, wrappedStream.Length);
            Assert.AreEqual(expectedContent, actualContent);
        }

        /// <summary>
        /// Read the stream with a small buffer, to test the index state between reads
        /// </summary>
        [TestMethod]
        public void SmallBuffer()
        {
            var contentStream = new MemoryStream(Encoding.Default.GetBytes("Hello world"));
            var trailingHeaders = new Dictionary<string, string>
            {
                {"x-amz-checksum-sha256", "" }  // checksum will be calculated as the stream is read then replaced at the end
            };
            var wrappedStream = new TrailingHeadersWrapperStream(contentStream, trailingHeaders, CoreChecksumAlgorithm.SHA256);

            var bytesRead = -1;
            var bufferSize = 1;
            var buffer = new byte[bufferSize];
            var outputAsString = "";
            while (bytesRead != 0)
            {
                bytesRead = wrappedStream.Read(buffer, 0, bufferSize);
                outputAsString += Encoding.Default.GetString(buffer, 0, bytesRead);
            }

            var expectedContent =
               "B\r\n" +
               "Hello world\r\n" +
               "0\r\n" +
               "x-amz-checksum-sha256:ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=\r\n" +
               "\r\n";

            Assert.AreEqual(expectedContent.Length, wrappedStream.Length);
            Assert.AreEqual(expectedContent, outputAsString);
        }

        /// <summary>
        /// Test reading the stream with a larger underlying stream
        /// </summary>
        [TestMethod]
        public void LargeData()
        {
            var data = new string('a', 100000);
            var contentStream = new MemoryStream(Encoding.Default.GetBytes(data));
            var trailingHeaders = new Dictionary<string, string>
            {
                {"x-amz-checksum-sha256", "" }  // checksum will be calculated as the stream is read then replaced at the end
            };
            var wrappedStream = new TrailingHeadersWrapperStream(contentStream, trailingHeaders, CoreChecksumAlgorithm.SHA256);

            var actualContent = new StreamReader(wrappedStream).ReadToEnd();

            var expectedContent =
                "186A0\r\n" +
                $"{data}\r\n" +
                "0\r\n" +
                "x-amz-checksum-sha256:bRzyLXzAmwhd/CXuGh864CZYBMYHvCB0rSU7zIL9ge4=\r\n" +
                "\r\n";

            Assert.AreEqual(expectedContent.Length, wrappedStream.Length);
            Assert.AreEqual(expectedContent, actualContent);
        }

        /// <summary>
        /// Tests wrapping a stream with trailing headers that are not a checksum
        /// </summary>
        [TestMethod]
        public void NonChecksumTrailingHeaders()
        {
            var contentStream = new MemoryStream(Encoding.Default.GetBytes("Hello world"));
            var trailingHeaders = new Dictionary<string, string>
            {
                {"header-a", "value-a" },
                {"header-b", "value-b" }
            };
            var wrappedStream = new TrailingHeadersWrapperStream(contentStream, trailingHeaders);

            var actualContent = new StreamReader(wrappedStream).ReadToEnd();

            var expectedContent =
                "B\r\n" +
                "Hello world\r\n" +
                "0\r\n" +
                "header-a:value-a\r\n" +
                "header-b:value-b\r\n" +
                "\r\n";

            Assert.AreEqual(expectedContent.Length, wrappedStream.Length);
            Assert.AreEqual(expectedContent, actualContent);
        }

        /// <summary>
        /// Tests wrapping a stream with multiple trailing headers, 
        /// one set up front and one checksum that is calculated while
        /// reading the stream.
        /// </summary>
        [TestMethod]
        public void ChecksumAndOtherTrailingHeaders()
        {
            var contentStream = new MemoryStream(Encoding.Default.GetBytes("Hello world"));
            var trailingHeaders = new Dictionary<string, string>
            {
                {"header-a", "value-a" },
                {"header-b", "value-b" },
                {"x-amz-checksum-sha256", "" }  // checksum will be calculated as the stream is read then replaced at the end
            };
            var wrappedStream = new TrailingHeadersWrapperStream(contentStream, trailingHeaders, CoreChecksumAlgorithm.SHA256);

            var actualContent = new StreamReader(wrappedStream).ReadToEnd();

            var expectedContent =
                "B\r\n" +
                "Hello world\r\n" +
                "0\r\n" +
                "header-a:value-a\r\n" +
                "header-b:value-b\r\n" +
                "x-amz-checksum-sha256:ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=\r\n" +
                "\r\n";

            Assert.AreEqual(expectedContent.Length, wrappedStream.Length);
            Assert.AreEqual(expectedContent, actualContent);
        }
    }
}
