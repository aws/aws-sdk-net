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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Information about agents associated with the user’s Amazon Web Services account. Information
    /// includes agent IDs, IP addresses, media access control (MAC) addresses, agent or collector
    /// status, hostname where the agent resides, and agent version for each agent.
    /// </summary>
    public partial class AgentInfo
    {
        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The agent or collector ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 20)]
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

        /// <summary>
        /// Gets and sets the property AgentNetworkInfoList. 
        /// <para>
        /// Network details about the host where the agent or collector resides.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgentNetworkInfo> AgentNetworkInfoList { get; set; } = AWSConfigs.InitializeCollections ? new List<AgentNetworkInfo>() : null;

        /// <summary>
        /// Checks to see if the AgentNetworkInfoList property is set.
        /// </summary>
        internal bool IsSetAgentNetworkInfoList() => this.AgentNetworkInfoList != null && (this.AgentNetworkInfoList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AgentType. 
        /// <para>
        /// Type of agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string AgentType { get; set; }

        /// <summary>
        /// Checks to see if the AgentType property is set.
        /// </summary>
        internal bool IsSetAgentType() => this.AgentType != null;

        /// <summary>
        /// Gets and sets the property CollectionStatus. 
        /// <para>
        /// Status of the collection process for an agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string CollectionStatus { get; set; }

        /// <summary>
        /// Checks to see if the CollectionStatus property is set.
        /// </summary>
        internal bool IsSetCollectionStatus() => this.CollectionStatus != null;

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The ID of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorId property is set.
        /// </summary>
        internal bool IsSetConnectorId() => this.ConnectorId != null;

        /// <summary>
        /// Gets and sets the property Health. 
        /// <para>
        /// The health of the agent.
        /// </para>
        /// </summary>
        public AgentStatus Health { get; set; }

        /// <summary>
        /// Checks to see if the Health property is set.
        /// </summary>
        internal bool IsSetHealth() => this.Health != null;

        /// <summary>
        /// Gets and sets the property HostName. 
        /// <para>
        /// The name of the host where the agent or collector resides. The host can be a server
        /// or virtual machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string HostName { get; set; }

        /// <summary>
        /// Checks to see if the HostName property is set.
        /// </summary>
        internal bool IsSetHostName() => this.HostName != null;

        /// <summary>
        /// Gets and sets the property LastHealthPingTime. 
        /// <para>
        /// Time since agent health was reported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string LastHealthPingTime { get; set; }

        /// <summary>
        /// Checks to see if the LastHealthPingTime property is set.
        /// </summary>
        internal bool IsSetLastHealthPingTime() => this.LastHealthPingTime != null;

        /// <summary>
        /// Gets and sets the property RegisteredTime. 
        /// <para>
        /// Agent's first registration timestamp in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string RegisteredTime { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredTime property is set.
        /// </summary>
        internal bool IsSetRegisteredTime() => this.RegisteredTime != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The agent or collector version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
