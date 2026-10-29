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
    /// Container for the parameters to the CreateDirectConnectGatewayAssociation operation.
    /// Creates an association between a Direct Connect gateway and a virtual private gateway.
    /// The virtual private gateway must be attached to a VPC and must not be associated with
    /// another Direct Connect gateway.
    /// </summary>
    public partial class CreateDirectConnectGatewayAssociationRequest : AmazonDirectConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AddAllowedPrefixesToDirectConnectGateway. 
        /// <para>
        /// The Amazon VPC prefixes to advertise to the Direct Connect gateway
        /// </para>
        ///  
        /// <para>
        /// This parameter is required when you create an association to a transit gateway.
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
        public List<RouteFilterPrefix> AddAllowedPrefixesToDirectConnectGateway { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteFilterPrefix>() : null;

        /// <summary>
        /// Checks to see if the AddAllowedPrefixesToDirectConnectGateway property is set.
        /// </summary>
        internal bool IsSetAddAllowedPrefixesToDirectConnectGateway() => this.AddAllowedPrefixesToDirectConnectGateway != null && (this.AddAllowedPrefixesToDirectConnectGateway.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The ID of the virtual private gateway or transit gateway.
        /// </para>
        /// </summary>
        public string GatewayId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayId property is set.
        /// </summary>
        internal bool IsSetGatewayId() => this.GatewayId != null;

        /// <summary>
        /// Gets and sets the property VirtualGatewayId. 
        /// <para>
        /// The ID of the virtual private gateway.
        /// </para>
        /// </summary>
        public string VirtualGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the VirtualGatewayId property is set.
        /// </summary>
        internal bool IsSetVirtualGatewayId() => this.VirtualGatewayId != null;
    }
}
