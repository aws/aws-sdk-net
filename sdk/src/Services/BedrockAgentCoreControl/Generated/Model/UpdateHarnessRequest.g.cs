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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateHarness operation. Operation to update a
    /// harness.
    /// </summary>
    public partial class UpdateHarnessRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property AllowedTools. 
        /// <para>
        /// The tools that the agent is allowed to use. If specified, this replaces all existing
        /// allowed tools. If not specified, the existing value is retained.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedTools { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedTools property is set.
        /// </summary>
        internal bool IsSetAllowedTools() => this.AllowedTools != null && (this.AllowedTools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration.
        /// </summary>
        public UpdatedAuthorizerConfiguration AuthorizerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerConfiguration property is set.
        /// </summary>
        internal bool IsSetAuthorizerConfiguration() => this.AuthorizerConfiguration != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The compute environment configuration for the harness. If not specified, the existing
        /// value is retained.
        /// </para>
        /// </summary>
        public HarnessEnvironmentProviderRequest Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property EnvironmentArtifact. 
        /// <para>
        /// The environment artifact for the harness. Use the optionalValue wrapper to set a new
        /// value, or set it to null to clear the existing configuration.
        /// </para>
        /// </summary>
        public UpdatedHarnessEnvironmentArtifact EnvironmentArtifact { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentArtifact property is set.
        /// </summary>
        internal bool IsSetEnvironmentArtifact() => this.EnvironmentArtifact != null;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// Environment variables to set in the harness runtime environment. If specified, this
        /// replaces all existing environment variables. If not specified, the existing value
        /// is retained.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 50)]
        public Dictionary<string, string> EnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetEnvironmentVariables() => this.EnvironmentVariables != null && (this.EnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role that the harness assumes when running. If not specified, the
        /// existing value is retained.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property HarnessId. 
        /// <para>
        /// The ID of the harness to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HarnessId { get; set; }

        /// <summary>
        /// Checks to see if the HarnessId property is set.
        /// </summary>
        internal bool IsSetHarnessId() => this.HarnessId != null;

        /// <summary>
        /// Gets and sets the property Hooks. 
        /// <para>
        /// The lifecycle hooks to run at defined points in the agent loop. If specified, this
        /// replaces all existing hooks. If not specified, the existing hooks are retained.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<HarnessHook> Hooks { get; set; } = AWSConfigs.InitializeCollections ? new List<HarnessHook>() : null;

        /// <summary>
        /// Checks to see if the Hooks property is set.
        /// </summary>
        internal bool IsSetHooks() => this.Hooks != null && (this.Hooks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxIterations. 
        /// <para>
        /// The maximum number of iterations the agent loop can execute per invocation. If not
        /// specified, the existing value is retained.
        /// </para>
        /// </summary>
        public int? MaxIterations { get; set; }

        /// <summary>
        /// Checks to see if the MaxIterations property is set.
        /// </summary>
        internal bool IsSetMaxIterations() => this.MaxIterations.HasValue;

        /// <summary>
        /// Gets and sets the property MaxTokens. 
        /// <para>
        /// The maximum total number of output tokens the agent can generate across all model
        /// calls within a single invocation. If not specified, the existing value is retained.
        /// </para>
        /// </summary>
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Checks to see if the MaxTokens property is set.
        /// </summary>
        internal bool IsSetMaxTokens() => this.MaxTokens.HasValue;

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The AgentCore Memory configuration. Use the optionalValue wrapper to set a new value,
        /// or set it to null to clear the existing configuration.
        /// </para>
        /// </summary>
        public UpdatedHarnessMemoryConfiguration Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory != null;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model configuration for the harness. If not specified, the existing value is retained.
        /// </para>
        /// </summary>
        public HarnessModelConfiguration Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property Skills. 
        /// <para>
        /// The skills available to the agent. If specified, this replaces all existing skills.
        /// If not specified, the existing value is retained.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarnessSkill> Skills { get; set; } = AWSConfigs.InitializeCollections ? new List<HarnessSkill>() : null;

        /// <summary>
        /// Checks to see if the Skills property is set.
        /// </summary>
        internal bool IsSetSkills() => this.Skills != null && (this.Skills.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SystemPrompt. 
        /// <para>
        /// The system prompt that defines the agent's behavior. If not specified, the existing
        /// value is retained.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarnessSystemContentBlock> SystemPrompt { get; set; } = AWSConfigs.InitializeCollections ? new List<HarnessSystemContentBlock>() : null;

        /// <summary>
        /// Checks to see if the SystemPrompt property is set.
        /// </summary>
        internal bool IsSetSystemPrompt() => this.SystemPrompt != null && (this.SystemPrompt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The maximum duration in seconds for the agent loop execution per invocation. If not
        /// specified, the existing value is retained.
        /// </para>
        /// </summary>
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutSeconds() => this.TimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Tools. 
        /// <para>
        /// The tools available to the agent. If specified, this replaces all existing tools.
        /// If not specified, the existing value is retained.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarnessTool> Tools { get; set; } = AWSConfigs.InitializeCollections ? new List<HarnessTool>() : null;

        /// <summary>
        /// Checks to see if the Tools property is set.
        /// </summary>
        internal bool IsSetTools() => this.Tools != null && (this.Tools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Truncation. 
        /// <para>
        /// The truncation configuration for managing conversation context. If not specified,
        /// the existing value is retained.
        /// </para>
        /// </summary>
        public HarnessTruncationConfiguration Truncation { get; set; }

        /// <summary>
        /// Checks to see if the Truncation property is set.
        /// </summary>
        internal bool IsSetTruncation() => this.Truncation != null;
    }
}
