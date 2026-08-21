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
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class Crc32StreamTests
    {
        // Expected CRC-32 values (big-endian, base64 encoded) match the well-known
        // values also asserted in ChecksumTests for CoreChecksumAlgorithm.CRC32.
        private const string EmptyCrc = "AAAAAA==";
        private const string AbcCrc = "NSRBwg==";
        private const string HelloWorldCrc = "i9aeUg==";

        /// <summary>
        /// Encodes the stream's running CRC-32 int as a big-endian base64 string, matching
        /// the representation used elsewhere in the SDK for checksums.
        /// </summary>
        private static string ToBase64(int crc32)
        {
            var bytes = BitConverter.GetBytes(crc32);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            return Convert.ToBase64String(bytes);
        }

        [DataRow("", EmptyCrc)]
        [DataRow("abc", AbcCrc)]
        [DataRow("Hello world", HelloWorldCrc)]
        [TestMethod]
        public void WritePath_ComputesKnownCrc32_AndForwardsBytes(string content, string expectedBase64)
        {
            var contentBytes = Encoding.UTF8.GetBytes(content);

            using (var inner = new MemoryStream())
            using (var crcStream = new Crc32Stream(inner))
            {
                crcStream.Write(contentBytes, 0, contentBytes.Length);

                Assert.AreEqual(expectedBase64, ToBase64(crcStream.Crc32));
                Assert.AreEqual(contentBytes.Length, crcStream.TotalBytesSlurped);
                // Bytes written to the CRC stream must be forwarded unchanged to the inner stream.
                CollectionAssert.AreEqual(contentBytes, inner.ToArray());
            }
        }

        [DataRow("", EmptyCrc)]
        [DataRow("abc", AbcCrc)]
        [DataRow("Hello world", HelloWorldCrc)]
        [TestMethod]
        public void ReadPath_ComputesKnownCrc32_AndReturnsBytes(string content, string expectedBase64)
        {
            var contentBytes = Encoding.UTF8.GetBytes(content);

            using (var inner = new MemoryStream(contentBytes))
            using (var crcStream = new Crc32Stream(inner))
            {
                var read = ReadFully(crcStream);

                Assert.AreEqual(expectedBase64, ToBase64(crcStream.Crc32));
                Assert.AreEqual(contentBytes.Length, crcStream.TotalBytesSlurped);
                CollectionAssert.AreEqual(contentBytes, read);
            }
        }

        [TestMethod]
        public void MidStreamPeek_DoesNotResetRunningCrc()
        {
            var part1 = Encoding.UTF8.GetBytes("Hello ");
            var part2 = Encoding.UTF8.GetBytes("world");
            var whole = Encoding.UTF8.GetBytes("Hello world");

            using (var inner = new MemoryStream())
            using (var crcStream = new Crc32Stream(inner))
            {
                crcStream.Write(part1, 0, part1.Length);
                // Peeking mid-stream must equal the CRC of just the bytes written so far...
                Assert.AreEqual(ComputeCrc32(part1), crcStream.Crc32);

                crcStream.Write(part2, 0, part2.Length);
                // ...and continuing to append must keep accumulating (not reset after the peek).
                Assert.AreEqual(ComputeCrc32(whole), crcStream.Crc32);
                Assert.AreEqual(HelloWorldCrc, ToBase64(crcStream.Crc32));
            }
        }

        [TestMethod]
        public void ReadPath_WithLengthCap_StopsAtLengthAndHashesOnlyThoseBytes()
        {
            var source = new byte[100];
            new Random(42).NextBytes(source);

            const int cap = 40;
            using (var inner = new MemoryStream(source))
            using (var crcStream = new Crc32Stream(inner, cap))
            {
                var buffer = new byte[256];

                // First read is clamped to the cap.
                int first = crcStream.Read(buffer, 0, buffer.Length);
                Assert.AreEqual(cap, first);

                // Once the cap is reached the stream reports EOF even though the inner stream has more.
                int second = crcStream.Read(buffer, 0, buffer.Length);
                Assert.AreEqual(0, second);

                Assert.AreEqual(cap, crcStream.TotalBytesSlurped);
                Assert.AreEqual(cap, crcStream.Position);
                Assert.AreEqual(cap, crcStream.Length);

                // CRC must cover only the first `cap` bytes, not the whole source.
                var capped = new byte[cap];
                Array.Copy(source, capped, cap);
                Assert.AreEqual(ComputeCrc32(capped), crcStream.Crc32);
            }
        }

        [TestMethod]
        public void ReadPath_WithLengthCap_ClampsFinalPartialRead()
        {
            var source = new byte[50];
            new Random(7).NextBytes(source);

            const int cap = 40;
            using (var inner = new MemoryStream(source))
            using (var crcStream = new Crc32Stream(inner, cap))
            {
                var buffer = new byte[30];

                int first = crcStream.Read(buffer, 0, buffer.Length);   // 30 bytes
                Assert.AreEqual(30, first);

                int second = crcStream.Read(buffer, 0, buffer.Length);  // clamped to remaining 10
                Assert.AreEqual(10, second);

                int third = crcStream.Read(buffer, 0, buffer.Length);   // EOF
                Assert.AreEqual(0, third);

                Assert.AreEqual(cap, crcStream.TotalBytesSlurped);
            }
        }

        [TestMethod]
        public void EmptyInput_Crc32IsZero()
        {
            using (var inner = new MemoryStream())
            using (var crcStream = new Crc32Stream(inner))
            {
                Assert.AreEqual(0, crcStream.Crc32);
                Assert.AreEqual(EmptyCrc, ToBase64(crcStream.Crc32));
                Assert.AreEqual(0, crcStream.TotalBytesSlurped);
            }
        }

        [TestMethod]
        public void Write_WithZeroCount_DoesNotAdvanceOrChangeCrc()
        {
            var data = Encoding.UTF8.GetBytes("abc");
            using (var inner = new MemoryStream())
            using (var crcStream = new Crc32Stream(inner))
            {
                crcStream.Write(data, 0, 0);
                Assert.AreEqual(0, crcStream.Crc32);
                Assert.AreEqual(0, crcStream.TotalBytesSlurped);
            }
        }

        [TestMethod]
        public void Capabilities_DelegateToInnerStream()
        {
            var readable = new MemoryStream(new byte[] { 1, 2, 3 });
            using (var crcStream = new Crc32Stream(readable))
            {
                Assert.AreEqual(readable.CanRead, crcStream.CanRead);
                Assert.AreEqual(readable.CanSeek, crcStream.CanSeek);
                Assert.AreEqual(readable.CanWrite, crcStream.CanWrite);
            }
        }

        [TestMethod]
        public void Seek_SetLength_And_SetPosition_ThrowNotImplemented()
        {
            using (var inner = new MemoryStream())
            using (var crcStream = new Crc32Stream(inner))
            {
                Assert.ThrowsExactly<NotImplementedException>(() => crcStream.Seek(0, SeekOrigin.Begin));
                Assert.ThrowsExactly<NotImplementedException>(() => crcStream.SetLength(10));
                Assert.ThrowsExactly<NotImplementedException>(() => crcStream.Position = 5);
            }
        }

        /// <summary>
        /// Computes the CRC-32 of a buffer using an independent <see cref="Crc32Stream"/> write pass,
        /// used as the reference value for incremental/length-cap assertions.
        /// </summary>
        private static int ComputeCrc32(byte[] data)
        {
            using (var inner = new MemoryStream())
            using (var crcStream = new Crc32Stream(inner))
            {
                crcStream.Write(data, 0, data.Length);
                return crcStream.Crc32;
            }
        }

        private static byte[] ReadFully(Stream stream)
        {
            using (var output = new MemoryStream())
            {
                var buffer = new byte[16];
                int read;
                while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    output.Write(buffer, 0, read);
                }
                return output.ToArray();
            }
        }
    }
}
