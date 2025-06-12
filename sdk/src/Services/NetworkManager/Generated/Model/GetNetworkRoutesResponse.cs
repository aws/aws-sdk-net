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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// This is the response object from the GetNetworkRoutes operation.
    /// </summary>
    public partial class GetNetworkRoutesResponse : AmazonWebServiceResponse
    {
        private CoreNetworkSegmentEdgeIdentifier _coreNetworkSegmentEdge;
        private List<NetworkRoute> _networkRoutes = AWSConfigs.InitializeCollections ? new List<NetworkRoute>() : null;
        private string _routeTableArn;
        private DateTime? _routeTableTimestamp;
        private RouteTableType _routeTableType;

        /// <summary>
        /// Gets and sets the property CoreNetworkSegmentEdge. 
        /// <para>
        /// Describes a core network segment edge.
        /// </para>
        /// </summary>
        public CoreNetworkSegmentEdgeIdentifier CoreNetworkSegmentEdge
        {
            get { return this._coreNetworkSegmentEdge; }
            set { this._coreNetworkSegmentEdge = value; }
        }

        // Check to see if CoreNetworkSegmentEdge property is set
        internal bool IsSetCoreNetworkSegmentEdge()
        {
            return this._coreNetworkSegmentEdge != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkRoutes. 
        /// <para>
        /// The network routes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkRoute> NetworkRoutes
        {
            get { return this._networkRoutes; }
            set { this._networkRoutes = value; }
        }

        // Check to see if NetworkRoutes property is set
        internal bool IsSetNetworkRoutes()
        {
            return this._networkRoutes != null && (this._networkRoutes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RouteTableArn. 
        /// <para>
        /// The ARN of the route table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1500)]
        public string RouteTableArn
        {
            get { return this._routeTableArn; }
            set { this._routeTableArn = value; }
        }

        // Check to see if RouteTableArn property is set
        internal bool IsSetRouteTableArn()
        {
            return this._routeTableArn != null;
        }

        /// <summary>
        /// Gets and sets the property RouteTableTimestamp. 
        /// <para>
        /// The route table creation time.
        /// </para>
        /// </summary>
        public DateTime? RouteTableTimestamp
        {
            get { return this._routeTableTimestamp; }
            set { this._routeTableTimestamp = value; }
        }

        // Check to see if RouteTableTimestamp property is set
        internal bool IsSetRouteTableTimestamp()
        {
            return this._routeTableTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RouteTableType. 
        /// <para>
        /// The route table type.
        /// </para>
        /// </summary>
        public RouteTableType RouteTableType
        {
            get { return this._routeTableType; }
            set { this._routeTableType = value; }
        }

        // Check to see if RouteTableType property is set
        internal bool IsSetRouteTableType()
        {
            return this._routeTableType != null;
        }

    }
}