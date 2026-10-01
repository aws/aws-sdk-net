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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Contextual attributes capturing operation details, LLM configuration, usage metrics,
    /// and conversation data
    /// </summary>
    public partial class SpanAttributes
    {
        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// Amazon Connect agent ID
        /// </para>
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

        /// <summary>
        /// Gets and sets the property AiAgentArn. 
        /// <para>
        /// AI agent ARN
        /// </para>
        /// </summary>
        public string AiAgentArn { get; set; }

        /// <summary>
        /// Checks to see if the AiAgentArn property is set.
        /// </summary>
        internal bool IsSetAiAgentArn() => this.AiAgentArn != null;

        /// <summary>
        /// Gets and sets the property AiAgentId. 
        /// <para>
        /// AI agent identifier
        /// </para>
        /// </summary>
        public string AiAgentId { get; set; }

        /// <summary>
        /// Checks to see if the AiAgentId property is set.
        /// </summary>
        internal bool IsSetAiAgentId() => this.AiAgentId != null;

        /// <summary>
        /// Gets and sets the property AiAgentInvoker. 
        /// <para>
        /// Entity that invoked the AI agent
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string AiAgentInvoker { get; set; }

        /// <summary>
        /// Checks to see if the AiAgentInvoker property is set.
        /// </summary>
        internal bool IsSetAiAgentInvoker() => this.AiAgentInvoker != null;

        /// <summary>
        /// Gets and sets the property AiAgentName. 
        /// <para>
        /// AI agent name
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AiAgentName { get; set; }

        /// <summary>
        /// Checks to see if the AiAgentName property is set.
        /// </summary>
        internal bool IsSetAiAgentName() => this.AiAgentName != null;

        /// <summary>
        /// Gets and sets the property AiAgentOrchestratorUseCase. 
        /// <para>
        /// AI agent orchestrator use case
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string AiAgentOrchestratorUseCase { get; set; }

        /// <summary>
        /// Checks to see if the AiAgentOrchestratorUseCase property is set.
        /// </summary>
        internal bool IsSetAiAgentOrchestratorUseCase() => this.AiAgentOrchestratorUseCase != null;

        /// <summary>
        /// Gets and sets the property AiAgentType. 
        /// <para>
        /// AI agent type
        /// </para>
        /// </summary>
        public AIAgentType AiAgentType { get; set; }

        /// <summary>
        /// Checks to see if the AiAgentType property is set.
        /// </summary>
        internal bool IsSetAiAgentType() => this.AiAgentType != null;

        /// <summary>
        /// Gets and sets the property AiAgentVersion. 
        /// <para>
        /// AI agent version number
        /// </para>
        /// </summary>
        public int? AiAgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AiAgentVersion property is set.
        /// </summary>
        internal bool IsSetAiAgentVersion() => this.AiAgentVersion.HasValue;

        /// <summary>
        /// Gets and sets the property CacheReadInputTokens. 
        /// <para>
        /// Number of input tokens that were retrieved from cache
        /// </para>
        /// </summary>
        public int? CacheReadInputTokens { get; set; }

        /// <summary>
        /// Checks to see if the CacheReadInputTokens property is set.
        /// </summary>
        internal bool IsSetCacheReadInputTokens() => this.CacheReadInputTokens.HasValue;

        /// <summary>
        /// Gets and sets the property CacheWriteInputTokens. 
        /// <para>
        /// Number of input tokens that were written to cache in this request
        /// </para>
        /// </summary>
        public int? CacheWriteInputTokens { get; set; }

        /// <summary>
        /// Checks to see if the CacheWriteInputTokens property is set.
        /// </summary>
        internal bool IsSetCacheWriteInputTokens() => this.CacheWriteInputTokens.HasValue;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// Amazon Connect contact identifier
        /// </para>
        /// </summary>
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property ErrorType. 
        /// <para>
        /// Error classification if span failed (e.g., throttle, timeout)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string ErrorType { get; set; }

        /// <summary>
        /// Checks to see if the ErrorType property is set.
        /// </summary>
        internal bool IsSetErrorType() => this.ErrorType != null;

        /// <summary>
        /// Gets and sets the property GuardrailAssessments. 
        /// <para>
        /// Guardrail assessments for the inference span. Absent on other span types and when
        /// no AI Guardrail is attached to the AI Agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<SpanGuardrailAssessment> GuardrailAssessments { get; set; } = AWSConfigs.InitializeCollections ? new List<SpanGuardrailAssessment>() : null;

        /// <summary>
        /// Checks to see if the GuardrailAssessments property is set.
        /// </summary>
        internal bool IsSetGuardrailAssessments() => this.GuardrailAssessments != null && (this.GuardrailAssessments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InitialContactId. 
        /// <para>
        /// Amazon Connect contact identifier
        /// </para>
        /// </summary>
        public string InitialContactId { get; set; }

        /// <summary>
        /// Checks to see if the InitialContactId property is set.
        /// </summary>
        internal bool IsSetInitialContactId() => this.InitialContactId != null;

        /// <summary>
        /// Gets and sets the property InputMessages. 
        /// <para>
        /// Input message collection sent to LLM
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<SpanMessage> InputMessages { get; set; } = AWSConfigs.InitializeCollections ? new List<SpanMessage>() : null;

        /// <summary>
        /// Checks to see if the InputMessages property is set.
        /// </summary>
        internal bool IsSetInputMessages() => this.InputMessages != null && (this.InputMessages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// Amazon Connect instance ARN
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property InteractionMode. 
        /// <para>
        /// How the orchestrator engaged the collaborator agent. Present on spans that invoke
        /// a collaborator agent.
        /// </para>
        /// </summary>
        public InteractionMode InteractionMode { get; set; }

        /// <summary>
        /// Checks to see if the InteractionMode property is set.
        /// </summary>
        internal bool IsSetInteractionMode() => this.InteractionMode != null;

        /// <summary>
        /// Gets and sets the property OperationName. 
        /// <para>
        /// Action being performed
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string OperationName { get; set; }

        /// <summary>
        /// Checks to see if the OperationName property is set.
        /// </summary>
        internal bool IsSetOperationName() => this.OperationName != null;

        /// <summary>
        /// Gets and sets the property OutputMessages. 
        /// <para>
        /// Output message collection received from LLM
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<SpanMessage> OutputMessages { get; set; } = AWSConfigs.InitializeCollections ? new List<SpanMessage>() : null;

        /// <summary>
        /// Checks to see if the OutputMessages property is set.
        /// </summary>
        internal bool IsSetOutputMessages() => this.OutputMessages != null && (this.OutputMessages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PromptArn. 
        /// <para>
        /// AI prompt ARN
        /// </para>
        /// </summary>
        public string PromptArn { get; set; }

        /// <summary>
        /// Checks to see if the PromptArn property is set.
        /// </summary>
        internal bool IsSetPromptArn() => this.PromptArn != null;

        /// <summary>
        /// Gets and sets the property PromptId. 
        /// <para>
        /// AI prompt identifier
        /// </para>
        /// </summary>
        public string PromptId { get; set; }

        /// <summary>
        /// Checks to see if the PromptId property is set.
        /// </summary>
        internal bool IsSetPromptId() => this.PromptId != null;

        /// <summary>
        /// Gets and sets the property PromptName. 
        /// <para>
        /// AI prompt name
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PromptName { get; set; }

        /// <summary>
        /// Checks to see if the PromptName property is set.
        /// </summary>
        internal bool IsSetPromptName() => this.PromptName != null;

        /// <summary>
        /// Gets and sets the property PromptType. 
        /// <para>
        /// AI prompt type
        /// </para>
        /// </summary>
        public AIPromptType PromptType { get; set; }

        /// <summary>
        /// Checks to see if the PromptType property is set.
        /// </summary>
        internal bool IsSetPromptType() => this.PromptType != null;

        /// <summary>
        /// Gets and sets the property PromptVersion. 
        /// <para>
        /// AI prompt version number
        /// </para>
        /// </summary>
        public int? PromptVersion { get; set; }

        /// <summary>
        /// Checks to see if the PromptVersion property is set.
        /// </summary>
        internal bool IsSetPromptVersion() => this.PromptVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// Model provider identifier (e.g., aws.bedrock)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderName property is set.
        /// </summary>
        internal bool IsSetProviderName() => this.ProviderName != null;

        /// <summary>
        /// Gets and sets the property RequestMaxTokens. 
        /// <para>
        /// Maximum tokens configured for generation
        /// </para>
        /// </summary>
        public int? RequestMaxTokens { get; set; }

        /// <summary>
        /// Checks to see if the RequestMaxTokens property is set.
        /// </summary>
        internal bool IsSetRequestMaxTokens() => this.RequestMaxTokens.HasValue;

        /// <summary>
        /// Gets and sets the property RequestModel. 
        /// <para>
        /// LLM model ID for request (e.g., anthropic.claude-3-sonnet)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string RequestModel { get; set; }

        /// <summary>
        /// Checks to see if the RequestModel property is set.
        /// </summary>
        internal bool IsSetRequestModel() => this.RequestModel != null;

        /// <summary>
        /// Gets and sets the property ResponseFinishReasons. 
        /// <para>
        /// Generation termination reasons (e.g., stop, max_tokens)
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> ResponseFinishReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResponseFinishReasons property is set.
        /// </summary>
        internal bool IsSetResponseFinishReasons() => this.ResponseFinishReasons != null && (this.ResponseFinishReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResponseModel. 
        /// <para>
        /// Actual model used for response (usually matches requestModel)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string ResponseModel { get; set; }

        /// <summary>
        /// Checks to see if the ResponseModel property is set.
        /// </summary>
        internal bool IsSetResponseModel() => this.ResponseModel != null;

        /// <summary>
        /// Gets and sets the property ReturnReason. 
        /// <para>
        /// Reason a sub-agent returned control to the calling agent. Present on return_to_agent
        /// spans.
        /// </para>
        /// </summary>
        public ReturnReason ReturnReason { get; set; }

        /// <summary>
        /// Checks to see if the ReturnReason property is set.
        /// </summary>
        internal bool IsSetReturnReason() => this.ReturnReason != null;

        /// <summary>
        /// Gets and sets the property SessionName. 
        /// <para>
        /// Session name
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string SessionName { get; set; }

        /// <summary>
        /// Checks to see if the SessionName property is set.
        /// </summary>
        internal bool IsSetSessionName() => this.SessionName != null;

        /// <summary>
        /// Gets and sets the property SystemInstructions. 
        /// <para>
        /// System prompt instructions
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<SpanMessageValue> SystemInstructions { get; set; } = AWSConfigs.InitializeCollections ? new List<SpanMessageValue>() : null;

        /// <summary>
        /// Checks to see if the SystemInstructions property is set.
        /// </summary>
        internal bool IsSetSystemInstructions() => this.SystemInstructions != null && (this.SystemInstructions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetAgentId. 
        /// <para>
        /// Identifier of the collaborator agent being invoked. For first-party collaborators
        /// this is the Amazon Connect AI agent ID; for third-party collaborators this is the
        /// external application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string TargetAgentId { get; set; }

        /// <summary>
        /// Checks to see if the TargetAgentId property is set.
        /// </summary>
        internal bool IsSetTargetAgentId() => this.TargetAgentId != null;

        /// <summary>
        /// Gets and sets the property Temperature. 
        /// <para>
        /// Sampling temperature for generation
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public float? Temperature { get; set; }

        /// <summary>
        /// Checks to see if the Temperature property is set.
        /// </summary>
        internal bool IsSetTemperature() => this.Temperature.HasValue;

        /// <summary>
        /// Gets and sets the property TimeToFirstTokenMs. 
        /// <para>
        /// Time to first token in milliseconds, measured from when Amazon Bedrock was invoked
        /// to when the first token was returned
        /// </para>
        /// </summary>
        public int? TimeToFirstTokenMs { get; set; }

        /// <summary>
        /// Checks to see if the TimeToFirstTokenMs property is set.
        /// </summary>
        internal bool IsSetTimeToFirstTokenMs() => this.TimeToFirstTokenMs.HasValue;

        /// <summary>
        /// Gets and sets the property TopP. 
        /// <para>
        /// Top-p sampling parameter for generation
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public float? TopP { get; set; }

        /// <summary>
        /// Checks to see if the TopP property is set.
        /// </summary>
        internal bool IsSetTopP() => this.TopP.HasValue;

        /// <summary>
        /// Gets and sets the property UsageInputTokens. 
        /// <para>
        /// Number of input tokens in prompt
        /// </para>
        /// </summary>
        public int? UsageInputTokens { get; set; }

        /// <summary>
        /// Checks to see if the UsageInputTokens property is set.
        /// </summary>
        internal bool IsSetUsageInputTokens() => this.UsageInputTokens.HasValue;

        /// <summary>
        /// Gets and sets the property UsageOutputTokens. 
        /// <para>
        /// Number of output tokens in response
        /// </para>
        /// </summary>
        public int? UsageOutputTokens { get; set; }

        /// <summary>
        /// Checks to see if the UsageOutputTokens property is set.
        /// </summary>
        internal bool IsSetUsageOutputTokens() => this.UsageOutputTokens.HasValue;

        /// <summary>
        /// Gets and sets the property UsageTotalTokens. 
        /// <para>
        /// Total tokens consumed (input + output)
        /// </para>
        /// </summary>
        public int? UsageTotalTokens { get; set; }

        /// <summary>
        /// Checks to see if the UsageTotalTokens property is set.
        /// </summary>
        internal bool IsSetUsageTotalTokens() => this.UsageTotalTokens.HasValue;
    }
}
