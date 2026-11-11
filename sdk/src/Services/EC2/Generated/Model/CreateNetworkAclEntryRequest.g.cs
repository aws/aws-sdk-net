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
    /// Container for the parameters to the CreateNetworkAclEntry operation. Creates an entry
    /// (a rule) in a network ACL with the specified rule number. Each network ACL has a set
    /// of numbered ingress rules and a separate set of numbered egress rules. When determining
    /// whether a packet should be allowed in or out of a subnet associated with the ACL,
    /// we process the entries in the ACL according to the rule numbers, in ascending order.
    /// Each network ACL has a set of ingress rules and a separate set of egress rules. <para>
    /// We recommend that you leave room between the rule numbers (for example, 100, 110,
    /// 120, ...), and not number them one right after the other (for example, 101, 102, 103,
    /// ...). This makes it easier to add a rule between existing ones without having to renumber
    /// the rules. </para> <para> After you add an entry, you can't modify it; you must either
    /// replace it, or create an entry and delete the old one. </para> <para> For more information
    /// about network ACLs, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-network-acls.html">Network
    /// ACLs</a> in the <i>Amazon VPC User Guide</i>. </para>
    /// </summary>
    public partial class CreateNetworkAclEntryRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The IPv4 network range to allow or deny, in CIDR notation (for example <c>172.16.0.0/24</c>).
        /// We modify the specified CIDR block to its canonical form; for example, if you specify
        /// <c>100.68.0.18/18</c>, we modify it to <c>100.68.0.0/18</c>.
        /// </para>
        /// </summary>
        public string CidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the CidrBlock property is set.
        /// </summary>
        internal bool IsSetCidrBlock() => this.CidrBlock != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Egress. 
        /// <para>
        /// Indicates whether this is an egress rule (rule is applied to traffic leaving the subnet).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Egress { get; set; }

        /// <summary>
        /// Checks to see if the Egress property is set.
        /// </summary>
        internal bool IsSetEgress() => this.Egress.HasValue;

        /// <summary>
        /// Gets and sets the property IcmpTypeCode. 
        /// <para>
        /// ICMP protocol: The ICMP or ICMPv6 type and code. Required if specifying protocol 1
        /// (ICMP) or protocol 58 (ICMPv6) with an IPv6 CIDR block.
        /// </para>
        /// </summary>
        public IcmpTypeCode IcmpTypeCode { get; set; }

        /// <summary>
        /// Checks to see if the IcmpTypeCode property is set.
        /// </summary>
        internal bool IsSetIcmpTypeCode() => this.IcmpTypeCode != null;

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlock. 
        /// <para>
        /// The IPv6 network range to allow or deny, in CIDR notation (for example <c>2001:db8:1234:1a00::/64</c>).
        /// </para>
        /// </summary>
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6CidrBlock property is set.
        /// </summary>
        internal bool IsSetIpv6CidrBlock() => this.Ipv6CidrBlock != null;

        /// <summary>
        /// Gets and sets the property NetworkAclId. 
        /// <para>
        /// The ID of the network ACL.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkAclId property is set.
        /// </summary>
        internal bool IsSetNetworkAclId() => this.NetworkAclId != null;

        /// <summary>
        /// Gets and sets the property PortRange. 
        /// <para>
        /// TCP or UDP protocols: The range of ports the rule applies to. Required if specifying
        /// protocol 6 (TCP) or 17 (UDP).
        /// </para>
        /// </summary>
        public PortRange PortRange { get; set; }

        /// <summary>
        /// Checks to see if the PortRange property is set.
        /// </summary>
        internal bool IsSetPortRange() => this.PortRange != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol number. A value of "-1" means all protocols. If you specify "-1" or a
        /// protocol number other than "6" (TCP), "17" (UDP), or "1" (ICMP), traffic on all ports
        /// is allowed, regardless of any ports or ICMP types or codes that you specify. If you
        /// specify protocol "58" (ICMPv6) and specify an IPv4 CIDR block, traffic for all ICMP
        /// types and codes allowed, regardless of any that you specify. If you specify protocol
        /// "58" (ICMPv6) and specify an IPv6 CIDR block, you must specify an ICMP type and code.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property RuleAction. 
        /// <para>
        /// Indicates whether to allow or deny the traffic that matches the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuleAction RuleAction { get; set; }

        /// <summary>
        /// Checks to see if the RuleAction property is set.
        /// </summary>
        internal bool IsSetRuleAction() => this.RuleAction != null;

        /// <summary>
        /// Gets and sets the property RuleNumber. 
        /// <para>
        /// The rule number for the entry (for example, 100). ACL entries are processed in ascending
        /// order by rule number.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Positive integer from 1 to 32766. The range 32767 to 65535 is reserved
        /// for internal use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? RuleNumber { get; set; }

        /// <summary>
        /// Checks to see if the RuleNumber property is set.
        /// </summary>
        internal bool IsSetRuleNumber() => this.RuleNumber.HasValue;
    }
}
