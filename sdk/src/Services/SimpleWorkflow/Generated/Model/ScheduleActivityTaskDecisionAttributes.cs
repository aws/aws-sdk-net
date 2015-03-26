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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides details of the <code>ScheduleActivityTask</code> decision.
    /// 
    ///  
    /// <para>
    /// <b>Access Control</b>
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this decision's access to Amazon SWF resources
    /// as follows:
    /// </para>
    ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
    /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
    /// deny permission to call this action.</li> <li>Constrain the following parameters by
    /// using a <code>Condition</code> element with the appropriate keys. <ul> <li><code>activityType.name</code>:
    /// String constraint. The key is <code>swf:activityType.name</code>.</li> <li><code>activityType.version</code>:
    /// String constraint. The key is <code>swf:activityType.version</code>.</li> <li><code>taskList</code>:
    /// String constraint. The key is <code>swf:taskList.name</code>.</li> </ul> </li> </ul>
    /// 
    /// <para>
    /// If the caller does not have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
    /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a>.
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
        /// <b>Required.</b> The <code>activityId</code> of the activity task.
        /// </para>
        ///  
        /// <para>
        /// The specified string must not start or end with whitespace. It must not contain a
        /// <code>:</code> (colon), <code>/</code> (slash), <code>|</code> (vertical bar), or
        /// any control characters (\u0000-\u001f | \u007f - \u009f). Also, it must not contain
        /// the literal string quotarnquot.
        /// </para>
        /// </summary>
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
        /// <b>Required.</b> The type of the activity task to schedule.
        /// </para>
        /// </summary>
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
        /// <i>Optional.</i> Data attached to the event that can be used by the decider in subsequent
        /// workflow tasks. This data is not sent to the activity.
        /// </para>
        /// </summary>
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
        /// attempts to record a heartbeat or returns a result, it will be ignored. This overrides
        /// the default heartbeat timeout specified when registering the activity type using <a>RegisterActivityType</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds; an integer greater than or equal to 0. The value
        /// "NONE" can be used to specify unlimited duration.
        /// </para>
        /// </summary>
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
        /// The duration is specified in seconds; an integer greater than or equal to 0. The value
        /// "NONE" can be used to specify unlimited duration.
        /// </para>
        ///  <note>A schedule-to-close timeout for this activity task must be specified either
        /// as a default for the activity type or through this field. If neither this field is
        /// set nor a default schedule-to-close timeout was specified at registration time then
        /// a fault will be returned.</note>
        /// </summary>
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
        /// <i>Optional.</i> If set, specifies the maximum duration the activity task can wait
        /// to be assigned to a worker. This overrides the default schedule-to-start timeout specified
        /// when registering the activity type using <a>RegisterActivityType</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds; an integer greater than or equal to 0. The value
        /// "NONE" can be used to specify unlimited duration.
        /// </para>
        ///  <note>A schedule-to-start timeout for this activity task must be specified either
        /// as a default for the activity type or through this field. If neither this field is
        /// set nor a default schedule-to-start timeout was specified at registration time then
        /// a fault will be returned.</note>
        /// </summary>
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
        /// The duration is specified in seconds; an integer greater than or equal to 0. The value
        /// "NONE" can be used to specify unlimited duration.
        /// </para>
        ///  <note>A start-to-close timeout for this activity task must be specified either as
        /// a default for the activity type or through this field. If neither this field is set
        /// nor a default start-to-close timeout was specified at registration time then a fault
        /// will be returned.</note>
        /// </summary>
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
        /// If not specified, the <code>defaultTaskList</code> registered with the activity type
        /// will be used.
        /// </para>
        ///  <note>A task list for this activity task must be specified either as a default for
        /// the activity type or through this field. If neither this field is set nor a default
        /// task list was specified at registration time then a fault will be returned.</note>
        /// 
        /// <para>
        /// The specified string must not start or end with whitespace. It must not contain a
        /// <code>:</code> (colon), <code>/</code> (slash), <code>|</code> (vertical bar), or
        /// any control characters (\u0000-\u001f | \u007f - \u009f). Also, it must not contain
        /// the literal string quotarnquot.
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
        /// <i>Optional.</i> If set, specifies the priority with which the activity task is to
        /// be assigned to a worker. This overrides the defaultTaskPriority specified when registering
        /// the activity type using <a>RegisterActivityType</a>. Valid values are integers that
        /// range from Java's <code>Integer.MIN_VALUE</code> (-2147483648) to <code>Integer.MAX_VALUE</code>
        /// (2147483647). Higher numbers indicate higher priority.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting task priority, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/programming-priority.html">Setting
        /// Task Priority</a> in the <i>Amazon Simple Workflow Developer Guide</i>.
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