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
    /// Provides details of <code>WorkflowExecutionStarted</code> event.
    /// </summary>
    public partial class WorkflowExecutionStartedEventAttributes
    {
        private ChildPolicy _childPolicy;
        private string _continuedExecutionRunId;
        private string _executionStartToCloseTimeout;
        private string _input;
        private long? _parentInitiatedEventId;
        private WorkflowExecution _parentWorkflowExecution;
        private List<string> _tagList = new List<string>();
        private TaskList _taskList;
        private string _taskStartToCloseTimeout;
        private WorkflowType _workflowType;

        /// <summary>
        /// Gets and sets the property ChildPolicy. 
        /// <para>
        ///  The policy to use for the child workflow executions if this workflow execution is
        /// terminated, by calling the <a>TerminateWorkflowExecution</a> action explicitly or
        /// due to an expired timeout. The supported child policies are: <ul> <li> <b>TERMINATE:</b>
        /// the child executions will be terminated.</li> <li> <b>REQUEST_CANCEL:</b> a request
        /// to cancel will be attempted for each child execution by recording a <code>WorkflowExecutionCancelRequested</code>
        /// event in its history. It is up to the decider to take appropriate actions when it
        /// receives an execution history with this event. </li> <li> <b>ABANDON:</b> no action
        /// will be taken. The child executions will continue to run.</li> </ul> 
        /// </para>
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
        /// Gets and sets the property ContinuedExecutionRunId. 
        /// <para>
        ///  If this workflow execution was started due to a <code>ContinueAsNewWorkflowExecution</code>
        /// decision, then it contains the <code>runId</code> of the previous workflow execution
        /// that was closed and continued as this execution. 
        /// </para>
        /// </summary>
        public string ContinuedExecutionRunId
        {
            get { return this._continuedExecutionRunId; }
            set { this._continuedExecutionRunId = value; }
        }

        // Check to see if ContinuedExecutionRunId property is set
        internal bool IsSetContinuedExecutionRunId()
        {
            return this._continuedExecutionRunId != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStartToCloseTimeout. 
        /// <para>
        ///  The maximum duration for this workflow execution. 
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
        ///  The input provided to the workflow execution (if any). 
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
        /// Gets and sets the property ParentInitiatedEventId. 
        /// <para>
        ///  The id of the <code>StartChildWorkflowExecutionInitiated</code> event corresponding
        /// to the <code>StartChildWorkflowExecution</code> <a>Decision</a> to start this workflow
        /// execution. The source event with this Id can be found in the history of the source
        /// workflow execution. This information can be useful for diagnosing problems by tracing
        /// back the chain of events leading up to this event. 
        /// </para>
        /// </summary>
        public long ParentInitiatedEventId
        {
            get { return this._parentInitiatedEventId.GetValueOrDefault(); }
            set { this._parentInitiatedEventId = value; }
        }

        // Check to see if ParentInitiatedEventId property is set
        internal bool IsSetParentInitiatedEventId()
        {
            return this._parentInitiatedEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParentWorkflowExecution. 
        /// <para>
        ///  The source workflow execution that started this workflow execution. The member is
        /// not set if the workflow execution was not started by a workflow. 
        /// </para>
        /// </summary>
        public WorkflowExecution ParentWorkflowExecution
        {
            get { return this._parentWorkflowExecution; }
            set { this._parentWorkflowExecution = value; }
        }

        // Check to see if ParentWorkflowExecution property is set
        internal bool IsSetParentWorkflowExecution()
        {
            return this._parentWorkflowExecution != null;
        }

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        ///  The list of tags associated with this workflow execution. An execution can have up
        /// to 5 tags. 
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
        /// <para>
        ///  The name of the task list for scheduling the decision tasks for this workflow execution.
        /// 
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
        /// Gets and sets the property TaskStartToCloseTimeout. 
        /// <para>
        ///  The maximum duration of decision tasks for this workflow type. 
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
        /// Gets and sets the property WorkflowType. 
        /// <para>
        ///  The workflow type of this execution. 
        /// </para>
        /// </summary>
        public WorkflowType WorkflowType
        {
            get { return this._workflowType; }
            set { this._workflowType = value; }
        }

        // Check to see if WorkflowType property is set
        internal bool IsSetWorkflowType()
        {
            return this._workflowType != null;
        }

    }
}