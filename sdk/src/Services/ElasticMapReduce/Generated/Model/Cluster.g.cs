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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The detailed description of the cluster.
    /// </summary>
    public partial class Cluster
    {
        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// The applications installed on this cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Application> Applications { get; set; } = AWSConfigs.InitializeCollections ? new List<Application>() : null;

        /// <summary>
        /// Checks to see if the Applications property is set.
        /// </summary>
        internal bool IsSetApplications() => this.Applications != null && (this.Applications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoScalingRole. 
        /// <para>
        /// An IAM role for automatic scaling policies. The default role is <c>EMR_AutoScaling_DefaultRole</c>.
        /// The IAM role provides permissions that the automatic scaling feature requires to launch
        /// and terminate Amazon EC2 instances in an instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string AutoScalingRole { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingRole property is set.
        /// </summary>
        internal bool IsSetAutoScalingRole() => this.AutoScalingRole != null;

        /// <summary>
        /// Gets and sets the property AutoTerminate. 
        /// <para>
        /// Specifies whether the cluster should terminate after completing all steps.
        /// </para>
        /// </summary>
        public bool? AutoTerminate { get; set; }

        /// <summary>
        /// Checks to see if the AutoTerminate property is set.
        /// </summary>
        internal bool IsSetAutoTerminate() => this.AutoTerminate.HasValue;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// Applies only to Amazon EMR releases 4.x and later. The list of configurations that
        /// are supplied to the Amazon EMR cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Configuration> Configurations { get; set; } = AWSConfigs.InitializeCollections ? new List<Configuration>() : null;

        /// <summary>
        /// Checks to see if the Configurations property is set.
        /// </summary>
        internal bool IsSetConfigurations() => this.Configurations != null && (this.Configurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomAmiId. 
        /// <para>
        /// Available only in Amazon EMR releases 5.7.0 and later. The ID of a custom Amazon EBS-backed
        /// Linux AMI if the cluster uses a custom AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string CustomAmiId { get; set; }

        /// <summary>
        /// Checks to see if the CustomAmiId property is set.
        /// </summary>
        internal bool IsSetCustomAmiId() => this.CustomAmiId != null;

        /// <summary>
        /// Gets and sets the property EbsRootVolumeIops. 
        /// <para>
        /// The IOPS, of the Amazon EBS root device volume of the Linux AMI that is used for each
        /// Amazon EC2 instance. Available in Amazon EMR releases 6.15.0 and later.
        /// </para>
        /// </summary>
        public int? EbsRootVolumeIops { get; set; }

        /// <summary>
        /// Checks to see if the EbsRootVolumeIops property is set.
        /// </summary>
        internal bool IsSetEbsRootVolumeIops() => this.EbsRootVolumeIops.HasValue;

        /// <summary>
        /// Gets and sets the property EbsRootVolumeSize. 
        /// <para>
        /// The size, in GiB, of the Amazon EBS root device volume of the Linux AMI that is used
        /// for each Amazon EC2 instance. Available in Amazon EMR releases 4.x and later.
        /// </para>
        /// </summary>
        public int? EbsRootVolumeSize { get; set; }

        /// <summary>
        /// Checks to see if the EbsRootVolumeSize property is set.
        /// </summary>
        internal bool IsSetEbsRootVolumeSize() => this.EbsRootVolumeSize.HasValue;

        /// <summary>
        /// Gets and sets the property EbsRootVolumeThroughput. 
        /// <para>
        /// The throughput, in MiB/s, of the Amazon EBS root device volume of the Linux AMI that
        /// is used for each Amazon EC2 instance. Available in Amazon EMR releases 6.15.0 and
        /// later.
        /// </para>
        /// </summary>
        public int? EbsRootVolumeThroughput { get; set; }

        /// <summary>
        /// Checks to see if the EbsRootVolumeThroughput property is set.
        /// </summary>
        internal bool IsSetEbsRootVolumeThroughput() => this.EbsRootVolumeThroughput.HasValue;

        /// <summary>
        /// Gets and sets the property Ec2InstanceAttributes. 
        /// <para>
        /// Provides information about the Amazon EC2 instances in a cluster grouped by category.
        /// For example, key name, subnet ID, IAM instance profile, and so on.
        /// </para>
        /// </summary>
        public Ec2InstanceAttributes Ec2InstanceAttributes { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceAttributes property is set.
        /// </summary>
        internal bool IsSetEc2InstanceAttributes() => this.Ec2InstanceAttributes != null;

        /// <summary>
        /// Gets and sets the property ExtendedSupport. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public bool? ExtendedSupport { get; set; }

        /// <summary>
        /// Checks to see if the ExtendedSupport property is set.
        /// </summary>
        internal bool IsSetExtendedSupport() => this.ExtendedSupport.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

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
        public InstanceCollectionType InstanceCollectionType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCollectionType property is set.
        /// </summary>
        internal bool IsSetInstanceCollectionType() => this.InstanceCollectionType != null;

        /// <summary>
        /// Gets and sets the property KerberosAttributes. 
        /// <para>
        /// Attributes for Kerberos configuration when Kerberos authentication is enabled using
        /// a security configuration. For more information see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-kerberos.html">Use
        /// Kerberos Authentication</a> in the <i>Amazon EMR Management Guide</i>.
        /// </para>
        /// </summary>
        public KerberosAttributes KerberosAttributes { get; set; }

        /// <summary>
        /// Checks to see if the KerberosAttributes property is set.
        /// </summary>
        internal bool IsSetKerberosAttributes() => this.KerberosAttributes != null;

        /// <summary>
        /// Gets and sets the property LogEncryptionKmsKeyId. 
        /// <para>
        ///  The KMS key used for encrypting log files. This attribute is only available with
        /// Amazon EMR 5.30.0 and later, excluding Amazon EMR 6.0.0. 
        /// </para>
        /// </summary>
        public string LogEncryptionKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the LogEncryptionKmsKeyId property is set.
        /// </summary>
        internal bool IsSetLogEncryptionKmsKeyId() => this.LogEncryptionKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LogUri. 
        /// <para>
        /// The path to the Amazon S3 location where logs for this cluster are stored.
        /// </para>
        /// </summary>
        public string LogUri { get; set; }

        /// <summary>
        /// Checks to see if the LogUri property is set.
        /// </summary>
        internal bool IsSetLogUri() => this.LogUri != null;

        /// <summary>
        /// Gets and sets the property MasterPublicDnsName. 
        /// <para>
        /// The DNS name of the master node. If the cluster is on a private subnet, this is the
        /// private DNS name. On a public subnet, this is the public DNS name.
        /// </para>
        /// </summary>
        public string MasterPublicDnsName { get; set; }

        /// <summary>
        /// Checks to see if the MasterPublicDnsName property is set.
        /// </summary>
        internal bool IsSetMasterPublicDnsName() => this.MasterPublicDnsName != null;

        /// <summary>
        /// Gets and sets the property MonitoringConfiguration. 
        /// <para>
        /// Contains Cloudwatch log configuration metadata and settings.
        /// </para>
        /// </summary>
        public MonitoringConfiguration MonitoringConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringConfiguration property is set.
        /// </summary>
        internal bool IsSetMonitoringConfiguration() => this.MonitoringConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cluster. This parameter can't contain the characters &lt;, >, $, |,
        /// or ` (backtick).
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        public int? NormalizedInstanceHours { get; set; }

        /// <summary>
        /// Checks to see if the NormalizedInstanceHours property is set.
        /// </summary>
        internal bool IsSetNormalizedInstanceHours() => this.NormalizedInstanceHours.HasValue;

        /// <summary>
        /// Gets and sets the property OSReleaseLabel. 
        /// <para>
        /// The Amazon Linux release specified in a cluster launch RunJobFlow request. If no Amazon
        /// Linux release was specified, the default Amazon Linux release is shown in the response.
        /// </para>
        /// </summary>
        public string OSReleaseLabel { get; set; }

        /// <summary>
        /// Checks to see if the OSReleaseLabel property is set.
        /// </summary>
        internal bool IsSetOSReleaseLabel() => this.OSReleaseLabel != null;

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Outpost where the cluster is launched. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the OutpostArn property is set.
        /// </summary>
        internal bool IsSetOutpostArn() => this.OutpostArn != null;

        /// <summary>
        /// Gets and sets the property PlacementGroups. 
        /// <para>
        /// Placement group configured for an Amazon EMR cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlacementGroupConfig> PlacementGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<PlacementGroupConfig>() : null;

        /// <summary>
        /// Checks to see if the PlacementGroups property is set.
        /// </summary>
        internal bool IsSetPlacementGroups() => this.PlacementGroups != null && (this.PlacementGroups.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public string ReleaseLabel { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseLabel property is set.
        /// </summary>
        internal bool IsSetReleaseLabel() => this.ReleaseLabel != null;

        /// <summary>
        /// Gets and sets the property RepoUpgradeOnBoot. 
        /// <para>
        /// Applies only when <c>CustomAmiID</c> is used. Specifies the type of updates that the
        /// Amazon Linux AMI package repositories apply when an instance boots using the AMI.
        /// </para>
        /// </summary>
        public RepoUpgradeOnBoot RepoUpgradeOnBoot { get; set; }

        /// <summary>
        /// Checks to see if the RepoUpgradeOnBoot property is set.
        /// </summary>
        internal bool IsSetRepoUpgradeOnBoot() => this.RepoUpgradeOnBoot != null;

        /// <summary>
        /// Gets and sets the property RequestedAmiVersion. 
        /// <para>
        /// The AMI version requested for this cluster.
        /// </para>
        /// </summary>
        public string RequestedAmiVersion { get; set; }

        /// <summary>
        /// Checks to see if the RequestedAmiVersion property is set.
        /// </summary>
        internal bool IsSetRequestedAmiVersion() => this.RequestedAmiVersion != null;

        /// <summary>
        /// Gets and sets the property RunningAmiVersion. 
        /// <para>
        /// The AMI version running on this cluster.
        /// </para>
        /// </summary>
        public string RunningAmiVersion { get; set; }

        /// <summary>
        /// Checks to see if the RunningAmiVersion property is set.
        /// </summary>
        internal bool IsSetRunningAmiVersion() => this.RunningAmiVersion != null;

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
        public ScaleDownBehavior ScaleDownBehavior { get; set; }

        /// <summary>
        /// Checks to see if the ScaleDownBehavior property is set.
        /// </summary>
        internal bool IsSetScaleDownBehavior() => this.ScaleDownBehavior != null;

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// The name of the security configuration applied to the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string SecurityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfiguration property is set.
        /// </summary>
        internal bool IsSetSecurityConfiguration() => this.SecurityConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The IAM role that Amazon EMR assumes in order to access Amazon Web Services resources
        /// on your behalf.
        /// </para>
        /// </summary>
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property SessionEnabled. 
        /// <para>
        /// Indicates whether Spark Connect sessions are enabled on the cluster.
        /// </para>
        /// </summary>
        public bool? SessionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SessionEnabled property is set.
        /// </summary>
        internal bool IsSetSessionEnabled() => this.SessionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status details about the cluster.
        /// </para>
        /// </summary>
        public ClusterStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StepConcurrencyLevel. 
        /// <para>
        /// Specifies the number of steps that can be executed concurrently.
        /// </para>
        /// </summary>
        public int? StepConcurrencyLevel { get; set; }

        /// <summary>
        /// Checks to see if the StepConcurrencyLevel property is set.
        /// </summary>
        internal bool IsSetStepConcurrencyLevel() => this.StepConcurrencyLevel.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with a cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TerminationProtected. 
        /// <para>
        /// Indicates whether Amazon EMR will lock the cluster to prevent the Amazon EC2 instances
        /// from being terminated by an API call or user intervention, or in the event of a cluster
        /// error.
        /// </para>
        /// </summary>
        public bool? TerminationProtected { get; set; }

        /// <summary>
        /// Checks to see if the TerminationProtected property is set.
        /// </summary>
        internal bool IsSetTerminationProtected() => this.TerminationProtected.HasValue;

        /// <summary>
        /// Gets and sets the property UnhealthyNodeReplacement. 
        /// <para>
        /// Indicates whether Amazon EMR should gracefully replace Amazon EC2 core instances that
        /// have degraded within the cluster.
        /// </para>
        /// </summary>
        public bool? UnhealthyNodeReplacement { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthyNodeReplacement property is set.
        /// </summary>
        internal bool IsSetUnhealthyNodeReplacement() => this.UnhealthyNodeReplacement.HasValue;

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
        public bool? VisibleToAllUsers { get; set; }

        /// <summary>
        /// Checks to see if the VisibleToAllUsers property is set.
        /// </summary>
        internal bool IsSetVisibleToAllUsers() => this.VisibleToAllUsers.HasValue;
    }
}
