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
using Amazon.Runtime.Internal.UserAgent;

namespace Amazon.Runtime
{
    /// <summary>
    /// An <see cref="IAWSTokenProvider"/> implementation can be assigned to
    /// <see cref="IClientConfig.AWSTokenProvider"/> or added to a <see cref="AWSTokenProviderChain"/>.
    /// </summary>
    public class ServiceBearerStaticTokenProvider : IAWSTokenProvider
    {
        private readonly string _token;
        private readonly DateTime? _expiration;

        /// <summary>
        /// Creates a new <see cref="ServiceBearerStaticTokenProvider"/> that can be assigned to
        /// <see cref="IClientConfig.AWSTokenProvider"/> or added to a <see cref="AWSTokenProviderChain"/>.
        /// </summary>
        /// <param name="token">
        /// Bearer token to use to authorize AWS SDK requests based off of the service environment variable tokens.
        /// </param>
        /// <param name="expiration">Expiration date should not be set for the token as the expiration date
        /// is controlled by the service. The expiration date is reserved for future use.
        /// </param>
        public ServiceBearerStaticTokenProvider(string token, DateTime? expiration = null)
        {
            _token = token;
            _expiration = expiration;
        }

#if BCL
        public bool TryResolveToken(out AWSToken token)
        {
            if (IsTokenUnexpired())
            {
                token = new AWSToken 
                { 
                    Token = _token,
                    Expiration = _expiration,
                    FeatureIdSources = { UserAgentFeatureId.BEARER_SERVICE_ENV_VARS }
                };

                return true;
            }
            else
            {
                token = null;
                return false;
            }
        }
#endif

        public Task<TryResponse<AWSToken>> TryResolveTokenAsync(CancellationToken cancellationToken = default)
        {
            var isTokenUnexpired = IsTokenUnexpired();

            return Task.FromResult(
                new TryResponse<AWSToken>
                {
                    Success = isTokenUnexpired,
                    Value = isTokenUnexpired ? new AWSToken { 
                        Token = _token, 
                        Expiration = _expiration,
                        FeatureIdSources = { UserAgentFeatureId.BEARER_SERVICE_ENV_VARS }
                    } : null
                });
        }

        private bool IsTokenUnexpired()
        {
            // Service environment variable tokens do not expire per the SDK. The service will
            // reject the request is the token is expired.
            return true;
        }
    }
}