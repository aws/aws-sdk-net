using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

using Amazon.CognitoIdentity.Model;
using Amazon.Util.Internal.PlatformServices;

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

        private GetCredentialsForIdentityResponse GetCredentialsForIdentity(GetCredentialsForIdentityRequest getCredentialsRequest)
        {
            var getCredentialsResult = Amazon.Runtime.Internal.Util.AsyncHelpers.RunSync<GetCredentialsForIdentityResponse>(() => cib.GetCredentialsForIdentityAsync(getCredentialsRequest));
            return getCredentialsResult;
        }

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
        /// the CacheIdentityId, GetCachedIdentityId and ClearIdentityCache methods need to be overridden.
        /// </para>
        /// </summary>
        /// <returns>The previously cached identity id</returns>
        public virtual string GetCachedIdentityId()
        {
            // override this method to support caching
            return null;
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
        /// the CacheIdentityId, GetCachedIdentityId and ClearIdentityCache methods need to be overridden.
        /// </para>
        /// </summary>
        /// <param name="identityId">The Cognito identity id to cache</param>
        public virtual void CacheIdentityId(string identityId)
        {
            // override this method to support caching
        }

        /// <summary>
        /// Clears the currently identity id from the cache.
        /// <para>
        /// For the base .NET 3.5 and .NET 4.5 version of the SDK the identity id is not cached. To support caching 
        /// the CacheIdentityId, GetCachedIdentityId and ClearIdentityCache methods need to be overridden.
        /// </para>
        /// </summary>
        public virtual void ClearIdentityCache()
        {
            // override this method to support caching
        }

        /// <summary>
        /// Caches the credentials to player pref's
        /// </summary>
        public virtual void CacheCredentials(CredentialsRefreshState credentialsState)
        {
            //TODO: add support for caching
        }

        /// <summary>
        /// Gets the cached credentials state
        /// </summary>
        public virtual CredentialsRefreshState GetCachedCredentials()
        {
            return null;
            //TODO: add support for caching
        }

    }
}