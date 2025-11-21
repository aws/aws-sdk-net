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
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Schemas.Model;
using Amazon.Schemas.Model.Internal.MarshallTransformations;
using Amazon.Schemas.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Schemas
{
    /// <summary>
    /// <para>Implementation for accessing Schemas</para>
    ///
    /// Amazon EventBridge Schema Registry
    /// </summary>
    public partial class AmazonSchemasClient : AmazonServiceClient, IAmazonSchemas
    {
        private static IServiceMetadata serviceMetadata = new AmazonSchemasMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSchemasClient with the credentials loaded from the application's
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
        public AmazonSchemasClient()
            : base(new AmazonSchemasConfig()) { }

        /// <summary>
        /// Constructs AmazonSchemasClient with the credentials loaded from the application's
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
        public AmazonSchemasClient(RegionEndpoint region)
            : base(new AmazonSchemasConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSchemasClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSchemasClient Configuration Object</param>
        public AmazonSchemasClient(AmazonSchemasConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSchemasClient(AWSCredentials credentials)
            : this(credentials, new AmazonSchemasConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSchemasClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSchemasConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Credentials and an
        /// AmazonSchemasClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSchemasClient Configuration Object</param>
        public AmazonSchemasClient(AWSCredentials credentials, AmazonSchemasConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSchemasClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSchemasConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSchemasClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSchemasConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSchemasClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSchemasClient Configuration Object</param>
        public AmazonSchemasClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSchemasConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSchemasClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSchemasConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSchemasClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSchemasConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSchemasClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSchemasClient Configuration Object</param>
        public AmazonSchemasClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSchemasConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISchemasPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISchemasPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SchemasPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSchemasEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSchemasAuthSchemeHandler());
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


        #region  CreateDiscoverer

        internal virtual CreateDiscovererResponse CreateDiscoverer(CreateDiscovererRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiscovererResponseUnmarshaller.Instance;

            return Invoke<CreateDiscovererResponse>(request, options);
        }



        /// <summary>
        /// Creates a discoverer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDiscoverer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateDiscoverer">REST API Reference for CreateDiscoverer Operation</seealso>
        public virtual Task<CreateDiscovererResponse> CreateDiscovererAsync(CreateDiscovererRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiscovererResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDiscovererResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRegistry

        internal virtual CreateRegistryResponse CreateRegistry(CreateRegistryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistryResponseUnmarshaller.Instance;

            return Invoke<CreateRegistryResponse>(request, options);
        }



        /// <summary>
        /// Creates a registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        public virtual Task<CreateRegistryResponse> CreateRegistryAsync(CreateRegistryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRegistryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSchema

        internal virtual CreateSchemaResponse CreateSchema(CreateSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return Invoke<CreateSchemaResponse>(request, options);
        }



        /// <summary>
        /// Creates a schema definition.
        /// 
        ///  <note>
        /// <para>
        /// Inactive schemas will be deleted after two years.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual Task<CreateSchemaResponse> CreateSchemaAsync(CreateSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDiscoverer

        internal virtual DeleteDiscovererResponse DeleteDiscoverer(DeleteDiscovererRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDiscovererResponseUnmarshaller.Instance;

            return Invoke<DeleteDiscovererResponse>(request, options);
        }



        /// <summary>
        /// Deletes a discoverer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDiscoverer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteDiscoverer">REST API Reference for DeleteDiscoverer Operation</seealso>
        public virtual Task<DeleteDiscovererResponse> DeleteDiscovererAsync(DeleteDiscovererRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDiscovererResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDiscovererResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRegistry

        internal virtual DeleteRegistryResponse DeleteRegistry(DeleteRegistryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistryResponseUnmarshaller.Instance;

            return Invoke<DeleteRegistryResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        public virtual Task<DeleteRegistryResponse> DeleteRegistryAsync(DeleteRegistryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRegistryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Delete the resource-based policy attached to the specified registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSchema

        internal virtual DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaResponse>(request, options);
        }



        /// <summary>
        /// Delete a schema definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual Task<DeleteSchemaResponse> DeleteSchemaAsync(DeleteSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSchemaVersion

        internal virtual DeleteSchemaVersionResponse DeleteSchemaVersion(DeleteSchemaVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaVersionResponse>(request, options);
        }



        /// <summary>
        /// Delete the schema version definition
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchemaVersion service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchemaVersion">REST API Reference for DeleteSchemaVersion Operation</seealso>
        public virtual Task<DeleteSchemaVersionResponse> DeleteSchemaVersionAsync(DeleteSchemaVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSchemaVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeCodeBinding

        internal virtual DescribeCodeBindingResponse DescribeCodeBinding(DescribeCodeBindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCodeBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeBindingResponseUnmarshaller.Instance;

            return Invoke<DescribeCodeBindingResponse>(request, options);
        }



        /// <summary>
        /// Describe the code binding URI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeBinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCodeBinding service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeCodeBinding">REST API Reference for DescribeCodeBinding Operation</seealso>
        public virtual Task<DescribeCodeBindingResponse> DescribeCodeBindingAsync(DescribeCodeBindingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCodeBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeBindingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCodeBindingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDiscoverer

        internal virtual DescribeDiscovererResponse DescribeDiscoverer(DescribeDiscovererRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDiscovererResponseUnmarshaller.Instance;

            return Invoke<DescribeDiscovererResponse>(request, options);
        }



        /// <summary>
        /// Describes the discoverer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDiscoverer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeDiscoverer">REST API Reference for DescribeDiscoverer Operation</seealso>
        public virtual Task<DescribeDiscovererResponse> DescribeDiscovererAsync(DescribeDiscovererRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDiscovererResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDiscovererResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRegistry

        internal virtual DescribeRegistryResponse DescribeRegistry(DescribeRegistryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistryResponseUnmarshaller.Instance;

            return Invoke<DescribeRegistryResponse>(request, options);
        }



        /// <summary>
        /// Describes the registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeRegistry">REST API Reference for DescribeRegistry Operation</seealso>
        public virtual Task<DescribeRegistryResponse> DescribeRegistryAsync(DescribeRegistryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRegistryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSchema

        internal virtual DescribeSchemaResponse DescribeSchema(DescribeSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchemaResponseUnmarshaller.Instance;

            return Invoke<DescribeSchemaResponse>(request, options);
        }



        /// <summary>
        /// Retrieve the schema definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeSchema">REST API Reference for DescribeSchema Operation</seealso>
        public virtual Task<DescribeSchemaResponse> DescribeSchemaAsync(DescribeSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportSchema

        internal virtual ExportSchemaResponse ExportSchema(ExportSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportSchemaResponseUnmarshaller.Instance;

            return Invoke<ExportSchemaResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ExportSchema">REST API Reference for ExportSchema Operation</seealso>
        public virtual Task<ExportSchemaResponse> ExportSchemaAsync(ExportSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<ExportSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCodeBindingSource

        internal virtual GetCodeBindingSourceResponse GetCodeBindingSource(GetCodeBindingSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeBindingSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeBindingSourceResponseUnmarshaller.Instance;

            return Invoke<GetCodeBindingSourceResponse>(request, options);
        }



        /// <summary>
        /// Get the code binding source URI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeBindingSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCodeBindingSource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetCodeBindingSource">REST API Reference for GetCodeBindingSource Operation</seealso>
        public virtual Task<GetCodeBindingSourceResponse> GetCodeBindingSourceAsync(GetCodeBindingSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeBindingSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeBindingSourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetCodeBindingSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDiscoveredSchema

        internal virtual GetDiscoveredSchemaResponse GetDiscoveredSchema(GetDiscoveredSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDiscoveredSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiscoveredSchemaResponseUnmarshaller.Instance;

            return Invoke<GetDiscoveredSchemaResponse>(request, options);
        }



        /// <summary>
        /// Get the discovered schema that was generated based on sampled events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveredSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDiscoveredSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetDiscoveredSchema">REST API Reference for GetDiscoveredSchema Operation</seealso>
        public virtual Task<GetDiscoveredSchemaResponse> GetDiscoveredSchemaAsync(GetDiscoveredSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDiscoveredSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiscoveredSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<GetDiscoveredSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourcePolicy

        internal virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the resource-based policy attached to a given registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDiscoverers

        internal virtual ListDiscoverersResponse ListDiscoverers(ListDiscoverersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDiscoverersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoverersResponseUnmarshaller.Instance;

            return Invoke<ListDiscoverersResponse>(request, options);
        }



        /// <summary>
        /// List the discoverers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoverers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDiscoverers service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListDiscoverers">REST API Reference for ListDiscoverers Operation</seealso>
        public virtual Task<ListDiscoverersResponse> ListDiscoverersAsync(ListDiscoverersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDiscoverersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoverersResponseUnmarshaller.Instance;

            return InvokeAsync<ListDiscoverersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRegistries

        internal virtual ListRegistriesResponse ListRegistries(ListRegistriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegistriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistriesResponseUnmarshaller.Instance;

            return Invoke<ListRegistriesResponse>(request, options);
        }



        /// <summary>
        /// List the registries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegistries service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        public virtual Task<ListRegistriesResponse> ListRegistriesAsync(ListRegistriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegistriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRegistriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSchemas

        internal virtual ListSchemasResponse ListSchemas(ListSchemasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return Invoke<ListSchemasResponse>(request, options);
        }



        /// <summary>
        /// List the schemas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual Task<ListSchemasResponse> ListSchemasAsync(ListSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return InvokeAsync<ListSchemasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSchemaVersions

        internal virtual ListSchemaVersionsResponse ListSchemaVersions(ListSchemaVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaVersionsResponseUnmarshaller.Instance;

            return Invoke<ListSchemaVersionsResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of the schema versions and related information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemaVersions service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        public virtual Task<ListSchemaVersionsResponse> ListSchemaVersionsAsync(ListSchemaVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSchemaVersionsResponse>(request, options, cancellationToken);
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
        /// Get tags for resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutCodeBinding

        internal virtual PutCodeBindingResponse PutCodeBinding(PutCodeBindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutCodeBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCodeBindingResponseUnmarshaller.Instance;

            return Invoke<PutCodeBindingResponse>(request, options);
        }



        /// <summary>
        /// Put code binding URI
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCodeBinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutCodeBinding service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.GoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutCodeBinding">REST API Reference for PutCodeBinding Operation</seealso>
        public virtual Task<PutCodeBindingResponse> PutCodeBindingAsync(PutCodeBindingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutCodeBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCodeBindingResponseUnmarshaller.Instance;

            return InvokeAsync<PutCodeBindingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// The name of the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchSchemas

        internal virtual SearchSchemasResponse SearchSchemas(SearchSchemasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSchemasResponseUnmarshaller.Instance;

            return Invoke<SearchSchemasResponse>(request, options);
        }



        /// <summary>
        /// Search the schemas
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSchemas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchSchemas service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/SearchSchemas">REST API Reference for SearchSchemas Operation</seealso>
        public virtual Task<SearchSchemasResponse> SearchSchemasAsync(SearchSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSchemasResponseUnmarshaller.Instance;

            return InvokeAsync<SearchSchemasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartDiscoverer

        internal virtual StartDiscovererResponse StartDiscoverer(StartDiscovererRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDiscovererResponseUnmarshaller.Instance;

            return Invoke<StartDiscovererResponse>(request, options);
        }



        /// <summary>
        /// Starts the discoverer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDiscoverer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StartDiscoverer">REST API Reference for StartDiscoverer Operation</seealso>
        public virtual Task<StartDiscovererResponse> StartDiscovererAsync(StartDiscovererRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDiscovererResponseUnmarshaller.Instance;

            return InvokeAsync<StartDiscovererResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopDiscoverer

        internal virtual StopDiscovererResponse StopDiscoverer(StopDiscovererRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDiscovererResponseUnmarshaller.Instance;

            return Invoke<StopDiscovererResponse>(request, options);
        }



        /// <summary>
        /// Stops the discoverer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDiscoverer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StopDiscoverer">REST API Reference for StopDiscoverer Operation</seealso>
        public virtual Task<StopDiscovererResponse> StopDiscovererAsync(StopDiscovererRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDiscovererResponseUnmarshaller.Instance;

            return InvokeAsync<StopDiscovererResponse>(request, options, cancellationToken);
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
        /// Add tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDiscoverer

        internal virtual UpdateDiscovererResponse UpdateDiscoverer(UpdateDiscovererRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDiscovererResponseUnmarshaller.Instance;

            return Invoke<UpdateDiscovererResponse>(request, options);
        }



        /// <summary>
        /// Updates the discoverer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDiscoverer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateDiscoverer">REST API Reference for UpdateDiscoverer Operation</seealso>
        public virtual Task<UpdateDiscovererResponse> UpdateDiscovererAsync(UpdateDiscovererRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDiscovererResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDiscovererResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRegistry

        internal virtual UpdateRegistryResponse UpdateRegistry(UpdateRegistryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistryResponseUnmarshaller.Instance;

            return Invoke<UpdateRegistryResponse>(request, options);
        }



        /// <summary>
        /// Updates a registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        public virtual Task<UpdateRegistryResponse> UpdateRegistryAsync(UpdateRegistryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistryResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRegistryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSchema

        internal virtual UpdateSchemaResponse UpdateSchema(UpdateSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return Invoke<UpdateSchemaResponse>(request, options);
        }



        /// <summary>
        /// Updates the schema definition
        /// 
        ///  <note>
        /// <para>
        /// Inactive schemas will be deleted after two years.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public virtual Task<UpdateSchemaResponse> UpdateSchemaAsync(UpdateSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSchemaResponse>(request, options, cancellationToken);
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