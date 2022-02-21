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
using Amazon.Util.Internal;
using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Amazon.Util
{
    public static partial class CryptoUtilFactory
    {
        partial class CryptoUtil : ICryptoUtil
        {
            /// <summary>
            /// Computes a hash-based message authentication code
            /// </summary>
            /// <param name="data">Input to compute the hash code for</param>
            /// <param name="key">Signing key</param>
            /// <param name="algorithmName">Hashing algorithm to use</param>
            /// <returns>Computed hash code in base-64</returns>
            public string HMACSign(byte[] data, string key, SigningAlgorithm algorithmName)
            {
                if (String.IsNullOrEmpty(key))
                    throw new ArgumentNullException("key", "Please specify a Secret Signing Key.");

                if (data == null || data.Length == 0)
                    throw new ArgumentNullException("data", "Please specify data to sign.");

                KeyedHashAlgorithm algorithm = KeyedHashAlgorithm.Create(algorithmName.ToString().ToUpper(CultureInfo.InvariantCulture));
                if (null == algorithm)
                    throw new InvalidOperationException("Please specify a KeyedHashAlgorithm to use.");

                try
                {
                    algorithm.Key = Encoding.UTF8.GetBytes(key);
                    byte[] bytes = algorithm.ComputeHash(data);
                    return Convert.ToBase64String(bytes);
                }
                finally
                {
                    algorithm.Clear();
                }
            }

            /// <summary>
            /// Computes a hash-based message authentication code
            /// </summary>
            /// <param name="data">Input to compute the hash code for</param>
            /// <param name="key">Signing key</param>
            /// <param name="algorithmName">Hashing algorithm to use</param>
            /// <returns>Computed hash code in bytes</returns>
            public byte[] HMACSignBinary(byte[] data, byte[] key, SigningAlgorithm algorithmName)
            {
                if (key == null || key.Length == 0)
                    throw new ArgumentNullException("key", "Please specify a Secret Signing Key.");

                if (data == null || data.Length == 0)
                    throw new ArgumentNullException("data", "Please specify data to sign.");

                KeyedHashAlgorithm algorithm = KeyedHashAlgorithm.Create(algorithmName.ToString().ToUpper(CultureInfo.InvariantCulture));
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
                    algorithm.Clear();
                }
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
                try
                {
                    return HashAlgorithm.Create("SHA-256");
                }
                catch (Exception) // Managed Hash Provider is not FIPS compliant.
                {
                    return new SHA256CryptoServiceProvider();
                }
            }
        }
    }
}
