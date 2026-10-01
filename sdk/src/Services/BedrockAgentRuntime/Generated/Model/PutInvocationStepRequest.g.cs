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
    /// Container for the parameters to the PutInvocationStep operation. Add an invocation
    /// step to an invocation in a session. An invocation step stores fine-grained state checkpoints,
    /// including text and images, for each interaction. For more information about sessions,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
    /// and retrieve conversation history and context with Amazon Bedrock sessions</a>. <para>
    /// Related APIs: </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_GetInvocationStep.html">GetInvocationStep</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_ListInvocationSteps.html">ListInvocationSteps</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_ListInvocations.html">ListInvocations</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_ListInvocations.html">ListSessions</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class PutInvocationStepRequest : AmazonBedrockAgentRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property InvocationIdentifier. 
        /// <para>
        /// The unique identifier (in UUID format) of the invocation to add the invocation step
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InvocationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the InvocationIdentifier property is set.
        /// </summary>
        internal bool IsSetInvocationIdentifier() => this.InvocationIdentifier != null;

        /// <summary>
        /// Gets and sets the property InvocationStepId. 
        /// <para>
        /// The unique identifier of the invocation step in UUID format.
        /// </para>
        /// </summary>
        public string InvocationStepId { get; set; }

        /// <summary>
        /// Checks to see if the InvocationStepId property is set.
        /// </summary>
        internal bool IsSetInvocationStepId() => this.InvocationStepId != null;

        /// <summary>
        /// Gets and sets the property InvocationStepTime. 
        /// <para>
        /// The timestamp for when the invocation step occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? InvocationStepTime { get; set; }

        /// <summary>
        /// Checks to see if the InvocationStepTime property is set.
        /// </summary>
        internal bool IsSetInvocationStepTime() => this.InvocationStepTime.HasValue;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The payload for the invocation step, including text and images for the interaction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InvocationStepPayload Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property SessionIdentifier. 
        /// <para>
        /// The unique identifier for the session to add the invocation step to. You can specify
        /// either the session's <c>sessionId</c> or its Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SessionIdentifier property is set.
        /// </summary>
        internal bool IsSetSessionIdentifier() => this.SessionIdentifier != null;
    }
}
