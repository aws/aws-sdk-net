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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Contains information about a recommended action that can be applied to optimize an
    /// Amazon Web Services resource.
    /// </summary>
    public partial class RecommendedAction
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the resource.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CurrentResourceDetails.
        /// </summary>
        public ResourceDetails CurrentResourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the CurrentResourceDetails property is set.
        /// </summary>
        internal bool IsSetCurrentResourceDetails() => this.CurrentResourceDetails != null;

        /// <summary>
        /// Gets and sets the property CurrentResourceSummary. 
        /// <para>
        /// A summary of the resource's current configuration.
        /// </para>
        /// </summary>
        public string CurrentResourceSummary { get; set; }

        /// <summary>
        /// Checks to see if the CurrentResourceSummary property is set.
        /// </summary>
        internal bool IsSetCurrentResourceSummary() => this.CurrentResourceSummary != null;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings.
        /// </summary>
        public EstimatedMonthlySavings EstimatedMonthlySavings { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlySavings property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlySavings() => this.EstimatedMonthlySavings != null;

        /// <summary>
        /// Gets and sets the property LookBackPeriodInDays. 
        /// <para>
        /// The number of days of historical data used to generate the recommendation.
        /// </para>
        /// </summary>
        public int? LookBackPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the LookBackPeriodInDays property is set.
        /// </summary>
        internal bool IsSetLookBackPeriodInDays() => this.LookBackPeriodInDays.HasValue;

        /// <summary>
        /// Gets and sets the property RecommendedActionId. 
        /// <para>
        /// The unique identifier of the recommended action.
        /// </para>
        /// </summary>
        public string RecommendedActionId { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedActionId property is set.
        /// </summary>
        internal bool IsSetRecommendedActionId() => this.RecommendedActionId != null;

        /// <summary>
        /// Gets and sets the property RecommendedActionType. 
        /// <para>
        /// The type of action being recommended.
        /// </para>
        /// </summary>
        public RecommendedActionType RecommendedActionType { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedActionType property is set.
        /// </summary>
        internal bool IsSetRecommendedActionType() => this.RecommendedActionType != null;

        /// <summary>
        /// Gets and sets the property RecommendedResourceDetails.
        /// </summary>
        public ResourceDetails RecommendedResourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedResourceDetails property is set.
        /// </summary>
        internal bool IsSetRecommendedResourceDetails() => this.RecommendedResourceDetails != null;

        /// <summary>
        /// Gets and sets the property RecommendedResourceSummary. 
        /// <para>
        /// A summary of the resource's recommended configuration.
        /// </para>
        /// </summary>
        public string RecommendedResourceSummary { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedResourceSummary property is set.
        /// </summary>
        internal bool IsSetRecommendedResourceSummary() => this.RecommendedResourceSummary != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where the resource is located.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource that the recommendation applies to.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource that the recommendation applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The tags associated with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public List<Tag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource being evaluated.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property RestartNeeded. 
        /// <para>
        /// Indicates whether implementing the recommended action requires a resource restart.
        /// </para>
        /// </summary>
        public bool? RestartNeeded { get; set; }

        /// <summary>
        /// Checks to see if the RestartNeeded property is set.
        /// </summary>
        internal bool IsSetRestartNeeded() => this.RestartNeeded.HasValue;
    }
}
