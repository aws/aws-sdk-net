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
    /// This is the response object from the ListAgentCollaborators operation.
    /// </summary>
    public partial class ListAgentCollaboratorsResponse : AmazonWebServiceResponse
    {
        private List<AgentCollaboratorSummary> _agentCollaboratorSummaries = AWSConfigs.InitializeCollections ? new List<AgentCollaboratorSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AgentCollaboratorSummaries. 
        /// <para>
        /// A list of collaborator summaries.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<AgentCollaboratorSummary> AgentCollaboratorSummaries
        {
            get { return this._agentCollaboratorSummaries; }
            set { this._agentCollaboratorSummaries = value; }
        }

        // Check to see if AgentCollaboratorSummaries property is set
        internal bool IsSetAgentCollaboratorSummaries()
        {
            return this._agentCollaboratorSummaries != null && (this._agentCollaboratorSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specify the pagination token from a previous request to retrieve the next page of
        /// results.
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