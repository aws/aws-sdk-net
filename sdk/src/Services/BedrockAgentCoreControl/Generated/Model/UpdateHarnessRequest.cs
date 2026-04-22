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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateHarness operation.
    /// Operation to update a Harness.
    /// </summary>
    public partial class UpdateHarnessRequest : AmazonBedrockAgentCoreControlRequest
    {
        private List<string> _allowedTools = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private UpdatedAuthorizerConfiguration _authorizerConfiguration;
        private string _clientToken;
        private HarnessEnvironmentProviderRequest _environment;
        private UpdatedHarnessEnvironmentArtifact _environmentArtifact;
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _executionRoleArn;
        private string _harnessId;
        private int? _maxIterations;
        private int? _maxTokens;
        private UpdatedHarnessMemoryConfiguration _memory;
        private HarnessModelConfiguration _model;
        private List<HarnessSkill> _skills = AWSConfigs.InitializeCollections ? new List<HarnessSkill>() : null;
        private List<HarnessSystemContentBlock> _systemPrompt = AWSConfigs.InitializeCollections ? new List<HarnessSystemContentBlock>() : null;
        private int? _timeoutSeconds;
        private List<HarnessTool> _tools = AWSConfigs.InitializeCollections ? new List<HarnessTool>() : null;
        private HarnessTruncationConfiguration _truncation;

        /// <summary>
        /// Gets and sets the property AllowedTools. 
        /// <para>
        /// The tools that the agent is allowed to use. If specified, this replaces all existing
        /// allowed tools. If not specified, the existing value is retained.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedTools
        {
            get { return this._allowedTools; }
            set { this._allowedTools = value; }
        }

        // Check to see if AllowedTools property is set
        internal bool IsSetAllowedTools()
        {
            return this._allowedTools != null && (this._allowedTools.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration.
        /// </summary>
        public UpdatedAuthorizerConfiguration AuthorizerConfiguration
        {
            get { return this._authorizerConfiguration; }
            set { this._authorizerConfiguration = value; }
        }

        // Check to see if AuthorizerConfiguration property is set
        internal bool IsSetAuthorizerConfiguration()
        {
            return this._authorizerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The compute environment configuration for the harness. If not specified, the existing
        /// value is retained.
        /// </para>
        /// </summary>
        public HarnessEnvironmentProviderRequest Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentArtifact. 
        /// <para>
        /// The environment artifact for the harness. Use the optionalValue wrapper to set a new
        /// value, or set it to null to clear the existing configuration.
        /// </para>
        /// </summary>
        public UpdatedHarnessEnvironmentArtifact EnvironmentArtifact
        {
            get { return this._environmentArtifact; }
            set { this._environmentArtifact = value; }
        }

        // Check to see if EnvironmentArtifact property is set
        internal bool IsSetEnvironmentArtifact()
        {
            return this._environmentArtifact != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// Environment variables to set in the harness runtime environment. If specified, this
        /// replaces all existing environment variables. If not specified, the existing value
        /// is retained.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role that the harness assumes when running. If not specified, the
        /// existing value is retained.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property HarnessId. 
        /// <para>
        /// The ID of the harness to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HarnessId
        {
            get { return this._harnessId; }
            set { this._harnessId = value; }
        }

        // Check to see if HarnessId property is set
        internal bool IsSetHarnessId()
        {
            return this._harnessId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxIterations. 
        /// <para>
        /// The maximum number of iterations the agent loop can execute per invocation. If not
        /// specified, the existing value is retained.
        /// </para>
        /// </summary>
        public int? MaxIterations
        {
            get { return this._maxIterations; }
            set { this._maxIterations = value; }
        }

        // Check to see if MaxIterations property is set
        internal bool IsSetMaxIterations()
        {
            return this._maxIterations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxTokens. 
        /// <para>
        /// The maximum number of tokens the agent can generate per iteration. If not specified,
        /// the existing value is retained.
        /// </para>
        /// </summary>
        public int? MaxTokens
        {
            get { return this._maxTokens; }
            set { this._maxTokens = value; }
        }

        // Check to see if MaxTokens property is set
        internal bool IsSetMaxTokens()
        {
            return this._maxTokens.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The AgentCore Memory configuration. Use the optionalValue wrapper to set a new value,
        /// or set it to null to clear the existing configuration.
        /// </para>
        /// </summary>
        public UpdatedHarnessMemoryConfiguration Memory
        {
            get { return this._memory; }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory != null;
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model configuration for the harness. If not specified, the existing value is retained.
        /// </para>
        /// </summary>
        public HarnessModelConfiguration Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        // Check to see if Model property is set
        internal bool IsSetModel()
        {
            return this._model != null;
        }

        /// <summary>
        /// Gets and sets the property Skills. 
        /// <para>
        /// The skills available to the agent. If specified, this replaces all existing skills.
        /// If not specified, the existing value is retained.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarnessSkill> Skills
        {
            get { return this._skills; }
            set { this._skills = value; }
        }

        // Check to see if Skills property is set
        internal bool IsSetSkills()
        {
            return this._skills != null && (this._skills.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SystemPrompt. 
        /// <para>
        /// The system prompt that defines the agent's behavior. If not specified, the existing
        /// value is retained.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarnessSystemContentBlock> SystemPrompt
        {
            get { return this._systemPrompt; }
            set { this._systemPrompt = value; }
        }

        // Check to see if SystemPrompt property is set
        internal bool IsSetSystemPrompt()
        {
            return this._systemPrompt != null && (this._systemPrompt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The maximum duration in seconds for the agent loop execution per invocation. If not
        /// specified, the existing value is retained.
        /// </para>
        /// </summary>
        public int? TimeoutSeconds
        {
            get { return this._timeoutSeconds; }
            set { this._timeoutSeconds = value; }
        }

        // Check to see if TimeoutSeconds property is set
        internal bool IsSetTimeoutSeconds()
        {
            return this._timeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tools. 
        /// <para>
        /// The tools available to the agent. If specified, this replaces all existing tools.
        /// If not specified, the existing value is retained.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarnessTool> Tools
        {
            get { return this._tools; }
            set { this._tools = value; }
        }

        // Check to see if Tools property is set
        internal bool IsSetTools()
        {
            return this._tools != null && (this._tools.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Truncation. 
        /// <para>
        /// The truncation configuration for managing conversation context. If not specified,
        /// the existing value is retained.
        /// </para>
        /// </summary>
        public HarnessTruncationConfiguration Truncation
        {
            get { return this._truncation; }
            set { this._truncation = value; }
        }

        // Check to see if Truncation property is set
        internal bool IsSetTruncation()
        {
            return this._truncation != null;
        }

    }
}