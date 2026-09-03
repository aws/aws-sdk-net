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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
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
namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// The patchable descriptor fields applied during an UpdateRegistryRecord call. Each
    /// field is independently patchable.
    /// </summary>
    public partial class UpdatedDescriptorsFields
    {
        private UpdatedA2aAgentCardDescriptor _a2aAgentCard;
        private UpdatedAgentSkillsDefinitionDescriptor _agentSkillsDefinition;
        private UpdatedAgUiDescriptor _agui;
        private UpdatedCustomDescriptor _custom;
        private UpdatedHttpDescriptor _http;
        private UpdatedMcpServerDescriptor _mcpServer;

        /// <summary>
        /// Gets and sets the property A2aAgentCard. 
        /// <para>
        /// The patch for the A2A agent card descriptor.
        /// </para>
        /// </summary>
        public UpdatedA2aAgentCardDescriptor A2aAgentCard
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
        /// <para>
        /// The patch for the agent skills definition descriptor.
        /// </para>
        /// </summary>
        public UpdatedAgentSkillsDefinitionDescriptor AgentSkillsDefinition
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
        /// Gets and sets the property Agui. 
        /// <para>
        /// The patch for the AG-UI descriptor.
        /// </para>
        /// </summary>
        public UpdatedAgUiDescriptor Agui
        {
            get { return this._agui; }
            set { this._agui = value; }
        }

        // Check to see if Agui property is set
        internal bool IsSetAgui()
        {
            return this._agui != null;
        }

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        /// The patch for the custom descriptor.
        /// </para>
        /// </summary>
        public UpdatedCustomDescriptor Custom
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
        /// Gets and sets the property Http. 
        /// <para>
        /// The patch for the HTTP descriptor.
        /// </para>
        /// </summary>
        public UpdatedHttpDescriptor Http
        {
            get { return this._http; }
            set { this._http = value; }
        }

        // Check to see if Http property is set
        internal bool IsSetHttp()
        {
            return this._http != null;
        }

        /// <summary>
        /// Gets and sets the property McpServer. 
        /// <para>
        /// The patch for the MCP server descriptor.
        /// </para>
        /// </summary>
        public UpdatedMcpServerDescriptor McpServer
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