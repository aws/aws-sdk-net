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
using System.Net;

using Amazon.Util;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Auth
{
    public enum ClientProtocol { QueryStringProtocol, RestProtocol, Unknown }

    public abstract class AbstractAWSSigner
    {
        protected const string DEFAULT_ENCODING = "UTF-8";

        /// <summary>
        /// Computes RFC 2104-compliant HMAC signature.
        /// </summary>
        protected static string ComputeHash(string data, string secretkey, SigningAlgorithm algorithm)
        {
            try 
            {
                string signature = CryptoUtilFactory.CryptoInstance.HMACSign(data, secretkey, algorithm);

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
        protected static string ComputeHash(byte[] data, string secretkey, SigningAlgorithm algorithm)
        {
            try
            {
                string signature = CryptoUtilFactory.CryptoInstance.HMACSign(data, secretkey, algorithm);

                return signature;
            }
            catch (Exception e)
            {
                throw new SignatureException("Failed to generate signature: " + e.Message, e);
            }
        }

        public abstract void Sign(IRequest request, ClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey);

        public abstract ClientProtocol Protocol { get; }
    }
}
