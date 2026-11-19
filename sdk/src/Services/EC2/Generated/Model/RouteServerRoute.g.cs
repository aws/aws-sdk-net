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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a route in the route server's routing database.
    /// </summary>
    public partial class RouteServerRoute
    {
        /// <summary>
        /// Gets and sets the property AsPaths. 
        /// <para>
        /// The AS path attributes of the BGP route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AsPaths { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AsPaths property is set.
        /// </summary>
        internal bool IsSetAsPaths() => this.AsPaths != null && (this.AsPaths.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Med. 
        /// <para>
        /// The Multi-Exit Discriminator (MED) value of the BGP route.
        /// </para>
        /// </summary>
        public int? Med { get; set; }

        /// <summary>
        /// Checks to see if the Med property is set.
        /// </summary>
        internal bool IsSetMed() => this.Med.HasValue;

        /// <summary>
        /// Gets and sets the property NextHopIp. 
        /// <para>
        /// The IP address for the next hop.
        /// </para>
        /// </summary>
        public string NextHopIp { get; set; }

        /// <summary>
        /// Checks to see if the NextHopIp property is set.
        /// </summary>
        internal bool IsSetNextHopIp() => this.NextHopIp != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The destination CIDR block of the route.
        /// </para>
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property RouteInstallationDetails. 
        /// <para>
        /// Details about the installation status of this route in route tables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteServerRouteInstallationDetail> RouteInstallationDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteServerRouteInstallationDetail>() : null;

        /// <summary>
        /// Checks to see if the RouteInstallationDetails property is set.
        /// </summary>
        internal bool IsSetRouteInstallationDetails() => this.RouteInstallationDetails != null && (this.RouteInstallationDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RouteServerEndpointId. 
        /// <para>
        /// The ID of the route server endpoint that received this route.
        /// </para>
        /// </summary>
        public string RouteServerEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the RouteServerEndpointId property is set.
        /// </summary>
        internal bool IsSetRouteServerEndpointId() => this.RouteServerEndpointId != null;

        /// <summary>
        /// Gets and sets the property RouteServerPeerId. 
        /// <para>
        /// The ID of the route server peer that advertised this route.
        /// </para>
        /// </summary>
        public string RouteServerPeerId { get; set; }

        /// <summary>
        /// Checks to see if the RouteServerPeerId property is set.
        /// </summary>
        internal bool IsSetRouteServerPeerId() => this.RouteServerPeerId != null;

        /// <summary>
        /// Gets and sets the property RouteStatus. 
        /// <para>
        /// The current status of the route in the routing database. Values are <c>in-rib</c>
        /// or <c>in-fib</c> depending on if the routes are in the RIB or the FIB database.
        /// </para>
        ///  
        /// <para>
        /// The <a href="https://en.wikipedia.org/wiki/Routing_table">Routing Information Base
        /// (RIB)</a> serves as a database that stores all the routing information and network
        /// topology data collected by a router or routing system, such as routes learned from
        /// BGP peers. The RIB is constantly updated as new routing information is received or
        /// existing routes change. This ensures that the route server always has the most current
        /// view of the network topology and can make optimal routing decisions.
        /// </para>
        ///  
        /// <para>
        /// The <a href="https://en.wikipedia.org/wiki/Forwarding_information_base">Forwarding
        /// Information Base (FIB)</a> serves as a forwarding table for what route server has
        /// determined are the best-path routes in the RIB after evaluating all available routing
        /// information and policies. The FIB routes are installed on the route tables. The FIB
        /// is recomputed whenever there are changes to the RIB.
        /// </para>
        /// </summary>
        public RouteServerRouteStatus RouteStatus { get; set; }

        /// <summary>
        /// Checks to see if the RouteStatus property is set.
        /// </summary>
        internal bool IsSetRouteStatus() => this.RouteStatus != null;
    }
}
