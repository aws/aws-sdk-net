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

using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Identity;

namespace Amazon.Runtime
{
    /// <summary>
    /// A resolver that provides an anonymous identity. 
    /// </summary>
    public class AnonymousIdentityResolver : IIdentityResolver<AnonymousAWSCredentials>
    {
        private readonly AnonymousAWSCredentials _credentials = new();

        BaseIdentity IIdentityResolver.ResolveIdentity(IClientConfig clientConfig) 
            => _credentials;

        /// <summary>
        /// Resolves the identity by returning an instance of <see cref="AnonymousAWSCredentials"/>.
        /// </summary>
        public AnonymousAWSCredentials ResolveIdentity(IClientConfig clientConfig) 
            => _credentials;

        Task<BaseIdentity> IIdentityResolver.ResolveIdentityAsync(IClientConfig clientConfig, CancellationToken cancellationToken)
            => Task.FromResult<BaseIdentity>(_credentials);

        /// <summary>
        /// Resolves the identity by returning an instance of <see cref="AnonymousAWSCredentials"/>.
        /// </summary>
        public Task<AnonymousAWSCredentials> ResolveIdentityAsync(IClientConfig clientConfig, CancellationToken cancellationToken = default)
            => Task.FromResult(_credentials);
    }
}
