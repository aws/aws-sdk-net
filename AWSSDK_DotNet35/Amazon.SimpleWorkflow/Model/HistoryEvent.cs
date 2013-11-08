/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Event within a workflow execution. A history event can be one of these types: </para>
    /// <ul>
    /// <li> <b>WorkflowExecutionStarted</b> : The workflow execution was started. </li>
    /// <li> <b>WorkflowExecutionCompleted</b> : The workflow execution was closed due to successful completion. </li>
    /// <li> <b>WorkflowExecutionFailed</b> : The workflow execution closed due to a failure. </li>
    /// <li> <b>WorkflowExecutionTimedOut</b> : The workflow execution was closed because a time out was exceeded. </li>
    /// <li> <b>WorkflowExecutionCanceled</b> : The workflow execution was successfully canceled and closed. </li>
    /// <li> <b>WorkflowExecutionTerminated</b> : The workflow execution was terminated. </li>
    /// <li> <b>WorkflowExecutionContinuedAsNew</b> : The workflow execution was closed and a new execution of the same type was created with the
    /// same workflowId. </li>
    /// <li> <b>WorkflowExecutionCancelRequested</b> : A request to cancel this workflow execution was made. </li>
    /// <li> <b>DecisionTaskScheduled</b> : A decision task was scheduled for the workflow execution. </li>
    /// <li> <b>DecisionTaskStarted</b> : The decision task was dispatched to a decider. </li>
    /// <li> <b>DecisionTaskCompleted</b> : The decider successfully completed a decision task by calling RespondDecisionTaskCompleted. </li>
    /// <li> <b>DecisionTaskTimedOut</b> : The decision task timed out. </li>
    /// <li> <b>ActivityTaskScheduled</b> : An activity task was scheduled for execution. </li>
    /// <li> <b>ScheduleActivityTaskFailed</b> : Failed to process ScheduleActivityTask decision. This happens when the decision is not configured
    /// properly, for example the activity type specified is not registered. </li>
    /// <li> <b>ActivityTaskStarted</b> : The scheduled activity task was dispatched to a worker. </li>
    /// <li> <b>ActivityTaskCompleted</b> : An activity worker successfully completed an activity task by calling RespondActivityTaskCompleted.
    /// </li>
    /// <li> <b>ActivityTaskFailed</b> : An activity worker failed an activity task by calling RespondActivityTaskFailed. </li>
    /// <li> <b>ActivityTaskTimedOut</b> : The activity task timed out. </li>
    /// <li> <b>ActivityTaskCanceled</b> : The activity task was successfully canceled. </li>
    /// <li> <b>ActivityTaskCancelRequested</b> : A <c>RequestCancelActivityTask</c> decision was received by the system. </li>
    /// <li> <b>RequestCancelActivityTaskFailed</b> : Failed to process RequestCancelActivityTask decision. This happens when the decision is not
    /// configured properly. </li>
    /// <li> <b>WorkflowExecutionSignaled</b> : An external signal was received for the workflow execution. </li>
    /// <li> <b>MarkerRecorded</b> : A marker was recorded in the workflow history as the result of a <c>RecordMarker</c> decision. </li>
    /// <li> <b>TimerStarted</b> : A timer was started for the workflow execution due to a <c>StartTimer</c> decision. </li>
    /// <li> <b>StartTimerFailed</b> : Failed to process StartTimer decision. This happens when the decision is not configured properly, for
    /// example a timer already exists with the specified timer Id. </li>
    /// <li> <b>TimerFired</b> : A timer, previously started for this workflow execution, fired. </li>
    /// <li> <b>TimerCanceled</b> : A timer, previously started for this workflow execution, was successfully canceled. </li>
    /// <li> <b>CancelTimerFailed</b> : Failed to process CancelTimer decision. This happens when the decision is not configured properly, for
    /// example no timer exists with the specified timer Id. </li>
    /// <li> <b>StartChildWorkflowExecutionInitiated</b> : A request was made to start a child workflow execution. </li>
    /// <li> <b>StartChildWorkflowExecutionFailed</b> : Failed to process StartChildWorkflowExecution decision. This happens when the decision is
    /// not configured properly, for example the workflow type specified is not registered. </li>
    /// <li> <b>ChildWorkflowExecutionStarted</b> : A child workflow execution was successfully started. </li>
    /// <li> <b>ChildWorkflowExecutionCompleted</b> : A child workflow execution, started by this workflow execution, completed successfully and
    /// was closed. </li>
    /// <li> <b>ChildWorkflowExecutionFailed</b> : A child workflow execution, started by this workflow execution, failed to complete successfully
    /// and was closed. </li>
    /// <li> <b>ChildWorkflowExecutionTimedOut</b> : A child workflow execution, started by this workflow execution, timed out and was closed.
    /// </li>
    /// <li> <b>ChildWorkflowExecutionCanceled</b> : A child workflow execution, started by this workflow execution, was canceled and closed.
    /// </li>
    /// <li> <b>ChildWorkflowExecutionTerminated</b> : A child workflow execution, started by this workflow execution, was terminated. </li>
    /// <li> <b>SignalExternalWorkflowExecutionInitiated</b> : A request to signal an external workflow was made. </li>
    /// <li> <b>ExternalWorkflowExecutionSignaled</b> : A signal, requested by this workflow execution, was successfully delivered to the target
    /// external workflow execution. </li>
    /// <li> <b>SignalExternalWorkflowExecutionFailed</b> : The request to signal an external workflow execution failed. </li>
    /// <li> <b>RequestCancelExternalWorkflowExecutionInitiated</b> : A request was made to request the cancellation of an external workflow
    /// execution. </li>
    /// <li> <b>ExternalWorkflowExecutionCancelRequested</b> : Request to cancel an external workflow execution was successfully delivered to the
    /// target execution. </li>
    /// <li> <b>RequestCancelExternalWorkflowExecutionFailed</b> : Request to cancel an external workflow execution failed. </li>
    /// 
    /// </ul>
    /// </summary>
    public class HistoryEvent
    {
        
        private DateTime? eventTimestamp;
        private EventType eventType;
        private long? eventId;
        private WorkflowExecutionStartedEventAttributes workflowExecutionStartedEventAttributes;
        private WorkflowExecutionCompletedEventAttributes workflowExecutionCompletedEventAttributes;
        private CompleteWorkflowExecutionFailedEventAttributes completeWorkflowExecutionFailedEventAttributes;
        private WorkflowExecutionFailedEventAttributes workflowExecutionFailedEventAttributes;
        private FailWorkflowExecutionFailedEventAttributes failWorkflowExecutionFailedEventAttributes;
        private WorkflowExecutionTimedOutEventAttributes workflowExecutionTimedOutEventAttributes;
        private WorkflowExecutionCanceledEventAttributes workflowExecutionCanceledEventAttributes;
        private CancelWorkflowExecutionFailedEventAttributes cancelWorkflowExecutionFailedEventAttributes;
        private WorkflowExecutionContinuedAsNewEventAttributes workflowExecutionContinuedAsNewEventAttributes;
        private ContinueAsNewWorkflowExecutionFailedEventAttributes continueAsNewWorkflowExecutionFailedEventAttributes;
        private WorkflowExecutionTerminatedEventAttributes workflowExecutionTerminatedEventAttributes;
        private WorkflowExecutionCancelRequestedEventAttributes workflowExecutionCancelRequestedEventAttributes;
        private DecisionTaskScheduledEventAttributes decisionTaskScheduledEventAttributes;
        private DecisionTaskStartedEventAttributes decisionTaskStartedEventAttributes;
        private DecisionTaskCompletedEventAttributes decisionTaskCompletedEventAttributes;
        private DecisionTaskTimedOutEventAttributes decisionTaskTimedOutEventAttributes;
        private ActivityTaskScheduledEventAttributes activityTaskScheduledEventAttributes;
        private ActivityTaskStartedEventAttributes activityTaskStartedEventAttributes;
        private ActivityTaskCompletedEventAttributes activityTaskCompletedEventAttributes;
        private ActivityTaskFailedEventAttributes activityTaskFailedEventAttributes;
        private ActivityTaskTimedOutEventAttributes activityTaskTimedOutEventAttributes;
        private ActivityTaskCanceledEventAttributes activityTaskCanceledEventAttributes;
        private ActivityTaskCancelRequestedEventAttributes activityTaskCancelRequestedEventAttributes;
        private WorkflowExecutionSignaledEventAttributes workflowExecutionSignaledEventAttributes;
        private MarkerRecordedEventAttributes markerRecordedEventAttributes;
        private RecordMarkerFailedEventAttributes recordMarkerFailedEventAttributes;
        private TimerStartedEventAttributes timerStartedEventAttributes;
        private TimerFiredEventAttributes timerFiredEventAttributes;
        private TimerCanceledEventAttributes timerCanceledEventAttributes;
        private StartChildWorkflowExecutionInitiatedEventAttributes startChildWorkflowExecutionInitiatedEventAttributes;
        private ChildWorkflowExecutionStartedEventAttributes childWorkflowExecutionStartedEventAttributes;
        private ChildWorkflowExecutionCompletedEventAttributes childWorkflowExecutionCompletedEventAttributes;
        private ChildWorkflowExecutionFailedEventAttributes childWorkflowExecutionFailedEventAttributes;
        private ChildWorkflowExecutionTimedOutEventAttributes childWorkflowExecutionTimedOutEventAttributes;
        private ChildWorkflowExecutionCanceledEventAttributes childWorkflowExecutionCanceledEventAttributes;
        private ChildWorkflowExecutionTerminatedEventAttributes childWorkflowExecutionTerminatedEventAttributes;
        private SignalExternalWorkflowExecutionInitiatedEventAttributes signalExternalWorkflowExecutionInitiatedEventAttributes;
        private ExternalWorkflowExecutionSignaledEventAttributes externalWorkflowExecutionSignaledEventAttributes;
        private SignalExternalWorkflowExecutionFailedEventAttributes signalExternalWorkflowExecutionFailedEventAttributes;
        private ExternalWorkflowExecutionCancelRequestedEventAttributes externalWorkflowExecutionCancelRequestedEventAttributes;
        private RequestCancelExternalWorkflowExecutionInitiatedEventAttributes requestCancelExternalWorkflowExecutionInitiatedEventAttributes;
        private RequestCancelExternalWorkflowExecutionFailedEventAttributes requestCancelExternalWorkflowExecutionFailedEventAttributes;
        private ScheduleActivityTaskFailedEventAttributes scheduleActivityTaskFailedEventAttributes;
        private RequestCancelActivityTaskFailedEventAttributes requestCancelActivityTaskFailedEventAttributes;
        private StartTimerFailedEventAttributes startTimerFailedEventAttributes;
        private CancelTimerFailedEventAttributes cancelTimerFailedEventAttributes;
        private StartChildWorkflowExecutionFailedEventAttributes startChildWorkflowExecutionFailedEventAttributes;

        /// <summary>
        /// The date and time when the event occurred.
        ///  
        /// </summary>
        public DateTime EventTimestamp
        {
            get { return this.eventTimestamp ?? default(DateTime); }
            set { this.eventTimestamp = value; }
        }

        // Check to see if EventTimestamp property is set
        internal bool IsSetEventTimestamp()
        {
            return this.eventTimestamp.HasValue;
        }

        /// <summary>
        /// The type of the history event.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>WorkflowExecutionStarted, WorkflowExecutionCancelRequested, WorkflowExecutionCompleted, CompleteWorkflowExecutionFailed, WorkflowExecutionFailed, FailWorkflowExecutionFailed, WorkflowExecutionTimedOut, WorkflowExecutionCanceled, CancelWorkflowExecutionFailed, WorkflowExecutionContinuedAsNew, ContinueAsNewWorkflowExecutionFailed, WorkflowExecutionTerminated, DecisionTaskScheduled, DecisionTaskStarted, DecisionTaskCompleted, DecisionTaskTimedOut, ActivityTaskScheduled, ScheduleActivityTaskFailed, ActivityTaskStarted, ActivityTaskCompleted, ActivityTaskFailed, ActivityTaskTimedOut, ActivityTaskCanceled, ActivityTaskCancelRequested, RequestCancelActivityTaskFailed, WorkflowExecutionSignaled, MarkerRecorded, RecordMarkerFailed, TimerStarted, StartTimerFailed, TimerFired, TimerCanceled, CancelTimerFailed, StartChildWorkflowExecutionInitiated, StartChildWorkflowExecutionFailed, ChildWorkflowExecutionStarted, ChildWorkflowExecutionCompleted, ChildWorkflowExecutionFailed, ChildWorkflowExecutionTimedOut, ChildWorkflowExecutionCanceled, ChildWorkflowExecutionTerminated, SignalExternalWorkflowExecutionInitiated, SignalExternalWorkflowExecutionFailed, ExternalWorkflowExecutionSignaled, RequestCancelExternalWorkflowExecutionInitiated, RequestCancelExternalWorkflowExecutionFailed, ExternalWorkflowExecutionCancelRequested</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public EventType EventType
        {
            get { return this.eventType; }
            set { this.eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this.eventType != null;
        }

        /// <summary>
        /// The system generated id of the event. This id uniquely identifies the event with in the workflow execution history.
        ///  
        /// </summary>
        public long EventId
        {
            get { return this.eventId ?? default(long); }
            set { this.eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this.eventId.HasValue;
        }

        /// <summary>
        /// If the event is of type <c>WorkflowExecutionStarted</c> then this member is set and provides detailed information about the event. It is not
        /// set for other event types.
        ///  
        /// </summary>
        public WorkflowExecutionStartedEventAttributes WorkflowExecutionStartedEventAttributes
        {
            get { return this.workflowExecutionStartedEventAttributes; }
            set { this.workflowExecutionStartedEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionStartedEventAttributes property is set
        internal bool IsSetWorkflowExecutionStartedEventAttributes()
        {
            return this.workflowExecutionStartedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>WorkflowExecutionCompleted</c> then this member is set and provides detailed information about the event. It is
        /// not set for other event types.
        ///  
        /// </summary>
        public WorkflowExecutionCompletedEventAttributes WorkflowExecutionCompletedEventAttributes
        {
            get { return this.workflowExecutionCompletedEventAttributes; }
            set { this.workflowExecutionCompletedEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionCompletedEventAttributes property is set
        internal bool IsSetWorkflowExecutionCompletedEventAttributes()
        {
            return this.workflowExecutionCompletedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>CompleteWorkflowExecutionFailed</c> then this member is set and provides detailed information about the event. It
        /// is not set for other event types.
        ///  
        /// </summary>
        public CompleteWorkflowExecutionFailedEventAttributes CompleteWorkflowExecutionFailedEventAttributes
        {
            get { return this.completeWorkflowExecutionFailedEventAttributes; }
            set { this.completeWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if CompleteWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetCompleteWorkflowExecutionFailedEventAttributes()
        {
            return this.completeWorkflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>WorkflowExecutionFailed</c> then this member is set and provides detailed information about the event. It is not
        /// set for other event types.
        ///  
        /// </summary>
        public WorkflowExecutionFailedEventAttributes WorkflowExecutionFailedEventAttributes
        {
            get { return this.workflowExecutionFailedEventAttributes; }
            set { this.workflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetWorkflowExecutionFailedEventAttributes()
        {
            return this.workflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>FailWorkflowExecutionFailed</c> then this member is set and provides detailed information about the event. It is
        /// not set for other event types.
        ///  
        /// </summary>
        public FailWorkflowExecutionFailedEventAttributes FailWorkflowExecutionFailedEventAttributes
        {
            get { return this.failWorkflowExecutionFailedEventAttributes; }
            set { this.failWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if FailWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetFailWorkflowExecutionFailedEventAttributes()
        {
            return this.failWorkflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>WorkflowExecutionTimedOut</c> then this member is set and provides detailed information about the event. It is
        /// not set for other event types.
        ///  
        /// </summary>
        public WorkflowExecutionTimedOutEventAttributes WorkflowExecutionTimedOutEventAttributes
        {
            get { return this.workflowExecutionTimedOutEventAttributes; }
            set { this.workflowExecutionTimedOutEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionTimedOutEventAttributes property is set
        internal bool IsSetWorkflowExecutionTimedOutEventAttributes()
        {
            return this.workflowExecutionTimedOutEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>WorkflowExecutionCanceled</c> then this member is set and provides detailed information about the event. It is
        /// not set for other event types.
        ///  
        /// </summary>
        public WorkflowExecutionCanceledEventAttributes WorkflowExecutionCanceledEventAttributes
        {
            get { return this.workflowExecutionCanceledEventAttributes; }
            set { this.workflowExecutionCanceledEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionCanceledEventAttributes property is set
        internal bool IsSetWorkflowExecutionCanceledEventAttributes()
        {
            return this.workflowExecutionCanceledEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>CancelWorkflowExecutionFailed</c> then this member is set and provides detailed information about the event. It
        /// is not set for other event types.
        ///  
        /// </summary>
        public CancelWorkflowExecutionFailedEventAttributes CancelWorkflowExecutionFailedEventAttributes
        {
            get { return this.cancelWorkflowExecutionFailedEventAttributes; }
            set { this.cancelWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if CancelWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetCancelWorkflowExecutionFailedEventAttributes()
        {
            return this.cancelWorkflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>WorkflowExecutionContinuedAsNew</c> then this member is set and provides detailed information about the event. It
        /// is not set for other event types.
        ///  
        /// </summary>
        public WorkflowExecutionContinuedAsNewEventAttributes WorkflowExecutionContinuedAsNewEventAttributes
        {
            get { return this.workflowExecutionContinuedAsNewEventAttributes; }
            set { this.workflowExecutionContinuedAsNewEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionContinuedAsNewEventAttributes property is set
        internal bool IsSetWorkflowExecutionContinuedAsNewEventAttributes()
        {
            return this.workflowExecutionContinuedAsNewEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ContinueAsNewWorkflowExecutionFailed</c> then this member is set and provides detailed information about the
        /// event. It is not set for other event types.
        ///  
        /// </summary>
        public ContinueAsNewWorkflowExecutionFailedEventAttributes ContinueAsNewWorkflowExecutionFailedEventAttributes
        {
            get { return this.continueAsNewWorkflowExecutionFailedEventAttributes; }
            set { this.continueAsNewWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if ContinueAsNewWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetContinueAsNewWorkflowExecutionFailedEventAttributes()
        {
            return this.continueAsNewWorkflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>WorkflowExecutionTerminated</c> then this member is set and provides detailed information about the event. It is
        /// not set for other event types.
        ///  
        /// </summary>
        public WorkflowExecutionTerminatedEventAttributes WorkflowExecutionTerminatedEventAttributes
        {
            get { return this.workflowExecutionTerminatedEventAttributes; }
            set { this.workflowExecutionTerminatedEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionTerminatedEventAttributes property is set
        internal bool IsSetWorkflowExecutionTerminatedEventAttributes()
        {
            return this.workflowExecutionTerminatedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>WorkflowExecutionCancelRequested</c> then this member is set and provides detailed information about the event.
        /// It is not set for other event types.
        ///  
        /// </summary>
        public WorkflowExecutionCancelRequestedEventAttributes WorkflowExecutionCancelRequestedEventAttributes
        {
            get { return this.workflowExecutionCancelRequestedEventAttributes; }
            set { this.workflowExecutionCancelRequestedEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionCancelRequestedEventAttributes property is set
        internal bool IsSetWorkflowExecutionCancelRequestedEventAttributes()
        {
            return this.workflowExecutionCancelRequestedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>DecisionTaskScheduled</c> then this member is set and provides detailed information about the event. It is not
        /// set for other event types.
        ///  
        /// </summary>
        public DecisionTaskScheduledEventAttributes DecisionTaskScheduledEventAttributes
        {
            get { return this.decisionTaskScheduledEventAttributes; }
            set { this.decisionTaskScheduledEventAttributes = value; }
        }

        // Check to see if DecisionTaskScheduledEventAttributes property is set
        internal bool IsSetDecisionTaskScheduledEventAttributes()
        {
            return this.decisionTaskScheduledEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>DecisionTaskStarted</c> then this member is set and provides detailed information about the event. It is not set
        /// for other event types.
        ///  
        /// </summary>
        public DecisionTaskStartedEventAttributes DecisionTaskStartedEventAttributes
        {
            get { return this.decisionTaskStartedEventAttributes; }
            set { this.decisionTaskStartedEventAttributes = value; }
        }

        // Check to see if DecisionTaskStartedEventAttributes property is set
        internal bool IsSetDecisionTaskStartedEventAttributes()
        {
            return this.decisionTaskStartedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>DecisionTaskCompleted</c> then this member is set and provides detailed information about the event. It is not
        /// set for other event types.
        ///  
        /// </summary>
        public DecisionTaskCompletedEventAttributes DecisionTaskCompletedEventAttributes
        {
            get { return this.decisionTaskCompletedEventAttributes; }
            set { this.decisionTaskCompletedEventAttributes = value; }
        }

        // Check to see if DecisionTaskCompletedEventAttributes property is set
        internal bool IsSetDecisionTaskCompletedEventAttributes()
        {
            return this.decisionTaskCompletedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>DecisionTaskTimedOut</c> then this member is set and provides detailed information about the event. It is not set
        /// for other event types.
        ///  
        /// </summary>
        public DecisionTaskTimedOutEventAttributes DecisionTaskTimedOutEventAttributes
        {
            get { return this.decisionTaskTimedOutEventAttributes; }
            set { this.decisionTaskTimedOutEventAttributes = value; }
        }

        // Check to see if DecisionTaskTimedOutEventAttributes property is set
        internal bool IsSetDecisionTaskTimedOutEventAttributes()
        {
            return this.decisionTaskTimedOutEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ActivityTaskScheduled</c> then this member is set and provides detailed information about the event. It is not
        /// set for other event types.
        ///  
        /// </summary>
        public ActivityTaskScheduledEventAttributes ActivityTaskScheduledEventAttributes
        {
            get { return this.activityTaskScheduledEventAttributes; }
            set { this.activityTaskScheduledEventAttributes = value; }
        }

        // Check to see if ActivityTaskScheduledEventAttributes property is set
        internal bool IsSetActivityTaskScheduledEventAttributes()
        {
            return this.activityTaskScheduledEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ActivityTaskStarted</c> then this member is set and provides detailed information about the event. It is not set
        /// for other event types.
        ///  
        /// </summary>
        public ActivityTaskStartedEventAttributes ActivityTaskStartedEventAttributes
        {
            get { return this.activityTaskStartedEventAttributes; }
            set { this.activityTaskStartedEventAttributes = value; }
        }

        // Check to see if ActivityTaskStartedEventAttributes property is set
        internal bool IsSetActivityTaskStartedEventAttributes()
        {
            return this.activityTaskStartedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ActivityTaskCompleted</c> then this member is set and provides detailed information about the event. It is not
        /// set for other event types.
        ///  
        /// </summary>
        public ActivityTaskCompletedEventAttributes ActivityTaskCompletedEventAttributes
        {
            get { return this.activityTaskCompletedEventAttributes; }
            set { this.activityTaskCompletedEventAttributes = value; }
        }

        // Check to see if ActivityTaskCompletedEventAttributes property is set
        internal bool IsSetActivityTaskCompletedEventAttributes()
        {
            return this.activityTaskCompletedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ActivityTaskFailed</c> then this member is set and provides detailed information about the event. It is not set
        /// for other event types.
        ///  
        /// </summary>
        public ActivityTaskFailedEventAttributes ActivityTaskFailedEventAttributes
        {
            get { return this.activityTaskFailedEventAttributes; }
            set { this.activityTaskFailedEventAttributes = value; }
        }

        // Check to see if ActivityTaskFailedEventAttributes property is set
        internal bool IsSetActivityTaskFailedEventAttributes()
        {
            return this.activityTaskFailedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ActivityTaskTimedOut</c> then this member is set and provides detailed information about the event. It is not set
        /// for other event types.
        ///  
        /// </summary>
        public ActivityTaskTimedOutEventAttributes ActivityTaskTimedOutEventAttributes
        {
            get { return this.activityTaskTimedOutEventAttributes; }
            set { this.activityTaskTimedOutEventAttributes = value; }
        }

        // Check to see if ActivityTaskTimedOutEventAttributes property is set
        internal bool IsSetActivityTaskTimedOutEventAttributes()
        {
            return this.activityTaskTimedOutEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ActivityTaskCanceled</c> then this member is set and provides detailed information about the event. It is not set
        /// for other event types.
        ///  
        /// </summary>
        public ActivityTaskCanceledEventAttributes ActivityTaskCanceledEventAttributes
        {
            get { return this.activityTaskCanceledEventAttributes; }
            set { this.activityTaskCanceledEventAttributes = value; }
        }

        // Check to see if ActivityTaskCanceledEventAttributes property is set
        internal bool IsSetActivityTaskCanceledEventAttributes()
        {
            return this.activityTaskCanceledEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ActivityTaskcancelRequested</c> then this member is set and provides detailed information about the event. It is
        /// not set for other event types.
        ///  
        /// </summary>
        public ActivityTaskCancelRequestedEventAttributes ActivityTaskCancelRequestedEventAttributes
        {
            get { return this.activityTaskCancelRequestedEventAttributes; }
            set { this.activityTaskCancelRequestedEventAttributes = value; }
        }

        // Check to see if ActivityTaskCancelRequestedEventAttributes property is set
        internal bool IsSetActivityTaskCancelRequestedEventAttributes()
        {
            return this.activityTaskCancelRequestedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>WorkflowExecutionSignaled</c> then this member is set and provides detailed information about the event. It is
        /// not set for other event types.
        ///  
        /// </summary>
        public WorkflowExecutionSignaledEventAttributes WorkflowExecutionSignaledEventAttributes
        {
            get { return this.workflowExecutionSignaledEventAttributes; }
            set { this.workflowExecutionSignaledEventAttributes = value; }
        }

        // Check to see if WorkflowExecutionSignaledEventAttributes property is set
        internal bool IsSetWorkflowExecutionSignaledEventAttributes()
        {
            return this.workflowExecutionSignaledEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>MarkerRecorded</c> then this member is set and provides detailed information about the event. It is not set for
        /// other event types.
        ///  
        /// </summary>
        public MarkerRecordedEventAttributes MarkerRecordedEventAttributes
        {
            get { return this.markerRecordedEventAttributes; }
            set { this.markerRecordedEventAttributes = value; }
        }

        // Check to see if MarkerRecordedEventAttributes property is set
        internal bool IsSetMarkerRecordedEventAttributes()
        {
            return this.markerRecordedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>DecisionTaskFailed</c> then this member is set and provides detailed information about the event. It is not set
        /// for other event types.
        ///  
        /// </summary>
        public RecordMarkerFailedEventAttributes RecordMarkerFailedEventAttributes
        {
            get { return this.recordMarkerFailedEventAttributes; }
            set { this.recordMarkerFailedEventAttributes = value; }
        }

        // Check to see if RecordMarkerFailedEventAttributes property is set
        internal bool IsSetRecordMarkerFailedEventAttributes()
        {
            return this.recordMarkerFailedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>TimerStarted</c> then this member is set and provides detailed information about the event. It is not set for
        /// other event types.
        ///  
        /// </summary>
        public TimerStartedEventAttributes TimerStartedEventAttributes
        {
            get { return this.timerStartedEventAttributes; }
            set { this.timerStartedEventAttributes = value; }
        }

        // Check to see if TimerStartedEventAttributes property is set
        internal bool IsSetTimerStartedEventAttributes()
        {
            return this.timerStartedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>TimerFired</c> then this member is set and provides detailed information about the event. It is not set for other
        /// event types.
        ///  
        /// </summary>
        public TimerFiredEventAttributes TimerFiredEventAttributes
        {
            get { return this.timerFiredEventAttributes; }
            set { this.timerFiredEventAttributes = value; }
        }

        // Check to see if TimerFiredEventAttributes property is set
        internal bool IsSetTimerFiredEventAttributes()
        {
            return this.timerFiredEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>TimerCanceled</c> then this member is set and provides detailed information about the event. It is not set for
        /// other event types.
        ///  
        /// </summary>
        public TimerCanceledEventAttributes TimerCanceledEventAttributes
        {
            get { return this.timerCanceledEventAttributes; }
            set { this.timerCanceledEventAttributes = value; }
        }

        // Check to see if TimerCanceledEventAttributes property is set
        internal bool IsSetTimerCanceledEventAttributes()
        {
            return this.timerCanceledEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>StartChildWorkflowExecutionInitiated</c> then this member is set and provides detailed information about the
        /// event. It is not set for other event types.
        ///  
        /// </summary>
        public StartChildWorkflowExecutionInitiatedEventAttributes StartChildWorkflowExecutionInitiatedEventAttributes
        {
            get { return this.startChildWorkflowExecutionInitiatedEventAttributes; }
            set { this.startChildWorkflowExecutionInitiatedEventAttributes = value; }
        }

        // Check to see if StartChildWorkflowExecutionInitiatedEventAttributes property is set
        internal bool IsSetStartChildWorkflowExecutionInitiatedEventAttributes()
        {
            return this.startChildWorkflowExecutionInitiatedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ChildWorkflowExecutionStarted</c> then this member is set and provides detailed information about the event. It
        /// is not set for other event types.
        ///  
        /// </summary>
        public ChildWorkflowExecutionStartedEventAttributes ChildWorkflowExecutionStartedEventAttributes
        {
            get { return this.childWorkflowExecutionStartedEventAttributes; }
            set { this.childWorkflowExecutionStartedEventAttributes = value; }
        }

        // Check to see if ChildWorkflowExecutionStartedEventAttributes property is set
        internal bool IsSetChildWorkflowExecutionStartedEventAttributes()
        {
            return this.childWorkflowExecutionStartedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ChildWorkflowExecutionCompleted</c> then this member is set and provides detailed information about the event. It
        /// is not set for other event types.
        ///  
        /// </summary>
        public ChildWorkflowExecutionCompletedEventAttributes ChildWorkflowExecutionCompletedEventAttributes
        {
            get { return this.childWorkflowExecutionCompletedEventAttributes; }
            set { this.childWorkflowExecutionCompletedEventAttributes = value; }
        }

        // Check to see if ChildWorkflowExecutionCompletedEventAttributes property is set
        internal bool IsSetChildWorkflowExecutionCompletedEventAttributes()
        {
            return this.childWorkflowExecutionCompletedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ChildWorkflowExecutionFailed</c> then this member is set and provides detailed information about the event. It is
        /// not set for other event types.
        ///  
        /// </summary>
        public ChildWorkflowExecutionFailedEventAttributes ChildWorkflowExecutionFailedEventAttributes
        {
            get { return this.childWorkflowExecutionFailedEventAttributes; }
            set { this.childWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if ChildWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetChildWorkflowExecutionFailedEventAttributes()
        {
            return this.childWorkflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ChildWorkflowExecutionTimedOut</c> then this member is set and provides detailed information about the event. It
        /// is not set for other event types.
        ///  
        /// </summary>
        public ChildWorkflowExecutionTimedOutEventAttributes ChildWorkflowExecutionTimedOutEventAttributes
        {
            get { return this.childWorkflowExecutionTimedOutEventAttributes; }
            set { this.childWorkflowExecutionTimedOutEventAttributes = value; }
        }

        // Check to see if ChildWorkflowExecutionTimedOutEventAttributes property is set
        internal bool IsSetChildWorkflowExecutionTimedOutEventAttributes()
        {
            return this.childWorkflowExecutionTimedOutEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ChildWorkflowExecutionCanceled</c> then this member is set and provides detailed information about the event. It
        /// is not set for other event types.
        ///  
        /// </summary>
        public ChildWorkflowExecutionCanceledEventAttributes ChildWorkflowExecutionCanceledEventAttributes
        {
            get { return this.childWorkflowExecutionCanceledEventAttributes; }
            set { this.childWorkflowExecutionCanceledEventAttributes = value; }
        }

        // Check to see if ChildWorkflowExecutionCanceledEventAttributes property is set
        internal bool IsSetChildWorkflowExecutionCanceledEventAttributes()
        {
            return this.childWorkflowExecutionCanceledEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ChildWorkflowExecutionTerminated</c> then this member is set and provides detailed information about the event.
        /// It is not set for other event types.
        ///  
        /// </summary>
        public ChildWorkflowExecutionTerminatedEventAttributes ChildWorkflowExecutionTerminatedEventAttributes
        {
            get { return this.childWorkflowExecutionTerminatedEventAttributes; }
            set { this.childWorkflowExecutionTerminatedEventAttributes = value; }
        }

        // Check to see if ChildWorkflowExecutionTerminatedEventAttributes property is set
        internal bool IsSetChildWorkflowExecutionTerminatedEventAttributes()
        {
            return this.childWorkflowExecutionTerminatedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>SignalExternalWorkflowExecutionInitiated</c> then this member is set and provides detailed information about the
        /// event. It is not set for other event types.
        ///  
        /// </summary>
        public SignalExternalWorkflowExecutionInitiatedEventAttributes SignalExternalWorkflowExecutionInitiatedEventAttributes
        {
            get { return this.signalExternalWorkflowExecutionInitiatedEventAttributes; }
            set { this.signalExternalWorkflowExecutionInitiatedEventAttributes = value; }
        }

        // Check to see if SignalExternalWorkflowExecutionInitiatedEventAttributes property is set
        internal bool IsSetSignalExternalWorkflowExecutionInitiatedEventAttributes()
        {
            return this.signalExternalWorkflowExecutionInitiatedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ExternalWorkflowExecutionSignaled</c> then this member is set and provides detailed information about the event.
        /// It is not set for other event types.
        ///  
        /// </summary>
        public ExternalWorkflowExecutionSignaledEventAttributes ExternalWorkflowExecutionSignaledEventAttributes
        {
            get { return this.externalWorkflowExecutionSignaledEventAttributes; }
            set { this.externalWorkflowExecutionSignaledEventAttributes = value; }
        }

        // Check to see if ExternalWorkflowExecutionSignaledEventAttributes property is set
        internal bool IsSetExternalWorkflowExecutionSignaledEventAttributes()
        {
            return this.externalWorkflowExecutionSignaledEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>SignalExternalWorkflowExecutionFailed</c> then this member is set and provides detailed information about the
        /// event. It is not set for other event types.
        ///  
        /// </summary>
        public SignalExternalWorkflowExecutionFailedEventAttributes SignalExternalWorkflowExecutionFailedEventAttributes
        {
            get { return this.signalExternalWorkflowExecutionFailedEventAttributes; }
            set { this.signalExternalWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if SignalExternalWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetSignalExternalWorkflowExecutionFailedEventAttributes()
        {
            return this.signalExternalWorkflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ExternalWorkflowExecutionCancelRequested</c> then this member is set and provides detailed information about the
        /// event. It is not set for other event types.
        ///  
        /// </summary>
        public ExternalWorkflowExecutionCancelRequestedEventAttributes ExternalWorkflowExecutionCancelRequestedEventAttributes
        {
            get { return this.externalWorkflowExecutionCancelRequestedEventAttributes; }
            set { this.externalWorkflowExecutionCancelRequestedEventAttributes = value; }
        }

        // Check to see if ExternalWorkflowExecutionCancelRequestedEventAttributes property is set
        internal bool IsSetExternalWorkflowExecutionCancelRequestedEventAttributes()
        {
            return this.externalWorkflowExecutionCancelRequestedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>RequestCancelExternalWorkflowExecutionInitiated</c> then this member is set and provides detailed information
        /// about the event. It is not set for other event types.
        ///  
        /// </summary>
        public RequestCancelExternalWorkflowExecutionInitiatedEventAttributes RequestCancelExternalWorkflowExecutionInitiatedEventAttributes
        {
            get { return this.requestCancelExternalWorkflowExecutionInitiatedEventAttributes; }
            set { this.requestCancelExternalWorkflowExecutionInitiatedEventAttributes = value; }
        }

        // Check to see if RequestCancelExternalWorkflowExecutionInitiatedEventAttributes property is set
        internal bool IsSetRequestCancelExternalWorkflowExecutionInitiatedEventAttributes()
        {
            return this.requestCancelExternalWorkflowExecutionInitiatedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>RequestCancelExternalWorkflowExecutionFailed</c> then this member is set and provides detailed information about
        /// the event. It is not set for other event types.
        ///  
        /// </summary>
        public RequestCancelExternalWorkflowExecutionFailedEventAttributes RequestCancelExternalWorkflowExecutionFailedEventAttributes
        {
            get { return this.requestCancelExternalWorkflowExecutionFailedEventAttributes; }
            set { this.requestCancelExternalWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if RequestCancelExternalWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetRequestCancelExternalWorkflowExecutionFailedEventAttributes()
        {
            return this.requestCancelExternalWorkflowExecutionFailedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>ScheduleActivityTaskFailed</c> then this member is set and provides detailed information about the event. It is
        /// not set for other event types.
        ///  
        /// </summary>
        public ScheduleActivityTaskFailedEventAttributes ScheduleActivityTaskFailedEventAttributes
        {
            get { return this.scheduleActivityTaskFailedEventAttributes; }
            set { this.scheduleActivityTaskFailedEventAttributes = value; }
        }

        // Check to see if ScheduleActivityTaskFailedEventAttributes property is set
        internal bool IsSetScheduleActivityTaskFailedEventAttributes()
        {
            return this.scheduleActivityTaskFailedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>RequestCancelActivityTaskFailed</c> then this member is set and provides detailed information about the event. It
        /// is not set for other event types.
        ///  
        /// </summary>
        public RequestCancelActivityTaskFailedEventAttributes RequestCancelActivityTaskFailedEventAttributes
        {
            get { return this.requestCancelActivityTaskFailedEventAttributes; }
            set { this.requestCancelActivityTaskFailedEventAttributes = value; }
        }

        // Check to see if RequestCancelActivityTaskFailedEventAttributes property is set
        internal bool IsSetRequestCancelActivityTaskFailedEventAttributes()
        {
            return this.requestCancelActivityTaskFailedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>StartTimerFailed</c> then this member is set and provides detailed information about the event. It is not set for
        /// other event types.
        ///  
        /// </summary>
        public StartTimerFailedEventAttributes StartTimerFailedEventAttributes
        {
            get { return this.startTimerFailedEventAttributes; }
            set { this.startTimerFailedEventAttributes = value; }
        }

        // Check to see if StartTimerFailedEventAttributes property is set
        internal bool IsSetStartTimerFailedEventAttributes()
        {
            return this.startTimerFailedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>CancelTimerFailed</c> then this member is set and provides detailed information about the event. It is not set
        /// for other event types.
        ///  
        /// </summary>
        public CancelTimerFailedEventAttributes CancelTimerFailedEventAttributes
        {
            get { return this.cancelTimerFailedEventAttributes; }
            set { this.cancelTimerFailedEventAttributes = value; }
        }

        // Check to see if CancelTimerFailedEventAttributes property is set
        internal bool IsSetCancelTimerFailedEventAttributes()
        {
            return this.cancelTimerFailedEventAttributes != null;
        }

        /// <summary>
        /// If the event is of type <c>StartChildWorkflowExecutionFailed</c> then this member is set and provides detailed information about the event.
        /// It is not set for other event types.
        ///  
        /// </summary>
        public StartChildWorkflowExecutionFailedEventAttributes StartChildWorkflowExecutionFailedEventAttributes
        {
            get { return this.startChildWorkflowExecutionFailedEventAttributes; }
            set { this.startChildWorkflowExecutionFailedEventAttributes = value; }
        }

        // Check to see if StartChildWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetStartChildWorkflowExecutionFailedEventAttributes()
        {
            return this.startChildWorkflowExecutionFailedEventAttributes != null;
        }
    }
}
