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

namespace Amazon.Runtime
{
    /// <summary>
    /// Combines the recommended <see cref="IAWSTokenProvider"/> into a <see cref="AWSTokenProviderChain"/>.
    /// <para />
    /// Configuration parameters for each <see cref="IAWSTokenProvider"/> are exposed here to simplify configuration.
    /// <example>
    /// Example below demonstrates how to build a custom <see cref="DefaultAWSTokenProviderChain"/> in a
    /// <see cref="ClientConfig.AWSTokenProvider"/>.
    /// NOTE: The below example requires .NET 4.5 or above.
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
#if !BCL35 // ProfileTokenProvider doesn't support 3.5
                    new ProfileTokenProvider(ProfileName)
#endif
                );

            _chain = new Lazy<IAWSTokenProvider>(chainBuilder);
        }

        // default providers constructor parameters flattened to properties

        /// <summary>
        /// Used to initialize <see cref="ProfileTokenProvider"/>.
        /// </summary>
        public string ProfileName { get; set; }

#if BCL
        public bool TryResolveToken(out AWSToken token)
        {
            return _chain.Value.TryResolveToken(out token);
        }
#endif

#if AWS_ASYNC_API
        public async Task<TryResponse<AWSToken>> TryResolveTokenAsync(CancellationToken cancellationToken = default)
        {
            return await _chain.Value.TryResolveTokenAsync(cancellationToken).ConfigureAwait(false);
        }
#endif

#if BCL35
        private class Lazy<T> where T : class
        {
            private readonly Func<T> _builder;
            private object _lock = new object();

            public Lazy(Func<T> builder)
            {
                _builder = builder;
            }

            private volatile T _value;
            public T Value
            {
                get
                {
                    if (null != _value)
                        return _value;

                    lock (_lock)
                    {
                        if (null != _value)
                            return _value;

                        _value = _builder();

                        return _value;
                    }
                }
            }
        }
#endif
    }
}