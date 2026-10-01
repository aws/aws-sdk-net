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
    /// Container for the parameters to the CreateNodegroup operation. Creates a managed node
    /// group for an Amazon EKS cluster. <para> You can only create a node group for your
    /// cluster that is equal to the current Kubernetes version for the cluster. All node
    /// groups are created with the latest AMI release version for the respective minor Kubernetes
    /// version of the cluster, unless you deploy a custom AMI using a launch template. </para>
    /// <para> For later updates, you will only be able to update a node group using a launch
    /// template only if it was originally deployed with a launch template. Additionally,
    /// the launch template ID or name must match what was used when the node group was created.
    /// You can update the launch template version with necessary changes. For more information
    /// about using launch templates, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Customizing
    /// managed nodes with launch templates</a>. </para> <para> An Amazon EKS managed node
    /// group is an Amazon EC2 Auto Scaling group and associated Amazon EC2 instances that
    /// are managed by Amazon Web Services for an Amazon EKS cluster. For more information,
    /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/managed-node-groups.html">Managed
    /// node groups</a> in the <i>Amazon EKS User Guide</i>. </para> <note> <para> Windows
    /// AMI types are only supported for commercial Amazon Web Services Regions that support
    /// Windows on Amazon EKS. </para> </note>
    /// </summary>
    public partial class CreateNodegroupRequest : AmazonEKSRequest
    {
        /// <summary>
        /// Gets and sets the property AmiType. 
        /// <para>
        /// The AMI type for your node group. If you specify <c>launchTemplate</c>, and your launch
        /// template uses a custom AMI, then don't specify <c>amiType</c>, or the node group deployment
        /// will fail. If your launch template uses a Windows custom AMI, then add <c>eks:kube-proxy-windows</c>
        /// to your Windows nodes <c>rolearn</c> in the <c>aws-auth</c> <c>ConfigMap</c>. For
        /// more information about using launch templates with Amazon EKS, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Customizing
        /// managed nodes with launch templates</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public AMITypes AmiType { get; set; }

        /// <summary>
        /// Checks to see if the AmiType property is set.
        /// </summary>
        internal bool IsSetAmiType() => this.AmiType != null;

        /// <summary>
        /// Gets and sets the property CapacityType. 
        /// <para>
        /// The capacity type for your node group.
        /// </para>
        /// </summary>
        public CapacityTypes CapacityType { get; set; }

        /// <summary>
        /// Checks to see if the CapacityType property is set.
        /// </summary>
        internal bool IsSetCapacityType() => this.CapacityType != null;

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
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property DiskSize. 
        /// <para>
        /// The root device disk size (in GiB) for your node group instances. The default disk
        /// size is 20 GiB for Linux and Bottlerocket. The default disk size is 50 GiB for Windows.
        /// If you specify <c>launchTemplate</c>, then don't specify <c>diskSize</c>, or the node
        /// group deployment will fail. For more information about using launch templates with
        /// Amazon EKS, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Customizing
        /// managed nodes with launch templates</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public int? DiskSize { get; set; }

        /// <summary>
        /// Checks to see if the DiskSize property is set.
        /// </summary>
        internal bool IsSetDiskSize() => this.DiskSize.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// Specify the instance types for a node group. If you specify a GPU instance type, make
        /// sure to also specify an applicable GPU AMI type with the <c>amiType</c> parameter.
        /// If you specify <c>launchTemplate</c>, then you can specify zero or one instance type
        /// in your launch template <i>or</i> you can specify 0-20 instance types for <c>instanceTypes</c>.
        /// If however, you specify an instance type in your launch template <i>and</i> specify
        /// any <c>instanceTypes</c>, the node group deployment will fail. If you don't specify
        /// an instance type in a launch template or for <c>instanceTypes</c>, then <c>t3.medium</c>
        /// is used, by default. If you specify <c>Spot</c> for <c>capacityType</c>, then we recommend
        /// specifying multiple values for <c>instanceTypes</c>. For more information, see <a
        /// href="https://docs.aws.amazon.com/eks/latest/userguide/managed-node-groups.html#managed-node-group-capacity-types">Managed
        /// node group capacity types</a> and <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Customizing
        /// managed nodes with launch templates</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceTypes property is set.
        /// </summary>
        internal bool IsSetInstanceTypes() => this.InstanceTypes != null && (this.InstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// The Kubernetes <c>labels</c> to apply to the nodes in the node group when they are
        /// created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Labels { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Labels property is set.
        /// </summary>
        internal bool IsSetLabels() => this.Labels != null && (this.Labels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// An object representing a node group's launch template specification. When using this
        /// object, don't directly specify <c>instanceTypes</c>, <c>diskSize</c>, or <c>remoteAccess</c>.
        /// You cannot later specify a different launch template ID or name than what was used
        /// to create the node group.
        /// </para>
        ///  
        /// <para>
        /// Make sure that the launch template meets the requirements in <c>launchTemplateSpecification</c>.
        /// Also refer to <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Customizing
        /// managed nodes with launch templates</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplate { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplate property is set.
        /// </summary>
        internal bool IsSetLaunchTemplate() => this.LaunchTemplate != null;

        /// <summary>
        /// Gets and sets the property NodeRepairConfig. 
        /// <para>
        /// The node auto repair configuration for the node group.
        /// </para>
        /// </summary>
        public NodeRepairConfig NodeRepairConfig { get; set; }

        /// <summary>
        /// Checks to see if the NodeRepairConfig property is set.
        /// </summary>
        internal bool IsSetNodeRepairConfig() => this.NodeRepairConfig != null;

        /// <summary>
        /// Gets and sets the property NodeRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to associate with your node group.
        /// The Amazon EKS worker node <c>kubelet</c> daemon makes calls to Amazon Web Services
        /// APIs on your behalf. Nodes receive permissions for these API calls through an IAM
        /// instance profile and associated policies. Before you can launch nodes and register
        /// them into a cluster, you must create an IAM role for those nodes to use when they
        /// are launched. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/create-node-role.html">Amazon
        /// EKS node IAM role</a> in the <i> <i>Amazon EKS User Guide</i> </i>. If you specify
        /// <c>launchTemplate</c>, then don't specify <c> <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_IamInstanceProfile.html">IamInstanceProfile</a>
        /// </c> in your launch template, or the node group deployment will fail. For more information
        /// about using launch templates with Amazon EKS, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Customizing
        /// managed nodes with launch templates</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NodeRole { get; set; }

        /// <summary>
        /// Checks to see if the NodeRole property is set.
        /// </summary>
        internal bool IsSetNodeRole() => this.NodeRole != null;

        /// <summary>
        /// Gets and sets the property NodegroupName. 
        /// <para>
        /// The unique name to give your node group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NodegroupName { get; set; }

        /// <summary>
        /// Checks to see if the NodegroupName property is set.
        /// </summary>
        internal bool IsSetNodegroupName() => this.NodegroupName != null;

        /// <summary>
        /// Gets and sets the property ReleaseVersion. 
        /// <para>
        /// The AMI version of the Amazon EKS optimized AMI to use with your node group. By default,
        /// the latest available AMI version for the node group's current Kubernetes version is
        /// used. For information about Linux versions, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-linux-ami-versions.html">Amazon
        /// EKS optimized Amazon Linux AMI versions</a> in the <i>Amazon EKS User Guide</i>. Amazon
        /// EKS managed node groups support the November 2022 and later releases of the Windows
        /// AMIs. For information about Windows versions, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-ami-versions-windows.html">Amazon
        /// EKS optimized Windows AMI versions</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>launchTemplate</c>, and your launch template uses a custom AMI,
        /// then don't specify <c>releaseVersion</c>, or the node group deployment will fail.
        /// For more information about using launch templates with Amazon EKS, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Customizing
        /// managed nodes with launch templates</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseVersion property is set.
        /// </summary>
        internal bool IsSetReleaseVersion() => this.ReleaseVersion != null;

        /// <summary>
        /// Gets and sets the property RemoteAccess. 
        /// <para>
        /// The remote access configuration to use with your node group. For Linux, the protocol
        /// is SSH. For Windows, the protocol is RDP. If you specify <c>launchTemplate</c>, then
        /// don't specify <c>remoteAccess</c>, or the node group deployment will fail. For more
        /// information about using launch templates with Amazon EKS, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Customizing
        /// managed nodes with launch templates</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public RemoteAccessConfig RemoteAccess { get; set; }

        /// <summary>
        /// Checks to see if the RemoteAccess property is set.
        /// </summary>
        internal bool IsSetRemoteAccess() => this.RemoteAccess != null;

        /// <summary>
        /// Gets and sets the property ScalingConfig. 
        /// <para>
        /// The scaling configuration details for the Auto Scaling group that is created for your
        /// node group.
        /// </para>
        /// </summary>
        public NodegroupScalingConfig ScalingConfig { get; set; }

        /// <summary>
        /// Checks to see if the ScalingConfig property is set.
        /// </summary>
        internal bool IsSetScalingConfig() => this.ScalingConfig != null;

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The subnets to use for the Auto Scaling group that is created for your node group.
        /// If you specify <c>launchTemplate</c>, then don't specify <c> <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateNetworkInterface.html">SubnetId</a>
        /// </c> in your launch template, or the node group deployment will fail. For more information
        /// about using launch templates with Amazon EKS, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Customizing
        /// managed nodes with launch templates</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Subnets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Subnets property is set.
        /// </summary>
        internal bool IsSetSubnets() => this.Subnets != null && (this.Subnets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that assists with categorization and organization. Each tag consists of a
        /// key and an optional value. You define both. Tags don't propagate to any other cluster
        /// or Amazon Web Services resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Taints. 
        /// <para>
        /// The Kubernetes taints to be applied to the nodes in the node group. For more information,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/node-taints-managed-node-groups.html">Node
        /// taints on managed node groups</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Taint> Taints { get; set; } = AWSConfigs.InitializeCollections ? new List<Taint>() : null;

        /// <summary>
        /// Checks to see if the Taints property is set.
        /// </summary>
        internal bool IsSetTaints() => this.Taints != null && (this.Taints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdateConfig. 
        /// <para>
        /// The node group update configuration.
        /// </para>
        /// </summary>
        public NodegroupUpdateConfig UpdateConfig { get; set; }

        /// <summary>
        /// Checks to see if the UpdateConfig property is set.
        /// </summary>
        internal bool IsSetUpdateConfig() => this.UpdateConfig != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The Kubernetes version to use for your managed nodes. By default, the Kubernetes version
        /// of the cluster is used, and this is the only accepted specified value. If you specify
        /// <c>launchTemplate</c>, and your launch template uses a custom AMI, then don't specify
        /// <c>version</c>, or the node group deployment will fail. For more information about
        /// using launch templates with Amazon EKS, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Customizing
        /// managed nodes with launch templates</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;

        /// <summary>
        /// Gets and sets the property WarmPoolConfig. 
        /// <para>
        /// The warm pool configuration for the node group. Warm pools maintain pre-initialized
        /// EC2 instances that can quickly join your cluster during scale-out events, improving
        /// application scaling performance and reducing costs.
        /// </para>
        /// </summary>
        public WarmPoolConfig WarmPoolConfig { get; set; }

        /// <summary>
        /// Checks to see if the WarmPoolConfig property is set.
        /// </summary>
        internal bool IsSetWarmPoolConfig() => this.WarmPoolConfig != null;
    }
}
