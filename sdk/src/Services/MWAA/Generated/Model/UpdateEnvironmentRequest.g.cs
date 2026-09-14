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

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEnvironment operation. Updates an Amazon
    /// Managed Workflows for Apache Airflow (MWAA) environment.
    /// </summary>
    public partial class UpdateEnvironmentRequest : AmazonMWAARequest
    {
        /// <summary>
        /// Gets and sets the property AirflowConfigurationOptions. 
        /// <para>
        /// A list of key-value pairs containing the Apache Airflow configuration options you
        /// want to attach to your environment. For more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-env-variables.html">Apache
        /// Airflow configuration options</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> AirflowConfigurationOptions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AirflowConfigurationOptions property is set.
        /// </summary>
        internal bool IsSetAirflowConfigurationOptions() => this.AirflowConfigurationOptions != null && (this.AirflowConfigurationOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AirflowVersion. 
        /// <para>
        /// The Apache Airflow version for your environment. To upgrade your environment, specify
        /// a newer version of Apache Airflow supported by Amazon MWAA. To downgrade your environment,
        /// specify an older version of Apache Airflow supported by Amazon MWAA.
        /// </para>
        ///  
        /// <para>
        /// Before you upgrade or downgrade an environment, make sure your requirements, DAGs,
        /// plugins, and other resources used in your workflows are compatible with the new Apache
        /// Airflow version. For more information about updating your resources, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/upgrading-environment.html">Upgrading
        /// and downgrading an Amazon MWAA environment</a>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>2.7.2</c>, <c>2.8.1</c>, <c>2.9.2</c>, <c>2.10.1</c>, <c>2.10.3</c>,
        /// <c>2.11.0</c>, and <c>3.0.6</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string AirflowVersion { get; set; }

        /// <summary>
        /// Checks to see if the AirflowVersion property is set.
        /// </summary>
        internal bool IsSetAirflowVersion() => this.AirflowVersion != null;

        /// <summary>
        /// Gets and sets the property DagS3Path. 
        /// <para>
        /// The relative path to the DAGs folder on your Amazon S3 bucket. For example, <c>dags</c>.
        /// For more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-dag-folder.html">Adding
        /// or updating DAGs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DagS3Path { get; set; }

        /// <summary>
        /// Checks to see if the DagS3Path property is set.
        /// </summary>
        internal bool IsSetDagS3Path() => this.DagS3Path != null;

        /// <summary>
        /// Gets and sets the property EnvironmentClass. 
        /// <para>
        /// The environment class type. Valid values: <c>mw1.micro</c>, <c>mw1.small</c>, <c>mw1.medium</c>,
        /// <c>mw1.large</c>, <c>mw1.xlarge</c>, and <c>mw1.2xlarge</c>. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/environment-class.html">Amazon
        /// MWAA environment class</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string EnvironmentClass { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentClass property is set.
        /// </summary>
        internal bool IsSetEnvironmentClass() => this.EnvironmentClass != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the execution role in IAM that allows MWAA to access
        /// Amazon Web Services resources in your environment. For example, <c>arn:aws:iam::123456789:role/my-execution-role</c>.
        /// For more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/mwaa-create-role.html">Amazon
        /// MWAA Execution role</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1224)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The Apache Airflow log types to send to CloudWatch Logs.
        /// </para>
        /// </summary>
        public LoggingConfigurationInput LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;

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
        [AWSProperty(Min = 1)]
        public int? MaxWebservers { get; set; }

        /// <summary>
        /// Checks to see if the MaxWebservers property is set.
        /// </summary>
        internal bool IsSetMaxWebservers() => this.MaxWebservers.HasValue;

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
        [AWSProperty(Min = 1)]
        public int? MaxWorkers { get; set; }

        /// <summary>
        /// Checks to see if the MaxWorkers property is set.
        /// </summary>
        internal bool IsSetMaxWorkers() => this.MaxWorkers.HasValue;

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
        [AWSProperty(Min = 1)]
        public int? MinWebservers { get; set; }

        /// <summary>
        /// Checks to see if the MinWebservers property is set.
        /// </summary>
        internal bool IsSetMinWebservers() => this.MinWebservers.HasValue;

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
        [AWSProperty(Min = 1)]
        public int? MinWorkers { get; set; }

        /// <summary>
        /// Checks to see if the MinWorkers property is set.
        /// </summary>
        internal bool IsSetMinWorkers() => this.MinWorkers.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of your Amazon MWAA environment. For example, <c>MyMWAAEnvironment</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 80)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The VPC networking components used to secure and enable network traffic between the
        /// Amazon Web Services resources for your environment. For more information, refer to
        /// <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/networking-about.html">About
        /// networking on Amazon MWAA</a>.
        /// </para>
        /// </summary>
        public UpdateNetworkConfigurationInput NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property PluginsS3ObjectVersion. 
        /// <para>
        /// The version of the plugins.zip file on your Amazon S3 bucket. You must specify a version
        /// each time a <c>plugins.zip</c> file is updated. For more information, refer to <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/versioning-workflows.html">How
        /// S3 Versioning works</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PluginsS3ObjectVersion { get; set; }

        /// <summary>
        /// Checks to see if the PluginsS3ObjectVersion property is set.
        /// </summary>
        internal bool IsSetPluginsS3ObjectVersion() => this.PluginsS3ObjectVersion != null;

        /// <summary>
        /// Gets and sets the property PluginsS3Path. 
        /// <para>
        /// The relative path to the <c>plugins.zip</c> file on your Amazon S3 bucket. For example,
        /// <c>plugins.zip</c>. If specified, then the plugins.zip version is required. For more
        /// information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-dag-import-plugins.html">Installing
        /// custom plugins</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PluginsS3Path { get; set; }

        /// <summary>
        /// Checks to see if the PluginsS3Path property is set.
        /// </summary>
        internal bool IsSetPluginsS3Path() => this.PluginsS3Path != null;

        /// <summary>
        /// Gets and sets the property RequirementsS3ObjectVersion. 
        /// <para>
        /// The version of the requirements.txt file on your Amazon S3 bucket. You must specify
        /// a version each time a <c>requirements.txt</c> file is updated. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/versioning-workflows.html">How
        /// S3 Versioning works</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string RequirementsS3ObjectVersion { get; set; }

        /// <summary>
        /// Checks to see if the RequirementsS3ObjectVersion property is set.
        /// </summary>
        internal bool IsSetRequirementsS3ObjectVersion() => this.RequirementsS3ObjectVersion != null;

        /// <summary>
        /// Gets and sets the property RequirementsS3Path. 
        /// <para>
        /// The relative path to the <c>requirements.txt</c> file on your Amazon S3 bucket. For
        /// example, <c>requirements.txt</c>. If specified, then a file version is required. For
        /// more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/working-dags-dependencies.html">Installing
        /// Python dependencies</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string RequirementsS3Path { get; set; }

        /// <summary>
        /// Checks to see if the RequirementsS3Path property is set.
        /// </summary>
        internal bool IsSetRequirementsS3Path() => this.RequirementsS3Path != null;

        /// <summary>
        /// Gets and sets the property Schedulers. 
        /// <para>
        /// The number of Apache Airflow schedulers to run in your Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 5)]
        public int? Schedulers { get; set; }

        /// <summary>
        /// Checks to see if the Schedulers property is set.
        /// </summary>
        internal bool IsSetSchedulers() => this.Schedulers.HasValue;

        /// <summary>
        /// Gets and sets the property SourceBucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket where your DAG code and supporting
        /// files are stored. For example, <c>arn:aws:s3:::my-airflow-bucket-unique-name</c>.
        /// For more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/mwaa-s3-bucket.html">Create
        /// an Amazon S3 bucket for Amazon MWAA</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1224)]
        public string SourceBucketArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceBucketArn property is set.
        /// </summary>
        internal bool IsSetSourceBucketArn() => this.SourceBucketArn != null;

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
        ///  For more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/using-startup-script.html">Using
        /// a startup script</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string StartupScriptS3ObjectVersion { get; set; }

        /// <summary>
        /// Checks to see if the StartupScriptS3ObjectVersion property is set.
        /// </summary>
        internal bool IsSetStartupScriptS3ObjectVersion() => this.StartupScriptS3ObjectVersion != null;

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
        /// configuration options, and set environment variables. For more information, refer
        /// to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/using-startup-script.html">Using
        /// a startup script</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string StartupScriptS3Path { get; set; }

        /// <summary>
        /// Checks to see if the StartupScriptS3Path property is set.
        /// </summary>
        internal bool IsSetStartupScriptS3Path() => this.StartupScriptS3Path != null;

        /// <summary>
        /// Gets and sets the property WebserverAccessMode. 
        /// <para>
        /// The Apache Airflow <i>Web server</i> access mode. For more information, refer to <a
        /// href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-networking.html">Apache
        /// Airflow access modes</a>.
        /// </para>
        ///  
        /// <para>
        /// If set to <c>PUBLIC_AND_PRIVATE</c>, creates both a public network load balancer (NLB)
        /// for browser access and a private VPC endpoint (VPCE) for worker-to-webserver communication.
        /// This mode is only available for Apache Airflow version 3.2 and later.
        /// </para>
        /// </summary>
        public WebserverAccessMode WebserverAccessMode { get; set; }

        /// <summary>
        /// Checks to see if the WebserverAccessMode property is set.
        /// </summary>
        internal bool IsSetWebserverAccessMode() => this.WebserverAccessMode != null;

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceWindowStart. 
        /// <para>
        /// The day and time of the week in Coordinated Universal Time (UTC) 24-hour standard
        /// time to start weekly maintenance updates of your environment in the following format:
        /// <c>DAY:HH:MM</c>. For example: <c>TUE:03:30</c>. You can specify a start time in 30
        /// minute increments only.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 9)]
        public string WeeklyMaintenanceWindowStart { get; set; }

        /// <summary>
        /// Checks to see if the WeeklyMaintenanceWindowStart property is set.
        /// </summary>
        internal bool IsSetWeeklyMaintenanceWindowStart() => this.WeeklyMaintenanceWindowStart != null;

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
        public WorkerReplacementStrategy WorkerReplacementStrategy { get; set; }

        /// <summary>
        /// Checks to see if the WorkerReplacementStrategy property is set.
        /// </summary>
        internal bool IsSetWorkerReplacementStrategy() => this.WorkerReplacementStrategy != null;
    }
}
