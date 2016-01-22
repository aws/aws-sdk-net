using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

using Amazon.CognitoSync.Model;

namespace Amazon.CognitoSync.SyncManager.Internal
{
    /// <summary>
    /// Remote data storage using Cognito Sync service on which we can invoke
    /// actions like creating a dataset or record.
    /// </summary>
    public partial class CognitoSyncStorage : IDisposable
    {
        #region ListDataset

        /// <summary>
        /// Gets a list of <see cref="DatasetMetadata"/>
        /// </summary>
        /// <param name="cancellationToken">
        ///  A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataStorageException"></exception>
        public async Task<List<DatasetMetadata>> ListDatasetMetadataAsync(CancellationToken cancellationToken)
        {
            return await PopulateListDatasetMetadata(null, new List<DatasetMetadata>(), cancellationToken).ConfigureAwait(false);
        }

        private async Task<List<DatasetMetadata>> PopulateListDatasetMetadata(string nextToken, List<DatasetMetadata> datasets, CancellationToken cancellationToken)
        {
            ListDatasetsRequest request = new ListDatasetsRequest();
            // a large enough number to reduce # of requests
            request.MaxResults = 64;
            request.NextToken = nextToken;

            ListDatasetsResponse response = await client.ListDatasetsAsync(request, cancellationToken).ConfigureAwait(false);

            foreach (Amazon.CognitoSync.Model.Dataset dataset in response.Datasets)
            {
                datasets.Add(ModelToDatasetMetadata(dataset));
            }
            nextToken = response.NextToken;

            if (nextToken != null)
            {
                await PopulateListDatasetMetadata(nextToken, datasets, cancellationToken).ConfigureAwait(false);
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
        /// <returns>A list of records which have been updated since lastSyncCount.</returns>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="lastSyncCount">Last sync count.</param>
        /// <param name="cancellationToken">
        ///  A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataStorageException"></exception>
        public async Task<DatasetUpdates> ListUpdatesAsync(string datasetName, long lastSyncCount, CancellationToken cancellationToken)
        {
            return await PopulateListUpdatesAsync(datasetName, lastSyncCount, new List<Record>(), null, cancellationToken).ConfigureAwait(false);
        }

        private async Task<DatasetUpdates> PopulateListUpdatesAsync(string datasetName, long lastSyncCount, List<Record> records, string nextToken, CancellationToken cancellationToken)
        {
            ListRecordsRequest request = new ListRecordsRequest();
            request.IdentityPoolId = identityPoolId;
            request.IdentityId = this.GetCurrentIdentityId();
            request.DatasetName = datasetName;
            request.LastSyncCount = lastSyncCount;
            // mark it large enough to reduce # of requests
            request.MaxResults = 1024;
            request.NextToken = nextToken;

            ListRecordsResponse listRecordsResponse = await client.ListRecordsAsync(request, cancellationToken).ConfigureAwait(false);
            foreach (Amazon.CognitoSync.Model.Record remoteRecord in listRecordsResponse.Records)
            {
                records.Add(ModelToRecord(remoteRecord));
            }
            // update last evaluated key
            nextToken = listRecordsResponse.NextToken;

            if (nextToken != null)
                await PopulateListUpdatesAsync(datasetName, lastSyncCount, records, nextToken, cancellationToken).ConfigureAwait(false);


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
        /// modified by a different device, this operation throws ConflictException.
        /// Otherwise it returns a list of records that are updated successfully.
        /// </summary>
        /// <returns>The records.</returns>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="records">Records.</param>
        /// <param name="syncSessionToken">Sync session token.</param>
        /// <param name="cancellationToken">
        ///  A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DatasetNotFoundException"></exception>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataConflictException"></exception>
        public async Task<List<Record>> PutRecordsAsync(string datasetName, List<Record> records, string syncSessionToken, CancellationToken cancellationToken)
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
            List<Record> updatedRecords = new List<Record>();

            try
            {
                UpdateRecordsResponse updateRecordsResponse = await client.UpdateRecordsAsync(request, cancellationToken).ConfigureAwait(false);
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

        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="cancellationToken">
        ///  A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DatasetNotFoundException"></exception>
        public async Task DeleteDatasetAsync(string datasetName, CancellationToken cancellationToken)
        {
            DeleteDatasetRequest request = new DeleteDatasetRequest();
            request.IdentityPoolId = identityPoolId;
            request.IdentityId = this.GetCurrentIdentityId();
            request.DatasetName = datasetName;

            try
            {
                await client.DeleteDatasetAsync(request, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw HandleException(ex, "Failed to delete dataset: " + datasetName);
            }
        }

        #endregion

        #region GetDatasetMetadata
        /// <summary>
        /// Retrieves the metadata of a dataset.
        /// </summary>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="cancellationToken">
        ///  A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataStorageException"></exception>
        public async Task<DatasetMetadata> GetDatasetMetadataAsync(string datasetName, CancellationToken cancellationToken)
        {
            DescribeDatasetRequest request = new DescribeDatasetRequest();
            request.IdentityPoolId = identityPoolId;
            request.IdentityId = this.GetCurrentIdentityId();
            request.DatasetName = datasetName;

            try
            {
                DescribeDatasetResponse describeDatasetResponse = await client.DescribeDatasetAsync(request, cancellationToken).ConfigureAwait(false);
                return ModelToDatasetMetadata(describeDatasetResponse.Dataset);
            }
            catch (Exception ex)
            {
                throw new DataStorageException("Failed to get metadata of dataset: "
                                                                         + datasetName, ex);
            }
        }
        #endregion
    }
}
