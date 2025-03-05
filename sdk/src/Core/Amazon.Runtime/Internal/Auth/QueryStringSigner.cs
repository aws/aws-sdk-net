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
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using Amazon.Runtime.Identity;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

namespace Amazon.Runtime.Internal.Auth
{
    public class QueryStringSigner : AbstractAWSSigner
    {
        private const string SignatureVersion2 = "2";

        public QueryStringSigner() 
        {
        }

        public override ClientProtocol Protocol
        {
            get { return ClientProtocol.QueryStringProtocol; }
        }

        /// <summary>
        /// Signs the specified request with the AWS2 signing protocol by using the
        /// AWS account credentials given in the method parameters.
        /// </summary>
        /// <param name="request">The request to have the signature compute for</param>
        /// <param name="clientConfig">The configuration that specifies which hashing algorithm to use</param>
        /// <param name="metrics">Request metrics</param>
        /// <param name="identity">AWS credentials for the account making the request</param>
        /// <exception cref="Amazon.Runtime.SignatureException">If any problems are encountered while signing the request</exception>
        public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, BaseIdentity identity)
        {
            var credentials = identity as AWSCredentials;
            var immutableCredentials = credentials.GetCredentials();

            if (string.IsNullOrEmpty(immutableCredentials?.AccessKey))
            {
                throw new ArgumentOutOfRangeException("awsAccessKeyId", "The AWS Access Key ID cannot be NULL or a Zero length string");
            }

            request.Parameters["AWSAccessKeyId"] = immutableCredentials.AccessKey;
            request.Parameters["SignatureVersion"] = SignatureVersion2;
            request.Parameters["SignatureMethod"] = clientConfig.SignatureMethod.ToString();
            request.Parameters["Timestamp"] = AWSSDKUtils.GetFormattedTimestampISO8601(clientConfig, request.OriginalRequest);
            request.SignedAt = CorrectClockSkew.GetCorrectedUtcNowForEndpoint(request.Endpoint.ToString());
            // remove Signature parameter, in case this is a retry
            request.Parameters.Remove("Signature");

            string toSign = AWSSDKUtils.CalculateStringToSignV2(request.ParameterCollection, request.Endpoint.AbsoluteUri);
            metrics.AddProperty(Metric.StringToSign, toSign);
            string auth = ComputeHash(toSign, immutableCredentials.SecretKey, clientConfig.SignatureMethod);
            request.Parameters["Signature"] = auth;
        }
    }
}
