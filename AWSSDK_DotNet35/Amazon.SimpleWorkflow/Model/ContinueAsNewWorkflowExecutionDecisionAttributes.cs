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
    /// <para>Provides details of the <c>ContinueAsNewWorkflowExecution</c> decision.</para> <para> <b>Access Control</b> </para> <para>You can use
    /// IAM policies to control this decision's access to Amazon SWF in much the same way as for the regular API:</para>
    /// <ul>
    /// <li>Use a <c>Resource</c> element with the domain name to limit the decision to only specified domains.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to specify this decision.</li>
    /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
    /// <ul>
    /// <li> <c>tag</c> : TBD.</li>
    /// <li> <c>taskList</c> : String constraint. The key is "swf:taskList.name".</li>
    /// <li> <c>workflowTypeVersion</c> : String constraint. The key is TBD.</li>
    /// 
    /// </ul>
    /// </li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails. The associated event attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
    /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage
    /// Access to Amazon SWF Workflows</a> .</para>
    /// </summary>
    public class ContinueAsNewWorkflowExecutionDecisionAttributes
    {
        
        private string input;
        private string executionStartToCloseTimeout;
        private TaskList taskList;
        private string taskStartToCloseTimeout;
        private ChildPolicy childPolicy;
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

        // Check to see if WorkflowTypeVersion property is set
        internal bool IsSetWorkflowTypeVersion()
        {
            return this.workflowTypeVersion != null;
        }
    }
}
