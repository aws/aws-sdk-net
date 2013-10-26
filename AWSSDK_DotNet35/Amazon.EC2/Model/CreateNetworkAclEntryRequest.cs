/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the CreateNetworkAclEntry operation.
    /// <para> Creates an entry (i.e., rule) in a network ACL with a rule number you specify. Each network ACL has a set of numbered ingress rules
    /// and a separate set of numbered egress rules. When determining whether a packet should be allowed in or out of a subnet associated with the
    /// ACL, Amazon VPC processes the entries in the ACL according to the rule numbers, in ascending order. </para> <para> <b>Important:</b> We
    /// recommend that you leave room between the rules (e.g., 100, 110, 120, etc.), and not number them sequentially (101, 102, 103, etc.). This
    /// allows you to easily add a new rule between existing ones without having to renumber the rules. </para> <para> After you add an entry, you
    /// can't modify it; you must either replace it, or create a new entry and delete the old one. </para> <para> For more information about network
    /// ACLs, go to Network ACLs in the Amazon Virtual Private Cloud User Guide. </para>
    /// </summary>
    public partial class CreateNetworkAclEntryRequest : AmazonEC2Request
    {
        private string networkAclId;
        private int? ruleNumber;
        private string protocol;
        private RuleAction ruleAction;
        private bool? egress;
        private string cidrBlock;
        private IcmpTypeCode icmpTypeCode;
        private PortRange portRange;


        /// <summary>
        /// ID of the ACL where the entry will be created.
        ///  
        /// </summary>
        public string NetworkAclId
        {
            get { return this.networkAclId; }
            set { this.networkAclId = value; }
        }

        // Check to see if NetworkAclId property is set
        internal bool IsSetNetworkAclId()
        {
            return this.networkAclId != null;
        }

        /// <summary>
        /// Rule number to assign to the entry (e.g., 100). ACL entries are processed in ascending order by rule number.
        ///  
        /// </summary>
        public int RuleNumber
        {
            get { return this.ruleNumber ?? default(int); }
            set { this.ruleNumber = value; }
        }

        // Check to see if RuleNumber property is set
        internal bool IsSetRuleNumber()
        {
            return this.ruleNumber.HasValue;
        }

        /// <summary>
        /// IP protocol the rule applies to. Valid Values: <c>tcp</c>, <c>udp</c>, <c>icmp</c> or an IP protocol number.
        ///  
        /// </summary>
        public string Protocol
        {
            get { return this.protocol; }
            set { this.protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this.protocol != null;
        }

        /// <summary>
        /// Whether to allow or deny traffic that matches the rule.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>allow, deny</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public RuleAction RuleAction
        {
            get { return this.ruleAction; }
            set { this.ruleAction = value; }
        }

        // Check to see if RuleAction property is set
        internal bool IsSetRuleAction()
        {
            return this.ruleAction != null;
        }

        /// <summary>
        /// Whether this rule applies to egress traffic from the subnet (<c>true</c>) or ingress traffic to the subnet (<c>false</c>).
        ///  
        /// </summary>
        public bool Egress
        {
            get { return this.egress ?? default(bool); }
            set { this.egress = value; }
        }

        // Check to see if Egress property is set
        internal bool IsSetEgress()
        {
            return this.egress.HasValue;
        }

        /// <summary>
        /// The CIDR range to allow or deny, in CIDR notation (e.g., <c>172.16.0.0/24</c>).
        ///  
        /// </summary>
        public string CidrBlock
        {
            get { return this.cidrBlock; }
            set { this.cidrBlock = value; }
        }

        // Check to see if CidrBlock property is set
        internal bool IsSetCidrBlock()
        {
            return this.cidrBlock != null;
        }

        /// <summary>
        /// ICMP values.
        ///  
        /// </summary>
        public IcmpTypeCode IcmpTypeCode
        {
            get { return this.icmpTypeCode; }
            set { this.icmpTypeCode = value; }
        }

        // Check to see if IcmpTypeCode property is set
        internal bool IsSetIcmpTypeCode()
        {
            return this.icmpTypeCode != null;
        }

        /// <summary>
        /// Port ranges.
        ///  
        /// </summary>
        public PortRange PortRange
        {
            get { return this.portRange; }
            set { this.portRange = value; }
        }

        // Check to see if PortRange property is set
        internal bool IsSetPortRange()
        {
            return this.portRange != null;
        }

    }
}
    
