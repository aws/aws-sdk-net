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
using Amazon.Runtime.Credentials;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Util;
using Amazon.Util.Internal;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime
{
    /// <summary>
    /// Looks for a AWS Profile and then passes token resolution
    /// to <see cref="SSOTokenProvider"/>.
    /// <para />
    /// This provider requires .NET 4.5 or newer.
    /// </summary>
    public class ProfileTokenProvider : IAWSTokenProvider
    {
        private readonly ISSOTokenProviderFactory _ssoTokenProviderFactory;
        private readonly ICredentialProfileSource _credentialProfileSource;
        private readonly string _profileName;

        public ProfileTokenProvider(
            ISSOTokenProviderFactory ssoTokenProviderFactory,
            ICredentialProfileSource credentialProfileSource,
            string profileName = null)
        {
            _ssoTokenProviderFactory = ssoTokenProviderFactory;
            _credentialProfileSource = credentialProfileSource;
            _profileName = profileName;
        }

        public ProfileTokenProvider(string profileName = null)
            : this(
                new SSOTokenProviderFactory(
                    new SSOTokenFileCache(
                        CryptoUtilFactory.CryptoInstance,
                        new FileRetriever(),
                        new DirectoryRetriever())),
                new CredentialProfileStoreChain(), 
                profileName) { }

#if BCL
        public bool TryResolveToken(out AWSToken token)
        {
            if (LoadAndValidateProfile(out var profile))
            {
                return _ssoTokenProviderFactory.Build(profile).TryResolveToken(out token);
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
            if (LoadAndValidateProfile(out var profile))
            {
                return _ssoTokenProviderFactory.Build(profile).TryResolveTokenAsync(cancellationToken);
            }
            else
            {
                return Task.FromResult(TryResponse<AWSToken>.Failure);
            }
        }

        /// <summary>
        /// Loads the <see cref="CredentialProfile"/> from <see cref="_credentialProfileSource"/>
        /// and runs some validation logic.
        /// <para />
        /// NOTE: Per the Spec, this method can throw exceptions that should bubble up through
        /// IAWSTokenProvider.TryResolveToken.
        /// </summary>
        /// <returns>
        /// True if the profile has all necessary data points and should be further processed by
        /// <see cref="SSOTokenProvider"/>.
        /// </returns>
        private bool LoadAndValidateProfile(out CredentialProfile profile)
        {
            var profileName =
                !string.IsNullOrEmpty(_profileName)
                    ? _profileName
                    : DefaultAWSCredentialsIdentityResolver.GetProfileName();

            if (!_credentialProfileSource.TryGetProfile(profileName, out profile))
                return false;

            if (string.IsNullOrEmpty(profile.Options.SsoSession))
                // not a valid sso profile, it will be skipped
                return false;

           
            if (string.IsNullOrEmpty(profile.Options.SsoStartUrl))
            {
                throw new AmazonClientException(
                    $"Invalid Configuration.  SSO Session [{profile.Options.SsoSession}] is missing sso_start_url.");
            }

            if (string.IsNullOrEmpty(profile.Options.SsoRegion))
            {
                throw new AmazonClientException(
                    $"Invalid Configuration.  SSO Session [{profile.Options.SsoSession}] is missing sso_region.");
            }

            return true;
        }
    }
}