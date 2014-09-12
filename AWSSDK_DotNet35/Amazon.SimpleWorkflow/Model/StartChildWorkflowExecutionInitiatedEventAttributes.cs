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
    /// Provides details of the <code>StartChildWorkflowExecutionInitiated</code> event.
    /// </summary>
    public partial class StartChildWorkflowExecutionInitiatedEventAttributes
    {
        private ChildPolicy _childPolicy;
        private string _control;
        private long? _decisionTaskCompletedEventId;
        private string _executionStartToCloseTimeout;
        private string _input;
        private List<string> _tagList = new List<string>();
        private TaskList _taskList;
        private string _taskStartToCloseTimeout;
        private string _workflowId;
        private WorkflowType _workflowType;

        /// <summary>
        /// Gets and sets the property ChildPolicy. 
        /// <para>
        ///  The policy to use for the child workflow executions if this execution gets terminated
        /// by explicitly calling the <a>TerminateWorkflowExecution</a> action or due to an expired
        /// timeout.
        /// </para>
        ///  
        /// <para>
        /// The supported child policies are:
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
        /// Gets and sets the property Control. 
        /// <para>
        ///  Optional data attached to the event that can be used by the decider in subsequent
        /// decision tasks. This data is not sent to the activity. 
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
        /// Gets and sets the property DecisionTaskCompletedEventId. 
        /// <para>
        ///  The id of the <code>DecisionTaskCompleted</code> event corresponding to the decision
        /// task that resulted in the <code>StartChildWorkflowExecution</code> <a>Decision</a>
        /// to request this child workflow execution. This information can be useful for diagnosing
        /// problems by tracing back the cause of events. 
        /// </para>
        /// </summary>
        public long DecisionTaskCompletedEventId
        {
            get { return this._decisionTaskCompletedEventId.GetValueOrDefault(); }
            set { this._decisionTaskCompletedEventId = value; }
        }

        // Check to see if DecisionTaskCompletedEventId property is set
        internal bool IsSetDecisionTaskCompletedEventId()
        {
            return this._decisionTaskCompletedEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionStartToCloseTimeout. 
        /// <para>
        ///  The maximum duration for the child workflow execution. If the workflow execution
        /// is not closed within this duration, it will be timed out and force terminated. 
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
        ///  The inputs provided to the child workflow execution (if any). 
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
        ///  The list of tags to associated with the child workflow execution. 
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
        ///  The name of the task list used for the decision tasks of the child workflow execution.
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
        ///  The maximum duration allowed for the decision tasks for this workflow execution.
        /// 
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
        /// Gets and sets the property WorkflowId. 
        /// <para>
        ///  The <code>workflowId</code> of the child workflow execution. 
        /// </para>
        /// </summary>
        public string WorkflowId
        {
            get { return this._workflowId; }
            set { this._workflowId = value; }
        }

        // Check to see if WorkflowId property is set
        internal bool IsSetWorkflowId()
        {
            return this._workflowId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowType. 
        /// <para>
        ///  The type of the child workflow execution. 
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