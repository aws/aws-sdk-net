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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// This is the response object from the GetInsightSummaries operation.
    /// </summary>
    public partial class GetInsightSummariesResponse : AmazonWebServiceResponse
    {
        private List<InsightSummary> _insightSummaries = new List<InsightSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InsightSummaries. 
        /// <para>
        /// The summary of each insight within the group matching the provided filters. The summary
        /// contains the InsightID, start and end time, the root cause service, the root cause
        /// and client impact statistics, the top anomalous services, and the status of the insight.
        /// </para>
        /// </summary>
        public List<InsightSummary> InsightSummaries
        {
            get { return this._insightSummaries; }
            set { this._insightSummaries = value; }
        }

        // Check to see if InsightSummaries property is set
        internal bool IsSetInsightSummaries()
        {
            return this._insightSummaries != null && this._insightSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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