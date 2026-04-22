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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeHarness operation.
    /// Operation to invoke a Harness.
    /// </summary>
    public partial class InvokeHarnessRequest : AmazonBedrockAgentCoreRequest
    {
        private string _actorId;
        private List<string> _allowedTools = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _harnessArn;
        private int? _maxIterations;
        private int? _maxTokens;
        private List<HarnessMessage> _messages = AWSConfigs.InitializeCollections ? new List<HarnessMessage>() : null;
        private HarnessModelConfiguration _model;
        private string _runtimeSessionId;
        private List<HarnessSkill> _skills = AWSConfigs.InitializeCollections ? new List<HarnessSkill>() : null;
        private List<HarnessSystemContentBlock> _systemPrompt = AWSConfigs.InitializeCollections ? new List<HarnessSystemContentBlock>() : null;
        private int? _timeoutSeconds;
        private List<HarnessTool> _tools = AWSConfigs.InitializeCollections ? new List<HarnessTool>() : null;

        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The actor ID for memory operations. Overrides the actor ID configured on the harness.
        /// </para>
        /// </summary>
        public string ActorId
        {
            get { return this._actorId; }
            set { this._actorId = value; }
        }

        // Check to see if ActorId property is set
        internal bool IsSetActorId()
        {
            return this._actorId != null;
        }

        /// <summary>
        /// Gets and sets the property AllowedTools. 
        /// <para>
        /// The tools that the agent is allowed to use for this invocation. If specified, overrides
        /// the harness default.
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
        /// Gets and sets the property HarnessArn. 
        /// <para>
        /// The ARN of the harness to invoke.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HarnessArn
        {
            get { return this._harnessArn; }
            set { this._harnessArn = value; }
        }

        // Check to see if HarnessArn property is set
        internal bool IsSetHarnessArn()
        {
            return this._harnessArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxIterations. 
        /// <para>
        /// The maximum number of iterations the agent loop can execute. If specified, overrides
        /// the harness default.
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
        /// The maximum number of tokens the agent can generate per iteration. If specified, overrides
        /// the harness default.
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
        /// Gets and sets the property Messages. 
        /// <para>
        /// The messages to send to the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<HarnessMessage> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && (this._messages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model configuration to use for this invocation. If specified, overrides the harness
        /// default.
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
        /// Gets and sets the property RuntimeSessionId. 
        /// <para>
        /// The session ID for the invocation. Use the same session ID across requests to continue
        /// a conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RuntimeSessionId
        {
            get { return this._runtimeSessionId; }
            set { this._runtimeSessionId = value; }
        }

        // Check to see if RuntimeSessionId property is set
        internal bool IsSetRuntimeSessionId()
        {
            return this._runtimeSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property Skills. 
        /// <para>
        /// The skills available to the agent for this invocation. If specified, overrides the
        /// harness default.
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
        /// The system prompt to use for this invocation. If specified, overrides the harness
        /// default.
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
        /// The maximum duration in seconds for the agent loop execution. If specified, overrides
        /// the harness default.
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
        /// The tools available to the agent for this invocation. If specified, overrides the
        /// harness default.
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

    }
}