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
    /// Container for the parameters to the StartRun operation.
    /// Starts a workflow run. To duplicate a run, specify the run's ID and a role ARN. The
    /// remaining parameters are copied from the previous run.
    /// 
    ///  
    /// <para>
    /// StartRun will not support re-run for a workflow that is shared with you.
    /// </para>
    ///  
    /// <para>
    /// HealthOmics stores a fixed number of runs that are available to the console and API.
    /// By default, HealthOmics doesn't any remove any runs. If HealthOmics reaches the maximum
    /// number of runs, you must manually remove runs. To have older runs removed automatically,
    /// set the retention mode to <c>REMOVE</c>.
    /// </para>
    ///  
    /// <para>
    /// By default, the run uses STATIC storage. For STATIC storage, set the <c>storageCapacity</c>
    /// field. You can set the storage type to DYNAMIC. You do not set <c>storageCapacity</c>,
    /// because HealthOmics dynamically scales the storage up or down as required. For more
    /// information about static and dynamic storage, see <a href="https://docs.aws.amazon.com/omics/latest/dev/Using-workflows.html">Running
    /// workflows</a> in the <i>AWS HealthOmics User Guide</i>.
    /// </para>
    /// </summary>
    public partial class StartRunRequest : AmazonOmicsRequest
    {
        private CacheBehavior _cacheBehavior;
        private string _cacheId;
        private RunLogLevel _logLevel;
        private string _name;
        private string _outputUri;
        private Amazon.Runtime.Documents.Document _parameters;
        private int? _priority;
        private string _requestId;
        private RunRetentionMode _retentionMode;
        private string _roleArn;
        private string _runGroupId;
        private string _runId;
        private int? _storageCapacity;
        private StorageType _storageType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _workflowId;
        private string _workflowOwnerId;
        private WorkflowType _workflowType;

        /// <summary>
        /// Gets and sets the property CacheBehavior. 
        /// <para>
        /// The cache behavior for the run. You specify this value if you want to override the
        /// default behavior for the cache. You had set the default value when you created the
        /// cache. For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/how-run-cache.html#run-cache-behavior">Run
        /// cache behavior</a> in the AWS HealthOmics User Guide.
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
        /// Identifier of the cache associated with this run. If you don't specify a cache ID,
        /// no task outputs are cached for this run.
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
        /// A log level for the run.
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
        /// A name for the run.
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
        /// An output URI for the run.
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
        /// Parameters for the run.
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
        /// A priority for the run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000)]
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// To ensure that requests don't run multiple times, specify a unique ID for each request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionMode. 
        /// <para>
        /// The retention mode for the run. The default value is RETAIN. 
        /// </para>
        ///  
        /// <para>
        /// HealthOmics stores a fixed number of runs that are available to the console and API.
        /// In the default mode (RETAIN), you need to remove runs manually when the number of
        /// run exceeds the maximum. If you set the retention mode to <c>REMOVE</c>, HealthOmics
        /// automatically removes runs (that have mode set to REMOVE) when the number of run exceeds
        /// the maximum. All run logs are available in CloudWatch logs, if you need information
        /// about a run that is no longer available to the API.
        /// </para>
        ///  
        /// <para>
        /// For more information about retention mode, see <a href="https://docs.aws.amazon.com/omics/latest/dev/starting-a-run.html">Specifying
        /// run retention mode</a> in the <i>AWS HealthOmics User Guide</i>.
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
        /// A service role for the run.
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
        /// The ID of a run to duplicate.
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
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// A storage capacity for the run in gibibytes. This field is not required if the storage
        /// type is dynamic (the system ignores any value that you enter).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000)]
        public int StorageCapacity
        {
            get { return this._storageCapacity.GetValueOrDefault(); }
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
        /// The run's storage type. By default, the run uses STATIC storage type, which allocates
        /// a fixed amount of storage. If you set the storage type to DYNAMIC, HealthOmics dynamically
        /// scales the storage up or down, based on file system utilization.
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
        /// Tags for the run.
        /// </para>
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

    }
}