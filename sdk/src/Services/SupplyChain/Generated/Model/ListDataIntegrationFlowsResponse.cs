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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The response parameters for ListDataIntegrationFlows.
    /// </summary>
    public partial class ListDataIntegrationFlowsResponse : AmazonWebServiceResponse
    {
        private List<DataIntegrationFlow> _flows = AWSConfigs.InitializeCollections ? new List<DataIntegrationFlow>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Flows. 
        /// <para>
        /// The response parameters for ListDataIntegrationFlows.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DataIntegrationFlow> Flows
        {
            get { return this._flows; }
            set { this._flows = value; }
        }

        // Check to see if Flows property is set
        internal bool IsSetFlows()
        {
            return this._flows != null && (this._flows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to fetch the next page of the DataIntegrationFlows.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
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

    }
}