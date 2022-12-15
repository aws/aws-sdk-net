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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateNodegroup operation.
    /// Creates a managed node group for an Amazon EKS cluster. You can only create a node
    /// group for your cluster that is equal to the current Kubernetes version for the cluster.
    /// All node groups are created with the latest AMI release version for the respective
    /// minor Kubernetes version of the cluster, unless you deploy a custom AMI using a launch
    /// template. For more information about using launch templates, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Launch
    /// template support</a>.
    /// 
    ///  
    /// <para>
    /// An Amazon EKS managed node group is an Amazon EC2 Auto Scaling group and associated
    /// Amazon EC2 instances that are managed by Amazon Web Services for an Amazon EKS cluster.
    /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/managed-node-groups.html">Managed
    /// node groups</a> in the <i>Amazon EKS User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Windows AMI types are only supported for commercial Regions that support Windows Amazon
    /// EKS.
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
        private List<string> _instanceTypes = new List<string>();
        private Dictionary<string, string> _labels = new Dictionary<string, string>();
        private LaunchTemplateSpecification _launchTemplate;
        private string _nodegroupName;
        private string _nodeRole;
        private string _releaseVersion;
        private RemoteAccessConfig _remoteAccess;
        private NodegroupScalingConfig _scalingConfig;
        private List<string> _subnets = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private List<Taint> _taints = new List<Taint>();
        private NodegroupUpdateConfig _updateConfig;
        private string _version;

        /// <summary>
        /// Gets and sets the property AmiType. 
        /// <para>
        /// The AMI type for your node group. If you specify <code>launchTemplate</code>, and
        /// your launch template uses a custom AMI, then don't specify <code>amiType</code>, or
        /// the node group deployment will fail. If your launch template uses a Windows custom
        /// AMI, then add <code>eks:kube-proxy-windows</code> to your Windows nodes <code>rolearn</code>
        /// in the <code>aws-auth</code> <code>ConfigMap</code>. For more information about using
        /// launch templates with Amazon EKS, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Launch
        /// template support</a> in the <i>Amazon EKS User Guide</i>.
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
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
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
        /// The name of the cluster to create the node group in.
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
        /// If you specify <code>launchTemplate</code>, then don't specify <code>diskSize</code>,
        /// or the node group deployment will fail. For more information about using launch templates
        /// with Amazon EKS, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Launch
        /// template support</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public int DiskSize
        {
            get { return this._diskSize.GetValueOrDefault(); }
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
        /// sure to also specify an applicable GPU AMI type with the <code>amiType</code> parameter.
        /// If you specify <code>launchTemplate</code>, then you can specify zero or one instance
        /// type in your launch template <i>or</i> you can specify 0-20 instance types for <code>instanceTypes</code>.
        /// If however, you specify an instance type in your launch template <i>and</i> specify
        /// any <code>instanceTypes</code>, the node group deployment will fail. If you don't
        /// specify an instance type in a launch template or for <code>instanceTypes</code>, then
        /// <code>t3.medium</code> is used, by default. If you specify <code>Spot</code> for <code>capacityType</code>,
        /// then we recommend specifying multiple values for <code>instanceTypes</code>. For more
        /// information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/managed-node-groups.html#managed-node-group-capacity-types">Managed
        /// node group capacity types</a> and <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Launch
        /// template support</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public List<string> InstanceTypes
        {
            get { return this._instanceTypes; }
            set { this._instanceTypes = value; }
        }

        // Check to see if InstanceTypes property is set
        internal bool IsSetInstanceTypes()
        {
            return this._instanceTypes != null && this._instanceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// The Kubernetes labels to be applied to the nodes in the node group when they are created.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && this._labels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// An object representing a node group's launch template specification. If specified,
        /// then do not specify <code>instanceTypes</code>, <code>diskSize</code>, or <code>remoteAccess</code>
        /// and make sure that the launch template meets the requirements in <code>launchTemplateSpecification</code>.
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
        /// Gets and sets the property NodeRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to associate with your node group.
        /// The Amazon EKS worker node <code>kubelet</code> daemon makes calls to Amazon Web Services
        /// APIs on your behalf. Nodes receive permissions for these API calls through an IAM
        /// instance profile and associated policies. Before you can launch nodes and register
        /// them into a cluster, you must create an IAM role for those nodes to use when they
        /// are launched. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/create-node-role.html">Amazon
        /// EKS node IAM role</a> in the <i> <i>Amazon EKS User Guide</i> </i>. If you specify
        /// <code>launchTemplate</code>, then don't specify <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_IamInstanceProfile.html">
        /// <code>IamInstanceProfile</code> </a> in your launch template, or the node group deployment
        /// will fail. For more information about using launch templates with Amazon EKS, see
        /// <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Launch
        /// template support</a> in the <i>Amazon EKS User Guide</i>.
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
        /// If you specify <code>launchTemplate</code>, and your launch template uses a custom
        /// AMI, then don't specify <code>releaseVersion</code>, or the node group deployment
        /// will fail. For more information about using launch templates with Amazon EKS, see
        /// <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Launch
        /// template support</a> in the <i>Amazon EKS User Guide</i>.
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
        /// is SSH. For Windows, the protocol is RDP. If you specify <code>launchTemplate</code>,
        /// then don't specify <code>remoteAccess</code>, or the node group deployment will fail.
        /// For more information about using launch templates with Amazon EKS, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Launch
        /// template support</a> in the <i>Amazon EKS User Guide</i>.
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
        /// If you specify <code>launchTemplate</code>, then don't specify <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateNetworkInterface.html">
        /// <code>SubnetId</code> </a> in your launch template, or the node group deployment will
        /// fail. For more information about using launch templates with Amazon EKS, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Launch
        /// template support</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
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
            return this._subnets != null && this._subnets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata to apply to the node group to assist with categorization and organization.
        /// Each tag consists of a key and an optional value. You define both. Node group tags
        /// do not propagate to any other resources associated with the node group, such as the
        /// Amazon EC2 instances or subnets.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Taints. 
        /// <para>
        /// The Kubernetes taints to be applied to the nodes in the node group. For more information,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/node-taints-managed-node-groups.html">Node
        /// taints on managed node groups</a>.
        /// </para>
        /// </summary>
        public List<Taint> Taints
        {
            get { return this._taints; }
            set { this._taints = value; }
        }

        // Check to see if Taints property is set
        internal bool IsSetTaints()
        {
            return this._taints != null && this._taints.Count > 0; 
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
        /// <code>launchTemplate</code>, and your launch template uses a custom AMI, then don't
        /// specify <code>version</code>, or the node group deployment will fail. For more information
        /// about using launch templates with Amazon EKS, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Launch
        /// template support</a> in the <i>Amazon EKS User Guide</i>.
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