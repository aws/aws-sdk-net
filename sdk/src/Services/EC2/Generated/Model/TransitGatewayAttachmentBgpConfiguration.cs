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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private BgpStatus _bgpStatus;
        private string _peerAddress;
        private long? _peerAsn;
        private string _transitGatewayAddress;
        private long? _transitGatewayAsn;

        /// <summary>
        /// Gets and sets the property BgpStatus. 
        /// <para>
        /// The BGP status.
        /// </para>
        /// </summary>
        public BgpStatus BgpStatus
        {
            get { return this._bgpStatus; }
            set { this._bgpStatus = value; }
        }

        // Check to see if BgpStatus property is set
        internal bool IsSetBgpStatus()
        {
            return this._bgpStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PeerAddress. 
        /// <para>
        /// The interior BGP peer IP address for the appliance.
        /// </para>
        /// </summary>
        public string PeerAddress
        {
            get { return this._peerAddress; }
            set { this._peerAddress = value; }
        }

        // Check to see if PeerAddress property is set
        internal bool IsSetPeerAddress()
        {
            return this._peerAddress != null;
        }

        /// <summary>
        /// Gets and sets the property PeerAsn. 
        /// <para>
        /// The peer Autonomous System Number (ASN).
        /// </para>
        /// </summary>
        public long? PeerAsn
        {
            get { return this._peerAsn; }
            set { this._peerAsn = value; }
        }

        // Check to see if PeerAsn property is set
        internal bool IsSetPeerAsn()
        {
            return this._peerAsn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayAddress. 
        /// <para>
        /// The interior BGP peer IP address for the transit gateway.
        /// </para>
        /// </summary>
        public string TransitGatewayAddress
        {
            get { return this._transitGatewayAddress; }
            set { this._transitGatewayAddress = value; }
        }

        // Check to see if TransitGatewayAddress property is set
        internal bool IsSetTransitGatewayAddress()
        {
            return this._transitGatewayAddress != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayAsn. 
        /// <para>
        /// The transit gateway Autonomous System Number (ASN).
        /// </para>
        /// </summary>
        public long? TransitGatewayAsn
        {
            get { return this._transitGatewayAsn; }
            set { this._transitGatewayAsn = value; }
        }

        // Check to see if TransitGatewayAsn property is set
        internal bool IsSetTransitGatewayAsn()
        {
            return this._transitGatewayAsn.HasValue; 
        }

    }
}