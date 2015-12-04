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

using Amazon.Util.Internal;
using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using ThirdParty.Json.LitJson;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    public partial class SQLiteEventStore : IEventStore
    {
        private SqliteConnection connection;

        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this._isDisposed)
            {
                if (disposing)
                {
                    if (connection != null)
                    {
                        connection.Close();
                        connection.Dispose();
                    }
                }
                this._isDisposed = true;
            }
        }


        private void CreateOrOpenDatabase()
        {
            lock (_lock)
            {
                this.DBfileFullPath = System.IO.Path.Combine(AmazonHookedPlatformInfo.Instance.PersistentDataPath, dbFileName);

                string vacuumCommand = "PRAGMA auto_vacuum = 1";
                string sqlCommand = string.Format(CultureInfo.InvariantCulture, "CREATE TABLE IF NOT EXISTS {0} ({1} TEXT NOT NULL,{2} TEXT NOT NULL UNIQUE,{3} TEXT NOT NULL, {4}  INTEGER NOT NULL DEFAULT 0 )",
                    TABLE_NAME, EVENT_COLUMN_NAME, EVENT_ID_COLUMN_NAME, MA_APP_ID_COLUMN_NAME, EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME);

                bool toCreate = !File.Exists(this.DBfileFullPath);

                if (toCreate)
                {
                    string directory = Path.GetDirectoryName(this.DBfileFullPath);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }
                    SqliteConnection.CreateFile(this.DBfileFullPath);
                }
                try
                {
                    connection = new SqliteConnection("URI=file:" + this.DBfileFullPath);
                    connection.Open();
                    if (toCreate)
                    {
                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = vacuumCommand;
                            command.ExecuteNonQuery();
                        }
                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = sqlCommand;
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

        /// <summary>
        /// Sets up database.
        /// </summary>
        private void SetupSQLiteEventStore()
        {
            CreateOrOpenDatabase();
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
                    string query = string.Format(CultureInfo.InvariantCulture, "INSERT INTO {0}  ({1},{2},{3}) values(@eventString , @eventId , @appid )", TABLE_NAME, EVENT_COLUMN_NAME, EVENT_ID_COLUMN_NAME, MA_APP_ID_COLUMN_NAME);

                    try
                    {
                        connection = new SqliteConnection("URI=file:" + this.DBfileFullPath);
                        connection.Open();
                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = query;
                            BindData(command, eventString, Guid.NewGuid().ToString(), appId);
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

        /// <summary>
        /// Deletes a list of events.
        /// </summary>
        /// <returns><c>true</c>, if events was deleted, <c>false</c> otherwise.</returns>
        /// <param name="rowIds">Row identifiers.</param>
        public void DeleteEvent(List<string> rowIds)
        {
            lock (_lock)
            {
                try
                {
                    connection = new SqliteConnection("URI=file:" + this.DBfileFullPath);
                    connection.Open();
                    string ids = string.Format(CultureInfo.InvariantCulture, "'{0}'", string.Join("', '", rowIds.ToArray()));
                    string query = string.Format(CultureInfo.InvariantCulture, "DELETE FROM {0} WHERE {1} IN ({2})", TABLE_NAME, EVENT_ID_COLUMN_NAME, ids);
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;
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

        /// <summary>
        /// Get All event from the Event Store
        /// </summary>
        /// <param name="appID">Appid.</param>
        /// <param name="maxAllowed">maximum number of events to fetch</param>
        /// <returns>All the events as a List of <see cref="ThirdParty.Json.LitJson.JsonData"/>.</returns>
        public List<JsonData> GetEvents(string appID, int maxAllowed)
        {
            List<JsonData> eventList = new List<JsonData>();
            lock (_lock)
            {
                try
                {
                    connection = new SqliteConnection("URI=file:" + this.DBfileFullPath);
                    connection.Open();
                    string query = string.Format(CultureInfo.InvariantCulture, "SELECT {0},{1},{2} FROM {3} WHERE {4}  = @appId ORDER BY {5}, ROWID LIMIT {6} ",
                        EVENT_ID_COLUMN_NAME, EVENT_COLUMN_NAME, MA_APP_ID_COLUMN_NAME, TABLE_NAME, MA_APP_ID_COLUMN_NAME, EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME, maxAllowed);
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        BindData(command, appID);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    JsonData data = new JsonData();
                                    data["id"] = reader.GetString(0);
                                    data["event"] = reader.GetString(1);
                                    data["appId"] = reader.GetString(2);
                                    eventList.Add(data);
                                }
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

                try
                {
                    connection = new SqliteConnection("URI=file:" + this.DBfileFullPath);
                    connection.Open();
                    string query = string.Format(CultureInfo.InvariantCulture, "SELECT COUNT(*) C FROM {0} where {1} = @appId ", TABLE_NAME, MA_APP_ID_COLUMN_NAME);

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        BindData(command, appID);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                UnityEngine.Debug.Log("HAS ROWS = TRUE");
                                while (reader.Read())
                                {
                                    count = reader.GetInt32(0);
                                    UnityEngine
                                        .Debug.Log(string.Format("count = {0}", count));
                                }
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
            }

            return count;
        }

        /// <summary>
        /// Increments the delivery attempt.
        /// </summary>
        /// <returns>Success of operation</returns>
        /// <param name="rowIds">Row identifiers.</param>
        public bool IncrementDeliveryAttempt(List<string> rowIds)
        {
            bool success = false;
            lock (_lock)
            {
                try
                {
                    connection = new SqliteConnection("URI=file:" + this.DBfileFullPath);
                    connection.Open();
                    string ids = "'" + String.Join("', '", rowIds.ToArray()) + "'";
                    string query = String.Format("UPDATE " + TABLE_NAME + " SET " + EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME + "= " + EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME + "+1 WHERE " + EVENT_ID_COLUMN_NAME + " IN ({0})", ids);
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;
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
                return success;
            }
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
                    try
                    {
                        connection = new SqliteConnection("URI=file:" + this.DBfileFullPath);
                        connection.Open();
                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = pageCountCommand;
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        pageCount = reader.GetInt64(0);
                                    }
                                }
                            }


                            command.CommandText = pageSizeCommand;
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        pageSize = reader.GetInt64(0);
                                    }
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
                }
                return pageCount * pageSize;
            }
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

    }
}

