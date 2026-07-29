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
        private long? _asnLong;
        private string _bgpPeerId;
        private string _customerAddress;
        private string _virtualInterfaceId;

        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The autonomous system number (ASN). The valid range is from 1 to 2147483646 for Border
        /// Gateway Protocol (BGP) configuration. If you provide a number greater than the maximum,
        /// an error is returned. Use <c>asnLong</c> instead.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can use <c>asnLong</c> or <c>asn</c>, but not both. We recommend using <c>asnLong</c>
        /// as it supports a greater pool of numbers. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you provide a value in the same API call for both <c>asn</c> and <c>asnLong</c>,
        /// the API will only accept the value for <c>asnLong</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you enter a 4-byte ASN for the <c>asn</c> parameter, the API returns an error.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are using a 2-byte ASN, the API response will include the 2-byte value for
        /// both the <c>asn</c> and <c>asnLong</c> fields.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? Asn
        {
            get { return this._asn; }
            set { this._asn = value; }
        }

        // Check to see if Asn property is set
        internal bool IsSetAsn()
        {
            return this._asn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AsnLong. 
        /// <para>
        /// The long ASN for the BGP peer to be deleted from a Direct Connect virtual interface.
        /// The valid range is from 1 to 4294967294 for BGP configuration. 
        /// </para>
        ///  
        /// <para>
        /// Note the following limitations when using <c>asnLong</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can use <c>asnLong</c> or <c>asn</c>, but not both. We recommend using <c>asnLong</c>
        /// as it supports a greater pool of numbers. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>asnLong</c> accepts any valid ASN value, regardless if it's 2-byte or 4-byte.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When using a 4-byte <c>asnLong</c>, the API response returns <c>0</c> for the legacy
        /// <c>asn</c> attribute since 4-byte ASN values exceed the maximum supported value of
        /// 2,147,483,647.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are using a 2-byte ASN, the API response will include the 2-byte value for
        /// both the <c>asn</c> and <c>asnLong</c> fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you provide a value in the same API call for both <c>asn</c> and <c>asnLong</c>,
        /// the API will only accept the value for <c>asnLong</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public long? AsnLong
        {
            get { return this._asnLong; }
            set { this._asnLong = value; }
        }

        // Check to see if AsnLong property is set
        internal bool IsSetAsnLong()
        {
            return this._asnLong.HasValue; 
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