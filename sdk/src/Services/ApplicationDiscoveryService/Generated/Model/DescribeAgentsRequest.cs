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
    /// Lists agents or the Connector by ID or lists all agents/Connectors associated with
    /// your user account if you did not specify an ID.
    /// </summary>
    public partial class DescribeAgentsRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private List<string> _agentIds = new List<string>();
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AgentIds. 
        /// <para>
        /// The agent or the Connector IDs for which you want information. If you specify no IDs,
        /// the system returns information about all agents/Connectors associated with your AWS
        /// user account.
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
        /// Gets and sets the property Filters. 
        /// <para>
        /// You can filter the request using various logical operators and a <i>key</i>-<i>value</i>
        /// format. For example: 
        /// </para>
        ///  
        /// <para>
        ///  <code>{"key": "collectionStatus", "value": "STARTED"}</code> 
        /// </para>
        ///  
        /// <para>
        /// For a complete list of filter options and guidance about using them with this action,
        /// see <a href="http://docs.aws.amazon.com/application-discovery/latest/APIReference/managing-agent.html">Managing
        /// AWS Application Discovery Service Agents and the AWS Application Discovery Connector
        /// </a>.
        /// </para>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The total number of agents/Connectors to return in a single page of output. The maximum
        /// value is 100.
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
        /// Token to retrieve the next set of results. For example, if you previously specified
        /// 100 IDs for <code>DescribeAgentsRequest$agentIds</code> but set <code>DescribeAgentsRequest$maxResults</code>
        /// to 10, you received a set of 10 results along with a token. Use that token in this
        /// query to get the next set of 10.
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