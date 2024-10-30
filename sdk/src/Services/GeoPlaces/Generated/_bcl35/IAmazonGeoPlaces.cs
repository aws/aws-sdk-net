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

using Amazon.Runtime;
using Amazon.GeoPlaces.Model;

#pragma warning disable CS1570
namespace Amazon.GeoPlaces
{
    /// <summary>
    /// <para>Interface for accessing GeoPlaces</para>
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
    public partial interface IAmazonGeoPlaces : IAmazonService, IDisposable
    {




        
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
        AutocompleteResponse Autocomplete(AutocompleteRequest request);

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
        IAsyncResult BeginAutocomplete(AutocompleteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Autocomplete operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAutocomplete.</param>
        /// 
        /// <returns>Returns a  AutocompleteResult from GeoPlaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/Autocomplete">REST API Reference for Autocomplete Operation</seealso>
        AutocompleteResponse EndAutocomplete(IAsyncResult asyncResult);

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
        GeocodeResponse Geocode(GeocodeRequest request);

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
        IAsyncResult BeginGeocode(GeocodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Geocode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGeocode.</param>
        /// 
        /// <returns>Returns a  GeocodeResult from GeoPlaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/Geocode">REST API Reference for Geocode Operation</seealso>
        GeocodeResponse EndGeocode(IAsyncResult asyncResult);

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
        GetPlaceResponse GetPlace(GetPlaceRequest request);

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
        IAsyncResult BeginGetPlace(GetPlaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlace.</param>
        /// 
        /// <returns>Returns a  GetPlaceResult from GeoPlaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/GetPlace">REST API Reference for GetPlace Operation</seealso>
        GetPlaceResponse EndGetPlace(IAsyncResult asyncResult);

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
        ReverseGeocodeResponse ReverseGeocode(ReverseGeocodeRequest request);

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
        IAsyncResult BeginReverseGeocode(ReverseGeocodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReverseGeocode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReverseGeocode.</param>
        /// 
        /// <returns>Returns a  ReverseGeocodeResult from GeoPlaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/ReverseGeocode">REST API Reference for ReverseGeocode Operation</seealso>
        ReverseGeocodeResponse EndReverseGeocode(IAsyncResult asyncResult);

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
        SearchNearbyResponse SearchNearby(SearchNearbyRequest request);

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
        IAsyncResult BeginSearchNearby(SearchNearbyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchNearby operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchNearby.</param>
        /// 
        /// <returns>Returns a  SearchNearbyResult from GeoPlaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/SearchNearby">REST API Reference for SearchNearby Operation</seealso>
        SearchNearbyResponse EndSearchNearby(IAsyncResult asyncResult);

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
        SearchTextResponse SearchText(SearchTextRequest request);

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
        IAsyncResult BeginSearchText(SearchTextRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchText operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchText.</param>
        /// 
        /// <returns>Returns a  SearchTextResult from GeoPlaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/SearchText">REST API Reference for SearchText Operation</seealso>
        SearchTextResponse EndSearchText(IAsyncResult asyncResult);

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
        SuggestResponse Suggest(SuggestRequest request);

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
        IAsyncResult BeginSuggest(SuggestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Suggest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSuggest.</param>
        /// 
        /// <returns>Returns a  SuggestResult from GeoPlaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-places-2020-11-19/Suggest">REST API Reference for Suggest Operation</seealso>
        SuggestResponse EndSuggest(IAsyncResult asyncResult);

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