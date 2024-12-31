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
    /// Container for the parameters to the UpdateAgentCollaborator operation.
    /// Updates an agent's collaborator.
    /// </summary>
    public partial class UpdateAgentCollaboratorRequest : AmazonBedrockAgentRequest
    {
        private AgentDescriptor _agentDescriptor;
        private string _agentId;
        private string _agentVersion;
        private string _collaborationInstruction;
        private string _collaboratorId;
        private string _collaboratorName;
        private RelayConversationHistory _relayConversationHistory;

        /// <summary>
        /// Gets and sets the property AgentDescriptor. 
        /// <para>
        /// An agent descriptor for the agent collaborator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentDescriptor AgentDescriptor
        {
            get { return this._agentDescriptor; }
            set { this._agentDescriptor = value; }
        }

        // Check to see if AgentDescriptor property is set
        internal bool IsSetAgentDescriptor()
        {
            return this._agentDescriptor != null;
        }

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The agent's ID.
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
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The agent's version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=5)]
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }

        // Check to see if AgentVersion property is set
        internal bool IsSetAgentVersion()
        {
            return this._agentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property CollaborationInstruction. 
        /// <para>
        /// Instruction for the collaborator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4000)]
        public string CollaborationInstruction
        {
            get { return this._collaborationInstruction; }
            set { this._collaborationInstruction = value; }
        }

        // Check to see if CollaborationInstruction property is set
        internal bool IsSetCollaborationInstruction()
        {
            return this._collaborationInstruction != null;
        }

        /// <summary>
        /// Gets and sets the property CollaboratorId. 
        /// <para>
        /// The collaborator's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CollaboratorId
        {
            get { return this._collaboratorId; }
            set { this._collaboratorId = value; }
        }

        // Check to see if CollaboratorId property is set
        internal bool IsSetCollaboratorId()
        {
            return this._collaboratorId != null;
        }

        /// <summary>
        /// Gets and sets the property CollaboratorName. 
        /// <para>
        /// The collaborator's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CollaboratorName
        {
            get { return this._collaboratorName; }
            set { this._collaboratorName = value; }
        }

        // Check to see if CollaboratorName property is set
        internal bool IsSetCollaboratorName()
        {
            return this._collaboratorName != null;
        }

        /// <summary>
        /// Gets and sets the property RelayConversationHistory. 
        /// <para>
        /// A relay conversation history for the collaborator.
        /// </para>
        /// </summary>
        public RelayConversationHistory RelayConversationHistory
        {
            get { return this._relayConversationHistory; }
            set { this._relayConversationHistory = value; }
        }

        // Check to see if RelayConversationHistory property is set
        internal bool IsSetRelayConversationHistory()
        {
            return this._relayConversationHistory != null;
        }

    }
}