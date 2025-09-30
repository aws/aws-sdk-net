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
 * Do not modify this file. This file is generated from the cloudcontrol-2021-09-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudControlApi.Model;
using Amazon.CloudControlApi.Model.Internal.MarshallTransformations;
using Amazon.CloudControlApi.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CloudControlApi
{
    /// <summary>
    /// <para>Implementation for accessing CloudControlApi</para>
    ///
    /// For more information about Amazon Web Services Cloud Control API, see the <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/what-is-cloudcontrolapi.html">Amazon
    /// Web Services Cloud Control API User Guide</a>.
    /// </summary>
    public partial class AmazonCloudControlApiClient : AmazonServiceClient, IAmazonCloudControlApi
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudControlApiMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudControlApiClient with the credentials loaded from the application's
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
        public AmazonCloudControlApiClient()
            : base(new AmazonCloudControlApiConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudControlApiClient with the credentials loaded from the application's
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
        public AmazonCloudControlApiClient(RegionEndpoint region)
            : base(new AmazonCloudControlApiConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudControlApiClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudControlApiClient Configuration Object</param>
        public AmazonCloudControlApiClient(AmazonCloudControlApiConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonCloudControlApiClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudControlApiClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudControlApiConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudControlApiClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudControlApiClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudControlApiConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudControlApiClient with AWS Credentials and an
        /// AmazonCloudControlApiClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudControlApiClient Configuration Object</param>
        public AmazonCloudControlApiClient(AWSCredentials credentials, AmazonCloudControlApiConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudControlApiClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudControlApiClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudControlApiConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudControlApiClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudControlApiClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudControlApiConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudControlApiClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudControlApiClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudControlApiClient Configuration Object</param>
        public AmazonCloudControlApiClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudControlApiConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudControlApiClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudControlApiClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudControlApiConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudControlApiClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudControlApiClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudControlApiConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudControlApiClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudControlApiClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudControlApiClient Configuration Object</param>
        public AmazonCloudControlApiClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudControlApiConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ICloudControlApiPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICloudControlApiPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CloudControlApiPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudControlApiEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudControlApiAuthSchemeHandler());
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


        #region  CancelResourceRequest

        internal virtual CancelResourceRequestResponse CancelResourceRequest(CancelResourceRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelResourceRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelResourceRequestResponseUnmarshaller.Instance;

            return Invoke<CancelResourceRequestResponse>(request, options);
        }



        /// <summary>
        /// Cancels the specified resource operation request. For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-manage-requests.html#resource-operations-manage-requests-cancel">Canceling
        /// resource operation requests</a> in the <i>Amazon Web Services Cloud Control API User
        /// Guide</i>.
        /// 
        ///  
        /// <para>
        /// Only resource operations requests with a status of <c>PENDING</c> or <c>IN_PROGRESS</c>
        /// can be canceled.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelResourceRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelResourceRequest service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.ConcurrentModificationException">
        /// The resource is currently being modified by another operation.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.RequestTokenNotFoundException">
        /// A resource operation with the specified request token can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/CancelResourceRequest">REST API Reference for CancelResourceRequest Operation</seealso>
        public virtual Task<CancelResourceRequestResponse> CancelResourceRequestAsync(CancelResourceRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelResourceRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelResourceRequestResponseUnmarshaller.Instance;

            return InvokeAsync<CancelResourceRequestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateResource

        internal virtual CreateResourceResponse CreateResource(CreateResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return Invoke<CreateResourceResponse>(request, options);
        }



        /// <summary>
        /// Creates the specified resource. For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-create.html">Creating
        /// a resource</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.
        /// 
        ///  
        /// <para>
        /// After you have initiated a resource creation request, you can monitor the progress
        /// of your request by calling <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/APIReference/API_GetResourceRequestStatus.html">GetResourceRequestStatus</a>
        /// using the <c>RequestToken</c> of the <c>ProgressEvent</c> type returned by <c>CreateResource</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResource service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ClientTokenConflictException">
        /// The specified client token has already been used in another resource request.
        /// 
        ///  
        /// <para>
        /// It's best practice for client tokens to be unique for each resource operation request.
        /// However, client token expire after 36 hours.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ConcurrentOperationException">
        /// Another resource operation is currently being performed on this resource.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.GeneralServiceException">
        /// The resource handler has returned that the downstream service generated an error that
        /// doesn't map to any other handler error code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerFailureException">
        /// The resource handler has failed without a returning a more specific error code. This
        /// can include timeouts.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerInternalFailureException">
        /// The resource handler has returned that an unexpected error occurred within the resource
        /// handler.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidCredentialsException">
        /// The resource handler has returned that the credentials provided by the user are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidRequestException">
        /// The resource handler has returned that invalid input from the user has generated a
        /// generic exception.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NetworkFailureException">
        /// The resource handler has returned that the request couldn't be completed due to networking
        /// issues, such as a failure to receive a response from the server.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotStabilizedException">
        /// The resource handler has returned that the downstream resource failed to complete
        /// all of its ready-state checks.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotUpdatableException">
        /// One or more properties included in this resource operation are defined as create-only,
        /// and therefore can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.PrivateTypeException">
        /// Cloud Control API hasn't received a valid response from the resource handler, due
        /// to a configuration error. This includes issues such as the resource handler returning
        /// an invalid response, or timing out.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceConflictException">
        /// The resource is temporarily unavailable to be acted upon. For example, if the resource
        /// is currently undergoing an operation and can't be acted upon until that operation
        /// is finished.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceNotFoundException">
        /// A resource with the specified identifier can't be found.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceInternalErrorException">
        /// The resource handler has returned that the downstream service returned an internal
        /// error, typically with a <c>5XX HTTP</c> status code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceLimitExceededException">
        /// The resource handler has returned that a non-transient resource limit was reached
        /// on the service side.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.UnsupportedActionException">
        /// The specified resource doesn't support this resource operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/CreateResource">REST API Reference for CreateResource Operation</seealso>
        public virtual Task<CreateResourceResponse> CreateResourceAsync(CreateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteResource

        internal virtual DeleteResourceResponse DeleteResource(DeleteResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified resource. For details, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-delete.html">Deleting
        /// a resource</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.
        /// 
        ///  
        /// <para>
        /// After you have initiated a resource deletion request, you can monitor the progress
        /// of your request by calling <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/APIReference/API_GetResourceRequestStatus.html">GetResourceRequestStatus</a>
        /// using the <c>RequestToken</c> of the <c>ProgressEvent</c> returned by <c>DeleteResource</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResource service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ClientTokenConflictException">
        /// The specified client token has already been used in another resource request.
        /// 
        ///  
        /// <para>
        /// It's best practice for client tokens to be unique for each resource operation request.
        /// However, client token expire after 36 hours.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ConcurrentOperationException">
        /// Another resource operation is currently being performed on this resource.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.GeneralServiceException">
        /// The resource handler has returned that the downstream service generated an error that
        /// doesn't map to any other handler error code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerFailureException">
        /// The resource handler has failed without a returning a more specific error code. This
        /// can include timeouts.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerInternalFailureException">
        /// The resource handler has returned that an unexpected error occurred within the resource
        /// handler.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidCredentialsException">
        /// The resource handler has returned that the credentials provided by the user are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidRequestException">
        /// The resource handler has returned that invalid input from the user has generated a
        /// generic exception.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NetworkFailureException">
        /// The resource handler has returned that the request couldn't be completed due to networking
        /// issues, such as a failure to receive a response from the server.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotStabilizedException">
        /// The resource handler has returned that the downstream resource failed to complete
        /// all of its ready-state checks.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotUpdatableException">
        /// One or more properties included in this resource operation are defined as create-only,
        /// and therefore can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.PrivateTypeException">
        /// Cloud Control API hasn't received a valid response from the resource handler, due
        /// to a configuration error. This includes issues such as the resource handler returning
        /// an invalid response, or timing out.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceConflictException">
        /// The resource is temporarily unavailable to be acted upon. For example, if the resource
        /// is currently undergoing an operation and can't be acted upon until that operation
        /// is finished.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceNotFoundException">
        /// A resource with the specified identifier can't be found.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceInternalErrorException">
        /// The resource handler has returned that the downstream service returned an internal
        /// error, typically with a <c>5XX HTTP</c> status code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceLimitExceededException">
        /// The resource handler has returned that a non-transient resource limit was reached
        /// on the service side.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.UnsupportedActionException">
        /// The specified resource doesn't support this resource operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        public virtual Task<DeleteResourceResponse> DeleteResourceAsync(DeleteResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResource

        internal virtual GetResourceResponse GetResource(GetResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceResponseUnmarshaller.Instance;

            return Invoke<GetResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the current state of the specified resource. For details,
        /// see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-read.html">Reading
        /// a resource's current state</a>.
        /// 
        ///  
        /// <para>
        /// You can use this action to return information about an existing resource in your account
        /// and Amazon Web Services Region, whether those resources were provisioned using Cloud
        /// Control API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResource service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.GeneralServiceException">
        /// The resource handler has returned that the downstream service generated an error that
        /// doesn't map to any other handler error code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerFailureException">
        /// The resource handler has failed without a returning a more specific error code. This
        /// can include timeouts.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerInternalFailureException">
        /// The resource handler has returned that an unexpected error occurred within the resource
        /// handler.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidCredentialsException">
        /// The resource handler has returned that the credentials provided by the user are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidRequestException">
        /// The resource handler has returned that invalid input from the user has generated a
        /// generic exception.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NetworkFailureException">
        /// The resource handler has returned that the request couldn't be completed due to networking
        /// issues, such as a failure to receive a response from the server.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotStabilizedException">
        /// The resource handler has returned that the downstream resource failed to complete
        /// all of its ready-state checks.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotUpdatableException">
        /// One or more properties included in this resource operation are defined as create-only,
        /// and therefore can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.PrivateTypeException">
        /// Cloud Control API hasn't received a valid response from the resource handler, due
        /// to a configuration error. This includes issues such as the resource handler returning
        /// an invalid response, or timing out.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceConflictException">
        /// The resource is temporarily unavailable to be acted upon. For example, if the resource
        /// is currently undergoing an operation and can't be acted upon until that operation
        /// is finished.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceNotFoundException">
        /// A resource with the specified identifier can't be found.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceInternalErrorException">
        /// The resource handler has returned that the downstream service returned an internal
        /// error, typically with a <c>5XX HTTP</c> status code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceLimitExceededException">
        /// The resource handler has returned that a non-transient resource limit was reached
        /// on the service side.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.UnsupportedActionException">
        /// The specified resource doesn't support this resource operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/GetResource">REST API Reference for GetResource Operation</seealso>
        public virtual Task<GetResourceResponse> GetResourceAsync(GetResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourceRequestStatus

        internal virtual GetResourceRequestStatusResponse GetResourceRequestStatus(GetResourceRequestStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceRequestStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceRequestStatusResponseUnmarshaller.Instance;

            return Invoke<GetResourceRequestStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns the current status of a resource operation request. For more information,
        /// see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-manage-requests.html#resource-operations-manage-requests-track">Tracking
        /// the progress of resource operation requests</a> in the <i>Amazon Web Services Cloud
        /// Control API User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceRequestStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceRequestStatus service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.RequestTokenNotFoundException">
        /// A resource operation with the specified request token can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/GetResourceRequestStatus">REST API Reference for GetResourceRequestStatus Operation</seealso>
        public virtual Task<GetResourceRequestStatusResponse> GetResourceRequestStatusAsync(GetResourceRequestStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceRequestStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceRequestStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceRequestStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResourceRequests

        internal virtual ListResourceRequestsResponse ListResourceRequests(ListResourceRequestsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceRequestsResponseUnmarshaller.Instance;

            return Invoke<ListResourceRequestsResponse>(request, options);
        }



        /// <summary>
        /// Returns existing resource operation requests. This includes requests of all status
        /// types. For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-manage-requests.html#resource-operations-manage-requests-list">Listing
        /// active resource operation requests</a> in the <i>Amazon Web Services Cloud Control
        /// API User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// Resource operation requests expire after 7 days.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceRequests service method, as returned by CloudControlApi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/ListResourceRequests">REST API Reference for ListResourceRequests Operation</seealso>
        public virtual Task<ListResourceRequestsResponse> ListResourceRequestsAsync(ListResourceRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceRequestsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResources

        internal virtual ListResourcesResponse ListResources(ListResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return Invoke<ListResourcesResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the specified resources. For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-list.html">Discovering
        /// resources</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can use this action to return information about existing resources in your account
        /// and Amazon Web Services Region, whether those resources were provisioned using Cloud
        /// Control API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.GeneralServiceException">
        /// The resource handler has returned that the downstream service generated an error that
        /// doesn't map to any other handler error code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerFailureException">
        /// The resource handler has failed without a returning a more specific error code. This
        /// can include timeouts.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerInternalFailureException">
        /// The resource handler has returned that an unexpected error occurred within the resource
        /// handler.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidCredentialsException">
        /// The resource handler has returned that the credentials provided by the user are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidRequestException">
        /// The resource handler has returned that invalid input from the user has generated a
        /// generic exception.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NetworkFailureException">
        /// The resource handler has returned that the request couldn't be completed due to networking
        /// issues, such as a failure to receive a response from the server.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotStabilizedException">
        /// The resource handler has returned that the downstream resource failed to complete
        /// all of its ready-state checks.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotUpdatableException">
        /// One or more properties included in this resource operation are defined as create-only,
        /// and therefore can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.PrivateTypeException">
        /// Cloud Control API hasn't received a valid response from the resource handler, due
        /// to a configuration error. This includes issues such as the resource handler returning
        /// an invalid response, or timing out.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceConflictException">
        /// The resource is temporarily unavailable to be acted upon. For example, if the resource
        /// is currently undergoing an operation and can't be acted upon until that operation
        /// is finished.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceNotFoundException">
        /// A resource with the specified identifier can't be found.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceInternalErrorException">
        /// The resource handler has returned that the downstream service returned an internal
        /// error, typically with a <c>5XX HTTP</c> status code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceLimitExceededException">
        /// The resource handler has returned that a non-transient resource limit was reached
        /// on the service side.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.UnsupportedActionException">
        /// The specified resource doesn't support this resource operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/ListResources">REST API Reference for ListResources Operation</seealso>
        public virtual Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateResource

        internal virtual UpdateResourceResponse UpdateResource(UpdateResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified property values in the resource.
        /// 
        ///  
        /// <para>
        /// You specify your resource property updates as a list of patch operations contained
        /// in a JSON patch document that adheres to the <a href="https://datatracker.ietf.org/doc/html/rfc6902">
        /// <i>RFC 6902 - JavaScript Object Notation (JSON) Patch</i> </a> standard.
        /// </para>
        ///  
        /// <para>
        /// For details on how Cloud Control API performs resource update operations, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-update.html">Updating
        /// a resource</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// After you have initiated a resource update request, you can monitor the progress of
        /// your request by calling <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/APIReference/API_GetResourceRequestStatus.html">GetResourceRequestStatus</a>
        /// using the <c>RequestToken</c> of the <c>ProgressEvent</c> returned by <c>UpdateResource</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the properties of a specific resource, refer to the related
        /// topic for the resource in the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Resource
        /// and property types reference</a> in the <i>CloudFormation Users Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResource service method, as returned by CloudControlApi.</returns>
        /// <exception cref="Amazon.CloudControlApi.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ClientTokenConflictException">
        /// The specified client token has already been used in another resource request.
        /// 
        ///  
        /// <para>
        /// It's best practice for client tokens to be unique for each resource operation request.
        /// However, client token expire after 36 hours.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ConcurrentOperationException">
        /// Another resource operation is currently being performed on this resource.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.GeneralServiceException">
        /// The resource handler has returned that the downstream service generated an error that
        /// doesn't map to any other handler error code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerFailureException">
        /// The resource handler has failed without a returning a more specific error code. This
        /// can include timeouts.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.HandlerInternalFailureException">
        /// The resource handler has returned that an unexpected error occurred within the resource
        /// handler.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidCredentialsException">
        /// The resource handler has returned that the credentials provided by the user are invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.InvalidRequestException">
        /// The resource handler has returned that invalid input from the user has generated a
        /// generic exception.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NetworkFailureException">
        /// The resource handler has returned that the request couldn't be completed due to networking
        /// issues, such as a failure to receive a response from the server.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotStabilizedException">
        /// The resource handler has returned that the downstream resource failed to complete
        /// all of its ready-state checks.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.NotUpdatableException">
        /// One or more properties included in this resource operation are defined as create-only,
        /// and therefore can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.PrivateTypeException">
        /// Cloud Control API hasn't received a valid response from the resource handler, due
        /// to a configuration error. This includes issues such as the resource handler returning
        /// an invalid response, or timing out.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceConflictException">
        /// The resource is temporarily unavailable to be acted upon. For example, if the resource
        /// is currently undergoing an operation and can't be acted upon until that operation
        /// is finished.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ResourceNotFoundException">
        /// A resource with the specified identifier can't be found.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceInternalErrorException">
        /// The resource handler has returned that the downstream service returned an internal
        /// error, typically with a <c>5XX HTTP</c> status code.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ServiceLimitExceededException">
        /// The resource handler has returned that a non-transient resource limit was reached
        /// on the service side.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <exception cref="Amazon.CloudControlApi.Model.UnsupportedActionException">
        /// The specified resource doesn't support this resource operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudcontrol-2021-09-30/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        public virtual Task<UpdateResourceResponse> UpdateResourceAsync(UpdateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResourceResponse>(request, options, cancellationToken);
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