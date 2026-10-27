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
    /// Information about an operation within a durable execution.
    /// </summary>
    public partial class Operation
    {
        /// <summary>
        /// Gets and sets the property CallbackDetails.
        /// </summary>
        public CallbackDetails CallbackDetails { get; set; }

        /// <summary>
        /// Checks to see if the CallbackDetails property is set.
        /// </summary>
        internal bool IsSetCallbackDetails() => this.CallbackDetails != null;

        /// <summary>
        /// Gets and sets the property ChainedInvokeDetails.
        /// </summary>
        public ChainedInvokeDetails ChainedInvokeDetails { get; set; }

        /// <summary>
        /// Checks to see if the ChainedInvokeDetails property is set.
        /// </summary>
        internal bool IsSetChainedInvokeDetails() => this.ChainedInvokeDetails != null;

        /// <summary>
        /// Gets and sets the property ContextDetails. 
        /// <para>
        /// Details about the context, if this operation represents a context.
        /// </para>
        /// </summary>
        public ContextDetails ContextDetails { get; set; }

        /// <summary>
        /// Checks to see if the ContextDetails property is set.
        /// </summary>
        internal bool IsSetContextDetails() => this.ContextDetails != null;

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The date and time when the operation ended, in <a href="https://www.w3.org/TR/NOTE-datetime">ISO-8601
        /// format</a> (YYYY-MM-DDThh:mm:ss.sTZD).
        /// </para>
        /// </summary>
        public DateTime? EndTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EndTimestamp property is set.
        /// </summary>
        internal bool IsSetEndTimestamp() => this.EndTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionDetails. 
        /// <para>
        /// Details about the execution, if this operation represents an execution.
        /// </para>
        /// </summary>
        public ExecutionDetails ExecutionDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionDetails property is set.
        /// </summary>
        internal bool IsSetExecutionDetails() => this.ExecutionDetails != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

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
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The date and time when the operation started, in <a href="https://www.w3.org/TR/NOTE-datetime">ISO-8601
        /// format</a> (YYYY-MM-DDThh:mm:ss.sTZD).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OperationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StepDetails. 
        /// <para>
        /// Details about the step, if this operation represents a step.
        /// </para>
        /// </summary>
        public StepDetails StepDetails { get; set; }

        /// <summary>
        /// Checks to see if the StepDetails property is set.
        /// </summary>
        internal bool IsSetStepDetails() => this.StepDetails != null;

        /// <summary>
        /// Gets and sets the property SubType. 
        /// <para>
        /// The subtype of the operation, providing additional categorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string SubType { get; set; }

        /// <summary>
        /// Checks to see if the SubType property is set.
        /// </summary>
        internal bool IsSetSubType() => this.SubType != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OperationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property WaitDetails. 
        /// <para>
        /// Details about the wait operation, if this operation represents a wait.
        /// </para>
        /// </summary>
        public WaitDetails WaitDetails { get; set; }

        /// <summary>
        /// Checks to see if the WaitDetails property is set.
        /// </summary>
        internal bool IsSetWaitDetails() => this.WaitDetails != null;
    }
}
