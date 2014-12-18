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
    /// The configuration settings for a workflow execution including timeout values, tasklist
    /// etc. These configuration settings are determined from the defaults specified when
    /// registering the workflow type and those specified when starting the workflow execution.
    /// </summary>
    public partial class WorkflowExecutionConfiguration
    {
        private ChildPolicy _childPolicy;
        private string _executionStartToCloseTimeout;
        private TaskList _taskList;
        private string _taskPriority;
        private string _taskStartToCloseTimeout;

        /// <summary>
        /// Gets and sets the property ChildPolicy. 
        /// <para>
        /// The policy to use for the child workflow executions if this workflow execution is
        /// terminated, by calling the <a>TerminateWorkflowExecution</a> action explicitly or
        /// due to an expired timeout.
        /// </para>
        ///  
        /// <para>
        /// The supported child policies are:
        /// </para>
        ///  <ul> <li><b>TERMINATE:</b> the child executions will be terminated.</li> <li><b>REQUEST_CANCEL:</b>
        /// a request to cancel will be attempted for each child execution by recording a <code>WorkflowExecutionCancelRequested</code>
        /// event in its history. It is up to the decider to take appropriate actions when it
        /// receives an execution history with this event.</li> <li><b>ABANDON:</b> no action
        /// will be taken. The child executions will continue to run.</li> </ul>
        /// </summary>
        public ChildPolicy ChildPolicy
        {
            get { return this._childPolicy; }
            set { this._childPolicy = value; }
        }

        // Check to see if ChildPolicy property is set
        internal bool IsSetChildPolicy()
        {
            return this._childPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStartToCloseTimeout. 
        /// <para>
        /// The total duration for this workflow execution.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds; an integer greater than or equal to 0. The value
        /// "NONE" can be used to specify unlimited duration.
        /// </para>
        /// </summary>
        public string ExecutionStartToCloseTimeout
        {
            get { return this._executionStartToCloseTimeout; }
            set { this._executionStartToCloseTimeout = value; }
        }

        // Check to see if ExecutionStartToCloseTimeout property is set
        internal bool IsSetExecutionStartToCloseTimeout()
        {
            return this._executionStartToCloseTimeout != null;
        }

        /// <summary>
        /// Gets and sets the property TaskList. 
        /// <para>
        /// The task list used for the decision tasks generated for this workflow execution.
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
        /// The priority assigned to decision tasks for this workflow execution. Valid values
        /// are integers that range from Java's <code>Integer.MIN_VALUE</code> (-2147483648) to
        /// <code>Integer.MAX_VALUE</code> (2147483647). Higher numbers indicate higher priority.
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

        /// <summary>
        /// Gets and sets the property TaskStartToCloseTimeout. 
        /// <para>
        /// The maximum duration allowed for decision tasks for this workflow execution.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds; an integer greater than or equal to 0. The value
        /// "NONE" can be used to specify unlimited duration.
        /// </para>
        /// </summary>
        public string TaskStartToCloseTimeout
        {
            get { return this._taskStartToCloseTimeout; }
            set { this._taskStartToCloseTimeout = value; }
        }

        // Check to see if TaskStartToCloseTimeout property is set
        internal bool IsSetTaskStartToCloseTimeout()
        {
            return this._taskStartToCloseTimeout != null;
        }

    }
}