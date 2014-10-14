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
    /// The configuration settings of a workflow type.
    /// </summary>
    public partial class WorkflowTypeConfiguration
    {
        private ChildPolicy _defaultChildPolicy;
        private string _defaultExecutionStartToCloseTimeout;
        private TaskList _defaultTaskList;
        private string _defaultTaskStartToCloseTimeout;

        /// <summary>
        /// Gets and sets the property DefaultChildPolicy. 
        /// <para>
        /// The optional default policy to use for the child workflow executions when a workflow
        /// execution of this type is terminated, by calling the <a>TerminateWorkflowExecution</a>
        /// action explicitly or due to an expired timeout. This default can be overridden when
        /// starting a workflow execution using the <a>StartWorkflowExecution</a> action or the
        /// <code>StartChildWorkflowExecution</code> <a>Decision</a>. The supported child policies
        /// are:
        /// </para>
        ///  <ul> <li> <b>TERMINATE:</b> the child executions will be terminated.</li> <li> <b>REQUEST_CANCEL:</b>
        /// a request to cancel will be attempted for each child execution by recording a <code>WorkflowExecutionCancelRequested</code>
        /// event in its history. It is up to the decider to take appropriate actions when it
        /// receives an execution history with this event.</li> <li> <b>ABANDON:</b> no action
        /// will be taken. The child executions will continue to run.</li> </ul>
        /// </summary>
        public ChildPolicy DefaultChildPolicy
        {
            get { return this._defaultChildPolicy; }
            set { this._defaultChildPolicy = value; }
        }

        // Check to see if DefaultChildPolicy property is set
        internal bool IsSetDefaultChildPolicy()
        {
            return this._defaultChildPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultExecutionStartToCloseTimeout. 
        /// <para>
        /// The optional default maximum duration, specified when registering the workflow type,
        /// for executions of this workflow type. This default can be overridden when starting
        /// a workflow execution using the <a>StartWorkflowExecution</a> action or the <code>StartChildWorkflowExecution</code>
        /// <a>Decision</a>.
        /// </para>
        ///  
        /// <para>
        /// The valid values are integers greater than or equal to <code>0</code>. An integer
        /// value can be used to specify the duration in seconds while <code>NONE</code> can be
        /// used to specify unlimited duration.
        /// </para>
        /// </summary>
        public string DefaultExecutionStartToCloseTimeout
        {
            get { return this._defaultExecutionStartToCloseTimeout; }
            set { this._defaultExecutionStartToCloseTimeout = value; }
        }

        // Check to see if DefaultExecutionStartToCloseTimeout property is set
        internal bool IsSetDefaultExecutionStartToCloseTimeout()
        {
            return this._defaultExecutionStartToCloseTimeout != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTaskList. 
        /// <para>
        /// The optional default task list, specified when registering the workflow type, for
        /// decisions tasks scheduled for workflow executions of this type. This default can be
        /// overridden when starting a workflow execution using the <a>StartWorkflowExecution</a>
        /// action or the <code>StartChildWorkflowExecution</code> <a>Decision</a>.
        /// </para>
        /// </summary>
        public TaskList DefaultTaskList
        {
            get { return this._defaultTaskList; }
            set { this._defaultTaskList = value; }
        }

        // Check to see if DefaultTaskList property is set
        internal bool IsSetDefaultTaskList()
        {
            return this._defaultTaskList != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTaskStartToCloseTimeout. 
        /// <para>
        /// The optional default maximum duration, specified when registering the workflow type,
        /// that a decision task for executions of this workflow type might take before returning
        /// completion or failure. If the task does not close in the specified time then the task
        /// is automatically timed out and rescheduled. If the decider eventually reports a completion
        /// or failure, it is ignored. This default can be overridden when starting a workflow
        /// execution using the <a>StartWorkflowExecution</a> action or the <code>StartChildWorkflowExecution</code>
        /// <a>Decision</a>.
        /// </para>
        ///  
        /// <para>
        /// The valid values are integers greater than or equal to <code>0</code>. An integer
        /// value can be used to specify the duration in seconds while <code>NONE</code> can be
        /// used to specify unlimited duration.
        /// </para>
        /// </summary>
        public string DefaultTaskStartToCloseTimeout
        {
            get { return this._defaultTaskStartToCloseTimeout; }
            set { this._defaultTaskStartToCloseTimeout = value; }
        }

        // Check to see if DefaultTaskStartToCloseTimeout property is set
        internal bool IsSetDefaultTaskStartToCloseTimeout()
        {
            return this._defaultTaskStartToCloseTimeout != null;
        }

    }
}