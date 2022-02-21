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
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests for the SigV4 chunked stream wrapper
    /// </summary>
    [TestClass]
    public class ChunkedUploadWrapperStreamTests
    {
        private static DateTime _fixedSigningTimestamp = new DateTime(2015, 8, 30, 12, 36, 0, DateTimeKind.Utc);
        private static string _accessKey = "accesskey";
        private static byte[] _signingKey = new byte[32];
        private static byte[] _headerSignature = new byte[64];

        private const string expectedSHA1Content =
                "B;chunk-signature=6a4d50a3307c001ad83900a73442136a0a0f203520fd8c0e966f655cc830bbe8\r\n" +
                "Hello world\r\n" +
                "0;chunk-signature=9384094dc67fd7c29a4c7e0aa3866233b3774e41d1470b8f51a96becbd91f60c\r\n" +
                "x-amz-checksum-sha1:e1AsOh9IyGCa4hLN+2Od7jlnP14=\r\n" +
                "x-amz-trailer-signature:5e9fae6e80d8cb558e2c43d228a8c36d6b36b5f6f8b86fb8f6596111f3f229a1\r\n" +
                "\r\n";
        private const string expectedSHA256Content =
                "B;chunk-signature=6a4d50a3307c001ad83900a73442136a0a0f203520fd8c0e966f655cc830bbe8\r\n" +
                "Hello world\r\n" +
                "0;chunk-signature=9384094dc67fd7c29a4c7e0aa3866233b3774e41d1470b8f51a96becbd91f60c\r\n" +
                "x-amz-checksum-sha256:ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=\r\n" +
                "x-amz-trailer-signature:e80653c66f820ac440e6a520b0953d44605b2c9a81d9e8d98f50012b00bad6c6\r\n" +
                "\r\n";
        private const string expectedCRC32Content =
                "B;chunk-signature=6a4d50a3307c001ad83900a73442136a0a0f203520fd8c0e966f655cc830bbe8\r\n" +
                "Hello world\r\n" +
                "0;chunk-signature=9384094dc67fd7c29a4c7e0aa3866233b3774e41d1470b8f51a96becbd91f60c\r\n" +
                "x-amz-checksum-crc32:i9aeUg==\r\n" +
                "x-amz-trailer-signature:c236bc8c064531085d756c476de022427a9604260ea6f3687bdaab9d6b5f3b9b\r\n" +
                "\r\n";
        private const string expectedCRC32CContent =
                "B;chunk-signature=6a4d50a3307c001ad83900a73442136a0a0f203520fd8c0e966f655cc830bbe8\r\n" +
                "Hello world\r\n" +
                "0;chunk-signature=9384094dc67fd7c29a4c7e0aa3866233b3774e41d1470b8f51a96becbd91f60c\r\n" +
                "x-amz-checksum-crc32c:crUfeA==\r\n" +
                "x-amz-trailer-signature:ad2c42bee2f802836062a35974f2145e8fa97ae75ac6170c70ac367c8bcaff87\r\n" +
                "\r\n";

        /// <summary>
        /// Tests a given trailing checksum for a signed, chunked stream
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

            var headerSigningResult = new AWS4SigningResult(_accessKey, _fixedSigningTimestamp, "", "", _signingKey, _headerSignature);
            var wrappedStream = new ChunkedUploadWrapperStream(contentStream, 8192 , headerSigningResult, algorithm, trailingHeaders);

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
            var headerSigningResult = new AWS4SigningResult(_accessKey, _fixedSigningTimestamp, "", "", _signingKey, _headerSignature);
            var wrappedStream = new ChunkedUploadWrapperStream(contentStream, 1, headerSigningResult, CoreChecksumAlgorithm.SHA256, trailingHeaders);

            var bytesRead = -1;
            var bufferSize = 1;
            var buffer = new byte[bufferSize];
            var outputAsString = "";
            while (bytesRead != 0)
            {
                bytesRead = wrappedStream.Read(buffer, 0, bufferSize);
                outputAsString += Encoding.Default.GetString(buffer, 0, bytesRead);
            }

            Assert.AreEqual(expectedSHA256Content.Length, wrappedStream.Length);
            Assert.AreEqual(expectedSHA256Content, outputAsString);
        }

        /// <summary>
        /// Test reading the stream with a larger underlying stream
        /// (which requires multiple chunks)
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
            var headerSigningResult = new AWS4SigningResult(_accessKey, _fixedSigningTimestamp, "", "", _signingKey, _headerSignature);
            var wrappedStream = new ChunkedUploadWrapperStream(contentStream, 8192, headerSigningResult, CoreChecksumAlgorithm.SHA256, trailingHeaders);

            var actualContent = new StreamReader(wrappedStream).ReadToEnd();

            var expectedContent =
                "14000;chunk-signature=dd6818ebe851d9f6006431fac25c71960881bf8d86501344f19a43c1a2c2a9a7\r\n" +
                $"{new string('a', 81920)}\r\n" +
                "46A0;chunk-signature=88f059571f2bc312c8fd7ebd2082f587561ca83a6d5bb863e6e3d4ef78819256\r\n" +
                $"{new string('a', 18080)}\r\n" +
                "0;chunk-signature=07857eed4f1a53ae7d042e0c410053d610ed947827ca1c5572ed401666732805\r\n" +
                "x-amz-checksum-sha256:bRzyLXzAmwhd/CXuGh864CZYBMYHvCB0rSU7zIL9ge4=\r\n" +
                "x-amz-trailer-signature:cd8a0ba8bc4abaaa5f6e9921c30ca6e018110bcbaa3ea876e7b777b924bb4009\r\n" +
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
            var headerSigningResult = new AWS4SigningResult(_accessKey, _fixedSigningTimestamp, "", "", _signingKey, _headerSignature);
            var wrappedStream = new ChunkedUploadWrapperStream(contentStream, 8192, headerSigningResult, CoreChecksumAlgorithm.NONE, trailingHeaders);

            var actualContent = new StreamReader(wrappedStream).ReadToEnd();

            var expectedContent =
                "B;chunk-signature=6a4d50a3307c001ad83900a73442136a0a0f203520fd8c0e966f655cc830bbe8\r\n" +
                "Hello world\r\n" +
                "0;chunk-signature=9384094dc67fd7c29a4c7e0aa3866233b3774e41d1470b8f51a96becbd91f60c\r\n" +
                "header-a:value-a\r\n" +
                "header-b:value-b\r\n" +
                "x-amz-trailer-signature:ff2899b910cb941057f921d11738b5d875f2e117ea9504cfea4f9c7a788a0852\r\n" +
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
            var headerSigningResult = new AWS4SigningResult(_accessKey, _fixedSigningTimestamp, "", "", _signingKey, _headerSignature);
            var wrappedStream = new ChunkedUploadWrapperStream(contentStream, 8192, headerSigningResult, CoreChecksumAlgorithm.SHA256, trailingHeaders);

            var actualContent = new StreamReader(wrappedStream).ReadToEnd();

            var expectedContent =
                "B;chunk-signature=6a4d50a3307c001ad83900a73442136a0a0f203520fd8c0e966f655cc830bbe8\r\n" +
                "Hello world\r\n" +
                "0;chunk-signature=9384094dc67fd7c29a4c7e0aa3866233b3774e41d1470b8f51a96becbd91f60c\r\n" +
                "header-a:value-a\r\n" +
                "header-b:value-b\r\n" +
                "x-amz-checksum-sha256:ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=\r\n" +
                "x-amz-trailer-signature:0e357651fe17d33ea0d4173b2fd745d596354a66347ee8b5e4de44036c62becb\r\n" +
                "\r\n";

            Assert.AreEqual(expectedContent.Length, wrappedStream.Length);
            Assert.AreEqual(expectedContent, actualContent);
        }
    }
}
