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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the StartWorkflowExecution operation.
    /// <para> Starts an execution of the workflow type in the specified domain using the provided <c>workflowId</c> and input data. </para>
    /// <para>This action returns the newly started workflow execution.</para> <para> <b>Access Control</b> </para> <para>You can use IAM policies
    /// to control this action's access to Amazon SWF resources as follows:</para>
    /// <ul>
    /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
    /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
    /// <ul>
    /// <li> <c>tagList.member.0</c> : The key is <c>swf:tagList.member.0</c> .</li>
    /// <li> <c>tagList.member.1</c> : The key is <c>swf:tagList.member.1</c> .</li>
    /// <li> <c>tagList.member.2</c> : The key is <c>swf:tagList.member.2</c> .</li>
    /// <li> <c>tagList.member.3</c> : The key is <c>swf:tagList.member.3</c> .</li>
    /// <li> <c>tagList.member.4</c> : The key is <c>swf:tagList.member.4</c> .</li>
    /// <li> <c>taskList</c> : String constraint. The key is <c>swf:taskList.name</c> .</li>
    /// <li> <c>name</c> : String constraint. The key is <c>swf:workflowType.name</c> .</li>
    /// <li> <c>version</c> : String constraint. The key is <c>swf:workflowType.version</c> .</li>
    /// 
    /// </ul>
    /// </li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
    /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
    /// .</para>
    /// </summary>
    public partial class StartWorkflowExecutionRequest : AmazonWebServiceRequest
    {
        private string domain;
        private string workflowId;
        private WorkflowType workflowType;
        private TaskList taskList;
        private string input;
        private string executionStartToCloseTimeout;
        private List<string> tagList = new List<string>();
        private string taskStartToCloseTimeout;
        private ChildPolicy childPolicy;

        /// <summary>
        /// The name of the domain in which the workflow execution is created.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this.domain; }
            set { this.domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this.domain != null;
        }

        /// <summary>
        /// The user defined identifier associated with the workflow execution. You can use this to associate a custom identifier with the workflow
        /// execution. You may specify the same identifier if a workflow execution is logically a <i>restart</i> of a previous execution. You cannot
        /// have two open workflow executions with the same <c>workflowId</c> at the same time. The specified string must not start or end with
        /// whitespace. It must not contain a <c>:</c> (colon), <c>/</c> (slash), <c>|</c> (vertical bar), or any control characters (\u0000-\u001f |
        /// \u007f - \u009f). Also, it must not contain the literal string "arn".
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string WorkflowId
        {
            get { return this.workflowId; }
            set { this.workflowId = value; }
        }

        // Check to see if WorkflowId property is set
        internal bool IsSetWorkflowId()
        {
            return this.workflowId != null;
        }

        /// <summary>
        /// The type of the workflow to start.
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
        /// The task list to use for the decision tasks generated for this workflow execution. This overrides the <c>defaultTaskList</c> specified when
        /// registering the workflow type. <note>A task list for this workflow execution must be specified either as a default for the workflow type or
        /// through this parameter. If neither this parameter is set nor a default task list was specified at registration time then a fault will be
        /// returned.</note> The specified string must not start or end with whitespace. It must not contain a <c>:</c> (colon), <c>/</c> (slash),
        /// <c>|</c> (vertical bar), or any control characters (\u0000-\u001f | \u007f - \u009f). Also, it must not contain the literal string "arn".
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
        /// The input for the workflow execution. This is a free form string which should be meaningful to the workflow you are starting. This
        /// <c>input</c> is made available to the new workflow execution in the <c>WorkflowExecutionStarted</c> history event.
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
        /// The total duration for this workflow execution. This overrides the defaultExecutionStartToCloseTimeout specified when registering the
        /// workflow type. The duration is specified in seconds. The valid values are integers greater than or equal to 0. Exceeding this limit will
        /// cause the workflow execution to time out. Unlike some of the other timeout parameters in Amazon SWF, you cannot specify a value of "NONE"
        /// for this timeout; there is a one-year max limit on the time that a workflow execution can run. <note> An execution start-to-close timeout
        /// must be specified either through this parameter or as a default when the workflow type is registered. If neither this parameter nor a
        /// default execution start-to-close timeout is specified, a fault is returned. </note>
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
        /// The list of tags to associate with the workflow execution. You can specify a maximum of 5 tags. You can list workflow executions with a
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

        /// <summary>
        /// Specifies the maximum duration of decision tasks for this workflow execution. This parameter overrides the
        /// <c>defaultTaskStartToCloseTimout</c> specified when registering the workflow type using <a>RegisterWorkflowType</a>. The valid values are
        /// integers greater than or equal to <c>0</c>. An integer value can be used to specify the duration in seconds while <c>NONE</c> can be used to
        /// specify unlimited duration. <note>A task start-to-close timeout for this workflow execution must be specified either as a default for the
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
        /// If set, specifies the policy to use for the child workflow executions of this workflow execution if it is terminated, by calling the
        /// <a>TerminateWorkflowExecution</a> action explicitly or due to an expired timeout. This policy overrides the default child policy specified
        /// when registering the workflow type using <a>RegisterWorkflowType</a>. The supported child policies are: <ul> <li><b>TERMINATE:</b> the child
        /// executions will be terminated.</li> <li><b>REQUEST_CANCEL:</b> a request to cancel will be attempted for each child execution by recording a
        /// <c>WorkflowExecutionCancelRequested</c> event in its history. It is up to the decider to take appropriate actions when it receives an
        /// execution history with this event. </li> <li><b>ABANDON:</b> no action will be taken. The child executions will continue to run.</li> </ul>
        /// <note>A child policy for this workflow execution must be specified either as a default for the workflow type or through this parameter. If
        /// neither this parameter is set nor a default child policy was specified at registration time then a fault will be returned.</note>
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

    }
}
    
