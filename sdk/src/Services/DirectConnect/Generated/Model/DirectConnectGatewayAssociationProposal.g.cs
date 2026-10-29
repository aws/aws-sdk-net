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
    /// Information about the proposal request to attach a virtual private gateway to a Direct
    /// Connect gateway.
    /// </summary>
    public partial class DirectConnectGatewayAssociationProposal
    {
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
        /// The ID of the Amazon Web Services account that owns the Direct Connect gateway.
        /// </para>
        /// </summary>
        public string DirectConnectGatewayOwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the DirectConnectGatewayOwnerAccount property is set.
        /// </summary>
        internal bool IsSetDirectConnectGatewayOwnerAccount() => this.DirectConnectGatewayOwnerAccount != null;

        /// <summary>
        /// Gets and sets the property ExistingAllowedPrefixesToDirectConnectGateway. 
        /// <para>
        /// The existing Amazon VPC prefixes advertised to the Direct Connect gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteFilterPrefix> ExistingAllowedPrefixesToDirectConnectGateway { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteFilterPrefix>() : null;

        /// <summary>
        /// Checks to see if the ExistingAllowedPrefixesToDirectConnectGateway property is set.
        /// </summary>
        internal bool IsSetExistingAllowedPrefixesToDirectConnectGateway() => this.ExistingAllowedPrefixesToDirectConnectGateway != null && (this.ExistingAllowedPrefixesToDirectConnectGateway.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProposalId. 
        /// <para>
        /// The ID of the association proposal.
        /// </para>
        /// </summary>
        public string ProposalId { get; set; }

        /// <summary>
        /// Checks to see if the ProposalId property is set.
        /// </summary>
        internal bool IsSetProposalId() => this.ProposalId != null;

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
        public DirectConnectGatewayAssociationProposalState ProposalState { get; set; }

        /// <summary>
        /// Checks to see if the ProposalState property is set.
        /// </summary>
        internal bool IsSetProposalState() => this.ProposalState != null;

        /// <summary>
        /// Gets and sets the property RequestedAllowedPrefixesToDirectConnectGateway. 
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
        public List<RouteFilterPrefix> RequestedAllowedPrefixesToDirectConnectGateway { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteFilterPrefix>() : null;

        /// <summary>
        /// Checks to see if the RequestedAllowedPrefixesToDirectConnectGateway property is set.
        /// </summary>
        internal bool IsSetRequestedAllowedPrefixesToDirectConnectGateway() => this.RequestedAllowedPrefixesToDirectConnectGateway != null && (this.RequestedAllowedPrefixesToDirectConnectGateway.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
