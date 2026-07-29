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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
    /// &lt;p&gt;Configuration for event detection enrichment on video time-series data.&lt;/p&gt;
    /// &lt;p&gt;Event detection generates embeddings from video data enabling natural language
    /// similarity search on events. This allows customers to:&lt;/p&gt; &lt;ul&gt; &lt;li&gt;Query
    /// video events using semantic search after enrichment completes&lt;/li&gt; &lt;li&gt;Find
    /// relevant video segments through natural language queries&lt;/li&gt; &lt;li&gt;Search
    /// across video time-series data stored in IoT SiteWise&lt;/li&gt; &lt;/ul&gt; &lt;p&gt;You
    /// must specify the dataset, exactly one time-series identifier (timeSeriesId OR propertyAlias),
    /// and trim settings defining the video time window to process.&lt;/p&gt;
    /// </summary>
    public partial class EventDetection
    {
        private string _datasetId;
        private string _propertyAlias;
        private string _timeSeriesId;
        private EnrichmentTrimSettings _trimSettings;

        /// <summary>
        /// Gets and sets the property DatasetId. &lt;p&gt;The IoT SiteWise dataset ID containing
        /// the video time-series data to analyze. Query IoT SiteWise to discover available datasets
        /// in your workspace.&lt;/p&gt;
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string DatasetId
        {
            get { return this._datasetId; }
            set { this._datasetId = value; }
        }

        // Check to see if DatasetId property is set
        internal bool IsSetDatasetId()
        {
            return this._datasetId != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyAlias. &lt;p&gt;Human-readable alias for the video
        /// time series to analyze (e.g., /camera/warehouse/zone-a). Specify either propertyAlias
        /// or timeSeriesId, but not both. Use this when you have configured friendly aliases
        /// in IoT SiteWise for better readability.&lt;/p&gt;
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string PropertyAlias
        {
            get { return this._propertyAlias; }
            set { this._propertyAlias = value; }
        }

        // Check to see if PropertyAlias property is set
        internal bool IsSetPropertyAlias()
        {
            return this._propertyAlias != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesId. &lt;p&gt;Unique system identifier for the
        /// video time series to analyze. Specify either timeSeriesId or propertyAlias, but not
        /// both. Use this when you have the system-generated time series identifier from IoT
        /// SiteWise.&lt;/p&gt;
        /// </summary>
        [AWSProperty(Min=36, Max=73)]
        public string TimeSeriesId
        {
            get { return this._timeSeriesId; }
            set { this._timeSeriesId = value; }
        }

        // Check to see if TimeSeriesId property is set
        internal bool IsSetTimeSeriesId()
        {
            return this._timeSeriesId != null;
        }

        /// <summary>
        /// Gets and sets the property TrimSettings. &lt;p&gt;Time range settings defining which
        /// portion of the video time-series data to process. Required to ensure predictable processing
        /// time and prevent analyzing unbounded datasets. Start and end times must be within
        /// the dataset's time bounds.&lt;/p&gt;
        /// </summary>
        [AWSProperty(Required=true)]
        public EnrichmentTrimSettings TrimSettings
        {
            get { return this._trimSettings; }
            set { this._trimSettings = value; }
        }

        // Check to see if TrimSettings property is set
        internal bool IsSetTrimSettings()
        {
            return this._trimSettings != null;
        }

    }
}