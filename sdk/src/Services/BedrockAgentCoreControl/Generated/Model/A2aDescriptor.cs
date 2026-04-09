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
    /// The Agent-to-Agent (A2A) protocol descriptor for a registry record. Contains the agent
    /// card definition as defined by the A2A protocol specification.
    /// </summary>
    public partial class A2aDescriptor
    {
        private AgentCardDefinition _agentCard;

        /// <summary>
        /// Gets and sets the property AgentCard. 
        /// <para>
        /// The agent card definition for the A2A agent, as defined by the A2A protocol specification.
        /// </para>
        /// </summary>
        public AgentCardDefinition AgentCard
        {
            get { return this._agentCard; }
            set { this._agentCard = value; }
        }

        // Check to see if AgentCard property is set
        internal bool IsSetAgentCard()
        {
            return this._agentCard != null;
        }

    }
}