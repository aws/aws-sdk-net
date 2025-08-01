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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The detailed description of the cluster.
    /// </summary>
    public partial class Cluster
    {
        private List<Application> _applications = AWSConfigs.InitializeCollections ? new List<Application>() : null;
        private string _autoScalingRole;
        private bool? _autoTerminate;
        private string _clusterArn;
        private List<Configuration> _configurations = AWSConfigs.InitializeCollections ? new List<Configuration>() : null;
        private string _customAmiId;
        private int? _ebsRootVolumeIops;
        private int? _ebsRootVolumeSize;
        private int? _ebsRootVolumeThroughput;
        private Ec2InstanceAttributes _ec2InstanceAttributes;
        private bool? _extendedSupport;
        private string _id;
        private InstanceCollectionType _instanceCollectionType;
        private KerberosAttributes _kerberosAttributes;
        private string _logEncryptionKmsKeyId;
        private string _logUri;
        private string _masterPublicDnsName;
        private string _name;
        private int? _normalizedInstanceHours;
        private string _osReleaseLabel;
        private string _outpostArn;
        private List<PlacementGroupConfig> _placementGroups = AWSConfigs.InitializeCollections ? new List<PlacementGroupConfig>() : null;
        private string _releaseLabel;
        private RepoUpgradeOnBoot _repoUpgradeOnBoot;
        private string _requestedAmiVersion;
        private string _runningAmiVersion;
        private ScaleDownBehavior _scaleDownBehavior;
        private string _securityConfiguration;
        private string _serviceRole;
        private ClusterStatus _status;
        private int? _stepConcurrencyLevel;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _terminationProtected;
        private bool? _unhealthyNodeReplacement;
        private bool? _visibleToAllUsers;

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// The applications installed on this cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Application> Applications
        {
            get { return this._applications; }
            set { this._applications = value; }
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this._applications != null && (this._applications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoScalingRole. 
        /// <para>
        /// An IAM role for automatic scaling policies. The default role is <c>EMR_AutoScaling_DefaultRole</c>.
        /// The IAM role provides permissions that the automatic scaling feature requires to launch
        /// and terminate Amazon EC2 instances in an instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string AutoScalingRole
        {
            get { return this._autoScalingRole; }
            set { this._autoScalingRole = value; }
        }

        // Check to see if AutoScalingRole property is set
        internal bool IsSetAutoScalingRole()
        {
            return this._autoScalingRole != null;
        }

        /// <summary>
        /// Gets and sets the property AutoTerminate. 
        /// <para>
        /// Specifies whether the cluster should terminate after completing all steps.
        /// </para>
        /// </summary>
        public bool? AutoTerminate
        {
            get { return this._autoTerminate; }
            set { this._autoTerminate = value; }
        }

        // Check to see if AutoTerminate property is set
        internal bool IsSetAutoTerminate()
        {
            return this._autoTerminate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// Applies only to Amazon EMR releases 4.x and later. The list of configurations that
        /// are supplied to the Amazon EMR cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Configuration> Configurations
        {
            get { return this._configurations; }
            set { this._configurations = value; }
        }

        // Check to see if Configurations property is set
        internal bool IsSetConfigurations()
        {
            return this._configurations != null && (this._configurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomAmiId. 
        /// <para>
        /// Available only in Amazon EMR releases 5.7.0 and later. The ID of a custom Amazon EBS-backed
        /// Linux AMI if the cluster uses a custom AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string CustomAmiId
        {
            get { return this._customAmiId; }
            set { this._customAmiId = value; }
        }

        // Check to see if CustomAmiId property is set
        internal bool IsSetCustomAmiId()
        {
            return this._customAmiId != null;
        }

        /// <summary>
        /// Gets and sets the property EbsRootVolumeIops. 
        /// <para>
        /// The IOPS, of the Amazon EBS root device volume of the Linux AMI that is used for each
        /// Amazon EC2 instance. Available in Amazon EMR releases 6.15.0 and later.
        /// </para>
        /// </summary>
        public int? EbsRootVolumeIops
        {
            get { return this._ebsRootVolumeIops; }
            set { this._ebsRootVolumeIops = value; }
        }

        // Check to see if EbsRootVolumeIops property is set
        internal bool IsSetEbsRootVolumeIops()
        {
            return this._ebsRootVolumeIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EbsRootVolumeSize. 
        /// <para>
        /// The size, in GiB, of the Amazon EBS root device volume of the Linux AMI that is used
        /// for each Amazon EC2 instance. Available in Amazon EMR releases 4.x and later.
        /// </para>
        /// </summary>
        public int? EbsRootVolumeSize
        {
            get { return this._ebsRootVolumeSize; }
            set { this._ebsRootVolumeSize = value; }
        }

        // Check to see if EbsRootVolumeSize property is set
        internal bool IsSetEbsRootVolumeSize()
        {
            return this._ebsRootVolumeSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EbsRootVolumeThroughput. 
        /// <para>
        /// The throughput, in MiB/s, of the Amazon EBS root device volume of the Linux AMI that
        /// is used for each Amazon EC2 instance. Available in Amazon EMR releases 6.15.0 and
        /// later.
        /// </para>
        /// </summary>
        public int? EbsRootVolumeThroughput
        {
            get { return this._ebsRootVolumeThroughput; }
            set { this._ebsRootVolumeThroughput = value; }
        }

        // Check to see if EbsRootVolumeThroughput property is set
        internal bool IsSetEbsRootVolumeThroughput()
        {
            return this._ebsRootVolumeThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceAttributes. 
        /// <para>
        /// Provides information about the Amazon EC2 instances in a cluster grouped by category.
        /// For example, key name, subnet ID, IAM instance profile, and so on.
        /// </para>
        /// </summary>
        public Ec2InstanceAttributes Ec2InstanceAttributes
        {
            get { return this._ec2InstanceAttributes; }
            set { this._ec2InstanceAttributes = value; }
        }

        // Check to see if Ec2InstanceAttributes property is set
        internal bool IsSetEc2InstanceAttributes()
        {
            return this._ec2InstanceAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ExtendedSupport. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public bool? ExtendedSupport
        {
            get { return this._extendedSupport; }
            set { this._extendedSupport = value; }
        }

        // Check to see if ExtendedSupport property is set
        internal bool IsSetExtendedSupport()
        {
            return this._extendedSupport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the cluster.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property InstanceCollectionType. <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note> 
        /// <para>
        /// The instance group configuration of the cluster. A value of <c>INSTANCE_GROUP</c>
        /// indicates a uniform instance group configuration. A value of <c>INSTANCE_FLEET</c>
        /// indicates an instance fleets configuration.
        /// </para>
        /// </summary>
        public InstanceCollectionType InstanceCollectionType
        {
            get { return this._instanceCollectionType; }
            set { this._instanceCollectionType = value; }
        }

        // Check to see if InstanceCollectionType property is set
        internal bool IsSetInstanceCollectionType()
        {
            return this._instanceCollectionType != null;
        }

        /// <summary>
        /// Gets and sets the property KerberosAttributes. 
        /// <para>
        /// Attributes for Kerberos configuration when Kerberos authentication is enabled using
        /// a security configuration. For more information see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-kerberos.html">Use
        /// Kerberos Authentication</a> in the <i>Amazon EMR Management Guide</i>.
        /// </para>
        /// </summary>
        public KerberosAttributes KerberosAttributes
        {
            get { return this._kerberosAttributes; }
            set { this._kerberosAttributes = value; }
        }

        // Check to see if KerberosAttributes property is set
        internal bool IsSetKerberosAttributes()
        {
            return this._kerberosAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property LogEncryptionKmsKeyId. 
        /// <para>
        ///  The KMS key used for encrypting log files. This attribute is only available with
        /// Amazon EMR 5.30.0 and later, excluding Amazon EMR 6.0.0. 
        /// </para>
        /// </summary>
        public string LogEncryptionKmsKeyId
        {
            get { return this._logEncryptionKmsKeyId; }
            set { this._logEncryptionKmsKeyId = value; }
        }

        // Check to see if LogEncryptionKmsKeyId property is set
        internal bool IsSetLogEncryptionKmsKeyId()
        {
            return this._logEncryptionKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LogUri. 
        /// <para>
        /// The path to the Amazon S3 location where logs for this cluster are stored.
        /// </para>
        /// </summary>
        public string LogUri
        {
            get { return this._logUri; }
            set { this._logUri = value; }
        }

        // Check to see if LogUri property is set
        internal bool IsSetLogUri()
        {
            return this._logUri != null;
        }

        /// <summary>
        /// Gets and sets the property MasterPublicDnsName. 
        /// <para>
        /// The DNS name of the master node. If the cluster is on a private subnet, this is the
        /// private DNS name. On a public subnet, this is the public DNS name.
        /// </para>
        /// </summary>
        public string MasterPublicDnsName
        {
            get { return this._masterPublicDnsName; }
            set { this._masterPublicDnsName = value; }
        }

        // Check to see if MasterPublicDnsName property is set
        internal bool IsSetMasterPublicDnsName()
        {
            return this._masterPublicDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cluster. This parameter can't contain the characters &lt;, &gt;, $,
        /// |, or ` (backtick).
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NormalizedInstanceHours. 
        /// <para>
        /// An approximation of the cost of the cluster, represented in m1.small/hours. This value
        /// is incremented one time for every hour an m1.small instance runs. Larger instances
        /// are weighted more, so an Amazon EC2 instance that is roughly four times more expensive
        /// would result in the normalized instance hours being incremented by four. This result
        /// is only an approximation and does not reflect the actual billing rate.
        /// </para>
        /// </summary>
        public int? NormalizedInstanceHours
        {
            get { return this._normalizedInstanceHours; }
            set { this._normalizedInstanceHours = value; }
        }

        // Check to see if NormalizedInstanceHours property is set
        internal bool IsSetNormalizedInstanceHours()
        {
            return this._normalizedInstanceHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OSReleaseLabel. 
        /// <para>
        /// The Amazon Linux release specified in a cluster launch RunJobFlow request. If no Amazon
        /// Linux release was specified, the default Amazon Linux release is shown in the response.
        /// </para>
        /// </summary>
        public string OSReleaseLabel
        {
            get { return this._osReleaseLabel; }
            set { this._osReleaseLabel = value; }
        }

        // Check to see if OSReleaseLabel property is set
        internal bool IsSetOSReleaseLabel()
        {
            return this._osReleaseLabel != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Outpost where the cluster is launched. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property PlacementGroups. 
        /// <para>
        /// Placement group configured for an Amazon EMR cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlacementGroupConfig> PlacementGroups
        {
            get { return this._placementGroups; }
            set { this._placementGroups = value; }
        }

        // Check to see if PlacementGroups property is set
        internal bool IsSetPlacementGroups()
        {
            return this._placementGroups != null && (this._placementGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The Amazon EMR release label, which determines the version of open-source application
        /// packages installed on the cluster. Release labels are in the form <c>emr-x.x.x</c>,
        /// where x.x.x is an Amazon EMR release version such as <c>emr-5.14.0</c>. For more information
        /// about Amazon EMR release versions and included application versions and features,
        /// see <a href="https://docs.aws.amazon.com/emr/latest/ReleaseGuide/">https://docs.aws.amazon.com/emr/latest/ReleaseGuide/</a>.
        /// The release label applies only to Amazon EMR releases version 4.0 and later. Earlier
        /// versions use <c>AmiVersion</c>.
        /// </para>
        /// </summary>
        public string ReleaseLabel
        {
            get { return this._releaseLabel; }
            set { this._releaseLabel = value; }
        }

        // Check to see if ReleaseLabel property is set
        internal bool IsSetReleaseLabel()
        {
            return this._releaseLabel != null;
        }

        /// <summary>
        /// Gets and sets the property RepoUpgradeOnBoot. 
        /// <para>
        /// Applies only when <c>CustomAmiID</c> is used. Specifies the type of updates that the
        /// Amazon Linux AMI package repositories apply when an instance boots using the AMI.
        /// </para>
        /// </summary>
        public RepoUpgradeOnBoot RepoUpgradeOnBoot
        {
            get { return this._repoUpgradeOnBoot; }
            set { this._repoUpgradeOnBoot = value; }
        }

        // Check to see if RepoUpgradeOnBoot property is set
        internal bool IsSetRepoUpgradeOnBoot()
        {
            return this._repoUpgradeOnBoot != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedAmiVersion. 
        /// <para>
        /// The AMI version requested for this cluster.
        /// </para>
        /// </summary>
        public string RequestedAmiVersion
        {
            get { return this._requestedAmiVersion; }
            set { this._requestedAmiVersion = value; }
        }

        // Check to see if RequestedAmiVersion property is set
        internal bool IsSetRequestedAmiVersion()
        {
            return this._requestedAmiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RunningAmiVersion. 
        /// <para>
        /// The AMI version running on this cluster.
        /// </para>
        /// </summary>
        public string RunningAmiVersion
        {
            get { return this._runningAmiVersion; }
            set { this._runningAmiVersion = value; }
        }

        // Check to see if RunningAmiVersion property is set
        internal bool IsSetRunningAmiVersion()
        {
            return this._runningAmiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ScaleDownBehavior. 
        /// <para>
        /// The way that individual Amazon EC2 instances terminate when an automatic scale-in
        /// activity occurs or an instance group is resized. <c>TERMINATE_AT_INSTANCE_HOUR</c>
        /// indicates that Amazon EMR terminates nodes at the instance-hour boundary, regardless
        /// of when the request to terminate the instance was submitted. This option is only available
        /// with Amazon EMR 5.1.0 and later and is the default for clusters created using that
        /// version. <c>TERMINATE_AT_TASK_COMPLETION</c> indicates that Amazon EMR adds nodes
        /// to a deny list and drains tasks from nodes before terminating the Amazon EC2 instances,
        /// regardless of the instance-hour boundary. With either behavior, Amazon EMR removes
        /// the least active nodes first and blocks instance termination if it could lead to HDFS
        /// corruption. <c>TERMINATE_AT_TASK_COMPLETION</c> is available only in Amazon EMR releases
        /// 4.1.0 and later, and is the default for versions of Amazon EMR earlier than 5.1.0.
        /// </para>
        /// </summary>
        public ScaleDownBehavior ScaleDownBehavior
        {
            get { return this._scaleDownBehavior; }
            set { this._scaleDownBehavior = value; }
        }

        // Check to see if ScaleDownBehavior property is set
        internal bool IsSetScaleDownBehavior()
        {
            return this._scaleDownBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// The name of the security configuration applied to the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string SecurityConfiguration
        {
            get { return this._securityConfiguration; }
            set { this._securityConfiguration = value; }
        }

        // Check to see if SecurityConfiguration property is set
        internal bool IsSetSecurityConfiguration()
        {
            return this._securityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The IAM role that Amazon EMR assumes in order to access Amazon Web Services resources
        /// on your behalf.
        /// </para>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status details about the cluster.
        /// </para>
        /// </summary>
        public ClusterStatus Status
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
        /// Gets and sets the property StepConcurrencyLevel. 
        /// <para>
        /// Specifies the number of steps that can be executed concurrently.
        /// </para>
        /// </summary>
        public int? StepConcurrencyLevel
        {
            get { return this._stepConcurrencyLevel; }
            set { this._stepConcurrencyLevel = value; }
        }

        // Check to see if StepConcurrencyLevel property is set
        internal bool IsSetStepConcurrencyLevel()
        {
            return this._stepConcurrencyLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with a cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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
        /// Gets and sets the property TerminationProtected. 
        /// <para>
        /// Indicates whether Amazon EMR will lock the cluster to prevent the Amazon EC2 instances
        /// from being terminated by an API call or user intervention, or in the event of a cluster
        /// error.
        /// </para>
        /// </summary>
        public bool? TerminationProtected
        {
            get { return this._terminationProtected; }
            set { this._terminationProtected = value; }
        }

        // Check to see if TerminationProtected property is set
        internal bool IsSetTerminationProtected()
        {
            return this._terminationProtected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnhealthyNodeReplacement. 
        /// <para>
        /// Indicates whether Amazon EMR should gracefully replace Amazon EC2 core instances that
        /// have degraded within the cluster.
        /// </para>
        /// </summary>
        public bool? UnhealthyNodeReplacement
        {
            get { return this._unhealthyNodeReplacement; }
            set { this._unhealthyNodeReplacement = value; }
        }

        // Check to see if UnhealthyNodeReplacement property is set
        internal bool IsSetUnhealthyNodeReplacement()
        {
            return this._unhealthyNodeReplacement.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VisibleToAllUsers. 
        /// <para>
        /// Indicates whether the cluster is visible to IAM principals in the Amazon Web Services
        /// account associated with the cluster. When <c>true</c>, IAM principals in the Amazon
        /// Web Services account can perform Amazon EMR cluster actions on the cluster that their
        /// IAM policies allow. When <c>false</c>, only the IAM principal that created the cluster
        /// and the Amazon Web Services account root user can perform Amazon EMR actions, regardless
        /// of IAM permissions policies attached to other IAM principals.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>true</c> if a value is not provided when creating a cluster
        /// using the Amazon EMR API <a>RunJobFlow</a> command, the CLI <a href="https://docs.aws.amazon.com/cli/latest/reference/emr/create-cluster.html">create-cluster</a>
        /// command, or the Amazon Web Services Management Console.
        /// </para>
        /// </summary>
        public bool? VisibleToAllUsers
        {
            get { return this._visibleToAllUsers; }
            set { this._visibleToAllUsers = value; }
        }

        // Check to see if VisibleToAllUsers property is set
        internal bool IsSetVisibleToAllUsers()
        {
            return this._visibleToAllUsers.HasValue; 
        }

    }
}