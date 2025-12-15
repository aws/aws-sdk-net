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
    /// Container for the parameters to the ListPolicyGenerationAssets operation.
    /// Retrieves a list of generated policy assets from a policy generation request within
    /// the AgentCore Policy system. This operation returns the actual Cedar policies and
    /// related artifacts produced by the AI-powered policy generation process, allowing users
    /// to review and select from multiple generated policy options.
    /// </summary>
    public partial class ListPolicyGenerationAssetsRequest : AmazonBedrockAgentCoreControlRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _policyEngineId;
        private string _policyGenerationId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of policy generation assets to return in a single response. If
        /// not specified, the default is 10 assets per page, with a maximum of 100 per page.
        /// This helps control response size when dealing with policy generations that produce
        /// many alternative policy options.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token returned from a previous <a href="https://docs.aws.amazon.com/bedrock-agentcore-control/latest/APIReference/API_ListPolicyGenerationAssets.html">ListPolicyGenerationAssets</a>
        /// call. Use this token to retrieve the next page of assets when the response is paginated
        /// due to large numbers of generated policy options.
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
        /// Gets and sets the property PolicyEngineId. 
        /// <para>
        /// The unique identifier of the policy engine associated with the policy generation request.
        /// This provides the context for the generation operation and ensures assets are retrieved
        /// from the correct policy engine.
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

        /// <summary>
        /// Gets and sets the property PolicyGenerationId. 
        /// <para>
        /// The unique identifier of the policy generation request whose assets are to be retrieved.
        /// This must be a valid generation ID from a previous <a href="https://docs.aws.amazon.com/bedrock-agentcore-control/latest/APIReference/API_StartPolicyGeneration.html">StartPolicyGeneration</a>
        /// call that has completed processing.
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