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
using System.IO;

using Amazon.Runtime;
using Amazon.CognitoIdentity;
using Amazon.CognitoSync;
using Amazon.CognitoSync.Model;
using Amazon.Util.Internal;
using Amazon.CognitoSync.SyncManager;
#if BCL45 || PCL
using System.Threading.Tasks;
#endif
using System.Threading;

namespace Amazon.CognitoSync.SyncManager.Internal
{
    /// <summary>
    /// An <see cref="Amazon.CognitoSync.SyncManager.IRemoteDataStorage"/> implementation 
    /// using Cognito Sync service on which we can invoke actions like creating a dataset, or record
    /// </summary>
    public class CognitoSyncStorage : IRemoteDataStorage, IDisposable
    {
        private readonly string identityPoolId;
        private readonly AmazonCognitoSyncClient client;
        private readonly CognitoAWSCredentials cognitoCredentials;

        #region Dispose

        /// <summary>
        /// Dispose this Object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose this Object
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (client != null)
                    client.Dispose();
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Creates an insance of IRemoteStorage Interface. 
        /// </summary>
        /// <param name="cognitoCredentials"><see cref="Amazon.CognitoIdentity.CognitoAWSCredentials"/></param>
        /// <param name="config"><see cref="Amazon.CognitoSync.AmazonCognitoSyncConfig"/></param>
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

        //TODO add BCL35
#if BCL35
        /// <summary>
        /// Gets a list of <see cref="DatasetMetadata"/>. Temporary Placeholder.
        /// </summary>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataStorageException"></exception>
        public void GetDatasetMetadataAsync() { }
#endif
#if UNITY
        #region GetDataset
        /// <summary>
        /// Gets a list of <see cref="DatasetMetadata"/>
        /// </summary>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. </param>
        /// <exception cref="DataStorageException"></exception>
        public void GetDatasetMetadataAsync(AmazonCognitoSyncCallback<List<DatasetMetadata>> callback, AsyncOptions options = null)
        {
            options = options ?? new AsyncOptions();
            PopulateGetDatasetMetadataAsync(null, new List<DatasetMetadata>(), callback, options);
        }

        private void PopulateGetDatasetMetadataAsync(string nextToken, List<DatasetMetadata> datasets, AmazonCognitoSyncCallback<List<DatasetMetadata>> callback, AsyncOptions options)
        {

            ListDatasetsRequest request = new ListDatasetsRequest();
            // a large enough number to reduce # of requests
            request.MaxResults = 64;
            request.NextToken = nextToken;

            client.ListDatasetsAsync(request, (responseObj) =>
            {
                Exception ex = responseObj.Exception;
                ListDatasetsResponse response = responseObj.Response;
                object obj = responseObj.state;
                if (ex != null)
                {
                    InternalSDKUtils.AsyncExecutor(() => callback(new AmazonCognitoSyncResult<List<DatasetMetadata>>(null, ex, obj)), options);
                }
                else
                {
                    foreach (Amazon.CognitoSync.Model.Dataset dataset in response.Datasets)
                    {
                        datasets.Add(ModelToDatasetMetadata(dataset));
                    }

                    nextToken = response.NextToken;

                    if (nextToken == null)
                    {
                        InternalSDKUtils.AsyncExecutor(() => callback(new AmazonCognitoSyncResult<List<DatasetMetadata>>(datasets, null, obj)), options);
                        return;
                    }
                    PopulateGetDatasetMetadataAsync(nextToken, datasets, callback, options);
                }
            },
            options);
        }
        #endregion

        #region ListUpdates


        public void ListUpdatesAsync(string datasetName, long lastSyncCount, AmazonCognitoSyncCallback<DatasetUpdates> callback, AsyncOptions options = null)
        {
            options = options ?? new AsyncOptions();
            PopulateListUpdatesAsync(datasetName, lastSyncCount, new List<Record>(), null, callback, options);
        }

        private void PopulateListUpdatesAsync(string datasetName, long lastSyncCount, List<Record> records, string nextToken, AmazonCognitoSyncCallback<DatasetUpdates> callback, AsyncOptions options)
        {
            ListRecordsRequest request = new ListRecordsRequest();
            request.IdentityPoolId = identityPoolId;
            request.IdentityId = this.GetCurrentIdentityId();
            request.DatasetName = datasetName;
            request.LastSyncCount = lastSyncCount;
            // mark it large enough to reduce # of requests
            request.MaxResults = 1024;
            request.NextToken = nextToken;

            client.ListRecordsAsync(request, (responseObj) =>
            {
                ListRecordsResponse res = responseObj.Response;
                Exception ex = responseObj.Exception;
                object obj = responseObj.state;

                if (ex != null)
                {
                    InternalSDKUtils.AsyncExecutor(() => callback(new AmazonCognitoSyncResult<DatasetUpdates>(null, ex, obj)), options); ;
                }
                else
                {
                    ListRecordsResponse listRecordsResponse = res;
                    foreach (Amazon.CognitoSync.Model.Record remoteRecord in listRecordsResponse.Records)
                    {
                        //builder.addRecord(modelToRecord(remoteRecord));
                        records.Add(ModelToRecord(remoteRecord));
                    }
                    if (listRecordsResponse.NextToken == null)
                    {
                        DatasetUpdates updates = new DatasetUpdates(
                            datasetName,
                            records,
                            listRecordsResponse.DatasetSyncCount,
                            listRecordsResponse.SyncSessionToken,
                            listRecordsResponse.DatasetExists,
                            listRecordsResponse.DatasetDeletedAfterRequestedSyncCount,
                            listRecordsResponse.MergedDatasetNames
                        );

                        InternalSDKUtils.AsyncExecutor(() => callback(new AmazonCognitoSyncResult<DatasetUpdates>(updates, ex, obj)), options);

                        return;
                    }
                    // update last evaluated key
                    nextToken = listRecordsResponse.NextToken;

                    // emulating the while loop
                    PopulateListUpdatesAsync(datasetName, lastSyncCount, records, nextToken, callback, new AsyncOptions() { ExecuteCallbackOnMainThread = false, State = obj });
                }
            },
            options);

        }

        #endregion


        #region PutRecords


        public void PutRecordsAsync(string datasetName, List<Record> records, string syncSessionToken, AmazonCognitoSyncCallback<List<Record>> callback, AsyncOptions options = null)
        {
            options = options ?? new AsyncOptions();
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

            client.UpdateRecordsAsync(request, (responseObj) =>
            {
                Exception ex = responseObj.Exception;
                UpdateRecordsResponse updateRecordsResponse = responseObj.Response;
                Exception putRecordsException = null;
                object obj = responseObj.state;
                if (ex != null)
                {
                    putRecordsException = HandleException(ex, "Failed to update records in dataset: " + datasetName);
                }
                else
                {
                    foreach (Amazon.CognitoSync.Model.Record remoteRecord in updateRecordsResponse.Records)
                    {
                        updatedRecords.Add(ModelToRecord(remoteRecord));
                    }
                }

                InternalSDKUtils.AsyncExecutor(() => callback(new AmazonCognitoSyncResult<List<Record>>(updatedRecords, putRecordsException, obj)), options);

            },
            options);
        }

        #endregion


        #region DeleteDataset


        public void DeleteDatasetAsync(string datasetName, AmazonCognitoSyncCallback callback, AsyncOptions options = null)
        {
            options = options ?? new AsyncOptions();

            DeleteDatasetRequest request = new DeleteDatasetRequest();
            request.IdentityPoolId = identityPoolId;
            request.IdentityId = this.GetCurrentIdentityId();
            request.DatasetName = datasetName;

            client.DeleteDatasetAsync(request, (responseObj) =>
            {
                if (responseObj.Exception != null)
                {
                    InternalSDKUtils.AsyncExecutor(() => callback(new AmazonCognitoSyncResult(HandleException(responseObj.Exception, "Failed to delete dataset: " + datasetName), responseObj.state)), options);
                }
                else
                {
                    InternalSDKUtils.AsyncExecutor(() => callback(new AmazonCognitoSyncResult(null, responseObj.state)), options);
                }
            },
            options);
        }

        #endregion


        #region GetDatasetMetadata

        public void GetDatasetMetadataAsync(string datasetName, AmazonCognitoSyncCallback<DatasetMetadata> callback, AsyncOptions options = null)
        {
            options = options ?? new AsyncOptions();

            DescribeDatasetRequest request = new DescribeDatasetRequest();
            request.IdentityPoolId = identityPoolId;
            request.IdentityId = this.GetCurrentIdentityId();
            request.DatasetName = datasetName;

            client.DescribeDatasetAsync(request, (responseObj) =>
            {
                Exception dataStorageException = null;
                DatasetMetadata metadata = null;
                if (responseObj.Exception != null)
                {
                    dataStorageException = new DataStorageException("Failed to get metadata of dataset: "
                                                                        + datasetName, responseObj.Exception);
                }
                else
                {
                    metadata = ModelToDatasetMetadata(responseObj.Response.Dataset);
                }

                InternalSDKUtils.AsyncExecutor(() => callback(new AmazonCognitoSyncResult<DatasetMetadata>(metadata, dataStorageException, responseObj.state)), options);
            },
            options);
        }

        #endregion

#elif BCL45 || PCL
        #region GetDataset
        /// <summary>
        /// Gets a list of <see cref="DatasetMetadata"/>
        /// </summary>
        /// <param name="cancellationToken">
        ///  A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <exception cref="Amazon.CognitoSync.SyncManager.DataStorageException"></exception>
        public async Task<List<DatasetMetadata>> GetDatasetMetadataAsync(CancellationToken cancellationToken)
        {
            return await PopulateGetDatasetMetadata(null, new List<DatasetMetadata>(), cancellationToken).ConfigureAwait(false);
        }

        private async Task<List<DatasetMetadata>> PopulateGetDatasetMetadata(string nextToken, List<DatasetMetadata> datasets, CancellationToken cancellationToken)
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
                await PopulateGetDatasetMetadata(nextToken, datasets, cancellationToken).ConfigureAwait(false);
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
#endif

        #region Private Methods

        private string GetCurrentIdentityId()
        {
            return cognitoCredentials.GetIdentityId();
        }

        private static RecordPatch RecordToPatch(Record record)
        {
            RecordPatch patch = new RecordPatch();
            patch.DeviceLastModifiedDate = record.DeviceLastModifiedDate.Value;
            patch.Key = record.Key;
            patch.Value = record.Value;
            patch.SyncCount = record.SyncCount;
            patch.Op = (record.Value == null ? Operation.Remove : Operation.Replace);
            return patch;
        }

        private static DatasetMetadata ModelToDatasetMetadata(Amazon.CognitoSync.Model.Dataset model)
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

        private static Record ModelToRecord(Amazon.CognitoSync.Model.Record model)
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

        private static SyncManagerException HandleException(Exception e, string message)
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

