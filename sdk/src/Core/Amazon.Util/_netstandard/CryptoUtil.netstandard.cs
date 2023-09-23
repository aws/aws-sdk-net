/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */
using Amazon.Runtime;
using Amazon.Util.Internal;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Amazon.Util
{
    public static partial class CryptoUtilFactory
    {
        partial class CryptoUtil : ICryptoUtil
        {
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
