/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// The structure representing the BatchGetFrameMetricDataResponse.
    /// </summary>
    public partial class BatchGetFrameMetricDataResponse : AmazonWebServiceResponse
    {
        private DateTime? _endTime;
        private List<TimestampStructure> _endTimes = new List<TimestampStructure>();
        private List<FrameMetricDatum> _frameMetricData = new List<FrameMetricDatum>();
        private AggregationPeriod _resolution;
        private DateTime? _startTime;
        private Dictionary<string, List<TimestampStructure>> _unprocessedEndTimes = new Dictionary<string, List<TimestampStructure>>();

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The end time of the time period for the returned time series values. This is specified
        /// using the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond
        /// past June 1, 2020 1:15:02 PM UTC. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTimes. 
        /// <para>
        ///  List of instances, or time steps, in the time series. For example, if the <code>period</code>
        /// is one day (<code>PT24H)</code>), and the <code>resolution</code> is five minutes
        /// (<code>PT5M</code>), then there are 288 <code>endTimes</code> in the list that are
        /// each five minutes appart. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<TimestampStructure> EndTimes
        {
            get { return this._endTimes; }
            set { this._endTimes = value; }
        }

        // Check to see if EndTimes property is set
        internal bool IsSetEndTimes()
        {
            return this._endTimes != null && this._endTimes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FrameMetricData. 
        /// <para>
        /// Details of the metrics to request a time series of values. The metric includes the
        /// name of the frame, the aggregation type to calculate the metric value for the frame,
        /// and the thread states to use to get the count for the metric value of the frame.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FrameMetricDatum> FrameMetricData
        {
            get { return this._frameMetricData; }
            set { this._frameMetricData = value; }
        }

        // Check to see if FrameMetricData property is set
        internal bool IsSetFrameMetricData()
        {
            return this._frameMetricData != null && this._frameMetricData.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Resolution. 
        /// <para>
        /// Resolution or granularity of the profile data used to generate the time series. This
        /// is the value used to jump through time steps in a time series. There are 3 valid values.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>P1D</code> — 1 day 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PT1H</code> — 1 hour 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PT5M</code> — 5 minutes 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AggregationPeriod Resolution
        {
            get { return this._resolution; }
            set { this._resolution = value; }
        }

        // Check to see if Resolution property is set
        internal bool IsSetResolution()
        {
            return this._resolution != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start time of the time period for the returned time series values. This is specified
        /// using the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond
        /// past June 1, 2020 1:15:02 PM UTC. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedEndTimes. 
        /// <para>
        /// List of instances which remained unprocessed. This will create a missing time step
        /// in the list of end times.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, List<TimestampStructure>> UnprocessedEndTimes
        {
            get { return this._unprocessedEndTimes; }
            set { this._unprocessedEndTimes = value; }
        }

        // Check to see if UnprocessedEndTimes property is set
        internal bool IsSetUnprocessedEndTimes()
        {
            return this._unprocessedEndTimes != null && this._unprocessedEndTimes.Count > 0; 
        }

    }
}