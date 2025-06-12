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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// This is the response object from the StartDataCollectionByAgentIds operation.
    /// </summary>
    public partial class StartDataCollectionByAgentIdsResponse : AmazonWebServiceResponse
    {
        private List<AgentConfigurationStatus> _agentsConfigurationStatus = AWSConfigs.InitializeCollections ? new List<AgentConfigurationStatus>() : null;

        /// <summary>
        /// Gets and sets the property AgentsConfigurationStatus. 
        /// <para>
        /// Information about agents that were instructed to start collecting data. Information
        /// includes the agent ID, a description of the operation performed, and whether the agent
        /// configuration was updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgentConfigurationStatus> AgentsConfigurationStatus
        {
            get { return this._agentsConfigurationStatus; }
            set { this._agentsConfigurationStatus = value; }
        }

        // Check to see if AgentsConfigurationStatus property is set
        internal bool IsSetAgentsConfigurationStatus()
        {
            return this._agentsConfigurationStatus != null && (this._agentsConfigurationStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}