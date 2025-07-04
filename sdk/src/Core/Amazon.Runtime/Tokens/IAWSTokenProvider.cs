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

using Amazon.Runtime.Internal.Auth;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime
{
    /// <remarks>
    /// Any class that can provide a <see cref="AWSToken"/>.  Intended to be consumed
    /// by <see cref="BearerTokenSigner"/> as part of signing.
    /// <para />
    /// See <see cref="BearerTokenSigner"/> for more details.
    /// </remarks>
    public interface IAWSTokenProvider
    {
#if BCL 
        /// <summary>
        /// Attempts to load an <see cref="AWSToken"/>.
        /// <para />
        /// NOTE: In some extreme circumstances, providers may throw an
        /// exception.
        /// </summary>
        bool TryResolveToken(out AWSToken token);
#endif

        /// <summary>
        /// Attempts to load an <see cref="AWSToken"/>.
        /// <para />
        /// NOTE: In some extreme circumstances, providers may throw an
        /// exception.
        /// </summary>
        Task<TryResponse<AWSToken>> TryResolveTokenAsync(CancellationToken cancellationToken = default);
    }
}