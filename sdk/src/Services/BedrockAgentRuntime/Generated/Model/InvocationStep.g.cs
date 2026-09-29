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
    /// Stores fine-grained state checkpoints, including text and images, for each interaction
    /// in an invocation in a session. For more information about sessions, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
    /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
    /// </summary>
    public partial class InvocationStep
    {
        /// <summary>
        /// Gets and sets the property InvocationId. 
        /// <para>
        /// The unique identifier (in UUID format) for the invocation that includes the invocation
        /// step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InvocationId { get; set; }

        /// <summary>
        /// Checks to see if the InvocationId property is set.
        /// </summary>
        internal bool IsSetInvocationId() => this.InvocationId != null;

        /// <summary>
        /// Gets and sets the property InvocationStepId. 
        /// <para>
        /// The unique identifier (in UUID format) for the invocation step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InvocationStepId { get; set; }

        /// <summary>
        /// Checks to see if the InvocationStepId property is set.
        /// </summary>
        internal bool IsSetInvocationStepId() => this.InvocationStepId != null;

        /// <summary>
        /// Gets and sets the property InvocationStepTime. 
        /// <para>
        /// The timestamp for when the invocation step was created.
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
        /// Payload content, such as text and images, for the invocation step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InvocationStepPayload Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session containing the invocation step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;
    }
}
