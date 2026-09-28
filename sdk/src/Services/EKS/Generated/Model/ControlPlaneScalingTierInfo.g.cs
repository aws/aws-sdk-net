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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Information about a provisioned control plane scaling tier.
    /// </summary>
    public partial class ControlPlaneScalingTierInfo
    {
        /// <summary>
        /// Gets and sets the property ApiRequestConcurrency. 
        /// <para>
        /// The maximum API request concurrency supported by this tier.
        /// </para>
        /// </summary>
        public int? ApiRequestConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the ApiRequestConcurrency property is set.
        /// </summary>
        internal bool IsSetApiRequestConcurrency() => this.ApiRequestConcurrency.HasValue;

        /// <summary>
        /// Gets and sets the property ClusterDatabaseSizeGb. 
        /// <para>
        /// The maximum cluster database size in GB supported by this tier.
        /// </para>
        /// </summary>
        public int? ClusterDatabaseSizeGb { get; set; }

        /// <summary>
        /// Checks to see if the ClusterDatabaseSizeGb property is set.
        /// </summary>
        internal bool IsSetClusterDatabaseSizeGb() => this.ClusterDatabaseSizeGb.HasValue;

        /// <summary>
        /// Gets and sets the property ControlPlaneComponentConfigOverrides. 
        /// <para>
        /// The control plane component configuration overrides specific to this scaling tier.
        /// </para>
        /// </summary>
        public ControlPlaneConfigInfo ControlPlaneComponentConfigOverrides { get; set; }

        /// <summary>
        /// Checks to see if the ControlPlaneComponentConfigOverrides property is set.
        /// </summary>
        internal bool IsSetControlPlaneComponentConfigOverrides() => this.ControlPlaneComponentConfigOverrides != null;

        /// <summary>
        /// Gets and sets the property PodSchedulingRatePerSecond. 
        /// <para>
        /// The maximum pod scheduling rate per second supported by this tier.
        /// </para>
        /// </summary>
        public int? PodSchedulingRatePerSecond { get; set; }

        /// <summary>
        /// Checks to see if the PodSchedulingRatePerSecond property is set.
        /// </summary>
        internal bool IsSetPodSchedulingRatePerSecond() => this.PodSchedulingRatePerSecond.HasValue;

        /// <summary>
        /// Gets and sets the property TierName. 
        /// <para>
        /// The name of the scaling tier.
        /// </para>
        /// </summary>
        public string TierName { get; set; }

        /// <summary>
        /// Checks to see if the TierName property is set.
        /// </summary>
        internal bool IsSetTierName() => this.TierName != null;
    }
}
