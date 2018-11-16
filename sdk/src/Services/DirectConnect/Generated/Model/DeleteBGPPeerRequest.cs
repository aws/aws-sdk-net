/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBGPPeer operation.
    /// Deletes the specified BGP peer on the specified virtual interface with the specified
    /// customer address and ASN.
    /// 
    ///  
    /// <para>
    /// You cannot delete the last BGP peer from a virtual interface.
    /// </para>
    /// </summary>
    public partial class DeleteBGPPeerRequest : AmazonDirectConnectRequest
    {
        private int? _asn;
        private string _bgpPeerId;
        private string _customerAddress;
        private string _virtualInterfaceId;

        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The autonomous system (AS) number for Border Gateway Protocol (BGP) configuration.
        /// </para>
        /// </summary>
        public int Asn
        {
            get { return this._asn.GetValueOrDefault(); }
            set { this._asn = value; }
        }

        // Check to see if Asn property is set
        internal bool IsSetAsn()
        {
            return this._asn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BgpPeerId. 
        /// <para>
        /// The ID of the BGP peer.
        /// </para>
        /// </summary>
        public string BgpPeerId
        {
            get { return this._bgpPeerId; }
            set { this._bgpPeerId = value; }
        }

        // Check to see if BgpPeerId property is set
        internal bool IsSetBgpPeerId()
        {
            return this._bgpPeerId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerAddress. 
        /// <para>
        /// The IP address assigned to the customer interface.
        /// </para>
        /// </summary>
        public string CustomerAddress
        {
            get { return this._customerAddress; }
            set { this._customerAddress = value; }
        }

        // Check to see if CustomerAddress property is set
        internal bool IsSetCustomerAddress()
        {
            return this._customerAddress != null;
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