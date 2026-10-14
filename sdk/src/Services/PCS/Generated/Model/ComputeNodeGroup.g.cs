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
    /// A compute node group associated with a cluster.
    /// </summary>
    public partial class ComputeNodeGroup
    {
        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        /// The ID of the Amazon Machine Image (AMI) that PCS uses to launch instances. If not
        /// provided, PCS uses the AMI ID specified in the custom launch template.
        /// </para>
        /// </summary>
        public string AmiId { get; set; }

        /// <summary>
        /// Checks to see if the AmiId property is set.
        /// </summary>
        internal bool IsSetAmiId() => this.AmiId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) of the compute node group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The ID of the cluster of the compute node group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

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
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// The list of errors that occurred during compute node group provisioning.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ErrorInfo> ErrorInfo { get; set; } = AWSConfigs.InitializeCollections ? new List<ErrorInfo>() : null;

        /// <summary>
        /// Checks to see if the ErrorInfo property is set.
        /// </summary>
        internal bool IsSetErrorInfo() => this.ErrorInfo != null && (this.ErrorInfo.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property Id. 
        /// <para>
        /// The generated unique ID of the compute node group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

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
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The date and time the resource was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that identifies the compute node group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 25)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NodeLifecycleActions. 
        /// <para>
        /// The lifecycle actions to run on compute nodes in the compute node group. Use lifecycle
        /// actions to run custom scripts at defined stages of a compute node's lifecycle, such
        /// as when a compute node finishes bootstrapping or becomes ready to accept jobs.
        /// </para>
        /// </summary>
        public NodeLifecycleActions NodeLifecycleActions { get; set; }

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
        /// </summary>
        [AWSProperty(Required = true)]
        public ScalingConfiguration ScalingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScalingConfiguration property is set.
        /// </summary>
        internal bool IsSetScalingConfiguration() => this.ScalingConfiguration != null;

        /// <summary>
        /// Gets and sets the property SlurmConfiguration.
        /// </summary>
        public ComputeNodeGroupSlurmConfiguration SlurmConfiguration { get; set; }

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
        /// Gets and sets the property Status. 
        /// <para>
        /// The provisioning status of the compute node group.
        /// </para>
        ///  <note> 
        /// <para>
        /// The provisioning status doesn't indicate the overall health of the compute node group.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// The resource enters the <c>SUSPENDING</c> and <c>SUSPENDED</c> states when the scheduler
        /// is beyond end of life and we have suspended the cluster. When in these states, you
        /// can't use the cluster. The cluster controller is down and all compute instances are
        /// terminated. The resources still count toward your service quotas. You can delete a
        /// resource if its status is <c>SUSPENDED</c>. For more information, see <a href="https://docs.aws.amazon.com/pcs/latest/userguide/slurm-versions_faq.html">Frequently
        /// asked questions about Slurm versions in PCS</a> in the <i>PCS User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComputeNodeGroupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The list of subnet IDs where instances are provisioned by the compute node group.
        /// The subnets must be in the same VPC as the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
