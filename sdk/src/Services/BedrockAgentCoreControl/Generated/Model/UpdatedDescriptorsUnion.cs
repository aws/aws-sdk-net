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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Contains per-descriptor-type wrappers for updating descriptors. Each descriptor type
    /// can be updated independently.
    /// </summary>
    public partial class UpdatedDescriptorsUnion
    {
        private UpdatedA2aDescriptor _a2a;
        private UpdatedAgentSkillsDescriptor _agentSkills;
        private UpdatedCustomDescriptor _custom;
        private UpdatedMcpDescriptor _mcp;

        /// <summary>
        /// Gets and sets the property A2a. 
        /// <para>
        /// The updated A2A descriptor.
        /// </para>
        /// </summary>
        public UpdatedA2aDescriptor A2a
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
        /// The updated agent skills descriptor.
        /// </para>
        /// </summary>
        public UpdatedAgentSkillsDescriptor AgentSkills
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
        /// The updated custom descriptor.
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
        /// Gets and sets the property Mcp. 
        /// <para>
        /// The updated MCP descriptor.
        /// </para>
        /// </summary>
        public UpdatedMcpDescriptor Mcp
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