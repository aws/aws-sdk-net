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

namespace Amazon.Runtime.SharedInterfaces.Internal
{
    /// <summary>
    /// Interface for an implementation of checksum algorithms
    /// </summary>
    public interface IChecksumProvider
    {
        /// <summary>
        /// Computes a CRC32 hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <returns>CRC32 hash as a base64-encoded string</returns>
        string Crc32(byte[] source);

        /// <summary>
        /// Computes a CRC32 hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <param name="previous">Previous value of a rolling checksum</param>
        /// <returns>Updated CRC32 hash as 32-bit integer</returns>
        uint Crc32(byte[] source, uint previous);

        /// <summary>
        /// Computes a CRC32C hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <returns>CRC32C hash as a base64-encoded string</returns>
        string Crc32C(byte[] source);

        /// <summary>
        /// Computes a CRC32C hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <param name="previous">Previous value of a rolling checksum</param>
        /// <returns>Updated CRC32C hash as 32-bit integer</returns>
        uint Crc32C(byte[] source, uint previous);

        /// <summary>
        /// Computes a CRC64NVME hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <returns>CRC64NVME hash as a base64-encoded string</returns>
        string Crc64NVME(byte[] source);

        /// <summary>
        /// Computes a CRC64NVME hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <param name="previous">Previous value of a rolling checksum</param>
        /// <returns>Updated CRC64NVME hash as 64-bit integer</returns>
        ulong Crc64NVME(byte[] source, ulong previous);
    }
}
