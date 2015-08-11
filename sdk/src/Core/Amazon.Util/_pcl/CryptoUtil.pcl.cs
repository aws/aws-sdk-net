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

using System.Runtime.InteropServices.WindowsRuntime;
//using Windows.Security.Cryptography;
//using Windows.Security.Cryptography.Core;
//using Windows.Storage.Streams;

using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using PCLCrypto;

namespace Amazon.Util
{
    public static partial class CryptoUtilFactory
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
                var crypt = WinRTCrypto.MacAlgorithmProvider.OpenAlgorithm(Convert(algorithmName));

                if (String.IsNullOrEmpty(key))
                {
                    throw new ArgumentNullException("key", "Please specify a Secret Signing Key.");
                }

                if (data == null || data.Length == 0)
                {
                    throw new ArgumentNullException("data", "Please specify data to sign.");
                }

                if (null == crypt)
                {
                    throw new ArgumentNullException("algorithm", "Please specify a KeyedHashAlgorithm to use.");
                }

                var dataBuffer = WinRTCrypto.CryptographicBuffer.CreateFromByteArray(data);
                var keyBuffer = WinRTCrypto.CryptographicBuffer.ConvertStringToBinary(key, Encoding.UTF8);
                var cryptoKey = crypt.CreateKey(keyBuffer);

                var sigBuffer = WinRTCrypto.CryptographicEngine.Sign(cryptoKey, dataBuffer);
                var signature = WinRTCrypto.CryptographicBuffer.EncodeToBase64String(sigBuffer);
                return signature;
            }

            public byte[] HMACSignBinary(byte[] data, byte[] key, SigningAlgorithm algorithmName)
            {
                var crypt = WinRTCrypto.MacAlgorithmProvider.OpenAlgorithm(Convert(algorithmName));

                if (key == null || key.Length == 0)
                {
                    throw new ArgumentNullException("key", "Please specify a Secret Signing Key.");
                }

                if (data == null || data.Length == 0)
                {
                    throw new ArgumentNullException("data", "Please specify data to sign.");
                }

                if (null == crypt)
                {
                    throw new ArgumentNullException("algorithm", "Please specify a KeyedHashAlgorithm to use.");
                }

                var dataBuffer = WinRTCrypto.CryptographicBuffer.CreateFromByteArray(data);
                var keyBuffer = WinRTCrypto.CryptographicBuffer.CreateFromByteArray(key);
                var cryptoKey = crypt.CreateKey(keyBuffer);

                var sigBuffer = WinRTCrypto.CryptographicEngine.Sign(cryptoKey, dataBuffer);
                byte[] result;
                WinRTCrypto.CryptographicBuffer.CopyToByteArray(sigBuffer, out result);
                return result;
            }

            public byte[] ComputeSHA256Hash(byte[] data)
            {
                return SHA256HashAlgorithmInstance.HashData(data);
            }

            public byte[] ComputeSHA256Hash(Stream stream)
            {
                using (var hash = SHA256HashAlgorithmInstance.CreateHash())
                {
                    int bytesRead = 0;
                    byte[] buffer = new byte[AWSSDKUtils.DefaultBufferSize];
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        Append(hash, bytesRead, buffer);
                    }

                    return hash.GetValueAndReset();
                }
            }

            // Appends a given number of bytes to the hash
            private static void Append(CryptographicHash hash, int bytesRead, byte[] buffer)
            {
                if (bytesRead == buffer.Length)
                {
                    // append the whole buffer
                    hash.Append(buffer);
                }
                else
                {
                    // only a part of the buffer should be appended, so need a smaller buffer
                    var partialBuffer = new byte[bytesRead];
                    Array.Copy(buffer, partialBuffer, bytesRead);
                    hash.Append(partialBuffer);
                }
            }

            public byte[] ComputeMD5Hash(byte[] data)
            {
                using (var wrapper = new HashingWrapperMD5())
                {
                    return wrapper.ComputeHash(data);
                }
            }

            public byte[] ComputeMD5Hash(Stream stream)
            {
                using (var wrapper = new HashingWrapperMD5())
                {
                    return wrapper.ComputeHash(stream);
                }
            }

            MacAlgorithm Convert(SigningAlgorithm algorithm)
            {
                switch (algorithm)
                {
                    case SigningAlgorithm.HmacSHA256:
                        return MacAlgorithm.HmacSha256;
                    case SigningAlgorithm.HmacSHA1:
                        return MacAlgorithm.HmacSha1;
                    default:
                        throw new Exception("Unknown signing algorithm: " + algorithm.ToString());
                }
            }

            [ThreadStatic]
            private static IHashAlgorithmProvider _hashAlgorithm = null;
            private static IHashAlgorithmProvider SHA256HashAlgorithmInstance
            {
                get
                {
                    if (null == _hashAlgorithm)
                        _hashAlgorithm = PCLCrypto.WinRTCrypto.HashAlgorithmProvider.OpenAlgorithm(HashAlgorithm.Sha256);
                    return _hashAlgorithm;
                }
            }
        }
    }
}
