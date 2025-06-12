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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
        private List<RouteFilterPrefix> _allowedPrefixesToDirectConnectGateway = AWSConfigs.InitializeCollections ? new List<RouteFilterPrefix>() : null;
        private AssociatedCoreNetwork _associatedCoreNetwork;
        private AssociatedGateway _associatedGateway;
        private string _associationId;
        private DirectConnectGatewayAssociationState _associationState;
        private string _directConnectGatewayId;
        private string _directConnectGatewayOwnerAccount;
        private string _stateChangeError;
        private string _virtualGatewayId;
        private string _virtualGatewayOwnerAccount;
        private string _virtualGatewayRegion;

        /// <summary>
        /// Gets and sets the property AllowedPrefixesToDirectConnectGateway. 
        /// <para>
        /// The Amazon VPC prefixes to advertise to the Direct Connect gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteFilterPrefix> AllowedPrefixesToDirectConnectGateway
        {
            get { return this._allowedPrefixesToDirectConnectGateway; }
            set { this._allowedPrefixesToDirectConnectGateway = value; }
        }

        // Check to see if AllowedPrefixesToDirectConnectGateway property is set
        internal bool IsSetAllowedPrefixesToDirectConnectGateway()
        {
            return this._allowedPrefixesToDirectConnectGateway != null && (this._allowedPrefixesToDirectConnectGateway.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssociatedCoreNetwork. 
        /// <para>
        /// The ID of the Cloud WAN core network associated with the Direct Connect gateway attachment.
        /// </para>
        /// </summary>
        public AssociatedCoreNetwork AssociatedCoreNetwork
        {
            get { return this._associatedCoreNetwork; }
            set { this._associatedCoreNetwork = value; }
        }

        // Check to see if AssociatedCoreNetwork property is set
        internal bool IsSetAssociatedCoreNetwork()
        {
            return this._associatedCoreNetwork != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedGateway. 
        /// <para>
        /// Information about the associated gateway.
        /// </para>
        /// </summary>
        public AssociatedGateway AssociatedGateway
        {
            get { return this._associatedGateway; }
            set { this._associatedGateway = value; }
        }

        // Check to see if AssociatedGateway property is set
        internal bool IsSetAssociatedGateway()
        {
            return this._associatedGateway != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the Direct Connect gateway association.
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

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
        public DirectConnectGatewayAssociationState AssociationState
        {
            get { return this._associationState; }
            set { this._associationState = value; }
        }

        // Check to see if AssociationState property is set
        internal bool IsSetAssociationState()
        {
            return this._associationState != null;
        }

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayId. 
        /// <para>
        /// The ID of the Direct Connect gateway.
        /// </para>
        /// </summary>
        public string DirectConnectGatewayId
        {
            get { return this._directConnectGatewayId; }
            set { this._directConnectGatewayId = value; }
        }

        // Check to see if DirectConnectGatewayId property is set
        internal bool IsSetDirectConnectGatewayId()
        {
            return this._directConnectGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayOwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the associated gateway.
        /// </para>
        /// </summary>
        public string DirectConnectGatewayOwnerAccount
        {
            get { return this._directConnectGatewayOwnerAccount; }
            set { this._directConnectGatewayOwnerAccount = value; }
        }

        // Check to see if DirectConnectGatewayOwnerAccount property is set
        internal bool IsSetDirectConnectGatewayOwnerAccount()
        {
            return this._directConnectGatewayOwnerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property StateChangeError. 
        /// <para>
        /// The error message if the state of an object failed to advance.
        /// </para>
        /// </summary>
        public string StateChangeError
        {
            get { return this._stateChangeError; }
            set { this._stateChangeError = value; }
        }

        // Check to see if StateChangeError property is set
        internal bool IsSetStateChangeError()
        {
            return this._stateChangeError != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualGatewayId. 
        /// <para>
        /// The ID of the virtual private gateway. Applies only to private virtual interfaces.
        /// </para>
        /// </summary>
        public string VirtualGatewayId
        {
            get { return this._virtualGatewayId; }
            set { this._virtualGatewayId = value; }
        }

        // Check to see if VirtualGatewayId property is set
        internal bool IsSetVirtualGatewayId()
        {
            return this._virtualGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualGatewayOwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the virtual private gateway.
        /// </para>
        /// </summary>
        public string VirtualGatewayOwnerAccount
        {
            get { return this._virtualGatewayOwnerAccount; }
            set { this._virtualGatewayOwnerAccount = value; }
        }

        // Check to see if VirtualGatewayOwnerAccount property is set
        internal bool IsSetVirtualGatewayOwnerAccount()
        {
            return this._virtualGatewayOwnerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualGatewayRegion. 
        /// <para>
        /// The Amazon Web Services Region where the virtual private gateway is located.
        /// </para>
        /// </summary>
        public string VirtualGatewayRegion
        {
            get { return this._virtualGatewayRegion; }
            set { this._virtualGatewayRegion = value; }
        }

        // Check to see if VirtualGatewayRegion property is set
        internal bool IsSetVirtualGatewayRegion()
        {
            return this._virtualGatewayRegion != null;
        }

    }
}