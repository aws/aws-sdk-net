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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeAgent operation.
    /// Sends a prompt for the agent to process and respond to. Use return control event type
    /// for function calling.
    /// 
    ///  <note> 
    /// <para>
    /// The CLI doesn't support <c>InvokeAgent</c>.
    /// </para>
    ///  </note> <ul> <li> 
    /// <para>
    /// To continue the same conversation with an agent, use the same <c>sessionId</c> value
    /// in the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To activate trace enablement, turn <c>enableTrace</c> to <c>true</c>. Trace enablement
    /// helps you follow the agent's reasoning process that led it to the information it processed,
    /// the actions it took, and the final result it yielded. For more information, see <a
    /// href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-test.html#trace-events">Trace
    /// enablement</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// End a conversation by setting <c>endSession</c> to <c>true</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// In the <c>sessionState</c> object, you can include attributes for the session or prompt
    /// or parameters returned from the action group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use return control event type for function calling.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The response is returned in the <c>bytes</c> field of the <c>chunk</c> object.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <c>attribution</c> object contains citations for parts of the response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you set <c>enableTrace</c> to <c>true</c> in the request, you can trace the agent's
    /// steps and reasoning process that led it to the response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Errors are also surfaced in the response.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class InvokeAgentRequest : AmazonBedrockAgentRuntimeRequest
    {
        private string _agentAliasId;
        private string _agentId;
        private bool? _enableTrace;
        private bool? _endSession;
        private string _inputText;
        private string _sessionId;
        private SessionState _sessionState;

        /// <summary>
        /// Gets and sets the property AgentAliasId. 
        /// <para>
        /// The alias of the agent to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public string AgentAliasId
        {
            get { return this._agentAliasId; }
            set { this._agentAliasId = value; }
        }

        // Check to see if AgentAliasId property is set
        internal bool IsSetAgentAliasId()
        {
            return this._agentAliasId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier of the agent to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public string AgentId
        {
            get { return this._agentId; }
            set { this._agentId = value; }
        }

        // Check to see if AgentId property is set
        internal bool IsSetAgentId()
        {
            return this._agentId != null;
        }

        /// <summary>
        /// Gets and sets the property EnableTrace. 
        /// <para>
        /// Specifies whether to turn on the trace or not to track the agent's reasoning process.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-test.html#trace-events">Trace
        /// enablement</a>.
        /// </para>
        /// </summary>
        public bool EnableTrace
        {
            get { return this._enableTrace.GetValueOrDefault(); }
            set { this._enableTrace = value; }
        }

        // Check to see if EnableTrace property is set
        internal bool IsSetEnableTrace()
        {
            return this._enableTrace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndSession. 
        /// <para>
        /// Specifies whether to end the session with the agent or not.
        /// </para>
        /// </summary>
        public bool EndSession
        {
            get { return this._endSession.GetValueOrDefault(); }
            set { this._endSession = value; }
        }

        // Check to see if EndSession property is set
        internal bool IsSetEndSession()
        {
            return this._endSession.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputText. 
        /// <para>
        /// The prompt text to send the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=25000000)]
        public string InputText
        {
            get { return this._inputText; }
            set { this._inputText = value; }
        }

        // Check to see if InputText property is set
        internal bool IsSetInputText()
        {
            return this._inputText != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session. Use the same value across requests to continue
        /// the same conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=100)]
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

        /// <summary>
        /// Gets and sets the property SessionState. 
        /// <para>
        /// Contains parameters that specify various attributes of the session. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-session-state.html">Control
        /// session context</a>.
        /// </para>
        /// </summary>
        public SessionState SessionState
        {
            get { return this._sessionState; }
            set { this._sessionState = value; }
        }

        // Check to see if SessionState property is set
        internal bool IsSetSessionState()
        {
            return this._sessionState != null;
        }

    }
}