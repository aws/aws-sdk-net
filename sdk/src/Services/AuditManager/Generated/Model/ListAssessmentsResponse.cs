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
    /// This is the response object from the ListAssessments operation.
    /// </summary>
    public partial class ListAssessmentsResponse : AmazonWebServiceResponse
    {
        private List<AssessmentMetadataItem> _assessmentMetadata = new List<AssessmentMetadataItem>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AssessmentMetadata. 
        /// <para>
        ///  The metadata associated with the assessment. 
        /// </para>
        /// </summary>
        public List<AssessmentMetadataItem> AssessmentMetadata
        {
            get { return this._assessmentMetadata; }
            set { this._assessmentMetadata = value; }
        }

        // Check to see if AssessmentMetadata property is set
        internal bool IsSetAssessmentMetadata()
        {
            return this._assessmentMetadata != null && this._assessmentMetadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token used to fetch the next set of results. 
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