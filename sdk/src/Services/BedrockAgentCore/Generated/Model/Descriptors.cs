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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Contains the descriptor configuration for a registry record. Only the field that
    /// matches the record's <c>descriptorType</c> is populated.
    /// </summary>
    public partial class Descriptors
    {
        private A2aDescriptor _a2a;
        private AgentSkillsDescriptor _agentSkills;
        private CustomDescriptor _custom;
        private McpDescriptor _mcp;

        /// <summary>
        /// Gets and sets the property A2a. 
        /// <para>
        ///  The A2A (Agent-to-Agent) descriptor configuration. Populated when the record's <c>descriptorType</c>
        /// is <c>A2A</c>.
        /// </para>
        /// </summary>
        public A2aDescriptor A2a
        {
            get { return this._a2a; }
            set { this._a2a = value; }
        }

        // Check to see if A2a property is set
        internal bool IsSetA2a()
        {
            return this._a2a != null;
        }

        /// <summary>
        /// Gets and sets the property AgentSkills. 
        /// <para>
        ///  The agent skills descriptor configuration. Populated when the record's <c>descriptorType</c>
        /// is <c>AGENT_SKILLS</c>.
        /// </para>
        /// </summary>
        public AgentSkillsDescriptor AgentSkills
        {
            get { return this._agentSkills; }
            set { this._agentSkills = value; }
        }

        // Check to see if AgentSkills property is set
        internal bool IsSetAgentSkills()
        {
            return this._agentSkills != null;
        }

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        ///  The custom descriptor configuration. Populated when the record's <c>descriptorType</c>
        /// is <c>CUSTOM</c>.
        /// </para>
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
        /// Gets and sets the property Mcp. 
        /// <para>
        ///  The MCP (Model Context Protocol) descriptor configuration. Populated when the record's
        /// <c>descriptorType</c> is <c>MCP</c>.
        /// </para>
        /// </summary>
        public McpDescriptor Mcp
        {
            get { return this._mcp; }
            set { this._mcp = value; }
        }

        // Check to see if Mcp property is set
        internal bool IsSetMcp()
        {
            return this._mcp != null;
        }

    }
}