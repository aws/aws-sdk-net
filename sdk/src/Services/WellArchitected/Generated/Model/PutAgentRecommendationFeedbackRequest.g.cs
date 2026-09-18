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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the PutAgentRecommendationFeedback operation. Submits
    /// user feedback on a recommendation to help improve future optimization suggestions
    /// and track implementation outcomes.
    /// </summary>
    public partial class PutAgentRecommendationFeedbackRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property Comments. 
        /// <para>
        /// Optional comments providing additional context about the feedback.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Comments { get; set; }

        /// <summary>
        /// Checks to see if the Comments property is set.
        /// </summary>
        internal bool IsSetComments() => this.Comments != null;

        /// <summary>
        /// Gets and sets the property FeedbackCategory. 
        /// <para>
        /// Optional category classifying the nature of the feedback.
        /// </para>
        /// </summary>
        public FeedbackCategory FeedbackCategory { get; set; }

        /// <summary>
        /// Checks to see if the FeedbackCategory property is set.
        /// </summary>
        internal bool IsSetFeedbackCategory() => this.FeedbackCategory != null;

        /// <summary>
        /// Gets and sets the property RecommendationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommendation to provide feedback for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string RecommendationArn { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationArn property is set.
        /// </summary>
        internal bool IsSetRecommendationArn() => this.RecommendationArn != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of feedback being provided.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationFeedbackType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
