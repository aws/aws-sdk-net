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
    /// The details of a task.
    /// </summary>
    public partial class TaskSummary
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private DateTime? _endedAt;
        private int? _failureRetryCount;
        private string _latestSessionActionId;
        private Dictionary<string, TaskParameterValue> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, TaskParameterValue>() : null;
        private TaskRunStatus _runStatus;
        private DateTime? _startedAt;
        private TaskTargetRunStatus _targetRunStatus;
        private string _taskId;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user or system that created this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property FailureRetryCount. 
        /// <para>
        /// The number of times that the task failed and was retried.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int FailureRetryCount
        {
            get { return this._failureRetryCount.GetValueOrDefault(); }
            set { this._failureRetryCount = value; }
        }

        // Check to see if FailureRetryCount property is set
        internal bool IsSetFailureRetryCount()
        {
            return this._failureRetryCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestSessionActionId. 
        /// <para>
        /// The latest session action for the task.
        /// </para>
        /// </summary>
        public string LatestSessionActionId
        {
            get { return this._latestSessionActionId; }
            set { this._latestSessionActionId = value; }
        }

        // Check to see if LatestSessionActionId property is set
        internal bool IsSetLatestSessionActionId()
        {
            return this._latestSessionActionId != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The task parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, TaskParameterValue> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RunStatus. 
        /// <para>
        /// The run status of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TaskRunStatus RunStatus
        {
            get { return this._runStatus; }
            set { this._runStatus = value; }
        }

        // Check to see if RunStatus property is set
        internal bool IsSetRunStatus()
        {
            return this._runStatus != null;
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
        /// Gets and sets the property TargetRunStatus. 
        /// <para>
        /// The run status on which the started.
        /// </para>
        /// </summary>
        public TaskTargetRunStatus TargetRunStatus
        {
            get { return this._targetRunStatus; }
            set { this._targetRunStatus = value; }
        }

        // Check to see if TargetRunStatus property is set
        internal bool IsSetTargetRunStatus()
        {
            return this._targetRunStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The task ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the resource was updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user or system that updated this resource.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

    }
}