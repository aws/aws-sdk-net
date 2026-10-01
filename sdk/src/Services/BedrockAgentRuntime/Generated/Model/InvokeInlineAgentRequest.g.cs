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
    /// Container for the parameters to the InvokeInlineAgent operation. Invokes an inline
    /// Amazon Bedrock agent using the configurations you provide with the request. <ul> <li>
    /// <para> Specify the following fields for security purposes. </para> <ul> <li> <para>
    /// (Optional) <c>customerEncryptionKeyArn</c> – The Amazon Resource Name (ARN) of a KMS
    /// key to encrypt the creation of the agent. </para> </li> <li> <para> (Optional) <c>idleSessionTTLinSeconds</c>
    /// – Specify the number of seconds for which the agent should maintain session information.
    /// After this time expires, the subsequent <c>InvokeInlineAgent</c> request begins a
    /// new session. </para> </li> </ul> </li> <li> <para> To override the default prompt
    /// behavior for agent orchestration and to use advanced prompts, include a <c>promptOverrideConfiguration</c>
    /// object. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/advanced-prompts.html">Advanced
    /// prompts</a>. </para> </li> <li> <para> The agent instructions will not be honored
    /// if your agent has only one knowledge base, uses default prompts, has no action group,
    /// and user input is disabled. </para> </li> </ul> <note> </note>
    /// </summary>
    public partial class InvokeInlineAgentRequest : AmazonBedrockAgentRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property ActionGroups. 
        /// <para>
        ///  A list of action groups with each action group defining the action the inline agent
        /// needs to carry out. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgentActionGroup> ActionGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<AgentActionGroup>() : null;

        /// <summary>
        /// Checks to see if the ActionGroups property is set.
        /// </summary>
        internal bool IsSetActionGroups() => this.ActionGroups != null && (this.ActionGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AgentCollaboration. 
        /// <para>
        ///  Defines how the inline collaborator agent handles information across multiple collaborator
        /// agents to coordinate a final response. The inline collaborator agent can also be the
        /// supervisor. 
        /// </para>
        /// </summary>
        public AgentCollaboration AgentCollaboration { get; set; }

        /// <summary>
        /// Checks to see if the AgentCollaboration property is set.
        /// </summary>
        internal bool IsSetAgentCollaboration() => this.AgentCollaboration != null;

        /// <summary>
        /// Gets and sets the property AgentName. 
        /// <para>
        /// The name for the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string AgentName { get; set; }

        /// <summary>
        /// Checks to see if the AgentName property is set.
        /// </summary>
        internal bool IsSetAgentName() => this.AgentName != null;

        /// <summary>
        /// Gets and sets the property BedrockModelConfigurations. 
        /// <para>
        /// Model settings for the request.
        /// </para>
        /// </summary>
        public InlineBedrockModelConfigurations BedrockModelConfigurations { get; set; }

        /// <summary>
        /// Checks to see if the BedrockModelConfigurations property is set.
        /// </summary>
        internal bool IsSetBedrockModelConfigurations() => this.BedrockModelConfigurations != null;

        /// <summary>
        /// Gets and sets the property CollaboratorConfigurations. 
        /// <para>
        ///  Settings for an inline agent collaborator called with <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeInlineAgent.html">InvokeInlineAgent</a>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CollaboratorConfiguration> CollaboratorConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<CollaboratorConfiguration>() : null;

        /// <summary>
        /// Checks to see if the CollaboratorConfigurations property is set.
        /// </summary>
        internal bool IsSetCollaboratorConfigurations() => this.CollaboratorConfigurations != null && (this.CollaboratorConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Collaborators. 
        /// <para>
        ///  List of collaborator inline agents. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Collaborator> Collaborators { get; set; } = AWSConfigs.InitializeCollections ? new List<Collaborator>() : null;

        /// <summary>
        /// Checks to see if the Collaborators property is set.
        /// </summary>
        internal bool IsSetCollaborators() => this.Collaborators != null && (this.Collaborators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomOrchestration. 
        /// <para>
        /// Contains details of the custom orchestration configured for the agent. 
        /// </para>
        /// </summary>
        public CustomOrchestration CustomOrchestration { get; set; }

        /// <summary>
        /// Checks to see if the CustomOrchestration property is set.
        /// </summary>
        internal bool IsSetCustomOrchestration() => this.CustomOrchestration != null;

        /// <summary>
        /// Gets and sets the property CustomerEncryptionKeyArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Amazon Web Services KMS key to use to encrypt
        /// your inline agent. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CustomerEncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomerEncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetCustomerEncryptionKeyArn() => this.CustomerEncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property EnableTrace. 
        /// <para>
        ///  Specifies whether to turn on the trace or not to track the agent's reasoning process.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/trace-events.html">Using
        /// trace</a>. 
        /// </para>
        /// </summary>
        public bool? EnableTrace { get; set; }

        /// <summary>
        /// Checks to see if the EnableTrace property is set.
        /// </summary>
        internal bool IsSetEnableTrace() => this.EnableTrace.HasValue;

        /// <summary>
        /// Gets and sets the property EndSession. 
        /// <para>
        ///  Specifies whether to end the session with the inline agent or not. 
        /// </para>
        /// </summary>
        public bool? EndSession { get; set; }

        /// <summary>
        /// Checks to see if the EndSession property is set.
        /// </summary>
        internal bool IsSetEndSession() => this.EndSession.HasValue;

        /// <summary>
        /// Gets and sets the property FoundationModel. 
        /// <para>
        ///  The <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-ids.html#model-ids-arns">model
        /// identifier (ID)</a> of the model to use for orchestration by the inline agent. For
        /// example, <c>meta.llama3-1-70b-instruct-v1:0</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string FoundationModel { get; set; }

        /// <summary>
        /// Checks to see if the FoundationModel property is set.
        /// </summary>
        internal bool IsSetFoundationModel() => this.FoundationModel != null;

        /// <summary>
        /// Gets and sets the property GuardrailConfiguration. 
        /// <para>
        ///  The <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails.html">guardrails</a>
        /// to assign to the inline agent. 
        /// </para>
        /// </summary>
        public GuardrailConfigurationWithArn GuardrailConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailConfiguration property is set.
        /// </summary>
        internal bool IsSetGuardrailConfiguration() => this.GuardrailConfiguration != null;

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
        [AWSProperty(Min = 60, Max = 3600)]
        public int? IdleSessionTTLInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IdleSessionTTLInSeconds property is set.
        /// </summary>
        internal bool IsSetIdleSessionTTLInSeconds() => this.IdleSessionTTLInSeconds.HasValue;

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
        public InlineSessionState InlineSessionState { get; set; }

        /// <summary>
        /// Checks to see if the InlineSessionState property is set.
        /// </summary>
        internal bool IsSetInlineSessionState() => this.InlineSessionState != null;

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
        [AWSProperty(Sensitive = true, Max = 25000000)]
        public string InputText { get; set; }

        /// <summary>
        /// Checks to see if the InputText property is set.
        /// </summary>
        internal bool IsSetInputText() => this.InputText != null;

        /// <summary>
        /// Gets and sets the property Instruction. 
        /// <para>
        ///  The instructions that tell the inline agent what it should do and how it should interact
        /// with users. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 40)]
        public string Instruction { get; set; }

        /// <summary>
        /// Checks to see if the Instruction property is set.
        /// </summary>
        internal bool IsSetInstruction() => this.Instruction != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBases. 
        /// <para>
        ///  Contains information of the knowledge bases to associate with. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KnowledgeBase> KnowledgeBases { get; set; } = AWSConfigs.InitializeCollections ? new List<KnowledgeBase>() : null;

        /// <summary>
        /// Checks to see if the KnowledgeBases property is set.
        /// </summary>
        internal bool IsSetKnowledgeBases() => this.KnowledgeBases != null && (this.KnowledgeBases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrchestrationType. 
        /// <para>
        /// Specifies the type of orchestration strategy for the agent. This is set to DEFAULT
        /// orchestration type, by default. 
        /// </para>
        /// </summary>
        public OrchestrationType OrchestrationType { get; set; }

        /// <summary>
        /// Checks to see if the OrchestrationType property is set.
        /// </summary>
        internal bool IsSetOrchestrationType() => this.OrchestrationType != null;

        /// <summary>
        /// Gets and sets the property PromptCreationConfigurations. 
        /// <para>
        /// Specifies parameters that control how the service populates the agent prompt for an
        /// <c>InvokeInlineAgent</c> request. You can control which aspects of previous invocations
        /// in the same agent session the service uses to populate the agent prompt. This gives
        /// you more granular control over the contextual history that is used to process the
        /// current request.
        /// </para>
        /// </summary>
        public PromptCreationConfigurations PromptCreationConfigurations { get; set; }

        /// <summary>
        /// Checks to see if the PromptCreationConfigurations property is set.
        /// </summary>
        internal bool IsSetPromptCreationConfigurations() => this.PromptCreationConfigurations != null;

        /// <summary>
        /// Gets and sets the property PromptOverrideConfiguration. 
        /// <para>
        ///  Configurations for advanced prompts used to override the default prompts to enhance
        /// the accuracy of the inline agent. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public PromptOverrideConfiguration PromptOverrideConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PromptOverrideConfiguration property is set.
        /// </summary>
        internal bool IsSetPromptOverrideConfiguration() => this.PromptOverrideConfiguration != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        ///  The unique identifier of the session. Use the same value across requests to continue
        /// the same conversation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

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
        public StreamingConfigurations StreamingConfigurations { get; set; }

        /// <summary>
        /// Checks to see if the StreamingConfigurations property is set.
        /// </summary>
        internal bool IsSetStreamingConfigurations() => this.StreamingConfigurations != null;
    }
}
