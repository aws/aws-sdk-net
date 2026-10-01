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
    /// Time range settings for extracting a specific window of video time-series data to
    /// process.
    /// 
    ///  
    /// <para>
    /// Trim settings define the time bounds for enrichment and must satisfy:
    /// </para>
    ///  <ul> <li>Start and end times must be within the dataset's time bounds</li> <li>Trim
    /// settings retrieve fully contained data segments within the specified time range</li>
    /// <li>endTime must be greater than startTime</li> <li>Both times should represent valid
    /// data ranges in the dataset</li> </ul> 
    /// <para>
    /// Trim settings are required to:
    /// </para>
    ///  <ul> <li>Prevent accidentally analyzing unbounded datasets</li> <li>Ensure predictable
    /// processing time and costs</li> <li>Allow focused analysis on specific time periods
    /// of interest</li> </ul>
    /// </summary>
    public partial class EnrichmentTrimSettings
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// End time for the video analysis time range in nanoseconds since Unix epoch (TimeInNanos
        /// format). Data segments at or before this time are included in the enrichment. Must
        /// be greater than startTime and within the dataset's time bounds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeInNanos EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Start time for the video analysis time range in nanoseconds since Unix epoch (TimeInNanos
        /// format). Data segments at or after this time are included in the enrichment. Must
        /// be within the dataset's time bounds.
        /// </para>
        ///  
        /// <para>
        /// Example (JavaScript): Date.parse('2024-01-01T00:00:00Z') * 1000000 Example (Python):
        /// int(datetime.timestamp() * 1e9)
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeInNanos StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime != null;
    }
}
