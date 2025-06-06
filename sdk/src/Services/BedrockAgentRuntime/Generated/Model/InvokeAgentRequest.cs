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
    /// Container for the parameters to the InvokeAgent operation.
    /// <note> </note> 
    /// <para>
    /// Sends a prompt for the agent to process and respond to. Note the following fields
    /// for the request:
    /// 
    ///  <ul> <li> 
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
    /// or, if you configured an action group to return control, results from invocation of
    /// the action group.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The response contains both <b>chunk</b> and <b>trace</b> attributes.
    /// </para>
    ///  
    /// <para>
    /// The final response is returned in the <c>bytes</c> field of the <c>chunk</c> object.
    /// The <c>InvokeAgent</c> returns one chunk for the entire interaction.
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
    /// If the action predicted was configured to return control, the response returns parameters
    /// for the action, elicited from the user, in the <c>returnControl</c> field.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Errors are also surfaced in the response.
    /// </para>
    ///  </li> </ul>
    /// </para>
    /// </summary>
    public partial class InvokeAgentRequest : AmazonBedrockAgentRuntimeRequest
    {
        private string _agentAliasId;
        private string _agentId;
        private BedrockModelConfigurations _bedrockModelConfigurations;
        private bool? _enableTrace;
        private bool? _endSession;
        private string _inputText;
        private string _memoryId;
        private PromptCreationConfigurations _promptCreationConfigurations;
        private string _sessionId;
        private SessionState _sessionState;
        private string _sourceArn;
        private StreamingConfigurations _streamingConfigurations;

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
        /// Gets and sets the property BedrockModelConfigurations. 
        /// <para>
        /// Model performance settings for the request.
        /// </para>
        /// </summary>
        public BedrockModelConfigurations BedrockModelConfigurations
        {
            get { return this._bedrockModelConfigurations; }
            set { this._bedrockModelConfigurations = value; }
        }

        // Check to see if BedrockModelConfigurations property is set
        internal bool IsSetBedrockModelConfigurations()
        {
            return this._bedrockModelConfigurations != null;
        }

        /// <summary>
        /// Gets and sets the property EnableTrace. 
        /// <para>
        /// Specifies whether to turn on the trace or not to track the agent's reasoning process.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-test.html#trace-events">Trace
        /// enablement</a>.
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
        /// Specifies whether to end the session with the agent or not.
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
        /// The prompt text to send the agent.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you include <c>returnControlInvocationResults</c> in the <c>sessionState</c> field,
        /// the <c>inputText</c> field will be ignored.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The unique identifier of the agent memory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string MemoryId
        {
            get { return this._memoryId; }
            set { this._memoryId = value; }
        }

        // Check to see if MemoryId property is set
        internal bool IsSetMemoryId()
        {
            return this._memoryId != null;
        }

        /// <summary>
        /// Gets and sets the property PromptCreationConfigurations. 
        /// <para>
        /// Specifies parameters that control how the service populates the agent prompt for an
        /// <c>InvokeAgent</c> request. You can control which aspects of previous invocations
        /// in the same agent session the service uses to populate the agent prompt. This gives
        /// you more granular control over the contextual history that is used to process the
        /// current request.
        /// </para>
        /// </summary>
        public PromptCreationConfigurations PromptCreationConfigurations
        {
            get { return this._promptCreationConfigurations; }
            set { this._promptCreationConfigurations = value; }
        }

        // Check to see if PromptCreationConfigurations property is set
        internal bool IsSetPromptCreationConfigurations()
        {
            return this._promptCreationConfigurations != null;
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
        ///  <note> 
        /// <para>
        /// If you include <c>returnControlInvocationResults</c> in the <c>sessionState</c> field,
        /// the <c>inputText</c> field will be ignored.
        /// </para>
        ///  </note>
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

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The ARN of the resource making the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property StreamingConfigurations. 
        /// <para>
        ///  Specifies the configurations for streaming. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To use agent streaming, you need permissions to perform the <c>bedrock:InvokeModelWithResponseStream</c>
        /// action.
        /// </para>
        ///  </note>
        /// </summary>
        public StreamingConfigurations StreamingConfigurations
        {
            get { return this._streamingConfigurations; }
            set { this._streamingConfigurations = value; }
        }

        // Check to see if StreamingConfigurations property is set
        internal bool IsSetStreamingConfigurations()
        {
            return this._streamingConfigurations != null;
        }

    }
}