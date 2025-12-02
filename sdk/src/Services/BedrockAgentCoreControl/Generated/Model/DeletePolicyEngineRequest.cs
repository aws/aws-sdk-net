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
    /// Container for the parameters to the DeletePolicyEngine operation.
    /// Deletes an existing policy engine from the AgentCore Policy system. The policy engine
    /// must not have any associated policies before deletion. Once deleted, the policy engine
    /// and all its configurations become unavailable for policy management and evaluation.
    /// This is an asynchronous operation. Use the <c>GetPolicyEngine</c> operation to poll
    /// the <c>status</c> field to track completion.
    /// </summary>
    public partial class DeletePolicyEngineRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _policyEngineId;

        /// <summary>
        /// Gets and sets the property PolicyEngineId. 
        /// <para>
        /// The unique identifier of the policy engine to be deleted. This must be a valid policy
        /// engine ID that exists within the account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=59)]
        public string PolicyEngineId
        {
            get { return this._policyEngineId; }
            set { this._policyEngineId = value; }
        }

        // Check to see if PolicyEngineId property is set
        internal bool IsSetPolicyEngineId()
        {
            return this._policyEngineId != null;
        }

    }
}