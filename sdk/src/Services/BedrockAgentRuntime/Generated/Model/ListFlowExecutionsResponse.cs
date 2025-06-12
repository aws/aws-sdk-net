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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// This is the response object from the ListFlowExecutions operation.
    /// </summary>
    public partial class ListFlowExecutionsResponse : AmazonWebServiceResponse
    {
        private List<FlowExecutionSummary> _flowExecutionSummaries = AWSConfigs.InitializeCollections ? new List<FlowExecutionSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FlowExecutionSummaries. 
        /// <para>
        /// A list of flow execution summaries. Each summary includes the execution ARN, flow
        /// identifier, flow alias identifier, flow version, status, and timestamps.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<FlowExecutionSummary> FlowExecutionSummaries
        {
            get { return this._flowExecutionSummaries; }
            set { this._flowExecutionSummaries = value; }
        }

        // Check to see if FlowExecutionSummaries property is set
        internal bool IsSetFlowExecutionSummaries()
        {
            return this._flowExecutionSummaries != null && (this._flowExecutionSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to retrieve the next set of results. This value is returned if more results
        /// are available.
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

    }
}