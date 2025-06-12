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
    /// Container for the parameters to the CreateDirectConnectGatewayAssociationProposal operation.
    /// Creates a proposal to associate the specified virtual private gateway or transit gateway
    /// with the specified Direct Connect gateway.
    /// 
    ///  
    /// <para>
    /// You can associate a Direct Connect gateway and virtual private gateway or transit
    /// gateway that is owned by any Amazon Web Services account. 
    /// </para>
    /// </summary>
    public partial class CreateDirectConnectGatewayAssociationProposalRequest : AmazonDirectConnectRequest
    {
        private List<RouteFilterPrefix> _addAllowedPrefixesToDirectConnectGateway = AWSConfigs.InitializeCollections ? new List<RouteFilterPrefix>() : null;
        private string _directConnectGatewayId;
        private string _directConnectGatewayOwnerAccount;
        private string _gatewayId;
        private List<RouteFilterPrefix> _removeAllowedPrefixesToDirectConnectGateway = AWSConfigs.InitializeCollections ? new List<RouteFilterPrefix>() : null;

        /// <summary>
        /// Gets and sets the property AddAllowedPrefixesToDirectConnectGateway. 
        /// <para>
        /// The Amazon VPC prefixes to advertise to the Direct Connect gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteFilterPrefix> AddAllowedPrefixesToDirectConnectGateway
        {
            get { return this._addAllowedPrefixesToDirectConnectGateway; }
            set { this._addAllowedPrefixesToDirectConnectGateway = value; }
        }

        // Check to see if AddAllowedPrefixesToDirectConnectGateway property is set
        internal bool IsSetAddAllowedPrefixesToDirectConnectGateway()
        {
            return this._addAllowedPrefixesToDirectConnectGateway != null && (this._addAllowedPrefixesToDirectConnectGateway.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property DirectConnectGatewayOwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the Direct Connect gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The ID of the virtual private gateway or transit gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveAllowedPrefixesToDirectConnectGateway. 
        /// <para>
        /// The Amazon VPC prefixes to no longer advertise to the Direct Connect gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteFilterPrefix> RemoveAllowedPrefixesToDirectConnectGateway
        {
            get { return this._removeAllowedPrefixesToDirectConnectGateway; }
            set { this._removeAllowedPrefixesToDirectConnectGateway = value; }
        }

        // Check to see if RemoveAllowedPrefixesToDirectConnectGateway property is set
        internal bool IsSetRemoveAllowedPrefixesToDirectConnectGateway()
        {
            return this._removeAllowedPrefixesToDirectConnectGateway != null && (this._removeAllowedPrefixesToDirectConnectGateway.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}