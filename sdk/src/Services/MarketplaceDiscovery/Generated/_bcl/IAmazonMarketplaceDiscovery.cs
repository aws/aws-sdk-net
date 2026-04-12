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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MarketplaceDiscovery.Model;

#pragma warning disable CS1570
namespace Amazon.MarketplaceDiscovery
{
    /// <summary>
    /// <para>Interface for accessing MarketplaceDiscovery</para>
    ///
    /// The AWS Marketplace Discovery API provides programmatic access to the AWS Marketplace
    /// catalog, including searching and browsing listings, retrieving product details and
    /// fulfillment options, and accessing public and private offer pricing and terms.
    /// </summary>
    public partial interface IAmazonMarketplaceDiscovery : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMarketplaceDiscoveryPaginatorFactory Paginators { get; }

        
        #region  GetListing


        /// <summary>
        /// Provides details about a listing, such as descriptions, badges, categories, pricing
        /// model summaries, reviews, and associated products and offers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListing service method.</param>
        /// 
        /// <returns>The response from the GetListing service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/GetListing">REST API Reference for GetListing Operation</seealso>
        GetListingResponse GetListing(GetListingRequest request);



        /// <summary>
        /// Provides details about a listing, such as descriptions, badges, categories, pricing
        /// model summaries, reviews, and associated products and offers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetListing service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/GetListing">REST API Reference for GetListing Operation</seealso>
        Task<GetListingResponse> GetListingAsync(GetListingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOffer


        /// <summary>
        /// Provides details about an offer, such as the pricing model, seller of record, availability
        /// dates, badges, and associated products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOffer service method.</param>
        /// 
        /// <returns>The response from the GetOffer service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/GetOffer">REST API Reference for GetOffer Operation</seealso>
        GetOfferResponse GetOffer(GetOfferRequest request);



        /// <summary>
        /// Provides details about an offer, such as the pricing model, seller of record, availability
        /// dates, badges, and associated products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOffer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOffer service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/GetOffer">REST API Reference for GetOffer Operation</seealso>
        Task<GetOfferResponse> GetOfferAsync(GetOfferRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOfferSet


        /// <summary>
        /// Provides details about an offer set, which is a bundle of offers across multiple products.
        /// Includes the seller, availability dates, buyer notes, and associated product-offer
        /// pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOfferSet service method.</param>
        /// 
        /// <returns>The response from the GetOfferSet service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/GetOfferSet">REST API Reference for GetOfferSet Operation</seealso>
        GetOfferSetResponse GetOfferSet(GetOfferSetRequest request);



        /// <summary>
        /// Provides details about an offer set, which is a bundle of offers across multiple products.
        /// Includes the seller, availability dates, buyer notes, and associated product-offer
        /// pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOfferSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOfferSet service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/GetOfferSet">REST API Reference for GetOfferSet Operation</seealso>
        Task<GetOfferSetResponse> GetOfferSetAsync(GetOfferSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOfferTerms


        /// <summary>
        /// Returns the terms attached to an offer, such as pricing terms (usage-based, contract,
        /// BYOL, free trial), legal terms, payment schedules, validity terms, support terms,
        /// and renewal terms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOfferTerms service method.</param>
        /// 
        /// <returns>The response from the GetOfferTerms service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/GetOfferTerms">REST API Reference for GetOfferTerms Operation</seealso>
        GetOfferTermsResponse GetOfferTerms(GetOfferTermsRequest request);



        /// <summary>
        /// Returns the terms attached to an offer, such as pricing terms (usage-based, contract,
        /// BYOL, free trial), legal terms, payment schedules, validity terms, support terms,
        /// and renewal terms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOfferTerms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOfferTerms service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/GetOfferTerms">REST API Reference for GetOfferTerms Operation</seealso>
        Task<GetOfferTermsResponse> GetOfferTermsAsync(GetOfferTermsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetProduct


        /// <summary>
        /// Provides details about a product, such as descriptions, highlights, categories, fulfillment
        /// option summaries, promotional media, and seller engagement options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProduct service method.</param>
        /// 
        /// <returns>The response from the GetProduct service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/GetProduct">REST API Reference for GetProduct Operation</seealso>
        GetProductResponse GetProduct(GetProductRequest request);



        /// <summary>
        /// Provides details about a product, such as descriptions, highlights, categories, fulfillment
        /// option summaries, promotional media, and seller engagement options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProduct service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/GetProduct">REST API Reference for GetProduct Operation</seealso>
        Task<GetProductResponse> GetProductAsync(GetProductRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFulfillmentOptions


        /// <summary>
        /// Returns the fulfillment options available for a product, including deployment details
        /// such as version information, operating systems, usage instructions, and release notes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFulfillmentOptions service method.</param>
        /// 
        /// <returns>The response from the ListFulfillmentOptions service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/ListFulfillmentOptions">REST API Reference for ListFulfillmentOptions Operation</seealso>
        ListFulfillmentOptionsResponse ListFulfillmentOptions(ListFulfillmentOptionsRequest request);



        /// <summary>
        /// Returns the fulfillment options available for a product, including deployment details
        /// such as version information, operating systems, usage instructions, and release notes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFulfillmentOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFulfillmentOptions service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/ListFulfillmentOptions">REST API Reference for ListFulfillmentOptions Operation</seealso>
        Task<ListFulfillmentOptionsResponse> ListFulfillmentOptionsAsync(ListFulfillmentOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPurchaseOptions


        /// <summary>
        /// Returns the purchase options (offers and offer sets) available to the buyer. You can
        /// filter results by product, seller, purchase option type, visibility scope, and availability
        /// status.
        /// 
        ///  <note> 
        /// <para>
        /// You must include at least one of the following filters in the request: a <c>PRODUCT_ID</c>
        /// filter to specify the product for which to retrieve purchase options, or a <c>VISIBILITY_SCOPE</c>
        /// filter to retrieve purchase options by visibility.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPurchaseOptions service method.</param>
        /// 
        /// <returns>The response from the ListPurchaseOptions service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/ListPurchaseOptions">REST API Reference for ListPurchaseOptions Operation</seealso>
        ListPurchaseOptionsResponse ListPurchaseOptions(ListPurchaseOptionsRequest request);



        /// <summary>
        /// Returns the purchase options (offers and offer sets) available to the buyer. You can
        /// filter results by product, seller, purchase option type, visibility scope, and availability
        /// status.
        /// 
        ///  <note> 
        /// <para>
        /// You must include at least one of the following filters in the request: a <c>PRODUCT_ID</c>
        /// filter to specify the product for which to retrieve purchase options, or a <c>VISIBILITY_SCOPE</c>
        /// filter to retrieve purchase options by visibility.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPurchaseOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPurchaseOptions service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/ListPurchaseOptions">REST API Reference for ListPurchaseOptions Operation</seealso>
        Task<ListPurchaseOptionsResponse> ListPurchaseOptionsAsync(ListPurchaseOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchFacets


        /// <summary>
        /// Returns available facet values for filtering listings, such as categories, pricing
        /// models, fulfillment option types, publishers, and customer ratings. Each facet value
        /// includes a count of matching listings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFacets service method.</param>
        /// 
        /// <returns>The response from the SearchFacets service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/SearchFacets">REST API Reference for SearchFacets Operation</seealso>
        SearchFacetsResponse SearchFacets(SearchFacetsRequest request);



        /// <summary>
        /// Returns available facet values for filtering listings, such as categories, pricing
        /// models, fulfillment option types, publishers, and customer ratings. Each facet value
        /// includes a count of matching listings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFacets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchFacets service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/SearchFacets">REST API Reference for SearchFacets Operation</seealso>
        Task<SearchFacetsResponse> SearchFacetsAsync(SearchFacetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchListings


        /// <summary>
        /// Returns a list of product listings based on search criteria and filters. You can search
        /// by keyword, filter by category, pricing model, fulfillment type, and other attributes,
        /// and sort results by relevance or customer rating.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchListings service method.</param>
        /// 
        /// <returns>The response from the SearchListings service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/SearchListings">REST API Reference for SearchListings Operation</seealso>
        SearchListingsResponse SearchListings(SearchListingsRequest request);



        /// <summary>
        /// Returns a list of product listings based on search criteria and filters. You can search
        /// by keyword, filter by category, pricing model, fulfillment type, and other attributes,
        /// and sort results by relevance or customer rating.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchListings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchListings service method, as returned by MarketplaceDiscovery.</returns>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.InternalServerException">
        /// Unexpected error during processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDiscovery.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-discovery-2026-02-05/SearchListings">REST API Reference for SearchListings Operation</seealso>
        Task<SearchListingsResponse> SearchListingsAsync(SearchListingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}