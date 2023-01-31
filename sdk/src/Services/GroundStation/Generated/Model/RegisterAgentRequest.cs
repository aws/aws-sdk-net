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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterAgent operation.
    /// Registers a new agent with AWS Groundstation.
    /// </summary>
    public partial class RegisterAgentRequest : AmazonGroundStationRequest
    {
        private AgentDetails _agentDetails;
        private DiscoveryData _discoveryData;

        /// <summary>
        /// Gets and sets the property AgentDetails. 
        /// <para>
        /// Detailed information about the agent being registered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentDetails AgentDetails
        {
            get { return this._agentDetails; }
            set { this._agentDetails = value; }
        }

        // Check to see if AgentDetails property is set
        internal bool IsSetAgentDetails()
        {
            return this._agentDetails != null;
        }

        /// <summary>
        /// Gets and sets the property DiscoveryData. 
        /// <para>
        /// Data for associating and agent with the capabilities it is managing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DiscoveryData DiscoveryData
        {
            get { return this._discoveryData; }
            set { this._discoveryData = value; }
        }

        // Check to see if DiscoveryData property is set
        internal bool IsSetDiscoveryData()
        {
            return this._discoveryData != null;
        }

    }
}