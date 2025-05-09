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
    /// Describes a security group rule.
    /// 
    ///  
    /// <para>
    /// You must specify exactly one of the following parameters, based on the rule type:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CidrIpv4
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CidrIpv6
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// PrefixListId
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ReferencedGroupId
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    ///  Amazon Web Services <a href="https://en.wikipedia.org/wiki/Canonicalization">canonicalizes</a>
    /// IPv4 and IPv6 CIDRs. For example, if you specify 100.68.0.18/18 for the CIDR block,
    /// Amazon Web Services canonicalizes the CIDR block to 100.68.0.0/18. Any subsequent
    /// DescribeSecurityGroups and DescribeSecurityGroupRules calls will return the canonicalized
    /// form of the CIDR block. Additionally, if you attempt to add another rule with the
    /// non-canonical form of the CIDR (such as 100.68.0.18/18) and there is already a rule
    /// for the canonicalized form of the CIDR block (such as 100.68.0.0/18), the API throws
    /// an duplicate rule error.
    /// </para>
    ///  </note> 
    /// <para>
    /// When you modify a rule, you cannot change the rule type. For example, if the rule
    /// uses an IPv4 address range, you must use <c>CidrIpv4</c> to specify a new IPv4 address
    /// range.
    /// </para>
    /// </summary>
    public partial class SecurityGroupRuleRequest
    {
        private string _cidrIpv4;
        private string _cidrIpv6;
        private string _description;
        private int? _fromPort;
        private string _ipProtocol;
        private string _prefixListId;
        private string _referencedGroupId;
        private int? _toPort;

        /// <summary>
        /// Gets and sets the property CidrIpv4. 
        /// <para>
        /// The IPv4 CIDR range. To specify a single IPv4 address, use the /32 prefix length.
        /// 
        /// </para>
        /// </summary>
        public string CidrIpv4
        {
            get { return this._cidrIpv4; }
            set { this._cidrIpv4 = value; }
        }

        // Check to see if CidrIpv4 property is set
        internal bool IsSetCidrIpv4()
        {
            return this._cidrIpv4 != null;
        }

        /// <summary>
        /// Gets and sets the property CidrIpv6. 
        /// <para>
        /// The IPv6 CIDR range. To specify a single IPv6 address, use the /128 prefix length.
        /// </para>
        /// </summary>
        public string CidrIpv6
        {
            get { return this._cidrIpv6; }
            set { this._cidrIpv6 = value; }
        }

        // Check to see if CidrIpv6 property is set
        internal bool IsSetCidrIpv6()
        {
            return this._cidrIpv6 != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the security group rule.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

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
        /// Use <c>-1</c> to specify all protocols.
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
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list.
        /// </para>
        /// </summary>
        public string PrefixListId
        {
            get { return this._prefixListId; }
            set { this._prefixListId = value; }
        }

        // Check to see if PrefixListId property is set
        internal bool IsSetPrefixListId()
        {
            return this._prefixListId != null;
        }

        /// <summary>
        /// Gets and sets the property ReferencedGroupId. 
        /// <para>
        /// The ID of the security group that is referenced in the security group rule.
        /// </para>
        /// </summary>
        public string ReferencedGroupId
        {
            get { return this._referencedGroupId; }
            set { this._referencedGroupId = value; }
        }

        // Check to see if ReferencedGroupId property is set
        internal bool IsSetReferencedGroupId()
        {
            return this._referencedGroupId != null;
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

    }
}