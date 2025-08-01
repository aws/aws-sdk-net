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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
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
namespace Amazon.MWAA.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEnvironment operation.
    /// Updates an Amazon Managed Workflows for Apache Airflow (MWAA) environment.
    /// </summary>
    public partial class UpdateEnvironmentRequest : AmazonMWAARequest
    {
        private Dictionary<string, string> _airflowConfigurationOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _airflowVersion;
        private string _dagS3Path;
        private string _environmentClass;
        private string _executionRoleArn;
        private LoggingConfigurationInput _loggingConfiguration;
        private int? _maxWebservers;
        private int? _maxWorkers;
        private int? _minWebservers;
        private int? _minWorkers;
        private string _name;
        private UpdateNetworkConfigurationInput _networkConfiguration;
        private string _pluginsS3ObjectVersion;
        private string _pluginsS3Path;
        private string _requirementsS3ObjectVersion;
        private string _requirementsS3Path;
        private int? _schedulers;
        private string _sourceBucketArn;
        private string _startupScriptS3ObjectVersion;
        private string _startupScriptS3Path;
        private WebserverAccessMode _webserverAccessMode;
        private string _weeklyMaintenanceWindowStart;
        private WorkerReplacementStrategy _workerReplacementStrategy;

        /// <summary>
        /// Gets and sets the property AirflowConfigurationOptions. 
        /// <para>
        /// A list of key-value pairs containing the Apache Airflow configuration options you
        /// want to attach to your environment. For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-env-variables.html">Apache
        /// Airflow configuration options</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> AirflowConfigurationOptions
        {
            get { return this._airflowConfigurationOptions; }
            set { this._airflowConfigurationOptions = value; }
        }

        // Check to see if AirflowConfigurationOptions property is set
        internal bool IsSetAirflowConfigurationOptions()
        {
            return this._airflowConfigurationOptions != null && (this._airflowConfigurationOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AirflowVersion. 
        /// <para>
        /// The Apache Airflow version for your environment. To upgrade your environment, specify
        /// a newer version of Apache Airflow supported by Amazon MWAA.
        /// </para>
        ///  
        /// <para>
        /// Before you upgrade an environment, make sure your requirements, DAGs, plugins, and
        /// other resources used in your workflows are compatible with the new Apache Airflow
        /// version. For more information about updating your resources, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/upgrading-environment.html">Upgrading
        /// an Amazon MWAA environment</a>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>1.10.12</c>, <c>2.0.2</c>, <c>2.2.2</c>, <c>2.4.3</c>, <c>2.5.1</c>,
        /// <c>2.6.3</c>, <c>2.7.2</c>, <c>2.8.1</c>, <c>2.9.2</c>, <c>2.10.1</c>, and <c>2.10.3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string AirflowVersion
        {
            get { return this._airflowVersion; }
            set { this._airflowVersion = value; }
        }

        // Check to see if AirflowVersion property is set
        internal bool IsSetAirflowVersion()
        {
            return this._airflowVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DagS3Path. 
        /// <para>
        /// The relative path to the DAGs folder on your Amazon S3 bucket. For example, <c>dags</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-dag-folder.html">Adding
        /// or updating DAGs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string DagS3Path
        {
            get { return this._dagS3Path; }
            set { this._dagS3Path = value; }
        }

        // Check to see if DagS3Path property is set
        internal bool IsSetDagS3Path()
        {
            return this._dagS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentClass. 
        /// <para>
        /// The environment class type. Valid values: <c>mw1.micro</c>, <c>mw1.small</c>, <c>mw1.medium</c>,
        /// <c>mw1.large</c>, <c>mw1.xlarge</c>, and <c>mw1.2xlarge</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/environment-class.html">Amazon
        /// MWAA environment class</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string EnvironmentClass
        {
            get { return this._environmentClass; }
            set { this._environmentClass = value; }
        }

        // Check to see if EnvironmentClass property is set
        internal bool IsSetEnvironmentClass()
        {
            return this._environmentClass != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the execution role in IAM that allows MWAA to access
        /// Amazon Web Services resources in your environment. For example, <c>arn:aws:iam::123456789:role/my-execution-role</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/mwaa-create-role.html">Amazon
        /// MWAA Execution role</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The Apache Airflow log types to send to CloudWatch Logs.
        /// </para>
        /// </summary>
        public LoggingConfigurationInput LoggingConfiguration
        {
            get { return this._loggingConfiguration; }
            set { this._loggingConfiguration = value; }
        }

        // Check to see if LoggingConfiguration property is set
        internal bool IsSetLoggingConfiguration()
        {
            return this._loggingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MaxWebservers. 
        /// <para>
        ///  The maximum number of web servers that you want to run in your environment. Amazon
        /// MWAA scales the number of Apache Airflow web servers up to the number you specify
        /// for <c>MaxWebservers</c> when you interact with your Apache Airflow environment using
        /// Apache Airflow REST API, or the Apache Airflow CLI. For example, in scenarios where
        /// your workload requires network calls to the Apache Airflow REST API with a high transaction-per-second
        /// (TPS) rate, Amazon MWAA will increase the number of web servers up to the number set
        /// in <c>MaxWebserers</c>. As TPS rates decrease Amazon MWAA disposes of the additional
        /// web servers, and scales down to the number set in <c>MinxWebserers</c>. 
        /// </para>
        ///  
        /// <para>
        /// Valid values: For environments larger than mw1.micro, accepts values from <c>2</c>
        /// to <c>5</c>. Defaults to <c>2</c> for all environment sizes except mw1.micro, which
        /// defaults to <c>1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxWebservers
        {
            get { return this._maxWebservers; }
            set { this._maxWebservers = value; }
        }

        // Check to see if MaxWebservers property is set
        internal bool IsSetMaxWebservers()
        {
            return this._maxWebservers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxWorkers. 
        /// <para>
        /// The maximum number of workers that you want to run in your environment. MWAA scales
        /// the number of Apache Airflow workers up to the number you specify in the <c>MaxWorkers</c>
        /// field. For example, <c>20</c>. When there are no more tasks running, and no more in
        /// the queue, MWAA disposes of the extra workers leaving the one worker that is included
        /// with your environment, or the number you specify in <c>MinWorkers</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxWorkers
        {
            get { return this._maxWorkers; }
            set { this._maxWorkers = value; }
        }

        // Check to see if MaxWorkers property is set
        internal bool IsSetMaxWorkers()
        {
            return this._maxWorkers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinWebservers. 
        /// <para>
        ///  The minimum number of web servers that you want to run in your environment. Amazon
        /// MWAA scales the number of Apache Airflow web servers up to the number you specify
        /// for <c>MaxWebservers</c> when you interact with your Apache Airflow environment using
        /// Apache Airflow REST API, or the Apache Airflow CLI. As the transaction-per-second
        /// rate, and the network load, decrease, Amazon MWAA disposes of the additional web servers,
        /// and scales down to the number set in <c>MinxWebserers</c>. 
        /// </para>
        ///  
        /// <para>
        /// Valid values: For environments larger than mw1.micro, accepts values from <c>2</c>
        /// to <c>5</c>. Defaults to <c>2</c> for all environment sizes except mw1.micro, which
        /// defaults to <c>1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MinWebservers
        {
            get { return this._minWebservers; }
            set { this._minWebservers = value; }
        }

        // Check to see if MinWebservers property is set
        internal bool IsSetMinWebservers()
        {
            return this._minWebservers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinWorkers. 
        /// <para>
        /// The minimum number of workers that you want to run in your environment. MWAA scales
        /// the number of Apache Airflow workers up to the number you specify in the <c>MaxWorkers</c>
        /// field. When there are no more tasks running, and no more in the queue, MWAA disposes
        /// of the extra workers leaving the worker count you specify in the <c>MinWorkers</c>
        /// field. For example, <c>2</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MinWorkers
        {
            get { return this._minWorkers; }
            set { this._minWorkers = value; }
        }

        // Check to see if MinWorkers property is set
        internal bool IsSetMinWorkers()
        {
            return this._minWorkers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of your Amazon MWAA environment. For example, <c>MyMWAAEnvironment</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
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
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The VPC networking components used to secure and enable network traffic between the
        /// Amazon Web Services resources for your environment. For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/networking-about.html">About
        /// networking on Amazon MWAA</a>.
        /// </para>
        /// </summary>
        public UpdateNetworkConfigurationInput NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PluginsS3ObjectVersion. 
        /// <para>
        /// The version of the plugins.zip file on your Amazon S3 bucket. You must specify a version
        /// each time a <c>plugins.zip</c> file is updated. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/versioning-workflows.html">How
        /// S3 Versioning works</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PluginsS3ObjectVersion
        {
            get { return this._pluginsS3ObjectVersion; }
            set { this._pluginsS3ObjectVersion = value; }
        }

        // Check to see if PluginsS3ObjectVersion property is set
        internal bool IsSetPluginsS3ObjectVersion()
        {
            return this._pluginsS3ObjectVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PluginsS3Path. 
        /// <para>
        /// The relative path to the <c>plugins.zip</c> file on your Amazon S3 bucket. For example,
        /// <c>plugins.zip</c>. If specified, then the plugins.zip version is required. For more
        /// information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-dag-import-plugins.html">Installing
        /// custom plugins</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PluginsS3Path
        {
            get { return this._pluginsS3Path; }
            set { this._pluginsS3Path = value; }
        }

        // Check to see if PluginsS3Path property is set
        internal bool IsSetPluginsS3Path()
        {
            return this._pluginsS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property RequirementsS3ObjectVersion. 
        /// <para>
        /// The version of the requirements.txt file on your Amazon S3 bucket. You must specify
        /// a version each time a <c>requirements.txt</c> file is updated. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/versioning-workflows.html">How
        /// S3 Versioning works</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RequirementsS3ObjectVersion
        {
            get { return this._requirementsS3ObjectVersion; }
            set { this._requirementsS3ObjectVersion = value; }
        }

        // Check to see if RequirementsS3ObjectVersion property is set
        internal bool IsSetRequirementsS3ObjectVersion()
        {
            return this._requirementsS3ObjectVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RequirementsS3Path. 
        /// <para>
        /// The relative path to the <c>requirements.txt</c> file on your Amazon S3 bucket. For
        /// example, <c>requirements.txt</c>. If specified, then a file version is required. For
        /// more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/working-dags-dependencies.html">Installing
        /// Python dependencies</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RequirementsS3Path
        {
            get { return this._requirementsS3Path; }
            set { this._requirementsS3Path = value; }
        }

        // Check to see if RequirementsS3Path property is set
        internal bool IsSetRequirementsS3Path()
        {
            return this._requirementsS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property Schedulers. 
        /// <para>
        /// The number of Apache Airflow schedulers to run in your Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public int? Schedulers
        {
            get { return this._schedulers; }
            set { this._schedulers = value; }
        }

        // Check to see if Schedulers property is set
        internal bool IsSetSchedulers()
        {
            return this._schedulers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceBucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket where your DAG code and supporting
        /// files are stored. For example, <c>arn:aws:s3:::my-airflow-bucket-unique-name</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/mwaa-s3-bucket.html">Create
        /// an Amazon S3 bucket for Amazon MWAA</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string SourceBucketArn
        {
            get { return this._sourceBucketArn; }
            set { this._sourceBucketArn = value; }
        }

        // Check to see if SourceBucketArn property is set
        internal bool IsSetSourceBucketArn()
        {
            return this._sourceBucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartupScriptS3ObjectVersion. 
        /// <para>
        ///  The version of the startup shell script in your Amazon S3 bucket. You must specify
        /// the <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/versioning-workflows.html">version
        /// ID</a> that Amazon S3 assigns to the file every time you update the script. 
        /// </para>
        ///  
        /// <para>
        ///  Version IDs are Unicode, UTF-8 encoded, URL-ready, opaque strings that are no more
        /// than 1,024 bytes long. The following is an example: 
        /// </para>
        ///  
        /// <para>
        ///  <c>3sL4kqtJlcpXroDTDmJ+rmSpXd3dIbrHY+MTRCxf3vjVBH40Nr8X8gdRQBpUMLUo</c> 
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/using-startup-script.html">Using
        /// a startup script</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StartupScriptS3ObjectVersion
        {
            get { return this._startupScriptS3ObjectVersion; }
            set { this._startupScriptS3ObjectVersion = value; }
        }

        // Check to see if StartupScriptS3ObjectVersion property is set
        internal bool IsSetStartupScriptS3ObjectVersion()
        {
            return this._startupScriptS3ObjectVersion != null;
        }

        /// <summary>
        /// Gets and sets the property StartupScriptS3Path. 
        /// <para>
        /// The relative path to the startup shell script in your Amazon S3 bucket. For example,
        /// <c>s3://mwaa-environment/startup.sh</c>.
        /// </para>
        ///  
        /// <para>
        ///  Amazon MWAA runs the script as your environment starts, and before running the Apache
        /// Airflow process. You can use this script to install dependencies, modify Apache Airflow
        /// configuration options, and set environment variables. For more information, see <a
        /// href="https://docs.aws.amazon.com/mwaa/latest/userguide/using-startup-script.html">Using
        /// a startup script</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StartupScriptS3Path
        {
            get { return this._startupScriptS3Path; }
            set { this._startupScriptS3Path = value; }
        }

        // Check to see if StartupScriptS3Path property is set
        internal bool IsSetStartupScriptS3Path()
        {
            return this._startupScriptS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property WebserverAccessMode. 
        /// <para>
        /// The Apache Airflow <i>Web server</i> access mode. For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-networking.html">Apache
        /// Airflow access modes</a>.
        /// </para>
        /// </summary>
        public WebserverAccessMode WebserverAccessMode
        {
            get { return this._webserverAccessMode; }
            set { this._webserverAccessMode = value; }
        }

        // Check to see if WebserverAccessMode property is set
        internal bool IsSetWebserverAccessMode()
        {
            return this._webserverAccessMode != null;
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceWindowStart. 
        /// <para>
        /// The day and time of the week in Coordinated Universal Time (UTC) 24-hour standard
        /// time to start weekly maintenance updates of your environment in the following format:
        /// <c>DAY:HH:MM</c>. For example: <c>TUE:03:30</c>. You can specify a start time in 30
        /// minute increments only.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=9)]
        public string WeeklyMaintenanceWindowStart
        {
            get { return this._weeklyMaintenanceWindowStart; }
            set { this._weeklyMaintenanceWindowStart = value; }
        }

        // Check to see if WeeklyMaintenanceWindowStart property is set
        internal bool IsSetWeeklyMaintenanceWindowStart()
        {
            return this._weeklyMaintenanceWindowStart != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerReplacementStrategy. 
        /// <para>
        /// The worker replacement strategy to use when updating the environment.
        /// </para>
        ///  
        /// <para>
        /// You can select one of the following strategies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Forced -</b> Stops and replaces Apache Airflow workers without waiting for tasks
        /// to complete before an update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Graceful -</b> Allows Apache Airflow workers to complete running tasks for up
        /// to 12 hours during an update before they're stopped and replaced.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WorkerReplacementStrategy WorkerReplacementStrategy
        {
            get { return this._workerReplacementStrategy; }
            set { this._workerReplacementStrategy = value; }
        }

        // Check to see if WorkerReplacementStrategy property is set
        internal bool IsSetWorkerReplacementStrategy()
        {
            return this._workerReplacementStrategy != null;
        }

    }
}