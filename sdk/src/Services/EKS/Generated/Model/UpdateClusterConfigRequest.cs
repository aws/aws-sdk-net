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
    /// Container for the parameters to the UpdateClusterConfig operation.
    /// Updates an Amazon EKS cluster configuration. Your cluster continues to function during
    /// the update. The response output includes an update ID that you can use to track the
    /// status of your cluster update with <c>DescribeUpdate</c>.
    /// 
    ///  
    /// <para>
    /// You can use this operation to do the following actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can use this API operation to enable or disable exporting the Kubernetes control
    /// plane logs for your cluster to CloudWatch Logs. By default, cluster control plane
    /// logs aren't exported to CloudWatch Logs. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html">Amazon
    /// EKS Cluster control plane logs</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// CloudWatch Logs ingestion, archive storage, and data scanning rates apply to exported
    /// control plane logs. For more information, see <a href="http://aws.amazon.com/cloudwatch/pricing/">CloudWatch
    /// Pricing</a>.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// You can also use this API operation to enable or disable public and private access
    /// to your cluster's Kubernetes API server endpoint. By default, public access is enabled,
    /// and private access is disabled. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">
    /// Cluster API server endpoint</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can also use this API operation to choose different subnets and security groups
    /// for the cluster. You must specify at least two subnets that are in different Availability
    /// Zones. You can't change which VPC the subnets are from, the subnets must be in the
    /// same VPC as the subnets that the cluster was created with. For more information about
    /// the VPC requirements, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html">https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html</a>
    /// in the <i> <i>Amazon EKS User Guide</i> </i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can also use this API operation to enable or disable ARC zonal shift. If zonal
    /// shift is enabled, Amazon Web Services configures zonal autoshift for the cluster.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can also use this API operation to add, change, or remove the configuration in
    /// the cluster for EKS Hybrid Nodes. To remove the configuration, use the <c>remoteNetworkConfig</c>
    /// key with an object containing both subkeys with empty arrays for each. Here is an
    /// inline example: <c>"remoteNetworkConfig": { "remoteNodeNetworks": [], "remotePodNetworks":
    /// [] }</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Cluster updates are asynchronous, and they should finish within a few minutes. During
    /// an update, the cluster status moves to <c>UPDATING</c> (this status transition is
    /// eventually consistent). When the update is complete (either <c>Failed</c> or <c>Successful</c>),
    /// the cluster status moves to <c>Active</c>.
    /// </para>
    /// </summary>
    public partial class UpdateClusterConfigRequest : AmazonEKSRequest
    {
        private UpdateAccessConfigRequest _accessConfig;
        private string _clientRequestToken;
        private ComputeConfigRequest _computeConfig;
        private bool? _deletionProtection;
        private KubernetesNetworkConfigRequest _kubernetesNetworkConfig;
        private Logging _logging;
        private string _name;
        private RemoteNetworkConfigRequest _remoteNetworkConfig;
        private VpcConfigRequest _resourcesVpcConfig;
        private StorageConfigRequest _storageConfig;
        private UpgradePolicyRequest _upgradePolicy;
        private ZonalShiftConfigRequest _zonalShiftConfig;

        /// <summary>
        /// Gets and sets the property AccessConfig. 
        /// <para>
        /// The access configuration for the cluster.
        /// </para>
        /// </summary>
        public UpdateAccessConfigRequest AccessConfig
        {
            get { return this._accessConfig; }
            set { this._accessConfig = value; }
        }

        // Check to see if AccessConfig property is set
        internal bool IsSetAccessConfig()
        {
            return this._accessConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeConfig. 
        /// <para>
        /// Update the configuration of the compute capability of your EKS Auto Mode cluster.
        /// For example, enable the capability.
        /// </para>
        /// </summary>
        public ComputeConfigRequest ComputeConfig
        {
            get { return this._computeConfig; }
            set { this._computeConfig = value; }
        }

        // Check to see if ComputeConfig property is set
        internal bool IsSetComputeConfig()
        {
            return this._computeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether to enable or disable deletion protection for the cluster. When enabled
        /// (<c>true</c>), the cluster cannot be deleted until deletion protection is explicitly
        /// disabled. When disabled (<c>false</c>), the cluster can be deleted normally.
        /// </para>
        /// </summary>
        public bool? DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KubernetesNetworkConfig.
        /// </summary>
        public KubernetesNetworkConfigRequest KubernetesNetworkConfig
        {
            get { return this._kubernetesNetworkConfig; }
            set { this._kubernetesNetworkConfig = value; }
        }

        // Check to see if KubernetesNetworkConfig property is set
        internal bool IsSetKubernetesNetworkConfig()
        {
            return this._kubernetesNetworkConfig != null;
        }

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
        public Logging Logging
        {
            get { return this._logging; }
            set { this._logging = value; }
        }

        // Check to see if Logging property is set
        internal bool IsSetLogging()
        {
            return this._logging != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon EKS cluster to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteNetworkConfig.
        /// </summary>
        public RemoteNetworkConfigRequest RemoteNetworkConfig
        {
            get { return this._remoteNetworkConfig; }
            set { this._remoteNetworkConfig = value; }
        }

        // Check to see if RemoteNetworkConfig property is set
        internal bool IsSetRemoteNetworkConfig()
        {
            return this._remoteNetworkConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcesVpcConfig.
        /// </summary>
        public VpcConfigRequest ResourcesVpcConfig
        {
            get { return this._resourcesVpcConfig; }
            set { this._resourcesVpcConfig = value; }
        }

        // Check to see if ResourcesVpcConfig property is set
        internal bool IsSetResourcesVpcConfig()
        {
            return this._resourcesVpcConfig != null;
        }

        /// <summary>
        /// Gets and sets the property StorageConfig. 
        /// <para>
        /// Update the configuration of the block storage capability of your EKS Auto Mode cluster.
        /// For example, enable the capability.
        /// </para>
        /// </summary>
        public StorageConfigRequest StorageConfig
        {
            get { return this._storageConfig; }
            set { this._storageConfig = value; }
        }

        // Check to see if StorageConfig property is set
        internal bool IsSetStorageConfig()
        {
            return this._storageConfig != null;
        }

        /// <summary>
        /// Gets and sets the property UpgradePolicy. 
        /// <para>
        /// You can enable or disable extended support for clusters currently on standard support.
        /// You cannot disable extended support once it starts. You must enable extended support
        /// before your cluster exits standard support.
        /// </para>
        /// </summary>
        public UpgradePolicyRequest UpgradePolicy
        {
            get { return this._upgradePolicy; }
            set { this._upgradePolicy = value; }
        }

        // Check to see if UpgradePolicy property is set
        internal bool IsSetUpgradePolicy()
        {
            return this._upgradePolicy != null;
        }

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
        public ZonalShiftConfigRequest ZonalShiftConfig
        {
            get { return this._zonalShiftConfig; }
            set { this._zonalShiftConfig = value; }
        }

        // Check to see if ZonalShiftConfig property is set
        internal bool IsSetZonalShiftConfig()
        {
            return this._zonalShiftConfig != null;
        }

    }
}