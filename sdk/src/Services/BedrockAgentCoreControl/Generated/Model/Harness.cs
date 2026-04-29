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
    /// Representation of a Harness.
    /// </summary>
    public partial class Harness
    {
        private List<string> _allowedTools = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _arn;
        private AuthorizerConfiguration _authorizerConfiguration;
        private DateTime? _createdAt;
        private HarnessEnvironmentProvider _environment;
        private HarnessEnvironmentArtifact _environmentArtifact;
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _executionRoleArn;
        private string _failureReason;
        private string _harnessId;
        private string _harnessName;
        private int? _maxIterations;
        private int? _maxTokens;
        private HarnessMemoryConfiguration _memory;
        private HarnessModelConfiguration _model;
        private List<HarnessSkill> _skills = AWSConfigs.InitializeCollections ? new List<HarnessSkill>() : null;
        private HarnessStatus _status;
        private List<HarnessSystemContentBlock> _systemPrompt = AWSConfigs.InitializeCollections ? new List<HarnessSystemContentBlock>() : null;
        private int? _timeoutSeconds;
        private List<HarnessTool> _tools = AWSConfigs.InitializeCollections ? new List<HarnessTool>() : null;
        private HarnessTruncationConfiguration _truncation;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AllowedTools. 
        /// <para>
        /// The allowed tools of the Harness. All tools are allowed by default.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the Harness.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration.
        /// </summary>
        public AuthorizerConfiguration AuthorizerConfiguration
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The createdAt time of the Harness.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The compute environment on which the Harness runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HarnessEnvironmentProvider Environment
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
        /// The environment artifact (e.g., container) in which the Harness operates.
        /// </para>
        /// </summary>
        public HarnessEnvironmentArtifact EnvironmentArtifact
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
        /// Environment variables exposed in the environment in which the Harness operates.
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
        /// IAM role the Harness assumes when running.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Reason why create or update operations fail.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property HarnessId. 
        /// <para>
        /// The ID of the Harness.
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
        /// Gets and sets the property HarnessName. 
        /// <para>
        /// The name of the Harness.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HarnessName
        {
            get { return this._harnessName; }
            set { this._harnessName = value; }
        }

        // Check to see if HarnessName property is set
        internal bool IsSetHarnessName()
        {
            return this._harnessName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxIterations. 
        /// <para>
        /// The maximum number of iterations in the agent loop allowed before exiting per invocation.
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
        /// The maximum number of tokens allowed before exiting per invocation.
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
        /// AgentCore Memory instance configuration for short and long term memory.
        /// </para>
        /// </summary>
        public HarnessMemoryConfiguration Memory
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
        /// The configuration of the default model used by the Harness.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The skills of the Harness.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Harness.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HarnessStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SystemPrompt. 
        /// <para>
        /// The system prompt of the Harness.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The maximum duration per invocation.
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
        /// The tools of the Harness.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Configuration for truncating model context.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The updatedAt time of the Harness.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}