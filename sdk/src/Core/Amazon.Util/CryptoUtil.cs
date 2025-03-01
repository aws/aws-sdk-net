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
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Util.Internal;
using AWSSDK.Runtime.Internal.Util;
using System;
using System.Buffers;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using ThirdParty.MD5;

namespace Amazon.Util
{
    public static partial class CryptoUtilFactory
    {
        private const int SHA1_BASE64_LENGTH = 28;
        private const int SHA56_BASE64_LENGTH = 44;
        private const int CRC32_BASE64_LENGTH = 8;
        private const int CRC64NVME_BASE64_LENGTH = 12;

        static CryptoUtil util = new CryptoUtil();

        public static ICryptoUtil CryptoInstance
        {
            get { return util; }
        }

        /// <summary>
        /// Returns a new instance of the specified hashing algorithm
        /// </summary>
        /// <param name="algorithm">Hashing algorithm to instantiate</param>
        /// <returns>New instance of the given algorithm</returns>
        public static HashAlgorithm GetChecksumInstance(CoreChecksumAlgorithm algorithm)
        {
            switch (algorithm)
            {
                case CoreChecksumAlgorithm.SHA1:
                    // Disable this warning of SHA1 being obsolete because we have some use cases we need it.
#pragma warning disable SYSLIB0021
                    return new SHA1Managed();
#pragma warning restore

                case CoreChecksumAlgorithm.SHA256:
                    return CryptoUtil.CreateSHA256Instance();

                case CoreChecksumAlgorithm.CRC32:
                    return new Crc32Managed();

                case CoreChecksumAlgorithm.CRC32C:
                    return new CrtCrc32c();

                case CoreChecksumAlgorithm.CRC64NVME:
                    return new CrtCrc64NVME();

                default:
                    throw new AmazonClientException($"Unable to instantiate checksum algorithm {algorithm}");
            }
        }

        /// <summary>
        /// Returns the length of the base64 encoded checksum of the specifed hashing algorithm
        /// </summary>
        /// <param name="algorithm">Hashing algorithm </param>
        /// <returns>Length of the base64 encoded checksum</returns>
        public static int GetChecksumBase64Length(CoreChecksumAlgorithm algorithm)
        {
            switch (algorithm)
            {
                case CoreChecksumAlgorithm.SHA1:
                    return SHA1_BASE64_LENGTH;
                case CoreChecksumAlgorithm.SHA256:
                    return SHA56_BASE64_LENGTH;
                case CoreChecksumAlgorithm.CRC32:
                case CoreChecksumAlgorithm.CRC32C:
                    return CRC32_BASE64_LENGTH;
                case CoreChecksumAlgorithm.CRC64NVME:
                    return CRC64NVME_BASE64_LENGTH;
                default:
                    throw new AmazonClientException($"Unable to determine the base64-encoded length of {algorithm}");
            }
        }

        partial class CryptoUtil : ICryptoUtil
        {
            internal CryptoUtil()
            {
            }

            /// <summary>
            /// Computes a hash-based message authentication code
            /// </summary>
            /// <param name="data">Input to compute the hash code for</param>
            /// <param name="key">Signing key</param>
            /// <param name="algorithmName">Hashing algorithm to use</param>
            /// <returns>Computed hash code</returns>
            public string HMACSign(string data, string key, SigningAlgorithm algorithmName)
            {
                Encoding encoding = Encoding.UTF8;
                int maxSize = encoding.GetMaxByteCount(data.Length);
                byte[] buffer = ArrayPool<byte>.Shared.Rent(maxSize);

                try
                {
                    int size = encoding.GetBytes(data, 0, data.Length, buffer, 0);
                    ArraySegment<byte> binaryData = new ArraySegment<byte>(buffer, 0, size);

                    return HMACSign(binaryData, key, algorithmName);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }

            /// <summary>
            /// Computes a SHA1 hash
            /// </summary>
            /// <param name="data">Input to compute the hash code for</param>
            /// <returns>Computed hash code</returns>
            public byte[] ComputeSHA1Hash(byte[] data)
            {
// Disable this warning of SHA1 being obsolete because we have some use cases we need it.
#pragma warning disable SYSLIB0021
                using (var sha1 = new SHA1Managed())
                {
                    return sha1.ComputeHash(data);
                }
#pragma warning restore SYSLIB0021
            }

            /// <summary>
            /// Computes a SHA256 hash
            /// </summary>
            /// <param name="data">Input to compute the hash code for</param>
            /// <returns>Computed hash code</returns>
            public byte[] ComputeSHA256Hash(byte[] data)
            {
                return SHA256HashAlgorithmInstance.ComputeHash(data);
            }

            /// <summary>
            /// Computes a SHA256 hash
            /// </summary>
            /// <param name="steam">Input to compute the hash code for</param>
            /// <returns>Computed hash code</returns>
            public byte[] ComputeSHA256Hash(Stream steam)
            {
                return SHA256HashAlgorithmInstance.ComputeHash(steam);
            }

            /// <summary>
            /// Computes an MD5 hash
            /// </summary>
            /// <param name="data">Input to compute the hash code for</param>
            /// <returns>Computed hash code</returns>
            public byte[] ComputeMD5Hash(byte[] data)
            {
                var hashed = new MD5Managed().ComputeHash(data);
                return hashed;
            }

            /// <summary>
            /// Computes an MD5 hash
            /// </summary>
            /// <param name="steam">Input to compute the hash code for</param>
            /// <returns>Computed hash code</returns>
            public byte[] ComputeMD5Hash(Stream steam)
            {
                var hashed = new MD5Managed().ComputeHash(steam);
                return hashed;
            }

            /// <summary>
            /// Computes a CRC32 hash
            /// </summary>
            /// <param name="data">Data to hash</param>
            /// <returns>CRC32 hash as a base64-encoded string</returns>
            public string ComputeCRC32Hash(byte[] data)
            {
                var hashed = new Crc32Managed().ComputeHash(data);
                return Convert.ToBase64String(hashed);
            }

            /// <summary>
            /// Computes a CRC32C hash
            /// </summary>
            /// <param name="data">Data to hash</param>
            /// <returns>CRC32C hash as a base64-encoded string</returns>
            public string ComputeCRC32CHash(byte[] data)
            {
                return ChecksumCRTWrapper.Crc32C(data);
            }

            /// <summary>
            /// Computes a CRC64NVME hash
            /// </summary>
            /// <param name="data">Data to hash</param>
            /// <returns>CRC64NVME hash as a base64-encoded string</returns>
            public string ComputeCRC64NVMEHash(byte[] data)
            {
                return ChecksumCRTWrapper.Crc64NVME(data);
            }

            public string HMACSign(byte[] data, string key, SigningAlgorithm algorithmName)
                => HMACSign(new ArraySegment<byte>(data, 0, data.Length), key, algorithmName);

            private string HMACSign(ArraySegment<byte> data, string key, SigningAlgorithm algorithmName)
            {
                if (String.IsNullOrEmpty(key))
                    throw new ArgumentNullException("key", "Please specify a Secret Signing Key.");

                if (data == null || data.Count == 0)
                    throw new ArgumentNullException("data", "Please specify data to sign.");

                KeyedHashAlgorithm algorithm = CreateKeyedHashAlgorithm(algorithmName);
                if (null == algorithm)
                    throw new InvalidOperationException("Please specify a KeyedHashAlgorithm to use.");

                try
                {
                    algorithm.Key = Encoding.UTF8.GetBytes(key);
                    byte[] bytes = algorithm.ComputeHash(data.Array, data.Offset, data.Count);
                    return Convert.ToBase64String(bytes);
                }
                finally
                {
                    algorithm.Dispose();
                }
            }

            public byte[] HMACSignBinary(byte[] data, byte[] key, SigningAlgorithm algorithmName)
            {
                if (key == null || key.Length == 0)
                    throw new ArgumentNullException("key", "Please specify a Secret Signing Key.");

                if (data == null || data.Length == 0)
                    throw new ArgumentNullException("data", "Please specify data to sign.");

                KeyedHashAlgorithm algorithm = CreateKeyedHashAlgorithm(algorithmName);
                if (null == algorithm)
                    throw new InvalidOperationException("Please specify a KeyedHashAlgorithm to use.");

                try
                {
                    algorithm.Key = key;
                    byte[] bytes = algorithm.ComputeHash(data);
                    return bytes;
                }
                finally
                {
                    algorithm.Dispose();
                }
            }

            static KeyedHashAlgorithm CreateKeyedHashAlgorithm(SigningAlgorithm algorithmName)
            {
                KeyedHashAlgorithm algorithm;
                switch (algorithmName)
                {
                    case SigningAlgorithm.HmacSHA256:
                        algorithm = new HMACSHA256();
                        break;
                    case SigningAlgorithm.HmacSHA1:
                        algorithm = new HMACSHA1();
                        break;
                    default:
                        throw new Exception(string.Format("KeyedHashAlgorithm {0} was not found.", algorithmName.ToString()));
                }

                return algorithm;
            }

            [ThreadStatic]
            private static HashAlgorithm _hashAlgorithm = null;
            private static HashAlgorithm SHA256HashAlgorithmInstance
            {
                get
                {
                    if (null == _hashAlgorithm)
                    {
                        _hashAlgorithm = CreateSHA256Instance();
                    }
                    return _hashAlgorithm;
                }
            }

            internal static HashAlgorithm CreateSHA256Instance()
            {
                return SHA256.Create();
            }
        }
    }
}
