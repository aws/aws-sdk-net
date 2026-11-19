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
    /// The configuration for an AutoAllowlist firewall rule, which observes the DNS traffic
    /// of the VPCs that use the rule group, through a rule group association or a Route 53
    /// Profile. The rule allows the domains on its managed domain list. When you create the
    /// rule, DNS Firewall seeds the observed domains from the look-back window of each VPC.
    /// After that, a domain is listed as observed when any DNS Firewall rule blocks a query
    /// for it from a VPC that uses the rule group, including rules in other rule groups,
    /// so place a rule that blocks the domains you haven't approved after the AutoAllowlist
    /// rule. To review the observed domains, call <a>ListFirewallRuleDomains</a>. To approve
    /// or deny them, call <a>UpdateFirewallDomains</a> on the rule's managed domain list.
    /// 
    ///  
    /// <para>
    /// An AutoAllowlist rule uses the <c>ALLOW</c> action, applies to all query types, and
    /// always inspects redirection domains. You can't set <c>Qtype</c>, <c>FirewallDomainRedirectionAction</c>,
    /// <c>BlockResponse</c>, or the DNS Firewall Advanced settings on it. A rule group can
    /// contain one AutoAllowlist rule.
    /// </para>
    ///  
    /// <para>
    /// A new AutoAllowlist rule has status <c>CREATING</c> while DNS Firewall reads the look-back
    /// window of each VPC that uses the rule group, which can take hours for a rule group
    /// that many VPCs use. Until the status is <c>COMPLETE</c>, the observed domains and
    /// request counts are partial and <a>UpdateFirewallRule</a> rejects the rule. You can
    /// approve, remove, and deny domains while the rule is <c>CREATING</c>.
    /// </para>
    /// </summary>
    public partial class AutoAllowlistConfig
    {
        /// <summary>
        /// Gets and sets the property AutoAllowlistFirewallDomainListId. 
        /// <para>
        /// The ID of the managed domain list that DNS Firewall creates and maintains for this
        /// AutoAllowlist rule. The list is named <c>AutoAllowlist - </c> followed by the rule
        /// name, cut to 64 characters, and is renamed when you rename the rule. DNS Firewall
        /// returns this value in responses. You can't set it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AutoAllowlistFirewallDomainListId { get; set; }

        /// <summary>
        /// Checks to see if the AutoAllowlistFirewallDomainListId property is set.
        /// </summary>
        internal bool IsSetAutoAllowlistFirewallDomainListId() => this.AutoAllowlistFirewallDomainListId != null;

        /// <summary>
        /// Gets and sets the property ImportFromFirewallDomainListId. 
        /// <para>
        /// The ID of a domain list whose domains DNS Firewall copies into the AutoAllowlist rule's
        /// managed domain list after you create the rule. You must own the source list, and it
        /// must be in <c>COMPLETE</c> status, in the same Region, and not a managed or AutoAllowlist
        /// list. DNS Firewall reads the source list while the copy runs, so don't change or delete
        /// it until the managed list's status is no longer <c>IMPORTING</c>. A change made to
        /// the source list during the copy can be reflected in the managed list, and deleting
        /// the source list fails the copy. The managed list then has status <c>COMPLETE</c>,
        /// or <c>COMPLETE_IMPORT_FAILED</c> if the copy failed. DNS Firewall uses this value
        /// only when you create the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ImportFromFirewallDomainListId { get; set; }

        /// <summary>
        /// Checks to see if the ImportFromFirewallDomainListId property is set.
        /// </summary>
        internal bool IsSetImportFromFirewallDomainListId() => this.ImportFromFirewallDomainListId != null;

        /// <summary>
        /// Gets and sets the property InitialDataTimeframeHours. 
        /// <para>
        /// The look-back window, in hours, of historical DNS traffic that DNS Firewall uses to
        /// seed the initial set of observed domains when you create the rule. Valid values are
        /// from <c>1</c> to <c>168</c> (7 days). You can't change this value after you create
        /// the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 168)]
        public int? InitialDataTimeframeHours { get; set; }

        /// <summary>
        /// Checks to see if the InitialDataTimeframeHours property is set.
        /// </summary>
        internal bool IsSetInitialDataTimeframeHours() => this.InitialDataTimeframeHours.HasValue;
    }
}
