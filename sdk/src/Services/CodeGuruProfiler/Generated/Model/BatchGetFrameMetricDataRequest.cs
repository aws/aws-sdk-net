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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
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
    /// Container for the parameters to the BatchGetFrameMetricData operation.
    /// Returns the time series of values for a requested list of frame metrics from a time
    /// period.
    /// </summary>
    public partial class BatchGetFrameMetricDataRequest : AmazonCodeGuruProfilerRequest
    {
        private DateTime? _endTime;
        private List<FrameMetric> _frameMetrics = AWSConfigs.InitializeCollections ? new List<FrameMetric>() : null;
        private string _period;
        private string _profilingGroupName;
        private DateTime? _startTime;
        private AggregationPeriod _targetResolution;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The end time of the time period for the returned time series values. This is specified
        /// using the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond
        /// past June 1, 2020 1:15:02 PM UTC. 
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
        /// Gets and sets the property FrameMetrics. 
        /// <para>
        ///  The details of the metrics that are used to request a time series of values. The
        /// metric includes the name of the frame, the aggregation type to calculate the metric
        /// value for the frame, and the thread states to use to get the count for the metric
        /// value of the frame.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FrameMetric> FrameMetrics
        {
            get { return this._frameMetrics; }
            set { this._frameMetrics = value; }
        }

        // Check to see if FrameMetrics property is set
        internal bool IsSetFrameMetrics()
        {
            return this._frameMetrics != null && (this._frameMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        ///  The duration of the frame metrics used to return the time series values. Specify
        /// using the ISO 8601 format. The maximum period duration is one day (<c>PT24H</c> or
        /// <c>P1D</c>). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period != null;
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        ///  The name of the profiling group associated with the the frame metrics used to return
        /// the time series values. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProfilingGroupName
        {
            get { return this._profilingGroupName; }
            set { this._profilingGroupName = value; }
        }

        // Check to see if ProfilingGroupName property is set
        internal bool IsSetProfilingGroupName()
        {
            return this._profilingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start time of the time period for the frame metrics used to return the time series
        /// values. This is specified using the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z
        /// represents 1 millisecond past June 1, 2020 1:15:02 PM UTC. 
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
        public AggregationPeriod TargetResolution
        {
            get { return this._targetResolution; }
            set { this._targetResolution = value; }
        }

        // Check to see if TargetResolution property is set
        internal bool IsSetTargetResolution()
        {
            return this._targetResolution != null;
        }

    }
}