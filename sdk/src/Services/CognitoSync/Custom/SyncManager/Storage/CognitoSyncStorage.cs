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
#pragma warning disable 0649

using System;
using System.Collections.Generic;
using System.IO;

using Amazon.Runtime;
using Amazon.CognitoIdentity;
using Amazon.CognitoSync.Model;
using Amazon.Util.Internal;
using Amazon.CognitoSync.SyncManager;

namespace Amazon.CognitoSync.SyncManager.Internal
{
    public class CognitoSyncStorage : IRemoteDataStorage
    {
        private readonly string identityPoolId;
        private readonly AmazonCognitoSyncClient client;
        private readonly CognitoAWSCredentials cognitoCredentials;

        #region Constructor
        public CognitoSyncStorage(CognitoAWSCredentials cognitoCredentials, AmazonCognitoSyncConfig config)
        {
            if (cognitoCredentials == null)
            {
                throw new ArgumentNullException("cognitoCredentials");
            }
            this.identityPoolId = cognitoCredentials.IdentityPoolId;
            this.cognitoCredentials = cognitoCredentials;
            this.client = new AmazonCognitoSyncClient(cognitoCredentials, config);
        }

        #endregion

        #region GetDataset

        /// <summary>
        /// Gets a list of <see cref="DatasetMetadata"/>
        /// </summary>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. </param>
        /// <exception cref="DataStorageException"></exception>
        public List<DatasetMetadata> GetDatasetMetadata()
        {
            return PopulateGetDatasetMetadata(null, new List<DatasetMetadata>());
        }

        private List<DatasetMetadata> PopulateGetDatasetMetadata(string nextToken, List<DatasetMetadata> datasets)
        {
            ListDatasetsRequest request = new ListDatasetsRequest();
            // a large enough number to reduce # of requests
            request.MaxResults = 64;
            request.NextToken = nextToken;

            ListDatasetsResponse response = client.ListDatasets(request);
            foreach (Amazon.CognitoSync.Model.Dataset dataset in response.Datasets)
            {
                datasets.Add(ModelToDatasetMetadata(dataset));
            }
            nextToken = response.NextToken;

            if (nextToken != null)
            {
                PopulateGetDatasetMetadata(nextToken, datasets);
            }
            return datasets;
        }

        #endregion

        #region ListUpdates
        public DatasetUpdates ListUpdates(string datasetName, long lastSyncCount)
        {
            return PopulateListUpdates(datasetName, lastSyncCount, new List<Record>(), null);
        }

        private DatasetUpdates PopulateListUpdates(string datasetName, long lastSyncCount, List<Record> records, string nextToken)
        {
            ListRecordsRequest request = new ListRecordsRequest();
            request.IdentityPoolId = identityPoolId;
            request.IdentityId = this.GetCurrentIdentityId();
            request.DatasetName = datasetName;
            request.LastSyncCount = lastSyncCount;
            // mark it large enough to reduce # of requests
            request.MaxResults = 1024;
            request.NextToken = nextToken;

            ListRecordsResponse listRecordsResponse = client.ListRecords(request);
            foreach (Amazon.CognitoSync.Model.Record remoteRecord in listRecordsResponse.Records)
            {
                records.Add(this.ModelToRecord(remoteRecord));
            }
            // update last evaluated key
            nextToken = listRecordsResponse.NextToken;

            if (nextToken != null)
                PopulateListUpdates(datasetName, lastSyncCount, records, nextToken);


            DatasetUpdates updates = new DatasetUpdates(
                    datasetName,
                    records,
                    listRecordsResponse.DatasetSyncCount,
                    listRecordsResponse.SyncSessionToken,
                    listRecordsResponse.DatasetExists,
                    listRecordsResponse.DatasetDeletedAfterRequestedSyncCount,
                    listRecordsResponse.MergedDatasetNames
                );

            return updates;
        }

        #endregion

        #region PutRecords

        public List<Record> PutRecords(string datasetName, List<Record> records, string syncSessionToken)
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
                patches.Add(this.RecordToPatch(record));
            }
            request.RecordPatches = patches;
            List<Record> updatedRecords = new List<Record>();

            try
            {
                UpdateRecordsResponse updateRecordsResponse = client.UpdateRecords(request);
                foreach (Amazon.CognitoSync.Model.Record remoteRecord in updateRecordsResponse.Records)
                {
                    updatedRecords.Add(ModelToRecord(remoteRecord));
                }
                return updatedRecords;
            }
            catch (Exception ex)
            {
                throw HandleException(ex, "Failed to update records in dataset: " + datasetName);
            }
        }

        #endregion

        #region DeleteDataset


        public void DeleteDataset(string datasetName)
        {
            DeleteDatasetRequest request = new DeleteDatasetRequest();
            request.IdentityPoolId = identityPoolId;
            request.IdentityId = this.GetCurrentIdentityId();
            request.DatasetName = datasetName;

            try
            {
                client.DeleteDataset(request);
            }
            catch (Exception ex)
            {
                throw HandleException(ex, "Failed to delete dataset: " + datasetName);
            }
        }

        #endregion

        #region GetDatasetMetadata

        public DatasetMetadata GetDatasetMetadata(string datasetName)
        {
            DescribeDatasetRequest request = new DescribeDatasetRequest();
            request.IdentityPoolId = identityPoolId;
            request.IdentityId = this.GetCurrentIdentityId();
            request.DatasetName = datasetName;

            try
            {
                DescribeDatasetResponse describeDatasetResponse = client.DescribeDataset(request);
                return ModelToDatasetMetadata(describeDatasetResponse.Dataset);
            }
            catch (Exception ex)
            {
                throw new DataStorageException("Failed to get metadata of dataset: "
                                                                         + datasetName, ex);
            }
        }

        #endregion

        #region Private Methods

        private string GetCurrentIdentityId()
        {
            return cognitoCredentials.GetIdentityId();
        }

        private RecordPatch RecordToPatch(Record record)
        {
            RecordPatch patch = new RecordPatch();
            patch.Key = record.Key;
            patch.Value = record.Value;
            patch.SyncCount = record.SyncCount;
            patch.Op = (record.Value == null ? Operation.Remove : Operation.Replace);
            return patch;
        }

        private DatasetMetadata ModelToDatasetMetadata(Amazon.CognitoSync.Model.Dataset model)
        {
            return new DatasetMetadata(
                model.DatasetName,
                model.CreationDate,
                model.LastModifiedDate,
                model.LastModifiedBy,
                model.DataStorage,
                model.NumRecords
                );
        }

        private Record ModelToRecord(Amazon.CognitoSync.Model.Record model)
        {
            return new Record(
                model.Key,
                model.Value,
                model.SyncCount,
                model.LastModifiedDate,
                model.LastModifiedBy,
                model.DeviceLastModifiedDate,
                false);
        }

        private SyncManagerException HandleException(Exception e, string message)
        {
            var ase = e as AmazonServiceException;

            if (ase == null) ase = new AmazonServiceException(e);

            if (ase.GetType() == typeof(ResourceNotFoundException))
            {
                return new DatasetNotFoundException(message);
            }
            else if (ase.GetType() == typeof(ResourceConflictException)
                     || ase.StatusCode == System.Net.HttpStatusCode.Conflict)
            {
                return new DataConflictException(message);
            }
            else if (ase.GetType() == typeof(LimitExceededException))
            {
                return new DataLimitExceededException(message);
            }
            else if (IsNetworkException(ase))
            {
                return new NetworkException(message);
            }
            else
            {
                return new DataStorageException(message, ase);
            }
        }

        private static bool IsNetworkException(AmazonServiceException ase)
        {
            return ase.InnerException != null && ase.InnerException.GetType() == typeof(IOException);
        }

        #endregion
    }
}

