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
 * Do not modify this file. This file is generated from the agent-registry-2025-12-01.normal.json service model.
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
namespace Amazon.AgentRegistry.Model
{
    /// <summary>
    /// The protocol-specific descriptors that describe how to connect to and use the registry
    /// record.
    /// </summary>
    public partial class Descriptors
    {
        private A2aAgentCardDescriptor _a2aAgentCard;
        private AgentSkillsDefinitionDescriptor _agentSkillsDefinition;
        private CustomDescriptor _custom;
        private McpServerDescriptor _mcpServer;

        /// <summary>
        /// Gets and sets the property A2aAgentCard.
        /// </summary>
        public A2aAgentCardDescriptor A2aAgentCard
        {
            get { return this._a2aAgentCard; }
            set { this._a2aAgentCard = value; }
        }

        // Check to see if A2aAgentCard property is set
        internal bool IsSetA2aAgentCard()
        {
            return this._a2aAgentCard != null;
        }

        /// <summary>
        /// Gets and sets the property AgentSkillsDefinition.
        /// </summary>
        public AgentSkillsDefinitionDescriptor AgentSkillsDefinition
        {
            get { return this._agentSkillsDefinition; }
            set { this._agentSkillsDefinition = value; }
        }

        // Check to see if AgentSkillsDefinition property is set
        internal bool IsSetAgentSkillsDefinition()
        {
            return this._agentSkillsDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property Custom.
        /// </summary>
        public CustomDescriptor Custom
        {
            get { return this._custom; }
            set { this._custom = value; }
        }

        // Check to see if Custom property is set
        internal bool IsSetCustom()
        {
            return this._custom != null;
        }

        /// <summary>
        /// Gets and sets the property McpServer.
        /// </summary>
        public McpServerDescriptor McpServer
        {
            get { return this._mcpServer; }
            set { this._mcpServer = value; }
        }

        // Check to see if McpServer property is set
        internal bool IsSetMcpServer()
        {
            return this._mcpServer != null;
        }

    }
}