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
    /// Container for the parameters to the UpdateClusterConfig operation. Updates an Amazon
    /// EKS cluster configuration. Your cluster continues to function during the update. The
    /// response output includes an update ID that you can use to track the status of your
    /// cluster update with <c>DescribeUpdate</c>. <para> You can use this operation to do
    /// the following actions: </para> <ul> <li> <para> You can use this API operation to
    /// enable or disable exporting the Kubernetes control plane logs for your cluster to
    /// CloudWatch Logs. By default, cluster control plane logs aren't exported to CloudWatch
    /// Logs. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html">Amazon
    /// EKS Cluster control plane logs</a> in the <i> <i>Amazon EKS User Guide</i> </i>. </para>
    /// <note> <para> CloudWatch Logs ingestion, archive storage, and data scanning rates
    /// apply to exported control plane logs. For more information, see <a href="http://aws.amazon.com/cloudwatch/pricing/">CloudWatch
    /// Pricing</a>. </para> </note> </li> <li> <para> You can also use this API operation
    /// to enable or disable public and private access to your cluster's Kubernetes API server
    /// endpoint. By default, public access is enabled, and private access is disabled. For
    /// more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">
    /// Cluster API server endpoint</a> in the <i> <i>Amazon EKS User Guide</i> </i>. </para>
    /// </li> <li> <para> You can also use this API operation to choose different subnets
    /// and security groups for the cluster. You must specify at least two subnets that are
    /// in different Availability Zones. You can't change which VPC the subnets are from,
    /// the subnets must be in the same VPC as the subnets that the cluster was created with.
    /// For more information about the VPC requirements, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html">https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html</a>
    /// in the <i> <i>Amazon EKS User Guide</i> </i>. </para> </li> <li> <para> You can also
    /// use this API operation to enable or disable ARC zonal shift. If zonal shift is enabled,
    /// Amazon Web Services configures zonal autoshift for the cluster. </para> </li> <li>
    /// <para> You can also use this API operation to add, change, or remove the configuration
    /// in the cluster for EKS Hybrid Nodes. To remove the configuration, use the <c>remoteNetworkConfig</c>
    /// key with an object containing both subkeys with empty arrays for each. Here is an
    /// inline example: <c>"remoteNetworkConfig": { "remoteNodeNetworks": [], "remotePodNetworks":
    /// [] }</c>. </para> </li> </ul> <para> Cluster updates are asynchronous, and they should
    /// finish within a few minutes. During an update, the cluster status moves to <c>UPDATING</c>
    /// (this status transition is eventually consistent). When the update is complete (either
    /// <c>Failed</c> or <c>Successful</c>), the cluster status moves to <c>Active</c>. </para>
    /// </summary>
    public partial class UpdateClusterConfigRequest : AmazonEKSRequest
    {
        /// <summary>
        /// Gets and sets the property AccessConfig. 
        /// <para>
        /// The access configuration for the cluster.
        /// </para>
        /// </summary>
        public UpdateAccessConfigRequest AccessConfig { get; set; }

        /// <summary>
        /// Checks to see if the AccessConfig property is set.
        /// </summary>
        internal bool IsSetAccessConfig() => this.AccessConfig != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property ComputeConfig. 
        /// <para>
        /// Update the configuration of the compute capability of your EKS Auto Mode cluster.
        /// For example, enable the capability.
        /// </para>
        /// </summary>
        public ComputeConfigRequest ComputeConfig { get; set; }

        /// <summary>
        /// Checks to see if the ComputeConfig property is set.
        /// </summary>
        internal bool IsSetComputeConfig() => this.ComputeConfig != null;

        /// <summary>
        /// Gets and sets the property ControlPlaneScalingConfig. 
        /// <para>
        /// The control plane scaling tier configuration. For more information, see EKS Provisioned
        /// Control Plane in the Amazon EKS User Guide.
        /// </para>
        /// </summary>
        public ControlPlaneScalingConfig ControlPlaneScalingConfig { get; set; }

        /// <summary>
        /// Checks to see if the ControlPlaneScalingConfig property is set.
        /// </summary>
        internal bool IsSetControlPlaneScalingConfig() => this.ControlPlaneScalingConfig != null;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether to enable or disable deletion protection for the cluster. When enabled
        /// (<c>true</c>), the cluster cannot be deleted until deletion protection is explicitly
        /// disabled. When disabled (<c>false</c>), the cluster can be deleted normally.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property KubeApiServerConfig. 
        /// <para>
        /// The Kubernetes API server configuration for the updated cluster.
        /// </para>
        /// </summary>
        public KubeApiServerConfigRequest KubeApiServerConfig { get; set; }

        /// <summary>
        /// Checks to see if the KubeApiServerConfig property is set.
        /// </summary>
        internal bool IsSetKubeApiServerConfig() => this.KubeApiServerConfig != null;

        /// <summary>
        /// Gets and sets the property KubeControllerManagerConfig. 
        /// <para>
        /// The Kubernetes controller manager configuration for the updated cluster.
        /// </para>
        /// </summary>
        public KubeControllerManagerConfigRequest KubeControllerManagerConfig { get; set; }

        /// <summary>
        /// Checks to see if the KubeControllerManagerConfig property is set.
        /// </summary>
        internal bool IsSetKubeControllerManagerConfig() => this.KubeControllerManagerConfig != null;

        /// <summary>
        /// Gets and sets the property KubeSchedulerConfig. 
        /// <para>
        /// The Kubernetes scheduler configuration for the updated cluster.
        /// </para>
        /// </summary>
        public KubeSchedulerConfigRequest KubeSchedulerConfig { get; set; }

        /// <summary>
        /// Checks to see if the KubeSchedulerConfig property is set.
        /// </summary>
        internal bool IsSetKubeSchedulerConfig() => this.KubeSchedulerConfig != null;

        /// <summary>
        /// Gets and sets the property KubernetesNetworkConfig.
        /// </summary>
        public KubernetesNetworkConfigRequest KubernetesNetworkConfig { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesNetworkConfig property is set.
        /// </summary>
        internal bool IsSetKubernetesNetworkConfig() => this.KubernetesNetworkConfig != null;

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// Enable or disable exporting the Kubernetes control plane logs for your cluster to
        /// CloudWatch Logs . By default, cluster control plane logs aren't exported to CloudWatch
        /// Logs . For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html">Amazon
        /// EKS cluster control plane logs</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// CloudWatch Logs ingestion, archive storage, and data scanning rates apply to exported
        /// control plane logs. For more information, see <a href="http://aws.amazon.com/cloudwatch/pricing/">CloudWatch
        /// Pricing</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public Logging Logging { get; set; }

        /// <summary>
        /// Checks to see if the Logging property is set.
        /// </summary>
        internal bool IsSetLogging() => this.Logging != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon EKS cluster to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RemoteNetworkConfig.
        /// </summary>
        public RemoteNetworkConfigRequest RemoteNetworkConfig { get; set; }

        /// <summary>
        /// Checks to see if the RemoteNetworkConfig property is set.
        /// </summary>
        internal bool IsSetRemoteNetworkConfig() => this.RemoteNetworkConfig != null;

        /// <summary>
        /// Gets and sets the property ResourcesVpcConfig. 
        /// <para>
        /// An object representing the VPC configuration to use for the cluster update. You can
        /// use this parameter to update the control plane egress mode, the subnets used by the
        /// cluster, the security groups, and the endpoint access settings.
        /// </para>
        /// </summary>
        public VpcConfigRequest ResourcesVpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesVpcConfig property is set.
        /// </summary>
        internal bool IsSetResourcesVpcConfig() => this.ResourcesVpcConfig != null;

        /// <summary>
        /// Gets and sets the property StorageConfig. 
        /// <para>
        /// Update the configuration of the block storage capability of your EKS Auto Mode cluster.
        /// For example, enable the capability.
        /// </para>
        /// </summary>
        public StorageConfigRequest StorageConfig { get; set; }

        /// <summary>
        /// Checks to see if the StorageConfig property is set.
        /// </summary>
        internal bool IsSetStorageConfig() => this.StorageConfig != null;

        /// <summary>
        /// Gets and sets the property UpgradePolicy. 
        /// <para>
        /// You can enable or disable extended support for clusters currently on standard support.
        /// You cannot disable extended support once it starts. You must enable extended support
        /// before your cluster exits standard support.
        /// </para>
        /// </summary>
        public UpgradePolicyRequest UpgradePolicy { get; set; }

        /// <summary>
        /// Checks to see if the UpgradePolicy property is set.
        /// </summary>
        internal bool IsSetUpgradePolicy() => this.UpgradePolicy != null;

        /// <summary>
        /// Gets and sets the property ZonalShiftConfig. 
        /// <para>
        /// Enable or disable ARC zonal shift for the cluster. If zonal shift is enabled, Amazon
        /// Web Services configures zonal autoshift for the cluster.
        /// </para>
        ///  
        /// <para>
        /// Zonal shift is a feature of Amazon Application Recovery Controller (ARC). ARC zonal
        /// shift is designed to be a temporary measure that allows you to move traffic for a
        /// resource away from an impaired AZ until the zonal shift expires or you cancel it.
        /// You can extend the zonal shift if necessary.
        /// </para>
        ///  
        /// <para>
        /// You can start a zonal shift for an EKS cluster, or you can allow Amazon Web Services
        /// to do it for you by enabling <i>zonal autoshift</i>. This shift updates the flow of
        /// east-to-west network traffic in your cluster to only consider network endpoints for
        /// Pods running on worker nodes in healthy AZs. Additionally, any ALB or NLB handling
        /// ingress traffic for applications in your EKS cluster will automatically route traffic
        /// to targets in the healthy AZs. For more information about zonal shift in EKS, see
        /// <a href="https://docs.aws.amazon.com/eks/latest/userguide/zone-shift.html">Learn about
        /// Amazon Application Recovery Controller (ARC) Zonal Shift in Amazon EKS</a> in the
        /// <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        /// </summary>
        public ZonalShiftConfigRequest ZonalShiftConfig { get; set; }

        /// <summary>
        /// Checks to see if the ZonalShiftConfig property is set.
        /// </summary>
        internal bool IsSetZonalShiftConfig() => this.ZonalShiftConfig != null;
    }
}
