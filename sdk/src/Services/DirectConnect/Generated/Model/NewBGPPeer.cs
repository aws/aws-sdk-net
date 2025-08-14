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
    /// Information about a new BGP peer.
    /// </summary>
    public partial class NewBGPPeer
    {
        private AddressFamily _addressFamily;
        private string _amazonAddress;
        private int? _asn;
        private long? _asnLong;
        private string _authKey;
        private string _customerAddress;

        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The address family for the BGP peer.
        /// </para>
        /// </summary>
        public AddressFamily AddressFamily
        {
            get { return this._addressFamily; }
            set { this._addressFamily = value; }
        }

        // Check to see if AddressFamily property is set
        internal bool IsSetAddressFamily()
        {
            return this._addressFamily != null;
        }

        /// <summary>
        /// Gets and sets the property AmazonAddress. 
        /// <para>
        /// The IP address assigned to the Amazon interface.
        /// </para>
        /// </summary>
        public string AmazonAddress
        {
            get { return this._amazonAddress; }
            set { this._amazonAddress = value; }
        }

        // Check to see if AmazonAddress property is set
        internal bool IsSetAmazonAddress()
        {
            return this._amazonAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The autonomous system number (ASN). The valid range is from 1 to 2147483646 for Border
        /// Gateway Protocol (BGP) configuration. If you provide a number greater than the maximum,
        /// an error is returned. Use <c>asnLong</c> instead.
        /// </para>
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
        /// The long ASN for a new BGP peer. The valid range is from 1 to 4294967294.
        /// </para>
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
        /// Gets and sets the property AuthKey. 
        /// <para>
        /// The authentication key for BGP configuration. This string has a minimum length of
        /// 6 characters and and a maximun lenth of 80 characters.
        /// </para>
        /// </summary>
        public string AuthKey
        {
            get { return this._authKey; }
            set { this._authKey = value; }
        }

        // Check to see if AuthKey property is set
        internal bool IsSetAuthKey()
        {
            return this._authKey != null;
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

    }
}