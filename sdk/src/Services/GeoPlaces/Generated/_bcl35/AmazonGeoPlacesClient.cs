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
        /// Initiates the asynchronous execution of the Autocomplete operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Autocomplete operation on AmazonGeoPlacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAutocomplete
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/Autocomplete">REST API Reference for Autocomplete Operation</seealso>
        public virtual IAsyncResult BeginAutocomplete(AutocompleteRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AutocompleteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AutocompleteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Autocomplete operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAutocomplete.</param>
        /// 
        /// <returns>Returns a  AutocompleteResult from GeoPlaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/Autocomplete">REST API Reference for Autocomplete Operation</seealso>
        public virtual AutocompleteResponse EndAutocomplete(IAsyncResult asyncResult)
        {
            return EndInvoke<AutocompleteResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the Geocode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Geocode operation on AmazonGeoPlacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGeocode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/Geocode">REST API Reference for Geocode Operation</seealso>
        public virtual IAsyncResult BeginGeocode(GeocodeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GeocodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GeocodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Geocode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGeocode.</param>
        /// 
        /// <returns>Returns a  GeocodeResult from GeoPlaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/Geocode">REST API Reference for Geocode Operation</seealso>
        public virtual GeocodeResponse EndGeocode(IAsyncResult asyncResult)
        {
            return EndInvoke<GeocodeResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetPlace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlace operation on AmazonGeoPlacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/GetPlace">REST API Reference for GetPlace Operation</seealso>
        public virtual IAsyncResult BeginGetPlace(GetPlaceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlace.</param>
        /// 
        /// <returns>Returns a  GetPlaceResult from GeoPlaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/GetPlace">REST API Reference for GetPlace Operation</seealso>
        public virtual GetPlaceResponse EndGetPlace(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPlaceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ReverseGeocode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReverseGeocode operation on AmazonGeoPlacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReverseGeocode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/ReverseGeocode">REST API Reference for ReverseGeocode Operation</seealso>
        public virtual IAsyncResult BeginReverseGeocode(ReverseGeocodeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReverseGeocodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReverseGeocodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReverseGeocode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReverseGeocode.</param>
        /// 
        /// <returns>Returns a  ReverseGeocodeResult from GeoPlaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/ReverseGeocode">REST API Reference for ReverseGeocode Operation</seealso>
        public virtual ReverseGeocodeResponse EndReverseGeocode(IAsyncResult asyncResult)
        {
            return EndInvoke<ReverseGeocodeResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the SearchNearby operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchNearby operation on AmazonGeoPlacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchNearby
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/SearchNearby">REST API Reference for SearchNearby Operation</seealso>
        public virtual IAsyncResult BeginSearchNearby(SearchNearbyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchNearbyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchNearbyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchNearby operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchNearby.</param>
        /// 
        /// <returns>Returns a  SearchNearbyResult from GeoPlaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/SearchNearby">REST API Reference for SearchNearby Operation</seealso>
        public virtual SearchNearbyResponse EndSearchNearby(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchNearbyResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the SearchText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchText operation on AmazonGeoPlacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchText
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/SearchText">REST API Reference for SearchText Operation</seealso>
        public virtual IAsyncResult BeginSearchText(SearchTextRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTextResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchText operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchText.</param>
        /// 
        /// <returns>Returns a  SearchTextResult from GeoPlaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/SearchText">REST API Reference for SearchText Operation</seealso>
        public virtual SearchTextResponse EndSearchText(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchTextResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the Suggest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Suggest operation on AmazonGeoPlacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSuggest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/Suggest">REST API Reference for Suggest Operation</seealso>
        public virtual IAsyncResult BeginSuggest(SuggestRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SuggestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuggestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Suggest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSuggest.</param>
        /// 
        /// <returns>Returns a  SuggestResult from GeoPlaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/Suggest">REST API Reference for Suggest Operation</seealso>
        public virtual SuggestResponse EndSuggest(IAsyncResult asyncResult)
        {
            return EndInvoke<SuggestResponse>(asyncResult);
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