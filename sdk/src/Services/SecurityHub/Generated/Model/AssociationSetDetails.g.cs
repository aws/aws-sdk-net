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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The associations between a route table and one or more subnets or a gateway.
    /// </summary>
    public partial class AssociationSetDetails
    {
        /// <summary>
        /// Gets and sets the property AssociationState. 
        /// <para>
        ///  The state of the association between a route table and a subnet or gateway. 
        /// </para>
        /// </summary>
        public AssociationStateDetails AssociationState { get; set; }

        /// <summary>
        /// Checks to see if the AssociationState property is set.
        /// </summary>
        internal bool IsSetAssociationState() => this.AssociationState != null;

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        ///  The ID of the internet gateway or virtual private gateway. 
        /// </para>
        /// </summary>
        public string GatewayId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayId property is set.
        /// </summary>
        internal bool IsSetGatewayId() => this.GatewayId != null;

        /// <summary>
        /// Gets and sets the property Main. 
        /// <para>
        ///  Indicates whether this is the main route table. 
        /// </para>
        /// </summary>
        public bool? Main { get; set; }

        /// <summary>
        /// Checks to see if the Main property is set.
        /// </summary>
        internal bool IsSetMain() => this.Main.HasValue;

        /// <summary>
        /// Gets and sets the property RouteTableAssociationId. 
        /// <para>
        ///  The ID of the association. 
        /// </para>
        /// </summary>
        public string RouteTableAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the RouteTableAssociationId property is set.
        /// </summary>
        internal bool IsSetRouteTableAssociationId() => this.RouteTableAssociationId != null;

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        ///  The ID of the route table. 
        /// </para>
        /// </summary>
        public string RouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the RouteTableId property is set.
        /// </summary>
        internal bool IsSetRouteTableId() => this.RouteTableId != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        ///  The ID of the subnet. A subnet ID is not returned for an implicit association. 
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;
    }
}
