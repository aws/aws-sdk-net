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
    /// Describes the permissions for a security group rule.
    /// </summary>
    public partial class IpPermission
    {
        private int? _fromPort;
        private string _ipProtocol;
        private List<IpRange> _ipv4Ranges = AWSConfigs.InitializeCollections ? new List<IpRange>() : null;
        private List<Ipv6Range> _ipv6Ranges = AWSConfigs.InitializeCollections ? new List<Ipv6Range>() : null;
        private List<PrefixListId> _prefixListIds = AWSConfigs.InitializeCollections ? new List<PrefixListId>() : null;
        private int? _toPort;
        private List<UserIdGroupPair> _userIdGroupPairs = AWSConfigs.InitializeCollections ? new List<UserIdGroupPair>() : null;

        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// If the protocol is TCP or UDP, this is the start of the port range. If the protocol
        /// is ICMP or ICMPv6, this is the ICMP type or -1 (all ICMP types).
        /// </para>
        /// </summary>
        public int? FromPort
        {
            get { return this._fromPort; }
            set { this._fromPort = value; }
        }

        // Check to see if FromPort property is set
        internal bool IsSetFromPort()
        {
            return this._fromPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpProtocol. 
        /// <para>
        /// The IP protocol name (<c>tcp</c>, <c>udp</c>, <c>icmp</c>, <c>icmpv6</c>) or number
        /// (see <a href="http://www.iana.org/assignments/protocol-numbers/protocol-numbers.xhtml">Protocol
        /// Numbers</a>).
        /// </para>
        ///  
        /// <para>
        /// Use <c>-1</c> to specify all protocols. When authorizing security group rules, specifying
        /// <c>-1</c> or a protocol number other than <c>tcp</c>, <c>udp</c>, <c>icmp</c>, or
        /// <c>icmpv6</c> allows traffic on all ports, regardless of any port range you specify.
        /// For <c>tcp</c>, <c>udp</c>, and <c>icmp</c>, you must specify a port range. For <c>icmpv6</c>,
        /// the port range is optional; if you omit the port range, traffic for all types and
        /// codes is allowed.
        /// </para>
        /// </summary>
        public string IpProtocol
        {
            get { return this._ipProtocol; }
            set { this._ipProtocol = value; }
        }

        // Check to see if IpProtocol property is set
        internal bool IsSetIpProtocol()
        {
            return this._ipProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv4Ranges. 
        /// <para>
        /// The IPv4 address ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpRange> Ipv4Ranges
        {
            get { return this._ipv4Ranges; }
            set { this._ipv4Ranges = value; }
        }

        // Check to see if Ipv4Ranges property is set
        internal bool IsSetIpv4Ranges()
        {
            return this._ipv4Ranges != null && (this._ipv4Ranges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Ipv6Ranges. 
        /// <para>
        /// The IPv6 address ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ipv6Range> Ipv6Ranges
        {
            get { return this._ipv6Ranges; }
            set { this._ipv6Ranges = value; }
        }

        // Check to see if Ipv6Ranges property is set
        internal bool IsSetIpv6Ranges()
        {
            return this._ipv6Ranges != null && (this._ipv6Ranges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrefixListIds. 
        /// <para>
        /// The prefix list IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PrefixListId> PrefixListIds
        {
            get { return this._prefixListIds; }
            set { this._prefixListIds = value; }
        }

        // Check to see if PrefixListIds property is set
        internal bool IsSetPrefixListIds()
        {
            return this._prefixListIds != null && (this._prefixListIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// If the protocol is TCP or UDP, this is the end of the port range. If the protocol
        /// is ICMP or ICMPv6, this is the ICMP code or -1 (all ICMP codes). If the start port
        /// is -1 (all ICMP types), then the end port must be -1 (all ICMP codes).
        /// </para>
        /// </summary>
        public int? ToPort
        {
            get { return this._toPort; }
            set { this._toPort = value; }
        }

        // Check to see if ToPort property is set
        internal bool IsSetToPort()
        {
            return this._toPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserIdGroupPairs. 
        /// <para>
        /// The security group and Amazon Web Services account ID pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserIdGroupPair> UserIdGroupPairs
        {
            get { return this._userIdGroupPairs; }
            set { this._userIdGroupPairs = value; }
        }

        // Check to see if UserIdGroupPairs property is set
        internal bool IsSetUserIdGroupPairs()
        {
            return this._userIdGroupPairs != null && (this._userIdGroupPairs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}