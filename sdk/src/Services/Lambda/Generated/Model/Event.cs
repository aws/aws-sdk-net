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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// An event that occurred during the execution of a durable function.
    /// </summary>
    public partial class Event
    {
        private CallbackFailedDetails _callbackFailedDetails;
        private CallbackStartedDetails _callbackStartedDetails;
        private CallbackSucceededDetails _callbackSucceededDetails;
        private CallbackTimedOutDetails _callbackTimedOutDetails;
        private ChainedInvokeFailedDetails _chainedInvokeFailedDetails;
        private ChainedInvokeStartedDetails _chainedInvokeStartedDetails;
        private ChainedInvokeStoppedDetails _chainedInvokeStoppedDetails;
        private ChainedInvokeSucceededDetails _chainedInvokeSucceededDetails;
        private ChainedInvokeTimedOutDetails _chainedInvokeTimedOutDetails;
        private ContextFailedDetails _contextFailedDetails;
        private ContextStartedDetails _contextStartedDetails;
        private ContextSucceededDetails _contextSucceededDetails;
        private int? _eventId;
        private DateTime? _eventTimestamp;
        private EventType _eventType;
        private ExecutionFailedDetails _executionFailedDetails;
        private ExecutionStartedDetails _executionStartedDetails;
        private ExecutionStoppedDetails _executionStoppedDetails;
        private ExecutionSucceededDetails _executionSucceededDetails;
        private ExecutionTimedOutDetails _executionTimedOutDetails;
        private string _id;
        private InvocationCompletedDetails _invocationCompletedDetails;
        private string _name;
        private string _parentId;
        private StepFailedDetails _stepFailedDetails;
        private StepStartedDetails _stepStartedDetails;
        private StepSucceededDetails _stepSucceededDetails;
        private string _subType;
        private WaitCancelledDetails _waitCancelledDetails;
        private WaitStartedDetails _waitStartedDetails;
        private WaitSucceededDetails _waitSucceededDetails;

        /// <summary>
        /// Gets and sets the property CallbackFailedDetails.
        /// </summary>
        public CallbackFailedDetails CallbackFailedDetails
        {
            get { return this._callbackFailedDetails; }
            set { this._callbackFailedDetails = value; }
        }

        // Check to see if CallbackFailedDetails property is set
        internal bool IsSetCallbackFailedDetails()
        {
            return this._callbackFailedDetails != null;
        }

        /// <summary>
        /// Gets and sets the property CallbackStartedDetails.
        /// </summary>
        public CallbackStartedDetails CallbackStartedDetails
        {
            get { return this._callbackStartedDetails; }
            set { this._callbackStartedDetails = value; }
        }

        // Check to see if CallbackStartedDetails property is set
        internal bool IsSetCallbackStartedDetails()
        {
            return this._callbackStartedDetails != null;
        }

        /// <summary>
        /// Gets and sets the property CallbackSucceededDetails.
        /// </summary>
        public CallbackSucceededDetails CallbackSucceededDetails
        {
            get { return this._callbackSucceededDetails; }
            set { this._callbackSucceededDetails = value; }
        }

        // Check to see if CallbackSucceededDetails property is set
        internal bool IsSetCallbackSucceededDetails()
        {
            return this._callbackSucceededDetails != null;
        }

        /// <summary>
        /// Gets and sets the property CallbackTimedOutDetails.
        /// </summary>
        public CallbackTimedOutDetails CallbackTimedOutDetails
        {
            get { return this._callbackTimedOutDetails; }
            set { this._callbackTimedOutDetails = value; }
        }

        // Check to see if CallbackTimedOutDetails property is set
        internal bool IsSetCallbackTimedOutDetails()
        {
            return this._callbackTimedOutDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ChainedInvokeFailedDetails.
        /// </summary>
        public ChainedInvokeFailedDetails ChainedInvokeFailedDetails
        {
            get { return this._chainedInvokeFailedDetails; }
            set { this._chainedInvokeFailedDetails = value; }
        }

        // Check to see if ChainedInvokeFailedDetails property is set
        internal bool IsSetChainedInvokeFailedDetails()
        {
            return this._chainedInvokeFailedDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ChainedInvokeStartedDetails.
        /// </summary>
        public ChainedInvokeStartedDetails ChainedInvokeStartedDetails
        {
            get { return this._chainedInvokeStartedDetails; }
            set { this._chainedInvokeStartedDetails = value; }
        }

        // Check to see if ChainedInvokeStartedDetails property is set
        internal bool IsSetChainedInvokeStartedDetails()
        {
            return this._chainedInvokeStartedDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ChainedInvokeStoppedDetails. 
        /// <para>
        /// Details about a chained invocation that was stopped.
        /// </para>
        /// </summary>
        public ChainedInvokeStoppedDetails ChainedInvokeStoppedDetails
        {
            get { return this._chainedInvokeStoppedDetails; }
            set { this._chainedInvokeStoppedDetails = value; }
        }

        // Check to see if ChainedInvokeStoppedDetails property is set
        internal bool IsSetChainedInvokeStoppedDetails()
        {
            return this._chainedInvokeStoppedDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ChainedInvokeSucceededDetails. 
        /// <para>
        /// Details about a chained invocation that succeeded.
        /// </para>
        /// </summary>
        public ChainedInvokeSucceededDetails ChainedInvokeSucceededDetails
        {
            get { return this._chainedInvokeSucceededDetails; }
            set { this._chainedInvokeSucceededDetails = value; }
        }

        // Check to see if ChainedInvokeSucceededDetails property is set
        internal bool IsSetChainedInvokeSucceededDetails()
        {
            return this._chainedInvokeSucceededDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ChainedInvokeTimedOutDetails. 
        /// <para>
        /// Details about a chained invocation that timed out.
        /// </para>
        /// </summary>
        public ChainedInvokeTimedOutDetails ChainedInvokeTimedOutDetails
        {
            get { return this._chainedInvokeTimedOutDetails; }
            set { this._chainedInvokeTimedOutDetails = value; }
        }

        // Check to see if ChainedInvokeTimedOutDetails property is set
        internal bool IsSetChainedInvokeTimedOutDetails()
        {
            return this._chainedInvokeTimedOutDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ContextFailedDetails. 
        /// <para>
        /// Details about a context that failed.
        /// </para>
        /// </summary>
        public ContextFailedDetails ContextFailedDetails
        {
            get { return this._contextFailedDetails; }
            set { this._contextFailedDetails = value; }
        }

        // Check to see if ContextFailedDetails property is set
        internal bool IsSetContextFailedDetails()
        {
            return this._contextFailedDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ContextStartedDetails. 
        /// <para>
        /// Details about a context that started.
        /// </para>
        /// </summary>
        public ContextStartedDetails ContextStartedDetails
        {
            get { return this._contextStartedDetails; }
            set { this._contextStartedDetails = value; }
        }

        // Check to see if ContextStartedDetails property is set
        internal bool IsSetContextStartedDetails()
        {
            return this._contextStartedDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ContextSucceededDetails. 
        /// <para>
        /// Details about a context that succeeded.
        /// </para>
        /// </summary>
        public ContextSucceededDetails ContextSucceededDetails
        {
            get { return this._contextSucceededDetails; }
            set { this._contextSucceededDetails = value; }
        }

        // Check to see if ContextSucceededDetails property is set
        internal bool IsSetContextSucceededDetails()
        {
            return this._contextSucceededDetails != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The unique identifier for this event. Event IDs increment sequentially.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int EventId
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
        /// The date and time when this event occurred, in <a href="https://www.w3.org/TR/NOTE-datetime">ISO-8601
        /// format</a> (YYYY-MM-DDThh:mm:ss.sTZD).
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
        /// The type of event that occurred.
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
        /// Gets and sets the property ExecutionFailedDetails. 
        /// <para>
        /// Details about an execution that failed.
        /// </para>
        /// </summary>
        public ExecutionFailedDetails ExecutionFailedDetails
        {
            get { return this._executionFailedDetails; }
            set { this._executionFailedDetails = value; }
        }

        // Check to see if ExecutionFailedDetails property is set
        internal bool IsSetExecutionFailedDetails()
        {
            return this._executionFailedDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStartedDetails. 
        /// <para>
        /// Details about an execution that started.
        /// </para>
        /// </summary>
        public ExecutionStartedDetails ExecutionStartedDetails
        {
            get { return this._executionStartedDetails; }
            set { this._executionStartedDetails = value; }
        }

        // Check to see if ExecutionStartedDetails property is set
        internal bool IsSetExecutionStartedDetails()
        {
            return this._executionStartedDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStoppedDetails. 
        /// <para>
        /// Details about an execution that was stopped.
        /// </para>
        /// </summary>
        public ExecutionStoppedDetails ExecutionStoppedDetails
        {
            get { return this._executionStoppedDetails; }
            set { this._executionStoppedDetails = value; }
        }

        // Check to see if ExecutionStoppedDetails property is set
        internal bool IsSetExecutionStoppedDetails()
        {
            return this._executionStoppedDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionSucceededDetails. 
        /// <para>
        /// Details about an execution that succeeded.
        /// </para>
        /// </summary>
        public ExecutionSucceededDetails ExecutionSucceededDetails
        {
            get { return this._executionSucceededDetails; }
            set { this._executionSucceededDetails = value; }
        }

        // Check to see if ExecutionSucceededDetails property is set
        internal bool IsSetExecutionSucceededDetails()
        {
            return this._executionSucceededDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionTimedOutDetails. 
        /// <para>
        /// Details about an execution that timed out.
        /// </para>
        /// </summary>
        public ExecutionTimedOutDetails ExecutionTimedOutDetails
        {
            get { return this._executionTimedOutDetails; }
            set { this._executionTimedOutDetails = value; }
        }

        // Check to see if ExecutionTimedOutDetails property is set
        internal bool IsSetExecutionTimedOutDetails()
        {
            return this._executionTimedOutDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationCompletedDetails. 
        /// <para>
        /// Details about a function invocation that completed.
        /// </para>
        /// </summary>
        public InvocationCompletedDetails InvocationCompletedDetails
        {
            get { return this._invocationCompletedDetails; }
            set { this._invocationCompletedDetails = value; }
        }

        // Check to see if InvocationCompletedDetails property is set
        internal bool IsSetInvocationCompletedDetails()
        {
            return this._invocationCompletedDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The customer-provided name for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// The unique identifier of the parent operation, if this operation is running within
        /// a child context.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ParentId
        {
            get { return this._parentId; }
            set { this._parentId = value; }
        }

        // Check to see if ParentId property is set
        internal bool IsSetParentId()
        {
            return this._parentId != null;
        }

        /// <summary>
        /// Gets and sets the property StepFailedDetails. 
        /// <para>
        /// Details about a step that failed.
        /// </para>
        /// </summary>
        public StepFailedDetails StepFailedDetails
        {
            get { return this._stepFailedDetails; }
            set { this._stepFailedDetails = value; }
        }

        // Check to see if StepFailedDetails property is set
        internal bool IsSetStepFailedDetails()
        {
            return this._stepFailedDetails != null;
        }

        /// <summary>
        /// Gets and sets the property StepStartedDetails. 
        /// <para>
        /// Details about a step that started.
        /// </para>
        /// </summary>
        public StepStartedDetails StepStartedDetails
        {
            get { return this._stepStartedDetails; }
            set { this._stepStartedDetails = value; }
        }

        // Check to see if StepStartedDetails property is set
        internal bool IsSetStepStartedDetails()
        {
            return this._stepStartedDetails != null;
        }

        /// <summary>
        /// Gets and sets the property StepSucceededDetails. 
        /// <para>
        /// Details about a step that succeeded.
        /// </para>
        /// </summary>
        public StepSucceededDetails StepSucceededDetails
        {
            get { return this._stepSucceededDetails; }
            set { this._stepSucceededDetails = value; }
        }

        // Check to see if StepSucceededDetails property is set
        internal bool IsSetStepSucceededDetails()
        {
            return this._stepSucceededDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SubType. 
        /// <para>
        /// The subtype of the event, providing additional categorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string SubType
        {
            get { return this._subType; }
            set { this._subType = value; }
        }

        // Check to see if SubType property is set
        internal bool IsSetSubType()
        {
            return this._subType != null;
        }

        /// <summary>
        /// Gets and sets the property WaitCancelledDetails. 
        /// <para>
        /// Details about a wait operation that was cancelled.
        /// </para>
        /// </summary>
        public WaitCancelledDetails WaitCancelledDetails
        {
            get { return this._waitCancelledDetails; }
            set { this._waitCancelledDetails = value; }
        }

        // Check to see if WaitCancelledDetails property is set
        internal bool IsSetWaitCancelledDetails()
        {
            return this._waitCancelledDetails != null;
        }

        /// <summary>
        /// Gets and sets the property WaitStartedDetails. 
        /// <para>
        /// Details about a wait operation that started.
        /// </para>
        /// </summary>
        public WaitStartedDetails WaitStartedDetails
        {
            get { return this._waitStartedDetails; }
            set { this._waitStartedDetails = value; }
        }

        // Check to see if WaitStartedDetails property is set
        internal bool IsSetWaitStartedDetails()
        {
            return this._waitStartedDetails != null;
        }

        /// <summary>
        /// Gets and sets the property WaitSucceededDetails. 
        /// <para>
        /// Details about a wait operation that succeeded.
        /// </para>
        /// </summary>
        public WaitSucceededDetails WaitSucceededDetails
        {
            get { return this._waitSucceededDetails; }
            set { this._waitSucceededDetails = value; }
        }

        // Check to see if WaitSucceededDetails property is set
        internal bool IsSetWaitSucceededDetails()
        {
            return this._waitSucceededDetails != null;
        }

    }
}