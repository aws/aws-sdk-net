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
    /// Describes an Amazon Managed Workflows for Apache Airflow (MWAA) environment.
    /// </summary>
    public partial class Environment
    {
        /// <summary>
        /// Gets and sets the property AirflowConfigurationOptions. 
        /// <para>
        /// A list of key-value pairs containing the Apache Airflow configuration options attached
        /// to your environment. For more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-env-variables.html">Apache
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
        /// The Apache Airflow version on your environment.
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1224)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CeleryExecutorQueue. 
        /// <para>
        /// The queue ARN for the environment's <a href="https://airflow.apache.org/docs/apache-airflow/stable/core-concepts/executor/celery.html">Celery
        /// Executor</a>. Amazon MWAA uses a Celery Executor to distribute tasks across multiple
        /// workers. When you create an environment in a shared VPC, you must provide access to
        /// the Celery Executor queue from your VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1224)]
        public string CeleryExecutorQueue { get; set; }

        /// <summary>
        /// Checks to see if the CeleryExecutorQueue property is set.
        /// </summary>
        internal bool IsSetCeleryExecutorQueue() => this.CeleryExecutorQueue != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The day and time the environment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DagS3Path. 
        /// <para>
        /// The relative path to the DAGs folder in your Amazon S3 bucket. For example, <c>s3://mwaa-environment/dags</c>.
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
        /// Gets and sets the property DatabaseVpcEndpointService. 
        /// <para>
        /// The VPC endpoint for the environment's Amazon RDS database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1224)]
        public string DatabaseVpcEndpointService { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseVpcEndpointService property is set.
        /// </summary>
        internal bool IsSetDatabaseVpcEndpointService() => this.DatabaseVpcEndpointService != null;

        /// <summary>
        /// Gets and sets the property EndpointManagement. 
        /// <para>
        /// Defines whether the VPC endpoints configured for the environment are created, and
        /// managed, by the customer or by Amazon MWAA. If set to <c>SERVICE</c>, Amazon MWAA
        /// will create and manage the required VPC endpoints in your VPC. If set to <c>CUSTOMER</c>,
        /// you must create, and manage, the VPC endpoints in your VPC.
        /// </para>
        /// </summary>
        public EndpointManagement EndpointManagement { get; set; }

        /// <summary>
        /// Checks to see if the EndpointManagement property is set.
        /// </summary>
        internal bool IsSetEndpointManagement() => this.EndpointManagement != null;

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
        /// Gets and sets the property KmsKey. 
        /// <para>
        /// The KMS encryption key used to encrypt the data in your environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1224)]
        public string KmsKey { get; set; }

        /// <summary>
        /// Checks to see if the KmsKey property is set.
        /// </summary>
        internal bool IsSetKmsKey() => this.KmsKey != null;

        /// <summary>
        /// Gets and sets the property LastUpdate. 
        /// <para>
        /// The status of the last update on the environment.
        /// </para>
        /// </summary>
        public LastUpdate LastUpdate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdate property is set.
        /// </summary>
        internal bool IsSetLastUpdate() => this.LastUpdate != null;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The Apache Airflow logs published to CloudWatch Logs.
        /// </para>
        /// </summary>
        public LoggingConfiguration LoggingConfiguration { get; set; }

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
        /// The maximum number of workers that run in your environment. For example, <c>20</c>.
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
        /// The minimum number of workers that run in your environment. For example, <c>2</c>.
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
        /// The name of the Amazon MWAA environment. For example, <c>MyMWAAEnvironment</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// Describes the VPC networking components used to secure and enable network traffic
        /// between the Amazon Web Services resources for your environment. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/networking-about.html">About
        /// networking on Amazon MWAA</a>.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property PluginsS3ObjectVersion. 
        /// <para>
        /// The version of the <c>plugins.zip</c> file in your Amazon S3 bucket. You must specify
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
        ///  <c>3sL4kqtJlcpXroDTDmJ+rmSpXd3dIbrHY+MTRCxf3vjVBH40Nr8X8gdRQBpUMLUo</c> 
        /// </para>
        ///  
        /// <para>
        /// For more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-dag-import-plugins.html">Installing
        /// custom plugins</a>.
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
        /// The relative path to the file in your Amazon S3 bucket. For example, <c>s3://mwaa-environment/plugins.zip</c>.
        /// For more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-dag-import-plugins.html">Installing
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
        /// The version of the <c>requirements.txt </c> file on your Amazon S3 bucket. You must
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
        ///  <c>3sL4kqtJlcpXroDTDmJ+rmSpXd3dIbrHY+MTRCxf3vjVBH40Nr8X8gdRQBpUMLUo</c> 
        /// </para>
        ///  
        /// <para>
        ///  For more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/working-dags-dependencies.html">Installing
        /// Python dependencies</a>. 
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
        /// The relative path to the <c>requirements.txt</c> file in your Amazon S3 bucket. For
        /// example, <c>s3://mwaa-environment/requirements.txt</c>. For more information, refer
        /// to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/working-dags-dependencies.html">Installing
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
        /// The number of Apache Airflow schedulers that run in your Amazon MWAA environment.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 5)]
        public int? Schedulers { get; set; }

        /// <summary>
        /// Checks to see if the Schedulers property is set.
        /// </summary>
        internal bool IsSetSchedulers() => this.Schedulers.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the service-linked role of the environment. For
        /// more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/mwaa-slr.html">Amazon
        /// MWAA Service-linked role</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1224)]
        public string ServiceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceRoleArn() => this.ServiceRoleArn != null;

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
        ///  <c>3sL4kqtJlcpXroDTDmJ+rmSpXd3dIbrHY+MTRCxf3vjVBH40Nr8X8gdRQBpUMLUo</c> 
        /// </para>
        ///  
        /// <para>
        ///  For more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/using-startup-script.html">Using
        /// a startup script</a>. 
        /// </para>
        /// </summary>
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
        public string StartupScriptS3Path { get; set; }

        /// <summary>
        /// Checks to see if the StartupScriptS3Path property is set.
        /// </summary>
        internal bool IsSetStartupScriptS3Path() => this.StartupScriptS3Path != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Amazon MWAA environment.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The request to create the environment is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING_SNAPSHOT</c> - The request to update environment details, or upgrade
        /// the environment version, is in progress and Amazon MWAA is creating a storage volume
        /// snapshot of the Amazon RDS database cluster associated with the environment. A database
        /// snapshot is a backup created at a specific point in time. Amazon MWAA uses snapshots
        /// to recover environment metadata if the process to update or upgrade an environment
        /// fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c> - The request to create the environment failed and the environment
        /// was not created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - The request was successful and the environment is ready to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c> - The request was successful, but the process to create the environment
        /// is paused until you create the required VPC endpoints in your VPC. After you create
        /// the VPC endpoints, the process resumes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The request to update the environment is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROLLING_BACK</c> - The request to update environment details or upgrade the environment
        /// version failed and Amazon MWAA is restoring the environment using the latest storage
        /// volume snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The request to delete the environment is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> - The request to delete the environment is complete, and the environment
        /// has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNAVAILABLE</c> - The request failed, but the environment did not return to its
        /// previous state and is not stable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_FAILED</c> - The request to update the environment failed and the environment
        /// was restored to its previous state successfully and is ready to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MAINTENANCE</c> - The environment is undergoing maintenance. Depending on the
        /// type of work Amazon MWAA is performing, your environment might be unavailable during
        /// this process. Note that as part of the maintenance work, Amazon MWAA performs with
        /// a <c>GRACEFUL</c> <a href="https://docs.aws.amazon.com/mwaa/latest/API/API_UpdateEnvironment.html#mwaa-UpdateEnvironment-request-WorkerReplacementStrategy">
        /// <c>workerReplacementStrategy</c> </a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can review our troubleshooting guide for a list of common errors and their solutions.
        /// For more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/troubleshooting.html">Amazon
        /// MWAA troubleshooting</a>.
        /// </para>
        /// </summary>
        public EnvironmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value tag pairs associated to your environment. For example, <c>"Environment":
        /// "Staging"</c>. For more information, refer to <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WebserverAccessMode. 
        /// <para>
        /// The Apache Airflow <i>web server</i> access mode. For more information, refer to <a
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
        /// Gets and sets the property WebserverUrl. 
        /// <para>
        /// The Apache Airflow <i>web server</i> host name for the Amazon MWAA environment. For
        /// more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/access-airflow-ui.html">Accessing
        /// the Apache Airflow UI</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string WebserverUrl { get; set; }

        /// <summary>
        /// Checks to see if the WebserverUrl property is set.
        /// </summary>
        internal bool IsSetWebserverUrl() => this.WebserverUrl != null;

        /// <summary>
        /// Gets and sets the property WebserverVpcEndpointService. 
        /// <para>
        /// The VPC endpoint for the environment's web server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1224)]
        public string WebserverVpcEndpointService { get; set; }

        /// <summary>
        /// Checks to see if the WebserverVpcEndpointService property is set.
        /// </summary>
        internal bool IsSetWebserverVpcEndpointService() => this.WebserverVpcEndpointService != null;

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceWindowStart. 
        /// <para>
        /// The day and time of the week in Coordinated Universal Time (UTC) 24-hour standard
        /// time that weekly maintenance updates are scheduled. For example: <c>TUE:03:30</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 9)]
        public string WeeklyMaintenanceWindowStart { get; set; }

        /// <summary>
        /// Checks to see if the WeeklyMaintenanceWindowStart property is set.
        /// </summary>
        internal bool IsSetWeeklyMaintenanceWindowStart() => this.WeeklyMaintenanceWindowStart != null;
    }
}
