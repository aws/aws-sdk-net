using Amazon.CognitoSync.SyncManager.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.CognitoSync.SyncManager
{
    public partial class CognitoSyncManager
    {
        private delegate List<DatasetMetadata> RefreshDatasetMetadataInnerDelegate(CognitoSyncStorage remote, ILocalStorage local, string identityId);
        private RefreshDatasetMetadataInnerDelegate RefreshDatasetMetadataInnerHandler = delegate (CognitoSyncStorage remote, ILocalStorage local, string identityId)
        {
            List<DatasetMetadata> response = remote.ListDatasetMetadata();
            local.UpdateDatasetMetadata(identityId, response);
            return response;
        };
        /// <summary>
        /// Initiates the asynchronous execution of the RefreshDatasetMetadata operation.
        /// 
        /// Refreshes dataset metadata. Dataset metadata is pulled from remote
        /// storage and stored in local storage. Their record data isn't pulled down
        /// until you sync each dataset.
        /// </summary>
        /// 
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRefreshDatasetMetadata(AsyncCallback callback, object state)
        {
            return RefreshDatasetMetadataInnerHandler.BeginInvoke(Remote, Local, IdentityId, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the RefreshDatasetMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRefreshDatasetMetadata.</param>
        public List<DatasetMetadata> EndRefreshDatasetMetadata(IAsyncResult asyncResult)
        {
            return RefreshDatasetMetadataInnerHandler.EndInvoke(asyncResult);
        }
    }
}
