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
    /// RunJobFlow creates and starts running a new job flow. The job flow will run the steps
    /// specified. Once the job flow completes, the cluster is stopped and the HDFS partition
    /// is lost. To prevent loss of data, configure the last step of the job flow to store
    /// results in Amazon S3. If the <a>JobFlowInstancesConfig</a> <code>KeepJobFlowAliveWhenNoSteps</code>
    /// parameter is set to <code>TRUE</code>, the job flow will transition to the WAITING
    /// state rather than shutting down once the steps have completed. 
    /// 
    ///  
    /// <para>
    /// For additional protection, you can set the <a>JobFlowInstancesConfig</a> <code>TerminationProtected</code>
    /// parameter to <code>TRUE</code> to lock the job flow and prevent it from being terminated
    /// by API call, user intervention, or in the event of a job flow error.
    /// </para>
    ///  
    /// <para>
    /// A maximum of 256 steps are allowed in each job flow.
    /// </para>
    ///  
    /// <para>
    /// If your job flow is long-running (such as a Hive data warehouse) or complex, you may
    /// require more than 256 steps to process your data. You can bypass the 256-step limitation
    /// in various ways, including using the SSH shell to connect to the master node and submitting
    /// queries directly to the software running on the master node, such as Hive and Hadoop.
    /// For more information on how to do this, go to <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/AddMoreThan256Steps.html">Add
    /// More than 256 Steps to a Job Flow</a> in the <i>Amazon Elastic MapReduce Developer's
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For long running job flows, we recommend that you periodically store your results.
    /// </para>
    /// </summary>
    public partial class RunJobFlowRequest : AmazonElasticMapReduceRequest
    {
        private string _additionalInfo;
        private string _amiVersion;
        private List<Application> _applications = new List<Application>();
        private List<BootstrapActionConfig> _bootstrapActions = new List<BootstrapActionConfig>();
        private List<Configuration> _configurations = new List<Configuration>();
        private JobFlowInstancesConfig _instances;
        private string _jobFlowRole;
        private string _logUri;
        private string _name;
        private List<SupportedProductConfig> _newSupportedProducts = new List<SupportedProductConfig>();
        private string _releaseLabel;
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
        /// <param name="instances">A specification of the number and type of Amazon EC2 instances on which to run the job flow.</param>
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
        /// Gets and sets the property AmiVersion. <note> 
        /// <para>
        /// For Amazon EMR releases 3.x and 2.x. For Amazon EMR releases 4.x and greater, use
        /// ReleaseLabel.
        /// </para>
        ///  </note> 
        /// <para>
        /// The version of the Amazon Machine Image (AMI) to use when launching Amazon EC2 instances
        /// in the job flow. The following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The version number of the AMI to use, for example, "2.0."
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the AMI supports multiple versions of Hadoop (for example, AMI 1.0 supports both
        /// Hadoop 0.18 and 0.20) you can use the <a>JobFlowInstancesConfig</a> <code>HadoopVersion</code>
        /// parameter to modify the version of Hadoop from the defaults shown above.
        /// </para>
        ///  
        /// <para>
        /// For details about the AMI versions currently supported by Amazon Elastic MapReduce,
        /// go to <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/EnvironmentConfig_AMIVersion.html#ami-versions-supported">AMI
        /// Versions Supported in Elastic MapReduce</a> in the <i>Amazon Elastic MapReduce Developer's
        /// Guide.</i> 
        /// </para>
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
        /// Gets and sets the property Applications. <note> 
        /// <para>
        /// Amazon EMR releases 4.x or later.
        /// </para>
        ///  </note> 
        /// <para>
        /// A list of applications for the cluster. Valid values are: "Hadoop", "Hive", "Mahout",
        /// "Pig", and "Spark." They are case insensitive.
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
        /// Gets and sets the property BootstrapActions. 
        /// <para>
        /// A list of bootstrap actions that will be run before Hadoop is started on the cluster
        /// nodes.
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
        /// Gets and sets the property Configurations. <note> 
        /// <para>
        /// Amazon EMR releases 4.x or later.
        /// </para>
        ///  </note> 
        /// <para>
        /// The list of configurations supplied for the EMR cluster you are creating.
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
        /// Gets and sets the property Instances. 
        /// <para>
        /// A specification of the number and type of Amazon EC2 instances on which to run the
        /// job flow.
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
        /// For Amazon EMR releases 3.x and 2.x. For Amazon EMR releases 4.x and greater, use
        /// Applications.
        /// </para>
        ///  </note> 
        /// <para>
        /// A list of strings that indicates third-party software to use with the job flow that
        /// accepts a user argument list. EMR accepts and forwards the argument list to the corresponding
        /// installation script as bootstrap action arguments. For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-mapr.html">Launch
        /// a Job Flow on the MapR Distribution for Hadoop</a>. Currently supported values are:
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
        /// Gets and sets the property ReleaseLabel. <note> 
        /// <para>
        /// Amazon EMR releases 4.x or later.
        /// </para>
        ///  </note> 
        /// <para>
        /// The release label for the Amazon EMR release. For Amazon EMR 3.x and 2.x AMIs, use
        /// amiVersion instead instead of ReleaseLabel.
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
        /// A list of steps to be executed by the job flow.
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
        /// For Amazon EMR releases 3.x and 2.x. For Amazon EMR releases 4.x and greater, use
        /// Applications.
        /// </para>
        ///  </note> 
        /// <para>
        /// A list of strings that indicates third-party software to use with the job flow. For
        /// more information, go to <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-supported-products.html">Use
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
        /// Whether the job flow is visible to all IAM users of the AWS account associated with
        /// the job flow. If this value is set to <code>true</code>, all IAM users of that AWS
        /// account can view and (if they have the proper policy permissions set) manage the job
        /// flow. If it is set to <code>false</code>, only the IAM user that created the job flow
        /// can view and manage it.
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