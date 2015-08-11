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

#if BCL
using System.Data.SQLite;
#elif PCL
using SQLitePCL;
using PCLStorage;
#endif

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// Implementation of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.IEventStore"/>.
    /// The object stores Mobile Analytic events in SQLite database.
    /// </summary>
    [System.Security.SecuritySafeCritical]
    public class SQLiteEventStore : IEventStore
    {
        private Logger _logger = Logger.GetLogger(typeof(SQLiteEventStore));
        private const String TABLE_NAME = "ma_events";
        private const String EVENT_COLUMN_NAME = "ma_event";
        private const String EVENT_ID_COLUMN_NAME = "ma_event_id";
        private const String EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME = "ma_delivery_attempt_count";
        private const String MA_APP_ID_COLUMN_NAME = "ma_app_id";
        private const String TABLE_ROWID = "ROWID";
        private const String DB_SIZE_KEY = "MAX_DB_SIZE";
        private const String DB_WARNING_THRESHOLD_KEY = "DB_WARNING_THRESHOLD";
        private const String dbFileName = "mobile_analytic_event.db";

        // platform specific db file path
        private String _dbFileFullPath;
        private object _lock = new object();
        private MobileAnalyticsManagerConfig _maConfig;

        /// <summary>
        /// Constructor of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.SQLiteEventStore"/>
        /// </summary>
        /// <param name="maConfig">Mobile Analytics Manager Configuration.</param>
        public SQLiteEventStore(MobileAnalyticsManagerConfig maConfig)
        {
            _maConfig = maConfig;
#if BCL
            _dbFileFullPath = InternalSDKUtils.DetermineAppLocalStoragePath(dbFileName);
            //_dbFileFullPath = dbFileName; 
#elif PCL
            _dbFileFullPath = System.IO.Path.Combine(PCLStorage.FileSystem.Current.LocalStorage.Path, dbFileName);
#endif
            _logger.InfoFormat("Initialize SQLite event store. The SQLite DB file path is {0}.", _dbFileFullPath);
            SetupSQLiteEventStore();
        }


        /// <summary>
        /// Sets up SQLite database.
        /// </summary>
        private void SetupSQLiteEventStore()
        {
            string vacuumCommand = "PRAGMA auto_vacuum = 1";
            string sqlCommand = string.Format(CultureInfo.InvariantCulture, "CREATE TABLE IF NOT EXISTS {0} ({1} TEXT NOT NULL,{2} TEXT NOT NULL UNIQUE,{3} TEXT NOT NULL, {4}  INTEGER NOT NULL DEFAULT 0 )",
                TABLE_NAME, EVENT_COLUMN_NAME, EVENT_ID_COLUMN_NAME, MA_APP_ID_COLUMN_NAME, EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME);
#if BCL
            lock (_lock)
            {
                using (var connection = new SQLiteConnection("Data Source=" + _dbFileFullPath + ";Version=3;"))
                {
                    try
                    {
                        if (!File.Exists(_dbFileFullPath))
                        {
                            string directory = Path.GetDirectoryName(_dbFileFullPath);
                            if (!Directory.Exists(directory))
                            {
                                Directory.CreateDirectory(directory);
                            }
                            SQLiteConnection.CreateFile(_dbFileFullPath);
                        }

                        connection.Open();
                        using (var command = new SQLiteCommand(vacuumCommand, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        using (var command = new SQLiteCommand(sqlCommand, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    finally
                    {
                        if (null != connection)
                            connection.Close();
                    }
                }
            }
#elif PCL
            lock (_lock)
            {
#if __IOS__
                SQLitePCL.CurrentPlatform.Init();
#endif
                using (var connection = new SQLiteConnection(_dbFileFullPath))
                {
                    using (var statement = connection.Prepare(vacuumCommand))
                    {
                        statement.Step();
                    }
                    using (var createTableStmt = connection.Prepare(sqlCommand))
                    {
                        createTableStmt.Step();
                    }
                }
            }
#endif
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
#if BCL
                string sqlCommand = string.Format(CultureInfo.InvariantCulture, "INSERT INTO {0}  ({1},{2},{3}) values(@event,@id,@appID)", TABLE_NAME, EVENT_COLUMN_NAME, EVENT_ID_COLUMN_NAME, MA_APP_ID_COLUMN_NAME);
                lock (_lock)
                {
                    using (var connection = new SQLiteConnection("Data Source=" + _dbFileFullPath + ";Version=3;"))
                    {
                        try
                        {
                            connection.Open();
                            using (var command = new SQLiteCommand(sqlCommand, connection))
                            {
                                command.Parameters.Add(new SQLiteParameter("@event", eventString));
                                command.Parameters.Add(new SQLiteParameter("@id", Guid.NewGuid().ToString()));
                                command.Parameters.Add(new SQLiteParameter("@appID", appID));
                                command.ExecuteNonQuery();
                            }
                        }
                        finally
                        {
                            if (null != connection)
                                connection.Close();
                        }
                    }
                }
#elif PCL
                string sqlCommand = string.Format(CultureInfo.InvariantCulture, "INSERT INTO {0}  ({1},{2},{3}) values(?,?,?)", TABLE_NAME, EVENT_COLUMN_NAME, EVENT_ID_COLUMN_NAME, MA_APP_ID_COLUMN_NAME);              
                lock (_lock)
                {
                    using (var connection = new SQLiteConnection(_dbFileFullPath))
                    {
                        using (var statement = connection.Prepare(sqlCommand))
                        {
                            statement.Bind(1, eventString);
                            statement.Bind(2, Guid.NewGuid().ToString());
                            statement.Bind(3, appID);
                            statement.Step();
                        }
                    }
                }
#endif
            }
        }

        /// <summary>
        /// Deletes a list of events.
        /// </summary>
        /// <param name="rowIds">List of row identifiers.</param>
        [System.Security.SecuritySafeCritical]
        public void DeleteEvent(List<string> rowIds)
        {
            string ids = "'" + string.Join("', '", rowIds.ToArray()) + "'";
            string sqlCommand = string.Format(CultureInfo.InvariantCulture, "DELETE FROM " + TABLE_NAME + " WHERE " + EVENT_ID_COLUMN_NAME + " IN ({0})", ids);
#if BCL
            SQLiteConnection connection = null;
            lock (_lock)
            {
                using (connection = new SQLiteConnection("Data Source=" + _dbFileFullPath + ";Version=3;"))
                {
                    try
                    {
                        connection.Open();
                        using (var command = new SQLiteCommand(sqlCommand, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    finally
                    {
                        if (null != connection)
                            connection.Close();
                    }
                }
            }
#elif PCL
            lock (_lock)
            {
                using (var connection = new SQLiteConnection(_dbFileFullPath))
                {
                    using (var statement = connection.Prepare(sqlCommand))
                    {
                        statement.Step();
                    }
                }
            }
#endif
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
#if BCL
            string sqlCommand = string.Format(CultureInfo.InvariantCulture, "SELECT * FROM {0} WHERE {1}  = @appID ORDER BY {2},   ROWID LIMIT {3} ", TABLE_NAME, MA_APP_ID_COLUMN_NAME, EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME, maxAllowed);
            lock (_lock)
            {
                using (var connection = new SQLiteConnection("Data Source=" + _dbFileFullPath + ";Version=3;"))
                {
                    try
                    {
                        connection.Open();
                        using (var command = new SQLiteCommand(sqlCommand, connection))
                        {
                            command.Parameters.Add(new SQLiteParameter("@appID", appID));
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    JsonData data = new JsonData();
                                    data["id"] = reader[EVENT_ID_COLUMN_NAME].ToString();
                                    data["event"] = reader[EVENT_COLUMN_NAME.ToUpperInvariant()].ToString();
                                    data["appID"] = reader[MA_APP_ID_COLUMN_NAME].ToString();
                                    eventList.Add(data);
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (null != connection)
                            connection.Close();
                    }
                }

            }
#elif PCL
            string sqlCommand = string.Format(CultureInfo.InvariantCulture, "SELECT * FROM {0} WHERE {1}  = ? ORDER BY {2},   ROWID LIMIT {3} ", TABLE_NAME, MA_APP_ID_COLUMN_NAME, EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME, maxAllowed);  
            lock (_lock)
            {
                using (var connection = new SQLiteConnection(_dbFileFullPath))
                {
                    using (var statement = connection.Prepare(sqlCommand))
                    {
                        statement.Bind(1, appID);
                        while (statement.Step() == SQLiteResult.ROW)
                        {
                            JsonData data = new JsonData();
                            data["id"] = statement.GetText(EVENT_ID_COLUMN_NAME);
                            data["event"] = statement.GetText(EVENT_COLUMN_NAME.ToLower());
                            data["appID"] = statement.GetText(MA_APP_ID_COLUMN_NAME);
                            eventList.Add(data);
                        }
                    }
                }
            }
#endif
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
#if BCL
            string sqlCommand = string.Format(CultureInfo.InvariantCulture, "SELECT COUNT(*) C FROM {0} where {1} = @appID", TABLE_NAME, MA_APP_ID_COLUMN_NAME);
            using (var connection = new SQLiteConnection("Data Source=" + _dbFileFullPath + ";Version=3;"))
            {
                try
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(sqlCommand, connection))
                    {
                        command.Parameters.Add(new SQLiteParameter("@appID", appID));
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                count = (long)reader["C"];
                            }
                        }
                    }
                }
                finally
                {
                    if (null != connection)
                        connection.Close();
                }
            }

#elif PCL
            string sqlCommand = string.Format(CultureInfo.InvariantCulture, "SELECT COUNT(*) C FROM {0} where {1} = ?", TABLE_NAME, MA_APP_ID_COLUMN_NAME);
            using (var connection = new SQLiteConnection(_dbFileFullPath))
            {
                using (var statement = connection.Prepare(sqlCommand))
                {
                    statement.Bind(1, appID);
                    while (statement.Step() == SQLiteResult.ROW)
                    {
                        count = statement.GetInteger("C");
                    }
                }
            }
#endif
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
#if BCL
                FileInfo fileInfo = new FileInfo(_dbFileFullPath);
                return fileInfo.Length;
#elif PCL
                string pageCountCommand = "PRAGMA page_count;";
                string pageSizeCommand = "PRAGMA page_size;";
                long pageCount = 0, pageSize = 0;

                lock (_lock)
                {
                    using (var connection = new SQLiteConnection(_dbFileFullPath))
                    {
                        using (var statement = connection.Prepare(pageCountCommand))
                        {
                            while (statement.Step() == SQLiteResult.ROW)
                            {
                                pageCount = statement.GetInteger(0);
                            }
                        }

                        using (var statement = connection.Prepare(pageSizeCommand))
                        {
                            while (statement.Step() == SQLiteResult.ROW)
                            {
                                pageSize = statement.GetInteger(0);
                            }
                        }
                    }
                }
                return pageCount * pageSize;
#endif
            }
        }

        /// <summary>
        /// Get the SQLite Event Store's database file full path.
        /// </summary>
        /// <returns> The database file full path. </returns>
        public string DBfileFullPath
        {
            get
            {
                return _dbFileFullPath;
            }
        }

    }
}

