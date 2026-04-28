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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Paginators for the MarketplaceDiscovery service
    ///</summary>
    public interface IMarketplaceDiscoveryPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetOfferTerms operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetOfferTermsPaginator GetOfferTerms(GetOfferTermsRequest request);

        /// <summary>
        /// Paginator for ListFulfillmentOptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFulfillmentOptionsPaginator ListFulfillmentOptions(ListFulfillmentOptionsRequest request);

        /// <summary>
        /// Paginator for ListPurchaseOptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPurchaseOptionsPaginator ListPurchaseOptions(ListPurchaseOptionsRequest request);

        /// <summary>
        /// Paginator for SearchFacets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        ISearchFacetsPaginator SearchFacets(SearchFacetsRequest request);

        /// <summary>
        /// Paginator for SearchListings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchListingsPaginator SearchListings(SearchListingsRequest request);
    }
}