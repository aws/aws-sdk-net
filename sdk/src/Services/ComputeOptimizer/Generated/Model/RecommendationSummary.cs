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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// A summary of a recommendation.
    /// </summary>
    public partial class RecommendationSummary
    {
        private string _accountId;
        private SavingsOpportunity _aggregatedSavingsOpportunity;
        private CurrentPerformanceRiskRatings _currentPerformanceRiskRatings;
        private SavingsOpportunity _idleSavingsOpportunity;
        private List<IdleSummary> _idleSummaries = AWSConfigs.InitializeCollections ? new List<IdleSummary>() : null;
        private List<InferredWorkloadSaving> _inferredWorkloadSavings = AWSConfigs.InitializeCollections ? new List<InferredWorkloadSaving>() : null;
        private RecommendationSourceType _recommendationResourceType;
        private SavingsOpportunity _savingsOpportunity;
        private List<Summary> _summaries = AWSConfigs.InitializeCollections ? new List<Summary>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the recommendation summary.
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
        /// Gets and sets the property AggregatedSavingsOpportunity.
        /// </summary>
        public SavingsOpportunity AggregatedSavingsOpportunity
        {
            get { return this._aggregatedSavingsOpportunity; }
            set { this._aggregatedSavingsOpportunity = value; }
        }

        // Check to see if AggregatedSavingsOpportunity property is set
        internal bool IsSetAggregatedSavingsOpportunity()
        {
            return this._aggregatedSavingsOpportunity != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentPerformanceRiskRatings. 
        /// <para>
        /// An object that describes the performance risk ratings for a given resource type.
        /// </para>
        /// </summary>
        public CurrentPerformanceRiskRatings CurrentPerformanceRiskRatings
        {
            get { return this._currentPerformanceRiskRatings; }
            set { this._currentPerformanceRiskRatings = value; }
        }

        // Check to see if CurrentPerformanceRiskRatings property is set
        internal bool IsSetCurrentPerformanceRiskRatings()
        {
            return this._currentPerformanceRiskRatings != null;
        }

        /// <summary>
        /// Gets and sets the property IdleSavingsOpportunity.
        /// </summary>
        public SavingsOpportunity IdleSavingsOpportunity
        {
            get { return this._idleSavingsOpportunity; }
            set { this._idleSavingsOpportunity = value; }
        }

        // Check to see if IdleSavingsOpportunity property is set
        internal bool IsSetIdleSavingsOpportunity()
        {
            return this._idleSavingsOpportunity != null;
        }

        /// <summary>
        /// Gets and sets the property IdleSummaries. 
        /// <para>
        ///  Describes the findings summary of the idle resources. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IdleSummary> IdleSummaries
        {
            get { return this._idleSummaries; }
            set { this._idleSummaries = value; }
        }

        // Check to see if IdleSummaries property is set
        internal bool IsSetIdleSummaries()
        {
            return this._idleSummaries != null && (this._idleSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InferredWorkloadSavings. 
        /// <para>
        ///  An array of objects that describes the estimated monthly saving amounts for the instances
        /// running on the specified <c>inferredWorkloadTypes</c>. The array contains the top
        /// five savings opportunites for the instances that run inferred workload types. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InferredWorkloadSaving> InferredWorkloadSavings
        {
            get { return this._inferredWorkloadSavings; }
            set { this._inferredWorkloadSavings = value; }
        }

        // Check to see if InferredWorkloadSavings property is set
        internal bool IsSetInferredWorkloadSavings()
        {
            return this._inferredWorkloadSavings != null && (this._inferredWorkloadSavings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecommendationResourceType. 
        /// <para>
        /// The resource type that the recommendation summary applies to.
        /// </para>
        /// </summary>
        public RecommendationSourceType RecommendationResourceType
        {
            get { return this._recommendationResourceType; }
            set { this._recommendationResourceType = value; }
        }

        // Check to see if RecommendationResourceType property is set
        internal bool IsSetRecommendationResourceType()
        {
            return this._recommendationResourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsOpportunity. 
        /// <para>
        /// An object that describes the savings opportunity for a given resource type. Savings
        /// opportunity includes the estimated monthly savings amount and percentage.
        /// </para>
        /// </summary>
        public SavingsOpportunity SavingsOpportunity
        {
            get { return this._savingsOpportunity; }
            set { this._savingsOpportunity = value; }
        }

        // Check to see if SavingsOpportunity property is set
        internal bool IsSetSavingsOpportunity()
        {
            return this._savingsOpportunity != null;
        }

        /// <summary>
        /// Gets and sets the property Summaries. 
        /// <para>
        /// An array of objects that describe a recommendation summary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Summary> Summaries
        {
            get { return this._summaries; }
            set { this._summaries = value; }
        }

        // Check to see if Summaries property is set
        internal bool IsSetSummaries()
        {
            return this._summaries != null && (this._summaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}