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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// This is the response object from the ListADAssessments operation.
    /// </summary>
    public partial class ListADAssessmentsResponse : AmazonWebServiceResponse
    {
        private List<AssessmentSummary> _assessments = AWSConfigs.InitializeCollections ? new List<AssessmentSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Assessments. 
        /// <para>
        /// A list of assessment summaries containing basic information about each directory assessment.
        /// </para>
        /// </summary>
        public List<AssessmentSummary> Assessments
        {
            get { return this._assessments; }
            set { this._assessments = value; }
        }

        // Check to see if Assessments property is set
        internal bool IsSetAssessments()
        {
            return this._assessments != null && (this._assessments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If not null, more results are available. Pass this value for the <c>NextToken</c>
        /// parameter in a subsequent request to retrieve the next set of items.
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