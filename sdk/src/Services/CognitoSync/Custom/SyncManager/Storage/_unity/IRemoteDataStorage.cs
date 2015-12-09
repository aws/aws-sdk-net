//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

using Amazon.Runtime;
using System.Collections.Generic;

namespace Amazon.CognitoSync.SyncManager
{
    /// <summary>
    /// A remote storage like a cognito sync service on which we can invoke actions like creating a dataset, or record
    /// </summary>
    public interface IRemoteDataStorage
    {
        #region GetDatasets
        /// <summary>
        /// Gets a list of <see cref="DatasetMetadata"/>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. 
        /// 	Retrieve this object from within the callback
        /// 	procedure using the AsyncState property.</param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataStorageException"></exception>
        void GetDatasetMetadataAsync(AmazonCognitoSyncCallback<List<DatasetMetadata>> callback, AsyncOptions options = null);
        #endregion


        #region GetDatasetMetadata
        /// <summary>
        /// Retrieves the metadata of a dataset.
        /// </summary>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="callback">An Action delegate that is invoked when 
        /// 	the operation completes with AmazonServiceResult result</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. 
        /// 	Retrieve this object from within the callback
        /// 	procedure using the AsyncState property.</param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataStorageException"></exception>
        void GetDatasetMetadataAsync(string datasetName, AmazonCognitoSyncCallback<DatasetMetadata> callback, AsyncOptions options = null);
        #endregion


        #region ListUpdate
        /// <summary>
        /// Gets a list of records which have been updated since lastSyncCount
        /// (inclusive). If the value of a record equals null, then the record is
        /// deleted. If you pass 0 as lastSyncCount, the full list of records will be
        /// returned.
        /// </summary>
        /// <returns>A list of records which have been updated since lastSyncCount.</returns>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when 
        /// 	the operation completes with AmazonServiceResult result</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. 
        /// 	Retrieve this object from within the callback
        /// 	procedure using the AsyncState property.</param>
        /// <param name="lastSyncCount">Last sync count.</param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataStorageException"></exception>
        void ListUpdatesAsync(string datasetName, long lastSyncCount, AmazonCognitoSyncCallback<DatasetUpdates> callback, AsyncOptions options = null);
        #endregion


        #region PutRecords
        /// <summary>
        /// Post updates to remote storage. Each record has a sync count. If the sync
        /// count doesn't match what's on the remote storage, i.e. the record is
        /// modified by a different device, this operation throws ConflictException.
        /// Otherwise it returns a list of records that are updated successfully.
        /// </summary>
        /// <returns>The records.</returns>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="records">Records.</param>
        /// <param name="syncSessionToken">Sync session token.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when 
        /// 	the operation completes with AmazonServiceResult result</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. 
        /// 	Retrieve this object from within the callback
        /// 	procedure using the AsyncState property.</param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DatasetNotFoundException"></exception>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataConflictException"></exception>
        void PutRecordsAsync(string datasetName, List<Record> records, string syncSessionToken, AmazonCognitoSyncCallback<List<Record>> callback, AsyncOptions options = null);
        #endregion


        #region DeleteDataset
        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when 
        /// 	the operation completes with AmazonServiceResult result</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. 
        /// 	Retrieve this object from within the callback
        /// 	procedure using the AsyncState property.</param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DatasetNotFoundException"></exception>
        void DeleteDatasetAsync(string datasetName, AmazonCognitoSyncCallback callback, AsyncOptions options = null);
        #endregion
    }
}
