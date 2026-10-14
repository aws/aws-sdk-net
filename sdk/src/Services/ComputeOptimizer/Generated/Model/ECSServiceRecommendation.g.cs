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
    /// Describes an Amazon ECS service recommendation.
    /// </summary>
    public partial class ECSServiceRecommendation
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The Amazon Web Services account ID of the Amazon ECS service. 
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CurrentPerformanceRisk. 
        /// <para>
        ///  The risk of the current Amazon ECS service not meeting the performance needs of its
        /// workloads. The higher the risk, the more likely the current service can't meet the
        /// performance requirements of its workload. 
        /// </para>
        /// </summary>
        public CurrentPerformanceRisk CurrentPerformanceRisk { get; set; }

        /// <summary>
        /// Checks to see if the CurrentPerformanceRisk property is set.
        /// </summary>
        internal bool IsSetCurrentPerformanceRisk() => this.CurrentPerformanceRisk != null;

        /// <summary>
        /// Gets and sets the property CurrentServiceConfiguration. 
        /// <para>
        ///  The configuration of the current Amazon ECS service. 
        /// </para>
        /// </summary>
        public ServiceConfiguration CurrentServiceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CurrentServiceConfiguration property is set.
        /// </summary>
        internal bool IsSetCurrentServiceConfiguration() => this.CurrentServiceConfiguration != null;

        /// <summary>
        /// Gets and sets the property EffectiveRecommendationPreferences. 
        /// <para>
        ///  Describes the effective recommendation preferences for Amazon ECS services. 
        /// </para>
        /// </summary>
        public ECSEffectiveRecommendationPreferences EffectiveRecommendationPreferences { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveRecommendationPreferences property is set.
        /// </summary>
        internal bool IsSetEffectiveRecommendationPreferences() => this.EffectiveRecommendationPreferences != null;

        /// <summary>
        /// Gets and sets the property Finding. 
        /// <para>
        ///  The finding classification of an Amazon ECS service. 
        /// </para>
        ///  
        /// <para>
        /// Findings for Amazon ECS services include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>Underprovisioned</c> </b> — When Compute Optimizer detects that there’s not
        /// enough memory or CPU, an Amazon ECS service is considered under-provisioned. An under-provisioned
        /// service might result in poor application performance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Overprovisioned</c> </b> — When Compute Optimizer detects that there’s excessive
        /// memory or CPU, an Amazon ECS service is considered over-provisioned. An over-provisioned
        /// service might result in additional infrastructure costs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Optimized</c> </b> — When both the CPU and memory of your Amazon ECS service
        /// meet the performance requirements of your workload, the service is considered optimized.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ECSServiceRecommendationFinding Finding { get; set; }

        /// <summary>
        /// Checks to see if the Finding property is set.
        /// </summary>
        internal bool IsSetFinding() => this.Finding != null;

        /// <summary>
        /// Gets and sets the property FindingReasonCodes. 
        /// <para>
        ///  The reason for the finding classification of an Amazon ECS service. 
        /// </para>
        ///  
        /// <para>
        /// Finding reason codes for Amazon ECS services include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>CPUUnderprovisioned</c> </b> — The service CPU configuration can be sized
        /// up to enhance the performance of your workload. This is identified by analyzing the
        /// <c>CPUUtilization</c> metric of the current service during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>CPUOverprovisioned</c> </b> — The service CPU configuration can be sized down
        /// while still meeting the performance requirements of your workload. This is identified
        /// by analyzing the <c>CPUUtilization</c> metric of the current service during the look-back
        /// period. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>MemoryUnderprovisioned</c> </b> — The service memory configuration can be
        /// sized up to enhance the performance of your workload. This is identified by analyzing
        /// the <c>MemoryUtilization</c> metric of the current service during the look-back period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>MemoryOverprovisioned</c> </b> — The service memory configuration can be sized
        /// down while still meeting the performance requirements of your workload. This is identified
        /// by analyzing the <c>MemoryUtilization</c> metric of the current service during the
        /// look-back period.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FindingReasonCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FindingReasonCodes property is set.
        /// </summary>
        internal bool IsSetFindingReasonCodes() => this.FindingReasonCodes != null && (this.FindingReasonCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        ///  The timestamp of when the Amazon ECS service recommendation was last generated. 
        /// </para>
        /// </summary>
        public DateTime? LastRefreshTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastRefreshTimestamp property is set.
        /// </summary>
        internal bool IsSetLastRefreshTimestamp() => this.LastRefreshTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchType. 
        /// <para>
        ///  The launch type the Amazon ECS service is using. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Compute Optimizer only supports the Fargate launch type.
        /// </para>
        ///  </note>
        /// </summary>
        public ECSServiceLaunchType LaunchType { get; set; }

        /// <summary>
        /// Checks to see if the LaunchType property is set.
        /// </summary>
        internal bool IsSetLaunchType() => this.LaunchType != null;

        /// <summary>
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        ///  The number of days the Amazon ECS service utilization metrics were analyzed. 
        /// </para>
        /// </summary>
        public double? LookbackPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the LookbackPeriodInDays property is set.
        /// </summary>
        internal bool IsSetLookbackPeriodInDays() => this.LookbackPeriodInDays.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the current Amazon ECS service. 
        /// </para>
        ///  
        /// <para>
        ///  The following is the format of the ARN: 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:ecs:region:aws_account_id:service/cluster-name/service-name</c> 
        /// </para>
        /// </summary>
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property ServiceRecommendationOptions. 
        /// <para>
        ///  An array of objects that describe the recommendation options for the Amazon ECS service.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ECSServiceRecommendationOption> ServiceRecommendationOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<ECSServiceRecommendationOption>() : null;

        /// <summary>
        /// Checks to see if the ServiceRecommendationOptions property is set.
        /// </summary>
        internal bool IsSetServiceRecommendationOptions() => this.ServiceRecommendationOptions != null && (this.ServiceRecommendationOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of tags assigned to your Amazon ECS service recommendations. 
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
        ///  An array of objects that describe the utilization metrics of the Amazon ECS service.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ECSServiceUtilizationMetric> UtilizationMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<ECSServiceUtilizationMetric>() : null;

        /// <summary>
        /// Checks to see if the UtilizationMetrics property is set.
        /// </summary>
        internal bool IsSetUtilizationMetrics() => this.UtilizationMetrics != null && (this.UtilizationMetrics.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
