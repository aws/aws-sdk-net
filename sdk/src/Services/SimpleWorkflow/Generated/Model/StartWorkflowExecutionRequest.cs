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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the StartWorkflowExecution operation.
    /// Starts an execution of the workflow type in the specified domain using the provided
    /// <code>workflowId</code> and input data.
    /// 
    ///  
    /// <para>
    /// This action returns the newly started workflow execution.
    /// </para>
    ///  
    /// <para>
    ///  <b>Access Control</b> 
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this action's access to Amazon SWF resources as
    /// follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use a <code>Resource</code> element with the domain name to limit the action to only
    /// specified domains.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use an <code>Action</code> element to allow or deny permission to call this action.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Constrain the following parameters by using a <code>Condition</code> element with
    /// the appropriate keys.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>tagList.member.0</code>: The key is <code>swf:tagList.member.0</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>tagList.member.1</code>: The key is <code>swf:tagList.member.1</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>tagList.member.2</code>: The key is <code>swf:tagList.member.2</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>tagList.member.3</code>: The key is <code>swf:tagList.member.3</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>tagList.member.4</code>: The key is <code>swf:tagList.member.4</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>taskList</code>: String constraint. The key is <code>swf:taskList.name</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>workflowType.name</code>: String constraint. The key is <code>swf:workflowType.name</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>workflowType.version</code>: String constraint. The key is <code>swf:workflowType.version</code>.
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
    /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class StartWorkflowExecutionRequest : AmazonSimpleWorkflowRequest
    {
        private ChildPolicy _childPolicy;
        private string _domain;
        private string _executionStartToCloseTimeout;
        private string _input;
        private string _lambdaRole;
        private List<string> _tagList = new List<string>();
        private TaskList _taskList;
        private string _taskPriority;
        private string _taskStartToCloseTimeout;
        private string _workflowId;
        private WorkflowType _workflowType;

        /// <summary>
        /// Gets and sets the property ChildPolicy. 
        /// <para>
        /// If set, specifies the policy to use for the child workflow executions of this workflow
        /// execution if it is terminated, by calling the <a>TerminateWorkflowExecution</a> action
        /// explicitly or due to an expired timeout. This policy overrides the default child policy
        /// specified when registering the workflow type using <a>RegisterWorkflowType</a>.
        /// </para>
        ///  
        /// <para>
        /// The supported child policies are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>TERMINATE</code> – The child executions are terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REQUEST_CANCEL</code> – A request to cancel is attempted for each child execution
        /// by recording a <code>WorkflowExecutionCancelRequested</code> event in its history.
        /// It is up to the decider to take appropriate actions when it receives an execution
        /// history with this event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ABANDON</code> – No action is taken. The child executions continue to run.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// A child policy for this workflow execution must be specified either as a default for
        /// the workflow type or through this parameter. If neither this parameter is set nor
        /// a default child policy was specified at registration time then a fault is returned.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain in which the workflow execution is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStartToCloseTimeout. 
        /// <para>
        /// The total duration for this workflow execution. This overrides the defaultExecutionStartToCloseTimeout
        /// specified when registering the workflow type.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds; an integer greater than or equal to <code>0</code>.
        /// Exceeding this limit causes the workflow execution to time out. Unlike some of the
        /// other timeout parameters in Amazon SWF, you cannot specify a value of "NONE" for this
        /// timeout; there is a one-year max limit on the time that a workflow execution can run.
        /// </para>
        ///  <note> 
        /// <para>
        /// An execution start-to-close timeout must be specified either through this parameter
        /// or as a default when the workflow type is registered. If neither this parameter nor
        /// a default execution start-to-close timeout is specified, a fault is returned.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=8)]
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
        /// The input for the workflow execution. This is a free form string which should be meaningful
        /// to the workflow you are starting. This <code>input</code> is made available to the
        /// new workflow execution in the <code>WorkflowExecutionStarted</code> history event.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
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
        /// Gets and sets the property LambdaRole. 
        /// <para>
        /// The IAM role to attach to this workflow execution.
        /// </para>
        ///  <note> 
        /// <para>
        /// Executions of this workflow type need IAM roles to invoke Lambda functions. If you
        /// don't attach an IAM role, any attempt to schedule a Lambda task fails. This results
        /// in a <code>ScheduleLambdaFunctionFailed</code> history event. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/lambda-task.html">https://docs.aws.amazon.com/amazonswf/latest/developerguide/lambda-task.html</a>
        /// in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string LambdaRole
        {
            get { return this._lambdaRole; }
            set { this._lambdaRole = value; }
        }

        // Check to see if LambdaRole property is set
        internal bool IsSetLambdaRole()
        {
            return this._lambdaRole != null;
        }

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// The list of tags to associate with the workflow execution. You can specify a maximum
        /// of 5 tags. You can list workflow executions with a specific tag by calling <a>ListOpenWorkflowExecutions</a>
        /// or <a>ListClosedWorkflowExecutions</a> and specifying a <a>TagFilter</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
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
        /// The task list to use for the decision tasks generated for this workflow execution.
        /// This overrides the <code>defaultTaskList</code> specified when registering the workflow
        /// type.
        /// </para>
        ///  <note> 
        /// <para>
        /// A task list for this workflow execution must be specified either as a default for
        /// the workflow type or through this parameter. If neither this parameter is set nor
        /// a default task list was specified at registration time then a fault is returned.
        /// </para>
        ///  </note> 
        /// <para>
        /// The specified string must not start or end with whitespace. It must not contain a
        /// <code>:</code> (colon), <code>/</code> (slash), <code>|</code> (vertical bar), or
        /// any control characters (<code>\u0000-\u001f</code> | <code>\u007f-\u009f</code>).
        /// Also, it must not <i>be</i> the literal string <code>arn</code>.
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
        /// The task priority to use for this workflow execution. This overrides any default priority
        /// that was assigned when the workflow type was registered. If not set, then the default
        /// task priority for the workflow type is used. Valid values are integers that range
        /// from Java's <code>Integer.MIN_VALUE</code> (-2147483648) to <code>Integer.MAX_VALUE</code>
        /// (2147483647). Higher numbers indicate higher priority.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting task priority, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/programming-priority.html">Setting
        /// Task Priority</a> in the <i>Amazon SWF Developer Guide</i>.
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
        /// Specifies the maximum duration of decision tasks for this workflow execution. This
        /// parameter overrides the <code>defaultTaskStartToCloseTimout</code> specified when
        /// registering the workflow type using <a>RegisterWorkflowType</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <code>0</code>.
        /// You can use <code>NONE</code> to specify unlimited duration.
        /// </para>
        ///  <note> 
        /// <para>
        /// A task start-to-close timeout for this workflow execution must be specified either
        /// as a default for the workflow type or through this parameter. If neither this parameter
        /// is set nor a default task start-to-close timeout was specified at registration time
        /// then a fault is returned.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=8)]
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
        /// The user defined identifier associated with the workflow execution. You can use this
        /// to associate a custom identifier with the workflow execution. You may specify the
        /// same identifier if a workflow execution is logically a <i>restart</i> of a previous
        /// execution. You cannot have two open workflow executions with the same <code>workflowId</code>
        /// at the same time within the same domain.
        /// </para>
        ///  
        /// <para>
        /// The specified string must not start or end with whitespace. It must not contain a
        /// <code>:</code> (colon), <code>/</code> (slash), <code>|</code> (vertical bar), or
        /// any control characters (<code>\u0000-\u001f</code> | <code>\u007f-\u009f</code>).
        /// Also, it must not <i>be</i> the literal string <code>arn</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// The type of the workflow to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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