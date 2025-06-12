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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private List<string> _asPaths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _med;
        private string _nextHopIp;
        private string _prefix;
        private List<RouteServerRouteInstallationDetail> _routeInstallationDetails = AWSConfigs.InitializeCollections ? new List<RouteServerRouteInstallationDetail>() : null;
        private string _routeServerEndpointId;
        private string _routeServerPeerId;
        private RouteServerRouteStatus _routeStatus;

        /// <summary>
        /// Gets and sets the property AsPaths. 
        /// <para>
        /// The AS path attributes of the BGP route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AsPaths
        {
            get { return this._asPaths; }
            set { this._asPaths = value; }
        }

        // Check to see if AsPaths property is set
        internal bool IsSetAsPaths()
        {
            return this._asPaths != null && (this._asPaths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Med. 
        /// <para>
        /// The Multi-Exit Discriminator (MED) value of the BGP route.
        /// </para>
        /// </summary>
        public int? Med
        {
            get { return this._med; }
            set { this._med = value; }
        }

        // Check to see if Med property is set
        internal bool IsSetMed()
        {
            return this._med.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextHopIp. 
        /// <para>
        /// The IP address for the next hop.
        /// </para>
        /// </summary>
        public string NextHopIp
        {
            get { return this._nextHopIp; }
            set { this._nextHopIp = value; }
        }

        // Check to see if NextHopIp property is set
        internal bool IsSetNextHopIp()
        {
            return this._nextHopIp != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The destination CIDR block of the route.
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property RouteInstallationDetails. 
        /// <para>
        /// Details about the installation status of this route in route tables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteServerRouteInstallationDetail> RouteInstallationDetails
        {
            get { return this._routeInstallationDetails; }
            set { this._routeInstallationDetails = value; }
        }

        // Check to see if RouteInstallationDetails property is set
        internal bool IsSetRouteInstallationDetails()
        {
            return this._routeInstallationDetails != null && (this._routeInstallationDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RouteServerEndpointId. 
        /// <para>
        /// The ID of the route server endpoint that received this route.
        /// </para>
        /// </summary>
        public string RouteServerEndpointId
        {
            get { return this._routeServerEndpointId; }
            set { this._routeServerEndpointId = value; }
        }

        // Check to see if RouteServerEndpointId property is set
        internal bool IsSetRouteServerEndpointId()
        {
            return this._routeServerEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property RouteServerPeerId. 
        /// <para>
        /// The ID of the route server peer that advertised this route.
        /// </para>
        /// </summary>
        public string RouteServerPeerId
        {
            get { return this._routeServerPeerId; }
            set { this._routeServerPeerId = value; }
        }

        // Check to see if RouteServerPeerId property is set
        internal bool IsSetRouteServerPeerId()
        {
            return this._routeServerPeerId != null;
        }

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
        public RouteServerRouteStatus RouteStatus
        {
            get { return this._routeStatus; }
            set { this._routeStatus = value; }
        }

        // Check to see if RouteStatus property is set
        internal bool IsSetRouteStatus()
        {
            return this._routeStatus != null;
        }

    }
}