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

using SQLitePCL;
using PCLStorage;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// Implementation of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.IEventStore"/>.
    /// The object stores Mobile Analytic events in SQLite database.
    /// </summary>
    public partial class SQLiteEventStore : IEventStore
    {

        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {

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

            lock (_lock)
            {
#if __IOS__
                SQLitePCL.CurrentPlatform.Init();
#endif
                using (var connection = new SQLiteConnection(this.DBfileFullPath))
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
                    using (var connection = new SQLiteConnection(this.DBfileFullPath))
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
                using (var connection = new SQLiteConnection(this.DBfileFullPath))
                {
                    using (var statement = connection.Prepare(sqlCommand))
                    {
                        statement.Step();
                    }
                }
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
                using (var connection = new SQLiteConnection(this.DBfileFullPath))
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
            using (var connection = new SQLiteConnection(this.DBfileFullPath))
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
                    using (var connection = new SQLiteConnection(this.DBfileFullPath))
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
            }
        }
    }
}

