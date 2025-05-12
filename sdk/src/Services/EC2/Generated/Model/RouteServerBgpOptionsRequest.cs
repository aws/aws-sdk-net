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
    /// The BGP configuration options requested for a route server peer.
    /// </summary>
    public partial class RouteServerBgpOptionsRequest
    {
        private long? _peerAsn;
        private RouteServerPeerLivenessMode _peerLivenessDetection;

        /// <summary>
        /// Gets and sets the property PeerAsn. 
        /// <para>
        /// The Border Gateway Protocol (BGP) Autonomous System Number (ASN) for the appliance.
        /// Valid values are from 1 to 4294967295. We recommend using a private ASN in the 64512–65534
        /// (16-bit ASN) or 4200000000–4294967294 (32-bit ASN) range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PeerLivenessDetection. 
        /// <para>
        /// The requested liveness detection protocol for the BGP peer.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>bgp-keepalive</c>: The standard BGP keep alive mechanism (<a href="https://www.rfc-editor.org/rfc/rfc4271#page-21">RFC4271</a>)
        /// that is stable but may take longer to fail-over in cases of network impact or router
        /// failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>bfd</c>: An additional Bidirectional Forwarding Detection (BFD) protocol (<a href="https://www.rfc-editor.org/rfc/rfc5880">RFC5880</a>)
        /// that enables fast failover by using more sensitive liveness detection.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Defaults to <c>bgp-keepalive</c>.
        /// </para>
        /// </summary>
        public RouteServerPeerLivenessMode PeerLivenessDetection
        {
            get { return this._peerLivenessDetection; }
            set { this._peerLivenessDetection = value; }
        }

        // Check to see if PeerLivenessDetection property is set
        internal bool IsSetPeerLivenessDetection()
        {
            return this._peerLivenessDetection != null;
        }

    }
}