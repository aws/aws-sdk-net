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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Provides the details of the <c>ActivityTaskScheduled</c> event.
    /// </summary>
    public partial class ActivityTaskScheduledEventAttributes
    {
        /// <summary>
        /// Gets and sets the property ActivityId. 
        /// <para>
        /// The unique ID of the activity task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Checks to see if the ActivityId property is set.
        /// </summary>
        internal bool IsSetActivityId() => this.ActivityId != null;

        /// <summary>
        /// Gets and sets the property ActivityType. 
        /// <para>
        /// The type of the activity task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActivityType ActivityType { get; set; }

        /// <summary>
        /// Checks to see if the ActivityType property is set.
        /// </summary>
        internal bool IsSetActivityType() => this.ActivityType != null;

        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        /// Data attached to the event that can be used by the decider in subsequent workflow
        /// tasks. This data isn't sent to the activity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string Control { get; set; }

        /// <summary>
        /// Checks to see if the Control property is set.
        /// </summary>
        internal bool IsSetControl() => this.Control != null;

        /// <summary>
        /// Gets and sets the property DecisionTaskCompletedEventId. 
        /// <para>
        /// The ID of the <c>DecisionTaskCompleted</c> event corresponding to the decision that
        /// resulted in the scheduling of this activity task. This information can be useful for
        /// diagnosing problems by tracing back the chain of events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? DecisionTaskCompletedEventId { get; set; }

        /// <summary>
        /// Checks to see if the DecisionTaskCompletedEventId property is set.
        /// </summary>
        internal bool IsSetDecisionTaskCompletedEventId() => this.DecisionTaskCompletedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property HeartbeatTimeout. 
        /// <para>
        /// The maximum time before which the worker processing this task must report progress
        /// by calling <a>RecordActivityTaskHeartbeat</a>. If the timeout is exceeded, the activity
        /// task is automatically timed out. If the worker subsequently attempts to record a heartbeat
        /// or return a result, it is ignored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public string HeartbeatTimeout { get; set; }

        /// <summary>
        /// Checks to see if the HeartbeatTimeout property is set.
        /// </summary>
        internal bool IsSetHeartbeatTimeout() => this.HeartbeatTimeout != null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The input provided to the activity task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property ScheduleToCloseTimeout. 
        /// <para>
        /// The maximum amount of time for this activity task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public string ScheduleToCloseTimeout { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleToCloseTimeout property is set.
        /// </summary>
        internal bool IsSetScheduleToCloseTimeout() => this.ScheduleToCloseTimeout != null;

        /// <summary>
        /// Gets and sets the property ScheduleToStartTimeout. 
        /// <para>
        /// The maximum amount of time the activity task can wait to be assigned to a worker.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public string ScheduleToStartTimeout { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleToStartTimeout property is set.
        /// </summary>
        internal bool IsSetScheduleToStartTimeout() => this.ScheduleToStartTimeout != null;

        /// <summary>
        /// Gets and sets the property StartToCloseTimeout. 
        /// <para>
        /// The maximum amount of time a worker may take to process the activity task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public string StartToCloseTimeout { get; set; }

        /// <summary>
        /// Checks to see if the StartToCloseTimeout property is set.
        /// </summary>
        internal bool IsSetStartToCloseTimeout() => this.StartToCloseTimeout != null;

        /// <summary>
        /// Gets and sets the property TaskList. 
        /// <para>
        /// The task list in which the activity task has been scheduled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TaskList TaskList { get; set; }

        /// <summary>
        /// Checks to see if the TaskList property is set.
        /// </summary>
        internal bool IsSetTaskList() => this.TaskList != null;

        /// <summary>
        /// Gets and sets the property TaskPriority. 
        /// <para>
        ///  The priority to assign to the scheduled activity task. If set, this overrides any
        /// default priority value that was assigned when the activity type was registered.
        /// </para>
        ///  
        /// <para>
        /// Valid values are integers that range from Java's <c>Integer.MIN_VALUE</c> (-2147483648)
        /// to <c>Integer.MAX_VALUE</c> (2147483647). Higher numbers indicate higher priority.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting task priority, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/programming-priority.html">Setting
        /// Task Priority</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        public string TaskPriority { get; set; }

        /// <summary>
        /// Checks to see if the TaskPriority property is set.
        /// </summary>
        internal bool IsSetTaskPriority() => this.TaskPriority != null;
    }
}
