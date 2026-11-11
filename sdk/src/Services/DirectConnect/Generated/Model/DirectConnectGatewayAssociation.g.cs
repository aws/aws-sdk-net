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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about an association between a Direct Connect gateway and a virtual private
    /// gateway or transit gateway.
    /// </summary>
    public partial class DirectConnectGatewayAssociation
    {
        /// <summary>
        /// Gets and sets the property AllowedPrefixesToDirectConnectGateway. 
        /// <para>
        /// The Amazon VPC prefixes to advertise to the Direct Connect gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteFilterPrefix> AllowedPrefixesToDirectConnectGateway { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteFilterPrefix>() : null;

        /// <summary>
        /// Checks to see if the AllowedPrefixesToDirectConnectGateway property is set.
        /// </summary>
        internal bool IsSetAllowedPrefixesToDirectConnectGateway() => this.AllowedPrefixesToDirectConnectGateway != null && (this.AllowedPrefixesToDirectConnectGateway.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssociatedCoreNetwork. 
        /// <para>
        /// The ID of the Cloud WAN core network associated with the Direct Connect gateway attachment.
        /// </para>
        /// </summary>
        public AssociatedCoreNetwork AssociatedCoreNetwork { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedCoreNetwork property is set.
        /// </summary>
        internal bool IsSetAssociatedCoreNetwork() => this.AssociatedCoreNetwork != null;

        /// <summary>
        /// Gets and sets the property AssociatedGateway. 
        /// <para>
        /// Information about the associated gateway.
        /// </para>
        /// </summary>
        public AssociatedGateway AssociatedGateway { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedGateway property is set.
        /// </summary>
        internal bool IsSetAssociatedGateway() => this.AssociatedGateway != null;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the Direct Connect gateway association.
        /// </para>
        /// </summary>
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property AssociationState. 
        /// <para>
        /// The state of the association. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>associating</c>: The initial state after calling <a>CreateDirectConnectGatewayAssociation</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>associated</c>: The Direct Connect gateway and virtual private gateway or transit
        /// gateway are successfully associated and ready to pass traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disassociating</c>: The initial state after calling <a>DeleteDirectConnectGatewayAssociation</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disassociated</c>: The virtual private gateway or transit gateway is disassociated
        /// from the Direct Connect gateway. Traffic flow between the Direct Connect gateway and
        /// virtual private gateway or transit gateway is stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>updating</c>: The CIDR blocks for the virtual private gateway or transit gateway
        /// are currently being updated. This could be new CIDR blocks added or current CIDR blocks
        /// removed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DirectConnectGatewayAssociationState AssociationState { get; set; }

        /// <summary>
        /// Checks to see if the AssociationState property is set.
        /// </summary>
        internal bool IsSetAssociationState() => this.AssociationState != null;

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayId. 
        /// <para>
        /// The ID of the Direct Connect gateway.
        /// </para>
        /// </summary>
        public string DirectConnectGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the DirectConnectGatewayId property is set.
        /// </summary>
        internal bool IsSetDirectConnectGatewayId() => this.DirectConnectGatewayId != null;

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayOwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the associated gateway.
        /// </para>
        /// </summary>
        public string DirectConnectGatewayOwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the DirectConnectGatewayOwnerAccount property is set.
        /// </summary>
        internal bool IsSetDirectConnectGatewayOwnerAccount() => this.DirectConnectGatewayOwnerAccount != null;

        /// <summary>
        /// Gets and sets the property StateChangeError. 
        /// <para>
        /// The error message if the state of an object failed to advance.
        /// </para>
        /// </summary>
        public string StateChangeError { get; set; }

        /// <summary>
        /// Checks to see if the StateChangeError property is set.
        /// </summary>
        internal bool IsSetStateChangeError() => this.StateChangeError != null;

        /// <summary>
        /// Gets and sets the property VirtualGatewayId. 
        /// <para>
        /// The ID of the virtual private gateway. Applies only to private virtual interfaces.
        /// </para>
        /// </summary>
        public string VirtualGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the VirtualGatewayId property is set.
        /// </summary>
        internal bool IsSetVirtualGatewayId() => this.VirtualGatewayId != null;

        /// <summary>
        /// Gets and sets the property VirtualGatewayOwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the virtual private gateway.
        /// </para>
        /// </summary>
        public string VirtualGatewayOwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the VirtualGatewayOwnerAccount property is set.
        /// </summary>
        internal bool IsSetVirtualGatewayOwnerAccount() => this.VirtualGatewayOwnerAccount != null;

        /// <summary>
        /// Gets and sets the property VirtualGatewayRegion. 
        /// <para>
        /// The Amazon Web Services Region where the virtual private gateway is located.
        /// </para>
        /// </summary>
        public string VirtualGatewayRegion { get; set; }

        /// <summary>
        /// Checks to see if the VirtualGatewayRegion property is set.
        /// </summary>
        internal bool IsSetVirtualGatewayRegion() => this.VirtualGatewayRegion != null;
    }
}
