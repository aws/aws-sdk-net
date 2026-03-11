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
    /// The configuration for a policy engine associated with a gateway. A policy engine is
    /// a collection of policies that evaluates and authorizes agent tool calls. When associated
    /// with a gateway, the policy engine intercepts all agent requests and determines whether
    /// to allow or deny each action based on the defined policies.
    /// </summary>
    public partial class GatewayPolicyEngineConfiguration
    {
        private string _arn;
        private GatewayPolicyEngineMode _mode;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the policy engine. The policy engine contains Cedar policies that define
        /// fine-grained authorization rules specifying who can perform what actions on which
        /// resources as agents interact through the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=170)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The enforcement mode for the policy engine. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LOG_ONLY</c> - The policy engine evaluates each action against your policies and
        /// adds traces on whether tool calls would be allowed or denied, but does not enforce
        /// the decision. Use this mode to test and validate policies before enabling enforcement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENFORCE</c> - The policy engine evaluates actions against your policies and enforces
        /// decisions by allowing or denying agent operations. Test and validate policies in <c>LOG_ONLY</c>
        /// mode before enabling enforcement to avoid unintended denials or adversely affecting
        /// production traffic.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public GatewayPolicyEngineMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}