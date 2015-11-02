/*
 * Copyright 2012-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using UnityEngine;

using Amazon.Util.Storage;
using Amazon.MobileAnalytics.Model;

using ThirdParty.Json.LitJson;
using Amazon.MobileAnalytics.MobileAnalyticsManager;
using Amazon.Util.Storage.Internal;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;
using Amazon.Util.Internal;
using System.Globalization;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    public partial class SQLiteEventStore : IEventStore
    {
        private static SQLiteDatabase db;

        /// <summary>
        /// Initializes the <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.SQLiteEventStore"/> class.
        /// </summary>
        static SQLiteEventStore()
        {
            _dbFileFullPath = System.IO.Path.Combine(AmazonHookedPlatformInfo.Instance.PersistentDataPath, dbFileName);
            SetupSQLiteEventStore();
        }

        /// <summary>
        /// Sets up database.
        /// </summary>
        /// <param name="dbPath">Db path.</param>
        private static void SetupSQLiteEventStore()
        {
            lock (_lock)
            {
                SQLiteStatement stmt = null;
                try
                {
                    db = new SQLiteDatabase(_dbFileFullPath);

                    //turn on auto vacuuming so that when events are deleted, then we can recover the table space.
                    string vacuumCommand = "PRAGMA auto_vacuum = 1";
                    db.Exec(vacuumCommand);

                    string query = string.Format(CultureInfo.InvariantCulture, "CREATE TABLE IF NOT EXISTS {0} ({1} TEXT NOT NULL,{2} TEXT NOT NULL UNIQUE,{3} TEXT NOT NULL, {4}  INTEGER NOT NULL DEFAULT 0 )",
                 TABLE_NAME, EVENT_COLUMN_NAME, EVENT_ID_COLUMN_NAME, MA_APP_ID_COLUMN_NAME, EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME);

                    db.Exec(query);
                }
                finally
                {
                    if (stmt != null)
                        stmt.FinalizeStm();
                }
            }
        }

        /// <summary>
        /// Add an event to the store.
        /// </summary>
        /// <returns><c>true</c>, if event was put, <c>false</c> otherwise.</returns>
        public void PutEvent(string eventString, string appId)
        {
            bool proceedToInsert = false;
            long currentDatabaseSize = DatabaseSize;

            if (string.IsNullOrEmpty(appId))
                throw new ArgumentNullException("AppId");

            if (currentDatabaseSize >= _maConfig.MaxDBSize)
            {
                proceedToInsert = false;

                InvalidOperationException e = new InvalidOperationException();
                _logger.Error(e, "The database size has exceeded the threshold limit. Unable to insert any new events");
            }
            else if ((double)currentDatabaseSize / (double)_maConfig.MaxDBSize >= _maConfig.DBWarningThreshold)
            {
                proceedToInsert = true;
                _logger.InfoFormat("The database size is almost full");
            }
            else
            {
                proceedToInsert = true;
            }


            //keep the lock as short as possible
            if (proceedToInsert)
            {
                lock (_lock)
                {
                    SQLiteStatement stmt = null;
                    try
                    {
                        string query = string.Format(CultureInfo.InvariantCulture, "INSERT INTO {0}  ({1},{2},{3}) values(?,?,?)", TABLE_NAME, EVENT_COLUMN_NAME, EVENT_ID_COLUMN_NAME, MA_APP_ID_COLUMN_NAME);
                        stmt = db.Prepare(query);
                        stmt.BindText(1, eventString);
                        stmt.BindText(2, Guid.NewGuid().ToString());
                        stmt.BindText(3, appId);
                        stmt.Step();
                    }
                    finally
                    {
                        if (stmt != null)
                            stmt.FinalizeStm();
                    }
                }
            }

        }

        /// <summary>
        /// Deletes a list of events.
        /// </summary>
        /// <returns><c>true</c>, if events was deleted, <c>false</c> otherwise.</returns>
        /// <param name="rowIds">Row identifiers.</param>
        public void DeleteEvent(List<string> rowIds)
        {
            bool success = false;
            lock (_lock)
            {
                SQLiteStatement stmt = null;
                try
                {
                    string ids = string.Format(CultureInfo.InvariantCulture, "'{0}'", string.Join("', '", rowIds.ToArray()));
                    string query = string.Format(CultureInfo.InvariantCulture, "DELETE FROM {0} WHERE {1} IN ({2})", TABLE_NAME, EVENT_ID_COLUMN_NAME, ids);
                    stmt = db.Prepare(query);
                    stmt.Step();
                }
                finally
                {
                    if (stmt != null)
                        stmt.FinalizeStm();
                }
            }
        }

        /// <summary>
        /// Get All event from the Event Store
        /// </summary>
        /// <param name="appid">Appid.</param>
        /// <returns>All the events as a List of <see cref="ThirdParty.Json.LitJson.JsonData"/>.</returns>
        public List<JsonData> GetEvents(string appID, int maxAllowed)
        {
            List<JsonData> eventList = new List<JsonData>();
            lock (_lock)
            {
                SQLiteStatement stmt = null;
                try
                {
                    string query = string.Format(CultureInfo.InvariantCulture, "SELECT * FROM {0} WHERE {1}  = ? ORDER BY {2},   ROWID LIMIT {3} ", TABLE_NAME, MA_APP_ID_COLUMN_NAME, EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME, maxAllowed);
                    stmt = db.Prepare(query);
                    stmt.BindText(1, appID);
                    while (stmt.Read())
                    {
                        JsonData data = new JsonData();
                        data["id"] = stmt.Fields[EVENT_ID_COLUMN_NAME].TEXT;
                        data["event"] = stmt.Fields[EVENT_COLUMN_NAME.ToLower()].TEXT;
                        data["appId"] = stmt.Fields[MA_APP_ID_COLUMN_NAME].TEXT;
                        eventList.Add(data);
                    }
                }
                finally
                {
                    if (stmt != null)
                        stmt.FinalizeStm();
                }
            }

            return eventList;
        }

        /// <summary>
        /// Gets Numbers the of events.
        /// </summary>
        /// <returns>The number of events.</returns>
        public long NumberOfEvents(string appID)
        {
            long count = 0;
            lock (_lock)
            {
                SQLiteStatement stmt = null;
                try
                {
                    string query = string.Format(CultureInfo.InvariantCulture, "SELECT COUNT(*) C FROM {0} where {1} = ?", TABLE_NAME, MA_APP_ID_COLUMN_NAME);
                    stmt = db.Prepare(query);
                    stmt.BindText(1, appID);
                    while (stmt.Read())
                    {
                        count = stmt.Fields["C"].INTEGER;
                    }
                }
                finally
                {
                    if (stmt != null)
                        stmt.FinalizeStm();
                }

            }

            return count;
        }

        /// <summary>
        /// Increments the delivery attempt.
        /// </summary>
        /// <returns>true</returns>
        /// <c>false</c>
        /// <param name="rowIds">Row identifiers.</param>
        public bool IncrementDeliveryAttempt(List<string> rowIds)
        {
            bool success = false;
            lock (_lock)
            {
                SQLiteStatement stmt = null;
                try
                {
                    string ids = "'" + String.Join("', '", rowIds.ToArray()) + "'";
                    string query = String.Format("UPDATE " + TABLE_NAME + " SET " + EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME + "= " + EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME + "+1 WHERE " + EVENT_ID_COLUMN_NAME + " IN ({0})", ids);
                    stmt = db.Prepare(query);
                    stmt.Step();
                    success = true;
                }
                finally
                {
                    if (stmt != null)
                        stmt.FinalizeStm();
                }
            }
            return success;
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
                SQLiteStatement stmt = null;
                lock (_lock)
                {
                    try
                    {
                        stmt = db.Prepare(pageCountCommand);

                        pageCount = stmt.Fields["page_count"].INTEGER;

                        stmt = db.Prepare(pageSizeCommand);
                        pageSize = stmt.Fields["page_size"].INTEGER;
                    }
                    finally
                    {
                        if (stmt != null)
                            stmt.FinalizeStm();
                    }
                }
                return pageCount * pageSize;
            }
        }

    }
}

