/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-02-28
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Replaces an entry (i.e., rule) in a network ACL. For more information about network ACLs, go to Network
    /// ACLs in the Amazon Virtual Private Cloud User Guide.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-02-28/", IsNullable = false)]
    public class ReplaceNetworkAclEntryRequest
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
        /// Gets and sets the NetworkAclId property.
        /// ID of the ACL where the entry will be replaced.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkAclId")]
        public string NetworkAclId
        {
            get { return this.networkAclIdField; }
            set { this.networkAclIdField = value; }
        }

        /// <summary>
        /// Sets the NetworkAclId property
        /// </summary>
        /// <param name="networkAclId">ID of the ACL where the entry will be replaced.</param>
        /// <returns>this instance</returns>
        public ReplaceNetworkAclEntryRequest WithNetworkAclId(string networkAclId)
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
        /// Gets and sets the RuleNumber property.
        /// Rule number of the entry to replace.
        /// </summary>
        [XmlElementAttribute(ElementName = "RuleNumber")]
        public Decimal RuleNumber
        {
            get { return this.ruleNumberField.GetValueOrDefault(); }
            set { this.ruleNumberField = value; }
        }

        /// <summary>
        /// Sets the RuleNumber property
        /// </summary>
        /// <param name="ruleNumber">Rule number of the entry to replace.</param>
        /// <returns>this instance</returns>
        public ReplaceNetworkAclEntryRequest WithRuleNumber(Decimal ruleNumber)
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
        /// Gets and sets the Protocol property.
        /// IP protocol the rule applies to.
        ///
        /// Valid Values: tcp | udp | icmp or an IP protocol number.
        /// </summary>
        [XmlElementAttribute(ElementName = "Protocol")]
        public string Protocol
        {
            get { return this.protocolField; }
            set { this.protocolField = value; }
        }

        /// <summary>
        /// Sets the Protocol property
        /// </summary>
        /// <param name="protocol">IP protocol the rule applies to.
        ///
        /// Valid Values: tcp | udp | icmp or an IP protocol number.</param>
        /// <returns>this instance</returns>
        public ReplaceNetworkAclEntryRequest WithProtocol(string protocol)
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
        /// Gets and sets the RuleAction property.
        /// Whether to allow or deny traffic that matches the rule.
        ///
        /// Valid Values: allow | deny
        /// </summary>
        [XmlElementAttribute(ElementName = "RuleAction")]
        public string RuleAction
        {
            get { return this.ruleActionField; }
            set { this.ruleActionField = value; }
        }

        /// <summary>
        /// Sets the RuleAction property
        /// </summary>
        /// <param name="ruleAction">Whether to allow or deny traffic that matches the rule.
        ///
        /// Valid Values: allow | deny</param>
        /// <returns>this instance</returns>
        public ReplaceNetworkAclEntryRequest WithRuleAction(string ruleAction)
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
        /// Gets and sets the Egress property.
        /// Whether this rule applies to egress traffic from the No
        /// subnet (true) or ingress traffic (false).
        /// </summary>
        [XmlElementAttribute(ElementName = "Egress")]
        public bool Egress
        {
            get { return this.egressField.GetValueOrDefault(); }
            set { this.egressField = value; }
        }

        /// <summary>
        /// Sets the Egress property
        /// </summary>
        /// <param name="egress">Whether this rule applies to egress traffic from the No
        /// subnet (true) or ingress traffic (false).</param>
        /// <returns>this instance</returns>
        public ReplaceNetworkAclEntryRequest WithEgress(bool egress)
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
        /// Gets and sets the CidrBlock property.
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
        /// Sets the CidrBlock property
        /// </summary>
        /// <param name="cidrBlock">The CIDR range to allow or deny, in CIDR notation 
        /// (e.g., 172.16.0.0/24).</param>
        /// <returns>this instance</returns>
        public ReplaceNetworkAclEntryRequest WithCidrBlock(string cidrBlock)
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
        /// Gets and sets the Icmp property.
        /// For the ICMP protocol, this is the ICMP type and code.
        /// </summary>
        [XmlElementAttribute(ElementName = "Icmp")]
        public Icmp Icmp
        {
            get { return this.icmpField; }
            set { this.icmpField = value; }
        }

        /// <summary>
        /// Sets the Icmp property
        /// </summary>
        /// <param name="icmp">For the ICMP protocol, this is the ICMP type and code.</param>
        /// <returns>this instance</returns>
        public ReplaceNetworkAclEntryRequest WithIcmp(Icmp icmp)
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
        /// Gets and sets the PortRange property.
        /// For the TCP or UDP protocols, the range of ports the rule applies to.
        /// </summary>
        [XmlElementAttribute(ElementName = "PortRange")]
        public PortRange PortRange
        {
            get { return this.portRangeField; }
            set { this.portRangeField = value; }
        }

        /// <summary>
        /// Sets the PortRange property
        /// </summary>
        /// <param name="portRange">For the TCP or UDP protocols, the range of ports the rule applies to.</param>
        /// <returns>this instance</returns>
        public ReplaceNetworkAclEntryRequest WithPortRange(PortRange portRange)
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
