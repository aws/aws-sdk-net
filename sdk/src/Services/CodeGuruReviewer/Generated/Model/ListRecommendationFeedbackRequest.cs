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
    /// Container for the parameters to the ListRecommendationFeedback operation.
    /// Returns a list of <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RecommendationFeedbackSummary.html">RecommendationFeedbackSummary</a>
    /// objects that contain customer recommendation feedback for all CodeGuru Reviewer users.
    /// </summary>
    public partial class ListRecommendationFeedbackRequest : AmazonCodeGuruReviewerRequest
    {
        private string _codeReviewArn;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _recommendationIds = new List<string>();
        private List<string> _userIds = new List<string>();

        /// <summary>
        /// Gets and sets the property CodeReviewArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_CodeReview.html">CodeReview</a>
        /// object. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string CodeReviewArn
        {
            get { return this._codeReviewArn; }
            set { this._codeReviewArn = value; }
        }

        // Check to see if CodeReviewArn property is set
        internal bool IsSetCodeReviewArn()
        {
            return this._codeReviewArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that are returned per call. The default is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged.
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

        /// <summary>
        /// Gets and sets the property RecommendationIds. 
        /// <para>
        /// Used to query the recommendation feedback for a given recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> RecommendationIds
        {
            get { return this._recommendationIds; }
            set { this._recommendationIds = value; }
        }

        // Check to see if RecommendationIds property is set
        internal bool IsSetRecommendationIds()
        {
            return this._recommendationIds != null && this._recommendationIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserIds. 
        /// <para>
        /// An Amazon Web Services user's account ID or Amazon Resource Name (ARN). Use this ID
        /// to query the recommendation feedback for a code review from that user.
        /// </para>
        ///  
        /// <para>
        ///  The <code>UserId</code> is an IAM principal that can be specified as an Amazon Web
        /// Services account ID or an Amazon Resource Name (ARN). For more information, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html#Principal_specifying">
        /// Specifying a Principal</a> in the <i>Amazon Web Services Identity and Access Management
        /// User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> UserIds
        {
            get { return this._userIds; }
            set { this._userIds = value; }
        }

        // Check to see if UserIds property is set
        internal bool IsSetUserIds()
        {
            return this._userIds != null && this._userIds.Count > 0; 
        }

    }
}