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

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// The structure representing the ListFindingsReportsResponse.
    /// </summary>
    public partial class ListFindingsReportsResponse : AmazonWebServiceResponse
    {
        private List<FindingsReportSummary> _findingsReportSummaries = new List<FindingsReportSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FindingsReportSummaries. 
        /// <para>
        /// The list of analysis results summaries.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FindingsReportSummary> FindingsReportSummaries
        {
            get { return this._findingsReportSummaries; }
            set { this._findingsReportSummaries = value; }
        }

        // Check to see if FindingsReportSummaries property is set
        internal bool IsSetFindingsReportSummaries()
        {
            return this._findingsReportSummaries != null && this._findingsReportSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value to include in a future <code>ListFindingsReports</code>
        /// request. When the results of a <code>ListFindingsReports</code> request exceed <code>maxResults</code>,
        /// this value can be used to retrieve the next page of results. This value is <code>null</code>
        /// when there are no more results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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