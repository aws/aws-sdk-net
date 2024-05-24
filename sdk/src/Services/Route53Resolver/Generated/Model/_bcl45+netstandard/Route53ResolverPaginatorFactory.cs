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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Paginators for the Route53Resolver service
    ///</summary>
    public class Route53ResolverPaginatorFactory : IRoute53ResolverPaginatorFactory
    {
        private readonly IAmazonRoute53Resolver client;

        internal Route53ResolverPaginatorFactory(IAmazonRoute53Resolver client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListFirewallConfigs operation
        ///</summary>
        public IListFirewallConfigsPaginator ListFirewallConfigs(ListFirewallConfigsRequest request) 
        {
            return new ListFirewallConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFirewallDomainLists operation
        ///</summary>
        public IListFirewallDomainListsPaginator ListFirewallDomainLists(ListFirewallDomainListsRequest request) 
        {
            return new ListFirewallDomainListsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFirewallDomains operation
        ///</summary>
        public IListFirewallDomainsPaginator ListFirewallDomains(ListFirewallDomainsRequest request) 
        {
            return new ListFirewallDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFirewallRuleGroupAssociations operation
        ///</summary>
        public IListFirewallRuleGroupAssociationsPaginator ListFirewallRuleGroupAssociations(ListFirewallRuleGroupAssociationsRequest request) 
        {
            return new ListFirewallRuleGroupAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFirewallRuleGroups operation
        ///</summary>
        public IListFirewallRuleGroupsPaginator ListFirewallRuleGroups(ListFirewallRuleGroupsRequest request) 
        {
            return new ListFirewallRuleGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFirewallRules operation
        ///</summary>
        public IListFirewallRulesPaginator ListFirewallRules(ListFirewallRulesRequest request) 
        {
            return new ListFirewallRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOutpostResolvers operation
        ///</summary>
        public IListOutpostResolversPaginator ListOutpostResolvers(ListOutpostResolversRequest request) 
        {
            return new ListOutpostResolversPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResolverConfigs operation
        ///</summary>
        public IListResolverConfigsPaginator ListResolverConfigs(ListResolverConfigsRequest request) 
        {
            return new ListResolverConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResolverDnssecConfigs operation
        ///</summary>
        public IListResolverDnssecConfigsPaginator ListResolverDnssecConfigs(ListResolverDnssecConfigsRequest request) 
        {
            return new ListResolverDnssecConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResolverEndpointIpAddresses operation
        ///</summary>
        public IListResolverEndpointIpAddressesPaginator ListResolverEndpointIpAddresses(ListResolverEndpointIpAddressesRequest request) 
        {
            return new ListResolverEndpointIpAddressesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResolverEndpoints operation
        ///</summary>
        public IListResolverEndpointsPaginator ListResolverEndpoints(ListResolverEndpointsRequest request) 
        {
            return new ListResolverEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResolverQueryLogConfigAssociations operation
        ///</summary>
        public IListResolverQueryLogConfigAssociationsPaginator ListResolverQueryLogConfigAssociations(ListResolverQueryLogConfigAssociationsRequest request) 
        {
            return new ListResolverQueryLogConfigAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResolverQueryLogConfigs operation
        ///</summary>
        public IListResolverQueryLogConfigsPaginator ListResolverQueryLogConfigs(ListResolverQueryLogConfigsRequest request) 
        {
            return new ListResolverQueryLogConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResolverRuleAssociations operation
        ///</summary>
        public IListResolverRuleAssociationsPaginator ListResolverRuleAssociations(ListResolverRuleAssociationsRequest request) 
        {
            return new ListResolverRuleAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResolverRules operation
        ///</summary>
        public IListResolverRulesPaginator ListResolverRules(ListResolverRulesRequest request) 
        {
            return new ListResolverRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }
    }
}