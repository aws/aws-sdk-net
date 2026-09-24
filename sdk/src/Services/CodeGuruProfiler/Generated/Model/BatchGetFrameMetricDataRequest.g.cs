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

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetFrameMetricData operation. Returns the
    /// time series of values for a requested list of frame metrics from a time period.
    /// </summary>
    public partial class BatchGetFrameMetricDataRequest : AmazonCodeGuruProfilerRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The end time of the time period for the returned time series values. This is specified
        /// using the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond
        /// past June 1, 2020 1:15:02 PM UTC. 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FrameMetrics. 
        /// <para>
        ///  The details of the metrics that are used to request a time series of values. The
        /// metric includes the name of the frame, the aggregation type to calculate the metric
        /// value for the frame, and the thread states to use to get the count for the metric
        /// value of the frame.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FrameMetric> FrameMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<FrameMetric>() : null;

        /// <summary>
        /// Checks to see if the FrameMetrics property is set.
        /// </summary>
        internal bool IsSetFrameMetrics() => this.FrameMetrics != null && (this.FrameMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        ///  The duration of the frame metrics used to return the time series values. Specify
        /// using the ISO 8601 format. The maximum period duration is one day (<c>PT24H</c> or
        /// <c>P1D</c>). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period != null;

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        ///  The name of the profiling group associated with the the frame metrics used to return
        /// the time series values. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ProfilingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ProfilingGroupName property is set.
        /// </summary>
        internal bool IsSetProfilingGroupName() => this.ProfilingGroupName != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start time of the time period for the frame metrics used to return the time series
        /// values. This is specified using the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z
        /// represents 1 millisecond past June 1, 2020 1:15:02 PM UTC. 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TargetResolution. 
        /// <para>
        /// The requested resolution of time steps for the returned time series of values. If
        /// the requested target resolution is not available due to data not being retained we
        /// provide a best effort result by falling back to the most granular available resolution
        /// after the target resolution. There are 3 valid values. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>P1D</c> — 1 day 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PT1H</c> — 1 hour 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PT5M</c> — 5 minutes 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AggregationPeriod TargetResolution { get; set; }

        /// <summary>
        /// Checks to see if the TargetResolution property is set.
        /// </summary>
        internal bool IsSetTargetResolution() => this.TargetResolution != null;
    }
}
