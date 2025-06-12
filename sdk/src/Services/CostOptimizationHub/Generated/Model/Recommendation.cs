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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
        private string _accountId;
        private string _actionType;
        private string _currencyCode;
        private string _currentResourceSummary;
        private string _currentResourceType;
        private double? _estimatedMonthlyCost;
        private double? _estimatedMonthlySavings;
        private double? _estimatedSavingsPercentage;
        private string _implementationEffort;
        private DateTime? _lastRefreshTimestamp;
        private string _recommendationId;
        private int? _recommendationLookbackPeriodInDays;
        private string _recommendedResourceSummary;
        private string _recommendedResourceType;
        private string _region;
        private string _resourceArn;
        private string _resourceId;
        private bool? _restartNeeded;
        private bool? _rollbackPossible;
        private Source _source;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account to which the recommendation applies.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of tasks that can be carried out by this action.
        /// </para>
        /// </summary>
        public string ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code used for the recommendation.
        /// </para>
        /// </summary>
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentResourceSummary. 
        /// <para>
        /// Describes the current resource.
        /// </para>
        /// </summary>
        public string CurrentResourceSummary
        {
            get { return this._currentResourceSummary; }
            set { this._currentResourceSummary = value; }
        }

        // Check to see if CurrentResourceSummary property is set
        internal bool IsSetCurrentResourceSummary()
        {
            return this._currentResourceSummary != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentResourceType. 
        /// <para>
        /// The current resource type.
        /// </para>
        /// </summary>
        public string CurrentResourceType
        {
            get { return this._currentResourceType; }
            set { this._currentResourceType = value; }
        }

        // Check to see if CurrentResourceType property is set
        internal bool IsSetCurrentResourceType()
        {
            return this._currentResourceType != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedMonthlyCost. 
        /// <para>
        /// The estimated monthly cost of the current resource. For Reserved Instances and Savings
        /// Plans, it refers to the cost for eligible usage.
        /// </para>
        /// </summary>
        public double? EstimatedMonthlyCost
        {
            get { return this._estimatedMonthlyCost; }
            set { this._estimatedMonthlyCost = value; }
        }

        // Check to see if EstimatedMonthlyCost property is set
        internal bool IsSetEstimatedMonthlyCost()
        {
            return this._estimatedMonthlyCost.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings. 
        /// <para>
        /// The estimated monthly savings amount for the recommendation.
        /// </para>
        /// </summary>
        public double? EstimatedMonthlySavings
        {
            get { return this._estimatedMonthlySavings; }
            set { this._estimatedMonthlySavings = value; }
        }

        // Check to see if EstimatedMonthlySavings property is set
        internal bool IsSetEstimatedMonthlySavings()
        {
            return this._estimatedMonthlySavings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedSavingsPercentage. 
        /// <para>
        /// The estimated savings percentage relative to the total cost over the cost calculation
        /// lookback period.
        /// </para>
        /// </summary>
        public double? EstimatedSavingsPercentage
        {
            get { return this._estimatedSavingsPercentage; }
            set { this._estimatedSavingsPercentage = value; }
        }

        // Check to see if EstimatedSavingsPercentage property is set
        internal bool IsSetEstimatedSavingsPercentage()
        {
            return this._estimatedSavingsPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImplementationEffort. 
        /// <para>
        /// The effort required to implement the recommendation.
        /// </para>
        /// </summary>
        public string ImplementationEffort
        {
            get { return this._implementationEffort; }
            set { this._implementationEffort = value; }
        }

        // Check to see if ImplementationEffort property is set
        internal bool IsSetImplementationEffort()
        {
            return this._implementationEffort != null;
        }

        /// <summary>
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        /// The time when the recommendation was last generated.
        /// </para>
        /// </summary>
        public DateTime? LastRefreshTimestamp
        {
            get { return this._lastRefreshTimestamp; }
            set { this._lastRefreshTimestamp = value; }
        }

        // Check to see if LastRefreshTimestamp property is set
        internal bool IsSetLastRefreshTimestamp()
        {
            return this._lastRefreshTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The ID for the recommendation.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RecommendationLookbackPeriodInDays. 
        /// <para>
        /// The lookback period that's used to generate the recommendation.
        /// </para>
        /// </summary>
        public int? RecommendationLookbackPeriodInDays
        {
            get { return this._recommendationLookbackPeriodInDays; }
            set { this._recommendationLookbackPeriodInDays = value; }
        }

        // Check to see if RecommendationLookbackPeriodInDays property is set
        internal bool IsSetRecommendationLookbackPeriodInDays()
        {
            return this._recommendationLookbackPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecommendedResourceSummary. 
        /// <para>
        /// Describes the recommended resource.
        /// </para>
        /// </summary>
        public string RecommendedResourceSummary
        {
            get { return this._recommendedResourceSummary; }
            set { this._recommendedResourceSummary = value; }
        }

        // Check to see if RecommendedResourceSummary property is set
        internal bool IsSetRecommendedResourceSummary()
        {
            return this._recommendedResourceSummary != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedResourceType. 
        /// <para>
        /// The recommended resource type.
        /// </para>
        /// </summary>
        public string RecommendedResourceType
        {
            get { return this._recommendedResourceType; }
            set { this._recommendedResourceType = value; }
        }

        // Check to see if RecommendedResourceType property is set
        internal bool IsSetRecommendedResourceType()
        {
            return this._recommendedResourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region of the resource.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the recommendation.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID for the recommendation.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property RestartNeeded. 
        /// <para>
        /// Whether or not implementing the recommendation requires a restart.
        /// </para>
        /// </summary>
        public bool? RestartNeeded
        {
            get { return this._restartNeeded; }
            set { this._restartNeeded = value; }
        }

        // Check to see if RestartNeeded property is set
        internal bool IsSetRestartNeeded()
        {
            return this._restartNeeded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RollbackPossible. 
        /// <para>
        /// Whether or not implementing the recommendation can be rolled back.
        /// </para>
        /// </summary>
        public bool? RollbackPossible
        {
            get { return this._rollbackPossible; }
            set { this._rollbackPossible = value; }
        }

        // Check to see if RollbackPossible property is set
        internal bool IsSetRollbackPossible()
        {
            return this._rollbackPossible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the recommendation.
        /// </para>
        /// </summary>
        public Source Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags assigned to the recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}