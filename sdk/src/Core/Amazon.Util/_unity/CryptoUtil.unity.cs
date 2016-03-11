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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

using Amazon.Runtime;
using ThirdParty.MD5;

namespace Amazon.Util
{
    public static partial class CryptoUtilFactory
    {
        private static HashSet<string> _initializedAlgorithmNames = new HashSet<string>();
        private static object _keyedHashAlgorithmCreationLock = new object();

        partial class CryptoUtil : ICryptoUtil
        {
            public string HMACSign(string data, string key, SigningAlgorithm algorithmName)
            {
                var binaryData = Encoding.UTF8.GetBytes(data);
                return HMACSign(binaryData, key, algorithmName);
            }

            /// <summary>
            /// The iOS il2cpp implementation of System.Security.Cryptography.RandomNumberGenerator,
            /// which is called by the initialization of KeyedHashAlgorithm.Create for a given
            /// algorithm name, is not threadsafe. We keep track of which algorithms have been
            /// initialized, and retain a lock if this is the first time we create a particular
            /// algorithm.
            /// </summary>
            /// <param name="algorithmName"></param>
            /// <returns></returns>
            private KeyedHashAlgorithm ThreadSafeCreateKeyedHashedAlgorithm(SigningAlgorithm algorithmName)
            {
                string algorithmNameUpper = algorithmName.ToString().ToUpper(CultureInfo.InvariantCulture);
                KeyedHashAlgorithm algorithm = null;
                bool firstCreation = true;
                lock (_keyedHashAlgorithmCreationLock)
                {
                    firstCreation = !_initializedAlgorithmNames.Contains(algorithmNameUpper);

                    if (firstCreation)
                    {
                        algorithm = KeyedHashAlgorithm.Create(algorithmNameUpper);
                        _initializedAlgorithmNames.Add(algorithmNameUpper);
                    }
                }
                if (!firstCreation)
                {
                    algorithm = KeyedHashAlgorithm.Create(algorithmNameUpper);
                }
                return algorithm;
            }

            public string HMACSign(byte[] data, string key, SigningAlgorithm algorithmName)
            {
                if (String.IsNullOrEmpty(key))
                    throw new ArgumentNullException("key", "Please specify a Secret Signing Key.");

                if (data == null || data.Length == 0)
                    throw new ArgumentNullException("data", "Please specify data to sign.");

                KeyedHashAlgorithm algorithm = ThreadSafeCreateKeyedHashedAlgorithm(algorithmName);

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

            public byte[] ComputeSHA256Hash(byte[] data)
            {
                return SHA256HashAlgorithmInstance.ComputeHash(data);
            }

            public byte[] ComputeSHA256Hash(Stream steam)
            {
                return SHA256HashAlgorithmInstance.ComputeHash(steam);
            }

            public byte[] ComputeMD5Hash(byte[] data)
            {
                var hashed = new MD5Managed().ComputeHash(data);
                return hashed;
            }

            public byte[] ComputeMD5Hash(Stream steam)
            {
                var hashed = new MD5Managed().ComputeHash(steam);
                return hashed;
            }

            public byte[] HMACSignBinary(byte[] data, byte[] key, SigningAlgorithm algorithmName)
            {
                if (key == null || key.Length == 0)
                    throw new ArgumentNullException("key", "Please specify a Secret Signing Key.");

                if (data == null || data.Length == 0)
                    throw new ArgumentNullException("data", "Please specify data to sign.");

                KeyedHashAlgorithm algorithm = ThreadSafeCreateKeyedHashedAlgorithm(algorithmName);
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
                        _hashAlgorithm = SHA256Managed.Create();
                    }
                    return _hashAlgorithm;
                }
            }
        }
    }
}
