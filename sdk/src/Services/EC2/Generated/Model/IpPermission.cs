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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a security group rule.
    /// </summary>
    public partial class IpPermission
    {
        private int? _fromPort;
        private string _ipProtocol;
        private List<string> _ipRanges = new List<string>();
        private List<Ipv6Range> _ipv6Ranges = new List<Ipv6Range>();
        private List<PrefixListId> _prefixListIds = new List<PrefixListId>();
        private int? _toPort;
        private List<UserIdGroupPair> _userIdGroupPairs = new List<UserIdGroupPair>();

        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// The start of port range for the TCP and UDP protocols, or an ICMP/ICMPv6 type number.
        /// A value of <code>-1</code> indicates all ICMP/ICMPv6 types.
        /// </para>
        /// </summary>
        public int FromPort
        {
            get { return this._fromPort.GetValueOrDefault(); }
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
        /// The IP protocol name (<code>tcp</code>, <code>udp</code>, <code>icmp</code>) or number
        /// (see <a href="http://www.iana.org/assignments/protocol-numbers/protocol-numbers.xhtml">Protocol
        /// Numbers</a>). 
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC only] Use <code>-1</code> to specify all protocols. When authorizing security
        /// group rules, specifying <code>-1</code> or a protocol number other than <code>tcp</code>,
        /// <code>udp</code>, <code>icmp</code>, or <code>58</code> (ICMPv6) allows traffic on
        /// all ports, regardless of any port range you specify. For <code>tcp</code>, <code>udp</code>,
        /// and <code>icmp</code>, you must specify a port range. For <code>58</code> (ICMPv6),
        /// you can optionally specify a port range; if you don't, traffic for all types and codes
        /// is allowed when authorizing rules. 
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
        /// Gets and sets the property IpRanges. 
        /// <para>
        /// One or more IPv4 ranges.
        /// </para>
        /// </summary>
        public List<string> IpRanges
        {
            get { return this._ipRanges; }
            set { this._ipRanges = value; }
        }

        // Check to see if IpRanges property is set
        internal bool IsSetIpRanges()
        {
            return this._ipRanges != null && this._ipRanges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6Ranges. 
        /// <para>
        /// [EC2-VPC only] One or more IPv6 ranges.
        /// </para>
        /// </summary>
        public List<Ipv6Range> Ipv6Ranges
        {
            get { return this._ipv6Ranges; }
            set { this._ipv6Ranges = value; }
        }

        // Check to see if Ipv6Ranges property is set
        internal bool IsSetIpv6Ranges()
        {
            return this._ipv6Ranges != null && this._ipv6Ranges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PrefixListIds. 
        /// <para>
        /// (Valid for <a>AuthorizeSecurityGroupEgress</a>, <a>RevokeSecurityGroupEgress</a> and
        /// <a>DescribeSecurityGroups</a> only) One or more prefix list IDs for an AWS service.
        /// In an <a>AuthorizeSecurityGroupEgress</a> request, this is the AWS service that you
        /// want to access through a VPC endpoint from instances associated with the security
        /// group.
        /// </para>
        /// </summary>
        public List<PrefixListId> PrefixListIds
        {
            get { return this._prefixListIds; }
            set { this._prefixListIds = value; }
        }

        // Check to see if PrefixListIds property is set
        internal bool IsSetPrefixListIds()
        {
            return this._prefixListIds != null && this._prefixListIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// The end of port range for the TCP and UDP protocols, or an ICMP/ICMPv6 code. A value
        /// of <code>-1</code> indicates all ICMP/ICMPv6 codes for the specified ICMP type.
        /// </para>
        /// </summary>
        public int ToPort
        {
            get { return this._toPort.GetValueOrDefault(); }
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
        /// One or more security group and AWS account ID pairs.
        /// </para>
        /// </summary>
        public List<UserIdGroupPair> UserIdGroupPairs
        {
            get { return this._userIdGroupPairs; }
            set { this._userIdGroupPairs = value; }
        }

        // Check to see if UserIdGroupPairs property is set
        internal bool IsSetUserIdGroupPairs()
        {
            return this._userIdGroupPairs != null && this._userIdGroupPairs.Count > 0; 
        }

    }
}