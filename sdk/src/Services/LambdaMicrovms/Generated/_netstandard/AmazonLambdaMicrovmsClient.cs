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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.LambdaMicrovms.Model;
using Amazon.LambdaMicrovms.Model.Internal.MarshallTransformations;
using Amazon.LambdaMicrovms.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.LambdaMicrovms
{
    /// <summary>
    /// <para>Implementation for accessing LambdaMicrovms</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Provides APIs to create, manage, and operate AWS Lambda MicroVMs and their associated
    /// MicroVM Image environments.
    /// </summary>
    public partial class AmazonLambdaMicrovmsClient : AmazonServiceClient, IAmazonLambdaMicrovms
    {
        private static IServiceMetadata serviceMetadata = new AmazonLambdaMicrovmsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonLambdaMicrovmsClient with the credentials loaded from the application's
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
        public AmazonLambdaMicrovmsClient()
            : base(new AmazonLambdaMicrovmsConfig()) { }

        /// <summary>
        /// Constructs AmazonLambdaMicrovmsClient with the credentials loaded from the application's
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
        public AmazonLambdaMicrovmsClient(RegionEndpoint region)
            : base(new AmazonLambdaMicrovmsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLambdaMicrovmsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLambdaMicrovmsClient Configuration Object</param>
        public AmazonLambdaMicrovmsClient(AmazonLambdaMicrovmsConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonLambdaMicrovmsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLambdaMicrovmsClient(AWSCredentials credentials)
            : this(credentials, new AmazonLambdaMicrovmsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaMicrovmsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaMicrovmsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLambdaMicrovmsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaMicrovmsClient with AWS Credentials and an
        /// AmazonLambdaMicrovmsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLambdaMicrovmsClient Configuration Object</param>
        public AmazonLambdaMicrovmsClient(AWSCredentials credentials, AmazonLambdaMicrovmsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaMicrovmsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLambdaMicrovmsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLambdaMicrovmsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaMicrovmsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaMicrovmsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLambdaMicrovmsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaMicrovmsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLambdaMicrovmsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLambdaMicrovmsClient Configuration Object</param>
        public AmazonLambdaMicrovmsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLambdaMicrovmsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaMicrovmsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLambdaMicrovmsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLambdaMicrovmsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaMicrovmsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaMicrovmsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLambdaMicrovmsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaMicrovmsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLambdaMicrovmsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLambdaMicrovmsClient Configuration Object</param>
        public AmazonLambdaMicrovmsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLambdaMicrovmsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ILambdaMicrovmsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ILambdaMicrovmsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new LambdaMicrovmsPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLambdaMicrovmsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLambdaMicrovmsAuthSchemeHandler());
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


        #region  CreateMicrovmAuthToken

        internal virtual CreateMicrovmAuthTokenResponse CreateMicrovmAuthToken(CreateMicrovmAuthTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMicrovmAuthTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMicrovmAuthTokenResponseUnmarshaller.Instance;

            return Invoke<CreateMicrovmAuthTokenResponse>(request, options);
        }



        /// <summary>
        /// Creates an authentication token for accessing a running MicroVM. The token grants
        /// access to the specified ports on the MicroVM endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrovmAuthToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMicrovmAuthToken service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/CreateMicrovmAuthToken">REST API Reference for CreateMicrovmAuthToken Operation</seealso>
        public virtual Task<CreateMicrovmAuthTokenResponse> CreateMicrovmAuthTokenAsync(CreateMicrovmAuthTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMicrovmAuthTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMicrovmAuthTokenResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMicrovmAuthTokenResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMicrovmImage

        internal virtual CreateMicrovmImageResponse CreateMicrovmImage(CreateMicrovmImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMicrovmImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMicrovmImageResponseUnmarshaller.Instance;

            return Invoke<CreateMicrovmImageResponse>(request, options);
        }



        /// <summary>
        /// Creates a MicroVM image from the specified code artifact and base image. The build
        /// is asynchronous — the image transitions from CREATING to CREATED on success, or CREATE_FAILED
        /// on failure. Use GetMicrovmImage to poll for completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrovmImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMicrovmImage service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota for Lambda MicroVMs.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/CreateMicrovmImage">REST API Reference for CreateMicrovmImage Operation</seealso>
        public virtual Task<CreateMicrovmImageResponse> CreateMicrovmImageAsync(CreateMicrovmImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMicrovmImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMicrovmImageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMicrovmImageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMicrovmShellAuthToken

        internal virtual CreateMicrovmShellAuthTokenResponse CreateMicrovmShellAuthToken(CreateMicrovmShellAuthTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMicrovmShellAuthTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMicrovmShellAuthTokenResponseUnmarshaller.Instance;

            return Invoke<CreateMicrovmShellAuthTokenResponse>(request, options);
        }



        /// <summary>
        /// Creates a shell authentication token for interactive shell access to a running MicroVM.
        /// The MicroVM must have been run with the SHELL_INGRESS network connector attached.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrovmShellAuthToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMicrovmShellAuthToken service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/CreateMicrovmShellAuthToken">REST API Reference for CreateMicrovmShellAuthToken Operation</seealso>
        public virtual Task<CreateMicrovmShellAuthTokenResponse> CreateMicrovmShellAuthTokenAsync(CreateMicrovmShellAuthTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMicrovmShellAuthTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMicrovmShellAuthTokenResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMicrovmShellAuthTokenResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMicrovmImage

        internal virtual DeleteMicrovmImageResponse DeleteMicrovmImage(DeleteMicrovmImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMicrovmImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMicrovmImageResponseUnmarshaller.Instance;

            return Invoke<DeleteMicrovmImageResponse>(request, options);
        }



        /// <summary>
        /// Deletes a MicroVM image. This operation is idempotent; deleting an image that has
        /// already been deleted succeeds without error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrovmImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMicrovmImage service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/DeleteMicrovmImage">REST API Reference for DeleteMicrovmImage Operation</seealso>
        public virtual Task<DeleteMicrovmImageResponse> DeleteMicrovmImageAsync(DeleteMicrovmImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMicrovmImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMicrovmImageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMicrovmImageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMicrovmImageVersion

        internal virtual DeleteMicrovmImageVersionResponse DeleteMicrovmImageVersion(DeleteMicrovmImageVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMicrovmImageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMicrovmImageVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteMicrovmImageVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specific version of a MicroVM image. This operation is idempotent; deleting
        /// a version that has already been deleted succeeds without error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrovmImageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMicrovmImageVersion service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/DeleteMicrovmImageVersion">REST API Reference for DeleteMicrovmImageVersion Operation</seealso>
        public virtual Task<DeleteMicrovmImageVersionResponse> DeleteMicrovmImageVersionAsync(DeleteMicrovmImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMicrovmImageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMicrovmImageVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMicrovmImageVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMicrovm

        internal virtual GetMicrovmResponse GetMicrovm(GetMicrovmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMicrovmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMicrovmResponseUnmarshaller.Instance;

            return Invoke<GetMicrovmResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of a specific MicroVM, including its state, endpoint, image
        /// information, and configuration. The state field is eventually consistent — determine
        /// readiness by connecting to the endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMicrovm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMicrovm service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/GetMicrovm">REST API Reference for GetMicrovm Operation</seealso>
        public virtual Task<GetMicrovmResponse> GetMicrovmAsync(GetMicrovmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMicrovmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMicrovmResponseUnmarshaller.Instance;

            return InvokeAsync<GetMicrovmResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMicrovmImage

        internal virtual GetMicrovmImageResponse GetMicrovmImage(GetMicrovmImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMicrovmImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMicrovmImageResponseUnmarshaller.Instance;

            return Invoke<GetMicrovmImageResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of a MicroVM image, including its state, versions, and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMicrovmImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMicrovmImage service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/GetMicrovmImage">REST API Reference for GetMicrovmImage Operation</seealso>
        public virtual Task<GetMicrovmImageResponse> GetMicrovmImageAsync(GetMicrovmImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMicrovmImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMicrovmImageResponseUnmarshaller.Instance;

            return InvokeAsync<GetMicrovmImageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMicrovmImageBuild

        internal virtual GetMicrovmImageBuildResponse GetMicrovmImageBuild(GetMicrovmImageBuildRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMicrovmImageBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMicrovmImageBuildResponseUnmarshaller.Instance;

            return Invoke<GetMicrovmImageBuildResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of a specific MicroVM image build, including its state, target
        /// architecture, and snapshot information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMicrovmImageBuild service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMicrovmImageBuild service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/GetMicrovmImageBuild">REST API Reference for GetMicrovmImageBuild Operation</seealso>
        public virtual Task<GetMicrovmImageBuildResponse> GetMicrovmImageBuildAsync(GetMicrovmImageBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMicrovmImageBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMicrovmImageBuildResponseUnmarshaller.Instance;

            return InvokeAsync<GetMicrovmImageBuildResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMicrovmImageVersion

        internal virtual GetMicrovmImageVersionResponse GetMicrovmImageVersion(GetMicrovmImageVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMicrovmImageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMicrovmImageVersionResponseUnmarshaller.Instance;

            return Invoke<GetMicrovmImageVersionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of a specific version of a MicroVM image, including its configuration,
        /// state, and build information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMicrovmImageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMicrovmImageVersion service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/GetMicrovmImageVersion">REST API Reference for GetMicrovmImageVersion Operation</seealso>
        public virtual Task<GetMicrovmImageVersionResponse> GetMicrovmImageVersionAsync(GetMicrovmImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMicrovmImageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMicrovmImageVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetMicrovmImageVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListManagedMicrovmImages

        internal virtual ListManagedMicrovmImagesResponse ListManagedMicrovmImages(ListManagedMicrovmImagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedMicrovmImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedMicrovmImagesResponseUnmarshaller.Instance;

            return Invoke<ListManagedMicrovmImagesResponse>(request, options);
        }



        /// <summary>
        /// Lists AWS managed MicroVM images available for use as base images. We recommend using
        /// pagination to ensure that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedMicrovmImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedMicrovmImages service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ListManagedMicrovmImages">REST API Reference for ListManagedMicrovmImages Operation</seealso>
        public virtual Task<ListManagedMicrovmImagesResponse> ListManagedMicrovmImagesAsync(ListManagedMicrovmImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedMicrovmImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedMicrovmImagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListManagedMicrovmImagesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListManagedMicrovmImageVersions

        internal virtual ListManagedMicrovmImageVersionsResponse ListManagedMicrovmImageVersions(ListManagedMicrovmImageVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedMicrovmImageVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedMicrovmImageVersionsResponseUnmarshaller.Instance;

            return Invoke<ListManagedMicrovmImageVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists versions of a managed MicroVM image. We recommend using pagination to ensure
        /// that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedMicrovmImageVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedMicrovmImageVersions service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ListManagedMicrovmImageVersions">REST API Reference for ListManagedMicrovmImageVersions Operation</seealso>
        public virtual Task<ListManagedMicrovmImageVersionsResponse> ListManagedMicrovmImageVersionsAsync(ListManagedMicrovmImageVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedMicrovmImageVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedMicrovmImageVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListManagedMicrovmImageVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMicrovmImageBuilds

        internal virtual ListMicrovmImageBuildsResponse ListMicrovmImageBuilds(ListMicrovmImageBuildsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMicrovmImageBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMicrovmImageBuildsResponseUnmarshaller.Instance;

            return Invoke<ListMicrovmImageBuildsResponse>(request, options);
        }



        /// <summary>
        /// Lists builds for a MicroVM image version with optional filtering by architecture and
        /// chipset. We recommend using pagination to ensure that the operation returns quickly
        /// and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrovmImageBuilds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMicrovmImageBuilds service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ListMicrovmImageBuilds">REST API Reference for ListMicrovmImageBuilds Operation</seealso>
        public virtual Task<ListMicrovmImageBuildsResponse> ListMicrovmImageBuildsAsync(ListMicrovmImageBuildsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMicrovmImageBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMicrovmImageBuildsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMicrovmImageBuildsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMicrovmImages

        internal virtual ListMicrovmImagesResponse ListMicrovmImages(ListMicrovmImagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMicrovmImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMicrovmImagesResponseUnmarshaller.Instance;

            return Invoke<ListMicrovmImagesResponse>(request, options);
        }



        /// <summary>
        /// Lists MicroVM images in the account with optional name filtering. We recommend using
        /// pagination to ensure that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrovmImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMicrovmImages service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ListMicrovmImages">REST API Reference for ListMicrovmImages Operation</seealso>
        public virtual Task<ListMicrovmImagesResponse> ListMicrovmImagesAsync(ListMicrovmImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMicrovmImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMicrovmImagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListMicrovmImagesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMicrovmImageVersions

        internal virtual ListMicrovmImageVersionsResponse ListMicrovmImageVersions(ListMicrovmImageVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMicrovmImageVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMicrovmImageVersionsResponseUnmarshaller.Instance;

            return Invoke<ListMicrovmImageVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists versions of a MicroVM image. We recommend using pagination to ensure that the
        /// operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrovmImageVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMicrovmImageVersions service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ListMicrovmImageVersions">REST API Reference for ListMicrovmImageVersions Operation</seealso>
        public virtual Task<ListMicrovmImageVersionsResponse> ListMicrovmImageVersionsAsync(ListMicrovmImageVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMicrovmImageVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMicrovmImageVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMicrovmImageVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMicrovms

        internal virtual ListMicrovmsResponse ListMicrovms(ListMicrovmsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMicrovmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMicrovmsResponseUnmarshaller.Instance;

            return Invoke<ListMicrovmsResponse>(request, options);
        }



        /// <summary>
        /// Lists MicroVMs in the account with optional filtering by image and version. We recommend
        /// using pagination to ensure that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrovms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMicrovms service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ListMicrovms">REST API Reference for ListMicrovms Operation</seealso>
        public virtual Task<ListMicrovmsResponse> ListMicrovmsAsync(ListMicrovmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMicrovmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMicrovmsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMicrovmsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags associated with a Lambda MicroVM resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ServiceException">
        /// The AWS Lambda MicroVMs service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. Retry the request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ResumeMicrovm

        internal virtual ResumeMicrovmResponse ResumeMicrovm(ResumeMicrovmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResumeMicrovmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeMicrovmResponseUnmarshaller.Instance;

            return Invoke<ResumeMicrovmResponse>(request, options);
        }



        /// <summary>
        /// Resumes a suspended MicroVM, restoring it to RUNNING state with all state intact.
        /// The MicroVM must be in SUSPENDED state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeMicrovm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResumeMicrovm service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ResumeMicrovm">REST API Reference for ResumeMicrovm Operation</seealso>
        public virtual Task<ResumeMicrovmResponse> ResumeMicrovmAsync(ResumeMicrovmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResumeMicrovmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeMicrovmResponseUnmarshaller.Instance;

            return InvokeAsync<ResumeMicrovmResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RunMicrovm

        internal virtual RunMicrovmResponse RunMicrovm(RunMicrovmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RunMicrovmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunMicrovmResponseUnmarshaller.Instance;

            return Invoke<RunMicrovmResponse>(request, options);
        }



        /// <summary>
        /// Runs a new MicroVM from the specified image. The MicroVM starts in PENDING state and
        /// transitions to RUNNING once provisioning completes. To connect, generate an authentication
        /// token using CreateMicrovmAuthToken.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunMicrovm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RunMicrovm service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota for Lambda MicroVMs.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/RunMicrovm">REST API Reference for RunMicrovm Operation</seealso>
        public virtual Task<RunMicrovmResponse> RunMicrovmAsync(RunMicrovmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RunMicrovmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunMicrovmResponseUnmarshaller.Instance;

            return InvokeAsync<RunMicrovmResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SuspendMicrovm

        internal virtual SuspendMicrovmResponse SuspendMicrovm(SuspendMicrovmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SuspendMicrovmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuspendMicrovmResponseUnmarshaller.Instance;

            return Invoke<SuspendMicrovmResponse>(request, options);
        }



        /// <summary>
        /// Suspends a running MicroVM, preserving its full memory and disk state. The MicroVM
        /// transitions through SUSPENDING to SUSPENDED. To restore, call ResumeMicrovm or send
        /// traffic to the endpoint if autoResumeEnabled is true.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendMicrovm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SuspendMicrovm service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/SuspendMicrovm">REST API Reference for SuspendMicrovm Operation</seealso>
        public virtual Task<SuspendMicrovmResponse> SuspendMicrovmAsync(SuspendMicrovmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SuspendMicrovmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuspendMicrovmResponseUnmarshaller.Instance;

            return InvokeAsync<SuspendMicrovmResponse>(request, options, cancellationToken);
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
        /// Adds tags to a Lambda MicroVM resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ServiceException">
        /// The AWS Lambda MicroVMs service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. Retry the request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TerminateMicrovm

        internal virtual TerminateMicrovmResponse TerminateMicrovm(TerminateMicrovmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TerminateMicrovmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateMicrovmResponseUnmarshaller.Instance;

            return Invoke<TerminateMicrovmResponse>(request, options);
        }



        /// <summary>
        /// Terminates a MicroVM. This operation is idempotent; terminating a MicroVM that has
        /// already been terminated succeeds without error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateMicrovm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateMicrovm service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/TerminateMicrovm">REST API Reference for TerminateMicrovm Operation</seealso>
        public virtual Task<TerminateMicrovmResponse> TerminateMicrovmAsync(TerminateMicrovmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TerminateMicrovmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateMicrovmResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateMicrovmResponse>(request, options, cancellationToken);
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
        /// Removes tags from a Lambda MicroVM resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ServiceException">
        /// The AWS Lambda MicroVMs service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. Retry the request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateMicrovmImage

        internal virtual UpdateMicrovmImageResponse UpdateMicrovmImage(UpdateMicrovmImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMicrovmImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMicrovmImageResponseUnmarshaller.Instance;

            return Invoke<UpdateMicrovmImageResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of a MicroVM image and triggers a new version build. This
        /// operation uses PUT semantics — all required fields (codeArtifact, baseImageArn, buildRoleArn)
        /// must be provided with every request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMicrovmImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMicrovmImage service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota for Lambda MicroVMs.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/UpdateMicrovmImage">REST API Reference for UpdateMicrovmImage Operation</seealso>
        public virtual Task<UpdateMicrovmImageResponse> UpdateMicrovmImageAsync(UpdateMicrovmImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMicrovmImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMicrovmImageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMicrovmImageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateMicrovmImageVersion

        internal virtual UpdateMicrovmImageVersionResponse UpdateMicrovmImageVersion(UpdateMicrovmImageVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMicrovmImageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMicrovmImageVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateMicrovmImageVersionResponse>(request, options);
        }



        /// <summary>
        /// Updates the status of a specific MicroVM image version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMicrovmImageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMicrovmImageVersion service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/UpdateMicrovmImageVersion">REST API Reference for UpdateMicrovmImageVersion Operation</seealso>
        public virtual Task<UpdateMicrovmImageVersionResponse> UpdateMicrovmImageVersionAsync(UpdateMicrovmImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMicrovmImageVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMicrovmImageVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMicrovmImageVersionResponse>(request, options, cancellationToken);
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