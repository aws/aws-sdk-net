/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para>Provides details of the <c>ScheduleActivityTask</c> decision.</para> <para> <b>Access Control</b> </para> <para>You can use IAM
    /// policies to control this decision's access to Amazon SWF in much the same way as for the regular API:</para>
    /// <ul>
    /// <li>Use a <c>Resource</c> element with the domain name to limit the decision to only specified domains.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to specify this decision.</li>
    /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
    /// <ul>
    /// <li> <c>activityType.name</c> : String constraint. The key is “swf:activityType.name”.</li>
    /// <li> <c>activityType.version</c> : String constraint. The key is “swf:activityType.version”.</li>
    /// <li> <c>taskList</c> : String constraint. The key is “swf:taskList.name”.</li>
    /// 
    /// </ul>
    /// </li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails. The associated event attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
    /// and example IAM policies, see Using IAM to Manage Access to Amazon SWF Workflows.</para>
    /// </summary>
    public class ScheduleActivityTaskDecisionAttributes
    {
        
        private ActivityType activityType;
        private string activityId;
        private string control;
        private string input;
        private string scheduleToCloseTimeout;
        private TaskList taskList;
        private string scheduleToStartTimeout;
        private string startToCloseTimeout;
        private string heartbeatTimeout;

        /// <summary>
        /// The type of the activity task to schedule. This field is required.
        ///  
        /// </summary>
        public ActivityType ActivityType
        {
            get { return this.activityType; }
            set { this.activityType = value; }
        }

        /// <summary>
        /// Sets the ActivityType property
        /// </summary>
        /// <param name="activityType">The value to set for the ActivityType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduleActivityTaskDecisionAttributes WithActivityType(ActivityType activityType)
        {
            this.activityType = activityType;
            return this;
        }
            

        // Check to see if ActivityType property is set
        internal bool IsSetActivityType()
        {
            return this.activityType != null;
        }

        /// <summary>
        /// The <c>activityId</c> of the activity task. This field is required. The specified string must not start or end with whitespace. It must not
        /// contain a <c>:</c> (colon), <c>/</c> (slash), <c>|</c> (vertical bar), or any control characters (\u0000-\u001f | \u007f - \u009f). Also, it
        /// must not contain the literal string "arn".
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ActivityId
        {
            get { return this.activityId; }
            set { this.activityId = value; }
        }

        /// <summary>
        /// Sets the ActivityId property
        /// </summary>
        /// <param name="activityId">The value to set for the ActivityId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduleActivityTaskDecisionAttributes WithActivityId(string activityId)
        {
            this.activityId = activityId;
            return this;
        }
            

        // Check to see if ActivityId property is set
        internal bool IsSetActivityId()
        {
            return this.activityId != null;
        }

        /// <summary>
        /// Optional data attached to the event that can be used by the decider in subsequent workflow tasks. This data is not sent to the activity.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 32768</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Control
        {
            get { return this.control; }
            set { this.control = value; }
        }

        /// <summary>
        /// Sets the Control property
        /// </summary>
        /// <param name="control">The value to set for the Control property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduleActivityTaskDecisionAttributes WithControl(string control)
        {
            this.control = control;
            return this;
        }
            

        // Check to see if Control property is set
        internal bool IsSetControl()
        {
            return this.control != null;
        }

        /// <summary>
        /// The input provided to the activity task.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 32768</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Input
        {
            get { return this.input; }
            set { this.input = value; }
        }

        /// <summary>
        /// Sets the Input property
        /// </summary>
        /// <param name="input">The value to set for the Input property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduleActivityTaskDecisionAttributes WithInput(string input)
        {
            this.input = input;
            return this;
        }
            

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this.input != null;
        }

        /// <summary>
        /// The maximum duration for this activity task. The valid values are integers greater than or equal to <c>0</c>. An integer value can be used
        /// to specify the duration in seconds while <c>NONE</c> can be used to specify unlimited duration. <note>A schedule-to-close timeout for this
        /// activity task must be specified either as a default for the activity type or through this field. If neither this field is set nor a default
        /// schedule-to-close timeout was specified at registration time then a fault will be returned.</note>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ScheduleToCloseTimeout
        {
            get { return this.scheduleToCloseTimeout; }
            set { this.scheduleToCloseTimeout = value; }
        }

        /// <summary>
        /// Sets the ScheduleToCloseTimeout property
        /// </summary>
        /// <param name="scheduleToCloseTimeout">The value to set for the ScheduleToCloseTimeout property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduleActivityTaskDecisionAttributes WithScheduleToCloseTimeout(string scheduleToCloseTimeout)
        {
            this.scheduleToCloseTimeout = scheduleToCloseTimeout;
            return this;
        }
            

        // Check to see if ScheduleToCloseTimeout property is set
        internal bool IsSetScheduleToCloseTimeout()
        {
            return this.scheduleToCloseTimeout != null;
        }

        /// <summary>
        /// If set, specifies the name of the task list in which to schedule the activity task. If not specified, the <c>defaultTaskList</c> registered
        /// with the activity type will be used. <note>A task list for this activity task must be specified either as a default for the activity type or
        /// through this field. If neither this field is set nor a default task list was specified at registration time then a fault will be
        /// returned.</note> The specified string must not start or end with whitespace. It must not contain a <c>:</c> (colon), <c>/</c> (slash),
        /// <c>|</c> (vertical bar), or any control characters (\u0000-\u001f | \u007f - \u009f). Also, it must not contain the literal string "arn".
        ///  
        /// </summary>
        public TaskList TaskList
        {
            get { return this.taskList; }
            set { this.taskList = value; }
        }

        /// <summary>
        /// Sets the TaskList property
        /// </summary>
        /// <param name="taskList">The value to set for the TaskList property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduleActivityTaskDecisionAttributes WithTaskList(TaskList taskList)
        {
            this.taskList = taskList;
            return this;
        }
            

        // Check to see if TaskList property is set
        internal bool IsSetTaskList()
        {
            return this.taskList != null;
        }

        /// <summary>
        /// If set, specifies the maximum duration the activity task can wait to be assigned to a worker. This overrides the default schedule-to-start
        /// timeout specified when registering the activity type using <a>RegisterActivityType</a>. The valid values are integers greater than or equal
        /// to <c>0</c>. An integer value can be used to specify the duration in seconds while <c>NONE</c> can be used to specify unlimited duration.
        /// <note>A schedule-to-start timeout for this activity task must be specified either as a default for the activity type or through this field.
        /// If neither this field is set nor a default schedule-to-start timeout was specified at registration time then a fault will be
        /// returned.</note>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ScheduleToStartTimeout
        {
            get { return this.scheduleToStartTimeout; }
            set { this.scheduleToStartTimeout = value; }
        }

        /// <summary>
        /// Sets the ScheduleToStartTimeout property
        /// </summary>
        /// <param name="scheduleToStartTimeout">The value to set for the ScheduleToStartTimeout property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduleActivityTaskDecisionAttributes WithScheduleToStartTimeout(string scheduleToStartTimeout)
        {
            this.scheduleToStartTimeout = scheduleToStartTimeout;
            return this;
        }
            

        // Check to see if ScheduleToStartTimeout property is set
        internal bool IsSetScheduleToStartTimeout()
        {
            return this.scheduleToStartTimeout != null;
        }

        /// <summary>
        /// If set, specifies the maximum duration a worker may take to process this activity task. This overrides the default start-to-close timeout
        /// specified when registering the activity type using <a>RegisterActivityType</a>. The valid values are integers greater than or equal to
        /// <c>0</c>. An integer value can be used to specify the duration in seconds while <c>NONE</c> can be used to specify unlimited duration.
        /// <note>A start-to-close timeout for this activity task must be specified either as a default for the activity type or through this field. If
        /// neither this field is set nor a default start-to-close timeout was specified at registration time then a fault will be returned.</note>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StartToCloseTimeout
        {
            get { return this.startToCloseTimeout; }
            set { this.startToCloseTimeout = value; }
        }

        /// <summary>
        /// Sets the StartToCloseTimeout property
        /// </summary>
        /// <param name="startToCloseTimeout">The value to set for the StartToCloseTimeout property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduleActivityTaskDecisionAttributes WithStartToCloseTimeout(string startToCloseTimeout)
        {
            this.startToCloseTimeout = startToCloseTimeout;
            return this;
        }
            

        // Check to see if StartToCloseTimeout property is set
        internal bool IsSetStartToCloseTimeout()
        {
            return this.startToCloseTimeout != null;
        }

        /// <summary>
        /// If set, specifies the maximum time before which a worker processing a task of this type must report progress by calling
        /// <a>RecordActivityTaskHeartbeat</a>. If the timeout is exceeded, the activity task is automatically timed out. If the worker subsequently
        /// attempts to record a heartbeat or returns a result, it will be ignored. This overrides the default heartbeat timeout specified when
        /// registering the activity type using <a>RegisterActivityType</a>. The valid values are integers greater than or equal to <c>0</c>. An integer
        /// value can be used to specify the duration in seconds while <c>NONE</c> can be used to specify unlimited duration.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string HeartbeatTimeout
        {
            get { return this.heartbeatTimeout; }
            set { this.heartbeatTimeout = value; }
        }

        /// <summary>
        /// Sets the HeartbeatTimeout property
        /// </summary>
        /// <param name="heartbeatTimeout">The value to set for the HeartbeatTimeout property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScheduleActivityTaskDecisionAttributes WithHeartbeatTimeout(string heartbeatTimeout)
        {
            this.heartbeatTimeout = heartbeatTimeout;
            return this;
        }
            

        // Check to see if HeartbeatTimeout property is set
        internal bool IsSetHeartbeatTimeout()
        {
            return this.heartbeatTimeout != null;
        }
    }
}
