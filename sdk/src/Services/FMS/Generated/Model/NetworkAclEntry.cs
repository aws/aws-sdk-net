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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Describes a rule in a network ACL.
    /// 
    ///  
    /// <para>
    /// Each network ACL has a set of numbered ingress rules and a separate set of numbered
    /// egress rules. When determining whether a packet should be allowed in or out of a subnet
    /// associated with the network ACL, Amazon Web Services processes the entries in the
    /// network ACL according to the rule numbers, in ascending order. 
    /// </para>
    ///  
    /// <para>
    /// When you manage an individual network ACL, you explicitly specify the rule numbers.
    /// When you specify the network ACL rules in a Firewall Manager policy, you provide the
    /// rules to run first, in the order that you want them to run, and the rules to run last,
    /// in the order that you want them to run. Firewall Manager assigns the rule numbers
    /// for you when you save the network ACL policy specification.
    /// </para>
    /// </summary>
    public partial class NetworkAclEntry
    {
        private string _cidrBlock;
        private bool? _egress;
        private NetworkAclIcmpTypeCode _icmpTypeCode;
        private string _ipv6CidrBlock;
        private NetworkAclPortRange _portRange;
        private string _protocol;
        private NetworkAclRuleAction _ruleAction;

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The IPv4 network range to allow or deny, in CIDR notation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Indicates whether the rule is an egress, or outbound, rule (applied to traffic leaving
        /// the subnet). If it's not an egress rule, then it's an ingress, or inbound, rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Egress
        {
            get { return this._egress; }
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
        /// ICMP protocol: The ICMP type and code.
        /// </para>
        /// </summary>
        public NetworkAclIcmpTypeCode IcmpTypeCode
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
        /// The IPv6 network range to allow or deny, in CIDR notation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property PortRange. 
        /// <para>
        /// TCP or UDP protocols: The range of ports the rule applies to.
        /// </para>
        /// </summary>
        public NetworkAclPortRange PortRange
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
        /// The protocol number. A value of "-1" means all protocols. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
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
        [AWSProperty(Required=true)]
        public NetworkAclRuleAction RuleAction
        {
            get { return this._ruleAction; }
            set { this._ruleAction = value; }
        }

        // Check to see if RuleAction property is set
        internal bool IsSetRuleAction()
        {
            return this._ruleAction != null;
        }

    }
}