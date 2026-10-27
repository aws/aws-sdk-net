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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Contains per-descriptor-type wrappers for updating descriptors. Each descriptor type
    /// can be updated independently.
    /// </summary>
    public partial class UpdatedDescriptorsUnion
    {
        /// <summary>
        /// Gets and sets the property A2a. 
        /// <para>
        /// The updated A2A descriptor.
        /// </para>
        /// </summary>
        public UpdatedA2aDescriptor A2a { get; set; }

        /// <summary>
        /// Checks to see if the A2a property is set.
        /// </summary>
        internal bool IsSetA2a() => this.A2a != null;

        /// <summary>
        /// Gets and sets the property AgentSkills. 
        /// <para>
        /// The updated agent skills descriptor.
        /// </para>
        /// </summary>
        public UpdatedAgentSkillsDescriptor AgentSkills { get; set; }

        /// <summary>
        /// Checks to see if the AgentSkills property is set.
        /// </summary>
        internal bool IsSetAgentSkills() => this.AgentSkills != null;

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        /// The updated custom descriptor.
        /// </para>
        /// </summary>
        public UpdatedCustomDescriptor Custom { get; set; }

        /// <summary>
        /// Checks to see if the Custom property is set.
        /// </summary>
        internal bool IsSetCustom() => this.Custom != null;

        /// <summary>
        /// Gets and sets the property Mcp. 
        /// <para>
        /// The updated MCP descriptor.
        /// </para>
        /// </summary>
        public UpdatedMcpDescriptor Mcp { get; set; }

        /// <summary>
        /// Checks to see if the Mcp property is set.
        /// </summary>
        internal bool IsSetMcp() => this.Mcp != null;
    }
}
