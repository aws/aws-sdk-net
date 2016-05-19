/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAgents operation.
    /// Lists AWS agents by ID or lists all agents associated with your user account if you
    /// did not specify an agent ID.
    /// </summary>
    public partial class DescribeAgentsRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private List<string> _agentIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AgentIds. 
        /// <para>
        /// The agent IDs for which you want information. If you specify no IDs, the system returns
        /// information about all agents associated with your AWS user account.
        /// </para>
        /// </summary>
        public List<string> AgentIds
        {
            get { return this._agentIds; }
            set { this._agentIds = value; }
        }

        // Check to see if AgentIds property is set
        internal bool IsSetAgentIds()
        {
            return this._agentIds != null && this._agentIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The total number of agents to return. The maximum value is 100.
        /// </para>
        /// </summary>
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
        /// A token to start the list. Use this token to get the next set of results.
        /// </para>
        /// </summary>
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