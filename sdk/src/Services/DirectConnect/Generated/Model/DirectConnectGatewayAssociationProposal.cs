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
    /// Information about the proposal request to attach a virtual private gateway to a Direct
    /// Connect gateway.
    /// </summary>
    public partial class DirectConnectGatewayAssociationProposal
    {
        private AssociatedGateway _associatedGateway;
        private string _directConnectGatewayId;
        private string _directConnectGatewayOwnerAccount;
        private List<RouteFilterPrefix> _existingAllowedPrefixesToDirectConnectGateway = AWSConfigs.InitializeCollections ? new List<RouteFilterPrefix>() : null;
        private string _proposalId;
        private DirectConnectGatewayAssociationProposalState _proposalState;
        private List<RouteFilterPrefix> _requestedAllowedPrefixesToDirectConnectGateway = AWSConfigs.InitializeCollections ? new List<RouteFilterPrefix>() : null;

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
        /// The ID of the Amazon Web Services account that owns the Direct Connect gateway.
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
        /// Gets and sets the property ExistingAllowedPrefixesToDirectConnectGateway. 
        /// <para>
        /// The existing Amazon VPC prefixes advertised to the Direct Connect gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteFilterPrefix> ExistingAllowedPrefixesToDirectConnectGateway
        {
            get { return this._existingAllowedPrefixesToDirectConnectGateway; }
            set { this._existingAllowedPrefixesToDirectConnectGateway = value; }
        }

        // Check to see if ExistingAllowedPrefixesToDirectConnectGateway property is set
        internal bool IsSetExistingAllowedPrefixesToDirectConnectGateway()
        {
            return this._existingAllowedPrefixesToDirectConnectGateway != null && (this._existingAllowedPrefixesToDirectConnectGateway.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProposalId. 
        /// <para>
        /// The ID of the association proposal.
        /// </para>
        /// </summary>
        public string ProposalId
        {
            get { return this._proposalId; }
            set { this._proposalId = value; }
        }

        // Check to see if ProposalId property is set
        internal bool IsSetProposalId()
        {
            return this._proposalId != null;
        }

        /// <summary>
        /// Gets and sets the property ProposalState. 
        /// <para>
        /// The state of the proposal. The following are possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>accepted</c>: The proposal has been accepted. The Direct Connect gateway association
        /// is available to use in this state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c>: The proposal has been deleted by the owner that made the proposal.
        /// The Direct Connect gateway association cannot be used in this state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>requested</c>: The proposal has been requested. The Direct Connect gateway association
        /// cannot be used in this state.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DirectConnectGatewayAssociationProposalState ProposalState
        {
            get { return this._proposalState; }
            set { this._proposalState = value; }
        }

        // Check to see if ProposalState property is set
        internal bool IsSetProposalState()
        {
            return this._proposalState != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedAllowedPrefixesToDirectConnectGateway. 
        /// <para>
        /// The Amazon VPC prefixes to advertise to the Direct Connect gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteFilterPrefix> RequestedAllowedPrefixesToDirectConnectGateway
        {
            get { return this._requestedAllowedPrefixesToDirectConnectGateway; }
            set { this._requestedAllowedPrefixesToDirectConnectGateway = value; }
        }

        // Check to see if RequestedAllowedPrefixesToDirectConnectGateway property is set
        internal bool IsSetRequestedAllowedPrefixesToDirectConnectGateway()
        {
            return this._requestedAllowedPrefixesToDirectConnectGateway != null && (this._requestedAllowedPrefixesToDirectConnectGateway.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}