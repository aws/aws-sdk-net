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
    /// Information about a BGP peer.
    /// </summary>
    public partial class BGPPeer
    {
        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The address family for the BGP peer.
        /// </para>
        /// </summary>
        public AddressFamily AddressFamily { get; set; }

        /// <summary>
        /// Checks to see if the AddressFamily property is set.
        /// </summary>
        internal bool IsSetAddressFamily() => this.AddressFamily != null;

        /// <summary>
        /// Gets and sets the property AmazonAddress. 
        /// <para>
        /// The IP address assigned to the Amazon interface.
        /// </para>
        /// </summary>
        public string AmazonAddress { get; set; }

        /// <summary>
        /// Checks to see if the AmazonAddress property is set.
        /// </summary>
        internal bool IsSetAmazonAddress() => this.AmazonAddress != null;

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
        public int? Asn { get; set; }

        /// <summary>
        /// Checks to see if the Asn property is set.
        /// </summary>
        internal bool IsSetAsn() => this.Asn.HasValue;

        /// <summary>
        /// Gets and sets the property AsnLong. 
        /// <para>
        /// The long ASN for the BGP peer. The valid range is from 1 to 4294967294 for BGP configuration.
        /// 
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
        public long? AsnLong { get; set; }

        /// <summary>
        /// Checks to see if the AsnLong property is set.
        /// </summary>
        internal bool IsSetAsnLong() => this.AsnLong.HasValue;

        /// <summary>
        /// Gets and sets the property AuthKey. 
        /// <para>
        /// The authentication key for BGP configuration. This string has a minimum length of
        /// 6 characters and and a maximun lenth of 80 characters.
        /// </para>
        /// </summary>
        public string AuthKey { get; set; }

        /// <summary>
        /// Checks to see if the AuthKey property is set.
        /// </summary>
        internal bool IsSetAuthKey() => this.AuthKey != null;

        /// <summary>
        /// Gets and sets the property AwsDeviceV2. 
        /// <para>
        /// The Direct Connect endpoint that terminates the BGP peer.
        /// </para>
        /// </summary>
        public string AwsDeviceV2 { get; set; }

        /// <summary>
        /// Checks to see if the AwsDeviceV2 property is set.
        /// </summary>
        internal bool IsSetAwsDeviceV2() => this.AwsDeviceV2 != null;

        /// <summary>
        /// Gets and sets the property AwsLogicalDeviceId. 
        /// <para>
        /// The Direct Connect endpoint that terminates the logical connection. This device might
        /// be different than the device that terminates the physical connection.
        /// </para>
        /// </summary>
        public string AwsLogicalDeviceId { get; set; }

        /// <summary>
        /// Checks to see if the AwsLogicalDeviceId property is set.
        /// </summary>
        internal bool IsSetAwsLogicalDeviceId() => this.AwsLogicalDeviceId != null;

        /// <summary>
        /// Gets and sets the property BgpPeerId. 
        /// <para>
        /// The ID of the BGP peer.
        /// </para>
        /// </summary>
        public string BgpPeerId { get; set; }

        /// <summary>
        /// Checks to see if the BgpPeerId property is set.
        /// </summary>
        internal bool IsSetBgpPeerId() => this.BgpPeerId != null;

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
        public BGPPeerState BgpPeerState { get; set; }

        /// <summary>
        /// Checks to see if the BgpPeerState property is set.
        /// </summary>
        internal bool IsSetBgpPeerState() => this.BgpPeerState != null;

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
        public BGPStatus BgpStatus { get; set; }

        /// <summary>
        /// Checks to see if the BgpStatus property is set.
        /// </summary>
        internal bool IsSetBgpStatus() => this.BgpStatus != null;

        /// <summary>
        /// Gets and sets the property CustomerAddress. 
        /// <para>
        /// The IP address assigned to the customer interface.
        /// </para>
        /// </summary>
        public string CustomerAddress { get; set; }

        /// <summary>
        /// Checks to see if the CustomerAddress property is set.
        /// </summary>
        internal bool IsSetCustomerAddress() => this.CustomerAddress != null;
    }
}
