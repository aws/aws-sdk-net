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
    /// Describes an Idle resource recommendation.
    /// </summary>
    public partial class IdleRecommendation
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the idle resource.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Finding. 
        /// <para>
        /// The finding classification of an idle resource.
        /// </para>
        /// </summary>
        public IdleFinding Finding { get; set; }

        /// <summary>
        /// Checks to see if the Finding property is set.
        /// </summary>
        internal bool IsSetFinding() => this.Finding != null;

        /// <summary>
        /// Gets and sets the property FindingDescription. 
        /// <para>
        /// A summary of the findings for the resource.
        /// </para>
        /// </summary>
        public string FindingDescription { get; set; }

        /// <summary>
        /// Checks to see if the FindingDescription property is set.
        /// </summary>
        internal bool IsSetFindingDescription() => this.FindingDescription != null;

        /// <summary>
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        /// The timestamp of when the idle resource recommendation was last generated.
        /// </para>
        /// </summary>
        public DateTime? LastRefreshTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastRefreshTimestamp property is set.
        /// </summary>
        internal bool IsSetLastRefreshTimestamp() => this.LastRefreshTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LookBackPeriodInDays. 
        /// <para>
        /// The number of days the idle resource utilization metrics were analyzed.
        /// </para>
        /// </summary>
        public double? LookBackPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the LookBackPeriodInDays property is set.
        /// </summary>
        internal bool IsSetLookBackPeriodInDays() => this.LookBackPeriodInDays.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the current idle resource.
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
        /// The unique identifier for the resource.
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource that is idle.
        /// </para>
        /// </summary>
        public IdleRecommendationResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SavingsOpportunity. 
        /// <para>
        /// The savings opportunity for the idle resource.
        /// </para>
        /// </summary>
        public IdleSavingsOpportunity SavingsOpportunity { get; set; }

        /// <summary>
        /// Checks to see if the SavingsOpportunity property is set.
        /// </summary>
        internal bool IsSetSavingsOpportunity() => this.SavingsOpportunity != null;

        /// <summary>
        /// Gets and sets the property SavingsOpportunityAfterDiscounts. 
        /// <para>
        /// The savings opportunity for the idle resource after any applying discounts.
        /// </para>
        /// </summary>
        public IdleSavingsOpportunityAfterDiscounts SavingsOpportunityAfterDiscounts { get; set; }

        /// <summary>
        /// Checks to see if the SavingsOpportunityAfterDiscounts property is set.
        /// </summary>
        internal bool IsSetSavingsOpportunityAfterDiscounts() => this.SavingsOpportunityAfterDiscounts != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags assigned to your idle resource recommendations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UtilizationMetrics. 
        /// <para>
        /// An array of objects that describe the utilization metrics of the idle resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IdleUtilizationMetric> UtilizationMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<IdleUtilizationMetric>() : null;

        /// <summary>
        /// Checks to see if the UtilizationMetrics property is set.
        /// </summary>
        internal bool IsSetUtilizationMetrics() => this.UtilizationMetrics != null && (this.UtilizationMetrics.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
