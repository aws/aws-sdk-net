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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
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
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides the details of the <c>ScheduleActivityTask</c> decision.
    /// 
    ///  
    /// <para>
    ///  <b>Access Control</b> 
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this decision's access to Amazon SWF resources
    /// as follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use a <c>Resource</c> element with the domain name to limit the action to only specified
    /// domains.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use an <c>Action</c> element to allow or deny permission to call this action.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Constrain the following parameters by using a <c>Condition</c> element with the appropriate
    /// keys.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>activityType.name</c> – String constraint. The key is <c>swf:activityType.name</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>activityType.version</c> – String constraint. The key is <c>swf:activityType.version</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>taskList</c> – String constraint. The key is <c>swf:taskList.name</c>.
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <c>cause</c> parameter is set to <c>OPERATION_NOT_PERMITTED</c>. For details
    /// and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ScheduleActivityTaskDecisionAttributes
    {
        private string _activityId;
        private ActivityType _activityType;
        private string _control;
        private string _heartbeatTimeout;
        private string _input;
        private string _scheduleToCloseTimeout;
        private string _scheduleToStartTimeout;
        private string _startToCloseTimeout;
        private TaskList _taskList;
        private string _taskPriority;

        /// <summary>
        /// Gets and sets the property ActivityId. 
        /// <para>
        ///  The <c>activityId</c> of the activity task.
        /// </para>
        ///  
        /// <para>
        /// The specified string must not contain a <c>:</c> (colon), <c>/</c> (slash), <c>|</c>
        /// (vertical bar), or any control characters (<c>\u0000-\u001f</c> | <c>\u007f-\u009f</c>).
        /// Also, it must <i>not</i> be the literal string <c>arn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ActivityId
        {
            get { return this._activityId; }
            set { this._activityId = value; }
        }

        // Check to see if ActivityId property is set
        internal bool IsSetActivityId()
        {
            return this._activityId != null;
        }

        /// <summary>
        /// Gets and sets the property ActivityType. 
        /// <para>
        ///  The type of the activity task to schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActivityType ActivityType
        {
            get { return this._activityType; }
            set { this._activityType = value; }
        }

        // Check to see if ActivityType property is set
        internal bool IsSetActivityType()
        {
            return this._activityType != null;
        }

        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        /// Data attached to the event that can be used by the decider in subsequent workflow
        /// tasks. This data isn't sent to the activity.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string Control
        {
            get { return this._control; }
            set { this._control = value; }
        }

        // Check to see if Control property is set
        internal bool IsSetControl()
        {
            return this._control != null;
        }

        /// <summary>
        /// Gets and sets the property HeartbeatTimeout. 
        /// <para>
        /// If set, specifies the maximum time before which a worker processing a task of this
        /// type must report progress by calling <a>RecordActivityTaskHeartbeat</a>. If the timeout
        /// is exceeded, the activity task is automatically timed out. If the worker subsequently
        /// attempts to record a heartbeat or returns a result, it is ignored. This overrides
        /// the default heartbeat timeout specified when registering the activity type using <a>RegisterActivityType</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8)]
        public string HeartbeatTimeout
        {
            get { return this._heartbeatTimeout; }
            set { this._heartbeatTimeout = value; }
        }

        // Check to see if HeartbeatTimeout property is set
        internal bool IsSetHeartbeatTimeout()
        {
            return this._heartbeatTimeout != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The input provided to the activity task.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleToCloseTimeout. 
        /// <para>
        /// The maximum duration for this activity task.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        ///  <note> 
        /// <para>
        /// A schedule-to-close timeout for this activity task must be specified either as a default
        /// for the activity type or through this field. If neither this field is set nor a default
        /// schedule-to-close timeout was specified at registration time then a fault is returned.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=8)]
        public string ScheduleToCloseTimeout
        {
            get { return this._scheduleToCloseTimeout; }
            set { this._scheduleToCloseTimeout = value; }
        }

        // Check to see if ScheduleToCloseTimeout property is set
        internal bool IsSetScheduleToCloseTimeout()
        {
            return this._scheduleToCloseTimeout != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleToStartTimeout. 
        /// <para>
        ///  If set, specifies the maximum duration the activity task can wait to be assigned
        /// to a worker. This overrides the default schedule-to-start timeout specified when registering
        /// the activity type using <a>RegisterActivityType</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        ///  <note> 
        /// <para>
        /// A schedule-to-start timeout for this activity task must be specified either as a default
        /// for the activity type or through this field. If neither this field is set nor a default
        /// schedule-to-start timeout was specified at registration time then a fault is returned.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=8)]
        public string ScheduleToStartTimeout
        {
            get { return this._scheduleToStartTimeout; }
            set { this._scheduleToStartTimeout = value; }
        }

        // Check to see if ScheduleToStartTimeout property is set
        internal bool IsSetScheduleToStartTimeout()
        {
            return this._scheduleToStartTimeout != null;
        }

        /// <summary>
        /// Gets and sets the property StartToCloseTimeout. 
        /// <para>
        /// If set, specifies the maximum duration a worker may take to process this activity
        /// task. This overrides the default start-to-close timeout specified when registering
        /// the activity type using <a>RegisterActivityType</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        ///  <note> 
        /// <para>
        /// A start-to-close timeout for this activity task must be specified either as a default
        /// for the activity type or through this field. If neither this field is set nor a default
        /// start-to-close timeout was specified at registration time then a fault is returned.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=8)]
        public string StartToCloseTimeout
        {
            get { return this._startToCloseTimeout; }
            set { this._startToCloseTimeout = value; }
        }

        // Check to see if StartToCloseTimeout property is set
        internal bool IsSetStartToCloseTimeout()
        {
            return this._startToCloseTimeout != null;
        }

        /// <summary>
        /// Gets and sets the property TaskList. 
        /// <para>
        /// If set, specifies the name of the task list in which to schedule the activity task.
        /// If not specified, the <c>defaultTaskList</c> registered with the activity type is
        /// used.
        /// </para>
        ///  <note> 
        /// <para>
        /// A task list for this activity task must be specified either as a default for the activity
        /// type or through this field. If neither this field is set nor a default task list was
        /// specified at registration time then a fault is returned.
        /// </para>
        ///  </note> 
        /// <para>
        /// The specified string must not contain a <c>:</c> (colon), <c>/</c> (slash), <c>|</c>
        /// (vertical bar), or any control characters (<c>\u0000-\u001f</c> | <c>\u007f-\u009f</c>).
        /// Also, it must <i>not</i> be the literal string <c>arn</c>.
        /// </para>
        /// </summary>
        public TaskList TaskList
        {
            get { return this._taskList; }
            set { this._taskList = value; }
        }

        // Check to see if TaskList property is set
        internal bool IsSetTaskList()
        {
            return this._taskList != null;
        }

        /// <summary>
        /// Gets and sets the property TaskPriority. 
        /// <para>
        ///  If set, specifies the priority with which the activity task is to be assigned to
        /// a worker. This overrides the defaultTaskPriority specified when registering the activity
        /// type using <a>RegisterActivityType</a>. Valid values are integers that range from
        /// Java's <c>Integer.MIN_VALUE</c> (-2147483648) to <c>Integer.MAX_VALUE</c> (2147483647).
        /// Higher numbers indicate higher priority.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting task priority, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/programming-priority.html">Setting
        /// Task Priority</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        public string TaskPriority
        {
            get { return this._taskPriority; }
            set { this._taskPriority = value; }
        }

        // Check to see if TaskPriority property is set
        internal bool IsSetTaskPriority()
        {
            return this._taskPriority != null;
        }

    }
}