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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// This is the response object from the StopFlowExecution operation.
    /// </summary>
    public partial class StopFlowExecutionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the flow execution that was
        /// stopped.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string ExecutionArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionArn property is set.
        /// </summary>
        internal bool IsSetExecutionArn() => this.ExecutionArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The updated status of the flow execution after the stop request. This will typically
        /// be ABORTED if the execution was successfully stopped.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlowExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
