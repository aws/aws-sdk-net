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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The details for a step.
    /// </summary>
    public partial class StepSummary
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private DependencyCounts _dependencyCounts;
        private DateTime? _endedAt;
        private StepLifecycleStatus _lifecycleStatus;
        private string _lifecycleStatusMessage;
        private string _name;
        private DateTime? _startedAt;
        private string _stepId;
        private StepTargetTaskRunStatus _targetTaskRunStatus;
        private int? _taskFailureRetryCount;
        private TaskRunStatus _taskRunStatus;
        private Dictionary<string, int> _taskRunStatusCounts = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the resource was created.
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
        /// Gets and sets the property DependencyCounts. 
        /// <para>
        /// The number of dependencies for the step.
        /// </para>
        /// </summary>
        public DependencyCounts DependencyCounts
        {
            get { return this._dependencyCounts; }
            set { this._dependencyCounts = value; }
        }

        // Check to see if DependencyCounts property is set
        internal bool IsSetDependencyCounts()
        {
            return this._dependencyCounts != null;
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time the resource ended running.
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
        /// Gets and sets the property LifecycleStatus. 
        /// <para>
        /// The life cycle status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A message that describes the lifecycle of the step.
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
        /// The name of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time the resource started running.
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
        /// Gets and sets the property StepId. 
        /// <para>
        /// The step ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TaskFailureRetryCount. 
        /// <para>
        /// The total number of times tasks from the step failed and were retried.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? TaskFailureRetryCount
        {
            get { return this._taskFailureRetryCount; }
            set { this._taskFailureRetryCount = value; }
        }

        // Check to see if TaskFailureRetryCount property is set
        internal bool IsSetTaskFailureRetryCount()
        {
            return this._taskFailureRetryCount.HasValue; 
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
        ///  <c>READY</c>–ready to process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ASSIGNED</c>–assigned and will run next on a worker.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SCHEDULED</c>–scheduled to run on a worker.
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
        [AWSProperty(Required=true)]
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the resource was updated.
        /// </para>
        /// </summary>
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