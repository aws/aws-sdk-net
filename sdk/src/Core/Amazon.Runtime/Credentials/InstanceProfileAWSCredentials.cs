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
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Amazon.Util.Internal;
using AWSSDK.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Threading.Tasks;

namespace Amazon.Runtime
{
    /// <summary>
    /// Credentials that are retrieved from the Instance Profile service on an EC2 instance
    /// </summary>
    /// <remarks>
    /// This is meant to be used when building a <see cref="AmazonServiceClient"/>, as opposed
    /// to <see cref="DefaultInstanceProfileAWSCredentials"/>, which is part of the
    /// <see cref="FallbackCredentialsFactory"/> chain.
    /// <para />
    /// While IMDS is enabled, it looks for newer credentials every 2 minutes, through a background refresh that never
    /// blocks callers and follows the refresh backoff. IMDS rotates in new credentials well before the current ones
    /// expire, so this keeps the cached credentials recent instead of holding them until their refresh window, which
    /// for 6-hour credentials opens after about 5 hours. Dispose the instance to stop this.
    /// </remarks>
    public class InstanceProfileAWSCredentials : URIBasedRefreshingCredentialHelper
    {
        #region Private members

        private readonly IWebProxy _proxy = null;

        private Logger _logger;

        #endregion

        #region Properties

        /// <summary>
        /// Role for which the credentials are retrieved
        /// </summary>
        public string Role { get; set; }

        #endregion


        #region Overrides

        /// <inheritdoc/>
        protected sealed override bool UsesManagedRefreshLifecycle => true;

        /// <summary>
        /// IMDS returns the same credentials until it rotates them, so it cannot supply longer-lived credentials on
        /// request: <see cref="RefreshingAWSCredentials.GetCredentials(TimeSpan)"/> behaves as
        /// <see cref="RefreshingAWSCredentials.GetCredentials()"/>.
        /// </summary>
        internal override bool SupportsMinimumLifetimeRefresh => false;

        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            var token = EC2InstanceMetadata.FetchApiToken();

            for (var attempt = 1; ; attempt++)
            {
                try
                {
                    // Return the credentials with the expiration IMDS reported. The base class chooses the background
                    // refresh window from that lifetime, so 6-hour credentials get a 60-minute window.
                    return GetRefreshState(token);
                }
                catch (Exception e) when (IsRetriedAfterLogging(e, attempt))
                {
                    // Retried once; see IsRetriedAfterLogging.
                }
            }
        }

        protected override async Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
        {
            var token = await EC2InstanceMetadata.FetchApiTokenAsync().ConfigureAwait(false);

            for (var attempt = 1; ; attempt++)
            {
                try
                {
                    // Return the credentials with the expiration IMDS reported; see GenerateNewCredentials.
                    return await GetRefreshStateAsync(token).ConfigureAwait(false);
                }
                catch (Exception e) when (IsRetriedAfterLogging(e, attempt))
                {
                    // Retried once; see IsRetriedAfterLogging.
                }
            }
        }

        /// <summary>
        /// Logs a failed request for credentials and returns true when it is made again. It is made once more when no
        /// credentials are cached and IMDS did not reject the request as unauthorized, as in earlier versions of the SDK:
        /// there are no credentials to fall back on, so a single dropped or throttled response would otherwise fail the
        /// fetch. Otherwise the failure is thrown, and the base class keeps serving the cached credentials and contacts
        /// IMDS again after the jittered refresh backoff. A response whose credentials have already expired is not a
        /// failure here: the base class uses it when nothing is cached and keeps the cached credentials otherwise.
        /// </summary>
        private bool IsRetriedAfterLogging(Exception e, int attempt)
        {
            HttpStatusCode? httpStatusCode = ExceptionUtils.DetermineHttpStatusCode(e);

            if (httpStatusCode == HttpStatusCode.Unauthorized)
            {
                Logger.GetLogger(typeof(EC2InstanceMetadata)).Error(e, "EC2 Metadata service returned unauthorized for token based secure data flow.");
                return false;
            }

            _logger.InfoFormat("Error getting credentials from Instance Profile service: {0}", e);
            return attempt == 1 && currentState == null;
        }

        #endregion


        #region Constructors

        /// <summary>
        /// Constructs <see cref="InstanceProfileAWSCredentials"/> for the specified role.
        /// </summary>
        /// <param name="role">Name of the role to use</param>
        public InstanceProfileAWSCredentials(string role)
            : this(role, null) { }

        /// <summary>
        /// Constructs <see cref="InstanceProfileAWSCredentials"/> for the specified role.
        /// </summary>
        /// <param name="role">Name of the role to use</param>
        /// <param name="proxy">Proxy used to process requests to the instance metadata service</param>
        public InstanceProfileAWSCredentials(string role, IWebProxy proxy)
            : this(role, proxy, DefaultInstanceProfileAWSCredentials.ScheduledRefreshInterval) { }

        /// <summary>
        /// For tests: the scheduled refresh runs every <paramref name="scheduledRefreshInterval"/>, or not at all when
        /// it is null.
        /// </summary>
        internal InstanceProfileAWSCredentials(string role, IWebProxy proxy, TimeSpan? scheduledRefreshInterval)
        {
            _logger = Logger.GetLogger(GetType());

            this._proxy = proxy;

            if (role == null)
                throw new ArgumentNullException(nameof(role));
            else if (IsNullOrWhiteSpace(role))
                throw new ArgumentException("The argument '" + nameof(role) + "' must contain a valid role name.");

            Role = role;
            // PreemptExpiryTime is not set: the base class chooses the background refresh window from the lifetime of
            // the credentials.

            if (EC2InstanceMetadata.IsIMDSEnabled && scheduledRefreshInterval is TimeSpan interval && interval > TimeSpan.Zero)
            {
                StartScheduledRefresh(interval);
            }
        }

        /// <summary>
        /// Constructs <see cref="InstanceProfileAWSCredentials"/> for the first found role.
        /// </summary>
        /// <remarks>This makes an IMDS call to retrieve the name of the IAM role associated with the instance during construction.</remarks>
        /// <exception cref="AmazonServiceException">Thrown when unable to retrieve the name of the IAM role.</exception>
        public InstanceProfileAWSCredentials()
            : this(proxy: null) { }

        /// <summary>
        /// Constructs <see cref="InstanceProfileAWSCredentials"/> for the first found role.
        /// </summary>
        /// <remarks>This makes an IMDS call to retrieve the name of the IAM role associated with the instance during construction.</remarks>
        /// <param name="proxy">Proxy used to process requests to the instance metadata service</param>
        /// <exception cref="AmazonServiceException">Thrown when unable to retrieve the name of the IAM role.</exception>
        public InstanceProfileAWSCredentials(IWebProxy proxy)
            : this(GetFirstRole(proxy), proxy) { }

        #endregion


        #region Public static methods

        /// <summary>
        /// Retrieves a list of all roles available through current InstanceProfile service
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAvailableRoles()
        {
            return GetAvailableRoles(null);
        }

        /// <summary>
        /// Retrieves a list of all roles available through current InstanceProfile service
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAvailableRoles(IWebProxy proxy)
        {
            var token = EC2InstanceMetadata.FetchApiToken();

            var allAliases = string.Empty;
            try
            {
                allAliases = GetContents(RolesUri, proxy, CreateMetadataTokenHeaders(token));
            }
            catch (Exception e)
            {
                HttpStatusCode? httpStatusCode = ExceptionUtils.DetermineHttpStatusCode(e);

                if (httpStatusCode == HttpStatusCode.Unauthorized)
                {
                    Logger.GetLogger(typeof(EC2InstanceMetadata)).Error(e, "EC2 Metadata service returned unauthorized for token based secure data flow.");
                }

                throw;
            }
            if (string.IsNullOrEmpty(allAliases))
                yield break;

            string[] parts = allAliases.Split(AliasSeparators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var part in parts)
            {
                var trim = part.Trim();
                if (!string.IsNullOrEmpty(trim))
                    yield return trim;
            }
        }

        /// <summary>
        /// Retrieves a list of all roles available through current InstanceProfile service
        /// </summary>
        /// <returns></returns>
        public static async Task<IEnumerable<string>> GetAvailableRolesAsync(IWebProxy proxy)
        {
            var token = await EC2InstanceMetadata.FetchApiTokenAsync().ConfigureAwait(false);
            var roles = new List<string>();
            var allAliases = string.Empty;
            try
            {
                allAliases = await GetContentsAsync(RolesUri, proxy, CreateMetadataTokenHeaders(token)).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                HttpStatusCode? httpStatusCode = ExceptionUtils.DetermineHttpStatusCode(e);

                if (httpStatusCode == HttpStatusCode.Unauthorized)
                {
                    Logger.GetLogger(typeof(EC2InstanceMetadata)).Error(e, "EC2 Metadata service returned unauthorized for token based secure data flow.");
                }

                throw;
            }
            if (!string.IsNullOrEmpty(allAliases))
            {
                string[] parts = allAliases.Split(AliasSeparators, StringSplitOptions.RemoveEmptyEntries);
                foreach (var part in parts)
                {
                    var trim = part.Trim();
                    if (!string.IsNullOrEmpty(trim))
                        roles.Add(trim);
                }
            }

            return roles;
        }

        #endregion


        #region Private members

        private static string[] AliasSeparators = new string[] { "<br/>" };
        private static string Server = EC2InstanceMetadata.ServiceEndpoint;
        private static string RolesPath = "/latest/meta-data/iam/security-credentials/";
        private static string InfoPath = "/latest/meta-data/iam/info";

        /// <summary>
        /// Resets the cached IMDS service endpoint so that the next credential fetch picks up
        /// any change to <see cref="EC2InstanceMetadata.ServiceEndpoint"/> (e.g. a change to
        /// the <c>AWS_EC2_METADATA_SERVICE_ENDPOINT</c> environment variable).
        /// </summary>
        internal static void ResetServiceEndpoint()
        {
            Server = EC2InstanceMetadata.ServiceEndpoint;
        }

        private static Uri RolesUri
        {
            get
            {
                return new Uri(Server + RolesPath);
            }
        }
        private Uri CurrentRoleUri
        {
            get
            {
                return new Uri(Server + RolesPath + Role);
            }
        }
        private static Uri InfoUri
        {
            get
            {
                return new Uri(Server + InfoPath);
            }
        }

        private CredentialsRefreshState GetRefreshState(string token)
        {
            SecurityInfo info = GetServiceInfo(_proxy, token);
            if (!string.IsNullOrEmpty(info.Message))
            {
                throw new AmazonServiceException(string.Format(CultureInfo.InvariantCulture,
                    "Unable to retrieve credentials. Message = \"{0}\".",
                    info.Message));
            }

            var credentials = GetRoleCredentials(token);

            var refreshState = 
                new CredentialsRefreshState(
                    new ImmutableCredentials(
                        credentials.AccessKeyId, 
                        credentials.SecretAccessKey, 
                        credentials.Token), 
                    credentials.Expiration);

            return refreshState;
        }

        private async Task<CredentialsRefreshState> GetRefreshStateAsync(string token)
        {
            SecurityInfo info = await GetServiceInfoAsync(_proxy, token).ConfigureAwait(false);
            if (!string.IsNullOrEmpty(info.Message))
            {
                throw new AmazonServiceException(string.Format(CultureInfo.InvariantCulture,
                    "Unable to retrieve credentials. Message = \"{0}\".",
                    info.Message));
            }

            var credentials = await GetRoleCredentialsAsync(token).ConfigureAwait(false);

            var refreshState =
                new CredentialsRefreshState(
                    new ImmutableCredentials(
                        credentials.AccessKeyId,
                        credentials.SecretAccessKey,
                        credentials.Token),
                    credentials.Expiration);

            return refreshState;
        }

        private static SecurityInfo GetServiceInfo(IWebProxy proxy, string token)
        {
            CheckIsIMDSEnabled();
            return GetObjectFromResponse<SecurityInfo, SecurityInfoJsonSerializerContexts>(InfoUri, proxy, CreateMetadataTokenHeaders(token));
        }

        private static async Task<SecurityInfo> GetServiceInfoAsync(IWebProxy proxy, string token)
        {
            CheckIsIMDSEnabled();
            return await GetObjectFromResponseAsync<SecurityInfo, SecurityInfoJsonSerializerContexts>(InfoUri, proxy, CreateMetadataTokenHeaders(token)).ConfigureAwait(false);
        }

        private SecurityCredentials GetRoleCredentials(string token)
        {
            CheckIsIMDSEnabled();
            return GetObjectFromResponse<SecurityCredentials, SecurityCredentialsJsonSerializerContexts>(CurrentRoleUri, _proxy, CreateMetadataTokenHeaders(token));
        }

        private async Task<SecurityCredentials> GetRoleCredentialsAsync(string token)
        {
            CheckIsIMDSEnabled();
            return await GetObjectFromResponseAsync<SecurityCredentials, SecurityCredentialsJsonSerializerContexts>(CurrentRoleUri, _proxy, CreateMetadataTokenHeaders(token)).ConfigureAwait(false);
        }

        private static void CheckIsIMDSEnabled()
        {
            // keep this behavior consistent with GetObjectFromResponse case.
            if (!EC2InstanceMetadata.IsIMDSEnabled) throw new AmazonServiceException(string.Format(CultureInfo.InvariantCulture, "Unable to retrieve credentials."));
        }

        private static string GetFirstRole()
        {
            return GetFirstRole(null);
        }

        private static async Task<string> GetFirstRoleAsync()
        {
            return await GetFirstRoleAsync(null).ConfigureAwait(false);
        }

        private static string GetFirstRole(IWebProxy proxy)
        {
            IEnumerable<string> roles = GetAvailableRoles(proxy);
            foreach (string role in roles)
            {
                return role;
            }

            // no roles found
            throw new InvalidOperationException("No roles found");
        }

        private static async Task<string> GetFirstRoleAsync(IWebProxy proxy)
        {
            IEnumerable<string> roles = await GetAvailableRolesAsync(proxy).ConfigureAwait(false);
            foreach (string role in roles)
            {
                return role;
            }

            // no roles found
            throw new InvalidOperationException("No roles found");
        }

        /// <summary>
        /// Return true if string is null or whitespace, false otherwise.
        /// We can't use String.IsNullOrWhitespace because it doesn't exist
        /// in all frameworks we support.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static bool IsNullOrWhiteSpace(string s)
        {
            if (s == null)
                return true;
            else if (s.Trim().Length == 0)
                return true;
            else
                return false;
        }

        private static Dictionary<string, string> CreateMetadataTokenHeaders(string token)
        {
            Dictionary<string, string> headers = null;
            if (!string.IsNullOrEmpty(token))
            {
                headers = new Dictionary<string, string>();
                headers.Add(HeaderKeys.XAwsEc2MetadataToken, token);
            }

            return headers;
        }
                
        #endregion
    }
}
