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
    /// Produces the same values as <see cref="ThirdParty.Ionic.Zlib.CRC32"/> (IEEE polynomial), computed with
    /// the slicing-by-16 algorithm in <see cref="Crc32Slicing"/>, which processes 16 bytes per step instead of one.
    /// </remarks>
    public class Crc32Managed : HashAlgorithm
    {
        // Running (pre-conditioned) register, same convention as Ionic's _RunningCrc32Result.
        private uint _runningCrc32 = 0xFFFFFFFF;

        public Crc32Managed()
        {
        }

        public override void Initialize()
        {
            // Kept as a no-op to preserve the previous behavior exactly: the running value was never reset here.
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            _runningCrc32 = Crc32Slicing.Update(_runningCrc32, new ReadOnlySpan<byte>(array, ibStart, cbSize));
        }

        protected override byte[] HashFinal()
        {
            var result = BitConverter.GetBytes(unchecked((int)~_runningCrc32));

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(result);
            }

            return result;
        }
    }
}
