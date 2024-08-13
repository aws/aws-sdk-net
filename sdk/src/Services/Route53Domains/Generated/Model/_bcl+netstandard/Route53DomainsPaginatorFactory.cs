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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Paginators for the Route53Domains service
    ///</summary>
    public class Route53DomainsPaginatorFactory : IRoute53DomainsPaginatorFactory
    {
        private readonly IAmazonRoute53Domains client;

        internal Route53DomainsPaginatorFactory(IAmazonRoute53Domains client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        public IListDomainsPaginator ListDomains(ListDomainsRequest request) 
        {
            return new ListDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOperations operation
        ///</summary>
        public IListOperationsPaginator ListOperations(ListOperationsRequest request) 
        {
            return new ListOperationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPrices operation
        ///</summary>
        public IListPricesPaginator ListPrices(ListPricesRequest request) 
        {
            return new ListPricesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ViewBilling operation
        ///</summary>
        public IViewBillingPaginator ViewBilling(ViewBillingRequest request) 
        {
            return new ViewBillingPaginator(this.client, request);
        }
    }
}