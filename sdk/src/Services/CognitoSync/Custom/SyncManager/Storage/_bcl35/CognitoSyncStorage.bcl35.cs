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

using Amazon.Runtime;
using Amazon.CognitoSync.Model;
using Amazon.Util.Internal;

namespace Amazon.CognitoSync.SyncManager.Internal
{
    public partial class CognitoSyncStorage : IRemoteDataStorage, IDisposable
    {
        #region GetDataset

        private delegate List<DatasetMetadata> PopulateDatasetMetadataDelegate(AmazonCognitoSyncClient client, ListDatasetsRequest request);
        private PopulateDatasetMetadataDelegate DatasetMetadataPopulator = delegate(AmazonCognitoSyncClient client, ListDatasetsRequest request)
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
        private ListDatasetsRequest PrepareListDatasetsRequest()
        {
            ListDatasetsRequest request = new ListDatasetsRequest();
            // a large enough number to reduce # of requests
            request.MaxResults = 64;
            return request;
        }

        //TODO: document
        public List<DatasetMetadata> GetAllDatasetMetadata()
        {
            return DatasetMetadataPopulator.Invoke(client, PrepareListDatasetsRequest());
        }

        //TODO: document
        public IAsyncResult BeginGetAllDatasetMetadata(AsyncCallback callback, object state)
        {
            return DatasetMetadataPopulator.BeginInvoke(client, PrepareListDatasetsRequest(), callback, state);
        }

        //TODO: document
        //TODO: A better name would be good. Or a way to differentiate between EndGetAllDatasetMetadata and EndGetDatasetMetadata besides naming the differently.
        public List<DatasetMetadata> EndGetAllDatasetMetadata(IAsyncResult asyncResult)
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
        private delegate DatasetUpdates PopulateUpdatesDelegate(AmazonCognitoSyncClient client, ListRecordsRequest request);
        private PopulateUpdatesDelegate UpdatesPopulator = delegate(AmazonCognitoSyncClient client, ListRecordsRequest request)
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

        //TODO: document
        public DatasetUpdates ListUpdates(string datasetName, long lastSyncCount)
        {
            return UpdatesPopulator.Invoke(client, PrepareListRecordsRequest(datasetName, lastSyncCount));
        }

        //TODO: document
        public IAsyncResult BeginListUpdates(string datasetName, long lastSyncCount, AsyncCallback callback, object state)
        {
            return UpdatesPopulator.BeginInvoke(client, PrepareListRecordsRequest(datasetName, lastSyncCount), callback, state);
        }

        //TODO: document
        public DatasetUpdates EndListUpdates(IAsyncResult asyncResult)
        {
            return UpdatesPopulator.EndInvoke(asyncResult);
        }
        #endregion

        #region PutRecords
        //TODO: document
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

        private List<Record> ExtractRecords(UpdateRecordsResponse response)
        {
            List<Record> updatedRecords = new List<Record>();
            foreach (Amazon.CognitoSync.Model.Record remoteRecord in response.Records)
            {
                updatedRecords.Add(ModelToRecord(remoteRecord));
            }
            return updatedRecords;
        }

        public List<Record> PutRecords(string datasetName, List<Record> records, string syncSessionToken)
        {
            UpdateRecordsResponse response = client.UpdateRecords(PrepareUpdateRecordsRequest(datasetName, records, syncSessionToken));
            return ExtractRecords(response);
        }


        //TODO: document
        public IAsyncResult BeginPutRecords(string datasetName, List<Record> records, string syncSessionToken, AsyncCallback callback, object state)
        {
            return client.BeginUpdateRecords(PrepareUpdateRecordsRequest(datasetName, records, syncSessionToken), callback, state);
        }

        //TODO: document
        public List<Record> EndPutRecords(IAsyncResult asyncResult)
        {
            //TODO: do we need to do something like try{...}catch (Exception ex) {throw new DataStorageException("Failed to get metadata of dataset: "+ datasetName, ex);}??
            UpdateRecordsResponse response = client.EndUpdateRecords(asyncResult);
            return ExtractRecords(response);
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

        //TODO: document
        public void DeleteDataset(string datasetName)
        {
            client.DeleteDataset(PrepareDeleteDatasetRequest(datasetName));
        }

        //TODO: document
        public IAsyncResult BeginDeleteDataset(string datasetName, AsyncCallback callback, object state)
        {
            return client.BeginDeleteDataset(PrepareDeleteDatasetRequest(datasetName), callback, state);
        }

        //TODO: document
        public void EndDeleteDataset(IAsyncResult asyncResult)
        {
            //TODO: do we need to do something like try{...}catch (Exception ex) {throw new DataStorageException("Failed to get metadata of dataset: "+ datasetName, ex);}??
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

        //TODO: document
        public DatasetMetadata GetDatasetMetadata(string datasetName)
        {
            return ModelToDatasetMetadata(client.DescribeDataset(PrepareDescribeDatasetRequest(datasetName)).Dataset);
        }

        //TODO: document
        public IAsyncResult BeginGetDatasetMetadata(string datasetName, AsyncCallback callback, object state)
        {
            return client.BeginDescribeDataset(PrepareDescribeDatasetRequest(datasetName), callback, state);
        }

        //TODO: document
        public DatasetMetadata EndGetDatasetMetadata(IAsyncResult asyncResult)
        {
            //TODO: do we need to do something like try{...}catch (Exception ex) {throw new DataStorageException("Failed to get metadata of dataset: "+ datasetName, ex);}??
            return ModelToDatasetMetadata(client.EndDescribeDataset(asyncResult).Dataset);
        }
        #endregion
    }
}