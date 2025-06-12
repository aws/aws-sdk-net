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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// Information about a job run. A job run is a unit of work, such as a Spark JAR, Hive
    /// query, or SparkSQL query, that you submit to an Amazon EMR Serverless application.
    /// </summary>
    public partial class JobRun
    {
        private string _applicationId;
        private string _arn;
        private int? _attempt;
        private DateTime? _attemptCreatedAt;
        private DateTime? _attemptUpdatedAt;
        private ResourceUtilization _billedResourceUtilization;
        private ConfigurationOverrides _configurationOverrides;
        private DateTime? _createdAt;
        private string _createdBy;
        private DateTime? _endedAt;
        private JobRunExecutionIamPolicy _executionIamPolicy;
        private string _executionRole;
        private long? _executionTimeoutMinutes;
        private JobDriver _jobDriver;
        private string _jobRunId;
        private JobRunMode _mode;
        private string _name;
        private NetworkConfiguration _networkConfiguration;
        private long? _queuedDurationMilliseconds;
        private string _releaseLabel;
        private RetryPolicy _retryPolicy;
        private DateTime? _startedAt;
        private JobRunState _state;
        private string _stateDetails;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _totalExecutionDurationSeconds;
        private TotalResourceUtilization _totalResourceUtilization;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application the job is running on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The execution role ARN of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=1024)]
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
        /// Gets and sets the property Attempt. 
        /// <para>
        /// The attempt of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Attempt
        {
            get { return this._attempt; }
            set { this._attempt = value; }
        }

        // Check to see if Attempt property is set
        internal bool IsSetAttempt()
        {
            return this._attempt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AttemptCreatedAt. 
        /// <para>
        /// The date and time of when the job run attempt was created.
        /// </para>
        /// </summary>
        public DateTime? AttemptCreatedAt
        {
            get { return this._attemptCreatedAt; }
            set { this._attemptCreatedAt = value; }
        }

        // Check to see if AttemptCreatedAt property is set
        internal bool IsSetAttemptCreatedAt()
        {
            return this._attemptCreatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AttemptUpdatedAt. 
        /// <para>
        /// The date and time of when the job run attempt was last updated.
        /// </para>
        /// </summary>
        public DateTime? AttemptUpdatedAt
        {
            get { return this._attemptUpdatedAt; }
            set { this._attemptUpdatedAt = value; }
        }

        // Check to see if AttemptUpdatedAt property is set
        internal bool IsSetAttemptUpdatedAt()
        {
            return this._attemptUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BilledResourceUtilization. 
        /// <para>
        /// The aggregate vCPU, memory, and storage that Amazon Web Services has billed for the
        /// job run. The billed resources include a 1-minute minimum usage for workers, plus additional
        /// storage over 20 GB per worker. Note that billed resources do not include usage for
        /// idle pre-initialized workers.
        /// </para>
        /// </summary>
        public ResourceUtilization BilledResourceUtilization
        {
            get { return this._billedResourceUtilization; }
            set { this._billedResourceUtilization = value; }
        }

        // Check to see if BilledResourceUtilization property is set
        internal bool IsSetBilledResourceUtilization()
        {
            return this._billedResourceUtilization != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationOverrides. 
        /// <para>
        /// The configuration settings that are used to override default configuration.
        /// </para>
        /// </summary>
        public ConfigurationOverrides ConfigurationOverrides
        {
            get { return this._configurationOverrides; }
            set { this._configurationOverrides = value; }
        }

        // Check to see if ConfigurationOverrides property is set
        internal bool IsSetConfigurationOverrides()
        {
            return this._configurationOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the job run was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user who created the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time when the job was terminated.
        /// </para>
        /// </summary>
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionIamPolicy.
        /// </summary>
        public JobRunExecutionIamPolicy ExecutionIamPolicy
        {
            get { return this._executionIamPolicy; }
            set { this._executionIamPolicy = value; }
        }

        // Check to see if ExecutionIamPolicy property is set
        internal bool IsSetExecutionIamPolicy()
        {
            return this._executionIamPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The execution role ARN of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionTimeoutMinutes. 
        /// <para>
        /// Returns the job run timeout value from the <c>StartJobRun</c> call. If no timeout
        /// was specified, then it returns the default timeout of 720 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public long? ExecutionTimeoutMinutes
        {
            get { return this._executionTimeoutMinutes; }
            set { this._executionTimeoutMinutes = value; }
        }

        // Check to see if ExecutionTimeoutMinutes property is set
        internal bool IsSetExecutionTimeoutMinutes()
        {
            return this._executionTimeoutMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobDriver. 
        /// <para>
        /// The job driver for the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobDriver JobDriver
        {
            get { return this._jobDriver; }
            set { this._jobDriver = value; }
        }

        // Check to see if JobDriver property is set
        internal bool IsSetJobDriver()
        {
            return this._jobDriver != null;
        }

        /// <summary>
        /// Gets and sets the property JobRunId. 
        /// <para>
        /// The ID of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string JobRunId
        {
            get { return this._jobRunId; }
            set { this._jobRunId = value; }
        }

        // Check to see if JobRunId property is set
        internal bool IsSetJobRunId()
        {
            return this._jobRunId != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the job run.
        /// </para>
        /// </summary>
        public JobRunMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The optional job run name. This doesn't have to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property QueuedDurationMilliseconds. 
        /// <para>
        /// The total time for a job in the QUEUED state in milliseconds.
        /// </para>
        /// </summary>
        public long? QueuedDurationMilliseconds
        {
            get { return this._queuedDurationMilliseconds; }
            set { this._queuedDurationMilliseconds = value; }
        }

        // Check to see if QueuedDurationMilliseconds property is set
        internal bool IsSetQueuedDurationMilliseconds()
        {
            return this._queuedDurationMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The Amazon EMR release associated with the application your job is running on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ReleaseLabel
        {
            get { return this._releaseLabel; }
            set { this._releaseLabel = value; }
        }

        // Check to see if ReleaseLabel property is set
        internal bool IsSetReleaseLabel()
        {
            return this._releaseLabel != null;
        }

        /// <summary>
        /// Gets and sets the property RetryPolicy. 
        /// <para>
        /// The retry policy of the job run.
        /// </para>
        /// </summary>
        public RetryPolicy RetryPolicy
        {
            get { return this._retryPolicy; }
            set { this._retryPolicy = value; }
        }

        // Check to see if RetryPolicy property is set
        internal bool IsSetRetryPolicy()
        {
            return this._retryPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time when the job moved to the RUNNING state.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobRunState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateDetails. 
        /// <para>
        /// The state details of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string StateDetails
        {
            get { return this._stateDetails; }
            set { this._stateDetails = value; }
        }

        // Check to see if StateDetails property is set
        internal bool IsSetStateDetails()
        {
            return this._stateDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the job run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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
        /// Gets and sets the property TotalExecutionDurationSeconds. 
        /// <para>
        /// The job run total execution duration in seconds. This field is only available for
        /// job runs in a <c>COMPLETED</c>, <c>FAILED</c>, or <c>CANCELLED</c> state.
        /// </para>
        /// </summary>
        public int? TotalExecutionDurationSeconds
        {
            get { return this._totalExecutionDurationSeconds; }
            set { this._totalExecutionDurationSeconds = value; }
        }

        // Check to see if TotalExecutionDurationSeconds property is set
        internal bool IsSetTotalExecutionDurationSeconds()
        {
            return this._totalExecutionDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalResourceUtilization. 
        /// <para>
        /// The aggregate vCPU, memory, and storage resources used from the time the job starts
        /// to execute, until the time the job terminates, rounded up to the nearest second.
        /// </para>
        /// </summary>
        public TotalResourceUtilization TotalResourceUtilization
        {
            get { return this._totalResourceUtilization; }
            set { this._totalResourceUtilization = value; }
        }

        // Check to see if TotalResourceUtilization property is set
        internal bool IsSetTotalResourceUtilization()
        {
            return this._totalResourceUtilization != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the job run was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}