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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateExportTask operation.
    /// Creates an <code>ExportTask</code> which allows you to efficiently export data from
    /// a Log Group to your Amazon S3 bucket. 
    /// 
    ///  
    /// <para>
    ///  This is an asynchronous call. If all the required information is provided, this API
    /// will initiate an export task and respond with the task Id. Once started, <code>DescribeExportTasks</code>
    /// can be used to get the status of an export task. You can only have one active (<code>RUNNING</code>
    /// or <code>PENDING</code>) export task at a time, per account. 
    /// </para>
    ///  
    /// <para>
    ///  You can export logs from multiple log groups or multiple time ranges to the same
    /// Amazon S3 bucket. To separate out log data for each export task, you can specify a
    /// prefix that will be used as the Amazon S3 key prefix for all exported objects. 
    /// </para>
    /// </summary>
    public partial class CreateExportTaskRequest : AmazonCloudWatchLogsRequest
    {
        private string _destination;
        private string _destinationPrefix;
        private long? _from;
        private string _logGroupName;
        private string _logStreamNamePrefix;
        private string _taskName;
        private long? _to;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// Name of Amazon S3 bucket to which the log data will be exported.
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b> Only buckets in the same AWS region are supported.
        /// </para>
        /// </summary>
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
        /// Prefix that will be used as the start of Amazon S3 key for every object exported.
        /// If not specified, this defaults to 'exportedlogs'.
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
        /// Gets and sets the property From. 
        /// <para>
        /// A point in time expressed as the number of milliseconds since Jan 1, 1970 00:00:00
        /// UTC. It indicates the start time of the range for the request. Events with a timestamp
        /// prior to this time will not be exported.
        /// </para>
        /// </summary>
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
        /// The name of the log group to export.
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
        /// Gets and sets the property LogStreamNamePrefix. 
        /// <para>
        /// Will only export log streams that match the provided logStreamNamePrefix. If you don't
        /// specify a value, no prefix filter is applied.
        /// </para>
        /// </summary>
        public string LogStreamNamePrefix
        {
            get { return this._logStreamNamePrefix; }
            set { this._logStreamNamePrefix = value; }
        }

        // Check to see if LogStreamNamePrefix property is set
        internal bool IsSetLogStreamNamePrefix()
        {
            return this._logStreamNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property TaskName. 
        /// <para>
        /// The name of the export task.
        /// </para>
        /// </summary>
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
        /// A point in time expressed as the number of milliseconds since Jan 1, 1970 00:00:00
        /// UTC. It indicates the end time of the range for the request. Events with a timestamp
        /// later than this time will not be exported.
        /// </para>
        /// </summary>
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