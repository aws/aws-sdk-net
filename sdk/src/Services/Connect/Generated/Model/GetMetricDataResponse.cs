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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the GetMetricData operation.
    /// </summary>
    public partial class GetMetricDataResponse : AmazonWebServiceResponse
    {
        private List<HistoricalMetricResult> _metricResults = new List<HistoricalMetricResult>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MetricResults. 
        /// <para>
        /// Information about the historical metrics.
        /// </para>
        ///  
        /// <para>
        /// If no grouping is specified, a summary of metric data is returned.
        /// </para>
        /// </summary>
        public List<HistoricalMetricResult> MetricResults
        {
            get { return this._metricResults; }
            set { this._metricResults = value; }
        }

        // Check to see if MetricResults property is set
        internal bool IsSetMetricResults()
        {
            return this._metricResults != null && this._metricResults.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for the next set of results.
        /// </para>
        ///  
        /// <para>
        /// The token expires after 5 minutes from the time it is created. Subsequent requests
        /// that use the token must use the same request parameters as the request that generated
        /// the token.
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

    }
}