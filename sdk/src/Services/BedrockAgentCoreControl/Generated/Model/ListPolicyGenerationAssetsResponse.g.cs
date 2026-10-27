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
    /// This is the response object from the ListPolicyGenerationAssets operation.
    /// </summary>
    public partial class ListPolicyGenerationAssetsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that can be used in subsequent <a href="https://docs.aws.amazon.com/bedrock-agentcore-control/latest/APIReference/API_ListPolicyGenerationAssets.html">ListPolicyGenerationAssets</a>
        /// calls to retrieve additional assets. This token is only present when there are more
        /// generated policy assets available beyond the current response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PolicyGenerationAssets. 
        /// <para>
        /// An array of generated policy assets including Dogwood policies and related artifacts
        /// from the AI-powered policy generation process. Each asset represents a different policy
        /// option or variation generated from the original natural language input.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PolicyGenerationAsset> PolicyGenerationAssets { get; set; } = AWSConfigs.InitializeCollections ? new List<PolicyGenerationAsset>() : null;

        /// <summary>
        /// Checks to see if the PolicyGenerationAssets property is set.
        /// </summary>
        internal bool IsSetPolicyGenerationAssets() => this.PolicyGenerationAssets != null && (this.PolicyGenerationAssets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
