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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBGPPeer operation.
    /// Creates a BGP peer on the specified virtual interface.
    /// 
    ///  
    /// <para>
    /// You must create a BGP peer for the corresponding address family (IPv4/IPv6) in order
    /// to access Amazon Web Services resources that also use that address family.
    /// </para>
    ///  
    /// <para>
    /// If logical redundancy is not supported by the connection, interconnect, or LAG, the
    /// BGP peer cannot be in the same address family as an existing BGP peer on the virtual
    /// interface.
    /// </para>
    ///  
    /// <para>
    /// When creating a IPv6 BGP peer, omit the Amazon address and customer address. IPv6
    /// addresses are automatically assigned from the Amazon pool of IPv6 addresses; you cannot
    /// specify custom IPv6 addresses.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you let Amazon Web Services auto-assign IPv4 addresses, a /30 CIDR will be allocated
    /// from 169.254.0.0/16. Amazon Web Services does not recommend this option if you intend
    /// to use the customer router peer IP address as the source and destination for traffic.
    /// Instead you should use RFC 1918 or other addressing, and specify the address yourself.
    /// For more information about RFC 1918 see <a href="https://datatracker.ietf.org/doc/html/rfc1918">
    /// Address Allocation for Private Internets</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// For a public virtual interface, the Autonomous System Number (ASN) must be private
    /// or already on the allow list for the virtual interface.
    /// </para>
    /// </summary>
    public partial class CreateBGPPeerRequest : AmazonDirectConnectRequest
    {
        private NewBGPPeer _newbgpPeer;
        private string _virtualInterfaceId;

        /// <summary>
        /// Gets and sets the property NewBGPPeer. 
        /// <para>
        /// Information about the BGP peer.
        /// </para>
        /// </summary>
        public NewBGPPeer NewBGPPeer
        {
            get { return this._newbgpPeer; }
            set { this._newbgpPeer = value; }
        }

        // Check to see if NewBGPPeer property is set
        internal bool IsSetNewBGPPeer()
        {
            return this._newbgpPeer != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualInterfaceId. 
        /// <para>
        /// The ID of the virtual interface.
        /// </para>
        /// </summary>
        public string VirtualInterfaceId
        {
            get { return this._virtualInterfaceId; }
            set { this._virtualInterfaceId = value; }
        }

        // Check to see if VirtualInterfaceId property is set
        internal bool IsSetVirtualInterfaceId()
        {
            return this._virtualInterfaceId != null;
        }

    }
}