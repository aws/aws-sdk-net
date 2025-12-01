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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53GlobalResolver.Model
{
    /// <summary>
    /// Paginators for the Route53GlobalResolver service
    ///</summary>
    public interface IRoute53GlobalResolverPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAccessSources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAccessSourcesPaginator ListAccessSources(ListAccessSourcesRequest request);

        /// <summary>
        /// Paginator for ListAccessTokens operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAccessTokensPaginator ListAccessTokens(ListAccessTokensRequest request);

        /// <summary>
        /// Paginator for ListDNSViews operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDNSViewsPaginator ListDNSViews(ListDNSViewsRequest request);

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
        /// Paginator for ListFirewallRules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFirewallRulesPaginator ListFirewallRules(ListFirewallRulesRequest request);

        /// <summary>
        /// Paginator for ListGlobalResolvers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListGlobalResolversPaginator ListGlobalResolvers(ListGlobalResolversRequest request);

        /// <summary>
        /// Paginator for ListHostedZoneAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListHostedZoneAssociationsPaginator ListHostedZoneAssociations(ListHostedZoneAssociationsRequest request);

        /// <summary>
        /// Paginator for ListManagedFirewallDomainLists operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListManagedFirewallDomainListsPaginator ListManagedFirewallDomainLists(ListManagedFirewallDomainListsRequest request);
    }
}