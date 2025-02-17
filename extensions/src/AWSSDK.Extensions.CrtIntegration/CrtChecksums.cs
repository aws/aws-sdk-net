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

using Amazon.Runtime.SharedInterfaces.Internal;
using Aws.Crt.Checksums;
using System;

namespace AWSSDK.Extensions.CrtIntegration
{
    /// <summary>
    /// Wrapper for checksum algorithms provided by Aws.Crt.Checksums
    /// </summary>
    public class CrtChecksums : IChecksumProvider
    {
        /// <summary>
        /// Computes a CRC32 hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <returns>CRC32 hash as a base64-encoded string</returns>
        public string Crc32(byte[] source) => ConvertUintChecksumToBase64(Crc.crc32(source));

        /// <summary>
        /// Computes a CRC32 hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <param name="previous">Previous value of a rolling checksum</param>
        /// <returns>Updated CRC32 hash as 32-bit integer</returns>
        public uint Crc32(byte[] source, uint previous) => Crc.crc32(source, previous);

        /// <summary>
        /// Computes a CRC32C hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <returns>CRC32C hash as a base64-encoded string</returns>
        public string Crc32C(byte[] source) => ConvertUintChecksumToBase64(Crc.crc32c(source));

        /// <summary>
        /// Computes a CRC32C hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <param name="previous">Previous value of a rolling checksum</param>
        /// <returns>Updated CRC32C hash as 32-bit integer</returns>
        public uint Crc32C(byte[] source, uint previous) => Crc.crc32c(source, previous);

        /// <summary>
        /// Computes a CRC64NVME hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <returns>Crc64NVME hash as a base64-encoded string</returns>
        public string Crc64NVME(byte[] source) => ConvertUlongChecksumToBase64(Crc.crc64nvme(source));
        
        /// <summary>
        /// Computes a CRC64NVME hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <param name="previous">Previous value of a rolling checksum</param>
        /// <returns>Updated Crc64NVME hash as 64-bit integer</returns>
        public ulong Crc64NVME(byte[] source, ulong previous) => Crc.crc64nvme(source, previous);

        /// <summary>
        /// Converts the 32-bit checksum from CRT into a base-64 string
        /// </summary>
        /// <param name="checksum">32-bit checksum</param>
        /// <returns>Checksum as a base64-encoded string</returns>
        private string ConvertUintChecksumToBase64(uint checksum)
        {
            var bytes = BitConverter.GetBytes(checksum);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// Converts the 64-bit checksum from CRT into a base-64 string
        /// </summary>
        /// <param name="checksum">64-bit checksum</param>
        /// <returns>Checksum as a base64-encoded string</returns>
        private string ConvertUlongChecksumToBase64(ulong checksum)
        {
            var bytes = BitConverter.GetBytes(checksum);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return Convert.ToBase64String(bytes);
        }
    }
}
