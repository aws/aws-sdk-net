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

namespace Amazon.Runtime
{
    /// <summary>
    /// Combines the recommended <see cref="IAWSTokenProvider"/> into a <see cref="AWSTokenProviderChain"/>.
    /// <para />
    /// Configuration parameters for each <see cref="IAWSTokenProvider"/> are exposed here to simplify configuration.
    /// <example>
    /// Example below demonstrates how to build a custom <see cref="DefaultAWSTokenProviderChain"/> in a
    /// <see cref="ClientConfig.AWSTokenProvider"/>.
    /// <code>
    /// <![CDATA[
    /// var exampleServiceClientConfig = new ExampleServiceClientConfig
    /// {
    ///    AWSTokenProvider = new DefaultAWSTokenProviderChain
    ///    {
    ///       ProfileName = "my-sso-profile"
    ///    }
    /// }
    /// ]]>
    /// </code> 
    /// </example>
    /// </summary>
    public class DefaultAWSTokenProviderChain : IAWSTokenProvider
    {
        private readonly Lazy<IAWSTokenProvider> _chain;

        public DefaultAWSTokenProviderChain()
        {
            Func<IAWSTokenProvider> chainBuilder = () => 
                new AWSTokenProviderChain(
                    new ProfileTokenProvider(ProfileName)
                );

            _chain = new Lazy<IAWSTokenProvider>(chainBuilder);
        }

        // default providers constructor parameters flattened to properties

        /// <summary>
        /// Used to initialize ProfileTokenProvider.
        /// </summary>
        public string ProfileName { get; set; }

#if BCL
        public bool TryResolveToken(out AWSToken token)
        {
            return _chain.Value.TryResolveToken(out token);
        }
#endif

        public async Task<TryResponse<AWSToken>> TryResolveTokenAsync(CancellationToken cancellationToken = default)
        {
            return await _chain.Value.TryResolveTokenAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}