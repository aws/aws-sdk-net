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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.OpenSearchService.Model;
using Amazon.OpenSearchService.Model.Internal.MarshallTransformations;
using Amazon.OpenSearchService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.OpenSearchService
{
    /// <summary>
    /// <para>Implementation for accessing OpenSearchService</para>
    ///
    /// Use the Amazon OpenSearch Service configuration API to create, configure, and manage
    /// OpenSearch Service domains. The endpoint for configuration service requests is Region
    /// specific: es.<i>region</i>.amazonaws.com. For example, es.us-east-1.amazonaws.com.
    /// For a current list of supported Regions and endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#service-regions">Amazon
    /// Web Services service endpoints</a>.
    /// </summary>
    public partial class AmazonOpenSearchServiceClient : AmazonServiceClient, IAmazonOpenSearchService
    {
        private static IServiceMetadata serviceMetadata = new AmazonOpenSearchServiceMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonOpenSearchServiceClient with the credentials loaded from the application's
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
        public AmazonOpenSearchServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpenSearchServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonOpenSearchServiceClient with the credentials loaded from the application's
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
        public AmazonOpenSearchServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpenSearchServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonOpenSearchServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonOpenSearchServiceClient Configuration Object</param>
        public AmazonOpenSearchServiceClient(AmazonOpenSearchServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonOpenSearchServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonOpenSearchServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonOpenSearchServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpenSearchServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonOpenSearchServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServiceClient with AWS Credentials and an
        /// AmazonOpenSearchServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonOpenSearchServiceClient Configuration Object</param>
        public AmazonOpenSearchServiceClient(AWSCredentials credentials, AmazonOpenSearchServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonOpenSearchServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOpenSearchServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpenSearchServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOpenSearchServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOpenSearchServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonOpenSearchServiceClient Configuration Object</param>
        public AmazonOpenSearchServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonOpenSearchServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonOpenSearchServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOpenSearchServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpenSearchServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOpenSearchServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOpenSearchServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonOpenSearchServiceClient Configuration Object</param>
        public AmazonOpenSearchServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonOpenSearchServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IOpenSearchServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IOpenSearchServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new OpenSearchServicePaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOpenSearchServiceEndpointResolver());
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


        #region  AcceptInboundConnection

        internal virtual AcceptInboundConnectionResponse AcceptInboundConnection(AcceptInboundConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptInboundConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptInboundConnectionResponseUnmarshaller.Instance;

            return Invoke<AcceptInboundConnectionResponse>(request, options);
        }



        /// <summary>
        /// Allows the destination Amazon OpenSearch Service domain owner to accept an inbound
        /// cross-cluster search connection request. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cross-cluster-search.html">Cross-cluster
        /// search for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInboundConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptInboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AcceptInboundConnection">REST API Reference for AcceptInboundConnection Operation</seealso>
        public virtual Task<AcceptInboundConnectionResponse> AcceptInboundConnectionAsync(AcceptInboundConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptInboundConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptInboundConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptInboundConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddDataSource

        internal virtual AddDataSourceResponse AddDataSource(AddDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddDataSourceResponseUnmarshaller.Instance;

            return Invoke<AddDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Creates a new direct-query data source to the specified domain. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/direct-query-s3-creating.html">Creating
        /// Amazon OpenSearch Service data source integrations with Amazon S3</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddDataSource service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DependencyFailureException">
        /// An exception for when a failure in one of the dependencies results in the service
        /// being unable to fetch details about the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AddDataSource">REST API Reference for AddDataSource Operation</seealso>
        public virtual Task<AddDataSourceResponse> AddDataSourceAsync(AddDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }



        /// <summary>
        /// Attaches tags to an existing Amazon OpenSearch Service domain. Tags are a set of case-sensitive
        /// key-value pairs. A domain can have up to 10 tags. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-awsresourcetagging.html">Tagging
        /// Amazon OpenSearch Service domains</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociatePackage

        internal virtual AssociatePackageResponse AssociatePackage(AssociatePackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePackageResponseUnmarshaller.Instance;

            return Invoke<AssociatePackageResponse>(request, options);
        }



        /// <summary>
        /// Associates a package with an Amazon OpenSearch Service domain. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AssociatePackage">REST API Reference for AssociatePackage Operation</seealso>
        public virtual Task<AssociatePackageResponse> AssociatePackageAsync(AssociatePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePackageResponseUnmarshaller.Instance;

            return InvokeAsync<AssociatePackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeVpcEndpointAccess

        internal virtual AuthorizeVpcEndpointAccessResponse AuthorizeVpcEndpointAccess(AuthorizeVpcEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeVpcEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeVpcEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<AuthorizeVpcEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Provides access to an Amazon OpenSearch Service domain through the use of an interface
        /// VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeVpcEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeVpcEndpointAccess service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AuthorizeVpcEndpointAccess">REST API Reference for AuthorizeVpcEndpointAccess Operation</seealso>
        public virtual Task<AuthorizeVpcEndpointAccessResponse> AuthorizeVpcEndpointAccessAsync(AuthorizeVpcEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeVpcEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeVpcEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeVpcEndpointAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelDomainConfigChange

        internal virtual CancelDomainConfigChangeResponse CancelDomainConfigChange(CancelDomainConfigChangeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDomainConfigChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDomainConfigChangeResponseUnmarshaller.Instance;

            return Invoke<CancelDomainConfigChangeResponse>(request, options);
        }



        /// <summary>
        /// Cancels a pending configuration change on an Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDomainConfigChange service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelDomainConfigChange service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CancelDomainConfigChange">REST API Reference for CancelDomainConfigChange Operation</seealso>
        public virtual Task<CancelDomainConfigChangeResponse> CancelDomainConfigChangeAsync(CancelDomainConfigChangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDomainConfigChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDomainConfigChangeResponseUnmarshaller.Instance;

            return InvokeAsync<CancelDomainConfigChangeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelServiceSoftwareUpdate

        internal virtual CancelServiceSoftwareUpdateResponse CancelServiceSoftwareUpdate(CancelServiceSoftwareUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return Invoke<CancelServiceSoftwareUpdateResponse>(request, options);
        }



        /// <summary>
        /// Cancels a scheduled service software update for an Amazon OpenSearch Service domain.
        /// You can only perform this operation before the <c>AutomatedUpdateDate</c> and when
        /// the domain's <c>UpdateStatus</c> is <c>PENDING_UPDATE</c>. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/service-software.html">Service
        /// software updates in Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelServiceSoftwareUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelServiceSoftwareUpdate service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CancelServiceSoftwareUpdate">REST API Reference for CancelServiceSoftwareUpdate Operation</seealso>
        public virtual Task<CancelServiceSoftwareUpdateResponse> CancelServiceSoftwareUpdateAsync(CancelServiceSoftwareUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<CancelServiceSoftwareUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomain

        internal virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon OpenSearch Service domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html">Creating
        /// and managing Amazon OpenSearch Service domains</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access a sub-resource that's either invalid or
        /// not supported.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOutboundConnection

        internal virtual CreateOutboundConnectionResponse CreateOutboundConnection(CreateOutboundConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOutboundConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOutboundConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateOutboundConnectionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new cross-cluster search connection from a source Amazon OpenSearch Service
        /// domain to a destination domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cross-cluster-search.html">Cross-cluster
        /// search for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOutboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreateOutboundConnection">REST API Reference for CreateOutboundConnection Operation</seealso>
        public virtual Task<CreateOutboundConnectionResponse> CreateOutboundConnectionAsync(CreateOutboundConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOutboundConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOutboundConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOutboundConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePackage

        internal virtual CreatePackageResponse CreatePackage(CreatePackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackageResponseUnmarshaller.Instance;

            return Invoke<CreatePackageResponse>(request, options);
        }



        /// <summary>
        /// Creates a package for use with Amazon OpenSearch Service domains. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access a sub-resource that's either invalid or
        /// not supported.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        public virtual Task<CreatePackageResponse> CreatePackageAsync(CreatePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackageResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcEndpoint

        internal virtual CreateVpcEndpointResponse CreateVpcEndpoint(CreateVpcEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon OpenSearch Service-managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcEndpoint service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        public virtual Task<CreateVpcEndpointResponse> CreateVpcEndpointAsync(CreateVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataSource

        internal virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a direct-query data source. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/direct-query-s3-delete.html">Deleting
        /// an Amazon OpenSearch Service data source with Amazon S3</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DependencyFailureException">
        /// An exception for when a failure in one of the dependencies results in the service
        /// being unable to fetch details about the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomain

        internal virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon OpenSearch Service domain and all of its data. You can't recover
        /// a domain after you delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInboundConnection

        internal virtual DeleteInboundConnectionResponse DeleteInboundConnection(DeleteInboundConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInboundConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInboundConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteInboundConnectionResponse>(request, options);
        }



        /// <summary>
        /// Allows the destination Amazon OpenSearch Service domain owner to delete an existing
        /// inbound cross-cluster search connection. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cross-cluster-search.html">Cross-cluster
        /// search for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteInboundConnection">REST API Reference for DeleteInboundConnection Operation</seealso>
        public virtual Task<DeleteInboundConnectionResponse> DeleteInboundConnectionAsync(DeleteInboundConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInboundConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInboundConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInboundConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOutboundConnection

        internal virtual DeleteOutboundConnectionResponse DeleteOutboundConnection(DeleteOutboundConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOutboundConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOutboundConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteOutboundConnectionResponse>(request, options);
        }



        /// <summary>
        /// Allows the source Amazon OpenSearch Service domain owner to delete an existing outbound
        /// cross-cluster search connection. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cross-cluster-search.html">Cross-cluster
        /// search for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOutboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteOutboundConnection">REST API Reference for DeleteOutboundConnection Operation</seealso>
        public virtual Task<DeleteOutboundConnectionResponse> DeleteOutboundConnectionAsync(DeleteOutboundConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOutboundConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOutboundConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOutboundConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePackage

        internal virtual DeletePackageResponse DeletePackage(DeletePackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackageResponseUnmarshaller.Instance;

            return Invoke<DeletePackageResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon OpenSearch Service package. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        public virtual Task<DeletePackageResponse> DeletePackageAsync(DeletePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackageResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcEndpoint

        internal virtual DeleteVpcEndpointResponse DeleteVpcEndpoint(DeleteVpcEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon OpenSearch Service-managed interface VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcEndpoint service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteVpcEndpoint">REST API Reference for DeleteVpcEndpoint Operation</seealso>
        public virtual Task<DeleteVpcEndpointResponse> DeleteVpcEndpointAsync(DeleteVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomain

        internal virtual DescribeDomainResponse DescribeDomain(DescribeDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainResponse>(request, options);
        }



        /// <summary>
        /// Describes the domain configuration for the specified Amazon OpenSearch Service domain,
        /// including the domain ID, domain service endpoint, and domain ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        public virtual Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomainAutoTunes

        internal virtual DescribeDomainAutoTunesResponse DescribeDomainAutoTunes(DescribeDomainAutoTunesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainAutoTunesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainAutoTunesResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainAutoTunesResponse>(request, options);
        }



        /// <summary>
        /// Returns the list of optimizations that Auto-Tune has made to an Amazon OpenSearch
        /// Service domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html">Auto-Tune
        /// for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainAutoTunes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomainAutoTunes service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainAutoTunes">REST API Reference for DescribeDomainAutoTunes Operation</seealso>
        public virtual Task<DescribeDomainAutoTunesResponse> DescribeDomainAutoTunesAsync(DescribeDomainAutoTunesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainAutoTunesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainAutoTunesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainAutoTunesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomainChangeProgress

        internal virtual DescribeDomainChangeProgressResponse DescribeDomainChangeProgress(DescribeDomainChangeProgressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainChangeProgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainChangeProgressResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainChangeProgressResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the current blue/green deployment happening on an Amazon
        /// OpenSearch Service domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-configuration-changes.html">Making
        /// configuration changes in Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainChangeProgress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomainChangeProgress service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainChangeProgress">REST API Reference for DescribeDomainChangeProgress Operation</seealso>
        public virtual Task<DescribeDomainChangeProgressResponse> DescribeDomainChangeProgressAsync(DescribeDomainChangeProgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainChangeProgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainChangeProgressResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainChangeProgressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomainConfig

        internal virtual DescribeDomainConfigResponse DescribeDomainConfig(DescribeDomainConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainConfigResponse>(request, options);
        }



        /// <summary>
        /// Returns the configuration of an Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomainConfig service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainConfig">REST API Reference for DescribeDomainConfig Operation</seealso>
        public virtual Task<DescribeDomainConfigResponse> DescribeDomainConfigAsync(DescribeDomainConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomainHealth

        internal virtual DescribeDomainHealthResponse DescribeDomainHealth(DescribeDomainHealthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainHealthResponse>(request, options);
        }



        /// <summary>
        /// Returns information about domain and node health, the standby Availability Zone, number
        /// of nodes per Availability Zone, and shard count per node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomainHealth service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainHealth">REST API Reference for DescribeDomainHealth Operation</seealso>
        public virtual Task<DescribeDomainHealthResponse> DescribeDomainHealthAsync(DescribeDomainHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainHealthResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainHealthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomainNodes

        internal virtual DescribeDomainNodesResponse DescribeDomainNodes(DescribeDomainNodesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainNodesResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainNodesResponse>(request, options);
        }



        /// <summary>
        /// Returns information about domain and nodes, including data nodes, master nodes, ultrawarm
        /// nodes, Availability Zone(s), standby nodes, node configurations, and node states.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomainNodes service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DependencyFailureException">
        /// An exception for when a failure in one of the dependencies results in the service
        /// being unable to fetch details about the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainNodes">REST API Reference for DescribeDomainNodes Operation</seealso>
        public virtual Task<DescribeDomainNodesResponse> DescribeDomainNodesAsync(DescribeDomainNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainNodesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainNodesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomains

        internal virtual DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainsResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainsResponse>(request, options);
        }



        /// <summary>
        /// Returns domain configuration information about the specified Amazon OpenSearch Service
        /// domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomains">REST API Reference for DescribeDomains Operation</seealso>
        public virtual Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDryRunProgress

        internal virtual DescribeDryRunProgressResponse DescribeDryRunProgress(DescribeDryRunProgressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDryRunProgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDryRunProgressResponseUnmarshaller.Instance;

            return Invoke<DescribeDryRunProgressResponse>(request, options);
        }



        /// <summary>
        /// Describes the progress of a pre-update dry run analysis on an Amazon OpenSearch Service
        /// domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-configuration-changes#dryrun">Determining
        /// whether a change will cause a blue/green deployment</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDryRunProgress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDryRunProgress service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDryRunProgress">REST API Reference for DescribeDryRunProgress Operation</seealso>
        public virtual Task<DescribeDryRunProgressResponse> DescribeDryRunProgressAsync(DescribeDryRunProgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDryRunProgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDryRunProgressResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDryRunProgressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInboundConnections

        internal virtual DescribeInboundConnectionsResponse DescribeInboundConnections(DescribeInboundConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInboundConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInboundConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeInboundConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the inbound cross-cluster search connections for a destination (remote)
        /// Amazon OpenSearch Service domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cross-cluster-search.html">Cross-cluster
        /// search for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInboundConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInboundConnections service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidPaginationTokenException">
        /// Request processing failed because you provided an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeInboundConnections">REST API Reference for DescribeInboundConnections Operation</seealso>
        public virtual Task<DescribeInboundConnectionsResponse> DescribeInboundConnectionsAsync(DescribeInboundConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInboundConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInboundConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInboundConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceTypeLimits

        internal virtual DescribeInstanceTypeLimitsResponse DescribeInstanceTypeLimits(DescribeInstanceTypeLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceTypeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceTypeLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceTypeLimitsResponse>(request, options);
        }



        /// <summary>
        /// Describes the instance count, storage, and master node limits for a given OpenSearch
        /// or Elasticsearch version and instance type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceTypeLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceTypeLimits service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access a sub-resource that's either invalid or
        /// not supported.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeInstanceTypeLimits">REST API Reference for DescribeInstanceTypeLimits Operation</seealso>
        public virtual Task<DescribeInstanceTypeLimitsResponse> DescribeInstanceTypeLimitsAsync(DescribeInstanceTypeLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceTypeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceTypeLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceTypeLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOutboundConnections

        internal virtual DescribeOutboundConnectionsResponse DescribeOutboundConnections(DescribeOutboundConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOutboundConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOutboundConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOutboundConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the outbound cross-cluster connections for a local (source) Amazon OpenSearch
        /// Service domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cross-cluster-search.html">Cross-cluster
        /// search for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOutboundConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOutboundConnections service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidPaginationTokenException">
        /// Request processing failed because you provided an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeOutboundConnections">REST API Reference for DescribeOutboundConnections Operation</seealso>
        public virtual Task<DescribeOutboundConnectionsResponse> DescribeOutboundConnectionsAsync(DescribeOutboundConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOutboundConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOutboundConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOutboundConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePackages

        internal virtual DescribePackagesResponse DescribePackages(DescribePackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackagesResponseUnmarshaller.Instance;

            return Invoke<DescribePackagesResponse>(request, options);
        }



        /// <summary>
        /// Describes all packages available to OpenSearch Service. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePackages service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribePackages">REST API Reference for DescribePackages Operation</seealso>
        public virtual Task<DescribePackagesResponse> DescribePackagesAsync(DescribePackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePackagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstanceOfferings

        internal virtual DescribeReservedInstanceOfferingsResponse DescribeReservedInstanceOfferings(DescribeReservedInstanceOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstanceOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstanceOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstanceOfferingsResponse>(request, options);
        }



        /// <summary>
        /// Describes the available Amazon OpenSearch Service Reserved Instance offerings for
        /// a given Region. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/ri.html">Reserved
        /// Instances in Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstanceOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstanceOfferings service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeReservedInstanceOfferings">REST API Reference for DescribeReservedInstanceOfferings Operation</seealso>
        public virtual Task<DescribeReservedInstanceOfferingsResponse> DescribeReservedInstanceOfferingsAsync(DescribeReservedInstanceOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstanceOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstanceOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstanceOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstances

        internal virtual DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesResponse>(request, options);
        }



        /// <summary>
        /// Describes the Amazon OpenSearch Service instances that you have reserved in a given
        /// Region. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/ri.html">Reserved
        /// Instances in Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        public virtual Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(DescribeReservedInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpoints

        internal virtual DescribeVpcEndpointsResponse DescribeVpcEndpoints(DescribeVpcEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more Amazon OpenSearch Service-managed VPC endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcEndpoints service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
        public virtual Task<DescribeVpcEndpointsResponse> DescribeVpcEndpointsAsync(DescribeVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DissociatePackage

        internal virtual DissociatePackageResponse DissociatePackage(DissociatePackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DissociatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DissociatePackageResponseUnmarshaller.Instance;

            return Invoke<DissociatePackageResponse>(request, options);
        }



        /// <summary>
        /// Removes a package from the specified Amazon OpenSearch Service domain. The package
        /// can't be in use with any OpenSearch index for the dissociation to succeed. The package
        /// is still available in OpenSearch Service for association later. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DissociatePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DissociatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DissociatePackage">REST API Reference for DissociatePackage Operation</seealso>
        public virtual Task<DissociatePackageResponse> DissociatePackageAsync(DissociatePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DissociatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DissociatePackageResponseUnmarshaller.Instance;

            return InvokeAsync<DissociatePackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCompatibleVersions

        internal virtual GetCompatibleVersionsResponse GetCompatibleVersions(GetCompatibleVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCompatibleVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompatibleVersionsResponseUnmarshaller.Instance;

            return Invoke<GetCompatibleVersionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a map of OpenSearch or Elasticsearch versions and the versions you can upgrade
        /// them to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCompatibleVersions service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetCompatibleVersions">REST API Reference for GetCompatibleVersions Operation</seealso>
        public virtual Task<GetCompatibleVersionsResponse> GetCompatibleVersionsAsync(GetCompatibleVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCompatibleVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompatibleVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCompatibleVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataSource

        internal virtual GetDataSourceResponse GetDataSource(GetDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a direct query data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DependencyFailureException">
        /// An exception for when a failure in one of the dependencies results in the service
        /// being unable to fetch details about the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual Task<GetDataSourceResponse> GetDataSourceAsync(GetDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomainMaintenanceStatus

        internal virtual GetDomainMaintenanceStatusResponse GetDomainMaintenanceStatus(GetDomainMaintenanceStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainMaintenanceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainMaintenanceStatusResponseUnmarshaller.Instance;

            return Invoke<GetDomainMaintenanceStatusResponse>(request, options);
        }



        /// <summary>
        /// The status of the maintenance action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainMaintenanceStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainMaintenanceStatus service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetDomainMaintenanceStatus">REST API Reference for GetDomainMaintenanceStatus Operation</seealso>
        public virtual Task<GetDomainMaintenanceStatusResponse> GetDomainMaintenanceStatusAsync(GetDomainMaintenanceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainMaintenanceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainMaintenanceStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainMaintenanceStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPackageVersionHistory

        internal virtual GetPackageVersionHistoryResponse GetPackageVersionHistory(GetPackageVersionHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPackageVersionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPackageVersionHistoryResponseUnmarshaller.Instance;

            return Invoke<GetPackageVersionHistoryResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of Amazon OpenSearch Service package versions, along with their creation
        /// time, commit message, and plugin properties (if the package is a zip plugin package).
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPackageVersionHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPackageVersionHistory service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetPackageVersionHistory">REST API Reference for GetPackageVersionHistory Operation</seealso>
        public virtual Task<GetPackageVersionHistoryResponse> GetPackageVersionHistoryAsync(GetPackageVersionHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPackageVersionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPackageVersionHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetPackageVersionHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUpgradeHistory

        internal virtual GetUpgradeHistoryResponse GetUpgradeHistory(GetUpgradeHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUpgradeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeHistoryResponseUnmarshaller.Instance;

            return Invoke<GetUpgradeHistoryResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the complete history of the last 10 upgrades performed on an Amazon OpenSearch
        /// Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUpgradeHistory service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetUpgradeHistory">REST API Reference for GetUpgradeHistory Operation</seealso>
        public virtual Task<GetUpgradeHistoryResponse> GetUpgradeHistoryAsync(GetUpgradeHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUpgradeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetUpgradeHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUpgradeStatus

        internal virtual GetUpgradeStatusResponse GetUpgradeStatus(GetUpgradeStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUpgradeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeStatusResponseUnmarshaller.Instance;

            return Invoke<GetUpgradeStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns the most recent status of the last upgrade or upgrade eligibility check performed
        /// on an Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUpgradeStatus service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetUpgradeStatus">REST API Reference for GetUpgradeStatus Operation</seealso>
        public virtual Task<GetUpgradeStatusResponse> GetUpgradeStatusAsync(GetUpgradeStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUpgradeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetUpgradeStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataSources

        internal virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists direct-query data sources for a specific domain. For more information, see For
        /// more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/direct-query-s3.html">Working
        /// with Amazon OpenSearch Service direct queries with Amazon S3</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DependencyFailureException">
        /// An exception for when a failure in one of the dependencies results in the service
        /// being unable to fetch details about the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataSourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomainMaintenances

        internal virtual ListDomainMaintenancesResponse ListDomainMaintenances(ListDomainMaintenancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainMaintenancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainMaintenancesResponseUnmarshaller.Instance;

            return Invoke<ListDomainMaintenancesResponse>(request, options);
        }



        /// <summary>
        /// A list of maintenance actions for the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainMaintenances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainMaintenances service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListDomainMaintenances">REST API Reference for ListDomainMaintenances Operation</seealso>
        public virtual Task<ListDomainMaintenancesResponse> ListDomainMaintenancesAsync(ListDomainMaintenancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainMaintenancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainMaintenancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainMaintenancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomainNames

        internal virtual ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return Invoke<ListDomainNamesResponse>(request, options);
        }



        /// <summary>
        /// Returns the names of all Amazon OpenSearch Service domains owned by the current user
        /// in the active Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        public virtual Task<ListDomainNamesResponse> ListDomainNamesAsync(ListDomainNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainNamesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomainsForPackage

        internal virtual ListDomainsForPackageResponse ListDomainsForPackage(ListDomainsForPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsForPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsForPackageResponseUnmarshaller.Instance;

            return Invoke<ListDomainsForPackageResponse>(request, options);
        }



        /// <summary>
        /// Lists all Amazon OpenSearch Service domains associated with a given package. For more
        /// information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainsForPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainsForPackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListDomainsForPackage">REST API Reference for ListDomainsForPackage Operation</seealso>
        public virtual Task<ListDomainsForPackageResponse> ListDomainsForPackageAsync(ListDomainsForPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsForPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsForPackageResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainsForPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInstanceTypeDetails

        internal virtual ListInstanceTypeDetailsResponse ListInstanceTypeDetails(ListInstanceTypeDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceTypeDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceTypeDetailsResponseUnmarshaller.Instance;

            return Invoke<ListInstanceTypeDetailsResponse>(request, options);
        }



        /// <summary>
        /// Lists all instance types and available features for a given OpenSearch or Elasticsearch
        /// version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceTypeDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceTypeDetails service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListInstanceTypeDetails">REST API Reference for ListInstanceTypeDetails Operation</seealso>
        public virtual Task<ListInstanceTypeDetailsResponse> ListInstanceTypeDetailsAsync(ListInstanceTypeDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceTypeDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceTypeDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstanceTypeDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPackagesForDomain

        internal virtual ListPackagesForDomainResponse ListPackagesForDomain(ListPackagesForDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackagesForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagesForDomainResponseUnmarshaller.Instance;

            return Invoke<ListPackagesForDomainResponse>(request, options);
        }



        /// <summary>
        /// Lists all packages associated with an Amazon OpenSearch Service domain. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackagesForDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPackagesForDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListPackagesForDomain">REST API Reference for ListPackagesForDomain Operation</seealso>
        public virtual Task<ListPackagesForDomainResponse> ListPackagesForDomainAsync(ListPackagesForDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPackagesForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagesForDomainResponseUnmarshaller.Instance;

            return InvokeAsync<ListPackagesForDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListScheduledActions

        internal virtual ListScheduledActionsResponse ListScheduledActions(ListScheduledActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduledActionsResponseUnmarshaller.Instance;

            return Invoke<ListScheduledActionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of configuration changes that are scheduled for a domain. These changes
        /// can be <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/service-software.html">service
        /// software updates</a> or <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html#auto-tune-types">blue/green
        /// Auto-Tune enhancements</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScheduledActions service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidPaginationTokenException">
        /// Request processing failed because you provided an invalid pagination token.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListScheduledActions">REST API Reference for ListScheduledActions Operation</seealso>
        public virtual Task<ListScheduledActionsResponse> ListScheduledActionsAsync(ListScheduledActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduledActionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListScheduledActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }



        /// <summary>
        /// Returns all resource tags for an Amazon OpenSearch Service domain. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-awsresourcetagging.html">Tagging
        /// Amazon OpenSearch Service domains</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVersions

        internal virtual ListVersionsResponse ListVersions(ListVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return Invoke<ListVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all versions of OpenSearch and Elasticsearch that Amazon OpenSearch Service
        /// supports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListVersions">REST API Reference for ListVersions Operation</seealso>
        public virtual Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVpcEndpointAccess

        internal virtual ListVpcEndpointAccessResponse ListVpcEndpointAccess(ListVpcEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<ListVpcEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about each Amazon Web Services principal that is allowed to
        /// access a given Amazon OpenSearch Service domain through the use of an interface VPC
        /// endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVpcEndpointAccess service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListVpcEndpointAccess">REST API Reference for ListVpcEndpointAccess Operation</seealso>
        public virtual Task<ListVpcEndpointAccessResponse> ListVpcEndpointAccessAsync(ListVpcEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<ListVpcEndpointAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVpcEndpoints

        internal virtual ListVpcEndpointsResponse ListVpcEndpoints(ListVpcEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListVpcEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all Amazon OpenSearch Service-managed VPC endpoints in the current Amazon
        /// Web Services account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVpcEndpoints service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListVpcEndpoints">REST API Reference for ListVpcEndpoints Operation</seealso>
        public virtual Task<ListVpcEndpointsResponse> ListVpcEndpointsAsync(ListVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVpcEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVpcEndpointsForDomain

        internal virtual ListVpcEndpointsForDomainResponse ListVpcEndpointsForDomain(ListVpcEndpointsForDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointsForDomainResponseUnmarshaller.Instance;

            return Invoke<ListVpcEndpointsForDomainResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all Amazon OpenSearch Service-managed VPC endpoints associated with a particular
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpointsForDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVpcEndpointsForDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListVpcEndpointsForDomain">REST API Reference for ListVpcEndpointsForDomain Operation</seealso>
        public virtual Task<ListVpcEndpointsForDomainResponse> ListVpcEndpointsForDomainAsync(ListVpcEndpointsForDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointsForDomainResponseUnmarshaller.Instance;

            return InvokeAsync<ListVpcEndpointsForDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedInstanceOffering

        internal virtual PurchaseReservedInstanceOfferingResponse PurchaseReservedInstanceOffering(PurchaseReservedInstanceOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedInstanceOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedInstanceOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedInstanceOfferingResponse>(request, options);
        }



        /// <summary>
        /// Allows you to purchase Amazon OpenSearch Service Reserved Instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstanceOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseReservedInstanceOffering service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/PurchaseReservedInstanceOffering">REST API Reference for PurchaseReservedInstanceOffering Operation</seealso>
        public virtual Task<PurchaseReservedInstanceOfferingResponse> PurchaseReservedInstanceOfferingAsync(PurchaseReservedInstanceOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedInstanceOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedInstanceOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedInstanceOfferingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectInboundConnection

        internal virtual RejectInboundConnectionResponse RejectInboundConnection(RejectInboundConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectInboundConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectInboundConnectionResponseUnmarshaller.Instance;

            return Invoke<RejectInboundConnectionResponse>(request, options);
        }



        /// <summary>
        /// Allows the remote Amazon OpenSearch Service domain owner to reject an inbound cross-cluster
        /// connection request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectInboundConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectInboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/RejectInboundConnection">REST API Reference for RejectInboundConnection Operation</seealso>
        public virtual Task<RejectInboundConnectionResponse> RejectInboundConnectionAsync(RejectInboundConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectInboundConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectInboundConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<RejectInboundConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTags

        internal virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified set of tags from an Amazon OpenSearch Service domain. For more
        /// information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains.html#managedomains-awsresorcetagging">
        /// Tagging Amazon OpenSearch Service domains</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeVpcEndpointAccess

        internal virtual RevokeVpcEndpointAccessResponse RevokeVpcEndpointAccess(RevokeVpcEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeVpcEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeVpcEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<RevokeVpcEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Revokes access to an Amazon OpenSearch Service domain that was provided through an
        /// interface VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeVpcEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeVpcEndpointAccess service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/RevokeVpcEndpointAccess">REST API Reference for RevokeVpcEndpointAccess Operation</seealso>
        public virtual Task<RevokeVpcEndpointAccessResponse> RevokeVpcEndpointAccessAsync(RevokeVpcEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeVpcEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeVpcEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeVpcEndpointAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDomainMaintenance

        internal virtual StartDomainMaintenanceResponse StartDomainMaintenance(StartDomainMaintenanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDomainMaintenanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDomainMaintenanceResponseUnmarshaller.Instance;

            return Invoke<StartDomainMaintenanceResponse>(request, options);
        }



        /// <summary>
        /// Starts the node maintenance process on the data node. These processes can include
        /// a node reboot, an Opensearch or Elasticsearch process restart, or a Dashboard or Kibana
        /// restart.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDomainMaintenance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDomainMaintenance service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/StartDomainMaintenance">REST API Reference for StartDomainMaintenance Operation</seealso>
        public virtual Task<StartDomainMaintenanceResponse> StartDomainMaintenanceAsync(StartDomainMaintenanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDomainMaintenanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDomainMaintenanceResponseUnmarshaller.Instance;

            return InvokeAsync<StartDomainMaintenanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartServiceSoftwareUpdate

        internal virtual StartServiceSoftwareUpdateResponse StartServiceSoftwareUpdate(StartServiceSoftwareUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return Invoke<StartServiceSoftwareUpdateResponse>(request, options);
        }



        /// <summary>
        /// Schedules a service software update for an Amazon OpenSearch Service domain. For more
        /// information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/service-software.html">Service
        /// software updates in Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartServiceSoftwareUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartServiceSoftwareUpdate service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/StartServiceSoftwareUpdate">REST API Reference for StartServiceSoftwareUpdate Operation</seealso>
        public virtual Task<StartServiceSoftwareUpdateResponse> StartServiceSoftwareUpdateAsync(StartServiceSoftwareUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<StartServiceSoftwareUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataSource

        internal virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Updates a direct-query data source. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/direct-query-s3-creating.html">Working
        /// with Amazon OpenSearch Service data source integrations with Amazon S3</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DependencyFailureException">
        /// An exception for when a failure in one of the dependencies results in the service
        /// being unable to fetch details about the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainConfig

        internal virtual UpdateDomainConfigResponse UpdateDomainConfig(UpdateDomainConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainConfigResponse>(request, options);
        }



        /// <summary>
        /// Modifies the cluster configuration of the specified Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainConfig service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access a sub-resource that's either invalid or
        /// not supported.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdateDomainConfig">REST API Reference for UpdateDomainConfig Operation</seealso>
        public virtual Task<UpdateDomainConfigResponse> UpdateDomainConfigAsync(UpdateDomainConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePackage

        internal virtual UpdatePackageResponse UpdatePackage(UpdatePackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePackageResponseUnmarshaller.Instance;

            return Invoke<UpdatePackageResponse>(request, options);
        }



        /// <summary>
        /// Updates a package for use with Amazon OpenSearch Service domains. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdatePackage">REST API Reference for UpdatePackage Operation</seealso>
        public virtual Task<UpdatePackageResponse> UpdatePackageAsync(UpdatePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePackageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateScheduledAction

        internal virtual UpdateScheduledActionResponse UpdateScheduledAction(UpdateScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduledActionResponseUnmarshaller.Instance;

            return Invoke<UpdateScheduledActionResponse>(request, options);
        }



        /// <summary>
        /// Reschedules a planned domain configuration change for a later time. This change can
        /// be a scheduled <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/service-software.html">service
        /// software update</a> or a <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html#auto-tune-types">blue/green
        /// Auto-Tune enhancement</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateScheduledAction service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.SlotNotAvailableException">
        /// An exception for attempting to schedule a domain action during an unavailable time
        /// slot.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdateScheduledAction">REST API Reference for UpdateScheduledAction Operation</seealso>
        public virtual Task<UpdateScheduledActionResponse> UpdateScheduledActionAsync(UpdateScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduledActionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateScheduledActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVpcEndpoint

        internal virtual UpdateVpcEndpointResponse UpdateVpcEndpoint(UpdateVpcEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateVpcEndpointResponse>(request, options);
        }



        /// <summary>
        /// Modifies an Amazon OpenSearch Service-managed interface VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVpcEndpoint service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdateVpcEndpoint">REST API Reference for UpdateVpcEndpoint Operation</seealso>
        public virtual Task<UpdateVpcEndpointResponse> UpdateVpcEndpointAsync(UpdateVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVpcEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpgradeDomain

        internal virtual UpgradeDomainResponse UpgradeDomain(UpgradeDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpgradeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeDomainResponseUnmarshaller.Instance;

            return Invoke<UpgradeDomainResponse>(request, options);
        }



        /// <summary>
        /// Allows you to either upgrade your Amazon OpenSearch Service domain or perform an upgrade
        /// eligibility check to a compatible version of OpenSearch or Elasticsearch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpgradeDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpgradeDomain">REST API Reference for UpgradeDomain Operation</seealso>
        public virtual Task<UpgradeDomainResponse> UpgradeDomainAsync(UpgradeDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpgradeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeDomainResponseUnmarshaller.Instance;

            return InvokeAsync<UpgradeDomainResponse>(request, options, cancellationToken);
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonOpenSearchServiceEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}