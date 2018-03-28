using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

using Amazon.CognitoIdentity.Model;
using Amazon.Util.Storage;
using Amazon.Util.Storage.Internal;
using Amazon.Util.Internal.PlatformServices;
using System.Threading;

namespace Amazon.CognitoIdentity
{
    /// <summary>
    /// Temporary, short-lived session credentials that are automatically retrieved from
    /// Amazon Cognito Identity Service and AWS Security Token Service.
    /// Depending on configured Logins, credentials may be authenticated or unauthenticated.
    /// </summary>
    public partial class CognitoAWSCredentials : RefreshingAWSCredentials
    {
        private static readonly String IDENTITY_ID_CACHE_KEY = "CognitoIdentity:IdentityId";

        private static object _lock = new object();


        #region private methods
        private Amazon.SecurityToken.Model.Credentials GetStsCredentials(AssumeRoleWithWebIdentityRequest assumeRequest)
        {
            var ars = new AutoResetEvent(false);
            Amazon.SecurityToken.Model.Credentials credentials = null;
            Exception exception = null;
            sts.AssumeRoleWithWebIdentityAsync(assumeRequest, (assumeResult) =>
            {
                if (assumeResult.Exception != null)
                    exception = assumeResult.Exception;
                else
                    credentials = assumeResult.Response.Credentials;
                
                ars.Set();
            });
            ars.WaitOne();

            if (exception != null)
                throw exception;

            return credentials;
        }

        private GetCredentialsForIdentityResponse GetCredentialsForIdentity(GetCredentialsForIdentityRequest getCredentialsRequest)
        {
            var result = cib.GetCredentialsForIdentity(getCredentialsRequest);
            return result;
        }

        private GetOpenIdTokenResponse GetOpenId(GetOpenIdTokenRequest getTokenRequest)
        {
            var getTokenResult = cib.GetOpenIdToken(getTokenRequest);
            return getTokenResult;
        }

        #endregion

        #region private methods (WebGL)

        private void GetIdentityIdWebGL(RefreshIdentityOptions options, Action<string> callback)
        {
            // Locking so that concurrent calls do not make separate network calls,
            // and instead wait for the first caller to cache the Identity ID.
            lock (refreshIdLock) 
            {
                if (!IsIdentitySet || options == RefreshIdentityOptions.Refresh) 
                {
                    RefreshIdentityWebGL(IdentityState => 
                    {
                        _identityState = IdentityState;

                        if (!string.IsNullOrEmpty(_identityState.LoginProvider)) 
                        {
                            Logins[_identityState.LoginProvider] = _identityState.LoginToken;
                        }
                        UpdateIdentity(_identityState.IdentityId);

                        callback(identityId);
                    });
                }
                else
                    callback(identityId);
            }
        }
        
        private void RefreshIdentityWebGL(Action<IdentityState> callback)
        {
            bool isCached = true;
            if (!IsIdentitySet) 
            {
                var getIdRequest = new GetIdRequest 
                {
                    AccountId = AccountId,
                    IdentityPoolId = IdentityPoolId,
                    Logins = Logins
                };

                cib.GetIdAsync(getIdRequest, result => 
                {
                    isCached = false;
                    UpdateIdentity(result.Response.IdentityId);

                    callback(new IdentityState(identityId, isCached));
                });
            }
            else
                callback(new IdentityState(identityId, isCached));
        }
        
        private void GenerateNewCredentialsWebGL(Action<CredentialsRefreshState> callback)
        {
            Action<CredentialsRefreshState> handleCredentials = credentialsState => 
            {
                CacheCredentials(credentialsState);

                // Return new refresh state (credentials and expiration)
                callback(credentialsState);
            };

            // Pick role to use, depending on Logins
            string roleArn = UnAuthRoleArn;
            if (Logins.Count > 0)
                roleArn = AuthRoleArn;
            bool roleSpecified = !string.IsNullOrEmpty(roleArn);

            // Get credentials from determined role or from identity pool
            if (roleSpecified)
                GetCredentialsForRoleWebGL(roleArn, handleCredentials);
            else
                GetPoolCredentialsWebGL(handleCredentials);
        }
        
        private void GetPoolCredentialsWebGL(Action<CredentialsRefreshState> callback)
        {
            CredentialsRefreshState credentialsState;
            this.GetIdentityIdWebGL(RefreshIdentityOptions.Refresh, identity => 
            {
                var getCredentialsRequest = new GetCredentialsForIdentityRequest { IdentityId = identity };

                if (Logins.Count > 0)
                    getCredentialsRequest.Logins = Logins;

                //incase its BYOI provider override the logins dictionary with the new instance and set the values for cognito-identity provider
                if (_identityState != null && !string.IsNullOrEmpty(_identityState.LoginToken)) 
                {
                    getCredentialsRequest.Logins = new Dictionary<string, string>();
                    getCredentialsRequest.Logins["cognito-identity.amazonaws.com"] = _identityState.LoginToken;
                }

                GetCredentialsForIdentityWebGL(getCredentialsRequest, (response, e) => 
                {
                    bool retry = false;

                    if (e is AmazonCognitoIdentityException) 
                    {
                        if (ShouldRetry(e as AmazonCognitoIdentityException))
                            retry = true;
                        else
                            throw e;
                    }

                    if (retry) 
                    {
                        GetPoolCredentialsWebGL(callback);
                        return;
                    }

                    // IdentityId may have changed, save the new value
                    UpdateIdentity(response.IdentityId);

                    var credentials = response.Credentials;
                    credentialsState = new CredentialsRefreshState(credentials.GetCredentials(), credentials.Expiration);
                    callback(credentialsState);
                });
            });
        }
        
        private void GetCredentialsForRoleWebGL(string roleArn, Action<CredentialsRefreshState> callback)
        {
            CredentialsRefreshState credentialsState;
            // Retrieve Open Id Token
            // (Reuses existing IdentityId or creates a new one)
            this.GetIdentityIdWebGL(RefreshIdentityOptions.Refresh, identity => 
            {
                var getTokenRequest = new GetOpenIdTokenRequest { IdentityId = identity };
                // If logins are set, pass them to the GetOpenId call
                if (Logins.Count > 0)
                    getTokenRequest.Logins = Logins;

                GetOpenIdWebGL(getTokenRequest, (getTokenResult, e) => 
                {
                    bool retry = false;

                    if (e is AmazonCognitoIdentityException) 
                    {
                        if (ShouldRetry(e as AmazonCognitoIdentityException))
                            retry = true;
                        else
                            throw e;
                    }

                    if (retry) 
                    {
                        GetCredentialsForRoleWebGL(roleArn, callback);
                        return;
                    }

                    string token = getTokenResult.Token;

                    // IdentityId may have changed, save the new value
                    UpdateIdentity(getTokenResult.IdentityId);

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
                    callback(credentialsState);
                });
            });
        }

        private void GetCredentialsForIdentityWebGL(GetCredentialsForIdentityRequest getCredentialsRequest, Action<GetCredentialsForIdentityResponse, Exception> callback)
        {
            cib.GetCredentialsForIdentityAsync(getCredentialsRequest, result => 
            {
                callback(result.Response, result.Exception);
            });
        }

        private void GetOpenIdWebGL(GetOpenIdTokenRequest getTokenRequest, Action<GetOpenIdTokenResponse, Exception> callback)
        {
            cib.GetOpenIdTokenAsync(getTokenRequest, result => 
            {
                callback(result.Response, result.Exception);
            });
        }

        private void GetCredentialsWebGL(Action<ImmutableCredentials> callback)
        {
            // If credentials are expired, update
            if (ShouldUpdate) 
                {
                GenerateNewCredentialsWebGL(state => 
                {
                    currentState = state;
                    UpdateToGeneratedCredentials(currentState);

                    callback(currentState.Credentials.Copy());
                });
            }
            else
                callback(currentState.Credentials.Copy());
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Gets the previously cached the identity id retrieved from Cognito. 
        /// For Unity, the Identity id is stored in PlayerPrefs
        /// </summary>
        /// <returns>The previously cached identity id</returns>
        public virtual string GetCachedIdentityId()
        {
            var settings = ServiceFactory.Instance.GetService<IApplicationSettings>();
            return settings.GetValue(GetNamespacedKey(IDENTITY_ID_CACHE_KEY), ApplicationSettingsMode.Local);
        }

        /// <summary>
        /// Caches the identity id retrieved from Cognito. 
        /// <para>
        /// For Unity, the Identity id is stored in PlayerPrefs
        /// property.
        /// </para>
        /// </summary>
        /// <param name="identityId">The Cognito identity id to cache</param>
        public virtual void CacheIdentityId(string identityId)
        {
            var settings = ServiceFactory.Instance.GetService<IApplicationSettings>();
            settings.SetValue(GetNamespacedKey(IDENTITY_ID_CACHE_KEY), identityId, ApplicationSettingsMode.Local);
        }

        /// <summary>
        /// Clears the currently identity id from the cache.
        /// </summary>
        public virtual void ClearIdentityCache()
        {
            var settings = ServiceFactory.Instance.GetService<IApplicationSettings>();
            settings.RemoveValue(GetNamespacedKey(IDENTITY_ID_CACHE_KEY), ApplicationSettingsMode.Local);
        }

        /// <summary>
        /// Caches the credentials to player pref's
        /// </summary>
        internal void CacheCredentials(CredentialsRefreshState credentialsState)
        {
            //TODO: add support for caching
        }

        /// <summary>
        /// Gets the cached credentials state
        /// </summary>
        internal CredentialsRefreshState GetCachedCredentials()
        {
            return null;
            //TODO: add support for caching
        }
        #endregion

        #region GetIdentityId

        /// <summary>
        /// Gets the Identity Id corresponding to the credentials retrieved from Cognito.
        /// Note: this setting may change during execution. To be notified of its
        /// new value, attach a listener to IdentityChangedEvent
        /// </summary>
        /// <param name="callback">The callback which is executed when the asynchronous operations is completed</param>
        /// <param name="options">Options for executing asynchronous operation</param>
        public void GetIdentityIdAsync(AmazonCognitoIdentityCallback<string> callback, AsyncOptions options = null)
        {
            options = options == null ? new AsyncOptions() : options;

            CognitoIdentityAsyncExecutor.ExecuteAsync<string>(() =>
            {
                return GetIdentityId();
            }, options, callback);
        }
        #endregion

        #region GetCredentials

        /// <summary>
        /// Returns an instance of ImmutableCredentials for this instance
        /// </summary>
        /// <param name="callback">The callback which is executed when the asynchronous operations is completed</param>
        /// <param name="options">Options for executing asynchronous operation</param>
        public void GetCredentialsAsync(AmazonCognitoIdentityCallback<ImmutableCredentials> callback, AsyncOptions options = null)
        {
            if(UnityEngine.Application.platform == UnityEngine.RuntimePlatform.WebGLPlayer) 
            {
                GetCredentialsWebGL(credentials => 
                {
                    var result = new AmazonCognitoIdentityResult<ImmutableCredentials>(credentials);
                    callback(result);
                });
            }
            else {
                options = options == null ? new AsyncOptions() : options;

                CognitoIdentityAsyncExecutor.ExecuteAsync<ImmutableCredentials>(() =>
                {
                    return GetCredentials();
                }, options, callback);
            }
           
        }

        #endregion

    }
}