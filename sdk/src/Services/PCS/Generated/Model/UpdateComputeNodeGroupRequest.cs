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
    /// Container for the parameters to the UpdateComputeNodeGroup operation.
    /// Updates a compute node group. You can update many of the fields related to your compute
    /// node group including the configurations for networking, compute nodes, and settings
    /// specific to your scheduler (such as Slurm).
    /// </summary>
    public partial class UpdateComputeNodeGroupRequest : AmazonPCSRequest
    {
        private string _amiId;
        private string _clientToken;
        private string _clusterIdentifier;
        private string _computeNodeGroupIdentifier;
        private CustomLaunchTemplate _customLaunchTemplate;
        private string _iamInstanceProfileArn;
        private PurchaseOption _purchaseOption;
        private ScalingConfigurationRequest _scalingConfiguration;
        private UpdateComputeNodeGroupSlurmConfigurationRequest _slurmConfiguration;
        private SpotOptions _spotOptions;
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
        [AWSProperty(Min=8, Max=100)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The name or ID of the cluster of the compute node group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeNodeGroupIdentifier. 
        /// <para>
        /// The name or ID of the compute node group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComputeNodeGroupIdentifier
        {
            get { return this._computeNodeGroupIdentifier; }
            set { this._computeNodeGroupIdentifier = value; }
        }

        // Check to see if ComputeNodeGroupIdentifier property is set
        internal bool IsSetComputeNodeGroupIdentifier()
        {
            return this._computeNodeGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property CustomLaunchTemplate.
        /// </summary>
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
        /// <para>
        /// Specifies the boundaries of the compute node group auto scaling.
        /// </para>
        /// </summary>
        public ScalingConfigurationRequest ScalingConfiguration
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
        /// <para>
        /// Additional options related to the Slurm scheduler.
        /// </para>
        /// </summary>
        public UpdateComputeNodeGroupSlurmConfigurationRequest SlurmConfiguration
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The list of subnet IDs where the compute node group provisions instances. The subnets
        /// must be in the same VPC as the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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