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
    /// Container for the parameters to the CreatePolicyEngine operation.
    /// Creates a new policy engine within the AgentCore Policy system. A policy engine is
    /// a collection of policies that evaluates and authorizes agent tool calls. When associated
    /// with Gateways (each Gateway can be associated with at most one policy engine, but
    /// multiple Gateways can be associated with the same engine), the policy engine intercepts
    /// all agent requests and determines whether to allow or deny each action based on the
    /// defined policies. This is an asynchronous operation. Use the <a href="https://docs.aws.amazon.com/bedrock-agentcore-control/latest/APIReference/API_GetPolicyEngine.html">GetPolicyEngine</a>
    /// operation to poll the <c>status</c> field to track completion.
    /// </summary>
    public partial class CreatePolicyEngineRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _clientToken;
        private string _description;
        private string _name;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you retry a request with the same client token, the service returns
        /// the same response without creating a duplicate policy engine.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the policy engine's purpose and scope (1-4,096 characters).
        /// This helps administrators understand the policy engine's role in the overall governance
        /// strategy. Document which Gateway this engine will be associated with, what types of
        /// tools or workflows it governs, and the team or service responsible for maintaining
        /// it. Clear descriptions are essential when managing multiple policy engines across
        /// different services or environments.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The customer-assigned immutable name for the policy engine. This name identifies the
        /// policy engine and cannot be changed after creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}