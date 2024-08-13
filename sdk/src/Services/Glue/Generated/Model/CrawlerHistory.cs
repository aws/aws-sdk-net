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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Contains the information for a run of a crawler.
    /// </summary>
    public partial class CrawlerHistory
    {
        private string _crawlId;
        private double? _dpuHour;
        private DateTime? _endTime;
        private string _errorMessage;
        private string _logGroup;
        private string _logStream;
        private string _messagePrefix;
        private DateTime? _startTime;
        private CrawlerHistoryState _state;
        private string _summary;

        /// <summary>
        /// Gets and sets the property CrawlId. 
        /// <para>
        /// A UUID identifier for each crawl.
        /// </para>
        /// </summary>
        public string CrawlId
        {
            get { return this._crawlId; }
            set { this._crawlId = value; }
        }

        // Check to see if CrawlId property is set
        internal bool IsSetCrawlId()
        {
            return this._crawlId != null;
        }

        /// <summary>
        /// Gets and sets the property DPUHour. 
        /// <para>
        /// The number of data processing units (DPU) used in hours for the crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double? DPUHour
        {
            get { return this._dpuHour; }
            set { this._dpuHour = value; }
        }

        // Check to see if DPUHour property is set
        internal bool IsSetDPUHour()
        {
            return this._dpuHour.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time on which the crawl ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// If an error occurred, the error message associated with the crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroup. 
        /// <para>
        /// The log group associated with the crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogGroup
        {
            get { return this._logGroup; }
            set { this._logGroup = value; }
        }

        // Check to see if LogGroup property is set
        internal bool IsSetLogGroup()
        {
            return this._logGroup != null;
        }

        /// <summary>
        /// Gets and sets the property LogStream. 
        /// <para>
        /// The log stream associated with the crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogStream
        {
            get { return this._logStream; }
            set { this._logStream = value; }
        }

        // Check to see if LogStream property is set
        internal bool IsSetLogStream()
        {
            return this._logStream != null;
        }

        /// <summary>
        /// Gets and sets the property MessagePrefix. 
        /// <para>
        /// The prefix for a CloudWatch message about this crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string MessagePrefix
        {
            get { return this._messagePrefix; }
            set { this._messagePrefix = value; }
        }

        // Check to see if MessagePrefix property is set
        internal bool IsSetMessagePrefix()
        {
            return this._messagePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time on which the crawl started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the crawl.
        /// </para>
        /// </summary>
        public CrawlerHistoryState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// A run summary for the specific crawl in JSON. Contains the catalog tables and partitions
        /// that were added, updated, or deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

    }
}