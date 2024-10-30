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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGeoPlacesConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGeoPlacesConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

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
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGeoPlacesEndpointResolver());
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


        /// <summary>
        /// The autocomplete operation speeds up and increases the accuracy of entering addresses
        /// by providing a list of address candidates matching a partially entered address. Results
        /// are sorted from most to least matching. Filtering and biasing can be used to increase
        /// the relevance of the results if additional search context is known
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Autocomplete service method.</param>
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
        public virtual AutocompleteResponse Autocomplete(AutocompleteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AutocompleteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AutocompleteResponseUnmarshaller.Instance;

            return Invoke<AutocompleteResponse>(request, options);
        }


        /// <summary>
        /// The autocomplete operation speeds up and increases the accuracy of entering addresses
        /// by providing a list of address candidates matching a partially entered address. Results
        /// are sorted from most to least matching. Filtering and biasing can be used to increase
        /// the relevance of the results if additional search context is known
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
            var options = new InvokeOptions();
            options.RequestMarshaller = AutocompleteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AutocompleteResponseUnmarshaller.Instance;
            
            return InvokeAsync<AutocompleteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Geocode


        /// <summary>
        /// The <c>Geocode</c> action allows you to obtain coordinates, addresses, and other information
        /// about places.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Geocode service method.</param>
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
        public virtual GeocodeResponse Geocode(GeocodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GeocodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GeocodeResponseUnmarshaller.Instance;

            return Invoke<GeocodeResponse>(request, options);
        }


        /// <summary>
        /// The <c>Geocode</c> action allows you to obtain coordinates, addresses, and other information
        /// about places.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GeocodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GeocodeResponseUnmarshaller.Instance;
            
            return InvokeAsync<GeocodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPlace


        /// <summary>
        /// Finds a place by its unique ID. A <c>PlaceId</c> is returned by other place operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlace service method.</param>
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
        public virtual GetPlaceResponse GetPlace(GetPlaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaceResponseUnmarshaller.Instance;

            return Invoke<GetPlaceResponse>(request, options);
        }


        /// <summary>
        /// Finds a place by its unique ID. A <c>PlaceId</c> is returned by other place operations.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPlaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReverseGeocode


        /// <summary>
        /// The <c>ReverseGeocode</c> operation allows you to retrieve addresses and place information
        /// from coordinates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReverseGeocode service method.</param>
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
        public virtual ReverseGeocodeResponse ReverseGeocode(ReverseGeocodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReverseGeocodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReverseGeocodeResponseUnmarshaller.Instance;

            return Invoke<ReverseGeocodeResponse>(request, options);
        }


        /// <summary>
        /// The <c>ReverseGeocode</c> operation allows you to retrieve addresses and place information
        /// from coordinates.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ReverseGeocodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReverseGeocodeResponseUnmarshaller.Instance;
            
            return InvokeAsync<ReverseGeocodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchNearby


        /// <summary>
        /// Search nearby a specified location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchNearby service method.</param>
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
        public virtual SearchNearbyResponse SearchNearby(SearchNearbyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchNearbyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchNearbyResponseUnmarshaller.Instance;

            return Invoke<SearchNearbyResponse>(request, options);
        }


        /// <summary>
        /// Search nearby a specified location.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchNearbyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchNearbyResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchNearbyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchText


        /// <summary>
        /// Use the <c>SearchText</c> operation to search for geocode and place information. You
        /// can then complete a follow-up query suggested from the <c>Suggest</c> API via a query
        /// id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchText service method.</param>
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
        public virtual SearchTextResponse SearchText(SearchTextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTextResponseUnmarshaller.Instance;

            return Invoke<SearchTextResponse>(request, options);
        }


        /// <summary>
        /// Use the <c>SearchText</c> operation to search for geocode and place information. You
        /// can then complete a follow-up query suggested from the <c>Suggest</c> API via a query
        /// id.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTextResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchTextResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Suggest


        /// <summary>
        /// The <c>Suggest</c> operation finds addresses or place candidates based on incomplete
        /// or misspelled queries. You then select the best query to submit based on the returned
        /// results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Suggest service method.</param>
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
        public virtual SuggestResponse Suggest(SuggestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SuggestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuggestResponseUnmarshaller.Instance;

            return Invoke<SuggestResponse>(request, options);
        }


        /// <summary>
        /// The <c>Suggest</c> operation finds addresses or place candidates based on incomplete
        /// or misspelled queries. You then select the best query to submit based on the returned
        /// results.
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
            var options = new InvokeOptions();
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonGeoPlacesEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}