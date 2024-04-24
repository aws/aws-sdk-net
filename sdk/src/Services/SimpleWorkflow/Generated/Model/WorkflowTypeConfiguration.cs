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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// The configuration settings of a workflow type.
    /// </summary>
    public partial class WorkflowTypeConfiguration
    {
        private ChildPolicy _defaultChildPolicy;
        private string _defaultExecutionStartToCloseTimeout;
        private string _defaultLambdaRole;
        private TaskList _defaultTaskList;
        private string _defaultTaskPriority;
        private string _defaultTaskStartToCloseTimeout;

        /// <summary>
        /// Gets and sets the property DefaultChildPolicy. 
        /// <para>
        ///  The default policy to use for the child workflow executions when a workflow execution
        /// of this type is terminated, by calling the <a>TerminateWorkflowExecution</a> action
        /// explicitly or due to an expired timeout. This default can be overridden when starting
        /// a workflow execution using the <a>StartWorkflowExecution</a> action or the <c>StartChildWorkflowExecution</c>
        /// <a>Decision</a>.
        /// </para>
        ///  
        /// <para>
        /// The supported child policies are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TERMINATE</c> – The child executions are terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REQUEST_CANCEL</c> – A request to cancel is attempted for each child execution
        /// by recording a <c>WorkflowExecutionCancelRequested</c> event in its history. It is
        /// up to the decider to take appropriate actions when it receives an execution history
        /// with this event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ABANDON</c> – No action is taken. The child executions continue to run.
        /// </para>
        ///  </li> </ul>
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
        ///  The default maximum duration, specified when registering the workflow type, for executions
        /// of this workflow type. This default can be overridden when starting a workflow execution
        /// using the <a>StartWorkflowExecution</a> action or the <c>StartChildWorkflowExecution</c>
        /// <a>Decision</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8)]
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
        /// Gets and sets the property DefaultLambdaRole. 
        /// <para>
        /// The default IAM role attached to this workflow type.
        /// </para>
        ///  <note> 
        /// <para>
        /// Executions of this workflow type need IAM roles to invoke Lambda functions. If you
        /// don't specify an IAM role when starting this workflow type, the default Lambda role
        /// is attached to the execution. For more information, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/lambda-task.html">https://docs.aws.amazon.com/amazonswf/latest/developerguide/lambda-task.html</a>
        /// in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string DefaultLambdaRole
        {
            get { return this._defaultLambdaRole; }
            set { this._defaultLambdaRole = value; }
        }

        // Check to see if DefaultLambdaRole property is set
        internal bool IsSetDefaultLambdaRole()
        {
            return this._defaultLambdaRole != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTaskList. 
        /// <para>
        ///  The default task list, specified when registering the workflow type, for decisions
        /// tasks scheduled for workflow executions of this type. This default can be overridden
        /// when starting a workflow execution using the <a>StartWorkflowExecution</a> action
        /// or the <c>StartChildWorkflowExecution</c> <a>Decision</a>.
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
        /// Gets and sets the property DefaultTaskPriority. 
        /// <para>
        ///  The default task priority, specified when registering the workflow type, for all
        /// decision tasks of this workflow type. This default can be overridden when starting
        /// a workflow execution using the <a>StartWorkflowExecution</a> action or the <c>StartChildWorkflowExecution</c>
        /// decision.
        /// </para>
        ///  
        /// <para>
        /// Valid values are integers that range from Java's <c>Integer.MIN_VALUE</c> (-2147483648)
        /// to <c>Integer.MAX_VALUE</c> (2147483647). Higher numbers indicate higher priority.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting task priority, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/programming-priority.html">Setting
        /// Task Priority</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        public string DefaultTaskPriority
        {
            get { return this._defaultTaskPriority; }
            set { this._defaultTaskPriority = value; }
        }

        // Check to see if DefaultTaskPriority property is set
        internal bool IsSetDefaultTaskPriority()
        {
            return this._defaultTaskPriority != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTaskStartToCloseTimeout. 
        /// <para>
        ///  The default maximum duration, specified when registering the workflow type, that
        /// a decision task for executions of this workflow type might take before returning completion
        /// or failure. If the task doesn'tdo close in the specified time then the task is automatically
        /// timed out and rescheduled. If the decider eventually reports a completion or failure,
        /// it is ignored. This default can be overridden when starting a workflow execution using
        /// the <a>StartWorkflowExecution</a> action or the <c>StartChildWorkflowExecution</c>
        /// <a>Decision</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8)]
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