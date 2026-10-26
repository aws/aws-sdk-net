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
    /// Represents the information identifying a generated policy asset from the AI-powered
    /// policy generation process within the AgentCore Policy system. Each asset contains
    /// a Dogwood policy statement generated from natural language input, along with associated
    /// metadata and analysis findings to help users evaluate and select the most appropriate
    /// policy option.
    /// </summary>
    public partial class PolicyGenerationDetails
    {
        /// <summary>
        /// Gets and sets the property PolicyGenerationAssetId. 
        /// <para>
        /// The unique identifier for this generated policy asset within the policy generation
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 59)]
        public string PolicyGenerationAssetId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyGenerationAssetId property is set.
        /// </summary>
        internal bool IsSetPolicyGenerationAssetId() => this.PolicyGenerationAssetId != null;

        /// <summary>
        /// Gets and sets the property PolicyGenerationId. 
        /// <para>
        /// The unique identifier for this policy generation request.
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
