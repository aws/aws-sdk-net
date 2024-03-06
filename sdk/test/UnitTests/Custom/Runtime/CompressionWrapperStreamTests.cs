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
using System.Linq;
using System.Text;
using System.IO.Compression;
using Amazon.Runtime.Internal.Compression;
using Amazon.ElasticTranscoder.Model;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class CompressionWrapperStreamTests
    {
#if BCL
        [DataTestMethod]
        [DataRow(0, 10)]
        [DataRow(10, 10)]
        [DataRow(10, 100)]
        [DataRow(100, 10)]
        [DataRow(1000, 100)]
        [DataRow(10000, 1000)]
        [DataRow(100000, 10000)]
        [DataRow(1000000, 10000)]
        public async Task GzipStreamWrapperCompressionAsync(int textRepeatCount, int bufferSize)
        {
            var rand = new Random();
            var text = string.Join("", Enumerable.Repeat(0, textRepeatCount).Select(n => (char)rand.Next(127)));

            var contentStream = new MemoryStream(Encoding.Default.GetBytes(text));
            var compressedWrapStream = new CompressionWrapperStream(contentStream, new GZipCompression());

            var buffer = new byte[bufferSize];

            var bytesRead = 0;
            var compressedStream = new MemoryStream();

            while ((bytesRead = compressedWrapStream.Read(buffer, 0, bufferSize)) > 0)
            {
                await compressedStream.WriteAsync(buffer, 0, bytesRead);
            }

            var decompressedData = DecompressGzip(compressedStream);
            var resultString = Encoding.UTF8.GetString(decompressedData);

            Assert.AreEqual(resultString, text);
        }

        [DataTestMethod]
        [DataRow(0, 10)]
        [DataRow(10, 10)]
        [DataRow(100000, 10000)]
        public async Task RetryGzipStreamWrapperCompressionAsync(int textRepeatCount, int bufferSize)
        {
            var rand = new Random();
            var text = string.Join("", Enumerable.Repeat(0, textRepeatCount).Select(n => (char)rand.Next(127)));

            var contentStream = new MemoryStream(Encoding.Default.GetBytes(text));
            var compressedWrapStream = new CompressionWrapperStream(contentStream, new GZipCompression());

            for (int i = 0; i < 3; i++)
            {
                var buffer = new byte[bufferSize];
                var bytesRead = 0;

                var compressedStream = new MemoryStream();

                while ((bytesRead = compressedWrapStream.Read(buffer, 0, bufferSize)) > 0)
                {
                    await compressedStream.WriteAsync(buffer, 0, bytesRead);
                }

                var decompressedData = DecompressGzip(compressedStream);
                var resultString = Encoding.UTF8.GetString(decompressedData);

                Assert.AreEqual(resultString, text);

                // Reset compression wrapper stream
                compressedWrapStream.GetSeekableBaseStream().Position = 0;
                compressedWrapStream.Reset();
            }
        }
#endif
        public static byte[] DecompressGzip(Stream compressedStream)
        {
            compressedStream.Seek(0, SeekOrigin.Begin);
            using (var decompressedStream = new MemoryStream())
            using (var gzipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
            {
                gzipStream.CopyTo(decompressedStream);
                return decompressedStream.ToArray();
            }
        }
    }
}
    
