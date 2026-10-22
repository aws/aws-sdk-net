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
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using ThirdParty.Ionic.Zlib;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Equivalence tests for the accelerated CRC-32 paths against the original Ionic.Zlib
    /// byte-at-a-time table implementation.
    /// </summary>
    [TestClass]
    public class Crc32IeeeTests
    {
        private const int Seed = 0x5EED;

        // The original Ionic.Zlib per-byte step (CRC32._InternalComputeCrc32 uses the unmodified byte table).
        private static uint Reference(uint crc, byte[] data, int offset, int count)
        {
            var ionic = new CRC32();
            for (int i = 0; i < count; i++)
            {
                crc = unchecked((uint)ionic._InternalComputeCrc32(crc, data[offset + i]));
            }
            return crc;
        }

        private static byte[] RandomBytes(Random random, int length)
        {
            var data = new byte[length];
            random.NextBytes(data);
            return data;
        }

        private static byte[] ToBigEndian(uint crc)
        {
            return new[] { (byte)(crc >> 24), (byte)(crc >> 16), (byte)(crc >> 8), (byte)crc };
        }

        [DataRow("", 0x00000000u)]
        [DataRow("a", 0xE8B7BE43u)]
        [DataRow("abc", 0x352441C2u)]
        [DataRow("123456789", 0xCBF43926u)]
        [DataRow("The quick brown fox jumps over the lazy dog", 0x414FA339u)]
        [TestMethod]
        [TestCategory("Runtime")]
        public void KnownVectors(string input, uint expected)
        {
            var bytes = Encoding.ASCII.GetBytes(input);

            CollectionAssert.AreEqual(ToBigEndian(expected), new Crc32Managed().ComputeHash(bytes));
            Assert.AreEqual(expected, ~Crc32Ieee.Update(0xFFFFFFFFu, bytes, 0, bytes.Length));
            Assert.AreEqual(expected, ~Crc32Ieee.UpdateSlicing16(0xFFFFFFFFu, bytes));
            Assert.AreEqual(expected, ~Reference(0xFFFFFFFFu, bytes, 0, bytes.Length));
        }

        [TestMethod]
        [TestCategory("Runtime")]
        public void KnownVectorLarge()
        {
            // 1 MiB of zeros; independently known CRC-32.
            var zeros = new byte[1024 * 1024];
            Assert.AreEqual(0xA738EA1Cu, ~Crc32Ieee.Update(0xFFFFFFFFu, zeros, 0, zeros.Length));
            Assert.AreEqual(0xA738EA1Cu, ~Crc32Ieee.UpdateSlicing16(0xFFFFFFFFu, zeros));
        }

        [TestMethod]
        [TestCategory("Runtime")]
        public void ActiveImplementationMatchesHardware()
        {
#if NET8_0_OR_GREATER
            Crc32Ieee.Implementation expected;
            if (System.Runtime.Intrinsics.X86.Pclmulqdq.IsSupported)
                expected = Crc32Ieee.Implementation.Pclmulqdq;
            else if (System.Runtime.Intrinsics.Arm.Crc32.Arm64.IsSupported)
                expected = Crc32Ieee.Implementation.Arm64;
            else
                expected = Crc32Ieee.Implementation.Slicing16;
            Assert.AreEqual(expected, Crc32Ieee.ActiveImplementation);
#else
            Assert.AreEqual(Crc32Ieee.Implementation.Slicing16, Crc32Ieee.ActiveImplementation);
#endif
        }

        [TestMethod]
        [TestCategory("Runtime")]
        public void Slicing16MatchesReferenceAllLengthsAndOffsets()
        {
            var random = new Random(Seed);
            var buffer = RandomBytes(random, 2048 + 64);
            for (int length = 0; length <= 2048; length++)
            {
                int offset = random.Next(0, 64);
                uint seed = length % 3 == 0 ? 0xFFFFFFFFu : (uint)random.Next();
                Assert.AreEqual(Reference(seed, buffer, offset, length),
                    Crc32Ieee.UpdateSlicing16(seed, new ReadOnlySpan<byte>(buffer, offset, length)),
                    $"length={length} offset={offset}");
            }
        }

        [TestMethod]
        [TestCategory("Runtime")]
        public void DispatchMatchesReferenceAllLengthsAndOffsets()
        {
            var random = new Random(Seed + 1);
            var buffer = RandomBytes(random, 2048 + 64);
            for (int length = 0; length <= 2048; length++)
            {
                int offset = random.Next(0, 64);
                uint seed = length % 3 == 0 ? 0xFFFFFFFFu : (uint)random.Next();
                Assert.AreEqual(Reference(seed, buffer, offset, length),
                    Crc32Ieee.Update(seed, buffer, offset, length),
                    $"length={length} offset={offset}");
            }
        }

        [DataRow(64 * 1024)]
        [DataRow(256 * 1024 + 7)]
        [DataRow(1024 * 1024 + 13)]
        [DataRow(4 * 1024 * 1024 + 63)]
        [TestMethod]
        [TestCategory("Runtime")]
        public void LargeInputsMatchReference(int length)
        {
            var random = new Random(Seed + length);
            var buffer = RandomBytes(random, length + 3);
            uint expected = Reference(0xFFFFFFFFu, buffer, 3, length);

            Assert.AreEqual(expected, Crc32Ieee.Update(0xFFFFFFFFu, buffer, 3, length));
            Assert.AreEqual(expected, Crc32Ieee.UpdateSlicing16(0xFFFFFFFFu, new ReadOnlySpan<byte>(buffer, 3, length)));
#if NET8_0_OR_GREATER
            if (ThirdParty.RuntimeBackports.Crc32Pclmulqdq.IsSupported)
            {
                int blocks = length & ~15;
                uint crc = ThirdParty.RuntimeBackports.Crc32Pclmulqdq.UpdateBlocks(0xFFFFFFFFu, new ReadOnlySpan<byte>(buffer, 3, blocks));
                crc = Crc32Ieee.UpdateSlicing16(crc, new ReadOnlySpan<byte>(buffer, 3 + blocks, length - blocks));
                Assert.AreEqual(expected, crc);
            }
#endif
        }

#if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("Runtime")]
        public void PclmulqdqMatchesReferenceAllBlockLengthsAndOffsets()
        {
            if (!ThirdParty.RuntimeBackports.Crc32Pclmulqdq.IsSupported)
                Assert.Inconclusive("PCLMULQDQ is not supported on this machine.");

            var random = new Random(Seed + 2);
            var buffer = RandomBytes(random, 4096 + 64);
            for (int length = 16; length <= 4096; length += 16)
            {
                int offset = random.Next(0, 64);
                uint seed = length % 48 == 0 ? 0xFFFFFFFFu : (uint)random.Next();
                Assert.AreEqual(Reference(seed, buffer, offset, length),
                    ThirdParty.RuntimeBackports.Crc32Pclmulqdq.UpdateBlocks(seed, new ReadOnlySpan<byte>(buffer, offset, length)),
                    $"length={length} offset={offset}");
            }
        }

        [TestMethod]
        [TestCategory("Runtime")]
        public void PclmulqdqRejectsNonBlockLengths()
        {
            if (!ThirdParty.RuntimeBackports.Crc32Pclmulqdq.IsSupported)
                Assert.Inconclusive("PCLMULQDQ is not supported on this machine.");

            var buffer = new byte[64];
            Assert.ThrowsExactly<ArgumentException>(() => ThirdParty.RuntimeBackports.Crc32Pclmulqdq.UpdateBlocks(0, new ReadOnlySpan<byte>(buffer, 0, 0)));
            Assert.ThrowsExactly<ArgumentException>(() => ThirdParty.RuntimeBackports.Crc32Pclmulqdq.UpdateBlocks(0, new ReadOnlySpan<byte>(buffer, 0, 17)));
        }

        [TestMethod]
        [TestCategory("Runtime")]
        public void Arm64MatchesReferenceAllLengthsAndOffsets()
        {
            if (!System.Runtime.Intrinsics.Arm.Crc32.Arm64.IsSupported)
                Assert.Inconclusive("ARM64 CRC32 instructions are not supported on this machine.");

            var random = new Random(Seed + 3);
            var buffer = RandomBytes(random, 2048 + 64);
            for (int length = 0; length <= 2048; length++)
            {
                int offset = random.Next(0, 64);
                uint seed = length % 3 == 0 ? 0xFFFFFFFFu : (uint)random.Next();
                Assert.AreEqual(Reference(seed, buffer, offset, length),
                    Crc32Ieee.UpdateArm64(seed, new ReadOnlySpan<byte>(buffer, offset, length)),
                    $"length={length} offset={offset}");
            }
        }
#endif

        [TestMethod]
        [TestCategory("Runtime")]
        public void Crc32ManagedIncrementalChunkingMatchesOneShot()
        {
            var random = new Random(Seed + 4);
            for (int iteration = 0; iteration < 200; iteration++)
            {
                int length = iteration < 100 ? random.Next(0, 2049) : random.Next(0, 300 * 1024);
                var data = RandomBytes(random, length);
                var expected = ToBigEndian(~Reference(0xFFFFFFFFu, data, 0, length));

                using (var hash = new Crc32Managed())
                {
                    int position = 0;
                    while (position < length)
                    {
                        int chunk = Math.Min(length - position, random.Next(0, 3) == 0 ? random.Next(0, 17) : random.Next(0, 70000));
                        hash.TransformBlock(data, position, chunk, null, 0);
                        position += chunk;
                    }
                    hash.TransformFinalBlock(Array.Empty<byte>(), 0, 0);
                    CollectionAssert.AreEqual(expected, hash.Hash, $"iteration={iteration} length={length}");
                }
            }
        }

        [TestMethod]
        [TestCategory("Runtime")]
        public void ChecksumFactoryCrc32MatchesReference()
        {
            var random = new Random(Seed + 5);
            var data = RandomBytes(random, 256 * 1024);
            var expected = Convert.ToBase64String(ToBigEndian(~Reference(0xFFFFFFFFu, data, 0, data.Length)));

            var actual = Convert.ToBase64String(CryptoUtilFactory.GetChecksumInstance(CoreChecksumAlgorithm.CRC32).ComputeHash(data));
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, CryptoUtilFactory.CryptoInstance.ComputeCRC32Hash(data));

            using (var wrapper = new HashingWrapperCRC32())
            {
                wrapper.AppendBlock(data, 0, 1000);
                var hash = wrapper.AppendLastBlock(data, 1000, data.Length - 1000);
                Assert.AreEqual(expected, Convert.ToBase64String(hash));
            }
        }

        [TestMethod]
        [TestCategory("Runtime")]
        public void Crc32ManagedReuseKeepsRunningState()
        {
            // Crc32Managed.Initialize does not reset the running CRC; a second ComputeHash continues from the first.
            var data = Encoding.ASCII.GetBytes("123456789");
            var doubled = new byte[data.Length * 2];
            Buffer.BlockCopy(data, 0, doubled, 0, data.Length);
            Buffer.BlockCopy(data, 0, doubled, data.Length, data.Length);

            using (var hash = new Crc32Managed())
            {
                CollectionAssert.AreEqual(ToBigEndian(0xCBF43926u), hash.ComputeHash(data));
                CollectionAssert.AreEqual(ToBigEndian(~Reference(0xFFFFFFFFu, doubled, 0, doubled.Length)), hash.ComputeHash(data));
            }
        }

        [TestMethod]
        [TestCategory("Runtime")]
        public void CrcCalculatorStreamMatchesReference()
        {
            var random = new Random(Seed + 6);
            var data = RandomBytes(random, 200 * 1024 + 5);
            int expected = unchecked((int)~Reference(0xFFFFFFFFu, data, 0, data.Length));

            using (var stream = new CrcCalculatorStream(new MemoryStream(data), data.Length))
            {
                var buffer = new byte[9000];
                int read;
                do
                {
                    int offset = random.Next(0, 16);
                    read = stream.Read(buffer, offset, random.Next(1, buffer.Length - offset));
                } while (read > 0);
                Assert.AreEqual(expected, stream.Crc32);
                Assert.AreEqual(data.Length, stream.TotalBytesSlurped);
            }
        }

        [TestMethod]
        [TestCategory("Runtime")]
        public void SlurpBlockIgnoresNonPositiveCounts()
        {
            var crc = new CRC32();
            crc.SlurpBlock(new byte[4], 0, 0);
            Assert.AreEqual(0, crc.Crc32Result);
            Assert.AreEqual(0, crc.TotalBytesRead);
        }
    }
}
