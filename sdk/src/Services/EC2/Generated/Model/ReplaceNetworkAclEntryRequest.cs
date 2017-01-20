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
    /// Container for the parameters to the ReplaceNetworkAclEntry operation.
    /// Replaces an entry (rule) in a network ACL. For more information about network ACLs,
    /// see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
    /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </summary>
    public partial class ReplaceNetworkAclEntryRequest : AmazonEC2Request
    {
        private string _cidrBlock;
        private bool? _egress;
        private IcmpTypeCode _icmpTypeCode;
        private string _ipv6CidrBlock;
        private string _networkAclId;
        private PortRange _portRange;
        private string _protocol;
        private RuleAction _ruleAction;
        private int? _ruleNumber;

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The IPv4 network range to allow or deny, in CIDR notation (for example <code>172.16.0.0/24</code>).
        /// </para>
        /// </summary>
        public string CidrBlock
        {
            get { return this._cidrBlock; }
            set { this._cidrBlock = value; }
        }

        // Check to see if CidrBlock property is set
        internal bool IsSetCidrBlock()
        {
            return this._cidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property Egress. 
        /// <para>
        /// Indicates whether to replace the egress rule.
        /// </para>
        ///  
        /// <para>
        /// Default: If no value is specified, we replace the ingress rule.
        /// </para>
        /// </summary>
        public bool Egress
        {
            get { return this._egress.GetValueOrDefault(); }
            set { this._egress = value; }
        }

        // Check to see if Egress property is set
        internal bool IsSetEgress()
        {
            return this._egress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IcmpTypeCode. 
        /// <para>
        /// ICMP protocol: The ICMP or ICMPv6 type and code. Required if specifying the ICMP (1)
        /// protocol, or protocol 58 (ICMPv6) with an IPv6 CIDR block.
        /// </para>
        /// </summary>
        public IcmpTypeCode IcmpTypeCode
        {
            get { return this._icmpTypeCode; }
            set { this._icmpTypeCode = value; }
        }

        // Check to see if IcmpTypeCode property is set
        internal bool IsSetIcmpTypeCode()
        {
            return this._icmpTypeCode != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlock. 
        /// <para>
        /// The IPv6 network range to allow or deny, in CIDR notation (for example <code>2001:bd8:1234:1a00::/64</code>).
        /// </para>
        /// </summary>
        public string Ipv6CidrBlock
        {
            get { return this._ipv6CidrBlock; }
            set { this._ipv6CidrBlock = value; }
        }

        // Check to see if Ipv6CidrBlock property is set
        internal bool IsSetIpv6CidrBlock()
        {
            return this._ipv6CidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkAclId. 
        /// <para>
        /// The ID of the ACL.
        /// </para>
        /// </summary>
        public string NetworkAclId
        {
            get { return this._networkAclId; }
            set { this._networkAclId = value; }
        }

        // Check to see if NetworkAclId property is set
        internal bool IsSetNetworkAclId()
        {
            return this._networkAclId != null;
        }

        /// <summary>
        /// Gets and sets the property PortRange. 
        /// <para>
        /// TCP or UDP protocols: The range of ports the rule applies to. Required if specifying
        /// TCP (6) or UDP (17) for the protocol.
        /// </para>
        /// </summary>
        public PortRange PortRange
        {
            get { return this._portRange; }
            set { this._portRange = value; }
        }

        // Check to see if PortRange property is set
        internal bool IsSetPortRange()
        {
            return this._portRange != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The IP protocol. You can specify <code>all</code> or <code>-1</code> to mean all protocols.
        /// If you specify <code>all</code>, <code>-1</code>, or a protocol number other than
        /// <code>tcp</code>, <code>udp</code>, or <code>icmp</code>, traffic on all ports is
        /// allowed, regardless of any ports or ICMP types or codes you specify. If you specify
        /// protocol <code>58</code> (ICMPv6) and specify an IPv4 CIDR block, traffic for all
        /// ICMP types and codes allowed, regardless of any that you specify. If you specify protocol
        /// <code>58</code> (ICMPv6) and specify an IPv6 CIDR block, you must specify an ICMP
        /// type and code.
        /// </para>
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property RuleAction. 
        /// <para>
        /// Indicates whether to allow or deny the traffic that matches the rule.
        /// </para>
        /// </summary>
        public RuleAction RuleAction
        {
            get { return this._ruleAction; }
            set { this._ruleAction = value; }
        }

        // Check to see if RuleAction property is set
        internal bool IsSetRuleAction()
        {
            return this._ruleAction != null;
        }

        /// <summary>
        /// Gets and sets the property RuleNumber. 
        /// <para>
        /// The rule number of the entry to replace.
        /// </para>
        /// </summary>
        public int RuleNumber
        {
            get { return this._ruleNumber.GetValueOrDefault(); }
            set { this._ruleNumber = value; }
        }

        // Check to see if RuleNumber property is set
        internal bool IsSetRuleNumber()
        {
            return this._ruleNumber.HasValue; 
        }

    }
}