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
using System.Security.Cryptography;
using System.Text;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// The CRC32/MD5 and upload stream optimizations must produce results identical to the reference implementations.
    /// </summary>
    [TestClass]
    public class ChecksumAndUploadStreamEquivalenceTests
    {
        private static IEnumerable<Tuple<byte[], int[]>> Cases(int count, int maxLength, int seed)
        {
            var rng = new Random(seed);
            foreach (var len in new[] { 0, 1, 2, 3, 15, 16, 17, 31, 32, 33, 63, 64, 65, 127, 128, 129, 1000, 4096, 65536 + 7 })
                yield return Tuple.Create(RandomBytes(rng, len), new[] { len });
            for (int i = 0; i < count; i++)
            {
                int len = rng.Next(maxLength);
                var data = RandomBytes(rng, len);
                var splits = new List<int>();
                int left = len;
                while (left > 0)
                {
                    int take = Math.Min(left, rng.Next(1, 200));
                    splits.Add(take);
                    left -= take;
                }
                yield return Tuple.Create(data, splits.ToArray());
            }
        }

        private static byte[] RandomBytes(Random rng, int len)
        {
            var b = new byte[len];
            rng.NextBytes(b);
            return b;
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Crc32ManagedMatchesIonicReference()
        {
            foreach (var testCase in Cases(2000, 5000, 1))
            {
                var data = testCase.Item1;
                var reference = new ThirdParty.Ionic.Zlib.CRC32();
                reference.SlurpBlock(data, 0, data.Length);
                var expected = BitConverter.GetBytes(reference.Crc32Result);
                Array.Reverse(expected);

                using (var crc = new Crc32Managed())
                {
                    int offset = 0;
                    foreach (var n in testCase.Item2)
                    {
                        crc.TransformBlock(data, offset, n, null, 0);
                        offset += n;
                    }
                    crc.TransformFinalBlock(new byte[0], 0, 0);
                    CollectionAssert.AreEqual(expected, crc.Hash, "length " + data.Length);
                }
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Crc32FastAndPortablePathsAgree()
        {
            var rng = new Random(7);
            for (int i = 0; i < 2000; i++)
            {
                var data = RandomBytes(rng, rng.Next(0, 3000));
                uint seed = (uint)rng.Next();
                Assert.AreEqual(Crc32Slicing.UpdateSafe(seed, data), Crc32Slicing.Update(seed, data));
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Crc32KnownVector()
        {
            using (var crc = new Crc32Managed())
            {
                // CRC-32/ISO-HDLC check value for "123456789" is 0xCBF43926, big-endian as S3 expects.
                CollectionAssert.AreEqual(new byte[] { 0xCB, 0xF4, 0x39, 0x26 }, crc.ComputeHash(Encoding.ASCII.GetBytes("123456789")));
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void MD5ManagedMatchesSystemMD5()
        {
            using (var md5 = MD5.Create())
            {
                foreach (var testCase in Cases(2000, 5000, 2))
                {
                    var data = testCase.Item1;
                    var managed = new ThirdParty.MD5.MD5Managed();
                    int offset = 0;
                    foreach (var n in testCase.Item2)
                    {
                        managed.TransformBlock(data, offset, n, null, 0);
                        offset += n;
                    }
#if NETFRAMEWORK
                    managed.TransformFinalBlock(new byte[0], 0, 0);
                    var actual = managed.Hash;
#else
                    // The netstandard MD5Managed returns the hash from its own TransformFinalBlock.
                    var actual = managed.TransformFinalBlock(new byte[0], 0, 0);
#endif
                    CollectionAssert.AreEqual(md5.ComputeHash(data), actual, "length " + data.Length);
                }
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void HashingWrapperMD5MatchesSystemMD5()
        {
            var data = RandomBytes(new Random(3), 1000003);
            using (var md5 = MD5.Create())
            using (var wrapper = new HashingWrapperMD5())
            {
                for (int offset = 0; offset < data.Length; offset += 81920)
                    wrapper.AppendBlock(data, offset, Math.Min(81920, data.Length - offset));
                CollectionAssert.AreEqual(md5.ComputeHash(data), wrapper.AppendLastBlock(new byte[0]));
            }
        }

        /// <summary>
        /// Chunk buffers are sized to the payload when it is smaller than one chunk. The aws-chunked output must
        /// still be exactly as long as the precomputed Content-Length, including around the chunk-size boundary.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ChunkedUploadStreamLengthMatchesBytesProduced()
        {
            int chunk = ChunkedUploadWrapperStream.DefaultChunkSize;
            foreach (int size in new[] { 0, 1, 100, 8191, 8192, chunk - 1, chunk, chunk + 1, 3 * chunk + 17 })
            {
                foreach (bool trailing in new[] { false, true })
                {
                    var payload = RandomBytes(new Random(size), size);
                    var signing = new AWS4SigningResult("accesskey", "secretkey", new DateTime(2015, 8, 30, 12, 36, 0, DateTimeKind.Utc),
                        "content-type;host", "us-west-2/s3/aws4_request", new byte[32], new byte[64]);
                    var stream = trailing
                        ? new ChunkedUploadWrapperStream(new MemoryStream(payload), 8192, signing, CoreChecksumAlgorithm.CRC32,
                            new Dictionary<string, string> { { "x-amz-checksum-crc32", "" } }, new CachedChecksum { OnComplete = _ => { } })
                        : new ChunkedUploadWrapperStream(new MemoryStream(payload), 8192, signing);
                    long expected = stream.Length;
                    var output = new MemoryStream();
                    stream.CopyTo(output, 64 * 1024);
                    Assert.AreEqual(expected, output.Length, "size " + size + " trailing " + trailing);
                }
            }
        }
    }
}
