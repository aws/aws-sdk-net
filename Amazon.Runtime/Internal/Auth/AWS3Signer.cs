/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Security;
using System.Text;

using Amazon.Util;
using Amazon.Runtime;

namespace Amazon.Runtime.Internal.Auth
{
    internal class AWS3Signer : AbstractAWSSigner
    {
        private const string AUTHORIZATION_HEADER = "X-Amzn-Authorization";
        private const string NONCE_HEADER = "x-amz-nonce";
        private const string HTTP_SCHEME = "AWS3";
        private const string HTTPS_SCHEME = "AWS3-HTTPS";

        /// <summary>
        /// Signs the specified request with the AWS3 signing protocol by using the
        /// AWS account credentials given in the method parameters.
        /// </summary>
        /// <param name="awsAccessKeyId">The AWS public key</param>
        /// <param name="awsSecretAccessKey">The AWS secret key used to sign the request in clear text</param>
        /// <param name="clientConfig">The configuration that specifies which hashing algorithm to use</param>
        /// <param name="request">The request to have the signature compute for</param>
        /// <param name="secureKey">The AWS secret key stored in a secure string</param>
        /// <exception cref="Amazon.Runtime.SignatureException">If any problems are encountered while signing the request</exception>
        public override void Sign<T>(IRequest<T> request, ClientConfig clientConfig, string awsAccessKeyId, string awsSecretAccessKey, SecureString secureKey) 
        {
            string nonce = Guid.NewGuid().ToString();
            string date = AWSSDKUtils.FormattedCurrentTimestampRFC822;
            string stringToSign;

            stringToSign = date + nonce;

            String signature = ComputeHash(stringToSign, awsSecretAccessKey, secureKey, clientConfig.SignatureMethod);

            StringBuilder builder = new StringBuilder();
            builder.Append(HTTPS_SCHEME).Append(" ");
            builder.Append("AWSAccessKeyId=" + awsAccessKeyId + ",");
            builder.Append("Algorithm=" + clientConfig.SignatureMethod.ToString() + ",");
            builder.Append("SignedHeaders=x-amz-date;x-amz-nonce,");
            builder.Append("Signature=" + signature);

            request.Headers.Add(AUTHORIZATION_HEADER, builder.ToString());
            request.Headers.Add(NONCE_HEADER, nonce);
            request.Headers.Add("x-amz-date", date);           
        }
    }
}
