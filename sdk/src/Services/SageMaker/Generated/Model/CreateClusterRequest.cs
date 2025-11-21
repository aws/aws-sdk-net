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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// Container for the parameters to the CreateCluster operation.
    /// Creates a SageMaker HyperPod cluster. SageMaker HyperPod is a capability of SageMaker
    /// for creating and managing persistent clusters for developing large machine learning
    /// models, such as large language models (LLMs) and diffusion models. To learn more,
    /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html">Amazon
    /// SageMaker HyperPod</a> in the <i>Amazon SageMaker Developer Guide</i>.
    /// </summary>
    public partial class CreateClusterRequest : AmazonSageMakerRequest
    {
        private ClusterAutoScalingConfig _autoScaling;
        private string _clusterName;
        private string _clusterRole;
        private List<ClusterInstanceGroupSpecification> _instanceGroups = AWSConfigs.InitializeCollections ? new List<ClusterInstanceGroupSpecification>() : null;
        private ClusterNodeProvisioningMode _nodeProvisioningMode;
        private ClusterNodeRecovery _nodeRecovery;
        private ClusterOrchestrator _orchestrator;
        private List<ClusterRestrictedInstanceGroupSpecification> _restrictedInstanceGroups = AWSConfigs.InitializeCollections ? new List<ClusterRestrictedInstanceGroupSpecification>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private ClusterTieredStorageConfig _tieredStorageConfig;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property AutoScaling. 
        /// <para>
        /// The autoscaling configuration for the cluster. Enables automatic scaling of cluster
        /// nodes based on workload demand using a Karpenter-based system.
        /// </para>
        /// </summary>
        public ClusterAutoScalingConfig AutoScaling
        {
            get { return this._autoScaling; }
            set { this._autoScaling = value; }
        }

        // Check to see if AutoScaling property is set
        internal bool IsSetAutoScaling()
        {
            return this._autoScaling != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name for the new SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that HyperPod assumes to perform cluster
        /// autoscaling operations. This role must have permissions for <c>sagemaker:BatchAddClusterNodes</c>
        /// and <c>sagemaker:BatchDeleteClusterNodes</c>. This is only required when autoscaling
        /// is enabled and when HyperPod is performing autoscaling operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ClusterRole
        {
            get { return this._clusterRole; }
            set { this._clusterRole = value; }
        }

        // Check to see if ClusterRole property is set
        internal bool IsSetClusterRole()
        {
            return this._clusterRole != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// The instance groups to be created in the SageMaker HyperPod cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ClusterInstanceGroupSpecification> InstanceGroups
        {
            get { return this._instanceGroups; }
            set { this._instanceGroups = value; }
        }

        // Check to see if InstanceGroups property is set
        internal bool IsSetInstanceGroups()
        {
            return this._instanceGroups != null && (this._instanceGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeProvisioningMode. 
        /// <para>
        /// The mode for provisioning nodes in the cluster. You can specify the following modes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Continuous</b>: Scaling behavior that enables 1) concurrent operation execution
        /// within instance groups, 2) continuous retry mechanisms for failed operations, 3) enhanced
        /// customer visibility into cluster events through detailed event streams, 4) partial
        /// provisioning capabilities. Your clusters and instance groups remain <c>InService</c>
        /// while scaling. This mode is only supported for EKS orchestrated clusters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ClusterNodeProvisioningMode NodeProvisioningMode
        {
            get { return this._nodeProvisioningMode; }
            set { this._nodeProvisioningMode = value; }
        }

        // Check to see if NodeProvisioningMode property is set
        internal bool IsSetNodeProvisioningMode()
        {
            return this._nodeProvisioningMode != null;
        }

        /// <summary>
        /// Gets and sets the property NodeRecovery. 
        /// <para>
        /// The node recovery mode for the SageMaker HyperPod cluster. When set to <c>Automatic</c>,
        /// SageMaker HyperPod will automatically reboot or replace faulty nodes when issues are
        /// detected. When set to <c>None</c>, cluster administrators will need to manually manage
        /// any faulty cluster instances.
        /// </para>
        /// </summary>
        public ClusterNodeRecovery NodeRecovery
        {
            get { return this._nodeRecovery; }
            set { this._nodeRecovery = value; }
        }

        // Check to see if NodeRecovery property is set
        internal bool IsSetNodeRecovery()
        {
            return this._nodeRecovery != null;
        }

        /// <summary>
        /// Gets and sets the property Orchestrator. 
        /// <para>
        /// The type of orchestrator to use for the SageMaker HyperPod cluster. Currently, the
        /// only supported value is <c>"eks"</c>, which is to use an Amazon Elastic Kubernetes
        /// Service cluster as the orchestrator.
        /// </para>
        /// </summary>
        public ClusterOrchestrator Orchestrator
        {
            get { return this._orchestrator; }
            set { this._orchestrator = value; }
        }

        // Check to see if Orchestrator property is set
        internal bool IsSetOrchestrator()
        {
            return this._orchestrator != null;
        }

        /// <summary>
        /// Gets and sets the property RestrictedInstanceGroups. 
        /// <para>
        /// The specialized instance groups for training models like Amazon Nova to be created
        /// in the SageMaker HyperPod cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ClusterRestrictedInstanceGroupSpecification> RestrictedInstanceGroups
        {
            get { return this._restrictedInstanceGroups; }
            set { this._restrictedInstanceGroups = value; }
        }

        // Check to see if RestrictedInstanceGroups property is set
        internal bool IsSetRestrictedInstanceGroups()
        {
            return this._restrictedInstanceGroups != null && (this._restrictedInstanceGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Custom tags for managing the SageMaker HyperPod cluster as an Amazon Web Services
        /// resource. You can add tags to your cluster in the same way you add them in other Amazon
        /// Web Services services that support tagging. To learn more about tagging Amazon Web
        /// Services resources in general, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// Amazon Web Services Resources User Guide</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TieredStorageConfig. 
        /// <para>
        /// The configuration for managed tier checkpointing on the HyperPod cluster. When enabled,
        /// this feature uses a multi-tier storage approach for storing model checkpoints, providing
        /// faster checkpoint operations and improved fault tolerance across cluster nodes.
        /// </para>
        /// </summary>
        public ClusterTieredStorageConfig TieredStorageConfig
        {
            get { return this._tieredStorageConfig; }
            set { this._tieredStorageConfig = value; }
        }

        // Check to see if TieredStorageConfig property is set
        internal bool IsSetTieredStorageConfig()
        {
            return this._tieredStorageConfig != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// Specifies the Amazon Virtual Private Cloud (VPC) that is associated with the Amazon
        /// SageMaker HyperPod cluster. You can control access to and from your resources by configuring
        /// your VPC. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/infrastructure-give-access.html">Give
        /// SageMaker access to resources in your Amazon VPC</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When your Amazon VPC and subnets support IPv6, network communications differ based
        /// on the cluster orchestration platform:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Slurm-orchestrated clusters automatically configure nodes with dual IPv6 and IPv4
        /// addresses, allowing immediate IPv6 network communications.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In Amazon EKS-orchestrated clusters, nodes receive dual-stack addressing, but pods
        /// can only use IPv6 when the Amazon EKS cluster is explicitly IPv6-enabled. For information
        /// about deploying an IPv6 Amazon EKS cluster, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/deploy-ipv6-cluster.html#_deploy_an_ipv6_cluster_with_eksctl">Amazon
        /// EKS IPv6 Cluster Deployment</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Additional resources for IPv6 configuration:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For information about adding IPv6 support to your VPC, see to <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-migrate-ipv6.html">IPv6
        /// Support for VPC</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about creating a new IPv6-compatible VPC, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/create-vpc.html">Amazon
        /// VPC Creation Guide</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure SageMaker HyperPod with a custom Amazon VPC, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod-prerequisites.html#sagemaker-hyperpod-prerequisites-optional-vpc">Custom
        /// Amazon VPC Setup for SageMaker HyperPod</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}