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
    /// Provides the details of the <c>StartChildWorkflowExecution</c> decision.
    /// 
    ///  
    /// <para>
    ///  <b>Access Control</b> 
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this decision's access to Amazon SWF resources
    /// as follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use a <c>Resource</c> element with the domain name to limit the action to only specified
    /// domains.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use an <c>Action</c> element to allow or deny permission to call this action.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Constrain the following parameters by using a <c>Condition</c> element with the appropriate
    /// keys.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>tagList.member.N</c> – The key is "swf:tagList.N" where N is the tag number from
    /// 0 to 4, inclusive.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>taskList</c> – String constraint. The key is <c>swf:taskList.name</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>workflowType.name</c> – String constraint. The key is <c>swf:workflowType.name</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>workflowType.version</c> – String constraint. The key is <c>swf:workflowType.version</c>.
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <c>cause</c> parameter is set to <c>OPERATION_NOT_PERMITTED</c>. For details
    /// and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class StartChildWorkflowExecutionDecisionAttributes
    {
        private ChildPolicy _childPolicy;
        private string _control;
        private string _executionStartToCloseTimeout;
        private string _input;
        private string _lambdaRole;
        private List<string> _tagList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TaskList _taskList;
        private string _taskPriority;
        private string _taskStartToCloseTimeout;
        private string _workflowId;
        private WorkflowType _workflowType;

        /// <summary>
        /// Gets and sets the property ChildPolicy. 
        /// <para>
        ///  If set, specifies the policy to use for the child workflow executions if the workflow
        /// execution being started is terminated by calling the <a>TerminateWorkflowExecution</a>
        /// action explicitly or due to an expired timeout. This policy overrides the default
        /// child policy specified when registering the workflow type using <a>RegisterWorkflowType</a>.
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
        /// Gets and sets the property Control. 
        /// <para>
        /// The data attached to the event that can be used by the decider in subsequent workflow
        /// tasks. This data isn't sent to the child workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
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
        /// Gets and sets the property ExecutionStartToCloseTimeout. 
        /// <para>
        /// The total duration for this workflow execution. This overrides the defaultExecutionStartToCloseTimeout
        /// specified when registering the workflow type.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
        /// </para>
        ///  <note> 
        /// <para>
        /// An execution start-to-close timeout for this workflow execution must be specified
        /// either as a default for the workflow type or through this parameter. If neither this
        /// parameter is set nor a default execution start-to-close timeout was specified at registration
        /// time then a fault is returned.
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
        /// The input to be provided to the workflow execution.
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
        /// The IAM role attached to the child workflow execution.
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
        /// Gets and sets the property TagList. 
        /// <para>
        /// The list of tags to associate with the child workflow execution. A maximum of 5 tags
        /// can be specified. You can list workflow executions with a specific tag by calling
        /// <a>ListOpenWorkflowExecutions</a> or <a>ListClosedWorkflowExecutions</a> and specifying
        /// a <a>TagFilter</a>.
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
        /// The name of the task list to be used for decision tasks of the child workflow execution.
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
        /// <c>:</c> (colon), <c>/</c> (slash), <c>|</c> (vertical bar), or any control characters
        /// (<c>\u0000-\u001f</c> | <c>\u007f-\u009f</c>). Also, it must <i>not</i> be the literal
        /// string <c>arn</c>.
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
        ///  A task priority that, if set, specifies the priority for a decision task of this
        /// workflow execution. This overrides the defaultTaskPriority specified when registering
        /// the workflow type. Valid values are integers that range from Java's <c>Integer.MIN_VALUE</c>
        /// (-2147483648) to <c>Integer.MAX_VALUE</c> (2147483647). Higher numbers indicate higher
        /// priority.
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
        /// parameter overrides the <c>defaultTaskStartToCloseTimout</c> specified when registering
        /// the workflow type using <a>RegisterWorkflowType</a>.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds, an integer greater than or equal to <c>0</c>.
        /// You can use <c>NONE</c> to specify unlimited duration.
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
        ///  The <c>workflowId</c> of the workflow execution.
        /// </para>
        ///  
        /// <para>
        /// The specified string must not contain a <c>:</c> (colon), <c>/</c> (slash), <c>|</c>
        /// (vertical bar), or any control characters (<c>\u0000-\u001f</c> | <c>\u007f-\u009f</c>).
        /// Also, it must <i>not</i> be the literal string <c>arn</c>.
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
        ///  The type of the workflow execution to be started.
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