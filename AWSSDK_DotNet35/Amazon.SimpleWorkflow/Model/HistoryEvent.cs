/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Event within a workflow execution. A history event can be one of these types: 
    /// 
    ///  <ul> <li> <b>WorkflowExecutionStarted</b>: The workflow execution was started. </li>
    /// <li> <b>WorkflowExecutionCompleted</b>: The workflow execution was closed due to successful
    /// completion. </li> <li> <b>WorkflowExecutionFailed</b>: The workflow execution closed
    /// due to a failure. </li> <li> <b>WorkflowExecutionTimedOut</b>: The workflow execution
    /// was closed because a time out was exceeded. </li> <li> <b>WorkflowExecutionCanceled</b>:
    /// The workflow execution was successfully canceled and closed. </li> <li> <b>WorkflowExecutionTerminated</b>:
    /// The workflow execution was terminated. </li> <li> <b>WorkflowExecutionContinuedAsNew</b>:
    /// The workflow execution was closed and a new execution of the same type was created
    /// with the same workflowId. </li> <li> <b>WorkflowExecutionCancelRequested</b>: A request
    /// to cancel this workflow execution was made. </li> <li> <b>DecisionTaskScheduled</b>:
    /// A decision task was scheduled for the workflow execution. </li> <li> <b>DecisionTaskStarted</b>:
    /// The decision task was dispatched to a decider. </li> <li> <b>DecisionTaskCompleted</b>:
    /// The decider successfully completed a decision task by calling <a>RespondDecisionTaskCompleted</a>.
    /// </li> <li> <b>DecisionTaskTimedOut</b>: The decision task timed out. </li> <li> <b>ActivityTaskScheduled</b>:
    /// An activity task was scheduled for execution. </li> <li> <b>ScheduleActivityTaskFailed</b>:
    /// Failed to process ScheduleActivityTask decision. This happens when the decision is
    /// not configured properly, for example the activity type specified is not registered.
    /// </li> <li> <b>ActivityTaskStarted</b>: The scheduled activity task was dispatched
    /// to a worker. </li> <li> <b>ActivityTaskCompleted</b>: An activity worker successfully
    /// completed an activity task by calling <a>RespondActivityTaskCompleted</a>. </li> <li>
    /// <b>ActivityTaskFailed</b>: An activity worker failed an activity task by calling <a>RespondActivityTaskFailed</a>.
    /// </li> <li> <b>ActivityTaskTimedOut</b>: The activity task timed out. </li> <li> <b>ActivityTaskCanceled</b>:
    /// The activity task was successfully canceled. </li> <li> <b>ActivityTaskCancelRequested</b>:
    /// A <code>RequestCancelActivityTask</code> decision was received by the system. </li>
    /// <li> <b>RequestCancelActivityTaskFailed</b>: Failed to process RequestCancelActivityTask
    /// decision. This happens when the decision is not configured properly. </li> <li> <b>WorkflowExecutionSignaled</b>:
    /// An external signal was received for the workflow execution. </li> <li> <b>MarkerRecorded</b>:
    /// A marker was recorded in the workflow history as the result of a <code>RecordMarker</code>
    /// decision. </li> <li> <b>TimerStarted</b>: A timer was started for the workflow execution
    /// due to a <code>StartTimer</code> decision. </li> <li> <b>StartTimerFailed</b>: Failed
    /// to process StartTimer decision. This happens when the decision is not configured properly,
    /// for example a timer already exists with the specified timer Id. </li> <li> <b>TimerFired</b>:
    /// A timer, previously started for this workflow execution, fired. </li> <li> <b>TimerCanceled</b>:
    /// A timer, previously started for this workflow execution, was successfully canceled.
    /// </li> <li> <b>CancelTimerFailed</b>: Failed to process CancelTimer decision. This
    /// happens when the decision is not configured properly, for example no timer exists
    /// with the specified timer Id. </li> <li> <b>StartChildWorkflowExecutionInitiated</b>:
    /// A request was made to start a child workflow execution. </li> <li> <b>StartChildWorkflowExecutionFailed</b>:
    /// Failed to process StartChildWorkflowExecution decision. This happens when the decision
    /// is not configured properly, for example the workflow type specified is not registered.
    /// </li> <li> <b>ChildWorkflowExecutionStarted</b>: A child workflow execution was successfully
    /// started. </li> <li> <b>ChildWorkflowExecutionCompleted</b>: A child workflow execution,
    /// started by this workflow execution, completed successfully and was closed. </li> <li>
    /// <b>ChildWorkflowExecutionFailed</b>: A child workflow execution, started by this workflow
    /// execution, failed to complete successfully and was closed. </li> <li> <b>ChildWorkflowExecutionTimedOut</b>:
    /// A child workflow execution, started by this workflow execution, timed out and was
    /// closed. </li> <li> <b>ChildWorkflowExecutionCanceled</b>: A child workflow execution,
    /// started by this workflow execution, was canceled and closed. </li> <li> <b>ChildWorkflowExecutionTerminated</b>:
    /// A child workflow execution, started by this workflow execution, was terminated. </li>
    /// <li> <b>SignalExternalWorkflowExecutionInitiated</b>: A request to signal an external
    /// workflow was made. </li> <li> <b>ExternalWorkflowExecutionSignaled</b>: A signal,
    /// requested by this workflow execution, was successfully delivered to the target external
    /// workflow execution. </li> <li> <b>SignalExternalWorkflowExecutionFailed</b>: The request
    /// to signal an external workflow execution failed. </li> <li> <b>RequestCancelExternalWorkflowExecutionInitiated</b>:
    /// A request was made to request the cancellation of an external workflow execution.
    /// </li> <li> <b>ExternalWorkflowExecutionCancelRequested</b>: Request to cancel an external
    /// workflow execution was successfully delivered to the target execution. </li> <li>
    /// <b>RequestCancelExternalWorkflowExecutionFailed</b>: Request to cancel an external
    /// workflow execution failed. </li> </ul>
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
        private MarkerRecordedEventAttributes _markerRecordedEventAttributes;
        private RecordMarkerFailedEventAttributes _recordMarkerFailedEventAttributes;
        private RequestCancelActivityTaskFailedEventAttributes _requestCancelActivityTaskFailedEventAttributes;
        private RequestCancelExternalWorkflowExecutionFailedEventAttributes _requestCancelExternalWorkflowExecutionFailedEventAttributes;
        private RequestCancelExternalWorkflowExecutionInitiatedEventAttributes _requestCancelExternalWorkflowExecutionInitiatedEventAttributes;
        private ScheduleActivityTaskFailedEventAttributes _scheduleActivityTaskFailedEventAttributes;
        private SignalExternalWorkflowExecutionFailedEventAttributes _signalExternalWorkflowExecutionFailedEventAttributes;
        private SignalExternalWorkflowExecutionInitiatedEventAttributes _signalExternalWorkflowExecutionInitiatedEventAttributes;
        private StartChildWorkflowExecutionFailedEventAttributes _startChildWorkflowExecutionFailedEventAttributes;
        private StartChildWorkflowExecutionInitiatedEventAttributes _startChildWorkflowExecutionInitiatedEventAttributes;
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
        ///  If the event is of type <code>ActivityTaskCanceled</code> then this member is set
        /// and provides detailed information about the event. It is not set for other event types.
        /// 
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
        ///  If the event is of type <code>ActivityTaskcancelRequested</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        ///  If the event is of type <code>ActivityTaskCompleted</code> then this member is set
        /// and provides detailed information about the event. It is not set for other event types.
        /// 
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
        ///  If the event is of type <code>ActivityTaskFailed</code> then this member is set and
        /// provides detailed information about the event. It is not set for other event types.
        /// 
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
        ///  If the event is of type <code>ActivityTaskScheduled</code> then this member is set
        /// and provides detailed information about the event. It is not set for other event types.
        /// 
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
        ///  If the event is of type <code>ActivityTaskStarted</code> then this member is set
        /// and provides detailed information about the event. It is not set for other event types.
        /// 
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
        ///  If the event is of type <code>ActivityTaskTimedOut</code> then this member is set
        /// and provides detailed information about the event. It is not set for other event types.
        /// 
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
        ///  If the event is of type <code>CancelTimerFailed</code> then this member is set and
        /// provides detailed information about the event. It is not set for other event types.
        /// 
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
        ///  If the event is of type <code>CancelWorkflowExecutionFailed</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        ///  If the event is of type <code>ChildWorkflowExecutionCanceled</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        ///  If the event is of type <code>ChildWorkflowExecutionCompleted</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        ///  If the event is of type <code>ChildWorkflowExecutionFailed</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        ///  If the event is of type <code>ChildWorkflowExecutionStarted</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        ///  If the event is of type <code>ChildWorkflowExecutionTerminated</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        ///  If the event is of type <code>ChildWorkflowExecutionTimedOut</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        ///  If the event is of type <code>CompleteWorkflowExecutionFailed</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        ///  If the event is of type <code>ContinueAsNewWorkflowExecutionFailed</code> then this
        /// member is set and provides detailed information about the event. It is not set for
        /// other event types. 
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
        ///  If the event is of type <code>DecisionTaskCompleted</code> then this member is set
        /// and provides detailed information about the event. It is not set for other event types.
        /// 
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
        ///  If the event is of type <code>DecisionTaskScheduled</code> then this member is set
        /// and provides detailed information about the event. It is not set for other event types.
        /// 
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
        ///  If the event is of type <code>DecisionTaskStarted</code> then this member is set
        /// and provides detailed information about the event. It is not set for other event types.
        /// 
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
        ///  If the event is of type <code>DecisionTaskTimedOut</code> then this member is set
        /// and provides detailed information about the event. It is not set for other event types.
        /// 
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
        ///  The system generated id of the event. This id uniquely identifies the event with
        /// in the workflow execution history. 
        /// </para>
        /// </summary>
        public long EventId
        {
            get { return this._eventId.GetValueOrDefault(); }
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
        ///  The date and time when the event occurred. 
        /// </para>
        /// </summary>
        public DateTime EventTimestamp
        {
            get { return this._eventTimestamp.GetValueOrDefault(); }
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
        ///  The type of the history event. 
        /// </para>
        /// </summary>
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
        ///  If the event is of type <code>ExternalWorkflowExecutionCancelRequested</code> then
        /// this member is set and provides detailed information about the event. It is not set
        /// for other event types. 
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
        ///  If the event is of type <code>ExternalWorkflowExecutionSignaled</code> then this
        /// member is set and provides detailed information about the event. It is not set for
        /// other event types. 
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
        ///  If the event is of type <code>FailWorkflowExecutionFailed</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        /// Gets and sets the property MarkerRecordedEventAttributes. 
        /// <para>
        ///  If the event is of type <code>MarkerRecorded</code> then this member is set and provides
        /// detailed information about the event. It is not set for other event types. 
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
        ///  If the event is of type <code>DecisionTaskFailed</code> then this member is set and
        /// provides detailed information about the event. It is not set for other event types.
        /// 
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
        ///  If the event is of type <code>RequestCancelActivityTaskFailed</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        ///  If the event is of type <code>RequestCancelExternalWorkflowExecutionFailed</code>
        /// then this member is set and provides detailed information about the event. It is not
        /// set for other event types. 
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
        ///  If the event is of type <code>RequestCancelExternalWorkflowExecutionInitiated</code>
        /// then this member is set and provides detailed information about the event. It is not
        /// set for other event types. 
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
        ///  If the event is of type <code>ScheduleActivityTaskFailed</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        /// Gets and sets the property SignalExternalWorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <code>SignalExternalWorkflowExecutionFailed</code> then this
        /// member is set and provides detailed information about the event. It is not set for
        /// other event types.
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
        ///  If the event is of type <code>SignalExternalWorkflowExecutionInitiated</code> then
        /// this member is set and provides detailed information about the event. It is not set
        /// for other event types. 
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
        ///  If the event is of type <code>StartChildWorkflowExecutionFailed</code> then this
        /// member is set and provides detailed information about the event. It is not set for
        /// other event types. 
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
        ///  If the event is of type <code>StartChildWorkflowExecutionInitiated</code> then this
        /// member is set and provides detailed information about the event. It is not set for
        /// other event types. 
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
        /// Gets and sets the property StartTimerFailedEventAttributes. 
        /// <para>
        ///  If the event is of type <code>StartTimerFailed</code> then this member is set and
        /// provides detailed information about the event. It is not set for other event types.
        /// 
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
        ///  If the event is of type <code>TimerCanceled</code> then this member is set and provides
        /// detailed information about the event. It is not set for other event types. 
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
        ///  If the event is of type <code>TimerFired</code> then this member is set and provides
        /// detailed information about the event. It is not set for other event types. 
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
        ///  If the event is of type <code>TimerStarted</code> then this member is set and provides
        /// detailed information about the event. It is not set for other event types. 
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
        ///  If the event is of type <code>WorkflowExecutionCanceled</code> then this member is
        /// set and provides detailed information about the event. It is not set for other event
        /// types. 
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
        ///  If the event is of type <code>WorkflowExecutionCancelRequested</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        ///  If the event is of type <code>WorkflowExecutionCompleted</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        ///  If the event is of type <code>WorkflowExecutionContinuedAsNew</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        ///  If the event is of type <code>WorkflowExecutionFailed</code> then this member is
        /// set and provides detailed information about the event. It is not set for other event
        /// types. 
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
        ///  If the event is of type <code>WorkflowExecutionSignaled</code> then this member is
        /// set and provides detailed information about the event. It is not set for other event
        /// types. 
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
        ///  If the event is of type <code>WorkflowExecutionStarted</code> then this member is
        /// set and provides detailed information about the event. It is not set for other event
        /// types. 
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
        ///  If the event is of type <code>WorkflowExecutionTerminated</code> then this member
        /// is set and provides detailed information about the event. It is not set for other
        /// event types. 
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
        ///  If the event is of type <code>WorkflowExecutionTimedOut</code> then this member is
        /// set and provides detailed information about the event. It is not set for other event
        /// types. 
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