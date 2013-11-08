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
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

using Timer = System.Timers.Timer;

namespace Amazon.TraceListener
{
    /// <summary>
    /// <para>
    /// DynamoDBTraceListener is a custom TraceListener that logs events to a DynamoDB table.
    /// The listener can be configured through the application's .config file or by instantiating
    /// an instance of DynamoDBTraceListener and setting the Configuration property on the instance.
    /// </para>
    /// 
    /// <para>
    /// The target table must have a string hash key and a string range key.
    /// If the table does not exist the listener will create it during initialization with
    /// default read and write units set to 1 and 10, respectively, unless configured otherwise.
    /// </para>
    /// 
    /// <para>
    /// While DynamoDBTraceListener is running, it will write temporary log files into current
    /// directory. These log files will be deleted once the data is pushed to DynamoDB.
    /// The logs are pushed to DynamoDB under the following conditions:
    /// 1. Flush is called on the DynamoDBTraceListener
    /// 2. Close is called on the DynamoDBTraceListener
    /// 3. WritePeriod has elapsed since last write
    /// 
    /// (If the listener is used with the SDK clients, Flush is invoked when the client is disposed.)
    /// 
    /// If the application exits and there are still log files (in the event Flush is not invoked or
    /// the application terminates unexpectedly), these log files will be pushed to DynamoDB on the
    /// next execution of the application.
    /// 
    /// Log files can also be flushed manually by creating an instance of DynamoDBTraceListener and
    /// using the FlushLog method on a particular log file.
    /// </para>
    /// 
    /// <para>
    /// Example of an app.config entry setting up the listener with all possible configurations specified:
    /// <code>
    /// &lt;system.diagnostics&gt;
    ///   &lt;trace&gt;
    ///     &lt;listeners&gt;
    ///       &lt;add name=&quot;dynamo&quot; type=&quot;Amazon.Logging.DynamoDBTraceListener, AWS.Extensions&quot;
    ///             AWSAccessKey=&quot;YOUR_ACCESS_KEY&quot;
    ///             AWSSecretKey=&quot;YOUR_SECRET_KEY&quot;
    ///             Region=&quot;us-west-2&quot;
    ///             Table=&quot;Logs&quot;
    ///             CreateIfNotExist=&quot;true&quot;
    ///             ReadCapacityUnits=&quot;1&quot;
    ///             WriteCapacityUnits=&quot;10&quot;
    ///             HashKey=&quot;Origin&quot;
    ///             RangeKey=&quot;Timestamp&quot;
    ///             MaxLength=&quot;10000&quot;
    ///             ExcludeAttributes=&quot;Callstack, Host&quot;
    ///             HashKeyFormat=&quot;{Host}-{EventType}-{ProcessId}&quot;
    ///             RangeKeyFormat=&quot;{Time}&quot;
    ///             WritePeriodMs=&quot;60000&quot;
    ///             LogFilesDir=&quot;C:\Logs&quot;
    ///         /&gt;
    ///     &lt;/listeners&gt;
    ///   &lt;/trace&gt;
    /// &lt;/system.diagnostics&gt;
    /// </code>
    /// </para>
    /// </summary>
    public class DynamoDBTraceListener : System.Diagnostics.TraceListener
    {
        #region Private fields

        private object generalLock = new object();
        private Timer writeTimer = null;
        private TextWriter writer = null;
        private DateTime lastTimestamp = DateTime.MinValue;
        private static string logFileNameFormat = string.Format("{0}.{1}.log", typeof(DynamoDBTraceListener).FullName, "{0}");
        private static string logFileSearchPattern = string.Format(logFileNameFormat, "*");
        private static string tempLogFileName = string.Concat(Guid.NewGuid().ToString(), ".", string.Format(logFileNameFormat, "temp"));
        private const int bufferSize = 0x1000; // 4 KB

        private string _currentLogFile = null;
        private string CurrentLogFile
        {
            get
            {
                if (_currentLogFile == null)
                {
                    _currentLogFile = GetNewLogFilePath();
                }
                return _currentLogFile;
            }
        }
        private string _logFileDirectory = null;
        private string LogFileDirectory
        {
            get
            {
                if (_logFileDirectory == null)
                {
                    // Try the log directories in order
                    string[] directoriesToTest =
                    {
                        Configuration.LogFilesDirectory,                // user-specified
                        Directory.GetCurrentDirectory(),                // current
                        Path.Combine(Path.GetTempPath(), "DDBTLLogs")   // Windows Temp
                    };

                    foreach (var path in directoriesToTest)
                    {
                        if (string.IsNullOrEmpty(path))
                            continue;

                        string directory = Path.GetFullPath(path);
                        try
                        {
                            if (!Directory.Exists(directory))
                                Directory.CreateDirectory(directory);

                            string testPath = Path.Combine(directory, tempLogFileName);
                            // Test write
                            File.WriteAllText(testPath, testPath);

                            // If write succeeds, delete file and use path
                            if (File.Exists(testPath))
                            {
                                File.Delete(testPath);
                                _logFileDirectory = directory;
                                break;
                            }
                        }
                        catch { }
                    }

                    if (_logFileDirectory == null)
                    {
                        // If no directory has been set, disable the listener.
                        DisableListener("Could not determine log file directory");
                    }
                    else
                        WriteEventLogMessage("DynamoDBTraceListener will store temporary log files under " + _logFileDirectory, EventLogEntryType.Information);
                }
                return _logFileDirectory;
            }
        }
        private AmazonDynamoDBClient _client = null;
        private AmazonDynamoDBClient Client
        {
            get
            {
                if (_client == null)
                {
                    try
                    {
                        AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
                        {
                            RegionEndpoint = Configuration.Region,
                            DisableLogging = true
                        };

                        if (!string.IsNullOrEmpty(Configuration.AWSAccessKey) && !string.IsNullOrEmpty(Configuration.AWSSecretKey))
                            _client = new AmazonDynamoDBClient(Configuration.AWSAccessKey, Configuration.AWSSecretKey, config);
                        else if (Configuration.AWSCredentials != null)
                            _client = new AmazonDynamoDBClient(Configuration.AWSCredentials, config);
                        else
                            _client = new AmazonDynamoDBClient(config);
                    }
                    catch (Exception e)
                    {
                        DisableListener("Could not construct AmazonDynamoDBClient: " + e);
                    }
                }
                return _client;
            }
        }
        private bool _isTableActive = false;
        private bool IsTableActive
        {
            get
            {
                if (!_isTableActive)
                {
                    lock (generalLock)
                    {
                        if (!_isTableActive)
                        {
                            try
                            {
                                DescribeTableRequest describeRequest = new DescribeTableRequest { TableName = Configuration.TableName };
                                DescribeTableResponse descResponse = Client.DescribeTable(describeRequest);
                                string tableStatus = descResponse.DescribeTableResult.Table.TableStatus;

                                if (string.Equals(tableStatus, activeStatus, StringComparison.OrdinalIgnoreCase))
                                    _isTableActive = true;
                            }
                            catch (Exception e)
                            {
                                DisableListener(string.Format("Table {0} could not be described: {1}", Configuration.TableName, e));
                            }
                        }
                    }
                }
                return _isTableActive;
            }
        }
        private Table _table = null;
        private Table Table
        {
            get
            {
                if (_table == null)
                {
                    lock (generalLock)
                    {
                        if (_table == null)
                        {
                            // Get/create table
                            if (!Table.TryLoadTable(Client, Configuration.TableName, out _table))
                            {
                                if (Configuration.CreateTableIfNotExist)
                                    _table = CreateTable();
                                else
                                    DisableListener(string.Format("Table {0} was not found to be used to log, and autocreate is turned off.", Configuration.TableName));
                            }

                            // Validate table
                            if (_table == null)
                                DisableListener(string.Format("Table {0} could not be found or created", Configuration.TableName));
                            if (_table.HashKeys == null || _table.HashKeys.Count != 1)
                                DisableListener(string.Format("Table {0} was found, but does not contain a single hash key", Configuration.TableName));
                            if (_table.RangeKeys == null || _table.RangeKeys.Count != 1)
                                DisableListener(string.Format("Table {0} was found, but does not contain a single range key", Configuration.TableName));
                        }
                    }
                }
                return _table;
            }
        }
        private TraceEventCache TraceEventCache { get { return new TraceEventCache(); } }

        #endregion

        #region Properties/configuration

        private static Regex variableRegex = new Regex(@"\{(\w*?)\}", RegexOptions.Compiled);
        private static TimeSpan oneMillisecond = TimeSpan.FromMilliseconds(1);
        private static int minWritePeriodMs = (int)TimeSpan.FromSeconds(10).TotalMilliseconds;
        private static Configs defaultConfigs = new Configs();
        private static string host = System.Environment.MachineName;
        private const string activeStatus = "Active";
        private const string ellipsis = "...";

        private string ATTRIBUTE_ORIGIN { get { return Table.HashKeys[0]; } }
        private string ATTRIBUTE_TIMESTAMP { get { return Table.RangeKeys[0]; } }
        private const string ATTRIBUTE_MESSAGE = "Message";
        private const string ATTRIBUTE_HOST = "Host";
        private const string ATTRIBUTE_TIME = "Time";
        private const string ATTRIBUTE_SOURCE = "Source";
        private const string ATTRIBUTE_CALLSTACK = "Callstack";
        private const string ATTRIBUTE_PROCESSID = "ProcessId";
        private const string ATTRIBUTE_THREADID = "ThreadId";
        private const string ATTRIBUTE_EVENTID = "EventId";
        private const string ATTRIBUTE_EVENTTYPE = "EventType";

        private const string CONFIG_ACCESSKEY = "AWSAccessKey";
        private const string CONFIG_SECRETKEY = "AWSSecretKey";
        private const string CONFIG_REGION = "Region";
        private const string CONFIG_TABLE = "Table";
        private const string CONFIG_CREATE_TABLE_IF_NOT_EXIST = "CreateIfNotExist";
        private const string CONFIG_READ_UNITS = "ReadCapacityUnits";
        private const string CONFIG_WRITE_UNITS = "WriteCapacityUnits";
        private const string CONFIG_HASHKEY = "HashKey";
        private const string CONFIG_RANGEKEY = "RangeKey";
        private const string CONFIG_MAXLENGTH = "MaxLength";
        private const string CONFIG_EXCLUDEATTRIBUTES = "ExcludeAttributes";
        private const string CONFIG_HASHKEYFORMAT = "HashKeyFormat";
        private const string CONFIG_RANGEKEYFORMAT = "RangeKeyFormat";
        private const string CONFIG_WRITEPERIODMS = "WritePeriodMs";
        private const string CONFIG_LOGFILESDIR = "LogFilesDir";

        private Configs _configuration = null;
        /// <summary>
        /// Current configuration.
        /// </summary>
        public Configs Configuration
        {
            get
            {
                if (_configuration == null)
                {
                    lock (generalLock)
                    {
                        if (_configuration == null)
                        {
                            _configuration = GetConfigFromAttributes();
                        }
                    }
                }
                return _configuration;
            }
            set
            {
                lock (generalLock)
                {
                    _configuration = value;
                }
            }
        }

        /// <summary>
        /// Whether the DynamoDBTraceListener is enabled.
        /// Read-only field that is set to false if the listener is disabled.
        /// The listener can be disabled if initialization has failed (in which case an error will be
        /// logged to the event log) or the listener was closed.
        /// </summary>
        public bool IsEnabled { get; private set; }

        #endregion

        #region Private methods

        // Get a new time-stamped log file path.
        private string GetNewLogFilePath()
        {
            string logFileName = string.Format(logFileNameFormat, DateTime.Now.ToFileTime());
            string logFilePath = Path.Combine(LogFileDirectory, logFileName);
            return logFilePath;
        }

        // Create logs table and return Table object. Table won't be active yet.
        private Table CreateTable()
        {
            try
            {
                Client.CreateTable(new CreateTableRequest
                {
                    TableName = Configuration.TableName,
                    KeySchema = new List<KeySchemaElement>
                    {
                        new KeySchemaElement { AttributeName = defaultConfigs.HashKey, KeyType = "HASH" },
                        new KeySchemaElement { AttributeName = defaultConfigs.RangeKey, KeyType = "RANGE" }
                    },
                    AttributeDefinitions = new List<AttributeDefinition>
                    {
                        new AttributeDefinition { AttributeName = defaultConfigs.HashKey, AttributeType = "S" },
                        new AttributeDefinition { AttributeName = defaultConfigs.RangeKey, AttributeType = "S" }
                    },
                    ProvisionedThroughput = new ProvisionedThroughput { ReadCapacityUnits = Configuration.ReadUnits, WriteCapacityUnits = Configuration.WriteUnits }
                });
            }
            catch (Exception e)
            {
                WriteEventLogMessage(string.Format("Error while creating table {0}: {1}", Configuration.TableName, e.ToString()), EventLogEntryType.Error);
                return null;
            }

            Table table = Table.LoadTable(Client, Configuration.TableName);
            return table;
        }

        // Expands environment and attribute variables in string
        private string ExpandVariables(string value, Document doc)
        {
            string result = value;
            result = Environment.ExpandEnvironmentVariables(result);
            result = variableRegex.Replace(result, match =>
            {
                string key = match.Groups[1].Captures[0].Value;
                if (doc.Contains(key))
                    return doc[key].AsString();
                else
                    return match.Captures[0].Value;
            });
            return result;
        }

        // Composes a Document and pushes to background thread to log whenever
        private void Log(TraceEventCache eventCache, string source, TraceEventType eventType, int eventId, params object[] data)
        {
            if (!IsEnabled) return;

            Document doc = new Document();

            // Populate event data
            doc[ATTRIBUTE_CALLSTACK] = LimitLength(eventCache.Callstack);
            doc[ATTRIBUTE_PROCESSID] = eventCache.ProcessId;
            doc[ATTRIBUTE_THREADID] = eventCache.ThreadId;
            doc[ATTRIBUTE_HOST] = LimitLength(host);
            doc[ATTRIBUTE_SOURCE] = LimitLength(source);
            doc[ATTRIBUTE_EVENTTYPE] = eventType.ToString();
            doc[ATTRIBUTE_EVENTID] = eventId;
            doc[ATTRIBUTE_TIME] = GetCurrentTimestamp();

            // Set the message
            if (data != null && data.Length > 0)
            {
                string message = ComposeMessage(data);
                doc[ATTRIBUTE_MESSAGE] = LimitLength(message);
            }

            // Set hash/range keys, possibly from event data
            doc[ATTRIBUTE_ORIGIN] = ExpandVariables(Configuration.HashKeyFormat, doc);
            doc[ATTRIBUTE_TIMESTAMP] = ExpandVariables(Configuration.RangeKeyFormat, doc);

            // Remove attributes that should be excluded
            if (Configuration.ExcludeAttributes != null)
            {
                foreach (string exclude in Configuration.ExcludeAttributes)
                {
                    doc[exclude] = null;
                }
            }

            // Add message to documents list
            AppendDocument(doc);
        }

        // Limits the length of a string to Configuration.MaxLength
        private string LimitLength(string value)
        {
            if (value != null && value.Length > Configuration.MaxLength)
                value = value.Substring(0, Configuration.MaxLength - ellipsis.Length) + ellipsis;
            return value;
        }

        // Creates a message string from data objects
        private string ComposeMessage(object[] data)
        {
            string message;
            if (data == null || data.Length == 0)
                message = string.Empty;
            if (data.Length == 1)
                message = data[0].ToString();
            else
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    if (i != 0)
                    {
                        builder.Append(", ");
                    }
                    if (data[i] != null)
                    {
                        builder.Append(data[i].ToString());
                    }
                }
                message = builder.ToString();
            }

            return message;
        }

        // Retrieves a non-colliding timestamp
        private DateTime GetCurrentTimestamp()
        {
            DateTime now = DateTime.Now;
            // DateTime is converted to an ISO 8601 string with millisecond precision,
            // so we may need to avoid range key collisions by incrementing the date by a millisecond
            lock (generalLock)
            {
                var diff = (now - lastTimestamp);
                if (diff.TotalMilliseconds < 1)
                    now = lastTimestamp + oneMillisecond;
                lastTimestamp = now;
            }
            return now;
        }

        // Ensures that the writer object is created and ready for writing.
        // Otherwise, disables the listener.
        private bool EnsureWriter()
        {
            if (writer == null)
            {
                try
                {
                    writer = new StreamWriter(CurrentLogFile, true, Encoding.UTF8, bufferSize);
                }
                catch (Exception e)
                {
                    DisableListener("Error writing log file: " + e.ToString());
                }
            }

            return IsEnabled;
        }

        // Appends a Document to the log file.
        private void AppendDocument(Document doc)
        {
            if (!IsEnabled) return;

            string json = null;
            try
            {
                // JsonMapper doesn't properly serialize Documents, so we store the attribute map
                Dictionary<string, AttributeValue> attributeMap = doc.ToAttributeMap();
                json = JsonMapper.ToJson(attributeMap);
            }
            catch
            {
                json = null;
            }

            if (string.IsNullOrEmpty(json))
                return;

            // Perform write
            lock (generalLock)
            {
                if (EnsureWriter())
                {
                    writer.WriteLine(json);
                }
            }
        }

        // Timer action for handling timed writes
        private void TimedWriter(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!IsEnabled)
            {
                writeTimer.Enabled = false;
                return;
            }

            // Update interval, as it may have been changed after the start
            writeTimer.Interval = Configuration.WritePeriod.TotalMilliseconds;

            if (IsLogFileEmpty(CurrentLogFile))
                return;

            Flush();
        }

        // Reads documents from the old log files.
        private IEnumerable<Document> GetDocuments(string path)
        {
            if (!IsEnabled || IsLogFileEmpty(path))
                yield break;

            using (Stream stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Dictionary<string, AttributeValue> map;
                    try
                    {
                        map = JsonMapper.ToObject<Dictionary<string, AttributeValue>>(line);
                    }
                    catch
                    {
                        map = null;
                    }

                    if (map != null && map.Count > 0)
                    {
                        Document doc = Document.FromAttributeMap(map);
                        yield return doc;
                    }
                }
            }
        }

        // Returns true if the log file doesn't exist or has length = 0.
        private bool IsLogFileEmpty(string path)
        {
            var fileInfo = new FileInfo(path);
            return (!fileInfo.Exists || fileInfo.Length == 0);
        }

        // If file is no longer active, attempts to delete it. If that fails, empties the file out.
        private void DeleteLogFile(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch { }

            if (!IsLogFileEmpty(path))
            {
                try
                {
                    File.Open(path, FileMode.Truncate, FileAccess.Write, FileShare.Read).Close();
                }
                catch { }
            }
        }

        // Writes an event log message
        private void WriteEventLogMessage(string message, EventLogEntryType logEntryType)
        {
            string source = typeof(DynamoDBTraceListener).Name;
            if (!EventLog.SourceExists(source))
                EventLog.CreateEventSource(source, "Application");
            EventLog.WriteEntry(source, message, logEntryType);
        }

        // Disables the DynamoDBTraceListener and writes an error event log message
        private void DisableListener(string message)
        {
            IsEnabled = false;
            WriteEventLogMessage("DynamoDBTraceListener disabled: " + message, EventLogEntryType.Error);
        }

        // Initializes DynamoDBTraceListener
        private void Init()
        {
            // Property Attributes isn't set yet, so set first timer to go off at minimum period
            writeTimer = new Timer(minWritePeriodMs);
            writeTimer.AutoReset = true;
            writeTimer.Elapsed += TimedWriter;
            writeTimer.Enabled = true;
            IsEnabled = true;
        }

        #endregion

        #region TraceListener Overrides

        protected override string[] GetSupportedAttributes()
        {
            return new string[]
            {
                CONFIG_ACCESSKEY,
                CONFIG_SECRETKEY,
                CONFIG_REGION,
                CONFIG_TABLE,

                CONFIG_CREATE_TABLE_IF_NOT_EXIST,
                CONFIG_READ_UNITS,
                CONFIG_WRITE_UNITS,

                CONFIG_HASHKEY,
                CONFIG_RANGEKEY,
                CONFIG_MAXLENGTH,
                CONFIG_EXCLUDEATTRIBUTES,
                CONFIG_HASHKEYFORMAT,
                CONFIG_RANGEKEYFORMAT,
                CONFIG_WRITEPERIODMS,
                CONFIG_LOGFILESDIR
            };
        }
        public override bool IsThreadSafe { get { return false; } }
        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
        {
            Log(eventCache, source, eventType, id, data);
        }
        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data)
        {
            Log(eventCache, source, eventType, id, data);
        }
        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id)
        {
            Log(eventCache, source, eventType, id);
        }
        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args)
        {
            Log(eventCache, source, eventType, id, string.Format(format, args));
        }
        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
        {
            Log(eventCache, source, eventType, id, message);
        }
        public override void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId)
        {
            Log(eventCache, source, TraceEventType.Transfer, id, relatedActivityId);
        }
        public override void Write(string message)
        {
            TraceData(TraceEventCache, this.Name, TraceEventType.Information, 0, message);
        }
        public override void WriteLine(string message)
        {
            TraceData(TraceEventCache, this.Name, TraceEventType.Information, 0, message);
        }
        protected override void WriteIndent() { }
        public override void Flush()
        {
            if (!IsEnabled) return;

            // Flush to disk
            if (writer != null)
            {
                writer.Flush();
            }

            // Only flush log files to DynamoDB when the table is active
            if (!IsTableActive)
                return;

            // Get existing log files
            var logFiles = Directory
                .GetFiles(LogFileDirectory, logFileSearchPattern)
                .Where(p => !IsLogFileEmpty(p));

            // Use new log file for subsequent logs
            lock (generalLock)
            {
                _currentLogFile = GetNewLogFilePath();
                if (writer != null)
                {
                    try
                    {
                        writer.Flush();
                        writer.Close();
                    }
                    catch { }
                    writer = null;
                }
            }

            // Push log files to DynamoDB, then empty/delete them.
            // Each log file is sent to DynamoDB in its own batch.
            foreach (var oldLog in logFiles)
            {
                try
                {
                    FlushLog(oldLog);
                }
                catch (Exception e)
                {
                    DisableListener("Unable to write logs to DynamoDB: " + e);
                    return;
                }
            }
        }
        public override void Close()
        {
            Flush();
            base.Close();
        }

        #endregion

        #region Dispose Pattern Implementation

        bool disposed = false;

        /// <summary>
        /// Implements the Dispose pattern for the AmazonWebServiceClient
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected override void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Flush();
                }
                IsEnabled = false;
                disposed = true;
            }
        }

        /// <summary>
        /// The destructor for the client class.
        /// </summary>
        ~DynamoDBTraceListener()
        {
            this.Dispose(false);
        }

        #endregion

        #region Attribute methods

        private char[] valueSeparators = { ',' };
        // Retrieves a configuration from Attributes or the default configuration
        private Configs GetConfigFromAttributes()
        {
            // parse attributes to exclude
            var excludeAttributes = GetAttribute(CONFIG_EXCLUDEATTRIBUTES)
                .Split(valueSeparators, StringSplitOptions.RemoveEmptyEntries)  // split list by valueSeparators
                .Select(s => (s ?? string.Empty).Trim())                        // convert null to "" and trim
                .Where(s => s.Length > 0)                                       // keep only non-empty strings
                .ToArray();
            
            // parse write period
            int writePeriodMs = GetAttributeAsInt(CONFIG_WRITEPERIODMS, (int)defaultConfigs.WritePeriod.TotalMilliseconds);
            writePeriodMs = Math.Max(writePeriodMs, minWritePeriodMs);

            // construct configs from attributes
            var configs = new Configs
            {
                AWSAccessKey = GetAttribute(CONFIG_ACCESSKEY),
                AWSSecretKey = GetAttribute(CONFIG_SECRETKEY),
                Region = RegionEndpoint.GetBySystemName(GetAttribute(CONFIG_REGION, defaultConfigs.Region.SystemName)),
                TableName = GetAttribute(CONFIG_TABLE, defaultConfigs.TableName),
                ReadUnits = GetAttributeAsInt(CONFIG_READ_UNITS, defaultConfigs.ReadUnits),
                WriteUnits = GetAttributeAsInt(CONFIG_WRITE_UNITS, defaultConfigs.WriteUnits),
                CreateTableIfNotExist = GetAttributeAsBool(CONFIG_CREATE_TABLE_IF_NOT_EXIST, defaultConfigs.CreateTableIfNotExist),
                MaxLength = GetAttributeAsInt(CONFIG_MAXLENGTH, defaultConfigs.MaxLength),
                HashKeyFormat = GetAttribute(CONFIG_HASHKEYFORMAT, defaultConfigs.HashKeyFormat),
                RangeKeyFormat = GetAttribute(CONFIG_RANGEKEYFORMAT, defaultConfigs.RangeKeyFormat),
                HashKey = GetAttribute(CONFIG_HASHKEY, defaultConfigs.HashKey),
                RangeKey = GetAttribute(CONFIG_RANGEKEY, defaultConfigs.RangeKey),
                WritePeriod = TimeSpan.FromMilliseconds(writePeriodMs),
                ExcludeAttributes = excludeAttributes,
                LogFilesDirectory = GetAttribute(CONFIG_LOGFILESDIR, defaultConfigs.LogFilesDirectory)
            };

            return configs;
        }
        private bool GetAttributeAsBool(string name, bool defaultValue = false)
        {
            string value = GetAttribute(name);
            bool b;
            if (string.IsNullOrEmpty(value) || !bool.TryParse(value, out b))
                b = defaultValue;
            return b;
        }
        private int GetAttributeAsInt(string name, int defaultValue = -1)
        {
            string value = GetAttribute(name);
            int i;
            if (string.IsNullOrEmpty(value) || !int.TryParse(value, out i))
                i = defaultValue;
            return i;
        }
        private string GetAttribute(string name, string defaultValue = "")
        {
            if (Attributes.ContainsKey(name))
                return Attributes[name];
            else
                return defaultValue;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructs an instance of the DynamoDBTraceListener.
        /// </summary>
        public DynamoDBTraceListener()
            : base()
        {
            Init();
        }

        /// <summary>
        /// Constructs a named instance of the DynamoDBTraceListener.
        /// </summary>
        public DynamoDBTraceListener(string name)
            : base(name)
        {
            Init();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Flushes an existing log to DynamoDB, then deletes/empties the log file.
        /// This method can be invoked manually to flush left-over log files.
        /// </summary>
        /// <param name="log"></param>
        public void FlushLog(string log)
        {
            // Get Documents stored in log file
            var documents = GetDocuments(log);

            // Create, populate and execute BatchWrite
            var batchWrite = Table.CreateBatchWrite();
            foreach (var doc in documents)
            {
                batchWrite.AddDocumentToPut(doc);
            }

            // Attempt to write (may throw exception)
            batchWrite.Execute();

            // If BatchWrite succeeded, empty old log file
            DeleteLogFile(log);
        }

        #endregion

        #region Public classes

        /// <summary>
        /// DynamoDBTraceListener configurations.
        /// </summary>
        public class Configs
        {
            #region Login/table properties

            /// <summary>
            /// Access key to use.
            /// Config key: AWSAccessKey
            /// </summary>
            public string AWSAccessKey { get; set; }

            /// <summary>
            /// Secret key to use.
            /// Config key: AWSSecretKey
            /// </summary>
            public string AWSSecretKey { get; set; }

            /// <summary>
            /// Credentials to use.
            /// This property can only be set programmatically.
            /// </summary>
            public AWSCredentials AWSCredentials { get; set; }

            /// <summary>
            /// Region for the table. Default is US West 2 (Oregon).
            /// Config key: Region
            /// </summary>
            public RegionEndpoint Region { get; set; }

            /// <summary>
            /// Table used to store logs. Default is "Logs".
            /// Config key: Table
            /// </summary>
            public string TableName { get; set; }

            #endregion

            #region Table-creation properties

            /// <summary>
            /// Controls whether the table will be auto created if it doesn't exist. The default is true.
            /// Config key: CreateIfNotExist
            /// </summary>
            public bool CreateTableIfNotExist { get; set; }

            /// <summary>
            /// The read capacity units if the table is created. The default is 1.
            /// Config key: ReadCapacityUnits
            /// </summary>
            public int ReadUnits { get; set; }

            /// <summary>
            /// The write capacity units if the table is created. The default is 10.
            /// Config key: WriteCapacityUnits
            /// </summary>
            public int WriteUnits { get; set; }

            /// <summary>
            /// The hash-key name if the table is created. The default is "Origin".
            /// Config key: HashKey
            /// </summary>
            public string HashKey { get; set; }

            /// <summary>
            /// The range-key name if the table is created. The default is "Timestamp".
            /// Config key: RangeKey
            /// </summary>
            public string RangeKey { get; set; }

            #endregion

            #region Message/logging properties

            /// <summary>
            /// The maximum length of any one attribute. The default is 10,000 characters.
            /// Config key: MaxLength
            /// </summary>
            public int MaxLength { get; set; }

            /// <summary>
            /// Format of the hash key. The default is "{Host}".
            /// The format can include environment variables, attributes from the logged message, or can
            /// be a constant value.
            /// 
            /// Environment variables are specified like so: %ComputerName%
            /// Attributes are specified like so: {Host}
            /// For example: {Host}-{EventType}-{ProcessId} or %ComputerName%-{EventType}-{ProcessId}
            /// 
            /// Config key: HashKeyFormat
            /// </summary>
            public string HashKeyFormat { get; set; }

            /// <summary>
            /// Format of the range key. The default is "{Time}".
            /// The format can include environment variables, attributes from the logged message, or can
            /// be a constant value.
            /// 
            /// Environment variables are specified like so: %Time%
            /// Attributes are specified like so: {Time}
            /// 
            /// Config key: RangeKeyFormat
            /// </summary>
            public string RangeKeyFormat { get; set; }

            /// <summary>
            /// Array of attributes to exclude from the logged item. Default is null.
            /// Config key: ExcludeAttributes (comma-separated list of attribute names)
            /// </summary>
            public string[] ExcludeAttributes { get; set; }

            /// <summary>
            /// Largest time between writes to DynamoDB.
            /// If this period has passed since the last log write, all accumulated messages
            /// are written to DynamoDB immediately.
            /// 
            /// The listener only pushes messages to DynamoDB when the target table is active
            /// AND one of the following happens:
            ///  1. The time equal to WritePeriod since last write has elapsed
            ///  2. Flush is called
            ///  3. Close is called
            /// 
            /// Default value is 1 minute. Smallest allowed value is 0 seconds.
            /// 
            /// Config key: WritePeriodMs (number of milliseconds)
            /// </summary>
            public TimeSpan WritePeriod { get; set; }

            /// <summary>
            /// The directory that temporary log files should be written to.
            /// If the value is not specified, listener attempts to use the application's current
            /// directory, then the Windows temporary directory. If none of these are accessible,
            /// the listener will be disabled and an error message will be written to the error log.
            /// 
            /// Default value is null.
            /// 
            /// Config key: LogFilesDir
            /// </summary>
            public string LogFilesDirectory { get; set; }

            #endregion

            #region Constructor

            /// <summary>
            /// Constructs a default Configs instance.
            /// </summary>
            public Configs()
            {
                HashKey = "Origin";
                RangeKey = "Timestamp";
                TableName = "Logs";
                ReadUnits = 1;
                WriteUnits = 10;
                CreateTableIfNotExist = true;
                MaxLength = 10 * 1000;
                Region = RegionEndpoint.USWest2;
                HashKeyFormat = "{Host}";
                RangeKeyFormat = "{Time}";
                WritePeriod = TimeSpan.FromMinutes(1);
                LogFilesDirectory = null;
            }

            #endregion
        }

        #endregion
    }
}
