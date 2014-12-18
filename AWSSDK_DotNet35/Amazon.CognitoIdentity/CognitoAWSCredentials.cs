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
            public string OldIdentityId { get; private set; }
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
                var cachedIdentityId = this.GetCachedIdentityId();
                if (string.IsNullOrEmpty(cachedIdentityId))
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
                else
                {
                    UpdateIdentity(cachedIdentityId, false);
                }
            }

            return identityId;
        }

#if !BCL35
        /// <summary>
        /// Gets the Identity Id corresponding to the credentials retrieved from Cognito.
        /// Note: this setting may change during execution. To be notified of its
        /// new value, attach a listener to IdentityChangedEvent
        /// </summary>
        public async System.Threading.Tasks.Task<string> GetIdentityIdAsync()
        {
            if (!IsIdentitySet)
            {
                var cachedIdentityId = this.GetCachedIdentityId();
                if (string.IsNullOrEmpty(cachedIdentityId))
                {
                    var getIdRequest = new GetIdRequest
                    {
                        AccountId = AccountId,
                        IdentityPoolId = IdentityPoolId,
                        Logins = Logins
                    };

                    var getIdResult = await cib.GetIdAsync(getIdRequest);

                    UpdateIdentity(getIdResult.IdentityId, true);
                }
                else
                {
                    UpdateIdentity(cachedIdentityId, false);
                }
            }

            return identityId;
        }
#endif

        /// <summary>
        /// Event for identity change notifications.
        /// This event will fire whenever the Identity Id changes.
        /// </summary>
        public event EventHandler<IdentityChangedArgs> IdentityChangedEvent;

        #endregion

        #region Constructors

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
            if (string.IsNullOrEmpty(accountId)) throw new ArgumentNullException("accountId");
            if (string.IsNullOrEmpty(identityPoolId)) throw new ArgumentNullException("identityPoolId");
            if (string.IsNullOrEmpty(unAuthRoleArn) && string.IsNullOrEmpty(authRoleArn))
                throw new InvalidOperationException("At least one of unAuthRoleArn or authRoleArn must be specified");
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

#if BCL45 || WIN_RT || WINDOWS_PHONE 
        protected override async System.Threading.Tasks.Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
        {
            // Retrieve Open Id Token
            // (Reuses existing IdentityId or creates a new one)
            var getTokenRequest = new GetOpenIdTokenRequest { IdentityId = await GetIdentityIdAsync().ConfigureAwait(false) };
            // If logins are set, pass them to the GetOpenId call
            if (Logins.Count > 0)
                getTokenRequest.Logins = Logins;
            var getTokenResult = await cib.GetOpenIdTokenAsync(getTokenRequest).ConfigureAwait(false);
            string token = getTokenResult.Token;

            // IdentityId may have changed, save the new value
            UpdateIdentity(getTokenResult.IdentityId, true);

            // Pick role to use, depending on Logins
            string roleArn = UnAuthRoleArn;
            if (Logins.Count > 0)
                roleArn = AuthRoleArn;
            if (string.IsNullOrEmpty(roleArn))
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Unable to determine Role ARN. AuthRoleArn = [{0}], UnAuthRoleArn = [{1}], Logins.Count = {2}",
                    AuthRoleArn, UnAuthRoleArn, Logins.Count));

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
            var credentialsState = new CredentialsRefreshState(credentials.GetCredentials(), credentials.Expiration);
            return credentialsState;
        }
#endif

        // Retrieves credentials from Cognito Identity and STS
        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            // Retrieve Open Id Token
            // (Reuses existing IdentityId or creates a new one)
            var getTokenRequest = new GetOpenIdTokenRequest { IdentityId = GetIdentityId() };
            // If logins are set, pass them to the GetOpenId call
            if (Logins.Count > 0)
                getTokenRequest.Logins = Logins;
            var getTokenResult = GetOpenId(getTokenRequest);
            string token = getTokenResult.Token;

            // IdentityId may have changed, save the new value
            UpdateIdentity(getTokenResult.IdentityId, true);

            // Pick role to use, depending on Logins
            string roleArn = UnAuthRoleArn;
            if (Logins.Count > 0)
                roleArn = AuthRoleArn;
            if (string.IsNullOrEmpty(roleArn))
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Unable to determine Role ARN. AuthRoleArn = [{0}], UnAuthRoleArn = [{1}], Logins.Count = {2}",
                    AuthRoleArn, UnAuthRoleArn, Logins.Count));

            // Assume role with Open Id Token
            var assumeRequest = new AssumeRoleWithWebIdentityRequest
            {
                WebIdentityToken = token,
                RoleArn = roleArn,
                RoleSessionName = "NetProviderSession",
                DurationSeconds = DefaultDurationSeconds
            };
            var credentials = GetStsCredentials(assumeRequest);

            // Return new refresh state (credentials and expiration)
            var credentialsState = new CredentialsRefreshState(credentials.GetCredentials(), credentials.Expiration);
            return credentialsState;
        }

        #endregion
    }
}
