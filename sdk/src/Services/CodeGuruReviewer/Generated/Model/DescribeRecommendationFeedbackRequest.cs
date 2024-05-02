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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRecommendationFeedback operation.
    /// Describes the customer feedback for a CodeGuru Reviewer recommendation.
    /// </summary>
    public partial class DescribeRecommendationFeedbackRequest : AmazonCodeGuruReviewerRequest
    {
        private string _codeReviewArn;
        private string _recommendationId;
        private string _userId;

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
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The recommendation ID that can be used to track the provided recommendations and then
        /// to collect the feedback.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string RecommendationId
        {
            get { return this._recommendationId; }
            set { this._recommendationId = value; }
        }

        // Check to see if RecommendationId property is set
        internal bool IsSetRecommendationId()
        {
            return this._recommendationId != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// Optional parameter to describe the feedback for a given user. If this is not supplied,
        /// it defaults to the user making the request.
        /// </para>
        ///  
        /// <para>
        ///  The <c>UserId</c> is an IAM principal that can be specified as an Amazon Web Services
        /// account ID or an Amazon Resource Name (ARN). For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html#Principal_specifying">
        /// Specifying a Principal</a> in the <i>Amazon Web Services Identity and Access Management
        /// User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}