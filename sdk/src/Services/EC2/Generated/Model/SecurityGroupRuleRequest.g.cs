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
        /// <summary>
        /// Gets and sets the property CidrIpv4. 
        /// <para>
        /// The IPv4 CIDR range. To specify a single IPv4 address, use the /32 prefix length.
        /// 
        /// </para>
        /// </summary>
        public string CidrIpv4 { get; set; }

        /// <summary>
        /// Checks to see if the CidrIpv4 property is set.
        /// </summary>
        internal bool IsSetCidrIpv4() => this.CidrIpv4 != null;

        /// <summary>
        /// Gets and sets the property CidrIpv6. 
        /// <para>
        /// The IPv6 CIDR range. To specify a single IPv6 address, use the /128 prefix length.
        /// </para>
        /// </summary>
        public string CidrIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the CidrIpv6 property is set.
        /// </summary>
        internal bool IsSetCidrIpv6() => this.CidrIpv6 != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the security group rule.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// If the protocol is TCP or UDP, this is the start of the port range. If the protocol
        /// is ICMP or ICMPv6, this is the ICMP type or -1 (all ICMP types).
        /// </para>
        /// </summary>
        public int? FromPort { get; set; }

        /// <summary>
        /// Checks to see if the FromPort property is set.
        /// </summary>
        internal bool IsSetFromPort() => this.FromPort.HasValue;

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
        public string IpProtocol { get; set; }

        /// <summary>
        /// Checks to see if the IpProtocol property is set.
        /// </summary>
        internal bool IsSetIpProtocol() => this.IpProtocol != null;

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list.
        /// </para>
        /// </summary>
        public string PrefixListId { get; set; }

        /// <summary>
        /// Checks to see if the PrefixListId property is set.
        /// </summary>
        internal bool IsSetPrefixListId() => this.PrefixListId != null;

        /// <summary>
        /// Gets and sets the property ReferencedGroupId. 
        /// <para>
        /// The ID of the security group that is referenced in the security group rule.
        /// </para>
        /// </summary>
        public string ReferencedGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ReferencedGroupId property is set.
        /// </summary>
        internal bool IsSetReferencedGroupId() => this.ReferencedGroupId != null;

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// If the protocol is TCP or UDP, this is the end of the port range. If the protocol
        /// is ICMP or ICMPv6, this is the ICMP code or -1 (all ICMP codes). If the start port
        /// is -1 (all ICMP types), then the end port must be -1 (all ICMP codes).
        /// </para>
        /// </summary>
        public int? ToPort { get; set; }

        /// <summary>
        /// Checks to see if the ToPort property is set.
        /// </summary>
        internal bool IsSetToPort() => this.ToPort.HasValue;
    }
}
