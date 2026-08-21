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
using System.Linq;
using System.Security.Cryptography;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Implementation of CRC-64/NVME as a <see cref="HashAlgorithm"/> (without using the CRT dependency).
    /// </summary>
    /// <remarks>
    /// This class wraps <see cref="System.IO.Hashing.Crc64"/> configured with <see cref="Crc64ParameterSet.Nvme"/>.
    /// </remarks>
    public class Crc64NVMEManaged : HashAlgorithm
    {
        private Crc64 _crc64;

        public Crc64NVMEManaged()
        {
            _crc64 = new Crc64(Crc64ParameterSet.Nvme);
        }

        public override void Initialize()
        {
            _crc64.Reset();
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            _crc64.Append(array.AsSpan(ibStart, cbSize));
        }

        protected override byte[] HashFinal()
        {
            var result = _crc64.GetHashAndReset();
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(result);
            }

            return result;
        }
    }
}
