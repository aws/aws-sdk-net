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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// This is the response object from the ListAssessmentFrameworkShareRequests operation.
    /// </summary>
    public partial class ListAssessmentFrameworkShareRequestsResponse : AmazonWebServiceResponse
    {
        private List<AssessmentFrameworkShareRequest> _assessmentFrameworkShareRequests = AWSConfigs.InitializeCollections ? new List<AssessmentFrameworkShareRequest>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AssessmentFrameworkShareRequests. 
        /// <para>
        ///  The list of share requests that the <c>ListAssessmentFrameworkShareRequests</c> API
        /// returned. 
        /// </para>
        /// </summary>
        public List<AssessmentFrameworkShareRequest> AssessmentFrameworkShareRequests
        {
            get { return this._assessmentFrameworkShareRequests; }
            set { this._assessmentFrameworkShareRequests = value; }
        }

        // Check to see if AssessmentFrameworkShareRequests property is set
        internal bool IsSetAssessmentFrameworkShareRequests()
        {
            return this._assessmentFrameworkShareRequests != null && (this._assessmentFrameworkShareRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token that's used to fetch the next set of results. 
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