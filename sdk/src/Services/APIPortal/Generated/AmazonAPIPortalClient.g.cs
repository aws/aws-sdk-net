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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using Amazon.APIPortal.Model;
using Amazon.APIPortal.Model.Internal.MarshallTransformations;
using Amazon.APIPortal.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.APIPortal
{
    /// <summary>
    /// <para>Implementation for accessing APIPortal</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// API Portal discovers the APIs running in your AWS accounts and organization, lets
    /// you manage them as Managed APIs, and publishes their documentation to developer portals.
    /// </summary>
    public partial class AmazonAPIPortalClient : AmazonServiceClient, IAmazonAPIPortal
    {
        private static IServiceMetadata serviceMetadata = new AmazonAPIPortalMetadata();
        private IAPIPortalPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAPIPortalPaginatorFactory Paginators
        {
            get
            {
                if (this._paginators == null)
                {
                    this._paginators = new APIPortalPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        /// <summary>
        /// Constructs AmazonAPIPortalClient with the credentials loaded from the application's
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
        public AmazonAPIPortalClient() : base(new AmazonAPIPortalConfig()) { }

        /// <summary>
        /// Constructs AmazonAPIPortalClient with the credentials loaded from the application's
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
        public AmazonAPIPortalClient(RegionEndpoint region) : base(new AmazonAPIPortalConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonAPIPortalClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAPIPortalClient Configuration Object</param>
        public AmazonAPIPortalClient(AmazonAPIPortalConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonAPIPortalClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAPIPortalClient(AWSCredentials credentials)
            : this(credentials, new AmazonAPIPortalConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAPIPortalClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAPIPortalClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAPIPortalConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonAPIPortalClient with AWS Credentials and an
        /// AmazonAPIPortalClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAPIPortalClient Configuration Object</param>
        public AmazonAPIPortalClient(AWSCredentials credentials, AmazonAPIPortalConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAPIPortalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAPIPortalClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAPIPortalConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAPIPortalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAPIPortalClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAPIPortalConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonAPIPortalClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAPIPortalClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAPIPortalClient Configuration Object</param>
        public AmazonAPIPortalClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAPIPortalConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAPIPortalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAPIPortalClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAPIPortalConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAPIPortalClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAPIPortalClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAPIPortalConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonAPIPortalClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAPIPortalClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAPIPortalClient Configuration Object</param>
        public AmazonAPIPortalClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAPIPortalConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAPIPortalEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAPIPortalAuthSchemeHandler());
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

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Associate one or more Managed APIs with a product. Best-effort — IDs that fail are
        /// returned in {@link AssociateManagedApisResponse#failedItems}; IDs that succeed are
        /// omitted. Associating an already-associated Managed API is a no-op (not reported as
        /// failure).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateManagedApis service method.</param>
        /// <returns>The response from the AssociateManagedApis service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/AssociateManagedApis">REST API Reference for AssociateManagedApis Operation</seealso>
        public virtual AssociateManagedApisResponse AssociateManagedApis(AssociateManagedApisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateManagedApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateManagedApisResponseUnmarshaller.Instance;

            return Invoke<AssociateManagedApisResponse>(request, options);
        }
#else
        internal virtual AssociateManagedApisResponse AssociateManagedApis(AssociateManagedApisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateManagedApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateManagedApisResponseUnmarshaller.Instance;

            return Invoke<AssociateManagedApisResponse>(request, options);
        }
#endif

        /// <summary>
        /// Associate one or more Managed APIs with a product. Best-effort — IDs that fail are
        /// returned in {@link AssociateManagedApisResponse#failedItems}; IDs that succeed are
        /// omitted. Associating an already-associated Managed API is a no-op (not reported as
        /// failure).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateManagedApis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateManagedApis service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/AssociateManagedApis">REST API Reference for AssociateManagedApis Operation</seealso>
        public virtual Task<AssociateManagedApisResponse> AssociateManagedApisAsync(AssociateManagedApisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateManagedApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateManagedApisResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateManagedApisResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Promote a discovered API in the API inventory into the managed API list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateManagedApi service method.</param>
        /// <returns>The response from the CreateManagedApi service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateManagedApi">REST API Reference for CreateManagedApi Operation</seealso>
        public virtual CreateManagedApiResponse CreateManagedApi(CreateManagedApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateManagedApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateManagedApiResponseUnmarshaller.Instance;

            return Invoke<CreateManagedApiResponse>(request, options);
        }
#else
        internal virtual CreateManagedApiResponse CreateManagedApi(CreateManagedApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateManagedApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateManagedApiResponseUnmarshaller.Instance;

            return Invoke<CreateManagedApiResponse>(request, options);
        }
#endif

        /// <summary>
        /// Promote a discovered API in the API inventory into the managed API list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateManagedApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateManagedApi service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateManagedApi">REST API Reference for CreateManagedApi Operation</seealso>
        public virtual Task<CreateManagedApiResponse> CreateManagedApiAsync(CreateManagedApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateManagedApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateManagedApiResponseUnmarshaller.Instance;

            return InvokeAsync<CreateManagedApiResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a portal that publishes documentation for the products it includes. Use UpdatePortalPublishStatus
        /// to publish it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal service method.</param>
        /// <returns>The response from the CreatePortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        public virtual CreatePortalResponse CreatePortal(CreatePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalResponseUnmarshaller.Instance;

            return Invoke<CreatePortalResponse>(request, options);
        }
#else
        internal virtual CreatePortalResponse CreatePortal(CreatePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalResponseUnmarshaller.Instance;

            return Invoke<CreatePortalResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a portal that publishes documentation for the products it includes. Use UpdatePortalPublishStatus
        /// to publish it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreatePortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        public virtual Task<CreatePortalResponse> CreatePortalAsync(CreatePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePortalResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Starts building a preview of the portal's current content. Use GetPortal to check
        /// the preview status and get the preview URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortalPreview service method.</param>
        /// <returns>The response from the CreatePortalPreview service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreatePortalPreview">REST API Reference for CreatePortalPreview Operation</seealso>
        public virtual CreatePortalPreviewResponse CreatePortalPreview(CreatePortalPreviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalPreviewResponseUnmarshaller.Instance;

            return Invoke<CreatePortalPreviewResponse>(request, options);
        }
#else
        internal virtual CreatePortalPreviewResponse CreatePortalPreview(CreatePortalPreviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalPreviewResponseUnmarshaller.Instance;

            return Invoke<CreatePortalPreviewResponse>(request, options);
        }
#endif

        /// <summary>
        /// Starts building a preview of the portal's current content. Use GetPortal to check
        /// the preview status and get the preview URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortalPreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreatePortalPreview service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreatePortalPreview">REST API Reference for CreatePortalPreview Operation</seealso>
        public virtual Task<CreatePortalPreviewResponse> CreatePortalPreviewAsync(CreatePortalPreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalPreviewResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePortalPreviewResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a product. A product groups Managed APIs with their API pages and product
        /// pages so a portal can publish them together.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProduct service method.</param>
        /// <returns>The response from the CreateProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
        public virtual CreateProductResponse CreateProduct(CreateProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductResponseUnmarshaller.Instance;

            return Invoke<CreateProductResponse>(request, options);
        }
#else
        internal virtual CreateProductResponse CreateProduct(CreateProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductResponseUnmarshaller.Instance;

            return Invoke<CreateProductResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a product. A product groups Managed APIs with their API pages and product
        /// pages so a portal can publish them together.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
        public virtual Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProductResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates an API page that documents a Managed API in a product. The page content is
        /// generated asynchronously. Use `status` to track it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProductApiPage service method.</param>
        /// <returns>The response from the CreateProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateProductApiPage">REST API Reference for CreateProductApiPage Operation</seealso>
        public virtual CreateProductApiPageResponse CreateProductApiPage(CreateProductApiPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProductApiPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductApiPageResponseUnmarshaller.Instance;

            return Invoke<CreateProductApiPageResponse>(request, options);
        }
#else
        internal virtual CreateProductApiPageResponse CreateProductApiPage(CreateProductApiPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProductApiPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductApiPageResponseUnmarshaller.Instance;

            return Invoke<CreateProductApiPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates an API page that documents a Managed API in a product. The page content is
        /// generated asynchronously. Use `status` to track it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProductApiPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateProductApiPage">REST API Reference for CreateProductApiPage Operation</seealso>
        public virtual Task<CreateProductApiPageResponse> CreateProductApiPageAsync(CreateProductApiPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProductApiPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductApiPageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProductApiPageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a product page with free-form documentation. A product can have up to 40 pages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProductPage service method.</param>
        /// <returns>The response from the CreateProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateProductPage">REST API Reference for CreateProductPage Operation</seealso>
        public virtual CreateProductPageResponse CreateProductPage(CreateProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductPageResponseUnmarshaller.Instance;

            return Invoke<CreateProductPageResponse>(request, options);
        }
#else
        internal virtual CreateProductPageResponse CreateProductPage(CreateProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductPageResponseUnmarshaller.Instance;

            return Invoke<CreateProductPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a product page with free-form documentation. A product can have up to 40 pages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProductPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateProductPage">REST API Reference for CreateProductPage Operation</seealso>
        public virtual Task<CreateProductPageResponse> CreateProductPageAsync(CreateProductPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductPageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProductPageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the discovery configuration and stops any running discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDiscoveryConfiguration service method.</param>
        /// <returns>The response from the DeleteDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteDiscoveryConfiguration">REST API Reference for DeleteDiscoveryConfiguration Operation</seealso>
        public virtual DeleteDiscoveryConfigurationResponse DeleteDiscoveryConfiguration(DeleteDiscoveryConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDiscoveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteDiscoveryConfigurationResponse>(request, options);
        }
#else
        internal virtual DeleteDiscoveryConfigurationResponse DeleteDiscoveryConfiguration(DeleteDiscoveryConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDiscoveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteDiscoveryConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the discovery configuration and stops any running discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteDiscoveryConfiguration">REST API Reference for DeleteDiscoveryConfiguration Operation</seealso>
        public virtual Task<DeleteDiscoveryConfigurationResponse> DeleteDiscoveryConfigurationAsync(DeleteDiscoveryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDiscoveryConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDiscoveryConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a Managed API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteManagedApi service method.</param>
        /// <returns>The response from the DeleteManagedApi service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteManagedApi">REST API Reference for DeleteManagedApi Operation</seealso>
        public virtual DeleteManagedApiResponse DeleteManagedApi(DeleteManagedApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteManagedApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteManagedApiResponseUnmarshaller.Instance;

            return Invoke<DeleteManagedApiResponse>(request, options);
        }
#else
        internal virtual DeleteManagedApiResponse DeleteManagedApi(DeleteManagedApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteManagedApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteManagedApiResponseUnmarshaller.Instance;

            return Invoke<DeleteManagedApiResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a Managed API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteManagedApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteManagedApi service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteManagedApi">REST API Reference for DeleteManagedApi Operation</seealso>
        public virtual Task<DeleteManagedApiResponse> DeleteManagedApiAsync(DeleteManagedApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteManagedApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteManagedApiResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteManagedApiResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the organization-wide discovery configuration and stops any running discovery
        /// across the organization. Only the organization management account may call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganizationDiscoveryConfiguration service method.</param>
        /// <returns>The response from the DeleteOrganizationDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteOrganizationDiscoveryConfiguration">REST API Reference for DeleteOrganizationDiscoveryConfiguration Operation</seealso>
        public virtual DeleteOrganizationDiscoveryConfigurationResponse DeleteOrganizationDiscoveryConfiguration(DeleteOrganizationDiscoveryConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOrganizationDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOrganizationDiscoveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteOrganizationDiscoveryConfigurationResponse>(request, options);
        }
#else
        internal virtual DeleteOrganizationDiscoveryConfigurationResponse DeleteOrganizationDiscoveryConfiguration(DeleteOrganizationDiscoveryConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOrganizationDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOrganizationDiscoveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteOrganizationDiscoveryConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the organization-wide discovery configuration and stops any running discovery
        /// across the organization. Only the organization management account may call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganizationDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteOrganizationDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteOrganizationDiscoveryConfiguration">REST API Reference for DeleteOrganizationDiscoveryConfiguration Operation</seealso>
        public virtual Task<DeleteOrganizationDiscoveryConfigurationResponse> DeleteOrganizationDiscoveryConfigurationAsync(DeleteOrganizationDiscoveryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOrganizationDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOrganizationDiscoveryConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOrganizationDiscoveryConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// <returns>The response from the DeletePortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        public virtual DeletePortalResponse DeletePortal(DeletePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalResponseUnmarshaller.Instance;

            return Invoke<DeletePortalResponse>(request, options);
        }
#else
        internal virtual DeletePortalResponse DeletePortal(DeletePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalResponseUnmarshaller.Instance;

            return Invoke<DeletePortalResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeletePortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        public virtual Task<DeletePortalResponse> DeletePortalAsync(DeletePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePortalResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProduct service method.</param>
        /// <returns>The response from the DeleteProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProduct">REST API Reference for DeleteProduct Operation</seealso>
        public virtual DeleteProductResponse DeleteProduct(DeleteProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductResponseUnmarshaller.Instance;

            return Invoke<DeleteProductResponse>(request, options);
        }
#else
        internal virtual DeleteProductResponse DeleteProduct(DeleteProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductResponseUnmarshaller.Instance;

            return Invoke<DeleteProductResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProduct">REST API Reference for DeleteProduct Operation</seealso>
        public virtual Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProductResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an API page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductApiPage service method.</param>
        /// <returns>The response from the DeleteProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProductApiPage">REST API Reference for DeleteProductApiPage Operation</seealso>
        public virtual DeleteProductApiPageResponse DeleteProductApiPage(DeleteProductApiPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductApiPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductApiPageResponseUnmarshaller.Instance;

            return Invoke<DeleteProductApiPageResponse>(request, options);
        }
#else
        internal virtual DeleteProductApiPageResponse DeleteProductApiPage(DeleteProductApiPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductApiPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductApiPageResponseUnmarshaller.Instance;

            return Invoke<DeleteProductApiPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes an API page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductApiPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProductApiPage">REST API Reference for DeleteProductApiPage Operation</seealso>
        public virtual Task<DeleteProductApiPageResponse> DeleteProductApiPageAsync(DeleteProductApiPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductApiPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductApiPageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProductApiPageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a product page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductPage service method.</param>
        /// <returns>The response from the DeleteProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProductPage">REST API Reference for DeleteProductPage Operation</seealso>
        public virtual DeleteProductPageResponse DeleteProductPage(DeleteProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductPageResponseUnmarshaller.Instance;

            return Invoke<DeleteProductPageResponse>(request, options);
        }
#else
        internal virtual DeleteProductPageResponse DeleteProductPage(DeleteProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductPageResponseUnmarshaller.Instance;

            return Invoke<DeleteProductPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a product page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProductPage">REST API Reference for DeleteProductPage Operation</seealso>
        public virtual Task<DeleteProductPageResponse> DeleteProductPageAsync(DeleteProductPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductPageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProductPageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the sharing policy of a product. The product is no longer shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductSharingPolicy service method.</param>
        /// <returns>The response from the DeleteProductSharingPolicy service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProductSharingPolicy">REST API Reference for DeleteProductSharingPolicy Operation</seealso>
        public virtual DeleteProductSharingPolicyResponse DeleteProductSharingPolicy(DeleteProductSharingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductSharingPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteProductSharingPolicyResponse>(request, options);
        }
#else
        internal virtual DeleteProductSharingPolicyResponse DeleteProductSharingPolicy(DeleteProductSharingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductSharingPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteProductSharingPolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the sharing policy of a product. The product is no longer shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductSharingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProductSharingPolicy service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProductSharingPolicy">REST API Reference for DeleteProductSharingPolicy Operation</seealso>
        public virtual Task<DeleteProductSharingPolicyResponse> DeleteProductSharingPolicyAsync(DeleteProductSharingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductSharingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProductSharingPolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Disassociate one or more Managed APIs from a product. Best-effort — IDs that fail
        /// are returned in {@link DisassociateManagedApisResponse#failedItems}; IDs that succeed
        /// are omitted. Disassociating an unmapped Managed API is a no-op (not reported as failure).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateManagedApis service method.</param>
        /// <returns>The response from the DisassociateManagedApis service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DisassociateManagedApis">REST API Reference for DisassociateManagedApis Operation</seealso>
        public virtual DisassociateManagedApisResponse DisassociateManagedApis(DisassociateManagedApisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateManagedApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateManagedApisResponseUnmarshaller.Instance;

            return Invoke<DisassociateManagedApisResponse>(request, options);
        }
#else
        internal virtual DisassociateManagedApisResponse DisassociateManagedApis(DisassociateManagedApisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateManagedApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateManagedApisResponseUnmarshaller.Instance;

            return Invoke<DisassociateManagedApisResponse>(request, options);
        }
#endif

        /// <summary>
        /// Disassociate one or more Managed APIs from a product. Best-effort — IDs that fail
        /// are returned in {@link DisassociateManagedApisResponse#failedItems}; IDs that succeed
        /// are omitted. Disassociating an unmapped Managed API is a no-op (not reported as failure).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateManagedApis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateManagedApis service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DisassociateManagedApis">REST API Reference for DisassociateManagedApis Operation</seealso>
        public virtual Task<DisassociateManagedApisResponse> DisassociateManagedApisAsync(DisassociateManagedApisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateManagedApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateManagedApisResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateManagedApisResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets full details of a single API inventory item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiInventoryItem service method.</param>
        /// <returns>The response from the GetApiInventoryItem service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetApiInventoryItem">REST API Reference for GetApiInventoryItem Operation</seealso>
        public virtual GetApiInventoryItemResponse GetApiInventoryItem(GetApiInventoryItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiInventoryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiInventoryItemResponseUnmarshaller.Instance;

            return Invoke<GetApiInventoryItemResponse>(request, options);
        }
#else
        internal virtual GetApiInventoryItemResponse GetApiInventoryItem(GetApiInventoryItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiInventoryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiInventoryItemResponseUnmarshaller.Instance;

            return Invoke<GetApiInventoryItemResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets full details of a single API inventory item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiInventoryItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetApiInventoryItem service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetApiInventoryItem">REST API Reference for GetApiInventoryItem Operation</seealso>
        public virtual Task<GetApiInventoryItemResponse> GetApiInventoryItemAsync(GetApiInventoryItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiInventoryItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiInventoryItemResponseUnmarshaller.Instance;

            return InvokeAsync<GetApiInventoryItemResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the discovery configuration for the account and region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveryConfiguration service method.</param>
        /// <returns>The response from the GetDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetDiscoveryConfiguration">REST API Reference for GetDiscoveryConfiguration Operation</seealso>
        public virtual GetDiscoveryConfigurationResponse GetDiscoveryConfiguration(GetDiscoveryConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiscoveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetDiscoveryConfigurationResponse>(request, options);
        }
#else
        internal virtual GetDiscoveryConfigurationResponse GetDiscoveryConfiguration(GetDiscoveryConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiscoveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetDiscoveryConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the discovery configuration for the account and region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetDiscoveryConfiguration">REST API Reference for GetDiscoveryConfiguration Operation</seealso>
        public virtual Task<GetDiscoveryConfigurationResponse> GetDiscoveryConfigurationAsync(GetDiscoveryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiscoveryConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetDiscoveryConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a Managed API, including its security posture findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedApi service method.</param>
        /// <returns>The response from the GetManagedApi service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetManagedApi">REST API Reference for GetManagedApi Operation</seealso>
        public virtual GetManagedApiResponse GetManagedApi(GetManagedApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedApiResponseUnmarshaller.Instance;

            return Invoke<GetManagedApiResponse>(request, options);
        }
#else
        internal virtual GetManagedApiResponse GetManagedApi(GetManagedApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedApiResponseUnmarshaller.Instance;

            return Invoke<GetManagedApiResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a Managed API, including its security posture findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetManagedApi service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetManagedApi">REST API Reference for GetManagedApi Operation</seealso>
        public virtual Task<GetManagedApiResponse> GetManagedApiAsync(GetManagedApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedApiResponseUnmarshaller.Instance;

            return InvokeAsync<GetManagedApiResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the organization-wide discovery configuration. Only the organization management
        /// account and registered delegated administrators may call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationDiscoveryConfiguration service method.</param>
        /// <returns>The response from the GetOrganizationDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetOrganizationDiscoveryConfiguration">REST API Reference for GetOrganizationDiscoveryConfiguration Operation</seealso>
        public virtual GetOrganizationDiscoveryConfigurationResponse GetOrganizationDiscoveryConfiguration(GetOrganizationDiscoveryConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOrganizationDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrganizationDiscoveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetOrganizationDiscoveryConfigurationResponse>(request, options);
        }
#else
        internal virtual GetOrganizationDiscoveryConfigurationResponse GetOrganizationDiscoveryConfiguration(GetOrganizationDiscoveryConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOrganizationDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrganizationDiscoveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetOrganizationDiscoveryConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the organization-wide discovery configuration. Only the organization management
        /// account and registered delegated administrators may call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetOrganizationDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetOrganizationDiscoveryConfiguration">REST API Reference for GetOrganizationDiscoveryConfiguration Operation</seealso>
        public virtual Task<GetOrganizationDiscoveryConfigurationResponse> GetOrganizationDiscoveryConfigurationAsync(GetOrganizationDiscoveryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOrganizationDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrganizationDiscoveryConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetOrganizationDiscoveryConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns the configuration, publish status, and preview status of a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortal service method.</param>
        /// <returns>The response from the GetPortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetPortal">REST API Reference for GetPortal Operation</seealso>
        public virtual GetPortalResponse GetPortal(GetPortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalResponseUnmarshaller.Instance;

            return Invoke<GetPortalResponse>(request, options);
        }
#else
        internal virtual GetPortalResponse GetPortal(GetPortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalResponseUnmarshaller.Instance;

            return Invoke<GetPortalResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns the configuration, publish status, and preview status of a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetPortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetPortal">REST API Reference for GetPortal Operation</seealso>
        public virtual Task<GetPortalResponse> GetPortalAsync(GetPortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalResponseUnmarshaller.Instance;

            return InvokeAsync<GetPortalResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a product. To read a product shared with you by another account, supply `resourceOwnerAccountId`.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProduct service method.</param>
        /// <returns>The response from the GetProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProduct">REST API Reference for GetProduct Operation</seealso>
        public virtual GetProductResponse GetProduct(GetProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductResponseUnmarshaller.Instance;

            return Invoke<GetProductResponse>(request, options);
        }
#else
        internal virtual GetProductResponse GetProduct(GetProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductResponseUnmarshaller.Instance;

            return Invoke<GetProductResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a product. To read a product shared with you by another account, supply `resourceOwnerAccountId`.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProduct">REST API Reference for GetProduct Operation</seealso>
        public virtual Task<GetProductResponse> GetProductAsync(GetProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductResponseUnmarshaller.Instance;

            return InvokeAsync<GetProductResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns an API page, including its body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductApiPage service method.</param>
        /// <returns>The response from the GetProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProductApiPage">REST API Reference for GetProductApiPage Operation</seealso>
        public virtual GetProductApiPageResponse GetProductApiPage(GetProductApiPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductApiPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductApiPageResponseUnmarshaller.Instance;

            return Invoke<GetProductApiPageResponse>(request, options);
        }
#else
        internal virtual GetProductApiPageResponse GetProductApiPage(GetProductApiPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductApiPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductApiPageResponseUnmarshaller.Instance;

            return Invoke<GetProductApiPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns an API page, including its body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductApiPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProductApiPage">REST API Reference for GetProductApiPage Operation</seealso>
        public virtual Task<GetProductApiPageResponse> GetProductApiPageAsync(GetProductApiPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductApiPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductApiPageResponseUnmarshaller.Instance;

            return InvokeAsync<GetProductApiPageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns a product page, including its body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductPage service method.</param>
        /// <returns>The response from the GetProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProductPage">REST API Reference for GetProductPage Operation</seealso>
        public virtual GetProductPageResponse GetProductPage(GetProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductPageResponseUnmarshaller.Instance;

            return Invoke<GetProductPageResponse>(request, options);
        }
#else
        internal virtual GetProductPageResponse GetProductPage(GetProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductPageResponseUnmarshaller.Instance;

            return Invoke<GetProductPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns a product page, including its body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProductPage">REST API Reference for GetProductPage Operation</seealso>
        public virtual Task<GetProductPageResponse> GetProductPageAsync(GetProductPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductPageResponseUnmarshaller.Instance;

            return InvokeAsync<GetProductPageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns the sharing policy of a product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductSharingPolicy service method.</param>
        /// <returns>The response from the GetProductSharingPolicy service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProductSharingPolicy">REST API Reference for GetProductSharingPolicy Operation</seealso>
        public virtual GetProductSharingPolicyResponse GetProductSharingPolicy(GetProductSharingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductSharingPolicyResponseUnmarshaller.Instance;

            return Invoke<GetProductSharingPolicyResponse>(request, options);
        }
#else
        internal virtual GetProductSharingPolicyResponse GetProductSharingPolicy(GetProductSharingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductSharingPolicyResponseUnmarshaller.Instance;

            return Invoke<GetProductSharingPolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns the sharing policy of a product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductSharingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProductSharingPolicy service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProductSharingPolicy">REST API Reference for GetProductSharingPolicy Operation</seealso>
        public virtual Task<GetProductSharingPolicyResponse> GetProductSharingPolicyAsync(GetProductSharingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductSharingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetProductSharingPolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists discovered API inventory items with filtering and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApiInventoryItems service method.</param>
        /// <returns>The response from the ListApiInventoryItems service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListApiInventoryItems">REST API Reference for ListApiInventoryItems Operation</seealso>
        public virtual ListApiInventoryItemsResponse ListApiInventoryItems(ListApiInventoryItemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApiInventoryItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApiInventoryItemsResponseUnmarshaller.Instance;

            return Invoke<ListApiInventoryItemsResponse>(request, options);
        }
#else
        internal virtual ListApiInventoryItemsResponse ListApiInventoryItems(ListApiInventoryItemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApiInventoryItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApiInventoryItemsResponseUnmarshaller.Instance;

            return Invoke<ListApiInventoryItemsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists discovered API inventory items with filtering and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApiInventoryItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListApiInventoryItems service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListApiInventoryItems">REST API Reference for ListApiInventoryItems Operation</seealso>
        public virtual Task<ListApiInventoryItemsResponse> ListApiInventoryItemsAsync(ListApiInventoryItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApiInventoryItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApiInventoryItemsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApiInventoryItemsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists discovery statuses for services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveryStatuses service method.</param>
        /// <returns>The response from the ListDiscoveryStatuses service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListDiscoveryStatuses">REST API Reference for ListDiscoveryStatuses Operation</seealso>
        public virtual ListDiscoveryStatusesResponse ListDiscoveryStatuses(ListDiscoveryStatusesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDiscoveryStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveryStatusesResponseUnmarshaller.Instance;

            return Invoke<ListDiscoveryStatusesResponse>(request, options);
        }
#else
        internal virtual ListDiscoveryStatusesResponse ListDiscoveryStatuses(ListDiscoveryStatusesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDiscoveryStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveryStatusesResponseUnmarshaller.Instance;

            return Invoke<ListDiscoveryStatusesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists discovery statuses for services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveryStatuses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDiscoveryStatuses service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListDiscoveryStatuses">REST API Reference for ListDiscoveryStatuses Operation</seealso>
        public virtual Task<ListDiscoveryStatusesResponse> ListDiscoveryStatusesAsync(ListDiscoveryStatusesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDiscoveryStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveryStatusesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDiscoveryStatusesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists API-security events for a single managed API, most recent first. Returns up
        /// to 20 of the most recent events (not paginated).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedApiEvents service method.</param>
        /// <returns>The response from the ListManagedApiEvents service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListManagedApiEvents">REST API Reference for ListManagedApiEvents Operation</seealso>
        public virtual ListManagedApiEventsResponse ListManagedApiEvents(ListManagedApiEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedApiEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedApiEventsResponseUnmarshaller.Instance;

            return Invoke<ListManagedApiEventsResponse>(request, options);
        }
#else
        internal virtual ListManagedApiEventsResponse ListManagedApiEvents(ListManagedApiEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedApiEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedApiEventsResponseUnmarshaller.Instance;

            return Invoke<ListManagedApiEventsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists API-security events for a single managed API, most recent first. Returns up
        /// to 20 of the most recent events (not paginated).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedApiEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListManagedApiEvents service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListManagedApiEvents">REST API Reference for ListManagedApiEvents Operation</seealso>
        public virtual Task<ListManagedApiEventsResponse> ListManagedApiEventsAsync(ListManagedApiEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedApiEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedApiEventsResponseUnmarshaller.Instance;

            return InvokeAsync<ListManagedApiEventsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the Managed APIs in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedApis service method.</param>
        /// <returns>The response from the ListManagedApis service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListManagedApis">REST API Reference for ListManagedApis Operation</seealso>
        public virtual ListManagedApisResponse ListManagedApis(ListManagedApisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedApisResponseUnmarshaller.Instance;

            return Invoke<ListManagedApisResponse>(request, options);
        }
#else
        internal virtual ListManagedApisResponse ListManagedApis(ListManagedApisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedApisResponseUnmarshaller.Instance;

            return Invoke<ListManagedApisResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the Managed APIs in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedApis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListManagedApis service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListManagedApis">REST API Reference for ListManagedApis Operation</seealso>
        public virtual Task<ListManagedApisResponse> ListManagedApisAsync(ListManagedApisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedApisResponseUnmarshaller.Instance;

            return InvokeAsync<ListManagedApisResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the portals in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// <returns>The response from the ListPortals service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListPortals">REST API Reference for ListPortals Operation</seealso>
        public virtual ListPortalsResponse ListPortals(ListPortalsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPortalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalsResponseUnmarshaller.Instance;

            return Invoke<ListPortalsResponse>(request, options);
        }
#else
        internal virtual ListPortalsResponse ListPortals(ListPortalsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPortalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalsResponseUnmarshaller.Instance;

            return Invoke<ListPortalsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the portals in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListPortals service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListPortals">REST API Reference for ListPortals Operation</seealso>
        public virtual Task<ListPortalsResponse> ListPortalsAsync(ListPortalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPortalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPortalsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the API pages in a product. The results do not include page bodies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductApiPages service method.</param>
        /// <returns>The response from the ListProductApiPages service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListProductApiPages">REST API Reference for ListProductApiPages Operation</seealso>
        public virtual ListProductApiPagesResponse ListProductApiPages(ListProductApiPagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProductApiPagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductApiPagesResponseUnmarshaller.Instance;

            return Invoke<ListProductApiPagesResponse>(request, options);
        }
#else
        internal virtual ListProductApiPagesResponse ListProductApiPages(ListProductApiPagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProductApiPagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductApiPagesResponseUnmarshaller.Instance;

            return Invoke<ListProductApiPagesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the API pages in a product. The results do not include page bodies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductApiPages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProductApiPages service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListProductApiPages">REST API Reference for ListProductApiPages Operation</seealso>
        public virtual Task<ListProductApiPagesResponse> ListProductApiPagesAsync(ListProductApiPagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProductApiPagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductApiPagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProductApiPagesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the product pages in a product. The results do not include page bodies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductPages service method.</param>
        /// <returns>The response from the ListProductPages service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListProductPages">REST API Reference for ListProductPages Operation</seealso>
        public virtual ListProductPagesResponse ListProductPages(ListProductPagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProductPagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductPagesResponseUnmarshaller.Instance;

            return Invoke<ListProductPagesResponse>(request, options);
        }
#else
        internal virtual ListProductPagesResponse ListProductPages(ListProductPagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProductPagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductPagesResponseUnmarshaller.Instance;

            return Invoke<ListProductPagesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the product pages in a product. The results do not include page bodies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductPages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProductPages service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListProductPages">REST API Reference for ListProductPages Operation</seealso>
        public virtual Task<ListProductPagesResponse> ListProductPagesAsync(ListProductPagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProductPagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductPagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProductPagesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists products you own, products shared with you, or both.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProducts service method.</param>
        /// <returns>The response from the ListProducts service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListProducts">REST API Reference for ListProducts Operation</seealso>
        public virtual ListProductsResponse ListProducts(ListProductsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductsResponseUnmarshaller.Instance;

            return Invoke<ListProductsResponse>(request, options);
        }
#else
        internal virtual ListProductsResponse ListProducts(ListProductsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductsResponseUnmarshaller.Instance;

            return Invoke<ListProductsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists products you own, products shared with you, or both.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProducts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProducts service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListProducts">REST API Reference for ListProducts Operation</seealso>
        public virtual Task<ListProductsResponse> ListProductsAsync(ListProductsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProductsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the tags for an API Portal resource. One of the three basic tagging operations
        /// generated for Tagris integration (ListTagsForResource / TagResource / UntagResource).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }
#else
        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the tags for an API Portal resource. One of the three basic tagging operations
        /// generated for Tagris integration (ListTagsForResource / TagResource / UntagResource).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates or updates the discovery configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDiscoveryConfiguration service method.</param>
        /// <returns>The response from the PutDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/PutDiscoveryConfiguration">REST API Reference for PutDiscoveryConfiguration Operation</seealso>
        public virtual PutDiscoveryConfigurationResponse PutDiscoveryConfiguration(PutDiscoveryConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDiscoveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutDiscoveryConfigurationResponse>(request, options);
        }
#else
        internal virtual PutDiscoveryConfigurationResponse PutDiscoveryConfiguration(PutDiscoveryConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDiscoveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutDiscoveryConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates or updates the discovery configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/PutDiscoveryConfiguration">REST API Reference for PutDiscoveryConfiguration Operation</seealso>
        public virtual Task<PutDiscoveryConfigurationResponse> PutDiscoveryConfigurationAsync(PutDiscoveryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDiscoveryConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutDiscoveryConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates or updates the organization-wide discovery configuration. This is a singleton
        /// per organization. Only the organization management account and registered delegated
        /// administrators may call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOrganizationDiscoveryConfiguration service method.</param>
        /// <returns>The response from the PutOrganizationDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/PutOrganizationDiscoveryConfiguration">REST API Reference for PutOrganizationDiscoveryConfiguration Operation</seealso>
        public virtual PutOrganizationDiscoveryConfigurationResponse PutOrganizationDiscoveryConfiguration(PutOrganizationDiscoveryConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutOrganizationDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOrganizationDiscoveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutOrganizationDiscoveryConfigurationResponse>(request, options);
        }
#else
        internal virtual PutOrganizationDiscoveryConfigurationResponse PutOrganizationDiscoveryConfiguration(PutOrganizationDiscoveryConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutOrganizationDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOrganizationDiscoveryConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutOrganizationDiscoveryConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates or updates the organization-wide discovery configuration. This is a singleton
        /// per organization. Only the organization management account and registered delegated
        /// administrators may call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOrganizationDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutOrganizationDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/PutOrganizationDiscoveryConfiguration">REST API Reference for PutOrganizationDiscoveryConfiguration Operation</seealso>
        public virtual Task<PutOrganizationDiscoveryConfigurationResponse> PutOrganizationDiscoveryConfigurationAsync(PutOrganizationDiscoveryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutOrganizationDiscoveryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOrganizationDiscoveryConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutOrganizationDiscoveryConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates or replaces the sharing policy of a product. The policy controls which other
        /// accounts can read the product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProductSharingPolicy service method.</param>
        /// <returns>The response from the PutProductSharingPolicy service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/PutProductSharingPolicy">REST API Reference for PutProductSharingPolicy Operation</seealso>
        public virtual PutProductSharingPolicyResponse PutProductSharingPolicy(PutProductSharingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProductSharingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutProductSharingPolicyResponse>(request, options);
        }
#else
        internal virtual PutProductSharingPolicyResponse PutProductSharingPolicy(PutProductSharingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProductSharingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutProductSharingPolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates or replaces the sharing policy of a product. The policy controls which other
        /// accounts can read the product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProductSharingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutProductSharingPolicy service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/PutProductSharingPolicy">REST API Reference for PutProductSharingPolicy Operation</seealso>
        public virtual Task<PutProductSharingPolicyResponse> PutProductSharingPolicyAsync(PutProductSharingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProductSharingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutProductSharingPolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Starts the API discovery process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDiscovery service method.</param>
        /// <returns>The response from the StartDiscovery service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/StartDiscovery">REST API Reference for StartDiscovery Operation</seealso>
        public virtual StartDiscoveryResponse StartDiscovery(StartDiscoveryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDiscoveryResponseUnmarshaller.Instance;

            return Invoke<StartDiscoveryResponse>(request, options);
        }
#else
        internal virtual StartDiscoveryResponse StartDiscovery(StartDiscoveryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDiscoveryResponseUnmarshaller.Instance;

            return Invoke<StartDiscoveryResponse>(request, options);
        }
#endif

        /// <summary>
        /// Starts the API discovery process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDiscovery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartDiscovery service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/StartDiscovery">REST API Reference for StartDiscovery Operation</seealso>
        public virtual Task<StartDiscoveryResponse> StartDiscoveryAsync(StartDiscoveryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDiscoveryResponseUnmarshaller.Instance;

            return InvokeAsync<StartDiscoveryResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Stops the running API discovery process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDiscovery service method.</param>
        /// <returns>The response from the StopDiscovery service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/StopDiscovery">REST API Reference for StopDiscovery Operation</seealso>
        public virtual StopDiscoveryResponse StopDiscovery(StopDiscoveryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDiscoveryResponseUnmarshaller.Instance;

            return Invoke<StopDiscoveryResponse>(request, options);
        }
#else
        internal virtual StopDiscoveryResponse StopDiscovery(StopDiscoveryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDiscoveryResponseUnmarshaller.Instance;

            return Invoke<StopDiscoveryResponse>(request, options);
        }
#endif

        /// <summary>
        /// Stops the running API discovery process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDiscovery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StopDiscovery service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/StopDiscovery">REST API Reference for StopDiscovery Operation</seealso>
        public virtual Task<StopDiscoveryResponse> StopDiscoveryAsync(StopDiscoveryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDiscoveryResponseUnmarshaller.Instance;

            return InvokeAsync<StopDiscoveryResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Adds or updates tags on an API Portal resource. One of the three basic tagging operations
        /// generated for Tagris integration (ListTagsForResource / TagResource / UntagResource).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }
#else
        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Adds or updates tags on an API Portal resource. One of the three basic tagging operations
        /// generated for Tagris integration (ListTagsForResource / TagResource / UntagResource).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Removes tags from an API Portal resource. One of the three basic tagging operations
        /// generated for Tagris integration (ListTagsForResource / TagResource / UntagResource).
        /// tagKeys is a query string parameter: for tag-based access control (TBAC/ABAC) to work
        /// correctly, API Gateway requires the keys to be removed to be passed as a query string
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }
#else
        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Removes tags from an API Portal resource. One of the three basic tagging operations
        /// generated for Tagris integration (ListTagsForResource / TagResource / UntagResource).
        /// tagKeys is a query string parameter: for tag-based access control (TBAC/ABAC) to work
        /// correctly, API Gateway requires the keys to be removed to be passed as a query string
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates a portal. Only the fields supplied in the request are changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// <returns>The response from the UpdatePortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        public virtual UpdatePortalResponse UpdatePortal(UpdatePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalResponseUnmarshaller.Instance;

            return Invoke<UpdatePortalResponse>(request, options);
        }
#else
        internal virtual UpdatePortalResponse UpdatePortal(UpdatePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalResponseUnmarshaller.Instance;

            return Invoke<UpdatePortalResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates a portal. Only the fields supplied in the request are changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdatePortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        public virtual Task<UpdatePortalResponse> UpdatePortalAsync(UpdatePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePortalResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Publishes or disables a portal. The change runs asynchronously. Use GetPortal to track
        /// `publishStatus`.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortalPublishStatus service method.</param>
        /// <returns>The response from the UpdatePortalPublishStatus service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdatePortalPublishStatus">REST API Reference for UpdatePortalPublishStatus Operation</seealso>
        public virtual UpdatePortalPublishStatusResponse UpdatePortalPublishStatus(UpdatePortalPublishStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalPublishStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalPublishStatusResponseUnmarshaller.Instance;

            return Invoke<UpdatePortalPublishStatusResponse>(request, options);
        }
#else
        internal virtual UpdatePortalPublishStatusResponse UpdatePortalPublishStatus(UpdatePortalPublishStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalPublishStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalPublishStatusResponseUnmarshaller.Instance;

            return Invoke<UpdatePortalPublishStatusResponse>(request, options);
        }
#endif

        /// <summary>
        /// Publishes or disables a portal. The change runs asynchronously. Use GetPortal to track
        /// `publishStatus`.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortalPublishStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdatePortalPublishStatus service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdatePortalPublishStatus">REST API Reference for UpdatePortalPublishStatus Operation</seealso>
        public virtual Task<UpdatePortalPublishStatusResponse> UpdatePortalPublishStatusAsync(UpdatePortalPublishStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalPublishStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalPublishStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePortalPublishStatusResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates a product. Only the fields supplied in the request are changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProduct service method.</param>
        /// <returns>The response from the UpdateProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdateProduct">REST API Reference for UpdateProduct Operation</seealso>
        public virtual UpdateProductResponse UpdateProduct(UpdateProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductResponseUnmarshaller.Instance;

            return Invoke<UpdateProductResponse>(request, options);
        }
#else
        internal virtual UpdateProductResponse UpdateProduct(UpdateProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductResponseUnmarshaller.Instance;

            return Invoke<UpdateProductResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates a product. Only the fields supplied in the request are changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdateProduct">REST API Reference for UpdateProduct Operation</seealso>
        public virtual Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProductResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates an API page. Only the fields supplied in the request are changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductApiPage service method.</param>
        /// <returns>The response from the UpdateProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdateProductApiPage">REST API Reference for UpdateProductApiPage Operation</seealso>
        public virtual UpdateProductApiPageResponse UpdateProductApiPage(UpdateProductApiPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProductApiPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductApiPageResponseUnmarshaller.Instance;

            return Invoke<UpdateProductApiPageResponse>(request, options);
        }
#else
        internal virtual UpdateProductApiPageResponse UpdateProductApiPage(UpdateProductApiPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProductApiPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductApiPageResponseUnmarshaller.Instance;

            return Invoke<UpdateProductApiPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates an API page. Only the fields supplied in the request are changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductApiPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdateProductApiPage">REST API Reference for UpdateProductApiPage Operation</seealso>
        public virtual Task<UpdateProductApiPageResponse> UpdateProductApiPageAsync(UpdateProductApiPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProductApiPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductApiPageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProductApiPageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates a product page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductPage service method.</param>
        /// <returns>The response from the UpdateProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdateProductPage">REST API Reference for UpdateProductPage Operation</seealso>
        public virtual UpdateProductPageResponse UpdateProductPage(UpdateProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductPageResponseUnmarshaller.Instance;

            return Invoke<UpdateProductPageResponse>(request, options);
        }
#else
        internal virtual UpdateProductPageResponse UpdateProductPage(UpdateProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductPageResponseUnmarshaller.Instance;

            return Invoke<UpdateProductPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates a product page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdateProductPage">REST API Reference for UpdateProductPage Operation</seealso>
        public virtual Task<UpdateProductPageResponse> UpdateProductPageAsync(UpdateProductPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductPageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProductPageResponse>(request, options, cancellationToken);
        }

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
    }
}
