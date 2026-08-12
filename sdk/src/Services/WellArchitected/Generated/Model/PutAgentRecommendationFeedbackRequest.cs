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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the PutAgentRecommendationFeedback operation.
    /// Submits user feedback on a recommendation to help improve future optimization suggestions
    /// and track implementation outcomes.
    /// </summary>
    public partial class PutAgentRecommendationFeedbackRequest : AmazonWellArchitectedRequest
    {
        private string _comments;
        private FeedbackCategory _feedbackCategory;
        private string _recommendationArn;
        private RecommendationFeedbackType _type;

        /// <summary>
        /// Gets and sets the property Comments. 
        /// <para>
        /// Optional comments providing additional context about the feedback.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Comments
        {
            get { return this._comments; }
            set { this._comments = value; }
        }

        // Check to see if Comments property is set
        internal bool IsSetComments()
        {
            return this._comments != null;
        }

        /// <summary>
        /// Gets and sets the property FeedbackCategory. 
        /// <para>
        /// Optional category classifying the nature of the feedback.
        /// </para>
        /// </summary>
        public FeedbackCategory FeedbackCategory
        {
            get { return this._feedbackCategory; }
            set { this._feedbackCategory = value; }
        }

        // Check to see if FeedbackCategory property is set
        internal bool IsSetFeedbackCategory()
        {
            return this._feedbackCategory != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommendation to provide feedback for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string RecommendationArn
        {
            get { return this._recommendationArn; }
            set { this._recommendationArn = value; }
        }

        // Check to see if RecommendationArn property is set
        internal bool IsSetRecommendationArn()
        {
            return this._recommendationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of feedback being provided.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationFeedbackType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}