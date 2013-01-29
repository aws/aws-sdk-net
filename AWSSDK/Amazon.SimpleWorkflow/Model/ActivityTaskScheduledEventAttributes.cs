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
    /// <para> Provides details of the <c>ActivityTaskScheduled</c> event. </para>
    /// </summary>
    public class ActivityTaskScheduledEventAttributes
    {
        
        private ActivityType activityType;
        private string activityId;
        private string input;
        private string control;
        private string scheduleToStartTimeout;
        private string scheduleToCloseTimeout;
        private string startToCloseTimeout;
        private TaskList taskList;
        private long? decisionTaskCompletedEventId;
        private string heartbeatTimeout;

        /// <summary>
        /// The type of the activity task.
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
        public ActivityTaskScheduledEventAttributes WithActivityType(ActivityType activityType)
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
        /// The unique id of the activity task.
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
        public ActivityTaskScheduledEventAttributes WithActivityId(string activityId)
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
        public ActivityTaskScheduledEventAttributes WithInput(string input)
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
        public ActivityTaskScheduledEventAttributes WithControl(string control)
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
        /// The maximum amount of time the activity task can wait to be assigned to a worker.
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
        public ActivityTaskScheduledEventAttributes WithScheduleToStartTimeout(string scheduleToStartTimeout)
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
        /// The maximum amount of time for this activity task.
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
        public ActivityTaskScheduledEventAttributes WithScheduleToCloseTimeout(string scheduleToCloseTimeout)
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
        /// The maximum amount of time a worker may take to process the activity task.
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
        public ActivityTaskScheduledEventAttributes WithStartToCloseTimeout(string startToCloseTimeout)
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
        /// The task list in which the activity task has been scheduled.
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
        public ActivityTaskScheduledEventAttributes WithTaskList(TaskList taskList)
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
        /// The id of the <c>DecisionTaskCompleted</c> event corresponding to the decision that resulted in the scheduling of this activity task. This
        /// information can be useful for diagnosing problems by tracing back the chain of events leading up to this event.
        ///  
        /// </summary>
        public long DecisionTaskCompletedEventId
        {
            get { return this.decisionTaskCompletedEventId ?? default(long); }
            set { this.decisionTaskCompletedEventId = value; }
        }

        /// <summary>
        /// Sets the DecisionTaskCompletedEventId property
        /// </summary>
        /// <param name="decisionTaskCompletedEventId">The value to set for the DecisionTaskCompletedEventId property </param>
        /// <returns>this instance</returns>
        public ActivityTaskScheduledEventAttributes WithDecisionTaskCompletedEventId(long decisionTaskCompletedEventId)
        {
            this.decisionTaskCompletedEventId = decisionTaskCompletedEventId;
            return this;
        }
            

        // Check to see if DecisionTaskCompletedEventId property is set
        internal bool IsSetDecisionTaskCompletedEventId()
        {
            return this.decisionTaskCompletedEventId.HasValue;
        }

        /// <summary>
        /// The maximum time before which the worker processing this task must report progress by calling <a>RecordActivityTaskHeartbeat</a>. If the
        /// timeout is exceeded, the activity task is automatically timed out. If the worker subsequently attempts to record a heartbeat or return a
        /// result, it will be ignored.
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
        public ActivityTaskScheduledEventAttributes WithHeartbeatTimeout(string heartbeatTimeout)
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
