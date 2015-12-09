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

using System;
using System.Collections.Generic;

namespace Amazon.CognitoSync.SyncManager
{
    /// <summary>
    /// A remote storage like a cognito sync service on which we can invoke actions like creating a dataset, or record
    /// </summary>
    public interface IRemoteDataStorage
    {
        #region GetDataset
        //TODO: document
        List<DatasetMetadata> GetAllDatasetMetadata();

        //TODO: document
        IAsyncResult BeginGetAllDatasetMetadata(AsyncCallback callback, object state);

        //TODO: document
        List<DatasetMetadata> EndGetAllDatasetMetadata(IAsyncResult asyncResult);
        #endregion

        #region ListUpdates
        //TODO: document
        DatasetUpdates ListUpdates(string datasetName, long lastSyncCount);

        //TODO: document
        IAsyncResult BeginListUpdates(string datasetName, long lastSyncCount, AsyncCallback callback, object state);

        //TODO: document
        DatasetUpdates EndListUpdates(IAsyncResult asyncResult);
        #endregion

        #region PutRecords
        //TODO: document
        List<Record> PutRecords(string datasetName, List<Record> records, string syncSessionToken);

        //TODO: document
        IAsyncResult BeginPutRecords(string datasetName, List<Record> records, string syncSessionToken, AsyncCallback callback, object state);

        //TODO: document
        List<Record> EndPutRecords(IAsyncResult asyncResult);
        #endregion

        #region DeleteDataset
        //TODO: document
        void DeleteDataset(string datasetName);

        //TODO: document
        IAsyncResult BeginDeleteDataset(string datasetName, AsyncCallback callback, object state);

        //TODO: document
        void EndDeleteDataset(IAsyncResult asyncResult);
        #endregion

        #region GetDatasetMetadata
        //TODO: document
        DatasetMetadata GetDatasetMetadata(string datasetName);

        //TODO: document
        IAsyncResult BeginGetDatasetMetadata(string datasetName, AsyncCallback callback, object state);

        //TODO: document
        DatasetMetadata EndGetDatasetMetadata(IAsyncResult asyncResult);
        #endregion
    }
}

