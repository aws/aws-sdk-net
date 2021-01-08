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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// This is the response object from the DescribeAgents operation.
    /// </summary>
    public partial class DescribeAgentsResponse : AmazonWebServiceResponse
    {
        private List<AgentInfo> _agentsInfo = new List<AgentInfo>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AgentsInfo. 
        /// <para>
        /// Lists agents or the Connector by ID or lists all agents/Connectors associated with
        /// your user account if you did not specify an agent/Connector ID. The output includes
        /// agent/Connector IDs, IP addresses, media access control (MAC) addresses, agent/Connector
        /// health, host name where the agent/Connector resides, and the version number of each
        /// agent/Connector.
        /// </para>
        /// </summary>
        public List<AgentInfo> AgentsInfo
        {
            get { return this._agentsInfo; }
            set { this._agentsInfo = value; }
        }

        // Check to see if AgentsInfo property is set
        internal bool IsSetAgentsInfo()
        {
            return this._agentsInfo != null && this._agentsInfo.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token to retrieve the next set of results. For example, if you specified 100 IDs for
        /// <code>DescribeAgentsRequest$agentIds</code> but set <code>DescribeAgentsRequest$maxResults</code>
        /// to 10, you received a set of 10 results along with this token. Use this token in the
        /// next query to retrieve the next set of 10.
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