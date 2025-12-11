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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53GlobalResolver.Model
{
    /// <summary>
    /// Paginators for the Route53GlobalResolver service
    ///</summary>
    public class Route53GlobalResolverPaginatorFactory : IRoute53GlobalResolverPaginatorFactory
    {
        private readonly IAmazonRoute53GlobalResolver client;

        internal Route53GlobalResolverPaginatorFactory(IAmazonRoute53GlobalResolver client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccessSources operation
        ///</summary>
        public IListAccessSourcesPaginator ListAccessSources(ListAccessSourcesRequest request) 
        {
            return new ListAccessSourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccessTokens operation
        ///</summary>
        public IListAccessTokensPaginator ListAccessTokens(ListAccessTokensRequest request) 
        {
            return new ListAccessTokensPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDNSViews operation
        ///</summary>
        public IListDNSViewsPaginator ListDNSViews(ListDNSViewsRequest request) 
        {
            return new ListDNSViewsPaginator(this.client, request);
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
        /// Paginator for ListFirewallRules operation
        ///</summary>
        public IListFirewallRulesPaginator ListFirewallRules(ListFirewallRulesRequest request) 
        {
            return new ListFirewallRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGlobalResolvers operation
        ///</summary>
        public IListGlobalResolversPaginator ListGlobalResolvers(ListGlobalResolversRequest request) 
        {
            return new ListGlobalResolversPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHostedZoneAssociations operation
        ///</summary>
        public IListHostedZoneAssociationsPaginator ListHostedZoneAssociations(ListHostedZoneAssociationsRequest request) 
        {
            return new ListHostedZoneAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedFirewallDomainLists operation
        ///</summary>
        public IListManagedFirewallDomainListsPaginator ListManagedFirewallDomainLists(ListManagedFirewallDomainListsRequest request) 
        {
            return new ListManagedFirewallDomainListsPaginator(this.client, request);
        }
    }
}