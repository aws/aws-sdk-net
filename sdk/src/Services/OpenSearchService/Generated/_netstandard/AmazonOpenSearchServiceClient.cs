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

namespace Amazon.OpenSearchService
{
    /// <summary>
    /// Implementation for accessing OpenSearchService
    ///
    /// Amazon OpenSearch Configuration Service 
    /// <para>
    /// Use the Amazon OpenSearch configuration API to create, configure, and manage Amazon
    /// OpenSearch Service domains.
    /// </para>
    ///  
    /// <para>
    /// For sample code that uses the configuration API, see the <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/opensearch-configuration-samples.html">
    /// Amazon OpenSearch Service Developer Guide</a>. The guide also contains <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/request-signing.html">
    /// sample code for sending signed HTTP requests to the OpenSearch APIs</a>. 
    /// </para>
    ///  
    /// <para>
    /// The endpoint for configuration service requests is region-specific: es.<i>region</i>.amazonaws.com.
    /// For example, es.us-east-1.amazonaws.com. For a current list of supported regions and
    /// endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#service-regions"
    /// target="_blank">Regions and Endpoints</a>. 
    /// </para>
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


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
        /// Allows the remote domain owner to accept an inbound cross-cluster connection request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInboundConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptInboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
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
        
        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }



        /// <summary>
        /// Attaches tags to an existing domain. Tags are a set of case-sensitive key value pairs.
        /// An domain can have up to 10 tags. See <a href="http://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains.html#managedomains-awsresorcetagging"
        /// target="_blank"> Tagging Amazon OpenSearch Service domains</a> for more information.
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
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Associates a package with an Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// You can only perform this operation before the <code>AutomatedUpdateDate</code> and
        /// when the <code>UpdateStatus</code> is in the <code>PENDING_UPDATE</code> state.
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
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Creates a new Amazon OpenSearch Service domain. For more information, see <a href="http://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html"
        /// target="_blank">Creating and managing Amazon OpenSearch Service domains </a> in the
        /// <i>Amazon OpenSearch Service Developer Guide</i>.
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
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Creates a new cross-cluster connection from a local OpenSearch domain to a remote
        /// OpenSearch domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOutboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
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
        /// Create a package for use with Amazon OpenSearch Service domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        
        #region  DeleteDomain

        internal virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }



        /// <summary>
        /// Permanently deletes the specified domain and all of its data. Once a domain is deleted,
        /// it cannot be recovered.
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
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Allows the remote domain owner to delete an existing inbound cross-cluster connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
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
        /// Allows the local domain owner to delete an existing outbound cross-cluster connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOutboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
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
        /// Deletes the package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        
        #region  DescribeDomain

        internal virtual DescribeDomainResponse DescribeDomain(DescribeDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainResponse>(request, options);
        }



        /// <summary>
        /// Returns domain configuration information about the specified domain, including the
        /// domain ID, domain endpoint, and domain ARN.
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
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Provides scheduled Auto-Tune action details for the domain, such as Auto-Tune action
        /// type, description, severity, and scheduled date.
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
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Returns information about the current blue/green deployment happening on a domain,
        /// including a change ID, status, and progress stages.
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
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Provides cluster configuration information about the specified domain, such as the
        /// state, creation date, update version, and update date for cluster options.
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
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        
        #region  DescribeDomains

        internal virtual DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainsResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainsResponse>(request, options);
        }



        /// <summary>
        /// Returns domain configuration information about the specified domains, including the
        /// domain ID, domain endpoint, and domain ARN.
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
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        
        #region  DescribeInboundConnections

        internal virtual DescribeInboundConnectionsResponse DescribeInboundConnections(DescribeInboundConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInboundConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInboundConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeInboundConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the inbound cross-cluster connections for a remote domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInboundConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInboundConnections service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidPaginationTokenException">
        /// The request processing has failed because of invalid pagination token provided by
        /// customer. Returns an HTTP status code of 400.
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
        /// Describe the limits for a given instance type and OpenSearch or Elasticsearch version.
        /// When modifying an existing domain, specify the <code> <a>DomainName</a> </code> to
        /// see which limits you can modify.
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
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Lists all the outbound cross-cluster connections for a local domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOutboundConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOutboundConnections service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidPaginationTokenException">
        /// The request processing has failed because of invalid pagination token provided by
        /// customer. Returns an HTTP status code of 400.
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
        /// Describes all packages available to Amazon OpenSearch Service domains. Includes options
        /// for filtering, limiting the number of results, and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePackages service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Lists available reserved OpenSearch instance offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstanceOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstanceOfferings service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Returns information about reserved OpenSearch instances for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        
        #region  DissociatePackage

        internal virtual DissociatePackageResponse DissociatePackage(DissociatePackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DissociatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DissociatePackageResponseUnmarshaller.Instance;

            return Invoke<DissociatePackageResponse>(request, options);
        }



        /// <summary>
        /// Dissociates a package from the Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DissociatePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DissociatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Returns a list of upgrade-compatible versions of OpenSearch/Elasticsearch. You can
        /// optionally pass a <code> <a>DomainName</a> </code> to get all upgrade-compatible versions
        /// of OpenSearch/Elasticsearch for that specific domain.
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
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        
        #region  GetPackageVersionHistory

        internal virtual GetPackageVersionHistoryResponse GetPackageVersionHistory(GetPackageVersionHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPackageVersionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPackageVersionHistoryResponseUnmarshaller.Instance;

            return Invoke<GetPackageVersionHistoryResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of package versions, along with their creation time and commit message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPackageVersionHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPackageVersionHistory service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Retrieves the complete history of the last 10 upgrades performed on the domain.
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
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Retrieves the latest status of the last upgrade or upgrade eligibility check performed
        /// on the domain.
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
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        
        #region  ListDomainNames

        internal virtual ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return Invoke<ListDomainNamesResponse>(request, options);
        }



        /// <summary>
        /// Returns the names of all domains owned by the current user's account.
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
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Lists all Amazon OpenSearch Service domains associated with the package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainsForPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainsForPackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// 
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
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Lists all packages associated with the Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackagesForDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPackagesForDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }



        /// <summary>
        /// Returns all tags for the given domain.
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
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// List all supported versions of OpenSearch and Elasticsearch.
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
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        
        #region  PurchaseReservedInstanceOffering

        internal virtual PurchaseReservedInstanceOfferingResponse PurchaseReservedInstanceOffering(PurchaseReservedInstanceOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedInstanceOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedInstanceOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedInstanceOfferingResponse>(request, options);
        }



        /// <summary>
        /// Allows you to purchase reserved OpenSearch instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstanceOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseReservedInstanceOffering service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Allows the remote domain owner to reject an inbound cross-cluster connection request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectInboundConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectInboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
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
        /// Removes the specified set of tags from the given domain.
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
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        
        #region  StartServiceSoftwareUpdate

        internal virtual StartServiceSoftwareUpdateResponse StartServiceSoftwareUpdate(StartServiceSoftwareUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return Invoke<StartServiceSoftwareUpdateResponse>(request, options);
        }



        /// <summary>
        /// Schedules a service software update for an Amazon OpenSearch Service domain.
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
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        
        #region  UpdateDomainConfig

        internal virtual UpdateDomainConfigResponse UpdateDomainConfig(UpdateDomainConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainConfigResponse>(request, options);
        }



        /// <summary>
        /// Modifies the cluster configuration of the specified domain, such as setting the instance
        /// type and the number of instances.
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
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        /// Updates a package for use with Amazon OpenSearch Service domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        
        #region  UpgradeDomain

        internal virtual UpgradeDomainResponse UpgradeDomain(UpgradeDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpgradeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeDomainResponseUnmarshaller.Instance;

            return Invoke<UpgradeDomainResponse>(request, options);
        }



        /// <summary>
        /// Allows you to either upgrade your domain or perform an upgrade eligibility check to
        /// a compatible version of OpenSearch or Elasticsearch.
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
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
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
        
    }
}