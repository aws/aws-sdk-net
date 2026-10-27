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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the SendWorkflowStepState operation. Sends a callback
    /// for asynchronous custom steps. <para> The <c>ExecutionId</c>, <c>WorkflowId</c>, and
    /// <c>Token</c> are passed to the target resource during execution of a custom step of
    /// a workflow. You must include those with their callback as well as providing a status.
    /// </para>
    /// </summary>
    public partial class SendWorkflowStepStateRequest : AmazonTransferRequest
    {
        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// A unique identifier for the execution of a workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates whether the specified step succeeded or failed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomStepStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// Used to distinguish between multiple callbacks for multiple Lambda steps within the
        /// same execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Token { get; set; }

        /// <summary>
        /// Checks to see if the Token property is set.
        /// </summary>
        internal bool IsSetToken() => this.Token != null;

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// A unique identifier for the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowId property is set.
        /// </summary>
        internal bool IsSetWorkflowId() => this.WorkflowId != null;
    }
}
