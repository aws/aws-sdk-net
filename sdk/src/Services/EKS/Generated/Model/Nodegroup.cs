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
        private List<string> _instanceTypes = new List<string>();
        private Dictionary<string, string> _labels = new Dictionary<string, string>();
        private LaunchTemplateSpecification _launchTemplate;
        private DateTime? _modifiedAt;
        private string _nodegroupArn;
        private string _nodegroupName;
        private string _nodeRole;
        private string _releaseVersion;
        private RemoteAccessConfig _remoteAccess;
        private NodegroupResources _resources;
        private NodegroupScalingConfig _scalingConfig;
        private NodegroupStatus _status;
        private List<string> _subnets = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _version;

        /// <summary>
        /// Gets and sets the property AmiType. 
        /// <para>
        /// If the node group was deployed using a launch template with a custom AMI, then this
        /// is <code>CUSTOM</code>. For node groups that weren't deployed using a launch template,
        /// this is the AMI type that was specified in the node group configuration.
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
        /// The name of the cluster that the managed node group resides in.
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
        /// The Unix epoch timestamp in seconds for when the managed node group was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
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
        /// then this is <code>null</code>.
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
        /// launch template, then this is <code>null</code>.
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
        /// The Kubernetes labels applied to the nodes in the node group.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only labels that are applied with the Amazon EKS API are shown here. There may be
        /// other Kubernetes labels applied to the nodes in this group.
        /// </para>
        ///  </note>
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
        /// The Unix epoch timestamp in seconds for when the managed node group was last modified.
        /// </para>
        /// </summary>
        public DateTime ModifiedAt
        {
            get { return this._modifiedAt.GetValueOrDefault(); }
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
        /// Gets and sets the property NodeRole. 
        /// <para>
        /// The IAM role associated with your node group. The Amazon EKS worker node <code>kubelet</code>
        /// daemon makes calls to AWS APIs on your behalf. Worker nodes receive permissions for
        /// these API calls through an IAM instance profile and associated policies.
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
        /// deployed with a launch template, then this is <code>null</code>.
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
        /// </summary>
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
        /// The metadata applied to the node group to assist with categorization and organization.
        /// Each tag consists of a key and an optional value, both of which you define. Node group
        /// tags do not propagate to any other resources associated with the node group, such
        /// as the Amazon EC2 instances or subnets. 
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