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
        private string eventType;
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

        /// <summary>
        /// Sets the EventTimestamp property
        /// </summary>
        /// <param name="eventTimestamp">The value to set for the EventTimestamp property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithEventTimestamp(DateTime eventTimestamp)
        {
            this.eventTimestamp = eventTimestamp;
            return this;
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
        public string EventType
        {
            get { return this.eventType; }
            set { this.eventType = value; }
        }

        /// <summary>
        /// Sets the EventType property
        /// </summary>
        /// <param name="eventType">The value to set for the EventType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithEventType(string eventType)
        {
            this.eventType = eventType;
            return this;
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

        /// <summary>
        /// Sets the EventId property
        /// </summary>
        /// <param name="eventId">The value to set for the EventId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithEventId(long eventId)
        {
            this.eventId = eventId;
            return this;
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

        /// <summary>
        /// Sets the WorkflowExecutionStartedEventAttributes property
        /// </summary>
        /// <param name="workflowExecutionStartedEventAttributes">The value to set for the WorkflowExecutionStartedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithWorkflowExecutionStartedEventAttributes(WorkflowExecutionStartedEventAttributes workflowExecutionStartedEventAttributes)
        {
            this.workflowExecutionStartedEventAttributes = workflowExecutionStartedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the WorkflowExecutionCompletedEventAttributes property
        /// </summary>
        /// <param name="workflowExecutionCompletedEventAttributes">The value to set for the WorkflowExecutionCompletedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithWorkflowExecutionCompletedEventAttributes(WorkflowExecutionCompletedEventAttributes workflowExecutionCompletedEventAttributes)
        {
            this.workflowExecutionCompletedEventAttributes = workflowExecutionCompletedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the CompleteWorkflowExecutionFailedEventAttributes property
        /// </summary>
        /// <param name="completeWorkflowExecutionFailedEventAttributes">The value to set for the CompleteWorkflowExecutionFailedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithCompleteWorkflowExecutionFailedEventAttributes(CompleteWorkflowExecutionFailedEventAttributes completeWorkflowExecutionFailedEventAttributes)
        {
            this.completeWorkflowExecutionFailedEventAttributes = completeWorkflowExecutionFailedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the WorkflowExecutionFailedEventAttributes property
        /// </summary>
        /// <param name="workflowExecutionFailedEventAttributes">The value to set for the WorkflowExecutionFailedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithWorkflowExecutionFailedEventAttributes(WorkflowExecutionFailedEventAttributes workflowExecutionFailedEventAttributes)
        {
            this.workflowExecutionFailedEventAttributes = workflowExecutionFailedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the FailWorkflowExecutionFailedEventAttributes property
        /// </summary>
        /// <param name="failWorkflowExecutionFailedEventAttributes">The value to set for the FailWorkflowExecutionFailedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithFailWorkflowExecutionFailedEventAttributes(FailWorkflowExecutionFailedEventAttributes failWorkflowExecutionFailedEventAttributes)
        {
            this.failWorkflowExecutionFailedEventAttributes = failWorkflowExecutionFailedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the WorkflowExecutionTimedOutEventAttributes property
        /// </summary>
        /// <param name="workflowExecutionTimedOutEventAttributes">The value to set for the WorkflowExecutionTimedOutEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithWorkflowExecutionTimedOutEventAttributes(WorkflowExecutionTimedOutEventAttributes workflowExecutionTimedOutEventAttributes)
        {
            this.workflowExecutionTimedOutEventAttributes = workflowExecutionTimedOutEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the WorkflowExecutionCanceledEventAttributes property
        /// </summary>
        /// <param name="workflowExecutionCanceledEventAttributes">The value to set for the WorkflowExecutionCanceledEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithWorkflowExecutionCanceledEventAttributes(WorkflowExecutionCanceledEventAttributes workflowExecutionCanceledEventAttributes)
        {
            this.workflowExecutionCanceledEventAttributes = workflowExecutionCanceledEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the CancelWorkflowExecutionFailedEventAttributes property
        /// </summary>
        /// <param name="cancelWorkflowExecutionFailedEventAttributes">The value to set for the CancelWorkflowExecutionFailedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithCancelWorkflowExecutionFailedEventAttributes(CancelWorkflowExecutionFailedEventAttributes cancelWorkflowExecutionFailedEventAttributes)
        {
            this.cancelWorkflowExecutionFailedEventAttributes = cancelWorkflowExecutionFailedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the WorkflowExecutionContinuedAsNewEventAttributes property
        /// </summary>
        /// <param name="workflowExecutionContinuedAsNewEventAttributes">The value to set for the WorkflowExecutionContinuedAsNewEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithWorkflowExecutionContinuedAsNewEventAttributes(WorkflowExecutionContinuedAsNewEventAttributes workflowExecutionContinuedAsNewEventAttributes)
        {
            this.workflowExecutionContinuedAsNewEventAttributes = workflowExecutionContinuedAsNewEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ContinueAsNewWorkflowExecutionFailedEventAttributes property
        /// </summary>
        /// <param name="continueAsNewWorkflowExecutionFailedEventAttributes">The value to set for the ContinueAsNewWorkflowExecutionFailedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithContinueAsNewWorkflowExecutionFailedEventAttributes(ContinueAsNewWorkflowExecutionFailedEventAttributes continueAsNewWorkflowExecutionFailedEventAttributes)
        {
            this.continueAsNewWorkflowExecutionFailedEventAttributes = continueAsNewWorkflowExecutionFailedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the WorkflowExecutionTerminatedEventAttributes property
        /// </summary>
        /// <param name="workflowExecutionTerminatedEventAttributes">The value to set for the WorkflowExecutionTerminatedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithWorkflowExecutionTerminatedEventAttributes(WorkflowExecutionTerminatedEventAttributes workflowExecutionTerminatedEventAttributes)
        {
            this.workflowExecutionTerminatedEventAttributes = workflowExecutionTerminatedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the WorkflowExecutionCancelRequestedEventAttributes property
        /// </summary>
        /// <param name="workflowExecutionCancelRequestedEventAttributes">The value to set for the WorkflowExecutionCancelRequestedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithWorkflowExecutionCancelRequestedEventAttributes(WorkflowExecutionCancelRequestedEventAttributes workflowExecutionCancelRequestedEventAttributes)
        {
            this.workflowExecutionCancelRequestedEventAttributes = workflowExecutionCancelRequestedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the DecisionTaskScheduledEventAttributes property
        /// </summary>
        /// <param name="decisionTaskScheduledEventAttributes">The value to set for the DecisionTaskScheduledEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithDecisionTaskScheduledEventAttributes(DecisionTaskScheduledEventAttributes decisionTaskScheduledEventAttributes)
        {
            this.decisionTaskScheduledEventAttributes = decisionTaskScheduledEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the DecisionTaskStartedEventAttributes property
        /// </summary>
        /// <param name="decisionTaskStartedEventAttributes">The value to set for the DecisionTaskStartedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithDecisionTaskStartedEventAttributes(DecisionTaskStartedEventAttributes decisionTaskStartedEventAttributes)
        {
            this.decisionTaskStartedEventAttributes = decisionTaskStartedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the DecisionTaskCompletedEventAttributes property
        /// </summary>
        /// <param name="decisionTaskCompletedEventAttributes">The value to set for the DecisionTaskCompletedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithDecisionTaskCompletedEventAttributes(DecisionTaskCompletedEventAttributes decisionTaskCompletedEventAttributes)
        {
            this.decisionTaskCompletedEventAttributes = decisionTaskCompletedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the DecisionTaskTimedOutEventAttributes property
        /// </summary>
        /// <param name="decisionTaskTimedOutEventAttributes">The value to set for the DecisionTaskTimedOutEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithDecisionTaskTimedOutEventAttributes(DecisionTaskTimedOutEventAttributes decisionTaskTimedOutEventAttributes)
        {
            this.decisionTaskTimedOutEventAttributes = decisionTaskTimedOutEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ActivityTaskScheduledEventAttributes property
        /// </summary>
        /// <param name="activityTaskScheduledEventAttributes">The value to set for the ActivityTaskScheduledEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithActivityTaskScheduledEventAttributes(ActivityTaskScheduledEventAttributes activityTaskScheduledEventAttributes)
        {
            this.activityTaskScheduledEventAttributes = activityTaskScheduledEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ActivityTaskStartedEventAttributes property
        /// </summary>
        /// <param name="activityTaskStartedEventAttributes">The value to set for the ActivityTaskStartedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithActivityTaskStartedEventAttributes(ActivityTaskStartedEventAttributes activityTaskStartedEventAttributes)
        {
            this.activityTaskStartedEventAttributes = activityTaskStartedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ActivityTaskCompletedEventAttributes property
        /// </summary>
        /// <param name="activityTaskCompletedEventAttributes">The value to set for the ActivityTaskCompletedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithActivityTaskCompletedEventAttributes(ActivityTaskCompletedEventAttributes activityTaskCompletedEventAttributes)
        {
            this.activityTaskCompletedEventAttributes = activityTaskCompletedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ActivityTaskFailedEventAttributes property
        /// </summary>
        /// <param name="activityTaskFailedEventAttributes">The value to set for the ActivityTaskFailedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithActivityTaskFailedEventAttributes(ActivityTaskFailedEventAttributes activityTaskFailedEventAttributes)
        {
            this.activityTaskFailedEventAttributes = activityTaskFailedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ActivityTaskTimedOutEventAttributes property
        /// </summary>
        /// <param name="activityTaskTimedOutEventAttributes">The value to set for the ActivityTaskTimedOutEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithActivityTaskTimedOutEventAttributes(ActivityTaskTimedOutEventAttributes activityTaskTimedOutEventAttributes)
        {
            this.activityTaskTimedOutEventAttributes = activityTaskTimedOutEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ActivityTaskCanceledEventAttributes property
        /// </summary>
        /// <param name="activityTaskCanceledEventAttributes">The value to set for the ActivityTaskCanceledEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithActivityTaskCanceledEventAttributes(ActivityTaskCanceledEventAttributes activityTaskCanceledEventAttributes)
        {
            this.activityTaskCanceledEventAttributes = activityTaskCanceledEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ActivityTaskCancelRequestedEventAttributes property
        /// </summary>
        /// <param name="activityTaskCancelRequestedEventAttributes">The value to set for the ActivityTaskCancelRequestedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithActivityTaskCancelRequestedEventAttributes(ActivityTaskCancelRequestedEventAttributes activityTaskCancelRequestedEventAttributes)
        {
            this.activityTaskCancelRequestedEventAttributes = activityTaskCancelRequestedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the WorkflowExecutionSignaledEventAttributes property
        /// </summary>
        /// <param name="workflowExecutionSignaledEventAttributes">The value to set for the WorkflowExecutionSignaledEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithWorkflowExecutionSignaledEventAttributes(WorkflowExecutionSignaledEventAttributes workflowExecutionSignaledEventAttributes)
        {
            this.workflowExecutionSignaledEventAttributes = workflowExecutionSignaledEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the MarkerRecordedEventAttributes property
        /// </summary>
        /// <param name="markerRecordedEventAttributes">The value to set for the MarkerRecordedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithMarkerRecordedEventAttributes(MarkerRecordedEventAttributes markerRecordedEventAttributes)
        {
            this.markerRecordedEventAttributes = markerRecordedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the RecordMarkerFailedEventAttributes property
        /// </summary>
        /// <param name="recordMarkerFailedEventAttributes">The value to set for the RecordMarkerFailedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithRecordMarkerFailedEventAttributes(RecordMarkerFailedEventAttributes recordMarkerFailedEventAttributes)
        {
            this.recordMarkerFailedEventAttributes = recordMarkerFailedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the TimerStartedEventAttributes property
        /// </summary>
        /// <param name="timerStartedEventAttributes">The value to set for the TimerStartedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithTimerStartedEventAttributes(TimerStartedEventAttributes timerStartedEventAttributes)
        {
            this.timerStartedEventAttributes = timerStartedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the TimerFiredEventAttributes property
        /// </summary>
        /// <param name="timerFiredEventAttributes">The value to set for the TimerFiredEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithTimerFiredEventAttributes(TimerFiredEventAttributes timerFiredEventAttributes)
        {
            this.timerFiredEventAttributes = timerFiredEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the TimerCanceledEventAttributes property
        /// </summary>
        /// <param name="timerCanceledEventAttributes">The value to set for the TimerCanceledEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithTimerCanceledEventAttributes(TimerCanceledEventAttributes timerCanceledEventAttributes)
        {
            this.timerCanceledEventAttributes = timerCanceledEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the StartChildWorkflowExecutionInitiatedEventAttributes property
        /// </summary>
        /// <param name="startChildWorkflowExecutionInitiatedEventAttributes">The value to set for the StartChildWorkflowExecutionInitiatedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithStartChildWorkflowExecutionInitiatedEventAttributes(StartChildWorkflowExecutionInitiatedEventAttributes startChildWorkflowExecutionInitiatedEventAttributes)
        {
            this.startChildWorkflowExecutionInitiatedEventAttributes = startChildWorkflowExecutionInitiatedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ChildWorkflowExecutionStartedEventAttributes property
        /// </summary>
        /// <param name="childWorkflowExecutionStartedEventAttributes">The value to set for the ChildWorkflowExecutionStartedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithChildWorkflowExecutionStartedEventAttributes(ChildWorkflowExecutionStartedEventAttributes childWorkflowExecutionStartedEventAttributes)
        {
            this.childWorkflowExecutionStartedEventAttributes = childWorkflowExecutionStartedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ChildWorkflowExecutionCompletedEventAttributes property
        /// </summary>
        /// <param name="childWorkflowExecutionCompletedEventAttributes">The value to set for the ChildWorkflowExecutionCompletedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithChildWorkflowExecutionCompletedEventAttributes(ChildWorkflowExecutionCompletedEventAttributes childWorkflowExecutionCompletedEventAttributes)
        {
            this.childWorkflowExecutionCompletedEventAttributes = childWorkflowExecutionCompletedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ChildWorkflowExecutionFailedEventAttributes property
        /// </summary>
        /// <param name="childWorkflowExecutionFailedEventAttributes">The value to set for the ChildWorkflowExecutionFailedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithChildWorkflowExecutionFailedEventAttributes(ChildWorkflowExecutionFailedEventAttributes childWorkflowExecutionFailedEventAttributes)
        {
            this.childWorkflowExecutionFailedEventAttributes = childWorkflowExecutionFailedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ChildWorkflowExecutionTimedOutEventAttributes property
        /// </summary>
        /// <param name="childWorkflowExecutionTimedOutEventAttributes">The value to set for the ChildWorkflowExecutionTimedOutEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithChildWorkflowExecutionTimedOutEventAttributes(ChildWorkflowExecutionTimedOutEventAttributes childWorkflowExecutionTimedOutEventAttributes)
        {
            this.childWorkflowExecutionTimedOutEventAttributes = childWorkflowExecutionTimedOutEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ChildWorkflowExecutionCanceledEventAttributes property
        /// </summary>
        /// <param name="childWorkflowExecutionCanceledEventAttributes">The value to set for the ChildWorkflowExecutionCanceledEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithChildWorkflowExecutionCanceledEventAttributes(ChildWorkflowExecutionCanceledEventAttributes childWorkflowExecutionCanceledEventAttributes)
        {
            this.childWorkflowExecutionCanceledEventAttributes = childWorkflowExecutionCanceledEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ChildWorkflowExecutionTerminatedEventAttributes property
        /// </summary>
        /// <param name="childWorkflowExecutionTerminatedEventAttributes">The value to set for the ChildWorkflowExecutionTerminatedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithChildWorkflowExecutionTerminatedEventAttributes(ChildWorkflowExecutionTerminatedEventAttributes childWorkflowExecutionTerminatedEventAttributes)
        {
            this.childWorkflowExecutionTerminatedEventAttributes = childWorkflowExecutionTerminatedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the SignalExternalWorkflowExecutionInitiatedEventAttributes property
        /// </summary>
        /// <param name="signalExternalWorkflowExecutionInitiatedEventAttributes">The value to set for the SignalExternalWorkflowExecutionInitiatedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithSignalExternalWorkflowExecutionInitiatedEventAttributes(SignalExternalWorkflowExecutionInitiatedEventAttributes signalExternalWorkflowExecutionInitiatedEventAttributes)
        {
            this.signalExternalWorkflowExecutionInitiatedEventAttributes = signalExternalWorkflowExecutionInitiatedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ExternalWorkflowExecutionSignaledEventAttributes property
        /// </summary>
        /// <param name="externalWorkflowExecutionSignaledEventAttributes">The value to set for the ExternalWorkflowExecutionSignaledEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithExternalWorkflowExecutionSignaledEventAttributes(ExternalWorkflowExecutionSignaledEventAttributes externalWorkflowExecutionSignaledEventAttributes)
        {
            this.externalWorkflowExecutionSignaledEventAttributes = externalWorkflowExecutionSignaledEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the SignalExternalWorkflowExecutionFailedEventAttributes property
        /// </summary>
        /// <param name="signalExternalWorkflowExecutionFailedEventAttributes">The value to set for the SignalExternalWorkflowExecutionFailedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithSignalExternalWorkflowExecutionFailedEventAttributes(SignalExternalWorkflowExecutionFailedEventAttributes signalExternalWorkflowExecutionFailedEventAttributes)
        {
            this.signalExternalWorkflowExecutionFailedEventAttributes = signalExternalWorkflowExecutionFailedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ExternalWorkflowExecutionCancelRequestedEventAttributes property
        /// </summary>
        /// <param name="externalWorkflowExecutionCancelRequestedEventAttributes">The value to set for the ExternalWorkflowExecutionCancelRequestedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithExternalWorkflowExecutionCancelRequestedEventAttributes(ExternalWorkflowExecutionCancelRequestedEventAttributes externalWorkflowExecutionCancelRequestedEventAttributes)
        {
            this.externalWorkflowExecutionCancelRequestedEventAttributes = externalWorkflowExecutionCancelRequestedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the RequestCancelExternalWorkflowExecutionInitiatedEventAttributes property
        /// </summary>
        /// <param name="requestCancelExternalWorkflowExecutionInitiatedEventAttributes">The value to set for the RequestCancelExternalWorkflowExecutionInitiatedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithRequestCancelExternalWorkflowExecutionInitiatedEventAttributes(RequestCancelExternalWorkflowExecutionInitiatedEventAttributes requestCancelExternalWorkflowExecutionInitiatedEventAttributes)
        {
            this.requestCancelExternalWorkflowExecutionInitiatedEventAttributes = requestCancelExternalWorkflowExecutionInitiatedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the RequestCancelExternalWorkflowExecutionFailedEventAttributes property
        /// </summary>
        /// <param name="requestCancelExternalWorkflowExecutionFailedEventAttributes">The value to set for the RequestCancelExternalWorkflowExecutionFailedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithRequestCancelExternalWorkflowExecutionFailedEventAttributes(RequestCancelExternalWorkflowExecutionFailedEventAttributes requestCancelExternalWorkflowExecutionFailedEventAttributes)
        {
            this.requestCancelExternalWorkflowExecutionFailedEventAttributes = requestCancelExternalWorkflowExecutionFailedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the ScheduleActivityTaskFailedEventAttributes property
        /// </summary>
        /// <param name="scheduleActivityTaskFailedEventAttributes">The value to set for the ScheduleActivityTaskFailedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithScheduleActivityTaskFailedEventAttributes(ScheduleActivityTaskFailedEventAttributes scheduleActivityTaskFailedEventAttributes)
        {
            this.scheduleActivityTaskFailedEventAttributes = scheduleActivityTaskFailedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the RequestCancelActivityTaskFailedEventAttributes property
        /// </summary>
        /// <param name="requestCancelActivityTaskFailedEventAttributes">The value to set for the RequestCancelActivityTaskFailedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithRequestCancelActivityTaskFailedEventAttributes(RequestCancelActivityTaskFailedEventAttributes requestCancelActivityTaskFailedEventAttributes)
        {
            this.requestCancelActivityTaskFailedEventAttributes = requestCancelActivityTaskFailedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the StartTimerFailedEventAttributes property
        /// </summary>
        /// <param name="startTimerFailedEventAttributes">The value to set for the StartTimerFailedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithStartTimerFailedEventAttributes(StartTimerFailedEventAttributes startTimerFailedEventAttributes)
        {
            this.startTimerFailedEventAttributes = startTimerFailedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the CancelTimerFailedEventAttributes property
        /// </summary>
        /// <param name="cancelTimerFailedEventAttributes">The value to set for the CancelTimerFailedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithCancelTimerFailedEventAttributes(CancelTimerFailedEventAttributes cancelTimerFailedEventAttributes)
        {
            this.cancelTimerFailedEventAttributes = cancelTimerFailedEventAttributes;
            return this;
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

        /// <summary>
        /// Sets the StartChildWorkflowExecutionFailedEventAttributes property
        /// </summary>
        /// <param name="startChildWorkflowExecutionFailedEventAttributes">The value to set for the StartChildWorkflowExecutionFailedEventAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HistoryEvent WithStartChildWorkflowExecutionFailedEventAttributes(StartChildWorkflowExecutionFailedEventAttributes startChildWorkflowExecutionFailedEventAttributes)
        {
            this.startChildWorkflowExecutionFailedEventAttributes = startChildWorkflowExecutionFailedEventAttributes;
            return this;
        }
            

        // Check to see if StartChildWorkflowExecutionFailedEventAttributes property is set
        internal bool IsSetStartChildWorkflowExecutionFailedEventAttributes()
        {
            return this.startChildWorkflowExecutionFailedEventAttributes != null;
        }
    }
}
