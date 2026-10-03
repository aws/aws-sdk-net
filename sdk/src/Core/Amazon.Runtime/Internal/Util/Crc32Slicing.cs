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

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// CRC-32 (IEEE 802.3, reflected polynomial 0xEDB88320) using the slicing-by-16 technique: 16 bytes per
    /// iteration with table lookups instead of one byte per iteration. Produces exactly the same values as
    /// <see cref="ThirdParty.Ionic.Zlib.CRC32"/>; it only changes how fast they are computed.
    /// </summary>
    internal static class Crc32Slicing
    {
        private const uint Polynomial = 0xEDB88320u;

        // Table[k][b] = CRC of byte b followed by k zero bytes.
        private static readonly uint[] Table = CreateTable();

        private static uint[] CreateTable()
        {
            var table = new uint[16 * 256];
            for (uint i = 0; i < 256; i++)
            {
                uint crc = i;
                for (int j = 0; j < 8; j++)
                    crc = (crc & 1) != 0 ? (crc >> 1) ^ Polynomial : crc >> 1;
                table[i] = crc;
            }
            for (int k = 1; k < 16; k++)
            {
                for (int i = 0; i < 256; i++)
                {
                    uint prev = table[(k - 1) * 256 + i];
                    table[k * 256 + i] = (prev >> 8) ^ table[prev & 0xFF];
                }
            }
            return table;
        }

        /// <summary>
        /// Continues a running (non-inverted, i.e. pre-conditioned) CRC register over <paramref name="data"/>.
        /// The register convention matches Ionic's _RunningCrc32Result (initial value 0xFFFFFFFF, final ~).
        /// </summary>
        public static uint Update(uint crc, ReadOnlySpan<byte> data)
        {
#if NET8_0_OR_GREATER
            return UpdateUnsafe(crc, data);
#else
            return UpdateSafe(crc, data);
#endif
        }

#if NET8_0_OR_GREATER

        /// <summary>
        /// Pointer-based version of the loop below without bounds checks. Invariants: every table index is
        /// (k * 256 + a byte value) with k in [0, 15], so it is always inside the 4096-entry table, and data
        /// reads never go past <c>data.Length</c> (the 16-byte loop requires 16 remaining bytes).
        /// </summary>
        private static unsafe uint UpdateUnsafe(uint crc, ReadOnlySpan<byte> data)
        {
            fixed (uint* t = Table)
            fixed (byte* start = data)
            {
                byte* p = start;
                byte* end = start + data.Length;
                while (end - p >= 16)
                {
                    uint a = crc ^ System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(new ReadOnlySpan<byte>(p, 4));
                    crc = t[15 * 256 + (a & 0xFF)] ^
                          t[14 * 256 + ((a >> 8) & 0xFF)] ^
                          t[13 * 256 + ((a >> 16) & 0xFF)] ^
                          t[12 * 256 + (a >> 24)] ^
                          t[11 * 256 + p[4]] ^
                          t[10 * 256 + p[5]] ^
                          t[9 * 256 + p[6]] ^
                          t[8 * 256 + p[7]] ^
                          t[7 * 256 + p[8]] ^
                          t[6 * 256 + p[9]] ^
                          t[5 * 256 + p[10]] ^
                          t[4 * 256 + p[11]] ^
                          t[3 * 256 + p[12]] ^
                          t[2 * 256 + p[13]] ^
                          t[1 * 256 + p[14]] ^
                          t[p[15]];
                    p += 16;
                }
                while (p < end)
                    crc = (crc >> 8) ^ t[(crc ^ *p++) & 0xFF];
                return crc;
            }
        }
#endif

        /// <summary>Portable (bounds-checked) implementation; used where the pointer loop is not compiled.</summary>
        internal static uint UpdateSafe(uint crc, ReadOnlySpan<byte> data)
        {
            var t = Table;
            int i = 0;
            int len = data.Length;
            while (len - i >= 16)
            {
                uint a = crc ^ (uint)(data[i] | data[i + 1] << 8 | data[i + 2] << 16 | data[i + 3] << 24);
                crc = t[15 * 256 + (a & 0xFF)] ^
                      t[14 * 256 + ((a >> 8) & 0xFF)] ^
                      t[13 * 256 + ((a >> 16) & 0xFF)] ^
                      t[12 * 256 + (a >> 24)] ^
                      t[11 * 256 + data[i + 4]] ^
                      t[10 * 256 + data[i + 5]] ^
                      t[9 * 256 + data[i + 6]] ^
                      t[8 * 256 + data[i + 7]] ^
                      t[7 * 256 + data[i + 8]] ^
                      t[6 * 256 + data[i + 9]] ^
                      t[5 * 256 + data[i + 10]] ^
                      t[4 * 256 + data[i + 11]] ^
                      t[3 * 256 + data[i + 12]] ^
                      t[2 * 256 + data[i + 13]] ^
                      t[1 * 256 + data[i + 14]] ^
                      t[data[i + 15]];
                i += 16;
            }
            for (; i < len; i++)
                crc = (crc >> 8) ^ t[(crc ^ data[i]) & 0xFF];
            return crc;
        }
    }
}
