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
    /// Provides the details of the <c>DecisionTaskCompleted</c> event.
    /// </summary>
    public partial class DecisionTaskCompletedEventAttributes
    {
        private string _executionContext;
        private long? _scheduledEventId;
        private long? _startedEventId;
        private TaskList _taskList;
        private string _taskListScheduleToStartTimeout;

        /// <summary>
        /// Gets and sets the property ExecutionContext. 
        /// <para>
        /// User defined context for the workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string ExecutionContext
        {
            get { return this._executionContext; }
            set { this._executionContext = value; }
        }

        // Check to see if ExecutionContext property is set
        internal bool IsSetExecutionContext()
        {
            return this._executionContext != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledEventId. 
        /// <para>
        /// The ID of the <c>DecisionTaskScheduled</c> event that was recorded when this decision
        /// task was scheduled. This information can be useful for diagnosing problems by tracing
        /// back the chain of events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? ScheduledEventId
        {
            get { return this._scheduledEventId; }
            set { this._scheduledEventId = value; }
        }

        // Check to see if ScheduledEventId property is set
        internal bool IsSetScheduledEventId()
        {
            return this._scheduledEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedEventId. 
        /// <para>
        /// The ID of the <c>DecisionTaskStarted</c> event recorded when this decision task was
        /// started. This information can be useful for diagnosing problems by tracing back the
        /// chain of events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? StartedEventId
        {
            get { return this._startedEventId; }
            set { this._startedEventId = value; }
        }

        // Check to see if StartedEventId property is set
        internal bool IsSetStartedEventId()
        {
            return this._startedEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskList.
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
        /// Gets and sets the property TaskListScheduleToStartTimeout. 
        /// <para>
        /// The maximum amount of time the decision task can wait to be assigned to a worker.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8)]
        public string TaskListScheduleToStartTimeout
        {
            get { return this._taskListScheduleToStartTimeout; }
            set { this._taskListScheduleToStartTimeout = value; }
        }

        // Check to see if TaskListScheduleToStartTimeout property is set
        internal bool IsSetTaskListScheduleToStartTimeout()
        {
            return this._taskListScheduleToStartTimeout != null;
        }

    }
}