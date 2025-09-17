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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
        private string _amiId;
        private string _arn;
        private string _clusterId;
        private DateTime? _createdAt;
        private CustomLaunchTemplate _customLaunchTemplate;
        private List<ErrorInfo> _errorInfo = AWSConfigs.InitializeCollections ? new List<ErrorInfo>() : null;
        private string _iamInstanceProfileArn;
        private string _id;
        private List<InstanceConfig> _instanceConfigs = AWSConfigs.InitializeCollections ? new List<InstanceConfig>() : null;
        private DateTime? _modifiedAt;
        private string _name;
        private PurchaseOption _purchaseOption;
        private ScalingConfiguration _scalingConfiguration;
        private ComputeNodeGroupSlurmConfiguration _slurmConfiguration;
        private SpotOptions _spotOptions;
        private ComputeNodeGroupStatus _status;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        /// The ID of the Amazon Machine Image (AMI) that PCS uses to launch instances. If not
        /// provided, PCS uses the AMI ID specified in the custom launch template.
        /// </para>
        /// </summary>
        public string AmiId
        {
            get { return this._amiId; }
            set { this._amiId = value; }
        }

        // Check to see if AmiId property is set
        internal bool IsSetAmiId()
        {
            return this._amiId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) of the compute node group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The ID of the cluster of the compute node group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CustomLaunchTemplate.
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomLaunchTemplate CustomLaunchTemplate
        {
            get { return this._customLaunchTemplate; }
            set { this._customLaunchTemplate = value; }
        }

        // Check to see if CustomLaunchTemplate property is set
        internal bool IsSetCustomLaunchTemplate()
        {
            return this._customLaunchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// The list of errors that occurred during compute node group provisioning.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ErrorInfo> ErrorInfo
        {
            get { return this._errorInfo; }
            set { this._errorInfo = value; }
        }

        // Check to see if ErrorInfo property is set
        internal bool IsSetErrorInfo()
        {
            return this._errorInfo != null && (this._errorInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Required=true)]
        public string IamInstanceProfileArn
        {
            get { return this._iamInstanceProfileArn; }
            set { this._iamInstanceProfileArn = value; }
        }

        // Check to see if IamInstanceProfileArn property is set
        internal bool IsSetIamInstanceProfileArn()
        {
            return this._iamInstanceProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The generated unique ID of the compute node group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceConfigs. 
        /// <para>
        /// A list of EC2 instance configurations that PCS can provision in the compute node group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<InstanceConfig> InstanceConfigs
        {
            get { return this._instanceConfigs; }
            set { this._instanceConfigs = value; }
        }

        // Check to see if InstanceConfigs property is set
        internal bool IsSetInstanceConfigs()
        {
            return this._instanceConfigs != null && (this._instanceConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The date and time the resource was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that identifies the compute node group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=25)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PurchaseOption. 
        /// <para>
        /// Specifies how EC2 instances are purchased on your behalf. PCS supports On-Demand Instances,
        /// Spot Instances, and Amazon EC2 Capacity Blocks for ML. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-purchasing-options.html">Amazon
        /// EC2 billing and purchasing options</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>. For more information about PCS support for Capacity Blocks, see <a href="https://docs.aws.amazon.com/pcs/latest/userguide/capacity-blocks.html">Using
        /// Amazon EC2 Capacity Blocks for ML with PCS</a> in the <i>PCS User Guide</i>. If you
        /// don't provide this option, it defaults to On-Demand.
        /// </para>
        /// </summary>
        public PurchaseOption PurchaseOption
        {
            get { return this._purchaseOption; }
            set { this._purchaseOption = value; }
        }

        // Check to see if PurchaseOption property is set
        internal bool IsSetPurchaseOption()
        {
            return this._purchaseOption != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public ScalingConfiguration ScalingConfiguration
        {
            get { return this._scalingConfiguration; }
            set { this._scalingConfiguration = value; }
        }

        // Check to see if ScalingConfiguration property is set
        internal bool IsSetScalingConfiguration()
        {
            return this._scalingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SlurmConfiguration.
        /// </summary>
        public ComputeNodeGroupSlurmConfiguration SlurmConfiguration
        {
            get { return this._slurmConfiguration; }
            set { this._slurmConfiguration = value; }
        }

        // Check to see if SlurmConfiguration property is set
        internal bool IsSetSlurmConfiguration()
        {
            return this._slurmConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SpotOptions.
        /// </summary>
        public SpotOptions SpotOptions
        {
            get { return this._spotOptions; }
            set { this._spotOptions = value; }
        }

        // Check to see if SpotOptions property is set
        internal bool IsSetSpotOptions()
        {
            return this._spotOptions != null;
        }

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
        [AWSProperty(Required=true)]
        public ComputeNodeGroupStatus Status
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The list of subnet IDs where instances are provisioned by the compute node group.
        /// The subnets must be in the same VPC as the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}