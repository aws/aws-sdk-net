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
    /// Settings of an inline collaborator agent.
    /// </summary>
    public partial class CollaboratorConfiguration
    {
        private string _agentAliasArn;
        private string _collaboratorInstruction;
        private string _collaboratorName;
        private RelayConversationHistory _relayConversationHistory;

        /// <summary>
        /// Gets and sets the property AgentAliasArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the inline collaborator agent. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string AgentAliasArn
        {
            get { return this._agentAliasArn; }
            set { this._agentAliasArn = value; }
        }

        // Check to see if AgentAliasArn property is set
        internal bool IsSetAgentAliasArn()
        {
            return this._agentAliasArn != null;
        }

        /// <summary>
        /// Gets and sets the property CollaboratorInstruction. 
        /// <para>
        ///  Instructions that tell the inline collaborator agent what it should do and how it
        /// should interact with users. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4000)]
        public string CollaboratorInstruction
        {
            get { return this._collaboratorInstruction; }
            set { this._collaboratorInstruction = value; }
        }

        // Check to see if CollaboratorInstruction property is set
        internal bool IsSetCollaboratorInstruction()
        {
            return this._collaboratorInstruction != null;
        }

        /// <summary>
        /// Gets and sets the property CollaboratorName. 
        /// <para>
        ///  Name of the inline collaborator agent which must be the same name as specified for
        /// <c>agentName</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        ///  A relay conversation history for the inline collaborator agent. 
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