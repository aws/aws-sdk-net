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
    /// An object representing an AWS Batch compute resource. For more information, see <a
    /// href="https://docs.aws.amazon.com/batch/latest/userguide/compute_environments.html">Compute
    /// Environments</a> in the <i>AWS Batch User Guide</i>.
    /// </summary>
    public partial class ComputeResource
    {
        private CRAllocationStrategy _allocationStrategy;
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
        private string _spotIamFleetRole;
        private List<string> _subnets = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private CRType _type;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The allocation strategy to use for the compute resource if not enough instances of
        /// the best fitting instance type can be allocated. This might be because of availability
        /// of the instance type in the Region or <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-resource-limits.html">Amazon
        /// EC2 service limits</a>. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/allocation-strategies.html">Allocation
        /// Strategies</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources, and shouldn't
        /// be specified.
        /// </para>
        ///  </note> <dl> <dt>BEST_FIT (default)</dt> <dd> 
        /// <para>
        /// AWS Batch selects an instance type that best fits the needs of the jobs with a preference
        /// for the lowest-cost instance type. If additional instances of the selected instance
        /// type aren't available, AWS Batch will wait for the additional instances to be available.
        /// If there are not enough instances available, or if the user is hitting <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-resource-limits.html">Amazon
        /// EC2 service limits</a> then additional jobs aren't run until currently running jobs
        /// have completed. This allocation strategy keeps costs lower but can limit scaling.
        /// If you are using Spot Fleets with <code>BEST_FIT</code> then the Spot Fleet IAM Role
        /// must be specified.
        /// </para>
        ///  </dd> <dt>BEST_FIT_PROGRESSIVE</dt> <dd> 
        /// <para>
        /// AWS Batch will select additional instance types that are large enough to meet the
        /// requirements of the jobs in the queue, with a preference for instance types with a
        /// lower cost per unit vCPU. If additional instances of the previously selected instance
        /// types aren't available, AWS Batch will select new instance types.
        /// </para>
        ///  </dd> <dt>SPOT_CAPACITY_OPTIMIZED</dt> <dd> 
        /// <para>
        /// AWS Batch will select one or more instance types that are large enough to meet the
        /// requirements of the jobs in the queue, with a preference for instance types that are
        /// less likely to be interrupted. This allocation strategy is only available for Spot
        /// Instance compute resources.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// With both <code>BEST_FIT_PROGRESSIVE</code> and <code>SPOT_CAPACITY_OPTIMIZED</code>
        /// strategies, AWS Batch might need to go above <code>maxvCpus</code> to meet your capacity
        /// requirements. In this event, AWS Batch never exceeds <code>maxvCpus</code> by more
        /// than a single instance.
        /// </para>
        /// </summary>
        public CRAllocationStrategy AllocationStrategy
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
        /// percentage is 20%, then the Spot price must be less than 20% of the current On-Demand
        /// price for that Amazon EC2 instance. You always pay the lowest (market) price and never
        /// more than your maximum percentage. If you leave this field empty, the default value
        /// is 100% of the On-Demand price.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources, and shouldn't
        /// be specified.
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
        /// The desired number of Amazon EC2 vCPUS in the compute environment. AWS Batch modifies
        /// this value between the minimum and maximum values, based on job queue demand.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources, and shouldn't
        /// be specified.
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
        /// default is <code>ECS_AL1</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources, and shouldn't
        /// be specified.
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
        /// You can use this key pair to log in to your instances with SSH.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources, and shouldn't
        /// be specified.
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
        /// structure.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources, and shouldn't
        /// be specified.
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
        [Obsolete("This field is deprecated, use ec2Configuration[].imageIdOverride instead.")]
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
        /// ECS Instance Role</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources, and shouldn't
        /// be specified.
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
        /// and R4 instance families) on the fly that match the demand of your job queues.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources, and shouldn't
        /// be specified.
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
        /// instance types from the C5, M5. and R5 instance families are used.
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
        /// The launch template to use for your compute resources. Any other compute resource
        /// parameters that you specify in a <a>CreateComputeEnvironment</a> API operation override
        /// the same parameters in the launch template. You must specify either the launch template
        /// ID or launch template name in the request, but not both. For more information, see
        /// <a href="https://docs.aws.amazon.com/batch/latest/userguide/launch-templates.html">Launch
        /// Template Support</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources, and shouldn't
        /// be specified.
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
        /// The maximum number of Amazon EC2 vCPUs that a compute environment can reach.
        /// </para>
        ///  <note> 
        /// <para>
        /// With both <code>BEST_FIT_PROGRESSIVE</code> and <code>SPOT_CAPACITY_OPTIMIZED</code>
        /// allocation strategies, AWS Batch might need to go above <code>maxvCpus</code> to meet
        /// your capacity requirements. In this event, AWS Batch will never go above <code>maxvCpus</code>
        /// by more than a single instance (e.g., no more than a single instance from among those
        /// specified in your compute environment).
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// This parameter isn't applicable to jobs running on Fargate resources, and shouldn't
        /// be specified.
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
        /// Groups</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources, and shouldn't
        /// be specified.
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
        /// The Amazon EC2 security groups associated with instances launched in the compute environment.
        /// One or more security groups must be specified, either in <code>securityGroupIds</code>
        /// or using a launch template referenced in <code>launchTemplate</code>. This parameter
        /// is required for jobs running on Fargate resources and must contain at least one security
        /// group. (Fargate does not support launch templates.) If security groups are specified
        /// using both <code>securityGroupIds</code> and <code>launchTemplate</code>, the values
        /// in <code>securityGroupIds</code> will be used.
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
        /// Gets and sets the property SpotIamFleetRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon EC2 Spot Fleet IAM role applied to a
        /// <code>SPOT</code> compute environment. This role is required if the allocation strategy
        /// set to <code>BEST_FIT</code> or if the allocation strategy isn't specified. For more
        /// information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/spot_fleet_IAM_role.html">Amazon
        /// EC2 Spot Fleet Role</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources, and shouldn't
        /// be specified.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// To tag your Spot Instances on creation, the Spot Fleet IAM role specified here must
        /// use the newer <b>AmazonEC2SpotFleetTaggingRole</b> managed policy. The previously
        /// recommended <b>AmazonEC2SpotFleetRole</b> managed policy doesn't have the required
        /// permissions to tag Spot Instances. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/troubleshooting.html#spot-instance-no-tag">Spot
        /// Instances not tagged on creation</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        public string SpotIamFleetRole
        {
            get { return this._spotIamFleetRole; }
            set { this._spotIamFleetRole = value; }
        }

        // Check to see if SpotIamFleetRole property is set
        internal bool IsSetSpotIamFleetRole()
        {
            return this._spotIamFleetRole != null;
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The VPC subnets into which the compute resources are launched. These subnets must
        /// be within the same VPC. This parameter is required for jobs running on Fargate resources,
        /// where it can contain up to 16 subnets. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">VPCs
        /// and Subnets</a> in the <i>Amazon VPC User Guide</i>.
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
        /// Key-value pair tags to be applied to EC2 resources that are launched in the compute
        /// environment. For AWS Batch, these take the form of "String1": "String2", where String1
        /// is the tag key and String2 is the tag value−for example, { "Name": "AWS Batch Instance
        /// - C4OnDemand" }. This is helpful for recognizing your AWS Batch instances in the Amazon
        /// EC2 console. These tags can't be updated or removed after the compute environment
        /// has been created; any changes require creating a new compute environment and removing
        /// the old compute environment. These tags are not seen when using the AWS Batch <code>ListTagsForResource</code>
        /// API operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources, and shouldn't
        /// be specified.
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
        /// Environments</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  If you choose <code>SPOT</code>, you must also specify an Amazon EC2 Spot Fleet role
        /// with the <code>spotIamFleetRole</code> parameter. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/spot_fleet_IAM_role.html">Amazon
        /// EC2 Spot Fleet role</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}