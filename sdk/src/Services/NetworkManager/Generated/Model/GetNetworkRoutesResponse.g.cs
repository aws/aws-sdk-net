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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// This is the response object from the GetNetworkRoutes operation.
    /// </summary>
    public partial class GetNetworkRoutesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CoreNetworkSegmentEdge. 
        /// <para>
        /// Describes a core network segment edge.
        /// </para>
        /// </summary>
        public CoreNetworkSegmentEdgeIdentifier CoreNetworkSegmentEdge { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkSegmentEdge property is set.
        /// </summary>
        internal bool IsSetCoreNetworkSegmentEdge() => this.CoreNetworkSegmentEdge != null;

        /// <summary>
        /// Gets and sets the property NetworkRoutes. 
        /// <para>
        /// The network routes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkRoute> NetworkRoutes { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkRoute>() : null;

        /// <summary>
        /// Checks to see if the NetworkRoutes property is set.
        /// </summary>
        internal bool IsSetNetworkRoutes() => this.NetworkRoutes != null && (this.NetworkRoutes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RouteTableArn. 
        /// <para>
        /// The ARN of the route table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1500)]
        public string RouteTableArn { get; set; }

        /// <summary>
        /// Checks to see if the RouteTableArn property is set.
        /// </summary>
        internal bool IsSetRouteTableArn() => this.RouteTableArn != null;

        /// <summary>
        /// Gets and sets the property RouteTableTimestamp. 
        /// <para>
        /// The route table creation time.
        /// </para>
        /// </summary>
        public DateTime? RouteTableTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the RouteTableTimestamp property is set.
        /// </summary>
        internal bool IsSetRouteTableTimestamp() => this.RouteTableTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property RouteTableType. 
        /// <para>
        /// The route table type.
        /// </para>
        /// </summary>
        public RouteTableType RouteTableType { get; set; }

        /// <summary>
        /// Checks to see if the RouteTableType property is set.
        /// </summary>
        internal bool IsSetRouteTableType() => this.RouteTableType != null;
    }
}
