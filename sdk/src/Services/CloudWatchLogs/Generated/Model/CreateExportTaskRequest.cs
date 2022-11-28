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
    /// Container for the parameters to the CreateExportTask operation.
    /// Creates an export task so that you can efficiently export data from a log group to
    /// an Amazon S3 bucket. When you perform a <code>CreateExportTask</code> operation, you
    /// must use credentials that have permission to write to the S3 bucket that you specify
    /// as the destination.
    /// 
    ///  
    /// <para>
    /// Exporting log data to S3 buckets that are encrypted by KMS is supported. Exporting
    /// log data to Amazon S3 buckets that have S3 Object Lock enabled with a retention period
    /// is also supported.
    /// </para>
    ///  
    /// <para>
    /// Exporting to S3 buckets that are encrypted with AES-256 is supported. 
    /// </para>
    ///  
    /// <para>
    /// This is an asynchronous call. If all the required information is provided, this operation
    /// initiates an export task and responds with the ID of the task. After the task has
    /// started, you can use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeExportTasks.html">DescribeExportTasks</a>
    /// to get the status of the export task. Each account can only have one active (<code>RUNNING</code>
    /// or <code>PENDING</code>) export task at a time. To cancel an export task, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CancelExportTask.html">CancelExportTask</a>.
    /// </para>
    ///  
    /// <para>
    /// You can export logs from multiple log groups or multiple time ranges to the same S3
    /// bucket. To separate log data for each export task, specify a prefix to be used as
    /// the Amazon S3 key prefix for all exported objects.
    /// </para>
    ///  <note> 
    /// <para>
    /// Time-based sorting on chunks of log data inside an exported file is not guaranteed.
    /// You can sort the exported log field data by using Linux utilities.
    /// </para>
    ///  </note>
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
        /// The name of S3 bucket for the exported log data. The bucket must be in the same Amazon
        /// Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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
        /// The prefix used as the start of the key for every object exported. If you don't specify
        /// a value, the default is <code>exportedlogs</code>.
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
        /// The start time of the range for the request, expressed as the number of milliseconds
        /// after <code>Jan 1, 1970 00:00:00 UTC</code>. Events with a timestamp earlier than
        /// this time are not exported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
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
        /// The name of the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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
        /// Export only log streams that match the provided prefix. If you don't specify a value,
        /// no prefix filter is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// The end time of the range for the request, expressed as the number of milliseconds
        /// after <code>Jan 1, 1970 00:00:00 UTC</code>. Events with a timestamp later than this
        /// time are not exported.
        /// </para>
        ///  
        /// <para>
        /// You must specify a time that is not earlier than when this log group was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
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