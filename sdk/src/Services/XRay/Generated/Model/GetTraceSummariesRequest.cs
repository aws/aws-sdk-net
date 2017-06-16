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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the GetTraceSummaries operation.
    /// Retrieves IDs and metadata for traces available for a specified time frame using an
    /// optional filter. To get the full traces, pass the trace IDs to <code>BatchGetTraces</code>.
    /// 
    ///  
    /// <para>
    /// A filter expression can target traced requests that hit specific service nodes or
    /// edges, have errors, or come from a known user. For example, the following filter expression
    /// targets traces that pass through <code>api.example.com</code>:
    /// </para>
    ///  
    /// <para>
    ///  <code>service("api.example.com")</code> 
    /// </para>
    ///  
    /// <para>
    /// This filter expression finds traces that have an annotation named <code>account</code>
    /// with the value <code>12345</code>:
    /// </para>
    ///  
    /// <para>
    ///  <code>annotation.account = "12345"</code> 
    /// </para>
    ///  
    /// <para>
    /// For a full list of indexed fields and keywords that you can use in filter expressions,
    /// see <a href="http://docs.aws.amazon.com/xray/latest/devguide/xray-console-filters.html">Using
    /// Filter Expressions</a> in the <i>AWS X-Ray Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetTraceSummariesRequest : AmazonXRayRequest
    {
        private DateTime? _endTime;
        private string _filterExpression;
        private string _nextToken;
        private bool? _sampling;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time frame for which to retrieve traces.
        /// </para>
        /// </summary>
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
        /// Set to <code>true</code> to get summaries for only a subset of available traces.
        /// </para>
        /// </summary>
        public bool Sampling
        {
            get { return this._sampling.GetValueOrDefault(); }
            set { this._sampling = value; }
        }

        // Check to see if Sampling property is set
        internal bool IsSetSampling()
        {
            return this._sampling.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time frame for which to retrieve traces.
        /// </para>
        /// </summary>
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

    }
}