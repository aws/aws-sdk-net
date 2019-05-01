//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// SPDX-License-Identifier: Apache-2.0
//
using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CognitoSync.Model;
using Amazon.Util.Internal;

namespace Amazon.CognitoSync.SyncManager.Internal
{
    /// <summary>
    /// Remote data storage using Cognito Sync service on which we can invoke
    /// actions like creating a dataset or record.
    /// </summary>
    public partial class CognitoSyncStorage
    {
        #region GetDataset

        private delegate List<DatasetMetadata> PopulateDatasetMetadataDelegate(IAmazonCognitoSync client, ListDatasetsRequest request);
        private PopulateDatasetMetadataDelegate DatasetMetadataPopulator = delegate (IAmazonCognitoSync client, ListDatasetsRequest request)
        {
            var datasets = new List<DatasetMetadata>();
            string nextToken = null;
            do
            {
                request.NextToken = nextToken;
                ListDatasetsResponse response = client.ListDatasets(request);

                foreach (Amazon.CognitoSync.Model.Dataset dataset in response.Datasets)
                {
                    datasets.Add(ModelToDatasetMetadata(dataset));
                }
                nextToken = response.NextToken;
            } while (nextToken != null);
            return datasets;
        };

        private static ListDatasetsRequest PrepareListDatasetsRequest()
        {
            ListDatasetsRequest request = new ListDatasetsRequest();
            // a large enough number to reduce # of requests
            request.MaxResults = 64;
            return request;
        }

        /// <summary>
        /// Gets a list of <see cref="DatasetMetadata"/>
        /// </summary>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataStorageException"></exception>
        public List<DatasetMetadata> ListDatasetMetadata()
        {
            return DatasetMetadataPopulator.Invoke(client, PrepareListDatasetsRequest());
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasetMetadata operation.
        /// </summary>
        /// 
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBulkPublish
        ///         operation.</returns>
        public IAsyncResult BeginListDatasetMetadata(AsyncCallback callback, object state)
        {
            return DatasetMetadataPopulator.BeginInvoke(client, PrepareListDatasetsRequest(), callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the ListDatasetMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasetMetadata.</param>
        public List<DatasetMetadata> EndListDatasetMetadata(IAsyncResult asyncResult)
        {
            return DatasetMetadataPopulator.EndInvoke(asyncResult);
        }

        #endregion

        #region ListUpdates
        private ListRecordsRequest PrepareListRecordsRequest(string datasetName, long lastSyncCount)
        {
            ListRecordsRequest request = new ListRecordsRequest();
            request.IdentityPoolId = identityPoolId;
            request.IdentityId = this.GetCurrentIdentityId();
            request.DatasetName = datasetName;
            request.LastSyncCount = lastSyncCount;
            // mark it large enough to reduce # of requests
            request.MaxResults = 1024;
            return request;
        }

        private delegate DatasetUpdates PopulateUpdatesDelegate(IAmazonCognitoSync client, ListRecordsRequest request);
        private PopulateUpdatesDelegate UpdatesPopulator = delegate (IAmazonCognitoSync client, ListRecordsRequest request)
        {
            var records = new List<Record>();
            ListRecordsResponse response;
            string nextToken = null;
            do
            {
                request.NextToken = nextToken;
                response = client.ListRecords(request);
                foreach (Amazon.CognitoSync.Model.Record remoteRecord in response.Records)
                {
                    records.Add(ModelToRecord(remoteRecord));
                }
                // update last evaluated key
                nextToken = response.NextToken;
            } while (nextToken != null);

            return new DatasetUpdates(
                    request.DatasetName,
                    records,
                    response.DatasetSyncCount,
                    response.SyncSessionToken,
                    response.DatasetExists,
                    response.DatasetDeletedAfterRequestedSyncCount,
                    response.MergedDatasetNames
                );
        };

        /// <summary>
        /// Gets a list of records which have been updated since lastSyncCount
        /// (inclusive). If the value of a record equals null, then the record is
        /// deleted. If you pass 0 as lastSyncCount, the full list of records will be
        /// returned.
        /// </summary>
        /// <returns>A list of records which have been updated since lastSyncCount.</returns>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="lastSyncCount">Last sync count.</param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataStorageException"></exception>
        public DatasetUpdates ListUpdates(string datasetName, long lastSyncCount)
        {
            return UpdatesPopulator.Invoke(client, PrepareListRecordsRequest(datasetName, lastSyncCount));
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUpdates operation.
        /// </summary>
        /// 
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="lastSyncCount">Last sync count.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBulkPublish
        ///         operation.</returns>
        public IAsyncResult BeginListUpdates(string datasetName, long lastSyncCount, AsyncCallback callback, object state)
        {
            return UpdatesPopulator.BeginInvoke(client, PrepareListRecordsRequest(datasetName, lastSyncCount), callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUpdates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUpdates.</param>
        /// <returns>A list of records which have been updated since lastSyncCount.</returns>
        public DatasetUpdates EndListUpdates(IAsyncResult asyncResult)
        {
            return UpdatesPopulator.EndInvoke(asyncResult);
        }
        #endregion

        #region PutRecords
        private UpdateRecordsRequest PrepareUpdateRecordsRequest(string datasetName, List<Record> records, string syncSessionToken)
        {

            UpdateRecordsRequest request = new UpdateRecordsRequest();
            request.DatasetName = datasetName;
            request.IdentityPoolId = identityPoolId;
            request.IdentityId = this.GetCurrentIdentityId();
            request.SyncSessionToken = syncSessionToken;

            // create patches
            List<RecordPatch> patches = new List<RecordPatch>();
            foreach (Record record in records)
            {
                patches.Add(RecordToPatch(record));
            }
            request.RecordPatches = patches;
            return request;
        }

        private static List<Record> ExtractRecords(UpdateRecordsResponse response)
        {
            List<Record> updatedRecords = new List<Record>();
            foreach (Amazon.CognitoSync.Model.Record remoteRecord in response.Records)
            {
                updatedRecords.Add(ModelToRecord(remoteRecord));
            }
            return updatedRecords;
        }

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
        /// <exception cref="Amazon.CognitoSync.SyncManager.DatasetNotFoundException"></exception>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataConflictException"></exception>
        public List<Record> PutRecords(string datasetName, List<Record> records, string syncSessionToken)
        {
            UpdateRecordsResponse response = client.UpdateRecords(PrepareUpdateRecordsRequest(datasetName, records, syncSessionToken));
            return ExtractRecords(response);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRecords operation.
        /// </summary>
        /// 
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="records">Records.</param>
        /// <param name="syncSessionToken">Sync session token.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRecords
        ///         operation.</returns>
        public IAsyncResult BeginPutRecords(string datasetName, List<Record> records, string syncSessionToken, AsyncCallback callback, object state)
        {
            return client.BeginUpdateRecords(PrepareUpdateRecordsRequest(datasetName, records, syncSessionToken), callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the PutRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRecords.</param>
        public List<Record> EndPutRecords(IAsyncResult asyncResult)
        {
            try
            {
                UpdateRecordsResponse response = client.EndUpdateRecords(asyncResult);
                return ExtractRecords(response);
            }
            catch (Exception ex)
            {
                throw HandleException(ex, "Failed to update records in dataset");
            }
        }
        #endregion

        #region DeleteDataset
        private DeleteDatasetRequest PrepareDeleteDatasetRequest(string datasetName)
        {
            DeleteDatasetRequest request = new DeleteDatasetRequest();
            request.IdentityPoolId = identityPoolId;
            request.IdentityId = this.GetCurrentIdentityId();
            request.DatasetName = datasetName;
            return request;
        }

        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="datasetName">Dataset name.</param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DatasetNotFoundException"></exception>
        public void DeleteDataset(string datasetName)
        {
            client.DeleteDataset(PrepareDeleteDatasetRequest(datasetName));
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataset
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDataset(string datasetName, AsyncCallback callback, object state)
        {
            return client.BeginDeleteDataset(PrepareDeleteDatasetRequest(datasetName), callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        public void EndDeleteDataset(IAsyncResult asyncResult)
        {
            try
            {
                client.EndDeleteDataset(asyncResult);
            }
            catch (Exception ex)
            {
                throw HandleException(ex, "Failed to delete dataset");
            }
            client.EndDeleteDataset(asyncResult);
        }
        #endregion

        #region GetDatasetMetadata
        private DescribeDatasetRequest PrepareDescribeDatasetRequest(string datasetName)
        {
            DescribeDatasetRequest request = new DescribeDatasetRequest();
            request.IdentityPoolId = identityPoolId;
            request.IdentityId = this.GetCurrentIdentityId();
            request.DatasetName = datasetName;

            return request;
        }

        /// <summary>
        /// Retrieves the metadata of a dataset.
        /// </summary>
        /// <param name="datasetName">Dataset name.</param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataStorageException"></exception>
        public DatasetMetadata GetDatasetMetadata(string datasetName)
        {
            return ModelToDatasetMetadata(client.DescribeDataset(PrepareDescribeDatasetRequest(datasetName)).Dataset);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDatasetMetadata operation.
        /// </summary>
        /// 
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatasetMetadata
        ///         operation.</returns>
        public IAsyncResult BeginGetDatasetMetadata(string datasetName, AsyncCallback callback, object state)
        {
            return client.BeginDescribeDataset(PrepareDescribeDatasetRequest(datasetName), callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetDatasetMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDatasetMetadata.</param>
        public DatasetMetadata EndGetDatasetMetadata(IAsyncResult asyncResult)
        {
            try
            {
                return ModelToDatasetMetadata(client.EndDescribeDataset(asyncResult).Dataset);
            }
            catch (Exception ex)
            {
                throw new DataStorageException("Failed to get metadata of dataset", ex);
            }


        }
        #endregion
    }
}
