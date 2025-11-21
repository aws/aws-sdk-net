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
    /// Information about a BGP peer.
    /// </summary>
    public partial class BGPPeer
    {
        private AddressFamily _addressFamily;
        private string _amazonAddress;
        private int? _asn;
        private long? _asnLong;
        private string _authKey;
        private string _awsDeviceV2;
        private string _awsLogicalDeviceId;
        private string _bgpPeerId;
        private BGPPeerState _bgpPeerState;
        private BGPStatus _bgpStatus;
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
        ///  <note> 
        /// <para>
        /// You can use <c>asnLong</c> or <c>asn</c>, but not both. We recommend using <c>asnLong</c>
        /// as it supports a greater pool of numbers. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>asnLong</c> attribute accepts both ASN and long ASN ranges.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you provide a value in the same API call for both <c>asn</c> and <c>asnLong</c>,
        /// the API will only accept the value for <c>asnLong</c>.
        /// </para>
        ///  </li> </ul> </note>
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
        /// The long ASN for the BGP peer. The valid range is from 1 to 4294967294 for BGP configuration.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use <c>asnLong</c> or <c>asn</c>, but not both. We recommend using <c>asnLong</c>
        /// as it supports a greater pool of numbers. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>asnLong</c> attribute accepts both ASN and long ASN ranges.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you provide a value in the same API call for both <c>asn</c> and <c>asnLong</c>,
        /// the API will only accept the value for <c>asnLong</c>.
        /// </para>
        ///  </li> </ul> </note>
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
        /// Gets and sets the property AwsDeviceV2. 
        /// <para>
        /// The Direct Connect endpoint that terminates the BGP peer.
        /// </para>
        /// </summary>
        public string AwsDeviceV2
        {
            get { return this._awsDeviceV2; }
            set { this._awsDeviceV2 = value; }
        }

        // Check to see if AwsDeviceV2 property is set
        internal bool IsSetAwsDeviceV2()
        {
            return this._awsDeviceV2 != null;
        }

        /// <summary>
        /// Gets and sets the property AwsLogicalDeviceId. 
        /// <para>
        /// The Direct Connect endpoint that terminates the logical connection. This device might
        /// be different than the device that terminates the physical connection.
        /// </para>
        /// </summary>
        public string AwsLogicalDeviceId
        {
            get { return this._awsLogicalDeviceId; }
            set { this._awsLogicalDeviceId = value; }
        }

        // Check to see if AwsLogicalDeviceId property is set
        internal bool IsSetAwsLogicalDeviceId()
        {
            return this._awsLogicalDeviceId != null;
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
        /// Gets and sets the property BgpPeerState. 
        /// <para>
        /// The state of the BGP peer. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>verifying</c>: The BGP peering addresses or ASN require validation before the
        /// BGP peer can be created. This state applies only to public virtual interfaces.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c>: The BGP peer is created, and remains in this state until it is ready
        /// to be established.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available</c>: The BGP peer is ready to be established.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c>: The BGP peer is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c>: The BGP peer is deleted and cannot be established.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BGPPeerState BgpPeerState
        {
            get { return this._bgpPeerState; }
            set { this._bgpPeerState = value; }
        }

        // Check to see if BgpPeerState property is set
        internal bool IsSetBgpPeerState()
        {
            return this._bgpPeerState != null;
        }

        /// <summary>
        /// Gets and sets the property BgpStatus. 
        /// <para>
        /// The status of the BGP peer. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>up</c>: The BGP peer is established. This state does not indicate the state of
        /// the routing function. Ensure that you are receiving routes over the BGP session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>down</c>: The BGP peer is down.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unknown</c>: The BGP peer status is not available.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BGPStatus BgpStatus
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