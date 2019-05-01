//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// SPDX-License-Identifier: Apache-2.0
//

using Amazon.Runtime.Internal.Util;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Globalization;
using System.Security;
using System.Security.Permissions;
using Amazon.Util.Internal;

namespace Amazon.CognitoSync.SyncManager.Internal
{

    public partial class SQLiteLocalStorage : ILocalStorage
    {

        //datetime is converted to ticks and stored as string
        private SQLiteConnection connection;

        #region dispose methods
        /// <summary>
        /// Releases the resources consumed by this object if disposing is true. 
        /// </summary>
        [SecuritySafeCritical]
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        #endregion

        #region helper methods
        [SecuritySafeCritical]
        private void SetupDatabase()
        {

            //check if database already exists
            var filePath = InternalSDKUtils.DetermineAppLocalStoragePath(DB_FILE_NAME);

            var directoryPath = InternalSDKUtils.DetermineAppLocalStoragePath();
            if (!Directory.Exists(directoryPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(directoryPath);
            }

            if (!File.Exists(filePath))
                SQLiteConnection.CreateFile(filePath);

            connection = new SQLiteConnection(string.Format(CultureInfo.InvariantCulture, "Data Source={0};Version=3;", filePath));
            connection.Open();
            string createDatasetTable = "CREATE TABLE IF NOT EXISTS " + TABLE_DATASETS + "("
                        + DatasetColumns.IDENTITY_ID + " TEXT NOT NULL,"
                        + DatasetColumns.DATASET_NAME + " TEXT NOT NULL,"
                        + DatasetColumns.CREATION_TIMESTAMP + " TEXT DEFAULT '0',"
                        + DatasetColumns.LAST_MODIFIED_TIMESTAMP + " TEXT DEFAULT '0',"
                        + DatasetColumns.LAST_MODIFIED_BY + " TEXT,"
                        + DatasetColumns.STORAGE_SIZE_BYTES + " INTEGER DEFAULT 0,"
                        + DatasetColumns.RECORD_COUNT + " INTEGER DEFAULT 0,"
                        + DatasetColumns.LAST_SYNC_COUNT + " INTEGER NOT NULL DEFAULT 0,"
                        + DatasetColumns.LAST_SYNC_TIMESTAMP + " TEXT DEFAULT '0',"
                        + DatasetColumns.LAST_SYNC_RESULT + " TEXT,"
                        + "UNIQUE (" + DatasetColumns.IDENTITY_ID + ", "
                        + DatasetColumns.DATASET_NAME + ")"
                        + ")";

            using (var command = new SQLiteCommand(createDatasetTable, connection))
            {
                command.ExecuteNonQuery();
            }

            string createRecordsTable = "CREATE TABLE IF NOT EXISTS " + TABLE_RECORDS + "("
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
                        + ")";

            using (var command = new SQLiteCommand(createRecordsTable, connection))
            {
                command.ExecuteNonQuery();
            }

            string createKvStore = "CREATE TABLE IF NOT EXISTS kvstore (key TEXT NOT NULL, value TEXT NOT NULL, UNIQUE (KEY))";

            using (var command = new SQLiteCommand(createKvStore, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        [SecuritySafeCritical]
        internal void CreateDatasetHelper(string query, params object[] parameters)
        {
            using (var command = new SQLiteCommand(connection))
            {
                command.CommandText = query;
                BindData(command, parameters);
                command.ExecuteNonQuery();
            }
        }

        [SecuritySafeCritical]
        internal DatasetMetadata GetMetadataHelper(string identityId, string datasetName)
        {
            string query = DatasetColumns.BuildQuery(
                    DatasetColumns.IDENTITY_ID + " = @identityId AND " +
                        DatasetColumns.DATASET_NAME + " = @datasetName "
                    );

            DatasetMetadata metadata = null;

            using (var command = new SQLiteCommand(connection))
            {
                command.CommandText = query;
                BindData(command, identityId, datasetName);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        metadata = SqliteStmtToDatasetMetadata(reader);
                    }
                }
            }
            return metadata;
        }

        [SecuritySafeCritical]
        internal List<DatasetMetadata> GetDatasetMetadataHelper(string query, params string[] parameters)
        {
            List<DatasetMetadata> datasetMetadataList = new List<DatasetMetadata>();
            using (var command = new SQLiteCommand(connection))
            {
                command.CommandText = query;
                BindData(command, parameters);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.HasRows && reader.Read())
                    {
                        datasetMetadataList.Add(SqliteStmtToDatasetMetadata(reader));
                    }
                }
            }

            return datasetMetadataList;
        }

        [SecuritySafeCritical]
        internal Record GetRecordHelper(string query, params string[] parameters)
        {
            Record record = null;
            using (var command = new SQLiteCommand(connection))
            {
                command.CommandText = query;
                BindData(command, parameters);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        record = SqliteStmtToRecord(reader);
                    }
                }
            }
            return record;
        }

        [SecuritySafeCritical]
        internal List<Record> GetRecordsHelper(string query, params string[] parameters)
        {
            List<Record> records = new List<Record>();
            using (var command = new SQLiteCommand(connection))
            {
                command.CommandText = query;
                BindData(command, parameters);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.HasRows && reader.Read())
                    {
                        records.Add(SqliteStmtToRecord(reader));
                    }
                }
            }
            return records;
        }

        [SecuritySafeCritical]
        internal long GetLastSyncCountHelper(string query, params string[] parameters)
        {
            long lastSyncCount = 0;
            using (var command = new SQLiteCommand(connection))
            {
                command.CommandText = query;
                BindData(command, parameters);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        var nvc = reader.GetValues();
                        lastSyncCount = long.Parse(nvc[DatasetColumns.LAST_SYNC_COUNT], CultureInfo.InvariantCulture);
                    }
                }
            }
            return lastSyncCount;
        }

        [SecuritySafeCritical]
        internal List<Record> GetModifiedRecordsHelper(string query, params object[] parameters)
        {
            List<Record> records = new List<Record>();
            using (var command = new SQLiteCommand(connection))
            {
                command.CommandText = query;
                BindData(command, parameters);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.HasRows && reader.Read())
                    {
                        records.Add(SqliteStmtToRecord(reader));
                    }
                }
            }
            return records;
        }

        [SecuritySafeCritical]
        internal void ExecuteMultipleHelper(List<Statement> statements)
        {
            using (var transaction = connection.BeginTransaction())
            {
                foreach (var stmt in statements)
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = stmt.Query;
                        command.Transaction = transaction;
                        BindData(command, stmt.Parameters);
                        command.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
            }
        }

        [SecuritySafeCritical]
        internal void UpdateLastSyncCountHelper(string query, params object[] parameters)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = query;
                BindData(command, parameters);
                command.ExecuteNonQuery();
            }
        }

        [SecuritySafeCritical]
        internal void UpdateLastModifiedTimestampHelper(string query, params object[] parameters)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = query;
                BindData(command, parameters);
                command.ExecuteNonQuery();
            }
        }

        [SecuritySafeCritical]
        internal void UpdateOrInsertRecord(string identityId, string datasetName, Record record)
        {
            lock (sqlite_lock)
            {
                string checkRecordExistsQuery = "SELECT COUNT(*) FROM " + SQLiteLocalStorage.TABLE_RECORDS + " WHERE " +
                    RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                    RecordColumns.DATASET_NAME + " = @whereDatasetName AND " +
                    RecordColumns.KEY + " = @whereKey ";

                bool recordsFound = false;

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = checkRecordExistsQuery;
                    BindData(command, identityId, datasetName, record.Key);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                            recordsFound = reader.GetInt32(0) > 0;
                    }
                }

                if (recordsFound)
                {
                    string updateRecordQuery =
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
                    );

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = updateRecordQuery;
                        BindData(command, record.Value, record.SyncCount, record.IsModified ? 1 : 0, record.LastModifiedDate, record.LastModifiedBy, record.DeviceLastModifiedDate, identityId, datasetName, record.Key);
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    string insertRecord = RecordColumns.BuildInsert();
                    using (var command = new SQLiteCommand(insertRecord, connection))
                    {
                        BindData(command, identityId, datasetName, record.Key, record.Value, record.SyncCount, record.LastModifiedDate, record.LastModifiedBy, record.DeviceLastModifiedDate, record.IsModified ? 1 : 0);
                        command.ExecuteNonQuery();
                    }
                }

            }
        }

        #endregion

        #region private methods
        [SecuritySafeCritical]
        private static void BindData(SQLiteCommand command, params object[] parameters)
        {
            string query = command.CommandText;
            int count = 0;
            foreach (Match match in Regex.Matches(query, "(\\@\\w+) "))
            {
                var date = parameters[count] as DateTime?;
                if (date.HasValue)
                {
                    command.Parameters.Add(new SQLiteParameter(match.Groups[1].Value, date.Value.Ticks.ToString(CultureInfo.InvariantCulture.NumberFormat)));
                }
                else
                {
                    command.Parameters.Add(new SQLiteParameter(match.Groups[1].Value, parameters[count]));
                }
                count++;
            }
        }

        [SecuritySafeCritical]
        private static DatasetMetadata SqliteStmtToDatasetMetadata(SQLiteDataReader reader)
        {
            var nvc = reader.GetValues();
            return new DatasetMetadata(
                nvc[DatasetColumns.DATASET_NAME],
                new DateTime(long.Parse(nvc[DatasetColumns.CREATION_TIMESTAMP], CultureInfo.InvariantCulture.NumberFormat)),
                new DateTime(long.Parse(nvc[DatasetColumns.LAST_MODIFIED_TIMESTAMP], CultureInfo.InvariantCulture.NumberFormat)),
                nvc[DatasetColumns.LAST_MODIFIED_BY],
                long.Parse(nvc[DatasetColumns.STORAGE_SIZE_BYTES], CultureInfo.InvariantCulture.NumberFormat),
                long.Parse(nvc[DatasetColumns.RECORD_COUNT], CultureInfo.InvariantCulture.NumberFormat)
            );
        }

        [SecuritySafeCritical]
        private static Record SqliteStmtToRecord(SQLiteDataReader reader)
        {
            var nvc = reader.GetValues();
            return new Record(nvc[RecordColumns.KEY], nvc[RecordColumns.VALUE],
                               int.Parse(nvc[RecordColumns.SYNC_COUNT], CultureInfo.InvariantCulture), new DateTime(long.Parse(nvc[RecordColumns.LAST_MODIFIED_TIMESTAMP], CultureInfo.InvariantCulture.NumberFormat), DateTimeKind.Utc),
                               nvc[RecordColumns.LAST_MODIFIED_BY], new DateTime(long.Parse(nvc[RecordColumns.DEVICE_LAST_MODIFIED_TIMESTAMP], CultureInfo.InvariantCulture.NumberFormat), DateTimeKind.Utc),
                               int.Parse(nvc[RecordColumns.MODIFIED], CultureInfo.InvariantCulture) == 1);
        }
        #endregion


        #region BCL Specific implementation for identityId caching
        /// <summary>
        /// cache the identity
        /// </summary>
        /// <param name="key"></param>
        /// <param name="identity"></param>
        [SecuritySafeCritical]
        public void CacheIdentity(string key, string identity)
        {
            string query = "INSERT INTO kvstore(key,value) values ( @key , @value )";
            using (var command = connection.CreateCommand())
            {
                command.CommandText = query;
                BindData(command, key, identity);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Get the cached identity id
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [SecuritySafeCritical]
        public string GetIdentity(string key)
        {
            string query = "SELECT value FROM kvstore WHERE key = @key ";
            using (var command = connection.CreateCommand())
            {
                command.CommandText = query;
                BindData(command, key);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        return reader.GetString(0);
                }
            }
            return null;
        }

        /// <summary>
        /// Delete the cached identity id
        /// </summary>
        /// <param name="key"></param>
        [SecuritySafeCritical]
        public void DeleteCachedIdentity(string key)
        {
            string query = "delete from kvstore where key = @key ";
            using (var command = connection.CreateCommand())
            {
                command.CommandText = query;
                BindData(command, key);
                command.ExecuteNonQuery();
            }
        }

        #endregion

    }
}

