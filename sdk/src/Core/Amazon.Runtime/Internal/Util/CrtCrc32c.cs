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
using AWSSDK.Runtime.Internal.Util;
using System;
using System.Security.Cryptography;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Implementation of CRC32C, using the SDK-wide
    /// instance of AWS Common Runtime's checksums
    /// </summary>
    public class CrtCrc32c : HashAlgorithm
    {
        private uint _rollingResult;

        public override void Initialize()
        {
            _rollingResult = 0;
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            byte[] buffer = new byte[cbSize];
            Buffer.BlockCopy(array, ibStart, buffer, 0, cbSize);
            _rollingResult = ChecksumCRTWrapper.Crc32C(buffer, _rollingResult);
        }

        protected override byte[] HashFinal()
        {
            var result = BitConverter.GetBytes(_rollingResult);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(result);
            }

            return result;
        }
    }
}
