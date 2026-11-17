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
    /// Container for the parameters to the ResumeDurableExecution operation. Resumes a paused
    /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/durable-functions.html">durable
    /// execution</a>. If the pause interrupted an invocation, or an operation completed while
    /// the execution was paused, Lambda invokes your function. Otherwise, the execution continues
    /// to wait for its pending operations. <para> If the execution status is <c>PAUSING</c>,
    /// this operation cancels the pause, and the in-progress invocation continues. This operation
    /// returns a successful response while the execution status is still <c>PAUSED</c> or
    /// <c>PAUSING</c>, and the status changes to <c>RUNNING</c> when Lambda processes the
    /// request. For more information about resuming executions, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/durable-pause-resume.html">Pausing
    /// and resuming durable executions</a>. </para>
    /// </summary>
    public partial class ResumeDurableExecutionRequest : AmazonLambdaRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide so that the request completes
        /// no more than one time. If you repeat a request with the same client token and parameters
        /// within 15 minutes, Lambda doesn't resume the execution again and returns a successful
        /// response instead of an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DurableExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the durable execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string DurableExecutionArn { get; set; }

        /// <summary>
        /// Checks to see if the DurableExecutionArn property is set.
        /// </summary>
        internal bool IsSetDurableExecutionArn() => this.DurableExecutionArn != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A description of why you're resuming the execution. Lambda records the reason in the
        /// execution history.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;
    }
}
