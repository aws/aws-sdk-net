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
    /// Event within a workflow execution. A history event can be one of these types:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>ActivityTaskCancelRequested</c> – A <c>RequestCancelActivityTask</c> decision
    /// was received by the system.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ActivityTaskCanceled</c> – The activity task was successfully canceled.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ActivityTaskCompleted</c> – An activity worker successfully completed an activity
    /// task by calling <a>RespondActivityTaskCompleted</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ActivityTaskFailed</c> – An activity worker failed an activity task by calling
    /// <a>RespondActivityTaskFailed</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ActivityTaskScheduled</c> – An activity task was scheduled for execution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ActivityTaskStarted</c> – The scheduled activity task was dispatched to a worker.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ActivityTaskTimedOut</c> – The activity task timed out.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CancelTimerFailed</c> – Failed to process CancelTimer decision. This happens when
    /// the decision isn't configured properly, for example no timer exists with the specified
    /// timer Id.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CancelWorkflowExecutionFailed</c> – A request to cancel a workflow execution failed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ChildWorkflowExecutionCanceled</c> – A child workflow execution, started by this
    /// workflow execution, was canceled and closed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ChildWorkflowExecutionCompleted</c> – A child workflow execution, started by this
    /// workflow execution, completed successfully and was closed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ChildWorkflowExecutionFailed</c> – A child workflow execution, started by this
    /// workflow execution, failed to complete successfully and was closed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ChildWorkflowExecutionStarted</c> – A child workflow execution was successfully
    /// started.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ChildWorkflowExecutionTerminated</c> – A child workflow execution, started by
    /// this workflow execution, was terminated.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ChildWorkflowExecutionTimedOut</c> – A child workflow execution, started by this
    /// workflow execution, timed out and was closed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CompleteWorkflowExecutionFailed</c> – The workflow execution failed to complete.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ContinueAsNewWorkflowExecutionFailed</c> – The workflow execution failed to complete
    /// after being continued as a new workflow execution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DecisionTaskCompleted</c> – The decider successfully completed a decision task
    /// by calling <a>RespondDecisionTaskCompleted</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DecisionTaskScheduled</c> – A decision task was scheduled for the workflow execution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DecisionTaskStarted</c> – The decision task was dispatched to a decider.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DecisionTaskTimedOut</c> – The decision task timed out.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ExternalWorkflowExecutionCancelRequested</c> – Request to cancel an external workflow
    /// execution was successfully delivered to the target execution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ExternalWorkflowExecutionSignaled</c> – A signal, requested by this workflow execution,
    /// was successfully delivered to the target external workflow execution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>FailWorkflowExecutionFailed</c> – A request to mark a workflow execution as failed,
    /// itself failed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>MarkerRecorded</c> – A marker was recorded in the workflow history as the result
    /// of a <c>RecordMarker</c> decision.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RecordMarkerFailed</c> – A <c>RecordMarker</c> decision was returned as failed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RequestCancelActivityTaskFailed</c> – Failed to process RequestCancelActivityTask
    /// decision. This happens when the decision isn't configured properly.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RequestCancelExternalWorkflowExecutionFailed</c> – Request to cancel an external
    /// workflow execution failed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RequestCancelExternalWorkflowExecutionInitiated</c> – A request was made to request
    /// the cancellation of an external workflow execution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ScheduleActivityTaskFailed</c> – Failed to process ScheduleActivityTask decision.
    /// This happens when the decision isn't configured properly, for example the activity
    /// type specified isn't registered.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SignalExternalWorkflowExecutionFailed</c> – The request to signal an external
    /// workflow execution failed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SignalExternalWorkflowExecutionInitiated</c> – A request to signal an external
    /// workflow was made.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>StartActivityTaskFailed</c> – A scheduled activity task failed to start.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>StartChildWorkflowExecutionFailed</c> – Failed to process StartChildWorkflowExecution
    /// decision. This happens when the decision isn't configured properly, for example the
    /// workflow type specified isn't registered.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>StartChildWorkflowExecutionInitiated</c> – A request was made to start a child
    /// workflow execution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>StartTimerFailed</c> – Failed to process StartTimer decision. This happens when
    /// the decision isn't configured properly, for example a timer already exists with the
    /// specified timer Id.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TimerCanceled</c> – A timer, previously started for this workflow execution, was
    /// successfully canceled.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TimerFired</c> – A timer, previously started for this workflow execution, fired.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TimerStarted</c> – A timer was started for the workflow execution due to a <c>StartTimer</c>
    /// decision.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>WorkflowExecutionCancelRequested</c> – A request to cancel this workflow execution
    /// was made.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>WorkflowExecutionCanceled</c> – The workflow execution was successfully canceled
    /// and closed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>WorkflowExecutionCompleted</c> – The workflow execution was closed due to successful
    /// completion.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>WorkflowExecutionContinuedAsNew</c> – The workflow execution was closed and a
    /// new execution of the same type was created with the same workflowId.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>WorkflowExecutionFailed</c> – The workflow execution closed due to a failure.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>WorkflowExecutionSignaled</c> – An external signal was received for the workflow
    /// execution.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>WorkflowExecutionStarted</c> – The workflow execution was started.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>WorkflowExecutionTerminated</c> – The workflow execution was terminated.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>WorkflowExecutionTimedOut</c> – The workflow execution was closed because a time
    /// out was exceeded.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class HistoryEvent
    {
        private ActivityTaskCanceledEventAttributes _activityTaskCanceledEventAttributes;
        private ActivityTaskCancelRequestedEventAttributes _activityTaskCancelRequestedEventAttributes;
        private ActivityTaskCompletedEventAttributes _activityTaskCompletedEventAttributes;
        private ActivityTaskFailedEventAttributes _activityTaskFailedEventAttributes;
        private ActivityTaskScheduledEventAttributes _activityTaskScheduledEventAttributes;
        private ActivityTaskStartedEventAttributes _activityTaskStartedEventAttributes;
        private ActivityTaskTimedOutEventAttributes _activityTaskTimedOutEventAttributes;
        private CancelTimerFailedEventAttributes _cancelTimerFailedEventAttributes;
        private CancelWorkflowExecutionFailedEventAttributes _cancelWorkflowExecutionFailedEventAttributes;
        private ChildWorkflowExecutionCanceledEventAttributes _childWorkflowExecutionCanceledEventAttributes;
        private ChildWorkflowExecutionCompletedEventAttributes _childWorkflowExecutionCompletedEventAttributes;
        private ChildWorkflowExecutionFailedEventAttributes _childWorkflowExecutionFailedEventAttributes;
        private ChildWorkflowExecutionStartedEventAttributes _childWorkflowExecutionStartedEventAttributes;
        private ChildWorkflowExecutionTerminatedEventAttributes _childWorkflowExecutionTerminatedEventAttributes;
        private ChildWorkflowExecutionTimedOutEventAttributes _childWorkflowExecutionTimedOutEventAttributes;
        private CompleteWorkflowExecutionFailedEventAttributes _completeWorkflowExecutionFailedEventAttributes;
        private ContinueAsNewWorkflowExecutionFailedEventAttributes _continueAsNewWorkflowExecutionFailedEventAttributes;
        private DecisionTaskCompletedEventAttributes _decisionTaskCompletedEventAttributes;
        private DecisionTaskScheduledEventAttributes _decisionTaskScheduledEventAttributes;
        private DecisionTaskStartedEventAttributes _decisionTaskStartedEventAttributes;
        private DecisionTaskTimedOutEventAttributes _decisionTaskTimedOutEventAttributes;
        private long? _eventId;
        private DateTime? _eventTimestamp;
        private EventType _eventType;
        private ExternalWorkflowExecutionCancelRequestedEventAttributes _externalWorkflowExecutionCancelRequestedEventAttributes;
        private ExternalWorkflowExecutionSignaledEventAttributes _externalWorkflowExecutionSignaledEventAttributes;
        private FailWorkflowExecutionFailedEventAttributes _failWorkflowExecutionFailedEventAttributes;
        private LambdaFunctionCompletedEventAttributes _lambdaFunctionCompletedEventAttributes;
        private LambdaFunctionFailedEventAttributes _lambdaFunctionFailedEventAttributes;
        private LambdaFunctionScheduledEventAttributes _lambdaFunctionScheduledEventAttributes;
        private LambdaFunctionStartedEventAttributes _lambdaFunctionStartedEventAttributes;
        private LambdaFunctionTimedOutEventAttributes _lambdaFunctionTimedOutEventAttributes;
        private MarkerRecordedEventAttributes _markerRecordedEventAttributes;
        private RecordMarkerFailedEventAttributes _recordMarkerFailedEventAttributes;
        private RequestCancelActivityTaskFailedEventAttributes _requestCancelActivityTaskFailedEventAttributes;
        private RequestCancelExternalWorkflowExecutionFailedEventAttributes _requestCancelExternalWorkflowExecutionFailedEventAttributes;
        private RequestCancelExternalWorkflowExecutionInitiatedEventAttributes _requestCancelExternalWorkflowExecutionInitiatedEventAttributes;
        private ScheduleActivityTaskFailedEventAttributes _scheduleActivityTaskFailedEventAttributes;
        private ScheduleLambdaFunctionFailedEventAttributes _scheduleLambdaFunctionFailedEventAttributes;
        private SignalExternalWorkflowExecutionFailedEventAttributes _signalExternalWorkflowExecutionFailedEventAttributes;
        private SignalExternalWorkflowExecutionInitiatedEventAttributes _signalExternalWorkflowExecutionInitiatedEventAttributes;
        private StartChildWorkflowExecutionFailedEventAttributes _startChildWorkflowExecutionFailedEventAttributes;
        private StartChildWorkflowExecutionInitiatedEventAttributes _startChildWorkflowExecutionInitiatedEventAttributes;
        private StartLambdaFunctionFailedEventAttributes _startLambdaFunctionFailedEventAttributes;
        private StartTimerFailedEventAttributes _startTimerFailedEventAttributes;
        private TimerCanceledEventAttributes _timerCanceledEventAttributes;
        private TimerFiredEventAttributes _timerFiredEventAttributes;
        private TimerStartedEventAttributes _timerStartedEventAttributes;
        private WorkflowExecutionCanceledEventAttributes _workflowExecutionCanceledEventAttributes;
        private WorkflowExecutionCancelRequestedEventAttributes _workflowExecutionCancelRequestedEventAttributes;
        private WorkflowExecutionCompletedEventAttributes _workflowExecutionCompletedEventAttributes;
        private WorkflowExecutionContinuedAsNewEventAttributes _workflowExecutionContinuedAsNewEventAttributes;
        private WorkflowExecutionFailedEventAttributes _workflowExecutionFailedEventAttributes;
        private WorkflowExecutionSignaledEventAttributes _workflowExecutionSignaledEventAttributes;
        private WorkflowExecutionStartedEventAttributes _workflowExecutionStartedEventAttributes;
        private WorkflowExecutionTerminatedEventAttributes _workflowExecutionTerminatedEventAttributes;
        private WorkflowExecutionTimedOutEventAttributes _workflowExecutionTimedOutEventAttributes;

        /// <summary>
        /// Gets and sets the property ActivityTaskCanceledEventAttributes. 
        /// <para>
        /// If the event is of type <c>ActivityTaskCanceled</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ActivityTaskCanceledEventAttributes ActivityTaskCanceledEventAttributes
        {
            get { return this._activityTaskCanceledEventAttributes; }
            set { this._activityTaskCanceledEventAttributes = value; }
        }

        // Check to see if ActivityTaskCanceledEventAttributes property is set
        internal bool IsSetActivityTaskCanceledEventAttributes()
        {
            return this._activityTaskCanceledEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ActivityTaskCancelRequestedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ActivityTaskcancelRequested</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ActivityTaskCancelRequestedEventAttributes ActivityTaskCancelRequestedEventAttributes
        {
            get { return this._activityTaskCancelRequestedEventAttributes; }
            set { this._activityTaskCancelRequestedEventAttributes = value; }
        }

        // Check to see if ActivityTaskCancelRequestedEventAttributes property is set
        internal bool IsSetActivityTaskCancelRequestedEventAttributes()
        {
            return this._activityTaskCancelRequestedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ActivityTaskCompletedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ActivityTaskCompleted</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ActivityTaskCompletedEventAttributes ActivityTaskCompletedEventAttributes
        {
            get { return this._activityTaskCompletedEventAttributes; }
            set { this._activityTaskCompletedEventAttributes = value; }
        }

        // Check to see if ActivityTaskCompletedEventAttributes property is set
        internal bool IsSetActivityTaskCompletedEventAttributes()
        {
            return this._activityTaskCompletedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ActivityTaskFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ActivityTaskFailed</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ActivityTaskFailedEventAttributes ActivityTaskFailedEventAttributes
        {
            get { return this._activityTaskFailedEventAttributes; }
            set { this._activityTaskFailedEventAttributes = value; }
        }

        // Check to see if ActivityTaskFailedEventAttributes property is set
        internal bool IsSetActivityTaskFailedEventAttributes()
        {
            return this._activityTaskFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ActivityTaskScheduledEventAttributes. 
        /// <para>
        /// If the event is of type <c>ActivityTaskScheduled</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ActivityTaskScheduledEventAttributes ActivityTaskScheduledEventAttributes
        {
            get { return this._activityTaskScheduledEventAttributes; }
            set { this._activityTaskScheduledEventAttributes = value; }
        }

        // Check to see if ActivityTaskScheduledEventAttributes property is set
        internal bool IsSetActivityTaskScheduledEventAttributes()
        {
            return this._activityTaskScheduledEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ActivityTaskStartedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ActivityTaskStarted</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ActivityTaskStartedEventAttributes ActivityTaskStartedEventAttributes
        {
            get { return this._activityTaskStartedEventAttributes; }
            set { this._activityTaskStartedEventAttributes = value; }
        }

        // Check to see if ActivityTaskStartedEventAttributes property is set
        internal bool IsSetActivityTaskStartedEventAttributes()
        {
            return this._activityTaskStartedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ActivityTaskTimedOutEventAttributes. 
        /// <para>
        /// If the event is of type <c>ActivityTaskTimedOut</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ActivityTaskTimedOutEventAttributes ActivityTaskTimedOutEventAttributes
        {
            get { return this._activityTaskTimedOutEventAttributes; }
            set { this._activityTaskTimedOutEventAttributes = value; }
        }

        // Check to see if ActivityTaskTimedOutEventAttributes property is set
        internal bool IsSetActivityTaskTimedOutEventAttributes()
        {
            return this._activityTaskTimedOutEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property CancelTimerFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>CancelTimerFailed</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public CancelTimerFailedEventAttributes CancelTimerFailedEventAttributes
        {
            get { return this._cancelTimerFailedEventAttributes; }
            set { this._cancelTimerFailedEventAttributes = value; }
        }

        // Check to see if CancelTimerFailedEventAttributes property is set
        internal bool IsSetCancelTimerFailedEventAttributes()
        {
            return this._cancelTimerFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property CancelWorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>CancelWorkflowExecutionFailed</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public CancelWorkflowExecutionFailedEventAttributes CancelWorkflowExecutionFailedEventAttributes
        {
            get { return this._cancelWorkflowExecutionFailedEventAttributes; }
            set { this._cancelWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if CancelWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetCancelWorkflowExecutionFailedEventAttributes()
        {
            return this._cancelWorkflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ChildWorkflowExecutionCanceledEventAttributes. 
        /// <para>
        /// If the event is of type <c>ChildWorkflowExecutionCanceled</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public ChildWorkflowExecutionCanceledEventAttributes ChildWorkflowExecutionCanceledEventAttributes
        {
            get { return this._childWorkflowExecutionCanceledEventAttributes; }
            set { this._childWorkflowExecutionCanceledEventAttributes = value; }
        }

        // Check to see if ChildWorkflowExecutionCanceledEventAttributes property is set
        internal bool IsSetChildWorkflowExecutionCanceledEventAttributes()
        {
            return this._childWorkflowExecutionCanceledEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ChildWorkflowExecutionCompletedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ChildWorkflowExecutionCompleted</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public ChildWorkflowExecutionCompletedEventAttributes ChildWorkflowExecutionCompletedEventAttributes
        {
            get { return this._childWorkflowExecutionCompletedEventAttributes; }
            set { this._childWorkflowExecutionCompletedEventAttributes = value; }
        }

        // Check to see if ChildWorkflowExecutionCompletedEventAttributes property is set
        internal bool IsSetChildWorkflowExecutionCompletedEventAttributes()
        {
            return this._childWorkflowExecutionCompletedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ChildWorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ChildWorkflowExecutionFailed</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ChildWorkflowExecutionFailedEventAttributes ChildWorkflowExecutionFailedEventAttributes
        {
            get { return this._childWorkflowExecutionFailedEventAttributes; }
            set { this._childWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if ChildWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetChildWorkflowExecutionFailedEventAttributes()
        {
            return this._childWorkflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ChildWorkflowExecutionStartedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ChildWorkflowExecutionStarted</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ChildWorkflowExecutionStartedEventAttributes ChildWorkflowExecutionStartedEventAttributes
        {
            get { return this._childWorkflowExecutionStartedEventAttributes; }
            set { this._childWorkflowExecutionStartedEventAttributes = value; }
        }

        // Check to see if ChildWorkflowExecutionStartedEventAttributes property is set
        internal bool IsSetChildWorkflowExecutionStartedEventAttributes()
        {
            return this._childWorkflowExecutionStartedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ChildWorkflowExecutionTerminatedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ChildWorkflowExecutionTerminated</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public ChildWorkflowExecutionTerminatedEventAttributes ChildWorkflowExecutionTerminatedEventAttributes
        {
            get { return this._childWorkflowExecutionTerminatedEventAttributes; }
            set { this._childWorkflowExecutionTerminatedEventAttributes = value; }
        }

        // Check to see if ChildWorkflowExecutionTerminatedEventAttributes property is set
        internal bool IsSetChildWorkflowExecutionTerminatedEventAttributes()
        {
            return this._childWorkflowExecutionTerminatedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ChildWorkflowExecutionTimedOutEventAttributes. 
        /// <para>
        /// If the event is of type <c>ChildWorkflowExecutionTimedOut</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public ChildWorkflowExecutionTimedOutEventAttributes ChildWorkflowExecutionTimedOutEventAttributes
        {
            get { return this._childWorkflowExecutionTimedOutEventAttributes; }
            set { this._childWorkflowExecutionTimedOutEventAttributes = value; }
        }

        // Check to see if ChildWorkflowExecutionTimedOutEventAttributes property is set
        internal bool IsSetChildWorkflowExecutionTimedOutEventAttributes()
        {
            return this._childWorkflowExecutionTimedOutEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property CompleteWorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>CompleteWorkflowExecutionFailed</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public CompleteWorkflowExecutionFailedEventAttributes CompleteWorkflowExecutionFailedEventAttributes
        {
            get { return this._completeWorkflowExecutionFailedEventAttributes; }
            set { this._completeWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if CompleteWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetCompleteWorkflowExecutionFailedEventAttributes()
        {
            return this._completeWorkflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ContinueAsNewWorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ContinueAsNewWorkflowExecutionFailed</c> then this member
        /// is set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public ContinueAsNewWorkflowExecutionFailedEventAttributes ContinueAsNewWorkflowExecutionFailedEventAttributes
        {
            get { return this._continueAsNewWorkflowExecutionFailedEventAttributes; }
            set { this._continueAsNewWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if ContinueAsNewWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetContinueAsNewWorkflowExecutionFailedEventAttributes()
        {
            return this._continueAsNewWorkflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property DecisionTaskCompletedEventAttributes. 
        /// <para>
        /// If the event is of type <c>DecisionTaskCompleted</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public DecisionTaskCompletedEventAttributes DecisionTaskCompletedEventAttributes
        {
            get { return this._decisionTaskCompletedEventAttributes; }
            set { this._decisionTaskCompletedEventAttributes = value; }
        }

        // Check to see if DecisionTaskCompletedEventAttributes property is set
        internal bool IsSetDecisionTaskCompletedEventAttributes()
        {
            return this._decisionTaskCompletedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property DecisionTaskScheduledEventAttributes. 
        /// <para>
        /// If the event is of type <c>DecisionTaskScheduled</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public DecisionTaskScheduledEventAttributes DecisionTaskScheduledEventAttributes
        {
            get { return this._decisionTaskScheduledEventAttributes; }
            set { this._decisionTaskScheduledEventAttributes = value; }
        }

        // Check to see if DecisionTaskScheduledEventAttributes property is set
        internal bool IsSetDecisionTaskScheduledEventAttributes()
        {
            return this._decisionTaskScheduledEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property DecisionTaskStartedEventAttributes. 
        /// <para>
        /// If the event is of type <c>DecisionTaskStarted</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public DecisionTaskStartedEventAttributes DecisionTaskStartedEventAttributes
        {
            get { return this._decisionTaskStartedEventAttributes; }
            set { this._decisionTaskStartedEventAttributes = value; }
        }

        // Check to see if DecisionTaskStartedEventAttributes property is set
        internal bool IsSetDecisionTaskStartedEventAttributes()
        {
            return this._decisionTaskStartedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property DecisionTaskTimedOutEventAttributes. 
        /// <para>
        /// If the event is of type <c>DecisionTaskTimedOut</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public DecisionTaskTimedOutEventAttributes DecisionTaskTimedOutEventAttributes
        {
            get { return this._decisionTaskTimedOutEventAttributes; }
            set { this._decisionTaskTimedOutEventAttributes = value; }
        }

        // Check to see if DecisionTaskTimedOutEventAttributes property is set
        internal bool IsSetDecisionTaskTimedOutEventAttributes()
        {
            return this._decisionTaskTimedOutEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The system generated ID of the event. This ID uniquely identifies the event with in
        /// the workflow execution history.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventTimestamp. 
        /// <para>
        /// The date and time when the event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EventTimestamp
        {
            get { return this._eventTimestamp; }
            set { this._eventTimestamp = value; }
        }

        // Check to see if EventTimestamp property is set
        internal bool IsSetEventTimestamp()
        {
            return this._eventTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of the history event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventType EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalWorkflowExecutionCancelRequestedEventAttributes.
        /// 
        /// <para>
        /// If the event is of type <c>ExternalWorkflowExecutionCancelRequested</c> then this
        /// member is set and provides detailed information about the event. It isn't set for
        /// other event types. 
        /// </para>
        /// </summary>
        public ExternalWorkflowExecutionCancelRequestedEventAttributes ExternalWorkflowExecutionCancelRequestedEventAttributes
        {
            get { return this._externalWorkflowExecutionCancelRequestedEventAttributes; }
            set { this._externalWorkflowExecutionCancelRequestedEventAttributes = value; }
        }

        // Check to see if ExternalWorkflowExecutionCancelRequestedEventAttributes property is set
        internal bool IsSetExternalWorkflowExecutionCancelRequestedEventAttributes()
        {
            return this._externalWorkflowExecutionCancelRequestedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalWorkflowExecutionSignaledEventAttributes. 
        /// <para>
        /// If the event is of type <c>ExternalWorkflowExecutionSignaled</c> then this member
        /// is set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public ExternalWorkflowExecutionSignaledEventAttributes ExternalWorkflowExecutionSignaledEventAttributes
        {
            get { return this._externalWorkflowExecutionSignaledEventAttributes; }
            set { this._externalWorkflowExecutionSignaledEventAttributes = value; }
        }

        // Check to see if ExternalWorkflowExecutionSignaledEventAttributes property is set
        internal bool IsSetExternalWorkflowExecutionSignaledEventAttributes()
        {
            return this._externalWorkflowExecutionSignaledEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property FailWorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>FailWorkflowExecutionFailed</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public FailWorkflowExecutionFailedEventAttributes FailWorkflowExecutionFailedEventAttributes
        {
            get { return this._failWorkflowExecutionFailedEventAttributes; }
            set { this._failWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if FailWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetFailWorkflowExecutionFailedEventAttributes()
        {
            return this._failWorkflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionCompletedEventAttributes. 
        /// <para>
        /// Provides the details of the <c>LambdaFunctionCompleted</c> event. It isn't set for
        /// other event types.
        /// </para>
        /// </summary>
        public LambdaFunctionCompletedEventAttributes LambdaFunctionCompletedEventAttributes
        {
            get { return this._lambdaFunctionCompletedEventAttributes; }
            set { this._lambdaFunctionCompletedEventAttributes = value; }
        }

        // Check to see if LambdaFunctionCompletedEventAttributes property is set
        internal bool IsSetLambdaFunctionCompletedEventAttributes()
        {
            return this._lambdaFunctionCompletedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionFailedEventAttributes. 
        /// <para>
        /// Provides the details of the <c>LambdaFunctionFailed</c> event. It isn't set for other
        /// event types.
        /// </para>
        /// </summary>
        public LambdaFunctionFailedEventAttributes LambdaFunctionFailedEventAttributes
        {
            get { return this._lambdaFunctionFailedEventAttributes; }
            set { this._lambdaFunctionFailedEventAttributes = value; }
        }

        // Check to see if LambdaFunctionFailedEventAttributes property is set
        internal bool IsSetLambdaFunctionFailedEventAttributes()
        {
            return this._lambdaFunctionFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionScheduledEventAttributes. 
        /// <para>
        /// Provides the details of the <c>LambdaFunctionScheduled</c> event. It isn't set for
        /// other event types.
        /// </para>
        /// </summary>
        public LambdaFunctionScheduledEventAttributes LambdaFunctionScheduledEventAttributes
        {
            get { return this._lambdaFunctionScheduledEventAttributes; }
            set { this._lambdaFunctionScheduledEventAttributes = value; }
        }

        // Check to see if LambdaFunctionScheduledEventAttributes property is set
        internal bool IsSetLambdaFunctionScheduledEventAttributes()
        {
            return this._lambdaFunctionScheduledEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionStartedEventAttributes. 
        /// <para>
        /// Provides the details of the <c>LambdaFunctionStarted</c> event. It isn't set for other
        /// event types.
        /// </para>
        /// </summary>
        public LambdaFunctionStartedEventAttributes LambdaFunctionStartedEventAttributes
        {
            get { return this._lambdaFunctionStartedEventAttributes; }
            set { this._lambdaFunctionStartedEventAttributes = value; }
        }

        // Check to see if LambdaFunctionStartedEventAttributes property is set
        internal bool IsSetLambdaFunctionStartedEventAttributes()
        {
            return this._lambdaFunctionStartedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionTimedOutEventAttributes. 
        /// <para>
        /// Provides the details of the <c>LambdaFunctionTimedOut</c> event. It isn't set for
        /// other event types.
        /// </para>
        /// </summary>
        public LambdaFunctionTimedOutEventAttributes LambdaFunctionTimedOutEventAttributes
        {
            get { return this._lambdaFunctionTimedOutEventAttributes; }
            set { this._lambdaFunctionTimedOutEventAttributes = value; }
        }

        // Check to see if LambdaFunctionTimedOutEventAttributes property is set
        internal bool IsSetLambdaFunctionTimedOutEventAttributes()
        {
            return this._lambdaFunctionTimedOutEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property MarkerRecordedEventAttributes. 
        /// <para>
        /// If the event is of type <c>MarkerRecorded</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public MarkerRecordedEventAttributes MarkerRecordedEventAttributes
        {
            get { return this._markerRecordedEventAttributes; }
            set { this._markerRecordedEventAttributes = value; }
        }

        // Check to see if MarkerRecordedEventAttributes property is set
        internal bool IsSetMarkerRecordedEventAttributes()
        {
            return this._markerRecordedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property RecordMarkerFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>DecisionTaskFailed</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public RecordMarkerFailedEventAttributes RecordMarkerFailedEventAttributes
        {
            get { return this._recordMarkerFailedEventAttributes; }
            set { this._recordMarkerFailedEventAttributes = value; }
        }

        // Check to see if RecordMarkerFailedEventAttributes property is set
        internal bool IsSetRecordMarkerFailedEventAttributes()
        {
            return this._recordMarkerFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCancelActivityTaskFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>RequestCancelActivityTaskFailed</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public RequestCancelActivityTaskFailedEventAttributes RequestCancelActivityTaskFailedEventAttributes
        {
            get { return this._requestCancelActivityTaskFailedEventAttributes; }
            set { this._requestCancelActivityTaskFailedEventAttributes = value; }
        }

        // Check to see if RequestCancelActivityTaskFailedEventAttributes property is set
        internal bool IsSetRequestCancelActivityTaskFailedEventAttributes()
        {
            return this._requestCancelActivityTaskFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCancelExternalWorkflowExecutionFailedEventAttributes.
        /// 
        /// <para>
        /// If the event is of type <c>RequestCancelExternalWorkflowExecutionFailed</c> then this
        /// member is set and provides detailed information about the event. It isn't set for
        /// other event types.
        /// </para>
        /// </summary>
        public RequestCancelExternalWorkflowExecutionFailedEventAttributes RequestCancelExternalWorkflowExecutionFailedEventAttributes
        {
            get { return this._requestCancelExternalWorkflowExecutionFailedEventAttributes; }
            set { this._requestCancelExternalWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if RequestCancelExternalWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetRequestCancelExternalWorkflowExecutionFailedEventAttributes()
        {
            return this._requestCancelExternalWorkflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCancelExternalWorkflowExecutionInitiatedEventAttributes.
        /// 
        /// <para>
        /// If the event is of type <c>RequestCancelExternalWorkflowExecutionInitiated</c> then
        /// this member is set and provides detailed information about the event. It isn't set
        /// for other event types.
        /// </para>
        /// </summary>
        public RequestCancelExternalWorkflowExecutionInitiatedEventAttributes RequestCancelExternalWorkflowExecutionInitiatedEventAttributes
        {
            get { return this._requestCancelExternalWorkflowExecutionInitiatedEventAttributes; }
            set { this._requestCancelExternalWorkflowExecutionInitiatedEventAttributes = value; }
        }

        // Check to see if RequestCancelExternalWorkflowExecutionInitiatedEventAttributes property is set
        internal bool IsSetRequestCancelExternalWorkflowExecutionInitiatedEventAttributes()
        {
            return this._requestCancelExternalWorkflowExecutionInitiatedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleActivityTaskFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ScheduleActivityTaskFailed</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ScheduleActivityTaskFailedEventAttributes ScheduleActivityTaskFailedEventAttributes
        {
            get { return this._scheduleActivityTaskFailedEventAttributes; }
            set { this._scheduleActivityTaskFailedEventAttributes = value; }
        }

        // Check to see if ScheduleActivityTaskFailedEventAttributes property is set
        internal bool IsSetScheduleActivityTaskFailedEventAttributes()
        {
            return this._scheduleActivityTaskFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleLambdaFunctionFailedEventAttributes. 
        /// <para>
        /// Provides the details of the <c>ScheduleLambdaFunctionFailed</c> event. It isn't set
        /// for other event types.
        /// </para>
        /// </summary>
        public ScheduleLambdaFunctionFailedEventAttributes ScheduleLambdaFunctionFailedEventAttributes
        {
            get { return this._scheduleLambdaFunctionFailedEventAttributes; }
            set { this._scheduleLambdaFunctionFailedEventAttributes = value; }
        }

        // Check to see if ScheduleLambdaFunctionFailedEventAttributes property is set
        internal bool IsSetScheduleLambdaFunctionFailedEventAttributes()
        {
            return this._scheduleLambdaFunctionFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property SignalExternalWorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>SignalExternalWorkflowExecutionFailed</c> then this member
        /// is set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public SignalExternalWorkflowExecutionFailedEventAttributes SignalExternalWorkflowExecutionFailedEventAttributes
        {
            get { return this._signalExternalWorkflowExecutionFailedEventAttributes; }
            set { this._signalExternalWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if SignalExternalWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetSignalExternalWorkflowExecutionFailedEventAttributes()
        {
            return this._signalExternalWorkflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property SignalExternalWorkflowExecutionInitiatedEventAttributes.
        /// 
        /// <para>
        /// If the event is of type <c>SignalExternalWorkflowExecutionInitiated</c> then this
        /// member is set and provides detailed information about the event. It isn't set for
        /// other event types.
        /// </para>
        /// </summary>
        public SignalExternalWorkflowExecutionInitiatedEventAttributes SignalExternalWorkflowExecutionInitiatedEventAttributes
        {
            get { return this._signalExternalWorkflowExecutionInitiatedEventAttributes; }
            set { this._signalExternalWorkflowExecutionInitiatedEventAttributes = value; }
        }

        // Check to see if SignalExternalWorkflowExecutionInitiatedEventAttributes property is set
        internal bool IsSetSignalExternalWorkflowExecutionInitiatedEventAttributes()
        {
            return this._signalExternalWorkflowExecutionInitiatedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property StartChildWorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>StartChildWorkflowExecutionFailed</c> then this member
        /// is set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public StartChildWorkflowExecutionFailedEventAttributes StartChildWorkflowExecutionFailedEventAttributes
        {
            get { return this._startChildWorkflowExecutionFailedEventAttributes; }
            set { this._startChildWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if StartChildWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetStartChildWorkflowExecutionFailedEventAttributes()
        {
            return this._startChildWorkflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property StartChildWorkflowExecutionInitiatedEventAttributes. 
        /// <para>
        /// If the event is of type <c>StartChildWorkflowExecutionInitiated</c> then this member
        /// is set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public StartChildWorkflowExecutionInitiatedEventAttributes StartChildWorkflowExecutionInitiatedEventAttributes
        {
            get { return this._startChildWorkflowExecutionInitiatedEventAttributes; }
            set { this._startChildWorkflowExecutionInitiatedEventAttributes = value; }
        }

        // Check to see if StartChildWorkflowExecutionInitiatedEventAttributes property is set
        internal bool IsSetStartChildWorkflowExecutionInitiatedEventAttributes()
        {
            return this._startChildWorkflowExecutionInitiatedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property StartLambdaFunctionFailedEventAttributes. 
        /// <para>
        /// Provides the details of the <c>StartLambdaFunctionFailed</c> event. It isn't set for
        /// other event types.
        /// </para>
        /// </summary>
        public StartLambdaFunctionFailedEventAttributes StartLambdaFunctionFailedEventAttributes
        {
            get { return this._startLambdaFunctionFailedEventAttributes; }
            set { this._startLambdaFunctionFailedEventAttributes = value; }
        }

        // Check to see if StartLambdaFunctionFailedEventAttributes property is set
        internal bool IsSetStartLambdaFunctionFailedEventAttributes()
        {
            return this._startLambdaFunctionFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimerFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>StartTimerFailed</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public StartTimerFailedEventAttributes StartTimerFailedEventAttributes
        {
            get { return this._startTimerFailedEventAttributes; }
            set { this._startTimerFailedEventAttributes = value; }
        }

        // Check to see if StartTimerFailedEventAttributes property is set
        internal bool IsSetStartTimerFailedEventAttributes()
        {
            return this._startTimerFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property TimerCanceledEventAttributes. 
        /// <para>
        /// If the event is of type <c>TimerCanceled</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public TimerCanceledEventAttributes TimerCanceledEventAttributes
        {
            get { return this._timerCanceledEventAttributes; }
            set { this._timerCanceledEventAttributes = value; }
        }

        // Check to see if TimerCanceledEventAttributes property is set
        internal bool IsSetTimerCanceledEventAttributes()
        {
            return this._timerCanceledEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property TimerFiredEventAttributes. 
        /// <para>
        /// If the event is of type <c>TimerFired</c> then this member is set and provides detailed
        /// information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public TimerFiredEventAttributes TimerFiredEventAttributes
        {
            get { return this._timerFiredEventAttributes; }
            set { this._timerFiredEventAttributes = value; }
        }

        // Check to see if TimerFiredEventAttributes property is set
        internal bool IsSetTimerFiredEventAttributes()
        {
            return this._timerFiredEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property TimerStartedEventAttributes. 
        /// <para>
        /// If the event is of type <c>TimerStarted</c> then this member is set and provides detailed
        /// information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public TimerStartedEventAttributes TimerStartedEventAttributes
        {
            get { return this._timerStartedEventAttributes; }
            set { this._timerStartedEventAttributes = value; }
        }

        // Check to see if TimerStartedEventAttributes property is set
        internal bool IsSetTimerStartedEventAttributes()
        {
            return this._timerStartedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecutionCanceledEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionCanceled</c> then this member is set and
        /// provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public WorkflowExecutionCanceledEventAttributes WorkflowExecutionCanceledEventAttributes
        {
            get { return this._workflowExecutionCanceledEventAttributes; }
            set { this._workflowExecutionCanceledEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionCanceledEventAttributes property is set
        internal bool IsSetWorkflowExecutionCanceledEventAttributes()
        {
            return this._workflowExecutionCanceledEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecutionCancelRequestedEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionCancelRequested</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public WorkflowExecutionCancelRequestedEventAttributes WorkflowExecutionCancelRequestedEventAttributes
        {
            get { return this._workflowExecutionCancelRequestedEventAttributes; }
            set { this._workflowExecutionCancelRequestedEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionCancelRequestedEventAttributes property is set
        internal bool IsSetWorkflowExecutionCancelRequestedEventAttributes()
        {
            return this._workflowExecutionCancelRequestedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecutionCompletedEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionCompleted</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public WorkflowExecutionCompletedEventAttributes WorkflowExecutionCompletedEventAttributes
        {
            get { return this._workflowExecutionCompletedEventAttributes; }
            set { this._workflowExecutionCompletedEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionCompletedEventAttributes property is set
        internal bool IsSetWorkflowExecutionCompletedEventAttributes()
        {
            return this._workflowExecutionCompletedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecutionContinuedAsNewEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionContinuedAsNew</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public WorkflowExecutionContinuedAsNewEventAttributes WorkflowExecutionContinuedAsNewEventAttributes
        {
            get { return this._workflowExecutionContinuedAsNewEventAttributes; }
            set { this._workflowExecutionContinuedAsNewEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionContinuedAsNewEventAttributes property is set
        internal bool IsSetWorkflowExecutionContinuedAsNewEventAttributes()
        {
            return this._workflowExecutionContinuedAsNewEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionFailed</c> then this member is set and
        /// provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public WorkflowExecutionFailedEventAttributes WorkflowExecutionFailedEventAttributes
        {
            get { return this._workflowExecutionFailedEventAttributes; }
            set { this._workflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetWorkflowExecutionFailedEventAttributes()
        {
            return this._workflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecutionSignaledEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionSignaled</c> then this member is set and
        /// provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public WorkflowExecutionSignaledEventAttributes WorkflowExecutionSignaledEventAttributes
        {
            get { return this._workflowExecutionSignaledEventAttributes; }
            set { this._workflowExecutionSignaledEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionSignaledEventAttributes property is set
        internal bool IsSetWorkflowExecutionSignaledEventAttributes()
        {
            return this._workflowExecutionSignaledEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecutionStartedEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionStarted</c> then this member is set and
        /// provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public WorkflowExecutionStartedEventAttributes WorkflowExecutionStartedEventAttributes
        {
            get { return this._workflowExecutionStartedEventAttributes; }
            set { this._workflowExecutionStartedEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionStartedEventAttributes property is set
        internal bool IsSetWorkflowExecutionStartedEventAttributes()
        {
            return this._workflowExecutionStartedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecutionTerminatedEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionTerminated</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public WorkflowExecutionTerminatedEventAttributes WorkflowExecutionTerminatedEventAttributes
        {
            get { return this._workflowExecutionTerminatedEventAttributes; }
            set { this._workflowExecutionTerminatedEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionTerminatedEventAttributes property is set
        internal bool IsSetWorkflowExecutionTerminatedEventAttributes()
        {
            return this._workflowExecutionTerminatedEventAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecutionTimedOutEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionTimedOut</c> then this member is set and
        /// provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public WorkflowExecutionTimedOutEventAttributes WorkflowExecutionTimedOutEventAttributes
        {
            get { return this._workflowExecutionTimedOutEventAttributes; }
            set { this._workflowExecutionTimedOutEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionTimedOutEventAttributes property is set
        internal bool IsSetWorkflowExecutionTimedOutEventAttributes()
        {
            return this._workflowExecutionTimedOutEventAttributes != null;
        }

    }
}