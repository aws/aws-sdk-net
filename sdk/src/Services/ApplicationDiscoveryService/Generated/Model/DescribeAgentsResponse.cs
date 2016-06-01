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
    /// This is the response object from the DescribeAgents operation.
    /// </summary>
    public partial class DescribeAgentsResponse : AmazonWebServiceResponse
    {
        private List<AgentInfo> _agentsInfo = new List<AgentInfo>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AgentsInfo. 
        /// <para>
        /// Lists AWS agents by ID or lists all agents associated with your user account if you
        /// did not specify an agent ID. The output includes agent IDs, IP addresses, media access
        /// control (MAC) addresses, agent health, host name where the agent resides, and the
        /// version number of each agent.
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
        /// The call returns a token. Use this token to get the next set of results.
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