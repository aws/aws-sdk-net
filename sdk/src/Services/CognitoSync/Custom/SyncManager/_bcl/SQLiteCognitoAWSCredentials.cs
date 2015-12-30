using Amazon.CognitoIdentity;
using Amazon.CognitoSync.SyncManager.Internal;
using System;

namespace Amazon.CognitoSync.SyncManager
{
    /// <summary>
    /// The SQLiteCognitoAWSCredentials extends from <see cref="Amazon.CognitoIdentity.CognitoAWSCredentials"/> 
    /// and adds support for caching of identity id using SQLite
    /// </summary>
    public class SQLiteCognitoAWSCredentials : CognitoAWSCredentials
    {

        /// <summary>
        /// Constructs a new SQLiteCognitoAWSCredentials instance, which will use the
        /// specified Amazon Cognito identity pool to get short lived session credentials.
        /// </summary>
        /// <param name="identityPoolId">The Amazon Cogntio identity pool to use</param>
        /// <param name="region">Region to use when accessing Amazon Cognito and AWS Security Token Service.</param>
        public SQLiteCognitoAWSCredentials(string identityPoolId, RegionEndpoint region)
            : base(identityPoolId, region) { }


        /// <summary>
        /// Constructs a new SQLiteCognitoAWSCredentials instance, which will use the
        /// specified Amazon Cognito identity pool to make a requests to the
        /// AWS Security Token Service (STS) to request short lived session credentials.
        /// </summary>
        /// <param name="accountId">The AWS accountId for the account with Amazon Cognito</param>
        /// <param name="identityPoolId">The Amazon Cogntio identity pool to use</param>
        /// <param name="unAuthRoleArn">The ARN of the IAM Role that will be assumed when unauthenticated</param>
        /// <param name="authRoleArn">The ARN of the IAM Role that will be assumed when authenticated</param>
        /// <param name="region">Region to use when accessing Amazon Cognito and AWS Security Token Service.</param>
        public SQLiteCognitoAWSCredentials(string accountId, string identityPoolId, string unAuthRoleArn, string authRoleArn, RegionEndpoint region)
            : base(accountId, identityPoolId, unAuthRoleArn, authRoleArn, region) { }


        private const String IDENTITY_ID_CACHE_KEY = "CognitoIdentity:IdentityId";

        /// <summary>
        /// Caches the identity id retrieved from Cognito. 
        /// </summary>
        /// <param name="identityId">The Cognito identity id to cache</param>
        [System.Security.SecuritySafeCritical]
        public override void CacheIdentityId(string identityId)
        {
            base.CacheIdentityId(identityId);
            using (var kvStore = new SQLiteLocalStorage())
            {
                kvStore.CacheIdentity(GetNamespacedKey(IDENTITY_ID_CACHE_KEY), identityId);
            }
        }

        /// <summary>
        /// Clears the currently identity id from the cache.
        /// </summary>
        [System.Security.SecuritySafeCritical]
        public override void ClearIdentityCache()
        {
            base.ClearIdentityCache();
            using (var kvStore = new SQLiteLocalStorage())
            {
                kvStore.DeleteCachedIdentity(GetNamespacedKey(IDENTITY_ID_CACHE_KEY));
            }
        }

        /// <summary>
        /// Gets the previously cached the identity id retrieved from Cognito. 
        /// </summary>
        /// <returns>The previously cached identity id</returns>
        [System.Security.SecuritySafeCritical]
        public override string GetCachedIdentityId()
        {
            string identityId = null;
            using (var kvStore = new SQLiteLocalStorage())
            {
                identityId = kvStore.GetIdentity(GetNamespacedKey(IDENTITY_ID_CACHE_KEY));
            }
            return identityId;
        }

    }

}
