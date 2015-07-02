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

#if BCL35 || BCL45
using System.Data.SQLite;
#elif PCL 
using PCLStorage;
using SQLitePCL;
#endif



namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// Implementation of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.IEventStore"/>.
    /// The object stores Mobile Analytic events in SQLite database.
    /// </summary>
    public class SQLiteEventStore : IEventStore
    {

        private static Logger _logger = Logger.GetLogger(typeof(SQLiteEventStore));
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
        private static String _dbFileFullPath = null;
        private static object _lock = new object();
        private MobileAnalyticsManagerConfig _maConfig;
        
        /// <summary>
        /// Initializes the <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.SQLiteEventStore"/> class.
        /// </summary>
        static SQLiteEventStore()
        {

#if BCL35 || BCL45
            _dbFileFullPath = dbFileName;
#elif PCL
            _dbFileFullPath = System.IO.Path.Combine(PCLStorage.FileSystem.Current.LocalStorage.Path, dbFileName);
#endif      
            SetUpDatabase(dbFileName);
        }

        /// <summary>
        /// Constructor of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.SQLiteEventStore"/>
        /// </summary>
        /// <param name="maConfig">Mobile Analytics Manager Configuration.</param>
        public SQLiteEventStore(MobileAnalyticsManagerConfig maConfig)
        {
            _maConfig = maConfig;
        }


        /// <summary>
        /// Sets up SQLite database.
        /// </summary>
        /// <param name="dbPath">Database file full path.</param>
        private static void SetUpDatabase(String dbPath)
        {
#if __IOS__
            SQLitePCL.CurrentPlatform.Init();
#endif

            string vacuumCommand = "PRAGMA auto_vacuum = 1";
            string sqlCommand = "CREATE TABLE IF NOT EXISTS " + TABLE_NAME + " ("
                + EVENT_COLUMN_NAME + " TEXT NOT NULL," + EVENT_ID_COLUMN_NAME + " TEXT NOT NULL UNIQUE,"
                + MA_APP_ID_COLUMN_NAME + " TEXT NOT NULL,"
                + EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME + " INTEGER NOT NULL DEFAULT 0)";
#if BCL35 || BCL45
            if (!File.Exists(_dbFileFullPath))
                SQLiteConnection.CreateFile(_dbFileFullPath);
            SQLiteConnection connection = null;
            try
            {
                lock (_lock)
                {
                    connection = new SQLiteConnection("Data Source=" + _dbFileFullPath + ";Version=3;");
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(vacuumCommand, connection);
                    command.ExecuteNonQuery();
                    
                    command = new SQLiteCommand(sqlCommand, connection);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                _logger.Error(e, "Get exception from SetUpDatabase");
            }
            finally
            {
                if (null != connection)
                    connection.Close();
            }
#elif PCL 
            try
            {
                lock (_lock)
                {
                    using (var connection = new SQLiteConnection(_dbFileFullPath))
                    {
                        using (var statement = connection.Prepare(vacuumCommand))
                        {
                            statement.Step();
                        }

                        _logger.InfoFormat("run SQL command : {0}", sqlCommand);
                        using (var createTableStmt = connection.Prepare(sqlCommand))
                        {
                            createTableStmt.Step();
                        }
                    }
                }

            }
            catch (Exception e)
            {
                _logger.Error(e, "Get exception from SetUpDatabase");
            }
#endif
        }


        /// <summary>
        /// Add an event to the store.
        /// </summary>
        /// <param name="eventString">Amazon Mobile Analytics event in string.</param>
        /// <param name="appId">Amazon Mobile Analytics App ID.</param>
        /// <returns><c>true</c>, if event was put, <c>false</c> otherwise.</returns>
        public bool PutEvent(string eventString, string appId)
        {
            
            bool result = false;
            long currentDatabaseSize = GetDatabaseSize();

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

#if BCL35 || BCL45
                string sqlCommand = "INSERT INTO " + TABLE_NAME + " (" + EVENT_COLUMN_NAME + "," + EVENT_ID_COLUMN_NAME + "," + MA_APP_ID_COLUMN_NAME + ") values(@event,@id,@appId)";
                SQLiteConnection connection = null;
                lock (_lock)
                {
                    try
                    {
                        connection = new SQLiteConnection("Data Source=" + _dbFileFullPath + ";Version=3;");
                        connection.Open();
                        SQLiteCommand command = new SQLiteCommand(sqlCommand, connection);
                        command.Parameters.Add(new SQLiteParameter("@event",eventString));
                        command.Parameters.Add(new SQLiteParameter("@id", Guid.NewGuid().ToString()));
                        command.Parameters.Add(new SQLiteParameter("@appId", appId));
                        command.ExecuteNonQuery();
                        result = true;
                    }
                    catch (Exception e)
                    {
                        _logger.Error(e, "Get exception when putting event into local storage.");
                        result = false;
                    }
                    finally 
                    {
                        if (null != connection)
                            connection.Close();
                    }
                }
#elif PCL 
                string sqlCommand = "INSERT INTO " + TABLE_NAME + " (" + EVENT_COLUMN_NAME + "," + EVENT_ID_COLUMN_NAME + "," + MA_APP_ID_COLUMN_NAME + ") values(?,?,?)";
                lock (_lock)
                {
                    try
                    {
                        using (var connection = new SQLiteConnection(_dbFileFullPath))
                        {  
                            using (var statement = connection.Prepare(sqlCommand))
                            {
                                statement.Bind(1, eventString);
                                statement.Bind(2, Guid.NewGuid().ToString());
                                statement.Bind(3, appId);
                                statement.Step();
                                result = true;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        _logger.Error(e, "Get exception when putting event into local storage.");
                        result = false;
                    }
                }
#endif
            }

            return result;
        }

        /// <summary>
        /// Deletes a list of events.
        /// </summary>
        /// <param name="rowIds">List of row identifiers.</param>
        /// <returns><c>true</c>, if events was deleted, <c>false</c> otherwise.</returns>
        public bool DeleteEvent(List<string> rowIds)
        {
            bool result = false;
            string ids = "'" + String.Join("', '", rowIds.ToArray()) + "'";
            string sqlCommand = String.Format("DELETE FROM " + TABLE_NAME + " WHERE " + EVENT_ID_COLUMN_NAME + " IN ({0})", ids);
            lock (_lock)
            {
#if BCL35 || BCL45
                SQLiteConnection connection = null;
                try
                {
                    connection = new SQLiteConnection("Data Source=" + _dbFileFullPath + ";Version=3;");
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(sqlCommand, connection);
                    command.ExecuteNonQuery();
                    result = true;
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Get exception when deleting event from local storage.");
                    result = false;
                }
                finally 
                {
                    if (null != connection)
                        connection.Close();
                }

#elif PCL           
                try
                {
                    using (var connection = new SQLiteConnection(_dbFileFullPath))
                    {
                        using (var statement = connection.Prepare(sqlCommand))
                        {
                            statement.Step();
                            result = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Get exception when deleting event from local storage.");
                    result = false;
                }  
#endif
            }
            return result;
        }

        /// <summary>
        /// Get events from the Event Store
        /// </summary>
        /// <param name="appId">Amazon Mobile Analytics App Id.</param>
        /// <param name="maxAllowed">Max number of events is allowed to return.</param>
        /// <returns>The events as a List of <see cref="ThirdParty.Json.LitJson.JsonData"/>.</returns>
        public List<JsonData> GetEvents(string appId, int maxAllowed)
        {
            
            List<JsonData> eventList = new List<JsonData>();
            lock (_lock)
            {
#if BCL35 || BCL45
                string sqlCommand = "SELECT * FROM " + TABLE_NAME + " WHERE " + MA_APP_ID_COLUMN_NAME + " = @appId  ORDER BY " + EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME + ",ROWID LIMIT " + maxAllowed;
                SQLiteConnection connection = null;
                try
                {
                    connection = new SQLiteConnection("Data Source=" + _dbFileFullPath + ";Version=3;");
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(sqlCommand, connection);
                    command.Parameters.Add(new SQLiteParameter("@appId", appId));
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        JsonData data = new JsonData();
                        data["id"] = reader[EVENT_ID_COLUMN_NAME].ToString();
                        data["event"] = reader[EVENT_COLUMN_NAME.ToLower()].ToString();
                        data["appId"] = reader[MA_APP_ID_COLUMN_NAME].ToString();

                        eventList.Add(data);
                    }
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Exception happens when getting events.");
                }
                finally 
                {
                    if (null != connection)
                        connection.Close();
                }
#elif PCL 
                string sqlCommand = "SELECT * FROM " + TABLE_NAME + " WHERE " + MA_APP_ID_COLUMN_NAME + " = ?  ORDER BY " + EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME + ",ROWID LIMIT " + maxAllowed;
                try
                {
                    using (var connection = new SQLiteConnection(_dbFileFullPath))
                    {
                        using (var statement = connection.Prepare(sqlCommand))
                        {
                            statement.Bind(1, appId);
                            while (statement.Step() == SQLiteResult.ROW)
                            {
                                JsonData data = new JsonData();
                                data["id"] = statement.GetText(EVENT_ID_COLUMN_NAME);
                                data["event"] = statement.GetText(EVENT_COLUMN_NAME.ToLower());
                                data["appId"] = statement.GetText(MA_APP_ID_COLUMN_NAME);

                                eventList.Add(data);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Exception happens when getting events.");
                }
#endif
            }

            return eventList;
        }

        /// <summary>
        /// Gets Numbers the of events.
        /// </summary>
        /// <param name="appId">Amazon Mobile Analytics App Identifier.</param>
        /// <returns>The number of events.</returns>
        public long NumberOfEvents(string appId)
        {
            
            long count = 0;
            lock (_lock)
            {
#if BCL35 || BCL45
                string sqlCommand = "SELECT COUNT(*) C FROM " + TABLE_NAME + " where " + MA_APP_ID_COLUMN_NAME + " = @appId";
                SQLiteConnection connection = null;
                try
                {
                    connection = new SQLiteConnection("Data Source=" + _dbFileFullPath + ";Version=3;");
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(sqlCommand, connection);
                    command.Parameters.Add(new SQLiteParameter("@appId", appId));
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        count = (long)reader["C"];
                    }
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Exception happens when getting number of events.");
                }
                finally
                {
                    if (null != connection)
                        connection.Close();
                }                
#elif PCL             
                string sqlCommand = "SELECT COUNT(*) C FROM " + TABLE_NAME + " where " + MA_APP_ID_COLUMN_NAME + " = ?";
                try
                {
                    using (var connection = new SQLiteConnection(_dbFileFullPath))
                    {
                        using (var statement = connection.Prepare(sqlCommand))
                        {
                            statement.Bind(1, appId);
                            while (statement.Step() == SQLiteResult.ROW)
                            {
                                count = statement.GetInteger("C");
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Exception happens when getting number of events.");
                }
#endif

            }
            return count;
        }

        /// <summary>
        /// Gets the size of the database.
        /// </summary>
        /// <returns>The database size.</returns>
        public long GetDatabaseSize()
        {
#if BCL35 || BCL45
            FileInfo fileInfo = new FileInfo(_dbFileFullPath);
            return fileInfo.Length;
#elif PCL 
            string pageCountCommand = "PRAGMA page_count;";
            string pageSizeCommand = "PRAGMA page_size;";

            long pageCount = 0, pageSize = 0;

            try
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
            catch (Exception e)
            {
                _logger.Error(e, "Exception happens when getting number of events.");
                return 0;
            }

            return pageCount*pageSize;
#endif
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

