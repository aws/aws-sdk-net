using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Amazon.CognitoIdentity.Model;
using Amazon.Runtime;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

namespace Amazon.CognitoIdentity
{
    /// <summary>
    /// Temporary, short-lived session credentials that are automatically retrieved from
    /// Amazon Cognito Identity Service and AWS Security Token Service.
    /// Depending on configured Logins, credentials may be authenticated or unauthenticated.
    /// </summary>
    public partial class CognitoAWSCredentials : RefreshingAWSCredentials
    {
        #region Private members

        private string identityId;
        private static int DefaultDurationSeconds = (int)TimeSpan.FromHours(1).TotalSeconds;
        private IAmazonCognitoIdentity cib;
        private IAmazonSecurityTokenService sts;
        private bool IsIdentitySet { get { return !string.IsNullOrEmpty(identityId); } }

        // Updates IdentityId to new value and fires IdentityChangedEvent
        private void UpdateIdentity(string newIdentityId, bool updateCache)
        {
            // No-op if new IdentityId is same as old
            if (string.Equals(identityId, newIdentityId, StringComparison.Ordinal))
                return;

            if (updateCache)
                this.CacheIdentityId(newIdentityId);

            // Swap in new identity
            string oldIdentityId = identityId;
            identityId = newIdentityId;

            // Fire the event
            var handler = IdentityChangedEvent;
            if (handler != null)
            {
                var args = new IdentityChangedArgs(oldIdentityId, newIdentityId);
                handler(this, args);
            }
        }

        #endregion

        #region Public properties, methods, classes, and events

        /// <summary>
        /// Information about an identity change in the CognitoAWSCredentials.
        /// </summary>
        public class IdentityChangedArgs : EventArgs
        {
            /// <summary>
            /// Gets the OldIdentityId property.
            /// </summary>
            public string OldIdentityId { get; private set; }

            /// <summary>
            /// Gets the NewIdentityId property.
            /// </summary>
            public string NewIdentityId { get; private set; }

            internal IdentityChangedArgs(string oldIdentityId, string newIdentityId)
            {
                OldIdentityId = oldIdentityId;
                NewIdentityId = newIdentityId;
            }
        }

        /// <summary>
        /// The AWS accountId for the account with Amazon Cognito
        /// </summary>
        public string AccountId { get; private set; }
        /// <summary>
        /// The Amazon Cogntio identity pool to use
        /// </summary>
        public string IdentityPoolId { get; private set; }

        /// <summary>
        /// The ARN of the IAM Role that will be assumed when unauthenticated
        /// </summary>
        public string UnAuthRoleArn { get; private set; }

        /// <summary>
        /// The ARN of the IAM Role that will be assumed when authenticated
        /// </summary>
        public string AuthRoleArn { get; private set; }

        /// <summary>
        /// Logins map used to authenticated with Amazon Cognito.
        /// Note: After modifying this field, you must manually call Clear on this
        /// instance of the CognitoAWSCredentials, as your Identity Id may have changed.
        /// </summary>
        private Dictionary<string, string> Logins { get; set; }

        /// <summary>
        /// Clears current credentials state. This will reset the IdentityId.
        /// </summary>
        public void Clear()
        {
            identityId = null;
            ClearCredentials();
            ClearIdentityCache();
        }

        /// <summary>
        /// The list of current providers that are used for authenticated credentials.
        /// </summary>
        public string[] CurrentLoginProviders
        {
            get { return this.Logins.Keys.ToArray(); }
        }

        /// <summary>
        /// Removes a provider from the collection of logins.
        /// </summary>
        /// <param name="providerName">The provider name for the login (i.e. graph.facebook.com)</param>
        public void RemoveLogin(string providerName)
        {
            this.Logins.Remove(providerName);
            this.Clear();
        }

        /// <summary>
        /// Adds a login to be used for authenticated requests.
        /// </summary>
        /// <param name="providerName">The provider name for the login (i.e. graph.facebook.com)</param>
        /// <param name="token">The token provided by the identity provider.</param>
        public void AddLogin(string providerName, string token)
        {
            Logins[providerName] = token;
            this.Clear();
        }

        /// <summary>
        /// Gets the Identity Id corresponding to the credentials retrieved from Cognito.
        /// Note: this setting may change during execution. To be notified of its
        /// new value, attach a listener to IdentityChangedEvent
        /// </summary>
        public string GetIdentityId()
        {
            if (!IsIdentitySet)
            {
                var getIdRequest = new GetIdRequest
                {
                    AccountId = AccountId,
                    IdentityPoolId = IdentityPoolId,
                    Logins = Logins
                };
#if BCL
                var response = cib.GetId(getIdRequest);
#else
                var response = Amazon.Runtime.Internal.Util.AsyncHelpers.RunSync<GetIdResponse>(() => cib.GetIdAsync(getIdRequest));
#endif

                UpdateIdentity(response.IdentityId, true);
            }

            return identityId;
        }

        /// Checks to see if there is a cached identity id first and falls back to getting a fresh identity id by calling
        /// GetIdentityId()
        private GetIdentityIdStatus GetIdentityIdWithCaching()
        {
            if (!IsIdentitySet)
            {
                var cachedIdentityId = this.GetCachedIdentityId();
                if (string.IsNullOrEmpty(cachedIdentityId))
                {
                    var newIdentityId = GetIdentityId();
                    return new GetIdentityIdStatus(newIdentityId, fromCache: false);
                }
                else
                {
                    UpdateIdentity(cachedIdentityId, false);
                    return new GetIdentityIdStatus(cachedIdentityId, fromCache: true);
                }
            }
            return new GetIdentityIdStatus(identityId, fromCache: false);
        }

#if AWS_ASYNC_API
        /// <summary>
        /// Gets the Identity Id corresponding to the credentials retrieved from Cognito.
        /// Note: this setting may change during execution. To be notified of its
        /// new value, attach a listener to IdentityChangedEvent
        /// </summary>
        public async System.Threading.Tasks.Task<string> GetIdentityIdAsync()
        {
            if (!IsIdentitySet)
            {
                var getIdRequest = new GetIdRequest
                {
                    AccountId = AccountId,
                    IdentityPoolId = IdentityPoolId,
                    Logins = Logins
                };

                var getIdResult = await cib.GetIdAsync(getIdRequest).ConfigureAwait(false);

                UpdateIdentity(getIdResult.IdentityId, true);
            }

            return identityId;
        }

        /// <summary>
        /// Checks to see if there is a cached identity id first and falls back to getting a fresh identity id by calling
        /// GetIdentityIdAsync()
        /// </summary>
        /// <returns></returns>
        private async System.Threading.Tasks.Task<GetIdentityIdStatus> GetIdentityIdWithCachingAsync()
        {
            if (!IsIdentitySet)
            {
                var cachedIdentityId = this.GetCachedIdentityId();
                if (string.IsNullOrEmpty(cachedIdentityId))
                {
                    var newIdentityId = await GetIdentityIdAsync().ConfigureAwait(false);
                    return new GetIdentityIdStatus(newIdentityId, fromCache: false);
                }
                else
                {
                    UpdateIdentity(cachedIdentityId, false);
                    return new GetIdentityIdStatus(cachedIdentityId, fromCache: true);
                }
            }
            return new GetIdentityIdStatus(identityId, fromCache: false);
        }

#endif

        /// <summary>
        /// Simple class for returning back and identity id and whether the id returned was from a cache.
        /// </summary>
        class GetIdentityIdStatus
        {
            public GetIdentityIdStatus(string identityid, bool fromCache)
            {
                this.IdentityId = identityid;
                this.FromCache = fromCache;
            }

            public string IdentityId { get; set; }
            public bool FromCache { get; set; }
        }

        /// <summary>
        /// Checks the exception from a call that used an identity id and determines if the 
        /// failure was caused by a cached identity id. If it was determined then the cache
        /// is cleared and true is return.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        private bool ShouldRetry(AmazonCognitoIdentityException e, GetIdentityIdStatus status)
        {
            if (status.FromCache &&
                    ((e is NotAuthorizedException && e.Message.StartsWith("Access to Identity", StringComparison.OrdinalIgnoreCase)) ||
                      e is ResourceNotFoundException)
               )
            {
                this.identityId = null;
                this.ClearIdentityCache();

                return true;
            }

            return false;
        }

        /// <summary>
        /// Event for identity change notifications.
        /// This event will fire whenever the Identity Id changes.
        /// </summary>
        public event EventHandler<IdentityChangedArgs> IdentityChangedEvent;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new CognitoAWSCredentials instance, which will use the
        /// specified Amazon Cognito identity pool to get short lived session credentials.
        /// </summary>
        /// <param name="identityPoolId">The Amazon Cogntio identity pool to use</param>
        /// <param name="region">Region to use when accessing Amazon Cognito and AWS Security Token Service.</param>
        public CognitoAWSCredentials(string identityPoolId, RegionEndpoint region)
            : this(
                accountId: null, identityPoolId: identityPoolId,
                unAuthRoleArn: null, authRoleArn: null,
                region: region)
        { }

        /// <summary>
        /// Constructs a new CognitoAWSCredentials instance, which will use the
        /// specified Amazon Cognito identity pool to make a requests to the
        /// AWS Security Token Service (STS) to request short lived session credentials.
        /// </summary>
        /// <param name="accountId">The AWS accountId for the account with Amazon Cognito</param>
        /// <param name="identityPoolId">The Amazon Cogntio identity pool to use</param>
        /// <param name="unAuthRoleArn">The ARN of the IAM Role that will be assumed when unauthenticated</param>
        /// <param name="authRoleArn">The ARN of the IAM Role that will be assumed when authenticated</param>
        /// <param name="region">Region to use when accessing Amazon Cognito and AWS Security Token Service.</param>
        public CognitoAWSCredentials(
            string accountId, string identityPoolId,
            string unAuthRoleArn, string authRoleArn,
            RegionEndpoint region)
            : this(
                accountId, identityPoolId,
                unAuthRoleArn, authRoleArn,
                new AmazonCognitoIdentityClient(new AnonymousAWSCredentials(), region),
                new AmazonSecurityTokenServiceClient(new AnonymousAWSCredentials(), region))
        { }

        /// <summary>
        /// Constructs a new CognitoAWSCredentials instance, which will use the
        /// specified Amazon Cognito identity pool to make a requests to the
        /// AWS Security Token Service (STS) to request short lived session credentials.
        /// </summary>
        /// <param name="accountId">The AWS accountId for the account with Amazon Cognito</param>
        /// <param name="identityPoolId">The Amazon Cogntio identity pool to use</param>
        /// <param name="unAuthRoleArn">The ARN of the IAM Role that will be assumed when unauthenticated</param>
        /// <param name="authRoleArn">The ARN of the IAM Role that will be assumed when authenticated</param>
        /// <param name="cibClient">Preconfigured Cognito Identity client to make requests with</param>
        /// <param name="stsClient">>Preconfigured STS client to make requests with</param>
        public CognitoAWSCredentials(
            string accountId, string identityPoolId,
            string unAuthRoleArn, string authRoleArn,
            IAmazonCognitoIdentity cibClient, IAmazonSecurityTokenService stsClient)
        {
            if (string.IsNullOrEmpty(identityPoolId)) throw new ArgumentNullException("identityPoolId");
            if (cibClient == null) throw new ArgumentNullException("cibClient");
            if (stsClient == null) throw new ArgumentNullException("stsClient");

            AccountId = accountId;
            IdentityPoolId = identityPoolId;
            UnAuthRoleArn = unAuthRoleArn;
            AuthRoleArn = authRoleArn;
            Logins = new Dictionary<string, string>(StringComparer.Ordinal);
            cib = cibClient;
            sts = stsClient;
        }

        #endregion

        #region Overrides

#if AWS_ASYNC_API

        /// <summary>
        /// Retrieves credentials from Cognito Identity and optionally STS
        /// </summary>
        /// <returns></returns>
        protected override async System.Threading.Tasks.Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
        {
            CredentialsRefreshState credentialsState;

            // Pick role to use, depending on Logins
            string roleArn = UnAuthRoleArn;
            if (Logins.Count > 0)
                roleArn = AuthRoleArn;
            bool roleSpecified = !string.IsNullOrEmpty(roleArn);

            // Get credentials from determined role or from identity pool
            if (roleSpecified)
                credentialsState = await GetCredentialsForRoleAsync(roleArn).ConfigureAwait(false);
            else
                credentialsState = await GetPoolCredentialsAsync().ConfigureAwait(false);

            return credentialsState;
        }

        private async System.Threading.Tasks.Task<CredentialsRefreshState> GetCredentialsForRoleAsync(string roleArn)
        {
            CredentialsRefreshState credentialsState;
            // Retrieve Open Id Token
            // (Reuses existing IdentityId or creates a new one)
            var identity = await GetIdentityIdWithCachingAsync().ConfigureAwait(false);
            var getTokenRequest = new GetOpenIdTokenRequest { IdentityId = identity.IdentityId };
            // If logins are set, pass them to the GetOpenId call
            if (Logins.Count > 0)
                getTokenRequest.Logins = Logins;

            bool retry = false;
            GetOpenIdTokenResponse getTokenResult = null;
            try
            {
                getTokenResult = await cib.GetOpenIdTokenAsync(getTokenRequest).ConfigureAwait(false);
            }
            catch(AmazonCognitoIdentityException e)
            {
                if (ShouldRetry(e, identity))
                    retry = true;
                else
                    throw;
            }

            if(retry)
            {
                return await GetCredentialsForRoleAsync(roleArn).ConfigureAwait(false);
            }

            string token = getTokenResult.Token;

            // IdentityId may have changed, save the new value
            UpdateIdentity(getTokenResult.IdentityId, true);

            // Assume role with Open Id Token
            var assumeRequest = new AssumeRoleWithWebIdentityRequest
            {
                WebIdentityToken = token,
                RoleArn = roleArn,
                RoleSessionName = "NetProviderSession",
                DurationSeconds = DefaultDurationSeconds
            };
            var credentials = (await sts.AssumeRoleWithWebIdentityAsync(assumeRequest).ConfigureAwait(false)).Credentials;

            // Return new refresh state (credentials and expiration)
            credentialsState = new CredentialsRefreshState(credentials.GetCredentials(), credentials.Expiration);
            return credentialsState;
        }

        // Retrieves credentials for the roles defined on the identity pool
        private async System.Threading.Tasks.Task<CredentialsRefreshState> GetPoolCredentialsAsync()
        {
            CredentialsRefreshState credentialsState;
            var identity = await GetIdentityIdWithCachingAsync().ConfigureAwait(false);
            var getCredentialsRequest = new GetCredentialsForIdentityRequest { IdentityId = identity.IdentityId };
            if (Logins.Count > 0)
                getCredentialsRequest.Logins = Logins;

            bool retry = false;
            GetCredentialsForIdentityResponse response = null;
            try
            {
                response = (await cib.GetCredentialsForIdentityAsync(getCredentialsRequest).ConfigureAwait(false));
                // IdentityId may have changed, save the new value
                UpdateIdentity(response.IdentityId, true);
            }
            catch (AmazonCognitoIdentityException e)
            {
                if (ShouldRetry(e, identity))
                    retry = true;
                else
                    throw;
            }

            if (retry)
            {
                return await GetPoolCredentialsAsync().ConfigureAwait(false);
            }


            var credentials = response.Credentials;
            credentialsState = new CredentialsRefreshState(credentials.GetCredentials(), credentials.Expiration);
            return credentialsState;
        }

#endif

        /// <summary>
        /// Retrieves credentials from Cognito Identity and optionally STS
        /// </summary>
        /// <returns></returns>
        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            CredentialsRefreshState credentialsState;

            // Pick role to use, depending on Logins
            string roleArn = UnAuthRoleArn;
            if (Logins.Count > 0)
                roleArn = AuthRoleArn;
            bool roleSpecified = !string.IsNullOrEmpty(roleArn);

            // Get credentials from determined role or from identity pool
            if (roleSpecified)
                credentialsState = GetCredentialsForRole(roleArn);
            else
                credentialsState = GetPoolCredentials();

            // Return new refresh state (credentials and expiration)
            return credentialsState;
        }

        // Retrieves credentials for the roles defined on the identity pool
        private CredentialsRefreshState GetPoolCredentials()
        {
            CredentialsRefreshState credentialsState;
            var identity = this.GetIdentityIdWithCaching();
            var getCredentialsRequest = new GetCredentialsForIdentityRequest { IdentityId = identity.IdentityId };
            if (Logins.Count > 0)
                getCredentialsRequest.Logins = Logins;

            bool retry = false;
            GetCredentialsForIdentityResponse response = null;
            try
            {
                response = GetCredentialsForIdentity(getCredentialsRequest);
            }
            catch (AmazonCognitoIdentityException e)
            {
                if (ShouldRetry(e, identity))
                    retry = true;
                else
                    throw;
            }

            if (retry)
            {
                return GetPoolCredentials();
            }

            // IdentityId may have changed, save the new value
            UpdateIdentity(response.IdentityId, true);

            var credentials = response.Credentials;
            credentialsState = new CredentialsRefreshState(credentials.GetCredentials(), credentials.Expiration);
            return credentialsState;
        }

        // Retrieves credentials for the specific role, by making a call to STS
        private CredentialsRefreshState GetCredentialsForRole(string roleArn)
        {
            CredentialsRefreshState credentialsState;
            // Retrieve Open Id Token
            // (Reuses existing IdentityId or creates a new one)
            var identity = this.GetIdentityIdWithCaching();
            var getTokenRequest = new GetOpenIdTokenRequest { IdentityId = identity.IdentityId };
            // If logins are set, pass them to the GetOpenId call
            if (Logins.Count > 0)
                getTokenRequest.Logins = Logins;

            bool retry = false;
            GetOpenIdTokenResponse getTokenResult = null;
            try 
            {
                getTokenResult = GetOpenId(getTokenRequest);
            }
            catch (AmazonCognitoIdentityException e)
            {
                if (ShouldRetry(e, identity))
                    retry = true;
                else
                    throw;
            }

            if (retry)
            {
                return GetCredentialsForRole(roleArn);
            }

            string token = getTokenResult.Token;

            // IdentityId may have changed, save the new value
            UpdateIdentity(getTokenResult.IdentityId, true);

            // Assume role with Open Id Token
            var assumeRequest = new AssumeRoleWithWebIdentityRequest
            {
                WebIdentityToken = token,
                RoleArn = roleArn,
                RoleSessionName = "NetProviderSession",
                DurationSeconds = DefaultDurationSeconds
            };
            var credentials = GetStsCredentials(assumeRequest);

            credentialsState = new CredentialsRefreshState(credentials.GetCredentials(), credentials.Expiration);
            return credentialsState;
        }

        #endregion
    }
}
