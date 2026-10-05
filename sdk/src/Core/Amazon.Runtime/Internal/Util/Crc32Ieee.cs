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

using System;
using System.Runtime.InteropServices;
#if NET8_0_OR_GREATER
using System.Runtime.CompilerServices;
using ThirdParty.RuntimeBackports;
using ArmCrc32 = System.Runtime.Intrinsics.Arm.Crc32;
#endif

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// CRC-32 (IEEE 802.3, reflected polynomial 0xEDB88320) update over the raw CRC register.
    /// Callers own the initial value (0xFFFFFFFF) and the final one's complement, matching
    /// <see cref="ThirdParty.Ionic.Zlib.CRC32"/>.
    /// </summary>
    /// <remarks>
    /// Uses PCLMULQDQ folding on x86/x64 and the CRC32 instructions on ARM64 (.NET 8+),
    /// and slicing-by-16 tables everywhere else.
    /// </remarks>
    internal static class Crc32Ieee
    {
        internal enum Implementation
        {
            Slicing16,
            Pclmulqdq,
            Arm64
        }

        private const uint Polynomial = 0xEDB88320u;

        // Below this length, the fixed cost of the PCLMULQDQ reduction outweighs its throughput.
        internal const int VectorThreshold = 64;

        // 16 tables of 256 entries; table k maps a byte to its CRC contribution k bytes ahead.
        private static readonly uint[] SlicingTable = CreateSlicingTable();

        /// <summary>
        /// The implementation <see cref="Update(uint, ReadOnlySpan{byte})"/> uses for large inputs on this machine.
        /// </summary>
        internal static Implementation ActiveImplementation
        {
            get
            {
#if NET8_0_OR_GREATER
                if (Crc32Pclmulqdq.IsSupported)
                    return Implementation.Pclmulqdq;
                if (ArmCrc32.Arm64.IsSupported)
                    return Implementation.Arm64;
#endif
                return Implementation.Slicing16;
            }
        }

        internal static uint Update(uint crc, byte[] buffer, int offset, int count)
        {
            return Update(crc, new ReadOnlySpan<byte>(buffer, offset, count));
        }

        internal static uint Update(uint crc, ReadOnlySpan<byte> data)
        {
#if NET8_0_OR_GREATER
            if (data.Length >= VectorThreshold && Crc32Pclmulqdq.IsSupported)
            {
                int vectorLength = data.Length & ~15;
                crc = Crc32Pclmulqdq.UpdateBlocks(crc, data.Slice(0, vectorLength));
                data = data.Slice(vectorLength);
            }
            else if (ArmCrc32.Arm64.IsSupported)
            {
                return UpdateArm64(crc, data);
            }
#endif
            return UpdateSlicing16(crc, data);
        }

        internal static unsafe uint UpdateSlicing16(uint crc, ReadOnlySpan<byte> data)
        {
            int length = data.Length;
            if (length == 0)
                return crc;

            fixed (byte* start = &MemoryMarshal.GetReference(data))
            fixed (uint* t = SlicingTable)
            {
                byte* p = start;
                while (length >= 16)
                {
                    crc = t[0x0F00 + (byte)(p[0] ^ crc)] ^
                          t[0x0E00 + (byte)(p[1] ^ (crc >> 8))] ^
                          t[0x0D00 + (byte)(p[2] ^ (crc >> 16))] ^
                          t[0x0C00 + (byte)(p[3] ^ (crc >> 24))] ^
                          t[0x0B00 + p[4]] ^
                          t[0x0A00 + p[5]] ^
                          t[0x0900 + p[6]] ^
                          t[0x0800 + p[7]] ^
                          t[0x0700 + p[8]] ^
                          t[0x0600 + p[9]] ^
                          t[0x0500 + p[10]] ^
                          t[0x0400 + p[11]] ^
                          t[0x0300 + p[12]] ^
                          t[0x0200 + p[13]] ^
                          t[0x0100 + p[14]] ^
                          t[p[15]];
                    p += 16;
                    length -= 16;
                }

                while (length > 0)
                {
                    crc = t[(byte)(crc ^ *p)] ^ (crc >> 8);
                    p++;
                    length--;
                }
            }

            return crc;
        }

#if NET8_0_OR_GREATER
        internal static uint UpdateArm64(uint crc, ReadOnlySpan<byte> data)
        {
            ref byte start = ref MemoryMarshal.GetReference(data);
            int length = data.Length;
            int i = 0;

            for (; i <= length - 8; i += 8)
            {
                crc = ArmCrc32.Arm64.ComputeCrc32(crc, Unsafe.ReadUnaligned<ulong>(ref Unsafe.Add(ref start, i)));
            }

            for (; i < length; i++)
            {
                crc = ArmCrc32.ComputeCrc32(crc, Unsafe.Add(ref start, i));
            }

            return crc;
        }
#endif

        private static uint[] CreateSlicingTable()
        {
            var table = new uint[16 * 256];
            for (uint i = 0; i < 256; i++)
            {
                uint c = i;
                for (int j = 0; j < 8; j++)
                {
                    c = (c & 1) != 0 ? (c >> 1) ^ Polynomial : c >> 1;
                }
                table[i] = c;
            }

            for (int k = 1; k < 16; k++)
            {
                for (int i = 0; i < 256; i++)
                {
                    uint prev = table[((k - 1) * 256) + i];
                    table[(k * 256) + i] = (prev >> 8) ^ table[prev & 0xFF];
                }
            }

            return table;
        }
    }
}
