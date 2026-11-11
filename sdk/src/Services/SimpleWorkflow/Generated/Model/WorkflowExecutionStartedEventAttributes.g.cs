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
    /// Provides details of <c>WorkflowExecutionStarted</c> event.
    /// </summary>
    public partial class WorkflowExecutionStartedEventAttributes
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
        /// Gets and sets the property ContinuedExecutionRunId. 
        /// <para>
        /// If this workflow execution was started due to a <c>ContinueAsNewWorkflowExecution</c>
        /// decision, then it contains the <c>runId</c> of the previous workflow execution that
        /// was closed and continued as this execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string ContinuedExecutionRunId { get; set; }

        /// <summary>
        /// Checks to see if the ContinuedExecutionRunId property is set.
        /// </summary>
        internal bool IsSetContinuedExecutionRunId() => this.ContinuedExecutionRunId != null;

        /// <summary>
        /// Gets and sets the property ExecutionStartToCloseTimeout. 
        /// <para>
        /// The maximum duration for this workflow execution.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public string ExecutionStartToCloseTimeout { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStartToCloseTimeout property is set.
        /// </summary>
        internal bool IsSetExecutionStartToCloseTimeout() => this.ExecutionStartToCloseTimeout != null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The input provided to the workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property LambdaRole. 
        /// <para>
        /// The IAM role attached to the workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string LambdaRole { get; set; }

        /// <summary>
        /// Checks to see if the LambdaRole property is set.
        /// </summary>
        internal bool IsSetLambdaRole() => this.LambdaRole != null;

        /// <summary>
        /// Gets and sets the property ParentInitiatedEventId. 
        /// <para>
        /// The ID of the <c>StartChildWorkflowExecutionInitiated</c> event corresponding to the
        /// <c>StartChildWorkflowExecution</c> <a>Decision</a> to start this workflow execution.
        /// The source event with this ID can be found in the history of the source workflow execution.
        /// This information can be useful for diagnosing problems by tracing back the chain of
        /// events leading up to this event.
        /// </para>
        /// </summary>
        public long? ParentInitiatedEventId { get; set; }

        /// <summary>
        /// Checks to see if the ParentInitiatedEventId property is set.
        /// </summary>
        internal bool IsSetParentInitiatedEventId() => this.ParentInitiatedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property ParentWorkflowExecution. 
        /// <para>
        /// The source workflow execution that started this workflow execution. The member isn't
        /// set if the workflow execution was not started by a workflow.
        /// </para>
        /// </summary>
        public WorkflowExecution ParentWorkflowExecution { get; set; }

        /// <summary>
        /// Checks to see if the ParentWorkflowExecution property is set.
        /// </summary>
        internal bool IsSetParentWorkflowExecution() => this.ParentWorkflowExecution != null;

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// The list of tags associated with this workflow execution. An execution can have up
        /// to 5 tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> TagList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TagList property is set.
        /// </summary>
        internal bool IsSetTagList() => this.TagList != null && (this.TagList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskList. 
        /// <para>
        /// The name of the task list for scheduling the decision tasks for this workflow execution.
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
        /// The priority of the decision tasks in the workflow execution.
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
        /// The maximum duration of decision tasks for this workflow type.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public string TaskStartToCloseTimeout { get; set; }

        /// <summary>
        /// Checks to see if the TaskStartToCloseTimeout property is set.
        /// </summary>
        internal bool IsSetTaskStartToCloseTimeout() => this.TaskStartToCloseTimeout != null;

        /// <summary>
        /// Gets and sets the property WorkflowType. 
        /// <para>
        /// The workflow type of this execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowType WorkflowType { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowType property is set.
        /// </summary>
        internal bool IsSetWorkflowType() => this.WorkflowType != null;
    }
}
