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
 * Do not modify this file. This file is generated from the geo-maps-2020-11-19.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GeoMaps.Model;

#pragma warning disable CS1570
namespace Amazon.GeoMaps
{
    /// <summary>
    /// <para>Interface for accessing GeoMaps</para>
    ///
    /// Integrate high-quality base map data into your applications using <a href="https://maplibre.org">MapLibre</a>.
    /// Capabilities include: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Access to comprehensive base map data, allowing you to tailor the map display to your
    /// specific needs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Multiple pre-designed map styles suited for various application types, such as navigation,
    /// logistics, or data visualization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Generation of static map images for scenarios where interactive maps aren't suitable,
    /// such as:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Embedding in emails or documents
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Displaying in low-bandwidth environments
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Creating printable maps
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Enhancing application performance by reducing client-side rendering
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial interface IAmazonGeoMaps : IAmazonService, IDisposable
    {




        
        #region  GetGlyphs


        /// <summary>
        /// Returns the map's glyphs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlyphs service method.</param>
        /// 
        /// <returns>The response from the GetGlyphs service method, as returned by GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetGlyphs">REST API Reference for GetGlyphs Operation</seealso>
        GetGlyphsResponse GetGlyphs(GetGlyphsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGlyphs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGlyphs operation on AmazonGeoMapsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGlyphs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetGlyphs">REST API Reference for GetGlyphs Operation</seealso>
        IAsyncResult BeginGetGlyphs(GetGlyphsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGlyphs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGlyphs.</param>
        /// 
        /// <returns>Returns a  GetGlyphsResult from GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetGlyphs">REST API Reference for GetGlyphs Operation</seealso>
        GetGlyphsResponse EndGetGlyphs(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSprites


        /// <summary>
        /// Returns the map's sprites.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSprites service method.</param>
        /// 
        /// <returns>The response from the GetSprites service method, as returned by GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetSprites">REST API Reference for GetSprites Operation</seealso>
        GetSpritesResponse GetSprites(GetSpritesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSprites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSprites operation on AmazonGeoMapsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSprites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetSprites">REST API Reference for GetSprites Operation</seealso>
        IAsyncResult BeginGetSprites(GetSpritesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSprites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSprites.</param>
        /// 
        /// <returns>Returns a  GetSpritesResult from GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetSprites">REST API Reference for GetSprites Operation</seealso>
        GetSpritesResponse EndGetSprites(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStaticMap


        /// <summary>
        /// Provides high-quality static map images with customizable options. You can modify
        /// the map's appearance and overlay additional information. It's an ideal solution for
        /// applications requiring tailored static map snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStaticMap service method.</param>
        /// 
        /// <returns>The response from the GetStaticMap service method, as returned by GeoMaps.</returns>
        /// <exception cref="Amazon.GeoMaps.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.GeoMaps.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.GeoMaps.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.GeoMaps.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetStaticMap">REST API Reference for GetStaticMap Operation</seealso>
        GetStaticMapResponse GetStaticMap(GetStaticMapRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStaticMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStaticMap operation on AmazonGeoMapsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStaticMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetStaticMap">REST API Reference for GetStaticMap Operation</seealso>
        IAsyncResult BeginGetStaticMap(GetStaticMapRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStaticMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStaticMap.</param>
        /// 
        /// <returns>Returns a  GetStaticMapResult from GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetStaticMap">REST API Reference for GetStaticMap Operation</seealso>
        GetStaticMapResponse EndGetStaticMap(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStyleDescriptor


        /// <summary>
        /// Returns information about the style.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStyleDescriptor service method.</param>
        /// 
        /// <returns>The response from the GetStyleDescriptor service method, as returned by GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetStyleDescriptor">REST API Reference for GetStyleDescriptor Operation</seealso>
        GetStyleDescriptorResponse GetStyleDescriptor(GetStyleDescriptorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStyleDescriptor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStyleDescriptor operation on AmazonGeoMapsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStyleDescriptor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetStyleDescriptor">REST API Reference for GetStyleDescriptor Operation</seealso>
        IAsyncResult BeginGetStyleDescriptor(GetStyleDescriptorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStyleDescriptor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStyleDescriptor.</param>
        /// 
        /// <returns>Returns a  GetStyleDescriptorResult from GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetStyleDescriptor">REST API Reference for GetStyleDescriptor Operation</seealso>
        GetStyleDescriptorResponse EndGetStyleDescriptor(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTile


        /// <summary>
        /// Returns a tile. Map tiles are used by clients to render a map. they're addressed using
        /// a grid arrangement with an X coordinate, Y coordinate, and Z (zoom) level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTile service method.</param>
        /// 
        /// <returns>The response from the GetTile service method, as returned by GeoMaps.</returns>
        /// <exception cref="Amazon.GeoMaps.Model.AccessDeniedException">
        /// The request was denied because of insufficient access or permissions. Check with an
        /// administrator to verify your permissions.
        /// </exception>
        /// <exception cref="Amazon.GeoMaps.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.GeoMaps.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.GeoMaps.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetTile">REST API Reference for GetTile Operation</seealso>
        GetTileResponse GetTile(GetTileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTile operation on AmazonGeoMapsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetTile">REST API Reference for GetTile Operation</seealso>
        IAsyncResult BeginGetTile(GetTileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTile.</param>
        /// 
        /// <returns>Returns a  GetTileResult from GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetTile">REST API Reference for GetTile Operation</seealso>
        GetTileResponse EndGetTile(IAsyncResult asyncResult);

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