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
    /// This is the response object from the GetRecommendation operation.
    /// </summary>
    public partial class GetRecommendationResponse : AmazonWebServiceResponse
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
        /// The type of action you can take by adopting the recommendation.
        /// </para>
        /// </summary>
        public ActionType ActionType { get; set; }

        /// <summary>
        /// Checks to see if the ActionType property is set.
        /// </summary>
        internal bool IsSetActionType() => this.ActionType != null;

        /// <summary>
        /// Gets and sets the property CostCalculationLookbackPeriodInDays. 
        /// <para>
        /// The lookback period used to calculate cost impact for a recommendation.
        /// </para>
        /// </summary>
        public int? CostCalculationLookbackPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the CostCalculationLookbackPeriodInDays property is set.
        /// </summary>
        internal bool IsSetCostCalculationLookbackPeriodInDays() => this.CostCalculationLookbackPeriodInDays.HasValue;

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
        /// Gets and sets the property CurrentResourceDetails. 
        /// <para>
        /// The details for the resource.
        /// </para>
        /// </summary>
        public ResourceDetails CurrentResourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the CurrentResourceDetails property is set.
        /// </summary>
        internal bool IsSetCurrentResourceDetails() => this.CurrentResourceDetails != null;

        /// <summary>
        /// Gets and sets the property CurrentResourceType. 
        /// <para>
        /// The type of resource.
        /// </para>
        /// </summary>
        public ResourceType CurrentResourceType { get; set; }

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
        /// Gets and sets the property EstimatedSavingsOverCostCalculationLookbackPeriod. 
        /// <para>
        /// The estimated savings amount over the lookback period used to calculate cost impact
        /// for a recommendation.
        /// </para>
        /// </summary>
        public double? EstimatedSavingsOverCostCalculationLookbackPeriod { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedSavingsOverCostCalculationLookbackPeriod property is set.
        /// </summary>
        internal bool IsSetEstimatedSavingsOverCostCalculationLookbackPeriod() => this.EstimatedSavingsOverCostCalculationLookbackPeriod.HasValue;

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
        public ImplementationEffort ImplementationEffort { get; set; }

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
        /// Gets and sets the property RecommendedResourceDetails. 
        /// <para>
        /// The details about the recommended resource.
        /// </para>
        /// </summary>
        public ResourceDetails RecommendedResourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedResourceDetails property is set.
        /// </summary>
        internal bool IsSetRecommendedResourceDetails() => this.RecommendedResourceDetails != null;

        /// <summary>
        /// Gets and sets the property RecommendedResourceType. 
        /// <para>
        /// The resource type of the recommendation.
        /// </para>
        /// </summary>
        public ResourceType RecommendedResourceType { get; set; }

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
        /// The Amazon Resource Name (ARN) of the resource.
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
        /// The unique identifier for the resource. This is the same as the Amazon Resource Name
        /// (ARN), if available.
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
        /// A list of tags associated with the resource for which the recommendation exists.
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
