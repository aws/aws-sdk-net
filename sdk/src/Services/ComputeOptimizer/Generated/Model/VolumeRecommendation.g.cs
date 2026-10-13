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
    /// Describes an Amazon Elastic Block Store (Amazon EBS) volume recommendation.
    /// </summary>
    public partial class VolumeRecommendation
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the volume.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CurrentConfiguration. 
        /// <para>
        /// An array of objects that describe the current configuration of the volume.
        /// </para>
        /// </summary>
        public VolumeConfiguration CurrentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CurrentConfiguration property is set.
        /// </summary>
        internal bool IsSetCurrentConfiguration() => this.CurrentConfiguration != null;

        /// <summary>
        /// Gets and sets the property CurrentPerformanceRisk. 
        /// <para>
        /// The risk of the current EBS volume not meeting the performance needs of its workloads.
        /// The higher the risk, the more likely the current EBS volume doesn't have sufficient
        /// capacity.
        /// </para>
        /// </summary>
        public CurrentPerformanceRisk CurrentPerformanceRisk { get; set; }

        /// <summary>
        /// Checks to see if the CurrentPerformanceRisk property is set.
        /// </summary>
        internal bool IsSetCurrentPerformanceRisk() => this.CurrentPerformanceRisk != null;

        /// <summary>
        /// Gets and sets the property EffectiveRecommendationPreferences. 
        /// <para>
        ///  Describes the effective recommendation preferences for Amazon EBS volume. 
        /// </para>
        /// </summary>
        public EBSEffectiveRecommendationPreferences EffectiveRecommendationPreferences { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveRecommendationPreferences property is set.
        /// </summary>
        internal bool IsSetEffectiveRecommendationPreferences() => this.EffectiveRecommendationPreferences != null;

        /// <summary>
        /// Gets and sets the property Finding. 
        /// <para>
        /// The finding classification of the volume.
        /// </para>
        ///  
        /// <para>
        /// Findings for volumes include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>NotOptimized</c> </b>—A volume is considered not optimized when Compute Optimizer
        /// identifies a recommendation that can provide better performance for your workload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Optimized</c> </b>—An volume is considered optimized when Compute Optimizer
        /// determines that the volume is correctly provisioned to run your workload based on
        /// the chosen volume type. For optimized resources, Compute Optimizer might recommend
        /// a new generation volume type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EBSFinding Finding { get; set; }

        /// <summary>
        /// Checks to see if the Finding property is set.
        /// </summary>
        internal bool IsSetFinding() => this.Finding != null;

        /// <summary>
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        /// The timestamp of when the volume recommendation was last generated.
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
        /// The number of days for which utilization metrics were analyzed for the volume.
        /// </para>
        /// </summary>
        public double? LookBackPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the LookBackPeriodInDays property is set.
        /// </summary>
        internal bool IsSetLookBackPeriodInDays() => this.LookBackPeriodInDays.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of tags assigned to your Amazon EBS volume recommendations. 
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
        /// An array of objects that describe the utilization metrics of the volume.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EBSUtilizationMetric> UtilizationMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<EBSUtilizationMetric>() : null;

        /// <summary>
        /// Checks to see if the UtilizationMetrics property is set.
        /// </summary>
        internal bool IsSetUtilizationMetrics() => this.UtilizationMetrics != null && (this.UtilizationMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VolumeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the current volume.
        /// </para>
        /// </summary>
        public string VolumeArn { get; set; }

        /// <summary>
        /// Checks to see if the VolumeArn property is set.
        /// </summary>
        internal bool IsSetVolumeArn() => this.VolumeArn != null;

        /// <summary>
        /// Gets and sets the property VolumeRecommendationOptions. 
        /// <para>
        /// An array of objects that describe the recommendation options for the volume.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VolumeRecommendationOption> VolumeRecommendationOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<VolumeRecommendationOption>() : null;

        /// <summary>
        /// Checks to see if the VolumeRecommendationOptions property is set.
        /// </summary>
        internal bool IsSetVolumeRecommendationOptions() => this.VolumeRecommendationOptions != null && (this.VolumeRecommendationOptions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
