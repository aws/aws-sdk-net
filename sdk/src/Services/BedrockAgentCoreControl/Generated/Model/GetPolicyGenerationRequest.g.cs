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
    /// Container for the parameters to the GetPolicyGeneration operation. Retrieves information
    /// about a policy generation request within the AgentCore Policy system. Policy generation
    /// converts natural language descriptions into Dogwood policy statements using AI-powered
    /// translation, enabling non-technical users to create policies.
    /// </summary>
    public partial class GetPolicyGenerationRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property PolicyEngineId. 
        /// <para>
        /// The identifier of the policy engine associated with the policy generation request.
        /// This provides the context for the generation operation and schema validation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 59)]
        public string PolicyEngineId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyEngineId property is set.
        /// </summary>
        internal bool IsSetPolicyEngineId() => this.PolicyEngineId != null;

        /// <summary>
        /// Gets and sets the property PolicyGenerationId. 
        /// <para>
        /// The unique identifier of the policy generation request to be retrieved. This must
        /// be a valid generation ID from a previous <a href="https://docs.aws.amazon.com/bedrock-agentcore-control/latest/APIReference/API_StartPolicyGeneration.html">StartPolicyGeneration</a>
        /// call.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 59)]
        public string PolicyGenerationId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyGenerationId property is set.
        /// </summary>
        internal bool IsSetPolicyGenerationId() => this.PolicyGenerationId != null;
    }
}
