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
using SQLitePCL;
using SQLitePCL.Extensions;
using System;
using System.Collections.Generic;

namespace Amazon.CognitoSync.SyncManager.Internal
{
    public class SQLiteLocalStorage : ILocalStorage
    {

        //datetime is converted to ticks and stored as string

        private static SQLiteConnection connection;

        #region dispose methods

        public override void Dispose(bool disposing)
        {
            if (disposing)
            {
                connection.Dispose();
            }
        }

        #endregion

        #region helper methods


        private static void SetupDatabase()
        {
            string dbPath = "";

            connection = new SQLiteConnection(DB_FILE_NAME);

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
                    DatasetColumns.IDENTITY_ID + " = ? AND " +
                        DatasetColumns.DATASET_NAME + " = ?"
                    );

            DatasetMetadata metadata = null;

            using (var sqliteStatement = connection.Prepare(query))
            {
                BindData(sqliteStatement, identityId, datasetName);
                while (sqliteStatement.Step() == SQLiteResult.OK)
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
                while (sqliteStatement.Step() == SQLiteResult.OK)
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
                while (sqliteStatement.Step() == SQLiteResult.OK)
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
                while (sqliteStatement.Step() == SQLiteResult.OK)
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
                while (sqliteStatement.Step() == SQLiteResult.OK)
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
                while (sqliteStatement.Step() == SQLiteResult.OK)
                {
                    records.Add(SqliteStmtToRecord(sqliteStatement));
                }
            }
            return records;
        }

        internal void ExecuteMultipleHelper(List<Statement> statements)
        {
            connection.Prepare("BEGIN;").Step();
            foreach(var stmt in statements)
            {
                string query = stmt.Query.TrimEnd();
                //transaction statements should end with a semi-colon, so if there is no semi-colon then append it in the end
                if(!query.EndsWith(";"))
                {
                    query += ";";
                }
                using (var sqliteStatement = connection.Prepare(query))
                {
                    BindData(sqliteStatement, stmt.Parameters);
                    var result = sqliteStatement.Step();
                    if (result != SQLiteResult.OK)
                        throw new Exception(result.ToString());
                }
            }
            connection.Prepare("COMMIT;").Step();
        }

        internal void UpdateLastSyncCountHelper(string query, params object[] parameters)
        {
            using (var sqliteStatement = connection.Prepare(query))
            {
                BindData(sqliteStatement, parameters);
                var result = sqliteStatement.Step();
                if (result != SQLiteResult.OK)
                    throw new Exception(result.ToString());
            }
        }

        internal void UpdateLastModifiedTimestampHelper(string query, params object[] parameters)
        {
            using (var sqliteStatement = connection.Prepare(query))
            {
                BindData(sqliteStatement, parameters);
                var result = sqliteStatement.Step();
                if (result != SQLiteResult.OK)
                    throw new Exception(result.ToString());
            }
        }

        internal void UpdateAndClearRecord(string identityId, string datasetName, Record record)
        {
            lock (sqlite_lock)
            {
                string updateAndClearQuery = RecordColumns.BuildQuery(
                    RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                    RecordColumns.DATASET_NAME + " = @whereDatasetName AND " +
                    RecordColumns.KEY + " = @whereKey "
                );
                bool recordsFound = false;

                using (var sqliteStatement = connection.Prepare(updateAndClearQuery))
                {
                    BindData(sqliteStatement, identityId, datasetName, record.Key);
                    var result = sqliteStatement.Step();
                    if (result != SQLiteResult.OK)
                        throw new Exception(result.ToString());
                }

                if (recordsFound)
                {
                    string updateRecordQuery =
                    RecordColumns.BuildUpdate(
                        new string[] {
                            RecordColumns.VALUE,
                            RecordColumns.SYNC_COUNT,
                            RecordColumns.MODIFIED
                        },
                    RecordColumns.IDENTITY_ID + " = @whereIdentityId AND " +
                        RecordColumns.DATASET_NAME + " = @whereDatasetName AND " +
                        RecordColumns.KEY + " = @whereKey "
                    );

                    using (var sqliteStatement = connection.Prepare(updateAndClearQuery))
                    {
                        BindData(sqliteStatement, record.Value, record.SyncCount, record.IsModified ? 1 : 0, identityId, datasetName, record.Key);
                        var result = sqliteStatement.Step();
                        if (result != SQLiteResult.OK)
                            throw new Exception(result.ToString());
                    }
                }
                else
                {
                    string insertRecord = RecordColumns.BuildInsert();
                    using (var sqliteStatement = connection.Prepare(updateAndClearQuery))
                    {
                        BindData(sqliteStatement, identityId, datasetName, record.Key, record.Value, record.SyncCount, record.LastModifiedDate, record.LastModifiedBy, record.DeviceLastModifiedDate, record.IsModified ? 1 : 0);
                        var result = sqliteStatement.Step();
                        if (result != SQLiteResult.OK)
                            throw new Exception(result.ToString());
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
                for (int i = 0; i < parameters.Length; i++)
                {
                    object o = parameters[i];

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
                stmt.GetText(DatasetColumns.DATASET_NAME),
                new DateTime(long.Parse(stmt.GetText(DatasetColumns.CREATION_TIMESTAMP))),
                new DateTime(long.Parse(stmt.GetText(DatasetColumns.LAST_MODIFIED_TIMESTAMP))),
                stmt.GetText(DatasetColumns.LAST_MODIFIED_BY),
                stmt.GetInteger(DatasetColumns.STORAGE_SIZE_BYTES),
                stmt.GetInteger(DatasetColumns.RECORD_COUNT)
            );
        }

        private static Record SqliteStmtToRecord(ISQLiteStatement stmt)
        {
            return new Record(stmt.GetText(RecordColumns.KEY), stmt.GetText(RecordColumns.VALUE),
                               stmt.GetInteger(RecordColumns.SYNC_COUNT), new DateTime(long.Parse(stmt.GetText(RecordColumns.LAST_MODIFIED_TIMESTAMP))),
                               stmt.GetText(RecordColumns.LAST_MODIFIED_BY), new DateTime(long.Parse(stmt.GetText(RecordColumns.DEVICE_LAST_MODIFIED_TIMESTAMP))),
                               stmt.GetInteger(RecordColumns.MODIFIED) == 1);
        }
        #endregion

    }
}

