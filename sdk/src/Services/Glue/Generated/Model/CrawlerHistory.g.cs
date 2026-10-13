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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CrawlId. 
        /// <para>
        /// A UUID identifier for each crawl.
        /// </para>
        /// </summary>
        public string CrawlId { get; set; }

        /// <summary>
        /// Checks to see if the CrawlId property is set.
        /// </summary>
        internal bool IsSetCrawlId() => this.CrawlId != null;

        /// <summary>
        /// Gets and sets the property DPUHour. 
        /// <para>
        /// The number of data processing units (DPU) used in hours for the crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? DPUHour { get; set; }

        /// <summary>
        /// Checks to see if the DPUHour property is set.
        /// </summary>
        internal bool IsSetDPUHour() => this.DPUHour.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time on which the crawl ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// If an error occurred, the error message associated with the crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property LogGroup. 
        /// <para>
        /// The log group associated with the crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogGroup { get; set; }

        /// <summary>
        /// Checks to see if the LogGroup property is set.
        /// </summary>
        internal bool IsSetLogGroup() => this.LogGroup != null;

        /// <summary>
        /// Gets and sets the property LogStream. 
        /// <para>
        /// The log stream associated with the crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogStream { get; set; }

        /// <summary>
        /// Checks to see if the LogStream property is set.
        /// </summary>
        internal bool IsSetLogStream() => this.LogStream != null;

        /// <summary>
        /// Gets and sets the property MessagePrefix. 
        /// <para>
        /// The prefix for a CloudWatch message about this crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string MessagePrefix { get; set; }

        /// <summary>
        /// Checks to see if the MessagePrefix property is set.
        /// </summary>
        internal bool IsSetMessagePrefix() => this.MessagePrefix != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time on which the crawl started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the crawl.
        /// </para>
        /// </summary>
        public CrawlerHistoryState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// A run summary for the specific crawl in JSON. Contains the catalog tables and partitions
        /// that were added, updated, or deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;
    }
}
