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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MediaConnect.Model;
using Amazon.MediaConnect.Model.Internal.MarshallTransformations;
using Amazon.MediaConnect.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.MediaConnect
{
    /// <summary>
    /// <para>Implementation for accessing MediaConnect</para>
    ///
    /// Welcome to the Elemental MediaConnect API reference. 
    /// 
    ///  
    /// <para>
    /// MediaConnect is a service that lets you ingest live video content into the cloud and
    /// distribute it to destinations all over the world, both inside and outside the Amazon
    /// Web Services cloud. This API reference provides descriptions, syntax, and usage examples
    /// for each of the actions and data types that are supported by MediaConnect. 
    /// </para>
    ///  
    /// <para>
    /// Use the following links to get started with the MediaConnect API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/mediaconnect/latest/api/API_Operations.html">Actions</a>:
    /// An alphabetical list of all MediaConnect API operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/mediaconnect/latest/api/API_Types.html">Data
    /// types</a>: An alphabetical list of all MediaConnect data types.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/mediaconnect/latest/api/CommonParameters.html">Common
    /// parameters</a>: Parameters that all operations can use.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/mediaconnect/latest/api/CommonErrors.html">Common
    /// errors</a>: Client and server errors that all operations can return.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonMediaConnectClient : AmazonServiceClient, IAmazonMediaConnect
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaConnectMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMediaConnectClient with the credentials loaded from the application's
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
        public AmazonMediaConnectClient()
            : base(new AmazonMediaConnectConfig()) { }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with the credentials loaded from the application's
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
        public AmazonMediaConnectClient(RegionEndpoint region)
            : base(new AmazonMediaConnectConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMediaConnectClient Configuration Object</param>
        public AmazonMediaConnectClient(AmazonMediaConnectConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMediaConnectClient(AWSCredentials credentials)
            : this(credentials, new AmazonMediaConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaConnectClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMediaConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Credentials and an
        /// AmazonMediaConnectClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMediaConnectClient Configuration Object</param>
        public AmazonMediaConnectClient(AWSCredentials credentials, AmazonMediaConnectConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMediaConnectClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaConnectClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaConnectConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMediaConnectClient Configuration Object</param>
        public AmazonMediaConnectClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMediaConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMediaConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMediaConnectClient Configuration Object</param>
        public AmazonMediaConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMediaConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMediaConnectPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMediaConnectPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MediaConnectPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMediaConnectEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMediaConnectAuthSchemeHandler());
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


        #region  AddBridgeOutputs

        internal virtual AddBridgeOutputsResponse AddBridgeOutputs(AddBridgeOutputsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddBridgeOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddBridgeOutputsResponseUnmarshaller.Instance;

            return Invoke<AddBridgeOutputsResponse>(request, options);
        }



        /// <summary>
        /// Adds outputs to an existing bridge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddBridgeOutputs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddBridgeOutputs service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddBridgeOutputs">REST API Reference for AddBridgeOutputs Operation</seealso>
        public virtual Task<AddBridgeOutputsResponse> AddBridgeOutputsAsync(AddBridgeOutputsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddBridgeOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddBridgeOutputsResponseUnmarshaller.Instance;

            return InvokeAsync<AddBridgeOutputsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddBridgeSources

        internal virtual AddBridgeSourcesResponse AddBridgeSources(AddBridgeSourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddBridgeSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddBridgeSourcesResponseUnmarshaller.Instance;

            return Invoke<AddBridgeSourcesResponse>(request, options);
        }



        /// <summary>
        /// Adds sources to an existing bridge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddBridgeSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddBridgeSources service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddBridgeSources">REST API Reference for AddBridgeSources Operation</seealso>
        public virtual Task<AddBridgeSourcesResponse> AddBridgeSourcesAsync(AddBridgeSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddBridgeSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddBridgeSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<AddBridgeSourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddFlowMediaStreams

        internal virtual AddFlowMediaStreamsResponse AddFlowMediaStreams(AddFlowMediaStreamsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowMediaStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowMediaStreamsResponseUnmarshaller.Instance;

            return Invoke<AddFlowMediaStreamsResponse>(request, options);
        }



        /// <summary>
        /// Adds media streams to an existing flow. After you add a media stream to a flow, you
        /// can associate it with a source and/or an output that uses the ST 2110 JPEG XS or CDI
        /// protocol.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFlowMediaStreams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddFlowMediaStreams service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowMediaStreams">REST API Reference for AddFlowMediaStreams Operation</seealso>
        public virtual Task<AddFlowMediaStreamsResponse> AddFlowMediaStreamsAsync(AddFlowMediaStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowMediaStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowMediaStreamsResponseUnmarshaller.Instance;

            return InvokeAsync<AddFlowMediaStreamsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddFlowOutputs

        internal virtual AddFlowOutputsResponse AddFlowOutputs(AddFlowOutputsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowOutputsResponseUnmarshaller.Instance;

            return Invoke<AddFlowOutputsResponse>(request, options);
        }



        /// <summary>
        /// Adds outputs to an existing flow. You can create up to 50 outputs per flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFlowOutputs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddFlowOutputs service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.AddFlowOutputs420Exception">
        /// Exception raised by Elemental MediaConnect when adding the flow output. See the error
        /// message for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowOutputs">REST API Reference for AddFlowOutputs Operation</seealso>
        public virtual Task<AddFlowOutputsResponse> AddFlowOutputsAsync(AddFlowOutputsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowOutputsResponseUnmarshaller.Instance;

            return InvokeAsync<AddFlowOutputsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddFlowSources

        internal virtual AddFlowSourcesResponse AddFlowSources(AddFlowSourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowSourcesResponseUnmarshaller.Instance;

            return Invoke<AddFlowSourcesResponse>(request, options);
        }



        /// <summary>
        /// Adds sources to a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFlowSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddFlowSources service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowSources">REST API Reference for AddFlowSources Operation</seealso>
        public virtual Task<AddFlowSourcesResponse> AddFlowSourcesAsync(AddFlowSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<AddFlowSourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddFlowVpcInterfaces

        internal virtual AddFlowVpcInterfacesResponse AddFlowVpcInterfaces(AddFlowVpcInterfacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowVpcInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowVpcInterfacesResponseUnmarshaller.Instance;

            return Invoke<AddFlowVpcInterfacesResponse>(request, options);
        }



        /// <summary>
        /// Adds VPC interfaces to a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFlowVpcInterfaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddFlowVpcInterfaces service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowVpcInterfaces">REST API Reference for AddFlowVpcInterfaces Operation</seealso>
        public virtual Task<AddFlowVpcInterfacesResponse> AddFlowVpcInterfacesAsync(AddFlowVpcInterfacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowVpcInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowVpcInterfacesResponseUnmarshaller.Instance;

            return InvokeAsync<AddFlowVpcInterfacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateBridge

        internal virtual CreateBridgeResponse CreateBridge(CreateBridgeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBridgeResponseUnmarshaller.Instance;

            return Invoke<CreateBridgeResponse>(request, options);
        }



        /// <summary>
        /// Creates a new bridge. The request must include one source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBridge service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBridge service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.CreateBridge420Exception">
        /// Exception raised by Elemental MediaConnect when creating the bridge. See the error
        /// message for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateBridge">REST API Reference for CreateBridge Operation</seealso>
        public virtual Task<CreateBridgeResponse> CreateBridgeAsync(CreateBridgeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBridgeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBridgeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFlow

        internal virtual CreateFlowResponse CreateFlow(CreateFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowResponseUnmarshaller.Instance;

            return Invoke<CreateFlowResponse>(request, options);
        }



        /// <summary>
        /// Creates a new flow. The request must include one source. The request optionally can
        /// include outputs (up to 50) and entitlements (up to 50).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.CreateFlow420Exception">
        /// Exception raised by Elemental MediaConnect when creating the flow. See the error message
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateFlow">REST API Reference for CreateFlow Operation</seealso>
        public virtual Task<CreateFlowResponse> CreateFlowAsync(CreateFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGateway

        internal virtual CreateGatewayResponse CreateGateway(CreateGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateGatewayResponse>(request, options);
        }



        /// <summary>
        /// Creates a new gateway. The request must include at least one network (up to four).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGateway service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.CreateGateway420Exception">
        /// Exception raised by Elemental MediaConnect when creating the gateway. See the error
        /// message for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        public virtual Task<CreateGatewayResponse> CreateGatewayAsync(CreateGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGatewayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteBridge

        internal virtual DeleteBridgeResponse DeleteBridge(DeleteBridgeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBridgeResponseUnmarshaller.Instance;

            return Invoke<DeleteBridgeResponse>(request, options);
        }



        /// <summary>
        /// Deletes a bridge. Before you can delete a bridge, you must stop the bridge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBridge service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBridge service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteBridge">REST API Reference for DeleteBridge Operation</seealso>
        public virtual Task<DeleteBridgeResponse> DeleteBridgeAsync(DeleteBridgeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBridgeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBridgeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFlow

        internal virtual DeleteFlowResponse DeleteFlow(DeleteFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowResponse>(request, options);
        }



        /// <summary>
        /// Deletes a flow. Before you can delete a flow, you must stop the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteFlow">REST API Reference for DeleteFlow Operation</seealso>
        public virtual Task<DeleteFlowResponse> DeleteFlowAsync(DeleteFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGateway

        internal virtual DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayResponse>(request, options);
        }



        /// <summary>
        /// Deletes a gateway. Before you can delete a gateway, you must deregister its instances
        /// and delete its bridges.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        public virtual Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGatewayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeregisterGatewayInstance

        internal virtual DeregisterGatewayInstanceResponse DeregisterGatewayInstance(DeregisterGatewayInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterGatewayInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterGatewayInstanceResponseUnmarshaller.Instance;

            return Invoke<DeregisterGatewayInstanceResponse>(request, options);
        }



        /// <summary>
        /// Deregisters an instance. Before you deregister an instance, all bridges running on
        /// the instance must be stopped. If you want to deregister an instance without stopping
        /// the bridges, you must use the --force option.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterGatewayInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterGatewayInstance service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeregisterGatewayInstance">REST API Reference for DeregisterGatewayInstance Operation</seealso>
        public virtual Task<DeregisterGatewayInstanceResponse> DeregisterGatewayInstanceAsync(DeregisterGatewayInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterGatewayInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterGatewayInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterGatewayInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeBridge

        internal virtual DescribeBridgeResponse DescribeBridge(DescribeBridgeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBridgeResponseUnmarshaller.Instance;

            return Invoke<DescribeBridgeResponse>(request, options);
        }



        /// <summary>
        /// Displays the details of a bridge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBridge service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBridge service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeBridge">REST API Reference for DescribeBridge Operation</seealso>
        public virtual Task<DescribeBridgeResponse> DescribeBridgeAsync(DescribeBridgeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBridgeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBridgeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFlow

        internal virtual DescribeFlowResponse DescribeFlow(DescribeFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowResponse>(request, options);
        }



        /// <summary>
        /// Displays the details of a flow. The response includes the flow Amazon Resource Name
        /// (ARN), name, and Availability Zone, as well as details about the source, outputs,
        /// and entitlements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeFlow">REST API Reference for DescribeFlow Operation</seealso>
        public virtual Task<DescribeFlowResponse> DescribeFlowAsync(DescribeFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFlowSourceMetadata

        internal virtual DescribeFlowSourceMetadataResponse DescribeFlowSourceMetadata(DescribeFlowSourceMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowSourceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowSourceMetadataResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowSourceMetadataResponse>(request, options);
        }



        /// <summary>
        /// The <c>DescribeFlowSourceMetadata</c> API is used to view information about the flow's
        /// source transport stream and programs. This API displays status messages about the
        /// flow's source as well as details about the program's video, audio, and other data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowSourceMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFlowSourceMetadata service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeFlowSourceMetadata">REST API Reference for DescribeFlowSourceMetadata Operation</seealso>
        public virtual Task<DescribeFlowSourceMetadataResponse> DescribeFlowSourceMetadataAsync(DescribeFlowSourceMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowSourceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowSourceMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFlowSourceMetadataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFlowSourceThumbnail

        internal virtual DescribeFlowSourceThumbnailResponse DescribeFlowSourceThumbnail(DescribeFlowSourceThumbnailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowSourceThumbnailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowSourceThumbnailResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowSourceThumbnailResponse>(request, options);
        }



        /// <summary>
        /// Describes the thumbnail for the flow source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowSourceThumbnail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFlowSourceThumbnail service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeFlowSourceThumbnail">REST API Reference for DescribeFlowSourceThumbnail Operation</seealso>
        public virtual Task<DescribeFlowSourceThumbnailResponse> DescribeFlowSourceThumbnailAsync(DescribeFlowSourceThumbnailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowSourceThumbnailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowSourceThumbnailResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFlowSourceThumbnailResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGateway

        internal virtual DescribeGatewayResponse DescribeGateway(DescribeGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayResponseUnmarshaller.Instance;

            return Invoke<DescribeGatewayResponse>(request, options);
        }



        /// <summary>
        /// Displays the details of a gateway. The response includes the gateway Amazon Resource
        /// Name (ARN), name, and CIDR blocks, as well as details about the networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGateway service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeGateway">REST API Reference for DescribeGateway Operation</seealso>
        public virtual Task<DescribeGatewayResponse> DescribeGatewayAsync(DescribeGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGatewayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGatewayInstance

        internal virtual DescribeGatewayInstanceResponse DescribeGatewayInstance(DescribeGatewayInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeGatewayInstanceResponse>(request, options);
        }



        /// <summary>
        /// Displays the details of an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGatewayInstance service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeGatewayInstance">REST API Reference for DescribeGatewayInstance Operation</seealso>
        public virtual Task<DescribeGatewayInstanceResponse> DescribeGatewayInstanceAsync(DescribeGatewayInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGatewayInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeOffering

        internal virtual DescribeOfferingResponse DescribeOffering(DescribeOfferingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOfferingResponseUnmarshaller.Instance;

            return Invoke<DescribeOfferingResponse>(request, options);
        }



        /// <summary>
        /// Displays the details of an offering. The response includes the offering description,
        /// duration, outbound bandwidth, price, and Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOffering service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeOffering">REST API Reference for DescribeOffering Operation</seealso>
        public virtual Task<DescribeOfferingResponse> DescribeOfferingAsync(DescribeOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOfferingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeReservation

        internal virtual DescribeReservationResponse DescribeReservation(DescribeReservationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservationResponseUnmarshaller.Instance;

            return Invoke<DescribeReservationResponse>(request, options);
        }



        /// <summary>
        /// Displays the details of a reservation. The response includes the reservation name,
        /// state, start date and time, and the details of the offering that make up the rest
        /// of the reservation (such as price, duration, and outbound bandwidth).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservation service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeReservation">REST API Reference for DescribeReservation Operation</seealso>
        public virtual Task<DescribeReservationResponse> DescribeReservationAsync(DescribeReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GrantFlowEntitlements

        internal virtual GrantFlowEntitlementsResponse GrantFlowEntitlements(GrantFlowEntitlementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GrantFlowEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GrantFlowEntitlementsResponseUnmarshaller.Instance;

            return Invoke<GrantFlowEntitlementsResponse>(request, options);
        }



        /// <summary>
        /// Grants entitlements to an existing flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GrantFlowEntitlements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GrantFlowEntitlements service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.GrantFlowEntitlements420Exception">
        /// Exception raised by Elemental MediaConnect when granting the entitlement. See the
        /// error message for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GrantFlowEntitlements">REST API Reference for GrantFlowEntitlements Operation</seealso>
        public virtual Task<GrantFlowEntitlementsResponse> GrantFlowEntitlementsAsync(GrantFlowEntitlementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GrantFlowEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GrantFlowEntitlementsResponseUnmarshaller.Instance;

            return InvokeAsync<GrantFlowEntitlementsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBridges

        internal virtual ListBridgesResponse ListBridges(ListBridgesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBridgesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBridgesResponseUnmarshaller.Instance;

            return Invoke<ListBridgesResponse>(request, options);
        }



        /// <summary>
        /// Displays a list of bridges that are associated with this account and an optionally
        /// specified Amazon Resource Name (ARN). This request returns a paginated result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBridges service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBridges service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListBridges">REST API Reference for ListBridges Operation</seealso>
        public virtual Task<ListBridgesResponse> ListBridgesAsync(ListBridgesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBridgesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBridgesResponseUnmarshaller.Instance;

            return InvokeAsync<ListBridgesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEntitlements

        internal virtual ListEntitlementsResponse ListEntitlements(ListEntitlementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitlementsResponseUnmarshaller.Instance;

            return Invoke<ListEntitlementsResponse>(request, options);
        }



        /// <summary>
        /// Displays a list of all entitlements that have been granted to this account. This
        /// request returns 20 results per page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitlements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntitlements service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListEntitlements">REST API Reference for ListEntitlements Operation</seealso>
        public virtual Task<ListEntitlementsResponse> ListEntitlementsAsync(ListEntitlementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitlementsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEntitlementsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFlows

        internal virtual ListFlowsResponse ListFlows(ListFlowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowsResponseUnmarshaller.Instance;

            return Invoke<ListFlowsResponse>(request, options);
        }



        /// <summary>
        /// Displays a list of flows that are associated with this account. This request returns
        /// a paginated result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFlows service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListFlows">REST API Reference for ListFlows Operation</seealso>
        public virtual Task<ListFlowsResponse> ListFlowsAsync(ListFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFlowsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGatewayInstances

        internal virtual ListGatewayInstancesResponse ListGatewayInstances(ListGatewayInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewayInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewayInstancesResponseUnmarshaller.Instance;

            return Invoke<ListGatewayInstancesResponse>(request, options);
        }



        /// <summary>
        /// Displays a list of instances associated with the Amazon Web Services account. This
        /// request returns a paginated result. You can use the filterArn property to display
        /// only the instances associated with the selected Gateway Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGatewayInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGatewayInstances service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListGatewayInstances">REST API Reference for ListGatewayInstances Operation</seealso>
        public virtual Task<ListGatewayInstancesResponse> ListGatewayInstancesAsync(ListGatewayInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewayInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewayInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListGatewayInstancesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGateways

        internal virtual ListGatewaysResponse ListGateways(ListGatewaysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListGatewaysResponse>(request, options);
        }



        /// <summary>
        /// Displays a list of gateways that are associated with this account. This request returns
        /// a paginated result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<ListGatewaysResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListOfferings

        internal virtual ListOfferingsResponse ListOfferings(ListOfferingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingsResponseUnmarshaller.Instance;

            return Invoke<ListOfferingsResponse>(request, options);
        }



        /// <summary>
        /// Displays a list of all offerings that are available to this account in the current
        /// Amazon Web Services Region. If you have an active reservation (which means you've
        /// purchased an offering that has already started and hasn't expired yet), your account
        /// isn't eligible for other offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOfferings service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        public virtual Task<ListOfferingsResponse> ListOfferingsAsync(ListOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOfferingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReservations

        internal virtual ListReservationsResponse ListReservations(ListReservationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReservationsResponseUnmarshaller.Instance;

            return Invoke<ListReservationsResponse>(request, options);
        }



        /// <summary>
        /// Displays a list of all reservations that have been purchased by this account in the
        /// current Amazon Web Services Region. This list includes all reservations in all states
        /// (such as active and expired).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReservations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReservations service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListReservations">REST API Reference for ListReservations Operation</seealso>
        public virtual Task<ListReservationsResponse> ListReservationsAsync(ListReservationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReservationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReservationsResponse>(request, options, cancellationToken);
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
        /// List all tags on a MediaConnect resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PurchaseOffering

        internal virtual PurchaseOfferingResponse PurchaseOffering(PurchaseOfferingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PurchaseOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseOfferingResponse>(request, options);
        }



        /// <summary>
        /// Submits a request to purchase an offering. If you already have an active reservation,
        /// you can't purchase another offering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseOffering service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        public virtual Task<PurchaseOfferingResponse> PurchaseOfferingAsync(PurchaseOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PurchaseOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseOfferingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveBridgeOutput

        internal virtual RemoveBridgeOutputResponse RemoveBridgeOutput(RemoveBridgeOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveBridgeOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveBridgeOutputResponseUnmarshaller.Instance;

            return Invoke<RemoveBridgeOutputResponse>(request, options);
        }



        /// <summary>
        /// Removes an output from a bridge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveBridgeOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveBridgeOutput service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveBridgeOutput">REST API Reference for RemoveBridgeOutput Operation</seealso>
        public virtual Task<RemoveBridgeOutputResponse> RemoveBridgeOutputAsync(RemoveBridgeOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveBridgeOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveBridgeOutputResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveBridgeOutputResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveBridgeSource

        internal virtual RemoveBridgeSourceResponse RemoveBridgeSource(RemoveBridgeSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveBridgeSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveBridgeSourceResponseUnmarshaller.Instance;

            return Invoke<RemoveBridgeSourceResponse>(request, options);
        }



        /// <summary>
        /// Removes a source from a bridge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveBridgeSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveBridgeSource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveBridgeSource">REST API Reference for RemoveBridgeSource Operation</seealso>
        public virtual Task<RemoveBridgeSourceResponse> RemoveBridgeSourceAsync(RemoveBridgeSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveBridgeSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveBridgeSourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveBridgeSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveFlowMediaStream

        internal virtual RemoveFlowMediaStreamResponse RemoveFlowMediaStream(RemoveFlowMediaStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowMediaStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowMediaStreamResponseUnmarshaller.Instance;

            return Invoke<RemoveFlowMediaStreamResponse>(request, options);
        }



        /// <summary>
        /// Removes a media stream from a flow. This action is only available if the media stream
        /// is not associated with a source or output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowMediaStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveFlowMediaStream service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowMediaStream">REST API Reference for RemoveFlowMediaStream Operation</seealso>
        public virtual Task<RemoveFlowMediaStreamResponse> RemoveFlowMediaStreamAsync(RemoveFlowMediaStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowMediaStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowMediaStreamResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveFlowMediaStreamResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveFlowOutput

        internal virtual RemoveFlowOutputResponse RemoveFlowOutput(RemoveFlowOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowOutputResponseUnmarshaller.Instance;

            return Invoke<RemoveFlowOutputResponse>(request, options);
        }



        /// <summary>
        /// Removes an output from an existing flow. This request can be made only on an output
        /// that does not have an entitlement associated with it. If the output has an entitlement,
        /// you must revoke the entitlement instead. When an entitlement is revoked from a flow,
        /// the service automatically removes the associated output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveFlowOutput service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowOutput">REST API Reference for RemoveFlowOutput Operation</seealso>
        public virtual Task<RemoveFlowOutputResponse> RemoveFlowOutputAsync(RemoveFlowOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowOutputResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveFlowOutputResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveFlowSource

        internal virtual RemoveFlowSourceResponse RemoveFlowSource(RemoveFlowSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowSourceResponseUnmarshaller.Instance;

            return Invoke<RemoveFlowSourceResponse>(request, options);
        }



        /// <summary>
        /// Removes a source from an existing flow. This request can be made only if there is
        /// more than one source on the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveFlowSource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowSource">REST API Reference for RemoveFlowSource Operation</seealso>
        public virtual Task<RemoveFlowSourceResponse> RemoveFlowSourceAsync(RemoveFlowSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowSourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveFlowSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveFlowVpcInterface

        internal virtual RemoveFlowVpcInterfaceResponse RemoveFlowVpcInterface(RemoveFlowVpcInterfaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowVpcInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowVpcInterfaceResponseUnmarshaller.Instance;

            return Invoke<RemoveFlowVpcInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Removes a VPC Interface from an existing flow. This request can be made only on a
        /// VPC interface that does not have a Source or Output associated with it. If the VPC
        /// interface is referenced by a Source or Output, you must first delete or update the
        /// Source or Output to no longer reference the VPC interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowVpcInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveFlowVpcInterface service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowVpcInterface">REST API Reference for RemoveFlowVpcInterface Operation</seealso>
        public virtual Task<RemoveFlowVpcInterfaceResponse> RemoveFlowVpcInterfaceAsync(RemoveFlowVpcInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowVpcInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowVpcInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveFlowVpcInterfaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RevokeFlowEntitlement

        internal virtual RevokeFlowEntitlementResponse RevokeFlowEntitlement(RevokeFlowEntitlementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeFlowEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeFlowEntitlementResponseUnmarshaller.Instance;

            return Invoke<RevokeFlowEntitlementResponse>(request, options);
        }



        /// <summary>
        /// Revokes an entitlement from a flow. Once an entitlement is revoked, the content becomes
        /// unavailable to the subscriber and the associated output is removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeFlowEntitlement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeFlowEntitlement service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RevokeFlowEntitlement">REST API Reference for RevokeFlowEntitlement Operation</seealso>
        public virtual Task<RevokeFlowEntitlementResponse> RevokeFlowEntitlementAsync(RevokeFlowEntitlementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeFlowEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeFlowEntitlementResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeFlowEntitlementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartFlow

        internal virtual StartFlowResponse StartFlow(StartFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowResponseUnmarshaller.Instance;

            return Invoke<StartFlowResponse>(request, options);
        }



        /// <summary>
        /// Starts a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StartFlow">REST API Reference for StartFlow Operation</seealso>
        public virtual Task<StartFlowResponse> StartFlowAsync(StartFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowResponseUnmarshaller.Instance;

            return InvokeAsync<StartFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopFlow

        internal virtual StopFlowResponse StopFlow(StopFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFlowResponseUnmarshaller.Instance;

            return Invoke<StopFlowResponse>(request, options);
        }



        /// <summary>
        /// Stops a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StopFlow">REST API Reference for StopFlow Operation</seealso>
        public virtual Task<StopFlowResponse> StopFlowAsync(StopFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFlowResponseUnmarshaller.Instance;

            return InvokeAsync<StopFlowResponse>(request, options, cancellationToken);
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
        /// Associates the specified tags to a resource with the specified <c>resourceArn</c>.
        /// If existing tags on a resource are not specified in the request parameters, they are
        /// not changed. When a resource is deleted, the tags associated with that resource are
        /// deleted as well.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBridge

        internal virtual UpdateBridgeResponse UpdateBridge(UpdateBridgeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeResponseUnmarshaller.Instance;

            return Invoke<UpdateBridgeResponse>(request, options);
        }



        /// <summary>
        /// Updates the bridge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBridge service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBridge service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateBridge">REST API Reference for UpdateBridge Operation</seealso>
        public virtual Task<UpdateBridgeResponse> UpdateBridgeAsync(UpdateBridgeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBridgeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBridgeOutput

        internal virtual UpdateBridgeOutputResponse UpdateBridgeOutput(UpdateBridgeOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeOutputResponseUnmarshaller.Instance;

            return Invoke<UpdateBridgeOutputResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing bridge output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBridgeOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBridgeOutput service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateBridgeOutput">REST API Reference for UpdateBridgeOutput Operation</seealso>
        public virtual Task<UpdateBridgeOutputResponse> UpdateBridgeOutputAsync(UpdateBridgeOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeOutputResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBridgeOutputResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBridgeSource

        internal virtual UpdateBridgeSourceResponse UpdateBridgeSource(UpdateBridgeSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateBridgeSourceResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing bridge source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBridgeSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBridgeSource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateBridgeSource">REST API Reference for UpdateBridgeSource Operation</seealso>
        public virtual Task<UpdateBridgeSourceResponse> UpdateBridgeSourceAsync(UpdateBridgeSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeSourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBridgeSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBridgeState

        internal virtual UpdateBridgeStateResponse UpdateBridgeState(UpdateBridgeStateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeStateResponseUnmarshaller.Instance;

            return Invoke<UpdateBridgeStateResponse>(request, options);
        }



        /// <summary>
        /// Updates the bridge state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBridgeState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBridgeState service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateBridgeState">REST API Reference for UpdateBridgeState Operation</seealso>
        public virtual Task<UpdateBridgeStateResponse> UpdateBridgeStateAsync(UpdateBridgeStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeStateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBridgeStateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFlow

        internal virtual UpdateFlowResponse UpdateFlow(UpdateFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlow">REST API Reference for UpdateFlow Operation</seealso>
        public virtual Task<UpdateFlowResponse> UpdateFlowAsync(UpdateFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFlowEntitlement

        internal virtual UpdateFlowEntitlementResponse UpdateFlowEntitlement(UpdateFlowEntitlementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowEntitlementResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowEntitlementResponse>(request, options);
        }



        /// <summary>
        /// Updates an entitlement. You can change an entitlement's description, subscribers,
        /// and encryption. If you change the subscribers, the service will remove the outputs
        /// that are are used by the subscribers that are removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowEntitlement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFlowEntitlement service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowEntitlement">REST API Reference for UpdateFlowEntitlement Operation</seealso>
        public virtual Task<UpdateFlowEntitlementResponse> UpdateFlowEntitlementAsync(UpdateFlowEntitlementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowEntitlementResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFlowEntitlementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFlowMediaStream

        internal virtual UpdateFlowMediaStreamResponse UpdateFlowMediaStream(UpdateFlowMediaStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowMediaStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowMediaStreamResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowMediaStreamResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing media stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowMediaStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFlowMediaStream service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowMediaStream">REST API Reference for UpdateFlowMediaStream Operation</seealso>
        public virtual Task<UpdateFlowMediaStreamResponse> UpdateFlowMediaStreamAsync(UpdateFlowMediaStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowMediaStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowMediaStreamResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFlowMediaStreamResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFlowOutput

        internal virtual UpdateFlowOutputResponse UpdateFlowOutput(UpdateFlowOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowOutputResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowOutputResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing flow output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFlowOutput service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowOutput">REST API Reference for UpdateFlowOutput Operation</seealso>
        public virtual Task<UpdateFlowOutputResponse> UpdateFlowOutputAsync(UpdateFlowOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowOutputResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFlowOutputResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFlowSource

        internal virtual UpdateFlowSourceResponse UpdateFlowSource(UpdateFlowSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowSourceResponse>(request, options);
        }



        /// <summary>
        /// Updates the source of a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFlowSource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowSource">REST API Reference for UpdateFlowSource Operation</seealso>
        public virtual Task<UpdateFlowSourceResponse> UpdateFlowSourceAsync(UpdateFlowSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowSourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFlowSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGatewayInstance

        internal virtual UpdateGatewayInstanceResponse UpdateGatewayInstance(UpdateGatewayInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayInstanceResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing gateway instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGatewayInstance service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// This exception is thrown if the request contains a semantic error. The precise meaning
        /// depends on the API, and is documented in the error message.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateGatewayInstance">REST API Reference for UpdateGatewayInstance Operation</seealso>
        public virtual Task<UpdateGatewayInstanceResponse> UpdateGatewayInstanceAsync(UpdateGatewayInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGatewayInstanceResponse>(request, options, cancellationToken);
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