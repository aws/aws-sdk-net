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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Contains the descriptor configuration for a registry record. Only the field that
    /// matches the record's <c>descriptorType</c> is populated.
    /// </summary>
    public partial class Descriptors
    {
        /// <summary>
        /// Gets and sets the property A2a. 
        /// <para>
        ///  The A2A (Agent-to-Agent) descriptor configuration. Populated when the record's <c>descriptorType</c>
        /// is <c>A2A</c>.
        /// </para>
        /// </summary>
        public A2aDescriptor A2a { get; set; }

        /// <summary>
        /// Checks to see if the A2a property is set.
        /// </summary>
        internal bool IsSetA2a() => this.A2a != null;

        /// <summary>
        /// Gets and sets the property AgentSkills. 
        /// <para>
        ///  The agent skills descriptor configuration. Populated when the record's <c>descriptorType</c>
        /// is <c>AGENT_SKILLS</c>.
        /// </para>
        /// </summary>
        public AgentSkillsDescriptor AgentSkills { get; set; }

        /// <summary>
        /// Checks to see if the AgentSkills property is set.
        /// </summary>
        internal bool IsSetAgentSkills() => this.AgentSkills != null;

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        ///  The custom descriptor configuration. Populated when the record's <c>descriptorType</c>
        /// is <c>CUSTOM</c>.
        /// </para>
        /// </summary>
        public CustomDescriptor Custom { get; set; }

        /// <summary>
        /// Checks to see if the Custom property is set.
        /// </summary>
        internal bool IsSetCustom() => this.Custom != null;

        /// <summary>
        /// Gets and sets the property Mcp. 
        /// <para>
        ///  The MCP (Model Context Protocol) descriptor configuration. Populated when the record's
        /// <c>descriptorType</c> is <c>MCP</c>.
        /// </para>
        /// </summary>
        public McpDescriptor Mcp { get; set; }

        /// <summary>
        /// Checks to see if the Mcp property is set.
        /// </summary>
        internal bool IsSetMcp() => this.Mcp != null;
    }
}
