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
    /// Container for the parameters to the StopDataCollectionByAgentIds operation.
    /// Instructs the specified agents or connectors to stop collecting data.
    /// </summary>
    public partial class StopDataCollectionByAgentIdsRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private List<string> _agentIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AgentIds. 
        /// <para>
        /// The IDs of the agents or connectors from which to stop collecting data.
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

    }
}