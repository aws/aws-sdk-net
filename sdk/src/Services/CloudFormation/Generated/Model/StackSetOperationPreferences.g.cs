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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The user-specified preferences for how CloudFormation performs a StackSet operation.
    /// 
    ///  
    /// <para>
    /// For more information about maximum concurrent accounts and failure tolerance, see
    /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-concepts.html#stackset-ops-options">StackSet
    /// operation options</a>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <c>StackSetOperationPreferences</c> don't apply to <c>AutoDeployment</c>, even if
    /// it's enabled.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StackSetOperationPreferences
    {
        /// <summary>
        /// Gets and sets the property ConcurrencyMode. 
        /// <para>
        /// Specifies how the concurrency level behaves during the operation execution.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STRICT_FAILURE_TOLERANCE</c>: This option dynamically lowers the concurrency level
        /// to ensure the number of failed accounts never exceeds the value of <c>FailureToleranceCount</c>
        /// +1. The initial actual concurrency is set to the lower of either the value of the
        /// <c>MaxConcurrentCount</c>, or the value of <c>FailureToleranceCount</c> +1. The actual
        /// concurrency is then reduced proportionally by the number of failures. This is the
        /// default behavior.
        /// </para>
        ///  
        /// <para>
        /// If failure tolerance or Maximum concurrent accounts are set to percentages, the behavior
        /// is similar.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SOFT_FAILURE_TOLERANCE</c>: This option decouples <c>FailureToleranceCount</c>
        /// from the actual concurrency. This allows StackSet operations to run at the concurrency
        /// level set by the <c>MaxConcurrentCount</c> value, or <c>MaxConcurrentPercentage</c>,
        /// regardless of the number of failures.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ConcurrencyMode ConcurrencyMode { get; set; }

        /// <summary>
        /// Checks to see if the ConcurrencyMode property is set.
        /// </summary>
        internal bool IsSetConcurrencyMode() => this.ConcurrencyMode != null;

        /// <summary>
        /// Gets and sets the property FailureToleranceCount. 
        /// <para>
        /// The number of accounts per Region this operation can fail in before CloudFormation
        /// stops the operation in that Region. If the operation is stopped in a Region, CloudFormation
        /// doesn't attempt the operation in any subsequent Regions.
        /// </para>
        ///  
        /// <para>
        /// You can specify either <c>FailureToleranceCount</c> or <c>FailureTolerancePercentage</c>,
        /// but not both.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>0</c> is specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? FailureToleranceCount { get; set; }

        /// <summary>
        /// Checks to see if the FailureToleranceCount property is set.
        /// </summary>
        internal bool IsSetFailureToleranceCount() => this.FailureToleranceCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailureTolerancePercentage. 
        /// <para>
        /// The percentage of accounts per Region this stack operation can fail in before CloudFormation
        /// stops the operation in that Region. If the operation is stopped in a Region, CloudFormation
        /// doesn't attempt the operation in any subsequent Regions.
        /// </para>
        ///  
        /// <para>
        /// When calculating the number of accounts based on the specified percentage, CloudFormation
        /// rounds <i>down</i> to the next whole number.
        /// </para>
        ///  
        /// <para>
        /// You can specify either <c>FailureToleranceCount</c> or <c>FailureTolerancePercentage</c>,
        /// but not both.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>0</c> is specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? FailureTolerancePercentage { get; set; }

        /// <summary>
        /// Checks to see if the FailureTolerancePercentage property is set.
        /// </summary>
        internal bool IsSetFailureTolerancePercentage() => this.FailureTolerancePercentage.HasValue;

        /// <summary>
        /// Gets and sets the property MaxConcurrentCount. 
        /// <para>
        /// The maximum number of accounts in which to perform this operation at one time. This
        /// can depend on the value of <c>FailureToleranceCount</c> depending on your <c>ConcurrencyMode</c>.
        /// <c>MaxConcurrentCount</c> is at most one more than the <c>FailureToleranceCount</c>
        /// if you're using <c>STRICT_FAILURE_TOLERANCE</c>.
        /// </para>
        ///  
        /// <para>
        /// Note that this setting lets you specify the <i>maximum</i> for operations. For large
        /// deployments, under certain circumstances the actual number of accounts acted upon
        /// concurrently may be lower due to service throttling.
        /// </para>
        ///  
        /// <para>
        /// You can specify either <c>MaxConcurrentCount</c> or <c>MaxConcurrentPercentage</c>,
        /// but not both.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>1</c> is specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxConcurrentCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrentCount property is set.
        /// </summary>
        internal bool IsSetMaxConcurrentCount() => this.MaxConcurrentCount.HasValue;

        /// <summary>
        /// Gets and sets the property MaxConcurrentPercentage. 
        /// <para>
        /// The maximum percentage of accounts in which to perform this operation at one time.
        /// </para>
        ///  
        /// <para>
        /// When calculating the number of accounts based on the specified percentage, CloudFormation
        /// rounds down to the next whole number. This is true except in cases where rounding
        /// down would result is zero. In this case, CloudFormation sets the number as one instead.
        /// </para>
        ///  
        /// <para>
        /// Note that this setting lets you specify the <i>maximum</i> for operations. For large
        /// deployments, under certain circumstances the actual number of accounts acted upon
        /// concurrently may be lower due to service throttling.
        /// </para>
        ///  
        /// <para>
        /// You can specify either <c>MaxConcurrentCount</c> or <c>MaxConcurrentPercentage</c>,
        /// but not both.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>1</c> is specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxConcurrentPercentage { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrentPercentage property is set.
        /// </summary>
        internal bool IsSetMaxConcurrentPercentage() => this.MaxConcurrentPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property RegionConcurrencyType. 
        /// <para>
        /// The concurrency type of deploying StackSets operations in Regions, could be in parallel
        /// or one Region at a time.
        /// </para>
        /// </summary>
        public RegionConcurrencyType RegionConcurrencyType { get; set; }

        /// <summary>
        /// Checks to see if the RegionConcurrencyType property is set.
        /// </summary>
        internal bool IsSetRegionConcurrencyType() => this.RegionConcurrencyType != null;

        /// <summary>
        /// Gets and sets the property RegionOrder. 
        /// <para>
        /// The order of the Regions where you want to perform the stack operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RegionOrder { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RegionOrder property is set.
        /// </summary>
        internal bool IsSetRegionOrder() => this.RegionOrder != null && (this.RegionOrder.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
