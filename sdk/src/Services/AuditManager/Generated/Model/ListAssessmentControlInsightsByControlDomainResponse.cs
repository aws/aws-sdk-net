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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// This is the response object from the ListAssessmentControlInsightsByControlDomain operation.
    /// </summary>
    public partial class ListAssessmentControlInsightsByControlDomainResponse : AmazonWebServiceResponse
    {
        private List<ControlInsightsMetadataByAssessmentItem> _controlInsightsByAssessment = new List<ControlInsightsMetadataByAssessmentItem>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ControlInsightsByAssessment. 
        /// <para>
        /// The assessment control analytics data that the <code>ListAssessmentControlInsightsByControlDomain</code>
        /// API returned. 
        /// </para>
        /// </summary>
        public List<ControlInsightsMetadataByAssessmentItem> ControlInsightsByAssessment
        {
            get { return this._controlInsightsByAssessment; }
            set { this._controlInsightsByAssessment = value; }
        }

        // Check to see if ControlInsightsByAssessment property is set
        internal bool IsSetControlInsightsByAssessment()
        {
            return this._controlInsightsByAssessment != null && this._controlInsightsByAssessment.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token that's used to fetch the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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