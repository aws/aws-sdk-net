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
using System.Threading;
using System.Threading.Tasks;
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
        /// <c>GetGlyphs</c> returns the map's glyphs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlyphs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGlyphs service method, as returned by GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetGlyphs">REST API Reference for GetGlyphs Operation</seealso>
        Task<GetGlyphsResponse> GetGlyphsAsync(GetGlyphsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSprites



        /// <summary>
        /// <c>GetSprites</c> returns the map's sprites.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSprites service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSprites service method, as returned by GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetSprites">REST API Reference for GetSprites Operation</seealso>
        Task<GetSpritesResponse> GetSpritesAsync(GetSpritesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetStaticMap



        /// <summary>
        /// <c>GetStaticMap</c> provides high-quality static map images with customizable options.
        /// You can modify the map's appearance and overlay additional information. It's an ideal
        /// solution for applications requiring tailored static map snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStaticMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetStaticMapResponse> GetStaticMapAsync(GetStaticMapRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetStyleDescriptor



        /// <summary>
        /// <c>GetStyleDescriptor</c> returns information about the style.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStyleDescriptor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStyleDescriptor service method, as returned by GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetStyleDescriptor">REST API Reference for GetStyleDescriptor Operation</seealso>
        Task<GetStyleDescriptorResponse> GetStyleDescriptorAsync(GetStyleDescriptorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTile



        /// <summary>
        /// <c>GetTile</c> returns a tile. Map tiles are used by clients to render a map. they're
        /// addressed using a grid arrangement with an X coordinate, Y coordinate, and Z (zoom)
        /// level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetTileResponse> GetTileAsync(GetTileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonGeoMapsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonGeoMapsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonGeoMapsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonGeoMapsConfig to create AmazonGeoMapsClient");
            }

            return awsCredentials == null ? 
                    new AmazonGeoMapsClient(serviceClientConfig) :
                    new AmazonGeoMapsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}