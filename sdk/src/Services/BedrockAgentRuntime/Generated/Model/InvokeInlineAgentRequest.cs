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
    /// Container for the parameters to the InvokeInlineAgent operation.
    /// Invokes an inline Amazon Bedrock agent using the configurations you provide with
    /// the request. 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Specify the following fields for security purposes.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// (Optional) <c>customerEncryptionKeyArn</c> – The Amazon Resource Name (ARN) of a KMS
    /// key to encrypt the creation of the agent.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Optional) <c>idleSessionTTLinSeconds</c> – Specify the number of seconds for which
    /// the agent should maintain session information. After this time expires, the subsequent
    /// <c>InvokeInlineAgent</c> request begins a new session.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// To override the default prompt behavior for agent orchestration and to use advanced
    /// prompts, include a <c>promptOverrideConfiguration</c> object. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/advanced-prompts.html">Advanced
    /// prompts</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The agent instructions will not be honored if your agent has only one knowledge base,
    /// uses default prompts, has no action group, and user input is disabled.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// The CLI doesn't support streaming operations in Amazon Bedrock, including <c>InvokeInlineAgent</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class InvokeInlineAgentRequest : AmazonBedrockAgentRuntimeRequest
    {
        private List<AgentActionGroup> _actionGroups = AWSConfigs.InitializeCollections ? new List<AgentActionGroup>() : null;
        private InlineBedrockModelConfigurations _bedrockModelConfigurations;
        private string _customerEncryptionKeyArn;
        private bool? _enableTrace;
        private bool? _endSession;
        private string _foundationModel;
        private GuardrailConfigurationWithArn _guardrailConfiguration;
        private int? _idleSessionTTLInSeconds;
        private InlineSessionState _inlineSessionState;
        private string _inputText;
        private string _instruction;
        private List<KnowledgeBase> _knowledgeBases = AWSConfigs.InitializeCollections ? new List<KnowledgeBase>() : null;
        private PromptOverrideConfiguration _promptOverrideConfiguration;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property ActionGroups. 
        /// <para>
        ///  A list of action groups with each action group defining the action the inline agent
        /// needs to carry out. 
        /// </para>
        /// </summary>
        public List<AgentActionGroup> ActionGroups
        {
            get { return this._actionGroups; }
            set { this._actionGroups = value; }
        }

        // Check to see if ActionGroups property is set
        internal bool IsSetActionGroups()
        {
            return this._actionGroups != null && (this._actionGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BedrockModelConfigurations. 
        /// <para>
        /// Model settings for the request.
        /// </para>
        /// </summary>
        public InlineBedrockModelConfigurations BedrockModelConfigurations
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
        /// Gets and sets the property CustomerEncryptionKeyArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Amazon Web Services KMS key to use to encrypt
        /// your inline agent. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string CustomerEncryptionKeyArn
        {
            get { return this._customerEncryptionKeyArn; }
            set { this._customerEncryptionKeyArn = value; }
        }

        // Check to see if CustomerEncryptionKeyArn property is set
        internal bool IsSetCustomerEncryptionKeyArn()
        {
            return this._customerEncryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property EnableTrace. 
        /// <para>
        ///  Specifies whether to turn on the trace or not to track the agent's reasoning process.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/trace-events.html">Using
        /// trace</a>. <pre><c> &lt;/p&gt; </c></pre>
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
        ///  Specifies whether to end the session with the inline agent or not. 
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
        /// Gets and sets the property FoundationModel. 
        /// <para>
        ///  The <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-ids.html#model-ids-arns">model
        /// identifier (ID)</a> of the model to use for orchestration by the inline agent. For
        /// example, <c>meta.llama3-1-70b-instruct-v1:0</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string FoundationModel
        {
            get { return this._foundationModel; }
            set { this._foundationModel = value; }
        }

        // Check to see if FoundationModel property is set
        internal bool IsSetFoundationModel()
        {
            return this._foundationModel != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailConfiguration. 
        /// <para>
        ///  The <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails.html">guardrails</a>
        /// to assign to the inline agent. 
        /// </para>
        /// </summary>
        public GuardrailConfigurationWithArn GuardrailConfiguration
        {
            get { return this._guardrailConfiguration; }
            set { this._guardrailConfiguration = value; }
        }

        // Check to see if GuardrailConfiguration property is set
        internal bool IsSetGuardrailConfiguration()
        {
            return this._guardrailConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IdleSessionTTLInSeconds. 
        /// <para>
        ///  The number of seconds for which the inline agent should maintain session information.
        /// After this time expires, the subsequent <c>InvokeInlineAgent</c> request begins a
        /// new session. 
        /// </para>
        ///  
        /// <para>
        /// A user interaction remains active for the amount of time specified. If no conversation
        /// occurs during this time, the session expires and the data provided before the timeout
        /// is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=3600)]
        public int IdleSessionTTLInSeconds
        {
            get { return this._idleSessionTTLInSeconds.GetValueOrDefault(); }
            set { this._idleSessionTTLInSeconds = value; }
        }

        // Check to see if IdleSessionTTLInSeconds property is set
        internal bool IsSetIdleSessionTTLInSeconds()
        {
            return this._idleSessionTTLInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InlineSessionState. 
        /// <para>
        ///  Parameters that specify the various attributes of a sessions. You can include attributes
        /// for the session or prompt or, if you configured an action group to return control,
        /// results from invocation of the action group. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-session-state.html">Control
        /// session context</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you include <c>returnControlInvocationResults</c> in the <c>sessionState</c> field,
        /// the <c>inputText</c> field will be ignored.
        /// </para>
        ///  </note>
        /// </summary>
        public InlineSessionState InlineSessionState
        {
            get { return this._inlineSessionState; }
            set { this._inlineSessionState = value; }
        }

        // Check to see if InlineSessionState property is set
        internal bool IsSetInlineSessionState()
        {
            return this._inlineSessionState != null;
        }

        /// <summary>
        /// Gets and sets the property InputText. 
        /// <para>
        ///  The prompt text to send to the agent. 
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
        /// Gets and sets the property Instruction. 
        /// <para>
        ///  The instructions that tell the inline agent what it should do and how it should interact
        /// with users. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=40)]
        public string Instruction
        {
            get { return this._instruction; }
            set { this._instruction = value; }
        }

        // Check to see if Instruction property is set
        internal bool IsSetInstruction()
        {
            return this._instruction != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBases. 
        /// <para>
        ///  Contains information of the knowledge bases to associate with. 
        /// </para>
        /// </summary>
        public List<KnowledgeBase> KnowledgeBases
        {
            get { return this._knowledgeBases; }
            set { this._knowledgeBases = value; }
        }

        // Check to see if KnowledgeBases property is set
        internal bool IsSetKnowledgeBases()
        {
            return this._knowledgeBases != null && (this._knowledgeBases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PromptOverrideConfiguration. 
        /// <para>
        ///  Configurations for advanced prompts used to override the default prompts to enhance
        /// the accuracy of the inline agent. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public PromptOverrideConfiguration PromptOverrideConfiguration
        {
            get { return this._promptOverrideConfiguration; }
            set { this._promptOverrideConfiguration = value; }
        }

        // Check to see if PromptOverrideConfiguration property is set
        internal bool IsSetPromptOverrideConfiguration()
        {
            return this._promptOverrideConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        ///  The unique identifier of the session. Use the same value across requests to continue
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

    }
}