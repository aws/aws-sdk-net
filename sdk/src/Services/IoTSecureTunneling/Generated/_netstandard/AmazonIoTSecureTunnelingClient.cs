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
 * Do not modify this file. This file is generated from the iotsecuretunneling-2018-10-05.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTSecureTunneling.Model;
using Amazon.IoTSecureTunneling.Model.Internal.MarshallTransformations;
using Amazon.IoTSecureTunneling.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.IoTSecureTunneling
{
    /// <summary>
    /// <para>Implementation for accessing IoTSecureTunneling</para>
    ///
    /// IoT Secure Tunneling 
    /// <para>
    /// IoT Secure Tunneling creates remote connections to devices deployed in the field.
    /// </para>
    ///  
    /// <para>
    /// For more information about how IoT Secure Tunneling works, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/secure-tunneling.html">IoT
    /// Secure Tunneling</a>.
    /// </para>
    /// </summary>
    public partial class AmazonIoTSecureTunnelingClient : AmazonServiceClient, IAmazonIoTSecureTunneling
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTSecureTunnelingMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with the credentials loaded from the application's
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
        public AmazonIoTSecureTunnelingClient()
            : base(new AmazonIoTSecureTunnelingConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with the credentials loaded from the application's
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
        public AmazonIoTSecureTunnelingClient(RegionEndpoint region)
            : base(new AmazonIoTSecureTunnelingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTSecureTunnelingClient Configuration Object</param>
        public AmazonIoTSecureTunnelingClient(AmazonIoTSecureTunnelingConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTSecureTunnelingClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTSecureTunnelingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTSecureTunnelingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTSecureTunnelingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Credentials and an
        /// AmazonIoTSecureTunnelingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTSecureTunnelingClient Configuration Object</param>
        public AmazonIoTSecureTunnelingClient(AWSCredentials credentials, AmazonIoTSecureTunnelingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTSecureTunnelingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTSecureTunnelingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTSecureTunnelingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTSecureTunnelingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTSecureTunnelingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTSecureTunnelingClient Configuration Object</param>
        public AmazonIoTSecureTunnelingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTSecureTunnelingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTSecureTunnelingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTSecureTunnelingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTSecureTunnelingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTSecureTunnelingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSecureTunnelingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTSecureTunnelingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTSecureTunnelingClient Configuration Object</param>
        public AmazonIoTSecureTunnelingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTSecureTunnelingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IIoTSecureTunnelingPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIoTSecureTunnelingPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IoTSecureTunnelingPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTSecureTunnelingEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTSecureTunnelingAuthSchemeHandler());
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


        #region  CloseTunnel

        internal virtual CloseTunnelResponse CloseTunnel(CloseTunnelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CloseTunnelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloseTunnelResponseUnmarshaller.Instance;

            return Invoke<CloseTunnelResponse>(request, options);
        }



        /// <summary>
        /// Closes a tunnel identified by the unique tunnel id. When a <c>CloseTunnel</c> request
        /// is received, we close the WebSocket connections between the client and proxy server
        /// so no data can be transmitted.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CloseTunnel</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloseTunnel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CloseTunnel service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/CloseTunnel">REST API Reference for CloseTunnel Operation</seealso>
        public virtual Task<CloseTunnelResponse> CloseTunnelAsync(CloseTunnelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CloseTunnelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloseTunnelResponseUnmarshaller.Instance;

            return InvokeAsync<CloseTunnelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTunnel

        internal virtual DescribeTunnelResponse DescribeTunnel(DescribeTunnelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTunnelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTunnelResponseUnmarshaller.Instance;

            return Invoke<DescribeTunnelResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a tunnel identified by the unique tunnel id.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeTunnel</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTunnel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTunnel service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/DescribeTunnel">REST API Reference for DescribeTunnel Operation</seealso>
        public virtual Task<DescribeTunnelResponse> DescribeTunnelAsync(DescribeTunnelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTunnelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTunnelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTunnelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTunnels

        internal virtual ListTunnelsResponse ListTunnels(ListTunnelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTunnelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTunnelsResponseUnmarshaller.Instance;

            return Invoke<ListTunnelsResponse>(request, options);
        }



        /// <summary>
        /// List all tunnels for an Amazon Web Services account. Tunnels are listed by creation
        /// time in descending order, newer tunnels will be listed before older tunnels.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListTunnels</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTunnels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTunnels service method, as returned by IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTunnels">REST API Reference for ListTunnels Operation</seealso>
        public virtual Task<ListTunnelsResponse> ListTunnelsAsync(ListTunnelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTunnelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTunnelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTunnelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  OpenTunnel

        internal virtual OpenTunnelResponse OpenTunnel(OpenTunnelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OpenTunnelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OpenTunnelResponseUnmarshaller.Instance;

            return Invoke<OpenTunnelResponse>(request, options);
        }



        /// <summary>
        /// Creates a new tunnel, and returns two client access tokens for clients to use to connect
        /// to the IoT Secure Tunneling proxy server.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">OpenTunnel</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OpenTunnel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OpenTunnel service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.LimitExceededException">
        /// Thrown when a tunnel limit is exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/OpenTunnel">REST API Reference for OpenTunnel Operation</seealso>
        public virtual Task<OpenTunnelResponse> OpenTunnelAsync(OpenTunnelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OpenTunnelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OpenTunnelResponseUnmarshaller.Instance;

            return InvokeAsync<OpenTunnelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RotateTunnelAccessToken

        internal virtual RotateTunnelAccessTokenResponse RotateTunnelAccessToken(RotateTunnelAccessTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RotateTunnelAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateTunnelAccessTokenResponseUnmarshaller.Instance;

            return Invoke<RotateTunnelAccessTokenResponse>(request, options);
        }



        /// <summary>
        /// Revokes the current client access token (CAT) and returns new CAT for clients to use
        /// when reconnecting to secure tunneling to access the same tunnel.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">RotateTunnelAccessToken</a>
        /// action.
        /// </para>
        ///  <note> 
        /// <para>
        /// Rotating the CAT doesn't extend the tunnel duration. For example, say the tunnel duration
        /// is 12 hours and the tunnel has already been open for 4 hours. When you rotate the
        /// access tokens, the new tokens that are generated can only be used for the remaining
        /// 8 hours.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateTunnelAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RotateTunnelAccessToken service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/RotateTunnelAccessToken">REST API Reference for RotateTunnelAccessToken Operation</seealso>
        public virtual Task<RotateTunnelAccessTokenResponse> RotateTunnelAccessTokenAsync(RotateTunnelAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RotateTunnelAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateTunnelAccessTokenResponseUnmarshaller.Instance;

            return InvokeAsync<RotateTunnelAccessTokenResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// A resource tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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