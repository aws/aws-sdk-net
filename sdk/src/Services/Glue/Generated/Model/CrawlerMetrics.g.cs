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
    /// Metrics for a specified crawler.
    /// </summary>
    public partial class CrawlerMetrics
    {
        /// <summary>
        /// Gets and sets the property CrawlerName. 
        /// <para>
        /// The name of the crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CrawlerName { get; set; }

        /// <summary>
        /// Checks to see if the CrawlerName property is set.
        /// </summary>
        internal bool IsSetCrawlerName() => this.CrawlerName != null;

        /// <summary>
        /// Gets and sets the property LastRuntimeSeconds. 
        /// <para>
        /// The duration of the crawler's most recent run, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? LastRuntimeSeconds { get; set; }

        /// <summary>
        /// Checks to see if the LastRuntimeSeconds property is set.
        /// </summary>
        internal bool IsSetLastRuntimeSeconds() => this.LastRuntimeSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MedianRuntimeSeconds. 
        /// <para>
        /// The median duration of this crawler's runs, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? MedianRuntimeSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MedianRuntimeSeconds property is set.
        /// </summary>
        internal bool IsSetMedianRuntimeSeconds() => this.MedianRuntimeSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property StillEstimating. 
        /// <para>
        /// True if the crawler is still estimating how long it will take to complete this run.
        /// </para>
        /// </summary>
        public bool? StillEstimating { get; set; }

        /// <summary>
        /// Checks to see if the StillEstimating property is set.
        /// </summary>
        internal bool IsSetStillEstimating() => this.StillEstimating.HasValue;

        /// <summary>
        /// Gets and sets the property TablesCreated. 
        /// <para>
        /// The number of tables created by this crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TablesCreated { get; set; }

        /// <summary>
        /// Checks to see if the TablesCreated property is set.
        /// </summary>
        internal bool IsSetTablesCreated() => this.TablesCreated.HasValue;

        /// <summary>
        /// Gets and sets the property TablesDeleted. 
        /// <para>
        /// The number of tables deleted by this crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TablesDeleted { get; set; }

        /// <summary>
        /// Checks to see if the TablesDeleted property is set.
        /// </summary>
        internal bool IsSetTablesDeleted() => this.TablesDeleted.HasValue;

        /// <summary>
        /// Gets and sets the property TablesUpdated. 
        /// <para>
        /// The number of tables updated by this crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TablesUpdated { get; set; }

        /// <summary>
        /// Checks to see if the TablesUpdated property is set.
        /// </summary>
        internal bool IsSetTablesUpdated() => this.TablesUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property TimeLeftSeconds. 
        /// <para>
        /// The estimated time left to complete a running crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? TimeLeftSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeLeftSeconds property is set.
        /// </summary>
        internal bool IsSetTimeLeftSeconds() => this.TimeLeftSeconds.HasValue;
    }
}
