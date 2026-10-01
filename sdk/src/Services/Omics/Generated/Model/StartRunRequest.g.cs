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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the StartRun operation. Starts a new run and returns
    /// details about the run, or duplicates an existing run. A run is a single invocation
    /// of a workflow. If you provide request IDs, Amazon Web Services HealthOmics identifies
    /// duplicate requests and starts the run only once. Monitor the progress of the run by
    /// calling the <c>GetRun</c> API operation. <para> To start a new run, the following
    /// inputs are required: </para> <ul> <li> <para> A service role ARN (<c>roleArn</c>).
    /// </para> </li> <li> <para> The run's workflow ID (<c>workflowId</c>, not the <c>uuid</c>
    /// or <c>runId</c>). </para> </li> <li> <para> An Amazon S3 location (<c>outputUri</c>)
    /// where the run outputs will be saved. </para> </li> <li> <para> All required workflow
    /// parameters (<c>parameter</c>), which can include optional parameters from the parameter
    /// template. The run cannot include any parameters that are not defined in the parameter
    /// template. To see all possible parameters, use the <c>GetRun</c> API operation. </para>
    /// </li> <li> <para> For runs with a <c>STATIC</c> (default) storage type, specify the
    /// required storage capacity (in gibibytes). A storage capacity value is not required
    /// for runs that use <c>DYNAMIC</c> storage. </para> </li> </ul> <para> <c>StartRun</c>
    /// can also duplicate an existing run using the run's default values. You can modify
    /// these default values and/or add other optional inputs. To duplicate a run, the following
    /// inputs are required: </para> <ul> <li> <para> A service role ARN (<c>roleArn</c>).
    /// </para> </li> <li> <para> The ID of the run to duplicate (<c>runId</c>). </para> </li>
    /// <li> <para> An Amazon S3 location where the run outputs will be saved (<c>outputUri</c>).
    /// </para> </li> </ul> <para> To learn more about the optional parameters for <c>StartRun</c>,
    /// see <a href="https://docs.aws.amazon.com/omics/latest/dev/starting-a-run.html">Starting
    /// a run</a> in the <i>Amazon Web Services HealthOmics User Guide</i>. </para> <para>
    /// Use the <c>retentionMode</c> input to control how long the metadata for each run is
    /// stored in CloudWatch. There are two retention modes: </para> <ul> <li> <para> Specify
    /// <c>REMOVE</c> to automatically remove the oldest runs when you reach the maximum service
    /// retention limit for runs. It is recommended that you use the <c>REMOVE</c> mode to
    /// initiate major run requests so that your runs do not fail when you reach the limit.
    /// </para> </li> <li> <para> The <c>retentionMode</c> is set to the <c>RETAIN</c> mode
    /// by default, which allows you to manually remove runs after reaching the maximum service
    /// retention limit. Under this setting, you cannot create additional runs until you remove
    /// the excess runs. </para> </li> </ul> <para> To learn more about the retention modes,
    /// see <a href="https://docs.aws.amazon.com/omics/latest/dev/run-retention.html">Run
    /// retention mode</a> in the <i>Amazon Web Services HealthOmics User Guide</i>. </para>
    /// <para> You can use Amazon Q CLI to analyze run logs and make performance optimization
    /// recommendations. To get started, see the <a href="https://github.com/awslabs/mcp/tree/main/src/aws-healthomics-mcp-server">Amazon
    /// Web Services HealthOmics MCP server</a> on GitHub. </para>
    /// </summary>
    public partial class StartRunRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property CacheBehavior. 
        /// <para>
        /// The cache behavior for the run. You specify this value if you want to override the
        /// default behavior for the cache. You had set the default value when you created the
        /// cache. For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/how-run-cache.html#run-cache-behavior">Run
        /// cache behavior</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public CacheBehavior CacheBehavior { get; set; }

        /// <summary>
        /// Checks to see if the CacheBehavior property is set.
        /// </summary>
        internal bool IsSetCacheBehavior() => this.CacheBehavior != null;

        /// <summary>
        /// Gets and sets the property CacheId. 
        /// <para>
        /// Identifier of the cache associated with this run. If you don't specify a cache ID,
        /// no task outputs are cached for this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string CacheId { get; set; }

        /// <summary>
        /// Checks to see if the CacheId property is set.
        /// </summary>
        internal bool IsSetCacheId() => this.CacheId != null;

        /// <summary>
        /// Gets and sets the property ConfigurationName. 
        /// <para>
        /// Optional configuration name to use for the workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationName property is set.
        /// </summary>
        internal bool IsSetConfigurationName() => this.ConfigurationName != null;

        /// <summary>
        /// Gets and sets the property EngineSettings. 
        /// <para>
        /// Engine-specific settings for the workflow run. Use this field to specify configuration
        /// options that are specific to the workflow engine (for example, Nextflow profiles).
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document EngineSettings { get; set; }

        /// <summary>
        /// Checks to see if the EngineSettings property is set.
        /// </summary>
        internal bool IsSetEngineSettings() => !this.EngineSettings.IsNull();

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// A log level for the run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public RunLogLevel LogLevel { get; set; }

        /// <summary>
        /// Checks to see if the LogLevel property is set.
        /// </summary>
        internal bool IsSetLogLevel() => this.LogLevel != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the run. This is recommended to view and organize runs in the Amazon Web
        /// Services HealthOmics console and CloudWatch logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkingMode. 
        /// <para>
        /// Optional configuration for run networking behavior. If not specified, this will default
        /// to RESTRICTED.
        /// </para>
        /// </summary>
        public NetworkingMode NetworkingMode { get; set; }

        /// <summary>
        /// Checks to see if the NetworkingMode property is set.
        /// </summary>
        internal bool IsSetNetworkingMode() => this.NetworkingMode != null;

        /// <summary>
        /// Gets and sets the property OutputUri. 
        /// <para>
        /// An output S3 URI for the run. The S3 bucket must be in the same region as the workflow.
        /// The role ARN must have permission to write to this S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 750)]
        public string OutputUri { get; set; }

        /// <summary>
        /// Checks to see if the OutputUri property is set.
        /// </summary>
        internal bool IsSetOutputUri() => this.OutputUri != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Parameters for the run. The run needs all required parameters and can include optional
        /// parameters. The run cannot include any parameters that are not defined in the parameter
        /// template. To retrieve parameters from the run, use the GetRun API operation.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => !this.Parameters.IsNull();

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Use the run priority (highest: 1) to establish the order of runs in a run group when
        /// you start a run. If multiple runs share the same priority, the run that was initiated
        /// first will have the higher priority. Runs that do not belong to a run group can be
        /// assigned a priority. The priorities of these runs are ranked among other runs that
        /// are not in a run group. For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/creating-run-groups.html#run-priority">Run
        /// priority</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100000)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// An idempotency token used to dedupe retry requests so that duplicate runs are not
        /// created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property RetentionMode. 
        /// <para>
        /// The retention mode for the run. The default value is <c>RETAIN</c>. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services HealthOmics stores a fixed number of runs that are available to
        /// the console and API. In the default mode (<c>RETAIN</c>), you need to remove runs
        /// manually when the number of run exceeds the maximum. If you set the retention mode
        /// to <c>REMOVE</c>, Amazon Web Services HealthOmics automatically removes runs (that
        /// have mode set to <c>REMOVE</c>) when the number of run exceeds the maximum. All run
        /// logs are available in CloudWatch logs, if you need information about a run that is
        /// no longer available to the API.
        /// </para>
        ///  
        /// <para>
        /// For more information about retention mode, see <a href="https://docs.aws.amazon.com/omics/latest/dev/starting-a-run.html">Specifying
        /// run retention mode</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public RunRetentionMode RetentionMode { get; set; }

        /// <summary>
        /// Checks to see if the RetentionMode property is set.
        /// </summary>
        internal bool IsSetRetentionMode() => this.RetentionMode != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// A service role for the run. The <c>roleArn</c> requires access to Amazon Web Services
        /// HealthOmics, S3, Cloudwatch logs, and EC2. An example <c>roleArn</c> is <c>arn:aws:iam::123456789012:role/omics-service-role-serviceRole-W8O1XMPL7QZ</c>.
        /// In this example, the Amazon Web Services account ID is <c>123456789012</c> and the
        /// role name is <c>omics-service-role-serviceRole-W8O1XMPL7QZ</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property RunGroupId. 
        /// <para>
        /// The run's group ID. Use a run group to cap the compute resources (and number of concurrent
        /// runs) for the runs that you add to the run group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string RunGroupId { get; set; }

        /// <summary>
        /// Checks to see if the RunGroupId property is set.
        /// </summary>
        internal bool IsSetRunGroupId() => this.RunGroupId != null;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The ID of a run to duplicate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property ScratchStorageMode. 
        /// <para>
        /// Optional configuration for enabling scratch ephemeral storage mounted at /tmp. If
        /// not specified, this will default to SHARED. This configuration is applicable only
        /// for CPU tasks. For tasks using GPUs, scratch storage is always LOCAL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public ScratchStorageMode ScratchStorageMode { get; set; }

        /// <summary>
        /// Checks to see if the ScratchStorageMode property is set.
        /// </summary>
        internal bool IsSetScratchStorageMode() => this.ScratchStorageMode != null;

        /// <summary>
        /// Gets and sets the property SessionPolicy. Optional inline policy json for scoping
        /// down permissions via a session policy on the IAM role provided in the roleArn parameter.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SessionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the SessionPolicy property is set.
        /// </summary>
        internal bool IsSetSessionPolicy() => this.SessionPolicy != null;

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// The <c>STATIC</c> storage capacity (in gibibytes, GiB) for this run. The default run
        /// storage capacity is 1200 GiB. If your requested storage capacity is unavailable, the
        /// system rounds up the value to the nearest 1200 GiB multiple. If the requested storage
        /// capacity is still unavailable, the system rounds up the value to the nearest 2400
        /// GiB multiple. This field is not required if the storage type is <c>DYNAMIC</c> (the
        /// system ignores any value that you enter).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100000)]
        public int? StorageCapacity { get; set; }

        /// <summary>
        /// Checks to see if the StorageCapacity property is set.
        /// </summary>
        internal bool IsSetStorageCapacity() => this.StorageCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type for the run. If you set the storage type to <c>DYNAMIC</c>, Amazon
        /// Web Services HealthOmics dynamically scales the storage up or down, based on file
        /// system utilization. By default, the run uses <c>STATIC</c> storage type, which allocates
        /// a fixed amount of storage. For more information about <c>DYNAMIC</c> and <c>STATIC</c>
        /// storage, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflows-run-types.html">Run
        /// storage types</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public StorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags for the run. You can add up to 50 tags per run. For more information, see <a
        /// href="https://docs.aws.amazon.com/omics/latest/dev/add-a-tag.html">Adding a tag</a>
        /// in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The run's workflow ID. The <c>workflowId</c> is not the UUID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowId property is set.
        /// </summary>
        internal bool IsSetWorkflowId() => this.WorkflowId != null;

        /// <summary>
        /// Gets and sets the property WorkflowOwnerId. 
        /// <para>
        /// The 12-digit account ID of the workflow owner that is used for running a shared workflow.
        /// The workflow owner ID can be retrieved using the <c>GetShare</c> API operation. If
        /// you are the workflow owner, you do not need to include this ID.
        /// </para>
        /// </summary>
        public string WorkflowOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowOwnerId property is set.
        /// </summary>
        internal bool IsSetWorkflowOwnerId() => this.WorkflowOwnerId != null;

        /// <summary>
        /// Gets and sets the property WorkflowType. 
        /// <para>
        /// The run's workflow type. The <c>workflowType</c> must be specified if you are running
        /// a <c>READY2RUN</c> workflow. If you are running a <c>PRIVATE</c> workflow (default),
        /// you do not need to include the workflow type. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public WorkflowType WorkflowType { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowType property is set.
        /// </summary>
        internal bool IsSetWorkflowType() => this.WorkflowType != null;

        /// <summary>
        /// Gets and sets the property WorkflowVersionName. 
        /// <para>
        /// The name of the workflow version. Use workflow versions to track and organize changes
        /// to the workflow. If your workflow has multiple versions, the run uses the default
        /// version unless you specify a version name. To learn more, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflow-versions.html">Workflow
        /// versioning</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string WorkflowVersionName { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowVersionName property is set.
        /// </summary>
        internal bool IsSetWorkflowVersionName() => this.WorkflowVersionName != null;
    }
}
