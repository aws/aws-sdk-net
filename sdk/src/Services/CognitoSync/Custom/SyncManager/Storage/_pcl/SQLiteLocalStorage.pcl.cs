//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// SPDX-License-Identifier: Apache-2.0
//

using Amazon.Runtime.Internal.Util;
using Amazon.Util.Internal.PlatformServices;
using Sqlite3DatabaseHandle = SQLitePCL.sqlite3;
using Sqlite3Statement = SQLitePCL.sqlite3_stmt;
using Sqlite3 = SQLitePCL.raw;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Amazon.CognitoSync.SyncManager.Internal
{

    public enum Result : int
    {
        OK = 0,
        Error = 1,
        Internal = 2,
        Perm = 3,
        Abort = 4,
        Busy = 5,
        Locked = 6,
        NoMem = 7,
        ReadOnly = 8,
        Interrupt = 9,
        IOError = 10,
        Corrupt = 11,
        NotFound = 12,
        Full = 13,
        CannotOpen = 14,
        LockErr = 15,
        Empty = 16,
        SchemaChngd = 17,
        TooBig = 18,
        Constraint = 19,
        Mismatch = 20,
        Misuse = 21,
        NotImplementedLFS = 22,
        AccessDenied = 23,
        Format = 24,
        Range = 25,
        NonDBFile = 26,
        Notice = 27,
        Warning = 28,
        Row = 100,
        Done = 101
    }

    public class Sqlite3Exception : Exception
    {
        public Result Result { get; private set; }

        protected Sqlite3Exception(Result r, string message) : base(message)
        {
            Result = r;
        }

        public static Sqlite3Exception New(Result r, string message)
        {
            return new Sqlite3Exception(r, message);
        }
    }


    public partial class SQLiteLocalStorage : ILocalStorage
    {

        //datetime is converted to ticks and stored as string

        internal Sqlite3DatabaseHandle Handle;
        internal static readonly Sqlite3DatabaseHandle NullHandle = default(Sqlite3DatabaseHandle);


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
                Sqlite3.sqlite3_close(Handle);
            }
        }

#endregion

#region helper methods


        private void SetupDatabase()
        {
            SQLitePCL.Batteries.Init();

            string dbPath = Path.Combine(PCLStorage.FileSystem.Current.LocalStorage.Path, DB_FILE_NAME);

            var r = Sqlite3.sqlite3_open(dbPath, out Handle);

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

            if(r != Sqlite3.SQLITE_OK)
            {
                throw Sqlite3Exception.New((Result)Enum.Parse(typeof(Result),r.ToString()), string.Format("Could not open database file: {0} ({1})", dbPath, r));
            }

            Execute(createDatasetTable);

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

            Execute(createRecordsTable);
        }

        internal void CreateDatasetHelper(string query, params object[] parameters)
        {
            Execute(query, parameters);
        }

        internal DatasetMetadata GetMetadataHelper(string identityId, string datasetName)
        {
            string query = DatasetColumns.BuildQuery(
                    DatasetColumns.IDENTITY_ID + " = @identity_id AND " +
                        DatasetColumns.DATASET_NAME + " = @dataset_name "
                    );

            DatasetMetadata metadata = null;

            var stmt = ExecuteQuery(query, identityId, datasetName);
            try
            {
                while (Sqlite3.sqlite3_step(stmt) == Sqlite3.SQLITE_ROW)
                {
                    metadata = SqliteStmtToDatasetMetadata(stmt);
                }
            }
            finally
            {
                if (stmt != null)
                    Sqlite3.sqlite3_finalize(stmt);
            }
            
            return metadata;
        }

        internal List<DatasetMetadata> GetDatasetMetadataHelper(string query, params string[] parameters)
        {
            List<DatasetMetadata> datasetMetadataList = new List<DatasetMetadata>();

            Sqlite3Statement stmt = null;
            
            try
            {
                stmt = ExecuteQuery(query, parameters);
                while (Sqlite3.sqlite3_step(stmt) == Sqlite3.SQLITE_ROW)
                {
                    datasetMetadataList.Add(SqliteStmtToDatasetMetadata(stmt));
                }
            }
            finally
            {
                if(stmt != null)
                    Sqlite3.sqlite3_finalize(stmt);
            }

            return datasetMetadataList;
        }

        internal Record GetRecordHelper(string query, params string[] parameters)
        {
            Record record = null;
            Sqlite3Statement stmt = null;

            try
            {
                stmt = ExecuteQuery(query, parameters);

                while (Sqlite3.sqlite3_step(stmt) == Sqlite3.SQLITE_ROW)
                {
                    record = SqliteStmtToRecord(stmt);
                }
            }
            finally
            {
                if (stmt != null)
                    Sqlite3.sqlite3_finalize(stmt);
            }

            return record;
        }

        internal List<Record> GetRecordsHelper(string query, params string[] parameters)
        {
            List<Record> records = new List<Record>();

            Sqlite3Statement stmt = null;
            try
            {
                stmt = ExecuteQuery(query, parameters);

                while (Sqlite3.sqlite3_step(stmt) == Sqlite3.SQLITE_ROW)
                {
                    records.Add(SqliteStmtToRecord(stmt));
                }
            }
            finally
            {
                if (stmt != null)
                    Sqlite3.sqlite3_finalize(stmt);
            }
            return records;
        }

        internal long GetLastSyncCountHelper(string query, params string[] parameters)
        {
            long lastSyncCount = 0;
            Sqlite3Statement stmt = null;
            try
            {
                stmt = ExecuteQuery(query, parameters);
                while (Sqlite3.sqlite3_step(stmt) == Sqlite3.SQLITE_ROW)
                {
                    lastSyncCount = (Int64)GetColumnValue(stmt, typeof(Int64), DatasetColumns.LAST_SYNC_COUNT);
                }
            }
            finally
            {
                if (stmt != null)
                    Sqlite3.sqlite3_finalize(stmt);
            }
            return lastSyncCount;
        }

        internal List<Record> GetModifiedRecordsHelper(string query, params object[] parameters)
        {
            List<Record> records = new List<Record>();
            Sqlite3Statement stmt = null;
            try
            {
                stmt = ExecuteQuery(query, parameters);
                while (Sqlite3.sqlite3_step(stmt) == Sqlite3.SQLITE_ROW)
                {
                    records.Add(SqliteStmtToRecord(stmt));
                }
            }
            finally
            {
                if (stmt != null)
                    Sqlite3.sqlite3_finalize(stmt);
            }

            return records;
        }

        internal void ExecuteMultipleHelper(List<Statement> statements)
        {
            Execute("BEGIN;");
            foreach (var stmt in statements)
            {
                string query = stmt.Query;
                Execute(stmt.Query, stmt.Parameters);
            }
            Execute("COMMIT;");
        }

        internal void UpdateLastSyncCountHelper(string query, params object[] parameters)
        {
            Execute(query, parameters);
        }

        internal void UpdateLastModifiedTimestampHelper(string query, params object[] parameters)
        {
            Execute(query, parameters);
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
                Sqlite3Statement stmt = null;
                try
                {
                    stmt = ExecuteQuery(checkRecordExistsQuery, identityId, datasetName, record.Key);
                    while (Sqlite3.sqlite3_step(stmt) == Sqlite3.SQLITE_ROW)
                    {
                        recordsFound = Sqlite3.sqlite3_column_int(stmt, 0) > 0;
                    }
                }
                finally
                {
                    if (stmt != null)
                        Sqlite3.sqlite3_finalize(stmt);
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
                    
                     Execute(updateRecordQuery, record.Value, record.SyncCount, record.IsModified ? 1 : 0, record.LastModifiedDate, record.LastModifiedBy, record.DeviceLastModifiedDate, identityId, datasetName, record.Key);
                }
                else
                {
                    string insertRecord = RecordColumns.BuildInsert();
                    Execute(insertRecord, identityId, datasetName, record.Key, record.Value, record.SyncCount, record.LastModifiedDate, record.LastModifiedBy, record.DeviceLastModifiedDate, record.IsModified ? 1 : 0);
                }
            }
        }

#endregion

#region private methods

        private Sqlite3Statement ExecuteQuery(string query, params object[] parameters)
        {
            Sqlite3Statement statement;
            Result r = (Result)Enum.Parse(typeof(Result), Sqlite3.sqlite3_prepare_v2(Handle, query, out statement).ToString());
            if (r != Result.OK && r!= Result.Done && r!= Result.Row)
            {
                throw Sqlite3Exception.New(r, string.Format("Error executing statement {0}", r));
            }
            BindData(statement, parameters);
            return statement;
        }

        private void Execute(string query, params object[] parameters)
        {
            Sqlite3Statement statement = null;
            try
            {
                Result r = (Result)Enum.Parse(typeof(Result), Sqlite3.sqlite3_prepare_v2(Handle, query, out statement).ToString());
                if (r != Result.OK && r != Result.Done && r != Result.Row)
                {
                    throw Sqlite3Exception.New(r, string.Format("Error executing statement {0}", r));
                }
                BindData(statement, parameters);
                r = (Result)Enum.Parse(typeof(Result), Sqlite3.sqlite3_step(statement).ToString());
                if (r != Result.OK && r != Result.Done && r != Result.Row)
                {
                    throw Sqlite3Exception.New(r, string.Format("Error executing statement {0}", r));
                }
            }
            finally
            {
                if (statement != null)
                    Sqlite3.sqlite3_finalize(statement);
            }
        }

        private void BindData(Sqlite3Statement statement, params object[] parameters)
        {
            if (parameters != null)
            {
                for (int i = 1; i <= parameters.Length; i++)
                {
                    object o = parameters[i - 1];
                    if(o == null)
                    {
                        Sqlite3.sqlite3_bind_null(statement, i);
                        continue;
                    }

                    var type = o.GetType();
                    var dt = o as DateTime?;
                    if (dt.HasValue)
                    {
                        string ticks = dt.Value.Ticks.ToString();
                        Sqlite3.sqlite3_bind_text(statement, i, ticks);
                    }
                    else if (type == typeof(string))
                    {
                        Sqlite3.sqlite3_bind_text(statement, i, (string)o);
                    }
                    else if ((typeof(Int32) == type)
                            || (typeof(Boolean) == type)
                            || (typeof(Byte) == type)
                            || (typeof(UInt16) == type)
                            || (typeof(Int16) == type)
                            || (typeof(sbyte) == type)
                            || (typeof(Int64) == type)
                            || (typeof(long) == type)
                            || (typeof(UInt32) == type))
                    {
                        Sqlite3.sqlite3_bind_int64(statement, i,(Int64) Convert.ChangeType(o, typeof(Int64)));
                    }
                    else if ((typeof(double) == type)
                            || (typeof(float) == type)
                            || (typeof(decimal) == type))
                    {
                        Sqlite3.sqlite3_bind_double(statement, i, (double)o);
                    }
                    else if(type == typeof(byte[]))
                    {
                        Sqlite3.sqlite3_bind_blob(statement, i, (byte[])o);
                    }
                }
            }
        }
        
        private object GetColumnValue(Sqlite3Statement stmt, Type t, string columnName)
        {
            int columnCount = Sqlite3.sqlite3_column_count(stmt);
            int columnIndex = -1;
            int columnType = -1;
            for(int i = 0;i <columnCount; i++)
            {
                string colName = Sqlite3.sqlite3_column_name(stmt, i);
                if (colName.Equals(columnName, StringComparison.OrdinalIgnoreCase))
                {
                    columnIndex = i;
                    columnType = Sqlite3.sqlite3_column_type(stmt, i);
                    break;
                }
            }

            if(t == typeof(string))
            {
                return Sqlite3.sqlite3_column_text(stmt, columnIndex);
            }else if ((typeof(Int32) == t)
                    || (typeof(Boolean) == t)
                    || (typeof(Byte) == t)
                    || (typeof(UInt16) == t)
                    || (typeof(Int16) == t)
                    || (typeof(sbyte) == t))
            {
                return Convert.ChangeType(Sqlite3.sqlite3_column_int(stmt, columnIndex), t);
            }
            else if ((typeof(double) == t)
                   || (typeof(float) == t))
            {
                return Convert.ChangeType(Sqlite3.sqlite3_column_double(stmt, columnIndex), t);
            }
            else if (typeof(DateTime) == t)
            {
                string time = Sqlite3.sqlite3_column_text(stmt, columnIndex);
                return new DateTime(long.Parse(time, CultureInfo.InvariantCulture.NumberFormat), DateTimeKind.Utc);
            }
            else if (
                       (typeof(Int64) == t)
                    || (typeof(UInt32) == t)
                    )
            {
                return Convert.ChangeType(Sqlite3.sqlite3_column_int64(stmt, columnIndex), t, null);
            }
            else if (typeof(System.Nullable<long>) == t)
            {
                if (columnType == Sqlite3.SQLITE_NULL)
                {
                    return null;
                }
                else
                {
                    long? x = Sqlite3.sqlite3_column_int64(stmt, columnIndex);
                    return x;
                }
            }
            else if (typeof(System.Nullable<double>) == t)
            {
                if (columnType == Sqlite3.SQLITE_NULL)
                {
                    return null;
                }
                else
                {
                    double? x = Sqlite3.sqlite3_column_double(stmt, columnIndex);
                    return x;
                }
            }
            else if (typeof(System.Nullable<int>) == t)
            {
                if (columnType == Sqlite3.SQLITE_NULL)
                {
                    return null;
                }
                else
                {
                    int? x = Sqlite3.sqlite3_column_int(stmt, columnIndex);
                    return x;
                }
            }
            else if (typeof(decimal) == t)
            {
                return (decimal)Convert.ChangeType(Sqlite3.sqlite3_column_double(stmt, columnIndex), t);
            }
            else if (typeof(byte[]) == t)
            {
                return Sqlite3.sqlite3_column_blob(stmt, columnIndex);
            }
            else
            {
                throw new NotSupportedException("Invalid type conversion " + t.FullName);
            }
        }
        
        private DatasetMetadata SqliteStmtToDatasetMetadata(Sqlite3Statement stmt)
        {
            string datasetName = (string)GetColumnValue(stmt, typeof(string), RecordColumns.DATASET_NAME);
            DateTime creationTime = (DateTime)GetColumnValue(stmt, typeof(DateTime), DatasetColumns.CREATION_TIMESTAMP);
            DateTime lastModified = (DateTime)GetColumnValue(stmt, typeof(DateTime), DatasetColumns.LAST_MODIFIED_TIMESTAMP);
            string lastModifiedBy = (string)GetColumnValue(stmt, typeof(string), DatasetColumns.LAST_MODIFIED_BY);
            int storageSize = (int)GetColumnValue(stmt, typeof(int), DatasetColumns.STORAGE_SIZE_BYTES);
            int recordCount = (int)GetColumnValue(stmt, typeof(int), DatasetColumns.RECORD_COUNT);

            return new DatasetMetadata(datasetName, creationTime, lastModified, lastModifiedBy, storageSize, recordCount);
        }

        private Record SqliteStmtToRecord(Sqlite3Statement stmt)
        {
            string key = (string)GetColumnValue(stmt, typeof(string), RecordColumns.KEY);
            string value = (string)GetColumnValue(stmt, typeof(string), RecordColumns.VALUE);
            int syncCount = (int)GetColumnValue(stmt, typeof(int), RecordColumns.SYNC_COUNT);
            DateTime lastModified = (DateTime)GetColumnValue(stmt, typeof(DateTime), RecordColumns.LAST_MODIFIED_TIMESTAMP);
            string lastModifiedBy = (string)GetColumnValue(stmt, typeof(string), RecordColumns.LAST_MODIFIED_BY);
            DateTime deviceLastModifiedTimestamp = (DateTime)GetColumnValue(stmt, typeof(DateTime), RecordColumns.DEVICE_LAST_MODIFIED_TIMESTAMP);
            bool modified = (int)GetColumnValue(stmt, typeof(int), RecordColumns.MODIFIED) == 1;
            return new Record(key, 
                value, 
                syncCount,
                lastModified,
                lastModifiedBy,
                deviceLastModifiedTimestamp,
                modified);
        }
#endregion

    }
}

