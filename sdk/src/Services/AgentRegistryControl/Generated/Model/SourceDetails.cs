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
    /// The details about the upstream source from which a registry record was detected. Exactly
    /// one member is populated, corresponding to the source type.
    /// </summary>
    public partial class SourceDetails
    {
        private AgentCoreGatewaySourceDetails _agentcoreGateway;
        private AgentCoreRuntimeSourceDetails _agentcoreRuntime;

        /// <summary>
        /// Gets and sets the property AgentcoreGateway.
        /// </summary>
        public AgentCoreGatewaySourceDetails AgentcoreGateway
        {
            get { return this._agentcoreGateway; }
            set { this._agentcoreGateway = value; }
        }

        // Check to see if AgentcoreGateway property is set
        internal bool IsSetAgentcoreGateway()
        {
            return this._agentcoreGateway != null;
        }

        /// <summary>
        /// Gets and sets the property AgentcoreRuntime.
        /// </summary>
        public AgentCoreRuntimeSourceDetails AgentcoreRuntime
        {
            get { return this._agentcoreRuntime; }
            set { this._agentcoreRuntime = value; }
        }

        // Check to see if AgentcoreRuntime property is set
        internal bool IsSetAgentcoreRuntime()
        {
            return this._agentcoreRuntime != null;
        }

    }
}