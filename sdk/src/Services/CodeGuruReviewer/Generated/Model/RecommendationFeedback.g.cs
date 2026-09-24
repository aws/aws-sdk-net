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

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Information about the recommendation feedback.
    /// </summary>
    public partial class RecommendationFeedback
    {
        /// <summary>
        /// Gets and sets the property CodeReviewArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_CodeReview.html">CodeReview</a>
        /// object. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string CodeReviewArn { get; set; }

        /// <summary>
        /// Checks to see if the CodeReviewArn property is set.
        /// </summary>
        internal bool IsSetCodeReviewArn() => this.CodeReviewArn != null;

        /// <summary>
        /// Gets and sets the property CreatedTimeStamp. 
        /// <para>
        /// The time at which the feedback was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimeStamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimeStamp() => this.CreatedTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimeStamp. 
        /// <para>
        /// The time at which the feedback was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimeStamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimeStamp() => this.LastUpdatedTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property Reactions. 
        /// <para>
        /// List for storing reactions. Reactions are utf-8 text code for emojis. You can send
        /// an empty list to clear off all your feedback.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> Reactions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Reactions property is set.
        /// </summary>
        internal bool IsSetReactions() => this.Reactions != null && (this.Reactions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The recommendation ID that can be used to track the provided recommendations. Later
        /// on it can be used to collect the feedback.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string RecommendationId { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationId property is set.
        /// </summary>
        internal bool IsSetRecommendationId() => this.RecommendationId != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the user that made the API call.
        /// </para>
        ///  
        /// <para>
        ///  The <c>UserId</c> is an IAM principal that can be specified as an Amazon Web Services
        /// account ID or an Amazon Resource Name (ARN). For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html#Principal_specifying">
        /// Specifying a Principal</a> in the <i>Amazon Web Services Identity and Access Management
        /// User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
