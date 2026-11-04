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
        /// <summary>
        /// Gets and sets the property ActivityTaskCancelRequestedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ActivityTaskcancelRequested</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ActivityTaskCancelRequestedEventAttributes ActivityTaskCancelRequestedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ActivityTaskCancelRequestedEventAttributes property is set.
        /// </summary>
        internal bool IsSetActivityTaskCancelRequestedEventAttributes() => this.ActivityTaskCancelRequestedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ActivityTaskCanceledEventAttributes. 
        /// <para>
        /// If the event is of type <c>ActivityTaskCanceled</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ActivityTaskCanceledEventAttributes ActivityTaskCanceledEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ActivityTaskCanceledEventAttributes property is set.
        /// </summary>
        internal bool IsSetActivityTaskCanceledEventAttributes() => this.ActivityTaskCanceledEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ActivityTaskCompletedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ActivityTaskCompleted</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ActivityTaskCompletedEventAttributes ActivityTaskCompletedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ActivityTaskCompletedEventAttributes property is set.
        /// </summary>
        internal bool IsSetActivityTaskCompletedEventAttributes() => this.ActivityTaskCompletedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ActivityTaskFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ActivityTaskFailed</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ActivityTaskFailedEventAttributes ActivityTaskFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ActivityTaskFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetActivityTaskFailedEventAttributes() => this.ActivityTaskFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ActivityTaskScheduledEventAttributes. 
        /// <para>
        /// If the event is of type <c>ActivityTaskScheduled</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ActivityTaskScheduledEventAttributes ActivityTaskScheduledEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ActivityTaskScheduledEventAttributes property is set.
        /// </summary>
        internal bool IsSetActivityTaskScheduledEventAttributes() => this.ActivityTaskScheduledEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ActivityTaskStartedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ActivityTaskStarted</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ActivityTaskStartedEventAttributes ActivityTaskStartedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ActivityTaskStartedEventAttributes property is set.
        /// </summary>
        internal bool IsSetActivityTaskStartedEventAttributes() => this.ActivityTaskStartedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ActivityTaskTimedOutEventAttributes. 
        /// <para>
        /// If the event is of type <c>ActivityTaskTimedOut</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ActivityTaskTimedOutEventAttributes ActivityTaskTimedOutEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ActivityTaskTimedOutEventAttributes property is set.
        /// </summary>
        internal bool IsSetActivityTaskTimedOutEventAttributes() => this.ActivityTaskTimedOutEventAttributes != null;

        /// <summary>
        /// Gets and sets the property CancelTimerFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>CancelTimerFailed</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public CancelTimerFailedEventAttributes CancelTimerFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the CancelTimerFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetCancelTimerFailedEventAttributes() => this.CancelTimerFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property CancelWorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>CancelWorkflowExecutionFailed</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public CancelWorkflowExecutionFailedEventAttributes CancelWorkflowExecutionFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the CancelWorkflowExecutionFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetCancelWorkflowExecutionFailedEventAttributes() => this.CancelWorkflowExecutionFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ChildWorkflowExecutionCanceledEventAttributes. 
        /// <para>
        /// If the event is of type <c>ChildWorkflowExecutionCanceled</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public ChildWorkflowExecutionCanceledEventAttributes ChildWorkflowExecutionCanceledEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ChildWorkflowExecutionCanceledEventAttributes property is set.
        /// </summary>
        internal bool IsSetChildWorkflowExecutionCanceledEventAttributes() => this.ChildWorkflowExecutionCanceledEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ChildWorkflowExecutionCompletedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ChildWorkflowExecutionCompleted</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public ChildWorkflowExecutionCompletedEventAttributes ChildWorkflowExecutionCompletedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ChildWorkflowExecutionCompletedEventAttributes property is set.
        /// </summary>
        internal bool IsSetChildWorkflowExecutionCompletedEventAttributes() => this.ChildWorkflowExecutionCompletedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ChildWorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ChildWorkflowExecutionFailed</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ChildWorkflowExecutionFailedEventAttributes ChildWorkflowExecutionFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ChildWorkflowExecutionFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetChildWorkflowExecutionFailedEventAttributes() => this.ChildWorkflowExecutionFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ChildWorkflowExecutionStartedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ChildWorkflowExecutionStarted</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ChildWorkflowExecutionStartedEventAttributes ChildWorkflowExecutionStartedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ChildWorkflowExecutionStartedEventAttributes property is set.
        /// </summary>
        internal bool IsSetChildWorkflowExecutionStartedEventAttributes() => this.ChildWorkflowExecutionStartedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ChildWorkflowExecutionTerminatedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ChildWorkflowExecutionTerminated</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public ChildWorkflowExecutionTerminatedEventAttributes ChildWorkflowExecutionTerminatedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ChildWorkflowExecutionTerminatedEventAttributes property is set.
        /// </summary>
        internal bool IsSetChildWorkflowExecutionTerminatedEventAttributes() => this.ChildWorkflowExecutionTerminatedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ChildWorkflowExecutionTimedOutEventAttributes. 
        /// <para>
        /// If the event is of type <c>ChildWorkflowExecutionTimedOut</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public ChildWorkflowExecutionTimedOutEventAttributes ChildWorkflowExecutionTimedOutEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ChildWorkflowExecutionTimedOutEventAttributes property is set.
        /// </summary>
        internal bool IsSetChildWorkflowExecutionTimedOutEventAttributes() => this.ChildWorkflowExecutionTimedOutEventAttributes != null;

        /// <summary>
        /// Gets and sets the property CompleteWorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>CompleteWorkflowExecutionFailed</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public CompleteWorkflowExecutionFailedEventAttributes CompleteWorkflowExecutionFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the CompleteWorkflowExecutionFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetCompleteWorkflowExecutionFailedEventAttributes() => this.CompleteWorkflowExecutionFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ContinueAsNewWorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ContinueAsNewWorkflowExecutionFailed</c> then this member
        /// is set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public ContinueAsNewWorkflowExecutionFailedEventAttributes ContinueAsNewWorkflowExecutionFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ContinueAsNewWorkflowExecutionFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetContinueAsNewWorkflowExecutionFailedEventAttributes() => this.ContinueAsNewWorkflowExecutionFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property DecisionTaskCompletedEventAttributes. 
        /// <para>
        /// If the event is of type <c>DecisionTaskCompleted</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public DecisionTaskCompletedEventAttributes DecisionTaskCompletedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the DecisionTaskCompletedEventAttributes property is set.
        /// </summary>
        internal bool IsSetDecisionTaskCompletedEventAttributes() => this.DecisionTaskCompletedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property DecisionTaskScheduledEventAttributes. 
        /// <para>
        /// If the event is of type <c>DecisionTaskScheduled</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public DecisionTaskScheduledEventAttributes DecisionTaskScheduledEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the DecisionTaskScheduledEventAttributes property is set.
        /// </summary>
        internal bool IsSetDecisionTaskScheduledEventAttributes() => this.DecisionTaskScheduledEventAttributes != null;

        /// <summary>
        /// Gets and sets the property DecisionTaskStartedEventAttributes. 
        /// <para>
        /// If the event is of type <c>DecisionTaskStarted</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public DecisionTaskStartedEventAttributes DecisionTaskStartedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the DecisionTaskStartedEventAttributes property is set.
        /// </summary>
        internal bool IsSetDecisionTaskStartedEventAttributes() => this.DecisionTaskStartedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property DecisionTaskTimedOutEventAttributes. 
        /// <para>
        /// If the event is of type <c>DecisionTaskTimedOut</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public DecisionTaskTimedOutEventAttributes DecisionTaskTimedOutEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the DecisionTaskTimedOutEventAttributes property is set.
        /// </summary>
        internal bool IsSetDecisionTaskTimedOutEventAttributes() => this.DecisionTaskTimedOutEventAttributes != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The system generated ID of the event. This ID uniquely identifies the event with in
        /// the workflow execution history.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId.HasValue;

        /// <summary>
        /// Gets and sets the property EventTimestamp. 
        /// <para>
        /// The date and time when the event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EventTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EventTimestamp property is set.
        /// </summary>
        internal bool IsSetEventTimestamp() => this.EventTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of the history event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property ExternalWorkflowExecutionCancelRequestedEventAttributes.
        /// 
        /// <para>
        /// If the event is of type <c>ExternalWorkflowExecutionCancelRequested</c> then this
        /// member is set and provides detailed information about the event. It isn't set for
        /// other event types. 
        /// </para>
        /// </summary>
        public ExternalWorkflowExecutionCancelRequestedEventAttributes ExternalWorkflowExecutionCancelRequestedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ExternalWorkflowExecutionCancelRequestedEventAttributes property is set.
        /// </summary>
        internal bool IsSetExternalWorkflowExecutionCancelRequestedEventAttributes() => this.ExternalWorkflowExecutionCancelRequestedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ExternalWorkflowExecutionSignaledEventAttributes. 
        /// <para>
        /// If the event is of type <c>ExternalWorkflowExecutionSignaled</c> then this member
        /// is set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public ExternalWorkflowExecutionSignaledEventAttributes ExternalWorkflowExecutionSignaledEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ExternalWorkflowExecutionSignaledEventAttributes property is set.
        /// </summary>
        internal bool IsSetExternalWorkflowExecutionSignaledEventAttributes() => this.ExternalWorkflowExecutionSignaledEventAttributes != null;

        /// <summary>
        /// Gets and sets the property FailWorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>FailWorkflowExecutionFailed</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public FailWorkflowExecutionFailedEventAttributes FailWorkflowExecutionFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the FailWorkflowExecutionFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetFailWorkflowExecutionFailedEventAttributes() => this.FailWorkflowExecutionFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionCompletedEventAttributes. 
        /// <para>
        /// Provides the details of the <c>LambdaFunctionCompleted</c> event. It isn't set for
        /// other event types.
        /// </para>
        /// </summary>
        public LambdaFunctionCompletedEventAttributes LambdaFunctionCompletedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionCompletedEventAttributes property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionCompletedEventAttributes() => this.LambdaFunctionCompletedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionFailedEventAttributes. 
        /// <para>
        /// Provides the details of the <c>LambdaFunctionFailed</c> event. It isn't set for other
        /// event types.
        /// </para>
        /// </summary>
        public LambdaFunctionFailedEventAttributes LambdaFunctionFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionFailedEventAttributes() => this.LambdaFunctionFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionScheduledEventAttributes. 
        /// <para>
        /// Provides the details of the <c>LambdaFunctionScheduled</c> event. It isn't set for
        /// other event types.
        /// </para>
        /// </summary>
        public LambdaFunctionScheduledEventAttributes LambdaFunctionScheduledEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionScheduledEventAttributes property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionScheduledEventAttributes() => this.LambdaFunctionScheduledEventAttributes != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionStartedEventAttributes. 
        /// <para>
        /// Provides the details of the <c>LambdaFunctionStarted</c> event. It isn't set for other
        /// event types.
        /// </para>
        /// </summary>
        public LambdaFunctionStartedEventAttributes LambdaFunctionStartedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionStartedEventAttributes property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionStartedEventAttributes() => this.LambdaFunctionStartedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionTimedOutEventAttributes. 
        /// <para>
        /// Provides the details of the <c>LambdaFunctionTimedOut</c> event. It isn't set for
        /// other event types.
        /// </para>
        /// </summary>
        public LambdaFunctionTimedOutEventAttributes LambdaFunctionTimedOutEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionTimedOutEventAttributes property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionTimedOutEventAttributes() => this.LambdaFunctionTimedOutEventAttributes != null;

        /// <summary>
        /// Gets and sets the property MarkerRecordedEventAttributes. 
        /// <para>
        /// If the event is of type <c>MarkerRecorded</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public MarkerRecordedEventAttributes MarkerRecordedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the MarkerRecordedEventAttributes property is set.
        /// </summary>
        internal bool IsSetMarkerRecordedEventAttributes() => this.MarkerRecordedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property RecordMarkerFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>DecisionTaskFailed</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public RecordMarkerFailedEventAttributes RecordMarkerFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the RecordMarkerFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetRecordMarkerFailedEventAttributes() => this.RecordMarkerFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property RequestCancelActivityTaskFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>RequestCancelActivityTaskFailed</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public RequestCancelActivityTaskFailedEventAttributes RequestCancelActivityTaskFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the RequestCancelActivityTaskFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetRequestCancelActivityTaskFailedEventAttributes() => this.RequestCancelActivityTaskFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property RequestCancelExternalWorkflowExecutionFailedEventAttributes.
        /// 
        /// <para>
        /// If the event is of type <c>RequestCancelExternalWorkflowExecutionFailed</c> then this
        /// member is set and provides detailed information about the event. It isn't set for
        /// other event types.
        /// </para>
        /// </summary>
        public RequestCancelExternalWorkflowExecutionFailedEventAttributes RequestCancelExternalWorkflowExecutionFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the RequestCancelExternalWorkflowExecutionFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetRequestCancelExternalWorkflowExecutionFailedEventAttributes() => this.RequestCancelExternalWorkflowExecutionFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property RequestCancelExternalWorkflowExecutionInitiatedEventAttributes.
        /// 
        /// <para>
        /// If the event is of type <c>RequestCancelExternalWorkflowExecutionInitiated</c> then
        /// this member is set and provides detailed information about the event. It isn't set
        /// for other event types.
        /// </para>
        /// </summary>
        public RequestCancelExternalWorkflowExecutionInitiatedEventAttributes RequestCancelExternalWorkflowExecutionInitiatedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the RequestCancelExternalWorkflowExecutionInitiatedEventAttributes property is set.
        /// </summary>
        internal bool IsSetRequestCancelExternalWorkflowExecutionInitiatedEventAttributes() => this.RequestCancelExternalWorkflowExecutionInitiatedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ScheduleActivityTaskFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>ScheduleActivityTaskFailed</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public ScheduleActivityTaskFailedEventAttributes ScheduleActivityTaskFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleActivityTaskFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetScheduleActivityTaskFailedEventAttributes() => this.ScheduleActivityTaskFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property ScheduleLambdaFunctionFailedEventAttributes. 
        /// <para>
        /// Provides the details of the <c>ScheduleLambdaFunctionFailed</c> event. It isn't set
        /// for other event types.
        /// </para>
        /// </summary>
        public ScheduleLambdaFunctionFailedEventAttributes ScheduleLambdaFunctionFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleLambdaFunctionFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetScheduleLambdaFunctionFailedEventAttributes() => this.ScheduleLambdaFunctionFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property SignalExternalWorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>SignalExternalWorkflowExecutionFailed</c> then this member
        /// is set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public SignalExternalWorkflowExecutionFailedEventAttributes SignalExternalWorkflowExecutionFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the SignalExternalWorkflowExecutionFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetSignalExternalWorkflowExecutionFailedEventAttributes() => this.SignalExternalWorkflowExecutionFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property SignalExternalWorkflowExecutionInitiatedEventAttributes.
        /// 
        /// <para>
        /// If the event is of type <c>SignalExternalWorkflowExecutionInitiated</c> then this
        /// member is set and provides detailed information about the event. It isn't set for
        /// other event types.
        /// </para>
        /// </summary>
        public SignalExternalWorkflowExecutionInitiatedEventAttributes SignalExternalWorkflowExecutionInitiatedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the SignalExternalWorkflowExecutionInitiatedEventAttributes property is set.
        /// </summary>
        internal bool IsSetSignalExternalWorkflowExecutionInitiatedEventAttributes() => this.SignalExternalWorkflowExecutionInitiatedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property StartChildWorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>StartChildWorkflowExecutionFailed</c> then this member
        /// is set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public StartChildWorkflowExecutionFailedEventAttributes StartChildWorkflowExecutionFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the StartChildWorkflowExecutionFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetStartChildWorkflowExecutionFailedEventAttributes() => this.StartChildWorkflowExecutionFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property StartChildWorkflowExecutionInitiatedEventAttributes. 
        /// <para>
        /// If the event is of type <c>StartChildWorkflowExecutionInitiated</c> then this member
        /// is set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public StartChildWorkflowExecutionInitiatedEventAttributes StartChildWorkflowExecutionInitiatedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the StartChildWorkflowExecutionInitiatedEventAttributes property is set.
        /// </summary>
        internal bool IsSetStartChildWorkflowExecutionInitiatedEventAttributes() => this.StartChildWorkflowExecutionInitiatedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property StartLambdaFunctionFailedEventAttributes. 
        /// <para>
        /// Provides the details of the <c>StartLambdaFunctionFailed</c> event. It isn't set for
        /// other event types.
        /// </para>
        /// </summary>
        public StartLambdaFunctionFailedEventAttributes StartLambdaFunctionFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the StartLambdaFunctionFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetStartLambdaFunctionFailedEventAttributes() => this.StartLambdaFunctionFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property StartTimerFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>StartTimerFailed</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public StartTimerFailedEventAttributes StartTimerFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the StartTimerFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetStartTimerFailedEventAttributes() => this.StartTimerFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property TimerCanceledEventAttributes. 
        /// <para>
        /// If the event is of type <c>TimerCanceled</c> then this member is set and provides
        /// detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public TimerCanceledEventAttributes TimerCanceledEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the TimerCanceledEventAttributes property is set.
        /// </summary>
        internal bool IsSetTimerCanceledEventAttributes() => this.TimerCanceledEventAttributes != null;

        /// <summary>
        /// Gets and sets the property TimerFiredEventAttributes. 
        /// <para>
        /// If the event is of type <c>TimerFired</c> then this member is set and provides detailed
        /// information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public TimerFiredEventAttributes TimerFiredEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the TimerFiredEventAttributes property is set.
        /// </summary>
        internal bool IsSetTimerFiredEventAttributes() => this.TimerFiredEventAttributes != null;

        /// <summary>
        /// Gets and sets the property TimerStartedEventAttributes. 
        /// <para>
        /// If the event is of type <c>TimerStarted</c> then this member is set and provides detailed
        /// information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public TimerStartedEventAttributes TimerStartedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the TimerStartedEventAttributes property is set.
        /// </summary>
        internal bool IsSetTimerStartedEventAttributes() => this.TimerStartedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property WorkflowExecutionCancelRequestedEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionCancelRequested</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public WorkflowExecutionCancelRequestedEventAttributes WorkflowExecutionCancelRequestedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecutionCancelRequestedEventAttributes property is set.
        /// </summary>
        internal bool IsSetWorkflowExecutionCancelRequestedEventAttributes() => this.WorkflowExecutionCancelRequestedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property WorkflowExecutionCanceledEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionCanceled</c> then this member is set and
        /// provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public WorkflowExecutionCanceledEventAttributes WorkflowExecutionCanceledEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecutionCanceledEventAttributes property is set.
        /// </summary>
        internal bool IsSetWorkflowExecutionCanceledEventAttributes() => this.WorkflowExecutionCanceledEventAttributes != null;

        /// <summary>
        /// Gets and sets the property WorkflowExecutionCompletedEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionCompleted</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public WorkflowExecutionCompletedEventAttributes WorkflowExecutionCompletedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecutionCompletedEventAttributes property is set.
        /// </summary>
        internal bool IsSetWorkflowExecutionCompletedEventAttributes() => this.WorkflowExecutionCompletedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property WorkflowExecutionContinuedAsNewEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionContinuedAsNew</c> then this member is
        /// set and provides detailed information about the event. It isn't set for other event
        /// types.
        /// </para>
        /// </summary>
        public WorkflowExecutionContinuedAsNewEventAttributes WorkflowExecutionContinuedAsNewEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecutionContinuedAsNewEventAttributes property is set.
        /// </summary>
        internal bool IsSetWorkflowExecutionContinuedAsNewEventAttributes() => this.WorkflowExecutionContinuedAsNewEventAttributes != null;

        /// <summary>
        /// Gets and sets the property WorkflowExecutionFailedEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionFailed</c> then this member is set and
        /// provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public WorkflowExecutionFailedEventAttributes WorkflowExecutionFailedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecutionFailedEventAttributes property is set.
        /// </summary>
        internal bool IsSetWorkflowExecutionFailedEventAttributes() => this.WorkflowExecutionFailedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property WorkflowExecutionSignaledEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionSignaled</c> then this member is set and
        /// provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public WorkflowExecutionSignaledEventAttributes WorkflowExecutionSignaledEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecutionSignaledEventAttributes property is set.
        /// </summary>
        internal bool IsSetWorkflowExecutionSignaledEventAttributes() => this.WorkflowExecutionSignaledEventAttributes != null;

        /// <summary>
        /// Gets and sets the property WorkflowExecutionStartedEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionStarted</c> then this member is set and
        /// provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public WorkflowExecutionStartedEventAttributes WorkflowExecutionStartedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecutionStartedEventAttributes property is set.
        /// </summary>
        internal bool IsSetWorkflowExecutionStartedEventAttributes() => this.WorkflowExecutionStartedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property WorkflowExecutionTerminatedEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionTerminated</c> then this member is set
        /// and provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public WorkflowExecutionTerminatedEventAttributes WorkflowExecutionTerminatedEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecutionTerminatedEventAttributes property is set.
        /// </summary>
        internal bool IsSetWorkflowExecutionTerminatedEventAttributes() => this.WorkflowExecutionTerminatedEventAttributes != null;

        /// <summary>
        /// Gets and sets the property WorkflowExecutionTimedOutEventAttributes. 
        /// <para>
        /// If the event is of type <c>WorkflowExecutionTimedOut</c> then this member is set and
        /// provides detailed information about the event. It isn't set for other event types.
        /// </para>
        /// </summary>
        public WorkflowExecutionTimedOutEventAttributes WorkflowExecutionTimedOutEventAttributes { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecutionTimedOutEventAttributes property is set.
        /// </summary>
        internal bool IsSetWorkflowExecutionTimedOutEventAttributes() => this.WorkflowExecutionTimedOutEventAttributes != null;
    }
}
