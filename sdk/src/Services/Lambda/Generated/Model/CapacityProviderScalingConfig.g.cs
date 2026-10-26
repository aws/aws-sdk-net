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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Configuration that defines how the capacity provider scales compute instances based
    /// on demand and policies.
    /// </summary>
    public partial class CapacityProviderScalingConfig
    {
        /// <summary>
        /// Gets and sets the property MaxVCpuCount. 
        /// <para>
        /// The maximum number of vCPUs that the capacity provider can provision across all compute
        /// instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 15000)]
        public int? MaxVCpuCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxVCpuCount property is set.
        /// </summary>
        internal bool IsSetMaxVCpuCount() => this.MaxVCpuCount.HasValue;

        /// <summary>
        /// Gets and sets the property ScalingMode. 
        /// <para>
        /// The scaling mode that determines how the capacity provider responds to changes in
        /// demand.
        /// </para>
        /// </summary>
        public CapacityProviderScalingMode ScalingMode { get; set; }

        /// <summary>
        /// Checks to see if the ScalingMode property is set.
        /// </summary>
        internal bool IsSetScalingMode() => this.ScalingMode != null;

        /// <summary>
        /// Gets and sets the property ScalingPolicies. 
        /// <para>
        /// A list of scaling policies that define how the capacity provider scales compute instances
        /// based on metrics and thresholds.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<TargetTrackingScalingPolicy> ScalingPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<TargetTrackingScalingPolicy>() : null;

        /// <summary>
        /// Checks to see if the ScalingPolicies property is set.
        /// </summary>
        internal bool IsSetScalingPolicies() => this.ScalingPolicies != null && (this.ScalingPolicies.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
