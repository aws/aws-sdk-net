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
    /// Information about a Direct Connect gateway, which enables you to connect virtual interfaces
    /// and virtual private gateway or transit gateways.
    /// </summary>
    public partial class DirectConnectGateway
    {
        /// <summary>
        /// Gets and sets the property AmazonSideAsn. 
        /// <para>
        /// The autonomous system number (AS) for the Amazon side of the connection.
        /// </para>
        /// </summary>
        public long? AmazonSideAsn { get; set; }

        /// <summary>
        /// Checks to see if the AmazonSideAsn property is set.
        /// </summary>
        internal bool IsSetAmazonSideAsn() => this.AmazonSideAsn.HasValue;

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
        /// Gets and sets the property DirectConnectGatewayName. 
        /// <para>
        /// The name of the Direct Connect gateway.
        /// </para>
        /// </summary>
        public string DirectConnectGatewayName { get; set; }

        /// <summary>
        /// Checks to see if the DirectConnectGatewayName property is set.
        /// </summary>
        internal bool IsSetDirectConnectGatewayName() => this.DirectConnectGatewayName != null;

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayState. 
        /// <para>
        /// The state of the Direct Connect gateway. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>pending</c>: The initial state after calling <a>CreateDirectConnectGateway</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available</c>: The Direct Connect gateway is ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c>: The initial state after calling <a>DeleteDirectConnectGateway</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c>: The Direct Connect gateway is deleted and cannot pass traffic.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DirectConnectGatewayState DirectConnectGatewayState { get; set; }

        /// <summary>
        /// Checks to see if the DirectConnectGatewayState property is set.
        /// </summary>
        internal bool IsSetDirectConnectGatewayState() => this.DirectConnectGatewayState != null;

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the Direct Connect gateway.
        /// </para>
        /// </summary>
        public string OwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccount property is set.
        /// </summary>
        internal bool IsSetOwnerAccount() => this.OwnerAccount != null;

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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Information about a tag.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalPrefixPoolAllocations. 
        /// <para>
        /// The total number of inbound route prefixes allocated to the attachments on the Direct
        /// Connect gateway. The count combines the IPv4 and IPv6 address families.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TotalPrefixPoolAllocations { get; set; }

        /// <summary>
        /// Checks to see if the TotalPrefixPoolAllocations property is set.
        /// </summary>
        internal bool IsSetTotalPrefixPoolAllocations() => this.TotalPrefixPoolAllocations.HasValue;
    }
}
