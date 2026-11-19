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
    /// Optional filters and sort order for <a>ListFirewallRuleDomains</a>.
    /// </summary>
    public partial class ListFirewallRuleDomainsQueryOptions
    {
        /// <summary>
        /// Gets and sets the property DomainNameFilter. 
        /// <para>
        /// Returns only the domains whose name contains this substring.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DomainNameFilter { get; set; }

        /// <summary>
        /// Checks to see if the DomainNameFilter property is set.
        /// </summary>
        internal bool IsSetDomainNameFilter() => this.DomainNameFilter != null;

        /// <summary>
        /// Gets and sets the property DomainStatus. 
        /// <para>
        /// Filters the returned domains by review status. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OBSERVED</c> - Domains that DNS Firewall saw in the VPCs' DNS traffic and that
        /// you haven't allowed or denied. After the look-back window, a domain is observed when
        /// any DNS Firewall rule blocks a query for it from a VPC that uses the rule group, including
        /// rules in other rule groups, or when you remove it from the managed domain list. Domains
        /// from the look-back period that keep being queried and aren't blocked move to <c>ALLOWED</c>
        /// within about a day after the rule is created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALLOWED</c> - Domains that DNS Firewall allowed queries for, whether or not they're
        /// in the rule's managed domain list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DENIED</c> - Domains that were denied with the <c>DENY</c> operation. A denied
        /// domain that is still queried and not blocked can move to <c>ALLOWED</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a value, the operation returns <c>OBSERVED</c> domains.
        /// </para>
        /// </summary>
        public FirewallDomainStatusFilter DomainStatus { get; set; }

        /// <summary>
        /// Checks to see if the DomainStatus property is set.
        /// </summary>
        internal bool IsSetDomainStatus() => this.DomainStatus != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The attribute to sort the returned domains by. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TIME_ADDED</c> - The <c>AddedTime</c> of the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DAILY_TOTAL</c> - The <c>Last24HourRequests</c> count.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TOTAL_REQUESTS</c> - The <c>TotalRequests</c> count.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a value, the operation sorts by <c>TIME_ADDED</c>.
        /// </para>
        /// </summary>
        public FirewallRuleDomainSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort direction: <c>ASC</c> for ascending or <c>DESC</c> for descending. If you
        /// don't specify a value, the operation sorts in descending order.
        /// </para>
        /// </summary>
        public FirewallRuleDomainSortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
