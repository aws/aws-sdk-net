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
    /// Container for the parameters to the PutInvocationStep operation.
    /// Add an invocation step to an invocation in a session. An invocation step stores fine-grained
    /// state checkpoints, including text and images, for each interaction. For more information
    /// about sessions, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
    /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
    /// 
    ///  
    /// <para>
    /// Related APIs:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_GetInvocationStep.html">GetInvocationStep</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_ListInvocationSteps.html">ListInvocationSteps</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_ListInvocations.html">ListInvocations</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_ListInvocations.html">ListSessions</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutInvocationStepRequest : AmazonBedrockAgentRuntimeRequest
    {
        private string _invocationIdentifier;
        private string _invocationStepId;
        private DateTime? _invocationStepTime;
        private InvocationStepPayload _payload;
        private string _sessionIdentifier;

        /// <summary>
        /// Gets and sets the property InvocationIdentifier. 
        /// <para>
        /// The unique identifier (in UUID format) of the invocation to add the invocation step
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InvocationIdentifier
        {
            get { return this._invocationIdentifier; }
            set { this._invocationIdentifier = value; }
        }

        // Check to see if InvocationIdentifier property is set
        internal bool IsSetInvocationIdentifier()
        {
            return this._invocationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationStepId. 
        /// <para>
        /// The unique identifier of the invocation step in UUID format.
        /// </para>
        /// </summary>
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
        /// The timestamp for when the invocation step occurred.
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
        /// The payload for the invocation step, including text and images for the interaction.
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
        /// Gets and sets the property SessionIdentifier. 
        /// <para>
        /// The unique identifier for the session to add the invocation step to. You can specify
        /// either the session's <c>sessionId</c> or its Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionIdentifier
        {
            get { return this._sessionIdentifier; }
            set { this._sessionIdentifier = value; }
        }

        // Check to see if SessionIdentifier property is set
        internal bool IsSetSessionIdentifier()
        {
            return this._sessionIdentifier != null;
        }

    }
}