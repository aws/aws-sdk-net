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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
    /// Configuration for AgentCore Gateway.
    /// </summary>
    public partial class HarnessAgentCoreGatewayConfig
    {
        private string _gatewayArn;
        private HarnessGatewayOutboundAuth _outboundAuth;

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The ARN of the desired AgentCore Gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayArn
        {
            get { return this._gatewayArn; }
            set { this._gatewayArn = value; }
        }

        // Check to see if GatewayArn property is set
        internal bool IsSetGatewayArn()
        {
            return this._gatewayArn != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundAuth. 
        /// <para>
        /// How Loopy authenticates to this Gateway. Defaults to AWS_IAM (SigV4) if omitted.
        /// </para>
        /// </summary>
        public HarnessGatewayOutboundAuth OutboundAuth
        {
            get { return this._outboundAuth; }
            set { this._outboundAuth = value; }
        }

        // Check to see if OutboundAuth property is set
        internal bool IsSetOutboundAuth()
        {
            return this._outboundAuth != null;
        }

    }
}