/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Text;
using System.Security;
using System.Security.Cryptography;
using System.Net;

using Amazon.Util;

namespace Amazon.Runtime.Internal.Auth
{
    internal abstract class AbstractAWSSigner
    {
        protected const string DEFAULT_ENCODING = "UTF-8";

        /// <summary>
        /// Computes RFC 2104-compliant HMAC signature.
        /// </summary>
        protected string ComputeHash(string data, string clearkey, SecureString secureKey, SigningAlgorithm algorithm)
        {
            try 
            {
                KeyedHashAlgorithm mac = KeyedHashAlgorithm.Create(algorithm.ToString().ToUpper());

                string signature;
                if (string.IsNullOrEmpty(clearkey))
                {
                    signature = AWSSDKUtils.HMACSign(data, secureKey, mac);
                }
                else
                {
                    signature = AWSSDKUtils.HMACSign(data, clearkey, mac);
                }

                return signature;
            } 
            catch (Exception e) 
            {
                throw new SignatureException("Failed to generate signature: " + e.Message, e);
            }
        }

        /// <summary>
        /// Computes RFC 2104-compliant HMAC signature.
        /// </summary>
        protected string ComputeHash(byte[] data, string clearkey, SecureString secureKey, SigningAlgorithm algorithm)
        {
            try
            {
                KeyedHashAlgorithm mac = KeyedHashAlgorithm.Create(algorithm.ToString().ToUpper());

                string signature;
                if (string.IsNullOrEmpty(clearkey))
                {
                    signature = AWSSDKUtils.HMACSign(data, secureKey, mac);
                }
                else
                {
                    signature = AWSSDKUtils.HMACSign(data, clearkey, mac);
                }

                return signature;
            }
            catch (Exception e)
            {
                throw new SignatureException("Failed to generate signature: " + e.Message, e);
            }
        }

        [ThreadStatic]
        private static HashAlgorithm _hashAlgorithm = null;
        protected static HashAlgorithm CanonicalizationHash
        {
            get
            {
                if (null == _hashAlgorithm)
                {
                    try
                    {
                        _hashAlgorithm = HashAlgorithm.Create("SHA-256");
                    }
                    catch (Exception) // Managed Hash Provider is not FIPS compliant.
                    {
                        _hashAlgorithm = new SHA256CryptoServiceProvider();
                    }
                }
                return _hashAlgorithm;
            }
        }

        public abstract void Sign(IRequest request, ClientConfig clientConfig, string awsAccessKeyId, string awsSecretAccessKey, SecureString secureKey);
    }
}
