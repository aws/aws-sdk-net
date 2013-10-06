/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Creates an entry (i.e., rule) in a network ACL with a rule number you specify.
    /// </summary>
    /// <remarks>
    /// Each network ACL has a set of numbered ingress rules and a separate set of numbered egress rules.
    /// When determining whether a packet should be allowed in or out of a subnet associated with the ACL,
    /// Amazon VPC processes the entries in the ACL according to the rule numbers, in ascending order.
    ///
    /// We recommend that you leave room between the rules (e.g., 100, 110, 120, etc.), and not number
    /// them sequentially (101, 102, 103, etc.). This allows you to easily add a new rule between existing
    /// ones without having to renumber the rules.
    ///
    /// After you add an entry, you can't modify it; you must either replace it, or create a new entry and delete
    /// the old one.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateNetworkAclEntryRequest : EC2Request
    {    
        private string networkAclIdField;
        private Decimal? ruleNumberField;
        private string protocolField;
        private string ruleActionField;
        private bool? egressField;
        private string cidrBlockField;
        private Icmp icmpField;
        private PortRange portRangeField;

        /// <summary>
        /// ID of the ACL where the entry will be created.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkAclId")]
        public string NetworkAclId
        {
            get { return this.networkAclIdField; }
            set { this.networkAclIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the ACL where the entry will be created.
        /// </summary>
        /// <param name="networkAclId">ID of the ACL where the entry will be created.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateNetworkAclEntryRequest WithNetworkAclId(string networkAclId)
        {
            this.networkAclIdField = networkAclId;
            return this;
        }

        /// <summary>
        /// Checks if NetworkAclId property is set
        /// </summary>
        /// <returns>true if NetworkAclId property is set</returns>
        public bool IsSetNetworkAclId()
        {
            return this.networkAclIdField != null;
        }

        /// <summary>
        /// Rule number to assign to the entry (e.g., 100).
        /// </summary>
        /// <remarks>
        /// ACL  entries are processed in ascending order by rule
        /// number.
        /// </remarks>
        [XmlElementAttribute(ElementName = "RuleNumber")]
        public Decimal RuleNumber
        {
            get { return this.ruleNumberField.GetValueOrDefault(); }
            set { this.ruleNumberField = value; }
        }

        /// <summary>
        /// Sets the rule number to assign to the entry (e.g., 100).
        /// </summary>
        /// <param name="ruleNumber">Rule number to assign to the entry (e.g., 100).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateNetworkAclEntryRequest WithRuleNumber(Decimal ruleNumber)
        {
            this.ruleNumberField = ruleNumber;
            return this;
        }

        /// <summary>
        /// Checks if RuleNumber property is set
        /// </summary>
        /// <returns>true if RuleNumber property is set</returns>
        public bool IsSetRuleNumber()
        {
            return this.ruleNumberField.HasValue;
        }

        /// <summary>
        /// The IP protocol the rule applies to.
        /// You can use -1 to mean all protocols.
        /// </summary>
        [XmlElementAttribute(ElementName = "Protocol")]
        public string Protocol
        {
            get { return this.protocolField; }
            set { this.protocolField = value; }
        }

        /// <summary>
        /// Sets the IP protocol the rule applies to.
        /// </summary>
        /// <param name="protocol">IP protocol the rule applies to.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateNetworkAclEntryRequest WithProtocol(string protocol)
        {
            this.protocolField = protocol;
            return this;
        }

        /// <summary>
        /// Checks if Protocol property is set
        /// </summary>
        /// <returns>true if Protocol property is set</returns>
        public bool IsSetProtocol()
        {
            return this.protocolField != null;
        }

        /// <summary>
        /// Whether to allow or deny traffic that matches the rule.
        /// </summary>
        /// <remarks>
        /// Valid Values: allow | deny
        /// </remarks>
        [XmlElementAttribute(ElementName = "RuleAction")]
        public string RuleAction
        {
            get { return this.ruleActionField; }
            set { this.ruleActionField = value; }
        }

        /// <summary>
        /// Sets whether to allow or deny traffic that matches the rule.
        /// </summary>
        /// <param name="ruleAction">Whether to allow or deny traffic that matches the rule.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateNetworkAclEntryRequest WithRuleAction(string ruleAction)
        {
            this.ruleActionField = ruleAction;
            return this;
        }

        /// <summary>
        /// Checks if RuleAction property is set
        /// </summary>
        /// <returns>true if RuleAction property is set</returns>
        public bool IsSetRuleAction()
        {
            return this.ruleActionField != null;
        }

        /// <summary>
        /// Whether this rule applies to egress traffic from the subnet (true)
        /// or ingress traffic to the subnet (false).
        /// </summary>
        [XmlElementAttribute(ElementName = "Egress")]
        public bool Egress
        {
            get { return this.egressField.GetValueOrDefault(); }
            set { this.egressField = value; }
        }

        /// <summary>
        /// Sets whether this rule applies to egress traffic from the subnet (true)
        /// or ingress traffic to the subnet (false).
        /// </summary>
        /// <param name="egress">Whether this rule applies to egress traffic from the 
        /// subnet (true) or ingress traffic to the subnet (false).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateNetworkAclEntryRequest WithEgress(bool egress)
        {
            this.egressField = egress;
            return this;
        }

        /// <summary>
        /// Checks if Egress property is set
        /// </summary>
        /// <returns>true if Egress property is set</returns>
        public bool IsSetEgress()
        {
            return this.egressField.HasValue;
        }

        /// <summary>
        /// The CIDR range to allow or deny, in CIDR notation
        /// (e.g., 172.16.0.0/24).
        /// </summary>
        [XmlElementAttribute(ElementName = "CidrBlock")]
        public string CidrBlock
        {
            get { return this.cidrBlockField; }
            set { this.cidrBlockField = value; }
        }

        /// <summary>
        /// Sets the CIDR range to allow or deny, in CIDR notation.
        /// </summary>
        /// <param name="cidrBlock">The CIDR range to allow or deny, in CIDR notation
        /// (e.g., 172.16.0.0/24).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateNetworkAclEntryRequest WithCidrBlock(string cidrBlock)
        {
            this.cidrBlockField = cidrBlock;
            return this;
        }

        /// <summary>
        /// Checks if CidrBlock property is set
        /// </summary>
        /// <returns>true if CidrBlock property is set</returns>
        public bool IsSetCidrBlock()
        {
            return this.cidrBlockField != null;
        }

        /// <summary>
        /// The ICMP type and code for the ICMP protocol.
        /// </summary>
        [XmlElementAttribute(ElementName = "Icmp")]
        public Icmp Icmp
        {
            get { return this.icmpField; }
            set { this.icmpField = value; }
        }

        /// <summary>
        /// Sets the ICMP type and code for the ICMP protocol.
        /// </summary>
        /// <param name="icmp">For the ICMP protocol, this is the ICMP type and code.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateNetworkAclEntryRequest WithIcmp(Icmp icmp)
        {
            this.icmpField = icmp;
            return this;
        }

        /// <summary>
        /// Checks if Icmp property is set
        /// </summary>
        /// <returns>true if Icmp property is set</returns>
        public bool IsSetIcmp()
        {
            return this.icmpField != null;
        }

        /// <summary>
        /// The range of ports the rule applies to, for TCP or UDP protocols.
        /// </summary>
        [XmlElementAttribute(ElementName = "PortRange")]
        public PortRange PortRange
        {
            get { return this.portRangeField; }
            set { this.portRangeField = value; }
        }

        /// <summary>
        /// Sets the range of ports the rule applies to, for TCP or UDP protocols.
        /// </summary>
        /// <param name="portRange">For the TCP or UDP protocols, the range of ports the rule applies to.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateNetworkAclEntryRequest WithPortRange(PortRange portRange)
        {
            this.portRangeField = portRange;
            return this;
        }

        /// <summary>
        /// Checks if PortRange property is set
        /// </summary>
        /// <returns>true if PortRange property is set</returns>
        public bool IsSetPortRange()
        {
            return this.portRangeField != null;
        }

    }
}
