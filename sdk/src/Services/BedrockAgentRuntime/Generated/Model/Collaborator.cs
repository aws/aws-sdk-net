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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
        private List<AgentActionGroup> _actionGroups = AWSConfigs.InitializeCollections ? new List<AgentActionGroup>() : null;
        private AgentCollaboration _agentCollaboration;
        private string _agentName;
        private List<CollaboratorConfiguration> _collaboratorConfigurations = AWSConfigs.InitializeCollections ? new List<CollaboratorConfiguration>() : null;
        private string _customerEncryptionKeyArn;
        private string _foundationModel;
        private GuardrailConfigurationWithArn _guardrailConfiguration;
        private int? _idleSessionTTLInSeconds;
        private string _instruction;
        private List<KnowledgeBase> _knowledgeBases = AWSConfigs.InitializeCollections ? new List<KnowledgeBase>() : null;
        private PromptOverrideConfiguration _promptOverrideConfiguration;

        /// <summary>
        /// Gets and sets the property ActionGroups. 
        /// <para>
        ///  List of action groups with each action group defining tasks the inline collaborator
        /// agent needs to carry out. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgentActionGroup> ActionGroups
        {
            get { return this._actionGroups; }
            set { this._actionGroups = value; }
        }

        // Check to see if ActionGroups property is set
        internal bool IsSetActionGroups()
        {
            return this._actionGroups != null && (this._actionGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AgentCollaboration. 
        /// <para>
        ///  Defines how the inline supervisor agent handles information across multiple collaborator
        /// agents to coordinate a final response. 
        /// </para>
        /// </summary>
        public AgentCollaboration AgentCollaboration
        {
            get { return this._agentCollaboration; }
            set { this._agentCollaboration = value; }
        }

        // Check to see if AgentCollaboration property is set
        internal bool IsSetAgentCollaboration()
        {
            return this._agentCollaboration != null;
        }

        /// <summary>
        /// Gets and sets the property AgentName. 
        /// <para>
        ///  Name of the inline collaborator agent which must be the same name as specified for
        /// <c>collaboratorName</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string AgentName
        {
            get { return this._agentName; }
            set { this._agentName = value; }
        }

        // Check to see if AgentName property is set
        internal bool IsSetAgentName()
        {
            return this._agentName != null;
        }

        /// <summary>
        /// Gets and sets the property CollaboratorConfigurations. 
        /// <para>
        ///  Settings of the collaborator agent. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CollaboratorConfiguration> CollaboratorConfigurations
        {
            get { return this._collaboratorConfigurations; }
            set { this._collaboratorConfigurations = value; }
        }

        // Check to see if CollaboratorConfigurations property is set
        internal bool IsSetCollaboratorConfigurations()
        {
            return this._collaboratorConfigurations != null && (this._collaboratorConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomerEncryptionKeyArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the AWS KMS key that encrypts the inline collaborator.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string CustomerEncryptionKeyArn
        {
            get { return this._customerEncryptionKeyArn; }
            set { this._customerEncryptionKeyArn = value; }
        }

        // Check to see if CustomerEncryptionKeyArn property is set
        internal bool IsSetCustomerEncryptionKeyArn()
        {
            return this._customerEncryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property FoundationModel. 
        /// <para>
        ///  The foundation model used by the inline collaborator agent. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string FoundationModel
        {
            get { return this._foundationModel; }
            set { this._foundationModel = value; }
        }

        // Check to see if FoundationModel property is set
        internal bool IsSetFoundationModel()
        {
            return this._foundationModel != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailConfiguration. 
        /// <para>
        ///  Details of the guardwrail associated with the inline collaborator. 
        /// </para>
        /// </summary>
        public GuardrailConfigurationWithArn GuardrailConfiguration
        {
            get { return this._guardrailConfiguration; }
            set { this._guardrailConfiguration = value; }
        }

        // Check to see if GuardrailConfiguration property is set
        internal bool IsSetGuardrailConfiguration()
        {
            return this._guardrailConfiguration != null;
        }

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
        [AWSProperty(Min=60, Max=3600)]
        public int? IdleSessionTTLInSeconds
        {
            get { return this._idleSessionTTLInSeconds; }
            set { this._idleSessionTTLInSeconds = value; }
        }

        // Check to see if IdleSessionTTLInSeconds property is set
        internal bool IsSetIdleSessionTTLInSeconds()
        {
            return this._idleSessionTTLInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Instruction. 
        /// <para>
        ///  Instruction that tell the inline collaborator agent what it should do and how it
        /// should interact with users. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=40)]
        public string Instruction
        {
            get { return this._instruction; }
            set { this._instruction = value; }
        }

        // Check to see if Instruction property is set
        internal bool IsSetInstruction()
        {
            return this._instruction != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBases. 
        /// <para>
        ///  Knowledge base associated with the inline collaborator agent. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KnowledgeBase> KnowledgeBases
        {
            get { return this._knowledgeBases; }
            set { this._knowledgeBases = value; }
        }

        // Check to see if KnowledgeBases property is set
        internal bool IsSetKnowledgeBases()
        {
            return this._knowledgeBases != null && (this._knowledgeBases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PromptOverrideConfiguration. 
        /// <para>
        ///  Contains configurations to override prompt templates in different parts of an inline
        /// collaborator sequence. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/advanced-prompts.html">Advanced
        /// prompts</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public PromptOverrideConfiguration PromptOverrideConfiguration
        {
            get { return this._promptOverrideConfiguration; }
            set { this._promptOverrideConfiguration = value; }
        }

        // Check to see if PromptOverrideConfiguration property is set
        internal bool IsSetPromptOverrideConfiguration()
        {
            return this._promptOverrideConfiguration != null;
        }

    }
}