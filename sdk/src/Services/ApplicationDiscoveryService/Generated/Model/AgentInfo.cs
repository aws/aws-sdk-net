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
    /// Information about agents or connectors associated with the user’s AWS account. Information
    /// includes agent or connector IDs, IP addresses, media access control (MAC) addresses,
    /// agent or connector health, hostname where the agent or connector resides, and agent
    /// version for each agent.
    /// </summary>
    public partial class AgentInfo
    {
        private string _agentId;
        private List<AgentNetworkInfo> _agentNetworkInfoList = new List<AgentNetworkInfo>();
        private string _agentType;
        private string _collectionStatus;
        private string _connectorId;
        private AgentStatus _health;
        private string _hostName;
        private string _lastHealthPingTime;
        private string _registeredTime;
        private string _version;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The agent or connector ID.
        /// </para>
        /// </summary>
        public string AgentId
        {
            get { return this._agentId; }
            set { this._agentId = value; }
        }

        // Check to see if AgentId property is set
        internal bool IsSetAgentId()
        {
            return this._agentId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentNetworkInfoList. 
        /// <para>
        /// Network details about the host where the agent or connector resides.
        /// </para>
        /// </summary>
        public List<AgentNetworkInfo> AgentNetworkInfoList
        {
            get { return this._agentNetworkInfoList; }
            set { this._agentNetworkInfoList = value; }
        }

        // Check to see if AgentNetworkInfoList property is set
        internal bool IsSetAgentNetworkInfoList()
        {
            return this._agentNetworkInfoList != null && this._agentNetworkInfoList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AgentType. 
        /// <para>
        /// Type of agent.
        /// </para>
        /// </summary>
        public string AgentType
        {
            get { return this._agentType; }
            set { this._agentType = value; }
        }

        // Check to see if AgentType property is set
        internal bool IsSetAgentType()
        {
            return this._agentType != null;
        }

        /// <summary>
        /// Gets and sets the property CollectionStatus. 
        /// <para>
        /// Status of the collection process for an agent or connector.
        /// </para>
        /// </summary>
        public string CollectionStatus
        {
            get { return this._collectionStatus; }
            set { this._collectionStatus = value; }
        }

        // Check to see if CollectionStatus property is set
        internal bool IsSetCollectionStatus()
        {
            return this._collectionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The ID of the connector.
        /// </para>
        /// </summary>
        public string ConnectorId
        {
            get { return this._connectorId; }
            set { this._connectorId = value; }
        }

        // Check to see if ConnectorId property is set
        internal bool IsSetConnectorId()
        {
            return this._connectorId != null;
        }

        /// <summary>
        /// Gets and sets the property Health. 
        /// <para>
        /// The health of the agent or connector.
        /// </para>
        /// </summary>
        public AgentStatus Health
        {
            get { return this._health; }
            set { this._health = value; }
        }

        // Check to see if Health property is set
        internal bool IsSetHealth()
        {
            return this._health != null;
        }

        /// <summary>
        /// Gets and sets the property HostName. 
        /// <para>
        /// The name of the host where the agent or connector resides. The host can be a server
        /// or virtual machine.
        /// </para>
        /// </summary>
        public string HostName
        {
            get { return this._hostName; }
            set { this._hostName = value; }
        }

        // Check to see if HostName property is set
        internal bool IsSetHostName()
        {
            return this._hostName != null;
        }

        /// <summary>
        /// Gets and sets the property LastHealthPingTime. 
        /// <para>
        /// Time since agent or connector health was reported.
        /// </para>
        /// </summary>
        public string LastHealthPingTime
        {
            get { return this._lastHealthPingTime; }
            set { this._lastHealthPingTime = value; }
        }

        // Check to see if LastHealthPingTime property is set
        internal bool IsSetLastHealthPingTime()
        {
            return this._lastHealthPingTime != null;
        }

        /// <summary>
        /// Gets and sets the property RegisteredTime. 
        /// <para>
        /// Agent's first registration timestamp in UTC.
        /// </para>
        /// </summary>
        public string RegisteredTime
        {
            get { return this._registeredTime; }
            set { this._registeredTime = value; }
        }

        // Check to see if RegisteredTime property is set
        internal bool IsSetRegisteredTime()
        {
            return this._registeredTime != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The agent or connector version.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}