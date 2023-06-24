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
    /// This is the response object from the GetMaintenanceWindowExecutionTask operation.
    /// </summary>
    public partial class GetMaintenanceWindowExecutionTaskResponse : AmazonWebServiceResponse
    {
        private AlarmConfiguration _alarmConfiguration;
        private DateTime? _endTime;
        private string _maxConcurrency;
        private string _maxErrors;
        private int? _priority;
        private string _serviceRole;
        private DateTime? _startTime;
        private MaintenanceWindowExecutionStatus _status;
        private string _statusDetails;
        private string _taskArn;
        private string _taskExecutionId;
        private List<Dictionary<string, MaintenanceWindowTaskParameterValueExpression>> _taskParameters = new List<Dictionary<string, MaintenanceWindowTaskParameterValueExpression>>();
        private List<AlarmStateInformation> _triggeredAlarms = new List<AlarmStateInformation>();
        private MaintenanceWindowTaskType _type;
        private string _windowExecutionId;

        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// The details for the CloudWatch alarm you applied to your maintenance window task.
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
        /// The time the task execution completed.
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
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The defined maximum number of task executions that could be run in parallel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public string MaxConcurrency
        {
            get { return this._maxConcurrency; }
            set { this._maxConcurrency = value; }
        }

        // Check to see if MaxConcurrency property is set
        internal bool IsSetMaxConcurrency()
        {
            return this._maxConcurrency != null;
        }

        /// <summary>
        /// Gets and sets the property MaxErrors. 
        /// <para>
        /// The defined maximum number of task execution errors allowed before scheduling of the
        /// task execution would have been stopped.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public string MaxErrors
        {
            get { return this._maxErrors; }
            set { this._maxErrors = value; }
        }

        // Check to see if MaxErrors property is set
        internal bool IsSetMaxErrors()
        {
            return this._maxErrors != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The role that was assumed when running the task.
        /// </para>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the task execution started.
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
        /// The status of the task.
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
        /// The details explaining the status. Not available for all status values.
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
        /// The ID of the specific task execution in the maintenance window task that was retrieved.
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
        /// Gets and sets the property TaskParameters. 
        /// <para>
        /// The parameters passed to the task when it was run.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>TaskParameters</code> has been deprecated. To specify parameters to pass to
        /// a task when it runs, instead use the <code>Parameters</code> option in the <code>TaskInvocationParameters</code>
        /// structure. For information about how Systems Manager handles these options for the
        /// supported maintenance window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The map has the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Key</code>: string, between 1 and 255 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Value</code>: an array of strings, each between 1 and 255 characters
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<Dictionary<string, MaintenanceWindowTaskParameterValueExpression>> TaskParameters
        {
            get { return this._taskParameters; }
            set { this._taskParameters = value; }
        }

        // Check to see if TaskParameters property is set
        internal bool IsSetTaskParameters()
        {
            return this._taskParameters != null && this._taskParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TriggeredAlarms. 
        /// <para>
        /// The CloudWatch alarms that were invoked by the maintenance window task.
        /// </para>
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
            return this._triggeredAlarms != null && this._triggeredAlarms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of task that was run.
        /// </para>
        /// </summary>
        public MaintenanceWindowTaskType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property WindowExecutionId. 
        /// <para>
        /// The ID of the maintenance window execution that includes the task.
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