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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
        private string _invocationId;
        private string _invocationStepId;
        private DateTime? _invocationStepTime;
        private InvocationStepPayload _payload;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property InvocationId. 
        /// <para>
        /// The unique identifier (in UUID format) for the invocation that includes the invocation
        /// step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InvocationId
        {
            get { return this._invocationId; }
            set { this._invocationId = value; }
        }

        // Check to see if InvocationId property is set
        internal bool IsSetInvocationId()
        {
            return this._invocationId != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationStepId. 
        /// <para>
        /// The unique identifier (in UUID format) for the invocation step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InvocationStepId
        {
            get { return this._invocationStepId; }
            set { this._invocationStepId = value; }
        }

        // Check to see if InvocationStepId property is set
        internal bool IsSetInvocationStepId()
        {
            return this._invocationStepId != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationStepTime. 
        /// <para>
        /// The timestamp for when the invocation step was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? InvocationStepTime
        {
            get { return this._invocationStepTime; }
            set { this._invocationStepTime = value; }
        }

        // Check to see if InvocationStepTime property is set
        internal bool IsSetInvocationStepTime()
        {
            return this._invocationStepTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// Payload content, such as text and images, for the invocation step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InvocationStepPayload Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session containing the invocation step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}