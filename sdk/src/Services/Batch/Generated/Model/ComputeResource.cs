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
    /// An object that represents an Batch compute resource. For more information, see <a
    /// href="https://docs.aws.amazon.com/batch/latest/userguide/compute_environments.html">Compute
    /// environments</a> in the <i>Batch User Guide</i>.
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
        /// strategies</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// specify it.
        /// </para>
        ///  </note> <dl> <dt>BEST_FIT (default)</dt> <dd> 
        /// <para>
        /// Batch selects an instance type that best fits the needs of the jobs with a preference
        /// for the lowest-cost instance type. If additional instances of the selected instance
        /// type aren't available, Batch waits for the additional instances to be available. If
        /// there aren't enough instances available or the user is reaching <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-resource-limits.html">Amazon
        /// EC2 service limits</a>, additional jobs aren't run until the currently running jobs
        /// are completed. This allocation strategy keeps costs lower but can limit scaling. If
        /// you're using Spot Fleets with <code>BEST_FIT</code>, the Spot Fleet IAM Role must
        /// be specified. Compute resources that use a <code>BEST_FIT</code> allocation strategy
        /// don't support infrastructure updates and can't update some parameters. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  </dd> <dt>BEST_FIT_PROGRESSIVE</dt> <dd> 
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
        /// is 100% of the On-Demand price. For most use cases, we recommend leaving this field
        /// empty.
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
        /// Provides information that's used to select Amazon Machine Images (AMIs) for EC2 instances
        /// in the compute environment. If <code>Ec2Configuration</code> isn't specified, the
        /// default is <code>ECS_AL2</code>.
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
        /// You can use this key pair to log in to your instances with SSH.
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
        /// structure.
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
        /// ECS instance role</a> in the <i>Batch User Guide</i>.
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
        /// The launch template to use for your compute resources. Any other compute resource
        /// parameters that you specify in a <a>CreateComputeEnvironment</a> API operation override
        /// the same parameters in the launch template. You must specify either the launch template
        /// ID or launch template name in the request, but not both. For more information, see
        /// <a href="https://docs.aws.amazon.com/batch/latest/userguide/launch-templates.html">Launch
        /// template support</a> in the <i>Batch User Guide</i>.
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
        /// The maximum number of Amazon EC2 vCPUs that a compute environment can reach.
        /// </para>
        ///  <note> 
        /// <para>
        /// With both <code>BEST_FIT_PROGRESSIVE</code> and <code>SPOT_CAPACITY_OPTIMIZED</code>
        /// allocation strategies using On-Demand or Spot Instances, and the <code>BEST_FIT</code>
        /// strategy using Spot Instances, Batch might need to exceed <code>maxvCpus</code> to
        /// meet your capacity requirements. In this event, Batch never exceeds <code>maxvCpus</code>
        /// by more than a single instance. For example, no more than a single instance from among
        /// those specified in your compute environment is allocated.
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
        /// compute environment. One or more security groups must be specified, either in <code>securityGroupIds</code>
        /// or using a launch template referenced in <code>launchTemplate</code>. This parameter
        /// is required for jobs that are running on Fargate resources and must contain at least
        /// one security group. Fargate doesn't support launch templates. If security groups are
        /// specified using both <code>securityGroupIds</code> and <code>launchTemplate</code>,
        /// the values in <code>securityGroupIds</code> are used.
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
        /// EC2 spot fleet role</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources. Don't
        /// specify it.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// To tag your Spot Instances on creation, the Spot Fleet IAM role specified here must
        /// use the newer <b>AmazonEC2SpotFleetTaggingRole</b> managed policy. The previously
        /// recommended <b>AmazonEC2SpotFleetRole</b> managed policy doesn't have the required
        /// permissions to tag Spot Instances. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/troubleshooting.html#spot-instance-no-tag">Spot
        /// instances not tagged on creation</a> in the <i>Batch User Guide</i>.
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
        /// The VPC subnets where the compute resources are launched. These subnets must be within
        /// the same VPC. Fargate compute resources can contain up to 16 subnets. For more information,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">VPCs
        /// and subnets</a> in the <i>Amazon VPC User Guide</i>.
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
        /// environment. For Batch, these take the form of <code>"String1": "String2"</code>,
        /// where <code>String1</code> is the tag key and <code>String2</code> is the tag value-for
        /// example, <code>{ "Name": "Batch Instance - C4OnDemand" }</code>. This is helpful for
        /// recognizing your Batch instances in the Amazon EC2 console. Updating these tags requires
        /// an infrastructure update to the compute environment. For more information, see <a
        /// href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>. These tags aren't seen when
        /// using the Batch <code>ListTagsForResource</code> API operation.
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