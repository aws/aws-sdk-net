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
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Amazon.Runtime;
using Amazon.CognitoSync.SyncManager;
using Amazon.CognitoSync.SyncManager.Internal;
using System.Text;
using Amazon.Runtime.Internal.Util;
using Logger = Amazon.Runtime.Internal.Util.Logger;
using Amazon.Util;
using System.Globalization;

namespace Amazon.CognitoSync.SyncManager.Internal
{
    /// <summary>
    /// An implementation for <see cref="Amazon.CognitoSync.SyncManager.ILocalStorage"/> 
    /// using <see href="http://sqlite.org">SQLite</see>
    /// </summary>
    public partial class SQLiteLocalStorage : ILocalStorage, IDisposable
    {
        internal Logger _logger;

        private static object sqlite_lock = new object();

        internal const string DB_FILE_NAME = "aws_cognito_sync.db";

        #region constructor

#if !UNITY
        /// <summary>
        /// Creates a new instance of SQLiteLocalStorage
        /// </summary>
        public SQLiteLocalStorage()
        {
            _logger = Logger.GetLogger(this.GetType());
            SetupDatabase();
        }
#endif
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

        #region table datastructure

        internal const string TABLE_DATASETS = "datasets";
        internal const string TABLE_RECORDS = "records";

        static class DatasetColumns
        {
            internal const string IDENTITY_ID = "identity_id";
            internal const string DATASET_NAME = "dataset_name";
            internal const string CREATION_TIMESTAMP = "creation_timestamp";
            internal const string LAST_MODIFIED_TIMESTAMP = "last_modified_timestamp";
            internal const string LAST_MODIFIED_BY = "last_modified_by";
            internal const string STORAGE_SIZE_BYTES = "storage_size_bytes";
            internal const string RECORD_COUNT = "record_count";
            internal const string LAST_SYNC_COUNT = "last_sync_count";
            internal const string LAST_SYNC_TIMESTAMP = "last_sync_timestamp";
            internal const string LAST_SYNC_RESULT = "last_sync_result";
            internal static readonly string[] ALL = new string[] {
                IDENTITY_ID, DATASET_NAME,
                CREATION_TIMESTAMP, LAST_MODIFIED_TIMESTAMP, LAST_MODIFIED_BY,
                STORAGE_SIZE_BYTES, RECORD_COUNT,
                LAST_SYNC_COUNT, LAST_SYNC_TIMESTAMP, LAST_SYNC_RESULT,
            };
            internal static readonly int IDENTITY_ID_IDX = Array.IndexOf(DatasetColumns.ALL, DatasetColumns.IDENTITY_ID);
            internal static readonly int DATASET_NAME_IDX = Array.IndexOf(DatasetColumns.ALL, DatasetColumns.DATASET_NAME);
            internal static readonly int CREATION_TIMESTAMP_IDX = Array.IndexOf(DatasetColumns.ALL, DatasetColumns.CREATION_TIMESTAMP);
            internal static readonly int LAST_MODIFIED_TIMESTAMP_IDX = Array.IndexOf(DatasetColumns.ALL, DatasetColumns.LAST_MODIFIED_TIMESTAMP);
            internal static readonly int LAST_MODIFIED_BY_IDX = Array.IndexOf(DatasetColumns.ALL, DatasetColumns.LAST_MODIFIED_BY);
            internal static readonly int STORAGE_SIZE_BYTES_IDX = Array.IndexOf(DatasetColumns.ALL, DatasetColumns.STORAGE_SIZE_BYTES);
            internal static readonly int RECORD_COUNT_IDX = Array.IndexOf(DatasetColumns.ALL, DatasetColumns.RECORD_COUNT);
            internal static readonly int LAST_SYNC_COUNT_IDX = Array.IndexOf(DatasetColumns.ALL, DatasetColumns.LAST_SYNC_COUNT);
            internal static readonly int LAST_SYNC_TIMESTAMP_IDX = Array.IndexOf(DatasetColumns.ALL, DatasetColumns.LAST_SYNC_TIMESTAMP);
            internal static readonly int LAST_SYNC_RESULT_IDX = Array.IndexOf(DatasetColumns.ALL, DatasetColumns.LAST_SYNC_RESULT);

            public static string BuildQuery(string conditions)
            {
                string query = "SELECT " + string.Join(",", ALL) + " FROM " + SQLiteLocalStorage.TABLE_DATASETS;

                if (conditions != null && conditions.Trim().Length > 0)
                {
                    query += " WHERE " + conditions;
                }

                return query;
            }

            public static string BuildInsert()
            {
                return DatasetColumns.BuildInsert(ALL);
            }

            public static string BuildInsert(string[] fieldList)
            {
                string insert = "INSERT INTO " + SQLiteLocalStorage.TABLE_DATASETS + " (" + string.Join(",", fieldList) + ") " +
                    " VALUES ( ";

                for (int i = 0; i < fieldList.Length; i++)
                {
                    insert += "@" + fieldList[i] + (i < fieldList.Length - 1 ? " , " : " ");
                }

                insert += " )";

                return insert;
            }

            public static string BuildUpdate(string[] fieldList, string conditions)
            {
                string update = "UPDATE " + SQLiteLocalStorage.TABLE_DATASETS + " SET ";

                for (int i = 0; i < fieldList.Length; i++)
                {
                    update += fieldList[i] + " = @" + fieldList[i] + (i < fieldList.Length - 1 ? " , " : " ");
                }

                if (conditions != null && conditions.Trim().Length > 0)
                {
                    update += " WHERE " + conditions;
                }

                return update;
            }

            public static string BuildDelete(string conditions)
            {
                string delete = "DELETE FROM " + SQLiteLocalStorage.TABLE_DATASETS;

                if (conditions != null && conditions.Trim().Length > 0)
                {
                    delete += " WHERE " + conditions;
                }

                return delete;
            }
        }

        static class RecordColumns
        {
            internal const string IDENTITY_ID = "identity_id";
            internal const string DATASET_NAME = "dataset_name";
            internal const string KEY = "key";
            internal const string VALUE = "value";
            internal const string SYNC_COUNT = "sync_count";
            internal const string LAST_MODIFIED_TIMESTAMP = "last_modified_timestamp";
            internal const string LAST_MODIFIED_BY = "last_modified_by";
            internal const string DEVICE_LAST_MODIFIED_TIMESTAMP = "device_last_modified_timestamp";
            internal const string MODIFIED = "modified";
            internal static readonly string[] ALL = new string[] {
                IDENTITY_ID, DATASET_NAME, KEY, VALUE, SYNC_COUNT, LAST_MODIFIED_TIMESTAMP,
                LAST_MODIFIED_BY, DEVICE_LAST_MODIFIED_TIMESTAMP, MODIFIED
            };

            internal static readonly int IDENTITY_ID_IDX = Array.IndexOf(RecordColumns.ALL, RecordColumns.IDENTITY_ID);
            internal static readonly int DATASET_NAME_IDX = Array.IndexOf(RecordColumns.ALL, RecordColumns.DATASET_NAME);
            internal static readonly int KEY_IDX = Array.IndexOf(RecordColumns.ALL, RecordColumns.KEY);
            internal static readonly int VALUE_IDX = Array.IndexOf(RecordColumns.ALL, RecordColumns.VALUE);
            internal static readonly int SYNC_COUNT_IDX = Array.IndexOf(RecordColumns.ALL, RecordColumns.SYNC_COUNT);
            internal static readonly int LAST_MODIFIED_TIMESTAMP_IDX = Array.IndexOf(RecordColumns.ALL, RecordColumns.LAST_MODIFIED_TIMESTAMP);
            internal static readonly int LAST_MODIFIED_BY_IDX = Array.IndexOf(RecordColumns.ALL, RecordColumns.LAST_MODIFIED_BY);
            internal static readonly int DEVICE_LAST_MODIFIED_TIMESTAMP_IDX = Array.IndexOf(RecordColumns.ALL, RecordColumns.DEVICE_LAST_MODIFIED_TIMESTAMP);
            internal static readonly int MODIFIED_IDX = Array.IndexOf(RecordColumns.ALL, RecordColumns.MODIFIED);

            public static string BuildQuery(string conditions)
            {
                string query = "SELECT " + string.Join(",", ALL) + " FROM " + SQLiteLocalStorage.TABLE_RECORDS;

                if (conditions != null && conditions.Trim().Length > 0)
                {
                    query += " WHERE " + conditions;
                }
                return query;
            }

            public static string BuildInsert()
            {
                return RecordColumns.BuildInsert(ALL);
            }

            public static string BuildInsert(string[] fieldList)
            {
                string insert = "INSERT INTO " + SQLiteLocalStorage.TABLE_RECORDS + " (" + string.Join(" ,", fieldList) + " ) " +
                    " VALUES ( ";

                for (int i = 0; i < fieldList.Length; i++)
                {
                    insert += "@" + fieldList[i] + (i < fieldList.Length - 1 ? " , " : " ");
                }

                insert += " )";

                return insert;
            }

            public static string BuildUpdate(string[] fieldList, string conditions)
            {
                string update = "UPDATE " + SQLiteLocalStorage.TABLE_RECORDS + " SET ";

                for (int i = 0; i < fieldList.Length; i++)
                {
                    update += fieldList[i] + " = @" + fieldList[i] + (i < fieldList.Length - 1 ? " , " : " ");
                }

                if (conditions != null && conditions.Trim().Length > 0)
                {
                    update += " WHERE " + conditions;
                }

                return update;
            }

            public static string BuildDelete(string conditions)
            {
                string delete = "DELETE FROM " + SQLiteLocalStorage.TABLE_RECORDS;

                if (conditions != null && conditions.Trim().Length > 0)
                {
                    delete += " WHERE " + conditions;
                }

                return delete;
            }
        }

        #endregion

        #region helper class
        internal class Statement
        {
            public string Query { get; set; }
            public object[] Parameters { get; set; }
        }

        #endregion

        #region helper methods

        internal static byte[] ToUtf8(string sText)
        {
            byte[] byteArray;
            int nLen = Encoding.UTF8.GetByteCount(sText) + 1;
            byteArray = new byte[nLen];
            nLen = Encoding.UTF8.GetBytes(sText, 0, sText.Length, byteArray, 0);
            byteArray[nLen] = 0;
            return byteArray;
        }

        #endregion

        #region public api's
        /// <summary>
        /// Create a dataset 
        /// </summary>
        /// <param name="identityId">Identity Id</param>
        /// <param name="datasetName">Dataset name.</param>
        public void CreateDataset(string identityId, string datasetName)
        {
            lock (sqlite_lock)
            {
                DatasetMetadata metadata = GetMetadataHelper(identityId, datasetName);

                if (metadata == null)
                {
                    string query = DatasetColumns.BuildInsert(
                        new string[]
                        {
                            DatasetColumns.IDENTITY_ID,
                            DatasetColumns.DATASET_NAME,
                            DatasetColumns.CREATION_TIMESTAMP,
                            DatasetColumns.LAST_MODIFIED_TIMESTAMP
                        });

                    CreateDatasetHelper(query, identityId, datasetName, DateTime.Now, DateTime.Now);

                }
            }
        }

        /// <summary>
        /// Retrieves the string value of a key in dataset. The value can be null
        /// when the record doesn't exist or is marked as deleted.
        /// </summary>
        /// <returns>string value of the record, or null if not present or deleted.</returns>
        /// <param name="identityId">Identity identifier.</param>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="key">record key.</param>
        public string GetValue(string identityId, string datasetName, string key)
        {
            lock (sqlite_lock)
            {
                Record record = GetRecord(identityId, datasetName, key);

                if (record == null)
                {
                    return null;
                }
                else
                {
                    return record.Value;
                }
            }
        }

        /// <summary>
        /// Puts the value of a key in dataset. If a new value is assigned to the
        /// key, the record is marked as dirty. If the value is null, then the record
        /// is marked as deleted. The changed record will be synced with remote
        /// storage.
        /// </summary>
        /// <param name="identityId">Identity identifier.</param>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="key">record key.</param>
        /// <param name="value">string value. If null, the record is marked as deleted.</param>
        public void PutValue(string identityId, string datasetName, string key, string value)
        {
            lock (sqlite_lock)
            {
                bool result = PutValueHelper(identityId, datasetName, key, value);
                if (!result)
                {
                    _logger.DebugFormat("{0}", @"Cognito Sync - SQLiteStorage - Put Value Failed");
                }
                else
                {
                    UpdateLastModifiedTimestamp(identityId, datasetName);
                }
            }
        }

        /// <summary>
        /// Retrieves a key-value map from dataset, excluding marked as deleted
        /// values.
        /// </summary>
        /// <returns>a key-value map of all but deleted values.</returns>
        /// <param name="identityId">Identity identifier.</param>
        /// <param name="datasetName">Dataset name.</param>
        public Dictionary<string, string> GetValueMap(string identityId, string datasetName)
        {
            lock (sqlite_lock)
            {
                Dictionary<string, string> values = new Dictionary<string, string>();
                List<Record> records = GetRecords(identityId, datasetName);

                foreach (Record record in records)
                {
                    if (!record.IsDeleted)
                    {
                        values.Add(record.Key, record.Value);
                    }
                }

                return values;
            }
        }


        /// <summary>
        /// Puts a key-value map into a dataset. This is optimized for batch
        /// operation. It's the preferred way to put a list of records into dataset.
        /// </summary>
        /// <param name="identityId">Identity identifier.</param>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="values">a key-value map.</param>
        public void PutAllValues(string identityId, string datasetName, IDictionary<string, string> values)
        {
            lock (sqlite_lock)
            {
                foreach (KeyValuePair<string, string> entry in values)
                {
                    PutValueHelper(identityId, datasetName, entry.Key, entry.Value);
                }
                UpdateLastModifiedTimestamp(identityId, datasetName);
            }
        }

        /// <summary>
        /// Gets a list of dataset's metadata information.
        /// </summary>
        /// <returns>a list of dataset metadata</returns>
        /// <param name="identityId">Identity identifier.</param>
        /// <exception cref="DataStorageException"></exception>
        public List<DatasetMetadata> GetDatasetMetadata(string identityId)
        {
            lock (sqlite_lock)
            {
                string query = DatasetColumns.BuildQuery(
                DatasetColumns.IDENTITY_ID + " = @whereIdentityId "
                );

                return GetDatasetMetadataHelper(query, identityId);
            }
        }

        /// <summary>
        /// Retrieves the metadata of a dataset.
        /// </summary>
        /// <returns>The dataset metadata.</returns>
        /// <param name="identityId">Identity identifier.</param>
        /// <param name="datasetName">Dataset name.</param>
        /// <exception cref="DataStorageException"></exception>
#if BCL
        [System.Security.SecuritySafeCritical]
#endif
        public DatasetMetadata GetDatasetMetadata(string identityId, string datasetName)
        {
            lock (sqlite_lock)
            {
                return GetMetadataHelper(identityId, datasetName);
            }
        }

        /// <summary>
        /// Gets a raw record from local store. If the dataset/key combo doesn't
        /// // exist, null will be returned.
        /// </summary>
        /// <returns>a Record object if found, null otherwise.</returns>
        /// <param name="identityId">Identity identifier.</param>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="key">Key for the record.</param>
        public Record GetRecord(string identityId, string datasetName, string key)
        {
            lock (sqlite_lock)
            {
                Record record = null;

                string query = RecordColumns.BuildQuery(
                    RecordColumns.IDENTITY_ID + " = @identityId AND " +
                    RecordColumns.DATASET_NAME + " = @datasetName AND " +
                    RecordColumns.KEY + " = @key "
                );
                record = GetRecordHelper(query, identityId, datasetName, key);
                return record;
            }
        }

        /// <summary>
        /// Gets a list of all records.
        /// </summary>
        /// <returns>A list of records which have been updated since lastSyncCount.</returns>
        /// <param name="identityId">Identity identifier.</param>
        /// <param name="datasetName">Dataset name.</param>
        public List<Record> GetRecords(string identityId, string datasetName)
        {
            lock (sqlite_lock)
            {
                string query =
                RecordColumns.BuildQuery(
                    RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                    RecordColumns.DATASET_NAME + " = @whereDatasetName "
                );

                return GetRecordsHelper(query, identityId, datasetName);
            }
        }

        /// <summary>
        /// Puts a list of raw records into dataset.
        /// </summary>
        /// <param name="identityId">Identity identifier.</param>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="records">A list of Records.</param>
        public void PutRecords(string identityId, string datasetName, List<Record> records)
        {
            lock (sqlite_lock)
            {
                foreach (Record record in records)
                {
                    this.UpdateOrInsertRecord(identityId, datasetName, record);
                }
            }
        }

        /// <summary>
        /// Puts a list of raw records into that dataset if 
        /// the local version hasn't changed (to be used in 
        /// synchronizations). 
        /// </summary> 
        /// <param name="identityId">Identity id.</param>
        /// <param name="datasetName">Dataset name.</param>
        /// /// <param name="records">A list of remote records to compare with</param>
        /// <param name="localRecords">A list of records to check for changes.</param>
        public void ConditionallyPutRecords(String identityId, String datasetName, List<Record> records, List<Record> localRecords)
        {
            /*
             * Grab an instance of the record from the local store with the remote change's 
             * key and the snapshot version.
             * 1) If both are null the remote change is new and we should save. 
             * 2) If both exist but the values and sync counts have changed, 
             *    it has changed locally and we shouldn't overwrite with the remote changes, 
             *    which will still exist in remote. 
             * 3) If both exist and the values have not changed, we should save the remote change.	
             * 4) If the current check exists but it wasn't in the snapshot, we should save.	
             */

            Dictionary<string, Record> localRecordMap = new Dictionary<string, Record>();

            foreach (Record record in localRecords)
            {
                localRecordMap[record.Key] = record;
            }

            foreach (Record record in records)
            {
                Record databaseRecord = this.GetRecord(identityId, datasetName, record.Key);
                Record oldDatabaseRecord = localRecordMap[record.Key];
                if (databaseRecord != null && oldDatabaseRecord != null
                        && (!StringUtils.Equals(databaseRecord.Value, oldDatabaseRecord.Value)
                        || databaseRecord.SyncCount != oldDatabaseRecord.SyncCount
                        || !StringUtils.Equals(databaseRecord.LastModifiedBy, oldDatabaseRecord.LastModifiedBy)))
                {
                    continue;
                }
                UpdateOrInsertRecord(identityId, datasetName, record);
            }
        }

        /// <summary>
        /// Deletes a dataset. All the records associated with dataset are cleared and 
        /// dataset is marked as deleted for future sync.
        /// </summary>
        /// <param name="identityId">Identity identifier.</param>
        /// <param name="datasetName">Dataset name.</param>
        /// <exception cref="DatasetNotFoundException"></exception>
        public void DeleteDataset(string identityId, string datasetName)
        {
            DeleteDataset(identityId, datasetName, null);
        }


        private void DeleteDataset(string identityId, string datasetName, List<Statement> additionalStatements)
        {
            lock (sqlite_lock)
            {
                string deleteRecordsQuery =
                RecordColumns.BuildDelete(
                    RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                    RecordColumns.DATASET_NAME + " = @whereDatasetName "
                );

                Statement s1 = new Statement
                {
                    Query = deleteRecordsQuery,
                    Parameters = new string[] { identityId, datasetName }
                };

                string deleteDatasetQuery =
                DatasetColumns.BuildUpdate(
                    new string[] {
                        DatasetColumns.LAST_MODIFIED_TIMESTAMP,
                        DatasetColumns.LAST_SYNC_COUNT
                        },
                    DatasetColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                    DatasetColumns.DATASET_NAME + " = @whereDatasetName "
                );

                Statement s2 = new Statement
                {
                    Query = deleteDatasetQuery,
                    Parameters = new object[] { DateTime.Now, -1, identityId, datasetName }
                };

                List<Statement> statementsToExecute = new List<Statement>() { s1, s2 };

                if (additionalStatements != null)
                {
                    statementsToExecute.AddRange(additionalStatements);
                }

                ExecuteMultipleHelper(statementsToExecute);
            }
        }

        /// <summary>
        /// This is different from <see cref="DeleteDataset(String,String)"/>. Not only does it
        /// clears all records in the dataset, it also remove it from metadata table.
        /// It won't be visible in <see cref="GetDatasetMetadata(String,String)"/>.
        /// </summary>
        /// <param name="identityId">Identity identifier.</param>
        /// <param name="datasetName">Dataset name.</param>
        public void PurgeDataset(string identityId, string datasetName)
        {
            lock (sqlite_lock)
            {
                string query = DatasetColumns.BuildDelete(
                    DatasetColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                    DatasetColumns.DATASET_NAME + " = @whereDatasetName "
                );

                Statement s1 = new Statement
                {
                    Query = query,
                    Parameters = new string[] { identityId, datasetName }
                };

                DeleteDataset(identityId, datasetName, new List<Statement>() { s1 });
            }
        }

        /// <summary>
        /// Retrieves the last sync count. This sync count is a counter that
        /// represents when the last sync happened. The counter should be updated on
        /// a successful sync.
        /// </summary>
        /// <returns>The last sync count.</returns>
        /// <param name="identityId">Identity identifier.</param>
        /// <param name="datasetName">Dataset name.</param>
        public long GetLastSyncCount(string identityId, string datasetName)
        {
            lock (sqlite_lock)
            {
                string query = DatasetColumns.BuildQuery(
                    DatasetColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                    DatasetColumns.DATASET_NAME + " = @whereDatasetName "
                );

                return GetLastSyncCountHelper(query, identityId, datasetName);
            }
        }

        /// <summary>
        /// Retrieves a list of locally modified records since last successful sync
        /// operation.
        /// </summary>
        /// <returns>a list of locally modified records</returns>
        /// <param name="identityId">Identity identifier.</param>
        /// <param name="datasetName">Dataset name.</param>
        public List<Record> GetModifiedRecords(string identityId, string datasetName)
        {
            lock (sqlite_lock)
            {
                string query =
                    RecordColumns.BuildQuery(
                        RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                        RecordColumns.DATASET_NAME + " = @whereDatasetName AND " +
                        RecordColumns.MODIFIED + " = @whereModified "
                );
                return GetModifiedRecordsHelper(query, identityId, datasetName, 1); ;
            }
        }

        /// <summary>
        /// Updates the last sync count after successful sync with the remote data
        /// store.
        /// </summary>
        /// <param name="identityId">Identity identifier.</param>
        /// <param name="datasetName">Dataset name.</param>
        /// <param name="lastSyncCount">Last sync count.</param>
        public void UpdateLastSyncCount(string identityId, string datasetName, long lastSyncCount)
        {
            lock (sqlite_lock)
            {
                string query = DatasetColumns.BuildUpdate(
                    new string[] {
                        DatasetColumns.LAST_SYNC_COUNT,
                        DatasetColumns.LAST_SYNC_TIMESTAMP
                    },
                    RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                    RecordColumns.DATASET_NAME + " = @whereDatasetName "
                );
                UpdateLastSyncCountHelper(query, lastSyncCount, DateTime.Now, identityId, datasetName);
            }
        }

        /// <summary>
        /// Wipes all locally cached data including dataset metadata and records. All
        /// opened dataset handler should not perform further operations to avoid
        /// inconsistent state.
        /// </summary>
        public void WipeData()
        {
            lock (sqlite_lock)
            {
                string query1 = DatasetColumns.BuildDelete(null);
                string query2 = RecordColumns.BuildDelete(null);

                ExecuteMultipleHelper(new List<Statement>() { new Statement { Query = query1 }, new Statement { Query = query2 } });
            }
        }

        /// <summary>
        /// Reparents all datasets from old identity id to a new one.
        /// </summary>
        /// <param name="oldIdentityId">Old identity identifier.</param>
        /// <param name="newIdentityId">New identity identifier.</param>
        public void ChangeIdentityId(string oldIdentityId, string newIdentityId)
        {
            _logger.DebugFormat("Reparenting datasets from {0} to {1}", oldIdentityId, newIdentityId);
            lock (sqlite_lock)
            {

                List<Statement> statements = new List<Statement>();
                // if oldIdentityId is unknown, aka the dataset is created prior to
                // having a cognito id, just reparent datasets from unknown to
                // newIdentityId
                if (DatasetUtils.UNKNOWN_IDENTITY_ID == oldIdentityId)
                {

                    HashSet<string> commonDatasetNames = GetCommonDatasetNames(oldIdentityId, newIdentityId);

                    // append UNKNOWN to the name of all non unique datasets
                    foreach (String oldDatasetName in commonDatasetNames)
                    {
                        string updateDatasetQuery = "UPDATE " + TABLE_DATASETS
                              + " SET " + DatasetColumns.DATASET_NAME + " = @" + DatasetColumns.DATASET_NAME
                              + " WHERE " + DatasetColumns.IDENTITY_ID + " = @" + DatasetColumns.IDENTITY_ID
                              + " AND " + DatasetColumns.DATASET_NAME + " = @old" + DatasetColumns.DATASET_NAME + " ";

                        string timestamp = AWSSDKUtils.ConvertToUnixEpochMilliSeconds(DateTime.UtcNow).ToString(CultureInfo.InvariantCulture);

                        Statement updateDatasetStatement = new Statement()
                        {
                            Query = updateDatasetQuery,
                            Parameters = new string[] { oldDatasetName + "." + oldIdentityId + "-" + timestamp, oldIdentityId, oldDatasetName }
                        };

                        statements.Add(updateDatasetStatement);

                        string updateRecordsQuery = "UPDATE " + TABLE_RECORDS
                            + " SET " + RecordColumns.DATASET_NAME + " = @" + RecordColumns.DATASET_NAME
                            + " WHERE " + RecordColumns.IDENTITY_ID + " = @" + RecordColumns.IDENTITY_ID
                            + " AND " + RecordColumns.DATASET_NAME + " = @old" + RecordColumns.DATASET_NAME + " ";

                        Statement updateRecordsStatement = new Statement()
                        {
                            Query = updateRecordsQuery,
                            Parameters = new string[] { oldDatasetName + "." + oldIdentityId + "-" + timestamp, oldIdentityId, oldDatasetName }
                        };
                        statements.Add(updateRecordsStatement);

                    }

                    string updateIdentityDatasetQuery = DatasetColumns.BuildUpdate(
                            new string[] { DatasetColumns.IDENTITY_ID },
                            DatasetColumns.IDENTITY_ID + " = @oldIdentityId "
                        );

                    Statement UpdateIdentityDatasetStatement = new Statement()
                    {
                        Query = updateIdentityDatasetQuery,
                        Parameters = new string[] { newIdentityId, oldIdentityId }
                    };

                    statements.Add(UpdateIdentityDatasetStatement);

                    string updateRecordsIdentityQuery = RecordColumns.BuildUpdate(
                            new string[] { RecordColumns.IDENTITY_ID },
                            RecordColumns.IDENTITY_ID + " = @oldIdentityId "
                        );

                    Statement UpdateIdentityRecordsStatement = new Statement()
                    {
                        Query = updateRecordsIdentityQuery,
                        Parameters = new string[] { newIdentityId, oldIdentityId }
                    };

                    statements.Add(UpdateIdentityRecordsStatement);
                }
                else
                {
                    // 1. copy oldIdentityId/dataset to newIdentityId/dataset
                    // datasets table
                    string copyDatasetToNewIdentity = "INSERT INTO " + TABLE_DATASETS + "("
                        + DatasetColumns.IDENTITY_ID + ","
                        + DatasetColumns.DATASET_NAME + ","
                        + DatasetColumns.CREATION_TIMESTAMP + ","
                        + DatasetColumns.STORAGE_SIZE_BYTES + ","
                        + DatasetColumns.RECORD_COUNT
                        // last sync count is reset to default 0
                        + ")"
                        + " SELECT "
                        + "'" + newIdentityId + "'," // assign new owner
                        + DatasetColumns.DATASET_NAME + ","
                        + DatasetColumns.CREATION_TIMESTAMP + ","
                        + DatasetColumns.STORAGE_SIZE_BYTES + ","
                        + DatasetColumns.RECORD_COUNT
                        + " FROM " + TABLE_DATASETS
                        + " WHERE " + DatasetColumns.IDENTITY_ID + " = @" + DatasetColumns.IDENTITY_ID + " ";

                    statements.Add(new Statement
                    {
                        Query = copyDatasetToNewIdentity,
                        Parameters = new string[] { oldIdentityId }
                    });

                    // records table
                    string copyRecordsToNewIdentity = "INSERT INTO " + TABLE_RECORDS + "("
                        + RecordColumns.IDENTITY_ID + ","
                        + RecordColumns.DATASET_NAME + ","
                        + RecordColumns.KEY + ","
                        + RecordColumns.VALUE + ","
                        // sync count is resset to default 0
                        + RecordColumns.LAST_MODIFIED_TIMESTAMP + ","
                        + RecordColumns.LAST_MODIFIED_BY + ","
                        + RecordColumns.DEVICE_LAST_MODIFIED_TIMESTAMP
                        // modified is reset to default 1 (dirty)
                        + ")"
                        + " SELECT "
                        + "'" + newIdentityId + "'," // assign new owner
                        + RecordColumns.DATASET_NAME + ","
                        + RecordColumns.KEY + ","
                        + RecordColumns.VALUE + ","
                        + RecordColumns.LAST_MODIFIED_TIMESTAMP + ","
                        + RecordColumns.LAST_MODIFIED_BY + ","
                        + RecordColumns.DEVICE_LAST_MODIFIED_TIMESTAMP
                        + " FROM " + TABLE_RECORDS
                        + " WHERE " + RecordColumns.IDENTITY_ID + " = @" + RecordColumns.IDENTITY_ID + " ";

                    statements.Add(new Statement
                    {
                        Query = copyRecordsToNewIdentity,
                        Parameters = new string[] { oldIdentityId }
                    });


                    // 2. rename oldIdentityId/dataset to
                    // newIdentityId/dataset.oldIdentityId
                    // datasets table
                    string updateDatasetToNewIdentityQuery = "UPDATE " + TABLE_DATASETS
                        + " SET "
                        + DatasetColumns.IDENTITY_ID + " = '" + newIdentityId + "', "
                        + DatasetColumns.DATASET_NAME + " = "
                        + DatasetColumns.DATASET_NAME + " || '." + oldIdentityId + "'"
                        + " WHERE " + DatasetColumns.IDENTITY_ID + " = @" + DatasetColumns.IDENTITY_ID + " ";

                    statements.Add(new Statement
                    {
                        Query = updateDatasetToNewIdentityQuery,
                        Parameters = new string[] { oldIdentityId }
                    });

                    // records table
                    string updateRecordsToNewIdentityQuery = "UPDATE " + TABLE_RECORDS
                        + " SET "
                        + RecordColumns.IDENTITY_ID + " = '" + newIdentityId + "', "
                        + RecordColumns.DATASET_NAME + " = "
                        + RecordColumns.DATASET_NAME + " || '." + oldIdentityId + "'"
                        + " WHERE " + RecordColumns.IDENTITY_ID + " = @" + RecordColumns.IDENTITY_ID + " ";

                    statements.Add(new Statement
                    {
                        Query = updateRecordsToNewIdentityQuery,
                        Parameters = new string[] { oldIdentityId }
                    });
                }

                //execute all of them
                ExecuteMultipleHelper(statements);

            }

        }

        /// <summary>
        /// Updates local dataset metadata
        /// </summary>
        /// <param name="identityId">Identity identifier.</param>
        /// <param name="datasetMetadata">Dataset metadata.</param>
        public void UpdateDatasetMetadata(string identityId, List<DatasetMetadata> datasetMetadata)
        {
            lock (sqlite_lock)
            {
                foreach (DatasetMetadata metadata in datasetMetadata)
                {
                    if (!UpdateDatasetMetadataInternal(identityId, metadata))
                    {
                        string message = string.Format("Failure to update dataset metadata with Identity Id {0}", identityId);
                        _logger.Error(new Exception(message), message);
                    }
                }
            }
        }

        /// <summary>
        /// Updates the last modified timestamp
        /// </summary>
        /// <param name="identityId">Identity Identifier.</param>
        /// <param name="datasetName">Dataset name.</param>
        public void UpdateLastModifiedTimestamp(string identityId, string datasetName)
        {
            lock (sqlite_lock)
            {
                string query =
                    DatasetColumns.BuildUpdate(
                    new string[] { DatasetColumns.LAST_MODIFIED_TIMESTAMP },
                    DatasetColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                    DatasetColumns.DATASET_NAME + " = @whereDatasetName "
                );
                UpdateLastModifiedTimestampHelper(query, DateTime.Now, identityId, datasetName);
            }
        }

        #endregion

        #region private methods

#if BCL
        [System.Security.SecuritySafeCritical]
#endif
        private bool UpdateDatasetMetadataInternal(string identityId, DatasetMetadata metadata)
        {
            lock (sqlite_lock)
            {
                DatasetMetadata local = GetMetadataHelper(identityId, metadata.DatasetName);

                if (local == null)
                {
                    string updateDatasetMetadataQuery = DatasetColumns.BuildInsert();
                    ExecuteMultipleHelper(new List<Statement>(){
                            new Statement{
                                Query = updateDatasetMetadataQuery,
                                Parameters = new object[]{identityId,metadata.DatasetName,metadata.CreationDate,metadata.LastModifiedDate,metadata.RecordCount,metadata.StorageSizeBytes,0,0,null}
                            }
                        });
                }
                else
                {
                    string updateDatasetMetadataQuery = DatasetColumns.BuildUpdate(
                        new string[] {
                                DatasetColumns.DATASET_NAME,
                                DatasetColumns.CREATION_TIMESTAMP,
                                DatasetColumns.LAST_MODIFIED_TIMESTAMP,
                                DatasetColumns.LAST_MODIFIED_BY,
                                DatasetColumns.RECORD_COUNT,
                                DatasetColumns.STORAGE_SIZE_BYTES
                            },
                        DatasetColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                        DatasetColumns.DATASET_NAME + " = @whereDatasetName "
                    );
                    ExecuteMultipleHelper(new List<Statement>(){
                            new Statement{
                                Query = updateDatasetMetadataQuery,
                                Parameters = new object[]{metadata.DatasetName,metadata.CreationDate,metadata.LastModifiedDate,metadata.LastModifiedBy,metadata.RecordCount,metadata.StorageSizeBytes,identityId,metadata.DatasetName}
                            }
                        });
                }
                return true;

            }
        }

        private bool PutValueHelper(string identityId, string datasetName, string key, string value)
        {
            lock (sqlite_lock)
            {
                Record record = GetRecord(identityId, datasetName, key);

                if (record != null && string.Equals(record.Value, value))
                {
                    return true;
                }

                if (record == null)
                {
                    string insertRecord = RecordColumns.BuildInsert();
                    ExecuteMultipleHelper(new List<Statement>{new Statement{
                    Query = insertRecord,
                    Parameters = new object[]{identityId,datasetName,key,value,0,DateTime.Now,string.Empty,DateTime.Now,1}
                    }});
                    return true;
                }
                else
                {
                    string insertRecord =
                    RecordColumns.BuildUpdate(
                        new string[] {
                                RecordColumns.IDENTITY_ID, RecordColumns.DATASET_NAME, RecordColumns.KEY,
                                RecordColumns.VALUE, RecordColumns.MODIFIED, RecordColumns.SYNC_COUNT,
                                RecordColumns.DEVICE_LAST_MODIFIED_TIMESTAMP
                            },
                        RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                        RecordColumns.DATASET_NAME + " = @whereDatasetName AND " +
                        RecordColumns.KEY + " = @whereKey "
                    );
                    ExecuteMultipleHelper(new List<Statement>{new Statement{
                    Query = insertRecord,
                    Parameters = new object[]{identityId,datasetName,key,value,1,record.SyncCount,DateTime.Now,identityId,datasetName,key}
                    }});
                    return true;
                }
            }
        }

        private HashSet<string> GetCommonDatasetNames(string oldIdentityId, string newIdentityId)
        {
            HashSet<string> newNameSet = new HashSet<string>();
            HashSet<string> oldNameSet = new HashSet<string>();
            if (oldIdentityId != null && newIdentityId != null)
            {
                List<DatasetMetadata> newDatasets = GetDatasetMetadata(newIdentityId);
                List<DatasetMetadata> oldDatasets = GetDatasetMetadata(oldIdentityId);
                foreach (DatasetMetadata oldMetaData in oldDatasets)
                {
                    oldNameSet.Add(oldMetaData.DatasetName);
                }
                foreach (DatasetMetadata newMetaData in newDatasets)
                {
                    newNameSet.Add(newMetaData.DatasetName);
                }
                oldNameSet.IntersectWith(newNameSet);
            }
            return oldNameSet;
        }
        #endregion
    }
}

