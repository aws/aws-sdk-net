// Adapted from https://github.com/dotnet/runtime/blob/main/src/libraries/System.IO.Hashing/src/System/IO/Hashing/Crc32.Vectorized.cs
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// Folding constants are from Intel's "Fast CRC Computation for Generic Polynomials Using PCLMULQDQ
// Instruction" (Gopal et al., 2009) for the reflected IEEE 802.3 polynomial.

#if NET8_0_OR_GREATER
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace ThirdParty.RuntimeBackports
{
    internal static class Crc32Pclmulqdq
    {
        internal static bool IsSupported => Pclmulqdq.IsSupported && Sse2.IsSupported;

        /// <summary>
        /// Updates the raw (non-inverted) CRC-32 register over <paramref name="source"/>.
        /// The length must be a non-zero multiple of 16.
        /// </summary>
        internal static uint UpdateBlocks(uint crc, ReadOnlySpan<byte> source)
        {
            if (source.Length < 16 || (source.Length & 15) != 0)
                throw new ArgumentException("Length must be a non-zero multiple of 16.", nameof(source));

            ref byte src = ref MemoryMarshal.GetReference(source);
            int length = source.Length;

            Vector128<ulong> x0, x1, x2, x3, x4, x5, x6, x7, x8;

            if (length >= 64)
            {
                x1 = Load(ref src, 0);
                x2 = Load(ref src, 16);
                x3 = Load(ref src, 32);
                x4 = Load(ref src, 48);
                x1 ^= Vector128.CreateScalar(crc).AsUInt64();

                // k1, k2: fold by 4 x 128 bits
                x0 = Vector128.Create(0x0154442bd4UL, 0x01c6e41596UL);

                src = ref Unsafe.Add(ref src, 64);
                length -= 64;

                while (length >= 64)
                {
                    x5 = Pclmulqdq.CarrylessMultiply(x1, x0, 0x00);
                    x6 = Pclmulqdq.CarrylessMultiply(x2, x0, 0x00);
                    x7 = Pclmulqdq.CarrylessMultiply(x3, x0, 0x00);
                    x8 = Pclmulqdq.CarrylessMultiply(x4, x0, 0x00);

                    x1 = Pclmulqdq.CarrylessMultiply(x1, x0, 0x11);
                    x2 = Pclmulqdq.CarrylessMultiply(x2, x0, 0x11);
                    x3 = Pclmulqdq.CarrylessMultiply(x3, x0, 0x11);
                    x4 = Pclmulqdq.CarrylessMultiply(x4, x0, 0x11);

                    x1 ^= x5 ^ Load(ref src, 0);
                    x2 ^= x6 ^ Load(ref src, 16);
                    x3 ^= x7 ^ Load(ref src, 32);
                    x4 ^= x8 ^ Load(ref src, 48);

                    src = ref Unsafe.Add(ref src, 64);
                    length -= 64;
                }

                // k3, k4: fold by 1 x 128 bits
                x0 = Vector128.Create(0x01751997d0UL, 0x00ccaa009eUL);

                x5 = Pclmulqdq.CarrylessMultiply(x1, x0, 0x00);
                x1 = Pclmulqdq.CarrylessMultiply(x1, x0, 0x11);
                x1 ^= x2 ^ x5;

                x5 = Pclmulqdq.CarrylessMultiply(x1, x0, 0x00);
                x1 = Pclmulqdq.CarrylessMultiply(x1, x0, 0x11);
                x1 ^= x3 ^ x5;

                x5 = Pclmulqdq.CarrylessMultiply(x1, x0, 0x00);
                x1 = Pclmulqdq.CarrylessMultiply(x1, x0, 0x11);
                x1 ^= x4 ^ x5;
            }
            else
            {
                x1 = Load(ref src, 0);
                x1 ^= Vector128.CreateScalar(crc).AsUInt64();

                x0 = Vector128.Create(0x01751997d0UL, 0x00ccaa009eUL);

                src = ref Unsafe.Add(ref src, 16);
                length -= 16;
            }

            while (length >= 16)
            {
                x2 = Load(ref src, 0);

                x5 = Pclmulqdq.CarrylessMultiply(x1, x0, 0x00);
                x1 = Pclmulqdq.CarrylessMultiply(x1, x0, 0x11);
                x1 ^= x2 ^ x5;

                src = ref Unsafe.Add(ref src, 16);
                length -= 16;
            }

            // Fold 128 bits to 64 bits.
            x2 = Pclmulqdq.CarrylessMultiply(x1, x0, 0x10);
            x1 = Sse2.ShiftRightLogical128BitLane(x1, 8) ^ x2;

            // Fold 64 bits to 32 bits with k5.
            Vector128<ulong> mask32 = Vector128.CreateScalar(0xFFFFFFFFUL);
            x0 = Vector128.CreateScalar(0x0163cd6124UL);
            x2 = Sse2.ShiftRightLogical128BitLane(x1, 4);
            x1 &= mask32;
            x1 = Pclmulqdq.CarrylessMultiply(x1, x0, 0x00);
            x1 ^= x2;

            // Barrett reduction to 32 bits: P' (low) and mu (high).
            x0 = Vector128.Create(0x01db710641UL, 0x01f7011641UL);
            x2 = x1 & mask32;
            x2 = Pclmulqdq.CarrylessMultiply(x2, x0, 0x10);
            x2 &= mask32;
            x2 = Pclmulqdq.CarrylessMultiply(x2, x0, 0x00);
            x1 ^= x2;

            return x1.AsUInt32().GetElement(1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Vector128<ulong> Load(ref byte source, int offset)
        {
            return Vector128.LoadUnsafe(ref source, (nuint)offset).AsUInt64();
        }
    }
}
#endif
