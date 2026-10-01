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
    /// Configuration union for different tool types.
    /// </summary>
    public partial class HarnessToolConfiguration
    {
        /// <summary>
        /// Gets and sets the property AgentCoreBrowser. 
        /// <para>
        /// Configuration for AgentCore Browser.
        /// </para>
        /// </summary>
        public HarnessAgentCoreBrowserConfig AgentCoreBrowser { get; set; }

        /// <summary>
        /// Checks to see if the AgentCoreBrowser property is set.
        /// </summary>
        internal bool IsSetAgentCoreBrowser() => this.AgentCoreBrowser != null;

        /// <summary>
        /// Gets and sets the property AgentCoreCodeInterpreter. 
        /// <para>
        /// Configuration for AgentCore Code Interpreter.
        /// </para>
        /// </summary>
        public HarnessAgentCoreCodeInterpreterConfig AgentCoreCodeInterpreter { get; set; }

        /// <summary>
        /// Checks to see if the AgentCoreCodeInterpreter property is set.
        /// </summary>
        internal bool IsSetAgentCoreCodeInterpreter() => this.AgentCoreCodeInterpreter != null;

        /// <summary>
        /// Gets and sets the property AgentCoreGateway. 
        /// <para>
        /// Configuration for AgentCore Gateway.
        /// </para>
        /// </summary>
        public HarnessAgentCoreGatewayConfig AgentCoreGateway { get; set; }

        /// <summary>
        /// Checks to see if the AgentCoreGateway property is set.
        /// </summary>
        internal bool IsSetAgentCoreGateway() => this.AgentCoreGateway != null;

        /// <summary>
        /// Gets and sets the property InlineFunction. 
        /// <para>
        /// Configuration for an inline function tool.
        /// </para>
        /// </summary>
        public HarnessInlineFunctionConfig InlineFunction { get; set; }

        /// <summary>
        /// Checks to see if the InlineFunction property is set.
        /// </summary>
        internal bool IsSetInlineFunction() => this.InlineFunction != null;

        /// <summary>
        /// Gets and sets the property RemoteMcp. 
        /// <para>
        /// Configuration for remote MCP server.
        /// </para>
        /// </summary>
        public HarnessRemoteMcpConfig RemoteMcp { get; set; }

        /// <summary>
        /// Checks to see if the RemoteMcp property is set.
        /// </summary>
        internal bool IsSetRemoteMcp() => this.RemoteMcp != null;
    }
}
