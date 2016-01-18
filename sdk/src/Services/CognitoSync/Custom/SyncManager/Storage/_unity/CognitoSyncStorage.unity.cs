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
    public partial class CognitoSyncStorage: IDisposable
    {
        #region ListDataset

        /// <summary>
        /// Gets a list of <see cref="DatasetMetadata"/>
        /// </summary>
        public List<DatasetMetadata> ListDatasetMetadata()
        {
            return PopulateListDatasetMetadata(null, new List<DatasetMetadata>());
        }

        private List<DatasetMetadata> PopulateListDatasetMetadata(string nextToken, List<DatasetMetadata> datasets)
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

                PopulateListDatasetMetadata(nextToken, datasets);
            }

            return datasets;
        }
        #endregion

        #region ListUpdates


        /// <summary>
        /// Gets a list of records which have been updated since lastSyncCount
        /// (inclusive). If the value of a record equals null, then the record is
        /// deleted. If you pass 0 as lastSyncCount, the full list of records will be
        /// returned.
        /// </summary>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="lastSyncCount">Last sync count.</param>
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
                records.Add(ModelToRecord(remoteRecord));
            }
            if (listRecordsResponse.NextToken != null)
            {
                // update last evaluated key
                nextToken = listRecordsResponse.NextToken;
                PopulateListUpdates(datasetName, lastSyncCount, records, nextToken);
            }


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
        /// <summary>
        /// Post updates to remote storage. Each record has a sync count. If the sync
        /// count doesn't match what's on the remote storage, i.e. the record is
        /// modified by a different device, this operation sets the exception in the 
        /// callback response to ConflictException. Otherwise it returns a list of 
        /// records that are updated successfully.
        /// </summary>
        /// <returns>The records.</returns>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="records">Records.</param>
        public List<Record> PutRecords(string datasetName, List<Record> records, string syncSessionToken)
        {
            UpdateRecordsRequest request = new UpdateRecordsRequest();
            request.DatasetName = datasetName;
            request.IdentityPoolId = identityPoolId;
            request.IdentityId = this.GetCurrentIdentityId();
            request.SyncSessionToken = syncSessionToken;
            List<Record> updatedRecords = new List<Record>();

            // create patches
            List<RecordPatch> patches = new List<RecordPatch>();
            foreach (Record record in records)
            {
                patches.Add(RecordToPatch(record));
            }
            request.RecordPatches = patches;

            try
            {
                UpdateRecordsResponse updateRecordsResponse = client.UpdateRecords(request);

                foreach (Amazon.CognitoSync.Model.Record remoteRecord in updateRecordsResponse.Records)
                {
                    updatedRecords.Add(ModelToRecord(remoteRecord));
                }
            }
            catch (Exception e)
            {
                throw HandleException(e, "Failed to update records in dataset: " + datasetName);
            }
            
            return updatedRecords;
        }
        #endregion

        #region DeleteDataset
        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <returns>The records.</returns>
        /// <param name="datasetName">Dataset name.</param>
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
            catch (Exception e)
            {
                throw HandleException(e, "Failed to delete dataset: " + datasetName);
            }
        }
        #endregion

        #region GetDatasetMetadata
        /// <summary>
        /// Retrieves the metadata of a dataset.
        /// </summary>
        /// <returns>The records.</returns>
        /// <param name="datasetName">Dataset name.</param>
        public DatasetMetadata GetDatasetMetadata(string datasetName)
        {

            DescribeDatasetRequest request = new DescribeDatasetRequest();
            request.IdentityPoolId = identityPoolId;
            request.IdentityId = this.GetCurrentIdentityId();
            request.DatasetName = datasetName;
            DatasetMetadata metadata = null;

            try
            {
                var describeResponse = client.DescribeDataset(request);
                metadata = ModelToDatasetMetadata(describeResponse.Dataset);
            }
            catch (Exception e)
            {
                throw new DataStorageException("Failed to get metadata of dataset: "
                                                                        + datasetName, e);
            }

            return metadata;
        }

        #endregion

    }
}
