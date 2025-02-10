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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GeoRoutes.Model;

#pragma warning disable CS1570
namespace Amazon.GeoRoutes
{
    /// <summary>
    /// <para>Interface for accessing GeoRoutes</para>
    ///
    /// With the Amazon Location Routes API you can calculate routes and estimate travel time
    /// based on up-to-date road network and live traffic information.
    /// 
    ///  
    /// <para>
    /// Calculate optimal travel routes and estimate travel times using up-to-date road network
    /// and traffic data. Key features include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Point-to-point routing with estimated travel time, distance, and turn-by-turn directions
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Multi-point route optimization to minimize travel time or distance
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Route matrices for efficient multi-destination planning
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Isoline calculations to determine reachable areas within specified time or distance
    /// thresholds
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Map-matching to align GPS traces with the road network
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonGeoRoutes : IAmazonService, IDisposable
    {
                
        #region  CalculateIsolines



        /// <summary>
        /// Use the <c>CalculateIsolines</c> action to find service areas that can be reached
        /// in a given threshold of time, distance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CalculateIsolines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CalculateIsolines service method, as returned by GeoRoutes.</returns>
        /// <exception cref="Amazon.GeoRoutes.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GeoRoutes.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.GeoRoutes.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.GeoRoutes.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-routes-2020-11-19/CalculateIsolines">REST API Reference for CalculateIsolines Operation</seealso>
        Task<CalculateIsolinesResponse> CalculateIsolinesAsync(CalculateIsolinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CalculateRouteMatrix



        /// <summary>
        /// Use <c>CalculateRouteMatrix</c> to compute results for all pairs of Origins to Destinations.
        /// Each row corresponds to one entry in Origins. Each entry in the row corresponds to
        /// the route from that entry in Origins to an entry in Destinations positions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CalculateRouteMatrix service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CalculateRouteMatrix service method, as returned by GeoRoutes.</returns>
        /// <exception cref="Amazon.GeoRoutes.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GeoRoutes.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.GeoRoutes.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.GeoRoutes.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-routes-2020-11-19/CalculateRouteMatrix">REST API Reference for CalculateRouteMatrix Operation</seealso>
        Task<CalculateRouteMatrixResponse> CalculateRouteMatrixAsync(CalculateRouteMatrixRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CalculateRoutes



        /// <summary>
        /// <c>CalculateRoutes</c> computes routes given the following required parameters: <c>Origin</c>
        /// and <c>Destination</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CalculateRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CalculateRoutes service method, as returned by GeoRoutes.</returns>
        /// <exception cref="Amazon.GeoRoutes.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GeoRoutes.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.GeoRoutes.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.GeoRoutes.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-routes-2020-11-19/CalculateRoutes">REST API Reference for CalculateRoutes Operation</seealso>
        Task<CalculateRoutesResponse> CalculateRoutesAsync(CalculateRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  OptimizeWaypoints



        /// <summary>
        /// <c>OptimizeWaypoints</c> calculates the optimal order to travel between a set of
        /// waypoints to minimize either the travel time or the distance travelled during the
        /// journey, based on road network restrictions and the traffic pattern data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OptimizeWaypoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OptimizeWaypoints service method, as returned by GeoRoutes.</returns>
        /// <exception cref="Amazon.GeoRoutes.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GeoRoutes.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.GeoRoutes.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.GeoRoutes.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-routes-2020-11-19/OptimizeWaypoints">REST API Reference for OptimizeWaypoints Operation</seealso>
        Task<OptimizeWaypointsResponse> OptimizeWaypointsAsync(OptimizeWaypointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SnapToRoads



        /// <summary>
        /// <c>SnapToRoads</c> matches GPS trace to roads most likely traveled on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SnapToRoads service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SnapToRoads service method, as returned by GeoRoutes.</returns>
        /// <exception cref="Amazon.GeoRoutes.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GeoRoutes.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.GeoRoutes.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.GeoRoutes.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-routes-2020-11-19/SnapToRoads">REST API Reference for SnapToRoads Operation</seealso>
        Task<SnapToRoadsResponse> SnapToRoadsAsync(SnapToRoadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonGeoRoutesConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonGeoRoutesConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonGeoRoutesConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonGeoRoutesConfig to create AmazonGeoRoutesClient");
            }

            return awsCredentials == null ? 
                    new AmazonGeoRoutesClient(serviceClientConfig) :
                    new AmazonGeoRoutesClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}