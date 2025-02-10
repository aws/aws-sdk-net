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
using ThirdParty.Ionic.Zlib;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Implementation of CRC32 as a <see cref="HashAlgorithm"/> (without using the CRT dependency).
    /// </summary>
    /// <remarks>
    /// This classes uses the components included in the <see cref="ThirdParty.Ionic.Zlib.CRC32"/> class.
    /// </remarks>
    public class Crc32Managed : HashAlgorithm
    {
        private readonly CRC32 _crc32;

        public Crc32Managed()
        {
            _crc32 = new CRC32();
        }

        public override void Initialize() 
        {
            // Each instance of CRC32 contains its own Crc32Result property, so we don't need to reset it here.
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            _crc32.SlurpBlock(array, ibStart, cbSize);
        }

        protected override byte[] HashFinal()
        {
            var result = BitConverter.GetBytes(_crc32.Crc32Result);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(result);
            }

            return result;
        }
    }
}
