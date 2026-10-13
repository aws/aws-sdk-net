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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// A summary of a recommendation.
    /// </summary>
    public partial class RecommendationSummary
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the recommendation summary.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AggregatedSavingsOpportunity.
        /// </summary>
        public SavingsOpportunity AggregatedSavingsOpportunity { get; set; }

        /// <summary>
        /// Checks to see if the AggregatedSavingsOpportunity property is set.
        /// </summary>
        internal bool IsSetAggregatedSavingsOpportunity() => this.AggregatedSavingsOpportunity != null;

        /// <summary>
        /// Gets and sets the property CurrentPerformanceRiskRatings. 
        /// <para>
        /// An object that describes the performance risk ratings for a given resource type.
        /// </para>
        /// </summary>
        public CurrentPerformanceRiskRatings CurrentPerformanceRiskRatings { get; set; }

        /// <summary>
        /// Checks to see if the CurrentPerformanceRiskRatings property is set.
        /// </summary>
        internal bool IsSetCurrentPerformanceRiskRatings() => this.CurrentPerformanceRiskRatings != null;

        /// <summary>
        /// Gets and sets the property IdleSavingsOpportunity.
        /// </summary>
        public SavingsOpportunity IdleSavingsOpportunity { get; set; }

        /// <summary>
        /// Checks to see if the IdleSavingsOpportunity property is set.
        /// </summary>
        internal bool IsSetIdleSavingsOpportunity() => this.IdleSavingsOpportunity != null;

        /// <summary>
        /// Gets and sets the property IdleSummaries. 
        /// <para>
        ///  Describes the findings summary of the idle resources. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IdleSummary> IdleSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<IdleSummary>() : null;

        /// <summary>
        /// Checks to see if the IdleSummaries property is set.
        /// </summary>
        internal bool IsSetIdleSummaries() => this.IdleSummaries != null && (this.IdleSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InferredWorkloadSavings. 
        /// <para>
        ///  An array of objects that describes the estimated monthly saving amounts for the instances
        /// running on the specified <c>inferredWorkloadTypes</c>. The array contains the top
        /// five savings opportunites for the instances that run inferred workload types. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InferredWorkloadSaving> InferredWorkloadSavings { get; set; } = AWSConfigs.InitializeCollections ? new List<InferredWorkloadSaving>() : null;

        /// <summary>
        /// Checks to see if the InferredWorkloadSavings property is set.
        /// </summary>
        internal bool IsSetInferredWorkloadSavings() => this.InferredWorkloadSavings != null && (this.InferredWorkloadSavings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecommendationResourceType. 
        /// <para>
        /// The resource type that the recommendation summary applies to.
        /// </para>
        /// </summary>
        public RecommendationSourceType RecommendationResourceType { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationResourceType property is set.
        /// </summary>
        internal bool IsSetRecommendationResourceType() => this.RecommendationResourceType != null;

        /// <summary>
        /// Gets and sets the property SavingsOpportunity. 
        /// <para>
        /// An object that describes the savings opportunity for a given resource type. Savings
        /// opportunity includes the estimated monthly savings amount and percentage.
        /// </para>
        /// </summary>
        public SavingsOpportunity SavingsOpportunity { get; set; }

        /// <summary>
        /// Checks to see if the SavingsOpportunity property is set.
        /// </summary>
        internal bool IsSetSavingsOpportunity() => this.SavingsOpportunity != null;

        /// <summary>
        /// Gets and sets the property Summaries. 
        /// <para>
        /// An array of objects that describe a recommendation summary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Summary> Summaries { get; set; } = AWSConfigs.InitializeCollections ? new List<Summary>() : null;

        /// <summary>
        /// Checks to see if the Summaries property is set.
        /// </summary>
        internal bool IsSetSummaries() => this.Summaries != null && (this.Summaries.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
