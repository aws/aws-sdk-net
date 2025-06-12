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
    /// An object representing an Amazon EKS managed node group.
    /// </summary>
    public partial class Nodegroup
    {
        private AMITypes _amiType;
        private CapacityTypes _capacityType;
        private string _clusterName;
        private DateTime? _createdAt;
        private int? _diskSize;
        private NodegroupHealth _health;
        private List<string> _instanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _labels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private LaunchTemplateSpecification _launchTemplate;
        private DateTime? _modifiedAt;
        private string _nodegroupArn;
        private string _nodegroupName;
        private NodeRepairConfig _nodeRepairConfig;
        private string _nodeRole;
        private string _releaseVersion;
        private RemoteAccessConfig _remoteAccess;
        private NodegroupResources _resources;
        private NodegroupScalingConfig _scalingConfig;
        private NodegroupStatus _status;
        private List<string> _subnets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<Taint> _taints = AWSConfigs.InitializeCollections ? new List<Taint>() : null;
        private NodegroupUpdateConfig _updateConfig;
        private string _version;

        /// <summary>
        /// Gets and sets the property AmiType. 
        /// <para>
        /// If the node group was deployed using a launch template with a custom AMI, then this
        /// is <c>CUSTOM</c>. For node groups that weren't deployed using a launch template, this
        /// is the AMI type that was specified in the node group configuration.
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
        /// The capacity type of your managed node group.
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
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix epoch timestamp at object creation.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DiskSize. 
        /// <para>
        /// If the node group wasn't deployed with a launch template, then this is the disk size
        /// in the node group configuration. If the node group was deployed with a launch template,
        /// then this is <c>null</c>.
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
        /// Gets and sets the property Health. 
        /// <para>
        /// The health status of the node group. If there are issues with your node group's health,
        /// they are listed here.
        /// </para>
        /// </summary>
        public NodegroupHealth Health
        {
            get { return this._health; }
            set { this._health = value; }
        }

        // Check to see if Health property is set
        internal bool IsSetHealth()
        {
            return this._health != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// If the node group wasn't deployed with a launch template, then this is the instance
        /// type that is associated with the node group. If the node group was deployed with a
        /// launch template, then this is <c>null</c>.
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
        /// The Kubernetes <c>labels</c> applied to the nodes in the node group.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only <c>labels</c> that are applied with the Amazon EKS API are shown here. There
        /// may be other Kubernetes <c>labels</c> applied to the nodes in this group.
        /// </para>
        ///  </note>
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
        /// If a launch template was used to create the node group, then this is the launch template
        /// that was used.
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
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The Unix epoch timestamp for the last modification to the object.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodegroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with the managed node group.
        /// </para>
        /// </summary>
        public string NodegroupArn
        {
            get { return this._nodegroupArn; }
            set { this._nodegroupArn = value; }
        }

        // Check to see if NodegroupArn property is set
        internal bool IsSetNodegroupArn()
        {
            return this._nodegroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property NodegroupName. 
        /// <para>
        /// The name associated with an Amazon EKS managed node group.
        /// </para>
        /// </summary>
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
        /// The IAM role associated with your node group. The Amazon EKS node <c>kubelet</c> daemon
        /// makes calls to Amazon Web Services APIs on your behalf. Nodes receive permissions
        /// for these API calls through an IAM instance profile and associated policies.
        /// </para>
        /// </summary>
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
        /// If the node group was deployed using a launch template with a custom AMI, then this
        /// is the AMI ID that was specified in the launch template. For node groups that weren't
        /// deployed using a launch template, this is the version of the Amazon EKS optimized
        /// AMI that the node group was deployed with.
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
        /// If the node group wasn't deployed with a launch template, then this is the remote
        /// access configuration that is associated with the node group. If the node group was
        /// deployed with a launch template, then this is <c>null</c>.
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
        /// Gets and sets the property Resources. 
        /// <para>
        /// The resources associated with the node group, such as Auto Scaling groups and security
        /// groups for remote access.
        /// </para>
        /// </summary>
        public NodegroupResources Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingConfig. 
        /// <para>
        /// The scaling configuration details for the Auto Scaling group that is associated with
        /// your node group.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the managed node group.
        /// </para>
        /// </summary>
        public NodegroupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The subnets that were specified for the Auto Scaling group that is associated with
        /// your node group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// The Kubernetes taints to be applied to the nodes in the node group when they are created.
        /// Effect is one of <c>No_Schedule</c>, <c>Prefer_No_Schedule</c>, or <c>No_Execute</c>.
        /// Kubernetes taints can be used together with tolerations to control how workloads are
        /// scheduled to your nodes. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/node-taints-managed-node-groups.html">Node
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
        /// The Kubernetes version of the managed node group.
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