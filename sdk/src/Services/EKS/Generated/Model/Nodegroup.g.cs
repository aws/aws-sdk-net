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
    /// An object representing an Amazon EKS managed node group.
    /// </summary>
    public partial class Nodegroup
    {
        /// <summary>
        /// Gets and sets the property AmiType. 
        /// <para>
        /// If the node group was deployed using a launch template with a custom AMI, then this
        /// is <c>CUSTOM</c>. For node groups that weren't deployed using a launch template, this
        /// is the AMI type that was specified in the node group configuration.
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
        /// The capacity type of your managed node group.
        /// </para>
        /// </summary>
        public CapacityTypes CapacityType { get; set; }

        /// <summary>
        /// Checks to see if the CapacityType property is set.
        /// </summary>
        internal bool IsSetCapacityType() => this.CapacityType != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix epoch timestamp at object creation.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DiskSize. 
        /// <para>
        /// If the node group wasn't deployed with a launch template, then this is the disk size
        /// in the node group configuration. If the node group was deployed with a launch template,
        /// then this is <c>null</c>.
        /// </para>
        /// </summary>
        public int? DiskSize { get; set; }

        /// <summary>
        /// Checks to see if the DiskSize property is set.
        /// </summary>
        internal bool IsSetDiskSize() => this.DiskSize.HasValue;

        /// <summary>
        /// Gets and sets the property Health. 
        /// <para>
        /// The health status of the node group. If there are issues with your node group's health,
        /// they are listed here.
        /// </para>
        /// </summary>
        public NodegroupHealth Health { get; set; }

        /// <summary>
        /// Checks to see if the Health property is set.
        /// </summary>
        internal bool IsSetHealth() => this.Health != null;

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// If the node group wasn't deployed with a launch template, then this is the instance
        /// type that is associated with the node group. If the node group was deployed with a
        /// launch template, then this is <c>null</c>.
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
        /// The Kubernetes <c>labels</c> applied to the nodes in the node group.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only <c>labels</c> that are applied with the Amazon EKS API are shown here. There
        /// may be other Kubernetes <c>labels</c> applied to the nodes in this group.
        /// </para>
        ///  </note>
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
        /// If a launch template was used to create the node group, then this is the launch template
        /// that was used.
        /// </para>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplate { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplate property is set.
        /// </summary>
        internal bool IsSetLaunchTemplate() => this.LaunchTemplate != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The Unix epoch timestamp for the last modification to the object.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

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
        /// The IAM role associated with your node group. The Amazon EKS node <c>kubelet</c> daemon
        /// makes calls to Amazon Web Services APIs on your behalf. Nodes receive permissions
        /// for these API calls through an IAM instance profile and associated policies.
        /// </para>
        /// </summary>
        public string NodeRole { get; set; }

        /// <summary>
        /// Checks to see if the NodeRole property is set.
        /// </summary>
        internal bool IsSetNodeRole() => this.NodeRole != null;

        /// <summary>
        /// Gets and sets the property NodegroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with the managed node group.
        /// </para>
        /// </summary>
        public string NodegroupArn { get; set; }

        /// <summary>
        /// Checks to see if the NodegroupArn property is set.
        /// </summary>
        internal bool IsSetNodegroupArn() => this.NodegroupArn != null;

        /// <summary>
        /// Gets and sets the property NodegroupName. 
        /// <para>
        /// The name associated with an Amazon EKS managed node group.
        /// </para>
        /// </summary>
        public string NodegroupName { get; set; }

        /// <summary>
        /// Checks to see if the NodegroupName property is set.
        /// </summary>
        internal bool IsSetNodegroupName() => this.NodegroupName != null;

        /// <summary>
        /// Gets and sets the property ReleaseVersion. 
        /// <para>
        /// If the node group was deployed using a launch template with a custom AMI, then this
        /// is the AMI ID that was specified in the launch template. For node groups that weren't
        /// deployed using a launch template, this is the version of the Amazon EKS optimized
        /// AMI that the node group was deployed with.
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
        /// If the node group wasn't deployed with a launch template, then this is the remote
        /// access configuration that is associated with the node group. If the node group was
        /// deployed with a launch template, then this is <c>null</c>.
        /// </para>
        /// </summary>
        public RemoteAccessConfig RemoteAccess { get; set; }

        /// <summary>
        /// Checks to see if the RemoteAccess property is set.
        /// </summary>
        internal bool IsSetRemoteAccess() => this.RemoteAccess != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The resources associated with the node group, such as Auto Scaling groups and security
        /// groups for remote access.
        /// </para>
        /// </summary>
        public NodegroupResources Resources { get; set; }

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null;

        /// <summary>
        /// Gets and sets the property ScalingConfig. 
        /// <para>
        /// The scaling configuration details for the Auto Scaling group that is associated with
        /// your node group.
        /// </para>
        /// </summary>
        public NodegroupScalingConfig ScalingConfig { get; set; }

        /// <summary>
        /// Checks to see if the ScalingConfig property is set.
        /// </summary>
        internal bool IsSetScalingConfig() => this.ScalingConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the managed node group.
        /// </para>
        /// </summary>
        public NodegroupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The subnets that were specified for the Auto Scaling group that is associated with
        /// your node group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// The Kubernetes taints to be applied to the nodes in the node group when they are created.
        /// Effect is one of <c>No_Schedule</c>, <c>Prefer_No_Schedule</c>, or <c>No_Execute</c>.
        /// Kubernetes taints can be used together with tolerations to control how workloads are
        /// scheduled to your nodes. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/node-taints-managed-node-groups.html">Node
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
        /// The Kubernetes version of the managed node group.
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
        /// The warm pool configuration attached to the node group. Amazon EKS manages warm pools
        /// throughout the node group lifecycle using the <c>AWSServiceRoleForAmazonEKSNodegroup</c>
        /// service-linked role to create, update, and delete warm pool resources.
        /// </para>
        /// </summary>
        public WarmPoolConfig WarmPoolConfig { get; set; }

        /// <summary>
        /// Checks to see if the WarmPoolConfig property is set.
        /// </summary>
        internal bool IsSetWarmPoolConfig() => this.WarmPoolConfig != null;
    }
}
