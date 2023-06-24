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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AmplifyBackend.Model;
using Amazon.AmplifyBackend.Model.Internal.MarshallTransformations;
using Amazon.AmplifyBackend.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AmplifyBackend
{
    /// <summary>
    /// Implementation for accessing AmplifyBackend
    ///
    /// AWS Amplify Admin API
    /// </summary>
    public partial class AmazonAmplifyBackendClient : AmazonServiceClient, IAmazonAmplifyBackend
    {
        private static IServiceMetadata serviceMetadata = new AmazonAmplifyBackendMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with the credentials loaded from the application's
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
        public AmazonAmplifyBackendClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAmplifyBackendConfig()) { }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with the credentials loaded from the application's
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
        public AmazonAmplifyBackendClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAmplifyBackendConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAmplifyBackendClient Configuration Object</param>
        public AmazonAmplifyBackendClient(AmazonAmplifyBackendConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAmplifyBackendClient(AWSCredentials credentials)
            : this(credentials, new AmazonAmplifyBackendConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyBackendClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAmplifyBackendConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Credentials and an
        /// AmazonAmplifyBackendClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAmplifyBackendClient Configuration Object</param>
        public AmazonAmplifyBackendClient(AWSCredentials credentials, AmazonAmplifyBackendConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAmplifyBackendClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAmplifyBackendConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyBackendClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAmplifyBackendConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAmplifyBackendClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAmplifyBackendClient Configuration Object</param>
        public AmazonAmplifyBackendClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAmplifyBackendConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAmplifyBackendClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAmplifyBackendConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyBackendClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAmplifyBackendConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyBackendClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAmplifyBackendClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAmplifyBackendClient Configuration Object</param>
        public AmazonAmplifyBackendClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAmplifyBackendConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IAmplifyBackendPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAmplifyBackendPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AmplifyBackendPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAmplifyBackendEndpointResolver());
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


        #region  CloneBackend

        internal virtual CloneBackendResponse CloneBackend(CloneBackendRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CloneBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloneBackendResponseUnmarshaller.Instance;

            return Invoke<CloneBackendResponse>(request, options);
        }



        /// <summary>
        /// This operation clones an existing backend.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloneBackend service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CloneBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CloneBackend">REST API Reference for CloneBackend Operation</seealso>
        public virtual Task<CloneBackendResponse> CloneBackendAsync(CloneBackendRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CloneBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloneBackendResponseUnmarshaller.Instance;

            return InvokeAsync<CloneBackendResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBackend

        internal virtual CreateBackendResponse CreateBackend(CreateBackendRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendResponseUnmarshaller.Instance;

            return Invoke<CreateBackendResponse>(request, options);
        }



        /// <summary>
        /// This operation creates a backend for an Amplify app. Backends are automatically created
        /// at the time of app creation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackend service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackend">REST API Reference for CreateBackend Operation</seealso>
        public virtual Task<CreateBackendResponse> CreateBackendAsync(CreateBackendRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBackendResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBackendAPI

        internal virtual CreateBackendAPIResponse CreateBackendAPI(CreateBackendAPIRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendAPIResponseUnmarshaller.Instance;

            return Invoke<CreateBackendAPIResponse>(request, options);
        }



        /// <summary>
        /// Creates a new backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendAPI service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAPI">REST API Reference for CreateBackendAPI Operation</seealso>
        public virtual Task<CreateBackendAPIResponse> CreateBackendAPIAsync(CreateBackendAPIRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendAPIResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBackendAPIResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBackendAuth

        internal virtual CreateBackendAuthResponse CreateBackendAuth(CreateBackendAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendAuthResponseUnmarshaller.Instance;

            return Invoke<CreateBackendAuthResponse>(request, options);
        }



        /// <summary>
        /// Creates a new backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendAuth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAuth">REST API Reference for CreateBackendAuth Operation</seealso>
        public virtual Task<CreateBackendAuthResponse> CreateBackendAuthAsync(CreateBackendAuthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendAuthResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBackendAuthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBackendConfig

        internal virtual CreateBackendConfigResponse CreateBackendConfig(CreateBackendConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendConfigResponseUnmarshaller.Instance;

            return Invoke<CreateBackendConfigResponse>(request, options);
        }



        /// <summary>
        /// Creates a config object for a backend.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBackendConfig service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendConfig">REST API Reference for CreateBackendConfig Operation</seealso>
        public virtual Task<CreateBackendConfigResponse> CreateBackendConfigAsync(CreateBackendConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBackendConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBackendStorage

        internal virtual CreateBackendStorageResponse CreateBackendStorage(CreateBackendStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendStorageResponseUnmarshaller.Instance;

            return Invoke<CreateBackendStorageResponse>(request, options);
        }



        /// <summary>
        /// Creates a backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendStorage">REST API Reference for CreateBackendStorage Operation</seealso>
        public virtual Task<CreateBackendStorageResponse> CreateBackendStorageAsync(CreateBackendStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackendStorageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBackendStorageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateToken

        internal virtual CreateTokenResponse CreateToken(CreateTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTokenResponseUnmarshaller.Instance;

            return Invoke<CreateTokenResponse>(request, options);
        }



        /// <summary>
        /// Generates a one-time challenge code to authenticate a user into your Amplify Admin
        /// UI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateToken service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateToken">REST API Reference for CreateToken Operation</seealso>
        public virtual Task<CreateTokenResponse> CreateTokenAsync(CreateTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTokenResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBackend

        internal virtual DeleteBackendResponse DeleteBackend(DeleteBackendRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendResponseUnmarshaller.Instance;

            return Invoke<DeleteBackendResponse>(request, options);
        }



        /// <summary>
        /// Removes an existing environment from your Amplify project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackend service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackend">REST API Reference for DeleteBackend Operation</seealso>
        public virtual Task<DeleteBackendResponse> DeleteBackendAsync(DeleteBackendRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBackendResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBackendAPI

        internal virtual DeleteBackendAPIResponse DeleteBackendAPI(DeleteBackendAPIRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendAPIResponseUnmarshaller.Instance;

            return Invoke<DeleteBackendAPIResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendAPI service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAPI">REST API Reference for DeleteBackendAPI Operation</seealso>
        public virtual Task<DeleteBackendAPIResponse> DeleteBackendAPIAsync(DeleteBackendAPIRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendAPIResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBackendAPIResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBackendAuth

        internal virtual DeleteBackendAuthResponse DeleteBackendAuth(DeleteBackendAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendAuthResponseUnmarshaller.Instance;

            return Invoke<DeleteBackendAuthResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendAuth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAuth">REST API Reference for DeleteBackendAuth Operation</seealso>
        public virtual Task<DeleteBackendAuthResponse> DeleteBackendAuthAsync(DeleteBackendAuthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendAuthResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBackendAuthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBackendStorage

        internal virtual DeleteBackendStorageResponse DeleteBackendStorage(DeleteBackendStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendStorageResponseUnmarshaller.Instance;

            return Invoke<DeleteBackendStorageResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendStorage">REST API Reference for DeleteBackendStorage Operation</seealso>
        public virtual Task<DeleteBackendStorageResponse> DeleteBackendStorageAsync(DeleteBackendStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackendStorageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBackendStorageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteToken

        internal virtual DeleteTokenResponse DeleteToken(DeleteTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTokenResponseUnmarshaller.Instance;

            return Invoke<DeleteTokenResponse>(request, options);
        }



        /// <summary>
        /// Deletes the challenge token based on the given appId and sessionId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteToken service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteToken">REST API Reference for DeleteToken Operation</seealso>
        public virtual Task<DeleteTokenResponse> DeleteTokenAsync(DeleteTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTokenResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateBackendAPIModels

        internal virtual GenerateBackendAPIModelsResponse GenerateBackendAPIModels(GenerateBackendAPIModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateBackendAPIModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateBackendAPIModelsResponseUnmarshaller.Instance;

            return Invoke<GenerateBackendAPIModelsResponse>(request, options);
        }



        /// <summary>
        /// Generates a model schema for an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateBackendAPIModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateBackendAPIModels service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GenerateBackendAPIModels">REST API Reference for GenerateBackendAPIModels Operation</seealso>
        public virtual Task<GenerateBackendAPIModelsResponse> GenerateBackendAPIModelsAsync(GenerateBackendAPIModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateBackendAPIModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateBackendAPIModelsResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateBackendAPIModelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBackend

        internal virtual GetBackendResponse GetBackend(GetBackendRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendResponseUnmarshaller.Instance;

            return Invoke<GetBackendResponse>(request, options);
        }



        /// <summary>
        /// Provides project-level details for your Amplify UI project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackend service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackend">REST API Reference for GetBackend Operation</seealso>
        public virtual Task<GetBackendResponse> GetBackendAsync(GetBackendRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendResponseUnmarshaller.Instance;

            return InvokeAsync<GetBackendResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBackendAPI

        internal virtual GetBackendAPIResponse GetBackendAPI(GetBackendAPIRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendAPIResponseUnmarshaller.Instance;

            return Invoke<GetBackendAPIResponse>(request, options);
        }



        /// <summary>
        /// Gets the details for a backend API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAPI service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPI">REST API Reference for GetBackendAPI Operation</seealso>
        public virtual Task<GetBackendAPIResponse> GetBackendAPIAsync(GetBackendAPIRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendAPIResponseUnmarshaller.Instance;

            return InvokeAsync<GetBackendAPIResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBackendAPIModels

        internal virtual GetBackendAPIModelsResponse GetBackendAPIModels(GetBackendAPIModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendAPIModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendAPIModelsResponseUnmarshaller.Instance;

            return Invoke<GetBackendAPIModelsResponse>(request, options);
        }



        /// <summary>
        /// Gets a model introspection schema for an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAPIModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBackendAPIModels service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPIModels">REST API Reference for GetBackendAPIModels Operation</seealso>
        public virtual Task<GetBackendAPIModelsResponse> GetBackendAPIModelsAsync(GetBackendAPIModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendAPIModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendAPIModelsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBackendAPIModelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBackendAuth

        internal virtual GetBackendAuthResponse GetBackendAuth(GetBackendAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendAuthResponseUnmarshaller.Instance;

            return Invoke<GetBackendAuthResponse>(request, options);
        }



        /// <summary>
        /// Gets a backend auth details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAuth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAuth">REST API Reference for GetBackendAuth Operation</seealso>
        public virtual Task<GetBackendAuthResponse> GetBackendAuthAsync(GetBackendAuthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendAuthResponseUnmarshaller.Instance;

            return InvokeAsync<GetBackendAuthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBackendJob

        internal virtual GetBackendJobResponse GetBackendJob(GetBackendJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendJobResponseUnmarshaller.Instance;

            return Invoke<GetBackendJobResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specific job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBackendJob service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendJob">REST API Reference for GetBackendJob Operation</seealso>
        public virtual Task<GetBackendJobResponse> GetBackendJobAsync(GetBackendJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetBackendJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBackendStorage

        internal virtual GetBackendStorageResponse GetBackendStorage(GetBackendStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendStorageResponseUnmarshaller.Instance;

            return Invoke<GetBackendStorageResponse>(request, options);
        }



        /// <summary>
        /// Gets details for a backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendStorage">REST API Reference for GetBackendStorage Operation</seealso>
        public virtual Task<GetBackendStorageResponse> GetBackendStorageAsync(GetBackendStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackendStorageResponseUnmarshaller.Instance;

            return InvokeAsync<GetBackendStorageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetToken

        internal virtual GetTokenResponse GetToken(GetTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTokenResponseUnmarshaller.Instance;

            return Invoke<GetTokenResponse>(request, options);
        }



        /// <summary>
        /// Gets the challenge token based on the given appId and sessionId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetToken service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetToken">REST API Reference for GetToken Operation</seealso>
        public virtual Task<GetTokenResponse> GetTokenAsync(GetTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTokenResponseUnmarshaller.Instance;

            return InvokeAsync<GetTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportBackendAuth

        internal virtual ImportBackendAuthResponse ImportBackendAuth(ImportBackendAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportBackendAuthResponseUnmarshaller.Instance;

            return Invoke<ImportBackendAuthResponse>(request, options);
        }



        /// <summary>
        /// Imports an existing backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportBackendAuth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendAuth">REST API Reference for ImportBackendAuth Operation</seealso>
        public virtual Task<ImportBackendAuthResponse> ImportBackendAuthAsync(ImportBackendAuthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportBackendAuthResponseUnmarshaller.Instance;

            return InvokeAsync<ImportBackendAuthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportBackendStorage

        internal virtual ImportBackendStorageResponse ImportBackendStorage(ImportBackendStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportBackendStorageResponseUnmarshaller.Instance;

            return Invoke<ImportBackendStorageResponse>(request, options);
        }



        /// <summary>
        /// Imports an existing backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportBackendStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendStorage">REST API Reference for ImportBackendStorage Operation</seealso>
        public virtual Task<ImportBackendStorageResponse> ImportBackendStorageAsync(ImportBackendStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportBackendStorageResponseUnmarshaller.Instance;

            return InvokeAsync<ImportBackendStorageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBackendJobs

        internal virtual ListBackendJobsResponse ListBackendJobs(ListBackendJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackendJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackendJobsResponseUnmarshaller.Instance;

            return Invoke<ListBackendJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists the jobs for the backend of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackendJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBackendJobs service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListBackendJobs">REST API Reference for ListBackendJobs Operation</seealso>
        public virtual Task<ListBackendJobsResponse> ListBackendJobsAsync(ListBackendJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackendJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackendJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBackendJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListS3Buckets

        internal virtual ListS3BucketsResponse ListS3Buckets(ListS3BucketsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListS3BucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListS3BucketsResponseUnmarshaller.Instance;

            return Invoke<ListS3BucketsResponse>(request, options);
        }



        /// <summary>
        /// The list of S3 buckets in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListS3Buckets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListS3Buckets service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListS3Buckets">REST API Reference for ListS3Buckets Operation</seealso>
        public virtual Task<ListS3BucketsResponse> ListS3BucketsAsync(ListS3BucketsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListS3BucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListS3BucketsResponseUnmarshaller.Instance;

            return InvokeAsync<ListS3BucketsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveAllBackends

        internal virtual RemoveAllBackendsResponse RemoveAllBackends(RemoveAllBackendsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAllBackendsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAllBackendsResponseUnmarshaller.Instance;

            return Invoke<RemoveAllBackendsResponse>(request, options);
        }



        /// <summary>
        /// Removes all backend environments from your Amplify project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAllBackends service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveAllBackends service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveAllBackends">REST API Reference for RemoveAllBackends Operation</seealso>
        public virtual Task<RemoveAllBackendsResponse> RemoveAllBackendsAsync(RemoveAllBackendsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAllBackendsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAllBackendsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAllBackendsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveBackendConfig

        internal virtual RemoveBackendConfigResponse RemoveBackendConfig(RemoveBackendConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveBackendConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveBackendConfigResponseUnmarshaller.Instance;

            return Invoke<RemoveBackendConfigResponse>(request, options);
        }



        /// <summary>
        /// Removes the AWS resources required to access the Amplify Admin UI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveBackendConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveBackendConfig service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveBackendConfig">REST API Reference for RemoveBackendConfig Operation</seealso>
        public virtual Task<RemoveBackendConfigResponse> RemoveBackendConfigAsync(RemoveBackendConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveBackendConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveBackendConfigResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveBackendConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBackendAPI

        internal virtual UpdateBackendAPIResponse UpdateBackendAPI(UpdateBackendAPIRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendAPIResponseUnmarshaller.Instance;

            return Invoke<UpdateBackendAPIResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendAPI service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAPI">REST API Reference for UpdateBackendAPI Operation</seealso>
        public virtual Task<UpdateBackendAPIResponse> UpdateBackendAPIAsync(UpdateBackendAPIRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendAPIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendAPIResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBackendAPIResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBackendAuth

        internal virtual UpdateBackendAuthResponse UpdateBackendAuth(UpdateBackendAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendAuthResponseUnmarshaller.Instance;

            return Invoke<UpdateBackendAuthResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendAuth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAuth">REST API Reference for UpdateBackendAuth Operation</seealso>
        public virtual Task<UpdateBackendAuthResponse> UpdateBackendAuthAsync(UpdateBackendAuthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendAuthResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBackendAuthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBackendConfig

        internal virtual UpdateBackendConfigResponse UpdateBackendConfig(UpdateBackendConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateBackendConfigResponse>(request, options);
        }



        /// <summary>
        /// Updates the AWS resources required to access the Amplify Admin UI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBackendConfig service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendConfig">REST API Reference for UpdateBackendConfig Operation</seealso>
        public virtual Task<UpdateBackendConfigResponse> UpdateBackendConfigAsync(UpdateBackendConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBackendConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBackendJob

        internal virtual UpdateBackendJobResponse UpdateBackendJob(UpdateBackendJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendJobResponseUnmarshaller.Instance;

            return Invoke<UpdateBackendJobResponse>(request, options);
        }



        /// <summary>
        /// Updates a specific job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBackendJob service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendJob">REST API Reference for UpdateBackendJob Operation</seealso>
        public virtual Task<UpdateBackendJobResponse> UpdateBackendJobAsync(UpdateBackendJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBackendJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBackendStorage

        internal virtual UpdateBackendStorageResponse UpdateBackendStorage(UpdateBackendStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendStorageResponseUnmarshaller.Instance;

            return Invoke<UpdateBackendStorageResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendStorage">REST API Reference for UpdateBackendStorage Operation</seealso>
        public virtual Task<UpdateBackendStorageResponse> UpdateBackendStorageAsync(UpdateBackendStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackendStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackendStorageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBackendStorageResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}