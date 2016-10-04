/*
 * Copyright 2015-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

using Amazon.MobileAnalytics.Model;

using ThirdParty.Json.LitJson;
using Amazon.MobileAnalytics.MobileAnalyticsManager;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;
using Amazon.Util.Internal;
using System.Globalization;

using Sqlite3DatabaseHandle = SQLitePCL.sqlite3;
using Sqlite3Statement = SQLitePCL.sqlite3_stmt;
using Sqlite3 = SQLitePCL.raw;

using PCLStorage;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// Implementation of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.IEventStore"/>.
    /// The object stores Mobile Analytic events in SQLite database.
    /// </summary>
    public partial class SQLiteEventStore : IEventStore
    {

        internal Sqlite3DatabaseHandle Handle;
        internal static readonly Sqlite3DatabaseHandle NullHandle = default(Sqlite3DatabaseHandle);

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

        /// <summary>
        /// Sets up SQLite database.
        /// </summary>
        private void SetupSQLiteEventStore()
        {
            this.DBfileFullPath = System.IO.Path.Combine(PCLStorage.FileSystem.Current.LocalStorage.Path, dbFileName);
            string vacuumCommand = "PRAGMA auto_vacuum = 1";
            string sqlCommand = string.Format(CultureInfo.InvariantCulture, "CREATE TABLE IF NOT EXISTS {0} ({1} TEXT NOT NULL,{2} TEXT NOT NULL UNIQUE,{3} TEXT NOT NULL, {4}  INTEGER NOT NULL DEFAULT 0 )",
                TABLE_NAME, EVENT_COLUMN_NAME, EVENT_ID_COLUMN_NAME, MA_APP_ID_COLUMN_NAME, EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME);

            var r = Sqlite3.sqlite3_open(this.DBfileFullPath, out Handle);

            if (r != Sqlite3.SQLITE_OK)
            {
                throw Sqlite3Exception.New((Result)Enum.Parse(typeof(Result), r.ToString()), String.Format("Could not open database file: {0} ({1})", this.DBfileFullPath, r));
            }

            lock (_lock)
            {
                Execute(vacuumCommand);
                Execute(sqlCommand);
            }
        }


        /// <summary>
        /// Add an event to the store.
        /// </summary>
        /// <param name="eventString">Amazon Mobile Analytics event in string.</param>
        /// <param name="appID">Amazon Mobile Analytics App ID.</param>
        [System.Security.SecuritySafeCritical]
        public void PutEvent(string eventString, string appID)
        {
            long currentDatabaseSize = this.DatabaseSize;

            if (currentDatabaseSize >= _maConfig.MaxDBSize)
            {
                InvalidOperationException e = new InvalidOperationException();
                _logger.Error(e, "The database size has exceeded the threshold limit. Unable to insert any new events");
            }
            else if ((double)currentDatabaseSize / (double)_maConfig.MaxDBSize >= _maConfig.DBWarningThreshold)
            {
                _logger.InfoFormat("The database size is almost full");
            }
            else
            {
                string sqlCommand = string.Format(CultureInfo.InvariantCulture, "INSERT INTO {0}  ({1},{2},{3}) values(?,?,?)", TABLE_NAME, EVENT_COLUMN_NAME, EVENT_ID_COLUMN_NAME, MA_APP_ID_COLUMN_NAME);
                lock (_lock)
                {
                    Execute(sqlCommand, eventString, Guid.NewGuid().ToString(), appID);
                }
            }
        }

        /// <summary>
        /// Deletes a list of events.
        /// </summary>
        /// <param name="rowIds">List of row identifiers.</param>
        [System.Security.SecuritySafeCritical]
        public void DeleteEvent(List<string> rowIds)
        {
            string ids = string.Format(CultureInfo.InvariantCulture, "'{0}'", string.Join("', '", rowIds.ToArray()));
            string sqlCommand = string.Format(CultureInfo.InvariantCulture, "DELETE FROM {0} WHERE {1} IN ({2})", TABLE_NAME, EVENT_ID_COLUMN_NAME, ids);

            lock (_lock)
            {
                Execute(sqlCommand);
            }
        }

        /// <summary>
        /// Get events from the Event Store
        /// </summary>
        /// <param name="appID">Amazon Mobile Analytics App Id.</param>
        /// <param name="maxAllowed">Max number of events is allowed to return.</param>
        /// <returns>The events as a List of <see cref="ThirdParty.Json.LitJson.JsonData"/>.</returns>
        [System.Security.SecuritySafeCritical]
        public List<JsonData> GetEvents(string appID, int maxAllowed)
        {
            List<JsonData> eventList = new List<JsonData>();

            string sqlCommand = string.Format(CultureInfo.InvariantCulture, "SELECT * FROM {0} WHERE {1}  = ? ORDER BY {2},   ROWID LIMIT {3} ", TABLE_NAME, MA_APP_ID_COLUMN_NAME, EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME, maxAllowed);
            lock (_lock)
            {
                var stmt = ExecuteQuery(sqlCommand, appID);
                while (Sqlite3.sqlite3_step(stmt) == Sqlite3.SQLITE_ROW)
                {
                    JsonData data = new JsonData();
                    data["id"] = (string)GetColumnValue(stmt, typeof(string), EVENT_ID_COLUMN_NAME);
                    data["event"] = (string)GetColumnValue(stmt, typeof(string), EVENT_COLUMN_NAME);
                    data["appID"] = (string)GetColumnValue(stmt, typeof(string), MA_APP_ID_COLUMN_NAME);
                    eventList.Add(data);
                }
                Sqlite3.sqlite3_finalize(stmt); 
            }
            return eventList;
        }

        /// <summary>
        /// Gets Numbers the of events.
        /// </summary>
        /// <param name="appID">Amazon Mobile Analytics App Identifier.</param>
        /// <returns>The number of events.</returns>
        [System.Security.SecuritySafeCritical]
        public long NumberOfEvents(string appID)
        {
            long count = 0;

            string sqlCommand = string.Format(CultureInfo.InvariantCulture, "SELECT COUNT(*) C FROM {0} where {1} = ?", TABLE_NAME, MA_APP_ID_COLUMN_NAME);
            var stmt = ExecuteQuery(sqlCommand, appID);

            while (Sqlite3.sqlite3_step(stmt) == Sqlite3.SQLITE_ROW)
            {
                count = Sqlite3.sqlite3_column_int(stmt, 0);
            }

            Sqlite3.sqlite3_finalize(stmt);
             
            return count;
        }

        /// <summary>
        /// Gets the size of the database.
        /// </summary>
        /// <returns>The database size.</returns>
        public long DatabaseSize
        {
            get
            {
                string pageCountCommand = "PRAGMA page_count;";
                string pageSizeCommand = "PRAGMA page_size;";
                long pageCount = 0, pageSize = 0;

                lock (_lock)
                {
                    var stmt = ExecuteQuery(pageCountCommand);
                    while (Sqlite3.sqlite3_step(stmt) == Sqlite3.SQLITE_ROW)
                    {
                        pageCount = Sqlite3.sqlite3_column_int(stmt, 0);
                    }
                    Sqlite3.sqlite3_finalize(stmt);

                    stmt = ExecuteQuery(pageSizeCommand);
                    while (Sqlite3.sqlite3_step(stmt) == Sqlite3.SQLITE_ROW)
                    {
                        pageSize = Sqlite3.sqlite3_column_int(stmt, 0);
                    }
                    Sqlite3.sqlite3_finalize(stmt);
                }
                return pageCount * pageSize;
            }
        }

    #region private methods


    private Sqlite3Statement ExecuteQuery(string query, params object[] parameters)
    {
        Sqlite3Statement statement;
        Result r = (Result)Enum.Parse(typeof(Result), Sqlite3.sqlite3_prepare_v2(Handle, query, out statement).ToString());
        if (r != Result.OK && r != Result.Done && r != Result.Row)
        {
            throw Sqlite3Exception.New(r, string.Format("Error executing stateme {0}", r));
        }
        BindData(statement, parameters);
        return statement;
    }


    private void Execute(string query, params object[] parameters)
        {
            Sqlite3Statement statement;
            Result r = (Result)Enum.Parse(typeof(Result), Sqlite3.sqlite3_prepare_v2(Handle, query, out statement).ToString());
            if (r != Result.OK && r != Result.Done && r != Result.Row)
            {
                throw Sqlite3Exception.New(r, string.Format("Error executing stateme {0}", r));
            }
            BindData(statement, parameters);
            r = (Result)Enum.Parse(typeof(Result), Sqlite3.sqlite3_step(statement).ToString());
            if (r != Result.OK && r != Result.Done && r != Result.Row)
            {
                throw Sqlite3Exception.New(r, string.Format("Error executing stateme {0}", r));
            }
            Sqlite3.sqlite3_finalize(statement);
        }


        private void BindData(Sqlite3Statement statement, params object[] parameters)
        {
            if (parameters != null)
            {
                for (int i = 1; i <= parameters.Length; i++)
                {
                    object o = parameters[i - 1];
                    if (o == null)
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
                        Sqlite3.sqlite3_bind_text(statement, i, (String)o);
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
                        Sqlite3.sqlite3_bind_int64(statement, i, (int)Convert.ChangeType(o, typeof(int)));
                    }
                    else if ((typeof(double) == type)
                            || (typeof(float) == type)
                            || (typeof(decimal) == type))
                    {
                        Sqlite3.sqlite3_bind_double(statement, i, (double)o);
                    }
                    else if (type == typeof(byte[]))
                    {
                        Sqlite3.sqlite3_bind_blob(statement, i, (byte[])o);
                    }
                }
            }
        }

        private object GetColumnValue(Sqlite3Statement stmt, Type t, String columnName)
        {
            int columnCount = Sqlite3.sqlite3_column_count(stmt);
            int columnIndex = -1;
            int columnType = -1;
            for (int i = 0; i < columnCount; i++)
            {
                String colName = Sqlite3.sqlite3_column_name(stmt, i);
                if (colName.Equals(columnName, StringComparison.OrdinalIgnoreCase))
                {
                    columnIndex = i;
                    columnType = Sqlite3.sqlite3_column_type(stmt, i);
                    break;
                }
            }

            if (t == typeof(string))
            {
                return Sqlite3.sqlite3_column_text(stmt, columnIndex);
            }
            else if ((typeof(Int32) == t)
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
                throw new NotSupportedException("Invalid type conversion" + t);
            }
        }


        #endregion
    }

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

}

