/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// For more information on how to do this, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/Management/Guide/AddMoreThan256Steps.html">Add
    /// More than 256 Steps to a Cluster</a> in the <i>Amazon EMR Management Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For long running clusters, we recommend that you periodically store your results.
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
        private List<BootstrapActionConfig> _bootstrapActions = new List<BootstrapActionConfig>();
        private List<Configuration> _configurations = new List<Configuration>();
        private string _customAmiId;
        private int? _ebsRootVolumeSize;
        private JobFlowInstancesConfig _instances;
        private string _jobFlowRole;
        private string _logUri;
        private string _name;
        private List<SupportedProductConfig> _newSupportedProducts = new List<SupportedProductConfig>();
        private string _releaseLabel;
        private RepoUpgradeOnBoot _repoUpgradeOnBoot;
        private ScaleDownBehavior _scaleDownBehavior;
        private string _securityConfiguration;
        private string _serviceRole;
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
        /// For Amazon EMR AMI versions 3.x and 2.x. For Amazon EMR releases 4.0 and later, the
        /// Linux AMI is determined by the <code>ReleaseLabel</code> specified or by <code>CustomAmiID</code>.
        /// The version of the Amazon Machine Image (AMI) to use when launching Amazon EC2 instances
        /// in the job flow. For details about the AMI versions currently supported in EMR version
        /// 3.x and 2.x, see <a href="ElasticMapReduce/latest/DeveloperGuide/emr-dg.pdf#nameddest=ami-versions-supported">AMI
        /// Versions Supported in EMR</a> in the <i>Amazon EMR Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// If the AMI supports multiple versions of Hadoop (for example, AMI 1.0 supports both
        /// Hadoop 0.18 and 0.20), you can use the <a>JobFlowInstancesConfig</a> <code>HadoopVersion</code>
        /// parameter to modify the version of Hadoop from the defaults shown above.
        /// </para>
        ///  <note> 
        /// <para>
        /// Previously, the EMR AMI version API parameter options allowed you to use latest for
        /// the latest AMI version rather than specify a numerical value. Some regions no longer
        /// support this deprecated option as they only have a newer release label version of
        /// EMR, which requires you to specify an EMR release label release (EMR 4.x or later).
        /// </para>
        ///  </note>
        /// </summary>
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
        /// For Amazon EMR releases 4.0 and later. A list of applications for the cluster. Valid
        /// values are: "Hadoop", "Hive", "Mahout", "Pig", and "Spark." They are case insensitive.
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
        /// For more information about custom AMIs in Amazon EMR, see <a href="http://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-custom-ami.html">Using
        /// a Custom AMI</a> in the <i>Amazon EMR Management Guide</i>. If omitted, the cluster
        /// uses the base Linux AMI for the <code>ReleaseLabel</code> specified. For Amazon EMR
        /// versions 2.x and 3.x, use <code>AmiVersion</code> instead.
        /// </para>
        ///  
        /// <para>
        /// For information about creating a custom AMI, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html">Creating
        /// an Amazon EBS-Backed Linux AMI</a> in the <i>Amazon Elastic Compute Cloud User Guide
        /// for Linux Instances</i>. For information about finding an AMI ID, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/finding-an-ami.html">Finding
        /// a Linux AMI</a>. 
        /// </para>
        /// </summary>
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
        /// The size, in GiB, of the EBS root device volume of the Linux AMI that is used for
        /// each EC2 instance. Available in Amazon EMR version 4.x and later.
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
        /// Gets and sets the property LogUri. 
        /// <para>
        /// The location in Amazon S3 to write the log files of the job flow. If a value is not
        /// provided, logs are not created.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the job flow.
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
        /// Gets and sets the property NewSupportedProducts. <note> 
        /// <para>
        /// For Amazon EMR releases 3.x and 2.x. For Amazon EMR releases 4.x and later, use Applications.
        /// </para>
        ///  </note> 
        /// <para>
        /// A list of strings that indicates third-party software to use with the job flow that
        /// accepts a user argument list. EMR accepts and forwards the argument list to the corresponding
        /// installation script as bootstrap action arguments. For more information, see "Launch
        /// a Job Flow on the MapR Distribution for Hadoop" in the <a href="http://docs.aws.amazon.com/http:/docs.aws.amazon.com/emr/latest/DeveloperGuide/emr-dg.pdf">Amazon
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
        /// "hunk" - launch the cluster with the Hunk Big Data Analtics Platform.
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
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        ///  The release label for the Amazon EMR release. For Amazon EMR 3.x and 2.x AMIs, use
        /// <code>AmiVersion</code> instead.
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
        /// version. <code>TERMINATE_AT_TASK_COMPLETION</code> indicates that Amazon EMR blacklists
        /// and drains tasks from nodes before terminating the Amazon EC2 instances, regardless
        /// of the instance-hour boundary. With either behavior, Amazon EMR removes the least
        /// active nodes first and blocks instance termination if it could lead to HDFS corruption.
        /// <code>TERMINATE_AT_TASK_COMPLETION</code> available only in Amazon EMR version 4.1.0
        /// and later, and is the default for versions of Amazon EMR earlier than 5.1.0.
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
        /// The IAM role that will be assumed by the Amazon EMR service to access AWS resources
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
        /// see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-supported-products.html">Use
        /// Third Party Applications with Amazon EMR</a>. Currently supported values are:
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
        /// Gets and sets the property VisibleToAllUsers. 
        /// <para>
        /// Whether the cluster is visible to all IAM users of the AWS account associated with
        /// the cluster. If this value is set to <code>true</code>, all IAM users of that AWS
        /// account can view and (if they have the proper policy permissions set) manage the cluster.
        /// If it is set to <code>false</code>, only the IAM user that created the cluster can
        /// view and manage it.
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