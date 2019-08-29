//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// SPDX-License-Identifier: Apache-2.0
//
using Amazon.CognitoIdentity;
using Amazon.CognitoSync.SyncManager.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Logger = Amazon.Runtime.Internal.Util.Logger;
using Amazon.Util.Internal.PlatformServices;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;
#if BCL45 || PCL || NETSTANDARD
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;
#endif

namespace Amazon.CognitoSync.SyncManager
{
    /// <summary>
    /// Dataset is the container of <see cref="Amazon.CognitoSync.SyncManager.Record"/>s. It can have up to 1k
    /// <see cref="Amazon.CognitoSync.SyncManager.Record"/> or 1 MB in size. A typical use of Dataset is the
    /// following.
    /// 
    /// <code>
    /// //open or create dataset
    /// Dataset dataset = cognitoSyncManger.OpenOrCreateDataset(&quot;new dataset&quot;);
    /// // synchronize. It pulls down latest changes from remote storage
    /// // and push local changes to remote storage
    /// dataset.Synchronize();
    /// // reads value
    /// String highScore = dataset.Get(&quot;high_score&quot;);
    /// String name = dataset.Get(&quot;name&quot;);
    /// // sets value
    /// dataset.Put(&quot;high_score&quot;, &quot;90&quot;);
    /// dataset.Put(&quot;name&quot;, &quot;John&quot;);
    /// // push changes to remote if needed
    /// dataset.Synchronize();
    /// </code>
    /// </summary>
    /// <seealso href="http://docs.aws.amazon.com/cognito/latest/developerguide/synchronizing-data.html#understanding-datasets">Amazon Cognito Sync Dev. Guide - Understanding Datasets</seealso>
    public partial class Dataset : IDisposable
    {
        /// <summary>
        /// Max number of retries during synchronize before it gives up.
        /// </summary>
        private const int MAX_RETRY = 3;

        /// <summary>
        /// The name of the dataset
        /// </summary>
        protected string DatasetName
        {
            get
            {
                return this._datasetName;
            }
        }

        private string _datasetName;

        /// <summary>
        /// Instance of <see cref="Amazon.CognitoSync.SyncManager.ILocalStorage"/>
        /// </summary>
        protected ILocalStorage Local
        {
            get
            {
                return this._local;
            }
        }

        private ILocalStorage _local;

        private CognitoSyncStorage _remote;

        /// <summary>
        /// Instance of <see cref="Amazon.CognitoSync.SyncManager.Internal.CognitoSyncStorage"/>
        /// </summary>
        protected CognitoSyncStorage Remote
        {
            get
            {
                return this._remote;
            }
        }

        /// <summary>
        /// Instance of <see cref="Amazon.CognitoIdentity.CognitoAWSCredentials"/>
        /// </summary>
        protected CognitoAWSCredentials CognitoCredentials
        {
            get
            {
                return this._cognitoCredentials;
            }
        }

        private CognitoAWSCredentials _cognitoCredentials;

        private Boolean waitingForConnectivity = false;
        private bool _disposed;
        private Logger _logger;

        #region constructor

        /// <summary>
        /// Creates a new Dataset
        /// </summary>
        /// <param name="datasetName">The name of the dataset</param>
        /// <param name="cognitoCredentials">The Cognito Credentials associated with the dataset</param>
        /// <param name="local">Local storage, can be InMemoryStorage or SQLiteStorage or Some Custom Storage Class which implements <see cref="Amazon.CognitoSync.SyncManager.ILocalStorage"/></param>
        /// <param name="remote">Remote storage</param>
        internal Dataset(string datasetName, CognitoAWSCredentials cognitoCredentials, ILocalStorage local, CognitoSyncStorage remote)
        {
            this._datasetName = datasetName;
            this._cognitoCredentials = cognitoCredentials;
            this._local = local;
            this._remote = remote;
            _logger = Logger.GetLogger(this.GetType());
            DatasetSetupInternal();
        }

        #endregion

        #region dispose methods
        /// <summary>
        /// Releases the resources consumed by this object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

        #region public methods

        /// <summary>
        /// Retrieves the associated <see cref="Amazon.CognitoSync.SyncManager.DatasetMetadata"/> from local storage.
        /// </summary>
        /// <value>The metadata for the Dataset.</value>
        public DatasetMetadata Metadata
        {
            get
            {
                return Local.GetDatasetMetadata(IdentityId, DatasetName);
            }
        }

        internal List<string> LocalMergedDatasets
        {
            get
            {
                List<string> mergedDatasets = new List<string>();
                string prefix = DatasetName + ".";
                foreach (DatasetMetadata dataset in Local.GetDatasetMetadata(IdentityId))
                {
                    if (dataset.DatasetName.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                    {
                        mergedDatasets.Add(dataset.DatasetName);
                    }
                }
                return mergedDatasets;
            }
        }

        /// <summary>
        /// Delete this <see cref="Amazon.CognitoSync.SyncManager.Dataset"/>. You cannot do any more operations
        /// on this dataset.
        /// </summary>
        public void Delete()
        {
            Local.DeleteDataset(IdentityId, DatasetName);
        }

        /// <summary>
        /// Gets the value of a <see cref=
        /// "Record"/> with the given key. If the
        /// <see cref="Amazon.CognitoSync.SyncManager.Record"/> doesn't exist or is marked deleted, null will be returned.
        /// </summary>
        /// <param name="key">Key of the record in the dataset.</param>
        /// <seealso href="http://docs.aws.amazon.com/cognito/latest/developerguide/synchronizing-data.html#reading-and-writing-data">Amazon Cognito Sync Dev. Guide - Reading and Writing Data</seealso>
        public string Get(string key)
        {
            return Local.GetValue(IdentityId, DatasetName,
                                  DatasetUtils.ValidateRecordKey(key));
        }

        /// <summary>
        /// Gets the <see cref="Amazon.CognitoSync.SyncManager.Record"/> with the given key. If the
        /// <see cref="Amazon.CognitoSync.SyncManager.Record"/> doesn't exist or is marked deleted, null will be returned.
        /// </summary>
        /// <param name="key">Key of the record in the dataset.</param>
        public Record GetRecord(string key)
        {
            return Local.GetRecord(IdentityId, DatasetName,
                                  DatasetUtils.ValidateRecordKey(key));
        }

        /// <summary>
        /// Gets the Key/Value representation of all records of this dataset. Datasets marked
        /// as deleted records are excluded.
        /// </summary>
        /// <returns>Key/Value representation of all records, excluding deleted ones</returns>
        public IDictionary<string, string> ActiveRecords
        {
            get
            {
                IDictionary<string, string> map = new Dictionary<string, string>();
                foreach (Record record in Local.GetRecords(IdentityId, DatasetName))
                {
                    if (!record.IsDeleted)
                    {
                        map.Add(record.Key, record.Value);
                    }
                }
                return map;
            }
        }

        /// <summary>
        /// Retrieves all raw records, including those marked as deleted, from local storage.
        /// </summary>
        /// <returns>List of all raw records</returns>
        public IList<Record> Records
        {
            get
            {
                return Local.GetRecords(IdentityId, DatasetName);
            }
        }

        /// <summary>
        /// Gets the size of a record with the given key. If the key is deleted, -1
        /// will be returned.
        ///  The size is calculated as sum of UTF-8 string length of record key and value
        /// </summary>
        /// <returns>The size in bytes.</returns>
        /// <param name="key">The key of a record</param>
        public long GetSizeInBytes(string key)
        {
            return DatasetUtils.ComputeRecordSize(Local.GetRecord(IdentityId,
                DatasetName, DatasetUtils.ValidateRecordKey(key)));
        }

        /// <summary>
        /// Gets the total size in bytes of this dataset. Records that are marked as
        /// deleted don't contribute to the total size.
        /// The size is calculated as sum of UTF-8 string length of key and value for all the records
        /// </summary>
        /// <returns>The total size in bytes</returns>
        public long TotalSizeInBytes
        {
            get
            {
                long size = 0;
                foreach (Record record in Local.GetRecords(IdentityId, DatasetName))
                {
                    size += DatasetUtils.ComputeRecordSize(record);
                }
                return size;
            }
        }

        /// <summary>
        /// Retrieves the status of a record.
        /// </summary>
        /// <returns><c>true</c> if it is modified locally; otherwise, <c>false</c>.</returns>
        /// <param name="key">Key identifying a record</param>
        public bool IsModified(string key)
        {
            Record record = Local.GetRecord(IdentityId, DatasetName,
                                             DatasetUtils.ValidateRecordKey(key));
            return (record != null && record.IsModified);
        }

        /// <summary>
        /// Puts a <see cref="Amazon.CognitoSync.SyncManager.Record"/> with the given key and value into the
        /// Dataset. If a <see cref="Amazon.CognitoSync.SyncManager.Record"/> with the same key exists, its value
        /// will be overwritten. If a <see cref="Amazon.CognitoSync.SyncManager.Record"/> is marked as deleted previously,
        /// then it will be resurrected with new value while the sync count continues
        /// with previous value. No matter whether the value changes or not, the
        /// record is considered as updated, and it will be written to Cognito Sync
        /// service on next synchronize operation. If value is null, a
        /// ArgumentNullException will be thrown.
        /// </summary>
        /// <param name="key">Key of the record</param>
        /// <param name="value">String value of a <see cref="Amazon.CognitoSync.SyncManager.Record"/> to be put into the
        /// <see cref="Amazon.CognitoSync.SyncManager.Dataset"/></param>
        /// <seealso href="http://docs.aws.amazon.com/cognito/latest/developerguide/synchronizing-data.html#reading-and-writing-data">Amazon Cognito Sync Dev. Guide - Reading and Writing Data</seealso>
        public void Put(string key, string value)
        {
            Local.PutValue(IdentityId, DatasetName,
                           DatasetUtils.ValidateRecordKey(key), value);
        }

        /// <summary>
        /// Populates a dataset with a dictionary of key/value pairs
        /// </summary>
        /// <param name="values">An IDictionary of key/value pairs</param>
        public void PutAll(IDictionary<string, string> values)
        {
            foreach (string key in values.Keys)
            {
                DatasetUtils.ValidateRecordKey(key);
            }
            Local.PutAllValues(IdentityId, DatasetName, values);
        }

        /// <summary>
        /// Marks a <see cref="Amazon.CognitoSync.SyncManager.Record"/> with the given key as deleted. Nothing happens if
        /// the <see cref="Amazon.CognitoSync.SyncManager.Record"/> doesn't exist or is deleted already.
        /// </summary>
        /// <param name="key">Key identifying the Record</param>
        /// <seealso href="http://docs.aws.amazon.com/cognito/latest/developerguide/synchronizing-data.html#reading-and-writing-data">Amazon Cognito Sync Dev. Guide - Reading and Writing Data</seealso>
        public void Remove(string key)
        {
            Local.PutValue(IdentityId, DatasetName, DatasetUtils.ValidateRecordKey(key), null);
        }

        /// <summary>
        /// Saves resolved conflicting <see cref="Amazon.CognitoSync.SyncManager.Record" /> into local storage. This is
        /// used inside <see cref="SyncConflictDelegate"/> after you
        /// resolve all conflicts.
        /// </summary>
        /// <param name="remoteRecords">A list of records to save into local storage</param>
        public void Resolve(List<Record> remoteRecords)
        {
            Local.PutRecords(IdentityId, DatasetName, remoteRecords);
        }

        #endregion

        #region helper methods

        bool locked = false;
        bool queuedSync = false;

        private void EndSynchronizeAndCleanup()
        {
            locked = false;
            if (queuedSync)
            {
                queuedSync = false;
            }
        }


#if BCL35
        private void RunSyncOperation(int retry)
#else
        private async Task RunSyncOperationAsync(int retry, CancellationToken cancellationToken)
#endif
        {
            long lastSyncCount = Local.GetLastSyncCount(IdentityId, DatasetName);
#if !(BCL35)
            ExceptionDispatchInfo capturedException = null;
#endif
            // if dataset is deleted locally, push it to remote
            if (lastSyncCount == -1)
            {
                try
                {
#if BCL35
                    Remote.DeleteDataset(DatasetName);
#else
                    await Remote.DeleteDatasetAsync(DatasetName, cancellationToken).ConfigureAwait(false);
#endif
                }
                catch (DatasetNotFoundException)
                {
                    //Ignore the exception here, since the dataset was local only
                }
                catch (Exception e)
                {
                    _logger.InfoFormat("{0} , dataset : {1}", e.Message, this.DatasetName);
                    EndSynchronizeAndCleanup();
                    FireSyncFailureEvent(e);
                    return;
                }

                Local.PurgeDataset(IdentityId, DatasetName);
                _logger.InfoFormat("OnSyncSuccess: dataset delete is pushed to remote - {0}", this.DatasetName);
                EndSynchronizeAndCleanup();
                FireSyncSuccessEvent(new List<Record>());
                return;
            }

            // get latest modified records from remote
            _logger.InfoFormat("Get latest modified records since {0} for dataset {1}", lastSyncCount, this.DatasetName);
            DatasetUpdates datasetUpdates = null;
            try
            {
#if BCL35
                datasetUpdates = Remote.ListUpdates(DatasetName, lastSyncCount);
#else
                datasetUpdates = await Remote.ListUpdatesAsync(DatasetName, lastSyncCount, cancellationToken).ConfigureAwait(false);
#endif
            }
            catch (Exception listUpdatesException)
            {
                _logger.Error(listUpdatesException, string.Empty);
                EndSynchronizeAndCleanup();
                FireSyncFailureEvent(listUpdatesException);
                return;
            }

            if (datasetUpdates != null && datasetUpdates.MergedDatasetNameList.Count != 0 && this.OnDatasetMerged != null)
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
#if BCL35
                        this.RunSyncOperation(--retry);
#else
                        await this.RunSyncOperationAsync(--retry, cancellationToken).ConfigureAwait(false);
#endif
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
                    Local.DeleteDataset(IdentityId, DatasetName);
                    Local.PurgeDataset(IdentityId, DatasetName);
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
                    Record localRecord = Local.GetRecord(IdentityId,
                                                          DatasetName,
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
                    _logger.InfoFormat("Save {0} records to local", remoteRecords.Count);
                    Local.PutRecords(IdentityId, DatasetName, remoteRecords);
                }


                // new last sync count
                _logger.InfoFormat("Updated sync count {0}", datasetUpdates.SyncCount);
                Local.UpdateLastSyncCount(IdentityId, DatasetName,
                                          datasetUpdates.SyncCount);
            }

            // push changes to remote
            List<Record> localChanges = this.ModifiedRecords;
            long minPatchSyncCount = lastSyncCount;
            foreach (Record r in localChanges)
            {
                //track the max sync count
                if (r.SyncCount < minPatchSyncCount)
                {
                    minPatchSyncCount = r.SyncCount;
                }
            }
            if (localChanges.Count != 0)
            {
                _logger.InfoFormat("Push {0} records to remote", localChanges.Count);

                try
                {
#if BCL35
                    List<Record> result = Remote.PutRecords(DatasetName, localChanges, datasetUpdates.SyncSessionToken);
#else
                    List<Record> result = await Remote.PutRecordsAsync(DatasetName, localChanges, datasetUpdates.SyncSessionToken, cancellationToken).ConfigureAwait(false);
#endif

                    // update local meta data
                    Local.ConditionallyPutRecords(IdentityId, DatasetName, result, localChanges);

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
                        _logger.InfoFormat("Updated sync count {0}", newSyncCount);
                        Local.UpdateLastSyncCount(IdentityId, DatasetName,
                                                  newSyncCount);
                    }

                    _logger.InfoFormat("OnSyncSuccess");
                    EndSynchronizeAndCleanup();
                    FireSyncSuccessEvent(remoteRecords);
                    return;

                }
                catch (DataConflictException e)
                {
                    _logger.InfoFormat("Conflicts detected when pushing changes to remote: {0}", e.Message);
                    if (retry == 0)
                    {
                        EndSynchronizeAndCleanup();
                        FireSyncFailureEvent(e);
                    }
                    else
                    {
                        //it's possible there is a local dirty record with a stale sync count this will fix it
                        if (lastSyncCount > minPatchSyncCount)
                        {
                            Local.UpdateLastSyncCount(IdentityId, DatasetName, minPatchSyncCount);
                        }
#if BCL35
                        RunSyncOperation(--retry);
                    }
                    return;
                }
#else
                        capturedException = ExceptionDispatchInfo.Capture(e);
                    }
                }
#endif
                catch (Exception e)
                {
                    _logger.InfoFormat("OnSyncFailure {0}", e.Message);
                    EndSynchronizeAndCleanup();
                    FireSyncFailureEvent(e);
                    return;
                }
#if !(BCL35)
                if (capturedException != null)
                    await RunSyncOperationAsync(--retry, cancellationToken).ConfigureAwait(false);

                return;
#endif
            }
            else
            {
                _logger.InfoFormat("OnSyncSuccess");
                EndSynchronizeAndCleanup();
                FireSyncSuccessEvent(remoteRecords);
                return;
            }
        }

#if BCL35
        private void SynchornizeInternal()
#else
        private async Task SynchornizeInternalAsync(CancellationToken cancellationToken)
#endif
        {

            //make sure we have the latest identity id
            try
            {
#if BCL35
                CognitoCredentials.GetIdentityId();
#else
            await CognitoCredentials.GetIdentityIdAsync().ConfigureAwait(false);
#endif
                bool resume = true;
                List<string> mergedDatasets = LocalMergedDatasets;
                if (mergedDatasets.Count > 0)
                {
                    _logger.InfoFormat("Detected merge datasets - {0}", DatasetName);

                    if (this.OnDatasetMerged != null)
                    {
                        resume = this.OnDatasetMerged(this, mergedDatasets);
                    }
                }

                if (!resume)
                {
                    EndSynchronizeAndCleanup();
                    FireSyncFailureEvent(new OperationCanceledException(string.Format(CultureInfo.InvariantCulture, "Sync canceled on merge for dataset - {0}", this.DatasetName)));
                    return;
                }
#if BCL35
                RunSyncOperation(MAX_RETRY);
#else
                await RunSyncOperationAsync(MAX_RETRY, cancellationToken).ConfigureAwait(false);
#endif
            }
            catch (Exception e)
            {
                EndSynchronizeAndCleanup();
                FireSyncFailureEvent(e);
                _logger.Error(e, "");
            }

        }

        internal String IdentityId
        {
            get
            {
                return DatasetUtils.GetIdentityId(CognitoCredentials);
            }
        }

        internal List<Record> ModifiedRecords
        {
            get
            {
                return Local.GetModifiedRecords(IdentityId, DatasetName);
            }
        }

        #endregion

        #region SynchronizeEvents

        private EventHandler<SyncSuccessEventArgs> mOnSyncSuccess;

        /// <summary>
        /// This is called after remote changes are downloaded to local storage
        /// and local changes are uploaded to remote storage. Updated records
        /// from remote storage are passed in the callback. If conflicts occur
        /// during synchronize and are resolved in <see cref="SyncConflictDelegate"/> after
        /// several retries, then updatedRecords will be what are pulled down
        /// from remote in the last retry.   
        /// </summary>
        public event EventHandler<SyncSuccessEventArgs> OnSyncSuccess
        {
            add
            {
                lock (this)
                {
                    mOnSyncSuccess += value;
                }
            }
            remove
            {
                lock (this)
                {
                    mOnSyncSuccess -= value;
                }
            }
        }

        private EventHandler<SyncFailureEventArgs> mOnSyncFailure;

        /// <summary>
        /// This is called when an exception occurs during sync
        /// </summary>
        public event EventHandler<SyncFailureEventArgs> OnSyncFailure
        {
            add
            {
                lock (this)
                {
                    mOnSyncFailure += value;
                }
            }
            remove
            {
                lock (this)
                {
                    mOnSyncFailure -= value;
                }
            }
        }

        /// <summary>
        /// Fires a Sync Success Event
        /// </summary>
        /// <param name="records">List of records after successful sync</param>
        protected void FireSyncSuccessEvent(List<Record> records)
        {
            if (mOnSyncSuccess != null)
            {
                mOnSyncSuccess(this, new SyncSuccessEventArgs(records));
            }
        }

        /// <summary>
        /// Fires a Sync Failure event.
        /// </summary>
        /// <param name="exception">Exception object which caused the sync Failure</param>
        protected void FireSyncFailureEvent(Exception exception)
        {
            if (mOnSyncFailure != null)
            {
                mOnSyncFailure(this, new SyncFailureEventArgs(exception));
            }
        }
        #endregion

        #region SynchronizeDelegates
        /// <summary>
        /// Delegate which is invoked when a sync conflict occurs
        /// </summary>
        /// <param name="dataset">The data set which resulted in conflict</param>
        /// <param name="conflicts">List of Objects which have conflicts</param>
        /// <returns>true if you want to retry synchronization, else false</returns>
        public delegate bool SyncConflictDelegate(Dataset dataset, List<SyncConflict> conflicts);

        /// <summary>
        /// Delegate which is invoked when a data set is deleted
        /// </summary>
        /// <param name="dataset">The dataset which was deleted</param>
        /// <returns>true if you want to remove local dataset, or false if you want to
        /// keep it</returns>
        public delegate bool DatasetDeletedDelegate(Dataset dataset);

        /// <summary>
        /// Delegate which is invoked when a dataset is merged due to an identity merge
        /// </summary>
        /// <param name="dataset">The dataset which was merged, due to an identity merge</param>
        /// <param name="datasetNames">identity id's on which merge occured</param>
        /// <returns></returns>
        public delegate bool DatasetMergedDelegate(Dataset dataset, List<string> datasetNames);

        /// <summary>
        /// This can be triggered during two phases. One is when the remote
        /// changes are about to be written to local storage. The other is when
        /// local changes are uploaded to remote storage and got rejected. Here
        /// is an example:
        /// 
        /// <code>
        ///     playerInfo.OnSyncConflict = this.HandleSyncConflict;
        /// 
        ///     private bool HandleSyncConflict(Dataset dataset, List&lt;SyncConflict&gt; conflicts)
        ///     {
        ///         List&lt;Record&gt; resolved = new List&lt;Record&gt;();
        ///         for (SyncConflict conflict in conflicts) 
        ///         {
        ///             resolved.add(conflicts.resolveWithRemoteRecord());
        ///         }
        ///         dataset.Resolve(resolved);
        ///         return true;
        ///     }
        /// </code>
        /// </summary>
        public SyncConflictDelegate OnSyncConflict;

        /// <summary>
        /// This is triggered when the given dataset is deleted remotely. Return
        /// true if you want to remove local dataset, or false if you want to
        /// keep it.
        /// </summary>
        public DatasetDeletedDelegate OnDatasetDeleted;

        /// <summary>
        /// If two or more datasets are merged as a result of identity merge,
        /// this will be triggered. A list of names of merged datasets' is passed
        /// in. The merged dataset name will be appended with its old identity
        /// id. One can open the merged dataset, synchronize the content,
        /// reconcile with the current dataset, and remove it. This callback will
        /// fire off until the merged dataset is removed.
        /// <return></return>
        /// </summary>
        public DatasetMergedDelegate OnDatasetMerged;

        /// <summary>
        /// Clears all the delegates
        /// </summary>
        public void ClearAllDelegates()
        {
            if (mOnSyncSuccess != null)
                foreach (Delegate d in mOnSyncSuccess.GetInvocationList())
                    OnSyncSuccess -= (EventHandler<SyncSuccessEventArgs>)d;

            if (mOnSyncFailure != null)
                foreach (Delegate d in mOnSyncFailure.GetInvocationList())
                    OnSyncFailure -= (EventHandler<SyncFailureEventArgs>)d;

            if (OnSyncConflict != null)
                foreach (Delegate d in OnSyncConflict.GetInvocationList())
                    OnSyncConflict -= (SyncConflictDelegate)d;

            if (OnDatasetDeleted != null)
                foreach (Delegate d in OnDatasetDeleted.GetInvocationList())
                    OnDatasetDeleted -= (DatasetDeletedDelegate)d;

            if (OnDatasetMerged != null)
                foreach (Delegate d in OnDatasetMerged.GetInvocationList())
                    OnDatasetMerged -= (DatasetMergedDelegate)d;
        }

        #endregion

        #region Default conflict resolution
        internal bool ResolveConflictsWithDefaultPolicy(List<SyncConflict> conflicts)
        {
            List<Record> resolvedRecords = new List<Record>();

            foreach (SyncConflict conflict in conflicts)
            {
                if (conflict.RemoteRecord == null || conflict.LocalRecord.LastModifiedDate.Value.CompareTo(conflict.RemoteRecord.LastModifiedDate.Value) > 0)
                {
                    resolvedRecords.Add(conflict.ResolveWithLocalRecord());
                }
                else
                {
                    resolvedRecords.Add(conflict.ResolveWithRemoteRecord());
                }
            }
            this.Resolve(resolvedRecords);
            return true;
        }
        #endregion
    }

    /// <summary>
    /// A sync success event
    /// </summary>
    public class SyncSuccessEventArgs : EventArgs
    {
        /// <summary>
        /// List of updated records
        /// </summary>
        public List<Record> UpdatedRecords { get; private set; }

        internal SyncSuccessEventArgs(List<Record> updatedRecords)
        {
            this.UpdatedRecords = updatedRecords;
        }
    }

    /// <summary>
    /// A sync failure event
    /// </summary>
    public class SyncFailureEventArgs : EventArgs
    {
        /// <summary>
        /// Exception which triggered the failure event
        /// </summary>
        public Exception Exception { get; private set; }

        internal SyncFailureEventArgs(Exception exception)
        {
            this.Exception = exception;
        }
    }

}
