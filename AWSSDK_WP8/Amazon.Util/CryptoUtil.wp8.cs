/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

using Amazon.Runtime;
using ThirdParty.MD5;

namespace Amazon.Util
{
    internal static partial class CryptoUtilFactory
    {
        partial class CryptoUtil : ICryptoUtil
        {
            public string HMACSign(string data, string key, SigningAlgorithm algorithmName)
            {
                var binaryData = Encoding.UTF8.GetBytes(data);
                return HMACSign(binaryData, key, algorithmName);
            }

            public string HMACSign(byte[] data, string key, SigningAlgorithm algorithmName)
            {
                KeyedHashAlgorithm algorithm = CreateKeyedHashAlgorithm(algorithmName);
                if (String.IsNullOrEmpty(key))
                {
                    throw new ArgumentNullException("key", "Please specify a Secret Signing Key.");
                }

                if (data == null || data.Length == 0)
                {
                    throw new ArgumentNullException("data", "Please specify data to sign.");
                }

                if (null == algorithm)
                {
                    throw new ArgumentNullException("algorithm", "Please specify a KeyedHashAlgorithm to use.");
                }

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



            public byte[] ComputeSHA256Hash(byte[] data)
            {
                return CreateHashAlgorithm(SigningAlgorithm.HmacSHA256).ComputeHash(data);
            }

            public byte[] ComputeSHA256Hash(Stream steam)
            {
                return CreateHashAlgorithm(SigningAlgorithm.HmacSHA256).ComputeHash(steam);
            }

            public byte[] ComputeMD5Hash(byte[] data)
            {
                byte[] hashed = MD5Core.GetHash(data);
                return hashed;
            }

            public byte[] ComputeMD5Hash(Stream steam)
            {
                MD5Managed md5 = new MD5Managed();
                byte[] hashed = md5.ComputeHash(steam);
                return hashed;
            }

            public byte[] HMACSignBinary(byte[] data, byte[] key, SigningAlgorithm algorithmName)
            {
                KeyedHashAlgorithm algorithm = CreateKeyedHashAlgorithm(algorithmName);

                if (key == null || key.Length == 0)
                {
                    throw new ArgumentNullException("key", "Please specify a Secret Signing Key.");
                }

                if (data == null || data.Length == 0)
                {
                    throw new ArgumentNullException("data", "Please specify data to sign.");
                }

                if (null == algorithm)
                {
                    throw new ArgumentNullException("algorithm", "Please specify a KeyedHashAlgorithm to use.");
                }

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

            private HashAlgorithm CreateHashAlgorithm(SigningAlgorithm algorithm)
            {
                switch (algorithm)
                {
                    case SigningAlgorithm.HmacSHA256:
                        return new SHA256Managed();
                    case SigningAlgorithm.HmacSHA1:
                        return new SHA1Managed();
                    default:
                        throw new Exception("Unknown algorithm: " + algorithm.ToString());
                }
            }

            private KeyedHashAlgorithm CreateKeyedHashAlgorithm(SigningAlgorithm algorithm)
            {
                switch (algorithm)
                {
                    case SigningAlgorithm.HmacSHA256:
                        return new HMACSHA256();
                    case SigningAlgorithm.HmacSHA1:
                        return new HMACSHA1();
                    default:
                        throw new Exception("Unknown algorithm: " + algorithm.ToString());
                }
            }
        }
    }
}
