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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Defines an agent node in your flow. You specify the agent to invoke at this point
    /// in the flow. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-nodes.html">Node
    /// types in a flow</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class AgentFlowNodeConfiguration
    {
        private string _agentAliasArn;

        /// <summary>
        /// Gets and sets the property AgentAliasArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the alias of the agent to invoke.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string AgentAliasArn
        {
            get { return this._agentAliasArn; }
            set { this._agentAliasArn = value; }
        }

        // Check to see if AgentAliasArn property is set
        internal bool IsSetAgentAliasArn()
        {
            return this._agentAliasArn != null;
        }

    }
}