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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AppSync.Model;
using Amazon.AppSync.Model.Internal.MarshallTransformations;
using Amazon.AppSync.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.AppSync
{
    /// <summary>
    /// <para>Implementation for accessing AppSync</para>
    ///
    /// AppSync provides API actions for creating and interacting with data sources using
    /// GraphQL from your application.
    /// </summary>
    public partial class AmazonAppSyncClient : AmazonServiceClient, IAmazonAppSync
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppSyncMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAppSyncClient with the credentials loaded from the application's
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
        public AmazonAppSyncClient()
            : base(new AmazonAppSyncConfig()) { }

        /// <summary>
        /// Constructs AmazonAppSyncClient with the credentials loaded from the application's
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
        public AmazonAppSyncClient(RegionEndpoint region)
            : base(new AmazonAppSyncConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppSyncClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAppSyncClient Configuration Object</param>
        public AmazonAppSyncClient(AmazonAppSyncConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppSyncClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppSyncClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Credentials and an
        /// AmazonAppSyncClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppSyncClient Configuration Object</param>
        public AmazonAppSyncClient(AWSCredentials credentials, AmazonAppSyncConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppSyncClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppSyncClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppSyncConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppSyncClient Configuration Object</param>
        public AmazonAppSyncClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppSyncConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppSyncClient Configuration Object</param>
        public AmazonAppSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppSyncConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IAppSyncPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAppSyncPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AppSyncPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppSyncEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppSyncAuthSchemeHandler());
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


        #region  AssociateApi

        internal virtual AssociateApiResponse AssociateApi(AssociateApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApiResponseUnmarshaller.Instance;

            return Invoke<AssociateApiResponse>(request, options);
        }



        /// <summary>
        /// Maps an endpoint to your custom domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/AssociateApi">REST API Reference for AssociateApi Operation</seealso>
        public virtual Task<AssociateApiResponse> AssociateApiAsync(AssociateApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApiResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateApiResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateMergedGraphqlApi

        internal virtual AssociateMergedGraphqlApiResponse AssociateMergedGraphqlApi(AssociateMergedGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMergedGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMergedGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<AssociateMergedGraphqlApiResponse>(request, options);
        }



        /// <summary>
        /// Creates an association between a Merged API and source API using the source API's
        /// identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMergedGraphqlApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateMergedGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/AssociateMergedGraphqlApi">REST API Reference for AssociateMergedGraphqlApi Operation</seealso>
        public virtual Task<AssociateMergedGraphqlApiResponse> AssociateMergedGraphqlApiAsync(AssociateMergedGraphqlApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMergedGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMergedGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateMergedGraphqlApiResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateSourceGraphqlApi

        internal virtual AssociateSourceGraphqlApiResponse AssociateSourceGraphqlApi(AssociateSourceGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateSourceGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSourceGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<AssociateSourceGraphqlApiResponse>(request, options);
        }



        /// <summary>
        /// Creates an association between a Merged API and source API using the Merged API's
        /// identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceGraphqlApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateSourceGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/AssociateSourceGraphqlApi">REST API Reference for AssociateSourceGraphqlApi Operation</seealso>
        public virtual Task<AssociateSourceGraphqlApiResponse> AssociateSourceGraphqlApiAsync(AssociateSourceGraphqlApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateSourceGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSourceGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateSourceGraphqlApiResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateApi

        internal virtual CreateApiResponse CreateApi(CreateApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiResponseUnmarshaller.Instance;

            return Invoke<CreateApiResponse>(request, options);
        }



        /// <summary>
        /// Creates an <c>Api</c> object. Use this operation to create an AppSync API with your
        /// preferred configuration, such as an Event API that provides real-time message publishing
        /// and message subscriptions over WebSockets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateApi">REST API Reference for CreateApi Operation</seealso>
        public virtual Task<CreateApiResponse> CreateApiAsync(CreateApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApiResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateApiCache

        internal virtual CreateApiCacheResponse CreateApiCache(CreateApiCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiCacheResponseUnmarshaller.Instance;

            return Invoke<CreateApiCacheResponse>(request, options);
        }



        /// <summary>
        /// Creates a cache for the GraphQL API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApiCache service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateApiCache">REST API Reference for CreateApiCache Operation</seealso>
        public virtual Task<CreateApiCacheResponse> CreateApiCacheAsync(CreateApiCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiCacheResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApiCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateApiKey

        internal virtual CreateApiKeyResponse CreateApiKey(CreateApiKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return Invoke<CreateApiKeyResponse>(request, options);
        }



        /// <summary>
        /// Creates a unique key that you can distribute to clients who invoke your API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApiKey service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ApiKeyLimitExceededException">
        /// The API key exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ApiKeyValidityOutOfBoundsException">
        /// The API key expiration must be set to a value between 1 and 365 days from creation
        /// (for <c>CreateApiKey</c>) or from update (for <c>UpdateApiKey</c>).
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateApiKey">REST API Reference for CreateApiKey Operation</seealso>
        public virtual Task<CreateApiKeyResponse> CreateApiKeyAsync(CreateApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApiKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateChannelNamespace

        internal virtual CreateChannelNamespaceResponse CreateChannelNamespace(CreateChannelNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreateChannelNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Creates a <c>ChannelNamespace</c> for an <c>Api</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannelNamespace service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConflictException">
        /// A conflict with a previous successful update is detected. This typically occurs when
        /// the previous update did not have time to propagate before the next update was made.
        /// A retry (with appropriate backoff logic) is the recommended response to this exception.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateChannelNamespace">REST API Reference for CreateChannelNamespace Operation</seealso>
        public virtual Task<CreateChannelNamespaceResponse> CreateChannelNamespaceAsync(CreateChannelNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChannelNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDataSource

        internal virtual CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Creates a <c>DataSource</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDomainName

        internal virtual CreateDomainNameResponse CreateDomainName(CreateDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return Invoke<CreateDomainNameResponse>(request, options);
        }



        /// <summary>
        /// Creates a custom <c>DomainName</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomainName service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        public virtual Task<CreateDomainNameResponse> CreateDomainNameAsync(CreateDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainNameResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFunction

        internal virtual CreateFunctionResponse CreateFunction(CreateFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionResponseUnmarshaller.Instance;

            return Invoke<CreateFunctionResponse>(request, options);
        }



        /// <summary>
        /// Creates a <c>Function</c> object.
        /// 
        ///  
        /// <para>
        /// A function is a reusable entity. You can use multiple functions to compose the resolver
        /// logic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFunction service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        public virtual Task<CreateFunctionResponse> CreateFunctionAsync(CreateFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFunctionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGraphqlApi

        internal virtual CreateGraphqlApiResponse CreateGraphqlApi(CreateGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<CreateGraphqlApiResponse>(request, options);
        }



        /// <summary>
        /// Creates a <c>GraphqlApi</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraphqlApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ApiLimitExceededException">
        /// The GraphQL API exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateGraphqlApi">REST API Reference for CreateGraphqlApi Operation</seealso>
        public virtual Task<CreateGraphqlApiResponse> CreateGraphqlApiAsync(CreateGraphqlApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGraphqlApiResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateResolver

        internal virtual CreateResolverResponse CreateResolver(CreateResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverResponseUnmarshaller.Instance;

            return Invoke<CreateResolverResponse>(request, options);
        }



        /// <summary>
        /// Creates a <c>Resolver</c> object.
        /// 
        ///  
        /// <para>
        /// A resolver converts incoming requests into a format that a data source can understand,
        /// and converts the data source's responses into GraphQL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResolver service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResolver service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateResolver">REST API Reference for CreateResolver Operation</seealso>
        public virtual Task<CreateResolverResponse> CreateResolverAsync(CreateResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResolverResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateType

        internal virtual CreateTypeResponse CreateType(CreateTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTypeResponseUnmarshaller.Instance;

            return Invoke<CreateTypeResponse>(request, options);
        }



        /// <summary>
        /// Creates a <c>Type</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateType service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/CreateType">REST API Reference for CreateType Operation</seealso>
        public virtual Task<CreateTypeResponse> CreateTypeAsync(CreateTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTypeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteApi

        internal virtual DeleteApiResponse DeleteApi(DeleteApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiResponseUnmarshaller.Instance;

            return Invoke<DeleteApiResponse>(request, options);
        }



        /// <summary>
        /// Deletes an <c>Api</c> object
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteApi">REST API Reference for DeleteApi Operation</seealso>
        public virtual Task<DeleteApiResponse> DeleteApiAsync(DeleteApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApiResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteApiCache

        internal virtual DeleteApiCacheResponse DeleteApiCache(DeleteApiCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiCacheResponseUnmarshaller.Instance;

            return Invoke<DeleteApiCacheResponse>(request, options);
        }



        /// <summary>
        /// Deletes an <c>ApiCache</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApiCache service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteApiCache">REST API Reference for DeleteApiCache Operation</seealso>
        public virtual Task<DeleteApiCacheResponse> DeleteApiCacheAsync(DeleteApiCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiCacheResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApiCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteApiKey

        internal virtual DeleteApiKeyResponse DeleteApiKey(DeleteApiKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteApiKeyResponse>(request, options);
        }



        /// <summary>
        /// Deletes an API key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApiKey service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteApiKey">REST API Reference for DeleteApiKey Operation</seealso>
        public virtual Task<DeleteApiKeyResponse> DeleteApiKeyAsync(DeleteApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApiKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteChannelNamespace

        internal virtual DeleteChannelNamespaceResponse DeleteChannelNamespace(DeleteChannelNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a <c>ChannelNamespace</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannelNamespace service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteChannelNamespace">REST API Reference for DeleteChannelNamespace Operation</seealso>
        public virtual Task<DeleteChannelNamespaceResponse> DeleteChannelNamespaceAsync(DeleteChannelNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChannelNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDataSource

        internal virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a <c>DataSource</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDomainName

        internal virtual DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainNameResponse>(request, options);
        }



        /// <summary>
        /// Deletes a custom <c>DomainName</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomainName service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        public virtual Task<DeleteDomainNameResponse> DeleteDomainNameAsync(DeleteDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainNameResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFunction

        internal virtual DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a <c>Function</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFunction service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual Task<DeleteFunctionResponse> DeleteFunctionAsync(DeleteFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFunctionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGraphqlApi

        internal virtual DeleteGraphqlApiResponse DeleteGraphqlApi(DeleteGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<DeleteGraphqlApiResponse>(request, options);
        }



        /// <summary>
        /// Deletes a <c>GraphqlApi</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraphqlApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteGraphqlApi">REST API Reference for DeleteGraphqlApi Operation</seealso>
        public virtual Task<DeleteGraphqlApiResponse> DeleteGraphqlApiAsync(DeleteGraphqlApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGraphqlApiResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteResolver

        internal virtual DeleteResolverResponse DeleteResolver(DeleteResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverResponseUnmarshaller.Instance;

            return Invoke<DeleteResolverResponse>(request, options);
        }



        /// <summary>
        /// Deletes a <c>Resolver</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolver service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResolver service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteResolver">REST API Reference for DeleteResolver Operation</seealso>
        public virtual Task<DeleteResolverResponse> DeleteResolverAsync(DeleteResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResolverResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteType

        internal virtual DeleteTypeResponse DeleteType(DeleteTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteTypeResponse>(request, options);
        }



        /// <summary>
        /// Deletes a <c>Type</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteType service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DeleteType">REST API Reference for DeleteType Operation</seealso>
        public virtual Task<DeleteTypeResponse> DeleteTypeAsync(DeleteTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateApi

        internal virtual DisassociateApiResponse DisassociateApi(DisassociateApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApiResponseUnmarshaller.Instance;

            return Invoke<DisassociateApiResponse>(request, options);
        }



        /// <summary>
        /// Removes an <c>ApiAssociation</c> object from a custom domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DisassociateApi">REST API Reference for DisassociateApi Operation</seealso>
        public virtual Task<DisassociateApiResponse> DisassociateApiAsync(DisassociateApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApiResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateApiResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateMergedGraphqlApi

        internal virtual DisassociateMergedGraphqlApiResponse DisassociateMergedGraphqlApi(DisassociateMergedGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMergedGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMergedGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<DisassociateMergedGraphqlApiResponse>(request, options);
        }



        /// <summary>
        /// Deletes an association between a Merged API and source API using the source API's
        /// identifier and the association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMergedGraphqlApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMergedGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DisassociateMergedGraphqlApi">REST API Reference for DisassociateMergedGraphqlApi Operation</seealso>
        public virtual Task<DisassociateMergedGraphqlApiResponse> DisassociateMergedGraphqlApiAsync(DisassociateMergedGraphqlApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMergedGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMergedGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateMergedGraphqlApiResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateSourceGraphqlApi

        internal virtual DisassociateSourceGraphqlApiResponse DisassociateSourceGraphqlApi(DisassociateSourceGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateSourceGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSourceGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<DisassociateSourceGraphqlApiResponse>(request, options);
        }



        /// <summary>
        /// Deletes an association between a Merged API and source API using the Merged API's
        /// identifier and the association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSourceGraphqlApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateSourceGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/DisassociateSourceGraphqlApi">REST API Reference for DisassociateSourceGraphqlApi Operation</seealso>
        public virtual Task<DisassociateSourceGraphqlApiResponse> DisassociateSourceGraphqlApiAsync(DisassociateSourceGraphqlApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateSourceGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSourceGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateSourceGraphqlApiResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EvaluateCode

        internal virtual EvaluateCodeResponse EvaluateCode(EvaluateCodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EvaluateCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateCodeResponseUnmarshaller.Instance;

            return Invoke<EvaluateCodeResponse>(request, options);
        }



        /// <summary>
        /// Evaluates the given code and returns the response. The code definition requirements
        /// depend on the specified runtime. For <c>APPSYNC_JS</c> runtimes, the code defines
        /// the request and response functions. The request function takes the incoming request
        /// after a GraphQL operation is parsed and converts it into a request configuration for
        /// the selected data source operation. The response function interprets responses from
        /// the data source and maps it to the shape of the GraphQL field output type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvaluateCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EvaluateCode service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/EvaluateCode">REST API Reference for EvaluateCode Operation</seealso>
        public virtual Task<EvaluateCodeResponse> EvaluateCodeAsync(EvaluateCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EvaluateCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateCodeResponseUnmarshaller.Instance;

            return InvokeAsync<EvaluateCodeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EvaluateMappingTemplate

        internal virtual EvaluateMappingTemplateResponse EvaluateMappingTemplate(EvaluateMappingTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EvaluateMappingTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateMappingTemplateResponseUnmarshaller.Instance;

            return Invoke<EvaluateMappingTemplateResponse>(request, options);
        }



        /// <summary>
        /// Evaluates a given template and returns the response. The mapping template can be a
        /// request or response template.
        /// 
        ///  
        /// <para>
        /// Request templates take the incoming request after a GraphQL operation is parsed and
        /// convert it into a request configuration for the selected data source operation. Response
        /// templates interpret responses from the data source and map it to the shape of the
        /// GraphQL field output type.
        /// </para>
        ///  
        /// <para>
        /// Mapping templates are written in the Apache Velocity Template Language (VTL).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvaluateMappingTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EvaluateMappingTemplate service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/EvaluateMappingTemplate">REST API Reference for EvaluateMappingTemplate Operation</seealso>
        public virtual Task<EvaluateMappingTemplateResponse> EvaluateMappingTemplateAsync(EvaluateMappingTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EvaluateMappingTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateMappingTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<EvaluateMappingTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  FlushApiCache

        internal virtual FlushApiCacheResponse FlushApiCache(FlushApiCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlushApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlushApiCacheResponseUnmarshaller.Instance;

            return Invoke<FlushApiCacheResponse>(request, options);
        }



        /// <summary>
        /// Flushes an <c>ApiCache</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlushApiCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FlushApiCache service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/FlushApiCache">REST API Reference for FlushApiCache Operation</seealso>
        public virtual Task<FlushApiCacheResponse> FlushApiCacheAsync(FlushApiCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlushApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlushApiCacheResponseUnmarshaller.Instance;

            return InvokeAsync<FlushApiCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetApi

        internal virtual GetApiResponse GetApi(GetApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiResponseUnmarshaller.Instance;

            return Invoke<GetApiResponse>(request, options);
        }



        /// <summary>
        /// Retrieves an <c>Api</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetApi">REST API Reference for GetApi Operation</seealso>
        public virtual Task<GetApiResponse> GetApiAsync(GetApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiResponseUnmarshaller.Instance;

            return InvokeAsync<GetApiResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetApiAssociation

        internal virtual GetApiAssociationResponse GetApiAssociation(GetApiAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiAssociationResponseUnmarshaller.Instance;

            return Invoke<GetApiAssociationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves an <c>ApiAssociation</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApiAssociation service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetApiAssociation">REST API Reference for GetApiAssociation Operation</seealso>
        public virtual Task<GetApiAssociationResponse> GetApiAssociationAsync(GetApiAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetApiAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetApiCache

        internal virtual GetApiCacheResponse GetApiCache(GetApiCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiCacheResponseUnmarshaller.Instance;

            return Invoke<GetApiCacheResponse>(request, options);
        }



        /// <summary>
        /// Retrieves an <c>ApiCache</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApiCache service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetApiCache">REST API Reference for GetApiCache Operation</seealso>
        public virtual Task<GetApiCacheResponse> GetApiCacheAsync(GetApiCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiCacheResponseUnmarshaller.Instance;

            return InvokeAsync<GetApiCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetChannelNamespace

        internal virtual GetChannelNamespaceResponse GetChannelNamespace(GetChannelNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelNamespaceResponseUnmarshaller.Instance;

            return Invoke<GetChannelNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the channel namespace for a specified <c>Api</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChannelNamespace service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetChannelNamespace">REST API Reference for GetChannelNamespace Operation</seealso>
        public virtual Task<GetChannelNamespaceResponse> GetChannelNamespaceAsync(GetChannelNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<GetChannelNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDataSource

        internal virtual GetDataSourceResponse GetDataSource(GetDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a <c>DataSource</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual Task<GetDataSourceResponse> GetDataSourceAsync(GetDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDataSourceIntrospection

        internal virtual GetDataSourceIntrospectionResponse GetDataSourceIntrospection(GetDataSourceIntrospectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceIntrospectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceIntrospectionResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceIntrospectionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the record of an existing introspection. If the retrieval is successful,
        /// the result of the instrospection will also be returned. If the retrieval fails the
        /// operation, an error message will be returned instead.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSourceIntrospection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSourceIntrospection service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetDataSourceIntrospection">REST API Reference for GetDataSourceIntrospection Operation</seealso>
        public virtual Task<GetDataSourceIntrospectionResponse> GetDataSourceIntrospectionAsync(GetDataSourceIntrospectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceIntrospectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceIntrospectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataSourceIntrospectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDomainName

        internal virtual GetDomainNameResponse GetDomainName(GetDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return Invoke<GetDomainNameResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a custom <c>DomainName</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainName service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        public virtual Task<GetDomainNameResponse> GetDomainNameAsync(GetDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainNameResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFunction

        internal virtual GetFunctionResponse GetFunction(GetFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return Invoke<GetFunctionResponse>(request, options);
        }



        /// <summary>
        /// Get a <c>Function</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFunction service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual Task<GetFunctionResponse> GetFunctionAsync(GetFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFunctionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetGraphqlApi

        internal virtual GetGraphqlApiResponse GetGraphqlApi(GetGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<GetGraphqlApiResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a <c>GraphqlApi</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraphqlApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetGraphqlApi">REST API Reference for GetGraphqlApi Operation</seealso>
        public virtual Task<GetGraphqlApiResponse> GetGraphqlApiAsync(GetGraphqlApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<GetGraphqlApiResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetGraphqlApiEnvironmentVariables

        internal virtual GetGraphqlApiEnvironmentVariablesResponse GetGraphqlApiEnvironmentVariables(GetGraphqlApiEnvironmentVariablesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphqlApiEnvironmentVariablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphqlApiEnvironmentVariablesResponseUnmarshaller.Instance;

            return Invoke<GetGraphqlApiEnvironmentVariablesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the list of environmental variable key-value pairs associated with an API
        /// by its ID value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraphqlApiEnvironmentVariables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGraphqlApiEnvironmentVariables service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetGraphqlApiEnvironmentVariables">REST API Reference for GetGraphqlApiEnvironmentVariables Operation</seealso>
        public virtual Task<GetGraphqlApiEnvironmentVariablesResponse> GetGraphqlApiEnvironmentVariablesAsync(GetGraphqlApiEnvironmentVariablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphqlApiEnvironmentVariablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphqlApiEnvironmentVariablesResponseUnmarshaller.Instance;

            return InvokeAsync<GetGraphqlApiEnvironmentVariablesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIntrospectionSchema

        internal virtual GetIntrospectionSchemaResponse GetIntrospectionSchema(GetIntrospectionSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntrospectionSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntrospectionSchemaResponseUnmarshaller.Instance;

            return Invoke<GetIntrospectionSchemaResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the introspection schema for a GraphQL API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntrospectionSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIntrospectionSchema service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.GraphQLSchemaException">
        /// The GraphQL schema is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetIntrospectionSchema">REST API Reference for GetIntrospectionSchema Operation</seealso>
        public virtual Task<GetIntrospectionSchemaResponse> GetIntrospectionSchemaAsync(GetIntrospectionSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntrospectionSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntrospectionSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntrospectionSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResolver

        internal virtual GetResolverResponse GetResolver(GetResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverResponseUnmarshaller.Instance;

            return Invoke<GetResolverResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a <c>Resolver</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolver service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResolver service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetResolver">REST API Reference for GetResolver Operation</seealso>
        public virtual Task<GetResolverResponse> GetResolverAsync(GetResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverResponseUnmarshaller.Instance;

            return InvokeAsync<GetResolverResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSchemaCreationStatus

        internal virtual GetSchemaCreationStatusResponse GetSchemaCreationStatus(GetSchemaCreationStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaCreationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaCreationStatusResponseUnmarshaller.Instance;

            return Invoke<GetSchemaCreationStatusResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current status of a schema creation operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaCreationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchemaCreationStatus service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetSchemaCreationStatus">REST API Reference for GetSchemaCreationStatus Operation</seealso>
        public virtual Task<GetSchemaCreationStatusResponse> GetSchemaCreationStatusAsync(GetSchemaCreationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSchemaCreationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaCreationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetSchemaCreationStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSourceApiAssociation

        internal virtual GetSourceApiAssociationResponse GetSourceApiAssociation(GetSourceApiAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSourceApiAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSourceApiAssociationResponseUnmarshaller.Instance;

            return Invoke<GetSourceApiAssociationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a <c>SourceApiAssociation</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSourceApiAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSourceApiAssociation service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetSourceApiAssociation">REST API Reference for GetSourceApiAssociation Operation</seealso>
        public virtual Task<GetSourceApiAssociationResponse> GetSourceApiAssociationAsync(GetSourceApiAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSourceApiAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSourceApiAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetSourceApiAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetType

        internal virtual GetTypeResponse GetType(GetTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTypeResponseUnmarshaller.Instance;

            return Invoke<GetTypeResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a <c>Type</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetType service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/GetType">REST API Reference for GetType Operation</seealso>
        public virtual Task<GetTypeResponse> GetTypeAsync(GetTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTypeResponseUnmarshaller.Instance;

            return InvokeAsync<GetTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListApiKeys

        internal virtual ListApiKeysResponse ListApiKeys(ListApiKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApiKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApiKeysResponseUnmarshaller.Instance;

            return Invoke<ListApiKeysResponse>(request, options);
        }



        /// <summary>
        /// Lists the API keys for a given API.
        /// 
        ///  <note> 
        /// <para>
        /// API keys are deleted automatically 60 days after they expire. However, they may still
        /// be included in the response until they have actually been deleted. You can safely
        /// call <c>DeleteApiKey</c> to manually delete a key before it's automatically deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApiKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApiKeys service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListApiKeys">REST API Reference for ListApiKeys Operation</seealso>
        public virtual Task<ListApiKeysResponse> ListApiKeysAsync(ListApiKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApiKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApiKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListApiKeysResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListApis

        internal virtual ListApisResponse ListApis(ListApisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApisResponseUnmarshaller.Instance;

            return Invoke<ListApisResponse>(request, options);
        }



        /// <summary>
        /// Lists the APIs in your AppSync account.
        /// 
        ///  
        /// <para>
        ///  <c>ListApis</c> returns only the high level API details. For more detailed information
        /// about an API, use <c>GetApi</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApis service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListApis">REST API Reference for ListApis Operation</seealso>
        public virtual Task<ListApisResponse> ListApisAsync(ListApisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApisResponseUnmarshaller.Instance;

            return InvokeAsync<ListApisResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListChannelNamespaces

        internal virtual ListChannelNamespacesResponse ListChannelNamespaces(ListChannelNamespacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelNamespacesResponseUnmarshaller.Instance;

            return Invoke<ListChannelNamespacesResponse>(request, options);
        }



        /// <summary>
        /// Lists the channel namespaces for a specified <c>Api</c>.
        /// 
        ///  
        /// <para>
        ///  <c>ListChannelNamespaces</c> returns only high level details for the channel namespace.
        /// To retrieve code handlers, use <c>GetChannelNamespace</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelNamespaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelNamespaces service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListChannelNamespaces">REST API Reference for ListChannelNamespaces Operation</seealso>
        public virtual Task<ListChannelNamespacesResponse> ListChannelNamespacesAsync(ListChannelNamespacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelNamespacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelNamespacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDataSources

        internal virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists the data sources for a given API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataSourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDomainNames

        internal virtual ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return Invoke<ListDomainNamesResponse>(request, options);
        }



        /// <summary>
        /// Lists multiple custom domain names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        public virtual Task<ListDomainNamesResponse> ListDomainNamesAsync(ListDomainNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainNamesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFunctions

        internal virtual ListFunctionsResponse ListFunctions(ListFunctionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return Invoke<ListFunctionsResponse>(request, options);
        }



        /// <summary>
        /// List multiple functions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual Task<ListFunctionsResponse> ListFunctionsAsync(ListFunctionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFunctionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGraphqlApis

        internal virtual ListGraphqlApisResponse ListGraphqlApis(ListGraphqlApisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGraphqlApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphqlApisResponseUnmarshaller.Instance;

            return Invoke<ListGraphqlApisResponse>(request, options);
        }



        /// <summary>
        /// Lists your GraphQL APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGraphqlApis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGraphqlApis service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListGraphqlApis">REST API Reference for ListGraphqlApis Operation</seealso>
        public virtual Task<ListGraphqlApisResponse> ListGraphqlApisAsync(ListGraphqlApisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGraphqlApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphqlApisResponseUnmarshaller.Instance;

            return InvokeAsync<ListGraphqlApisResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResolvers

        internal virtual ListResolversResponse ListResolvers(ListResolversRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResolversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolversResponseUnmarshaller.Instance;

            return Invoke<ListResolversResponse>(request, options);
        }



        /// <summary>
        /// Lists the resolvers for a given API and type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolvers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResolvers service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListResolvers">REST API Reference for ListResolvers Operation</seealso>
        public virtual Task<ListResolversResponse> ListResolversAsync(ListResolversRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResolversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolversResponseUnmarshaller.Instance;

            return InvokeAsync<ListResolversResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResolversByFunction

        internal virtual ListResolversByFunctionResponse ListResolversByFunction(ListResolversByFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResolversByFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolversByFunctionResponseUnmarshaller.Instance;

            return Invoke<ListResolversByFunctionResponse>(request, options);
        }



        /// <summary>
        /// List the resolvers that are associated with a specific function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolversByFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResolversByFunction service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListResolversByFunction">REST API Reference for ListResolversByFunction Operation</seealso>
        public virtual Task<ListResolversByFunctionResponse> ListResolversByFunctionAsync(ListResolversByFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResolversByFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolversByFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<ListResolversByFunctionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSourceApiAssociations

        internal virtual ListSourceApiAssociationsResponse ListSourceApiAssociations(ListSourceApiAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSourceApiAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceApiAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListSourceApiAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the <c>SourceApiAssociationSummary</c> data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceApiAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSourceApiAssociations service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListSourceApiAssociations">REST API Reference for ListSourceApiAssociations Operation</seealso>
        public virtual Task<ListSourceApiAssociationsResponse> ListSourceApiAssociationsAsync(ListSourceApiAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSourceApiAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceApiAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSourceApiAssociationsResponse>(request, options, cancellationToken);
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
        /// Lists the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTypes

        internal virtual ListTypesResponse ListTypes(ListTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesResponseUnmarshaller.Instance;

            return Invoke<ListTypesResponse>(request, options);
        }



        /// <summary>
        /// Lists the types for a given API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTypes service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListTypes">REST API Reference for ListTypes Operation</seealso>
        public virtual Task<ListTypesResponse> ListTypesAsync(ListTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTypesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTypesByAssociation

        internal virtual ListTypesByAssociationResponse ListTypesByAssociation(ListTypesByAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypesByAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesByAssociationResponseUnmarshaller.Instance;

            return Invoke<ListTypesByAssociationResponse>(request, options);
        }



        /// <summary>
        /// Lists <c>Type</c> objects by the source API association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypesByAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTypesByAssociation service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/ListTypesByAssociation">REST API Reference for ListTypesByAssociation Operation</seealso>
        public virtual Task<ListTypesByAssociationResponse> ListTypesByAssociationAsync(ListTypesByAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypesByAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesByAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<ListTypesByAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutGraphqlApiEnvironmentVariables

        internal virtual PutGraphqlApiEnvironmentVariablesResponse PutGraphqlApiEnvironmentVariables(PutGraphqlApiEnvironmentVariablesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutGraphqlApiEnvironmentVariablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGraphqlApiEnvironmentVariablesResponseUnmarshaller.Instance;

            return Invoke<PutGraphqlApiEnvironmentVariablesResponse>(request, options);
        }



        /// <summary>
        /// Creates a list of environmental variables in an API by its ID value. 
        /// 
        ///  
        /// <para>
        /// When creating an environmental variable, it must follow the constraints below:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Both JavaScript and VTL templates support environmental variables.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Environmental variables are not evaluated before function invocation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Environmental variables only support string values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any defined value in an environmental variable is considered a string literal and
        /// not expanded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Variable evaluations should ideally be performed in the function code.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When creating an environmental variable key-value pair, it must follow the additional
        /// constraints below:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Keys must begin with a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys must be at least two characters long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys can only contain letters, numbers, and the underscore character (_).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Values can be up to 512 characters long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can configure up to 50 key-value pairs in a GraphQL API.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can create a list of environmental variables by adding it to the <c>environmentVariables</c>
        /// payload as a list in the format <c>{"key1":"value1","key2":"value2", …}</c>. Note
        /// that each call of the <c>PutGraphqlApiEnvironmentVariables</c> action will result
        /// in the overwriting of the existing environmental variable list of that API. This means
        /// the existing environmental variables will be lost. To avoid this, you must include
        /// all existing and new environmental variables in the list each time you call this action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGraphqlApiEnvironmentVariables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutGraphqlApiEnvironmentVariables service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/PutGraphqlApiEnvironmentVariables">REST API Reference for PutGraphqlApiEnvironmentVariables Operation</seealso>
        public virtual Task<PutGraphqlApiEnvironmentVariablesResponse> PutGraphqlApiEnvironmentVariablesAsync(PutGraphqlApiEnvironmentVariablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutGraphqlApiEnvironmentVariablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGraphqlApiEnvironmentVariablesResponseUnmarshaller.Instance;

            return InvokeAsync<PutGraphqlApiEnvironmentVariablesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartDataSourceIntrospection

        internal virtual StartDataSourceIntrospectionResponse StartDataSourceIntrospection(StartDataSourceIntrospectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDataSourceIntrospectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceIntrospectionResponseUnmarshaller.Instance;

            return Invoke<StartDataSourceIntrospectionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new introspection. Returns the <c>introspectionId</c> of the new introspection
        /// after its creation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceIntrospection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDataSourceIntrospection service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/StartDataSourceIntrospection">REST API Reference for StartDataSourceIntrospection Operation</seealso>
        public virtual Task<StartDataSourceIntrospectionResponse> StartDataSourceIntrospectionAsync(StartDataSourceIntrospectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDataSourceIntrospectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceIntrospectionResponseUnmarshaller.Instance;

            return InvokeAsync<StartDataSourceIntrospectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartSchemaCreation

        internal virtual StartSchemaCreationResponse StartSchemaCreation(StartSchemaCreationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSchemaCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaCreationResponseUnmarshaller.Instance;

            return Invoke<StartSchemaCreationResponse>(request, options);
        }



        /// <summary>
        /// Adds a new schema to your GraphQL API.
        /// 
        ///  
        /// <para>
        /// This operation is asynchronous. Use to determine when it has completed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSchemaCreation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSchemaCreation service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/StartSchemaCreation">REST API Reference for StartSchemaCreation Operation</seealso>
        public virtual Task<StartSchemaCreationResponse> StartSchemaCreationAsync(StartSchemaCreationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSchemaCreationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaCreationResponseUnmarshaller.Instance;

            return InvokeAsync<StartSchemaCreationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartSchemaMerge

        internal virtual StartSchemaMergeResponse StartSchemaMerge(StartSchemaMergeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSchemaMergeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaMergeResponseUnmarshaller.Instance;

            return Invoke<StartSchemaMergeResponse>(request, options);
        }



        /// <summary>
        /// Initiates a merge operation. Returns a status that shows the result of the merge operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSchemaMerge service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSchemaMerge service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/StartSchemaMerge">REST API Reference for StartSchemaMerge Operation</seealso>
        public virtual Task<StartSchemaMergeResponse> StartSchemaMergeAsync(StartSchemaMergeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSchemaMergeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaMergeResponseUnmarshaller.Instance;

            return InvokeAsync<StartSchemaMergeResponse>(request, options, cancellationToken);
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
        /// Tags a resource with user-supplied tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Untags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateApi

        internal virtual UpdateApiResponse UpdateApi(UpdateApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiResponseUnmarshaller.Instance;

            return Invoke<UpdateApiResponse>(request, options);
        }



        /// <summary>
        /// Updates an <c>Api</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateApi">REST API Reference for UpdateApi Operation</seealso>
        public virtual Task<UpdateApiResponse> UpdateApiAsync(UpdateApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApiResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateApiCache

        internal virtual UpdateApiCacheResponse UpdateApiCache(UpdateApiCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiCacheResponseUnmarshaller.Instance;

            return Invoke<UpdateApiCacheResponse>(request, options);
        }



        /// <summary>
        /// Updates the cache for the GraphQL API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApiCache service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateApiCache">REST API Reference for UpdateApiCache Operation</seealso>
        public virtual Task<UpdateApiCacheResponse> UpdateApiCacheAsync(UpdateApiCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiCacheResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApiCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateApiKey

        internal virtual UpdateApiKeyResponse UpdateApiKey(UpdateApiKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateApiKeyResponse>(request, options);
        }



        /// <summary>
        /// Updates an API key. You can update the key as long as it's not deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApiKey service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.ApiKeyValidityOutOfBoundsException">
        /// The API key expiration must be set to a value between 1 and 365 days from creation
        /// (for <c>CreateApiKey</c>) or from update (for <c>UpdateApiKey</c>).
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.LimitExceededException">
        /// The request exceeded a limit. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateApiKey">REST API Reference for UpdateApiKey Operation</seealso>
        public virtual Task<UpdateApiKeyResponse> UpdateApiKeyAsync(UpdateApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApiKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateChannelNamespace

        internal virtual UpdateChannelNamespaceResponse UpdateChannelNamespace(UpdateChannelNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelNamespaceResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Updates a <c>ChannelNamespace</c> associated with an <c>Api</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannelNamespace service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateChannelNamespace">REST API Reference for UpdateChannelNamespace Operation</seealso>
        public virtual Task<UpdateChannelNamespaceResponse> UpdateChannelNamespaceAsync(UpdateChannelNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChannelNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDataSource

        internal virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Updates a <c>DataSource</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDomainName

        internal virtual UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainNameResponse>(request, options);
        }



        /// <summary>
        /// Updates a custom <c>DomainName</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainName service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        public virtual Task<UpdateDomainNameResponse> UpdateDomainNameAsync(UpdateDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainNameResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFunction

        internal virtual UpdateFunctionResponse UpdateFunction(UpdateFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionResponseUnmarshaller.Instance;

            return Invoke<UpdateFunctionResponse>(request, options);
        }



        /// <summary>
        /// Updates a <c>Function</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFunction service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateFunction">REST API Reference for UpdateFunction Operation</seealso>
        public virtual Task<UpdateFunctionResponse> UpdateFunctionAsync(UpdateFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFunctionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGraphqlApi

        internal virtual UpdateGraphqlApiResponse UpdateGraphqlApi(UpdateGraphqlApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGraphqlApiResponseUnmarshaller.Instance;

            return Invoke<UpdateGraphqlApiResponse>(request, options);
        }



        /// <summary>
        /// Updates a <c>GraphqlApi</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGraphqlApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGraphqlApi service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.AccessDeniedException">
        /// You don't have access to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateGraphqlApi">REST API Reference for UpdateGraphqlApi Operation</seealso>
        public virtual Task<UpdateGraphqlApiResponse> UpdateGraphqlApiAsync(UpdateGraphqlApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGraphqlApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGraphqlApiResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGraphqlApiResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateResolver

        internal virtual UpdateResolverResponse UpdateResolver(UpdateResolverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverResponseUnmarshaller.Instance;

            return Invoke<UpdateResolverResponse>(request, options);
        }



        /// <summary>
        /// Updates a <c>Resolver</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolver service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResolver service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateResolver">REST API Reference for UpdateResolver Operation</seealso>
        public virtual Task<UpdateResolverResponse> UpdateResolverAsync(UpdateResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResolverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResolverResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSourceApiAssociation

        internal virtual UpdateSourceApiAssociationResponse UpdateSourceApiAssociation(UpdateSourceApiAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSourceApiAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSourceApiAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateSourceApiAssociationResponse>(request, options);
        }



        /// <summary>
        /// Updates some of the configuration choices of a particular source API association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceApiAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSourceApiAssociation service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateSourceApiAssociation">REST API Reference for UpdateSourceApiAssociation Operation</seealso>
        public virtual Task<UpdateSourceApiAssociationResponse> UpdateSourceApiAssociationAsync(UpdateSourceApiAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSourceApiAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSourceApiAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSourceApiAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateType

        internal virtual UpdateTypeResponse UpdateType(UpdateTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateTypeResponse>(request, options);
        }



        /// <summary>
        /// Updates a <c>Type</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateType service method, as returned by AppSync.</returns>
        /// <exception cref="Amazon.AppSync.Model.BadRequestException">
        /// The request is not well formed. For example, a value is invalid or a required field
        /// is missing. Check the field values, and then try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.ConcurrentModificationException">
        /// Another modification is in progress at this time and it must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.InternalFailureException">
        /// An internal AppSync error occurred. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.NotFoundException">
        /// The resource specified in the request was not found. Check the resource, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.AppSync.Model.UnauthorizedException">
        /// You aren't authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appsync-2017-07-25/UpdateType">REST API Reference for UpdateType Operation</seealso>
        public virtual Task<UpdateTypeResponse> UpdateTypeAsync(UpdateTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTypeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTypeResponse>(request, options, cancellationToken);
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