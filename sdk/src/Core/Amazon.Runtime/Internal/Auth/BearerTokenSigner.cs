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
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Identity;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Auth
{
    public class BearerTokenSigner : AbstractAWSSigner
    {
        public override bool RequiresCredentials { get; } = false;
        public override ClientProtocol Protocol { get; } = ClientProtocol.Unknown;

        public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, BaseIdentity identity)
        {
            if (request.Endpoint.Scheme == "http")
            {
                throw new AmazonClientException(
                    $"The configured endpoint [{request.Endpoint}] is invalid for the bearer authorization scheme. " +
                    "Endpoint must not use 'http'.");
            }

            if (identity is not AWSToken awsToken || string.IsNullOrEmpty(awsToken.Token))
            {
                throw new AmazonClientException("No Token found. Operation requires a Bearer token.");
            }

            request.Headers["Authorization"] = $"Bearer {awsToken.Token}";
        }
    }
}