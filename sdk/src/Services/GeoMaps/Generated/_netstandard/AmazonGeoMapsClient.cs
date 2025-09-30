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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.GeoMaps.Model;
using Amazon.GeoMaps.Model.Internal.MarshallTransformations;
using Amazon.GeoMaps.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.GeoMaps
{
    /// <summary>
    /// <para>Implementation for accessing GeoMaps</para>
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
    public partial class AmazonGeoMapsClient : AmazonServiceClient, IAmazonGeoMaps
    {
        private static IServiceMetadata serviceMetadata = new AmazonGeoMapsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonGeoMapsClient with the credentials loaded from the application's
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
        public AmazonGeoMapsClient()
            : base(new AmazonGeoMapsConfig()) { }

        /// <summary>
        /// Constructs AmazonGeoMapsClient with the credentials loaded from the application's
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
        public AmazonGeoMapsClient(RegionEndpoint region)
            : base(new AmazonGeoMapsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGeoMapsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGeoMapsClient Configuration Object</param>
        public AmazonGeoMapsClient(AmazonGeoMapsConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonGeoMapsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGeoMapsClient(AWSCredentials credentials)
            : this(credentials, new AmazonGeoMapsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGeoMapsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGeoMapsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGeoMapsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGeoMapsClient with AWS Credentials and an
        /// AmazonGeoMapsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGeoMapsClient Configuration Object</param>
        public AmazonGeoMapsClient(AWSCredentials credentials, AmazonGeoMapsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGeoMapsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGeoMapsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGeoMapsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGeoMapsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGeoMapsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGeoMapsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGeoMapsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGeoMapsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGeoMapsClient Configuration Object</param>
        public AmazonGeoMapsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGeoMapsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGeoMapsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGeoMapsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGeoMapsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGeoMapsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGeoMapsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGeoMapsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGeoMapsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGeoMapsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGeoMapsClient Configuration Object</param>
        public AmazonGeoMapsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGeoMapsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGeoMapsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGeoMapsAuthSchemeHandler());
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


        #region  GetGlyphs

        internal virtual GetGlyphsResponse GetGlyphs(GetGlyphsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGlyphsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlyphsResponseUnmarshaller.Instance;

            return Invoke<GetGlyphsResponse>(request, options);
        }



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
        public virtual Task<GetGlyphsResponse> GetGlyphsAsync(GetGlyphsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGlyphsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlyphsResponseUnmarshaller.Instance;

            return InvokeAsync<GetGlyphsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSprites

        internal virtual GetSpritesResponse GetSprites(GetSpritesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSpritesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpritesResponseUnmarshaller.Instance;

            return Invoke<GetSpritesResponse>(request, options);
        }



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
        public virtual Task<GetSpritesResponse> GetSpritesAsync(GetSpritesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSpritesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpritesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSpritesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetStaticMap

        internal virtual GetStaticMapResponse GetStaticMap(GetStaticMapRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStaticMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStaticMapResponseUnmarshaller.Instance;

            return Invoke<GetStaticMapResponse>(request, options);
        }



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
        public virtual Task<GetStaticMapResponse> GetStaticMapAsync(GetStaticMapRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStaticMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStaticMapResponseUnmarshaller.Instance;

            return InvokeAsync<GetStaticMapResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetStyleDescriptor

        internal virtual GetStyleDescriptorResponse GetStyleDescriptor(GetStyleDescriptorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStyleDescriptorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStyleDescriptorResponseUnmarshaller.Instance;

            return Invoke<GetStyleDescriptorResponse>(request, options);
        }



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
        public virtual Task<GetStyleDescriptorResponse> GetStyleDescriptorAsync(GetStyleDescriptorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStyleDescriptorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStyleDescriptorResponseUnmarshaller.Instance;

            return InvokeAsync<GetStyleDescriptorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTile

        internal virtual GetTileResponse GetTile(GetTileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTileResponseUnmarshaller.Instance;

            return Invoke<GetTileResponse>(request, options);
        }



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
        /// <exception cref="Amazon.GeoMaps.Model.ResourceNotFoundException">
        /// Exception thrown when the associated resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.GeoMaps.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.GeoMaps.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetTile">REST API Reference for GetTile Operation</seealso>
        public virtual Task<GetTileResponse> GetTileAsync(GetTileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTileResponseUnmarshaller.Instance;

            return InvokeAsync<GetTileResponse>(request, options, cancellationToken);
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