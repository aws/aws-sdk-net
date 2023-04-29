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

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// Describes an Amazon Managed Workflows for Apache Airflow (MWAA) environment.
    /// </summary>
    public partial class Environment
    {
        private Dictionary<string, string> _airflowConfigurationOptions = new Dictionary<string, string>();
        private string _airflowVersion;
        private string _arn;
        private DateTime? _createdAt;
        private string _dagS3Path;
        private string _environmentClass;
        private string _executionRoleArn;
        private string _kmsKey;
        private LastUpdate _lastUpdate;
        private LoggingConfiguration _loggingConfiguration;
        private int? _maxWorkers;
        private int? _minWorkers;
        private string _name;
        private NetworkConfiguration _networkConfiguration;
        private string _pluginsS3ObjectVersion;
        private string _pluginsS3Path;
        private string _requirementsS3ObjectVersion;
        private string _requirementsS3Path;
        private int? _schedulers;
        private string _serviceRoleArn;
        private string _sourceBucketArn;
        private string _startupScriptS3ObjectVersion;
        private string _startupScriptS3Path;
        private EnvironmentStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private WebserverAccessMode _webserverAccessMode;
        private string _webserverUrl;
        private string _weeklyMaintenanceWindowStart;

        /// <summary>
        /// Gets and sets the property AirflowConfigurationOptions. 
        /// <para>
        /// A list of key-value pairs containing the Apache Airflow configuration options attached
        /// to your environment. For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-env-variables.html">Apache
        /// Airflow configuration options</a>.
        /// </para>
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
            return this._airflowConfigurationOptions != null && this._airflowConfigurationOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AirflowVersion. 
        /// <para>
        /// The Apache Airflow version on your environment. Valid values: <code>1.10.12</code>,
        /// <code>2.0.2</code>, <code>2.2.2</code>, and <code>2.4.3</code>.
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The day and time the environment was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DagS3Path. 
        /// <para>
        /// The relative path to the DAGs folder in your Amazon S3 bucket. For example, <code>s3://mwaa-environment/dags</code>.
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
        /// The environment class type. Valid values: <code>mw1.small</code>, <code>mw1.medium</code>,
        /// <code>mw1.large</code>. For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/environment-class.html">Amazon
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
        /// Amazon Web Services resources in your environment. For example, <code>arn:aws:iam::123456789:role/my-execution-role</code>.
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
        /// Gets and sets the property KmsKey. 
        /// <para>
        /// The Amazon Web Services Key Management Service (KMS) encryption key used to encrypt
        /// the data in your environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdate. 
        /// <para>
        /// The status of the last update on the environment.
        /// </para>
        /// </summary>
        public LastUpdate LastUpdate
        {
            get { return this._lastUpdate; }
            set { this._lastUpdate = value; }
        }

        // Check to see if LastUpdate property is set
        internal bool IsSetLastUpdate()
        {
            return this._lastUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The Apache Airflow logs published to CloudWatch Logs.
        /// </para>
        /// </summary>
        public LoggingConfiguration LoggingConfiguration
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
        /// Gets and sets the property MaxWorkers. 
        /// <para>
        /// The maximum number of workers that run in your environment. For example, <code>20</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxWorkers
        {
            get { return this._maxWorkers.GetValueOrDefault(); }
            set { this._maxWorkers = value; }
        }

        // Check to see if MaxWorkers property is set
        internal bool IsSetMaxWorkers()
        {
            return this._maxWorkers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinWorkers. 
        /// <para>
        /// The minimum number of workers that run in your environment. For example, <code>2</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MinWorkers
        {
            get { return this._minWorkers.GetValueOrDefault(); }
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
        /// The name of the Amazon MWAA environment. For example, <code>MyMWAAEnvironment</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=80)]
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
        /// Describes the VPC networking components used to secure and enable network traffic
        /// between the Amazon Web Services resources for your environment. For more information,
        /// see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/networking-about.html">About
        /// networking on Amazon MWAA</a>.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
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
        /// The version of the <code>plugins.zip</code> file in your Amazon S3 bucket. You must
        /// specify the <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/versioning-workflows.html">version
        /// ID</a> that Amazon S3 assigns to the file.
        /// </para>
        ///  
        /// <para>
        ///  Version IDs are Unicode, UTF-8 encoded, URL-ready, opaque strings that are no more
        /// than 1,024 bytes long. The following is an example: 
        /// </para>
        ///  
        /// <para>
        ///  <code>3sL4kqtJlcpXroDTDmJ+rmSpXd3dIbrHY+MTRCxf3vjVBH40Nr8X8gdRQBpUMLUo</code> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-dag-import-plugins.html">Installing
        /// custom plugins</a>.
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
        /// The relative path to the file in your Amazon S3 bucket. For example, <code>s3://mwaa-environment/plugins.zip</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-dag-import-plugins.html">Installing
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
        /// The version of the <code>requirements.txt </code> file on your Amazon S3 bucket. You
        /// must specify the <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/versioning-workflows.html">version
        /// ID</a> that Amazon S3 assigns to the file.
        /// </para>
        ///  
        /// <para>
        ///  Version IDs are Unicode, UTF-8 encoded, URL-ready, opaque strings that are no more
        /// than 1,024 bytes long. The following is an example: 
        /// </para>
        ///  
        /// <para>
        ///  <code>3sL4kqtJlcpXroDTDmJ+rmSpXd3dIbrHY+MTRCxf3vjVBH40Nr8X8gdRQBpUMLUo</code> 
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/working-dags-dependencies.html">Installing
        /// Python dependencies</a>. 
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
        /// The relative path to the <code>requirements.txt</code> file in your Amazon S3 bucket.
        /// For example, <code>s3://mwaa-environment/requirements.txt</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/working-dags-dependencies.html">Installing
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
        /// The number of Apache Airflow schedulers that run in your Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public int Schedulers
        {
            get { return this._schedulers.GetValueOrDefault(); }
            set { this._schedulers = value; }
        }

        // Check to see if Schedulers property is set
        internal bool IsSetSchedulers()
        {
            return this._schedulers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the service-linked role of the environment. For
        /// more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/mwaa-slr.html">Amazon
        /// MWAA Service-linked role</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string ServiceRoleArn
        {
            get { return this._serviceRoleArn; }
            set { this._serviceRoleArn = value; }
        }

        // Check to see if ServiceRoleArn property is set
        internal bool IsSetServiceRoleArn()
        {
            return this._serviceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceBucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket where your DAG code and supporting
        /// files are stored. For example, <code>arn:aws:s3:::my-airflow-bucket-unique-name</code>.
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
        /// The version of the startup shell script in your Amazon S3 bucket. You must specify
        /// the <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/versioning-workflows.html">version
        /// ID</a> that Amazon S3 assigns to the file.
        /// </para>
        ///  
        /// <para>
        ///  Version IDs are Unicode, UTF-8 encoded, URL-ready, opaque strings that are no more
        /// than 1,024 bytes long. The following is an example: 
        /// </para>
        ///  
        /// <para>
        ///  <code>3sL4kqtJlcpXroDTDmJ+rmSpXd3dIbrHY+MTRCxf3vjVBH40Nr8X8gdRQBpUMLUo</code> 
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/using-startup-script.html">Using
        /// a startup script</a>. 
        /// </para>
        /// </summary>
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
        /// <code>s3://mwaa-environment/startup.sh</code>.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Amazon MWAA environment. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATING</code> - Indicates the request to create the environment is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_FAILED</code> - Indicates the request to create the environment failed,
        /// and the environment could not be created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AVAILABLE</code> - Indicates the request was successful and the environment
        /// is ready to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATING</code> - Indicates the request to update the environment is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETING</code> - Indicates the request to delete the environment is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETED</code> - Indicates the request to delete the environment is complete,
        /// and the environment has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UNAVAILABLE</code> - Indicates the request failed, but the environment was
        /// unable to rollback and is not in a stable state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_FAILED</code> - Indicates the request to update the environment failed,
        /// and the environment has rolled back successfully and is ready to use.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// We recommend reviewing our troubleshooting guide for a list of common errors and their
        /// solutions. For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/troubleshooting.html">Amazon
        /// MWAA troubleshooting</a>.
        /// </para>
        /// </summary>
        public EnvironmentStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value tag pairs associated to your environment. For example, <code>"Environment":
        /// "Staging"</code>. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property WebserverUrl. 
        /// <para>
        /// The Apache Airflow <i>Web server</i> host name for the Amazon MWAA environment. For
        /// more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/access-airflow-ui.html">Accessing
        /// the Apache Airflow UI</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string WebserverUrl
        {
            get { return this._webserverUrl; }
            set { this._webserverUrl = value; }
        }

        // Check to see if WebserverUrl property is set
        internal bool IsSetWebserverUrl()
        {
            return this._webserverUrl != null;
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceWindowStart. 
        /// <para>
        /// The day and time of the week in Coordinated Universal Time (UTC) 24-hour standard
        /// time that weekly maintenance updates are scheduled. For example: <code>TUE:03:30</code>.
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

    }
}