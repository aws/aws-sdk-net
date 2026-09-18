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
    /// Container for the parameters to the UpdateAgentCollaborator operation. Updates an
    /// agent's collaborator.
    /// </summary>
    public partial class UpdateAgentCollaboratorRequest : AmazonBedrockAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentDescriptor. 
        /// <para>
        /// An agent descriptor for the agent collaborator.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentDescriptor AgentDescriptor { get; set; }

        /// <summary>
        /// Checks to see if the AgentDescriptor property is set.
        /// </summary>
        internal bool IsSetAgentDescriptor() => this.AgentDescriptor != null;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The agent's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The agent's version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 5)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentVersion property is set.
        /// </summary>
        internal bool IsSetAgentVersion() => this.AgentVersion != null;

        /// <summary>
        /// Gets and sets the property CollaborationInstruction. 
        /// <para>
        /// Instruction for the collaborator.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 4000)]
        public string CollaborationInstruction { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationInstruction property is set.
        /// </summary>
        internal bool IsSetCollaborationInstruction() => this.CollaborationInstruction != null;

        /// <summary>
        /// Gets and sets the property CollaboratorId. 
        /// <para>
        /// The collaborator's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CollaboratorId { get; set; }

        /// <summary>
        /// Checks to see if the CollaboratorId property is set.
        /// </summary>
        internal bool IsSetCollaboratorId() => this.CollaboratorId != null;

        /// <summary>
        /// Gets and sets the property CollaboratorName. 
        /// <para>
        /// The collaborator's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CollaboratorName { get; set; }

        /// <summary>
        /// Checks to see if the CollaboratorName property is set.
        /// </summary>
        internal bool IsSetCollaboratorName() => this.CollaboratorName != null;

        /// <summary>
        /// Gets and sets the property RelayConversationHistory. 
        /// <para>
        /// A relay conversation history for the collaborator.
        /// </para>
        /// </summary>
        public RelayConversationHistory RelayConversationHistory { get; set; }

        /// <summary>
        /// Checks to see if the RelayConversationHistory property is set.
        /// </summary>
        internal bool IsSetRelayConversationHistory() => this.RelayConversationHistory != null;
    }
}
