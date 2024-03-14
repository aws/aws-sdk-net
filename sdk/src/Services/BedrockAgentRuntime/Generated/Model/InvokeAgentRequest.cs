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
    /// Invokes the specified Bedrock model to run inference using the input provided in the
    /// request body.
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
        /// Identifier for Agent Alias
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
        /// Identifier for Agent
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
        /// Enable agent trace events for improved debugging
        /// </para>
        /// </summary>
        public bool? EnableTrace
        {
            get { return this._enableTrace; }
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
        /// End current session
        /// </para>
        /// </summary>
        public bool? EndSession
        {
            get { return this._endSession; }
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
        /// Input data in the format specified in the Content-Type request header.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=25000000)]
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
        /// Identifier used for the current session
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
        /// Session state passed by customer. Base64 encoded json string representation of SessionState.
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