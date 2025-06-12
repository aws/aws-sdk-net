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
    /// Container for the parameters to the RespondDecisionTaskCompleted operation.
    /// Used by deciders to tell the service that the <a>DecisionTask</a> identified by the
    /// <c>taskToken</c> has successfully completed. The <c>decisions</c> argument specifies
    /// the list of decisions made while processing the task.
    /// 
    ///  
    /// <para>
    /// A <c>DecisionTaskCompleted</c> event is added to the workflow history. The <c>executionContext</c>
    /// specified is attached to the event in the workflow execution history.
    /// </para>
    ///  
    /// <para>
    ///  <b>Access Control</b> 
    /// </para>
    ///  
    /// <para>
    /// If an IAM policy grants permission to use <c>RespondDecisionTaskCompleted</c>, it
    /// can express permissions for the list of decisions in the <c>decisions</c> parameter.
    /// Each of the decisions has one or more parameters, much like a regular API call. To
    /// allow for policies to be as readable as possible, you can express permissions on decisions
    /// as if they were actual API calls, including applying conditions to some parameters.
    /// For more information, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class RespondDecisionTaskCompletedRequest : AmazonSimpleWorkflowRequest
    {
        private List<Decision> _decisions = AWSConfigs.InitializeCollections ? new List<Decision>() : null;
        private string _executionContext;
        private TaskList _taskList;
        private string _taskListScheduleToStartTimeout;
        private string _taskToken;

        /// <summary>
        /// Gets and sets the property Decisions. 
        /// <para>
        /// The list of decisions (possibly empty) made by the decider while processing this decision
        /// task. See the docs for the <a>Decision</a> structure for details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Decision> Decisions
        {
            get { return this._decisions; }
            set { this._decisions = value; }
        }

        // Check to see if Decisions property is set
        internal bool IsSetDecisions()
        {
            return this._decisions != null && (this._decisions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExecutionContext. 
        /// <para>
        /// User defined context to add to workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string ExecutionContext
        {
            get { return this._executionContext; }
            set { this._executionContext = value; }
        }

        // Check to see if ExecutionContext property is set
        internal bool IsSetExecutionContext()
        {
            return this._executionContext != null;
        }

        /// <summary>
        /// Gets and sets the property TaskList. 
        /// <para>
        /// The task list to use for the future decision tasks of this workflow execution. This
        /// list overrides the original task list you specified while starting the workflow execution.
        /// 
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
        /// Gets and sets the property TaskListScheduleToStartTimeout. 
        /// <para>
        /// Specifies a timeout (in seconds) for the task list override. When this parameter is
        /// missing, the task list override is permanent. This parameter makes it possible to
        /// temporarily override the task list. If a decision task scheduled on the override task
        /// list is not started within the timeout, the decision task will time out. Amazon SWF
        /// will revert the override and schedule a new decision task to the original task list.
        /// </para>
        ///  
        /// <para>
        /// If a decision task scheduled on the override task list is started within the timeout,
        /// but not completed within the start-to-close timeout, Amazon SWF will also revert the
        /// override and schedule a new decision task to the original task list.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8)]
        public string TaskListScheduleToStartTimeout
        {
            get { return this._taskListScheduleToStartTimeout; }
            set { this._taskListScheduleToStartTimeout = value; }
        }

        // Check to see if TaskListScheduleToStartTimeout property is set
        internal bool IsSetTaskListScheduleToStartTimeout()
        {
            return this._taskListScheduleToStartTimeout != null;
        }

        /// <summary>
        /// Gets and sets the property TaskToken. 
        /// <para>
        /// The <c>taskToken</c> from the <a>DecisionTask</a>.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <c>taskToken</c> is generated by the service and should be treated as an opaque value.
        /// If the task is passed to another process, its <c>taskToken</c> must also be passed.
        /// This enables it to provide its progress and respond with results.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string TaskToken
        {
            get { return this._taskToken; }
            set { this._taskToken = value; }
        }

        // Check to see if TaskToken property is set
        internal bool IsSetTaskToken()
        {
            return this._taskToken != null;
        }

    }
}