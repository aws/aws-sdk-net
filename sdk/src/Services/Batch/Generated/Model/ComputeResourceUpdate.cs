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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents the attributes of a compute environment that can be updated.
    /// For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
    /// compute environments</a> in the <i>Batch User Guide</i>.
    /// </summary>
    public partial class ComputeResourceUpdate
    {
        private CRUpdateAllocationStrategy _allocationStrategy;
        private int? _bidPercentage;
        private int? _desiredvCpus;
        private List<Ec2Configuration> _ec2Configuration = new List<Ec2Configuration>();
        private string _ec2KeyPair;
        private string _imageId;
        private string _instanceRole;
        private List<string> _instanceTypes = new List<string>();
        private LaunchTemplateSpecification _launchTemplate;
        private int? _maxvCpus;
        private int? _minvCpus;
        private string _placementGroup;
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _subnets = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private CRType _type;
        private bool? _updateToLatestImageVersion;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The allocation strategy to use for the compute resource if there's not enough instances
        /// of the best fitting instance type that can be allocated. This might be because of
        /// availability of the instance type in the Region or <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-resource-limits.html">Amazon
        /// EC2 service limits</a>. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/allocation-strategies.html">Allocation
        /// strategies</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When updating a compute environment, changing the allocation strategy requires an
        /// infrastructure update of the compute environment. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>. <code>BEST_FIT</code> isn't
        /// supported when updating a compute environment.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// specify it.
        /// </para>
        ///  </note> <dl> <dt>BEST_FIT_PROGRESSIVE</dt> <dd> 
        /// <para>
        /// Batch selects additional instance types that are large enough to meet the requirements
        /// of the jobs in the queue. Its preference is for instance types with lower cost vCPUs.
        /// If additional instances of the previously selected instance types aren't available,
        /// Batch selects new instance types.
        /// </para>
        ///  </dd> <dt>SPOT_CAPACITY_OPTIMIZED</dt> <dd> 
        /// <para>
        /// Batch selects one or more instance types that are large enough to meet the requirements
        /// of the jobs in the queue. Its preference is for instance types that are less likely
        /// to be interrupted. This allocation strategy is only available for Spot Instance compute
        /// resources.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// With both <code>BEST_FIT_PROGRESSIVE</code> and <code>SPOT_CAPACITY_OPTIMIZED</code>
        /// strategies using On-Demand or Spot Instances, and the <code>BEST_FIT</code> strategy
        /// using Spot Instances, Batch might need to exceed <code>maxvCpus</code> to meet your
        /// capacity requirements. In this event, Batch never exceeds <code>maxvCpus</code> by
        /// more than a single instance.
        /// </para>
        /// </summary>
        public CRUpdateAllocationStrategy AllocationStrategy
        {
            get { return this._allocationStrategy; }
            set { this._allocationStrategy = value; }
        }

        // Check to see if AllocationStrategy property is set
        internal bool IsSetAllocationStrategy()
        {
            return this._allocationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property BidPercentage. 
        /// <para>
        /// The maximum percentage that a Spot Instance price can be when compared with the On-Demand
        /// price for that instance type before instances are launched. For example, if your maximum
        /// percentage is 20%, the Spot price must be less than 20% of the current On-Demand price
        /// for that Amazon EC2 instance. You always pay the lowest (market) price and never more
        /// than your maximum percentage. For most use cases, we recommend leaving this field
        /// empty.
        /// </para>
        ///  
        /// <para>
        /// When updating a compute environment, changing the bid percentage requires an infrastructure
        /// update of the compute environment. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// specify it.
        /// </para>
        ///  </note>
        /// </summary>
        public int BidPercentage
        {
            get { return this._bidPercentage.GetValueOrDefault(); }
            set { this._bidPercentage = value; }
        }

        // Check to see if BidPercentage property is set
        internal bool IsSetBidPercentage()
        {
            return this._bidPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredvCpus. 
        /// <para>
        /// The desired number of Amazon EC2 vCPUS in the compute environment. Batch modifies
        /// this value between the minimum and maximum values based on job queue demand.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// specify it.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Batch doesn't support changing the desired number of vCPUs of an existing compute
        /// environment. Don't specify this parameter for compute environments using Amazon EKS
        /// clusters.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// When you update the <code>desiredvCpus</code> setting, the value must be between the
        /// <code>minvCpus</code> and <code>maxvCpus</code> values. 
        /// </para>
        ///  
        /// <para>
        /// Additionally, the updated <code>desiredvCpus</code> value must be greater than or
        /// equal to the current <code>desiredvCpus</code> value. For more information, see <a
        /// href="https://docs.aws.amazon.com/batch/latest/userguide/troubleshooting.html#error-desired-vcpus-update">Troubleshooting
        /// Batch</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public int DesiredvCpus
        {
            get { return this._desiredvCpus.GetValueOrDefault(); }
            set { this._desiredvCpus = value; }
        }

        // Check to see if DesiredvCpus property is set
        internal bool IsSetDesiredvCpus()
        {
            return this._desiredvCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ec2Configuration. 
        /// <para>
        /// Provides information used to select Amazon Machine Images (AMIs) for EC2 instances
        /// in the compute environment. If <code>Ec2Configuration</code> isn't specified, the
        /// default is <code>ECS_AL2</code>.
        /// </para>
        ///  
        /// <para>
        /// When updating a compute environment, changing this setting requires an infrastructure
        /// update of the compute environment. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>. To remove the EC2 configuration
        /// and any custom AMI ID specified in <code>imageIdOverride</code>, set this value to
        /// an empty string.
        /// </para>
        ///  
        /// <para>
        /// One or two values can be provided.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// specify it.
        /// </para>
        ///  </note>
        /// </summary>
        public List<Ec2Configuration> Ec2Configuration
        {
            get { return this._ec2Configuration; }
            set { this._ec2Configuration = value; }
        }

        // Check to see if Ec2Configuration property is set
        internal bool IsSetEc2Configuration()
        {
            return this._ec2Configuration != null && this._ec2Configuration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Ec2KeyPair. 
        /// <para>
        /// The Amazon EC2 key pair that's used for instances launched in the compute environment.
        /// You can use this key pair to log in to your instances with SSH. To remove the Amazon
        /// EC2 key pair, set this value to an empty string.
        /// </para>
        ///  
        /// <para>
        /// When updating a compute environment, changing the EC2 key pair requires an infrastructure
        /// update of the compute environment. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// specify it.
        /// </para>
        ///  </note>
        /// </summary>
        public string Ec2KeyPair
        {
            get { return this._ec2KeyPair; }
            set { this._ec2KeyPair = value; }
        }

        // Check to see if Ec2KeyPair property is set
        internal bool IsSetEc2KeyPair()
        {
            return this._ec2KeyPair != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The Amazon Machine Image (AMI) ID used for instances launched in the compute environment.
        /// This parameter is overridden by the <code>imageIdOverride</code> member of the <code>Ec2Configuration</code>
        /// structure. To remove the custom AMI ID and use the default AMI ID, set this value
        /// to an empty string.
        /// </para>
        ///  
        /// <para>
        /// When updating a compute environment, changing the AMI ID requires an infrastructure
        /// update of the compute environment. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// specify it.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// The AMI that you choose for a compute environment must match the architecture of the
        /// instance types that you intend to use for that compute environment. For example, if
        /// your compute environment uses A1 instance types, the compute resource AMI that you
        /// choose must support ARM instances. Amazon ECS vends both x86 and ARM versions of the
        /// Amazon ECS-optimized Amazon Linux 2 AMI. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html#ecs-optimized-ami-linux-variants.html">Amazon
        /// ECS-optimized Amazon Linux 2 AMI</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceRole. 
        /// <para>
        /// The Amazon ECS instance profile applied to Amazon EC2 instances in a compute environment.
        /// You can specify the short name or full Amazon Resource Name (ARN) of an instance profile.
        /// For example, <code> <i>ecsInstanceRole</i> </code> or <code>arn:aws:iam::<i>&lt;aws_account_id&gt;</i>:instance-profile/<i>ecsInstanceRole</i>
        /// </code>. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/instance_IAM_role.html">Amazon
        /// ECS instance role</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When updating a compute environment, changing this setting requires an infrastructure
        /// update of the compute environment. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// specify it.
        /// </para>
        ///  </note>
        /// </summary>
        public string InstanceRole
        {
            get { return this._instanceRole; }
            set { this._instanceRole = value; }
        }

        // Check to see if InstanceRole property is set
        internal bool IsSetInstanceRole()
        {
            return this._instanceRole != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// The instances types that can be launched. You can specify instance families to launch
        /// any instance type within those families (for example, <code>c5</code> or <code>p3</code>),
        /// or you can specify specific sizes within a family (such as <code>c5.8xlarge</code>).
        /// You can also choose <code>optimal</code> to select instance types (from the C4, M4,
        /// and R4 instance families) that match the demand of your job queues.
        /// </para>
        ///  
        /// <para>
        /// When updating a compute environment, changing this setting requires an infrastructure
        /// update of the compute environment. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// specify it.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// When you create a compute environment, the instance types that you select for the
        /// compute environment must share the same architecture. For example, you can't mix x86
        /// and ARM instances in the same compute environment.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Currently, <code>optimal</code> uses instance types from the C4, M4, and R4 instance
        /// families. In Regions that don't have instance types from those instance families,
        /// instance types from the C5, M5, and R5 instance families are used.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The updated launch template to use for your compute resources. You must specify either
        /// the launch template ID or launch template name in the request, but not both. For more
        /// information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/launch-templates.html">Launch
        /// template support</a> in the <i>Batch User Guide</i>. To remove the custom launch template
        /// and use the default launch template, set <code>launchTemplateId</code> or <code>launchTemplateName</code>
        /// member of the launch template specification to an empty string. Removing the launch
        /// template from a compute environment will not remove the AMI specified in the launch
        /// template. In order to update the AMI specified in a launch template, the <code>updateToLatestImageVersion</code>
        /// parameter must be set to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// When updating a compute environment, changing the launch template requires an infrastructure
        /// update of the compute environment. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// specify it.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property MaxvCpus. 
        /// <para>
        /// The maximum number of Amazon EC2 vCPUs that an environment can reach.
        /// </para>
        ///  <note> 
        /// <para>
        /// With both <code>BEST_FIT_PROGRESSIVE</code> and <code>SPOT_CAPACITY_OPTIMIZED</code>
        /// allocation strategies using On-Demand or Spot Instances, and the <code>BEST_FIT</code>
        /// strategy using Spot Instances, Batch might need to exceed <code>maxvCpus</code> to
        /// meet your capacity requirements. In this event, Batch never exceeds <code>maxvCpus</code>
        /// by more than a single instance. That is, no more than a single instance from among
        /// those specified in your compute environment.
        /// </para>
        ///  </note>
        /// </summary>
        public int MaxvCpus
        {
            get { return this._maxvCpus.GetValueOrDefault(); }
            set { this._maxvCpus = value; }
        }

        // Check to see if MaxvCpus property is set
        internal bool IsSetMaxvCpus()
        {
            return this._maxvCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinvCpus. 
        /// <para>
        /// The minimum number of Amazon EC2 vCPUs that an environment should maintain (even if
        /// the compute environment is <code>DISABLED</code>).
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// specify it.
        /// </para>
        ///  </note>
        /// </summary>
        public int MinvCpus
        {
            get { return this._minvCpus.GetValueOrDefault(); }
            set { this._minvCpus = value; }
        }

        // Check to see if MinvCpus property is set
        internal bool IsSetMinvCpus()
        {
            return this._minvCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlacementGroup. 
        /// <para>
        /// The Amazon EC2 placement group to associate with your compute resources. If you intend
        /// to submit multi-node parallel jobs to your compute environment, you should consider
        /// creating a cluster placement group and associate it with your compute resources. This
        /// keeps your multi-node parallel job on a logical grouping of instances within a single
        /// Availability Zone with high network flow potential. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// groups</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        ///  
        /// <para>
        /// When updating a compute environment, changing the placement group requires an infrastructure
        /// update of the compute environment. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// specify it.
        /// </para>
        ///  </note>
        /// </summary>
        public string PlacementGroup
        {
            get { return this._placementGroup; }
            set { this._placementGroup = value; }
        }

        // Check to see if PlacementGroup property is set
        internal bool IsSetPlacementGroup()
        {
            return this._placementGroup != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The Amazon EC2 security groups that are associated with instances launched in the
        /// compute environment. This parameter is required for Fargate compute resources, where
        /// it can contain up to 5 security groups. For Fargate compute resources, providing an
        /// empty list is handled as if this parameter wasn't specified and no change is made.
        /// For EC2 compute resources, providing an empty list removes the security groups from
        /// the compute resource.
        /// </para>
        ///  
        /// <para>
        /// When updating a compute environment, changing the EC2 security groups requires an
        /// infrastructure update of the compute environment. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The VPC subnets where the compute resources are launched. Fargate compute resources
        /// can contain up to 16 subnets. For Fargate compute resources, providing an empty list
        /// will be handled as if this parameter wasn't specified and no change is made. For EC2
        /// compute resources, providing an empty list removes the VPC subnets from the compute
        /// resource. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">VPCs
        /// and subnets</a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When updating a compute environment, changing the VPC subnets requires an infrastructure
        /// update of the compute environment. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Batch on Amazon EC2 and Batch on Amazon EKS support Local Zones. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html#concepts-local-zones">
        /// Local Zones</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>, <a href="https://docs.aws.amazon.com/eks/latest/userguide/local-zones.html">Amazon
        /// EKS and Amazon Web Services Local Zones</a> in the <i>Amazon EKS User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cluster-regions-zones.html#clusters-local-zones">
        /// Amazon ECS clusters in Local Zones, Wavelength Zones, and Amazon Web Services Outposts</a>
        /// in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Batch on Fargate doesn't currently support Local Zones.
        /// </para>
        ///  </note>
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
        /// Key-value pair tags to be applied to EC2 resources that are launched in the compute
        /// environment. For Batch, these take the form of <code>"String1": "String2"</code>,
        /// where <code>String1</code> is the tag key and <code>String2</code> is the tag value-for
        /// example, <code>{ "Name": "Batch Instance - C4OnDemand" }</code>. This is helpful for
        /// recognizing your Batch instances in the Amazon EC2 console. These tags aren't seen
        /// when using the Batch <code>ListTagsForResource</code> API operation.
        /// </para>
        ///  
        /// <para>
        /// When updating a compute environment, changing this setting requires an infrastructure
        /// update of the compute environment. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// specify it.
        /// </para>
        ///  </note>
        /// </summary>
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of compute environment: <code>EC2</code>, <code>SPOT</code>, <code>FARGATE</code>,
        /// or <code>FARGATE_SPOT</code>. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/compute_environments.html">Compute
        /// environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  If you choose <code>SPOT</code>, you must also specify an Amazon EC2 Spot Fleet role
        /// with the <code>spotIamFleetRole</code> parameter. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/spot_fleet_IAM_role.html">Amazon
        /// EC2 spot fleet role</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When updating a compute environment, changing the type of a compute environment requires
        /// an infrastructure update of the compute environment. For more information, see <a
        /// href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public CRType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateToLatestImageVersion. 
        /// <para>
        /// Specifies whether the AMI ID is updated to the latest one that's supported by Batch
        /// when the compute environment has an infrastructure update. The default value is <code>false</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// An AMI ID can either be specified in the <code>imageId</code> or <code>imageIdOverride</code>
        /// parameters or be determined by the launch template that's specified in the <code>launchTemplate</code>
        /// parameter. If an AMI ID is specified any of these ways, this parameter is ignored.
        /// For more information about to update AMI IDs during an infrastructure update, see
        /// <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html#updating-compute-environments-ami">Updating
        /// the AMI ID</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When updating a compute environment, changing this setting requires an infrastructure
        /// update of the compute environment. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public bool UpdateToLatestImageVersion
        {
            get { return this._updateToLatestImageVersion.GetValueOrDefault(); }
            set { this._updateToLatestImageVersion = value; }
        }

        // Check to see if UpdateToLatestImageVersion property is set
        internal bool IsSetUpdateToLatestImageVersion()
        {
            return this._updateToLatestImageVersion.HasValue; 
        }

    }
}