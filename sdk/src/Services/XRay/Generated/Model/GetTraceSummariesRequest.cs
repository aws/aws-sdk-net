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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the GetTraceSummaries operation.
    /// Retrieves IDs and annotations for traces available for a specified time frame using
    /// an optional filter. To get the full traces, pass the trace IDs to <c>BatchGetTraces</c>.
    /// 
    ///  
    /// <para>
    /// A filter expression can target traced requests that hit specific service nodes or
    /// edges, have errors, or come from a known user. For example, the following filter expression
    /// targets traces that pass through <c>api.example.com</c>:
    /// </para>
    ///  
    /// <para>
    ///  <c>service("api.example.com")</c> 
    /// </para>
    ///  
    /// <para>
    /// This filter expression finds traces that have an annotation named <c>account</c> with
    /// the value <c>12345</c>:
    /// </para>
    ///  
    /// <para>
    ///  <c>annotation.account = "12345"</c> 
    /// </para>
    ///  
    /// <para>
    /// For a full list of indexed fields and keywords that you can use in filter expressions,
    /// see <a href="https://docs.aws.amazon.com/xray/latest/devguide/aws-xray-interface-console.html#xray-console-filters">Use
    /// filter expressions</a> in the <i>Amazon Web Services X-Ray Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetTraceSummariesRequest : AmazonXRayRequest
    {
        private DateTime? _endTime;
        private string _filterExpression;
        private string _nextToken;
        private bool? _sampling;
        private SamplingStrategy _samplingStrategy;
        private DateTime? _startTime;
        private TimeRangeType _timeRangeType;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time frame for which to retrieve traces.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property FilterExpression. 
        /// <para>
        /// Specify a filter expression to retrieve trace summaries for services or requests that
        /// meet certain requirements.
        /// </para>
        /// </summary>
        public string FilterExpression
        {
            get { return this._filterExpression; }
            set { this._filterExpression = value; }
        }

        // Check to see if FilterExpression property is set
        internal bool IsSetFilterExpression()
        {
            return this._filterExpression != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specify the pagination token returned by a previous request to retrieve the next page
        /// of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Sampling. 
        /// <para>
        /// Set to <c>true</c> to get summaries for only a subset of available traces.
        /// </para>
        /// </summary>
        public bool? Sampling
        {
            get { return this._sampling; }
            set { this._sampling = value; }
        }

        // Check to see if Sampling property is set
        internal bool IsSetSampling()
        {
            return this._sampling.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SamplingStrategy. 
        /// <para>
        /// A parameter to indicate whether to enable sampling on trace summaries. Input parameters
        /// are Name and Value.
        /// </para>
        /// </summary>
        public SamplingStrategy SamplingStrategy
        {
            get { return this._samplingStrategy; }
            set { this._samplingStrategy = value; }
        }

        // Check to see if SamplingStrategy property is set
        internal bool IsSetSamplingStrategy()
        {
            return this._samplingStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time frame for which to retrieve traces.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TimeRangeType. 
        /// <para>
        /// Query trace summaries by TraceId (trace start time), Event (trace update time), or
        /// Service (trace segment end time).
        /// </para>
        /// </summary>
        public TimeRangeType TimeRangeType
        {
            get { return this._timeRangeType; }
            set { this._timeRangeType = value; }
        }

        // Check to see if TimeRangeType property is set
        internal bool IsSetTimeRangeType()
        {
            return this._timeRangeType != null;
        }

    }
}