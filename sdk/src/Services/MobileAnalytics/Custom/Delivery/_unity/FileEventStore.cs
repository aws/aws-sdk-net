using Amazon.Util.Internal;

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

using ThirdParty.Json.LitJson;

using Logger = Amazon.Runtime.Internal.Util.Logger;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    internal class FileConnection
    {
        const string DataSetName = "FileDataSet";
        
        string Path { get; }

        public DataSet Sql { get; }

        public DataTableCollection Tables => Sql.Tables;

        public FileConnection(string connection)
        {
            if (!connection.Contains("URI=file:"))
                throw new InvalidOperationException();

            Path = connection.Replace("URI=file:", "");
            Sql = new DataSet(DataSetName);
        }

        internal void Dispose()
        {
            Sql.Dispose();
        }

        internal void Save()
        {
            foreach (DataTable table in Tables)
                table.AcceptChanges();
            Sql.AcceptChanges();

            Sql.WriteXml(Path, XmlWriteMode.WriteSchema);
        }

        internal void Open()
        {
            Sql.ReadXml(Path, XmlReadMode.ReadSchema);

            Sql.AcceptChanges();
            foreach (DataTable table in Tables)
                table.AcceptChanges();
        }

        internal static void CreateFile(string dBfileFullPath)
        {
            File.Create(dBfileFullPath).Close();

            var sql = new DataSet(DataSetName);
            sql.WriteXml(dBfileFullPath, XmlWriteMode.WriteSchema);
            sql.Dispose();
        }
    }

    /// <summary>
    /// Implementation of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.IEventStore"/>.
    /// The object stores Mobile Analytic events in file database.
    /// </summary>
    [System.Security.SecuritySafeCritical]
    public partial class FileEventStore : IEventStore
    {
        private Logger _logger = Logger.GetLogger(typeof(FileEventStore));
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
        private static object _lock = new object();
        private MobileAnalyticsManagerConfig _maConfig;

#pragma warning disable 414
        private bool _isDisposed;
#pragma warning restore 414
        
        private bool keepOnlyOneConnection = true;

        private FileConnection connection;

        /// <summary>
        /// Constructor of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.FileEventStore"/>
        /// </summary>
        /// <param name="maConfig">Mobile Analytics Manager Configuration.</param>
        public FileEventStore(MobileAnalyticsManagerConfig maConfig)
        {
            _maConfig = maConfig;
            SetupSQLiteEventStore();
        }

        /// <summary>
        /// Get the SQLite Event Store's database file full path.
        /// </summary>
        /// <returns> The database file full path. </returns>
        public string DBfileFullPath {
            get;
            internal set;
        }


        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

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
                        connection.Save();
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

                if (!File.Exists(this.DBfileFullPath))
                {
                    string directory = Path.GetDirectoryName(this.DBfileFullPath);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }
                    FileConnection.CreateFile(this.DBfileFullPath);
                }
                try
                {
                    if (!keepOnlyOneConnection || connection == null)
                    {
                        connection = new FileConnection("URI=file:" + this.DBfileFullPath);
                        connection.Open();
                    }

                    if (!connection.Tables.Contains(TABLE_NAME))
                    {
                        var table = new DataTable(TABLE_NAME);
                        table.AcceptChanges();

                        var eventColumn = new DataColumn
                        {
                            ColumnName = EVENT_COLUMN_NAME,
                            DataType = typeof(string),
                            AllowDBNull = false
                        };
                        var eventIdColumn = new DataColumn
                        {
                            ColumnName = EVENT_ID_COLUMN_NAME,
                            DataType = typeof(string),
                            AllowDBNull = false,
                            Unique = true
                        };
                        var maAppIdColumn = new DataColumn
                        {
                            ColumnName = MA_APP_ID_COLUMN_NAME,
                            DataType = typeof(string),
                            AllowDBNull = false
                        };
                        var eventDeiliveryAttemptCountColumn = new DataColumn
                        {
                            ColumnName = EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME,
                            DataType = typeof(int),
                            AllowDBNull = false,
                            DefaultValue = 0
                        };

                        table.Columns.Add(eventColumn);
                        table.Columns.Add(eventIdColumn);
                        table.Columns.Add(maAppIdColumn);
                        table.Columns.Add(eventDeiliveryAttemptCountColumn);
                        table.AcceptChanges();

                        connection.Tables.Add(table);
                    }

                    connection.Sql.AcceptChanges();
                }
                finally
                {
                    if (!keepOnlyOneConnection && connection != null)
                    {
                        connection.Save();
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
                    try
                    {
                        if (!keepOnlyOneConnection || connection == null)
                        {
                            connection = new FileConnection("URI=file:" + this.DBfileFullPath);
                            connection.Open();
                        }

                        var eventRow = connection.Tables[TABLE_NAME].NewRow();
                        eventRow[EVENT_COLUMN_NAME] = eventString;
                        eventRow[EVENT_ID_COLUMN_NAME] = Guid.NewGuid().ToString();
                        eventRow[MA_APP_ID_COLUMN_NAME] = appId;

                        connection.Tables[TABLE_NAME].Rows.Add(eventRow);

                        connection.Sql.AcceptChanges();
                    }
                    finally
                    {
                        if (!keepOnlyOneConnection && connection != null)
                        {
                            connection.Save();
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
                    if (!keepOnlyOneConnection || connection == null)
                    {
                        connection = new FileConnection("URI=file:" + this.DBfileFullPath);
                        connection.Open();
                    }

                    List<DataRow> rows = new List<DataRow>();
                    foreach (var rowId in rowIds)
                    {
                        var matchingRows = connection.Tables[TABLE_NAME].Select($"{EVENT_ID_COLUMN_NAME} = '{rowId}'");
                        if (matchingRows != null && matchingRows.Length > 0)
                            rows.AddRange(matchingRows);
                    }
                    rows = rows.Distinct().ToList();

                    for (var i = 0; i < rows.Count; i++)
                        connection.Tables[TABLE_NAME].Rows.Remove(rows[i]);

                    connection.Sql.AcceptChanges();
                }
                finally
                {
                    if (!keepOnlyOneConnection && connection != null)
                    {
                        connection.Save();
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
                    if (!keepOnlyOneConnection || connection == null)
                    {
                        connection = new FileConnection("URI=file:" + this.DBfileFullPath);
                        connection.Open();
                    }

                    var events = connection.Tables[TABLE_NAME].Select($"{MA_APP_ID_COLUMN_NAME} = '{appID}'").OrderBy(r => r[EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME]).Take(maxAllowed);
                    foreach (var eventRow in events)
                    {
                        JsonData data = new JsonData();
                        data["id"] = eventRow[EVENT_ID_COLUMN_NAME].ToString();
                        data["event"] = eventRow[EVENT_COLUMN_NAME].ToString();
                        data["appId"] = eventRow[MA_APP_ID_COLUMN_NAME].ToString();
                        eventList.Add(data);
                    }

                    connection.Sql.AcceptChanges();
                }
                finally
                {
                    if (!keepOnlyOneConnection && connection != null)
                    {
                        connection.Save();
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
                    if (!keepOnlyOneConnection || connection == null)
                    {
                        connection = new FileConnection("URI=file:" + this.DBfileFullPath);
                        connection.Open();
                    }

                    count = connection.Tables[TABLE_NAME].Select($"{MA_APP_ID_COLUMN_NAME} = '{appID}'").Count();
                    UnityEngine.Debug.Log(string.Format("count = {0}", count));

                    connection.Sql.AcceptChanges();
                }
                finally
                {
                    if (!keepOnlyOneConnection && connection != null)
                    {
                        connection.Save();
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
                    if (!keepOnlyOneConnection || connection == null)
                    {
                        connection = new FileConnection("URI=file:" + this.DBfileFullPath);
                        connection.Open();
                    }

                    List<DataRow> rows = new List<DataRow>();
                    foreach (var rowId in rowIds)
                    {
                        var matchingRows = connection.Tables[TABLE_NAME].Select($"{EVENT_ID_COLUMN_NAME} = '{rowId}'");
                        if (matchingRows != null && matchingRows.Length > 0)
                            rows.AddRange(matchingRows);
                    }
                    rows = rows.Distinct().ToList();

                    for (var i = 0; i < rows.Count; i++)
                        rows[i][EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME] = (int)rows[i][EVENT_DELIVERY_ATTEMPT_COUNT_COLUMN_NAME] + 1;

                    connection.Sql.AcceptChanges();
                }
                finally
                {
                    if (!keepOnlyOneConnection && connection != null)
                    {
                        connection.Save();
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
                long sizeInKb = 0;
                lock (_lock)
                {
                    try
                    {
                        if (!keepOnlyOneConnection || connection == null)
                        {
                            connection = new FileConnection("URI=file:" + this.DBfileFullPath);
                            connection.Open();
                        }

                        var memoryStream = new MemoryStream();
                        var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                        binaryFormatter.Serialize(memoryStream, connection.Sql);
                        sizeInKb = memoryStream.Length;

                        binaryFormatter = null;
                        memoryStream.Dispose();

                        connection.Sql.AcceptChanges();
                    }
                    finally
                    {
                        if (!keepOnlyOneConnection && connection != null)
                        {
                            connection.Save();
                            connection.Dispose();
                        }
                    }
                }
                return sizeInKb;
            }
        }

        /// <summary>
        /// Saves the database.
        /// </summary>
        public void SaveDatabase()
        {
            lock (_lock)
            {
                try
                {
                    if (!keepOnlyOneConnection || connection == null)
                    {
                        connection = new FileConnection("URI=file:" + this.DBfileFullPath);
                        connection.Open();
                    }

                    connection.Save();
                }
                finally
                {
                    if (!keepOnlyOneConnection && connection != null)
                    {
                        connection.Save();
                        connection.Dispose();
                    }
                }
            }
        }
    }
}