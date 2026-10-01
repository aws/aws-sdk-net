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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Creates a new grouping recommendation.
    /// </summary>
    public partial class GroupingRecommendation
    {
        /// <summary>
        /// Gets and sets the property ConfidenceLevel. 
        /// <para>
        /// Indicates the confidence level of Resilience Hub on the grouping recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GroupingRecommendationConfidenceLevel ConfidenceLevel { get; set; }

        /// <summary>
        /// Checks to see if the ConfidenceLevel property is set.
        /// </summary>
        internal bool IsSetConfidenceLevel() => this.ConfidenceLevel != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Indicates the creation time of the grouping recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property GroupingAppComponent. 
        /// <para>
        /// Indicates the name of the recommended Application Component (AppComponent).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GroupingAppComponent GroupingAppComponent { get; set; }

        /// <summary>
        /// Checks to see if the GroupingAppComponent property is set.
        /// </summary>
        internal bool IsSetGroupingAppComponent() => this.GroupingAppComponent != null;

        /// <summary>
        /// Gets and sets the property GroupingRecommendationId. 
        /// <para>
        /// Indicates all the reasons available for rejecting a grouping recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string GroupingRecommendationId { get; set; }

        /// <summary>
        /// Checks to see if the GroupingRecommendationId property is set.
        /// </summary>
        internal bool IsSetGroupingRecommendationId() => this.GroupingRecommendationId != null;

        /// <summary>
        /// Gets and sets the property RecommendationReasons. 
        /// <para>
        /// Indicates all the reasons available for rejecting a grouping recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> RecommendationReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RecommendationReasons property is set.
        /// </summary>
        internal bool IsSetRecommendationReasons() => this.RecommendationReasons != null && (this.RecommendationReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RejectionReason. 
        /// <para>
        /// Indicates the reason you had selected while rejecting a grouping recommendation.
        /// </para>
        /// </summary>
        public GroupingRecommendationRejectionReason RejectionReason { get; set; }

        /// <summary>
        /// Checks to see if the RejectionReason property is set.
        /// </summary>
        internal bool IsSetRejectionReason() => this.RejectionReason != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// Indicates the resources that are grouped in a recommended AppComponent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<GroupingResource> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<GroupingResource>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// Indicates the confidence level of the grouping recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of grouping resources into AppComponents.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GroupingRecommendationStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
