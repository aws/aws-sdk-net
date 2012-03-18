/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Specifies a decision made by the decider. A decision can be one of these types: </para>
    /// <ul>
    /// <li> <b>ScheduleActivityTask</b> schedules an activity task.</li>
    /// <li> <b>RequestCancelActivityTask</b> attempts to cancel a previously scheduled activity task. If the activity task was scheduled but has
    /// not been assigned to a worker, then it will be canceled. If the activity task was already assigned to a worker, then the worker will be
    /// informed that cancellation has been requested in the response to RecordActivityTaskHeartbeat.</li>
    /// <li> <b>RecordMarker</b> records a <c>MarkerRecorded</c> event in the history. Markers can be used for adding custom information in the
    /// history for instance to let deciders know that they do not need to look at the history beyond the marker event.</li>
    /// <li> <b>CompleteWorkflowExecution</b> closes the workflow execution and records a <c>WorkflowExecutionCompleted</c> event in the history
    /// .</li>
    /// <li> <b>FailWorkflowExecution</b> closes the workflow execution and records a <c>WorkflowExecutionFailed</c> event in the history.</li>
    /// <li> <b>CancelWorkflowExecution</b> closes the workflow execution and records a <c>WorkflowExecutionCanceled</c> event in the history.</li>
    /// <li> <b>ContinueAsNewWorkflowExecution</b> closes the workflow execution and starts a new workflow execution of the same type using the
    /// same workflow id and a unique run Id. A <c>WorkflowExecutionContinuedAsNew</c> event is recorded in the history.</li>
    /// <li> <b>StartTimer</b> starts a timer for this workflow execution and records a <c>TimerStarted</c> event in the history. This timer will
    /// fire after the specified delay and record a <c>TimerFired</c> event.</li>
    /// <li> <b>CancelTimer</b> cancels a previously started timer and records a <c>TimerCanceled</c> event in the history.</li>
    /// <li> <b>SignalExternalWorkflowExecution</b> requests a signal to be delivered to the specified external workflow execution and records a
    /// <c>SignalExternalWorkflowExecutionInitiated</c> event in the history.</li>
    /// <li> <b>RequestCancelExternalWorkflowExecution</b> requests that a request be made to cancel the specified external workflow execution and
    /// records a <c>RequestCancelExternalWorkflowExecutionInitiated</c> event in the history.</li>
    /// <li> <b>StartChildWorkflowExecution</b> requests that a child workflow execution be started and records a
    /// <c>StartChildWorkflowExecutionInitiated</c> event in the history. The child workflow execution is a separate workflow execution with its own
    /// history.</li>
    /// 
    /// </ul>
    /// <para> The ordering of decisions should follow a logical flow. Some decisions might not make sense in the current context of the workflow
    /// execution and will therefore fail. A decision might also fail due to a limit being reached on your account. One of the following events
    /// might be added to the history to indicate an error: </para>
    /// <ul>
    /// <li> <b>ScheduleActivityTaskFailed</b> a ScheduleActivityTask decision failed. This could happen if the activity type specified in the
    /// decision is not registered, is in a deprecated state, or the decision is not properly configured.</li>
    /// <li> <b>RequestCancelActivityTaskFailed</b> a RequestCancelActivityTask decision failed. This could happen if there is no open activity
    /// task with the specified activityId.</li>
    /// <li> <b>StartTimerFailed</b> a StartTimer decision failed. This could happen if there is another open timer with the same timerId.</li>
    /// <li> <b>CancelTimerFailed</b> a CancelTimer decision failed. This could happen if there is no open timer with the specified timerId.</li>
    /// <li> <b>StartChildWorkflowExecutionFailed</b> a StartChildWorkflowExecution decision failed. This could happen if the workflow type
    /// specified is not registered, is deprecated, or the decision is not properly configured.</li>
    /// <li> <b>SignalExternalWorkflowExecutionFailed</b> a SignalExternalWorkflowExecution decision failed. This could happen if the
    /// <c>workflowID</c> specified in the decision was incorrect. </li>
    /// <li> <b>RequestCancelExternalWorkflowExecutionFailed</b> a RequestCancelExternalWorkflowExecution decision failed. This could happen if the
    /// <c>workflowID</c> specified in the decision was incorrect. </li>
    /// <li> <b>CancelWorkflowExecutionFailed</b> a CancelWorkflowExecution decision failed. This could happen if there is an unhandled decision
    /// task pending in the workflow execution. </li>
    /// <li> <b>CompleteWorkflowExecutionFailed</b> a CompleteWorkflowExecution decision failed. This could happen if there is an unhandled
    /// decision task pending in the workflow execution. </li>
    /// <li> <b>ContinueAsNewWorkflowExecutionFailed</b> a ContinueAsNewWorkflowExecution decision failed. This could happen if there is an
    /// unhandled decision task pending in the workflow execution or the ContinueAsNewWorkflowExecution decision was not configured correctly. </li>
    /// <li> <b>FailWorkflowExecutionFailed</b> a FailWorkflowExecution decision failed. This could happen if there is an unhandled decision task
    /// pending in the workflow execution. </li>
    /// 
    /// </ul>
    /// <para> The preceding error events might occur due to an error in the decider logic, which might put the workflow execution in an unstable
    /// state The cause field in the event structure for the error event indicates the cause of the error. </para> <para><b>NOTE:</b> A workflow
    /// execution may be closed by the decider by returning one of the following decisions when completing a decision task:
    /// CompleteWorkflowExecution, FailWorkflowExecution, CancelWorkflowExecution and ContinueAsNewWorkflowExecution. An UnhandledDecision fault
    /// will be returned if a workflow closing decision is specified and a signal or activity event had been added to the history while the decision
    /// task was being performed by the decider. Unlike the above situations which are logic issues, this fault is always possible because of race
    /// conditions in a distributed system. The right action here is to call RespondDecisionTaskCompleted without any decisions. This would result
    /// in another decision task with these new events included in the history. The decider should handle the new events and may decide to close the
    /// workflow execution. </para> <para> You must code a decision by first setting the decision type field to one of the above decision values,
    /// and then set the corresponding attributes field shown below: </para>
    /// <ul>
    /// <li> ScheduleActivityTaskDecisionAttributes </li>
    /// <li> RequestCancelActivityTaskDecisionAttributes </li>
    /// <li> CompleteWorkflowExecutionDecisionAttributes </li>
    /// <li> FailWorkflowExecutionDecisionAttributes </li>
    /// <li> CancelWorkflowExecutionDecisionAttributes </li>
    /// <li> ContinueAsNewWorkflowExecutionDecisionAttributes </li>
    /// <li> RecordMarkerDecisionAttributes </li>
    /// <li> StartTimerDecisionAttributes </li>
    /// <li> CancelTimerDecisionAttributes </li>
    /// <li> SignalExternalWorkflowExecutionDecisionAttributes </li>
    /// <li> RequestCancelExternalWorkflowExecutionDecisionAttributes </li>
    /// <li> StartChildWorkflowExecutionDecisionAttributes </li>
    /// 
    /// </ul>
    /// </summary>
    public class Decision  
    {
        
        private string decisionType;
        private ScheduleActivityTaskDecisionAttributes scheduleActivityTaskDecisionAttributes;
        private RequestCancelActivityTaskDecisionAttributes requestCancelActivityTaskDecisionAttributes;
        private CompleteWorkflowExecutionDecisionAttributes completeWorkflowExecutionDecisionAttributes;
        private FailWorkflowExecutionDecisionAttributes failWorkflowExecutionDecisionAttributes;
        private CancelWorkflowExecutionDecisionAttributes cancelWorkflowExecutionDecisionAttributes;
        private ContinueAsNewWorkflowExecutionDecisionAttributes continueAsNewWorkflowExecutionDecisionAttributes;
        private RecordMarkerDecisionAttributes recordMarkerDecisionAttributes;
        private StartTimerDecisionAttributes startTimerDecisionAttributes;
        private CancelTimerDecisionAttributes cancelTimerDecisionAttributes;
        private SignalExternalWorkflowExecutionDecisionAttributes signalExternalWorkflowExecutionDecisionAttributes;
        private RequestCancelExternalWorkflowExecutionDecisionAttributes requestCancelExternalWorkflowExecutionDecisionAttributes;
        private StartChildWorkflowExecutionDecisionAttributes startChildWorkflowExecutionDecisionAttributes;

        /// <summary>
        /// Specifies the type of the decision.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ScheduleActivityTask, RequestCancelActivityTask, CompleteWorkflowExecution, FailWorkflowExecution, CancelWorkflowExecution, ContinueAsNewWorkflowExecution, RecordMarker, StartTimer, CancelTimer, SignalExternalWorkflowExecution, RequestCancelExternalWorkflowExecution, StartChildWorkflowExecution</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DecisionType
        {
            get { return this.decisionType; }
            set { this.decisionType = value; }
        }

        /// <summary>
        /// Sets the DecisionType property
        /// </summary>
        /// <param name="decisionType">The value to set for the DecisionType property </param>
        /// <returns>this instance</returns>
        public Decision WithDecisionType(string decisionType)
        {
            this.decisionType = decisionType;
            return this;
        }
            

        // Check to see if DecisionType property is set
        internal bool IsSetDecisionType()
        {
            return this.decisionType != null;       
        }

        /// <summary>
        /// Provides details of the <c>ScheduleActivityTask</c> decision. It is not set for other decision types.
        ///  
        /// </summary>
        public ScheduleActivityTaskDecisionAttributes ScheduleActivityTaskDecisionAttributes
        {
            get { return this.scheduleActivityTaskDecisionAttributes; }
            set { this.scheduleActivityTaskDecisionAttributes = value; }
        }

        /// <summary>
        /// Sets the ScheduleActivityTaskDecisionAttributes property
        /// </summary>
        /// <param name="scheduleActivityTaskDecisionAttributes">The value to set for the ScheduleActivityTaskDecisionAttributes property </param>
        /// <returns>this instance</returns>
        public Decision WithScheduleActivityTaskDecisionAttributes(ScheduleActivityTaskDecisionAttributes scheduleActivityTaskDecisionAttributes)
        {
            this.scheduleActivityTaskDecisionAttributes = scheduleActivityTaskDecisionAttributes;
            return this;
        }
            

        // Check to see if ScheduleActivityTaskDecisionAttributes property is set
        internal bool IsSetScheduleActivityTaskDecisionAttributes()
        {
            return this.scheduleActivityTaskDecisionAttributes != null;       
        }

        /// <summary>
        /// Provides details of the <c>RequestCancelActivityTask</c> decision. It is not set for other decision types.
        ///  
        /// </summary>
        public RequestCancelActivityTaskDecisionAttributes RequestCancelActivityTaskDecisionAttributes
        {
            get { return this.requestCancelActivityTaskDecisionAttributes; }
            set { this.requestCancelActivityTaskDecisionAttributes = value; }
        }

        /// <summary>
        /// Sets the RequestCancelActivityTaskDecisionAttributes property
        /// </summary>
        /// <param name="requestCancelActivityTaskDecisionAttributes">The value to set for the RequestCancelActivityTaskDecisionAttributes property </param>
        /// <returns>this instance</returns>
        public Decision WithRequestCancelActivityTaskDecisionAttributes(RequestCancelActivityTaskDecisionAttributes requestCancelActivityTaskDecisionAttributes)
        {
            this.requestCancelActivityTaskDecisionAttributes = requestCancelActivityTaskDecisionAttributes;
            return this;
        }
            

        // Check to see if RequestCancelActivityTaskDecisionAttributes property is set
        internal bool IsSetRequestCancelActivityTaskDecisionAttributes()
        {
            return this.requestCancelActivityTaskDecisionAttributes != null;       
        }

        /// <summary>
        /// Provides details of the <c>CompleteWorkflowExecution</c> decision. It is not set for other decision types.
        ///  
        /// </summary>
        public CompleteWorkflowExecutionDecisionAttributes CompleteWorkflowExecutionDecisionAttributes
        {
            get { return this.completeWorkflowExecutionDecisionAttributes; }
            set { this.completeWorkflowExecutionDecisionAttributes = value; }
        }

        /// <summary>
        /// Sets the CompleteWorkflowExecutionDecisionAttributes property
        /// </summary>
        /// <param name="completeWorkflowExecutionDecisionAttributes">The value to set for the CompleteWorkflowExecutionDecisionAttributes property </param>
        /// <returns>this instance</returns>
        public Decision WithCompleteWorkflowExecutionDecisionAttributes(CompleteWorkflowExecutionDecisionAttributes completeWorkflowExecutionDecisionAttributes)
        {
            this.completeWorkflowExecutionDecisionAttributes = completeWorkflowExecutionDecisionAttributes;
            return this;
        }
            

        // Check to see if CompleteWorkflowExecutionDecisionAttributes property is set
        internal bool IsSetCompleteWorkflowExecutionDecisionAttributes()
        {
            return this.completeWorkflowExecutionDecisionAttributes != null;       
        }

        /// <summary>
        /// Provides details of the <c>FailWorkflowExecution</c> decision. It is not set for other decision types.
        ///  
        /// </summary>
        public FailWorkflowExecutionDecisionAttributes FailWorkflowExecutionDecisionAttributes
        {
            get { return this.failWorkflowExecutionDecisionAttributes; }
            set { this.failWorkflowExecutionDecisionAttributes = value; }
        }

        /// <summary>
        /// Sets the FailWorkflowExecutionDecisionAttributes property
        /// </summary>
        /// <param name="failWorkflowExecutionDecisionAttributes">The value to set for the FailWorkflowExecutionDecisionAttributes property </param>
        /// <returns>this instance</returns>
        public Decision WithFailWorkflowExecutionDecisionAttributes(FailWorkflowExecutionDecisionAttributes failWorkflowExecutionDecisionAttributes)
        {
            this.failWorkflowExecutionDecisionAttributes = failWorkflowExecutionDecisionAttributes;
            return this;
        }
            

        // Check to see if FailWorkflowExecutionDecisionAttributes property is set
        internal bool IsSetFailWorkflowExecutionDecisionAttributes()
        {
            return this.failWorkflowExecutionDecisionAttributes != null;       
        }

        /// <summary>
        /// Provides details of the <c>CancelWorkflowExecution</c> decision. It is not set for other decision types.
        ///  
        /// </summary>
        public CancelWorkflowExecutionDecisionAttributes CancelWorkflowExecutionDecisionAttributes
        {
            get { return this.cancelWorkflowExecutionDecisionAttributes; }
            set { this.cancelWorkflowExecutionDecisionAttributes = value; }
        }

        /// <summary>
        /// Sets the CancelWorkflowExecutionDecisionAttributes property
        /// </summary>
        /// <param name="cancelWorkflowExecutionDecisionAttributes">The value to set for the CancelWorkflowExecutionDecisionAttributes property </param>
        /// <returns>this instance</returns>
        public Decision WithCancelWorkflowExecutionDecisionAttributes(CancelWorkflowExecutionDecisionAttributes cancelWorkflowExecutionDecisionAttributes)
        {
            this.cancelWorkflowExecutionDecisionAttributes = cancelWorkflowExecutionDecisionAttributes;
            return this;
        }
            

        // Check to see if CancelWorkflowExecutionDecisionAttributes property is set
        internal bool IsSetCancelWorkflowExecutionDecisionAttributes()
        {
            return this.cancelWorkflowExecutionDecisionAttributes != null;       
        }

        /// <summary>
        /// Provides details of the <c>ContinueAsNewWorkflowExecution</c> decision. It is not set for other decision types.
        ///  
        /// </summary>
        public ContinueAsNewWorkflowExecutionDecisionAttributes ContinueAsNewWorkflowExecutionDecisionAttributes
        {
            get { return this.continueAsNewWorkflowExecutionDecisionAttributes; }
            set { this.continueAsNewWorkflowExecutionDecisionAttributes = value; }
        }

        /// <summary>
        /// Sets the ContinueAsNewWorkflowExecutionDecisionAttributes property
        /// </summary>
        /// <param name="continueAsNewWorkflowExecutionDecisionAttributes">The value to set for the ContinueAsNewWorkflowExecutionDecisionAttributes property </param>
        /// <returns>this instance</returns>
        public Decision WithContinueAsNewWorkflowExecutionDecisionAttributes(ContinueAsNewWorkflowExecutionDecisionAttributes continueAsNewWorkflowExecutionDecisionAttributes)
        {
            this.continueAsNewWorkflowExecutionDecisionAttributes = continueAsNewWorkflowExecutionDecisionAttributes;
            return this;
        }
            

        // Check to see if ContinueAsNewWorkflowExecutionDecisionAttributes property is set
        internal bool IsSetContinueAsNewWorkflowExecutionDecisionAttributes()
        {
            return this.continueAsNewWorkflowExecutionDecisionAttributes != null;       
        }

        /// <summary>
        /// Provides details of the <c>RecordMarker</c> decision. It is not set for other decision types.
        ///  
        /// </summary>
        public RecordMarkerDecisionAttributes RecordMarkerDecisionAttributes
        {
            get { return this.recordMarkerDecisionAttributes; }
            set { this.recordMarkerDecisionAttributes = value; }
        }

        /// <summary>
        /// Sets the RecordMarkerDecisionAttributes property
        /// </summary>
        /// <param name="recordMarkerDecisionAttributes">The value to set for the RecordMarkerDecisionAttributes property </param>
        /// <returns>this instance</returns>
        public Decision WithRecordMarkerDecisionAttributes(RecordMarkerDecisionAttributes recordMarkerDecisionAttributes)
        {
            this.recordMarkerDecisionAttributes = recordMarkerDecisionAttributes;
            return this;
        }
            

        // Check to see if RecordMarkerDecisionAttributes property is set
        internal bool IsSetRecordMarkerDecisionAttributes()
        {
            return this.recordMarkerDecisionAttributes != null;       
        }

        /// <summary>
        /// Provides details of the <c>StartTimer</c> decision. It is not set for other decision types.
        ///  
        /// </summary>
        public StartTimerDecisionAttributes StartTimerDecisionAttributes
        {
            get { return this.startTimerDecisionAttributes; }
            set { this.startTimerDecisionAttributes = value; }
        }

        /// <summary>
        /// Sets the StartTimerDecisionAttributes property
        /// </summary>
        /// <param name="startTimerDecisionAttributes">The value to set for the StartTimerDecisionAttributes property </param>
        /// <returns>this instance</returns>
        public Decision WithStartTimerDecisionAttributes(StartTimerDecisionAttributes startTimerDecisionAttributes)
        {
            this.startTimerDecisionAttributes = startTimerDecisionAttributes;
            return this;
        }
            

        // Check to see if StartTimerDecisionAttributes property is set
        internal bool IsSetStartTimerDecisionAttributes()
        {
            return this.startTimerDecisionAttributes != null;       
        }

        /// <summary>
        /// Provides details of the <c>CancelTimer</c> decision. It is not set for other decision types.
        ///  
        /// </summary>
        public CancelTimerDecisionAttributes CancelTimerDecisionAttributes
        {
            get { return this.cancelTimerDecisionAttributes; }
            set { this.cancelTimerDecisionAttributes = value; }
        }

        /// <summary>
        /// Sets the CancelTimerDecisionAttributes property
        /// </summary>
        /// <param name="cancelTimerDecisionAttributes">The value to set for the CancelTimerDecisionAttributes property </param>
        /// <returns>this instance</returns>
        public Decision WithCancelTimerDecisionAttributes(CancelTimerDecisionAttributes cancelTimerDecisionAttributes)
        {
            this.cancelTimerDecisionAttributes = cancelTimerDecisionAttributes;
            return this;
        }
            

        // Check to see if CancelTimerDecisionAttributes property is set
        internal bool IsSetCancelTimerDecisionAttributes()
        {
            return this.cancelTimerDecisionAttributes != null;       
        }

        /// <summary>
        /// Provides details of the <c>SignalExternalWorkflowExecution</c> decision. It is not set for other decision types.
        ///  
        /// </summary>
        public SignalExternalWorkflowExecutionDecisionAttributes SignalExternalWorkflowExecutionDecisionAttributes
        {
            get { return this.signalExternalWorkflowExecutionDecisionAttributes; }
            set { this.signalExternalWorkflowExecutionDecisionAttributes = value; }
        }

        /// <summary>
        /// Sets the SignalExternalWorkflowExecutionDecisionAttributes property
        /// </summary>
        /// <param name="signalExternalWorkflowExecutionDecisionAttributes">The value to set for the SignalExternalWorkflowExecutionDecisionAttributes property </param>
        /// <returns>this instance</returns>
        public Decision WithSignalExternalWorkflowExecutionDecisionAttributes(SignalExternalWorkflowExecutionDecisionAttributes signalExternalWorkflowExecutionDecisionAttributes)
        {
            this.signalExternalWorkflowExecutionDecisionAttributes = signalExternalWorkflowExecutionDecisionAttributes;
            return this;
        }
            

        // Check to see if SignalExternalWorkflowExecutionDecisionAttributes property is set
        internal bool IsSetSignalExternalWorkflowExecutionDecisionAttributes()
        {
            return this.signalExternalWorkflowExecutionDecisionAttributes != null;       
        }

        /// <summary>
        /// Provides details of the <c>RequestCancelExternalWorkflowExecution</c> decision. It is not set for other decision types.
        ///  
        /// </summary>
        public RequestCancelExternalWorkflowExecutionDecisionAttributes RequestCancelExternalWorkflowExecutionDecisionAttributes
        {
            get { return this.requestCancelExternalWorkflowExecutionDecisionAttributes; }
            set { this.requestCancelExternalWorkflowExecutionDecisionAttributes = value; }
        }

        /// <summary>
        /// Sets the RequestCancelExternalWorkflowExecutionDecisionAttributes property
        /// </summary>
        /// <param name="requestCancelExternalWorkflowExecutionDecisionAttributes">The value to set for the RequestCancelExternalWorkflowExecutionDecisionAttributes property </param>
        /// <returns>this instance</returns>
        public Decision WithRequestCancelExternalWorkflowExecutionDecisionAttributes(RequestCancelExternalWorkflowExecutionDecisionAttributes requestCancelExternalWorkflowExecutionDecisionAttributes)
        {
            this.requestCancelExternalWorkflowExecutionDecisionAttributes = requestCancelExternalWorkflowExecutionDecisionAttributes;
            return this;
        }
            

        // Check to see if RequestCancelExternalWorkflowExecutionDecisionAttributes property is set
        internal bool IsSetRequestCancelExternalWorkflowExecutionDecisionAttributes()
        {
            return this.requestCancelExternalWorkflowExecutionDecisionAttributes != null;       
        }

        /// <summary>
        /// Provides details of the <c>StartChildWorkflowExecution</c> decision. It is not set for other decision types.
        ///  
        /// </summary>
        public StartChildWorkflowExecutionDecisionAttributes StartChildWorkflowExecutionDecisionAttributes
        {
            get { return this.startChildWorkflowExecutionDecisionAttributes; }
            set { this.startChildWorkflowExecutionDecisionAttributes = value; }
        }

        /// <summary>
        /// Sets the StartChildWorkflowExecutionDecisionAttributes property
        /// </summary>
        /// <param name="startChildWorkflowExecutionDecisionAttributes">The value to set for the StartChildWorkflowExecutionDecisionAttributes property </param>
        /// <returns>this instance</returns>
        public Decision WithStartChildWorkflowExecutionDecisionAttributes(StartChildWorkflowExecutionDecisionAttributes startChildWorkflowExecutionDecisionAttributes)
        {
            this.startChildWorkflowExecutionDecisionAttributes = startChildWorkflowExecutionDecisionAttributes;
            return this;
        }
            

        // Check to see if StartChildWorkflowExecutionDecisionAttributes property is set
        internal bool IsSetStartChildWorkflowExecutionDecisionAttributes()
        {
            return this.startChildWorkflowExecutionDecisionAttributes != null;       
        }
    }
}
