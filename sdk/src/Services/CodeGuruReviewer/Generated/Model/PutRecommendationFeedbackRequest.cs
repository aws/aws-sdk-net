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
    /// Container for the parameters to the PutRecommendationFeedback operation.
    /// Stores customer feedback for a CodeGuru Reviewer recommendation. When this API is
    /// called again with different reactions the previous feedback is overwritten.
    /// </summary>
    public partial class PutRecommendationFeedbackRequest : AmazonCodeGuruReviewerRequest
    {
        private string _codeReviewArn;
        private List<string> _reactions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _recommendationId;

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
        /// Gets and sets the property Reactions. 
        /// <para>
        /// List for storing reactions. Reactions are utf-8 text code for emojis. If you send
        /// an empty list it clears all your feedback.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public List<string> Reactions
        {
            get { return this._reactions; }
            set { this._reactions = value; }
        }

        // Check to see if Reactions property is set
        internal bool IsSetReactions()
        {
            return this._reactions != null && (this._reactions.Count > 0 || !AWSConfigs.InitializeCollections); 
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

    }
}