/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object representing an AWS Batch job.
    /// </summary>
    public partial class JobDetail
    {
        private ArrayPropertiesDetail _arrayProperties;
        private List<AttemptDetail> _attempts = new List<AttemptDetail>();
        private ContainerDetail _container;
        private long? _createdAt;
        private List<JobDependency> _dependsOn = new List<JobDependency>();
        private string _jobDefinition;
        private string _jobId;
        private string _jobName;
        private string _jobQueue;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private RetryStrategy _retryStrategy;
        private long? _startedAt;
        private JobStatus _status;
        private string _statusReason;
        private long? _stoppedAt;
        private JobTimeout _timeout;

        /// <summary>
        /// Gets and sets the property ArrayProperties. 
        /// <para>
        /// The array properties of the job, if it is an array job.
        /// </para>
        /// </summary>
        public ArrayPropertiesDetail ArrayProperties
        {
            get { return this._arrayProperties; }
            set { this._arrayProperties = value; }
        }

        // Check to see if ArrayProperties property is set
        internal bool IsSetArrayProperties()
        {
            return this._arrayProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Attempts. 
        /// <para>
        /// A list of job attempts associated with this job.
        /// </para>
        /// </summary>
        public List<AttemptDetail> Attempts
        {
            get { return this._attempts; }
            set { this._attempts = value; }
        }

        // Check to see if Attempts property is set
        internal bool IsSetAttempts()
        {
            return this._attempts != null && this._attempts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// An object representing the details of the container that is associated with the job.
        /// </para>
        /// </summary>
        public ContainerDetail Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this._container != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix time stamp (in seconds and milliseconds) for when the job was created. For
        /// non-array jobs and parent array jobs, this is when the job entered the <code>SUBMITTED</code>
        /// state (at the time <a>SubmitJob</a> was called). For array child jobs, this is when
        /// the child job was spawned by its parent and entered the <code>PENDING</code> state.
        /// </para>
        /// </summary>
        public long CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// A list of job names or IDs on which this job depends.
        /// </para>
        /// </summary>
        public List<JobDependency> DependsOn
        {
            get { return this._dependsOn; }
            set { this._dependsOn = value; }
        }

        // Check to see if DependsOn property is set
        internal bool IsSetDependsOn()
        {
            return this._dependsOn != null && this._dependsOn.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JobDefinition. 
        /// <para>
        /// The job definition that is used by this job.
        /// </para>
        /// </summary>
        public string JobDefinition
        {
            get { return this._jobDefinition; }
            set { this._jobDefinition = value; }
        }

        // Check to see if JobDefinition property is set
        internal bool IsSetJobDefinition()
        {
            return this._jobDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID for the job.
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job.
        /// </para>
        /// </summary>
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobQueue. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job queue with which the job is associated.
        /// </para>
        /// </summary>
        public string JobQueue
        {
            get { return this._jobQueue; }
            set { this._jobQueue = value; }
        }

        // Check to see if JobQueue property is set
        internal bool IsSetJobQueue()
        {
            return this._jobQueue != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Additional parameters passed to the job that replace parameter substitution placeholders
        /// or override any corresponding parameter defaults from the job definition. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// The retry strategy to use for this job if an attempt fails.
        /// </para>
        /// </summary>
        public RetryStrategy RetryStrategy
        {
            get { return this._retryStrategy; }
            set { this._retryStrategy = value; }
        }

        // Check to see if RetryStrategy property is set
        internal bool IsSetRetryStrategy()
        {
            return this._retryStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The Unix time stamp (in seconds and milliseconds) for when the job was started (when
        /// the job transitioned from the <code>STARTING</code> state to the <code>RUNNING</code>
        /// state).
        /// </para>
        /// </summary>
        public long StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status for the job.
        /// </para>
        /// </summary>
        public JobStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short, human-readable string to provide additional details about the current status
        /// of the job. 
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The Unix time stamp (in seconds and milliseconds) for when the job was stopped (when
        /// the job transitioned from the <code>RUNNING</code> state to a terminal state, such
        /// as <code>SUCCEEDED</code> or <code>FAILED</code>).
        /// </para>
        /// </summary>
        public long StoppedAt
        {
            get { return this._stoppedAt.GetValueOrDefault(); }
            set { this._stoppedAt = value; }
        }

        // Check to see if StoppedAt property is set
        internal bool IsSetStoppedAt()
        {
            return this._stoppedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The timeout configuration for the job. 
        /// </para>
        /// </summary>
        public JobTimeout Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout != null;
        }

    }
}