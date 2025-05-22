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
    /// The response parameters of ListFlowExecutions.
    /// </summary>
    public partial class ListDataIntegrationFlowExecutionsResponse : AmazonWebServiceResponse
    {
        private List<DataIntegrationFlowExecution> _flowExecutions = AWSConfigs.InitializeCollections ? new List<DataIntegrationFlowExecution>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FlowExecutions. 
        /// <para>
        /// The list of flow executions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DataIntegrationFlowExecution> FlowExecutions
        {
            get { return this._flowExecutions; }
            set { this._flowExecutions = value; }
        }

        // Check to see if FlowExecutions property is set
        internal bool IsSetFlowExecutions()
        {
            return this._flowExecutions != null && (this._flowExecutions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to fetch next page of flow executions.
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