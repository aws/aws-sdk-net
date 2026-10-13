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
    /// Describes an Lambda function recommendation.
    /// </summary>
    public partial class LambdaFunctionRecommendation
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the function.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CurrentMemorySize. 
        /// <para>
        /// The amount of memory, in MB, that's allocated to the current function.
        /// </para>
        /// </summary>
        public int? CurrentMemorySize { get; set; }

        /// <summary>
        /// Checks to see if the CurrentMemorySize property is set.
        /// </summary>
        internal bool IsSetCurrentMemorySize() => this.CurrentMemorySize.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentPerformanceRisk. 
        /// <para>
        /// The risk of the current Lambda function not meeting the performance needs of its workloads.
        /// The higher the risk, the more likely the current Lambda function requires more memory.
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
        ///  Describes the effective recommendation preferences for Lambda functions. 
        /// </para>
        /// </summary>
        public LambdaEffectiveRecommendationPreferences EffectiveRecommendationPreferences { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveRecommendationPreferences property is set.
        /// </summary>
        internal bool IsSetEffectiveRecommendationPreferences() => this.EffectiveRecommendationPreferences != null;

        /// <summary>
        /// Gets and sets the property Finding. 
        /// <para>
        /// The finding classification of the function.
        /// </para>
        ///  
        /// <para>
        /// Findings for functions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>Optimized</c> </b> — The function is correctly provisioned to run your workload
        /// based on its current configuration and its utilization history. This finding classification
        /// does not include finding reason codes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>NotOptimized</c> </b> — The function is performing at a higher level (over-provisioned)
        /// or at a lower level (under-provisioned) than required for your workload because its
        /// current configuration is not optimal. Over-provisioned resources might lead to unnecessary
        /// infrastructure cost, and under-provisioned resources might lead to poor application
        /// performance. This finding classification can include the <c>MemoryUnderprovisioned</c>
        /// and <c>MemoryUnderprovisioned</c> finding reason codes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Unavailable</c> </b> — Compute Optimizer was unable to generate a recommendation
        /// for the function. This could be because the function has not accumulated sufficient
        /// metric data, or the function does not qualify for a recommendation. This finding classification
        /// can include the <c>InsufficientData</c> and <c>Inconclusive</c> finding reason codes.
        /// </para>
        ///  <note> 
        /// <para>
        /// Functions with a finding of unavailable are not returned unless you specify the <c>filter</c>
        /// parameter with a value of <c>Unavailable</c> in your <c>GetLambdaFunctionRecommendations</c>
        /// request.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        public LambdaFunctionRecommendationFinding Finding { get; set; }

        /// <summary>
        /// Checks to see if the Finding property is set.
        /// </summary>
        internal bool IsSetFinding() => this.Finding != null;

        /// <summary>
        /// Gets and sets the property FindingReasonCodes. 
        /// <para>
        /// The reason for the finding classification of the function.
        /// </para>
        ///  <note> 
        /// <para>
        /// Functions that have a finding classification of <c>Optimized</c> don't have a finding
        /// reason code.
        /// </para>
        ///  </note> 
        /// <para>
        /// Finding reason codes for functions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>MemoryOverprovisioned</c> </b> — The function is over-provisioned when its
        /// memory configuration can be sized down while still meeting the performance requirements
        /// of your workload. An over-provisioned function might lead to unnecessary infrastructure
        /// cost. This finding reason code is part of the <c>NotOptimized</c> finding classification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>MemoryUnderprovisioned</c> </b> — The function is under-provisioned when its
        /// memory configuration doesn't meet the performance requirements of the workload. An
        /// under-provisioned function might lead to poor application performance. This finding
        /// reason code is part of the <c>NotOptimized</c> finding classification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>InsufficientData</c> </b> — The function does not have sufficient metric data
        /// for Compute Optimizer to generate a recommendation. For more information, see the
        /// <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>Compute Optimizer User Guide</i>. This finding
        /// reason code is part of the <c>Unavailable</c> finding classification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Inconclusive</c> </b> — The function does not qualify for a recommendation
        /// because Compute Optimizer cannot generate a recommendation with a high degree of confidence.
        /// This finding reason code is part of the <c>Unavailable</c> finding classification.
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
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the current function.
        /// </para>
        /// </summary>
        public string FunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the FunctionArn property is set.
        /// </summary>
        internal bool IsSetFunctionArn() => this.FunctionArn != null;

        /// <summary>
        /// Gets and sets the property FunctionVersion. 
        /// <para>
        /// The version number of the current function.
        /// </para>
        /// </summary>
        public string FunctionVersion { get; set; }

        /// <summary>
        /// Checks to see if the FunctionVersion property is set.
        /// </summary>
        internal bool IsSetFunctionVersion() => this.FunctionVersion != null;

        /// <summary>
        /// Gets and sets the property LastRefreshTimestamp. 
        /// <para>
        /// The timestamp of when the function recommendation was last generated.
        /// </para>
        /// </summary>
        public DateTime? LastRefreshTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastRefreshTimestamp property is set.
        /// </summary>
        internal bool IsSetLastRefreshTimestamp() => this.LastRefreshTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        /// The number of days for which utilization metrics were analyzed for the function.
        /// </para>
        /// </summary>
        public double? LookbackPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the LookbackPeriodInDays property is set.
        /// </summary>
        internal bool IsSetLookbackPeriodInDays() => this.LookbackPeriodInDays.HasValue;

        /// <summary>
        /// Gets and sets the property MemorySizeRecommendationOptions. 
        /// <para>
        /// An array of objects that describe the memory configuration recommendation options
        /// for the function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LambdaFunctionMemoryRecommendationOption> MemorySizeRecommendationOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<LambdaFunctionMemoryRecommendationOption>() : null;

        /// <summary>
        /// Checks to see if the MemorySizeRecommendationOptions property is set.
        /// </summary>
        internal bool IsSetMemorySizeRecommendationOptions() => this.MemorySizeRecommendationOptions != null && (this.MemorySizeRecommendationOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberOfInvocations. 
        /// <para>
        /// The number of times your function code was applied during the look-back period.
        /// </para>
        /// </summary>
        public long? NumberOfInvocations { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfInvocations property is set.
        /// </summary>
        internal bool IsSetNumberOfInvocations() => this.NumberOfInvocations.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of tags assigned to your Lambda function recommendations. 
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
        /// An array of objects that describe the utilization metrics of the function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LambdaFunctionUtilizationMetric> UtilizationMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<LambdaFunctionUtilizationMetric>() : null;

        /// <summary>
        /// Checks to see if the UtilizationMetrics property is set.
        /// </summary>
        internal bool IsSetUtilizationMetrics() => this.UtilizationMetrics != null && (this.UtilizationMetrics.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
