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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
        private CacheBehavior _cacheBehavior;
        private string _cacheId;
        private RunLogLevel _logLevel;
        private string _name;
        private string _outputBucketOwnerId;
        private string _outputUri;
        private Amazon.Runtime.Documents.Document _parameters;
        private int? _priority;
        private RunRetentionMode _retentionMode;
        private string _roleArn;
        private string _runGroupId;
        private Dictionary<string, string> _runTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _storageCapacity;
        private StorageType _storageType;
        private string _workflowId;
        private string _workflowOwnerId;
        private WorkflowType _workflowType;
        private string _workflowVersionName;

        /// <summary>
        /// Gets and sets the property CacheBehavior. 
        /// <para>
        /// The cache behavior for the runs. Requires <c>cacheId</c> to be set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public CacheBehavior CacheBehavior
        {
            get { return this._cacheBehavior; }
            set { this._cacheBehavior = value; }
        }

        // Check to see if CacheBehavior property is set
        internal bool IsSetCacheBehavior()
        {
            return this._cacheBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property CacheId. 
        /// <para>
        /// The identifier of the run cache to associate with the runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=18)]
        public string CacheId
        {
            get { return this._cacheId; }
            set { this._cacheId = value; }
        }

        // Check to see if CacheId property is set
        internal bool IsSetCacheId()
        {
            return this._cacheId != null;
        }

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// The verbosity level for CloudWatch Logs emitted during each run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public RunLogLevel LogLevel
        {
            get { return this._logLevel; }
            set { this._logLevel = value; }
        }

        // Check to see if LogLevel property is set
        internal bool IsSetLogLevel()
        {
            return this._logLevel != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An optional user-friendly name applied to each workflow run. Can be overridden per
        /// run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property OutputBucketOwnerId. 
        /// <para>
        /// The expected AWS account ID of the owner of the output S3 bucket. Can be overridden
        /// per run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string OutputBucketOwnerId
        {
            get { return this._outputBucketOwnerId; }
            set { this._outputBucketOwnerId = value; }
        }

        // Check to see if OutputBucketOwnerId property is set
        internal bool IsSetOutputBucketOwnerId()
        {
            return this._outputBucketOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputUri. 
        /// <para>
        /// The destination S3 URI for workflow outputs. Must begin with <c>s3://</c>. The <c>roleArn</c>
        /// must grant write permissions to this bucket. Can be overridden per run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=750)]
        public string OutputUri
        {
            get { return this._outputUri; }
            set { this._outputUri = value; }
        }

        // Check to see if OutputUri property is set
        internal bool IsSetOutputUri()
        {
            return this._outputUri != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Workflow parameter names and values shared across all runs. Merged with per-run parameters;
        /// run-specific values take precedence when keys overlap. Can be overridden per run.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return !this._parameters.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// An integer priority for the workflow runs. Higher values correspond to higher priority.
        /// A value of 0 corresponds to the lowest priority. Can be overridden per run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetentionMode. 
        /// <para>
        /// The retention behavior for runs after completion.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public RunRetentionMode RetentionMode
        {
            get { return this._retentionMode; }
            set { this._retentionMode = value; }
        }

        // Check to see if RetentionMode property is set
        internal bool IsSetRetentionMode()
        {
            return this._retentionMode != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role ARN that grants HealthOmics permissions to access required AWS resources
        /// such as Amazon S3 and CloudWatch. The role must have the same permissions required
        /// for individual <c>StartRun</c> calls.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RunGroupId. 
        /// <para>
        /// The ID of the run group to contain all workflow runs in the batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=18)]
        public string RunGroupId
        {
            get { return this._runGroupId; }
            set { this._runGroupId = value; }
        }

        // Check to see if RunGroupId property is set
        internal bool IsSetRunGroupId()
        {
            return this._runGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property RunTags. 
        /// <para>
        /// AWS tags to associate with each workflow run. Merged with per-run <c>runTags</c>;
        /// run-specific values take precedence when keys overlap.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RunTags
        {
            get { return this._runTags; }
            set { this._runTags = value; }
        }

        // Check to see if RunTags property is set
        internal bool IsSetRunTags()
        {
            return this._runTags != null && (this._runTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// The filesystem size in gibibytes (GiB) provisioned for each workflow run and shared
        /// by all tasks in that run. Defaults to 1200 GiB if not specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000)]
        public int? StorageCapacity
        {
            get { return this._storageCapacity; }
            set { this._storageCapacity = value; }
        }

        // Check to see if StorageCapacity property is set
        internal bool IsSetStorageCapacity()
        {
            return this._storageCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type for the workflow runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public StorageType StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The identifier of the workflow to run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=18)]
        public string WorkflowId
        {
            get { return this._workflowId; }
            set { this._workflowId = value; }
        }

        // Check to see if WorkflowId property is set
        internal bool IsSetWorkflowId()
        {
            return this._workflowId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowOwnerId. 
        /// <para>
        /// The AWS account ID of the workflow owner, used for cross-account workflow sharing.
        /// </para>
        /// </summary>
        public string WorkflowOwnerId
        {
            get { return this._workflowOwnerId; }
            set { this._workflowOwnerId = value; }
        }

        // Check to see if WorkflowOwnerId property is set
        internal bool IsSetWorkflowOwnerId()
        {
            return this._workflowOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowType. 
        /// <para>
        /// The type of the originating workflow. Batch runs are not supported with <c>READY2RUN</c>
        /// workflows.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public WorkflowType WorkflowType
        {
            get { return this._workflowType; }
            set { this._workflowType = value; }
        }

        // Check to see if WorkflowType property is set
        internal bool IsSetWorkflowType()
        {
            return this._workflowType != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowVersionName. 
        /// <para>
        /// The version name of the specified workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string WorkflowVersionName
        {
            get { return this._workflowVersionName; }
            set { this._workflowVersionName = value; }
        }

        // Check to see if WorkflowVersionName property is set
        internal bool IsSetWorkflowVersionName()
        {
            return this._workflowVersionName != null;
        }

    }
}