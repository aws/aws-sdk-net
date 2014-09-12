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
    /// Provides details of the <code>ContinueAsNewWorkflowExecution</code> decision.
    /// 
    ///  
    /// <para>
    /// <b>Access Control</b>
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this decision's access to Amazon SWF in much the
    /// same way as for the regular API:
    /// </para>
    ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the decision
    /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
    /// deny permission to specify this decision.</li> <li>Constrain the following parameters
    /// by using a <code>Condition</code> element with the appropriate keys. <ul> <li> <code>tag</code>:
    /// TBD.</li> <li> <code>taskList</code>: String constraint. The key is "swf:taskList.name".</li>
    /// <li> <code>workflowTypeVersion</code>: String constraint. The key is TBD.</li> </ul>
    /// </li> </ul> 
    /// <para>
    /// If the caller does not have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
    /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a>.
    /// </para>
    /// </summary>
    public partial class ContinueAsNewWorkflowExecutionDecisionAttributes
    {
        private ChildPolicy _childPolicy;
        private string _executionStartToCloseTimeout;
        private string _input;
        private List<string> _tagList = new List<string>();
        private TaskList _taskList;
        private string _taskStartToCloseTimeout;
        private string _workflowTypeVersion;

        /// <summary>
        /// Gets and sets the property ChildPolicy. 
        /// <para>
        ///  If set, specifies the policy to use for the child workflow executions of the new
        /// execution if it is terminated by calling the <a>TerminateWorkflowExecution</a> action
        /// explicitly or due to an expired timeout. This policy overrides the default child policy
        /// specified when registering the workflow type using <a>RegisterWorkflowType</a>. The
        /// supported child policies are:
        /// </para>
        ///  <ul> <li> <b>TERMINATE:</b> the child executions will be terminated.</li> <li> <b>REQUEST_CANCEL:</b>
        /// a request to cancel will be attempted for each child execution by recording a <code>WorkflowExecutionCancelRequested</code>
        /// event in its history. It is up to the decider to take appropriate actions when it
        /// receives an execution history with this event. </li> <li> <b>ABANDON:</b> no action
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
        ///  If set, specifies the total duration for this workflow execution. This overrides
        /// the <code>defaultExecutionStartToCloseTimeout</code> specified when registering the
        /// workflow type. 
        /// </para>
        ///  
        /// <para>
        /// The valid values are integers greater than or equal to <code>0</code>. An integer
        /// value can be used to specify the duration in seconds while <code>NONE</code> can be
        /// used to specify unlimited duration.
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
        /// Gets and sets the property Input. 
        /// <para>
        ///  The input provided to the new workflow execution. 
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
        /// Gets and sets the property TagList. 
        /// <para>
        ///  The list of tags to associate with the new workflow execution. A maximum of 5 tags
        /// can be specified. You can list workflow executions with a specific tag by calling
        /// <a>ListOpenWorkflowExecutions</a> or <a>ListClosedWorkflowExecutions</a> and specifying
        /// a <a>TagFilter</a>. 
        /// </para>
        /// </summary>
        public List<string> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && this._tagList.Count > 0; 
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
        /// Gets and sets the property TaskStartToCloseTimeout. 
        /// <para>
        ///  Specifies the maximum duration of decision tasks for the new workflow execution.
        /// This parameter overrides the <code>defaultTaskStartToCloseTimout</code> specified
        /// when registering the workflow type using <a>RegisterWorkflowType</a>. 
        /// </para>
        ///  
        /// <para>
        /// The valid values are integers greater than or equal to <code>0</code>. An integer
        /// value can be used to specify the duration in seconds while <code>NONE</code> can be
        /// used to specify unlimited duration.
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

        /// <summary>
        /// Gets and sets the property WorkflowTypeVersion.
        /// </summary>
        public string WorkflowTypeVersion
        {
            get { return this._workflowTypeVersion; }
            set { this._workflowTypeVersion = value; }
        }

        // Check to see if WorkflowTypeVersion property is set
        internal bool IsSetWorkflowTypeVersion()
        {
            return this._workflowTypeVersion != null;
        }

    }
}