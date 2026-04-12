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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MarketplaceDiscovery.Model;
using Amazon.MarketplaceDiscovery.Model.Internal.MarshallTransformations;
using Amazon.MarketplaceDiscovery.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.MarketplaceDiscovery
{
    /// <summary>
    /// <para>Implementation for accessing MarketplaceDiscovery</para>
    ///
    /// The AWS Marketplace Discovery API provides programmatic access to the AWS Marketplace
    /// catalog, including searching and browsing listings, retrieving product details and
    /// fulfillment options, and accessing public and private offer pricing and terms.
    /// </summary>
    public partial class AmazonMarketplaceDiscoveryClient : AmazonServiceClient, IAmazonMarketplaceDiscovery
    {
        private static IServiceMetadata serviceMetadata = new AmazonMarketplaceDiscoveryMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMarketplaceDiscoveryClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonMarketplaceDiscoveryClient()
            : base(new AmazonMarketplaceDiscoveryConfig()) { }

        /// <summary>
        /// Constructs AmazonMarketplaceDiscoveryClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceDiscoveryClient(RegionEndpoint region)
            : base(new AmazonMarketplaceDiscoveryConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMarketplaceDiscoveryClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonMarketplaceDiscoveryClient Configuration Object</param>
        public AmazonMarketplaceDiscoveryClient(AmazonMarketplaceDiscoveryConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonMarketplaceDiscoveryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMarketplaceDiscoveryClient(AWSCredentials credentials)
            : this(credentials, new AmazonMarketplaceDiscoveryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDiscoveryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceDiscoveryClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMarketplaceDiscoveryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDiscoveryClient with AWS Credentials and an
        /// AmazonMarketplaceDiscoveryClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMarketplaceDiscoveryClient Configuration Object</param>
        public AmazonMarketplaceDiscoveryClient(AWSCredentials credentials, AmazonMarketplaceDiscoveryConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDiscoveryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMarketplaceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMarketplaceDiscoveryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDiscoveryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMarketplaceDiscoveryConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDiscoveryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMarketplaceDiscoveryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMarketplaceDiscoveryClient Configuration Object</param>
        public AmazonMarketplaceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMarketplaceDiscoveryConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDiscoveryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMarketplaceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMarketplaceDiscoveryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDiscoveryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMarketplaceDiscoveryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDiscoveryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMarketplaceDiscoveryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMarketplaceDiscoveryClient Configuration Object</param>
        public AmazonMarketplaceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMarketplaceDiscoveryConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMarketplaceDiscoveryPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMarketplaceDiscoveryPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MarketplaceDiscoveryPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMarketplaceDiscoveryEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMarketplaceDiscoveryAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  GetListing

        internal virtual GetListingResponse GetListing(GetListingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetListingResponseUnmarshaller.Instance;

            return Invoke<GetListingResponse>(request, options);
        }



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
        public virtual Task<GetListingResponse> GetListingAsync(GetListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetListingResponseUnmarshaller.Instance;

            return InvokeAsync<GetListingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetOffer

        internal virtual GetOfferResponse GetOffer(GetOfferRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOfferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOfferResponseUnmarshaller.Instance;

            return Invoke<GetOfferResponse>(request, options);
        }



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
        public virtual Task<GetOfferResponse> GetOfferAsync(GetOfferRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOfferRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOfferResponseUnmarshaller.Instance;

            return InvokeAsync<GetOfferResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetOfferSet

        internal virtual GetOfferSetResponse GetOfferSet(GetOfferSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOfferSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOfferSetResponseUnmarshaller.Instance;

            return Invoke<GetOfferSetResponse>(request, options);
        }



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
        public virtual Task<GetOfferSetResponse> GetOfferSetAsync(GetOfferSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOfferSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOfferSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetOfferSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetOfferTerms

        internal virtual GetOfferTermsResponse GetOfferTerms(GetOfferTermsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOfferTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOfferTermsResponseUnmarshaller.Instance;

            return Invoke<GetOfferTermsResponse>(request, options);
        }



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
        public virtual Task<GetOfferTermsResponse> GetOfferTermsAsync(GetOfferTermsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOfferTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOfferTermsResponseUnmarshaller.Instance;

            return InvokeAsync<GetOfferTermsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetProduct

        internal virtual GetProductResponse GetProduct(GetProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductResponseUnmarshaller.Instance;

            return Invoke<GetProductResponse>(request, options);
        }



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
        public virtual Task<GetProductResponse> GetProductAsync(GetProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductResponseUnmarshaller.Instance;

            return InvokeAsync<GetProductResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFulfillmentOptions

        internal virtual ListFulfillmentOptionsResponse ListFulfillmentOptions(ListFulfillmentOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFulfillmentOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFulfillmentOptionsResponseUnmarshaller.Instance;

            return Invoke<ListFulfillmentOptionsResponse>(request, options);
        }



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
        public virtual Task<ListFulfillmentOptionsResponse> ListFulfillmentOptionsAsync(ListFulfillmentOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFulfillmentOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFulfillmentOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFulfillmentOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPurchaseOptions

        internal virtual ListPurchaseOptionsResponse ListPurchaseOptions(ListPurchaseOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPurchaseOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPurchaseOptionsResponseUnmarshaller.Instance;

            return Invoke<ListPurchaseOptionsResponse>(request, options);
        }



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
        public virtual Task<ListPurchaseOptionsResponse> ListPurchaseOptionsAsync(ListPurchaseOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPurchaseOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPurchaseOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPurchaseOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchFacets

        internal virtual SearchFacetsResponse SearchFacets(SearchFacetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchFacetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFacetsResponseUnmarshaller.Instance;

            return Invoke<SearchFacetsResponse>(request, options);
        }



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
        public virtual Task<SearchFacetsResponse> SearchFacetsAsync(SearchFacetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchFacetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFacetsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchFacetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchListings

        internal virtual SearchListingsResponse SearchListings(SearchListingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchListingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchListingsResponseUnmarshaller.Instance;

            return Invoke<SearchListingsResponse>(request, options);
        }



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
        public virtual Task<SearchListingsResponse> SearchListingsAsync(SearchListingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchListingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchListingsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchListingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}