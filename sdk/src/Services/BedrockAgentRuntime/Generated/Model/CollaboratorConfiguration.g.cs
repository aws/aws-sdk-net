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
    /// Settings of an inline collaborator agent.
    /// </summary>
    public partial class CollaboratorConfiguration
    {
        /// <summary>
        /// Gets and sets the property AgentAliasArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the inline collaborator agent. 
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string AgentAliasArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentAliasArn property is set.
        /// </summary>
        internal bool IsSetAgentAliasArn() => this.AgentAliasArn != null;

        /// <summary>
        /// Gets and sets the property CollaboratorInstruction. 
        /// <para>
        ///  Instructions that tell the inline collaborator agent what it should do and how it
        /// should interact with users. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 4000)]
        public string CollaboratorInstruction { get; set; }

        /// <summary>
        /// Checks to see if the CollaboratorInstruction property is set.
        /// </summary>
        internal bool IsSetCollaboratorInstruction() => this.CollaboratorInstruction != null;

        /// <summary>
        /// Gets and sets the property CollaboratorName. 
        /// <para>
        ///  Name of the inline collaborator agent which must be the same name as specified for
        /// <c>agentName</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string CollaboratorName { get; set; }

        /// <summary>
        /// Checks to see if the CollaboratorName property is set.
        /// </summary>
        internal bool IsSetCollaboratorName() => this.CollaboratorName != null;

        /// <summary>
        /// Gets and sets the property RelayConversationHistory. 
        /// <para>
        ///  A relay conversation history for the inline collaborator agent. 
        /// </para>
        /// </summary>
        public RelayConversationHistory RelayConversationHistory { get; set; }

        /// <summary>
        /// Checks to see if the RelayConversationHistory property is set.
        /// </summary>
        internal bool IsSetRelayConversationHistory() => this.RelayConversationHistory != null;
    }
}
