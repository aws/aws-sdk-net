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
using SQLitePCL;
using SQLitePCL.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Amazon.CognitoSync.SyncManager.Internal
{
    public partial class SQLiteLocalStorage : ILocalStorage
    {

        //datetime is converted to ticks and stored as string

        private SQLiteConnection connection;

        #region dispose methods
        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
#if !__IOS__
                connection.Dispose();
#endif
            }
        }

#endregion

#region helper methods


        private void SetupDatabase()
        {
#if __IOS__
            SQLitePCL.CurrentPlatform.Init();
#endif

            string dbPath = Path.Combine(PCLStorage.FileSystem.Current.LocalStorage.Path, DB_FILE_NAME);

            connection = new SQLiteConnection(dbPath);

            string createDatasetTable = "CREATE TABLE IF NOT EXISTS " + TABLE_DATASETS + "("
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
                        + ")";

            using (var sqliteStatement = connection.Prepare(createDatasetTable))
            {
                sqliteStatement.Step();
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

            using (var sqliteStatement = connection.Prepare(createRecordsTable))
            {
                sqliteStatement.Step();
            }
        }

        internal void CreateDatasetHelper(string query, params object[] parameters)
        {
            using (var sqliteStatement = connection.Prepare(query))
            {
                BindData(sqliteStatement, parameters);
                sqliteStatement.Step();
            }
        }

        internal DatasetMetadata GetMetadataHelper(string identityId, string datasetName)
        {
            string query = DatasetColumns.BuildQuery(
                    DatasetColumns.IDENTITY_ID + " = @identity_id AND " +
                        DatasetColumns.DATASET_NAME + " = @dataset_name "
                    );

            DatasetMetadata metadata = null;

            using (var sqliteStatement = connection.Prepare(query))
            {
                BindData(sqliteStatement, identityId, datasetName);
                while (sqliteStatement.Step() == SQLiteResult.ROW)
                {
                    metadata = SqliteStmtToDatasetMetadata(sqliteStatement);
                }
            }

            return metadata;
        }

        internal List<DatasetMetadata> GetDatasetMetadataHelper(string query, params string[] parameters)
        {
            List<DatasetMetadata> datasetMetadataList = new List<DatasetMetadata>();
            using (var sqliteStatement = connection.Prepare(query))
            {
                BindData(sqliteStatement, parameters);
                while (sqliteStatement.Step() == SQLiteResult.ROW)
                {
                    datasetMetadataList.Add(SqliteStmtToDatasetMetadata(sqliteStatement));
                }
            }

            return datasetMetadataList;
        }

        internal Record GetRecordHelper(string query, params string[] parameters)
        {
            Record record = null;
            using (var sqliteStatement = connection.Prepare(query))
            {
                BindData(sqliteStatement, parameters);
                while (sqliteStatement.Step() == SQLiteResult.ROW)
                {
                    record = SqliteStmtToRecord(sqliteStatement);
                }
            }
            return record;
        }

        internal List<Record> GetRecordsHelper(string query, params string[] parameters)
        {
            List<Record> records = new List<Record>();
            using (var sqliteStatement = connection.Prepare(query))
            {
                BindData(sqliteStatement, parameters);
                while (sqliteStatement.Step() == SQLiteResult.ROW)
                {
                    records.Add(SqliteStmtToRecord(sqliteStatement));
                }
            }
            return records;
        }

        internal long GetLastSyncCountHelper(string query, params string[] parameters)
        {
            long lastSyncCount = 0;
            using (var sqliteStatement = connection.Prepare(query))
            {
                BindData(sqliteStatement, parameters);
                while (sqliteStatement.Step() == SQLiteResult.ROW)
                {
                    lastSyncCount = sqliteStatement.GetInteger(DatasetColumns.LAST_SYNC_COUNT);
                }
            }
            return lastSyncCount;
        }

        internal List<Record> GetModifiedRecordsHelper(string query, params object[] parameters)
        {
            List<Record> records = new List<Record>();
            using (var sqliteStatement = connection.Prepare(query))
            {
                BindData(sqliteStatement, parameters);
                while (sqliteStatement.Step() == SQLiteResult.ROW)
                {
                    records.Add(SqliteStmtToRecord(sqliteStatement));
                }
            }
            return records;
        }

        internal void ExecuteMultipleHelper(List<Statement> statements)
        {
            connection.Prepare("BEGIN;").Step();
            foreach (var stmt in statements)
            {
                string query = stmt.Query;
                using (var sqliteStatement = connection.Prepare(query))
                {
                    BindData(sqliteStatement, stmt.Parameters);
                    var result = sqliteStatement.Step();
                }
            }
            connection.Prepare("COMMIT;").Step();
        }

        internal void UpdateLastSyncCountHelper(string query, params object[] parameters)
        {
            using (var sqliteStatement = connection.Prepare(query))
            {
                BindData(sqliteStatement, parameters);
                sqliteStatement.Step();
            }
        }

        internal void UpdateLastModifiedTimestampHelper(string query, params object[] parameters)
        {
            using (var sqliteStatement = connection.Prepare(query))
            {
                BindData(sqliteStatement, parameters);
                sqliteStatement.Step();
            }
        }

        internal void UpdateOrInsertRecord(string identityId, string datasetName, Record record)
        {
            lock (sqlite_lock)
            {
                string checkRecordExistsQuery = "SELECT count(*) FROM " + SQLiteLocalStorage.TABLE_RECORDS + " WHERE " +
                    RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                    RecordColumns.DATASET_NAME + " = @whereDatasetName AND " +
                    RecordColumns.KEY + " = @whereKey ";

                bool recordsFound = false;
                using (var sqliteStatement = connection.Prepare(checkRecordExistsQuery))
                {
                    BindData(sqliteStatement, identityId, datasetName, record.Key);
                    var result = sqliteStatement.Step();

                    recordsFound = sqliteStatement.GetInteger(0) > 0;
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

                    using (var sqliteStatement = connection.Prepare(updateRecordQuery))
                    {
                        BindData(sqliteStatement, record.Value, record.SyncCount, record.IsModified ? 1 : 0, record.LastModifiedDate, record.LastModifiedBy, record.DeviceLastModifiedDate, identityId, datasetName, record.Key);
                        var result = sqliteStatement.Step();
                    }
                }
                else
                {
                    string insertRecord = RecordColumns.BuildInsert();
                    using (var sqliteStatement = connection.Prepare(insertRecord))
                    {
                        BindData(sqliteStatement, identityId, datasetName, record.Key, record.Value, record.SyncCount, record.LastModifiedDate, record.LastModifiedBy, record.DeviceLastModifiedDate, record.IsModified ? 1 : 0);
                        sqliteStatement.Step();
                    }
                }

            }
        }

#endregion

#region private methods
        private static void BindData(ISQLiteStatement statement, params object[] parameters)
        {
            if (parameters != null)
            {
                for (int i = 1; i <= parameters.Length; i++)
                {
                    object o = parameters[i - 1];

                    var dt = o as DateTime?;
                    if (dt.HasValue)
                    {
                        string ticks = dt.Value.Ticks.ToString();
                        statement.Bind(i, ticks);
                    }
                    else
                    {
                        statement.Bind(i, o);
                    }
                }
            }
        }

        private static DatasetMetadata SqliteStmtToDatasetMetadata(ISQLiteStatement stmt)
        {
            return new DatasetMetadata(
                stmt.DataType(RecordColumns.DATASET_NAME) == SQLiteType.NULL ? string.Empty : stmt.GetText(DatasetColumns.DATASET_NAME),
                new DateTime(long.Parse(stmt.GetText(DatasetColumns.CREATION_TIMESTAMP))),
                new DateTime(long.Parse(stmt.GetText(DatasetColumns.LAST_MODIFIED_TIMESTAMP))),
                stmt.DataType(DatasetColumns.LAST_MODIFIED_BY) == SQLiteType.NULL ? string.Empty : stmt.GetText(DatasetColumns.LAST_MODIFIED_BY),
                stmt.GetInteger(DatasetColumns.STORAGE_SIZE_BYTES),
                stmt.GetInteger(DatasetColumns.RECORD_COUNT)
            );
        }

        private static Record SqliteStmtToRecord(ISQLiteStatement stmt)
        {
            return new Record(stmt.GetText(RecordColumns.KEY),
                               stmt.GetText(RecordColumns.VALUE),
                               stmt.GetInteger(RecordColumns.SYNC_COUNT),
                               new DateTime(long.Parse(stmt.GetText(RecordColumns.LAST_MODIFIED_TIMESTAMP), CultureInfo.InvariantCulture.NumberFormat), DateTimeKind.Utc),
                               stmt.DataType(RecordColumns.LAST_MODIFIED_BY) == SQLiteType.NULL ? string.Empty : stmt.GetText(RecordColumns.LAST_MODIFIED_BY),
                               new DateTime(long.Parse(stmt.GetText(RecordColumns.DEVICE_LAST_MODIFIED_TIMESTAMP), CultureInfo.InvariantCulture.NumberFormat), DateTimeKind.Utc),
                               stmt.GetInteger(RecordColumns.MODIFIED) == 1);
        }
#endregion

    }
}

