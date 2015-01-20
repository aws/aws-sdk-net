using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;

using Amazon.CognitoIdentity.Model;
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
        private Amazon.SecurityToken.Model.Credentials GetStsCredentials(AssumeRoleWithWebIdentityRequest assumeRequest)
        {
            var assumeResult = Amazon.Runtime.Internal.Util.AsyncHelpers.RunSync<AssumeRoleWithWebIdentityResponse>(() => sts.AssumeRoleWithWebIdentityAsync(assumeRequest));
            var credentials = assumeResult.Credentials;
            return credentials;
        }

        private GetOpenIdTokenResponse GetOpenId(GetOpenIdTokenRequest getTokenRequest)
        {
            var getTokenResult = Amazon.Runtime.Internal.Util.AsyncHelpers.RunSync<GetOpenIdTokenResponse>(() => cib.GetOpenIdTokenAsync(getTokenRequest));
            return getTokenResult;
        }

        private Amazon.CognitoIdentity.Model.Credentials GetCredentialsForIdentity(GetCredentialsForIdentityRequest getCredentialsRequest)
        {
            var getCredentialsResult = Amazon.Runtime.Internal.Util.AsyncHelpers.RunSync<GetCredentialsForIdentityResponse>(() => cib.GetCredentialsForIdentityAsync(getCredentialsRequest));
            var credentials = getCredentialsResult.Credentials;
            return credentials;
        }

        /// <summary>
        /// The types of caching used for storing Cognito identity id.
        /// </summary>
        public enum CacheMode 
        {
            /// <summary>
            /// Turns off caching
            /// </summary>
            None, 
            /// <summary>
            /// Sets caching to use Windows.Storage.ApplicationData.Current.LocalSettings
            /// </summary>
            LocalSettings, 
            /// <summary>
            /// Sets caching to use Windows.Storage.ApplicationData.Current.RoamingSettings
            /// </summary>
            RoamingSettings 
        };

        private CacheMode _identityIdCacheMode = CacheMode.LocalSettings;

        /// <summary>
        /// Gets and sets the IdentityIdCacheMode. This property controls how the 
        /// Cognito identity id is cached. The default value is LocalSettings.
        /// </summary>
        public CacheMode IdentityIdCacheMode
        {
            get { return this._identityIdCacheMode; }
            set { this._identityIdCacheMode = value; }
        }

        const string IDENTITY_ID_CACHE_KEY = "CognitoIdentity:IdentityId";

        /// <summary>
        /// Gets the previously cached the identity id retrieved from Cognito. 
        /// <para>
        /// For the Windows Phone and Windows Store version of the SDK the identity id is stored in the 
        /// Windows.Storage.ApplicationData.Current.LocalSettings or 
        /// Windows.Storage.ApplicationData.Current.RoamingSettings depending on the IdentityIdCacheMode
        /// property. By default IdentityIdCacheMode will be set LocalSettings.
        /// </para>
        /// <para>
        /// For the base .NET 3.5 and .NET 4.5 version of the SDK the identity id is not cached. To support caching 
        /// the CacheIdentityId and GetCachedIdentityId methods need to be overridden.
        /// </para>
        /// </summary>
        /// <returns>The previously cached identity id</returns>
        public virtual string GetCachedIdentityId()
        {
            switch(this._identityIdCacheMode)
            {
                case CacheMode.LocalSettings:
                    return Windows.Storage.ApplicationData.Current.LocalSettings.Values[IDENTITY_ID_CACHE_KEY] as string;
                case CacheMode.RoamingSettings:
                    return Windows.Storage.ApplicationData.Current.RoamingSettings.Values[IDENTITY_ID_CACHE_KEY] as string;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Caches the identity id retrieved from Cognito. 
        /// <para>
        /// For the Windows Phone and Windows Store version of the SDK the identity id is stored in the 
        /// Windows.Storage.ApplicationData.Current.LocalSettings or 
        /// Windows.Storage.ApplicationData.Current.RoamingSettings depending on the IdentityIdCacheMode
        /// property.
        /// </para>
        /// <para>
        /// For the base .NET 3.5 and .NET 4.5 version of the SDK the identity id is not cached. To support caching 
        /// the CacheIdentityId and GetCachedIdentityId methods need to be overridden.
        /// </para>
        /// </summary>
        /// <param name="identityId">The Cognito identity id to cache</param>
        public virtual void CacheIdentityId(string identityId)
        {
            switch (this._identityIdCacheMode)
            {
                case CacheMode.LocalSettings:
                    Windows.Storage.ApplicationData.Current.LocalSettings.Values[IDENTITY_ID_CACHE_KEY] = identityId;
                    break;
                case CacheMode.RoamingSettings:
                    Windows.Storage.ApplicationData.Current.RoamingSettings.Values[IDENTITY_ID_CACHE_KEY] = identityId;
                    break;
            }
        }

        protected virtual void ClearIdentityCache()
        {
            switch (this._identityIdCacheMode)
            {
                case CacheMode.LocalSettings:
                    Windows.Storage.ApplicationData.Current.LocalSettings.Values[IDENTITY_ID_CACHE_KEY] = null;
                    break;
                case CacheMode.RoamingSettings:
                    Windows.Storage.ApplicationData.Current.RoamingSettings.Values[IDENTITY_ID_CACHE_KEY] = null;
                    break;
            }

        }
    }
}
