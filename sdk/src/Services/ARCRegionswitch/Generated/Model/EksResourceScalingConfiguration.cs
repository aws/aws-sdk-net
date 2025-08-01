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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// The Amazon Web Services EKS resource scaling configuration.
    /// </summary>
    public partial class EksResourceScalingConfiguration
    {
        private EksCapacityMonitoringApproach _capacityMonitoringApproach;
        private List<EksCluster> _eksClusters = AWSConfigs.InitializeCollections ? new List<EksCluster>() : null;
        private KubernetesResourceType _kubernetesResourceType;
        private List<Dictionary<string, Dictionary<string, KubernetesScalingResource>>> _scalingResources = AWSConfigs.InitializeCollections ? new List<Dictionary<string, Dictionary<string, KubernetesScalingResource>>>() : null;
        private int? _targetPercent;
        private int? _timeoutMinutes;
        private EksResourceScalingUngraceful _ungraceful;

        /// <summary>
        /// Gets and sets the property CapacityMonitoringApproach. 
        /// <para>
        /// The monitoring approach for the configuration, that is, whether it was sampled in
        /// the last 24 hours or autoscaled in the last 24 hours.
        /// </para>
        /// </summary>
        public EksCapacityMonitoringApproach CapacityMonitoringApproach
        {
            get { return this._capacityMonitoringApproach; }
            set { this._capacityMonitoringApproach = value; }
        }

        // Check to see if CapacityMonitoringApproach property is set
        internal bool IsSetCapacityMonitoringApproach()
        {
            return this._capacityMonitoringApproach != null;
        }

        /// <summary>
        /// Gets and sets the property EksClusters. 
        /// <para>
        /// The clusters for the configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2)]
        public List<EksCluster> EksClusters
        {
            get { return this._eksClusters; }
            set { this._eksClusters = value; }
        }

        // Check to see if EksClusters property is set
        internal bool IsSetEksClusters()
        {
            return this._eksClusters != null && (this._eksClusters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KubernetesResourceType. 
        /// <para>
        /// The Kubernetes resource type for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KubernetesResourceType KubernetesResourceType
        {
            get { return this._kubernetesResourceType; }
            set { this._kubernetesResourceType = value; }
        }

        // Check to see if KubernetesResourceType property is set
        internal bool IsSetKubernetesResourceType()
        {
            return this._kubernetesResourceType != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingResources. 
        /// <para>
        /// The scaling resources for the configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Dictionary<string, Dictionary<string, KubernetesScalingResource>>> ScalingResources
        {
            get { return this._scalingResources; }
            set { this._scalingResources = value; }
        }

        // Check to see if ScalingResources property is set
        internal bool IsSetScalingResources()
        {
            return this._scalingResources != null && (this._scalingResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetPercent. 
        /// <para>
        /// The target percentage for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? TargetPercent
        {
            get { return this._targetPercent; }
            set { this._targetPercent = value; }
        }

        // Check to see if TargetPercent property is set
        internal bool IsSetTargetPercent()
        {
            return this._targetPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutMinutes. 
        /// <para>
        /// The timeout value specified for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? TimeoutMinutes
        {
            get { return this._timeoutMinutes; }
            set { this._timeoutMinutes = value; }
        }

        // Check to see if TimeoutMinutes property is set
        internal bool IsSetTimeoutMinutes()
        {
            return this._timeoutMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ungraceful. 
        /// <para>
        /// The settings for ungraceful execution.
        /// </para>
        /// </summary>
        public EksResourceScalingUngraceful Ungraceful
        {
            get { return this._ungraceful; }
            set { this._ungraceful = value; }
        }

        // Check to see if Ungraceful property is set
        internal bool IsSetUngraceful()
        {
            return this._ungraceful != null;
        }

    }
}