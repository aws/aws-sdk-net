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
    /// &lt;p&gt;Time range settings for extracting a specific window of video time-series
    /// data to process.&lt;/p&gt; &lt;p&gt;Trim settings define the time bounds for enrichment
    /// and must satisfy:&lt;/p&gt; &lt;ul&gt; &lt;li&gt;Start and end times must be within
    /// the dataset's time bounds&lt;/li&gt; &lt;li&gt;Trim settings retrieve fully contained
    /// data segments within the specified time range&lt;/li&gt; &lt;li&gt;endTime must be
    /// greater than startTime&lt;/li&gt; &lt;li&gt;Both times should represent valid data
    /// ranges in the dataset&lt;/li&gt; &lt;/ul&gt; &lt;p&gt;Trim settings are required to:&lt;/p&gt;
    /// &lt;ul&gt; &lt;li&gt;Prevent accidentally analyzing unbounded datasets&lt;/li&gt;
    /// &lt;li&gt;Ensure predictable processing time and costs&lt;/li&gt; &lt;li&gt;Allow
    /// focused analysis on specific time periods of interest&lt;/li&gt; &lt;/ul&gt;
    /// </summary>
    public partial class EnrichmentTrimSettings
    {
        private TimeInNanos _endTime;
        private TimeInNanos _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. &lt;p&gt;End time for the video analysis time
        /// range in nanoseconds since Unix epoch (TimeInNanos format). Data segments at or before
        /// this time are included in the enrichment. Must be greater than startTime and within
        /// the dataset's time bounds.&lt;/p&gt;
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeInNanos EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. &lt;p&gt;Start time for the video analysis time
        /// range in nanoseconds since Unix epoch (TimeInNanos format). Data segments at or after
        /// this time are included in the enrichment. Must be within the dataset's time bounds.&lt;/p&gt;
        /// &lt;p&gt;Example (JavaScript): Date.parse('2024-01-01T00:00:00Z') * 1000000 Example
        /// (Python): int(datetime.timestamp() * 1e9)&lt;/p&gt;
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeInNanos StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

    }
}