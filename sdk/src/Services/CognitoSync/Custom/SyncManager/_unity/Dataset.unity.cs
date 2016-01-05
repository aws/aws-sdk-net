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
using Amazon.Runtime.Internal.Util;
using Amazon.Util.Internal.PlatformServices;
using System;
using System.Collections.Generic;
using System.Threading;


namespace Amazon.CognitoSync.SyncManager
{
    public partial class Dataset : IDisposable
    {

        INetworkReachability NetReachability;

        /// <summary>
        /// Synchronize <see cref="Dataset"/> between local storage and remote storage.
        /// </summary>
        public virtual void Synchronize()
        {
            if (NetReachability.NetworkStatus == NetworkStatus.NotReachable)
            {
                FireSyncFailureEvent(new NetworkException("Network connectivity unavailable."));
                return;
            }

            // if the thread is in background thread, then start synchronizing, 
            // else queue the synchronization in a threadpool thread
            if (!UnityInitializer.IsMainThread())
            {
                SynchronizeHelperAsync();
            }
            else
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    SynchronizeHelperAsync();
                }));
            }
        }

        private void DatasetSetupInternal()
        {
            NetReachability = ServiceFactory.Instance.GetService<INetworkReachability>();
            NetReachability.NetworkReachabilityChanged += OnNetworkReachabilityChanged;
        }

        /// <summary>
        /// Attempt to synchronize <see cref="Dataset"/> when connectivity is available. If
        /// the connectivity is available right away, it behaves the same as
        /// <see cref="Dataset.Synchronize()"/>. Otherwise it listens to connectivity
        /// changes, and will do a sync once the connectivity is back. Note that if
        /// this method is called multiple times, only the last synchronize request
        /// is kept. If either the dataset or the callback is garbage collected
        /// , this method will not perform a sync and the callback won't fire.
        /// </summary>
        public virtual void SynchronizeOnConnectivity()
        {
            if (NetReachability.NetworkStatus != NetworkStatus.NotReachable)
            {
                Synchronize();
            }
            else
            {
                waitingForConnectivity = true;
            }
        }

        private void RunSyncOperationAsync(int retry)
        {

            long lastSyncCount = _local.GetLastSyncCount(IdentityId, _datasetName);

            // if dataset is deleted locally, push it to remote
            if (lastSyncCount == -1)
            {
                _remote.DeleteDatasetAsync(_datasetName, (cognitoResult) =>
                {
                    if (cognitoResult.Exception != null)
                    {
                        if (cognitoResult.Exception is DatasetNotFoundException)
                        {
                            _logger.Error(cognitoResult.Exception, "Dataset was local-only, it's safe to ignore the service exception. Continuing.");
                        }
                        else
                        {
                            Exception e = cognitoResult.Exception;
                            _logger.InfoFormat("{0} , dataset : {1}", e.Message, this._datasetName);
                            EndSynchronizeAndCleanup();
                            FireSyncFailureEvent(e);
                            return;
                        }
                    }

                    _local.PurgeDataset(IdentityId, _datasetName);
                    _logger.InfoFormat("OnSyncSuccess: dataset delete is pushed to remote - {0}", this._datasetName);
                    EndSynchronizeAndCleanup();
                    FireSyncSuccessEvent(new List<Record>());

                    return;
                });
                return;
            }

            // get latest modified records from remote
            _logger.InfoFormat("get latest modified records since {0} for dataset {1}", lastSyncCount, this._datasetName);

            _remote.ListUpdatesAsync(_datasetName, lastSyncCount, (cognitoResult) =>
            {
                DatasetUpdates datasetUpdates = cognitoResult.Response;
                Exception listUpdatesException = cognitoResult.Exception;

                if (datasetUpdates == null || listUpdatesException != null)
                {
                    _logger.Error(listUpdatesException, string.Empty);
                    EndSynchronizeAndCleanup();
                    FireSyncFailureEvent(listUpdatesException);

                    return;
                }

                if (datasetUpdates.MergedDatasetNameList.Count != 0 && this.OnDatasetMerged != null)
                {
                    bool resume = this.OnDatasetMerged(this, datasetUpdates.MergedDatasetNameList);
                    if (resume)
                    {
                        if (retry == 0)
                        {
                            EndSynchronizeAndCleanup();
                            FireSyncFailureEvent(new SyncManagerException("Out of retries"));
                        }
                        else
                        {
                            this.RunSyncOperationAsync(--retry);
                        }
                        return;
                    }
                    else
                    {
                        _logger.InfoFormat("OnSyncFailure: Manual Cancel");
                        EndSynchronizeAndCleanup();
                        FireSyncFailureEvent(new SyncManagerException("Manual cancel"));
                        return;
                    }
                }

                // if the dataset doesn't exist or is deleted, trigger onDelete
                if (lastSyncCount != 0 && !datasetUpdates.Exists
                    || datasetUpdates.Deleted && this.OnDatasetDeleted != null)
                {
                    bool resume = this.OnDatasetDeleted(this);
                    if (resume)
                    {
                        // remove both records and metadata
                        _local.DeleteDataset(IdentityId, _datasetName);
                        _local.PurgeDataset(IdentityId, _datasetName);
                        _logger.InfoFormat("OnSyncSuccess");
                        EndSynchronizeAndCleanup();
                        FireSyncSuccessEvent(new List<Record>());
                        return;
                    }
                    else
                    {
                        _logger.InfoFormat("OnSyncFailure");
                        EndSynchronizeAndCleanup();
                        FireSyncFailureEvent(new SyncManagerException("Manual cancel"));
                        return;
                    }
                }
                lastSyncCount = datasetUpdates.SyncCount;

                List<Record> remoteRecords = datasetUpdates.Records;
                if (remoteRecords.Count != 0)
                {
                    // if conflict, prompt developer/user with callback
                    List<SyncConflict> conflicts = new List<SyncConflict>();
                    List<Record> conflictRecords = new List<Record>();
                    foreach (Record remoteRecord in remoteRecords)
                    {
                        Record localRecord = _local.GetRecord(IdentityId,
                                                              _datasetName,
                                                              remoteRecord.Key);
                        // only when local is changed and its value is different
                        if (localRecord != null && localRecord.IsModified
                            && !StringUtils.Equals(localRecord.Value, remoteRecord.Value))
                        {
                            conflicts.Add(new SyncConflict(remoteRecord, localRecord));
                            conflictRecords.Add(remoteRecord);
                        }
                    }
                    // retaining only non-conflict records
                    remoteRecords.RemoveAll(t => conflictRecords.Contains(t));

                    if (conflicts.Count > 0)
                    {
                        _logger.InfoFormat("{0} records in conflict!", conflicts.Count);
                        bool syncConflictResult = false;
                        if (this.OnSyncConflict == null)
                        {
                            // delegate is not implemented so the conflict resolution is applied
                            syncConflictResult = this.ResolveConflictsWithDefaultPolicy(conflicts);
                        }
                        else
                        {
                            syncConflictResult = this.OnSyncConflict(this, conflicts);
                        }
                        if (!syncConflictResult)
                        {
                            _logger.InfoFormat("User cancelled conflict resolution");
                            EndSynchronizeAndCleanup();
                            FireSyncFailureEvent(new OperationCanceledException("User cancelled conflict resolution"));
                            return;
                        }
                    }

                    // save to local
                    if (remoteRecords.Count > 0)
                    {
                        _logger.InfoFormat("save {0} records to local", remoteRecords.Count);
                        _local.PutRecords(IdentityId, _datasetName, remoteRecords);
                    }


                    // new last sync count
                    _logger.InfoFormat("updated sync count {0}", datasetUpdates.SyncCount);
                    _local.UpdateLastSyncCount(IdentityId, _datasetName,
                                              datasetUpdates.SyncCount);
                }

                // push changes to remote
                List<Record> localChanges = ModifiedRecords;
                long maxPatchSyncCount = 0;
                foreach (Record r in localChanges)
                {
                    //track the max sync count
                    if (r.SyncCount > maxPatchSyncCount)
                    {
                        maxPatchSyncCount = r.SyncCount;
                    }
                }
                if (localChanges.Count != 0)
                {
                    _logger.InfoFormat("push {0} records to remote", localChanges.Count);

                    _remote.PutRecordsAsync(_datasetName, localChanges, datasetUpdates.SyncSessionToken, (putRecordsResult) =>
                    {
                        Exception putRecordsException = putRecordsResult.Exception;
                        if (putRecordsException != null)
                        {
                            if (putRecordsException is DataConflictException)
                            {
                                _logger.InfoFormat("Conflicts detected when pushing changes to remote: {0}", putRecordsException.Message);
                                if (retry == 0)
                                {
                                    EndSynchronizeAndCleanup();
                                    FireSyncFailureEvent(putRecordsResult.Exception);
                                }
                                else
                                {
                                    //it's possible there is a local dirty record with a stale sync count this will fix it
                                    if (lastSyncCount > maxPatchSyncCount)
                                    {
                                        _local.UpdateLastSyncCount(IdentityId, _datasetName, maxPatchSyncCount);
                                    }
                                    this.RunSyncOperationAsync(--retry);
                                }
                                return;
                            }
                            else
                            {
                                _logger.InfoFormat("OnSyncFailure {0}", putRecordsException.Message);
                                EndSynchronizeAndCleanup();
                                FireSyncFailureEvent(putRecordsException);
                                return;
                            }
                        }

                        List<Record> result = putRecordsResult.Response;

                        // update local meta data
                        _local.ConditionallyPutRecords(IdentityId, _datasetName, result, localChanges);

                        // verify the server sync count is increased exactly by one, aka no
                        // other updates were made during this update.
                        long newSyncCount = 0;
                        foreach (Record record in result)
                        {
                            newSyncCount = newSyncCount < record.SyncCount
                                ? record.SyncCount
                                    : newSyncCount;
                        }
                        if (newSyncCount == lastSyncCount + 1)
                        {
                            _logger.InfoFormat("updated sync count {0}", newSyncCount);
                            _local.UpdateLastSyncCount(IdentityId, _datasetName,
                                                      newSyncCount);
                        }

                        _logger.InfoFormat("OnSyncSuccess");
                        EndSynchronizeAndCleanup();
                        FireSyncSuccessEvent(remoteRecords);
                        return;
                    });
                }
                else
                {
                    _logger.InfoFormat("OnSyncSuccess");
                    EndSynchronizeAndCleanup();
                    FireSyncSuccessEvent(remoteRecords);
                    return;
                }
            });
        }

        private void OnNetworkReachabilityChanged(object sender, NetworkStatusEventArgs e)
        {
            if (!waitingForConnectivity)
            {
                return;
            }

            if (e.Status != NetworkStatus.NotReachable)
            {
                Synchronize();
            }
        }

        /// <summary>
        /// Releases the resources consumed by this object if disposing is true. 
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                ClearAllDelegates();
                NetReachability.NetworkReachabilityChanged -= OnNetworkReachabilityChanged;
                _disposed = true;
            }
        }
    }
}
