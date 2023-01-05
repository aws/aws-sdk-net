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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the RunJobFlow operation.
    /// RunJobFlow creates and starts running a new cluster (job flow). The cluster runs the
    /// steps specified. After the steps complete, the cluster stops and the HDFS partition
    /// is lost. To prevent loss of data, configure the last step of the job flow to store
    /// results in Amazon S3. If the <a>JobFlowInstancesConfig</a> <code>KeepJobFlowAliveWhenNoSteps</code>
    /// parameter is set to <code>TRUE</code>, the cluster transitions to the WAITING state
    /// rather than shutting down after the steps have completed. 
    /// 
    ///  
    /// <para>
    /// For additional protection, you can set the <a>JobFlowInstancesConfig</a> <code>TerminationProtected</code>
    /// parameter to <code>TRUE</code> to lock the cluster and prevent it from being terminated
    /// by API call, user intervention, or in the event of a job flow error.
    /// </para>
    ///  
    /// <para>
    /// A maximum of 256 steps are allowed in each job flow.
    /// </para>
    ///  
    /// <para>
    /// If your cluster is long-running (such as a Hive data warehouse) or complex, you may
    /// require more than 256 steps to process your data. You can bypass the 256-step limitation
    /// in various ways, including using the SSH shell to connect to the master node and submitting
    /// queries directly to the software running on the master node, such as Hive and Hadoop.
    /// </para>
    ///  
    /// <para>
    /// For long-running clusters, we recommend that you periodically store your results.
    /// </para>
    ///  <note> 
    /// <para>
    /// The instance fleets configuration is available only in Amazon EMR versions 4.8.0 and
    /// later, excluding 5.0.x versions. The RunJobFlow request can contain InstanceFleets
    /// parameters or InstanceGroups parameters, but not both.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RunJobFlowRequest : AmazonElasticMapReduceRequest
    {
        private string _additionalInfo;
        private string _amiVersion;
        private List<Application> _applications = new List<Application>();
        private string _autoScalingRole;
        private AutoTerminationPolicy _autoTerminationPolicy;
        private List<BootstrapActionConfig> _bootstrapActions = new List<BootstrapActionConfig>();
        private List<Configuration> _configurations = new List<Configuration>();
        private string _customAmiId;
        private int? _ebsRootVolumeSize;
        private JobFlowInstancesConfig _instances;
        private string _jobFlowRole;
        private KerberosAttributes _kerberosAttributes;
        private string _logEncryptionKmsKeyId;
        private string _logUri;
        private ManagedScalingPolicy _managedScalingPolicy;
        private string _name;
        private List<SupportedProductConfig> _newSupportedProducts = new List<SupportedProductConfig>();
        private string _osReleaseLabel;
        private List<PlacementGroupConfig> _placementGroupConfigs = new List<PlacementGroupConfig>();
        private string _releaseLabel;
        private RepoUpgradeOnBoot _repoUpgradeOnBoot;
        private ScaleDownBehavior _scaleDownBehavior;
        private string _securityConfiguration;
        private string _serviceRole;
        private int? _stepConcurrencyLevel;
        private List<StepConfig> _steps = new List<StepConfig>();
        private List<string> _supportedProducts = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private bool? _visibleToAllUsers;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RunJobFlowRequest() { }

        /// <summary>
        /// Instantiates RunJobFlowRequest with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the job flow.</param>
        /// <param name="instances">A specification of the number and type of Amazon EC2 instances.</param>
        public RunJobFlowRequest(string name, JobFlowInstancesConfig instances)
        {
            _name = name;
            _instances = instances;
        }

        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// A JSON string for selecting additional features.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string AdditionalInfo
        {
            get { return this._additionalInfo; }
            set { this._additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this._additionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property AmiVersion. 
        /// <para>
        /// Applies only to Amazon EMR AMI versions 3.x and 2.x. For Amazon EMR releases 4.0 and
        /// later, <code>ReleaseLabel</code> is used. To specify a custom AMI, use <code>CustomAmiID</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string AmiVersion
        {
            get { return this._amiVersion; }
            set { this._amiVersion = value; }
        }

        // Check to see if AmiVersion property is set
        internal bool IsSetAmiVersion()
        {
            return this._amiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// Applies to Amazon EMR releases 4.0 and later. A case-insensitive list of applications
        /// for Amazon EMR to install and configure when launching the cluster. For a list of
        /// applications available for each Amazon EMR release version, see the <a href="https://docs.aws.amazon.com/emr/latest/ReleaseGuide/">Amazon
        /// EMRRelease Guide</a>.
        /// </para>
        /// </summary>
        public List<Application> Applications
        {
            get { return this._applications; }
            set { this._applications = value; }
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this._applications != null && this._applications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AutoScalingRole. 
        /// <para>
        /// An IAM role for automatic scaling policies. The default role is <code>EMR_AutoScaling_DefaultRole</code>.
        /// The IAM role provides permissions that the automatic scaling feature requires to launch
        /// and terminate EC2 instances in an instance group.
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
        /// Gets and sets the property AutoTerminationPolicy.
        /// </summary>
        public AutoTerminationPolicy AutoTerminationPolicy
        {
            get { return this._autoTerminationPolicy; }
            set { this._autoTerminationPolicy = value; }
        }

        // Check to see if AutoTerminationPolicy property is set
        internal bool IsSetAutoTerminationPolicy()
        {
            return this._autoTerminationPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property BootstrapActions. 
        /// <para>
        /// A list of bootstrap actions to run before Hadoop starts on the cluster nodes.
        /// </para>
        /// </summary>
        public List<BootstrapActionConfig> BootstrapActions
        {
            get { return this._bootstrapActions; }
            set { this._bootstrapActions = value; }
        }

        // Check to see if BootstrapActions property is set
        internal bool IsSetBootstrapActions()
        {
            return this._bootstrapActions != null && this._bootstrapActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// For Amazon EMR releases 4.0 and later. The list of configurations supplied for the
        /// EMR cluster you are creating.
        /// </para>
        /// </summary>
        public List<Configuration> Configurations
        {
            get { return this._configurations; }
            set { this._configurations = value; }
        }

        // Check to see if Configurations property is set
        internal bool IsSetConfigurations()
        {
            return this._configurations != null && this._configurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CustomAmiId. 
        /// <para>
        /// Available only in Amazon EMR version 5.7.0 and later. The ID of a custom Amazon EBS-backed
        /// Linux AMI. If specified, Amazon EMR uses this AMI when it launches cluster EC2 instances.
        /// For more information about custom AMIs in Amazon EMR, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-custom-ami.html">Using
        /// a Custom AMI</a> in the <i>Amazon EMR Management Guide</i>. If omitted, the cluster
        /// uses the base Linux AMI for the <code>ReleaseLabel</code> specified. For Amazon EMR
        /// versions 2.x and 3.x, use <code>AmiVersion</code> instead.
        /// </para>
        ///  
        /// <para>
        /// For information about creating a custom AMI, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html">Creating
        /// an Amazon EBS-Backed Linux AMI</a> in the <i>Amazon Elastic Compute Cloud User Guide
        /// for Linux Instances</i>. For information about finding an AMI ID, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/finding-an-ami.html">Finding
        /// a Linux AMI</a>. 
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
        /// Gets and sets the property EbsRootVolumeSize. 
        /// <para>
        /// The size, in GiB, of the Amazon EBS root device volume of the Linux AMI that is used
        /// for each EC2 instance. Available in Amazon EMR version 4.x and later.
        /// </para>
        /// </summary>
        public int EbsRootVolumeSize
        {
            get { return this._ebsRootVolumeSize.GetValueOrDefault(); }
            set { this._ebsRootVolumeSize = value; }
        }

        // Check to see if EbsRootVolumeSize property is set
        internal bool IsSetEbsRootVolumeSize()
        {
            return this._ebsRootVolumeSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// A specification of the number and type of Amazon EC2 instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobFlowInstancesConfig Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null;
        }

        /// <summary>
        /// Gets and sets the property JobFlowRole. 
        /// <para>
        /// Also called instance profile and EC2 role. An IAM role for an EMR cluster. The EC2
        /// instances of the cluster assume this role. The default role is <code>EMR_EC2_DefaultRole</code>.
        /// In order to use the default role, you must have already created it using the CLI or
        /// console.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string JobFlowRole
        {
            get { return this._jobFlowRole; }
            set { this._jobFlowRole = value; }
        }

        // Check to see if JobFlowRole property is set
        internal bool IsSetJobFlowRole()
        {
            return this._jobFlowRole != null;
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
        /// The KMS key used for encrypting log files. If a value is not provided, the logs remain
        /// encrypted by AES-256. This attribute is only available with Amazon EMR version 5.30.0
        /// and later, excluding Amazon EMR 6.0.0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
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
        /// The location in Amazon S3 to write the log files of the job flow. If a value is not
        /// provided, logs are not created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
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
        /// Gets and sets the property ManagedScalingPolicy. 
        /// <para>
        ///  The specified managed scaling policy for an Amazon EMR cluster. 
        /// </para>
        /// </summary>
        public ManagedScalingPolicy ManagedScalingPolicy
        {
            get { return this._managedScalingPolicy; }
            set { this._managedScalingPolicy = value; }
        }

        // Check to see if ManagedScalingPolicy property is set
        internal bool IsSetManagedScalingPolicy()
        {
            return this._managedScalingPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the job flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// Gets and sets the property NewSupportedProducts. <note> 
        /// <para>
        /// For Amazon EMR releases 3.x and 2.x. For Amazon EMR releases 4.x and later, use Applications.
        /// </para>
        ///  </note> 
        /// <para>
        /// A list of strings that indicates third-party software to use with the job flow that
        /// accepts a user argument list. EMR accepts and forwards the argument list to the corresponding
        /// installation script as bootstrap action arguments. For more information, see "Launch
        /// a Job Flow on the MapR Distribution for Hadoop" in the <a href="https://docs.aws.amazon.com/emr/latest/DeveloperGuide/emr-dg.pdf">Amazon
        /// EMR Developer Guide</a>. Supported values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// "mapr-m3" - launch the cluster using MapR M3 Edition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "mapr-m5" - launch the cluster using MapR M5 Edition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "mapr" with the user arguments specifying "--edition,m3" or "--edition,m5" - launch
        /// the job flow using MapR M3 or M5 Edition respectively.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "mapr-m7" - launch the cluster using MapR M7 Edition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "hunk" - launch the cluster with the Hunk Big Data Analytics Platform.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "hue"- launch the cluster with Hue installed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "spark" - launch the cluster with Apache Spark installed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "ganglia" - launch the cluster with the Ganglia Monitoring System installed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<SupportedProductConfig> NewSupportedProducts
        {
            get { return this._newSupportedProducts; }
            set { this._newSupportedProducts = value; }
        }

        // Check to see if NewSupportedProducts property is set
        internal bool IsSetNewSupportedProducts()
        {
            return this._newSupportedProducts != null && this._newSupportedProducts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OSReleaseLabel. 
        /// <para>
        /// Specifies a particular Amazon Linux release for all nodes in a cluster launch RunJobFlow
        /// request. If a release is not specified, Amazon EMR uses the latest validated Amazon
        /// Linux release for cluster launch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property PlacementGroupConfigs. 
        /// <para>
        /// The specified placement group configuration for an Amazon EMR cluster.
        /// </para>
        /// </summary>
        public List<PlacementGroupConfig> PlacementGroupConfigs
        {
            get { return this._placementGroupConfigs; }
            set { this._placementGroupConfigs = value; }
        }

        // Check to see if PlacementGroupConfigs property is set
        internal bool IsSetPlacementGroupConfigs()
        {
            return this._placementGroupConfigs != null && this._placementGroupConfigs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The Amazon EMR release label, which determines the version of open-source application
        /// packages installed on the cluster. Release labels are in the form <code>emr-x.x.x</code>,
        /// where x.x.x is an Amazon EMR release version such as <code>emr-5.14.0</code>. For
        /// more information about Amazon EMR release versions and included application versions
        /// and features, see <a href="https://docs.aws.amazon.com/emr/latest/ReleaseGuide/">https://docs.aws.amazon.com/emr/latest/ReleaseGuide/</a>.
        /// The release label applies only to Amazon EMR releases version 4.0 and later. Earlier
        /// versions use <code>AmiVersion</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Applies only when <code>CustomAmiID</code> is used. Specifies which updates from the
        /// Amazon Linux AMI package repositories to apply automatically when the instance boots
        /// using the AMI. If omitted, the default is <code>SECURITY</code>, which indicates that
        /// only security updates are applied. If <code>NONE</code> is specified, no updates are
        /// applied, and all updates must be applied manually.
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
        /// Gets and sets the property ScaleDownBehavior. 
        /// <para>
        /// Specifies the way that individual Amazon EC2 instances terminate when an automatic
        /// scale-in activity occurs or an instance group is resized. <code>TERMINATE_AT_INSTANCE_HOUR</code>
        /// indicates that Amazon EMR terminates nodes at the instance-hour boundary, regardless
        /// of when the request to terminate the instance was submitted. This option is only available
        /// with Amazon EMR 5.1.0 and later and is the default for clusters created using that
        /// version. <code>TERMINATE_AT_TASK_COMPLETION</code> indicates that Amazon EMR adds
        /// nodes to a deny list and drains tasks from nodes before terminating the Amazon EC2
        /// instances, regardless of the instance-hour boundary. With either behavior, Amazon
        /// EMR removes the least active nodes first and blocks instance termination if it could
        /// lead to HDFS corruption. <code>TERMINATE_AT_TASK_COMPLETION</code> available only
        /// in Amazon EMR version 4.1.0 and later, and is the default for versions of Amazon EMR
        /// earlier than 5.1.0.
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
        /// The name of a security configuration to apply to the cluster.
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
        /// on your behalf. If you've created a custom service role path, you must specify it
        /// for the service role when you launch your cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
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
        /// Gets and sets the property StepConcurrencyLevel. 
        /// <para>
        /// Specifies the number of steps that can be executed concurrently. The default value
        /// is <code>1</code>. The maximum value is <code>256</code>.
        /// </para>
        /// </summary>
        public int StepConcurrencyLevel
        {
            get { return this._stepConcurrencyLevel.GetValueOrDefault(); }
            set { this._stepConcurrencyLevel = value; }
        }

        // Check to see if StepConcurrencyLevel property is set
        internal bool IsSetStepConcurrencyLevel()
        {
            return this._stepConcurrencyLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// A list of steps to run.
        /// </para>
        /// </summary>
        public List<StepConfig> Steps
        {
            get { return this._steps; }
            set { this._steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this._steps != null && this._steps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedProducts. <note> 
        /// <para>
        /// For Amazon EMR releases 3.x and 2.x. For Amazon EMR releases 4.x and later, use Applications.
        /// </para>
        ///  </note> 
        /// <para>
        /// A list of strings that indicates third-party software to use. For more information,
        /// see the <a href="https://docs.aws.amazon.com/emr/latest/DeveloperGuide/emr-dg.pdf">Amazon
        /// EMR Developer Guide</a>. Currently supported values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// "mapr-m3" - launch the job flow using MapR M3 Edition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "mapr-m5" - launch the job flow using MapR M5 Edition.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> SupportedProducts
        {
            get { return this._supportedProducts; }
            set { this._supportedProducts = value; }
        }

        // Check to see if SupportedProducts property is set
        internal bool IsSetSupportedProducts()
        {
            return this._supportedProducts != null && this._supportedProducts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with a cluster and propagate to Amazon EC2 instances.
        /// </para>
        /// </summary>
        public List<Tag> Tags
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
        /// Gets and sets the property VisibleToAllUsers. <important> 
        /// <para>
        /// The VisibleToAllUsers parameter is no longer supported. By default, the value is set
        /// to <code>true</code>. Setting it to <code>false</code> now has no effect.
        /// </para>
        ///  </important> 
        /// <para>
        /// Set this value to <code>true</code> so that IAM principals in the Amazon Web Services
        /// account associated with the cluster can perform EMR actions on the cluster that their
        /// IAM policies allow. This value defaults to <code>true</code> for clusters created
        /// using the EMR API or the CLI <a href="https://docs.aws.amazon.com/cli/latest/reference/emr/create-cluster.html">create-cluster</a>
        /// command.
        /// </para>
        ///  
        /// <para>
        /// When set to <code>false</code>, only the IAM principal that created the cluster and
        /// the Amazon Web Services account root user can perform EMR actions for the cluster,
        /// regardless of the IAM permissions policies attached to other IAM principals. For more
        /// information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/security_iam_emr-with-iam.html#security_set_visible_to_all_users">Understanding
        /// the EMR Cluster VisibleToAllUsers Setting</a> in the <i>Amazon EMRManagement Guide</i>.
        /// </para>
        /// </summary>
        public bool VisibleToAllUsers
        {
            get { return this._visibleToAllUsers.GetValueOrDefault(); }
            set { this._visibleToAllUsers = value; }
        }

        // Check to see if VisibleToAllUsers property is set
        internal bool IsSetVisibleToAllUsers()
        {
            return this._visibleToAllUsers.HasValue; 
        }

    }
}