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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Describes the information about a task invocation for a particular target as part
    /// of a task execution performed as part of a maintenance window execution.
    /// </summary>
    public partial class MaintenanceWindowExecutionTaskInvocationIdentity
    {
        private DateTime? _endTime;
        private string _executionId;
        private string _invocationId;
        private string _ownerInformation;
        private string _parameters;
        private DateTime? _startTime;
        private MaintenanceWindowExecutionStatus _status;
        private string _statusDetails;
        private string _taskExecutionId;
        private MaintenanceWindowTaskType _taskType;
        private string _windowExecutionId;
        private string _windowTargetId;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time the invocation finished.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The ID of the action performed in the service that actually handled the task invocation.
        /// If the task type is <code>RUN_COMMAND</code>, this value is the command ID.
        /// </para>
        /// </summary>
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationId. 
        /// <para>
        /// The ID of the task invocation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string InvocationId
        {
            get { return this._invocationId; }
            set { this._invocationId = value; }
        }

        // Check to see if InvocationId property is set
        internal bool IsSetInvocationId()
        {
            return this._invocationId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerInformation. 
        /// <para>
        /// User-provided value that was specified when the target was registered with the maintenance
        /// window. This was also included in any Amazon CloudWatch Events events raised during
        /// the task invocation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string OwnerInformation
        {
            get { return this._ownerInformation; }
            set { this._ownerInformation = value; }
        }

        // Check to see if OwnerInformation property is set
        internal bool IsSetOwnerInformation()
        {
            return this._ownerInformation != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters that were provided for the invocation when it was run.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the invocation started.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
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
        /// The status of the task invocation.
        /// </para>
        /// </summary>
        public MaintenanceWindowExecutionStatus Status
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
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// The details explaining the status of the task invocation. Not available for all status
        /// values. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public string StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property TaskExecutionId. 
        /// <para>
        /// The ID of the specific task execution in the maintenance window execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string TaskExecutionId
        {
            get { return this._taskExecutionId; }
            set { this._taskExecutionId = value; }
        }

        // Check to see if TaskExecutionId property is set
        internal bool IsSetTaskExecutionId()
        {
            return this._taskExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property TaskType. 
        /// <para>
        /// The task type.
        /// </para>
        /// </summary>
        public MaintenanceWindowTaskType TaskType
        {
            get { return this._taskType; }
            set { this._taskType = value; }
        }

        // Check to see if TaskType property is set
        internal bool IsSetTaskType()
        {
            return this._taskType != null;
        }

        /// <summary>
        /// Gets and sets the property WindowExecutionId. 
        /// <para>
        /// The ID of the maintenance window execution that ran the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string WindowExecutionId
        {
            get { return this._windowExecutionId; }
            set { this._windowExecutionId = value; }
        }

        // Check to see if WindowExecutionId property is set
        internal bool IsSetWindowExecutionId()
        {
            return this._windowExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property WindowTargetId. 
        /// <para>
        /// The ID of the target definition in this maintenance window the invocation was performed
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Max=36)]
        public string WindowTargetId
        {
            get { return this._windowTargetId; }
            set { this._windowTargetId = value; }
        }

        // Check to see if WindowTargetId property is set
        internal bool IsSetWindowTargetId()
        {
            return this._windowTargetId != null;
        }

    }
}