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
    /// Representation of a harness.
    /// </summary>
    public partial class Harness
    {
        /// <summary>
        /// Gets and sets the property AllowedTools. 
        /// <para>
        /// The allowed tools of the harness. All tools are allowed by default.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AllowedTools { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedTools property is set.
        /// </summary>
        internal bool IsSetAllowedTools() => this.AllowedTools != null && (this.AllowedTools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the harness.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration.
        /// </summary>
        public AuthorizerConfiguration AuthorizerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerConfiguration property is set.
        /// </summary>
        internal bool IsSetAuthorizerConfiguration() => this.AuthorizerConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The createdAt time of the harness.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The compute environment on which the Harness runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HarnessEnvironmentProvider Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property EnvironmentArtifact. 
        /// <para>
        /// The environment artifact (e.g., container) in which the Harness operates.
        /// </para>
        /// </summary>
        public HarnessEnvironmentArtifact EnvironmentArtifact { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentArtifact property is set.
        /// </summary>
        internal bool IsSetEnvironmentArtifact() => this.EnvironmentArtifact != null;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// Environment variables exposed in the environment in which the harness operates.
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
        /// IAM role the harness assumes when running.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Reason why create or update operations fail.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property HarnessId. 
        /// <para>
        /// The ID of the harness.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HarnessId { get; set; }

        /// <summary>
        /// Checks to see if the HarnessId property is set.
        /// </summary>
        internal bool IsSetHarnessId() => this.HarnessId != null;

        /// <summary>
        /// Gets and sets the property HarnessName. 
        /// <para>
        /// The name of the harness.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HarnessName { get; set; }

        /// <summary>
        /// Checks to see if the HarnessName property is set.
        /// </summary>
        internal bool IsSetHarnessName() => this.HarnessName != null;

        /// <summary>
        /// Gets and sets the property HarnessVersion. 
        /// <para>
        /// The version of the harness. Incremented on every successful UpdateHarness.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string HarnessVersion { get; set; }

        /// <summary>
        /// Checks to see if the HarnessVersion property is set.
        /// </summary>
        internal bool IsSetHarnessVersion() => this.HarnessVersion != null;

        /// <summary>
        /// Gets and sets the property Hooks. 
        /// <para>
        /// The lifecycle hooks configured for the harness.
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
        /// The maximum number of iterations in the agent loop allowed before exiting per invocation.
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
        /// calls within a single invocation.
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
        /// AgentCore Memory instance configuration for short and long term memory.
        /// </para>
        /// </summary>
        public HarnessMemoryConfiguration Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory != null;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The configuration of the default model used by the Harness.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HarnessModelConfiguration Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property Skills. 
        /// <para>
        /// The skills of the harness.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<HarnessSkill> Skills { get; set; } = AWSConfigs.InitializeCollections ? new List<HarnessSkill>() : null;

        /// <summary>
        /// Checks to see if the Skills property is set.
        /// </summary>
        internal bool IsSetSkills() => this.Skills != null && (this.Skills.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the harness.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HarnessStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SystemPrompt. 
        /// <para>
        /// The system prompt of the harness.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<HarnessSystemContentBlock> SystemPrompt { get; set; } = AWSConfigs.InitializeCollections ? new List<HarnessSystemContentBlock>() : null;

        /// <summary>
        /// Checks to see if the SystemPrompt property is set.
        /// </summary>
        internal bool IsSetSystemPrompt() => this.SystemPrompt != null && (this.SystemPrompt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The maximum duration per invocation.
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
        /// The tools of the harness.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<HarnessTool> Tools { get; set; } = AWSConfigs.InitializeCollections ? new List<HarnessTool>() : null;

        /// <summary>
        /// Checks to see if the Tools property is set.
        /// </summary>
        internal bool IsSetTools() => this.Tools != null && (this.Tools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Truncation. 
        /// <para>
        /// Configuration for truncating model context.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HarnessTruncationConfiguration Truncation { get; set; }

        /// <summary>
        /// Checks to see if the Truncation property is set.
        /// </summary>
        internal bool IsSetTruncation() => this.Truncation != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The updatedAt time of the harness.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
