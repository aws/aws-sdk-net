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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
        private string _agentId;
        private string _aiAgentArn;
        private string _aiAgentId;
        private string _aiAgentInvoker;
        private string _aiAgentName;
        private string _aiAgentOrchestratorUseCase;
        private AIAgentType _aiAgentType;
        private int? _aiAgentVersion;
        private int? _cacheReadInputTokens;
        private int? _cacheWriteInputTokens;
        private string _contactId;
        private string _errorType;
        private string _initialContactId;
        private List<SpanMessage> _inputMessages = AWSConfigs.InitializeCollections ? new List<SpanMessage>() : null;
        private string _instanceArn;
        private string _operationName;
        private List<SpanMessage> _outputMessages = AWSConfigs.InitializeCollections ? new List<SpanMessage>() : null;
        private string _promptArn;
        private string _promptId;
        private string _promptName;
        private AIPromptType _promptType;
        private int? _promptVersion;
        private string _providerName;
        private int? _requestMaxTokens;
        private string _requestModel;
        private List<string> _responseFinishReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _responseModel;
        private string _sessionName;
        private List<SpanMessageValue> _systemInstructions = AWSConfigs.InitializeCollections ? new List<SpanMessageValue>() : null;
        private float? _temperature;
        private float? _topp;
        private int? _usageInputTokens;
        private int? _usageOutputTokens;
        private int? _usageTotalTokens;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// Amazon Connect agent ID
        /// </para>
        /// </summary>
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
        /// Gets and sets the property AiAgentArn. 
        /// <para>
        /// AI agent ARN
        /// </para>
        /// </summary>
        public string AiAgentArn
        {
            get { return this._aiAgentArn; }
            set { this._aiAgentArn = value; }
        }

        // Check to see if AiAgentArn property is set
        internal bool IsSetAiAgentArn()
        {
            return this._aiAgentArn != null;
        }

        /// <summary>
        /// Gets and sets the property AiAgentId. 
        /// <para>
        /// AI agent identifier
        /// </para>
        /// </summary>
        public string AiAgentId
        {
            get { return this._aiAgentId; }
            set { this._aiAgentId = value; }
        }

        // Check to see if AiAgentId property is set
        internal bool IsSetAiAgentId()
        {
            return this._aiAgentId != null;
        }

        /// <summary>
        /// Gets and sets the property AiAgentInvoker. 
        /// <para>
        /// Entity that invoked the AI agent
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string AiAgentInvoker
        {
            get { return this._aiAgentInvoker; }
            set { this._aiAgentInvoker = value; }
        }

        // Check to see if AiAgentInvoker property is set
        internal bool IsSetAiAgentInvoker()
        {
            return this._aiAgentInvoker != null;
        }

        /// <summary>
        /// Gets and sets the property AiAgentName. 
        /// <para>
        /// AI agent name
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AiAgentName
        {
            get { return this._aiAgentName; }
            set { this._aiAgentName = value; }
        }

        // Check to see if AiAgentName property is set
        internal bool IsSetAiAgentName()
        {
            return this._aiAgentName != null;
        }

        /// <summary>
        /// Gets and sets the property AiAgentOrchestratorUseCase. 
        /// <para>
        /// AI agent orchestrator use case
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string AiAgentOrchestratorUseCase
        {
            get { return this._aiAgentOrchestratorUseCase; }
            set { this._aiAgentOrchestratorUseCase = value; }
        }

        // Check to see if AiAgentOrchestratorUseCase property is set
        internal bool IsSetAiAgentOrchestratorUseCase()
        {
            return this._aiAgentOrchestratorUseCase != null;
        }

        /// <summary>
        /// Gets and sets the property AiAgentType. 
        /// <para>
        /// AI agent type
        /// </para>
        /// </summary>
        public AIAgentType AiAgentType
        {
            get { return this._aiAgentType; }
            set { this._aiAgentType = value; }
        }

        // Check to see if AiAgentType property is set
        internal bool IsSetAiAgentType()
        {
            return this._aiAgentType != null;
        }

        /// <summary>
        /// Gets and sets the property AiAgentVersion. 
        /// <para>
        /// AI agent version number
        /// </para>
        /// </summary>
        public int? AiAgentVersion
        {
            get { return this._aiAgentVersion; }
            set { this._aiAgentVersion = value; }
        }

        // Check to see if AiAgentVersion property is set
        internal bool IsSetAiAgentVersion()
        {
            return this._aiAgentVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheReadInputTokens. 
        /// <para>
        /// Number of input tokens that were retrieved from cache
        /// </para>
        /// </summary>
        public int? CacheReadInputTokens
        {
            get { return this._cacheReadInputTokens; }
            set { this._cacheReadInputTokens = value; }
        }

        // Check to see if CacheReadInputTokens property is set
        internal bool IsSetCacheReadInputTokens()
        {
            return this._cacheReadInputTokens.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheWriteInputTokens. 
        /// <para>
        /// Number of input tokens that were written to cache in this request
        /// </para>
        /// </summary>
        public int? CacheWriteInputTokens
        {
            get { return this._cacheWriteInputTokens; }
            set { this._cacheWriteInputTokens = value; }
        }

        // Check to see if CacheWriteInputTokens property is set
        internal bool IsSetCacheWriteInputTokens()
        {
            return this._cacheWriteInputTokens.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// Amazon Connect contact identifier
        /// </para>
        /// </summary>
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorType. 
        /// <para>
        /// Error classification if span failed (e.g., throttle, timeout)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string ErrorType
        {
            get { return this._errorType; }
            set { this._errorType = value; }
        }

        // Check to see if ErrorType property is set
        internal bool IsSetErrorType()
        {
            return this._errorType != null;
        }

        /// <summary>
        /// Gets and sets the property InitialContactId. 
        /// <para>
        /// Amazon Connect contact identifier
        /// </para>
        /// </summary>
        public string InitialContactId
        {
            get { return this._initialContactId; }
            set { this._initialContactId = value; }
        }

        // Check to see if InitialContactId property is set
        internal bool IsSetInitialContactId()
        {
            return this._initialContactId != null;
        }

        /// <summary>
        /// Gets and sets the property InputMessages. 
        /// <para>
        /// Input message collection sent to LLM
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<SpanMessage> InputMessages
        {
            get { return this._inputMessages; }
            set { this._inputMessages = value; }
        }

        // Check to see if InputMessages property is set
        internal bool IsSetInputMessages()
        {
            return this._inputMessages != null && (this._inputMessages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// Amazon Connect instance ARN
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property OperationName. 
        /// <para>
        /// Action being performed
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string OperationName
        {
            get { return this._operationName; }
            set { this._operationName = value; }
        }

        // Check to see if OperationName property is set
        internal bool IsSetOperationName()
        {
            return this._operationName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputMessages. 
        /// <para>
        /// Output message collection received from LLM
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<SpanMessage> OutputMessages
        {
            get { return this._outputMessages; }
            set { this._outputMessages = value; }
        }

        // Check to see if OutputMessages property is set
        internal bool IsSetOutputMessages()
        {
            return this._outputMessages != null && (this._outputMessages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PromptArn. 
        /// <para>
        /// AI prompt ARN
        /// </para>
        /// </summary>
        public string PromptArn
        {
            get { return this._promptArn; }
            set { this._promptArn = value; }
        }

        // Check to see if PromptArn property is set
        internal bool IsSetPromptArn()
        {
            return this._promptArn != null;
        }

        /// <summary>
        /// Gets and sets the property PromptId. 
        /// <para>
        /// AI prompt identifier
        /// </para>
        /// </summary>
        public string PromptId
        {
            get { return this._promptId; }
            set { this._promptId = value; }
        }

        // Check to see if PromptId property is set
        internal bool IsSetPromptId()
        {
            return this._promptId != null;
        }

        /// <summary>
        /// Gets and sets the property PromptName. 
        /// <para>
        /// AI prompt name
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PromptName
        {
            get { return this._promptName; }
            set { this._promptName = value; }
        }

        // Check to see if PromptName property is set
        internal bool IsSetPromptName()
        {
            return this._promptName != null;
        }

        /// <summary>
        /// Gets and sets the property PromptType. 
        /// <para>
        /// AI prompt type
        /// </para>
        /// </summary>
        public AIPromptType PromptType
        {
            get { return this._promptType; }
            set { this._promptType = value; }
        }

        // Check to see if PromptType property is set
        internal bool IsSetPromptType()
        {
            return this._promptType != null;
        }

        /// <summary>
        /// Gets and sets the property PromptVersion. 
        /// <para>
        /// AI prompt version number
        /// </para>
        /// </summary>
        public int? PromptVersion
        {
            get { return this._promptVersion; }
            set { this._promptVersion = value; }
        }

        // Check to see if PromptVersion property is set
        internal bool IsSetPromptVersion()
        {
            return this._promptVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// Model provider identifier (e.g., aws.bedrock)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string ProviderName
        {
            get { return this._providerName; }
            set { this._providerName = value; }
        }

        // Check to see if ProviderName property is set
        internal bool IsSetProviderName()
        {
            return this._providerName != null;
        }

        /// <summary>
        /// Gets and sets the property RequestMaxTokens. 
        /// <para>
        /// Maximum tokens configured for generation
        /// </para>
        /// </summary>
        public int? RequestMaxTokens
        {
            get { return this._requestMaxTokens; }
            set { this._requestMaxTokens = value; }
        }

        // Check to see if RequestMaxTokens property is set
        internal bool IsSetRequestMaxTokens()
        {
            return this._requestMaxTokens.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestModel. 
        /// <para>
        /// LLM model ID for request (e.g., anthropic.claude-3-sonnet)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string RequestModel
        {
            get { return this._requestModel; }
            set { this._requestModel = value; }
        }

        // Check to see if RequestModel property is set
        internal bool IsSetRequestModel()
        {
            return this._requestModel != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseFinishReasons. 
        /// <para>
        /// Generation termination reasons (e.g., stop, max_tokens)
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> ResponseFinishReasons
        {
            get { return this._responseFinishReasons; }
            set { this._responseFinishReasons = value; }
        }

        // Check to see if ResponseFinishReasons property is set
        internal bool IsSetResponseFinishReasons()
        {
            return this._responseFinishReasons != null && (this._responseFinishReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResponseModel. 
        /// <para>
        /// Actual model used for response (usually matches requestModel)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string ResponseModel
        {
            get { return this._responseModel; }
            set { this._responseModel = value; }
        }

        // Check to see if ResponseModel property is set
        internal bool IsSetResponseModel()
        {
            return this._responseModel != null;
        }

        /// <summary>
        /// Gets and sets the property SessionName. 
        /// <para>
        /// Session name
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string SessionName
        {
            get { return this._sessionName; }
            set { this._sessionName = value; }
        }

        // Check to see if SessionName property is set
        internal bool IsSetSessionName()
        {
            return this._sessionName != null;
        }

        /// <summary>
        /// Gets and sets the property SystemInstructions. 
        /// <para>
        /// System prompt instructions
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<SpanMessageValue> SystemInstructions
        {
            get { return this._systemInstructions; }
            set { this._systemInstructions = value; }
        }

        // Check to see if SystemInstructions property is set
        internal bool IsSetSystemInstructions()
        {
            return this._systemInstructions != null && (this._systemInstructions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Temperature. 
        /// <para>
        /// Sampling temperature for generation
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public float? Temperature
        {
            get { return this._temperature; }
            set { this._temperature = value; }
        }

        // Check to see if Temperature property is set
        internal bool IsSetTemperature()
        {
            return this._temperature.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopP. 
        /// <para>
        /// Top-p sampling parameter for generation
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public float? TopP
        {
            get { return this._topp; }
            set { this._topp = value; }
        }

        // Check to see if TopP property is set
        internal bool IsSetTopP()
        {
            return this._topp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UsageInputTokens. 
        /// <para>
        /// Number of input tokens in prompt
        /// </para>
        /// </summary>
        public int? UsageInputTokens
        {
            get { return this._usageInputTokens; }
            set { this._usageInputTokens = value; }
        }

        // Check to see if UsageInputTokens property is set
        internal bool IsSetUsageInputTokens()
        {
            return this._usageInputTokens.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UsageOutputTokens. 
        /// <para>
        /// Number of output tokens in response
        /// </para>
        /// </summary>
        public int? UsageOutputTokens
        {
            get { return this._usageOutputTokens; }
            set { this._usageOutputTokens = value; }
        }

        // Check to see if UsageOutputTokens property is set
        internal bool IsSetUsageOutputTokens()
        {
            return this._usageOutputTokens.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UsageTotalTokens. 
        /// <para>
        /// Total tokens consumed (input + output)
        /// </para>
        /// </summary>
        public int? UsageTotalTokens
        {
            get { return this._usageTotalTokens; }
            set { this._usageTotalTokens = value; }
        }

        // Check to see if UsageTotalTokens property is set
        internal bool IsSetUsageTotalTokens()
        {
            return this._usageTotalTokens.HasValue; 
        }

    }
}