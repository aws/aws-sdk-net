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
    /// This is the response object from the ListPolicyGenerationAssets operation.
    /// </summary>
    public partial class ListPolicyGenerationAssetsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PolicyGenerationAsset> _policyGenerationAssets = AWSConfigs.InitializeCollections ? new List<PolicyGenerationAsset>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that can be used in subsequent <a href="https://docs.aws.amazon.com/bedrock-agentcore-control/latest/APIReference/API_ListPolicyGenerationAssets.html">ListPolicyGenerationAssets</a>
        /// calls to retrieve additional assets. This token is only present when there are more
        /// generated policy assets available beyond the current response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyGenerationAssets. 
        /// <para>
        /// An array of generated policy assets including Cedar policies and related artifacts
        /// from the AI-powered policy generation process. Each asset represents a different policy
        /// option or variation generated from the original natural language input.
        /// </para>
        /// </summary>
        public List<PolicyGenerationAsset> PolicyGenerationAssets
        {
            get { return this._policyGenerationAssets; }
            set { this._policyGenerationAssets = value; }
        }

        // Check to see if PolicyGenerationAssets property is set
        internal bool IsSetPolicyGenerationAssets()
        {
            return this._policyGenerationAssets != null && (this._policyGenerationAssets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}