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
    /// Container for the parameters to the ListFirewallRuleDomains operation. Retrieves the
    /// domains of an AutoAllowlist firewall rule. Only the owner of the rule group can call
    /// this operation. Results are paginated. Use <c>MaxResults</c> and <c>NextToken</c>
    /// to retrieve additional domains. <para> Identify the rule by <c>FirewallThreatProtectionId</c>
    /// to get the domains that DNS Firewall observed in the VPCs that use the rule group,
    /// through a rule group association or through a Route 53 Profile that includes the rule
    /// group, including VPCs in other accounts. Each domain is returned with its <c>DomainStatus</c>
    /// and request counts. Use <c>QueryOptions</c> to filter and sort the results. </para>
    /// <para> Identify the rule's managed domain list by <c>FirewallDomainListId</c> to get
    /// the domains that the rule currently allows. For any other domain list, use <a>ListFirewallDomains</a>.
    /// </para>
    /// </summary>
    public partial class ListFirewallRuleDomainsRequest : AmazonRoute53ResolverRequest
    {
        /// <summary>
        /// Gets and sets the property FirewallDomainListId. 
        /// <para>
        /// The ID of the AutoAllowlist rule's managed domain list. Provide this to list the domains
        /// that the rule currently allows.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FirewallDomainListId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallDomainListId property is set.
        /// </summary>
        internal bool IsSetFirewallDomainListId() => this.FirewallDomainListId != null;

        /// <summary>
        /// Gets and sets the property FirewallRuleGroupId. 
        /// <para>
        /// The unique identifier of the firewall rule group that contains the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string FirewallRuleGroupId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallRuleGroupId property is set.
        /// </summary>
        internal bool IsSetFirewallRuleGroupId() => this.FirewallRuleGroupId != null;

        /// <summary>
        /// Gets and sets the property FirewallThreatProtectionId. 
        /// <para>
        /// The threat protection ID that identifies an AutoAllowlist rule. Provide this to list
        /// an AutoAllowlist rule's domains.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FirewallThreatProtectionId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallThreatProtectionId property is set.
        /// </summary>
        internal bool IsSetFirewallThreatProtectionId() => this.FirewallThreatProtectionId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of domains that you want to return in a single call. If more domains
        /// remain than can be returned, the response includes a <c>NextToken</c> value that you
        /// can use in a subsequent call to get the next batch. The default is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// For the first call to this operation, omit this value. If more domains remain than
        /// can be returned in a single call, the response includes a <c>NextToken</c> value.
        /// In your next call, specify that value to get the next batch of domains.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property QueryOptions. 
        /// <para>
        /// Optional filters and sort order for the returned domains. If you don't specify this,
        /// the operation returns the <c>OBSERVED</c> domains sorted by <c>TIME_ADDED</c> in descending
        /// order. See <a>ListFirewallRuleDomainsQueryOptions</a>.
        /// </para>
        /// </summary>
        public ListFirewallRuleDomainsQueryOptions QueryOptions { get; set; }

        /// <summary>
        /// Checks to see if the QueryOptions property is set.
        /// </summary>
        internal bool IsSetQueryOptions() => this.QueryOptions != null;
    }
}
