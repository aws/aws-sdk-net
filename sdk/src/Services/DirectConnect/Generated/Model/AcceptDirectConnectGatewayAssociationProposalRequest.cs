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
    /// Container for the parameters to the AcceptDirectConnectGatewayAssociationProposal operation.
    /// Accepts a proposal request to attach a virtual private gateway or transit gateway
    /// to a Direct Connect gateway.
    /// </summary>
    public partial class AcceptDirectConnectGatewayAssociationProposalRequest : AmazonDirectConnectRequest
    {
        private string _associatedGatewayOwnerAccount;
        private string _directConnectGatewayId;
        private List<RouteFilterPrefix> _overrideAllowedPrefixesToDirectConnectGateway = AWSConfigs.InitializeCollections ? new List<RouteFilterPrefix>() : null;
        private string _proposalId;

        /// <summary>
        /// Gets and sets the property AssociatedGatewayOwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the virtual private gateway or
        /// transit gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssociatedGatewayOwnerAccount
        {
            get { return this._associatedGatewayOwnerAccount; }
            set { this._associatedGatewayOwnerAccount = value; }
        }

        // Check to see if AssociatedGatewayOwnerAccount property is set
        internal bool IsSetAssociatedGatewayOwnerAccount()
        {
            return this._associatedGatewayOwnerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayId. 
        /// <para>
        /// The ID of the Direct Connect gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteFilterPrefix> OverrideAllowedPrefixesToDirectConnectGateway
        {
            get { return this._overrideAllowedPrefixesToDirectConnectGateway; }
            set { this._overrideAllowedPrefixesToDirectConnectGateway = value; }
        }

        // Check to see if OverrideAllowedPrefixesToDirectConnectGateway property is set
        internal bool IsSetOverrideAllowedPrefixesToDirectConnectGateway()
        {
            return this._overrideAllowedPrefixesToDirectConnectGateway != null && (this._overrideAllowedPrefixesToDirectConnectGateway.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProposalId. 
        /// <para>
        /// The ID of the request proposal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}