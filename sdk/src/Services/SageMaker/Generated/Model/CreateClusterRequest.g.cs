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
    /// Container for the parameters to the CreateCluster operation. Creates an Amazon SageMaker
    /// HyperPod cluster. SageMaker HyperPod is a capability of SageMaker for creating and
    /// managing persistent clusters for developing large machine learning models, such as
    /// large language models (LLMs) and diffusion models. To learn more, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html">Amazon
    /// SageMaker HyperPod</a> in the <i>Amazon SageMaker Developer Guide</i>.
    /// </summary>
    public partial class CreateClusterRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AutoScaling. 
        /// <para>
        /// The autoscaling configuration for the cluster. Enables automatic scaling of cluster
        /// nodes based on workload demand using a Karpenter-based system.
        /// </para>
        /// </summary>
        public ClusterAutoScalingConfig AutoScaling { get; set; }

        /// <summary>
        /// Checks to see if the AutoScaling property is set.
        /// </summary>
        internal bool IsSetAutoScaling() => this.AutoScaling != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name for the new SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property ClusterRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that HyperPod assumes to perform cluster
        /// autoscaling operations. This role must have permissions for <c>sagemaker:BatchAddClusterNodes</c>
        /// and <c>sagemaker:BatchDeleteClusterNodes</c>. This is only required when autoscaling
        /// is enabled and when HyperPod is performing autoscaling operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ClusterRole { get; set; }

        /// <summary>
        /// Checks to see if the ClusterRole property is set.
        /// </summary>
        internal bool IsSetClusterRole() => this.ClusterRole != null;

        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// The instance groups to be created in the SageMaker HyperPod cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<ClusterInstanceGroupSpecification> InstanceGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterInstanceGroupSpecification>() : null;

        /// <summary>
        /// Checks to see if the InstanceGroups property is set.
        /// </summary>
        internal bool IsSetInstanceGroups() => this.InstanceGroups != null && (this.InstanceGroups.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public ClusterNodeProvisioningMode NodeProvisioningMode { get; set; }

        /// <summary>
        /// Checks to see if the NodeProvisioningMode property is set.
        /// </summary>
        internal bool IsSetNodeProvisioningMode() => this.NodeProvisioningMode != null;

        /// <summary>
        /// Gets and sets the property NodeRecovery. 
        /// <para>
        /// The node recovery mode for the SageMaker HyperPod cluster. When set to <c>Automatic</c>,
        /// SageMaker HyperPod will automatically reboot or replace faulty nodes when issues are
        /// detected. When set to <c>None</c>, cluster administrators will need to manually manage
        /// any faulty cluster instances.
        /// </para>
        /// </summary>
        public ClusterNodeRecovery NodeRecovery { get; set; }

        /// <summary>
        /// Checks to see if the NodeRecovery property is set.
        /// </summary>
        internal bool IsSetNodeRecovery() => this.NodeRecovery != null;

        /// <summary>
        /// Gets and sets the property Orchestrator. 
        /// <para>
        /// The type of orchestrator to use for the SageMaker HyperPod cluster. Currently, supported
        /// values are <c>"Eks"</c> and <c>"Slurm"</c>, which is to use an Amazon Elastic Kubernetes
        /// Service or Slurm cluster as the orchestrator.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify the <c>Orchestrator</c> field, you must provide exactly one orchestrator
        /// configuration: either <c>Eks</c> or <c>Slurm</c>. Specifying both or providing an
        /// empty configuration returns a validation error.
        /// </para>
        ///  </note>
        /// </summary>
        public ClusterOrchestrator Orchestrator { get; set; }

        /// <summary>
        /// Checks to see if the Orchestrator property is set.
        /// </summary>
        internal bool IsSetOrchestrator() => this.Orchestrator != null;

        /// <summary>
        /// Gets and sets the property RestrictedInstanceGroups. 
        /// <para>
        /// The specialized instance groups for training models like Amazon Nova to be created
        /// in the SageMaker HyperPod cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<ClusterRestrictedInstanceGroupSpecification> RestrictedInstanceGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterRestrictedInstanceGroupSpecification>() : null;

        /// <summary>
        /// Checks to see if the RestrictedInstanceGroups property is set.
        /// </summary>
        internal bool IsSetRestrictedInstanceGroups() => this.RestrictedInstanceGroups != null && (this.RestrictedInstanceGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RestrictedInstanceGroupsConfig. 
        /// <para>
        /// The configuration for the restricted instance groups (RIG) in the SageMaker HyperPod
        /// cluster.
        /// </para>
        /// </summary>
        public ClusterRestrictedInstanceGroupsConfig RestrictedInstanceGroupsConfig { get; set; }

        /// <summary>
        /// Checks to see if the RestrictedInstanceGroupsConfig property is set.
        /// </summary>
        internal bool IsSetRestrictedInstanceGroupsConfig() => this.RestrictedInstanceGroupsConfig != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TieredStorageConfig. 
        /// <para>
        /// The configuration for managed tier checkpointing on the HyperPod cluster. When enabled,
        /// this feature uses a multi-tier storage approach for storing model checkpoints, providing
        /// faster checkpoint operations and improved fault tolerance across cluster nodes.
        /// </para>
        /// </summary>
        public ClusterTieredStorageConfig TieredStorageConfig { get; set; }

        /// <summary>
        /// Checks to see if the TieredStorageConfig property is set.
        /// </summary>
        internal bool IsSetTieredStorageConfig() => this.TieredStorageConfig != null;

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
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
