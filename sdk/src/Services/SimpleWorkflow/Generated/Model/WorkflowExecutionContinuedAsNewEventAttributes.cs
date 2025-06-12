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
    /// Provides the details of the <c>WorkflowExecutionContinuedAsNew</c> event.
    /// </summary>
    public partial class WorkflowExecutionContinuedAsNewEventAttributes
    {
        private ChildPolicy _childPolicy;
        private long? _decisionTaskCompletedEventId;
        private string _executionStartToCloseTimeout;
        private string _input;
        private string _lambdaRole;
        private string _newExecutionRunId;
        private List<string> _tagList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TaskList _taskList;
        private string _taskPriority;
        private string _taskStartToCloseTimeout;
        private WorkflowType _workflowType;

        /// <summary>
        /// Gets and sets the property ChildPolicy. 
        /// <para>
        /// The policy to use for the child workflow executions of the new execution if it is
        /// terminated by calling the <a>TerminateWorkflowExecution</a> action explicitly or due
        /// to an expired timeout.
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DecisionTaskCompletedEventId. 
        /// <para>
        /// The ID of the <c>DecisionTaskCompleted</c> event corresponding to the decision task
        /// that resulted in the <c>ContinueAsNewWorkflowExecution</c> decision that started this
        /// execution. This information can be useful for diagnosing problems by tracing back
        /// the chain of events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? DecisionTaskCompletedEventId
        {
            get { return this._decisionTaskCompletedEventId; }
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
        /// The total duration allowed for the new workflow execution.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
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
        /// The input provided to the new workflow execution.
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
        /// The IAM role to attach to the new (continued) workflow execution.
        /// </para>
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
        /// Gets and sets the property NewExecutionRunId. 
        /// <para>
        /// The <c>runId</c> of the new workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string NewExecutionRunId
        {
            get { return this._newExecutionRunId; }
            set { this._newExecutionRunId = value; }
        }

        // Check to see if NewExecutionRunId property is set
        internal bool IsSetNewExecutionRunId()
        {
            return this._newExecutionRunId != null;
        }

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// The list of tags associated with the new workflow execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tagList != null && (this._tagList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskList. 
        /// <para>
        /// The task list to use for the decisions of the new (continued) workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The priority of the task to use for the decisions of the new (continued) workflow
        /// execution.
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
        /// The maximum duration of decision tasks for the new workflow execution.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
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
        /// Gets and sets the property WorkflowType. 
        /// <para>
        /// The workflow type of this execution.
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