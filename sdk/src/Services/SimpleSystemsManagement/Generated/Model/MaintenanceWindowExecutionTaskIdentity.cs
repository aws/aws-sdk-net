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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about a task execution performed as part of a maintenance window execution.
    /// </summary>
    public partial class MaintenanceWindowExecutionTaskIdentity
    {
        private AlarmConfiguration _alarmConfiguration;
        private DateTime? _endTime;
        private DateTime? _startTime;
        private MaintenanceWindowExecutionStatus _status;
        private string _statusDetails;
        private string _taskArn;
        private string _taskExecutionId;
        private MaintenanceWindowTaskType _taskType;
        private List<AlarmStateInformation> _triggeredAlarms = AWSConfigs.InitializeCollections ? new List<AlarmStateInformation>() : null;
        private string _windowExecutionId;

        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// The details for the CloudWatch alarm applied to your maintenance window task.
        /// </para>
        /// </summary>
        public AlarmConfiguration AlarmConfiguration
        {
            get { return this._alarmConfiguration; }
            set { this._alarmConfiguration = value; }
        }

        // Check to see if AlarmConfiguration property is set
        internal bool IsSetAlarmConfiguration()
        {
            return this._alarmConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time the task execution finished.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the task execution started.
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
        /// The status of the task execution.
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
        /// The details explaining the status of the task execution. Not available for all status
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
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task that ran.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
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
        /// The type of task that ran.
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
        /// Gets and sets the property TriggeredAlarms. 
        /// <para>
        /// The CloudWatch alarm that was invoked by the maintenance window task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<AlarmStateInformation> TriggeredAlarms
        {
            get { return this._triggeredAlarms; }
            set { this._triggeredAlarms = value; }
        }

        // Check to see if TriggeredAlarms property is set
        internal bool IsSetTriggeredAlarms()
        {
            return this._triggeredAlarms != null && (this._triggeredAlarms.Count > 0 || !AWSConfigs.InitializeCollections); 
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

    }
}