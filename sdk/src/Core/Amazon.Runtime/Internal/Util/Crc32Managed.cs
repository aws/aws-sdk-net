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
using System.Security.Cryptography;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Implementation of CRC32 as a <see cref="HashAlgorithm"/> (without using the CRT dependency).
    /// </summary>
    /// <remarks>
    /// On .NET 10 and later this uses System.IO.Hashing, which is vectorized (tens of GB/s). The System.IO.Hashing
    /// builds used by the .NET 8, netstandard2.0 and .NET Framework targets compute CRC32 about as slowly as a
    /// byte-at-a-time table, so those targets use the slicing-by-16 implementation in <see cref="Crc32Slicing"/>
    /// (roughly 3-6x faster there). Both produce identical values.
    /// </remarks>
    public class Crc32Managed : HashAlgorithm
    {
#if NET10_0_OR_GREATER
        private System.IO.Hashing.Crc32 _crc32;

        public Crc32Managed()
        {
            _crc32 = new System.IO.Hashing.Crc32(System.IO.Hashing.Crc32ParameterSet.Crc32);
        }

        public override void Initialize()
        {
            _crc32.Reset();
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            _crc32.Append(array.AsSpan(ibStart, cbSize));
        }

        protected override byte[] HashFinal()
        {
            var result = _crc32.GetHashAndReset();

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(result);
            }

            return result;
        }
#else
        private const uint InitialValue = 0xFFFFFFFF;
        private uint _runningCrc32 = InitialValue;

        public Crc32Managed()
        {
        }

        public override void Initialize()
        {
            _runningCrc32 = InitialValue;
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            _runningCrc32 = Crc32Slicing.Update(_runningCrc32, new ReadOnlySpan<byte>(array, ibStart, cbSize));
        }

        protected override byte[] HashFinal()
        {
            // Big-endian, matching the System.IO.Hashing path above after its byte reversal.
            uint crc = ~_runningCrc32;
            _runningCrc32 = InitialValue; // GetHashAndReset semantics
            return new[] { (byte)(crc >> 24), (byte)(crc >> 16), (byte)(crc >> 8), (byte)crc };
        }
#endif
    }
}
