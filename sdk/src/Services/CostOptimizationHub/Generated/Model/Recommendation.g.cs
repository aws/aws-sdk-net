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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Describes a recommendation.
    /// </summary>
    public partial class Recommendation
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account to which the recommendation applies.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of tasks that can be carried out by this action.
        /// </para>
        /// </summary>
        public string ActionType { get; set; }

        /// <summary>
        /// Checks to see if the ActionType property is set.
        /// </summary>
        internal bool IsSetActionType() => this.ActionType != null;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code used for the recommendation.
        /// </para>
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property CurrentResourceSummary. 
        /// <para>
        /// Describes the current resource.
        /// </para>
        /// </summary>
        public string CurrentResourceSummary { get; set; }

        /// <summary>
        /// Checks to see if the CurrentResourceSummary property is set.
        /// </summary>
        internal bool IsSetCurrentResourceSummary() => this.CurrentResourceSummary != null;

        /// <summary>
        /// Gets and sets the property CurrentResourceType. 
        /// <para>
        /// The current resource type.
        /// </para>
        /// </summary>
        public string CurrentResourceType { get; set; }

        /// <summary>
        /// Checks to see if the CurrentResourceType property is set.
        /// </summary>
        internal bool IsSetCurrentResourceType() => this.CurrentResourceType != null;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlyCost. 
        /// <para>
        /// The estimated monthly cost of the current resource. For Reserved Instances and Savings
        /// Plans, it refers to the cost for eligible usage.
        /// </para>
        /// </summary>
        public double? EstimatedMonthlyCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlyCost property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlyCost() => this.EstimatedMonthlyCost.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings. 
        /// <para>
        /// The estimated monthly savings amount for the recommendation.
        /// </para>
        /// </summary>
        public double? EstimatedMonthlySavings { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlySavings property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlySavings() => this.EstimatedMonthlySavings.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedSavingsPercentage. 
        /// <para>
        /// The estimated savings percentage relative to the total cost over the cost calculation
        /// lookback period.
        /// </para>
        /// </summary>
        public double? EstimatedSavingsPercentage { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedSavingsPercentage property is set.
        /// </summary>
        internal bool IsSetEstimatedSavingsPercentage() => this.EstimatedSavingsPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property ImplementationEffort. 
        /// <para>
        /// The effort required to implement the recommendation.
        /// </para>
        /// </summary>
        public string ImplementationEffort { get; set; }

        /// <summary>
        /// Checks to see if the ImplementationEffort property is set.
        /// </summary>
        internal bool IsSetImplementationEffort() => this.ImplementationEffort != null;

        /// <summary>
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        /// The time when the recommendation was last generated.
        /// </para>
        /// </summary>
        public DateTime? LastRefreshTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastRefreshTimestamp property is set.
        /// </summary>
        internal bool IsSetLastRefreshTimestamp() => this.LastRefreshTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The ID for the recommendation.
        /// </para>
        /// </summary>
        public string RecommendationId { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationId property is set.
        /// </summary>
        internal bool IsSetRecommendationId() => this.RecommendationId != null;

        /// <summary>
        /// Gets and sets the property RecommendationLookbackPeriodInDays. 
        /// <para>
        /// The lookback period that's used to generate the recommendation.
        /// </para>
        /// </summary>
        public int? RecommendationLookbackPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationLookbackPeriodInDays property is set.
        /// </summary>
        internal bool IsSetRecommendationLookbackPeriodInDays() => this.RecommendationLookbackPeriodInDays.HasValue;

        /// <summary>
        /// Gets and sets the property RecommendedResourceSummary. 
        /// <para>
        /// Describes the recommended resource.
        /// </para>
        /// </summary>
        public string RecommendedResourceSummary { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedResourceSummary property is set.
        /// </summary>
        internal bool IsSetRecommendedResourceSummary() => this.RecommendedResourceSummary != null;

        /// <summary>
        /// Gets and sets the property RecommendedResourceType. 
        /// <para>
        /// The recommended resource type.
        /// </para>
        /// </summary>
        public string RecommendedResourceType { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedResourceType property is set.
        /// </summary>
        internal bool IsSetRecommendedResourceType() => this.RecommendedResourceType != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region of the resource.
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
        /// The Amazon Resource Name (ARN) for the recommendation.
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
        /// The resource ID for the recommendation.
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property RestartNeeded. 
        /// <para>
        /// Whether or not implementing the recommendation requires a restart.
        /// </para>
        /// </summary>
        public bool? RestartNeeded { get; set; }

        /// <summary>
        /// Checks to see if the RestartNeeded property is set.
        /// </summary>
        internal bool IsSetRestartNeeded() => this.RestartNeeded.HasValue;

        /// <summary>
        /// Gets and sets the property RollbackPossible. 
        /// <para>
        /// Whether or not implementing the recommendation can be rolled back.
        /// </para>
        /// </summary>
        public bool? RollbackPossible { get; set; }

        /// <summary>
        /// Checks to see if the RollbackPossible property is set.
        /// </summary>
        internal bool IsSetRollbackPossible() => this.RollbackPossible.HasValue;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the recommendation.
        /// </para>
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags assigned to the recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
