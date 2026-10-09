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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// The Amazon Web Services EKS resource scaling configuration.
    /// </summary>
    public partial class EksResourceScalingConfiguration
    {
        /// <summary>
        /// Gets and sets the property CapacityMonitoringApproach. 
        /// <para>
        /// The monitoring approach for the configuration, that is, whether it was sampled in
        /// the last 24 hours or autoscaled in the last 24 hours.
        /// </para>
        /// </summary>
        public EksCapacityMonitoringApproach CapacityMonitoringApproach { get; set; }

        /// <summary>
        /// Checks to see if the CapacityMonitoringApproach property is set.
        /// </summary>
        internal bool IsSetCapacityMonitoringApproach() => this.CapacityMonitoringApproach != null;

        /// <summary>
        /// Gets and sets the property EksClusters. 
        /// <para>
        /// The clusters for the configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 2)]
        public List<EksCluster> EksClusters { get; set; } = AWSConfigs.InitializeCollections ? new List<EksCluster>() : null;

        /// <summary>
        /// Checks to see if the EksClusters property is set.
        /// </summary>
        internal bool IsSetEksClusters() => this.EksClusters != null && (this.EksClusters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KubernetesResourceType. 
        /// <para>
        /// The Kubernetes resource type for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KubernetesResourceType KubernetesResourceType { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesResourceType property is set.
        /// </summary>
        internal bool IsSetKubernetesResourceType() => this.KubernetesResourceType != null;

        /// <summary>
        /// Gets and sets the property ScalingResources. 
        /// <para>
        /// The scaling resources for the configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<Dictionary<string, Dictionary<string, KubernetesScalingResource>>> ScalingResources { get; set; } = AWSConfigs.InitializeCollections ? new List<Dictionary<string, Dictionary<string, KubernetesScalingResource>>>() : null;

        /// <summary>
        /// Checks to see if the ScalingResources property is set.
        /// </summary>
        internal bool IsSetScalingResources() => this.ScalingResources != null && (this.ScalingResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetPercent. 
        /// <para>
        /// The target percentage for the configuration. The default is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? TargetPercent { get; set; }

        /// <summary>
        /// Checks to see if the TargetPercent property is set.
        /// </summary>
        internal bool IsSetTargetPercent() => this.TargetPercent.HasValue;

        /// <summary>
        /// Gets and sets the property TimeoutMinutes. 
        /// <para>
        /// The timeout value specified for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? TimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetTimeoutMinutes() => this.TimeoutMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property Ungraceful. 
        /// <para>
        /// The settings for ungraceful execution.
        /// </para>
        /// </summary>
        public EksResourceScalingUngraceful Ungraceful { get; set; }

        /// <summary>
        /// Checks to see if the Ungraceful property is set.
        /// </summary>
        internal bool IsSetUngraceful() => this.Ungraceful != null;
    }
}
