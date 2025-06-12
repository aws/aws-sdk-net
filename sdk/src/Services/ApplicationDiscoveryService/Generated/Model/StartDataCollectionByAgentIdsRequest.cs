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
    /// Container for the parameters to the StartDataCollectionByAgentIds operation.
    /// Instructs the specified agents to start collecting data.
    /// </summary>
    public partial class StartDataCollectionByAgentIdsRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private List<string> _agentIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AgentIds. 
        /// <para>
        /// The IDs of the agents from which to start collecting data. If you send a request to
        /// an agent ID that you do not have permission to contact, according to your Amazon Web
        /// Services account, the service does not throw an exception. Instead, it returns the
        /// error in the <i>Description</i> field. If you send a request to multiple agents and
        /// you do not have permission to contact some of those agents, the system does not throw
        /// an exception. Instead, the system shows <c>Failed</c> in the <i>Description</i> field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AgentIds
        {
            get { return this._agentIds; }
            set { this._agentIds = value; }
        }

        // Check to see if AgentIds property is set
        internal bool IsSetAgentIds()
        {
            return this._agentIds != null && (this._agentIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}