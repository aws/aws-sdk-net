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
    /// Provides details about the <c>DecisionTaskScheduled</c> event.
    /// </summary>
    public partial class DecisionTaskScheduledEventAttributes
    {
        private string _scheduleToStartTimeout;
        private string _startToCloseTimeout;
        private TaskList _taskList;
        private string _taskPriority;

        /// <summary>
        /// Gets and sets the property ScheduleToStartTimeout. 
        /// <para>
        /// The maximum amount of time the decision task can wait to be assigned to a worker.
        /// </para>
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
        /// The maximum duration for this decision task. The task is considered timed out if it
        /// doesn't completed within this duration.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
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
        /// The name of the task list in which the decision task was scheduled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  A task priority that, if set, specifies the priority for this decision task. Valid
        /// values are integers that range from Java's <c>Integer.MIN_VALUE</c> (-2147483648)
        /// to <c>Integer.MAX_VALUE</c> (2147483647). Higher numbers indicate higher priority.
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