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

using System.Linq;
#if AWS_ASYNC_API 
using System.Threading;
using System.Threading.Tasks;
#endif

namespace Amazon.Runtime
{
    /// <summary>
    /// Chain of <see cref="IAWSTokenProvider"/>.  Providers are evaluated in order, and the
    /// first provider to return an <see cref="AWSToken"/> wins.
    /// </summary>
    public class AWSTokenProviderChain : IAWSTokenProvider
    {
        private readonly IAWSTokenProvider[] _chain;

        public AWSTokenProviderChain(params IAWSTokenProvider[] providers)
        {
            _chain = providers ?? new IAWSTokenProvider[0];
        }

#if BCL
        public bool TryResolveToken(out AWSToken token)
        {
            token = null;

            foreach (var provider in _chain)
            {
                if (provider.TryResolveToken(out token))
                    return true;
            }

            return false;
        }
#endif

#if AWS_ASYNC_API
        public async Task<TryResponse<AWSToken>> TryResolveTokenAsync(CancellationToken cancellationToken = default)
        {
            foreach (var provider in _chain)
            {
                var token = await provider.TryResolveTokenAsync(cancellationToken).ConfigureAwait(false);
                
                if (token.Success)
                    return token;
            }

            return TryResponse<AWSToken>.Failure;
        }
#endif
    }
}