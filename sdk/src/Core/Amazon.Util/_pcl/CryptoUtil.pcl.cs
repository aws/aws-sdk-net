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
            private static string Sha256Name = HashAlgorithm.Sha256.ToString();
            private static string Md5Name = HashAlgorithm.Md5.ToString();

            public byte[] ComputeSHA256Hash(byte[] data)
            {
                return ComputeHash(data, Sha256Name);
            }

            public byte[] ComputeSHA256Hash(Stream steam)
            {
                return ComputeHash(steam, Sha256Name);
            }

            public byte[] ComputeMD5Hash(byte[] data)
            {
                return ComputeHash(data, Md5Name);
            }

            public byte[] ComputeMD5Hash(Stream steam)
            {
                return ComputeHash(steam, Md5Name);
            }

            private byte[] ComputeHash(byte[] data, string algorithmName)
            {
                //IBuffer inputBuffer = CryptographicBuffer.CreateFromByteArray(data);

                //var hasher = HashAlgorithmProvider.OpenAlgorithm(algorithmName);
                //var outputBuffer = hasher.HashData(inputBuffer);

                //byte[] hash;
                //CryptographicBuffer.CopyToByteArray(outputBuffer, out hash);
                //return hash;

                using (var wrapper = new HashingWrapper(algorithmName))
                {
                    return wrapper.ComputeHash(data);
                }
            }

            private byte[] ComputeHash(Stream steam, string algorithmName)
            {
                //var hasher = HashAlgorithmProvider.OpenAlgorithm(algorithmName);
                //var hash = hasher.CreateHash();

                //int bytesRead = 0;
                //var cryptoBuffer = CryptographicBuffer.CreateFromByteArray(new byte[AWSSDKUtils.DefaultBufferSize]);
                //byte[] buffer = new byte[AWSSDKUtils.DefaultBufferSize];
                //while ((bytesRead = steam.Read(buffer, 0, buffer.Length)) != 0)
                //{
                //    if (bytesRead != cryptoBuffer.Length)
                //        cryptoBuffer = CryptographicBuffer.CreateFromByteArray(new byte[bytesRead]);

                //    buffer.CopyTo(0, cryptoBuffer, 0, bytesRead);
                //    hash.Append(cryptoBuffer);
                //}

                ////return hash.GetValueAndReset().ToArray();

                //byte[] bytes;
                //CryptographicBuffer.CopyToByteArray(hash, out bytes);
                //return bytes;

                using(var wrapper = new HashingWrapper(algorithmName))
                {
                    return wrapper.ComputeHash(steam);
                }
            }

            public string HMACSign(string data, string key, SigningAlgorithm algorithmName)
            {
                var binaryData = Encoding.UTF8.GetBytes(data);
                return HMACSign(binaryData, key, algorithmName);
            }

            public string HMACSign(byte[] data, string key, SigningAlgorithm algorithmName)
            {                
                //var crypt = MacAlgorithmProvider.OpenAlgorithm(ConvertToAlgorithName(algorithmName));
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

                //IBuffer dataBuffer = CryptographicBuffer.CreateFromByteArray(data);
                var dataBuffer = WinRTCrypto.CryptographicBuffer.CreateFromByteArray(data);
                //var keyBuffer = CryptographicBuffer.ConvertStringToBinary(key, BinaryStringEncoding.Utf8);
                var keyBuffer = WinRTCrypto.CryptographicBuffer.ConvertStringToBinary(key, Encoding.UTF8);
                var cryptoKey = crypt.CreateKey(keyBuffer);

                //var sigBuffer = CryptographicEngine.Sign(cryptoKey, dataBuffer);
                var sigBuffer = WinRTCrypto.CryptographicEngine.Sign(cryptoKey, dataBuffer);
                //string signature = CryptographicBuffer.EncodeToBase64String(sigBuffer);
                var signature = WinRTCrypto.CryptographicBuffer.EncodeToBase64String(sigBuffer);
                return signature;
            }

            public byte[] HMACSignBinary(byte[] data, byte[] key, SigningAlgorithm algorithmName)
            {
                //var crypt = MacAlgorithmProvider.OpenAlgorithm(ConvertToAlgorithName(algorithmName));
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

            //string ConvertToAlgorithName(SigningAlgorithm algorithm)
            //{
            //    switch (algorithm)
            //    {
            //        case SigningAlgorithm.HmacSHA256:
            //            return MacAlgorithmNames.HmacSha256;
            //        case SigningAlgorithm.HmacSHA1:
            //            return MacAlgorithmNames.HmacSha1;
            //        default:
            //            throw new Exception("Unknown signing algorithm: " + algorithm.ToString());
            //    }
            //}

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
        }
    }
}
