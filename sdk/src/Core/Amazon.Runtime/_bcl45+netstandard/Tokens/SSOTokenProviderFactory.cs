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

using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;

namespace Amazon.Runtime
{
    /// <summary>
    /// Interface for a factory that constructs new instances of <see cref="SSOTokenProvider"/>
    /// </summary>
    public interface ISSOTokenProviderFactory
    {
        /// <summary>
        /// Constructs a new <see cref="SSOTokenProvider"/> initialized by the passed <paramref name="profile"/>.
        /// </summary>
        SSOTokenProvider Build(CredentialProfile profile);
    }

    /// <summary>
    /// Factory that constructs new new instances of <see cref="SSOTokenProvider"/>
    /// </summary>
    public class SSOTokenProviderFactory : ISSOTokenProviderFactory
    {
        private readonly ISSOTokenFileCache _ssoTokenFileCache;

        public SSOTokenProviderFactory(ISSOTokenFileCache ssoTokenFileCache)
        {
            _ssoTokenFileCache = ssoTokenFileCache;
        }

        /// <inheritdoc />
        public SSOTokenProvider Build(CredentialProfile profile)
        {
            return new SSOTokenProvider(
                new SSOTokenManager(
                    SSOServiceClientHelpers.BuildSSOIDCClient(
                        profile.Region),
                    _ssoTokenFileCache),
                profile.Options.SsoSession,
                profile.Options.SsoStartUrl,
                profile.Options.SsoRegion);
        }
    }
}