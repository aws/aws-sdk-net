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

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// The rule-type configuration for a DNS Firewall rule. <c>FirewallRuleType</c> is a
    /// tagged union — exactly one member must be set per rule, and the member determines
    /// what the rule matches against. This shape is mutually exclusive with the top-level
    /// <c>FirewallDomainListId</c> and <c>DnsThreatProtection</c> fields on <a>CreateFirewallRule</a>
    /// and <a>UpdateFirewallRule</a>.
    /// 
    ///  
    /// <para>
    /// Call <a>ListFirewallRuleTypes</a> to discover which rule-type variants and which values
    /// within each variant are available in your account and Region.
    /// </para>
    /// </summary>
    public partial class FirewallRuleType
    {
        /// <summary>
        /// Gets and sets the property DnsThreatProtection. 
        /// <para>
        /// Configures the rule to match a built-in DNS Firewall Advanced threat detector — <c>DGA</c>,
        /// <c>DNS_TUNNELING</c>, or <c>DICTIONARY_DGA</c>. See <a>DnsThreatProtectionRuleTypeConfig</a>.
        /// </para>
        /// </summary>
        public DnsThreatProtectionRuleTypeConfig DnsThreatProtection { get; set; }

        /// <summary>
        /// Checks to see if the DnsThreatProtection property is set.
        /// </summary>
        internal bool IsSetDnsThreatProtection() => this.DnsThreatProtection != null;

        /// <summary>
        /// Gets and sets the property FirewallAdvancedContentCategory. 
        /// <para>
        /// Configures the rule to match an Amazon Web Services-managed content category (for
        /// example, <c>VIOLENCE_AND_HATE_SPEECH</c>). See <a>FirewallAdvancedContentCategoryConfig</a>.
        /// </para>
        /// </summary>
        public FirewallAdvancedContentCategoryConfig FirewallAdvancedContentCategory { get; set; }

        /// <summary>
        /// Checks to see if the FirewallAdvancedContentCategory property is set.
        /// </summary>
        internal bool IsSetFirewallAdvancedContentCategory() => this.FirewallAdvancedContentCategory != null;

        /// <summary>
        /// Gets and sets the property FirewallAdvancedThreatCategory. 
        /// <para>
        /// Configures the rule to match an Amazon Web Services-managed advanced threat category
        /// (for example, <c>PHISHING</c>). See <a>FirewallAdvancedThreatCategoryConfig</a>.
        /// </para>
        /// </summary>
        public FirewallAdvancedThreatCategoryConfig FirewallAdvancedThreatCategory { get; set; }

        /// <summary>
        /// Checks to see if the FirewallAdvancedThreatCategory property is set.
        /// </summary>
        internal bool IsSetFirewallAdvancedThreatCategory() => this.FirewallAdvancedThreatCategory != null;

        /// <summary>
        /// Gets and sets the property PartnerThreatProtection. 
        /// <para>
        /// Configures the rule to match a third-party threat feed delivered through Amazon Web
        /// Services Marketplace. The calling account must hold an active subscription to the
        /// partner product named in <c>Partner</c>; if the subscription is missing or revoked,
        /// the rule is created with <c>Status</c> <c>CREATION_FAILED</c> and cannot be modified
        /// — only deleted. See <a>PartnerThreatProtectionConfig</a>.
        /// </para>
        /// </summary>
        public PartnerThreatProtectionConfig PartnerThreatProtection { get; set; }

        /// <summary>
        /// Checks to see if the PartnerThreatProtection property is set.
        /// </summary>
        internal bool IsSetPartnerThreatProtection() => this.PartnerThreatProtection != null;
    }
}
