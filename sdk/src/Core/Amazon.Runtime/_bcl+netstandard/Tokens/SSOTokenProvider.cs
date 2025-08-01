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
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal.Util;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime
{
    /// <summary>
    /// Looks in <see cref="_ssoCacheDirectory"/> for a file that matches
    /// <see cref="_sessionName"/> and then loads the SSO Token from that file.
    /// </summary>
    public class SSOTokenProvider : IAWSTokenProvider
    {
        private readonly ILogger _logger = Logger.GetLogger(typeof(SSOTokenProvider));

        private readonly ISSOTokenManager _ssoTokenManager;
        private readonly string _sessionName;
        private readonly string _startUrl;
        private readonly string _region;
        private readonly string _ssoCacheDirectory;

        public SSOTokenProvider(
            ISSOTokenManager ssoTokenManager,
            string sessionName, 
            string startUrl,
            string region, 
            string ssoCacheDirectory = null)
        {
            if (string.IsNullOrWhiteSpace(sessionName))
                throw new ArgumentNullException(nameof(sessionName));

            if (string.IsNullOrWhiteSpace(startUrl))
                throw new ArgumentNullException(nameof(startUrl));

            if (string.IsNullOrEmpty(region))
                throw new ArgumentNullException(nameof(region));

            _ssoTokenManager = ssoTokenManager;
            _sessionName = sessionName;
            _startUrl = startUrl;
            _region = region;
            _ssoCacheDirectory = ssoCacheDirectory;
        }

#if BCL
        public bool TryResolveToken(out AWSToken token)
        {
            token = null;

            try
            {
                var requestOptions = BuildSsoTokenManagerGetTokenOptions();

                var ssoToken = _ssoTokenManager.GetToken(requestOptions);

                token = MapSsoTokenToAwsToken(ssoToken);

                return true;
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                _logger.Error(e, "Exception trying to resolve SSO Token");

                // per the spec, rethrow SSOTokeManager exceptions so users
                // know if there is a problem with the cached sso token
                throw;
            }
        }
#endif

        public async Task<TryResponse<AWSToken>> TryResolveTokenAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                var requestOptions = BuildSsoTokenManagerGetTokenOptions();

                var ssoToken = await _ssoTokenManager.GetTokenAsync(requestOptions, cancellationToken).ConfigureAwait(false);

                return new TryResponse<AWSToken>
                {
                    Success = true,
                    Value = MapSsoTokenToAwsToken(ssoToken)
                };
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                _logger.Error(e, "Exception trying to resolve SSO Token");

                // per the spec, rethrow SSOTokeManager exceptions so users
                // know if there is a problem with the cached sso token
                throw;
            }
        }

        private SSOTokenManagerGetTokenOptions BuildSsoTokenManagerGetTokenOptions()
        {
            var requestOptions = new SSOTokenManagerGetTokenOptions
            {
                Session = _sessionName,
                StartUrl = _startUrl,
                Region = _region,
                SupportsGettingNewToken = false
            };

            if (!string.IsNullOrEmpty(_ssoCacheDirectory))
                requestOptions.CacheFolderLocation = _ssoCacheDirectory;

            return requestOptions;
        }

        private AWSToken MapSsoTokenToAwsToken(SsoToken token)
        {
            return new AWSToken
            {
                Token = token.AccessToken,
                Expiration = token.ExpiresAt
            };
        }
    }
}