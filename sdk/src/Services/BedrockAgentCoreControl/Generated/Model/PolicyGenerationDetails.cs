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
    /// Represents the information identifying a generated policy asset from the AI-powered
    /// policy generation process within the AgentCore Policy system. Each asset contains
    /// a Cedar policy statement generated from natural language input, along with associated
    /// metadata and analysis findings to help users evaluate and select the most appropriate
    /// policy option.
    /// </summary>
    public partial class PolicyGenerationDetails
    {
        private string _policyGenerationAssetId;
        private string _policyGenerationId;

        /// <summary>
        /// Gets and sets the property PolicyGenerationAssetId. 
        /// <para>
        /// The unique identifier for this generated policy asset within the policy generation
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=59)]
        public string PolicyGenerationAssetId
        {
            get { return this._policyGenerationAssetId; }
            set { this._policyGenerationAssetId = value; }
        }

        // Check to see if PolicyGenerationAssetId property is set
        internal bool IsSetPolicyGenerationAssetId()
        {
            return this._policyGenerationAssetId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyGenerationId. 
        /// <para>
        /// The unique identifier for this policy generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=59)]
        public string PolicyGenerationId
        {
            get { return this._policyGenerationId; }
            set { this._policyGenerationId = value; }
        }

        // Check to see if PolicyGenerationId property is set
        internal bool IsSetPolicyGenerationId()
        {
            return this._policyGenerationId != null;
        }

    }
}