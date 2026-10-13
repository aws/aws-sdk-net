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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Details of an instance (also called a <i>node</i> interchangeably) in a SageMaker
    /// HyperPod cluster.
    /// </summary>
    public partial class ClusterNodeDetails
    {
        /// <summary>
        /// Gets and sets the property CapacityType. 
        /// <para>
        /// The capacity type of the node. Valid values are <c>OnDemand</c> and <c>Spot</c>. When
        /// set to <c>OnDemand</c>, the node is launched as an On-Demand instance. When set to
        /// <c>Spot</c>, the node is launched as a Spot instance. 
        /// </para>
        /// </summary>
        public ClusterCapacityType CapacityType { get; set; }

        /// <summary>
        /// Checks to see if the CapacityType property is set.
        /// </summary>
        internal bool IsSetCapacityType() => this.CapacityType != null;

        /// <summary>
        /// Gets and sets the property CurrentImageId. 
        /// <para>
        /// The ID of the Amazon Machine Image (AMI) currently in use by the node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 21)]
        public string CurrentImageId { get; set; }

        /// <summary>
        /// Checks to see if the CurrentImageId property is set.
        /// </summary>
        internal bool IsSetCurrentImageId() => this.CurrentImageId != null;

        /// <summary>
        /// Gets and sets the property CurrentImageReleaseVersion. 
        /// <para>
        /// The version of the HyperPod-managed AMI currently running on the node.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string CurrentImageReleaseVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentImageReleaseVersion property is set.
        /// </summary>
        internal bool IsSetCurrentImageReleaseVersion() => this.CurrentImageReleaseVersion != null;

        /// <summary>
        /// Gets and sets the property DesiredImageId. 
        /// <para>
        /// The ID of the Amazon Machine Image (AMI) desired for the node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 21)]
        public string DesiredImageId { get; set; }

        /// <summary>
        /// Checks to see if the DesiredImageId property is set.
        /// </summary>
        internal bool IsSetDesiredImageId() => this.DesiredImageId != null;

        /// <summary>
        /// Gets and sets the property DesiredImageReleaseVersion. 
        /// <para>
        /// The desired version of the HyperPod-managed AMI for the node. This may differ from
        /// the current version when an update is pending.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string DesiredImageReleaseVersion { get; set; }

        /// <summary>
        /// Checks to see if the DesiredImageReleaseVersion property is set.
        /// </summary>
        internal bool IsSetDesiredImageReleaseVersion() => this.DesiredImageReleaseVersion != null;

        /// <summary>
        /// Gets and sets the property ImageVersionStatus. 
        /// <para>
        /// The status of the image version for the cluster node.
        /// </para>
        /// </summary>
        public ClusterImageVersionStatus ImageVersionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImageVersionStatus property is set.
        /// </summary>
        internal bool IsSetImageVersionStatus() => this.ImageVersionStatus != null;

        /// <summary>
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// The instance group name in which the instance is.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string InstanceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroupName property is set.
        /// </summary>
        internal bool IsSetInstanceGroupName() => this.InstanceGroupName != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceStatus. 
        /// <para>
        /// The status of the instance.
        /// </para>
        /// </summary>
        public ClusterInstanceStatusDetails InstanceStatus { get; set; }

        /// <summary>
        /// Checks to see if the InstanceStatus property is set.
        /// </summary>
        internal bool IsSetInstanceStatus() => this.InstanceStatus != null;

        /// <summary>
        /// Gets and sets the property InstanceStorageConfigs. 
        /// <para>
        /// The configurations of additional storage specified to the instance group where the
        /// instance (node) is launched.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 4)]
        public List<ClusterInstanceStorageConfig> InstanceStorageConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterInstanceStorageConfig>() : null;

        /// <summary>
        /// Checks to see if the InstanceStorageConfigs property is set.
        /// </summary>
        internal bool IsSetInstanceStorageConfigs() => this.InstanceStorageConfigs != null && (this.InstanceStorageConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of the instance.
        /// </para>
        /// </summary>
        public ClusterInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property KubernetesConfig. 
        /// <para>
        /// The Kubernetes configuration applied to this node, showing both the current and desired
        /// state of labels and taints. The cluster works to reconcile the actual state with the
        /// declared state. 
        /// </para>
        /// </summary>
        public ClusterKubernetesConfigNodeDetails KubernetesConfig { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesConfig property is set.
        /// </summary>
        internal bool IsSetKubernetesConfig() => this.KubernetesConfig != null;

        /// <summary>
        /// Gets and sets the property LastSoftwareUpdateTime. 
        /// <para>
        /// The time when the cluster was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastSoftwareUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSoftwareUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastSoftwareUpdateTime() => this.LastSoftwareUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// The time when the instance is launched.
        /// </para>
        /// </summary>
        public DateTime? LaunchTime { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTime property is set.
        /// </summary>
        internal bool IsSetLaunchTime() => this.LaunchTime.HasValue;

        /// <summary>
        /// Gets and sets the property LifeCycleConfig. 
        /// <para>
        /// The LifeCycle configuration applied to the instance.
        /// </para>
        /// </summary>
        public ClusterLifeCycleConfig LifeCycleConfig { get; set; }

        /// <summary>
        /// Checks to see if the LifeCycleConfig property is set.
        /// </summary>
        internal bool IsSetLifeCycleConfig() => this.LifeCycleConfig != null;

        /// <summary>
        /// Gets and sets the property NetworkInterface. 
        /// <para>
        /// The network interface configuration for the cluster node.
        /// </para>
        /// </summary>
        public ClusterNetworkInterfaceDetails NetworkInterface { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterface property is set.
        /// </summary>
        internal bool IsSetNetworkInterface() => this.NetworkInterface != null;

        /// <summary>
        /// Gets and sets the property NodeLogicalId. 
        /// <para>
        /// A unique identifier for the node that persists throughout its lifecycle, from provisioning
        /// request to termination. This identifier can be used to track the node even before
        /// it has an assigned <c>InstanceId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string NodeLogicalId { get; set; }

        /// <summary>
        /// Checks to see if the NodeLogicalId property is set.
        /// </summary>
        internal bool IsSetNodeLogicalId() => this.NodeLogicalId != null;

        /// <summary>
        /// Gets and sets the property OverrideVpcConfig. 
        /// <para>
        /// The customized Amazon VPC configuration at the instance group level that overrides
        /// the default Amazon VPC configuration of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        public VpcConfig OverrideVpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the OverrideVpcConfig property is set.
        /// </summary>
        internal bool IsSetOverrideVpcConfig() => this.OverrideVpcConfig != null;

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// The placement details of the SageMaker HyperPod cluster node.
        /// </para>
        /// </summary>
        public ClusterInstancePlacement Placement { get; set; }

        /// <summary>
        /// Checks to see if the Placement property is set.
        /// </summary>
        internal bool IsSetPlacement() => this.Placement != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsHostname. 
        /// <para>
        /// The private DNS hostname of the SageMaker HyperPod cluster node.
        /// </para>
        /// </summary>
        public string PrivateDnsHostname { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsHostname property is set.
        /// </summary>
        internal bool IsSetPrivateDnsHostname() => this.PrivateDnsHostname != null;

        /// <summary>
        /// Gets and sets the property PrivatePrimaryIp. 
        /// <para>
        /// The private primary IP address of the SageMaker HyperPod cluster node.
        /// </para>
        /// </summary>
        public string PrivatePrimaryIp { get; set; }

        /// <summary>
        /// Checks to see if the PrivatePrimaryIp property is set.
        /// </summary>
        internal bool IsSetPrivatePrimaryIp() => this.PrivatePrimaryIp != null;

        /// <summary>
        /// Gets and sets the property PrivatePrimaryIpv6. 
        /// <para>
        /// The private primary IPv6 address of the SageMaker HyperPod cluster node when configured
        /// with an Amazon VPC that supports IPv6 and includes subnets with IPv6 addressing enabled
        /// in either the cluster Amazon VPC configuration or the instance group Amazon VPC configuration.
        /// </para>
        /// </summary>
        public string PrivatePrimaryIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the PrivatePrimaryIpv6 property is set.
        /// </summary>
        internal bool IsSetPrivatePrimaryIpv6() => this.PrivatePrimaryIpv6 != null;

        /// <summary>
        /// Gets and sets the property ThreadsPerCore. 
        /// <para>
        /// The number of threads per CPU core you specified under <c>CreateCluster</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public int? ThreadsPerCore { get; set; }

        /// <summary>
        /// Checks to see if the ThreadsPerCore property is set.
        /// </summary>
        internal bool IsSetThreadsPerCore() => this.ThreadsPerCore.HasValue;

        /// <summary>
        /// Gets and sets the property UltraServerInfo. 
        /// <para>
        /// Contains information about the UltraServer.
        /// </para>
        /// </summary>
        public UltraServerInfo UltraServerInfo { get; set; }

        /// <summary>
        /// Checks to see if the UltraServerInfo property is set.
        /// </summary>
        internal bool IsSetUltraServerInfo() => this.UltraServerInfo != null;
    }
}
