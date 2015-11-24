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
using Amazon.Util;
using System.Globalization;
#if UNITY
using Amazon.Util.Storage.Internal;
#endif
#if UNITY
using UnityEngine;
#endif
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

#if UNITY
        public SQLiteLocalStorage(string path)
        {
            _logger = Logger.GetLogger(this.GetType());
            this.dataPath = path;
            this.SetupDatabase();
        }

        ~SQLiteLocalStorage()
        {
            if (db != null)
                db.CloseDatabase();
        }
#else
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

#if UNITY
        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //TODO: Do we want this? Research why we are closing in destructor instead of dispose method.
                //db.CloseDatabase();
            }
        }
#endif

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


#if UNITY
        public  void CreateDataset(string identityId, string datasetName)
        {
            lock (sqlite_lock)
            {
                DatasetMetadata metadata = this.GetMetadataInternal(identityId, datasetName);

                if (metadata == null)
                {
                    SQLiteStatement stmt = null;
                    try
                    {
                        string query = DatasetColumns.BuildInsert(
                        new string[] {
                        DatasetColumns.IDENTITY_ID,
                        DatasetColumns.DATASET_NAME,
                        DatasetColumns.CREATION_TIMESTAMP,
                        DatasetColumns.LAST_MODIFIED_TIMESTAMP
                       });

                        stmt = db.Prepare(query);
                        stmt.BindText(1, identityId);
                        stmt.BindText(2, datasetName);
                        stmt.BindDateTime(3, DateTime.Now);
                        stmt.BindDateTime(4, DateTime.Now);

                        stmt.Step();

                    }
                    finally
                    {
                        stmt.FinalizeStm();
                    }
                }
            }
        }
#else
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
#endif

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
#if UNITY       
                bool result = PutValueInternal(identityId, datasetName, key, value);
#else
                bool result = PutValueHelper(identityId, datasetName, key, value);
#endif
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
#if UNITY
                    PutValueInternal(identityId, datasetName, entry.Key, entry.Value);
#else
                    PutValueHelper(identityId, datasetName, entry.Key, entry.Value);
#endif
                }
                UpdateLastModifiedTimestamp(identityId, datasetName);
            }
        }


#if UNITY
        public List<DatasetMetadata> GetDatasetMetadata(string identityId)
        {
            lock (sqlite_lock)
            {
                List<DatasetMetadata> datasets = new List<DatasetMetadata>();
                SQLiteStatement stmt = null;
                try
                {


                    stmt = db.Prepare(DatasetColumns.BuildQuery(
                    DatasetColumns.IDENTITY_ID + " = @whereIdentityId"
                    ));

                    stmt.BindText(1, identityId);

                    while (stmt.Read())
                    {
                        datasets.Add(this.SqliteStmtToDatasetMetadata(stmt));
                    }

                }
                finally
                {
                    stmt.FinalizeStm();
                }
                return datasets;
            }
        }
#else
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
#endif

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
#if UNITY
                return GetMetadataInternal(identityId, datasetName);
#else
                return GetMetadataHelper(identityId, datasetName);
#endif
            }
        }

#if UNITY
        public  Record GetRecord(string identityId, string datasetName, string key)
        {
            lock (sqlite_lock)
            {

                Record record = null;
                SQLiteStatement stmt = null;
                try
                {


                    stmt = db.Prepare(RecordColumns.BuildQuery(
                    RecordColumns.IDENTITY_ID + " = @identityId AND " +
                        RecordColumns.DATASET_NAME + " = @datasetName AND " +
                        RecordColumns.KEY + " = @key"
                    ));

                    stmt.BindText(1, identityId);
                    stmt.BindText(2, datasetName);
                    stmt.BindText(3, key);

                    if (stmt.Read())
                    {
                        record = this.SqliteStmtToRecord(stmt);
                    }
                }
                finally
                {
                    stmt.FinalizeStm();
                }
                return record;
            }
        }
#else
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
#endif

#if UNITY
        public  List<Record> GetRecords(string identityId, string datasetName)
        {
            lock (sqlite_lock)
            {

                List<Record> records = new List<Record>();

                SQLiteStatement stmt = null;
                try
                {

                    stmt = db.Prepare(
                    RecordColumns.BuildQuery(
                        RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                        RecordColumns.DATASET_NAME + " = @whereDatasetName"
                    ));

                    stmt.BindText(1, identityId);
                    stmt.BindText(2, datasetName);

                    while (stmt.Read())
                    {
                        records.Add(this.SqliteStmtToRecord(stmt));
                    }
                }
                finally
                {
                    stmt.FinalizeStm();
                }
                return records;
            }
        }
#else
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
#endif

        public  void PutRecords(string identityId, string datasetName, List<Record> records)
        {
            // TODO: Make sure this lock is desired. Was there in unity but not in 45
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

#if UNITY
        public  void DeleteDataset(string identityId, string datasetName)
        {
            lock (sqlite_lock)
            {
                SQLiteStatement stmt = null;
                try
                {

                    stmt = db.Prepare(
                    RecordColumns.BuildDelete(
                        RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                        RecordColumns.DATASET_NAME + " = @whereDatasetName"
                    ));

                    stmt.BindText(1, identityId);
                    stmt.BindText(2, datasetName);
                    stmt.Step();

                    stmt.FinalizeStm();


                    stmt = db.Prepare(
                    DatasetColumns.BuildUpdate(
                        new string[] {
                    DatasetColumns.LAST_MODIFIED_TIMESTAMP,
                    DatasetColumns.LAST_SYNC_COUNT
                },
                        DatasetColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                        DatasetColumns.DATASET_NAME + " = @whereDatasetName"
                    ));
                    stmt.BindDateTime(1, DateTime.Now);
                    stmt.BindInt(2, -1);
                    stmt.BindText(3, identityId);
                    stmt.BindText(4, datasetName);

                    stmt.Step();

                }
                finally
                {
                    stmt.FinalizeStm();
                }

            }
        }
#else
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
#endif

#if UNITY
        public void PurgeDataset(string identityId, string datasetName)
        {
            lock (sqlite_lock)
            {
                this.DeleteDataset(identityId, datasetName);
                SQLiteStatement stmt = null;
                try
                {

                    stmt = db.Prepare(
                    DatasetColumns.BuildDelete(
                        DatasetColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                        DatasetColumns.DATASET_NAME + " = @whereDatasetName"
                    ));

                    stmt.BindText(1, identityId);
                    stmt.BindText(2, datasetName);


                    stmt.Step();

                }
                finally
                {
                    stmt.FinalizeStm();
                }
            }
        }
#else
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
#endif

#if UNITY
        public  long GetLastSyncCount(string identityId, string datasetName)
        {
            long lastSyncCount = 0;
            lock (sqlite_lock)
            {
                SQLiteStatement stmt = null;
                try
                {

                    stmt = db.Prepare(
                DatasetColumns.BuildQuery(
                    DatasetColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                        DatasetColumns.DATASET_NAME + " = @whereDatasetName"
                    ));

                    stmt.BindText(1, identityId);
                    stmt.BindText(2, datasetName);



                    if (stmt.Read())
                    {
                        lastSyncCount = stmt.Fields[DatasetColumns.LAST_SYNC_COUNT].INTEGER;
                    }

                }
                finally
                {
                    stmt.FinalizeStm();
                }
                return lastSyncCount;
            }
        }
#else
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
#endif

#if UNITY
        public List<Record> GetModifiedRecords(string identityId, string datasetName)
        {
            lock (sqlite_lock)
            {

                List<Record> records = new List<Record>();

                SQLiteStatement stmt = null;
                try
                {
                    stmt = db.Prepare(
                        RecordColumns.BuildQuery(
                            RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                            RecordColumns.DATASET_NAME + " = @whereDatasetName AND " +
                            RecordColumns.MODIFIED + " = @whereModified"
                    ));

                    stmt.BindText(1, identityId);
                    stmt.BindText(2, datasetName);
                    stmt.BindInt(3, 1);


                    while (stmt.Read())
                    {
                        records.Add(this.SqliteStmtToRecord(stmt));
                    }

                }
                finally
                {
                    stmt.FinalizeStm();
                }
                return records;
            }
        }
#else
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
#endif

#if UNITY 
        public  void UpdateLastSyncCount(string identityId, string datasetName, long lastSyncCount)
        {
            lock (sqlite_lock)
            {

                SQLiteStatement stmt = null;
                try
                {

                    stmt = db.Prepare(
                DatasetColumns.BuildUpdate(
                    new string[] {
                    DatasetColumns.LAST_SYNC_COUNT,
                    DatasetColumns.LAST_SYNC_TIMESTAMP
                },
                    RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                        RecordColumns.DATASET_NAME + " = @whereDatasetName"
                    ));

                    stmt.BindInt(1, lastSyncCount);
                    stmt.BindDateTime(2, DateTime.Now);
                    stmt.BindText(3, identityId);
                    stmt.BindText(4, datasetName);

                    stmt.Step();
                }
                finally
                {
                    stmt.FinalizeStm();
                }
            }
        }
#else
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
#endif

#if UNITY
        public  void WipeData()
        {
            lock (sqlite_lock)
            {
                db.Exec(DatasetColumns.BuildDelete(null));
                db.Exec(RecordColumns.BuildDelete(null));
            }
        }
#else
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
#endif

        
#if UNITY 
        public  void ChangeIdentityId(string oldIdentityId, string newIdentityId)
        {
            Debug.Log("Reparenting datasets from " + oldIdentityId + " to " + newIdentityId);
            GetCommonDatasetNames(oldIdentityId, newIdentityId);
            lock (sqlite_lock)
            {
                SQLiteStatement stmt = null;
                try
                {
                    // if oldIdentityId is unknown, aka the dataset is created prior to
                    // having a cognito id, just reparent datasets from unknown to
                    // newIdentityId
                    if (DatasetUtils.UNKNOWN_IDENTITY_ID == oldIdentityId)
                    {

                        HashSet<string> commonDatasetNames = GetCommonDatasetNames(oldIdentityId, newIdentityId);

                        // append UNKNOWN to the name of all non unique datasets
                        foreach (String oldDatasetName in commonDatasetNames)
                        {

                            stmt = db.Prepare("UPDATE " + TABLE_DATASETS
                                  + " SET " + DatasetColumns.DATASET_NAME + " = ?"
                                  + " WHERE " + DatasetColumns.IDENTITY_ID + " = ?"
                                  + " AND " + DatasetColumns.DATASET_NAME + " = ?"
                            );

                            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                            string timestamp = ((DateTime.UtcNow - epoch).TotalSeconds).ToString();

                            stmt.BindText(1, oldDatasetName + "." + oldIdentityId + "-" + timestamp);
                            stmt.BindText(2, oldIdentityId);
                            stmt.BindText(3, oldDatasetName);

                            stmt.Step();

                            stmt.FinalizeStm();

                            stmt = db.Prepare("UPDATE " + TABLE_RECORDS
                                + " SET " + RecordColumns.DATASET_NAME + " = ?"
                                + " WHERE " + RecordColumns.IDENTITY_ID + " = ?"
                                + " AND " + RecordColumns.DATASET_NAME + " = ?"
                            );

                            stmt.BindText(1, oldDatasetName + "." + oldIdentityId + "-" + timestamp);
                            stmt.BindText(2, oldIdentityId);
                            stmt.BindText(3, oldDatasetName);

                            stmt.Step();

                            stmt.FinalizeStm();
                        }

                        stmt = db.Prepare(
                            DatasetColumns.BuildUpdate(
                                new string[] { DatasetColumns.IDENTITY_ID },
                                DatasetColumns.IDENTITY_ID + " = ?"
                            )
                        );

                        stmt.BindText(1, newIdentityId);
                        stmt.BindText(2, oldIdentityId);

                        stmt.Step();

                        stmt.FinalizeStm();


                        stmt = db.Prepare(
                            RecordColumns.BuildUpdate(
                                new string[] { RecordColumns.IDENTITY_ID },
                                RecordColumns.IDENTITY_ID + " = ?"
                            )
                        );


                        stmt.BindText(1, newIdentityId);
                        stmt.BindText(2, oldIdentityId);

                        stmt.Step();

                    }
                    else
                    {
                        // 1. copy oldIdentityId/dataset to newIdentityId/dataset
                        // datasets table
                        stmt = db.Prepare("INSERT INTO " + TABLE_DATASETS + "("
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
                            + " WHERE " + DatasetColumns.IDENTITY_ID + " = ?"
                        );

                        stmt.BindText(1, oldIdentityId);

                        stmt.Step();
                        stmt.FinalizeStm();

                        // records table
                        stmt = db.Prepare("INSERT INTO " + TABLE_RECORDS + "("
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
                            + " WHERE " + RecordColumns.IDENTITY_ID + " = ?"
                        );

                        stmt.BindText(1, oldIdentityId);

                        stmt.Step();
                        stmt.FinalizeStm();

                        // 2. rename oldIdentityId/dataset to
                        // newIdentityId/dataset.oldIdentityId
                        // datasets table
                        stmt = db.Prepare("UPDATE " + TABLE_DATASETS
                            + " SET "
                            + DatasetColumns.IDENTITY_ID + " = '" + newIdentityId + "', "
                            + DatasetColumns.DATASET_NAME + " = "
                            + DatasetColumns.DATASET_NAME + " || '." + oldIdentityId + "'"
                            + " WHERE " + DatasetColumns.IDENTITY_ID + " = ?"
                        );

                        stmt.BindText(1, oldIdentityId);

                        stmt.Step();
                        stmt.FinalizeStm();

                        // records table
                        stmt = db.Prepare("UPDATE " + TABLE_RECORDS
                            + " SET "
                            + RecordColumns.IDENTITY_ID + " = '" + newIdentityId + "', "
                            + RecordColumns.DATASET_NAME + " = "
                            + RecordColumns.DATASET_NAME + " || '." + oldIdentityId + "'"
                            + " WHERE " + RecordColumns.IDENTITY_ID + " = ?"
                        );

                        stmt.BindText(1, oldIdentityId);

                        stmt.Step();
                    }
                }
                finally
                {
                    stmt.FinalizeStm();
                }
            }

        }
#else
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
#endif
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
                        // TODO: Log error while updating metadata
                    }
                }
            }
        }
        
#if UNITY
        public void UpdateLastModifiedTimestamp(string identityId, string datasetName)
        {
            lock (sqlite_lock)
            {
                SQLiteStatement stmt = null;
                try
                {
                    stmt = db.Prepare(
                        DatasetColumns.BuildUpdate(
                        new string[] { DatasetColumns.LAST_MODIFIED_TIMESTAMP },
                        DatasetColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                        DatasetColumns.DATASET_NAME + " = @whereDatasetName"
                    ));

                    stmt.BindDateTime(1, DateTime.Now);
                    stmt.BindText(2, identityId);
                    stmt.BindText(3, datasetName);
                    stmt.Step();
                }
                finally
                {
                    stmt.FinalizeStm();
                }

            }
        }
#else
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
#endif

        #endregion

        #region private methods

#if BCL
        [System.Security.SecuritySafeCritical]
#endif
#if UNITY
        private bool UpdateDatasetMetadataInternal(string identityId, DatasetMetadata metadata)
        {
            lock (sqlite_lock)
            {
                DatasetMetadata local = this.GetMetadataInternal(identityId, metadata.DatasetName);
                SQLiteStatement stmt = null;
                try
                {

                    if (local == null)
                    {
                        stmt = db.Prepare(DatasetColumns.BuildInsert());
                        stmt.BindText(1, identityId);
                        stmt.BindText(2, metadata.DatasetName);
                        stmt.BindDateTime(3, metadata.CreationDate);
                        stmt.BindDateTime(4, metadata.LastModifiedDate);
                        stmt.BindInt(5, metadata.RecordCount);
                        stmt.BindInt(6, metadata.StorageSizeBytes);
                        stmt.BindInt(7, 0);
                        stmt.BindInt(8, 0);
                        stmt.BindText(9, null);
                        stmt.Step();
                    }
                    else
                    {
                        stmt = db.Prepare(
                        DatasetColumns.BuildUpdate(
                            new string[] {
                                DatasetColumns.DATASET_NAME,
                                DatasetColumns.CREATION_TIMESTAMP,
                                DatasetColumns.LAST_MODIFIED_TIMESTAMP,
                                DatasetColumns.LAST_MODIFIED_BY,
                                DatasetColumns.RECORD_COUNT,
                                DatasetColumns.STORAGE_SIZE_BYTES
                            },
                            DatasetColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                            DatasetColumns.DATASET_NAME + " = @whereDatasetName"
                        ));

                        stmt.BindText(1, metadata.DatasetName);
                        stmt.BindDateTime(2, metadata.CreationDate);
                        stmt.BindDateTime(3, metadata.LastModifiedDate);
                        stmt.BindText(4, metadata.LastModifiedBy);

                        stmt.BindInt(5, metadata.RecordCount);
                        stmt.BindInt(6, metadata.StorageSizeBytes);

                        stmt.BindText(7, identityId);
                        stmt.BindText(8, metadata.DatasetName);
                        stmt.Step();
                    }
                    return true;
                }
                finally
                {
                    stmt.FinalizeStm();
                }
            }
        }
#else
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
#endif

#if UNITY
        private bool PutValueInternal(string identityId, string datasetName, string key, string value)
        {
            lock (sqlite_lock)
            {
                Record record = this.GetRecord(identityId, datasetName, key);

                if (record != null && string.Equals(record.Value, value))
                {
                    return true;
                }
                SQLiteStatement stmt = null;
                try
                {
                    if (record == null)
                    {
                        stmt = db.Prepare(RecordColumns.BuildInsert());
                        stmt.BindText(1, identityId);
                        stmt.BindText(2, datasetName);
                        stmt.BindText(3, key);
                        stmt.BindText(4, value);
                        stmt.BindInt(5, 0);
                        stmt.BindDateTime(6, DateTime.Now);
                        stmt.BindText(7, "");
                        stmt.BindInt(8, 0);
                        stmt.BindInt(9, 1);
                        stmt.Step();
                        return true;
                    }
                    else
                    {
                        stmt = db.Prepare(
                        RecordColumns.BuildUpdate(
                            new string[] { 
                                RecordColumns.IDENTITY_ID, RecordColumns.DATASET_NAME, RecordColumns.KEY, 
                                RecordColumns.VALUE, RecordColumns.MODIFIED, RecordColumns.SYNC_COUNT, 
                                RecordColumns.DEVICE_LAST_MODIFIED_TIMESTAMP 
                            },
                            RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                            RecordColumns.DATASET_NAME + " = @whereDatasetName AND " +
                            RecordColumns.KEY + " = @whereKey "
                        ));

                        stmt.BindText(1, identityId);
                        stmt.BindText(2, datasetName);
                        stmt.BindText(3, key);
                        stmt.BindText(4, value);
                        stmt.BindInt(5, 1);
                        stmt.BindInt(6, record.SyncCount);
                        stmt.BindDateTime(7, DateTime.Now);
                        stmt.BindText(8, identityId);
                        stmt.BindText(9, datasetName);
                        stmt.BindText(10, key);
                        stmt.Step();
                        return true;
                    }
                }
                finally
                {
                    stmt.FinalizeStm();
                }
            }
        }
#else
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
#endif
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

#if UNITY 
        internal readonly string dataPath;

        private void UpdateOrInsertRecord(string identityId, string datasetName, Record record)
        {
            lock (sqlite_lock)
            {
                SQLiteStatement stmt = null;
                try
                {
                    stmt = db.Prepare(
                    RecordColumns.BuildQuery(
                        RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                        RecordColumns.DATASET_NAME + " = @whereDatasetName AND " +
                        RecordColumns.KEY + " = @whereKey "
                    ));

                    stmt.BindText(1, identityId);
                    stmt.BindText(2, datasetName);
                    stmt.BindText(3, record.Key);
                    bool recordsFound = false;

                    while (stmt.Read())
                    {
                        recordsFound = true;
                    }
                    stmt.FinalizeStm();

                    if (recordsFound)
                    {
                        stmt = db.Prepare(
                        RecordColumns.BuildUpdate(
                            new string[] {
                            RecordColumns.VALUE,
                            RecordColumns.SYNC_COUNT,
                            RecordColumns.MODIFIED,
                            RecordColumns.LAST_MODIFIED_TIMESTAMP,
                            RecordColumns.LAST_MODIFIED_BY,
                            RecordColumns.DEVICE_LAST_MODIFIED_TIMESTAMP
                        },
                        RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                            RecordColumns.DATASET_NAME + " = @whereDatasetName AND " +
                            RecordColumns.KEY + " = @whereKey "
                        ));
                        stmt.BindText(1, record.Value);
                        stmt.BindInt(2, record.SyncCount);
                        stmt.BindInt(3, record.IsModified ? 1 : 0);
                        stmt.BindDateTime(4, record.LastModifiedDate);
                        stmt.BindText(5, record.LastModifiedBy);
                        stmt.BindDateTime(6, record.DeviceLastModifiedDate);
                        stmt.BindText(7, identityId);
                        stmt.BindText(8, datasetName);
                        stmt.BindText(9, record.Key);
                        stmt.Step();
                    }
                    else
                    {
                        stmt = db.Prepare(RecordColumns.BuildInsert());
                        stmt.BindText(1, identityId);
                        stmt.BindText(2, datasetName);
                        stmt.BindText(3, record.Key);
                        stmt.BindText(4, record.Value);
                        stmt.BindInt(5, record.SyncCount);
                        stmt.BindDateTime(6, record.LastModifiedDate);
                        stmt.BindText(7, record.LastModifiedBy);
                        stmt.BindDateTime(8, record.DeviceLastModifiedDate);
                        stmt.BindInt(9, record.IsModified ? 1 : 0);
                        stmt.Step();
                    }
                }
                finally
                {
                    stmt.FinalizeStm();
                }
            }
        }

        private Record SqliteStmtToRecord(SQLiteStatement stmt)
        {
            return new Record(stmt.Fields[RecordColumns.KEY].TEXT, stmt.Fields[RecordColumns.VALUE].TEXT,
                               stmt.Fields[RecordColumns.SYNC_COUNT].INTEGER, stmt.Fields[RecordColumns.LAST_MODIFIED_TIMESTAMP].DATETIME,
                               stmt.Fields[RecordColumns.LAST_MODIFIED_BY].TEXT, stmt.Fields[RecordColumns.DEVICE_LAST_MODIFIED_TIMESTAMP].DATETIME,
                               (stmt.Fields[RecordColumns.MODIFIED].INTEGER == 1));
        }

        private DatasetMetadata GetMetadataInternal(string identityId, string datasetName)
        {
            lock (sqlite_lock)
            {
                SQLiteStatement stmt = null;
                try
                {
                    stmt = db.Prepare(DatasetColumns.BuildQuery(
                    DatasetColumns.IDENTITY_ID + " = '" + identityId + "' AND " +
                        DatasetColumns.DATASET_NAME + " = '" + datasetName + "'"
                    ));
                    DatasetMetadata metadata = null;
                    while (stmt.Read())
                    {
                        metadata = this.SqliteStmtToDatasetMetadata(stmt);
                    }
                    return metadata;
                }
                finally
                {
                    stmt.FinalizeStm();
                }
            }
        }


        private DatasetMetadata SqliteStmtToDatasetMetadata(SQLiteStatement stmt)
        {
            return new DatasetMetadata(
                stmt.Fields[DatasetColumns.DATASET_NAME].TEXT,
                stmt.Fields[DatasetColumns.CREATION_TIMESTAMP].DATETIME,
                stmt.Fields[DatasetColumns.LAST_MODIFIED_TIMESTAMP].DATETIME,
                stmt.Fields[DatasetColumns.LAST_MODIFIED_BY].TEXT,
                stmt.Fields[DatasetColumns.STORAGE_SIZE_BYTES].INTEGER,
                stmt.Fields[DatasetColumns.RECORD_COUNT].INTEGER
            );
        }

        private SQLiteDatabase db = null;
        private void SetupDatabase()
        {
            lock (sqlite_lock)
            {

                SQLiteStatement stmt = null;
                try
                {

                    db = new SQLiteDatabase(this.dataPath);

                    string query = "SELECT count(*) as count FROM sqlite_master WHERE type='table' AND name='" + TABLE_DATASETS + "'";
                    stmt = db.Prepare(query);


                    if (stmt.Read() && stmt.Fields["count"].INTEGER == 0)
                    {
                        _logger.InfoFormat("{0}", @"Cognito Sync - SQLiteStorage - running create dataset");
                        db.Exec(
                    "CREATE TABLE " + TABLE_DATASETS + "("
                            + DatasetColumns.IDENTITY_ID + " TEXT NOT NULL,"
                            + DatasetColumns.DATASET_NAME + " TEXT NOT NULL,"
                            + DatasetColumns.CREATION_TIMESTAMP + " TEXT DEFAULT '0',"
                            + DatasetColumns.LAST_MODIFIED_TIMESTAMP + " TEXT DEFAULT '0',"
                            + DatasetColumns.LAST_MODIFIED_BY + " TEXT,"
                            + DatasetColumns.STORAGE_SIZE_BYTES + " INTEGER DEFAULT 0,"
                            + DatasetColumns.RECORD_COUNT + " INTEGER DEFAULT 0,"
                            + DatasetColumns.LAST_SYNC_COUNT + " INTEGER NOT NULL DEFAULT 0,"
                            + DatasetColumns.LAST_SYNC_TIMESTAMP + " INTEGER DEFAULT '0',"
                            + DatasetColumns.LAST_SYNC_RESULT + " TEXT,"
                            + "UNIQUE (" + DatasetColumns.IDENTITY_ID + ", "
                            + DatasetColumns.DATASET_NAME + ")"
                            + ")");
                    }

                    stmt.FinalizeStm();
                    query = "SELECT count(*) as count FROM sqlite_master WHERE type='table' AND name='" + TABLE_RECORDS + "'";

                    stmt = db.Prepare(query);


                    if (stmt.Read() && stmt.Fields["count"].INTEGER == 0)
                    {
                        _logger.InfoFormat("{0}", @"Cognito Sync - SQLiteStorage - running create dataset");
                        db.Exec(
                        "CREATE TABLE " + TABLE_RECORDS + "("
                            + RecordColumns.IDENTITY_ID + " TEXT NOT NULL,"
                            + RecordColumns.DATASET_NAME + " TEXT NOT NULL,"
                            + RecordColumns.KEY + " TEXT NOT NULL,"
                            + RecordColumns.VALUE + " TEXT,"
                            + RecordColumns.SYNC_COUNT + " INTEGER NOT NULL DEFAULT 0,"
                            + RecordColumns.LAST_MODIFIED_TIMESTAMP + " TEXT DEFAULT '0',"
                            + RecordColumns.LAST_MODIFIED_BY + " TEXT,"
                            + RecordColumns.DEVICE_LAST_MODIFIED_TIMESTAMP + " TEXT DEFAULT '0',"
                            + RecordColumns.MODIFIED + " INTEGER NOT NULL DEFAULT 1,"
                            + "UNIQUE (" + RecordColumns.IDENTITY_ID + ", " + RecordColumns.DATASET_NAME
                            + ", " + RecordColumns.KEY + ")"
                            + ")");
                    }

                }
                finally
                {
                    if (stmt != null)
                        stmt.FinalizeStm();
                }
                _logger.InfoFormat("{0}", @"Cognito Sync - SQLiteStorage - completed setupdatabase");
            }
        }
#endif
    }
}

