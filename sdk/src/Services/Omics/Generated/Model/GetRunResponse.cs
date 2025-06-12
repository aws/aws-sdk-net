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
    /// This is the response object from the GetRun operation.
    /// </summary>
    public partial class GetRunResponse : AmazonWebServiceResponse
    {
        private Accelerators _accelerators;
        private string _arn;
        private CacheBehavior _cacheBehavior;
        private string _cacheId;
        private DateTime? _creationTime;
        private string _definition;
        private string _digest;
        private string _engineVersion;
        private string _failureReason;
        private string _id;
        private RunLogLevel _logLevel;
        private RunLogLocation _logLocation;
        private string _name;
        private string _outputUri;
        private Amazon.Runtime.Documents.Document _parameters;
        private int? _priority;
        private Dictionary<string, string> _resourceDigests = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private RunRetentionMode _retentionMode;
        private string _roleArn;
        private string _runGroupId;
        private string _runId;
        private string _runOutputUri;
        private string _startedBy;
        private DateTime? _startTime;
        private RunStatus _status;
        private string _statusMessage;
        private DateTime? _stopTime;
        private int? _storageCapacity;
        private StorageType _storageType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _uuid;
        private string _workflowId;
        private string _workflowOwnerId;
        private WorkflowType _workflowType;
        private string _workflowUuid;
        private string _workflowVersionName;

        /// <summary>
        /// Gets and sets the property Accelerators. 
        /// <para>
        /// The computational accelerator used to run the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public Accelerators Accelerators
        {
            get { return this._accelerators; }
            set { this._accelerators = value; }
        }

        // Check to see if Accelerators property is set
        internal bool IsSetAccelerators()
        {
            return this._accelerators != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The run's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property CacheBehavior. 
        /// <para>
        /// The run cache behavior for the run.
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
        /// The run cache associated with the run.
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the run was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The run's definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property Digest. 
        /// <para>
        /// The run's digest.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Digest
        {
            get { return this._digest; }
            set { this._digest = value; }
        }

        // Check to see if Digest property is set
        internal bool IsSetDigest()
        {
            return this._digest != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The actual Nextflow engine version that Amazon Web Services HealthOmics used for the
        /// run. The other workflow definition languages don't provide a value for this field.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason a run has failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The run's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=18)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// The run's log level.
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
        /// Gets and sets the property LogLocation. 
        /// <para>
        /// The location of the run log.
        /// </para>
        /// </summary>
        public RunLogLocation LogLocation
        {
            get { return this._logLocation; }
            set { this._logLocation = value; }
        }

        // Check to see if LogLocation property is set
        internal bool IsSetLogLocation()
        {
            return this._logLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The run's name.
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
        /// Gets and sets the property OutputUri. 
        /// <para>
        /// The run's output URI.
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
        /// The run's parameters.
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
        /// The run's priority.
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
        /// Gets and sets the property ResourceDigests. 
        /// <para>
        /// The run's resource digests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ResourceDigests
        {
            get { return this._resourceDigests; }
            set { this._resourceDigests = value; }
        }

        // Check to see if ResourceDigests property is set
        internal bool IsSetResourceDigests()
        {
            return this._resourceDigests != null && (this._resourceDigests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RetentionMode. 
        /// <para>
        /// The run's retention mode.
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
        /// The run's service role ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// The run's group ID.
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
        /// Gets and sets the property RunId. 
        /// <para>
        /// The run's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=18)]
        public string RunId
        {
            get { return this._runId; }
            set { this._runId = value; }
        }

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this._runId != null;
        }

        /// <summary>
        /// Gets and sets the property RunOutputUri. 
        /// <para>
        /// The destination for workflow outputs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=750)]
        public string RunOutputUri
        {
            get { return this._runOutputUri; }
            set { this._runOutputUri = value; }
        }

        // Check to see if RunOutputUri property is set
        internal bool IsSetRunOutputUri()
        {
            return this._runOutputUri != null;
        }

        /// <summary>
        /// Gets and sets the property StartedBy. 
        /// <para>
        /// Who started the run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string StartedBy
        {
            get { return this._startedBy; }
            set { this._startedBy = value; }
        }

        // Check to see if StartedBy property is set
        internal bool IsSetStartedBy()
        {
            return this._startedBy != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the run started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The run's status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public RunStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The run's status message.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property StopTime. 
        /// <para>
        /// The run's stop time.
        /// </para>
        /// </summary>
        public DateTime? StopTime
        {
            get { return this._stopTime; }
            set { this._stopTime = value; }
        }

        // Check to see if StopTime property is set
        internal bool IsSetStopTime()
        {
            return this._stopTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// The run's storage capacity in gibibytes. For dynamic storage, after the run has completed,
        /// this value is the maximum amount of storage used during the run.
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
        /// The run's storage type.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The run's tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Uuid. 
        /// <para>
        /// The universally unique identifier for a run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Uuid
        {
            get { return this._uuid; }
            set { this._uuid = value; }
        }

        // Check to see if Uuid property is set
        internal bool IsSetUuid()
        {
            return this._uuid != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The run's workflow ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=18)]
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
        /// The ID of the workflow owner.
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
        /// The run's workflow type.
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
        /// Gets and sets the property WorkflowUuid. 
        /// <para>
        /// The universally unique identifier (UUID) value for the workflow.
        /// </para>
        /// </summary>
        public string WorkflowUuid
        {
            get { return this._workflowUuid; }
            set { this._workflowUuid = value; }
        }

        // Check to see if WorkflowUuid property is set
        internal bool IsSetWorkflowUuid()
        {
            return this._workflowUuid != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowVersionName. 
        /// <para>
        /// The workflow version name.
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