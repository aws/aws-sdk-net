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
using System.Collections.Generic;
using System.Net;

using Amazon.MediaConnect.Model;
using Amazon.MediaConnect.Model.Internal.MarshallTransformations;
using Amazon.MediaConnect.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaConnectConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaConnectConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMediaConnectEndpointResolver());
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

        /// <summary>
        /// Adds outputs to an existing bridge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddBridgeOutputs service method.</param>
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
        public virtual AddBridgeOutputsResponse AddBridgeOutputs(AddBridgeOutputsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddBridgeOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddBridgeOutputsResponseUnmarshaller.Instance;

            return Invoke<AddBridgeOutputsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddBridgeOutputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddBridgeOutputs operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddBridgeOutputs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddBridgeOutputs">REST API Reference for AddBridgeOutputs Operation</seealso>
        public virtual IAsyncResult BeginAddBridgeOutputs(AddBridgeOutputsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddBridgeOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddBridgeOutputsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddBridgeOutputs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddBridgeOutputs.</param>
        /// 
        /// <returns>Returns a  AddBridgeOutputsResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddBridgeOutputs">REST API Reference for AddBridgeOutputs Operation</seealso>
        public virtual AddBridgeOutputsResponse EndAddBridgeOutputs(IAsyncResult asyncResult)
        {
            return EndInvoke<AddBridgeOutputsResponse>(asyncResult);
        }

        #endregion
        
        #region  AddBridgeSources

        /// <summary>
        /// Adds sources to an existing bridge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddBridgeSources service method.</param>
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
        public virtual AddBridgeSourcesResponse AddBridgeSources(AddBridgeSourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddBridgeSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddBridgeSourcesResponseUnmarshaller.Instance;

            return Invoke<AddBridgeSourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddBridgeSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddBridgeSources operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddBridgeSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddBridgeSources">REST API Reference for AddBridgeSources Operation</seealso>
        public virtual IAsyncResult BeginAddBridgeSources(AddBridgeSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddBridgeSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddBridgeSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddBridgeSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddBridgeSources.</param>
        /// 
        /// <returns>Returns a  AddBridgeSourcesResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddBridgeSources">REST API Reference for AddBridgeSources Operation</seealso>
        public virtual AddBridgeSourcesResponse EndAddBridgeSources(IAsyncResult asyncResult)
        {
            return EndInvoke<AddBridgeSourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  AddFlowMediaStreams

        /// <summary>
        /// Adds media streams to an existing flow. After you add a media stream to a flow, you
        /// can associate it with a source and/or an output that uses the ST 2110 JPEG XS or CDI
        /// protocol.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFlowMediaStreams service method.</param>
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
        public virtual AddFlowMediaStreamsResponse AddFlowMediaStreams(AddFlowMediaStreamsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowMediaStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowMediaStreamsResponseUnmarshaller.Instance;

            return Invoke<AddFlowMediaStreamsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddFlowMediaStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddFlowMediaStreams operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddFlowMediaStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowMediaStreams">REST API Reference for AddFlowMediaStreams Operation</seealso>
        public virtual IAsyncResult BeginAddFlowMediaStreams(AddFlowMediaStreamsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowMediaStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowMediaStreamsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddFlowMediaStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddFlowMediaStreams.</param>
        /// 
        /// <returns>Returns a  AddFlowMediaStreamsResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowMediaStreams">REST API Reference for AddFlowMediaStreams Operation</seealso>
        public virtual AddFlowMediaStreamsResponse EndAddFlowMediaStreams(IAsyncResult asyncResult)
        {
            return EndInvoke<AddFlowMediaStreamsResponse>(asyncResult);
        }

        #endregion
        
        #region  AddFlowOutputs

        /// <summary>
        /// Adds outputs to an existing flow. You can create up to 50 outputs per flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFlowOutputs service method.</param>
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
        public virtual AddFlowOutputsResponse AddFlowOutputs(AddFlowOutputsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowOutputsResponseUnmarshaller.Instance;

            return Invoke<AddFlowOutputsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddFlowOutputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddFlowOutputs operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddFlowOutputs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowOutputs">REST API Reference for AddFlowOutputs Operation</seealso>
        public virtual IAsyncResult BeginAddFlowOutputs(AddFlowOutputsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowOutputsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddFlowOutputs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddFlowOutputs.</param>
        /// 
        /// <returns>Returns a  AddFlowOutputsResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowOutputs">REST API Reference for AddFlowOutputs Operation</seealso>
        public virtual AddFlowOutputsResponse EndAddFlowOutputs(IAsyncResult asyncResult)
        {
            return EndInvoke<AddFlowOutputsResponse>(asyncResult);
        }

        #endregion
        
        #region  AddFlowSources

        /// <summary>
        /// Adds sources to a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFlowSources service method.</param>
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
        public virtual AddFlowSourcesResponse AddFlowSources(AddFlowSourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowSourcesResponseUnmarshaller.Instance;

            return Invoke<AddFlowSourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddFlowSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddFlowSources operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddFlowSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowSources">REST API Reference for AddFlowSources Operation</seealso>
        public virtual IAsyncResult BeginAddFlowSources(AddFlowSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddFlowSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddFlowSources.</param>
        /// 
        /// <returns>Returns a  AddFlowSourcesResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowSources">REST API Reference for AddFlowSources Operation</seealso>
        public virtual AddFlowSourcesResponse EndAddFlowSources(IAsyncResult asyncResult)
        {
            return EndInvoke<AddFlowSourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  AddFlowVpcInterfaces

        /// <summary>
        /// Adds VPC interfaces to a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFlowVpcInterfaces service method.</param>
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
        public virtual AddFlowVpcInterfacesResponse AddFlowVpcInterfaces(AddFlowVpcInterfacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowVpcInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowVpcInterfacesResponseUnmarshaller.Instance;

            return Invoke<AddFlowVpcInterfacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddFlowVpcInterfaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddFlowVpcInterfaces operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddFlowVpcInterfaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowVpcInterfaces">REST API Reference for AddFlowVpcInterfaces Operation</seealso>
        public virtual IAsyncResult BeginAddFlowVpcInterfaces(AddFlowVpcInterfacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddFlowVpcInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddFlowVpcInterfacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddFlowVpcInterfaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddFlowVpcInterfaces.</param>
        /// 
        /// <returns>Returns a  AddFlowVpcInterfacesResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowVpcInterfaces">REST API Reference for AddFlowVpcInterfaces Operation</seealso>
        public virtual AddFlowVpcInterfacesResponse EndAddFlowVpcInterfaces(IAsyncResult asyncResult)
        {
            return EndInvoke<AddFlowVpcInterfacesResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetRouterInput

        /// <summary>
        /// Retrieves information about multiple router inputs in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRouterInput service method.</param>
        /// 
        /// <returns>The response from the BatchGetRouterInput service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/BatchGetRouterInput">REST API Reference for BatchGetRouterInput Operation</seealso>
        public virtual BatchGetRouterInputResponse BatchGetRouterInput(BatchGetRouterInputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetRouterInputResponseUnmarshaller.Instance;

            return Invoke<BatchGetRouterInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetRouterInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRouterInput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetRouterInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/BatchGetRouterInput">REST API Reference for BatchGetRouterInput Operation</seealso>
        public virtual IAsyncResult BeginBatchGetRouterInput(BatchGetRouterInputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetRouterInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetRouterInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetRouterInput.</param>
        /// 
        /// <returns>Returns a  BatchGetRouterInputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/BatchGetRouterInput">REST API Reference for BatchGetRouterInput Operation</seealso>
        public virtual BatchGetRouterInputResponse EndBatchGetRouterInput(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetRouterInputResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetRouterNetworkInterface

        /// <summary>
        /// Retrieves information about multiple router network interfaces in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRouterNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the BatchGetRouterNetworkInterface service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/BatchGetRouterNetworkInterface">REST API Reference for BatchGetRouterNetworkInterface Operation</seealso>
        public virtual BatchGetRouterNetworkInterfaceResponse BatchGetRouterNetworkInterface(BatchGetRouterNetworkInterfaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetRouterNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetRouterNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<BatchGetRouterNetworkInterfaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetRouterNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRouterNetworkInterface operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetRouterNetworkInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/BatchGetRouterNetworkInterface">REST API Reference for BatchGetRouterNetworkInterface Operation</seealso>
        public virtual IAsyncResult BeginBatchGetRouterNetworkInterface(BatchGetRouterNetworkInterfaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetRouterNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetRouterNetworkInterfaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetRouterNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetRouterNetworkInterface.</param>
        /// 
        /// <returns>Returns a  BatchGetRouterNetworkInterfaceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/BatchGetRouterNetworkInterface">REST API Reference for BatchGetRouterNetworkInterface Operation</seealso>
        public virtual BatchGetRouterNetworkInterfaceResponse EndBatchGetRouterNetworkInterface(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetRouterNetworkInterfaceResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetRouterOutput

        /// <summary>
        /// Retrieves information about multiple router outputs in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRouterOutput service method.</param>
        /// 
        /// <returns>The response from the BatchGetRouterOutput service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/BatchGetRouterOutput">REST API Reference for BatchGetRouterOutput Operation</seealso>
        public virtual BatchGetRouterOutputResponse BatchGetRouterOutput(BatchGetRouterOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetRouterOutputResponseUnmarshaller.Instance;

            return Invoke<BatchGetRouterOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRouterOutput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetRouterOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/BatchGetRouterOutput">REST API Reference for BatchGetRouterOutput Operation</seealso>
        public virtual IAsyncResult BeginBatchGetRouterOutput(BatchGetRouterOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetRouterOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetRouterOutput.</param>
        /// 
        /// <returns>Returns a  BatchGetRouterOutputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/BatchGetRouterOutput">REST API Reference for BatchGetRouterOutput Operation</seealso>
        public virtual BatchGetRouterOutputResponse EndBatchGetRouterOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetRouterOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBridge

        /// <summary>
        /// Creates a new bridge. The request must include one source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBridge service method.</param>
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
        public virtual CreateBridgeResponse CreateBridge(CreateBridgeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBridgeResponseUnmarshaller.Instance;

            return Invoke<CreateBridgeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBridge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBridge operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBridge
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateBridge">REST API Reference for CreateBridge Operation</seealso>
        public virtual IAsyncResult BeginCreateBridge(CreateBridgeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBridgeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBridge operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBridge.</param>
        /// 
        /// <returns>Returns a  CreateBridgeResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateBridge">REST API Reference for CreateBridge Operation</seealso>
        public virtual CreateBridgeResponse EndCreateBridge(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBridgeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFlow

        /// <summary>
        /// Creates a new flow. The request must include one source. The request optionally can
        /// include outputs (up to 50) and entitlements (up to 50).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlow service method.</param>
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
        public virtual CreateFlowResponse CreateFlow(CreateFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowResponseUnmarshaller.Instance;

            return Invoke<CreateFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFlow operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateFlow">REST API Reference for CreateFlow Operation</seealso>
        public virtual IAsyncResult BeginCreateFlow(CreateFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFlow.</param>
        /// 
        /// <returns>Returns a  CreateFlowResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateFlow">REST API Reference for CreateFlow Operation</seealso>
        public virtual CreateFlowResponse EndCreateFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGateway

        /// <summary>
        /// Creates a new gateway. The request must include at least one network (up to four).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway service method.</param>
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
        public virtual CreateGatewayResponse CreateGateway(CreateGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        public virtual IAsyncResult BeginCreateGateway(CreateGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGateway.</param>
        /// 
        /// <returns>Returns a  CreateGatewayResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        public virtual CreateGatewayResponse EndCreateGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRouterInput

        /// <summary>
        /// Creates a new router input in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouterInput service method.</param>
        /// 
        /// <returns>The response from the CreateRouterInput service method, as returned by MediaConnect.</returns>
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
        /// <exception cref="Amazon.MediaConnect.Model.RouterInputServiceQuotaExceededException">
        /// The request to create a new router input would exceed the service quotas for the account.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateRouterInput">REST API Reference for CreateRouterInput Operation</seealso>
        public virtual CreateRouterInputResponse CreateRouterInput(CreateRouterInputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouterInputResponseUnmarshaller.Instance;

            return Invoke<CreateRouterInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouterInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouterInput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRouterInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateRouterInput">REST API Reference for CreateRouterInput Operation</seealso>
        public virtual IAsyncResult BeginCreateRouterInput(CreateRouterInputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouterInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRouterInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRouterInput.</param>
        /// 
        /// <returns>Returns a  CreateRouterInputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateRouterInput">REST API Reference for CreateRouterInput Operation</seealso>
        public virtual CreateRouterInputResponse EndCreateRouterInput(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRouterInputResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRouterNetworkInterface

        /// <summary>
        /// Creates a new router network interface in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouterNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the CreateRouterNetworkInterface service method, as returned by MediaConnect.</returns>
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
        /// <exception cref="Amazon.MediaConnect.Model.RouterNetworkInterfaceServiceQuotaExceededException">
        /// The request to create a new router network interface would exceed the service quotas
        /// (limits) set for the account.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateRouterNetworkInterface">REST API Reference for CreateRouterNetworkInterface Operation</seealso>
        public virtual CreateRouterNetworkInterfaceResponse CreateRouterNetworkInterface(CreateRouterNetworkInterfaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouterNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouterNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<CreateRouterNetworkInterfaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouterNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouterNetworkInterface operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRouterNetworkInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateRouterNetworkInterface">REST API Reference for CreateRouterNetworkInterface Operation</seealso>
        public virtual IAsyncResult BeginCreateRouterNetworkInterface(CreateRouterNetworkInterfaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouterNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouterNetworkInterfaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRouterNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRouterNetworkInterface.</param>
        /// 
        /// <returns>Returns a  CreateRouterNetworkInterfaceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateRouterNetworkInterface">REST API Reference for CreateRouterNetworkInterface Operation</seealso>
        public virtual CreateRouterNetworkInterfaceResponse EndCreateRouterNetworkInterface(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRouterNetworkInterfaceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRouterOutput

        /// <summary>
        /// Creates a new router output in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouterOutput service method.</param>
        /// 
        /// <returns>The response from the CreateRouterOutput service method, as returned by MediaConnect.</returns>
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
        /// <exception cref="Amazon.MediaConnect.Model.RouterOutputServiceQuotaExceededException">
        /// The request to create a new router output would exceed the service quotas (limits)
        /// set for the account.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateRouterOutput">REST API Reference for CreateRouterOutput Operation</seealso>
        public virtual CreateRouterOutputResponse CreateRouterOutput(CreateRouterOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouterOutputResponseUnmarshaller.Instance;

            return Invoke<CreateRouterOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouterOutput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRouterOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateRouterOutput">REST API Reference for CreateRouterOutput Operation</seealso>
        public virtual IAsyncResult BeginCreateRouterOutput(CreateRouterOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouterOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRouterOutput.</param>
        /// 
        /// <returns>Returns a  CreateRouterOutputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateRouterOutput">REST API Reference for CreateRouterOutput Operation</seealso>
        public virtual CreateRouterOutputResponse EndCreateRouterOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRouterOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBridge

        /// <summary>
        /// Deletes a bridge. Before you can delete a bridge, you must stop the bridge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBridge service method.</param>
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
        public virtual DeleteBridgeResponse DeleteBridge(DeleteBridgeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBridgeResponseUnmarshaller.Instance;

            return Invoke<DeleteBridgeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBridge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBridge operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBridge
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteBridge">REST API Reference for DeleteBridge Operation</seealso>
        public virtual IAsyncResult BeginDeleteBridge(DeleteBridgeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBridgeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBridge operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBridge.</param>
        /// 
        /// <returns>Returns a  DeleteBridgeResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteBridge">REST API Reference for DeleteBridge Operation</seealso>
        public virtual DeleteBridgeResponse EndDeleteBridge(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBridgeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFlow

        /// <summary>
        /// Deletes a flow. Before you can delete a flow, you must stop the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlow service method.</param>
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
        public virtual DeleteFlowResponse DeleteFlow(DeleteFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlow operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteFlow">REST API Reference for DeleteFlow Operation</seealso>
        public virtual IAsyncResult BeginDeleteFlow(DeleteFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFlow.</param>
        /// 
        /// <returns>Returns a  DeleteFlowResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteFlow">REST API Reference for DeleteFlow Operation</seealso>
        public virtual DeleteFlowResponse EndDeleteFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGateway

        /// <summary>
        /// Deletes a gateway. Before you can delete a gateway, you must deregister its instances
        /// and delete its bridges.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
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
        public virtual DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        public virtual IAsyncResult BeginDeleteGateway(DeleteGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGateway.</param>
        /// 
        /// <returns>Returns a  DeleteGatewayResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        public virtual DeleteGatewayResponse EndDeleteGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRouterInput

        /// <summary>
        /// Deletes a router input from AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouterInput service method.</param>
        /// 
        /// <returns>The response from the DeleteRouterInput service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteRouterInput">REST API Reference for DeleteRouterInput Operation</seealso>
        public virtual DeleteRouterInputResponse DeleteRouterInput(DeleteRouterInputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouterInputResponseUnmarshaller.Instance;

            return Invoke<DeleteRouterInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouterInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouterInput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRouterInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteRouterInput">REST API Reference for DeleteRouterInput Operation</seealso>
        public virtual IAsyncResult BeginDeleteRouterInput(DeleteRouterInputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouterInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRouterInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouterInput.</param>
        /// 
        /// <returns>Returns a  DeleteRouterInputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteRouterInput">REST API Reference for DeleteRouterInput Operation</seealso>
        public virtual DeleteRouterInputResponse EndDeleteRouterInput(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRouterInputResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRouterNetworkInterface

        /// <summary>
        /// Deletes a router network interface from AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouterNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the DeleteRouterNetworkInterface service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteRouterNetworkInterface">REST API Reference for DeleteRouterNetworkInterface Operation</seealso>
        public virtual DeleteRouterNetworkInterfaceResponse DeleteRouterNetworkInterface(DeleteRouterNetworkInterfaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouterNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouterNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<DeleteRouterNetworkInterfaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouterNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouterNetworkInterface operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRouterNetworkInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteRouterNetworkInterface">REST API Reference for DeleteRouterNetworkInterface Operation</seealso>
        public virtual IAsyncResult BeginDeleteRouterNetworkInterface(DeleteRouterNetworkInterfaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouterNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouterNetworkInterfaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRouterNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouterNetworkInterface.</param>
        /// 
        /// <returns>Returns a  DeleteRouterNetworkInterfaceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteRouterNetworkInterface">REST API Reference for DeleteRouterNetworkInterface Operation</seealso>
        public virtual DeleteRouterNetworkInterfaceResponse EndDeleteRouterNetworkInterface(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRouterNetworkInterfaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRouterOutput

        /// <summary>
        /// Deletes a router output from AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouterOutput service method.</param>
        /// 
        /// <returns>The response from the DeleteRouterOutput service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteRouterOutput">REST API Reference for DeleteRouterOutput Operation</seealso>
        public virtual DeleteRouterOutputResponse DeleteRouterOutput(DeleteRouterOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouterOutputResponseUnmarshaller.Instance;

            return Invoke<DeleteRouterOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouterOutput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRouterOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteRouterOutput">REST API Reference for DeleteRouterOutput Operation</seealso>
        public virtual IAsyncResult BeginDeleteRouterOutput(DeleteRouterOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouterOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouterOutput.</param>
        /// 
        /// <returns>Returns a  DeleteRouterOutputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteRouterOutput">REST API Reference for DeleteRouterOutput Operation</seealso>
        public virtual DeleteRouterOutputResponse EndDeleteRouterOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRouterOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterGatewayInstance

        /// <summary>
        /// Deregisters an instance. Before you deregister an instance, all bridges running on
        /// the instance must be stopped. If you want to deregister an instance without stopping
        /// the bridges, you must use the --force option.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterGatewayInstance service method.</param>
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
        public virtual DeregisterGatewayInstanceResponse DeregisterGatewayInstance(DeregisterGatewayInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterGatewayInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterGatewayInstanceResponseUnmarshaller.Instance;

            return Invoke<DeregisterGatewayInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterGatewayInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterGatewayInstance operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterGatewayInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeregisterGatewayInstance">REST API Reference for DeregisterGatewayInstance Operation</seealso>
        public virtual IAsyncResult BeginDeregisterGatewayInstance(DeregisterGatewayInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterGatewayInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterGatewayInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterGatewayInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterGatewayInstance.</param>
        /// 
        /// <returns>Returns a  DeregisterGatewayInstanceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeregisterGatewayInstance">REST API Reference for DeregisterGatewayInstance Operation</seealso>
        public virtual DeregisterGatewayInstanceResponse EndDeregisterGatewayInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterGatewayInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBridge

        /// <summary>
        /// Displays the details of a bridge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBridge service method.</param>
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
        public virtual DescribeBridgeResponse DescribeBridge(DescribeBridgeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBridgeResponseUnmarshaller.Instance;

            return Invoke<DescribeBridgeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBridge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBridge operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBridge
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeBridge">REST API Reference for DescribeBridge Operation</seealso>
        public virtual IAsyncResult BeginDescribeBridge(DescribeBridgeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBridgeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBridge operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBridge.</param>
        /// 
        /// <returns>Returns a  DescribeBridgeResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeBridge">REST API Reference for DescribeBridge Operation</seealso>
        public virtual DescribeBridgeResponse EndDescribeBridge(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBridgeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFlow

        /// <summary>
        /// Displays the details of a flow. The response includes the flow Amazon Resource Name
        /// (ARN), name, and Availability Zone, as well as details about the source, outputs,
        /// and entitlements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlow service method.</param>
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
        public virtual DescribeFlowResponse DescribeFlow(DescribeFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlow operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeFlow">REST API Reference for DescribeFlow Operation</seealso>
        public virtual IAsyncResult BeginDescribeFlow(DescribeFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFlow.</param>
        /// 
        /// <returns>Returns a  DescribeFlowResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeFlow">REST API Reference for DescribeFlow Operation</seealso>
        public virtual DescribeFlowResponse EndDescribeFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFlowSourceMetadata

        /// <summary>
        /// The <c>DescribeFlowSourceMetadata</c> API is used to view information about the flow's
        /// source transport stream and programs. This API displays status messages about the
        /// flow's source as well as details about the program's video, audio, and other data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowSourceMetadata service method.</param>
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
        public virtual DescribeFlowSourceMetadataResponse DescribeFlowSourceMetadata(DescribeFlowSourceMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowSourceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowSourceMetadataResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowSourceMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFlowSourceMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowSourceMetadata operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFlowSourceMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeFlowSourceMetadata">REST API Reference for DescribeFlowSourceMetadata Operation</seealso>
        public virtual IAsyncResult BeginDescribeFlowSourceMetadata(DescribeFlowSourceMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowSourceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowSourceMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFlowSourceMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFlowSourceMetadata.</param>
        /// 
        /// <returns>Returns a  DescribeFlowSourceMetadataResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeFlowSourceMetadata">REST API Reference for DescribeFlowSourceMetadata Operation</seealso>
        public virtual DescribeFlowSourceMetadataResponse EndDescribeFlowSourceMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFlowSourceMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFlowSourceThumbnail

        /// <summary>
        /// Describes the thumbnail for the flow source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowSourceThumbnail service method.</param>
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
        public virtual DescribeFlowSourceThumbnailResponse DescribeFlowSourceThumbnail(DescribeFlowSourceThumbnailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowSourceThumbnailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowSourceThumbnailResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowSourceThumbnailResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFlowSourceThumbnail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowSourceThumbnail operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFlowSourceThumbnail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeFlowSourceThumbnail">REST API Reference for DescribeFlowSourceThumbnail Operation</seealso>
        public virtual IAsyncResult BeginDescribeFlowSourceThumbnail(DescribeFlowSourceThumbnailRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowSourceThumbnailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowSourceThumbnailResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFlowSourceThumbnail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFlowSourceThumbnail.</param>
        /// 
        /// <returns>Returns a  DescribeFlowSourceThumbnailResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeFlowSourceThumbnail">REST API Reference for DescribeFlowSourceThumbnail Operation</seealso>
        public virtual DescribeFlowSourceThumbnailResponse EndDescribeFlowSourceThumbnail(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFlowSourceThumbnailResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGateway

        /// <summary>
        /// Displays the details of a gateway. The response includes the gateway Amazon Resource
        /// Name (ARN), name, and CIDR blocks, as well as details about the networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGateway service method.</param>
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
        public virtual DescribeGatewayResponse DescribeGateway(DescribeGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayResponseUnmarshaller.Instance;

            return Invoke<DescribeGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGateway operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeGateway">REST API Reference for DescribeGateway Operation</seealso>
        public virtual IAsyncResult BeginDescribeGateway(DescribeGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGateway.</param>
        /// 
        /// <returns>Returns a  DescribeGatewayResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeGateway">REST API Reference for DescribeGateway Operation</seealso>
        public virtual DescribeGatewayResponse EndDescribeGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGatewayInstance

        /// <summary>
        /// Displays the details of an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInstance service method.</param>
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
        public virtual DescribeGatewayInstanceResponse DescribeGatewayInstance(DescribeGatewayInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeGatewayInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGatewayInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayInstance operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGatewayInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeGatewayInstance">REST API Reference for DescribeGatewayInstance Operation</seealso>
        public virtual IAsyncResult BeginDescribeGatewayInstance(DescribeGatewayInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGatewayInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGatewayInstance.</param>
        /// 
        /// <returns>Returns a  DescribeGatewayInstanceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeGatewayInstance">REST API Reference for DescribeGatewayInstance Operation</seealso>
        public virtual DescribeGatewayInstanceResponse EndDescribeGatewayInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGatewayInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOffering

        /// <summary>
        /// Displays the details of an offering. The response includes the offering description,
        /// duration, outbound bandwidth, price, and Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOffering service method.</param>
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
        public virtual DescribeOfferingResponse DescribeOffering(DescribeOfferingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOfferingResponseUnmarshaller.Instance;

            return Invoke<DescribeOfferingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOffering operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeOffering">REST API Reference for DescribeOffering Operation</seealso>
        public virtual IAsyncResult BeginDescribeOffering(DescribeOfferingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOfferingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOffering.</param>
        /// 
        /// <returns>Returns a  DescribeOfferingResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeOffering">REST API Reference for DescribeOffering Operation</seealso>
        public virtual DescribeOfferingResponse EndDescribeOffering(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOfferingResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReservation

        /// <summary>
        /// Displays the details of a reservation. The response includes the reservation name,
        /// state, start date and time, and the details of the offering that make up the rest
        /// of the reservation (such as price, duration, and outbound bandwidth).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservation service method.</param>
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
        public virtual DescribeReservationResponse DescribeReservation(DescribeReservationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservationResponseUnmarshaller.Instance;

            return Invoke<DescribeReservationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservation operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeReservation">REST API Reference for DescribeReservation Operation</seealso>
        public virtual IAsyncResult BeginDescribeReservation(DescribeReservationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservation.</param>
        /// 
        /// <returns>Returns a  DescribeReservationResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeReservation">REST API Reference for DescribeReservation Operation</seealso>
        public virtual DescribeReservationResponse EndDescribeReservation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReservationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRouterInput

        /// <summary>
        /// Retrieves information about a specific router input in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouterInput service method.</param>
        /// 
        /// <returns>The response from the GetRouterInput service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GetRouterInput">REST API Reference for GetRouterInput Operation</seealso>
        public virtual GetRouterInputResponse GetRouterInput(GetRouterInputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouterInputResponseUnmarshaller.Instance;

            return Invoke<GetRouterInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRouterInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRouterInput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRouterInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GetRouterInput">REST API Reference for GetRouterInput Operation</seealso>
        public virtual IAsyncResult BeginGetRouterInput(GetRouterInputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouterInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRouterInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRouterInput.</param>
        /// 
        /// <returns>Returns a  GetRouterInputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GetRouterInput">REST API Reference for GetRouterInput Operation</seealso>
        public virtual GetRouterInputResponse EndGetRouterInput(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRouterInputResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRouterInputSourceMetadata

        /// <summary>
        /// Retrieves detailed metadata information about a specific router input source, including
        /// stream details and connection state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouterInputSourceMetadata service method.</param>
        /// 
        /// <returns>The response from the GetRouterInputSourceMetadata service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GetRouterInputSourceMetadata">REST API Reference for GetRouterInputSourceMetadata Operation</seealso>
        public virtual GetRouterInputSourceMetadataResponse GetRouterInputSourceMetadata(GetRouterInputSourceMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouterInputSourceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouterInputSourceMetadataResponseUnmarshaller.Instance;

            return Invoke<GetRouterInputSourceMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRouterInputSourceMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRouterInputSourceMetadata operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRouterInputSourceMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GetRouterInputSourceMetadata">REST API Reference for GetRouterInputSourceMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetRouterInputSourceMetadata(GetRouterInputSourceMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouterInputSourceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouterInputSourceMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRouterInputSourceMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRouterInputSourceMetadata.</param>
        /// 
        /// <returns>Returns a  GetRouterInputSourceMetadataResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GetRouterInputSourceMetadata">REST API Reference for GetRouterInputSourceMetadata Operation</seealso>
        public virtual GetRouterInputSourceMetadataResponse EndGetRouterInputSourceMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRouterInputSourceMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRouterInputThumbnail

        /// <summary>
        /// Retrieves the thumbnail for a router input in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouterInputThumbnail service method.</param>
        /// 
        /// <returns>The response from the GetRouterInputThumbnail service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GetRouterInputThumbnail">REST API Reference for GetRouterInputThumbnail Operation</seealso>
        public virtual GetRouterInputThumbnailResponse GetRouterInputThumbnail(GetRouterInputThumbnailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouterInputThumbnailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouterInputThumbnailResponseUnmarshaller.Instance;

            return Invoke<GetRouterInputThumbnailResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRouterInputThumbnail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRouterInputThumbnail operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRouterInputThumbnail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GetRouterInputThumbnail">REST API Reference for GetRouterInputThumbnail Operation</seealso>
        public virtual IAsyncResult BeginGetRouterInputThumbnail(GetRouterInputThumbnailRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouterInputThumbnailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouterInputThumbnailResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRouterInputThumbnail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRouterInputThumbnail.</param>
        /// 
        /// <returns>Returns a  GetRouterInputThumbnailResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GetRouterInputThumbnail">REST API Reference for GetRouterInputThumbnail Operation</seealso>
        public virtual GetRouterInputThumbnailResponse EndGetRouterInputThumbnail(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRouterInputThumbnailResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRouterNetworkInterface

        /// <summary>
        /// Retrieves information about a specific router network interface in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouterNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the GetRouterNetworkInterface service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GetRouterNetworkInterface">REST API Reference for GetRouterNetworkInterface Operation</seealso>
        public virtual GetRouterNetworkInterfaceResponse GetRouterNetworkInterface(GetRouterNetworkInterfaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouterNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouterNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<GetRouterNetworkInterfaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRouterNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRouterNetworkInterface operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRouterNetworkInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GetRouterNetworkInterface">REST API Reference for GetRouterNetworkInterface Operation</seealso>
        public virtual IAsyncResult BeginGetRouterNetworkInterface(GetRouterNetworkInterfaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouterNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouterNetworkInterfaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRouterNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRouterNetworkInterface.</param>
        /// 
        /// <returns>Returns a  GetRouterNetworkInterfaceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GetRouterNetworkInterface">REST API Reference for GetRouterNetworkInterface Operation</seealso>
        public virtual GetRouterNetworkInterfaceResponse EndGetRouterNetworkInterface(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRouterNetworkInterfaceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRouterOutput

        /// <summary>
        /// Retrieves information about a specific router output in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouterOutput service method.</param>
        /// 
        /// <returns>The response from the GetRouterOutput service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GetRouterOutput">REST API Reference for GetRouterOutput Operation</seealso>
        public virtual GetRouterOutputResponse GetRouterOutput(GetRouterOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouterOutputResponseUnmarshaller.Instance;

            return Invoke<GetRouterOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRouterOutput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRouterOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GetRouterOutput">REST API Reference for GetRouterOutput Operation</seealso>
        public virtual IAsyncResult BeginGetRouterOutput(GetRouterOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouterOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRouterOutput.</param>
        /// 
        /// <returns>Returns a  GetRouterOutputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GetRouterOutput">REST API Reference for GetRouterOutput Operation</seealso>
        public virtual GetRouterOutputResponse EndGetRouterOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRouterOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  GrantFlowEntitlements

        /// <summary>
        /// Grants entitlements to an existing flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GrantFlowEntitlements service method.</param>
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
        public virtual GrantFlowEntitlementsResponse GrantFlowEntitlements(GrantFlowEntitlementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GrantFlowEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GrantFlowEntitlementsResponseUnmarshaller.Instance;

            return Invoke<GrantFlowEntitlementsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GrantFlowEntitlements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GrantFlowEntitlements operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGrantFlowEntitlements
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GrantFlowEntitlements">REST API Reference for GrantFlowEntitlements Operation</seealso>
        public virtual IAsyncResult BeginGrantFlowEntitlements(GrantFlowEntitlementsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GrantFlowEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GrantFlowEntitlementsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GrantFlowEntitlements operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGrantFlowEntitlements.</param>
        /// 
        /// <returns>Returns a  GrantFlowEntitlementsResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GrantFlowEntitlements">REST API Reference for GrantFlowEntitlements Operation</seealso>
        public virtual GrantFlowEntitlementsResponse EndGrantFlowEntitlements(IAsyncResult asyncResult)
        {
            return EndInvoke<GrantFlowEntitlementsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBridges

        /// <summary>
        /// Displays a list of bridges that are associated with this account and an optionally
        /// specified Amazon Resource Name (ARN). This request returns a paginated result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBridges service method.</param>
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
        public virtual ListBridgesResponse ListBridges(ListBridgesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBridgesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBridgesResponseUnmarshaller.Instance;

            return Invoke<ListBridgesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBridges operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBridges operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBridges
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListBridges">REST API Reference for ListBridges Operation</seealso>
        public virtual IAsyncResult BeginListBridges(ListBridgesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBridgesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBridgesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBridges operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBridges.</param>
        /// 
        /// <returns>Returns a  ListBridgesResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListBridges">REST API Reference for ListBridges Operation</seealso>
        public virtual ListBridgesResponse EndListBridges(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBridgesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEntitlements

        /// <summary>
        /// Displays a list of all entitlements that have been granted to this account. This
        /// request returns 20 results per page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitlements service method.</param>
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
        public virtual ListEntitlementsResponse ListEntitlements(ListEntitlementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitlementsResponseUnmarshaller.Instance;

            return Invoke<ListEntitlementsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEntitlements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntitlements operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEntitlements
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListEntitlements">REST API Reference for ListEntitlements Operation</seealso>
        public virtual IAsyncResult BeginListEntitlements(ListEntitlementsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitlementsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEntitlements operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEntitlements.</param>
        /// 
        /// <returns>Returns a  ListEntitlementsResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListEntitlements">REST API Reference for ListEntitlements Operation</seealso>
        public virtual ListEntitlementsResponse EndListEntitlements(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEntitlementsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFlows

        /// <summary>
        /// Displays a list of flows that are associated with this account. This request returns
        /// a paginated result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlows service method.</param>
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
        public virtual ListFlowsResponse ListFlows(ListFlowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowsResponseUnmarshaller.Instance;

            return Invoke<ListFlowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFlows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFlows operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFlows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListFlows">REST API Reference for ListFlows Operation</seealso>
        public virtual IAsyncResult BeginListFlows(ListFlowsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFlows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFlows.</param>
        /// 
        /// <returns>Returns a  ListFlowsResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListFlows">REST API Reference for ListFlows Operation</seealso>
        public virtual ListFlowsResponse EndListFlows(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFlowsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGatewayInstances

        /// <summary>
        /// Displays a list of instances associated with the Amazon Web Services account. This
        /// request returns a paginated result. You can use the filterArn property to display
        /// only the instances associated with the selected Gateway Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGatewayInstances service method.</param>
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
        public virtual ListGatewayInstancesResponse ListGatewayInstances(ListGatewayInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewayInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewayInstancesResponseUnmarshaller.Instance;

            return Invoke<ListGatewayInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGatewayInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGatewayInstances operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGatewayInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListGatewayInstances">REST API Reference for ListGatewayInstances Operation</seealso>
        public virtual IAsyncResult BeginListGatewayInstances(ListGatewayInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewayInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewayInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGatewayInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGatewayInstances.</param>
        /// 
        /// <returns>Returns a  ListGatewayInstancesResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListGatewayInstances">REST API Reference for ListGatewayInstances Operation</seealso>
        public virtual ListGatewayInstancesResponse EndListGatewayInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGatewayInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGateways

        /// <summary>
        /// Displays a list of gateways that are associated with this account. This request returns
        /// a paginated result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
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
        public virtual ListGatewaysResponse ListGateways(ListGatewaysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListGatewaysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGateways operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual IAsyncResult BeginListGateways(ListGatewaysRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGateways.</param>
        /// 
        /// <returns>Returns a  ListGatewaysResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual ListGatewaysResponse EndListGateways(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGatewaysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOfferings

        /// <summary>
        /// Displays a list of all offerings that are available to this account in the current
        /// Amazon Web Services Region. If you have an active reservation (which means you've
        /// purchased an offering that has already started and hasn't expired yet), your account
        /// isn't eligible for other offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings service method.</param>
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
        public virtual ListOfferingsResponse ListOfferings(ListOfferingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingsResponseUnmarshaller.Instance;

            return Invoke<ListOfferingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        public virtual IAsyncResult BeginListOfferings(ListOfferingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOfferings.</param>
        /// 
        /// <returns>Returns a  ListOfferingsResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        public virtual ListOfferingsResponse EndListOfferings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOfferingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReservations

        /// <summary>
        /// Displays a list of all reservations that have been purchased by this account in the
        /// current Amazon Web Services Region. This list includes all reservations in all states
        /// (such as active and expired).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReservations service method.</param>
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
        public virtual ListReservationsResponse ListReservations(ListReservationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReservationsResponseUnmarshaller.Instance;

            return Invoke<ListReservationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReservations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReservations operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReservations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListReservations">REST API Reference for ListReservations Operation</seealso>
        public virtual IAsyncResult BeginListReservations(ListReservationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReservationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReservations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReservations.</param>
        /// 
        /// <returns>Returns a  ListReservationsResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListReservations">REST API Reference for ListReservations Operation</seealso>
        public virtual ListReservationsResponse EndListReservations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReservationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRouterInputs

        /// <summary>
        /// Retrieves a list of router inputs in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRouterInputs service method.</param>
        /// 
        /// <returns>The response from the ListRouterInputs service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListRouterInputs">REST API Reference for ListRouterInputs Operation</seealso>
        public virtual ListRouterInputsResponse ListRouterInputs(ListRouterInputsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRouterInputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRouterInputsResponseUnmarshaller.Instance;

            return Invoke<ListRouterInputsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRouterInputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRouterInputs operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRouterInputs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListRouterInputs">REST API Reference for ListRouterInputs Operation</seealso>
        public virtual IAsyncResult BeginListRouterInputs(ListRouterInputsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRouterInputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRouterInputsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRouterInputs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRouterInputs.</param>
        /// 
        /// <returns>Returns a  ListRouterInputsResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListRouterInputs">REST API Reference for ListRouterInputs Operation</seealso>
        public virtual ListRouterInputsResponse EndListRouterInputs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRouterInputsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRouterNetworkInterfaces

        /// <summary>
        /// Retrieves a list of router network interfaces in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRouterNetworkInterfaces service method.</param>
        /// 
        /// <returns>The response from the ListRouterNetworkInterfaces service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListRouterNetworkInterfaces">REST API Reference for ListRouterNetworkInterfaces Operation</seealso>
        public virtual ListRouterNetworkInterfacesResponse ListRouterNetworkInterfaces(ListRouterNetworkInterfacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRouterNetworkInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRouterNetworkInterfacesResponseUnmarshaller.Instance;

            return Invoke<ListRouterNetworkInterfacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRouterNetworkInterfaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRouterNetworkInterfaces operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRouterNetworkInterfaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListRouterNetworkInterfaces">REST API Reference for ListRouterNetworkInterfaces Operation</seealso>
        public virtual IAsyncResult BeginListRouterNetworkInterfaces(ListRouterNetworkInterfacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRouterNetworkInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRouterNetworkInterfacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRouterNetworkInterfaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRouterNetworkInterfaces.</param>
        /// 
        /// <returns>Returns a  ListRouterNetworkInterfacesResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListRouterNetworkInterfaces">REST API Reference for ListRouterNetworkInterfaces Operation</seealso>
        public virtual ListRouterNetworkInterfacesResponse EndListRouterNetworkInterfaces(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRouterNetworkInterfacesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRouterOutputs

        /// <summary>
        /// Retrieves a list of router outputs in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRouterOutputs service method.</param>
        /// 
        /// <returns>The response from the ListRouterOutputs service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListRouterOutputs">REST API Reference for ListRouterOutputs Operation</seealso>
        public virtual ListRouterOutputsResponse ListRouterOutputs(ListRouterOutputsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRouterOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRouterOutputsResponseUnmarshaller.Instance;

            return Invoke<ListRouterOutputsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRouterOutputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRouterOutputs operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRouterOutputs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListRouterOutputs">REST API Reference for ListRouterOutputs Operation</seealso>
        public virtual IAsyncResult BeginListRouterOutputs(ListRouterOutputsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRouterOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRouterOutputsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRouterOutputs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRouterOutputs.</param>
        /// 
        /// <returns>Returns a  ListRouterOutputsResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListRouterOutputs">REST API Reference for ListRouterOutputs Operation</seealso>
        public virtual ListRouterOutputsResponse EndListRouterOutputs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRouterOutputsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForGlobalResource

        /// <summary>
        /// Lists the tags associated with a global resource in AWS Elemental MediaConnect. The
        /// API supports the following global resources: router inputs, router outputs and router
        /// network interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForGlobalResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForGlobalResource service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListTagsForGlobalResource">REST API Reference for ListTagsForGlobalResource Operation</seealso>
        public virtual ListTagsForGlobalResourceResponse ListTagsForGlobalResource(ListTagsForGlobalResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForGlobalResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForGlobalResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForGlobalResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForGlobalResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForGlobalResource operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForGlobalResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListTagsForGlobalResource">REST API Reference for ListTagsForGlobalResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForGlobalResource(ListTagsForGlobalResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForGlobalResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForGlobalResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForGlobalResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForGlobalResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForGlobalResourceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListTagsForGlobalResource">REST API Reference for ListTagsForGlobalResource Operation</seealso>
        public virtual ListTagsForGlobalResourceResponse EndListTagsForGlobalResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForGlobalResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List all tags on a MediaConnect resource in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PurchaseOffering

        /// <summary>
        /// Submits a request to purchase an offering. If you already have an active reservation,
        /// you can't purchase another offering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering service method.</param>
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
        public virtual PurchaseOfferingResponse PurchaseOffering(PurchaseOfferingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PurchaseOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseOfferingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        public virtual IAsyncResult BeginPurchaseOffering(PurchaseOfferingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PurchaseOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseOfferingResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        public virtual PurchaseOfferingResponse EndPurchaseOffering(IAsyncResult asyncResult)
        {
            return EndInvoke<PurchaseOfferingResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveBridgeOutput

        /// <summary>
        /// Removes an output from a bridge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveBridgeOutput service method.</param>
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
        public virtual RemoveBridgeOutputResponse RemoveBridgeOutput(RemoveBridgeOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveBridgeOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveBridgeOutputResponseUnmarshaller.Instance;

            return Invoke<RemoveBridgeOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveBridgeOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveBridgeOutput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveBridgeOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveBridgeOutput">REST API Reference for RemoveBridgeOutput Operation</seealso>
        public virtual IAsyncResult BeginRemoveBridgeOutput(RemoveBridgeOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveBridgeOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveBridgeOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveBridgeOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveBridgeOutput.</param>
        /// 
        /// <returns>Returns a  RemoveBridgeOutputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveBridgeOutput">REST API Reference for RemoveBridgeOutput Operation</seealso>
        public virtual RemoveBridgeOutputResponse EndRemoveBridgeOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveBridgeOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveBridgeSource

        /// <summary>
        /// Removes a source from a bridge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveBridgeSource service method.</param>
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
        public virtual RemoveBridgeSourceResponse RemoveBridgeSource(RemoveBridgeSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveBridgeSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveBridgeSourceResponseUnmarshaller.Instance;

            return Invoke<RemoveBridgeSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveBridgeSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveBridgeSource operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveBridgeSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveBridgeSource">REST API Reference for RemoveBridgeSource Operation</seealso>
        public virtual IAsyncResult BeginRemoveBridgeSource(RemoveBridgeSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveBridgeSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveBridgeSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveBridgeSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveBridgeSource.</param>
        /// 
        /// <returns>Returns a  RemoveBridgeSourceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveBridgeSource">REST API Reference for RemoveBridgeSource Operation</seealso>
        public virtual RemoveBridgeSourceResponse EndRemoveBridgeSource(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveBridgeSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveFlowMediaStream

        /// <summary>
        /// Removes a media stream from a flow. This action is only available if the media stream
        /// is not associated with a source or output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowMediaStream service method.</param>
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
        public virtual RemoveFlowMediaStreamResponse RemoveFlowMediaStream(RemoveFlowMediaStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowMediaStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowMediaStreamResponseUnmarshaller.Instance;

            return Invoke<RemoveFlowMediaStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveFlowMediaStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowMediaStream operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveFlowMediaStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowMediaStream">REST API Reference for RemoveFlowMediaStream Operation</seealso>
        public virtual IAsyncResult BeginRemoveFlowMediaStream(RemoveFlowMediaStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowMediaStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowMediaStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveFlowMediaStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveFlowMediaStream.</param>
        /// 
        /// <returns>Returns a  RemoveFlowMediaStreamResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowMediaStream">REST API Reference for RemoveFlowMediaStream Operation</seealso>
        public virtual RemoveFlowMediaStreamResponse EndRemoveFlowMediaStream(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveFlowMediaStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveFlowOutput

        /// <summary>
        /// Removes an output from an existing flow. This request can be made only on an output
        /// that does not have an entitlement associated with it. If the output has an entitlement,
        /// you must revoke the entitlement instead. When an entitlement is revoked from a flow,
        /// the service automatically removes the associated output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowOutput service method.</param>
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
        public virtual RemoveFlowOutputResponse RemoveFlowOutput(RemoveFlowOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowOutputResponseUnmarshaller.Instance;

            return Invoke<RemoveFlowOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveFlowOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowOutput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveFlowOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowOutput">REST API Reference for RemoveFlowOutput Operation</seealso>
        public virtual IAsyncResult BeginRemoveFlowOutput(RemoveFlowOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveFlowOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveFlowOutput.</param>
        /// 
        /// <returns>Returns a  RemoveFlowOutputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowOutput">REST API Reference for RemoveFlowOutput Operation</seealso>
        public virtual RemoveFlowOutputResponse EndRemoveFlowOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveFlowOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveFlowSource

        /// <summary>
        /// Removes a source from an existing flow. This request can be made only if there is
        /// more than one source on the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowSource service method.</param>
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
        public virtual RemoveFlowSourceResponse RemoveFlowSource(RemoveFlowSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowSourceResponseUnmarshaller.Instance;

            return Invoke<RemoveFlowSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveFlowSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowSource operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveFlowSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowSource">REST API Reference for RemoveFlowSource Operation</seealso>
        public virtual IAsyncResult BeginRemoveFlowSource(RemoveFlowSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveFlowSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveFlowSource.</param>
        /// 
        /// <returns>Returns a  RemoveFlowSourceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowSource">REST API Reference for RemoveFlowSource Operation</seealso>
        public virtual RemoveFlowSourceResponse EndRemoveFlowSource(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveFlowSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveFlowVpcInterface

        /// <summary>
        /// Removes a VPC Interface from an existing flow. This request can be made only on a
        /// VPC interface that does not have a Source or Output associated with it. If the VPC
        /// interface is referenced by a Source or Output, you must first delete or update the
        /// Source or Output to no longer reference the VPC interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowVpcInterface service method.</param>
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
        public virtual RemoveFlowVpcInterfaceResponse RemoveFlowVpcInterface(RemoveFlowVpcInterfaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowVpcInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowVpcInterfaceResponseUnmarshaller.Instance;

            return Invoke<RemoveFlowVpcInterfaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveFlowVpcInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowVpcInterface operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveFlowVpcInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowVpcInterface">REST API Reference for RemoveFlowVpcInterface Operation</seealso>
        public virtual IAsyncResult BeginRemoveFlowVpcInterface(RemoveFlowVpcInterfaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFlowVpcInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFlowVpcInterfaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveFlowVpcInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveFlowVpcInterface.</param>
        /// 
        /// <returns>Returns a  RemoveFlowVpcInterfaceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowVpcInterface">REST API Reference for RemoveFlowVpcInterface Operation</seealso>
        public virtual RemoveFlowVpcInterfaceResponse EndRemoveFlowVpcInterface(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveFlowVpcInterfaceResponse>(asyncResult);
        }

        #endregion
        
        #region  RestartRouterInput

        /// <summary>
        /// Restarts a router input. This operation can be used to recover from errors or refresh
        /// the input state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestartRouterInput service method.</param>
        /// 
        /// <returns>The response from the RestartRouterInput service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RestartRouterInput">REST API Reference for RestartRouterInput Operation</seealso>
        public virtual RestartRouterInputResponse RestartRouterInput(RestartRouterInputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestartRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestartRouterInputResponseUnmarshaller.Instance;

            return Invoke<RestartRouterInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestartRouterInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestartRouterInput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestartRouterInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RestartRouterInput">REST API Reference for RestartRouterInput Operation</seealso>
        public virtual IAsyncResult BeginRestartRouterInput(RestartRouterInputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestartRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestartRouterInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestartRouterInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestartRouterInput.</param>
        /// 
        /// <returns>Returns a  RestartRouterInputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RestartRouterInput">REST API Reference for RestartRouterInput Operation</seealso>
        public virtual RestartRouterInputResponse EndRestartRouterInput(IAsyncResult asyncResult)
        {
            return EndInvoke<RestartRouterInputResponse>(asyncResult);
        }

        #endregion
        
        #region  RestartRouterOutput

        /// <summary>
        /// Restarts a router output. This operation can be used to recover from errors or refresh
        /// the output state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestartRouterOutput service method.</param>
        /// 
        /// <returns>The response from the RestartRouterOutput service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RestartRouterOutput">REST API Reference for RestartRouterOutput Operation</seealso>
        public virtual RestartRouterOutputResponse RestartRouterOutput(RestartRouterOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestartRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestartRouterOutputResponseUnmarshaller.Instance;

            return Invoke<RestartRouterOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestartRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestartRouterOutput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestartRouterOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RestartRouterOutput">REST API Reference for RestartRouterOutput Operation</seealso>
        public virtual IAsyncResult BeginRestartRouterOutput(RestartRouterOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestartRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestartRouterOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestartRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestartRouterOutput.</param>
        /// 
        /// <returns>Returns a  RestartRouterOutputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RestartRouterOutput">REST API Reference for RestartRouterOutput Operation</seealso>
        public virtual RestartRouterOutputResponse EndRestartRouterOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<RestartRouterOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeFlowEntitlement

        /// <summary>
        /// Revokes an entitlement from a flow. Once an entitlement is revoked, the content becomes
        /// unavailable to the subscriber and the associated output is removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeFlowEntitlement service method.</param>
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
        public virtual RevokeFlowEntitlementResponse RevokeFlowEntitlement(RevokeFlowEntitlementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeFlowEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeFlowEntitlementResponseUnmarshaller.Instance;

            return Invoke<RevokeFlowEntitlementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeFlowEntitlement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeFlowEntitlement operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeFlowEntitlement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RevokeFlowEntitlement">REST API Reference for RevokeFlowEntitlement Operation</seealso>
        public virtual IAsyncResult BeginRevokeFlowEntitlement(RevokeFlowEntitlementRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeFlowEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeFlowEntitlementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeFlowEntitlement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeFlowEntitlement.</param>
        /// 
        /// <returns>Returns a  RevokeFlowEntitlementResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RevokeFlowEntitlement">REST API Reference for RevokeFlowEntitlement Operation</seealso>
        public virtual RevokeFlowEntitlementResponse EndRevokeFlowEntitlement(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeFlowEntitlementResponse>(asyncResult);
        }

        #endregion
        
        #region  StartFlow

        /// <summary>
        /// Starts a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFlow service method.</param>
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
        public virtual StartFlowResponse StartFlow(StartFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowResponseUnmarshaller.Instance;

            return Invoke<StartFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFlow operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StartFlow">REST API Reference for StartFlow Operation</seealso>
        public virtual IAsyncResult BeginStartFlow(StartFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFlow.</param>
        /// 
        /// <returns>Returns a  StartFlowResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StartFlow">REST API Reference for StartFlow Operation</seealso>
        public virtual StartFlowResponse EndStartFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<StartFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  StartRouterInput

        /// <summary>
        /// Starts a router input in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRouterInput service method.</param>
        /// 
        /// <returns>The response from the StartRouterInput service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StartRouterInput">REST API Reference for StartRouterInput Operation</seealso>
        public virtual StartRouterInputResponse StartRouterInput(StartRouterInputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRouterInputResponseUnmarshaller.Instance;

            return Invoke<StartRouterInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartRouterInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRouterInput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRouterInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StartRouterInput">REST API Reference for StartRouterInput Operation</seealso>
        public virtual IAsyncResult BeginStartRouterInput(StartRouterInputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRouterInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartRouterInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRouterInput.</param>
        /// 
        /// <returns>Returns a  StartRouterInputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StartRouterInput">REST API Reference for StartRouterInput Operation</seealso>
        public virtual StartRouterInputResponse EndStartRouterInput(IAsyncResult asyncResult)
        {
            return EndInvoke<StartRouterInputResponse>(asyncResult);
        }

        #endregion
        
        #region  StartRouterOutput

        /// <summary>
        /// Starts a router output in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRouterOutput service method.</param>
        /// 
        /// <returns>The response from the StartRouterOutput service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StartRouterOutput">REST API Reference for StartRouterOutput Operation</seealso>
        public virtual StartRouterOutputResponse StartRouterOutput(StartRouterOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRouterOutputResponseUnmarshaller.Instance;

            return Invoke<StartRouterOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRouterOutput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRouterOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StartRouterOutput">REST API Reference for StartRouterOutput Operation</seealso>
        public virtual IAsyncResult BeginStartRouterOutput(StartRouterOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRouterOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRouterOutput.</param>
        /// 
        /// <returns>Returns a  StartRouterOutputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StartRouterOutput">REST API Reference for StartRouterOutput Operation</seealso>
        public virtual StartRouterOutputResponse EndStartRouterOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<StartRouterOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  StopFlow

        /// <summary>
        /// Stops a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFlow service method.</param>
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
        public virtual StopFlowResponse StopFlow(StopFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFlowResponseUnmarshaller.Instance;

            return Invoke<StopFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopFlow operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StopFlow">REST API Reference for StopFlow Operation</seealso>
        public virtual IAsyncResult BeginStopFlow(StopFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopFlow.</param>
        /// 
        /// <returns>Returns a  StopFlowResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StopFlow">REST API Reference for StopFlow Operation</seealso>
        public virtual StopFlowResponse EndStopFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<StopFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  StopRouterInput

        /// <summary>
        /// Stops a router input in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRouterInput service method.</param>
        /// 
        /// <returns>The response from the StopRouterInput service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StopRouterInput">REST API Reference for StopRouterInput Operation</seealso>
        public virtual StopRouterInputResponse StopRouterInput(StopRouterInputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRouterInputResponseUnmarshaller.Instance;

            return Invoke<StopRouterInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopRouterInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopRouterInput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopRouterInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StopRouterInput">REST API Reference for StopRouterInput Operation</seealso>
        public virtual IAsyncResult BeginStopRouterInput(StopRouterInputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRouterInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopRouterInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopRouterInput.</param>
        /// 
        /// <returns>Returns a  StopRouterInputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StopRouterInput">REST API Reference for StopRouterInput Operation</seealso>
        public virtual StopRouterInputResponse EndStopRouterInput(IAsyncResult asyncResult)
        {
            return EndInvoke<StopRouterInputResponse>(asyncResult);
        }

        #endregion
        
        #region  StopRouterOutput

        /// <summary>
        /// Stops a router output in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRouterOutput service method.</param>
        /// 
        /// <returns>The response from the StopRouterOutput service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StopRouterOutput">REST API Reference for StopRouterOutput Operation</seealso>
        public virtual StopRouterOutputResponse StopRouterOutput(StopRouterOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRouterOutputResponseUnmarshaller.Instance;

            return Invoke<StopRouterOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopRouterOutput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopRouterOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StopRouterOutput">REST API Reference for StopRouterOutput Operation</seealso>
        public virtual IAsyncResult BeginStopRouterOutput(StopRouterOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRouterOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopRouterOutput.</param>
        /// 
        /// <returns>Returns a  StopRouterOutputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StopRouterOutput">REST API Reference for StopRouterOutput Operation</seealso>
        public virtual StopRouterOutputResponse EndStopRouterOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<StopRouterOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  TagGlobalResource

        /// <summary>
        /// Adds tags to a global resource in AWS Elemental MediaConnect. The API supports the
        /// following global resources: router inputs, router outputs and router network interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagGlobalResource service method.</param>
        /// 
        /// <returns>The response from the TagGlobalResource service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/TagGlobalResource">REST API Reference for TagGlobalResource Operation</seealso>
        public virtual TagGlobalResourceResponse TagGlobalResource(TagGlobalResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagGlobalResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagGlobalResourceResponseUnmarshaller.Instance;

            return Invoke<TagGlobalResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagGlobalResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagGlobalResource operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagGlobalResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/TagGlobalResource">REST API Reference for TagGlobalResource Operation</seealso>
        public virtual IAsyncResult BeginTagGlobalResource(TagGlobalResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagGlobalResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagGlobalResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagGlobalResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagGlobalResource.</param>
        /// 
        /// <returns>Returns a  TagGlobalResourceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/TagGlobalResource">REST API Reference for TagGlobalResource Operation</seealso>
        public virtual TagGlobalResourceResponse EndTagGlobalResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagGlobalResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates the specified tags to a resource with the specified <c>resourceArn</c>
        /// in the current region. If existing tags on a resource are not specified in the request
        /// parameters, they are not changed. When a resource is deleted, the tags associated
        /// with that resource are deleted as well.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TakeRouterInput

        /// <summary>
        /// Associates a router input with a router output in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TakeRouterInput service method.</param>
        /// 
        /// <returns>The response from the TakeRouterInput service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/TakeRouterInput">REST API Reference for TakeRouterInput Operation</seealso>
        public virtual TakeRouterInputResponse TakeRouterInput(TakeRouterInputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TakeRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TakeRouterInputResponseUnmarshaller.Instance;

            return Invoke<TakeRouterInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TakeRouterInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TakeRouterInput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTakeRouterInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/TakeRouterInput">REST API Reference for TakeRouterInput Operation</seealso>
        public virtual IAsyncResult BeginTakeRouterInput(TakeRouterInputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TakeRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TakeRouterInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TakeRouterInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTakeRouterInput.</param>
        /// 
        /// <returns>Returns a  TakeRouterInputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/TakeRouterInput">REST API Reference for TakeRouterInput Operation</seealso>
        public virtual TakeRouterInputResponse EndTakeRouterInput(IAsyncResult asyncResult)
        {
            return EndInvoke<TakeRouterInputResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagGlobalResource

        /// <summary>
        /// Removes tags from a global resource in AWS Elemental MediaConnect. The API supports
        /// the following global resources: router inputs, router outputs and router network interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagGlobalResource service method.</param>
        /// 
        /// <returns>The response from the UntagGlobalResource service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UntagGlobalResource">REST API Reference for UntagGlobalResource Operation</seealso>
        public virtual UntagGlobalResourceResponse UntagGlobalResource(UntagGlobalResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagGlobalResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagGlobalResourceResponseUnmarshaller.Instance;

            return Invoke<UntagGlobalResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagGlobalResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagGlobalResource operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagGlobalResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UntagGlobalResource">REST API Reference for UntagGlobalResource Operation</seealso>
        public virtual IAsyncResult BeginUntagGlobalResource(UntagGlobalResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagGlobalResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagGlobalResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagGlobalResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagGlobalResource.</param>
        /// 
        /// <returns>Returns a  UntagGlobalResourceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UntagGlobalResource">REST API Reference for UntagGlobalResource Operation</seealso>
        public virtual UntagGlobalResourceResponse EndUntagGlobalResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagGlobalResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes specified tags from a resource in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBridge

        /// <summary>
        /// Updates the bridge.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBridge service method.</param>
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
        public virtual UpdateBridgeResponse UpdateBridge(UpdateBridgeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeResponseUnmarshaller.Instance;

            return Invoke<UpdateBridgeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBridge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBridge operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBridge
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateBridge">REST API Reference for UpdateBridge Operation</seealso>
        public virtual IAsyncResult BeginUpdateBridge(UpdateBridgeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBridge operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBridge.</param>
        /// 
        /// <returns>Returns a  UpdateBridgeResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateBridge">REST API Reference for UpdateBridge Operation</seealso>
        public virtual UpdateBridgeResponse EndUpdateBridge(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBridgeResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBridgeOutput

        /// <summary>
        /// Updates an existing bridge output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBridgeOutput service method.</param>
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
        public virtual UpdateBridgeOutputResponse UpdateBridgeOutput(UpdateBridgeOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeOutputResponseUnmarshaller.Instance;

            return Invoke<UpdateBridgeOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBridgeOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBridgeOutput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBridgeOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateBridgeOutput">REST API Reference for UpdateBridgeOutput Operation</seealso>
        public virtual IAsyncResult BeginUpdateBridgeOutput(UpdateBridgeOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBridgeOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBridgeOutput.</param>
        /// 
        /// <returns>Returns a  UpdateBridgeOutputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateBridgeOutput">REST API Reference for UpdateBridgeOutput Operation</seealso>
        public virtual UpdateBridgeOutputResponse EndUpdateBridgeOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBridgeOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBridgeSource

        /// <summary>
        /// Updates an existing bridge source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBridgeSource service method.</param>
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
        public virtual UpdateBridgeSourceResponse UpdateBridgeSource(UpdateBridgeSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateBridgeSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBridgeSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBridgeSource operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBridgeSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateBridgeSource">REST API Reference for UpdateBridgeSource Operation</seealso>
        public virtual IAsyncResult BeginUpdateBridgeSource(UpdateBridgeSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBridgeSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBridgeSource.</param>
        /// 
        /// <returns>Returns a  UpdateBridgeSourceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateBridgeSource">REST API Reference for UpdateBridgeSource Operation</seealso>
        public virtual UpdateBridgeSourceResponse EndUpdateBridgeSource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBridgeSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBridgeState

        /// <summary>
        /// Updates the bridge state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBridgeState service method.</param>
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
        public virtual UpdateBridgeStateResponse UpdateBridgeState(UpdateBridgeStateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeStateResponseUnmarshaller.Instance;

            return Invoke<UpdateBridgeStateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBridgeState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBridgeState operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBridgeState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateBridgeState">REST API Reference for UpdateBridgeState Operation</seealso>
        public virtual IAsyncResult BeginUpdateBridgeState(UpdateBridgeStateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBridgeStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBridgeStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBridgeState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBridgeState.</param>
        /// 
        /// <returns>Returns a  UpdateBridgeStateResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateBridgeState">REST API Reference for UpdateBridgeState Operation</seealso>
        public virtual UpdateBridgeStateResponse EndUpdateBridgeState(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBridgeStateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFlow

        /// <summary>
        /// Updates an existing flow.
        /// 
        ///  <note> 
        /// <para>
        ///  Because <c>UpdateFlowSources</c> and <c>UpdateFlow</c> are separate operations, you
        /// can't change both the source type AND the flow size in a single request. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have a <c>MEDIUM</c> flow and you want to change the flow source to NDI®:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// First, use the <c>UpdateFlow</c> operation to upgrade the flow size to <c>LARGE</c>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After that, you can then use the <c>UpdateFlowSource</c> operation to configure the
        /// NDI source. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If you're switching from an NDI source to a transport stream (TS) source and want
        /// to downgrade the flow size: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// First, use the <c>UpdateFlowSource</c> operation to change the flow source type. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After that, you can then use the <c>UpdateFlow</c> operation to downgrade the flow
        /// size to <c>MEDIUM</c>.
        /// </para>
        ///  </li> </ul> </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlow service method.</param>
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
        public virtual UpdateFlowResponse UpdateFlow(UpdateFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlow operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlow">REST API Reference for UpdateFlow Operation</seealso>
        public virtual IAsyncResult BeginUpdateFlow(UpdateFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFlow.</param>
        /// 
        /// <returns>Returns a  UpdateFlowResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlow">REST API Reference for UpdateFlow Operation</seealso>
        public virtual UpdateFlowResponse EndUpdateFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFlowEntitlement

        /// <summary>
        /// Updates an entitlement. You can change an entitlement's description, subscribers,
        /// and encryption. If you change the subscribers, the service will remove the outputs
        /// that are are used by the subscribers that are removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowEntitlement service method.</param>
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
        public virtual UpdateFlowEntitlementResponse UpdateFlowEntitlement(UpdateFlowEntitlementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowEntitlementResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowEntitlementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFlowEntitlement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowEntitlement operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFlowEntitlement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowEntitlement">REST API Reference for UpdateFlowEntitlement Operation</seealso>
        public virtual IAsyncResult BeginUpdateFlowEntitlement(UpdateFlowEntitlementRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowEntitlementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFlowEntitlement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFlowEntitlement.</param>
        /// 
        /// <returns>Returns a  UpdateFlowEntitlementResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowEntitlement">REST API Reference for UpdateFlowEntitlement Operation</seealso>
        public virtual UpdateFlowEntitlementResponse EndUpdateFlowEntitlement(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFlowEntitlementResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFlowMediaStream

        /// <summary>
        /// Updates an existing media stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowMediaStream service method.</param>
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
        public virtual UpdateFlowMediaStreamResponse UpdateFlowMediaStream(UpdateFlowMediaStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowMediaStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowMediaStreamResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowMediaStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFlowMediaStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowMediaStream operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFlowMediaStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowMediaStream">REST API Reference for UpdateFlowMediaStream Operation</seealso>
        public virtual IAsyncResult BeginUpdateFlowMediaStream(UpdateFlowMediaStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowMediaStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowMediaStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFlowMediaStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFlowMediaStream.</param>
        /// 
        /// <returns>Returns a  UpdateFlowMediaStreamResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowMediaStream">REST API Reference for UpdateFlowMediaStream Operation</seealso>
        public virtual UpdateFlowMediaStreamResponse EndUpdateFlowMediaStream(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFlowMediaStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFlowOutput

        /// <summary>
        /// Updates an existing flow output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowOutput service method.</param>
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
        public virtual UpdateFlowOutputResponse UpdateFlowOutput(UpdateFlowOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowOutputResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFlowOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowOutput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFlowOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowOutput">REST API Reference for UpdateFlowOutput Operation</seealso>
        public virtual IAsyncResult BeginUpdateFlowOutput(UpdateFlowOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFlowOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFlowOutput.</param>
        /// 
        /// <returns>Returns a  UpdateFlowOutputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowOutput">REST API Reference for UpdateFlowOutput Operation</seealso>
        public virtual UpdateFlowOutputResponse EndUpdateFlowOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFlowOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFlowSource

        /// <summary>
        /// Updates the source of a flow.
        /// 
        ///  <note> 
        /// <para>
        ///  Because <c>UpdateFlowSources</c> and <c>UpdateFlow</c> are separate operations, you
        /// can't change both the source type AND the flow size in a single request. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have a <c>MEDIUM</c> flow and you want to change the flow source to NDI®:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// First, use the <c>UpdateFlow</c> operation to upgrade the flow size to <c>LARGE</c>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After that, you can then use the <c>UpdateFlowSource</c> operation to configure the
        /// NDI source. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If you're switching from an NDI source to a transport stream (TS) source and want
        /// to downgrade the flow size: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// First, use the <c>UpdateFlowSource</c> operation to change the flow source type. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After that, you can then use the <c>UpdateFlow</c> operation to downgrade the flow
        /// size to <c>MEDIUM</c>.
        /// </para>
        ///  </li> </ul> </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowSource service method.</param>
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
        public virtual UpdateFlowSourceResponse UpdateFlowSource(UpdateFlowSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFlowSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowSource operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFlowSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowSource">REST API Reference for UpdateFlowSource Operation</seealso>
        public virtual IAsyncResult BeginUpdateFlowSource(UpdateFlowSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFlowSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFlowSource.</param>
        /// 
        /// <returns>Returns a  UpdateFlowSourceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowSource">REST API Reference for UpdateFlowSource Operation</seealso>
        public virtual UpdateFlowSourceResponse EndUpdateFlowSource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFlowSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGatewayInstance

        /// <summary>
        /// Updates an existing gateway instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInstance service method.</param>
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
        public virtual UpdateGatewayInstanceResponse UpdateGatewayInstance(UpdateGatewayInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewayInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInstance operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGatewayInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateGatewayInstance">REST API Reference for UpdateGatewayInstance Operation</seealso>
        public virtual IAsyncResult BeginUpdateGatewayInstance(UpdateGatewayInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGatewayInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewayInstance.</param>
        /// 
        /// <returns>Returns a  UpdateGatewayInstanceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateGatewayInstance">REST API Reference for UpdateGatewayInstance Operation</seealso>
        public virtual UpdateGatewayInstanceResponse EndUpdateGatewayInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGatewayInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRouterInput

        /// <summary>
        /// Updates the configuration of an existing router input in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouterInput service method.</param>
        /// 
        /// <returns>The response from the UpdateRouterInput service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateRouterInput">REST API Reference for UpdateRouterInput Operation</seealso>
        public virtual UpdateRouterInputResponse UpdateRouterInput(UpdateRouterInputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouterInputResponseUnmarshaller.Instance;

            return Invoke<UpdateRouterInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRouterInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouterInput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRouterInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateRouterInput">REST API Reference for UpdateRouterInput Operation</seealso>
        public virtual IAsyncResult BeginUpdateRouterInput(UpdateRouterInputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouterInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouterInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRouterInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRouterInput.</param>
        /// 
        /// <returns>Returns a  UpdateRouterInputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateRouterInput">REST API Reference for UpdateRouterInput Operation</seealso>
        public virtual UpdateRouterInputResponse EndUpdateRouterInput(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRouterInputResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRouterNetworkInterface

        /// <summary>
        /// Updates the configuration of an existing router network interface in AWS Elemental
        /// MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouterNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the UpdateRouterNetworkInterface service method, as returned by MediaConnect.</returns>
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
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// The service is currently unavailable or busy.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateRouterNetworkInterface">REST API Reference for UpdateRouterNetworkInterface Operation</seealso>
        public virtual UpdateRouterNetworkInterfaceResponse UpdateRouterNetworkInterface(UpdateRouterNetworkInterfaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouterNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouterNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<UpdateRouterNetworkInterfaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRouterNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouterNetworkInterface operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRouterNetworkInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateRouterNetworkInterface">REST API Reference for UpdateRouterNetworkInterface Operation</seealso>
        public virtual IAsyncResult BeginUpdateRouterNetworkInterface(UpdateRouterNetworkInterfaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouterNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouterNetworkInterfaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRouterNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRouterNetworkInterface.</param>
        /// 
        /// <returns>Returns a  UpdateRouterNetworkInterfaceResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateRouterNetworkInterface">REST API Reference for UpdateRouterNetworkInterface Operation</seealso>
        public virtual UpdateRouterNetworkInterfaceResponse EndUpdateRouterNetworkInterface(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRouterNetworkInterfaceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRouterOutput

        /// <summary>
        /// Updates the configuration of an existing router output in AWS Elemental MediaConnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouterOutput service method.</param>
        /// 
        /// <returns>The response from the UpdateRouterOutput service method, as returned by MediaConnect.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateRouterOutput">REST API Reference for UpdateRouterOutput Operation</seealso>
        public virtual UpdateRouterOutputResponse UpdateRouterOutput(UpdateRouterOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouterOutputResponseUnmarshaller.Instance;

            return Invoke<UpdateRouterOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouterOutput operation on AmazonMediaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRouterOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateRouterOutput">REST API Reference for UpdateRouterOutput Operation</seealso>
        public virtual IAsyncResult BeginUpdateRouterOutput(UpdateRouterOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouterOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouterOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRouterOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRouterOutput.</param>
        /// 
        /// <returns>Returns a  UpdateRouterOutputResult from MediaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateRouterOutput">REST API Reference for UpdateRouterOutput Operation</seealso>
        public virtual UpdateRouterOutputResponse EndUpdateRouterOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRouterOutputResponse>(asyncResult);
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
            var resolver = new AmazonMediaConnectEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}