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
using System.Net;

using Amazon.GeoMaps.Model;
using Amazon.GeoMaps.Model.Internal.MarshallTransformations;
using Amazon.GeoMaps.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGeoMapsConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGeoMapsConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGeoMapsEndpointResolver());
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

        /// <summary>
        /// <c>GetGlyphs</c> returns the map's glyphs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlyphs service method.</param>
        /// 
        /// <returns>The response from the GetGlyphs service method, as returned by GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetGlyphs">REST API Reference for GetGlyphs Operation</seealso>
        public virtual GetGlyphsResponse GetGlyphs(GetGlyphsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGlyphsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlyphsResponseUnmarshaller.Instance;

            return Invoke<GetGlyphsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetGlyphs(GetGlyphsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGlyphsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlyphsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGlyphs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGlyphs.</param>
        /// 
        /// <returns>Returns a  GetGlyphsResult from GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetGlyphs">REST API Reference for GetGlyphs Operation</seealso>
        public virtual GetGlyphsResponse EndGetGlyphs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGlyphsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSprites

        /// <summary>
        /// <c>GetSprites</c> returns the map's sprites.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSprites service method.</param>
        /// 
        /// <returns>The response from the GetSprites service method, as returned by GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetSprites">REST API Reference for GetSprites Operation</seealso>
        public virtual GetSpritesResponse GetSprites(GetSpritesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSpritesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpritesResponseUnmarshaller.Instance;

            return Invoke<GetSpritesResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetSprites(GetSpritesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSpritesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpritesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSprites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSprites.</param>
        /// 
        /// <returns>Returns a  GetSpritesResult from GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetSprites">REST API Reference for GetSprites Operation</seealso>
        public virtual GetSpritesResponse EndGetSprites(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSpritesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStaticMap

        /// <summary>
        /// <c>GetStaticMap</c> provides high-quality static map images with customizable options.
        /// You can modify the map's appearance and overlay additional information. It's an ideal
        /// solution for applications requiring tailored static map snapshots.
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
        public virtual GetStaticMapResponse GetStaticMap(GetStaticMapRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStaticMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStaticMapResponseUnmarshaller.Instance;

            return Invoke<GetStaticMapResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetStaticMap(GetStaticMapRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStaticMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStaticMapResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStaticMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStaticMap.</param>
        /// 
        /// <returns>Returns a  GetStaticMapResult from GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetStaticMap">REST API Reference for GetStaticMap Operation</seealso>
        public virtual GetStaticMapResponse EndGetStaticMap(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStaticMapResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStyleDescriptor

        /// <summary>
        /// <c>GetStyleDescriptor</c> returns information about the style.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStyleDescriptor service method.</param>
        /// 
        /// <returns>The response from the GetStyleDescriptor service method, as returned by GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetStyleDescriptor">REST API Reference for GetStyleDescriptor Operation</seealso>
        public virtual GetStyleDescriptorResponse GetStyleDescriptor(GetStyleDescriptorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStyleDescriptorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStyleDescriptorResponseUnmarshaller.Instance;

            return Invoke<GetStyleDescriptorResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetStyleDescriptor(GetStyleDescriptorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStyleDescriptorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStyleDescriptorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStyleDescriptor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStyleDescriptor.</param>
        /// 
        /// <returns>Returns a  GetStyleDescriptorResult from GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetStyleDescriptor">REST API Reference for GetStyleDescriptor Operation</seealso>
        public virtual GetStyleDescriptorResponse EndGetStyleDescriptor(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStyleDescriptorResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTile

        /// <summary>
        /// <c>GetTile</c> returns a tile. Map tiles are used by clients to render a map. they're
        /// addressed using a grid arrangement with an X coordinate, Y coordinate, and Z (zoom)
        /// level.
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
        public virtual GetTileResponse GetTile(GetTileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTileResponseUnmarshaller.Instance;

            return Invoke<GetTileResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginGetTile(GetTileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTile.</param>
        /// 
        /// <returns>Returns a  GetTileResult from GeoMaps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/geo-maps-2020-11-19/GetTile">REST API Reference for GetTile Operation</seealso>
        public virtual GetTileResponse EndGetTile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTileResponse>(asyncResult);
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
            var resolver = new AmazonGeoMapsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}