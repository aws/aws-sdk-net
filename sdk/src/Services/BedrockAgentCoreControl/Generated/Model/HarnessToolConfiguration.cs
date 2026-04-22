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
    /// Configuration union for different tool types.
    /// </summary>
    public partial class HarnessToolConfiguration
    {
        private HarnessAgentCoreBrowserConfig _agentCoreBrowser;
        private HarnessAgentCoreCodeInterpreterConfig _agentCoreCodeInterpreter;
        private HarnessAgentCoreGatewayConfig _agentCoreGateway;
        private HarnessInlineFunctionConfig _inlineFunction;
        private HarnessRemoteMcpConfig _remoteMcp;

        /// <summary>
        /// Gets and sets the property AgentCoreBrowser. 
        /// <para>
        /// Configuration for AgentCore Browser.
        /// </para>
        /// </summary>
        public HarnessAgentCoreBrowserConfig AgentCoreBrowser
        {
            get { return this._agentCoreBrowser; }
            set { this._agentCoreBrowser = value; }
        }

        // Check to see if AgentCoreBrowser property is set
        internal bool IsSetAgentCoreBrowser()
        {
            return this._agentCoreBrowser != null;
        }

        /// <summary>
        /// Gets and sets the property AgentCoreCodeInterpreter. 
        /// <para>
        /// Configuration for AgentCore Code Interpreter.
        /// </para>
        /// </summary>
        public HarnessAgentCoreCodeInterpreterConfig AgentCoreCodeInterpreter
        {
            get { return this._agentCoreCodeInterpreter; }
            set { this._agentCoreCodeInterpreter = value; }
        }

        // Check to see if AgentCoreCodeInterpreter property is set
        internal bool IsSetAgentCoreCodeInterpreter()
        {
            return this._agentCoreCodeInterpreter != null;
        }

        /// <summary>
        /// Gets and sets the property AgentCoreGateway. 
        /// <para>
        /// Configuration for AgentCore Gateway.
        /// </para>
        /// </summary>
        public HarnessAgentCoreGatewayConfig AgentCoreGateway
        {
            get { return this._agentCoreGateway; }
            set { this._agentCoreGateway = value; }
        }

        // Check to see if AgentCoreGateway property is set
        internal bool IsSetAgentCoreGateway()
        {
            return this._agentCoreGateway != null;
        }

        /// <summary>
        /// Gets and sets the property InlineFunction. 
        /// <para>
        /// Configuration for an inline function tool.
        /// </para>
        /// </summary>
        public HarnessInlineFunctionConfig InlineFunction
        {
            get { return this._inlineFunction; }
            set { this._inlineFunction = value; }
        }

        // Check to see if InlineFunction property is set
        internal bool IsSetInlineFunction()
        {
            return this._inlineFunction != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteMcp. 
        /// <para>
        /// Configuration for remote MCP server.
        /// </para>
        /// </summary>
        public HarnessRemoteMcpConfig RemoteMcp
        {
            get { return this._remoteMcp; }
            set { this._remoteMcp = value; }
        }

        // Check to see if RemoteMcp property is set
        internal bool IsSetRemoteMcp()
        {
            return this._remoteMcp != null;
        }

    }
}