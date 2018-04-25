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
    /// This is the response object from the GetTraceSummaries operation.
    /// </summary>
    public partial class GetTraceSummariesResponse : AmazonWebServiceResponse
    {
        private DateTime? _approximateTime;
        private string _nextToken;
        private long? _tracesProcessedCount;
        private List<TraceSummary> _traceSummaries = new List<TraceSummary>();

        /// <summary>
        /// Gets and sets the property ApproximateTime. 
        /// <para>
        /// The start time of this page of results.
        /// </para>
        /// </summary>
        public DateTime ApproximateTime
        {
            get { return this._approximateTime.GetValueOrDefault(); }
            set { this._approximateTime = value; }
        }

        // Check to see if ApproximateTime property is set
        internal bool IsSetApproximateTime()
        {
            return this._approximateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the requested time frame contained more than one page of results, you can use this
        /// token to retrieve the next page. The first page contains the most most recent results,
        /// closest to the end of the time frame.
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
        /// Gets and sets the property TracesProcessedCount. 
        /// <para>
        /// The total number of traces processed, including traces that did not match the specified
        /// filter expression.
        /// </para>
        /// </summary>
        public long TracesProcessedCount
        {
            get { return this._tracesProcessedCount.GetValueOrDefault(); }
            set { this._tracesProcessedCount = value; }
        }

        // Check to see if TracesProcessedCount property is set
        internal bool IsSetTracesProcessedCount()
        {
            return this._tracesProcessedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TraceSummaries. 
        /// <para>
        /// Trace IDs and metadata for traces that were found in the specified time frame.
        /// </para>
        /// </summary>
        public List<TraceSummary> TraceSummaries
        {
            get { return this._traceSummaries; }
            set { this._traceSummaries = value; }
        }

        // Check to see if TraceSummaries property is set
        internal bool IsSetTraceSummaries()
        {
            return this._traceSummaries != null && this._traceSummaries.Count > 0; 
        }

    }
}