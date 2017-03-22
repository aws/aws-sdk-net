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
    /// This is the response object from the GetDiscoverySummary operation.
    /// </summary>
    public partial class GetDiscoverySummaryResponse : AmazonWebServiceResponse
    {
        private CustomerAgentInfo _agentSummary;
        private long? _applications;
        private CustomerConnectorInfo _connectorSummary;
        private long? _servers;
        private long? _serversMappedToApplications;
        private long? _serversMappedtoTags;

        /// <summary>
        /// Gets and sets the property AgentSummary. 
        /// <para>
        /// Details about discovered agents, including agent status and health.
        /// </para>
        /// </summary>
        public CustomerAgentInfo AgentSummary
        {
            get { return this._agentSummary; }
            set { this._agentSummary = value; }
        }

        // Check to see if AgentSummary property is set
        internal bool IsSetAgentSummary()
        {
            return this._agentSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// The number of applications discovered.
        /// </para>
        /// </summary>
        public long Applications
        {
            get { return this._applications.GetValueOrDefault(); }
            set { this._applications = value; }
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this._applications.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectorSummary. 
        /// <para>
        /// Details about discovered connectors, including connector status and health.
        /// </para>
        /// </summary>
        public CustomerConnectorInfo ConnectorSummary
        {
            get { return this._connectorSummary; }
            set { this._connectorSummary = value; }
        }

        // Check to see if ConnectorSummary property is set
        internal bool IsSetConnectorSummary()
        {
            return this._connectorSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Servers. 
        /// <para>
        /// The number of servers discovered.
        /// </para>
        /// </summary>
        public long Servers
        {
            get { return this._servers.GetValueOrDefault(); }
            set { this._servers = value; }
        }

        // Check to see if Servers property is set
        internal bool IsSetServers()
        {
            return this._servers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServersMappedToApplications. 
        /// <para>
        /// The number of servers mapped to applications.
        /// </para>
        /// </summary>
        public long ServersMappedToApplications
        {
            get { return this._serversMappedToApplications.GetValueOrDefault(); }
            set { this._serversMappedToApplications = value; }
        }

        // Check to see if ServersMappedToApplications property is set
        internal bool IsSetServersMappedToApplications()
        {
            return this._serversMappedToApplications.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServersMappedtoTags. 
        /// <para>
        /// The number of servers mapped to tags.
        /// </para>
        /// </summary>
        public long ServersMappedtoTags
        {
            get { return this._serversMappedtoTags.GetValueOrDefault(); }
            set { this._serversMappedtoTags = value; }
        }

        // Check to see if ServersMappedtoTags property is set
        internal bool IsSetServersMappedtoTags()
        {
            return this._serversMappedtoTags.HasValue; 
        }

    }
}