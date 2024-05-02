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
    /// Metrics for a specified crawler.
    /// </summary>
    public partial class CrawlerMetrics
    {
        private string _crawlerName;
        private double? _lastRuntimeSeconds;
        private double? _medianRuntimeSeconds;
        private bool? _stillEstimating;
        private int? _tablesCreated;
        private int? _tablesDeleted;
        private int? _tablesUpdated;
        private double? _timeLeftSeconds;

        /// <summary>
        /// Gets and sets the property CrawlerName. 
        /// <para>
        /// The name of the crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CrawlerName
        {
            get { return this._crawlerName; }
            set { this._crawlerName = value; }
        }

        // Check to see if CrawlerName property is set
        internal bool IsSetCrawlerName()
        {
            return this._crawlerName != null;
        }

        /// <summary>
        /// Gets and sets the property LastRuntimeSeconds. 
        /// <para>
        /// The duration of the crawler's most recent run, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double? LastRuntimeSeconds
        {
            get { return this._lastRuntimeSeconds; }
            set { this._lastRuntimeSeconds = value; }
        }

        // Check to see if LastRuntimeSeconds property is set
        internal bool IsSetLastRuntimeSeconds()
        {
            return this._lastRuntimeSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MedianRuntimeSeconds. 
        /// <para>
        /// The median duration of this crawler's runs, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double? MedianRuntimeSeconds
        {
            get { return this._medianRuntimeSeconds; }
            set { this._medianRuntimeSeconds = value; }
        }

        // Check to see if MedianRuntimeSeconds property is set
        internal bool IsSetMedianRuntimeSeconds()
        {
            return this._medianRuntimeSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StillEstimating. 
        /// <para>
        /// True if the crawler is still estimating how long it will take to complete this run.
        /// </para>
        /// </summary>
        public bool? StillEstimating
        {
            get { return this._stillEstimating; }
            set { this._stillEstimating = value; }
        }

        // Check to see if StillEstimating property is set
        internal bool IsSetStillEstimating()
        {
            return this._stillEstimating.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TablesCreated. 
        /// <para>
        /// The number of tables created by this crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TablesCreated
        {
            get { return this._tablesCreated; }
            set { this._tablesCreated = value; }
        }

        // Check to see if TablesCreated property is set
        internal bool IsSetTablesCreated()
        {
            return this._tablesCreated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TablesDeleted. 
        /// <para>
        /// The number of tables deleted by this crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TablesDeleted
        {
            get { return this._tablesDeleted; }
            set { this._tablesDeleted = value; }
        }

        // Check to see if TablesDeleted property is set
        internal bool IsSetTablesDeleted()
        {
            return this._tablesDeleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TablesUpdated. 
        /// <para>
        /// The number of tables updated by this crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TablesUpdated
        {
            get { return this._tablesUpdated; }
            set { this._tablesUpdated = value; }
        }

        // Check to see if TablesUpdated property is set
        internal bool IsSetTablesUpdated()
        {
            return this._tablesUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeLeftSeconds. 
        /// <para>
        /// The estimated time left to complete a running crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double? TimeLeftSeconds
        {
            get { return this._timeLeftSeconds; }
            set { this._timeLeftSeconds = value; }
        }

        // Check to see if TimeLeftSeconds property is set
        internal bool IsSetTimeLeftSeconds()
        {
            return this._timeLeftSeconds.HasValue; 
        }

    }
}