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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.GeoRoutes.Model;
using Amazon.GeoRoutes.Model.Internal.MarshallTransformations;
using Amazon.GeoRoutes.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.GeoRoutes
{
    /// <summary>
    /// <para>Implementation for accessing GeoRoutes</para>
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
    public partial class AmazonGeoRoutesClient : AmazonServiceClient, IAmazonGeoRoutes
    {
        private static IServiceMetadata serviceMetadata = new AmazonGeoRoutesMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonGeoRoutesClient with the credentials loaded from the application's
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
        public AmazonGeoRoutesClient()
            : base(new AmazonGeoRoutesConfig()) { }

        /// <summary>
        /// Constructs AmazonGeoRoutesClient with the credentials loaded from the application's
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
        public AmazonGeoRoutesClient(RegionEndpoint region)
            : base(new AmazonGeoRoutesConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGeoRoutesClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGeoRoutesClient Configuration Object</param>
        public AmazonGeoRoutesClient(AmazonGeoRoutesConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonGeoRoutesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGeoRoutesClient(AWSCredentials credentials)
            : this(credentials, new AmazonGeoRoutesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGeoRoutesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGeoRoutesClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGeoRoutesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGeoRoutesClient with AWS Credentials and an
        /// AmazonGeoRoutesClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGeoRoutesClient Configuration Object</param>
        public AmazonGeoRoutesClient(AWSCredentials credentials, AmazonGeoRoutesConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGeoRoutesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGeoRoutesClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGeoRoutesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGeoRoutesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGeoRoutesClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGeoRoutesConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGeoRoutesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGeoRoutesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGeoRoutesClient Configuration Object</param>
        public AmazonGeoRoutesClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGeoRoutesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGeoRoutesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGeoRoutesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGeoRoutesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGeoRoutesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGeoRoutesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGeoRoutesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGeoRoutesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGeoRoutesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGeoRoutesClient Configuration Object</param>
        public AmazonGeoRoutesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGeoRoutesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGeoRoutesEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGeoRoutesAuthSchemeHandler());
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


        #region  CalculateIsolines


        /// <summary>
        /// Use the <c>CalculateIsolines</c> action to find service areas that can be reached
        /// in a given threshold of time, distance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CalculateIsolines service method.</param>
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
        public virtual CalculateIsolinesResponse CalculateIsolines(CalculateIsolinesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CalculateIsolinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CalculateIsolinesResponseUnmarshaller.Instance;

            return Invoke<CalculateIsolinesResponse>(request, options);
        }


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
        public virtual Task<CalculateIsolinesResponse> CalculateIsolinesAsync(CalculateIsolinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CalculateIsolinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CalculateIsolinesResponseUnmarshaller.Instance;
            
            return InvokeAsync<CalculateIsolinesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CalculateRouteMatrix


        /// <summary>
        /// Use <c>CalculateRouteMatrix</c> to compute results for all pairs of Origins to Destinations.
        /// Each row corresponds to one entry in Origins. Each entry in the row corresponds to
        /// the route from that entry in Origins to an entry in Destinations positions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CalculateRouteMatrix service method.</param>
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
        public virtual CalculateRouteMatrixResponse CalculateRouteMatrix(CalculateRouteMatrixRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CalculateRouteMatrixRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CalculateRouteMatrixResponseUnmarshaller.Instance;

            return Invoke<CalculateRouteMatrixResponse>(request, options);
        }


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
        public virtual Task<CalculateRouteMatrixResponse> CalculateRouteMatrixAsync(CalculateRouteMatrixRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CalculateRouteMatrixRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CalculateRouteMatrixResponseUnmarshaller.Instance;
            
            return InvokeAsync<CalculateRouteMatrixResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CalculateRoutes


        /// <summary>
        /// <c>CalculateRoutes</c> computes routes given the following required parameters: <c>Origin</c>
        /// and <c>Destination</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CalculateRoutes service method.</param>
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
        public virtual CalculateRoutesResponse CalculateRoutes(CalculateRoutesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CalculateRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CalculateRoutesResponseUnmarshaller.Instance;

            return Invoke<CalculateRoutesResponse>(request, options);
        }


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
        public virtual Task<CalculateRoutesResponse> CalculateRoutesAsync(CalculateRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CalculateRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CalculateRoutesResponseUnmarshaller.Instance;
            
            return InvokeAsync<CalculateRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  OptimizeWaypoints


        /// <summary>
        /// <c>OptimizeWaypoints</c> calculates the optimal order to travel between a set of
        /// waypoints to minimize either the travel time or the distance travelled during the
        /// journey, based on road network restrictions and the traffic pattern data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OptimizeWaypoints service method.</param>
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
        public virtual OptimizeWaypointsResponse OptimizeWaypoints(OptimizeWaypointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OptimizeWaypointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OptimizeWaypointsResponseUnmarshaller.Instance;

            return Invoke<OptimizeWaypointsResponse>(request, options);
        }


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
        public virtual Task<OptimizeWaypointsResponse> OptimizeWaypointsAsync(OptimizeWaypointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OptimizeWaypointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OptimizeWaypointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<OptimizeWaypointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SnapToRoads


        /// <summary>
        /// <c>SnapToRoads</c> matches GPS trace to roads most likely traveled on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SnapToRoads service method.</param>
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
        public virtual SnapToRoadsResponse SnapToRoads(SnapToRoadsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SnapToRoadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SnapToRoadsResponseUnmarshaller.Instance;

            return Invoke<SnapToRoadsResponse>(request, options);
        }


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
        public virtual Task<SnapToRoadsResponse> SnapToRoadsAsync(SnapToRoadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SnapToRoadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SnapToRoadsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SnapToRoadsResponse>(request, options, cancellationToken);
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