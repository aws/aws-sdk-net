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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Paginators for the Route53Resolver service
    ///</summary>
    public interface IRoute53ResolverPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListFirewallConfigs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFirewallConfigsPaginator ListFirewallConfigs(ListFirewallConfigsRequest request);

        /// <summary>
        /// Paginator for ListFirewallDomainLists operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFirewallDomainListsPaginator ListFirewallDomainLists(ListFirewallDomainListsRequest request);

        /// <summary>
        /// Paginator for ListFirewallDomains operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFirewallDomainsPaginator ListFirewallDomains(ListFirewallDomainsRequest request);

        /// <summary>
        /// Paginator for ListFirewallRuleGroupAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFirewallRuleGroupAssociationsPaginator ListFirewallRuleGroupAssociations(ListFirewallRuleGroupAssociationsRequest request);

        /// <summary>
        /// Paginator for ListFirewallRuleGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFirewallRuleGroupsPaginator ListFirewallRuleGroups(ListFirewallRuleGroupsRequest request);

        /// <summary>
        /// Paginator for ListFirewallRules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFirewallRulesPaginator ListFirewallRules(ListFirewallRulesRequest request);

        /// <summary>
        /// Paginator for ListOutpostResolvers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOutpostResolversPaginator ListOutpostResolvers(ListOutpostResolversRequest request);

        /// <summary>
        /// Paginator for ListResolverConfigs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResolverConfigsPaginator ListResolverConfigs(ListResolverConfigsRequest request);

        /// <summary>
        /// Paginator for ListResolverDnssecConfigs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResolverDnssecConfigsPaginator ListResolverDnssecConfigs(ListResolverDnssecConfigsRequest request);

        /// <summary>
        /// Paginator for ListResolverEndpointIpAddresses operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResolverEndpointIpAddressesPaginator ListResolverEndpointIpAddresses(ListResolverEndpointIpAddressesRequest request);

        /// <summary>
        /// Paginator for ListResolverEndpoints operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResolverEndpointsPaginator ListResolverEndpoints(ListResolverEndpointsRequest request);

        /// <summary>
        /// Paginator for ListResolverQueryLogConfigAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResolverQueryLogConfigAssociationsPaginator ListResolverQueryLogConfigAssociations(ListResolverQueryLogConfigAssociationsRequest request);

        /// <summary>
        /// Paginator for ListResolverQueryLogConfigs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResolverQueryLogConfigsPaginator ListResolverQueryLogConfigs(ListResolverQueryLogConfigsRequest request);

        /// <summary>
        /// Paginator for ListResolverRuleAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResolverRuleAssociationsPaginator ListResolverRuleAssociations(ListResolverRuleAssociationsRequest request);

        /// <summary>
        /// Paginator for ListResolverRules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResolverRulesPaginator ListResolverRules(ListResolverRulesRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);
    }
}