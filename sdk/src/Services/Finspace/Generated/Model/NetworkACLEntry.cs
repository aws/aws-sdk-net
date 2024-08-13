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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// The network access control list (ACL) is an optional layer of security for your VPC
    /// that acts as a firewall for controlling traffic in and out of one or more subnets.
    /// The entry is a set of numbered ingress and egress rules that determine whether a packet
    /// should be allowed in or out of a subnet associated with the ACL. We process the entries
    /// in the ACL according to the rule numbers, in ascending order.
    /// </summary>
    public partial class NetworkACLEntry
    {
        private string _cidrBlock;
        private IcmpTypeCode _icmpTypeCode;
        private PortRange _portRange;
        private string _protocol;
        private RuleAction _ruleAction;
        private int? _ruleNumber;

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        ///  The IPv4 network range to allow or deny, in CIDR notation. For example, <c>172.16.0.0/24</c>.
        /// We modify the specified CIDR block to its canonical form. For example, if you specify
        /// <c>100.68.0.18/18</c>, we modify it to <c>100.68.0.0/18</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=18)]
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
        /// Gets and sets the property IcmpTypeCode. 
        /// <para>
        ///  Defines the ICMP protocol that consists of the ICMP type and code. 
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
        /// Gets and sets the property PortRange. 
        /// <para>
        ///  The range of ports the rule applies to. 
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
        ///  The protocol number. A value of <i>-1</i> means all the protocols. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
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
        ///  Indicates whether to allow or deny the traffic that matches the rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  The rule number for the entry. For example <i>100</i>. All the network ACL entries
        /// are processed in ascending order by rule number. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32766)]
        public int? RuleNumber
        {
            get { return this._ruleNumber; }
            set { this._ruleNumber = value; }
        }

        // Check to see if RuleNumber property is set
        internal bool IsSetRuleNumber()
        {
            return this._ruleNumber.HasValue; 
        }

    }
}