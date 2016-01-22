using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.CognitoSync.SyncManager
{
    public partial interface ILocalStorage
    {
        /// <summary>
        /// Caches the Identity Id
        /// </summary>
        /// <param name="key"></param>
        /// <param name="identity"></param>
        [System.Security.SecuritySafeCritical]
        void CacheIdentity(string key, string identity);

        /// <summary>
        /// Gets the cached identity id
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [System.Security.SecuritySafeCritical]
        string GetIdentity(string key);


        /// <summary>
        /// Removes the Identity Id identified by the key from the cache
        /// </summary>
        /// <param name="key"></param>
        [System.Security.SecuritySafeCritical]
        void DeleteCachedIdentity(string key);
    }
}
