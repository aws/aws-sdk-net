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
#if AWS_ASYNC_API
using System.Threading;
using System.Threading.Tasks;
#endif
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
    public class BearerTokenSigner : AbstractAWSSigner
    {
        public override bool RequiresCredentials { get; } = false;

#if BCL
        public override void Sign(
            IRequest request, 
            IClientConfig clientConfig, 
            RequestMetrics metrics, 
            string awsAccessKeyId,
            string awsSecretAccessKey)
        {
            if (request.Endpoint.Scheme == "http")
            {
                throw new AmazonClientException(
                    $"The configured endpoint [{request.Endpoint}] is invalid for the bearer authorization scheme. " +
                    "Endpoint must not use 'http'.");
            }

            if (null == clientConfig.AWSTokenProvider)
                return;

            if (!clientConfig.AWSTokenProvider.TryResolveToken(out var token) ||
                string.IsNullOrEmpty(token.Token))
            {
                throw new AmazonClientException("No Token found.  Operation requires a Bearer token.");
            }

            request.Headers["Authorization"] = $"Bearer {token}";
        }
#else
        public override void Sign(
            IRequest request,
            IClientConfig clientConfig,
            RequestMetrics metrics,
            string awsAccessKeyId,
            string awsSecretAccessKey)
        {
            throw new NotSupportedException($"Use {nameof(SignAsync)} instead.");
        }
#endif

#if AWS_ASYNC_API
        public override async Task SignAsync(
            IRequest request, 
            IClientConfig clientConfig, 
            RequestMetrics metrics, 
            ImmutableCredentials credentials,
            CancellationToken token = default)
        {
            if (request.Endpoint.Scheme == "http")
            {
                throw new AmazonClientException(
                    $"The configured endpoint [{request.Endpoint}] is invalid for the bearer authorization scheme. " +
                    "Endpoint must not use 'http'.");
            }

            if (null == clientConfig.AWSTokenProvider)
                return;

            var result = await clientConfig.AWSTokenProvider.TryResolveTokenAsync(token).ConfigureAwait(false);

            if (true != result.Success || string.IsNullOrEmpty(result.Value.Token))
                throw new AmazonClientException("No Token found.  Operation requires a Bearer token.");

            request.Headers["Authorization"] = $"Bearer {result.Value.Token}";
        }
#endif

        public override ClientProtocol Protocol { get; } = ClientProtocol.Unknown;
    }
}