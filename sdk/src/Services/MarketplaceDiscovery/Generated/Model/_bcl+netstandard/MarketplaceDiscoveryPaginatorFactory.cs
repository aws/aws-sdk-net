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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Paginators for the MarketplaceDiscovery service
    ///</summary>
    public class MarketplaceDiscoveryPaginatorFactory : IMarketplaceDiscoveryPaginatorFactory
    {
        private readonly IAmazonMarketplaceDiscovery client;

        internal MarketplaceDiscoveryPaginatorFactory(IAmazonMarketplaceDiscovery client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetOfferTerms operation
        ///</summary>
        public IGetOfferTermsPaginator GetOfferTerms(GetOfferTermsRequest request) 
        {
            return new GetOfferTermsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFulfillmentOptions operation
        ///</summary>
        public IListFulfillmentOptionsPaginator ListFulfillmentOptions(ListFulfillmentOptionsRequest request) 
        {
            return new ListFulfillmentOptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPurchaseOptions operation
        ///</summary>
        public IListPurchaseOptionsPaginator ListPurchaseOptions(ListPurchaseOptionsRequest request) 
        {
            return new ListPurchaseOptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchFacets operation
        ///</summary>
        public ISearchFacetsPaginator SearchFacets(SearchFacetsRequest request) 
        {
            return new SearchFacetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchListings operation
        ///</summary>
        public ISearchListingsPaginator SearchListings(SearchListingsRequest request) 
        {
            return new SearchListingsPaginator(this.client, request);
        }
    }
}