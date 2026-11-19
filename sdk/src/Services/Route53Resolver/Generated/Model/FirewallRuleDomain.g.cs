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
    /// A domain that DNS Firewall observed for an AutoAllowlist rule, with its review status
    /// and request volume. Counts are aggregated across all VPCs that use the rule group,
    /// through a rule group association or through a Route 53 Profile that includes the rule
    /// group, including VPCs in other accounts. The domain isn't attributed to the VPC or
    /// account in which it was observed.
    /// </summary>
    public partial class FirewallRuleDomain
    {
        /// <summary>
        /// Gets and sets the property AddedTime. 
        /// <para>
        /// The date and time when the domain was first observed and added, in RFC 3339 format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 40)]
        public string AddedTime { get; set; }

        /// <summary>
        /// Checks to see if the AddedTime property is set.
        /// </summary>
        internal bool IsSetAddedTime() => this.AddedTime != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DomainStatus. 
        /// <para>
        /// The review status of the domain:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OBSERVED</c> - DNS Firewall saw the domain in the VPCs' DNS traffic and you haven't
        /// allowed or denied it. The look-back window seeds the initial observed domains. After
        /// that, a domain becomes observed when any DNS Firewall rule blocks a query for it from
        /// a VPC that uses the rule group, including rules in other rule groups, or when you
        /// remove it from the managed domain list with <c>REMOVE</c>. To keep observing new domains,
        /// place a rule that blocks the domains you haven't approved after the AutoAllowlist
        /// rule. Domains from the look-back period that keep being queried and aren't blocked
        /// move to <c>ALLOWED</c> within about a day after the rule is created. Observed domains
        /// aren't evaluated for safety, so review them before you allow them.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALLOWED</c> - DNS Firewall allowed queries for the domain, whether or not the
        /// domain is in the rule's managed domain list. To get the domains in the managed domain
        /// list (the allowlist that the rule enforces), call <a>ListFirewallRuleDomains</a> with
        /// <c>FirewallDomainListId</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DENIED</c> - The domain was denied with the <c>DENY</c> operation of <a>UpdateFirewallDomains</a>,
        /// which also removes it from the managed domain list if it was there. A denied domain
        /// that is still queried and not blocked can move to <c>ALLOWED</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FirewallDomainStatus DomainStatus { get; set; }

        /// <summary>
        /// Checks to see if the DomainStatus property is set.
        /// </summary>
        internal bool IsSetDomainStatus() => this.DomainStatus != null;

        /// <summary>
        /// Gets and sets the property Last24HourRequests. 
        /// <para>
        /// The number of DNS requests observed for this domain in the last 24 hours.
        /// </para>
        /// </summary>
        public long? Last24HourRequests { get; set; }

        /// <summary>
        /// Checks to see if the Last24HourRequests property is set.
        /// </summary>
        internal bool IsSetLast24HourRequests() => this.Last24HourRequests.HasValue;

        /// <summary>
        /// Gets and sets the property TotalRequests. 
        /// <para>
        /// The total number of DNS requests observed for this domain since it was first added,
        /// including the requests in the look-back window that seeded the rule.
        /// </para>
        /// </summary>
        public long? TotalRequests { get; set; }

        /// <summary>
        /// Checks to see if the TotalRequests property is set.
        /// </summary>
        internal bool IsSetTotalRequests() => this.TotalRequests.HasValue;
    }
}
