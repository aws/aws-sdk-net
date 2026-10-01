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
    /// This is the response object from the GetRun operation.
    /// </summary>
    public partial class GetRunResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Accelerators. 
        /// <para>
        /// The computational accelerator used to run the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public Accelerators Accelerators { get; set; }

        /// <summary>
        /// Checks to see if the Accelerators property is set.
        /// </summary>
        internal bool IsSetAccelerators() => this.Accelerators != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The run's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BatchId. 
        /// <para>
        /// The run's batch ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string BatchId { get; set; }

        /// <summary>
        /// Checks to see if the BatchId property is set.
        /// </summary>
        internal bool IsSetBatchId() => this.BatchId != null;

        /// <summary>
        /// Gets and sets the property CacheBehavior. 
        /// <para>
        /// The run cache behavior for the run.
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
        /// The run cache associated with the run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string CacheId { get; set; }

        /// <summary>
        /// Checks to see if the CacheId property is set.
        /// </summary>
        internal bool IsSetCacheId() => this.CacheId != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Configuration details for the workflow run.
        /// </para>
        /// </summary>
        public ConfigurationDetails Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the run was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The run's definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property Digest. 
        /// <para>
        /// The run's digest.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Digest { get; set; }

        /// <summary>
        /// Checks to see if the Digest property is set.
        /// </summary>
        internal bool IsSetDigest() => this.Digest != null;

        /// <summary>
        /// Gets and sets the property EngineSettings. 
        /// <para>
        /// The engine-specific settings for the workflow run.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document EngineSettings { get; set; }

        /// <summary>
        /// Checks to see if the EngineSettings property is set.
        /// </summary>
        internal bool IsSetEngineSettings() => !this.EngineSettings.IsNull();

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The actual Nextflow engine version that Amazon Web Services HealthOmics used for the
        /// run. The other workflow definition languages don't provide a value for this field.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason a run has failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The run's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// The run's log level.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public RunLogLevel LogLevel { get; set; }

        /// <summary>
        /// Checks to see if the LogLevel property is set.
        /// </summary>
        internal bool IsSetLogLevel() => this.LogLevel != null;

        /// <summary>
        /// Gets and sets the property LogLocation. 
        /// <para>
        /// The location of the run log.
        /// </para>
        /// </summary>
        public RunLogLocation LogLocation { get; set; }

        /// <summary>
        /// Checks to see if the LogLocation property is set.
        /// </summary>
        internal bool IsSetLogLocation() => this.LogLocation != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The run's name.
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
        /// Configuration for run networking behavior. If absent, this will default to RESTRICTED.
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
        /// The run's output URI.
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
        /// The run's parameters.
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
        /// The run's priority.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100000)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceDigests. 
        /// <para>
        /// The run's resource digests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ResourceDigests { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ResourceDigests property is set.
        /// </summary>
        internal bool IsSetResourceDigests() => this.ResourceDigests != null && (this.ResourceDigests.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RetentionMode. 
        /// <para>
        /// The run's retention mode.
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
        /// The run's service role ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property RunGroupId. 
        /// <para>
        /// The run's group ID.
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
        /// The run's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property RunOutputUri. 
        /// <para>
        /// The destination for workflow outputs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 750)]
        public string RunOutputUri { get; set; }

        /// <summary>
        /// Checks to see if the RunOutputUri property is set.
        /// </summary>
        internal bool IsSetRunOutputUri() => this.RunOutputUri != null;

        /// <summary>
        /// Gets and sets the property ScratchStorageMode. 
        /// <para>
        /// Optional configuration for enabling scratch ephemeral storage mounted at /tmp. If
        /// absent, this will default to SHARED. This configuration is applicable only for CPU
        /// tasks. For tasks using GPUs, scratch storage is always LOCAL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public ScratchStorageMode ScratchStorageMode { get; set; }

        /// <summary>
        /// Checks to see if the ScratchStorageMode property is set.
        /// </summary>
        internal bool IsSetScratchStorageMode() => this.ScratchStorageMode != null;

        /// <summary>
        /// Gets and sets the property SessionPolicy. Inline policy json for scoping down permissions
        /// via a session policy on the IAM role.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SessionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the SessionPolicy property is set.
        /// </summary>
        internal bool IsSetSessionPolicy() => this.SessionPolicy != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the run started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartedBy. 
        /// <para>
        /// Who started the run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string StartedBy { get; set; }

        /// <summary>
        /// Checks to see if the StartedBy property is set.
        /// </summary>
        internal bool IsSetStartedBy() => this.StartedBy != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The run's status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public RunStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The run's status message.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StopTime. 
        /// <para>
        /// The run's stop time.
        /// </para>
        /// </summary>
        public DateTime? StopTime { get; set; }

        /// <summary>
        /// Checks to see if the StopTime property is set.
        /// </summary>
        internal bool IsSetStopTime() => this.StopTime.HasValue;

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// The run's storage capacity in gibibytes. For dynamic storage, after the run has completed,
        /// this value is the maximum amount of storage used during the run.
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
        /// The run's storage type.
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
        /// The run's tags.
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
        /// Gets and sets the property Uuid. 
        /// <para>
        /// The universally unique identifier for a run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Uuid { get; set; }

        /// <summary>
        /// Checks to see if the Uuid property is set.
        /// </summary>
        internal bool IsSetUuid() => this.Uuid != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// VPC configuration for the workflow run.
        /// </para>
        /// </summary>
        public VpcConfigResponse VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The run's workflow ID.
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
        /// The ID of the workflow owner.
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
        /// The run's workflow type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public WorkflowType WorkflowType { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowType property is set.
        /// </summary>
        internal bool IsSetWorkflowType() => this.WorkflowType != null;

        /// <summary>
        /// Gets and sets the property WorkflowUuid. 
        /// <para>
        /// The universally unique identifier (UUID) value for the workflow.
        /// </para>
        /// </summary>
        public string WorkflowUuid { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowUuid property is set.
        /// </summary>
        internal bool IsSetWorkflowUuid() => this.WorkflowUuid != null;

        /// <summary>
        /// Gets and sets the property WorkflowVersionName. 
        /// <para>
        /// The workflow version name.
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
