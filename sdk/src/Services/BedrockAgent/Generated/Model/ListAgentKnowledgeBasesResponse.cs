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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// This is the response object from the ListAgentKnowledgeBases operation.
    /// </summary>
    public partial class ListAgentKnowledgeBasesResponse : AmazonWebServiceResponse
    {
        private List<AgentKnowledgeBaseSummary> _agentKnowledgeBaseSummaries = AWSConfigs.InitializeCollections ? new List<AgentKnowledgeBaseSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AgentKnowledgeBaseSummaries. 
        /// <para>
        /// A list of objects, each of which contains information about a knowledge base associated
        /// with the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<AgentKnowledgeBaseSummary> AgentKnowledgeBaseSummaries
        {
            get { return this._agentKnowledgeBaseSummaries; }
            set { this._agentKnowledgeBaseSummaries = value; }
        }

        // Check to see if AgentKnowledgeBaseSummaries property is set
        internal bool IsSetAgentKnowledgeBaseSummaries()
        {
            return this._agentKnowledgeBaseSummaries != null && (this._agentKnowledgeBaseSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the total number of results is greater than the <c>maxResults</c> value provided
        /// in the request, use this token when making another request in the <c>nextToken</c>
        /// field to return the next batch of results.
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