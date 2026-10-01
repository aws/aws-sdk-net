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

namespace Amazon.TrustedAdvisor.Model
{
    /// <summary>
    /// Summary of Recommendation for an Account
    /// </summary>
    public partial class RecommendationSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the Recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AwsServices. 
        /// <para>
        /// The AWS Services that the Recommendation applies to
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsServices { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AwsServices property is set.
        /// </summary>
        internal bool IsSetAwsServices() => this.AwsServices != null && (this.AwsServices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CheckArn. 
        /// <para>
        /// The AWS Trusted Advisor Check ARN that relates to the Recommendation
        /// </para>
        /// </summary>
        public string CheckArn { get; set; }

        /// <summary>
        /// Checks to see if the CheckArn property is set.
        /// </summary>
        internal bool IsSetCheckArn() => this.CheckArn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// When the Recommendation was created, if created by AWS Trusted Advisor Priority
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID which identifies where the Recommendation was produced
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// When the Recommendation was last updated
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LifecycleStage. 
        /// <para>
        /// The lifecycle stage from AWS Trusted Advisor Priority
        /// </para>
        /// </summary>
        public RecommendationLifecycleStage LifecycleStage { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleStage property is set.
        /// </summary>
        internal bool IsSetLifecycleStage() => this.LifecycleStage != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the AWS Trusted Advisor Recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PillarSpecificAggregates. 
        /// <para>
        /// The pillar aggregations for cost savings
        /// </para>
        /// </summary>
        public RecommendationPillarSpecificAggregates PillarSpecificAggregates { get; set; }

        /// <summary>
        /// Checks to see if the PillarSpecificAggregates property is set.
        /// </summary>
        internal bool IsSetPillarSpecificAggregates() => this.PillarSpecificAggregates != null;

        /// <summary>
        /// Gets and sets the property Pillars. 
        /// <para>
        /// The Pillars that the Recommendation is optimizing
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public List<string> Pillars { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Pillars property is set.
        /// </summary>
        internal bool IsSetPillars() => this.Pillars != null && (this.Pillars.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourcesAggregates. 
        /// <para>
        /// An aggregation of all resources
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationResourcesAggregates ResourcesAggregates { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesAggregates property is set.
        /// </summary>
        internal bool IsSetResourcesAggregates() => this.ResourcesAggregates != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the Recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// This attribute provides additional details about potential discrepancies in check
        /// status determination.
        /// </para>
        /// </summary>
        public StatusReason StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Whether the Recommendation was automated or generated by AWS Trusted Advisor Priority
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
