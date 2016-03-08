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

using Mono.Data.Sqlite;
using Amazon.Util.Internal;
using System.IO;
using System.Text.RegularExpressions;
using Logger = Amazon.Runtime.Internal.Util.Logger;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Amazon.CognitoSync.SyncManager.Internal
{
    public partial class SQLiteLocalStorage : ILocalStorage
    {
        internal readonly string directoryPath;
        internal readonly string filePath;

        /// <summary>
        /// An implementation for <see cref="Amazon.CognitoSync.SyncManager.ILocalStorage"/> 
        /// using <see href="http://sqlite.org">SQLite</see>
        /// </summary>
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
                            metadata = DatasetMetadataFromReader(reader);
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

        private static DatasetMetadata DatasetMetadataFromReader(SqliteDataReader reader)
        {
            return new DatasetMetadata(
                reader.GetString(DatasetColumns.DATASET_NAME_IDX) ?? string.Empty,
                new DateTime(long.Parse(reader.GetString(DatasetColumns.CREATION_TIMESTAMP_IDX), CultureInfo.InvariantCulture.NumberFormat), DateTimeKind.Utc),
                new DateTime(long.Parse(reader.GetString(DatasetColumns.LAST_MODIFIED_TIMESTAMP_IDX), CultureInfo.InvariantCulture.NumberFormat), DateTimeKind.Utc),
                reader.IsDBNull(DatasetColumns.LAST_MODIFIED_BY_IDX) ? string.Empty : reader.GetString(DatasetColumns.LAST_MODIFIED_BY_IDX),
                reader.GetInt32(DatasetColumns.STORAGE_SIZE_BYTES_IDX),
                reader.GetInt32(DatasetColumns.RECORD_COUNT_IDX));
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
                            datasetMetadataList.Add(DatasetMetadataFromReader(reader));
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
                            record = RecordFromReader(reader);
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
                            records.Add(RecordFromReader(reader));
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
                            lastSyncCount = reader.GetInt64(DatasetColumns.LAST_SYNC_COUNT_IDX);
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
                            records.Add(RecordFromReader(reader));
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

        private static Record RecordFromReader(SqliteDataReader reader)
        {
            return new Record(
                reader.GetString(RecordColumns.KEY_IDX),
                reader.IsDBNull(RecordColumns.VALUE_IDX) ? null : reader.GetString(RecordColumns.VALUE_IDX),
                reader.GetInt32(RecordColumns.SYNC_COUNT_IDX),
                new DateTime(long.Parse(reader.GetString(RecordColumns.LAST_MODIFIED_TIMESTAMP_IDX), CultureInfo.InvariantCulture.NumberFormat), DateTimeKind.Utc),
                reader.IsDBNull(RecordColumns.LAST_MODIFIED_BY_IDX) ? string.Empty : reader.GetString(RecordColumns.LAST_MODIFIED_BY_IDX),
                new DateTime(long.Parse(reader.GetString(RecordColumns.DEVICE_LAST_MODIFIED_TIMESTAMP_IDX), CultureInfo.InvariantCulture.NumberFormat), DateTimeKind.Utc),
                reader.GetInt32(RecordColumns.MODIFIED_IDX) == 1);
        }

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

        internal void ExecuteMultipleHelper(List<Statement> statements)
        {
            try
            {
                connection = new SqliteConnection("URI=file:" + filePath);
                connection.Open();

                foreach (var stmt in statements)
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = stmt.Query;
                        BindData(command, stmt.Parameters);
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
