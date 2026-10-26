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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// An event that occurred during the execution of a durable function.
    /// </summary>
    public partial class Event
    {
        /// <summary>
        /// Gets and sets the property CallbackFailedDetails.
        /// </summary>
        public CallbackFailedDetails CallbackFailedDetails { get; set; }

        /// <summary>
        /// Checks to see if the CallbackFailedDetails property is set.
        /// </summary>
        internal bool IsSetCallbackFailedDetails() => this.CallbackFailedDetails != null;

        /// <summary>
        /// Gets and sets the property CallbackStartedDetails.
        /// </summary>
        public CallbackStartedDetails CallbackStartedDetails { get; set; }

        /// <summary>
        /// Checks to see if the CallbackStartedDetails property is set.
        /// </summary>
        internal bool IsSetCallbackStartedDetails() => this.CallbackStartedDetails != null;

        /// <summary>
        /// Gets and sets the property CallbackSucceededDetails.
        /// </summary>
        public CallbackSucceededDetails CallbackSucceededDetails { get; set; }

        /// <summary>
        /// Checks to see if the CallbackSucceededDetails property is set.
        /// </summary>
        internal bool IsSetCallbackSucceededDetails() => this.CallbackSucceededDetails != null;

        /// <summary>
        /// Gets and sets the property CallbackTimedOutDetails.
        /// </summary>
        public CallbackTimedOutDetails CallbackTimedOutDetails { get; set; }

        /// <summary>
        /// Checks to see if the CallbackTimedOutDetails property is set.
        /// </summary>
        internal bool IsSetCallbackTimedOutDetails() => this.CallbackTimedOutDetails != null;

        /// <summary>
        /// Gets and sets the property ChainedInvokeFailedDetails.
        /// </summary>
        public ChainedInvokeFailedDetails ChainedInvokeFailedDetails { get; set; }

        /// <summary>
        /// Checks to see if the ChainedInvokeFailedDetails property is set.
        /// </summary>
        internal bool IsSetChainedInvokeFailedDetails() => this.ChainedInvokeFailedDetails != null;

        /// <summary>
        /// Gets and sets the property ChainedInvokeStartedDetails.
        /// </summary>
        public ChainedInvokeStartedDetails ChainedInvokeStartedDetails { get; set; }

        /// <summary>
        /// Checks to see if the ChainedInvokeStartedDetails property is set.
        /// </summary>
        internal bool IsSetChainedInvokeStartedDetails() => this.ChainedInvokeStartedDetails != null;

        /// <summary>
        /// Gets and sets the property ChainedInvokeStoppedDetails. 
        /// <para>
        /// Details about a chained invocation that was stopped.
        /// </para>
        /// </summary>
        public ChainedInvokeStoppedDetails ChainedInvokeStoppedDetails { get; set; }

        /// <summary>
        /// Checks to see if the ChainedInvokeStoppedDetails property is set.
        /// </summary>
        internal bool IsSetChainedInvokeStoppedDetails() => this.ChainedInvokeStoppedDetails != null;

        /// <summary>
        /// Gets and sets the property ChainedInvokeSucceededDetails. 
        /// <para>
        /// Details about a chained invocation that succeeded.
        /// </para>
        /// </summary>
        public ChainedInvokeSucceededDetails ChainedInvokeSucceededDetails { get; set; }

        /// <summary>
        /// Checks to see if the ChainedInvokeSucceededDetails property is set.
        /// </summary>
        internal bool IsSetChainedInvokeSucceededDetails() => this.ChainedInvokeSucceededDetails != null;

        /// <summary>
        /// Gets and sets the property ChainedInvokeTimedOutDetails. 
        /// <para>
        /// Details about a chained invocation that timed out.
        /// </para>
        /// </summary>
        public ChainedInvokeTimedOutDetails ChainedInvokeTimedOutDetails { get; set; }

        /// <summary>
        /// Checks to see if the ChainedInvokeTimedOutDetails property is set.
        /// </summary>
        internal bool IsSetChainedInvokeTimedOutDetails() => this.ChainedInvokeTimedOutDetails != null;

        /// <summary>
        /// Gets and sets the property ContextFailedDetails. 
        /// <para>
        /// Details about a context that failed.
        /// </para>
        /// </summary>
        public ContextFailedDetails ContextFailedDetails { get; set; }

        /// <summary>
        /// Checks to see if the ContextFailedDetails property is set.
        /// </summary>
        internal bool IsSetContextFailedDetails() => this.ContextFailedDetails != null;

        /// <summary>
        /// Gets and sets the property ContextStartedDetails. 
        /// <para>
        /// Details about a context that started.
        /// </para>
        /// </summary>
        public ContextStartedDetails ContextStartedDetails { get; set; }

        /// <summary>
        /// Checks to see if the ContextStartedDetails property is set.
        /// </summary>
        internal bool IsSetContextStartedDetails() => this.ContextStartedDetails != null;

        /// <summary>
        /// Gets and sets the property ContextSucceededDetails. 
        /// <para>
        /// Details about a context that succeeded.
        /// </para>
        /// </summary>
        public ContextSucceededDetails ContextSucceededDetails { get; set; }

        /// <summary>
        /// Checks to see if the ContextSucceededDetails property is set.
        /// </summary>
        internal bool IsSetContextSucceededDetails() => this.ContextSucceededDetails != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The unique identifier for this event. Event IDs increment sequentially.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId.HasValue;

        /// <summary>
        /// Gets and sets the property EventTimestamp. 
        /// <para>
        /// The date and time when this event occurred, in <a href="https://www.w3.org/TR/NOTE-datetime">ISO-8601
        /// format</a> (YYYY-MM-DDThh:mm:ss.sTZD).
        /// </para>
        /// </summary>
        public DateTime? EventTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EventTimestamp property is set.
        /// </summary>
        internal bool IsSetEventTimestamp() => this.EventTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of event that occurred.
        /// </para>
        /// </summary>
        public EventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property ExecutionFailedDetails. 
        /// <para>
        /// Details about an execution that failed.
        /// </para>
        /// </summary>
        public ExecutionFailedDetails ExecutionFailedDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionFailedDetails property is set.
        /// </summary>
        internal bool IsSetExecutionFailedDetails() => this.ExecutionFailedDetails != null;

        /// <summary>
        /// Gets and sets the property ExecutionStartedDetails. 
        /// <para>
        /// Details about an execution that started.
        /// </para>
        /// </summary>
        public ExecutionStartedDetails ExecutionStartedDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStartedDetails property is set.
        /// </summary>
        internal bool IsSetExecutionStartedDetails() => this.ExecutionStartedDetails != null;

        /// <summary>
        /// Gets and sets the property ExecutionStoppedDetails. 
        /// <para>
        /// Details about an execution that was stopped.
        /// </para>
        /// </summary>
        public ExecutionStoppedDetails ExecutionStoppedDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStoppedDetails property is set.
        /// </summary>
        internal bool IsSetExecutionStoppedDetails() => this.ExecutionStoppedDetails != null;

        /// <summary>
        /// Gets and sets the property ExecutionSucceededDetails. 
        /// <para>
        /// Details about an execution that succeeded.
        /// </para>
        /// </summary>
        public ExecutionSucceededDetails ExecutionSucceededDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionSucceededDetails property is set.
        /// </summary>
        internal bool IsSetExecutionSucceededDetails() => this.ExecutionSucceededDetails != null;

        /// <summary>
        /// Gets and sets the property ExecutionTimedOutDetails. 
        /// <para>
        /// Details about an execution that timed out.
        /// </para>
        /// </summary>
        public ExecutionTimedOutDetails ExecutionTimedOutDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionTimedOutDetails property is set.
        /// </summary>
        internal bool IsSetExecutionTimedOutDetails() => this.ExecutionTimedOutDetails != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InvocationCompletedDetails. 
        /// <para>
        /// Details about a function invocation that completed.
        /// </para>
        /// </summary>
        public InvocationCompletedDetails InvocationCompletedDetails { get; set; }

        /// <summary>
        /// Checks to see if the InvocationCompletedDetails property is set.
        /// </summary>
        internal bool IsSetInvocationCompletedDetails() => this.InvocationCompletedDetails != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The customer-provided name for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// The unique identifier of the parent operation, if this operation is running within
        /// a child context.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ParentId { get; set; }

        /// <summary>
        /// Checks to see if the ParentId property is set.
        /// </summary>
        internal bool IsSetParentId() => this.ParentId != null;

        /// <summary>
        /// Gets and sets the property StepFailedDetails. 
        /// <para>
        /// Details about a step that failed.
        /// </para>
        /// </summary>
        public StepFailedDetails StepFailedDetails { get; set; }

        /// <summary>
        /// Checks to see if the StepFailedDetails property is set.
        /// </summary>
        internal bool IsSetStepFailedDetails() => this.StepFailedDetails != null;

        /// <summary>
        /// Gets and sets the property StepStartedDetails. 
        /// <para>
        /// Details about a step that started.
        /// </para>
        /// </summary>
        public StepStartedDetails StepStartedDetails { get; set; }

        /// <summary>
        /// Checks to see if the StepStartedDetails property is set.
        /// </summary>
        internal bool IsSetStepStartedDetails() => this.StepStartedDetails != null;

        /// <summary>
        /// Gets and sets the property StepSucceededDetails. 
        /// <para>
        /// Details about a step that succeeded.
        /// </para>
        /// </summary>
        public StepSucceededDetails StepSucceededDetails { get; set; }

        /// <summary>
        /// Checks to see if the StepSucceededDetails property is set.
        /// </summary>
        internal bool IsSetStepSucceededDetails() => this.StepSucceededDetails != null;

        /// <summary>
        /// Gets and sets the property SubType. 
        /// <para>
        /// The subtype of the event, providing additional categorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string SubType { get; set; }

        /// <summary>
        /// Checks to see if the SubType property is set.
        /// </summary>
        internal bool IsSetSubType() => this.SubType != null;

        /// <summary>
        /// Gets and sets the property WaitCancelledDetails. 
        /// <para>
        /// Details about a wait operation that was cancelled.
        /// </para>
        /// </summary>
        public WaitCancelledDetails WaitCancelledDetails { get; set; }

        /// <summary>
        /// Checks to see if the WaitCancelledDetails property is set.
        /// </summary>
        internal bool IsSetWaitCancelledDetails() => this.WaitCancelledDetails != null;

        /// <summary>
        /// Gets and sets the property WaitStartedDetails. 
        /// <para>
        /// Details about a wait operation that started.
        /// </para>
        /// </summary>
        public WaitStartedDetails WaitStartedDetails { get; set; }

        /// <summary>
        /// Checks to see if the WaitStartedDetails property is set.
        /// </summary>
        internal bool IsSetWaitStartedDetails() => this.WaitStartedDetails != null;

        /// <summary>
        /// Gets and sets the property WaitSucceededDetails. 
        /// <para>
        /// Details about a wait operation that succeeded.
        /// </para>
        /// </summary>
        public WaitSucceededDetails WaitSucceededDetails { get; set; }

        /// <summary>
        /// Checks to see if the WaitSucceededDetails property is set.
        /// </summary>
        internal bool IsSetWaitSucceededDetails() => this.WaitSucceededDetails != null;
    }
}
