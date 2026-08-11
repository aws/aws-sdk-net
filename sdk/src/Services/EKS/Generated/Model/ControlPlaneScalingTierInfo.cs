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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
        private int? _apiRequestConcurrency;
        private int? _clusterDatabaseSizeGb;
        private ControlPlaneConfigInfo _controlPlaneComponentConfigOverrides;
        private int? _podSchedulingRatePerSecond;
        private string _tierName;

        /// <summary>
        /// Gets and sets the property ApiRequestConcurrency. 
        /// <para>
        /// The maximum API request concurrency supported by this tier.
        /// </para>
        /// </summary>
        public int? ApiRequestConcurrency
        {
            get { return this._apiRequestConcurrency; }
            set { this._apiRequestConcurrency = value; }
        }

        // Check to see if ApiRequestConcurrency property is set
        internal bool IsSetApiRequestConcurrency()
        {
            return this._apiRequestConcurrency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterDatabaseSizeGb. 
        /// <para>
        /// The maximum cluster database size in GB supported by this tier.
        /// </para>
        /// </summary>
        public int? ClusterDatabaseSizeGb
        {
            get { return this._clusterDatabaseSizeGb; }
            set { this._clusterDatabaseSizeGb = value; }
        }

        // Check to see if ClusterDatabaseSizeGb property is set
        internal bool IsSetClusterDatabaseSizeGb()
        {
            return this._clusterDatabaseSizeGb.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ControlPlaneComponentConfigOverrides. 
        /// <para>
        /// The control plane component configuration overrides specific to this scaling tier.
        /// </para>
        /// </summary>
        public ControlPlaneConfigInfo ControlPlaneComponentConfigOverrides
        {
            get { return this._controlPlaneComponentConfigOverrides; }
            set { this._controlPlaneComponentConfigOverrides = value; }
        }

        // Check to see if ControlPlaneComponentConfigOverrides property is set
        internal bool IsSetControlPlaneComponentConfigOverrides()
        {
            return this._controlPlaneComponentConfigOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property PodSchedulingRatePerSecond. 
        /// <para>
        /// The maximum pod scheduling rate per second supported by this tier.
        /// </para>
        /// </summary>
        public int? PodSchedulingRatePerSecond
        {
            get { return this._podSchedulingRatePerSecond; }
            set { this._podSchedulingRatePerSecond = value; }
        }

        // Check to see if PodSchedulingRatePerSecond property is set
        internal bool IsSetPodSchedulingRatePerSecond()
        {
            return this._podSchedulingRatePerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TierName. 
        /// <para>
        /// The name of the scaling tier.
        /// </para>
        /// </summary>
        public string TierName
        {
            get { return this._tierName; }
            set { this._tierName = value; }
        }

        // Check to see if TierName property is set
        internal bool IsSetTierName()
        {
            return this._tierName != null;
        }

    }
}