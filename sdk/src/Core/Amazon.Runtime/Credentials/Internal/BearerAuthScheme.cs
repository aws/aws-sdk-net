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

using Amazon.Runtime.Identity;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime.Credentials.Internal
{
    /// <summary>
    /// The HTTP Bearer authentication scheme (which uses token credentials and its corresponding signer).
    /// </summary>
    public class BearerAuthScheme : IAuthScheme<AWSToken>
    {
        private static readonly ISigner _signer = new BearerTokenSigner();

        /// <inheritdoc/>
        public string SchemeId => AuthSchemeOption.Bearer;

        /// <inheritdoc/>
        public IIdentityResolver GetIdentityResolver(IIdentityResolverConfiguration configuration)
            => configuration.GetIdentityResolver<AWSToken>();

        /// <inheritdoc/>
        public ISigner Signer() => _signer;
    }
}
