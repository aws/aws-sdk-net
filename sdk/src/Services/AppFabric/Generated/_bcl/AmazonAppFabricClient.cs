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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AppFabric.Model;
using Amazon.AppFabric.Model.Internal.MarshallTransformations;
using Amazon.AppFabric.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.AppFabric
{
    /// <summary>
    /// <para>Implementation for accessing AppFabric</para>
    ///
    /// Amazon Web Services AppFabric quickly connects software as a service (SaaS) applications
    /// across your organization. This allows IT and security teams to easily manage and secure
    /// applications using a standard schema, and employees can complete everyday tasks faster
    /// using generative artificial intelligence (AI). You can use these APIs to complete
    /// AppFabric tasks, such as setting up audit log ingestions or viewing user access. For
    /// more information about AppFabric, including the required permissions to use the service,
    /// see the <a href="https://docs.aws.amazon.com/appfabric/latest/adminguide/">Amazon
    /// Web Services AppFabric Administration Guide</a>. For more information about using
    /// the Command Line Interface (CLI) to manage your AppFabric resources, see the <a href="https://docs.aws.amazon.com/cli/latest/reference/appfabric/index.html">AppFabric
    /// section of the CLI Reference</a>.
    /// </summary>
    public partial class AmazonAppFabricClient : AmazonServiceClient, IAmazonAppFabric
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppFabricMetadata();
        private IAppFabricPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAppFabricPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AppFabricPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonAppFabricClient with the credentials loaded from the application's
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
        public AmazonAppFabricClient()
            : base(new AmazonAppFabricConfig()) { }

        /// <summary>
        /// Constructs AmazonAppFabricClient with the credentials loaded from the application's
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
        public AmazonAppFabricClient(RegionEndpoint region)
            : base(new AmazonAppFabricConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppFabricClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAppFabricClient Configuration Object</param>
        public AmazonAppFabricClient(AmazonAppFabricConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonAppFabricClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppFabricClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppFabricConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppFabricClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppFabricClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppFabricConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppFabricClient with AWS Credentials and an
        /// AmazonAppFabricClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppFabricClient Configuration Object</param>
        public AmazonAppFabricClient(AWSCredentials credentials, AmazonAppFabricConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppFabricClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppFabricClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppFabricConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppFabricClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppFabricClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppFabricConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppFabricClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppFabricClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppFabricClient Configuration Object</param>
        public AmazonAppFabricClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppFabricConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppFabricClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppFabricClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppFabricConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppFabricClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppFabricClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppFabricConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppFabricClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppFabricClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppFabricClient Configuration Object</param>
        public AmazonAppFabricClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppFabricConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppFabricEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppFabricAuthSchemeHandler());
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


        #region  BatchGetUserAccessTasks


        /// <summary>
        /// Gets user access details in a batch request.
        /// 
        ///  
        /// <para>
        /// This action polls data from the tasks that are kicked off by the <c>StartUserAccessTasks</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetUserAccessTasks service method.</param>
        /// 
        /// <returns>The response from the BatchGetUserAccessTasks service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/BatchGetUserAccessTasks">REST API Reference for BatchGetUserAccessTasks Operation</seealso>
        public virtual BatchGetUserAccessTasksResponse BatchGetUserAccessTasks(BatchGetUserAccessTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetUserAccessTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetUserAccessTasksResponseUnmarshaller.Instance;

            return Invoke<BatchGetUserAccessTasksResponse>(request, options);
        }


        /// <summary>
        /// Gets user access details in a batch request.
        /// 
        ///  
        /// <para>
        /// This action polls data from the tasks that are kicked off by the <c>StartUserAccessTasks</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetUserAccessTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetUserAccessTasks service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/BatchGetUserAccessTasks">REST API Reference for BatchGetUserAccessTasks Operation</seealso>
        public virtual Task<BatchGetUserAccessTasksResponse> BatchGetUserAccessTasksAsync(BatchGetUserAccessTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetUserAccessTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetUserAccessTasksResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetUserAccessTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConnectAppAuthorization


        /// <summary>
        /// Establishes a connection between Amazon Web Services AppFabric and an application,
        /// which allows AppFabric to call the APIs of the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConnectAppAuthorization service method.</param>
        /// 
        /// <returns>The response from the ConnectAppAuthorization service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ConnectAppAuthorization">REST API Reference for ConnectAppAuthorization Operation</seealso>
        public virtual ConnectAppAuthorizationResponse ConnectAppAuthorization(ConnectAppAuthorizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConnectAppAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectAppAuthorizationResponseUnmarshaller.Instance;

            return Invoke<ConnectAppAuthorizationResponse>(request, options);
        }


        /// <summary>
        /// Establishes a connection between Amazon Web Services AppFabric and an application,
        /// which allows AppFabric to call the APIs of the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConnectAppAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConnectAppAuthorization service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ConnectAppAuthorization">REST API Reference for ConnectAppAuthorization Operation</seealso>
        public virtual Task<ConnectAppAuthorizationResponse> ConnectAppAuthorizationAsync(ConnectAppAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConnectAppAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectAppAuthorizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<ConnectAppAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAppAuthorization


        /// <summary>
        /// Creates an app authorization within an app bundle, which allows AppFabric to connect
        /// to an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppAuthorization service method.</param>
        /// 
        /// <returns>The response from the CreateAppAuthorization service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/CreateAppAuthorization">REST API Reference for CreateAppAuthorization Operation</seealso>
        public virtual CreateAppAuthorizationResponse CreateAppAuthorization(CreateAppAuthorizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAppAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppAuthorizationResponseUnmarshaller.Instance;

            return Invoke<CreateAppAuthorizationResponse>(request, options);
        }


        /// <summary>
        /// Creates an app authorization within an app bundle, which allows AppFabric to connect
        /// to an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppAuthorization service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/CreateAppAuthorization">REST API Reference for CreateAppAuthorization Operation</seealso>
        public virtual Task<CreateAppAuthorizationResponse> CreateAppAuthorizationAsync(CreateAppAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAppAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppAuthorizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAppAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAppBundle


        /// <summary>
        /// Creates an app bundle to collect data from an application using AppFabric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppBundle service method.</param>
        /// 
        /// <returns>The response from the CreateAppBundle service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/CreateAppBundle">REST API Reference for CreateAppBundle Operation</seealso>
        public virtual CreateAppBundleResponse CreateAppBundle(CreateAppBundleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAppBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppBundleResponseUnmarshaller.Instance;

            return Invoke<CreateAppBundleResponse>(request, options);
        }


        /// <summary>
        /// Creates an app bundle to collect data from an application using AppFabric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppBundle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppBundle service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/CreateAppBundle">REST API Reference for CreateAppBundle Operation</seealso>
        public virtual Task<CreateAppBundleResponse> CreateAppBundleAsync(CreateAppBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAppBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppBundleResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAppBundleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIngestion


        /// <summary>
        /// Creates a data ingestion for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestion service method.</param>
        /// 
        /// <returns>The response from the CreateIngestion service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/CreateIngestion">REST API Reference for CreateIngestion Operation</seealso>
        public virtual CreateIngestionResponse CreateIngestion(CreateIngestionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIngestionResponseUnmarshaller.Instance;

            return Invoke<CreateIngestionResponse>(request, options);
        }


        /// <summary>
        /// Creates a data ingestion for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIngestion service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/CreateIngestion">REST API Reference for CreateIngestion Operation</seealso>
        public virtual Task<CreateIngestionResponse> CreateIngestionAsync(CreateIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIngestionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateIngestionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIngestionDestination


        /// <summary>
        /// Creates an ingestion destination, which specifies how an application's ingested data
        /// is processed by Amazon Web Services AppFabric and where it's delivered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestionDestination service method.</param>
        /// 
        /// <returns>The response from the CreateIngestionDestination service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/CreateIngestionDestination">REST API Reference for CreateIngestionDestination Operation</seealso>
        public virtual CreateIngestionDestinationResponse CreateIngestionDestination(CreateIngestionDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIngestionDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIngestionDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateIngestionDestinationResponse>(request, options);
        }


        /// <summary>
        /// Creates an ingestion destination, which specifies how an application's ingested data
        /// is processed by Amazon Web Services AppFabric and where it's delivered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestionDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIngestionDestination service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/CreateIngestionDestination">REST API Reference for CreateIngestionDestination Operation</seealso>
        public virtual Task<CreateIngestionDestinationResponse> CreateIngestionDestinationAsync(CreateIngestionDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIngestionDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIngestionDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateIngestionDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAppAuthorization


        /// <summary>
        /// Deletes an app authorization. You must delete the associated ingestion before you
        /// can delete an app authorization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppAuthorization service method.</param>
        /// 
        /// <returns>The response from the DeleteAppAuthorization service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/DeleteAppAuthorization">REST API Reference for DeleteAppAuthorization Operation</seealso>
        public virtual DeleteAppAuthorizationResponse DeleteAppAuthorization(DeleteAppAuthorizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAppAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DeleteAppAuthorizationResponse>(request, options);
        }


        /// <summary>
        /// Deletes an app authorization. You must delete the associated ingestion before you
        /// can delete an app authorization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppAuthorization service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/DeleteAppAuthorization">REST API Reference for DeleteAppAuthorization Operation</seealso>
        public virtual Task<DeleteAppAuthorizationResponse> DeleteAppAuthorizationAsync(DeleteAppAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAppAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppAuthorizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAppAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAppBundle


        /// <summary>
        /// Deletes an app bundle. You must delete all associated app authorizations before you
        /// can delete an app bundle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppBundle service method.</param>
        /// 
        /// <returns>The response from the DeleteAppBundle service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/DeleteAppBundle">REST API Reference for DeleteAppBundle Operation</seealso>
        public virtual DeleteAppBundleResponse DeleteAppBundle(DeleteAppBundleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAppBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppBundleResponseUnmarshaller.Instance;

            return Invoke<DeleteAppBundleResponse>(request, options);
        }


        /// <summary>
        /// Deletes an app bundle. You must delete all associated app authorizations before you
        /// can delete an app bundle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppBundle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppBundle service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/DeleteAppBundle">REST API Reference for DeleteAppBundle Operation</seealso>
        public virtual Task<DeleteAppBundleResponse> DeleteAppBundleAsync(DeleteAppBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAppBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppBundleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAppBundleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIngestion


        /// <summary>
        /// Deletes an ingestion. You must stop (disable) the ingestion and you must delete all
        /// associated ingestion destinations before you can delete an app ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIngestion service method.</param>
        /// 
        /// <returns>The response from the DeleteIngestion service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/DeleteIngestion">REST API Reference for DeleteIngestion Operation</seealso>
        public virtual DeleteIngestionResponse DeleteIngestion(DeleteIngestionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIngestionResponseUnmarshaller.Instance;

            return Invoke<DeleteIngestionResponse>(request, options);
        }


        /// <summary>
        /// Deletes an ingestion. You must stop (disable) the ingestion and you must delete all
        /// associated ingestion destinations before you can delete an app ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIngestion service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/DeleteIngestion">REST API Reference for DeleteIngestion Operation</seealso>
        public virtual Task<DeleteIngestionResponse> DeleteIngestionAsync(DeleteIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIngestionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteIngestionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIngestionDestination


        /// <summary>
        /// Deletes an ingestion destination.
        /// 
        ///  
        /// <para>
        /// This deletes the association between an ingestion and it's destination. It doesn't
        /// delete previously ingested data or the storage destination, such as the Amazon S3
        /// bucket where the data is delivered. If the ingestion destination is deleted while
        /// the associated ingestion is enabled, the ingestion will fail and is eventually disabled.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIngestionDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteIngestionDestination service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/DeleteIngestionDestination">REST API Reference for DeleteIngestionDestination Operation</seealso>
        public virtual DeleteIngestionDestinationResponse DeleteIngestionDestination(DeleteIngestionDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIngestionDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIngestionDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteIngestionDestinationResponse>(request, options);
        }


        /// <summary>
        /// Deletes an ingestion destination.
        /// 
        ///  
        /// <para>
        /// This deletes the association between an ingestion and it's destination. It doesn't
        /// delete previously ingested data or the storage destination, such as the Amazon S3
        /// bucket where the data is delivered. If the ingestion destination is deleted while
        /// the associated ingestion is enabled, the ingestion will fail and is eventually disabled.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIngestionDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIngestionDestination service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/DeleteIngestionDestination">REST API Reference for DeleteIngestionDestination Operation</seealso>
        public virtual Task<DeleteIngestionDestinationResponse> DeleteIngestionDestinationAsync(DeleteIngestionDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIngestionDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIngestionDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteIngestionDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAppAuthorization


        /// <summary>
        /// Returns information about an app authorization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppAuthorization service method.</param>
        /// 
        /// <returns>The response from the GetAppAuthorization service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/GetAppAuthorization">REST API Reference for GetAppAuthorization Operation</seealso>
        public virtual GetAppAuthorizationResponse GetAppAuthorization(GetAppAuthorizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAppAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppAuthorizationResponseUnmarshaller.Instance;

            return Invoke<GetAppAuthorizationResponse>(request, options);
        }


        /// <summary>
        /// Returns information about an app authorization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppAuthorization service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/GetAppAuthorization">REST API Reference for GetAppAuthorization Operation</seealso>
        public virtual Task<GetAppAuthorizationResponse> GetAppAuthorizationAsync(GetAppAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAppAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppAuthorizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAppAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAppBundle


        /// <summary>
        /// Returns information about an app bundle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppBundle service method.</param>
        /// 
        /// <returns>The response from the GetAppBundle service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/GetAppBundle">REST API Reference for GetAppBundle Operation</seealso>
        public virtual GetAppBundleResponse GetAppBundle(GetAppBundleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAppBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppBundleResponseUnmarshaller.Instance;

            return Invoke<GetAppBundleResponse>(request, options);
        }


        /// <summary>
        /// Returns information about an app bundle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppBundle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppBundle service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/GetAppBundle">REST API Reference for GetAppBundle Operation</seealso>
        public virtual Task<GetAppBundleResponse> GetAppBundleAsync(GetAppBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAppBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppBundleResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAppBundleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIngestion


        /// <summary>
        /// Returns information about an ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIngestion service method.</param>
        /// 
        /// <returns>The response from the GetIngestion service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/GetIngestion">REST API Reference for GetIngestion Operation</seealso>
        public virtual GetIngestionResponse GetIngestion(GetIngestionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIngestionResponseUnmarshaller.Instance;

            return Invoke<GetIngestionResponse>(request, options);
        }


        /// <summary>
        /// Returns information about an ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIngestion service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/GetIngestion">REST API Reference for GetIngestion Operation</seealso>
        public virtual Task<GetIngestionResponse> GetIngestionAsync(GetIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIngestionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetIngestionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIngestionDestination


        /// <summary>
        /// Returns information about an ingestion destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIngestionDestination service method.</param>
        /// 
        /// <returns>The response from the GetIngestionDestination service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/GetIngestionDestination">REST API Reference for GetIngestionDestination Operation</seealso>
        public virtual GetIngestionDestinationResponse GetIngestionDestination(GetIngestionDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIngestionDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIngestionDestinationResponseUnmarshaller.Instance;

            return Invoke<GetIngestionDestinationResponse>(request, options);
        }


        /// <summary>
        /// Returns information about an ingestion destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIngestionDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIngestionDestination service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/GetIngestionDestination">REST API Reference for GetIngestionDestination Operation</seealso>
        public virtual Task<GetIngestionDestinationResponse> GetIngestionDestinationAsync(GetIngestionDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIngestionDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIngestionDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetIngestionDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppAuthorizations


        /// <summary>
        /// Returns a list of all app authorizations configured for an app bundle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppAuthorizations service method.</param>
        /// 
        /// <returns>The response from the ListAppAuthorizations service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ListAppAuthorizations">REST API Reference for ListAppAuthorizations Operation</seealso>
        public virtual ListAppAuthorizationsResponse ListAppAuthorizations(ListAppAuthorizationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAppAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppAuthorizationsResponseUnmarshaller.Instance;

            return Invoke<ListAppAuthorizationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all app authorizations configured for an app bundle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppAuthorizations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppAuthorizations service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ListAppAuthorizations">REST API Reference for ListAppAuthorizations Operation</seealso>
        public virtual Task<ListAppAuthorizationsResponse> ListAppAuthorizationsAsync(ListAppAuthorizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAppAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppAuthorizationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAppAuthorizationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppBundles


        /// <summary>
        /// Returns a list of app bundles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppBundles service method.</param>
        /// 
        /// <returns>The response from the ListAppBundles service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ListAppBundles">REST API Reference for ListAppBundles Operation</seealso>
        public virtual ListAppBundlesResponse ListAppBundles(ListAppBundlesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAppBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppBundlesResponseUnmarshaller.Instance;

            return Invoke<ListAppBundlesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of app bundles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppBundles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppBundles service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ListAppBundles">REST API Reference for ListAppBundles Operation</seealso>
        public virtual Task<ListAppBundlesResponse> ListAppBundlesAsync(ListAppBundlesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAppBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppBundlesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAppBundlesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIngestionDestinations


        /// <summary>
        /// Returns a list of all ingestion destinations configured for an ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestionDestinations service method.</param>
        /// 
        /// <returns>The response from the ListIngestionDestinations service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ListIngestionDestinations">REST API Reference for ListIngestionDestinations Operation</seealso>
        public virtual ListIngestionDestinationsResponse ListIngestionDestinations(ListIngestionDestinationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIngestionDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngestionDestinationsResponseUnmarshaller.Instance;

            return Invoke<ListIngestionDestinationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all ingestion destinations configured for an ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestionDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIngestionDestinations service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ListIngestionDestinations">REST API Reference for ListIngestionDestinations Operation</seealso>
        public virtual Task<ListIngestionDestinationsResponse> ListIngestionDestinationsAsync(ListIngestionDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIngestionDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngestionDestinationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListIngestionDestinationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIngestions


        /// <summary>
        /// Returns a list of all ingestions configured for an app bundle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestions service method.</param>
        /// 
        /// <returns>The response from the ListIngestions service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ListIngestions">REST API Reference for ListIngestions Operation</seealso>
        public virtual ListIngestionsResponse ListIngestions(ListIngestionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIngestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngestionsResponseUnmarshaller.Instance;

            return Invoke<ListIngestionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all ingestions configured for an app bundle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIngestions service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ListIngestions">REST API Reference for ListIngestions Operation</seealso>
        public virtual Task<ListIngestionsResponse> ListIngestionsAsync(ListIngestionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIngestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngestionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListIngestionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartIngestion


        /// <summary>
        /// Starts (enables) an ingestion, which collects data from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIngestion service method.</param>
        /// 
        /// <returns>The response from the StartIngestion service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/StartIngestion">REST API Reference for StartIngestion Operation</seealso>
        public virtual StartIngestionResponse StartIngestion(StartIngestionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartIngestionResponseUnmarshaller.Instance;

            return Invoke<StartIngestionResponse>(request, options);
        }


        /// <summary>
        /// Starts (enables) an ingestion, which collects data from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartIngestion service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/StartIngestion">REST API Reference for StartIngestion Operation</seealso>
        public virtual Task<StartIngestionResponse> StartIngestionAsync(StartIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartIngestionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartIngestionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartUserAccessTasks


        /// <summary>
        /// Starts the tasks to search user access status for a specific email address.
        /// 
        ///  
        /// <para>
        /// The tasks are stopped when the user access status data is found. The tasks are terminated
        /// when the API calls to the application time out.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartUserAccessTasks service method.</param>
        /// 
        /// <returns>The response from the StartUserAccessTasks service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/StartUserAccessTasks">REST API Reference for StartUserAccessTasks Operation</seealso>
        public virtual StartUserAccessTasksResponse StartUserAccessTasks(StartUserAccessTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartUserAccessTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartUserAccessTasksResponseUnmarshaller.Instance;

            return Invoke<StartUserAccessTasksResponse>(request, options);
        }


        /// <summary>
        /// Starts the tasks to search user access status for a specific email address.
        /// 
        ///  
        /// <para>
        /// The tasks are stopped when the user access status data is found. The tasks are terminated
        /// when the API calls to the application time out.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartUserAccessTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartUserAccessTasks service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/StartUserAccessTasks">REST API Reference for StartUserAccessTasks Operation</seealso>
        public virtual Task<StartUserAccessTasksResponse> StartUserAccessTasksAsync(StartUserAccessTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartUserAccessTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartUserAccessTasksResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartUserAccessTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopIngestion


        /// <summary>
        /// Stops (disables) an ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopIngestion service method.</param>
        /// 
        /// <returns>The response from the StopIngestion service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/StopIngestion">REST API Reference for StopIngestion Operation</seealso>
        public virtual StopIngestionResponse StopIngestion(StopIngestionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopIngestionResponseUnmarshaller.Instance;

            return Invoke<StopIngestionResponse>(request, options);
        }


        /// <summary>
        /// Stops (disables) an ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopIngestion service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/StopIngestion">REST API Reference for StopIngestion Operation</seealso>
        public virtual Task<StopIngestionResponse> StopIngestionAsync(StopIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopIngestionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopIngestionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAppAuthorization


        /// <summary>
        /// Updates an app authorization within an app bundle, which allows AppFabric to connect
        /// to an application.
        /// 
        ///  
        /// <para>
        /// If the app authorization was in a <c>connected</c> state, updating the app authorization
        /// will set it back to a <c>PendingConnect</c> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppAuthorization service method.</param>
        /// 
        /// <returns>The response from the UpdateAppAuthorization service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/UpdateAppAuthorization">REST API Reference for UpdateAppAuthorization Operation</seealso>
        public virtual UpdateAppAuthorizationResponse UpdateAppAuthorization(UpdateAppAuthorizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAppAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppAuthorizationResponseUnmarshaller.Instance;

            return Invoke<UpdateAppAuthorizationResponse>(request, options);
        }


        /// <summary>
        /// Updates an app authorization within an app bundle, which allows AppFabric to connect
        /// to an application.
        /// 
        ///  
        /// <para>
        /// If the app authorization was in a <c>connected</c> state, updating the app authorization
        /// will set it back to a <c>PendingConnect</c> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAppAuthorization service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/UpdateAppAuthorization">REST API Reference for UpdateAppAuthorization Operation</seealso>
        public virtual Task<UpdateAppAuthorizationResponse> UpdateAppAuthorizationAsync(UpdateAppAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAppAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppAuthorizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAppAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIngestionDestination


        /// <summary>
        /// Updates an ingestion destination, which specifies how an application's ingested data
        /// is processed by Amazon Web Services AppFabric and where it's delivered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIngestionDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateIngestionDestination service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/UpdateIngestionDestination">REST API Reference for UpdateIngestionDestination Operation</seealso>
        public virtual UpdateIngestionDestinationResponse UpdateIngestionDestination(UpdateIngestionDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIngestionDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIngestionDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateIngestionDestinationResponse>(request, options);
        }


        /// <summary>
        /// Updates an ingestion destination, which specifies how an application's ingested data
        /// is processed by Amazon Web Services AppFabric and where it's delivered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIngestionDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIngestionDestination service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/UpdateIngestionDestination">REST API Reference for UpdateIngestionDestination Operation</seealso>
        public virtual Task<UpdateIngestionDestinationResponse> UpdateIngestionDestinationAsync(UpdateIngestionDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIngestionDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIngestionDestinationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateIngestionDestinationResponse>(request, options, cancellationToken);
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