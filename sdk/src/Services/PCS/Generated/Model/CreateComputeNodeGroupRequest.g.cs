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

namespace Amazon.PCS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateComputeNodeGroup operation. Creates a managed
    /// set of compute nodes. You associate a compute node group with a cluster through 1
    /// or more PCS queues or as part of the login fleet. A compute node group includes the
    /// definition of the compute properties and lifecycle management. PCS uses the information
    /// you provide to this API action to launch compute nodes in your account. You can only
    /// specify subnets in the same Amazon VPC as your cluster. You receive billing charges
    /// for the compute nodes that PCS launches in your account. You must already have a launch
    /// template before you call this API. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">Launch
    /// an instance from a launch template</a> in the <i>Amazon Elastic Compute Cloud User
    /// Guide for Linux Instances</i>.
    /// </summary>
    public partial class CreateComputeNodeGroupRequest : AmazonPCSRequest
    {
        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        ///  The ID of the Amazon Machine Image (AMI) that PCS uses to launch compute nodes (Amazon
        /// EC2 instances). If you don't provide this value, PCS uses the AMI ID specified in
        /// the custom launch template.
        /// </para>
        /// </summary>
        public string AmiId { get; set; }

        /// <summary>
        /// Checks to see if the AmiId property is set.
        /// </summary>
        internal bool IsSetAmiId() => this.AmiId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. Idempotency ensures that an API request completes only once. With an
        /// idempotent request, if the original request completes successfully, the subsequent
        /// retries with the same client token return the result from the original successful
        /// request and they have no additional effect. If you don't specify a client token, the
        /// CLI and SDK automatically generate 1 for you.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The name or ID of the cluster to create a compute node group in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property ComputeNodeGroupName. 
        /// <para>
        /// A name to identify the cluster. Example: <c>MyCluster</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 25)]
        public string ComputeNodeGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ComputeNodeGroupName property is set.
        /// </summary>
        internal bool IsSetComputeNodeGroupName() => this.ComputeNodeGroupName != null;

        /// <summary>
        /// Gets and sets the property CustomLaunchTemplate.
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomLaunchTemplate CustomLaunchTemplate { get; set; }

        /// <summary>
        /// Checks to see if the CustomLaunchTemplate property is set.
        /// </summary>
        internal bool IsSetCustomLaunchTemplate() => this.CustomLaunchTemplate != null;

        /// <summary>
        /// Gets and sets the property IamInstanceProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM instance profile used to pass an IAM role
        /// when launching EC2 instances. The role contained in your instance profile must have
        /// the <c>pcs:RegisterComputeNodeGroupInstance</c> permission and the role name must
        /// start with <c>AWSPCS</c> or must have the path <c>/aws-pcs/</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/pcs/latest/userguide/security-instance-profiles.html">IAM
        /// instance profiles for PCS</a> in the <i>PCS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IamInstanceProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the IamInstanceProfileArn property is set.
        /// </summary>
        internal bool IsSetIamInstanceProfileArn() => this.IamInstanceProfileArn != null;

        /// <summary>
        /// Gets and sets the property InstanceConfigs. 
        /// <para>
        /// A list of EC2 instance configurations that PCS can provision in the compute node group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<InstanceConfig> InstanceConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceConfig>() : null;

        /// <summary>
        /// Checks to see if the InstanceConfigs property is set.
        /// </summary>
        internal bool IsSetInstanceConfigs() => this.InstanceConfigs != null && (this.InstanceConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NodeLifecycleActions. 
        /// <para>
        /// The lifecycle actions to run on compute nodes in the compute node group. Use lifecycle
        /// actions to run custom scripts at defined stages of a compute node's lifecycle, such
        /// as when a compute node finishes bootstrapping or becomes ready to accept jobs.
        /// </para>
        /// </summary>
        public NodeLifecycleActionsRequest NodeLifecycleActions { get; set; }

        /// <summary>
        /// Checks to see if the NodeLifecycleActions property is set.
        /// </summary>
        internal bool IsSetNodeLifecycleActions() => this.NodeLifecycleActions != null;

        /// <summary>
        /// Gets and sets the property PurchaseOption. 
        /// <para>
        /// Specifies how EC2 instances are purchased on your behalf. PCS supports On-Demand Instances,
        /// Spot Instances, Interruptible Capacity Reservations, On-Demand Capacity Reservations,
        /// and Amazon EC2 Capacity Blocks for ML. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-purchasing-options.html">Amazon
        /// EC2 billing and purchasing options</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>. For more information about PCS support for Capacity Blocks, see <a href="https://docs.aws.amazon.com/pcs/latest/userguide/capacity-blocks.html">Using
        /// Amazon EC2 Capacity Blocks for ML with PCS</a> in the <i>PCS User Guide</i>. For more
        /// information about PCS support for interruptible capacity reservations, see <a href="https://docs.aws.amazon.com/pcs/latest/userguide/capacity-reservations-iodcr.html">Using
        /// I-ODCRs with PCS</a> in the <i>PCS User Guide</i>. Choose On-Demand if you plan to
        /// use an On-Demand Capacity Reservation (ODCR). For more information, see <a href="https://docs.aws.amazon.com/pcs/latest/userguide/capacity-reservations-odcr.html">Using
        /// ODCRs with PCS</a>. If you don't provide this option, it defaults to On-Demand.
        /// </para>
        /// </summary>
        public PurchaseOption PurchaseOption { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseOption property is set.
        /// </summary>
        internal bool IsSetPurchaseOption() => this.PurchaseOption != null;

        /// <summary>
        /// Gets and sets the property ScalingConfiguration. 
        /// <para>
        /// Specifies the boundaries of the compute node group auto scaling.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScalingConfigurationRequest ScalingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScalingConfiguration property is set.
        /// </summary>
        internal bool IsSetScalingConfiguration() => this.ScalingConfiguration != null;

        /// <summary>
        /// Gets and sets the property SlurmConfiguration. 
        /// <para>
        /// Additional options related to the Slurm scheduler.
        /// </para>
        /// </summary>
        public ComputeNodeGroupSlurmConfigurationRequest SlurmConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SlurmConfiguration property is set.
        /// </summary>
        internal bool IsSetSlurmConfiguration() => this.SlurmConfiguration != null;

        /// <summary>
        /// Gets and sets the property SpotOptions.
        /// </summary>
        public SpotOptions SpotOptions { get; set; }

        /// <summary>
        /// Checks to see if the SpotOptions property is set.
        /// </summary>
        internal bool IsSetSpotOptions() => this.SpotOptions != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The list of subnet IDs where the compute node group launches instances. Subnets must
        /// be in the same VPC as the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// 1 or more tags added to the resource. Each tag consists of a tag key and tag value.
        /// The tag value is optional and can be an empty string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
