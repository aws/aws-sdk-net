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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains details about a version of an agent.
    /// </summary>
    public partial class AgentVersion
    {
        /// <summary>
        /// Gets and sets the property AgentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agent that the version belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string AgentArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentArn property is set.
        /// </summary>
        internal bool IsSetAgentArn() => this.AgentArn != null;

        /// <summary>
        /// Gets and sets the property AgentCollaboration. 
        /// <para>
        /// The agent's collaboration settings.
        /// </para>
        /// </summary>
        public AgentCollaboration AgentCollaboration { get; set; }

        /// <summary>
        /// Checks to see if the AgentCollaboration property is set.
        /// </summary>
        internal bool IsSetAgentCollaboration() => this.AgentCollaboration != null;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier of the agent that the version belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

        /// <summary>
        /// Gets and sets the property AgentName. 
        /// <para>
        /// The name of the agent that the version belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentName { get; set; }

        /// <summary>
        /// Checks to see if the AgentName property is set.
        /// </summary>
        internal bool IsSetAgentName() => this.AgentName != null;

        /// <summary>
        /// Gets and sets the property AgentResourceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role with permissions to invoke API operations
        /// on the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string AgentResourceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentResourceRoleArn property is set.
        /// </summary>
        internal bool IsSetAgentResourceRoleArn() => this.AgentResourceRoleArn != null;

        /// <summary>
        /// Gets and sets the property AgentStatus. 
        /// <para>
        /// The status of the agent that the version belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentStatus AgentStatus { get; set; }

        /// <summary>
        /// Checks to see if the AgentStatus property is set.
        /// </summary>
        internal bool IsSetAgentStatus() => this.AgentStatus != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the version was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerEncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key that encrypts the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CustomerEncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomerEncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetCustomerEncryptionKeyArn() => this.CustomerEncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// A list of reasons that the API operation on the version failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 2048)]
        public List<string> FailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null && (this.FailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FoundationModel. 
        /// <para>
        /// The foundation model that the version invokes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string FoundationModel { get; set; }

        /// <summary>
        /// Checks to see if the FoundationModel property is set.
        /// </summary>
        internal bool IsSetFoundationModel() => this.FoundationModel != null;

        /// <summary>
        /// Gets and sets the property GuardrailConfiguration. 
        /// <para>
        /// Details about the guardrail associated with the agent.
        /// </para>
        /// </summary>
        public GuardrailConfiguration GuardrailConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailConfiguration property is set.
        /// </summary>
        internal bool IsSetGuardrailConfiguration() => this.GuardrailConfiguration != null;

        /// <summary>
        /// Gets and sets the property IdleSessionTTLInSeconds. 
        /// <para>
        /// The number of seconds for which Amazon Bedrock keeps information about a user's conversation
        /// with the agent.
        /// </para>
        ///  
        /// <para>
        /// A user interaction remains active for the amount of time specified. If no conversation
        /// occurs during this time, the session expires and Amazon Bedrock deletes any data provided
        /// before the timeout.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 60, Max = 5400)]
        public int? IdleSessionTTLInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IdleSessionTTLInSeconds property is set.
        /// </summary>
        internal bool IsSetIdleSessionTTLInSeconds() => this.IdleSessionTTLInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Instruction. 
        /// <para>
        /// The instructions provided to the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 40, Max = 4000)]
        public string Instruction { get; set; }

        /// <summary>
        /// Checks to see if the Instruction property is set.
        /// </summary>
        internal bool IsSetInstruction() => this.Instruction != null;

        /// <summary>
        /// Gets and sets the property MemoryConfiguration. 
        /// <para>
        ///  Contains details of the memory configuration on the version of the agent. 
        /// </para>
        /// </summary>
        public MemoryConfiguration MemoryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MemoryConfiguration property is set.
        /// </summary>
        internal bool IsSetMemoryConfiguration() => this.MemoryConfiguration != null;

        /// <summary>
        /// Gets and sets the property PromptOverrideConfiguration. 
        /// <para>
        /// Contains configurations to override prompt templates in different parts of an agent
        /// sequence. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/advanced-prompts.html">Advanced
        /// prompts</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public PromptOverrideConfiguration PromptOverrideConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PromptOverrideConfiguration property is set.
        /// </summary>
        internal bool IsSetPromptOverrideConfiguration() => this.PromptOverrideConfiguration != null;

        /// <summary>
        /// Gets and sets the property RecommendedActions. 
        /// <para>
        /// A list of recommended actions to take for the failed API operation on the version
        /// to succeed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 2048)]
        public List<string> RecommendedActions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RecommendedActions property is set.
        /// </summary>
        internal bool IsSetRecommendedActions() => this.RecommendedActions != null && (this.RecommendedActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the version was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
