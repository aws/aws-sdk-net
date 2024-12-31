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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Contains the number of log events scanned by the query, the number of log events that
    /// matched the query criteria, and the total number of bytes in the log events that were
    /// scanned.
    /// 
    ///  
    /// <para>
    /// If the query involved log groups that have field index policies, the estimated number
    /// of skipped log events and the total bytes of those skipped log events are included.
    /// Using field indexes to skip log events in queries reduces scan volume and improves
    /// performance. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs-Field-Indexing.html">Create
    /// field indexes to improve query performance and reduce scan volume</a>.
    /// </para>
    /// </summary>
    public partial class QueryStatistics
    {
        private double? _bytesScanned;
        private double? _estimatedBytesSkipped;
        private double? _estimatedRecordsSkipped;
        private double? _logGroupsScanned;
        private double? _recordsMatched;
        private double? _recordsScanned;

        /// <summary>
        /// Gets and sets the property BytesScanned. 
        /// <para>
        /// The total number of bytes in the log events scanned during the query.
        /// </para>
        /// </summary>
        public double? BytesScanned
        {
            get { return this._bytesScanned; }
            set { this._bytesScanned = value; }
        }

        // Check to see if BytesScanned property is set
        internal bool IsSetBytesScanned()
        {
            return this._bytesScanned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedBytesSkipped. 
        /// <para>
        /// An estimate of the number of bytes in the log events that were skipped when processing
        /// this query, because the query contained an indexed field. Skipping these entries lowers
        /// query costs and improves the query performance time. For more information about field
        /// indexes, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutIndexPolicy.html">PutIndexPolicy</a>.
        /// </para>
        /// </summary>
        public double? EstimatedBytesSkipped
        {
            get { return this._estimatedBytesSkipped; }
            set { this._estimatedBytesSkipped = value; }
        }

        // Check to see if EstimatedBytesSkipped property is set
        internal bool IsSetEstimatedBytesSkipped()
        {
            return this._estimatedBytesSkipped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedRecordsSkipped. 
        /// <para>
        /// An estimate of the number of log events that were skipped when processing this query,
        /// because the query contained an indexed field. Skipping these entries lowers query
        /// costs and improves the query performance time. For more information about field indexes,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutIndexPolicy.html">PutIndexPolicy</a>.
        /// </para>
        /// </summary>
        public double? EstimatedRecordsSkipped
        {
            get { return this._estimatedRecordsSkipped; }
            set { this._estimatedRecordsSkipped = value; }
        }

        // Check to see if EstimatedRecordsSkipped property is set
        internal bool IsSetEstimatedRecordsSkipped()
        {
            return this._estimatedRecordsSkipped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogGroupsScanned. 
        /// <para>
        /// The number of log groups that were scanned by this query.
        /// </para>
        /// </summary>
        public double? LogGroupsScanned
        {
            get { return this._logGroupsScanned; }
            set { this._logGroupsScanned = value; }
        }

        // Check to see if LogGroupsScanned property is set
        internal bool IsSetLogGroupsScanned()
        {
            return this._logGroupsScanned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordsMatched. 
        /// <para>
        /// The number of log events that matched the query string.
        /// </para>
        /// </summary>
        public double? RecordsMatched
        {
            get { return this._recordsMatched; }
            set { this._recordsMatched = value; }
        }

        // Check to see if RecordsMatched property is set
        internal bool IsSetRecordsMatched()
        {
            return this._recordsMatched.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordsScanned. 
        /// <para>
        /// The total number of log events scanned during the query.
        /// </para>
        /// </summary>
        public double? RecordsScanned
        {
            get { return this._recordsScanned; }
            set { this._recordsScanned = value; }
        }

        // Check to see if RecordsScanned property is set
        internal bool IsSetRecordsScanned()
        {
            return this._recordsScanned.HasValue; 
        }

    }
}