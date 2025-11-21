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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.GeoPlaces.Model;
using Amazon.GeoPlaces.Model.Internal.MarshallTransformations;
using Amazon.GeoPlaces.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.GeoPlaces
{
    /// <summary>
    /// <para>Implementation for accessing GeoPlaces</para>
    ///
    /// The Places API enables powerful location search and geocoding capabilities for your
    /// applications, offering global coverage with rich, detailed information. Key features
    /// include: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Forward and reverse geocoding for addresses and coordinates
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Comprehensive place searches with detailed information, including:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Business names and addresses
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Contact information
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Hours of operation
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// POI (Points of Interest) categories
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Food types for restaurants
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Chain affiliation for relevant businesses
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Global data coverage with a wide range of POI categories
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Regular data updates to ensure accuracy and relevance
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonGeoPlacesClient : AmazonServiceClient, IAmazonGeoPlaces
    {
        private static IServiceMetadata serviceMetadata = new AmazonGeoPlacesMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonGeoPlacesClient with the credentials loaded from the application's
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
        public AmazonGeoPlacesClient()
            : base(new AmazonGeoPlacesConfig()) { }

        /// <summary>
        /// Constructs AmazonGeoPlacesClient with the credentials loaded from the application's
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
        public AmazonGeoPlacesClient(RegionEndpoint region)
            : base(new AmazonGeoPlacesConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGeoPlacesClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGeoPlacesClient Configuration Object</param>
        public AmazonGeoPlacesClient(AmazonGeoPlacesConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonGeoPlacesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGeoPlacesClient(AWSCredentials credentials)
            : this(credentials, new AmazonGeoPlacesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGeoPlacesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGeoPlacesClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGeoPlacesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGeoPlacesClient with AWS Credentials and an
        /// AmazonGeoPlacesClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGeoPlacesClient Configuration Object</param>
        public AmazonGeoPlacesClient(AWSCredentials credentials, AmazonGeoPlacesConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGeoPlacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGeoPlacesClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGeoPlacesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGeoPlacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGeoPlacesClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGeoPlacesConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGeoPlacesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGeoPlacesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGeoPlacesClient Configuration Object</param>
        public AmazonGeoPlacesClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGeoPlacesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGeoPlacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGeoPlacesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGeoPlacesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGeoPlacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGeoPlacesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGeoPlacesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGeoPlacesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGeoPlacesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGeoPlacesClient Configuration Object</param>
        public AmazonGeoPlacesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGeoPlacesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGeoPlacesEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGeoPlacesAuthSchemeHandler());
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


        #region  Autocomplete

        internal virtual AutocompleteResponse Autocomplete(AutocompleteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AutocompleteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AutocompleteResponseUnmarshaller.Instance;

            return Invoke<AutocompleteResponse>(request, options);
        }



        /// <summary>
        /// <c>Autocomplete</c> completes potential places and addresses as the user types, based
        /// on the partial input. The API enhances the efficiency and accuracy of address by completing
        /// query based on a few entered keystrokes. It helps you by completing partial queries
        /// with valid address completion. Also, the API supports the filtering of results based
        /// on geographic location, country, or specific place types, and can be tailored using
        /// optional parameters like language and political views.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Autocomplete service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Autocomplete service method, as returned by GeoPlaces.</returns>
        /// <exception cref="Amazon.GeoPlaces.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/Autocomplete">REST API Reference for Autocomplete Operation</seealso>
        public virtual Task<AutocompleteResponse> AutocompleteAsync(AutocompleteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AutocompleteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AutocompleteResponseUnmarshaller.Instance;

            return InvokeAsync<AutocompleteResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  Geocode

        internal virtual GeocodeResponse Geocode(GeocodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GeocodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GeocodeResponseUnmarshaller.Instance;

            return Invoke<GeocodeResponse>(request, options);
        }



        /// <summary>
        /// <c>Geocode</c> converts a textual address or place into geographic coordinates. You
        /// can obtain geographic coordinates, address component, and other related information.
        /// It supports flexible queries, including free-form text or structured queries with
        /// components like street names, postal codes, and regions. The Geocode API can also
        /// provide additional features such as time zone information and the inclusion of political
        /// views.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Geocode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Geocode service method, as returned by GeoPlaces.</returns>
        /// <exception cref="Amazon.GeoPlaces.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/Geocode">REST API Reference for Geocode Operation</seealso>
        public virtual Task<GeocodeResponse> GeocodeAsync(GeocodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GeocodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GeocodeResponseUnmarshaller.Instance;

            return InvokeAsync<GeocodeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPlace

        internal virtual GetPlaceResponse GetPlace(GetPlaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPlaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaceResponseUnmarshaller.Instance;

            return Invoke<GetPlaceResponse>(request, options);
        }



        /// <summary>
        /// <c>GetPlace</c> finds a place by its unique ID. A <c>PlaceId</c> is returned by other
        /// place operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPlace service method, as returned by GeoPlaces.</returns>
        /// <exception cref="Amazon.GeoPlaces.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/GetPlace">REST API Reference for GetPlace Operation</seealso>
        public virtual Task<GetPlaceResponse> GetPlaceAsync(GetPlaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPlaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaceResponseUnmarshaller.Instance;

            return InvokeAsync<GetPlaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ReverseGeocode

        internal virtual ReverseGeocodeResponse ReverseGeocode(ReverseGeocodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReverseGeocodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReverseGeocodeResponseUnmarshaller.Instance;

            return Invoke<ReverseGeocodeResponse>(request, options);
        }



        /// <summary>
        /// <c>ReverseGeocode</c> converts geographic coordinates into a human-readable address
        /// or place. You can obtain address component, and other related information such as
        /// place type, category, street information. The Reverse Geocode API supports filtering
        /// to on place type so that you can refine result based on your need. Also, The Reverse
        /// Geocode API can also provide additional features such as time zone information and
        /// the inclusion of political views.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReverseGeocode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReverseGeocode service method, as returned by GeoPlaces.</returns>
        /// <exception cref="Amazon.GeoPlaces.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/ReverseGeocode">REST API Reference for ReverseGeocode Operation</seealso>
        public virtual Task<ReverseGeocodeResponse> ReverseGeocodeAsync(ReverseGeocodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReverseGeocodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReverseGeocodeResponseUnmarshaller.Instance;

            return InvokeAsync<ReverseGeocodeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchNearby

        internal virtual SearchNearbyResponse SearchNearby(SearchNearbyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchNearbyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchNearbyResponseUnmarshaller.Instance;

            return Invoke<SearchNearbyResponse>(request, options);
        }



        /// <summary>
        /// <c>SearchNearby</c> queries for points of interest within a radius from a central
        /// coordinates, returning place results with optional filters such as categories, business
        /// chains, food types and more. The API returns details such as a place name, address,
        /// phone, category, food type, contact, opening hours. Also, the API can return phonemes,
        /// time zones and more based on requested parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchNearby service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchNearby service method, as returned by GeoPlaces.</returns>
        /// <exception cref="Amazon.GeoPlaces.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/SearchNearby">REST API Reference for SearchNearby Operation</seealso>
        public virtual Task<SearchNearbyResponse> SearchNearbyAsync(SearchNearbyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchNearbyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchNearbyResponseUnmarshaller.Instance;

            return InvokeAsync<SearchNearbyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchText

        internal virtual SearchTextResponse SearchText(SearchTextRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTextResponseUnmarshaller.Instance;

            return Invoke<SearchTextResponse>(request, options);
        }



        /// <summary>
        /// <c>SearchText</c> searches for geocode and place information. You can then complete
        /// a follow-up query suggested from the <c>Suggest</c> API via a query id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchText service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchText service method, as returned by GeoPlaces.</returns>
        /// <exception cref="Amazon.GeoPlaces.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/SearchText">REST API Reference for SearchText Operation</seealso>
        public virtual Task<SearchTextResponse> SearchTextAsync(SearchTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTextResponseUnmarshaller.Instance;

            return InvokeAsync<SearchTextResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  Suggest

        internal virtual SuggestResponse Suggest(SuggestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SuggestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuggestResponseUnmarshaller.Instance;

            return Invoke<SuggestResponse>(request, options);
        }



        /// <summary>
        /// <c>Suggest</c> provides intelligent predictions or recommendations based on the user's
        /// input or context, such as relevant places, points of interest, query terms or search
        /// category. It is designed to help users find places or point of interests candidates
        /// or identify a follow on query based on incomplete or misspelled queries. It returns
        /// a list of possible matches or refinements that can be used to formulate a more accurate
        /// query. Users can select the most appropriate suggestion and use it for further searching.
        /// The API provides options for filtering results by location and other attributes, and
        /// allows for additional features like phonemes and timezones. The response includes
        /// refined query terms and detailed place information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Suggest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Suggest service method, as returned by GeoPlaces.</returns>
        /// <exception cref="Amazon.GeoPlaces.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.GeoPlaces.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/Suggest">REST API Reference for Suggest Operation</seealso>
        public virtual Task<SuggestResponse> SuggestAsync(SuggestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SuggestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuggestResponseUnmarshaller.Instance;

            return InvokeAsync<SuggestResponse>(request, options, cancellationToken);
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