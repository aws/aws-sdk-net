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

namespace Amazon.Runtime
{
    /// <summary>
    /// AWS Credentials that resolve using AWS SSO.
    /// </summary>
    public class SSOAWSCredentials : RefreshingAWSCredentials
    {
        private const string SsoClientTypePublic = "public";

        private readonly Logger _logger = Logger.GetLogger(typeof(SSOAWSCredentials));

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

            AccountId = accountId;
            Region = region;
            RoleName = roleName;
            StartUrl = startUrl;
            Options = options;
        }

#if BCL
        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            ValidateCredentialsInputs();

            var oidcClient = CreateClient<ICoreAmazonSSOOIDC>(
                ServiceClientHelpers.SSO_OIDC_SERVICE_CLASS_NAME,
                ServiceClientHelpers.SSO_OIDC_SERVICE_CONFIG_NAME,
                ServiceClientHelpers.SSO_OIDC_ASSEMBLY_NAME);

            var ssoClient = CreateClient<ICoreAmazonSSO>(
                ServiceClientHelpers.SSO_SERVICE_CLASS_NAME,
                ServiceClientHelpers.SSO_SERVICE_CONFIG_NAME,
                ServiceClientHelpers.SSO_ASSEMBLY_NAME);

            var credentials = GetSsoCredentials(oidcClient, ssoClient) as SSOImmutableCredentials;

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

            var oidcClient = CreateClient<ICoreAmazonSSOOIDC>(
                ServiceClientHelpers.SSO_OIDC_SERVICE_CLASS_NAME,
                ServiceClientHelpers.SSO_OIDC_SERVICE_CONFIG_NAME,
                ServiceClientHelpers.SSO_OIDC_ASSEMBLY_NAME);

            var ssoClient = CreateClient<ICoreAmazonSSO>(
                ServiceClientHelpers.SSO_SERVICE_CLASS_NAME,
                ServiceClientHelpers.SSO_SERVICE_CONFIG_NAME,
                ServiceClientHelpers.SSO_ASSEMBLY_NAME);

            var credentials =
                await GetSsoCredentialsAsync(oidcClient, ssoClient).ConfigureAwait(false) as SSOImmutableCredentials;

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

        /// <summary>
        /// Attempts to get a service client at runtime which cannot be made a project reference.
        /// </summary>
        private T CreateClient<T>(string serviceClassName, string serviceConfigName, string parentAssemblyName) where T : class
        {
            try
            {
                var serviceConfig = ServiceClientHelpers.CreateServiceConfig(
                    parentAssemblyName,
                    serviceConfigName);

                serviceConfig.RegionEndpoint = RegionEndpoint.GetBySystemName(Region);

                if (Options?.ProxySettings != null)
                {
                    serviceConfig.SetWebProxy(Options.ProxySettings);
                }

                var serviceClient = ServiceClientHelpers.CreateServiceFromAssembly<T>(
                    parentAssemblyName,
                    serviceClassName,
                    new AnonymousAWSCredentials(), serviceConfig) as T;

                return serviceClient;
            }
            catch (Exception e)
            {
                var msg = string.Format(CultureInfo.CurrentCulture,
                    "Assembly {0} could not be found or loaded. This assembly must be available at runtime to use {1}.",
                    parentAssemblyName,
                    GetType().AssemblyQualifiedName);

                var exception = new InvalidOperationException(msg, e);
                _logger.Error(exception, exception.Message);
                throw exception;
            }
        }

#if BCL
        /// <summary>
        /// Performs the SSO flow to authenticate and get credentials
        /// </summary>
        /// <param name="oidc">SSO OIDC client</param>
        /// <param name="sso">SSO client</param>
        /// <returns>Resolved credentials</returns>
        private ImmutableCredentials GetSsoCredentials(ICoreAmazonSSOOIDC oidc, ICoreAmazonSSO sso)
        {
            var tokenCache = new SsoTokenCache(StartUrl);
            var token = tokenCache.GetAccessToken();

            // Get and cache a SSO token if necessary
            if (string.IsNullOrWhiteSpace(token))
            {
                if (string.IsNullOrEmpty(Options.ClientName))
                {
                    throw new ArgumentNullException($"Options property cannot be empty: {nameof(Options.ClientName)}");
                }

                if (Options.SsoVerificationCallback == null)
                {
                    throw new ArgumentNullException($"Options property cannot be empty: {nameof(Options.SsoVerificationCallback)}");
                }

                var response = oidc.GetSsoToken(new GetSsoTokenRequest()
                {
                    ClientName = GetSsoClientName(),
                    ClientType = SsoClientTypePublic,
                    StartUrl = StartUrl,
                    SsoVerificationCallback = Options.SsoVerificationCallback,
                });

                // If save fails, token will not be cached
                tokenCache.TrySave(new SsoToken()
                {
                    AccessToken = response.AccessToken,
                    Region = Region,
                    ExpiresAt = response.ExpiresAt,
                    StartUrl = StartUrl,
                });

                token = response.AccessToken;
            }

            // Use SSO token to get credentials
            return GetSsoRoleCredentials(sso, token);
        }
#endif

        /// <summary>
        /// Performs the SSO flow to authenticate and get credentials
        /// </summary>
        /// <param name="oidc">SSO OIDC client</param>
        /// <param name="sso">SSO client</param>
        /// <returns>Resolved credentials</returns>
        private async Task<ImmutableCredentials> GetSsoCredentialsAsync(ICoreAmazonSSOOIDC oidc, ICoreAmazonSSO sso)
        {
            var tokenCache = new SsoTokenCache(StartUrl);
            var token = tokenCache.GetAccessToken();

            // Get and cache a SSO token if necessary
            if (string.IsNullOrWhiteSpace(token))
            {
                if (string.IsNullOrEmpty(Options.ClientName))
                {
                    throw new ArgumentNullException($"Options property cannot be empty: {nameof(Options.ClientName)}");
                }

                if (Options.SsoVerificationCallback == null)
                {
                    throw new ArgumentNullException($"Options property cannot be empty: {nameof(Options.SsoVerificationCallback)}");
                }

                var response = await oidc.GetSsoTokenAsync(new GetSsoTokenRequest()
                {
                    ClientName = GetSsoClientName(),
                    ClientType = SsoClientTypePublic,
                    StartUrl = StartUrl,
                    SsoVerificationCallback = Options.SsoVerificationCallback,
                }).ConfigureAwait(false);

                // If save fails, token will not be cached
                tokenCache.TrySave(new SsoToken()
                {
                    AccessToken = response.AccessToken,
                    Region = Region,
                    ExpiresAt = response.ExpiresAt,
                    StartUrl = StartUrl,
                });

                token = response.AccessToken;
            }

            // Use SSO token to get credentials
            return await GetSsoRoleCredentialsAsync(sso, token).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns true if there is already a non-expired cached login access token in the token cache.
        /// </summary>
        /// <param name="startUrl"></param>
        /// <returns></returns>
        public static bool HasCachedAccessTokenAvailable(string startUrl)
        {
            var tokenCache = new SsoTokenCache(startUrl);
            return !string.IsNullOrEmpty(tokenCache.GetAccessToken());
        }

        /// <summary>
        /// Produces a client name watermarked with a timestamp for use in this provider's SSO Flow.
        /// </summary>
        /// <example>
        /// "sometool" -> "sometool-1599153467"
        /// </example>
        /// <returns>A Client Name to use in the internal SSO flow</returns>
        private string GetSsoClientName()
        {
#pragma warning disable CR1003 // Do not use DateTime.Now or DateTime.UtcNow, use AWSSDKUtils.CorrectedNow or AWSSDKUtils.CorrectedUtcNow
            var dateStamp = AWSSDKUtils.ConvertToUnixEpochSecondsString(DateTime.UtcNow);
#pragma warning restore CR1003 // Do not use DateTime.Now or DateTime.UtcNow, use AWSSDKUtils.CorrectedNow or AWSSDKUtils.CorrectedUtcNow
            return $"{Options.ClientName}-{dateStamp}";
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
