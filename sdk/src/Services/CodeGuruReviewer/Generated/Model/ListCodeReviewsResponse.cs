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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// This is the response object from the ListCodeReviews operation.
    /// </summary>
    public partial class ListCodeReviewsResponse : AmazonWebServiceResponse
    {
        private List<CodeReviewSummary> _codeReviewSummaries = new List<CodeReviewSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CodeReviewSummaries. 
        /// <para>
        ///  A list of code reviews that meet the criteria of the request. 
        /// </para>
        /// </summary>
        public List<CodeReviewSummary> CodeReviewSummaries
        {
            get { return this._codeReviewSummaries; }
            set { this._codeReviewSummaries = value; }
        }

        // Check to see if CodeReviewSummaries property is set
        internal bool IsSetCodeReviewSummaries()
        {
            return this._codeReviewSummaries != null && this._codeReviewSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  Pagination token. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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