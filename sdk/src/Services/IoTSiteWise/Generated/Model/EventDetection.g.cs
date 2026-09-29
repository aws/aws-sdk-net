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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Configuration for event detection enrichment on video time-series data.
    /// 
    ///  
    /// <para>
    /// Event detection generates embeddings from video data enabling natural language similarity
    /// search on events. This allows customers to:
    /// </para>
    ///  <ul> <li>Query video events using semantic search after enrichment completes</li>
    /// <li>Find relevant video segments through natural language queries</li> <li>Search
    /// across video time-series data stored in IoT SiteWise</li> </ul> 
    /// <para>
    /// You must specify the dataset, exactly one time-series identifier (timeSeriesId OR
    /// propertyAlias), and trim settings defining the video time window to process.
    /// </para>
    /// </summary>
    public partial class EventDetection
    {
        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The IoT SiteWise dataset ID containing the video time-series data to analyze. Query
        /// IoT SiteWise to discover available datasets in your workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Checks to see if the DatasetId property is set.
        /// </summary>
        internal bool IsSetDatasetId() => this.DatasetId != null;

        /// <summary>
        /// Gets and sets the property PropertyAlias. 
        /// <para>
        /// Human-readable alias for the video time series to analyze (e.g., /camera/warehouse/zone-a).
        /// Specify either propertyAlias or timeSeriesId, but not both. Use this when you have
        /// configured friendly aliases in IoT SiteWise for better readability.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string PropertyAlias { get; set; }

        /// <summary>
        /// Checks to see if the PropertyAlias property is set.
        /// </summary>
        internal bool IsSetPropertyAlias() => this.PropertyAlias != null;

        /// <summary>
        /// Gets and sets the property TimeSeriesId. 
        /// <para>
        /// Unique system identifier for the video time series to analyze. Specify either timeSeriesId
        /// or propertyAlias, but not both. Use this when you have the system-generated time series
        /// identifier from IoT SiteWise.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 73)]
        public string TimeSeriesId { get; set; }

        /// <summary>
        /// Checks to see if the TimeSeriesId property is set.
        /// </summary>
        internal bool IsSetTimeSeriesId() => this.TimeSeriesId != null;

        /// <summary>
        /// Gets and sets the property TrimSettings. 
        /// <para>
        /// Time range settings defining which portion of the video time-series data to process.
        /// Required to ensure predictable processing time and prevent analyzing unbounded datasets.
        /// Start and end times must be within the dataset's time bounds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EnrichmentTrimSettings TrimSettings { get; set; }

        /// <summary>
        /// Checks to see if the TrimSettings property is set.
        /// </summary>
        internal bool IsSetTrimSettings() => this.TrimSettings != null;
    }
}
