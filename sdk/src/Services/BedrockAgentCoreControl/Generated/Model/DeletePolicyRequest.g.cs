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
    /// Container for the parameters to the DeletePolicy operation. Deletes an existing policy
    /// from the AgentCore Policy system. Once deleted, the policy can no longer be used for
    /// agent behavior control and all references to it become invalid. This is an asynchronous
    /// operation. Use the <c>GetPolicy</c> operation to poll the <c>status</c> field to track
    /// completion.
    /// </summary>
    public partial class DeletePolicyRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property PolicyEngineId. 
        /// <para>
        /// The identifier of the policy engine that manages the policy to be deleted. This ensures
        /// the policy is deleted from the correct policy engine context.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 59)]
        public string PolicyEngineId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyEngineId property is set.
        /// </summary>
        internal bool IsSetPolicyEngineId() => this.PolicyEngineId != null;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The unique identifier of the policy to be deleted. This must be a valid policy ID
        /// that exists within the specified policy engine.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 59)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyId property is set.
        /// </summary>
        internal bool IsSetPolicyId() => this.PolicyId != null;
    }
}
