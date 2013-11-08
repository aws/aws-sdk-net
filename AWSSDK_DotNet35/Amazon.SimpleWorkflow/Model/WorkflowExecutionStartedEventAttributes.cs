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
    /// <para> Provides details of <c>WorkflowExecutionStarted</c> event. </para>
    /// </summary>
    public class WorkflowExecutionStartedEventAttributes
    {
        
        private string input;
        private string executionStartToCloseTimeout;
        private string taskStartToCloseTimeout;
        private ChildPolicy childPolicy;
        private TaskList taskList;
        private WorkflowType workflowType;
        private List<string> tagList = new List<string>();
        private string continuedExecutionRunId;
        private WorkflowExecution parentWorkflowExecution;
        private long? parentInitiatedEventId;

        /// <summary>
        /// The input provided to the workflow execution (if any).
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

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this.input != null;
        }

        /// <summary>
        /// The maximum duration for this workflow execution. The valid values are integers greater than or equal to <c>0</c>. An integer value can be
        /// used to specify the duration in seconds while <c>NONE</c> can be used to specify unlimited duration.
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
        public string ExecutionStartToCloseTimeout
        {
            get { return this.executionStartToCloseTimeout; }
            set { this.executionStartToCloseTimeout = value; }
        }

        // Check to see if ExecutionStartToCloseTimeout property is set
        internal bool IsSetExecutionStartToCloseTimeout()
        {
            return this.executionStartToCloseTimeout != null;
        }

        /// <summary>
        /// The maximum duration of decision tasks for this workflow type. The valid values are integers greater than or equal to <c>0</c>. An integer
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
        public string TaskStartToCloseTimeout
        {
            get { return this.taskStartToCloseTimeout; }
            set { this.taskStartToCloseTimeout = value; }
        }

        // Check to see if TaskStartToCloseTimeout property is set
        internal bool IsSetTaskStartToCloseTimeout()
        {
            return this.taskStartToCloseTimeout != null;
        }

        /// <summary>
        /// The policy to use for the child workflow executions if this workflow execution is terminated, by calling the
        /// <a>TerminateWorkflowExecution</a> action explicitly or due to an expired timeout. The supported child policies are: <ul>
        /// <li><b>TERMINATE:</b> the child executions will be terminated.</li> <li><b>REQUEST_CANCEL:</b> a request to cancel will be attempted for
        /// each child execution by recording a <c>WorkflowExecutionCancelRequested</c> event in its history. It is up to the decider to take
        /// appropriate actions when it receives an execution history with this event. </li> <li><b>ABANDON:</b> no action will be taken. The child
        /// executions will continue to run.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>TERMINATE, REQUEST_CANCEL, ABANDON</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ChildPolicy ChildPolicy
        {
            get { return this.childPolicy; }
            set { this.childPolicy = value; }
        }

        // Check to see if ChildPolicy property is set
        internal bool IsSetChildPolicy()
        {
            return this.childPolicy != null;
        }

        /// <summary>
        /// The name of the task list for scheduling the decision tasks for this workflow execution.
        ///  
        /// </summary>
        public TaskList TaskList
        {
            get { return this.taskList; }
            set { this.taskList = value; }
        }

        // Check to see if TaskList property is set
        internal bool IsSetTaskList()
        {
            return this.taskList != null;
        }

        /// <summary>
        /// The workflow type of this execution.
        ///  
        /// </summary>
        public WorkflowType WorkflowType
        {
            get { return this.workflowType; }
            set { this.workflowType = value; }
        }

        // Check to see if WorkflowType property is set
        internal bool IsSetWorkflowType()
        {
            return this.workflowType != null;
        }

        /// <summary>
        /// The list of tags associated with this workflow execution. An execution can have up to 5 tags.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 5</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> TagList
        {
            get { return this.tagList; }
            set { this.tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this.tagList.Count > 0;
        }

        /// <summary>
        /// If this workflow execution was started due to a <c>ContinueAsNewWorkflowExecution</c> decision, then it contains the <c>runId</c> of the
        /// previous workflow execution that was closed and continued as this execution.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 64</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ContinuedExecutionRunId
        {
            get { return this.continuedExecutionRunId; }
            set { this.continuedExecutionRunId = value; }
        }

        // Check to see if ContinuedExecutionRunId property is set
        internal bool IsSetContinuedExecutionRunId()
        {
            return this.continuedExecutionRunId != null;
        }

        /// <summary>
        /// The source workflow execution that started this workflow execution. The member is not set if the workflow execution was not started by a
        /// workflow.
        ///  
        /// </summary>
        public WorkflowExecution ParentWorkflowExecution
        {
            get { return this.parentWorkflowExecution; }
            set { this.parentWorkflowExecution = value; }
        }

        // Check to see if ParentWorkflowExecution property is set
        internal bool IsSetParentWorkflowExecution()
        {
            return this.parentWorkflowExecution != null;
        }

        /// <summary>
        /// The id of the <c>StartChildWorkflowExecutionInitiated</c> event corresponding to the <c>StartChildWorkflowExecution</c> <a>Decision</a> to
        /// start this workflow execution. The source event with this Id can be found in the history of the source workflow execution. This information
        /// can be useful for diagnosing problems by tracing back the chain of events leading up to this event.
        ///  
        /// </summary>
        public long ParentInitiatedEventId
        {
            get { return this.parentInitiatedEventId ?? default(long); }
            set { this.parentInitiatedEventId = value; }
        }

        // Check to see if ParentInitiatedEventId property is set
        internal bool IsSetParentInitiatedEventId()
        {
            return this.parentInitiatedEventId.HasValue;
        }
    }
}
