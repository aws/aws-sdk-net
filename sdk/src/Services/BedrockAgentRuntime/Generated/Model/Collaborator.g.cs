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
    /// List of inline collaborators.
    /// </summary>
    public partial class Collaborator
    {
        /// <summary>
        /// Gets and sets the property ActionGroups. 
        /// <para>
        ///  List of action groups with each action group defining tasks the inline collaborator
        /// agent needs to carry out. 
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
        ///  Defines how the inline supervisor agent handles information across multiple collaborator
        /// agents to coordinate a final response. 
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
        ///  Name of the inline collaborator agent which must be the same name as specified for
        /// <c>collaboratorName</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string AgentName { get; set; }

        /// <summary>
        /// Checks to see if the AgentName property is set.
        /// </summary>
        internal bool IsSetAgentName() => this.AgentName != null;

        /// <summary>
        /// Gets and sets the property CollaboratorConfigurations. 
        /// <para>
        ///  Settings of the collaborator agent. 
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
        /// Gets and sets the property CustomerEncryptionKeyArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the AWS KMS key that encrypts the inline collaborator.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CustomerEncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomerEncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetCustomerEncryptionKeyArn() => this.CustomerEncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property FoundationModel. 
        /// <para>
        ///  The foundation model used by the inline collaborator agent. 
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
        ///  Details of the guardwrail associated with the inline collaborator. 
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
        ///  The number of seconds for which the Amazon Bedrock keeps information about the user's
        /// conversation with the inline collaborator agent.
        /// </para>
        ///  
        /// <para>
        /// A user interaction remains active for the amount of time specified. If no conversation
        /// occurs during this time, the session expires and Amazon Bedrock deletes any data provided
        /// before the timeout. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 3600)]
        public int? IdleSessionTTLInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IdleSessionTTLInSeconds property is set.
        /// </summary>
        internal bool IsSetIdleSessionTTLInSeconds() => this.IdleSessionTTLInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Instruction. 
        /// <para>
        ///  Instruction that tell the inline collaborator agent what it should do and how it
        /// should interact with users. 
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
        ///  Knowledge base associated with the inline collaborator agent. 
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
        /// Gets and sets the property PromptOverrideConfiguration. 
        /// <para>
        ///  Contains configurations to override prompt templates in different parts of an inline
        /// collaborator sequence. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/advanced-prompts.html">Advanced
        /// prompts</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public PromptOverrideConfiguration PromptOverrideConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PromptOverrideConfiguration property is set.
        /// </summary>
        internal bool IsSetPromptOverrideConfiguration() => this.PromptOverrideConfiguration != null;
    }
}
