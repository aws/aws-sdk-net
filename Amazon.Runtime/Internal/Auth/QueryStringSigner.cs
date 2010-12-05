﻿/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime.Internal;
using Amazon.Util;

namespace Amazon.Runtime.Internal.Auth
{
    internal class QueryStringSigner : AbstractAWSSigner
    {
        internal QueryStringSigner() 
        {
        }

        /// <summary>
        /// Signs the specified request with the AWS2 signing protocol by using the
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
            if (String.IsNullOrEmpty(awsAccessKeyId))
            {
                throw new Exception("The AWS Access Key ID cannot be NULL or a Zero length string");
            }
          
            request.Parameters.Add("AWSAccessKeyId", awsAccessKeyId);
            request.Parameters.Add("SignatureVersion", clientConfig.SignatureVersion);
            request.Parameters.Add("SignatureMethod", clientConfig.SignatureMethod.ToString());
            request.Parameters.Add("Timestamp", AWSSDKUtils.FormattedCurrentTimestampISO8601);

            string toSign = AWSSDKUtils.CalculateStringToSignV2(request.Parameters, clientConfig.ServiceURL);
            string auth = ComputeHash(toSign, awsSecretAccessKey, secureKey, clientConfig.SignatureMethod);
            request.Parameters.Add("Signature", auth);
        }
    }
}
