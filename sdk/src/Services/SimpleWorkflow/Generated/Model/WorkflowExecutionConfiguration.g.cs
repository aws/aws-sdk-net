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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The configuration settings for a workflow execution including timeout values, tasklist
    /// etc. These configuration settings are determined from the defaults specified when
    /// registering the workflow type and those specified when starting the workflow execution.
    /// </summary>
    public partial class WorkflowExecutionConfiguration
    {
        /// <summary>
        /// Gets and sets the property ChildPolicy. 
        /// <para>
        /// The policy to use for the child workflow executions if this workflow execution is
        /// terminated, by calling the <a>TerminateWorkflowExecution</a> action explicitly or
        /// due to an expired timeout.
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
        [AWSProperty(Required = true)]
        public ChildPolicy ChildPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ChildPolicy property is set.
        /// </summary>
        internal bool IsSetChildPolicy() => this.ChildPolicy != null;

        /// <summary>
        /// Gets and sets the property ExecutionStartToCloseTimeout. 
        /// <para>
        /// The total duration for this workflow execution.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8)]
        public string ExecutionStartToCloseTimeout { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStartToCloseTimeout property is set.
        /// </summary>
        internal bool IsSetExecutionStartToCloseTimeout() => this.ExecutionStartToCloseTimeout != null;

        /// <summary>
        /// Gets and sets the property LambdaRole. 
        /// <para>
        /// The IAM role attached to the child workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string LambdaRole { get; set; }

        /// <summary>
        /// Checks to see if the LambdaRole property is set.
        /// </summary>
        internal bool IsSetLambdaRole() => this.LambdaRole != null;

        /// <summary>
        /// Gets and sets the property TaskList. 
        /// <para>
        /// The task list used for the decision tasks generated for this workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TaskList TaskList { get; set; }

        /// <summary>
        /// Checks to see if the TaskList property is set.
        /// </summary>
        internal bool IsSetTaskList() => this.TaskList != null;

        /// <summary>
        /// Gets and sets the property TaskPriority. 
        /// <para>
        /// The priority assigned to decision tasks for this workflow execution. Valid values
        /// are integers that range from Java's <c>Integer.MIN_VALUE</c> (-2147483648) to <c>Integer.MAX_VALUE</c>
        /// (2147483647). Higher numbers indicate higher priority.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting task priority, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/programming-priority.html">Setting
        /// Task Priority</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        /// </summary>
        public string TaskPriority { get; set; }

        /// <summary>
        /// Checks to see if the TaskPriority property is set.
        /// </summary>
        internal bool IsSetTaskPriority() => this.TaskPriority != null;

        /// <summary>
        /// Gets and sets the property TaskStartToCloseTimeout. 
        /// <para>
        /// The maximum duration allowed for decision tasks for this workflow execution.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8)]
        public string TaskStartToCloseTimeout { get; set; }

        /// <summary>
        /// Checks to see if the TaskStartToCloseTimeout property is set.
        /// </summary>
        internal bool IsSetTaskStartToCloseTimeout() => this.TaskStartToCloseTimeout != null;
    }
}
