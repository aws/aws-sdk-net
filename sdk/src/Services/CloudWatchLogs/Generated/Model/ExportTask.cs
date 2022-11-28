/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Represents an export task.
    /// </summary>
    public partial class ExportTask
    {
        private string _destination;
        private string _destinationPrefix;
        private ExportTaskExecutionInfo _executionInfo;
        private long? _from;
        private string _logGroupName;
        private ExportTaskStatus _status;
        private string _taskId;
        private string _taskName;
        private long? _to;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The name of the S3 bucket to which the log data was exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPrefix. 
        /// <para>
        /// The prefix that was used as the start of Amazon S3 key for every object exported.
        /// </para>
        /// </summary>
        public string DestinationPrefix
        {
            get { return this._destinationPrefix; }
            set { this._destinationPrefix = value; }
        }

        // Check to see if DestinationPrefix property is set
        internal bool IsSetDestinationPrefix()
        {
            return this._destinationPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionInfo. 
        /// <para>
        /// Execution information about the export task.
        /// </para>
        /// </summary>
        public ExportTaskExecutionInfo ExecutionInfo
        {
            get { return this._executionInfo; }
            set { this._executionInfo = value; }
        }

        // Check to see if ExecutionInfo property is set
        internal bool IsSetExecutionInfo()
        {
            return this._executionInfo != null;
        }

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The start time, expressed as the number of milliseconds after <code>Jan 1, 1970 00:00:00
        /// UTC</code>. Events with a timestamp before this time are not exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long From
        {
            get { return this._from.GetValueOrDefault(); }
            set { this._from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this._from.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group from which logs data was exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the export task.
        /// </para>
        /// </summary>
        public ExportTaskStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The ID of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property TaskName. 
        /// <para>
        /// The name of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string TaskName
        {
            get { return this._taskName; }
            set { this._taskName = value; }
        }

        // Check to see if TaskName property is set
        internal bool IsSetTaskName()
        {
            return this._taskName != null;
        }

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The end time, expressed as the number of milliseconds after <code>Jan 1, 1970 00:00:00
        /// UTC</code>. Events with a timestamp later than this time are not exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long To
        {
            get { return this._to.GetValueOrDefault(); }
            set { this._to = value; }
        }

        // Check to see if To property is set
        internal bool IsSetTo()
        {
            return this._to.HasValue; 
        }

    }
}