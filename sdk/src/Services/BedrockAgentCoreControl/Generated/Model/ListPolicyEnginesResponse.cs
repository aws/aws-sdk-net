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
    /// This is the response object from the ListPolicyEngines operation.
    /// </summary>
    public partial class ListPolicyEnginesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PolicyEngine> _policyEngines = AWSConfigs.InitializeCollections ? new List<PolicyEngine>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that can be used in subsequent <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/API_ListPolicyEngines.html">ListPolicyEngines</a>
        /// calls to retrieve additional results. This token is only present when there are more
        /// results available. 
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
        /// Gets and sets the property PolicyEngines. 
        /// <para>
        /// An array of policy engine objects that exist in the account. Each policy engine object
        /// contains the engine metadata, status, and key identifiers for further operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<PolicyEngine> PolicyEngines
        {
            get { return this._policyEngines; }
            set { this._policyEngines = value; }
        }

        // Check to see if PolicyEngines property is set
        internal bool IsSetPolicyEngines()
        {
            return this._policyEngines != null && (this._policyEngines.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}