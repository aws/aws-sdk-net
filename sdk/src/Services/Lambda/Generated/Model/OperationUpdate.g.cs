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
    /// An update to be applied to an operation during checkpointing.
    /// </summary>
    public partial class OperationUpdate
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take on the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OperationAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property CallbackOptions.
        /// </summary>
        public CallbackOptions CallbackOptions { get; set; }

        /// <summary>
        /// Checks to see if the CallbackOptions property is set.
        /// </summary>
        internal bool IsSetCallbackOptions() => this.CallbackOptions != null;

        /// <summary>
        /// Gets and sets the property ChainedInvokeOptions.
        /// </summary>
        public ChainedInvokeOptions ChainedInvokeOptions { get; set; }

        /// <summary>
        /// Checks to see if the ChainedInvokeOptions property is set.
        /// </summary>
        internal bool IsSetChainedInvokeOptions() => this.ChainedInvokeOptions != null;

        /// <summary>
        /// Gets and sets the property ContextOptions. 
        /// <para>
        /// Options for context operations.
        /// </para>
        /// </summary>
        public ContextOptions ContextOptions { get; set; }

        /// <summary>
        /// Checks to see if the ContextOptions property is set.
        /// </summary>
        internal bool IsSetContextOptions() => this.ContextOptions != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error information for failed operations. The combined size of all error fields
        /// is limited to 1 MB.
        /// </para>
        /// </summary>
        public ErrorObject Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

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
        /// Gets and sets the property Payload. 
        /// <para>
        /// The payload for successful operations. The maximum payload size is 6 MB for synchronous
        /// <c>EXECUTION</c> operations (RequestResponse invocationType), and 1 MB for asynchronous
        /// <c>EXECUTION</c> (Event invocationType), <c>CHAINED_INVOKE</c>, <c>CONTEXT</c>, <c>STEP</c>,
        /// <c>WAIT</c>, and <c>CALLBACK</c> operations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 6291456)]
        public string Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property StepOptions. 
        /// <para>
        /// Options for step operations.
        /// </para>
        /// </summary>
        public StepOptions StepOptions { get; set; }

        /// <summary>
        /// Checks to see if the StepOptions property is set.
        /// </summary>
        internal bool IsSetStepOptions() => this.StepOptions != null;

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
        /// The type of operation to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OperationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property WaitOptions. 
        /// <para>
        /// Options for wait operations.
        /// </para>
        /// </summary>
        public WaitOptions WaitOptions { get; set; }

        /// <summary>
        /// Checks to see if the WaitOptions property is set.
        /// </summary>
        internal bool IsSetWaitOptions() => this.WaitOptions != null;
    }
}
