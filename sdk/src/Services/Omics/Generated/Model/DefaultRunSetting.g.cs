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
    /// Shared configuration applied to all runs in a batch. Fields specified in a per-run
    /// <c>InlineSetting</c> entry override the corresponding fields in this object for that
    /// run. The <c>parameters</c> and <c>runTags</c> fields are merged rather than replaced
    /// — run-specific values take precedence when keys overlap.
    /// </summary>
    public partial class DefaultRunSetting
    {
        /// <summary>
        /// Gets and sets the property CacheBehavior. 
        /// <para>
        /// The cache behavior for the runs. Requires <c>cacheId</c> to be set.
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
        /// The identifier of the run cache to associate with the runs.
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
        /// The verbosity level for CloudWatch Logs emitted during each run.
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
        /// An optional user-friendly name applied to each workflow run. Can be overridden per
        /// run.
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
        /// Gets and sets the property OutputBucketOwnerId. 
        /// <para>
        /// The expected Amazon Web Services account ID of the owner of the output S3 bucket.
        /// Can be overridden per run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OutputBucketOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OutputBucketOwnerId property is set.
        /// </summary>
        internal bool IsSetOutputBucketOwnerId() => this.OutputBucketOwnerId != null;

        /// <summary>
        /// Gets and sets the property OutputUri. 
        /// <para>
        /// The destination S3 URI for workflow outputs. Must begin with <c>s3://</c>. The <c>roleArn</c>
        /// must grant write permissions to this bucket. Can be overridden per run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 750)]
        public string OutputUri { get; set; }

        /// <summary>
        /// Checks to see if the OutputUri property is set.
        /// </summary>
        internal bool IsSetOutputUri() => this.OutputUri != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Workflow parameter names and values shared across all runs. Merged with per-run parameters;
        /// run-specific values take precedence when keys overlap. Can be overridden per run.
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
        /// An integer priority for the workflow runs. Higher values correspond to higher priority.
        /// A value of 0 corresponds to the lowest priority. Can be overridden per run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100000)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property RetentionMode. 
        /// <para>
        /// The retention behavior for runs after completion.
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
        /// The IAM role ARN that grants HealthOmics permissions to access required Amazon Web
        /// Services resources such as Amazon S3 and CloudWatch. The role must have the same permissions
        /// required for individual <c>StartRun</c> calls.
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
        /// The ID of the run group to contain all workflow runs in the batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string RunGroupId { get; set; }

        /// <summary>
        /// Checks to see if the RunGroupId property is set.
        /// </summary>
        internal bool IsSetRunGroupId() => this.RunGroupId != null;

        /// <summary>
        /// Gets and sets the property RunTags. 
        /// <para>
        /// Amazon Web Services tags to associate with each workflow run. Merged with per-run
        /// <c>runTags</c>; run-specific values take precedence when keys overlap.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RunTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RunTags property is set.
        /// </summary>
        internal bool IsSetRunTags() => this.RunTags != null && (this.RunTags.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// The filesystem size in gibibytes (GiB) provisioned for each workflow run and shared
        /// by all tasks in that run. Defaults to 1200 GiB if not specified.
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
        /// The storage type for the workflow runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public StorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The identifier of the workflow to run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 18)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowId property is set.
        /// </summary>
        internal bool IsSetWorkflowId() => this.WorkflowId != null;

        /// <summary>
        /// Gets and sets the property WorkflowOwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the workflow owner, used for cross-account workflow
        /// sharing.
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
        /// The type of the originating workflow. Batch runs are not supported with <c>READY2RUN</c>
        /// workflows.
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
        /// The version name of the specified workflow.
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
