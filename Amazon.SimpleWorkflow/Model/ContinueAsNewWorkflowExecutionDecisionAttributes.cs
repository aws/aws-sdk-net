/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Provides details of the <c>ContinueAsNewWorkflowExecution</c> decision. </para>
    /// </summary>
    public class ContinueAsNewWorkflowExecutionDecisionAttributes  
    {
        
        private string input;
        private string executionStartToCloseTimeout;
        private TaskList taskList;
        private string taskStartToCloseTimeout;
        private string childPolicy;
        private List<string> tagList = new List<string>();
        private string workflowTypeVersion;

        /// <summary>
        /// The input provided to the new workflow execution.
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
        public ContinueAsNewWorkflowExecutionDecisionAttributes WithInput(string input)
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
        /// If set, specifies the total duration for this workflow execution. This overrides the <c>defaultExecutionStartToCloseTimeout</c> specified
        /// when registering the workflow type. The valid values are integers greater than or equal to <c>0</c>. An integer value can be used to specify
        /// the duration in seconds while <c>NONE</c> can be used to specify unlimited duration. <note>An execution start-to-close timeout for this
        /// workflow execution must be specified either as a default for the workflow type or through this field. If neither this field is set nor a
        /// default execution start-to-close timeout was specified at registration time then a fault will be returned.</note>
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

        /// <summary>
        /// Sets the ExecutionStartToCloseTimeout property
        /// </summary>
        /// <param name="executionStartToCloseTimeout">The value to set for the ExecutionStartToCloseTimeout property </param>
        /// <returns>this instance</returns>
        public ContinueAsNewWorkflowExecutionDecisionAttributes WithExecutionStartToCloseTimeout(string executionStartToCloseTimeout)
        {
            this.executionStartToCloseTimeout = executionStartToCloseTimeout;
            return this;
        }
            

        // Check to see if ExecutionStartToCloseTimeout property is set
        internal bool IsSetExecutionStartToCloseTimeout()
        {
            return this.executionStartToCloseTimeout != null;       
        }

        /// <summary>
        /// Represents a task list.
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
        public ContinueAsNewWorkflowExecutionDecisionAttributes WithTaskList(TaskList taskList)
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
        /// Specifies the maximum duration of decision tasks for the new workflow execution. This parameter overrides the
        /// <c>defaultTaskStartToCloseTimout</c> specified when registering the workflow type using <a>RegisterWorkflowType</a>. The valid values are
        /// integers greater than or equal to <c>0</c>. An integer value can be used to specify the duration in seconds while <c>NONE</c> can be used to
        /// specify unlimited duration. <note>A task start-to-close timeout for the new workflow execution must be specified either as a default for the
        /// workflow type or through this parameter. If neither this parameter is set nor a default task start-to-close timeout was specified at
        /// registration time then a fault will be returned.</note>
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

        /// <summary>
        /// Sets the TaskStartToCloseTimeout property
        /// </summary>
        /// <param name="taskStartToCloseTimeout">The value to set for the TaskStartToCloseTimeout property </param>
        /// <returns>this instance</returns>
        public ContinueAsNewWorkflowExecutionDecisionAttributes WithTaskStartToCloseTimeout(string taskStartToCloseTimeout)
        {
            this.taskStartToCloseTimeout = taskStartToCloseTimeout;
            return this;
        }
            

        // Check to see if TaskStartToCloseTimeout property is set
        internal bool IsSetTaskStartToCloseTimeout()
        {
            return this.taskStartToCloseTimeout != null;       
        }

        /// <summary>
        /// If set, specifies the policy to use for the child workflow executions of the new execution if it is terminated by calling the
        /// <a>TerminateWorkflowExecution</a> action explicitly or due to an expired timeout. This policy overrides the default child policy specified
        /// when registering the workflow type using <a>RegisterWorkflowType</a>. The supported child policies are: <ul> <li><b>TERMINATE:</b> the child
        /// executions will be terminated.</li> <li><b>REQUEST_CANCEL:</b> a request to cancel will be attempted for each child execution by recording a
        /// <c>WorkflowExecutionCancelRequested</c> event in its history. It is up to the decider to take appropriate actions when it receives an
        /// execution history with this event. </li> <li><b>ABANDON:</b> no action will be taken. The child executions will continue to run.</li> </ul>
        /// <note>A child policy for the new workflow execution must be specified either as a default registered for its workflow type or through this
        /// field. If neither this field is set nor a default child policy was specified at registration time then a fault will be returned. </note>
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
        public string ChildPolicy
        {
            get { return this.childPolicy; }
            set { this.childPolicy = value; }
        }

        /// <summary>
        /// Sets the ChildPolicy property
        /// </summary>
        /// <param name="childPolicy">The value to set for the ChildPolicy property </param>
        /// <returns>this instance</returns>
        public ContinueAsNewWorkflowExecutionDecisionAttributes WithChildPolicy(string childPolicy)
        {
            this.childPolicy = childPolicy;
            return this;
        }
            

        // Check to see if ChildPolicy property is set
        internal bool IsSetChildPolicy()
        {
            return this.childPolicy != null;       
        }

        /// <summary>
        /// The list of tags to associate with the new workflow execution. A maximum of 5 tags can be specified. You can list workflow executions with a
        /// specific tag by calling <a>ListOpenWorkflowExecutions</a> or <a>ListClosedWorkflowExecutions</a> and specifying a <a>TagFilter</a>.
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
        /// <summary>
        /// Adds elements to the TagList collection
        /// </summary>
        /// <param name="tagList">The values to add to the TagList collection </param>
        /// <returns>this instance</returns>
        public ContinueAsNewWorkflowExecutionDecisionAttributes WithTagList(params string[] tagList)
        {
            foreach (string element in tagList)
            {
                this.tagList.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the TagList collection
        /// </summary>
        /// <param name="tagList">The values to add to the TagList collection </param>
        /// <returns>this instance</returns>
        public ContinueAsNewWorkflowExecutionDecisionAttributes WithTagList(IEnumerable<string> tagList)
        {
            foreach (string element in tagList)
            {
                this.tagList.Add(element);
            }

            return this;
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this.tagList.Count > 0;       
        }
        public string WorkflowTypeVersion
        {
            get { return this.workflowTypeVersion; }
            set { this.workflowTypeVersion = value; }
        }

        /// <summary>
        /// Sets the WorkflowTypeVersion property
        /// </summary>
        /// <param name="workflowTypeVersion">The value to set for the WorkflowTypeVersion property </param>
        /// <returns>this instance</returns>
        public ContinueAsNewWorkflowExecutionDecisionAttributes WithWorkflowTypeVersion(string workflowTypeVersion)
        {
            this.workflowTypeVersion = workflowTypeVersion;
            return this;
        }
            

        // Check to see if WorkflowTypeVersion property is set
        internal bool IsSetWorkflowTypeVersion()
        {
            return this.workflowTypeVersion != null;       
        }
    }
}
