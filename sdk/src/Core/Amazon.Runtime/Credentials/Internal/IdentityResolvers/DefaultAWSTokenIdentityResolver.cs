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

using Smithy.Identity.Abstractions;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Credentials.Internal.IdentityResolvers
{
    /// <summary>
    /// A resolver that provides a bearer token identity.
    /// </summary>
    public class DefaultAWSTokenIdentityResolver : IIdentityResolver
    {
        private readonly IAWSTokenProvider _tokenProvider;

        public DefaultAWSTokenIdentityResolver() : this(null) { }

        public DefaultAWSTokenIdentityResolver(string profileName)
            => _tokenProvider = new AWSTokenProviderChain(new ProfileTokenProvider(profileName));

        /// <inheritdoc/>
        public BaseIdentity ResolveIdentity()
        {
#if NETFRAMEWORK
            if (_tokenProvider.TryResolveToken(out var token))
            {
                return token;
            }

            throw new AmazonClientException($"Failed to resolve bearer token in {nameof(DefaultAWSTokenIdentityResolver)}");
#else
            // This is bad, but the token provider does not have a synchronous implementation for targets other than the .NET Framework.
            var tokenResponse = _tokenProvider.TryResolveTokenAsync().GetAwaiter().GetResult();
            if (tokenResponse.Success)
            {
                return tokenResponse.Value;
            }

            throw new AmazonClientException($"Failed to resolve bearer token in {nameof(DefaultAWSTokenIdentityResolver)}");
#endif
        }

        /// <inheritdoc/>
        public async Task<BaseIdentity> ResolveIdentityAsync(CancellationToken cancellationToken = default)
        {
            var tokenResponse = await _tokenProvider.TryResolveTokenAsync(cancellationToken).ConfigureAwait(false);
            if (tokenResponse.Success)
            {
                return tokenResponse.Value;
            }

            throw new AmazonClientException($"Failed to resolve bearer token in {nameof(DefaultAWSTokenIdentityResolver)}");
        }
    }
}
