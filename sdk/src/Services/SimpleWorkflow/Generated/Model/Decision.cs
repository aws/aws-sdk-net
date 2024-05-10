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
    /// Specifies a decision made by the decider. A decision can be one of these types:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>CancelTimer</c> – Cancels a previously started timer and records a <c>TimerCanceled</c>
    /// event in the history.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CancelWorkflowExecution</c> – Closes the workflow execution and records a <c>WorkflowExecutionCanceled</c>
    /// event in the history.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CompleteWorkflowExecution</c> – Closes the workflow execution and records a <c>WorkflowExecutionCompleted</c>
    /// event in the history .
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ContinueAsNewWorkflowExecution</c> – Closes the workflow execution and starts
    /// a new workflow execution of the same type using the same workflow ID and a unique
    /// run Id. A <c>WorkflowExecutionContinuedAsNew</c> event is recorded in the history.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>FailWorkflowExecution</c> – Closes the workflow execution and records a <c>WorkflowExecutionFailed</c>
    /// event in the history.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RecordMarker</c> – Records a <c>MarkerRecorded</c> event in the history. Markers
    /// can be used for adding custom information in the history for instance to let deciders
    /// know that they don't need to look at the history beyond the marker event.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RequestCancelActivityTask</c> – Attempts to cancel a previously scheduled activity
    /// task. If the activity task was scheduled but has not been assigned to a worker, then
    /// it is canceled. If the activity task was already assigned to a worker, then the worker
    /// is informed that cancellation has been requested in the response to <a>RecordActivityTaskHeartbeat</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RequestCancelExternalWorkflowExecution</c> – Requests that a request be made to
    /// cancel the specified external workflow execution and records a <c>RequestCancelExternalWorkflowExecutionInitiated</c>
    /// event in the history.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ScheduleActivityTask</c> – Schedules an activity task.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SignalExternalWorkflowExecution</c> – Requests a signal to be delivered to the
    /// specified external workflow execution and records a <c>SignalExternalWorkflowExecutionInitiated</c>
    /// event in the history.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>StartChildWorkflowExecution</c> – Requests that a child workflow execution be
    /// started and records a <c>StartChildWorkflowExecutionInitiated</c> event in the history.
    /// The child workflow execution is a separate workflow execution with its own history.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>StartTimer</c> – Starts a timer for this workflow execution and records a <c>TimerStarted</c>
    /// event in the history. This timer fires after the specified delay and record a <c>TimerFired</c>
    /// event.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Access Control</b> 
    /// </para>
    ///  
    /// <para>
    /// If you grant permission to use <c>RespondDecisionTaskCompleted</c>, you can use IAM
    /// policies to express permissions for the list of decisions returned by this action
    /// as if they were members of the API. Treating decisions as a pseudo API maintains a
    /// uniform conceptual model and helps keep policies readable. For details and example
    /// IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Decision Failure</b> 
    /// </para>
    ///  
    /// <para>
    /// Decisions can fail for several reasons
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The ordering of decisions should follow a logical flow. Some decisions might not make
    /// sense in the current context of the workflow execution and therefore fails.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A limit on your account was reached.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The decision lacks sufficient permissions.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// One of the following events might be added to the history to indicate an error. The
    /// event attribute's <c>cause</c> parameter indicates the cause. If <c>cause</c> is set
    /// to <c>OPERATION_NOT_PERMITTED</c>, the decision failed because it lacked sufficient
    /// permissions. For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>ScheduleActivityTaskFailed</c> – A <c>ScheduleActivityTask</c> decision failed.
    /// This could happen if the activity type specified in the decision isn't registered,
    /// is in a deprecated state, or the decision isn't properly configured.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RequestCancelActivityTaskFailed</c> – A <c>RequestCancelActivityTask</c> decision
    /// failed. This could happen if there is no open activity task with the specified activityId.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>StartTimerFailed</c> – A <c>StartTimer</c> decision failed. This could happen
    /// if there is another open timer with the same timerId.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CancelTimerFailed</c> – A <c>CancelTimer</c> decision failed. This could happen
    /// if there is no open timer with the specified timerId.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>StartChildWorkflowExecutionFailed</c> – A <c>StartChildWorkflowExecution</c> decision
    /// failed. This could happen if the workflow type specified isn't registered, is deprecated,
    /// or the decision isn't properly configured.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SignalExternalWorkflowExecutionFailed</c> – A <c>SignalExternalWorkflowExecution</c>
    /// decision failed. This could happen if the <c>workflowID</c> specified in the decision
    /// was incorrect.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RequestCancelExternalWorkflowExecutionFailed</c> – A <c>RequestCancelExternalWorkflowExecution</c>
    /// decision failed. This could happen if the <c>workflowID</c> specified in the decision
    /// was incorrect.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CancelWorkflowExecutionFailed</c> – A <c>CancelWorkflowExecution</c> decision
    /// failed. This could happen if there is an unhandled decision task pending in the workflow
    /// execution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CompleteWorkflowExecutionFailed</c> – A <c>CompleteWorkflowExecution</c> decision
    /// failed. This could happen if there is an unhandled decision task pending in the workflow
    /// execution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ContinueAsNewWorkflowExecutionFailed</c> – A <c>ContinueAsNewWorkflowExecution</c>
    /// decision failed. This could happen if there is an unhandled decision task pending
    /// in the workflow execution or the ContinueAsNewWorkflowExecution decision was not configured
    /// correctly.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>FailWorkflowExecutionFailed</c> – A <c>FailWorkflowExecution</c> decision failed.
    /// This could happen if there is an unhandled decision task pending in the workflow execution.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The preceding error events might occur due to an error in the decider logic, which
    /// might put the workflow execution in an unstable state The cause field in the event
    /// structure for the error event indicates the cause of the error.
    /// </para>
    ///  <note> 
    /// <para>
    /// A workflow execution may be closed by the decider by returning one of the following
    /// decisions when completing a decision task: <c>CompleteWorkflowExecution</c>, <c>FailWorkflowExecution</c>,
    /// <c>CancelWorkflowExecution</c> and <c>ContinueAsNewWorkflowExecution</c>. An <c>UnhandledDecision</c>
    /// fault is returned if a workflow closing decision is specified and a signal or activity
    /// event had been added to the history while the decision task was being performed by
    /// the decider. Unlike the above situations which are logic issues, this fault is always
    /// possible because of race conditions in a distributed system. The right action here
    /// is to call <a>RespondDecisionTaskCompleted</a> without any decisions. This would result
    /// in another decision task with these new events included in the history. The decider
    /// should handle the new events and may decide to close the workflow execution.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>How to Code a Decision</b> 
    /// </para>
    ///  
    /// <para>
    /// You code a decision by first setting the decision type field to one of the above decision
    /// values, and then set the corresponding attributes field shown below:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c> <a>ScheduleActivityTaskDecisionAttributes</a> </c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <a>RequestCancelActivityTaskDecisionAttributes</a> </c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <a>CompleteWorkflowExecutionDecisionAttributes</a> </c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <a>FailWorkflowExecutionDecisionAttributes</a> </c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <a>CancelWorkflowExecutionDecisionAttributes</a> </c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <a>ContinueAsNewWorkflowExecutionDecisionAttributes</a> </c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <a>RecordMarkerDecisionAttributes</a> </c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <a>StartTimerDecisionAttributes</a> </c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <a>CancelTimerDecisionAttributes</a> </c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <a>SignalExternalWorkflowExecutionDecisionAttributes</a> </c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <a>RequestCancelExternalWorkflowExecutionDecisionAttributes</a> </c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <a>StartChildWorkflowExecutionDecisionAttributes</a> </c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Decision
    {
        private CancelTimerDecisionAttributes _cancelTimerDecisionAttributes;
        private CancelWorkflowExecutionDecisionAttributes _cancelWorkflowExecutionDecisionAttributes;
        private CompleteWorkflowExecutionDecisionAttributes _completeWorkflowExecutionDecisionAttributes;
        private ContinueAsNewWorkflowExecutionDecisionAttributes _continueAsNewWorkflowExecutionDecisionAttributes;
        private DecisionType _decisionType;
        private FailWorkflowExecutionDecisionAttributes _failWorkflowExecutionDecisionAttributes;
        private RecordMarkerDecisionAttributes _recordMarkerDecisionAttributes;
        private RequestCancelActivityTaskDecisionAttributes _requestCancelActivityTaskDecisionAttributes;
        private RequestCancelExternalWorkflowExecutionDecisionAttributes _requestCancelExternalWorkflowExecutionDecisionAttributes;
        private ScheduleActivityTaskDecisionAttributes _scheduleActivityTaskDecisionAttributes;
        private ScheduleLambdaFunctionDecisionAttributes _scheduleLambdaFunctionDecisionAttributes;
        private SignalExternalWorkflowExecutionDecisionAttributes _signalExternalWorkflowExecutionDecisionAttributes;
        private StartChildWorkflowExecutionDecisionAttributes _startChildWorkflowExecutionDecisionAttributes;
        private StartTimerDecisionAttributes _startTimerDecisionAttributes;

        /// <summary>
        /// Gets and sets the property CancelTimerDecisionAttributes. 
        /// <para>
        /// Provides the details of the <c>CancelTimer</c> decision. It isn't set for other decision
        /// types.
        /// </para>
        /// </summary>
        public CancelTimerDecisionAttributes CancelTimerDecisionAttributes
        {
            get { return this._cancelTimerDecisionAttributes; }
            set { this._cancelTimerDecisionAttributes = value; }
        }

        // Check to see if CancelTimerDecisionAttributes property is set
        internal bool IsSetCancelTimerDecisionAttributes()
        {
            return this._cancelTimerDecisionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property CancelWorkflowExecutionDecisionAttributes. 
        /// <para>
        /// Provides the details of the <c>CancelWorkflowExecution</c> decision. It isn't set
        /// for other decision types.
        /// </para>
        /// </summary>
        public CancelWorkflowExecutionDecisionAttributes CancelWorkflowExecutionDecisionAttributes
        {
            get { return this._cancelWorkflowExecutionDecisionAttributes; }
            set { this._cancelWorkflowExecutionDecisionAttributes = value; }
        }

        // Check to see if CancelWorkflowExecutionDecisionAttributes property is set
        internal bool IsSetCancelWorkflowExecutionDecisionAttributes()
        {
            return this._cancelWorkflowExecutionDecisionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property CompleteWorkflowExecutionDecisionAttributes. 
        /// <para>
        /// Provides the details of the <c>CompleteWorkflowExecution</c> decision. It isn't set
        /// for other decision types.
        /// </para>
        /// </summary>
        public CompleteWorkflowExecutionDecisionAttributes CompleteWorkflowExecutionDecisionAttributes
        {
            get { return this._completeWorkflowExecutionDecisionAttributes; }
            set { this._completeWorkflowExecutionDecisionAttributes = value; }
        }

        // Check to see if CompleteWorkflowExecutionDecisionAttributes property is set
        internal bool IsSetCompleteWorkflowExecutionDecisionAttributes()
        {
            return this._completeWorkflowExecutionDecisionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ContinueAsNewWorkflowExecutionDecisionAttributes. 
        /// <para>
        /// Provides the details of the <c>ContinueAsNewWorkflowExecution</c> decision. It isn't
        /// set for other decision types.
        /// </para>
        /// </summary>
        public ContinueAsNewWorkflowExecutionDecisionAttributes ContinueAsNewWorkflowExecutionDecisionAttributes
        {
            get { return this._continueAsNewWorkflowExecutionDecisionAttributes; }
            set { this._continueAsNewWorkflowExecutionDecisionAttributes = value; }
        }

        // Check to see if ContinueAsNewWorkflowExecutionDecisionAttributes property is set
        internal bool IsSetContinueAsNewWorkflowExecutionDecisionAttributes()
        {
            return this._continueAsNewWorkflowExecutionDecisionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property DecisionType. 
        /// <para>
        /// Specifies the type of the decision.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DecisionType DecisionType
        {
            get { return this._decisionType; }
            set { this._decisionType = value; }
        }

        // Check to see if DecisionType property is set
        internal bool IsSetDecisionType()
        {
            return this._decisionType != null;
        }

        /// <summary>
        /// Gets and sets the property FailWorkflowExecutionDecisionAttributes. 
        /// <para>
        /// Provides the details of the <c>FailWorkflowExecution</c> decision. It isn't set for
        /// other decision types.
        /// </para>
        /// </summary>
        public FailWorkflowExecutionDecisionAttributes FailWorkflowExecutionDecisionAttributes
        {
            get { return this._failWorkflowExecutionDecisionAttributes; }
            set { this._failWorkflowExecutionDecisionAttributes = value; }
        }

        // Check to see if FailWorkflowExecutionDecisionAttributes property is set
        internal bool IsSetFailWorkflowExecutionDecisionAttributes()
        {
            return this._failWorkflowExecutionDecisionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property RecordMarkerDecisionAttributes. 
        /// <para>
        /// Provides the details of the <c>RecordMarker</c> decision. It isn't set for other decision
        /// types.
        /// </para>
        /// </summary>
        public RecordMarkerDecisionAttributes RecordMarkerDecisionAttributes
        {
            get { return this._recordMarkerDecisionAttributes; }
            set { this._recordMarkerDecisionAttributes = value; }
        }

        // Check to see if RecordMarkerDecisionAttributes property is set
        internal bool IsSetRecordMarkerDecisionAttributes()
        {
            return this._recordMarkerDecisionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCancelActivityTaskDecisionAttributes. 
        /// <para>
        /// Provides the details of the <c>RequestCancelActivityTask</c> decision. It isn't set
        /// for other decision types.
        /// </para>
        /// </summary>
        public RequestCancelActivityTaskDecisionAttributes RequestCancelActivityTaskDecisionAttributes
        {
            get { return this._requestCancelActivityTaskDecisionAttributes; }
            set { this._requestCancelActivityTaskDecisionAttributes = value; }
        }

        // Check to see if RequestCancelActivityTaskDecisionAttributes property is set
        internal bool IsSetRequestCancelActivityTaskDecisionAttributes()
        {
            return this._requestCancelActivityTaskDecisionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCancelExternalWorkflowExecutionDecisionAttributes.
        /// 
        /// <para>
        /// Provides the details of the <c>RequestCancelExternalWorkflowExecution</c> decision.
        /// It isn't set for other decision types.
        /// </para>
        /// </summary>
        public RequestCancelExternalWorkflowExecutionDecisionAttributes RequestCancelExternalWorkflowExecutionDecisionAttributes
        {
            get { return this._requestCancelExternalWorkflowExecutionDecisionAttributes; }
            set { this._requestCancelExternalWorkflowExecutionDecisionAttributes = value; }
        }

        // Check to see if RequestCancelExternalWorkflowExecutionDecisionAttributes property is set
        internal bool IsSetRequestCancelExternalWorkflowExecutionDecisionAttributes()
        {
            return this._requestCancelExternalWorkflowExecutionDecisionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleActivityTaskDecisionAttributes. 
        /// <para>
        /// Provides the details of the <c>ScheduleActivityTask</c> decision. It isn't set for
        /// other decision types.
        /// </para>
        /// </summary>
        public ScheduleActivityTaskDecisionAttributes ScheduleActivityTaskDecisionAttributes
        {
            get { return this._scheduleActivityTaskDecisionAttributes; }
            set { this._scheduleActivityTaskDecisionAttributes = value; }
        }

        // Check to see if ScheduleActivityTaskDecisionAttributes property is set
        internal bool IsSetScheduleActivityTaskDecisionAttributes()
        {
            return this._scheduleActivityTaskDecisionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleLambdaFunctionDecisionAttributes. 
        /// <para>
        /// Provides the details of the <c>ScheduleLambdaFunction</c> decision. It isn't set for
        /// other decision types.
        /// </para>
        /// </summary>
        public ScheduleLambdaFunctionDecisionAttributes ScheduleLambdaFunctionDecisionAttributes
        {
            get { return this._scheduleLambdaFunctionDecisionAttributes; }
            set { this._scheduleLambdaFunctionDecisionAttributes = value; }
        }

        // Check to see if ScheduleLambdaFunctionDecisionAttributes property is set
        internal bool IsSetScheduleLambdaFunctionDecisionAttributes()
        {
            return this._scheduleLambdaFunctionDecisionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property SignalExternalWorkflowExecutionDecisionAttributes. 
        /// <para>
        /// Provides the details of the <c>SignalExternalWorkflowExecution</c> decision. It isn't
        /// set for other decision types.
        /// </para>
        /// </summary>
        public SignalExternalWorkflowExecutionDecisionAttributes SignalExternalWorkflowExecutionDecisionAttributes
        {
            get { return this._signalExternalWorkflowExecutionDecisionAttributes; }
            set { this._signalExternalWorkflowExecutionDecisionAttributes = value; }
        }

        // Check to see if SignalExternalWorkflowExecutionDecisionAttributes property is set
        internal bool IsSetSignalExternalWorkflowExecutionDecisionAttributes()
        {
            return this._signalExternalWorkflowExecutionDecisionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property StartChildWorkflowExecutionDecisionAttributes. 
        /// <para>
        /// Provides the details of the <c>StartChildWorkflowExecution</c> decision. It isn't
        /// set for other decision types.
        /// </para>
        /// </summary>
        public StartChildWorkflowExecutionDecisionAttributes StartChildWorkflowExecutionDecisionAttributes
        {
            get { return this._startChildWorkflowExecutionDecisionAttributes; }
            set { this._startChildWorkflowExecutionDecisionAttributes = value; }
        }

        // Check to see if StartChildWorkflowExecutionDecisionAttributes property is set
        internal bool IsSetStartChildWorkflowExecutionDecisionAttributes()
        {
            return this._startChildWorkflowExecutionDecisionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimerDecisionAttributes. 
        /// <para>
        /// Provides the details of the <c>StartTimer</c> decision. It isn't set for other decision
        /// types.
        /// </para>
        /// </summary>
        public StartTimerDecisionAttributes StartTimerDecisionAttributes
        {
            get { return this._startTimerDecisionAttributes; }
            set { this._startTimerDecisionAttributes = value; }
        }

        // Check to see if StartTimerDecisionAttributes property is set
        internal bool IsSetStartTimerDecisionAttributes()
        {
            return this._startTimerDecisionAttributes != null;
        }

    }
}