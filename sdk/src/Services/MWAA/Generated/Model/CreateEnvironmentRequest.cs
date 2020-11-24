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
    /// Container for the parameters to the CreateEnvironment operation.
    /// JSON blob that describes the environment to create.
    /// </summary>
    public partial class CreateEnvironmentRequest : AmazonMWAARequest
    {
        private Dictionary<string, string> _airflowConfigurationOptions = new Dictionary<string, string>();
        private string _airflowVersion;
        private string _dagS3Path;
        private string _environmentClass;
        private string _executionRoleArn;
        private string _kmsKey;
        private LoggingConfigurationInput _loggingConfiguration;
        private int? _maxWorkers;
        private string _name;
        private NetworkConfiguration _networkConfiguration;
        private string _pluginsS3ObjectVersion;
        private string _pluginsS3Path;
        private string _requirementsS3ObjectVersion;
        private string _requirementsS3Path;
        private string _sourceBucketArn;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private WebserverAccessMode _webserverAccessMode;
        private string _weeklyMaintenanceWindowStart;

        /// <summary>
        /// Gets and sets the property AirflowConfigurationOptions. 
        /// <para>
        /// The Apache Airflow configuration setting you want to override in your environment.
        /// For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-env-variables.html">Environment
        /// configuration</a>.
        /// </para>
        /// </summary>
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
        /// The Apache Airflow version you want to use for your environment.
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
        /// The relative path to the DAG folder on your Amazon S3 storage bucket. For example,
        /// <code>dags</code>. For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-dag-import.html">Importing
        /// DAGs on Amazon MWAA</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// The environment class you want to use for your environment. The environment class
        /// determines the size of the containers and database used for your Apache Airflow services.
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
        /// The Amazon Resource Name (ARN) of the execution role for your environment. An execution
        /// role is an AWS Identity and Access Management (IAM) role that grants MWAA permission
        /// to access AWS services and resources used by your environment. For example, <code>arn:aws:iam::123456789:role/my-execution-role</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/manage-access.html">Managing
        /// access to Amazon Managed Workflows for Apache Airflow</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1224)]
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
        /// The AWS Key Management Service (KMS) key to encrypt and decrypt the data in your environment.
        /// You can use an AWS KMS key managed by MWAA, or a custom KMS key (advanced). For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html?icmpid=docs_console_unmapped#master_keys">Customer
        /// master keys (CMKs)</a> in the AWS KMS developer guide.
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
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The Apache Airflow logs you want to send to Amazon CloudWatch Logs.
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
        /// Gets and sets the property MaxWorkers. 
        /// <para>
        /// The maximum number of workers that you want to run in your environment. MWAA scales
        /// the number of Apache Airflow workers and the Fargate containers that run your tasks
        /// up to the number you specify in this field. When there are no more tasks running,
        /// and no more in the queue, MWAA disposes of the extra containers leaving the one worker
        /// that is included with your environment.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of your MWAA environment.
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
        /// The VPC networking components you want to use for your environment. At least two private
        /// subnet identifiers and one VPC security group identifier are required to create an
        /// environment. For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/vpc-mwaa.html">Creating
        /// the VPC network for a MWAA environment</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The <code>plugins.zip</code> file version you want to use.
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
        /// The relative path to the <code>plugins.zip</code> file on your Amazon S3 storage bucket.
        /// For example, <code>plugins.zip</code>. If a relative path is provided in the request,
        /// then <code>PluginsS3ObjectVersion</code> is required. For more information, see <a
        /// href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-dag-import.html">Importing
        /// DAGs on Amazon MWAA</a>.
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
        /// The <code>requirements.txt</code> file version you want to use.
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
        /// The relative path to the <code>requirements.txt</code> file on your Amazon S3 storage
        /// bucket. For example, <code>requirements.txt</code>. If a relative path is provided
        /// in the request, then <code>RequirementsS3ObjectVersion</code> is required. For more
        /// information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-dag-import.html">Importing
        /// DAGs on Amazon MWAA</a>.
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
        /// Gets and sets the property SourceBucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of your Amazon S3 storage bucket. For example, <code>arn:aws:s3:::airflow-mybucketname</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1224)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata tags you want to attach to your environment. For more information, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging AWS
        /// resources</a>.
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
        /// The networking access of your Apache Airflow web server. A public network allows your
        /// Airflow UI to be accessed over the Internet by users granted access in your IAM policy.
        /// A private network limits access of your Airflow UI to users within your VPC. For more
        /// information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/vpc-mwaa.html">Creating
        /// the VPC network for a MWAA environment</a>.
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
        /// The day and time you want MWAA to start weekly maintenance updates on your environment.
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