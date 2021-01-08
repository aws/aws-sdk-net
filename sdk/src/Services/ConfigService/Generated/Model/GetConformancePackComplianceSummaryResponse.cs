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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the GetConformancePackComplianceSummary operation.
    /// </summary>
    public partial class GetConformancePackComplianceSummaryResponse : AmazonWebServiceResponse
    {
        private List<ConformancePackComplianceSummary> _conformancePackComplianceSummaryList = new List<ConformancePackComplianceSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConformancePackComplianceSummaryList. 
        /// <para>
        /// A list of <code>ConformancePackComplianceSummary</code> objects. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<ConformancePackComplianceSummary> ConformancePackComplianceSummaryList
        {
            get { return this._conformancePackComplianceSummaryList; }
            set { this._conformancePackComplianceSummaryList = value; }
        }

        // Check to see if ConformancePackComplianceSummaryList property is set
        internal bool IsSetConformancePackComplianceSummaryList()
        {
            return this._conformancePackComplianceSummaryList != null && this._conformancePackComplianceSummaryList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The nextToken string returned on a previous page that you use to get the next page
        /// of results in a paginated response.
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