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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
        private string _agentArn;
        private AgentCollaboration _agentCollaboration;
        private string _agentId;
        private string _agentName;
        private string _agentResourceRoleArn;
        private AgentStatus _agentStatus;
        private DateTime? _createdAt;
        private string _customerEncryptionKeyArn;
        private string _description;
        private List<string> _failureReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _foundationModel;
        private GuardrailConfiguration _guardrailConfiguration;
        private int? _idleSessionTTLInSeconds;
        private string _instruction;
        private MemoryConfiguration _memoryConfiguration;
        private PromptOverrideConfiguration _promptOverrideConfiguration;
        private List<string> _recommendedActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _updatedAt;
        private string _version;

        /// <summary>
        /// Gets and sets the property AgentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agent that the version belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string AgentArn
        {
            get { return this._agentArn; }
            set { this._agentArn = value; }
        }

        // Check to see if AgentArn property is set
        internal bool IsSetAgentArn()
        {
            return this._agentArn != null;
        }

        /// <summary>
        /// Gets and sets the property AgentCollaboration. 
        /// <para>
        /// The agent's collaboration settings.
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
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier of the agent that the version belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AgentName. 
        /// <para>
        /// The name of the agent that the version belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AgentResourceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role with permissions to invoke API operations
        /// on the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string AgentResourceRoleArn
        {
            get { return this._agentResourceRoleArn; }
            set { this._agentResourceRoleArn = value; }
        }

        // Check to see if AgentResourceRoleArn property is set
        internal bool IsSetAgentResourceRoleArn()
        {
            return this._agentResourceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property AgentStatus. 
        /// <para>
        /// The status of the agent that the version belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentStatus AgentStatus
        {
            get { return this._agentStatus; }
            set { this._agentStatus = value; }
        }

        // Check to see if AgentStatus property is set
        internal bool IsSetAgentStatus()
        {
            return this._agentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the version was created.
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
        /// Gets and sets the property CustomerEncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key that encrypts the agent.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// A list of reasons that the API operation on the version failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public List<string> FailureReasons
        {
            get { return this._failureReasons; }
            set { this._failureReasons = value; }
        }

        // Check to see if FailureReasons property is set
        internal bool IsSetFailureReasons()
        {
            return this._failureReasons != null && (this._failureReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FoundationModel. 
        /// <para>
        /// The foundation model that the version invokes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Details about the guardrail associated with the agent.
        /// </para>
        /// </summary>
        public GuardrailConfiguration GuardrailConfiguration
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
        [AWSProperty(Required=true, Min=60, Max=5400)]
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
        /// The instructions provided to the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=40, Max=4000)]
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
        /// Gets and sets the property MemoryConfiguration. 
        /// <para>
        ///  Contains details of the memory configuration on the version of the agent. 
        /// </para>
        /// </summary>
        public MemoryConfiguration MemoryConfiguration
        {
            get { return this._memoryConfiguration; }
            set { this._memoryConfiguration = value; }
        }

        // Check to see if MemoryConfiguration property is set
        internal bool IsSetMemoryConfiguration()
        {
            return this._memoryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PromptOverrideConfiguration. 
        /// <para>
        /// Contains configurations to override prompt templates in different parts of an agent
        /// sequence. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/advanced-prompts.html">Advanced
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

        /// <summary>
        /// Gets and sets the property RecommendedActions. 
        /// <para>
        /// A list of recommended actions to take for the failed API operation on the version
        /// to succeed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public List<string> RecommendedActions
        {
            get { return this._recommendedActions; }
            set { this._recommendedActions = value; }
        }

        // Check to see if RecommendedActions property is set
        internal bool IsSetRecommendedActions()
        {
            return this._recommendedActions != null && (this._recommendedActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the version was last updated.
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}