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
    /// A lifecycle hook action that sends an HTTP <c>POST</c> request to the agent's container.
    /// The path and port can't conflict with a path that your agent already serves for AgentCore
    /// Runtime, such as the protocol's invocation path or the health check path.
    /// </summary>
    public partial class HttpPostLifecycleHookAction
    {
        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path in the agent's container that AgentCore Runtime sends the <c>POST</c> request
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port in the agent's container that AgentCore Runtime sends the <c>POST</c> request
        /// to. If you don't specify a port, the default is the runtime's server port: the port
        /// in the protocol configuration if one is set, otherwise the protocol's default port.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8000, Max = 12000)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;
    }
}
