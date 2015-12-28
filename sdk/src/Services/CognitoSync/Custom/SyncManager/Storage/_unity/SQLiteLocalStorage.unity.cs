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

using Amazon.Util.Storage.Internal;
using Mono.Data.Sqlite;
using UnityEngine;
using Amazon.Util.Internal;
using System.IO;
using System.Text.RegularExpressions;
using Amazon.Runtime.Internal.Util;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Amazon.CognitoSync.SyncManager.Internal
{
    public partial class SQLiteLocalStorage : ILocalStorage
    {
        internal readonly string directoryPath;
        internal readonly string filePath;

        public SQLiteLocalStorage()
        {
            _logger = Logger.GetLogger(this.GetType());
            directoryPath = AmazonHookedPlatformInfo.Instance.PersistentDataPath;
            filePath = System.IO.Path.Combine(directoryPath, DB_FILE_NAME);
            this.SetupDatabase();
        }

        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        private SqliteConnection connection;

        private void SetupDatabase()
        {
            //check if database already exists
            if (!Directory.Exists(directoryPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(directoryPath);
            }
            if (!File.Exists(filePath))
            {
                SqliteConnection.CreateFile(filePath);
            }

            try
            {
                connection = new SqliteConnection("URI=file:" + filePath);
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

                using (var command = new SqliteCommand(createDatasetTable, connection))
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

                using (var command = new SqliteCommand(createRecordsTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                string createKvStore = "CREATE TABLE IF NOT EXISTS kvstore (key TEXT NOT NULL, value TEXT NOT NULL, UNIQUE (KEY))";

                using (var command = new SqliteCommand(createKvStore, connection))
                {
                    command.ExecuteNonQuery();
                }
                _logger.InfoFormat("{0}", @"Cognito Sync - SQLiteStorage - completed setupdatabase");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        internal void CreateDatasetHelper(string query, params object[] parameters)
        {

            try
            {
                connection = new SqliteConnection("URI=file:" + filePath);
                connection.Open();
                using (var command = new SqliteCommand(connection))
                {
                    command.CommandText = query;
                    BindData(command, parameters);
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }

        }

        internal DatasetMetadata GetMetadataHelper(string identityId, string datasetName)
        {
            string query = DatasetColumns.BuildQuery(
                    DatasetColumns.IDENTITY_ID + " = @identityId AND " +
                        DatasetColumns.DATASET_NAME + " = @datasetName "
                    );

            DatasetMetadata metadata = null;

            try
            {
                connection = new SqliteConnection("URI=file:" + filePath);
                connection.Open();
                using (var command = new SqliteCommand(connection))
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
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return metadata;
        }

        private static DatasetMetadata SqliteStmtToDatasetMetadata(SqliteDataReader reader)
        {
            var values = new object[reader.FieldCount];
            int valueCount = reader.GetValues(values);
            string datasetName = string.Empty;
            DateTime creationTimestamp = DateTime.MinValue;
            DateTime lastModifiedTimestamp = DateTime.MinValue;
            string lastModifiedBy = string.Empty;
            int storageSizeBytes = -1;
            int recordCount = -1;

            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            for (int i = 0; i < valueCount; i++)
            {
                Debug.LogWarning(string.Format("Value {0} in SqliteStmtToDatasetMetadata is {1}.", i, values[i].ToString()));
            }

            return null;
            //return new DatasetMetadata(
            //    stmt.DataType(RecordColumns.DATASET_NAME) == SQLiteType.NULL ? string.Empty : stmt.GetText(DatasetColumns.DATASET_NAME),
            //    new DateTime(long.Parse(stmt.GetText(DatasetColumns.CREATION_TIMESTAMP))),
            //    new DateTime(long.Parse(stmt.GetText(DatasetColumns.LAST_MODIFIED_TIMESTAMP))),
            //    stmt.DataType(DatasetColumns.LAST_MODIFIED_BY) == SQLiteType.NULL ? string.Empty : stmt.GetText(DatasetColumns.LAST_MODIFIED_BY),
            //    stmt.GetInteger(DatasetColumns.STORAGE_SIZE_BYTES),
            //    stmt.GetInteger(DatasetColumns.RECORD_COUNT)
            //);
        }


        private static void BindData(SqliteCommand command, params object[] parameters)
        {
            string query = command.CommandText;
            int count = 0;
            foreach (Match match in Regex.Matches(query, "(\\@\\w+) "))
            {
                var date = parameters[count] as DateTime?;
                if (date.HasValue)
                {
                    command.Parameters.Add(new SqliteParameter(match.Groups[1].Value, date.Value.Ticks.ToString(CultureInfo.InvariantCulture.NumberFormat)));
                }
                else
                {
                    command.Parameters.Add(new SqliteParameter(match.Groups[1].Value, parameters[count]));
                }
                count++;
            }
        }


        internal List<DatasetMetadata> GetDatasetMetadataHelper(string query, params string[] parameters)
        {
            List<DatasetMetadata> datasetMetadataList = new List<DatasetMetadata>();
            try
            {
                connection = new SqliteConnection("URI=file:" + filePath);
                connection.Open();

                using (var command = new SqliteCommand(connection))
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
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return datasetMetadataList;
        }

        internal Record GetRecordHelper(string query, params string[] parameters)
        {
            Record record = null;
            try
            {
                connection = new SqliteConnection("URI=file:" + filePath);
                connection.Open();

                using (var command = new SqliteCommand(connection))
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
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return record;
        }


        internal List<Record> GetRecordsHelper(string query, params string[] parameters)
        {
            List<Record> records = new List<Record>();
            try
            {
                connection = new SqliteConnection("URI=file:" + filePath);
                connection.Open();

                using (var command = new SqliteCommand(connection))
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
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return records;
        }


        internal long GetLastSyncCountHelper(string query, params string[] parameters)
        {
            long lastSyncCount = 0;
            try
            {
                connection = new SqliteConnection("URI=file:" + filePath);
                connection.Open();

                using (var command = new SqliteCommand(connection))
                {
                    command.CommandText = query;
                    BindData(command, parameters);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows && reader.Read())
                        {

                            //TODO
                            //TODO
                            //TODO
                            //TODO
                            var values = new object[reader.FieldCount];
                            int valueCount = reader.GetValues(values);
                            for (int i = 0; i < valueCount; i++)
                            {
                                Debug.LogWarning(string.Format("Value {0} in GetLastSyncCountHelper is {1}.", i, values[i].ToString()));
                            }
                            //TODO
                            //TODO
                            //var nvc = reader.GetValues();
                            //lastSyncCount = long.Parse(nvc[DatasetColumns.LAST_SYNC_COUNT], CultureInfo.InvariantCulture);
                        }
                    }
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return lastSyncCount;
        }

        internal List<Record> GetModifiedRecordsHelper(string query, params object[] parameters)
        {
            List<Record> records = new List<Record>();
            try
            {
                connection = new SqliteConnection("URI=file:" + filePath);
                connection.Open();

                using (var command = new SqliteCommand(connection))
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
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return records;
        }

        internal void UpdateOrInsertRecord(string identityId, string datasetName, Record record)
        {
            lock (sqlite_lock)
            {
                string checkRecordExistsQuery = "SELECT COUNT(*) FROM " + SQLiteLocalStorage.TABLE_RECORDS + " WHERE " +
                    RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                    RecordColumns.DATASET_NAME + " = @whereDatasetName AND " +
                    RecordColumns.KEY + " = @whereKey ";

                bool recordsFound = false;

                try
                {
                    connection = new SqliteConnection("URI=file:" + filePath);
                    connection.Open();

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
                        // TODO: unduplicate with bcl. Only this line is different +++ try/catch for connection mgmt
                        using (var command = new SqliteCommand(insertRecord, connection))
                        {
                            BindData(command, identityId, datasetName, record.Key, record.Value, record.SyncCount, record.LastModifiedDate, record.LastModifiedBy, record.DeviceLastModifiedDate, record.IsModified ? 1 : 0);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                        connection.Dispose();
                    }
                }
            }
        }

        private static Record SqliteStmtToRecord(SqliteDataReader reader)
        {
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            var values = new object[reader.FieldCount];
            int valueCount = reader.GetValues(values);
            for (int i = 0; i < valueCount; i++)
            {
                Debug.LogWarning(string.Format("Value {0} in SqliteStmtToRecord is {1}.", i, values[i].ToString()));
            }
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            return null;
            //var nvc = reader.GetValues();
            //return new Record(nvc[RecordColumns.KEY], nvc[RecordColumns.VALUE],
            //                   int.Parse(nvc[RecordColumns.SYNC_COUNT], CultureInfo.InvariantCulture), new DateTime(long.Parse(nvc[RecordColumns.LAST_MODIFIED_TIMESTAMP], CultureInfo.InvariantCulture.NumberFormat), DateTimeKind.Utc),
            //                   nvc[RecordColumns.LAST_MODIFIED_BY], new DateTime(long.Parse(nvc[RecordColumns.DEVICE_LAST_MODIFIED_TIMESTAMP], CultureInfo.InvariantCulture.NumberFormat), DateTimeKind.Utc),
            //                   int.Parse(nvc[RecordColumns.MODIFIED], CultureInfo.InvariantCulture) == 1);
        }

        //TODO: unduplicate this code with bcl unless try/catch for connection mgmt is kept
        /// <summary>
        /// cache the identity
        /// </summary>
        /// <param name="key"></param>
        /// <param name="identity"></param>
        public void CacheIdentity(string key, string identity)
        {
            string query = "INSERT INTO kvstore(key,value) values ( @key , @value )";
            try
            {
                connection = new SqliteConnection("URI=file:" + filePath);
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    BindData(command, key, identity);
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        //TODO: unduplicate this code with bcl unless try/catch for connection mgmt is kept
        /// <summary>
        /// Delete the cached identity id
        /// </summary>
        /// <param name="key"></param>
        public void DeleteCachedIdentity(string key)
        {
            string query = "delete from kvstore where key = @key ";
            try
            {
                connection = new SqliteConnection("URI=file:" + filePath);
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    BindData(command, key);
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        //TODO: unduplicate this code with bcl unless try/catch for connection mgmt is kept
        internal void ExecuteMultipleHelper(List<Statement> statements)
        {
            try
            {
                connection = new SqliteConnection("URI=file:" + filePath);
                connection.Open();

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
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        //TODO: unduplicate this code with bcl unless try/catch for connection mgmt is kept
        internal void UpdateLastSyncCountHelper(string query, params object[] parameters)
        {
            try
            {
                connection = new SqliteConnection("URI=file:" + filePath);
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    BindData(command, parameters);
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        //TODO: unduplicate this code with bcl unless try/catch for connection mgmt is kept
        internal void UpdateLastModifiedTimestampHelper(string query, params object[] parameters)
        {
            try
            {
                connection = new SqliteConnection("URI=file:" + filePath);
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    BindData(command, parameters);
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }
    }
}
