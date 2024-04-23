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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The details of a step search.
    /// </summary>
    public partial class StepSearchSummary
    {
        private DateTime? _createdAt;
        private DateTime? _endedAt;
        private string _jobId;
        private StepLifecycleStatus _lifecycleStatus;
        private string _lifecycleStatusMessage;
        private string _name;
        private ParameterSpace _parameterSpace;
        private string _queueId;
        private DateTime? _startedAt;
        private string _stepId;
        private StepTargetTaskRunStatus _targetTaskRunStatus;
        private TaskRunStatus _taskRunStatus;
        private Dictionary<string, int> _taskRunStatusCounts = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the resource was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
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
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time the resource ended running.
        /// </para>
        /// </summary>
        public DateTime EndedAt
        {
            get { return this._endedAt.GetValueOrDefault(); }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID.
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
        /// Gets and sets the property LifecycleStatus. 
        /// <para>
        /// The life cycle status.
        /// </para>
        /// </summary>
        public StepLifecycleStatus LifecycleStatus
        {
            get { return this._lifecycleStatus; }
            set { this._lifecycleStatus = value; }
        }

        // Check to see if LifecycleStatus property is set
        internal bool IsSetLifecycleStatus()
        {
            return this._lifecycleStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleStatusMessage. 
        /// <para>
        /// The life cycle status message.
        /// </para>
        /// </summary>
        public string LifecycleStatusMessage
        {
            get { return this._lifecycleStatusMessage; }
            set { this._lifecycleStatusMessage = value; }
        }

        // Check to see if LifecycleStatusMessage property is set
        internal bool IsSetLifecycleStatusMessage()
        {
            return this._lifecycleStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The step name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ParameterSpace. 
        /// <para>
        /// The parameters and combination expressions for the search.
        /// </para>
        /// </summary>
        public ParameterSpace ParameterSpace
        {
            get { return this._parameterSpace; }
            set { this._parameterSpace = value; }
        }

        // Check to see if ParameterSpace property is set
        internal bool IsSetParameterSpace()
        {
            return this._parameterSpace != null;
        }

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The queue ID.
        /// </para>
        /// </summary>
        public string QueueId
        {
            get { return this._queueId; }
            set { this._queueId = value; }
        }

        // Check to see if QueueId property is set
        internal bool IsSetQueueId()
        {
            return this._queueId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time the resource started running.
        /// </para>
        /// </summary>
        public DateTime StartedAt
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
        /// Gets and sets the property StepId. 
        /// <para>
        /// The step ID.
        /// </para>
        /// </summary>
        public string StepId
        {
            get { return this._stepId; }
            set { this._stepId = value; }
        }

        // Check to see if StepId property is set
        internal bool IsSetStepId()
        {
            return this._stepId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTaskRunStatus. 
        /// <para>
        /// The task status to start with on the job.
        /// </para>
        /// </summary>
        public StepTargetTaskRunStatus TargetTaskRunStatus
        {
            get { return this._targetTaskRunStatus; }
            set { this._targetTaskRunStatus = value; }
        }

        // Check to see if TargetTaskRunStatus property is set
        internal bool IsSetTargetTaskRunStatus()
        {
            return this._targetTaskRunStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TaskRunStatus. 
        /// <para>
        /// The task run status for the job.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c>–pending and waiting for resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READY</c>–ready to be processed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ASSIGNED</c>–assigned and will run next on a worker.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SCHEDULED</c>–scheduled to be run on a worker.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTERRUPTING</c>–being interrupted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c>–running on a worker.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUSPENDED</c>–the task is suspended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELED</c>–the task has been canceled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>–the task has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c>–the task has succeeded.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TaskRunStatus TaskRunStatus
        {
            get { return this._taskRunStatus; }
            set { this._taskRunStatus = value; }
        }

        // Check to see if TaskRunStatus property is set
        internal bool IsSetTaskRunStatus()
        {
            return this._taskRunStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TaskRunStatusCounts. 
        /// <para>
        /// The number of tasks running on the job.
        /// </para>
        /// </summary>
        public Dictionary<string, int> TaskRunStatusCounts
        {
            get { return this._taskRunStatusCounts; }
            set { this._taskRunStatusCounts = value; }
        }

        // Check to see if TaskRunStatusCounts property is set
        internal bool IsSetTaskRunStatusCounts()
        {
            return this._taskRunStatusCounts != null && (this._taskRunStatusCounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}