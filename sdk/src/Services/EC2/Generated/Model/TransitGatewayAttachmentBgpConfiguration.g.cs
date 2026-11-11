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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The BGP configuration information.
    /// </summary>
    public partial class TransitGatewayAttachmentBgpConfiguration
    {
        /// <summary>
        /// Gets and sets the property BgpStatus. 
        /// <para>
        /// The BGP status.
        /// </para>
        /// </summary>
        public BgpStatus BgpStatus { get; set; }

        /// <summary>
        /// Checks to see if the BgpStatus property is set.
        /// </summary>
        internal bool IsSetBgpStatus() => this.BgpStatus != null;

        /// <summary>
        /// Gets and sets the property PeerAddress. 
        /// <para>
        /// The interior BGP peer IP address for the appliance.
        /// </para>
        /// </summary>
        public string PeerAddress { get; set; }

        /// <summary>
        /// Checks to see if the PeerAddress property is set.
        /// </summary>
        internal bool IsSetPeerAddress() => this.PeerAddress != null;

        /// <summary>
        /// Gets and sets the property PeerAsn. 
        /// <para>
        /// The peer Autonomous System Number (ASN).
        /// </para>
        /// </summary>
        public long? PeerAsn { get; set; }

        /// <summary>
        /// Checks to see if the PeerAsn property is set.
        /// </summary>
        internal bool IsSetPeerAsn() => this.PeerAsn.HasValue;

        /// <summary>
        /// Gets and sets the property TransitGatewayAddress. 
        /// <para>
        /// The interior BGP peer IP address for the transit gateway.
        /// </para>
        /// </summary>
        public string TransitGatewayAddress { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayAddress property is set.
        /// </summary>
        internal bool IsSetTransitGatewayAddress() => this.TransitGatewayAddress != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayAsn. 
        /// <para>
        /// The transit gateway Autonomous System Number (ASN).
        /// </para>
        /// </summary>
        public long? TransitGatewayAsn { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayAsn property is set.
        /// </summary>
        internal bool IsSetTransitGatewayAsn() => this.TransitGatewayAsn.HasValue;
    }
}
