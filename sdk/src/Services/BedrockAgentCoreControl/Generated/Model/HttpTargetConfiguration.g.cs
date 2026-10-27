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
    /// The HTTP target configuration for a gateway target. Contains the configuration for
    /// HTTP-based target endpoints.
    /// </summary>
    public partial class HttpTargetConfiguration
    {
        /// <summary>
        /// Gets and sets the property AgentcoreRuntime. 
        /// <para>
        /// The AgentCore Runtime target configuration for HTTP-based communication with an agent
        /// runtime.
        /// </para>
        /// </summary>
        public RuntimeTargetConfiguration AgentcoreRuntime { get; set; }

        /// <summary>
        /// Checks to see if the AgentcoreRuntime property is set.
        /// </summary>
        internal bool IsSetAgentcoreRuntime() => this.AgentcoreRuntime != null;

        /// <summary>
        /// Gets and sets the property Connector. 
        /// <para>
        /// The connector-based configuration for the HTTP target. Use this configuration when
        /// you want to route HTTP requests through a managed connector.
        /// </para>
        /// </summary>
        public HttpConnectorTargetConfiguration Connector { get; set; }

        /// <summary>
        /// Checks to see if the Connector property is set.
        /// </summary>
        internal bool IsSetConnector() => this.Connector != null;

        /// <summary>
        /// Gets and sets the property Passthrough. 
        /// <para>
        /// The passthrough configuration for the HTTP target. A passthrough target forwards requests
        /// directly to an external HTTP endpoint.
        /// </para>
        /// </summary>
        public PassthroughTargetConfiguration Passthrough { get; set; }

        /// <summary>
        /// Checks to see if the Passthrough property is set.
        /// </summary>
        internal bool IsSetPassthrough() => this.Passthrough != null;
    }
}
