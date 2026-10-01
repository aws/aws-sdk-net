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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// The patchable descriptor fields applied during an UpdateRegistryRecord call. Each
    /// field is independently patchable.
    /// </summary>
    public partial class UpdatedDescriptorsFields
    {
        /// <summary>
        /// Gets and sets the property A2aAgentCard. 
        /// <para>
        /// The patch for the A2A agent card descriptor.
        /// </para>
        /// </summary>
        public UpdatedA2aAgentCardDescriptor A2aAgentCard { get; set; }

        /// <summary>
        /// Checks to see if the A2aAgentCard property is set.
        /// </summary>
        internal bool IsSetA2aAgentCard() => this.A2aAgentCard != null;

        /// <summary>
        /// Gets and sets the property AgentSkillsDefinition. 
        /// <para>
        /// The patch for the agent skills definition descriptor.
        /// </para>
        /// </summary>
        public UpdatedAgentSkillsDefinitionDescriptor AgentSkillsDefinition { get; set; }

        /// <summary>
        /// Checks to see if the AgentSkillsDefinition property is set.
        /// </summary>
        internal bool IsSetAgentSkillsDefinition() => this.AgentSkillsDefinition != null;

        /// <summary>
        /// Gets and sets the property Agui. 
        /// <para>
        /// The patch for the AG-UI descriptor.
        /// </para>
        /// </summary>
        public UpdatedAgUiDescriptor Agui { get; set; }

        /// <summary>
        /// Checks to see if the Agui property is set.
        /// </summary>
        internal bool IsSetAgui() => this.Agui != null;

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        /// The patch for the custom descriptor.
        /// </para>
        /// </summary>
        public UpdatedCustomDescriptor Custom { get; set; }

        /// <summary>
        /// Checks to see if the Custom property is set.
        /// </summary>
        internal bool IsSetCustom() => this.Custom != null;

        /// <summary>
        /// Gets and sets the property Http. 
        /// <para>
        /// The patch for the HTTP descriptor.
        /// </para>
        /// </summary>
        public UpdatedHttpDescriptor Http { get; set; }

        /// <summary>
        /// Checks to see if the Http property is set.
        /// </summary>
        internal bool IsSetHttp() => this.Http != null;

        /// <summary>
        /// Gets and sets the property McpServer. 
        /// <para>
        /// The patch for the MCP server descriptor.
        /// </para>
        /// </summary>
        public UpdatedMcpServerDescriptor McpServer { get; set; }

        /// <summary>
        /// Checks to see if the McpServer property is set.
        /// </summary>
        internal bool IsSetMcpServer() => this.McpServer != null;
    }
}
