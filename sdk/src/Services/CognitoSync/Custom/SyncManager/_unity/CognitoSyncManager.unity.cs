using Amazon.Runtime;
using Amazon.Util.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Amazon.CognitoSync.SyncManager
{
    public partial class CognitoSyncManager
    {
        /// <summary>
        /// Refreshes dataset metadata. Dataset metadata is pulled from remote
        /// storage and stored in local storage. Their record data isn't pulled down
        /// until you sync each dataset.
        /// </summary>
        /// <param name="callback">Callback once the refresh is complete</param>
        /// <param name="options">Options for asynchronous execution</param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataStorageException">Thrown when fail to fresh dataset metadata</exception>
        public void RefreshDatasetMetadataAsync(AmazonCognitoSyncCallback<List<DatasetMetadata>> callback, AsyncOptions options = null)
        {
            options = options ?? new AsyncOptions();
            AmazonCognitoSyncResult<List<DatasetMetadata>> cognitoResult = new AmazonCognitoSyncResult<List<DatasetMetadata>>(options.State);
            
            InternalSDKUtils.AsyncExecutor(() =>
            {
                try
                {
                    var response = Remote.ListDatasetMetadata();
                    Local.UpdateDatasetMetadata(IdentityId, response);
                    cognitoResult.Response = response;
                }
                catch (Exception e)
                {
                    cognitoResult.Exception = e;
                }
                callback(cognitoResult);
            }, options);
        }
    }
}
