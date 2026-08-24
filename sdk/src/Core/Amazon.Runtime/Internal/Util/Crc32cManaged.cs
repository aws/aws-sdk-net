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
using System.IO.Hashing;
using System.Security.Cryptography;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Implementation of CRC-32C as a <see cref="HashAlgorithm"/> (without using the CRT dependency).
    /// </summary>
    /// <remarks>
    /// This class wraps <see cref="System.IO.Hashing.Crc32"/> configured with <see cref="Crc32ParameterSet.Crc32C"/>.
    /// </remarks>
    public class Crc32cManaged : HashAlgorithm
    {
        private Crc32 _crc32c;

        public Crc32cManaged()
        {
            _crc32c = new Crc32(Crc32ParameterSet.Crc32C);
        }

        public override void Initialize()
        {
            _crc32c.Reset();
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            _crc32c.Append(array.AsSpan(ibStart, cbSize));
        }

        protected override byte[] HashFinal()
        {
            var result = _crc32c.GetHashAndReset();

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(result);
            }

            return result;
        }
    }
}
