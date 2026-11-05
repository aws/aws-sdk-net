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
    /// This is the response object from the GetDiscoverySummary operation.
    /// </summary>
    public partial class GetDiscoverySummaryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentSummary. 
        /// <para>
        /// Details about discovered agents, including agent status and health.
        /// </para>
        /// </summary>
        public CustomerAgentInfo AgentSummary { get; set; }

        /// <summary>
        /// Checks to see if the AgentSummary property is set.
        /// </summary>
        internal bool IsSetAgentSummary() => this.AgentSummary != null;

        /// <summary>
        /// Gets and sets the property AgentlessCollectorSummary. 
        /// <para>
        ///  Details about Agentless Collector collectors, including status. 
        /// </para>
        /// </summary>
        public CustomerAgentlessCollectorInfo AgentlessCollectorSummary { get; set; }

        /// <summary>
        /// Checks to see if the AgentlessCollectorSummary property is set.
        /// </summary>
        internal bool IsSetAgentlessCollectorSummary() => this.AgentlessCollectorSummary != null;

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// The number of applications discovered.
        /// </para>
        /// </summary>
        public long? Applications { get; set; }

        /// <summary>
        /// Checks to see if the Applications property is set.
        /// </summary>
        internal bool IsSetApplications() => this.Applications.HasValue;

        /// <summary>
        /// Gets and sets the property ConnectorSummary. 
        /// <para>
        /// Details about discovered connectors, including connector status and health.
        /// </para>
        /// </summary>
        public CustomerConnectorInfo ConnectorSummary { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorSummary property is set.
        /// </summary>
        internal bool IsSetConnectorSummary() => this.ConnectorSummary != null;

        /// <summary>
        /// Gets and sets the property MeCollectorSummary. 
        /// <para>
        ///  Details about Migration Evaluator collectors, including collector status and health.
        /// 
        /// </para>
        /// </summary>
        public CustomerMeCollectorInfo MeCollectorSummary { get; set; }

        /// <summary>
        /// Checks to see if the MeCollectorSummary property is set.
        /// </summary>
        internal bool IsSetMeCollectorSummary() => this.MeCollectorSummary != null;

        /// <summary>
        /// Gets and sets the property Servers. 
        /// <para>
        /// The number of servers discovered.
        /// </para>
        /// </summary>
        public long? Servers { get; set; }

        /// <summary>
        /// Checks to see if the Servers property is set.
        /// </summary>
        internal bool IsSetServers() => this.Servers.HasValue;

        /// <summary>
        /// Gets and sets the property ServersMappedToApplications. 
        /// <para>
        /// The number of servers mapped to applications.
        /// </para>
        /// </summary>
        public long? ServersMappedToApplications { get; set; }

        /// <summary>
        /// Checks to see if the ServersMappedToApplications property is set.
        /// </summary>
        internal bool IsSetServersMappedToApplications() => this.ServersMappedToApplications.HasValue;

        /// <summary>
        /// Gets and sets the property ServersMappedtoTags. 
        /// <para>
        /// The number of servers mapped to tags.
        /// </para>
        /// </summary>
        public long? ServersMappedtoTags { get; set; }

        /// <summary>
        /// Checks to see if the ServersMappedtoTags property is set.
        /// </summary>
        internal bool IsSetServersMappedtoTags() => this.ServersMappedtoTags.HasValue;
    }
}
