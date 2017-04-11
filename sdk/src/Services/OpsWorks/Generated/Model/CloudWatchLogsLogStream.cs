/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Describes the Amazon CloudWatch logs configuration for a layer. For detailed information
    /// about members of this data type, see the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AgentReference.html">CloudWatch
    /// Logs Agent Reference</a>.
    /// </summary>
    public partial class CloudWatchLogsLogStream
    {
        private int? _batchCount;
        private int? _batchSize;
        private int? _bufferDuration;
        private string _datetimeFormat;
        private CloudWatchLogsEncoding _encoding;
        private string _file;
        private string _fileFingerprintLines;
        private CloudWatchLogsInitialPosition _initialPosition;
        private string _logGroupName;
        private string _multiLineStartPattern;
        private CloudWatchLogsTimeZone _timeZone;

        /// <summary>
        /// Gets and sets the property BatchCount. 
        /// <para>
        /// Specifies the max number of log events in a batch, up to 10000. The default value
        /// is 1000.
        /// </para>
        /// </summary>
        public int BatchCount
        {
            get { return this._batchCount.GetValueOrDefault(); }
            set { this._batchCount = value; }
        }

        // Check to see if BatchCount property is set
        internal bool IsSetBatchCount()
        {
            return this._batchCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        /// Specifies the maximum size of log events in a batch, in bytes, up to 1048576 bytes.
        /// The default value is 32768 bytes. This size is calculated as the sum of all event
        /// messages in UTF-8, plus 26 bytes for each log event.
        /// </para>
        /// </summary>
        public int BatchSize
        {
            get { return this._batchSize.GetValueOrDefault(); }
            set { this._batchSize = value; }
        }

        // Check to see if BatchSize property is set
        internal bool IsSetBatchSize()
        {
            return this._batchSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BufferDuration. 
        /// <para>
        /// Specifies the time duration for the batching of log events. The minimum value is 5000ms
        /// and default value is 5000ms.
        /// </para>
        /// </summary>
        public int BufferDuration
        {
            get { return this._bufferDuration.GetValueOrDefault(); }
            set { this._bufferDuration = value; }
        }

        // Check to see if BufferDuration property is set
        internal bool IsSetBufferDuration()
        {
            return this._bufferDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatetimeFormat. 
        /// <para>
        /// Specifies how the time stamp is extracted from logs. For more information, see the
        /// <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AgentReference.html">CloudWatch
        /// Logs Agent Reference</a>.
        /// </para>
        /// </summary>
        public string DatetimeFormat
        {
            get { return this._datetimeFormat; }
            set { this._datetimeFormat = value; }
        }

        // Check to see if DatetimeFormat property is set
        internal bool IsSetDatetimeFormat()
        {
            return this._datetimeFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Encoding. 
        /// <para>
        /// Specifies the encoding of the log file so that the file can be read correctly. The
        /// default is <code>utf_8</code>. Encodings supported by Python <code>codecs.decode()</code>
        /// can be used here.
        /// </para>
        /// </summary>
        public CloudWatchLogsEncoding Encoding
        {
            get { return this._encoding; }
            set { this._encoding = value; }
        }

        // Check to see if Encoding property is set
        internal bool IsSetEncoding()
        {
            return this._encoding != null;
        }

        /// <summary>
        /// Gets and sets the property File. 
        /// <para>
        /// Specifies log files that you want to push to CloudWatch Logs.
        /// </para>
        ///  
        /// <para>
        ///  <code>File</code> can point to a specific file or multiple files (by using wild card
        /// characters such as <code>/var/log/system.log*</code>). Only the latest file is pushed
        /// to CloudWatch Logs, based on file modification time. We recommend that you use wild
        /// card characters to specify a series of files of the same type, such as <code>access_log.2014-06-01-01</code>,
        /// <code>access_log.2014-06-01-02</code>, and so on by using a pattern like <code>access_log.*</code>.
        /// Don't use a wildcard to match multiple file types, such as <code>access_log_80</code>
        /// and <code>access_log_443</code>. To specify multiple, different file types, add another
        /// log stream entry to the configuration file, so that each log file type is stored in
        /// a different log group.
        /// </para>
        ///  
        /// <para>
        /// Zipped files are not supported.
        /// </para>
        /// </summary>
        public string File
        {
            get { return this._file; }
            set { this._file = value; }
        }

        // Check to see if File property is set
        internal bool IsSetFile()
        {
            return this._file != null;
        }

        /// <summary>
        /// Gets and sets the property FileFingerprintLines. 
        /// <para>
        /// Specifies the range of lines for identifying a file. The valid values are one number,
        /// or two dash-delimited numbers, such as '1', '2-5'. The default value is '1', meaning
        /// the first line is used to calculate the fingerprint. Fingerprint lines are not sent
        /// to CloudWatch Logs unless all specified lines are available.
        /// </para>
        /// </summary>
        public string FileFingerprintLines
        {
            get { return this._fileFingerprintLines; }
            set { this._fileFingerprintLines = value; }
        }

        // Check to see if FileFingerprintLines property is set
        internal bool IsSetFileFingerprintLines()
        {
            return this._fileFingerprintLines != null;
        }

        /// <summary>
        /// Gets and sets the property InitialPosition. 
        /// <para>
        /// Specifies where to start to read data (start_of_file or end_of_file). The default
        /// is start_of_file. This setting is only used if there is no state persisted for that
        /// log stream.
        /// </para>
        /// </summary>
        public CloudWatchLogsInitialPosition InitialPosition
        {
            get { return this._initialPosition; }
            set { this._initialPosition = value; }
        }

        // Check to see if InitialPosition property is set
        internal bool IsSetInitialPosition()
        {
            return this._initialPosition != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// Specifies the destination log group. A log group is created automatically if it doesn't
        /// already exist. Log group names can be between 1 and 512 characters long. Allowed characters
        /// include a-z, A-Z, 0-9, '_' (underscore), '-' (hyphen), '/' (forward slash), and '.'
        /// (period).
        /// </para>
        /// </summary>
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property MultiLineStartPattern. 
        /// <para>
        /// Specifies the pattern for identifying the start of a log message.
        /// </para>
        /// </summary>
        public string MultiLineStartPattern
        {
            get { return this._multiLineStartPattern; }
            set { this._multiLineStartPattern = value; }
        }

        // Check to see if MultiLineStartPattern property is set
        internal bool IsSetMultiLineStartPattern()
        {
            return this._multiLineStartPattern != null;
        }

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// Specifies the time zone of log event time stamps.
        /// </para>
        /// </summary>
        public CloudWatchLogsTimeZone TimeZone
        {
            get { return this._timeZone; }
            set { this._timeZone = value; }
        }

        // Check to see if TimeZone property is set
        internal bool IsSetTimeZone()
        {
            return this._timeZone != null;
        }

    }
}