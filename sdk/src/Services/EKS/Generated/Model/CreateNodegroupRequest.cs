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
    /// Container for the parameters to the CreateNodegroup operation.
    /// Creates a managed node group for an Amazon EKS cluster.
    /// 
    ///  
    /// <para>
    /// You can only create a node group for your cluster that is equal to the current Kubernetes
    /// version for the cluster. All node groups are created with the latest AMI release version
    /// for the respective minor Kubernetes version of the cluster, unless you deploy a custom
    /// AMI using a launch template.
    /// </para>
    ///  
    /// <para>
    /// For later updates, you will only be able to update a node group using a launch template
    /// only if it was originally deployed with a launch template. Additionally, the launch
    /// template ID or name must match what was used when the node group was created. You
    /// can update the launch template version with necessary changes. For more information
    /// about using launch templates, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Customizing
    /// managed nodes with launch templates</a>.
    /// </para>
    ///  
    /// <para>
    /// An Amazon EKS managed node group is an Amazon EC2 Auto Scaling group and associated
    /// Amazon EC2 instances that are managed by Amazon Web Services for an Amazon EKS cluster.
    /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/managed-node-groups.html">Managed
    /// node groups</a> in the <i>Amazon EKS User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Windows AMI types are only supported for commercial Amazon Web Services Regions that
    /// support Windows on Amazon EKS.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateNodegroupRequest : AmazonEKSRequest
    {
        private AMITypes _amiType;
        private CapacityTypes _capacityType;
        private string _clientRequestToken;
        private string _clusterName;
        private int? _diskSize;
        private List<string> _instanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _labels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private LaunchTemplateSpecification _launchTemplate;
        private string _nodegroupName;
        private NodeRepairConfig _nodeRepairConfig;
        private string _nodeRole;
        private string _releaseVersion;
        private RemoteAccessConfig _remoteAccess;
        private NodegroupScalingConfig _scalingConfig;
        private List<string> _subnets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<Taint> _taints = AWSConfigs.InitializeCollections ? new List<Taint>() : null;
        private NodegroupUpdateConfig _updateConfig;
        private string _version;

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
        public AMITypes AmiType
        {
            get { return this._amiType; }
            set { this._amiType = value; }
        }

        // Check to see if AmiType property is set
        internal bool IsSetAmiType()
        {
            return this._amiType != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityType. 
        /// <para>
        /// The capacity type for your node group.
        /// </para>
        /// </summary>
        public CapacityTypes CapacityType
        {
            get { return this._capacityType; }
            set { this._capacityType = value; }
        }

        // Check to see if CapacityType property is set
        internal bool IsSetCapacityType()
        {
            return this._capacityType != null;
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
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        public int? DiskSize
        {
            get { return this._diskSize; }
            set { this._diskSize = value; }
        }

        // Check to see if DiskSize property is set
        internal bool IsSetDiskSize()
        {
            return this._diskSize.HasValue; 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceTypes
        {
            get { return this._instanceTypes; }
            set { this._instanceTypes = value; }
        }

        // Check to see if InstanceTypes property is set
        internal bool IsSetInstanceTypes()
        {
            return this._instanceTypes != null && (this._instanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// The Kubernetes <c>labels</c> to apply to the nodes in the node group when they are
        /// created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && (this._labels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public LaunchTemplateSpecification LaunchTemplate
        {
            get { return this._launchTemplate; }
            set { this._launchTemplate = value; }
        }

        // Check to see if LaunchTemplate property is set
        internal bool IsSetLaunchTemplate()
        {
            return this._launchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property NodegroupName. 
        /// <para>
        /// The unique name to give your node group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NodegroupName
        {
            get { return this._nodegroupName; }
            set { this._nodegroupName = value; }
        }

        // Check to see if NodegroupName property is set
        internal bool IsSetNodegroupName()
        {
            return this._nodegroupName != null;
        }

        /// <summary>
        /// Gets and sets the property NodeRepairConfig. 
        /// <para>
        /// The node auto repair configuration for the node group.
        /// </para>
        /// </summary>
        public NodeRepairConfig NodeRepairConfig
        {
            get { return this._nodeRepairConfig; }
            set { this._nodeRepairConfig = value; }
        }

        // Check to see if NodeRepairConfig property is set
        internal bool IsSetNodeRepairConfig()
        {
            return this._nodeRepairConfig != null;
        }

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
        [AWSProperty(Required=true)]
        public string NodeRole
        {
            get { return this._nodeRole; }
            set { this._nodeRole = value; }
        }

        // Check to see if NodeRole property is set
        internal bool IsSetNodeRole()
        {
            return this._nodeRole != null;
        }

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
        public string ReleaseVersion
        {
            get { return this._releaseVersion; }
            set { this._releaseVersion = value; }
        }

        // Check to see if ReleaseVersion property is set
        internal bool IsSetReleaseVersion()
        {
            return this._releaseVersion != null;
        }

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
        public RemoteAccessConfig RemoteAccess
        {
            get { return this._remoteAccess; }
            set { this._remoteAccess = value; }
        }

        // Check to see if RemoteAccess property is set
        internal bool IsSetRemoteAccess()
        {
            return this._remoteAccess != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingConfig. 
        /// <para>
        /// The scaling configuration details for the Auto Scaling group that is created for your
        /// node group.
        /// </para>
        /// </summary>
        public NodegroupScalingConfig ScalingConfig
        {
            get { return this._scalingConfig; }
            set { this._scalingConfig = value; }
        }

        // Check to see if ScalingConfig property is set
        internal bool IsSetScalingConfig()
        {
            return this._scalingConfig != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && (this._subnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that assists with categorization and organization. Each tag consists of a
        /// key and an optional value. You define both. Tags don't propagate to any other cluster
        /// or Amazon Web Services resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property Taints. 
        /// <para>
        /// The Kubernetes taints to be applied to the nodes in the node group. For more information,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/node-taints-managed-node-groups.html">Node
        /// taints on managed node groups</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Taint> Taints
        {
            get { return this._taints; }
            set { this._taints = value; }
        }

        // Check to see if Taints property is set
        internal bool IsSetTaints()
        {
            return this._taints != null && (this._taints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdateConfig. 
        /// <para>
        /// The node group update configuration.
        /// </para>
        /// </summary>
        public NodegroupUpdateConfig UpdateConfig
        {
            get { return this._updateConfig; }
            set { this._updateConfig = value; }
        }

        // Check to see if UpdateConfig property is set
        internal bool IsSetUpdateConfig()
        {
            return this._updateConfig != null;
        }

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
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}