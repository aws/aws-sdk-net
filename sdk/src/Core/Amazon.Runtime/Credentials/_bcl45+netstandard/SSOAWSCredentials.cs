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

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon.Runtime
{
    /// <summary>
    /// AWS Credentials that resolve using AWS SSO.
    /// </summary>
    public class SSOAWSCredentials : RefreshingAWSCredentials
    {
        private readonly Logger _logger = Logger.GetLogger(typeof(SSOAWSCredentials));
        private readonly ISSOTokenManager _ssoTokenManager;

        /// <summary>
        /// The AWS account ID that temporary AWS credentials will be resolved for.
        /// </summary>
        public string AccountId { get; private set; }

        /// <summary>
        /// The AWS region where the SSO directory for <see cref="StartUrl"/> is hosted.
        /// </summary>
        public string Region { get; private set; }

        /// <summary>
        /// The corresponding IAM role in the AWS account that temporary AWS credentials will be resolved for.
        /// </summary>
        public string RoleName { get; private set; }

        /// <summary>
        /// The main URL for users to login to their SSO directory.
        /// Provided by the SSO service via the web console.
        /// </summary>
        public string StartUrl { get; private set; }

        /// <summary>
        /// Options to be used in the SSO flow to resolve credentials.
        /// Developers wishing to support AWS SSO would want to provide the following:
        /// - <seealso cref="SSOAWSCredentialsOptions.ClientName"/>
        /// - <seealso cref="SSOAWSCredentialsOptions.SsoVerificationCallback"/>
        /// </summary>
        public SSOAWSCredentialsOptions Options { get; private set; }

        /// <summary>
        /// Constructs an SSOAWSCredentials object.
        /// </summary>
        /// <param name="accountId">The AWS account ID that temporary AWS credentials will be resolved for.</param>
        /// <param name="region">The AWS region where the SSO directory for <paramref name="startUrl"/> is hosted.</param>
        /// <param name="roleName">The corresponding IAM role in the AWS account that temporary AWS credentials will be resolved for.</param>
        /// <param name="startUrl">The main URL for users to login to their SSO directory.</param>
        public SSOAWSCredentials(string accountId, string region, string roleName, string startUrl)
            : this(accountId, region, roleName, startUrl, new SSOAWSCredentialsOptions())
        {
        }

        /// <summary>
        /// Constructs an SSOAWSCredentials object.
        /// </summary>
        /// <param name="accountId">The AWS account ID that temporary AWS credentials will be resolved for.</param>
        /// <param name="region">The AWS region where the SSO directory for <paramref name="startUrl"/> is hosted.</param>
        /// <param name="roleName">The corresponding IAM role in the AWS account that temporary AWS credentials will be resolved for.</param>
        /// <param name="startUrl">The main URL for users to login to their SSO directory.</param>
        /// <param name="options">Options to be used in the SSO flow to resolve credentials.</param>
        public SSOAWSCredentials(
            string accountId, string region,
            string roleName, string startUrl,
            SSOAWSCredentialsOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(region))
                throw new ArgumentNullException(nameof(region));

            AccountId = accountId;
            Region = region;
            RoleName = roleName;
            StartUrl = startUrl;
            Options = options;

            _ssoTokenManager = new SSOTokenManager(
                SSOServiceClientHelpers.BuildSSOIDCClient(
                    RegionEndpoint.GetBySystemName(region),
                    options.ProxySettings),
                new SSOTokenFileCache(
                    CryptoUtilFactory.CryptoInstance,
                    new FileRetriever(),
                    new DirectoryRetriever())
            );
        }

#if BCL
        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            ValidateCredentialsInputs();

            var ssoClient = 
                SSOServiceClientHelpers.BuildSSOClient(
                    RegionEndpoint.GetBySystemName(Region),
                    Options.ProxySettings);

            var credentials = GetSsoCredentials(ssoClient) as SSOImmutableCredentials;

            if (credentials == null)
            {
                throw new NotSupportedException("Unable to get credentials from SSO");
            }

            _logger.InfoFormat("New SSO credentials created that expire at {0}", credentials.Expiration.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture));
            return new CredentialsRefreshState(credentials, credentials.Expiration);
        }
#else
        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            return GenerateNewCredentialsAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        }
#endif

        protected override async Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
        {
            ValidateCredentialsInputs();

            var ssoClient = 
                SSOServiceClientHelpers.BuildSSOClient(
                    RegionEndpoint.GetBySystemName(Region),
                    Options.ProxySettings);

            var credentials =
                await GetSsoCredentialsAsync(ssoClient).ConfigureAwait(false) as SSOImmutableCredentials;

            if (credentials == null)
            {
                throw new NotSupportedException("Unable to get credentials from SSO");
            }

            _logger.InfoFormat("New SSO credentials created that expire at {0}", credentials.Expiration.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK", CultureInfo.InvariantCulture));
            return new CredentialsRefreshState(credentials, credentials.Expiration);
        }

        private void ValidateCredentialsInputs()
        {
            // Get the name of any empty properties
            var emptyPropertyNames = new Dictionary<string, string>
                {
                    {nameof(AccountId), AccountId},
                    {nameof(Region), Region},
                    {nameof(RoleName), RoleName},
                    {nameof(StartUrl), StartUrl},
                }.Where(propNameToValue => string.IsNullOrWhiteSpace(propNameToValue.Value))
                .Select(propNameToValue => propNameToValue.Key)
                .ToList();

            if (emptyPropertyNames.Any())
            {
                throw new ArgumentNullException($"Property cannot be empty: {string.Join(", ", emptyPropertyNames)}");
            }
        }

#if BCL
        /// <summary>
        /// Performs the SSO flow to authenticate and get credentials
        /// </summary>
        /// <param name="oidc">SSO OIDC client</param>
        /// <param name="sso">SSO client</param>
        /// <returns>Resolved credentials</returns>
        private ImmutableCredentials GetSsoCredentials(ICoreAmazonSSO sso)
        {
            var ssoTokenManagerGetTokenOptions = new SSOTokenManagerGetTokenOptions
            {
                ClientName = Options.ClientName,
                Region = Region,
                SsoVerificationCallback = Options.SsoVerificationCallback,
                StartUrl = StartUrl,
                Session = Options.SessionName
            };

            var token = _ssoTokenManager.GetToken(ssoTokenManagerGetTokenOptions);

            // Use SSO token to get credentials
            return GetSsoRoleCredentials(sso, token.AccessToken);
        }
#endif

        /// <summary>
        /// Performs the SSO flow to authenticate and get credentials
        /// </summary>
        /// <param name="sso">SSO client</param>
        /// <returns>Resolved credentials</returns>
        private async Task<ImmutableCredentials> GetSsoCredentialsAsync(ICoreAmazonSSO sso)
        {
            var ssoTokenManagerGetTokenOptions = new SSOTokenManagerGetTokenOptions
            {
                ClientName = Options.ClientName,
                Region = Region,
                SsoVerificationCallback = Options.SsoVerificationCallback,
                StartUrl = StartUrl,
                Session = Options.SessionName
            };

            var token = await _ssoTokenManager.GetTokenAsync(ssoTokenManagerGetTokenOptions).ConfigureAwait(false);

            // Use SSO token to get credentials
            return await GetSsoRoleCredentialsAsync(sso, token.AccessToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns true if there is already a non-expired cached login access token in the token cache.
        /// </summary>
        /// <param name="startUrl"></param>
        /// <returns>Obsolete: ALWAYS RETURNS FALSE</returns>
        [Obsolete("This method is no longer used or supported and will be removed in a future version.", error: false)]
        public static bool HasCachedAccessTokenAvailable(string startUrl)
        {
            return false;
        }

#if BCL
        /// <summary>
        /// Get resolved credentials from an AWS SSO access token
        /// </summary>
        /// <param name="sso">AWS SSO Client</param>
        /// <param name="accessToken">AWS SSO access token obtained from a user's authorization</param>
        /// <returns>Resolved credentials</returns>
        private ImmutableCredentials GetSsoRoleCredentials(ICoreAmazonSSO sso, string accessToken)
        {
            return sso.CredentialsFromSsoAccessToken(AccountId, RoleName, accessToken, null);
        }
#endif

        /// <summary>
        /// Get resolved credentials from an AWS SSO access token
        /// </summary>
        /// <param name="sso">AWS SSO Client</param>
        /// <param name="accessToken">AWS SSO access token obtained from a user's authorization</param>
        /// <returns>Resolved credentials</returns>
        private async Task<ImmutableCredentials> GetSsoRoleCredentialsAsync(ICoreAmazonSSO sso, string accessToken)
        {
            return await sso.CredentialsFromSsoAccessTokenAsync(AccountId, RoleName, accessToken, null)
                .ConfigureAwait(false);
        }
    }
}
