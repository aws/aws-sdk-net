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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// The recommendation for your DB instances, DB clusters, and DB parameter groups.
    /// </summary>
    public partial class DBRecommendation
    {
        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Additional information about the recommendation. The information might contain markdown.
        /// </para>
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalInfo property is set.
        /// </summary>
        internal bool IsSetAdditionalInfo() => this.AdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the recommendation.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>performance efficiency</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>security</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>reliability</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cost optimization</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>operational excellence</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sustainability</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time when the recommendation was created. For example, <c>2023-09-28T01:13:53.931000+00:00</c>.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A detailed description of the recommendation. The description might contain markdown.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Detection. 
        /// <para>
        /// A short description of the issue identified for this recommendation. The description
        /// might contain markdown.
        /// </para>
        /// </summary>
        public string Detection { get; set; }

        /// <summary>
        /// Checks to see if the Detection property is set.
        /// </summary>
        internal bool IsSetDetection() => this.Detection != null;

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// A short description that explains the possible impact of an issue.
        /// </para>
        /// </summary>
        public string Impact { get; set; }

        /// <summary>
        /// Checks to see if the Impact property is set.
        /// </summary>
        internal bool IsSetImpact() => this.Impact != null;

        /// <summary>
        /// Gets and sets the property IssueDetails. 
        /// <para>
        /// Details of the issue that caused the recommendation.
        /// </para>
        /// </summary>
        public IssueDetails IssueDetails { get; set; }

        /// <summary>
        /// Checks to see if the IssueDetails property is set.
        /// </summary>
        internal bool IsSetIssueDetails() => this.IssueDetails != null;

        /// <summary>
        /// Gets and sets the property Links. 
        /// <para>
        /// A link to documentation that provides additional information about the recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocLink> Links { get; set; } = AWSConfigs.InitializeCollections ? new List<DocLink>() : null;

        /// <summary>
        /// Checks to see if the Links property is set.
        /// </summary>
        internal bool IsSetLinks() => this.Links != null && (this.Links.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason why this recommendation was created. The information might contain markdown.
        /// </para>
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// A short description of the recommendation to resolve an issue. The description might
        /// contain markdown.
        /// </para>
        /// </summary>
        public string Recommendation { get; set; }

        /// <summary>
        /// Checks to see if the Recommendation property is set.
        /// </summary>
        internal bool IsSetRecommendation() => this.Recommendation != null;

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The unique identifier of the recommendation.
        /// </para>
        /// </summary>
        public string RecommendationId { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationId property is set.
        /// </summary>
        internal bool IsSetRecommendationId() => this.RecommendationId != null;

        /// <summary>
        /// Gets and sets the property RecommendedActions. 
        /// <para>
        /// A list of recommended actions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendedAction> RecommendedActions { get; set; } = AWSConfigs.InitializeCollections ? new List<RecommendedAction>() : null;

        /// <summary>
        /// Checks to see if the RecommendedActions property is set.
        /// </summary>
        internal bool IsSetRecommendedActions() => this.RecommendedActions != null && (this.RecommendedActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the RDS resource associated with the recommendation.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity level of the recommendation. The severity level can help you decide the
        /// urgency with which to address the recommendation.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>high</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>medium</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>low</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>informational</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Amazon Web Services service that generated the recommendations.
        /// </para>
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the recommendation.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>active</c> - The recommendations which are ready for you to apply.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c> - The applied or scheduled recommendations which are in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resolved</c> - The recommendations which are completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dismissed</c> - The recommendations that you dismissed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TypeDetection. 
        /// <para>
        /// A short description of the recommendation type. The description might contain markdown.
        /// </para>
        /// </summary>
        public string TypeDetection { get; set; }

        /// <summary>
        /// Checks to see if the TypeDetection property is set.
        /// </summary>
        internal bool IsSetTypeDetection() => this.TypeDetection != null;

        /// <summary>
        /// Gets and sets the property TypeId. 
        /// <para>
        /// A value that indicates the type of recommendation. This value determines how the description
        /// is rendered.
        /// </para>
        /// </summary>
        public string TypeId { get; set; }

        /// <summary>
        /// Checks to see if the TypeId property is set.
        /// </summary>
        internal bool IsSetTypeId() => this.TypeId != null;

        /// <summary>
        /// Gets and sets the property TypeRecommendation. 
        /// <para>
        /// A short description that summarizes the recommendation to fix all the issues of the
        /// recommendation type. The description might contain markdown.
        /// </para>
        /// </summary>
        public string TypeRecommendation { get; set; }

        /// <summary>
        /// Checks to see if the TypeRecommendation property is set.
        /// </summary>
        internal bool IsSetTypeRecommendation() => this.TypeRecommendation != null;

        /// <summary>
        /// Gets and sets the property UpdatedTime. 
        /// <para>
        /// The time when the recommendation was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTime property is set.
        /// </summary>
        internal bool IsSetUpdatedTime() => this.UpdatedTime.HasValue;
    }
}
