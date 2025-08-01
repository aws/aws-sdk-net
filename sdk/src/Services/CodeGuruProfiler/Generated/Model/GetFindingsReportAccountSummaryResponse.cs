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
    /// The structure representing the GetFindingsReportAccountSummaryResponse.
    /// </summary>
    public partial class GetFindingsReportAccountSummaryResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<FindingsReportSummary> _reportSummaries = AWSConfigs.InitializeCollections ? new List<FindingsReportSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value to include in a future <c>GetFindingsReportAccountSummary</c>
        /// request. When the results of a <c>GetFindingsReportAccountSummary</c> request exceed
        /// <c>maxResults</c>, this value can be used to retrieve the next page of results. This
        /// value is <c>null</c> when there are no more results to return.
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

        /// <summary>
        /// Gets and sets the property ReportSummaries. 
        /// <para>
        /// The return list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_FindingsReportSummary.html">
        /// <c>FindingsReportSummary</c> </a> objects taht contain summaries of analysis results
        /// for all profiling groups in your AWS account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FindingsReportSummary> ReportSummaries
        {
            get { return this._reportSummaries; }
            set { this._reportSummaries = value; }
        }

        // Check to see if ReportSummaries property is set
        internal bool IsSetReportSummaries()
        {
            return this._reportSummaries != null && (this._reportSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}