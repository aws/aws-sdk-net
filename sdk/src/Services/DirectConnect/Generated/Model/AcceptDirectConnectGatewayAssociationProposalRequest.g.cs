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
    /// Container for the parameters to the AcceptDirectConnectGatewayAssociationProposal
    /// operation. Accepts a proposal request to attach a virtual private gateway or transit
    /// gateway to a Direct Connect gateway.
    /// </summary>
    public partial class AcceptDirectConnectGatewayAssociationProposalRequest : AmazonDirectConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AssociatedGatewayOwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the virtual private gateway or
        /// transit gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssociatedGatewayOwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedGatewayOwnerAccount property is set.
        /// </summary>
        internal bool IsSetAssociatedGatewayOwnerAccount() => this.AssociatedGatewayOwnerAccount != null;

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayId. 
        /// <para>
        /// The ID of the Direct Connect gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectConnectGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the DirectConnectGatewayId property is set.
        /// </summary>
        internal bool IsSetDirectConnectGatewayId() => this.DirectConnectGatewayId != null;

        /// <summary>
        /// Gets and sets the property OverrideAllowedPrefixesToDirectConnectGateway. 
        /// <para>
        /// Overrides the Amazon VPC prefixes advertised to the Direct Connect gateway.
        /// </para>
        ///  
        /// <para>
        /// For information about how to set the prefixes, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/multi-account-associate-vgw.html#allowed-prefixes">Allowed
        /// Prefixes</a> in the <i>Direct Connect User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteFilterPrefix> OverrideAllowedPrefixesToDirectConnectGateway { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteFilterPrefix>() : null;

        /// <summary>
        /// Checks to see if the OverrideAllowedPrefixesToDirectConnectGateway property is set.
        /// </summary>
        internal bool IsSetOverrideAllowedPrefixesToDirectConnectGateway() => this.OverrideAllowedPrefixesToDirectConnectGateway != null && (this.OverrideAllowedPrefixesToDirectConnectGateway.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProposalId. 
        /// <para>
        /// The ID of the request proposal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProposalId { get; set; }

        /// <summary>
        /// Checks to see if the ProposalId property is set.
        /// </summary>
        internal bool IsSetProposalId() => this.ProposalId != null;
    }
}
