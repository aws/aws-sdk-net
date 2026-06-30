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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CertificateManager.Model;
using Amazon.CertificateManager.Model.Internal.MarshallTransformations;
using Amazon.CertificateManager.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CertificateManager
{
    /// <summary>
    /// <para>Implementation for accessing CertificateManager</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Certificate Manager 
    /// <para>
    /// You can use Certificate Manager (ACM) to manage SSL/TLS certificates for your Amazon
    /// Web Services-based websites and applications. For more information about using ACM,
    /// see the <a href="https://docs.aws.amazon.com/acm/latest/userguide/">Certificate Manager
    /// User Guide</a>.
    /// 
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonCertificateManagerClient : AmazonServiceClient, IAmazonCertificateManager
    {
        private static IServiceMetadata serviceMetadata = new AmazonCertificateManagerMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with the credentials loaded from the application's
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
        public AmazonCertificateManagerClient()
            : base(new AmazonCertificateManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with the credentials loaded from the application's
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
        public AmazonCertificateManagerClient(RegionEndpoint region)
            : base(new AmazonCertificateManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(AmazonCertificateManagerConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCertificateManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonCertificateManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCertificateManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCertificateManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Credentials and an
        /// AmazonCertificateManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(AWSCredentials credentials, AmazonCertificateManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCertificateManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCertificateManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCertificateManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCertificateManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCertificateManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCertificateManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCertificateManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCertificateManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ICertificateManagerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICertificateManagerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CertificateManagerPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCertificateManagerEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCertificateManagerAuthSchemeHandler());
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


        #region  AddTagsToCertificate

        internal virtual AddTagsToCertificateResponse AddTagsToCertificate(AddTagsToCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToCertificateResponseUnmarshaller.Instance;

            return Invoke<AddTagsToCertificateResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more tags to an ACM certificate. Tags are labels that you can use to identify
        /// and organize your Amazon Web Services resources. Each tag consists of a <c>key</c>
        /// and an optional <c>value</c>. You specify the certificate on input by its Amazon Resource
        /// Name (ARN). You specify the tag by using a key-value pair. 
        /// 
        ///  <note> 
        /// <para>
        /// This action applies only to the <c>certificate</c> resource type. For all other ACM
        /// resource types, use <a>TagResource</a> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can apply a tag to just one certificate if you want to identify a specific characteristic
        /// of that certificate, or you can apply the same tag to multiple certificates if you
        /// want to filter for a common relationship among those certificates. Similarly, you
        /// can apply the same tag to multiple resources if you want to specify a relationship
        /// among those resources. For example, you can add the same tag to an ACM certificate
        /// and an Elastic Load Balancing load balancer to indicate that they are both used by
        /// the same website. For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/tags.html">Tagging
        /// ACM certificates</a>. 
        /// </para>
        ///  
        /// <para>
        /// To remove one or more tags, use the <a>RemoveTagsFromCertificate</a> action. To view
        /// all of the tags that have been applied to the certificate, use the <a>ListTagsForCertificate</a>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <c>aws:</c>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/AddTagsToCertificate">REST API Reference for AddTagsToCertificate Operation</seealso>
        public virtual Task<AddTagsToCertificateResponse> AddTagsToCertificateAsync(AddTagsToCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToCertificateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAcmeDomainValidation

        internal virtual CreateAcmeDomainValidationResponse CreateAcmeDomainValidation(CreateAcmeDomainValidationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAcmeDomainValidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAcmeDomainValidationResponseUnmarshaller.Instance;

            return Invoke<CreateAcmeDomainValidationResponse>(request, options);
        }



        /// <summary>
        /// Creates a domain validation for an ACME endpoint. Domain validations authorize the
        /// endpoint to issue certificates for specified domain names. You configure prevalidation
        /// to prove domain ownership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAcmeDomainValidation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAcmeDomainValidation service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/CreateAcmeDomainValidation">REST API Reference for CreateAcmeDomainValidation Operation</seealso>
        public virtual Task<CreateAcmeDomainValidationResponse> CreateAcmeDomainValidationAsync(CreateAcmeDomainValidationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAcmeDomainValidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAcmeDomainValidationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAcmeDomainValidationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAcmeEndpoint

        internal virtual CreateAcmeEndpointResponse CreateAcmeEndpoint(CreateAcmeEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAcmeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAcmeEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateAcmeEndpointResponse>(request, options);
        }



        /// <summary>
        /// Creates an ACME endpoint, which is a managed ACME server with a unique endpoint URL.
        /// After creation, ACME clients can use the endpoint URL to automate certificate issuance
        /// using the ACME protocol.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAcmeEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAcmeEndpoint service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/CreateAcmeEndpoint">REST API Reference for CreateAcmeEndpoint Operation</seealso>
        public virtual Task<CreateAcmeEndpointResponse> CreateAcmeEndpointAsync(CreateAcmeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAcmeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAcmeEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAcmeEndpointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAcmeExternalAccountBinding

        internal virtual CreateAcmeExternalAccountBindingResponse CreateAcmeExternalAccountBinding(CreateAcmeExternalAccountBindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAcmeExternalAccountBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAcmeExternalAccountBindingResponseUnmarshaller.Instance;

            return Invoke<CreateAcmeExternalAccountBindingResponse>(request, options);
        }



        /// <summary>
        /// Creates an external account binding (EAB) for an ACME endpoint. An EAB provides credentials
        /// that authorize an ACME client to register an account with the endpoint. Each EAB is
        /// associated with an IAM role that controls what certificate operations the ACME client
        /// can perform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAcmeExternalAccountBinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAcmeExternalAccountBinding service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/CreateAcmeExternalAccountBinding">REST API Reference for CreateAcmeExternalAccountBinding Operation</seealso>
        public virtual Task<CreateAcmeExternalAccountBindingResponse> CreateAcmeExternalAccountBindingAsync(CreateAcmeExternalAccountBindingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAcmeExternalAccountBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAcmeExternalAccountBindingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAcmeExternalAccountBindingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAcmeDomainValidation

        internal virtual DeleteAcmeDomainValidationResponse DeleteAcmeDomainValidation(DeleteAcmeDomainValidationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAcmeDomainValidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAcmeDomainValidationResponseUnmarshaller.Instance;

            return Invoke<DeleteAcmeDomainValidationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a domain validation. After deletion, the ACME endpoint can no longer issue
        /// certificates for the associated domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAcmeDomainValidation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAcmeDomainValidation service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteAcmeDomainValidation">REST API Reference for DeleteAcmeDomainValidation Operation</seealso>
        public virtual Task<DeleteAcmeDomainValidationResponse> DeleteAcmeDomainValidationAsync(DeleteAcmeDomainValidationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAcmeDomainValidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAcmeDomainValidationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAcmeDomainValidationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAcmeEndpoint

        internal virtual DeleteAcmeEndpointResponse DeleteAcmeEndpoint(DeleteAcmeEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAcmeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAcmeEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteAcmeEndpointResponse>(request, options);
        }



        /// <summary>
        /// Deletes an ACME endpoint. After deletion, the endpoint URL is no longer accessible
        /// and ACME clients cannot issue certificates through it. Any existing external account
        /// bindings and domain validations associated with the endpoint are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAcmeEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAcmeEndpoint service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteAcmeEndpoint">REST API Reference for DeleteAcmeEndpoint Operation</seealso>
        public virtual Task<DeleteAcmeEndpointResponse> DeleteAcmeEndpointAsync(DeleteAcmeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAcmeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAcmeEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAcmeEndpointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAcmeExternalAccountBinding

        internal virtual DeleteAcmeExternalAccountBindingResponse DeleteAcmeExternalAccountBinding(DeleteAcmeExternalAccountBindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAcmeExternalAccountBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAcmeExternalAccountBindingResponseUnmarshaller.Instance;

            return Invoke<DeleteAcmeExternalAccountBindingResponse>(request, options);
        }



        /// <summary>
        /// Deletes an external account binding. Previously fetched credentials for this binding
        /// will no longer be usable for account registration. A deleted binding cannot be recovered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAcmeExternalAccountBinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAcmeExternalAccountBinding service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteAcmeExternalAccountBinding">REST API Reference for DeleteAcmeExternalAccountBinding Operation</seealso>
        public virtual Task<DeleteAcmeExternalAccountBindingResponse> DeleteAcmeExternalAccountBindingAsync(DeleteAcmeExternalAccountBindingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAcmeExternalAccountBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAcmeExternalAccountBindingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAcmeExternalAccountBindingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCertificate

        internal virtual DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteCertificateResponse>(request, options);
        }


        /// <summary>
        /// Deletes a certificate and its associated private key. If this action succeeds, the
        /// certificate is not available for use by Amazon Web Services services integrated with
        /// ACM. Deleting a certificate is eventually consistent. The may be a short delay before
        /// the certificate no longer appears in the list that can be displayed by calling the
        /// <a>ListCertificates</a> action or be retrieved by calling the <a>GetCertificate</a>
        /// action.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an ACM certificate that is being used by another Amazon Web Services
        /// service. To delete a certificate that is in use, you must first remove the certificate
        /// association using the console or the CLI for the associated service.
        /// </para>
        ///  
        /// <para>
        /// Deleting a certificate issued by a private certificate authority (CA) has no effect
        /// on the CA. You will continue to be charged for the CA until it is deleted. For more
        /// information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PCADeleteCA.html">
        /// Deleting Your Private CA</a> in the <i>Private Certificate Authority User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You cannot delete a certificate with a <c>CertificateKeyPairOrigin</c> of <c>ACME</c>.
        /// ACM automatically deletes these certificates 1 year after they expire.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deleting a certificate issued by a private certificate authority (CA) has no effect
        /// on the CA. You will continue to be charged for the CA until it is deleted. For more
        /// information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PCADeleteCA.html">Deleting
        /// your private CA</a> in the <i>Amazon Web Services Private Certificate Authority User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="certificateArn">String that contains the ARN of the ACM certificate to be deleted. This must be of the form:  <c>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</c>  For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs)</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another Amazon Web Services service in the caller's account.
        /// Remove the association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual Task<DeleteCertificateResponse> DeleteCertificateAsync(string certificateArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteCertificateRequest();
            request.CertificateArn = certificateArn;
            return DeleteCertificateAsync(request, cancellationToken);
        }



        /// <summary>
        /// Deletes a certificate and its associated private key. If this action succeeds, the
        /// certificate is not available for use by Amazon Web Services services integrated with
        /// ACM. Deleting a certificate is eventually consistent. The may be a short delay before
        /// the certificate no longer appears in the list that can be displayed by calling the
        /// <a>ListCertificates</a> action or be retrieved by calling the <a>GetCertificate</a>
        /// action.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an ACM certificate that is being used by another Amazon Web Services
        /// service. To delete a certificate that is in use, you must first remove the certificate
        /// association using the console or the CLI for the associated service.
        /// </para>
        ///  
        /// <para>
        /// Deleting a certificate issued by a private certificate authority (CA) has no effect
        /// on the CA. You will continue to be charged for the CA until it is deleted. For more
        /// information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PCADeleteCA.html">
        /// Deleting Your Private CA</a> in the <i>Private Certificate Authority User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You cannot delete a certificate with a <c>CertificateKeyPairOrigin</c> of <c>ACME</c>.
        /// ACM automatically deletes these certificates 1 year after they expire.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deleting a certificate issued by a private certificate authority (CA) has no effect
        /// on the CA. You will continue to be charged for the CA until it is deleted. For more
        /// information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PCADeleteCA.html">Deleting
        /// your private CA</a> in the <i>Amazon Web Services Private Certificate Authority User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another Amazon Web Services service in the caller's account.
        /// Remove the association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCertificateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAcmeAccount

        internal virtual DescribeAcmeAccountResponse DescribeAcmeAccount(DescribeAcmeAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAcmeAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcmeAccountResponseUnmarshaller.Instance;

            return Invoke<DescribeAcmeAccountResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed metadata about the specified ACME account, including its status,
        /// public key thumbprint, and associated external account binding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcmeAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAcmeAccount service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeAcmeAccount">REST API Reference for DescribeAcmeAccount Operation</seealso>
        public virtual Task<DescribeAcmeAccountResponse> DescribeAcmeAccountAsync(DescribeAcmeAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAcmeAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcmeAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAcmeAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAcmeDomainValidation

        internal virtual DescribeAcmeDomainValidationResponse DescribeAcmeDomainValidation(DescribeAcmeDomainValidationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAcmeDomainValidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcmeDomainValidationResponseUnmarshaller.Instance;

            return Invoke<DescribeAcmeDomainValidationResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed metadata about the specified domain validation, including its status,
        /// domain scope, and DNS resource records required for validation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcmeDomainValidation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAcmeDomainValidation service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeAcmeDomainValidation">REST API Reference for DescribeAcmeDomainValidation Operation</seealso>
        public virtual Task<DescribeAcmeDomainValidationResponse> DescribeAcmeDomainValidationAsync(DescribeAcmeDomainValidationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAcmeDomainValidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcmeDomainValidationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAcmeDomainValidationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAcmeEndpoint

        internal virtual DescribeAcmeEndpointResponse DescribeAcmeEndpoint(DescribeAcmeEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAcmeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcmeEndpointResponseUnmarshaller.Instance;

            return Invoke<DescribeAcmeEndpointResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed metadata about the specified ACME endpoint, including its status,
        /// URL, authorization behavior, and certificate authority configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcmeEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAcmeEndpoint service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeAcmeEndpoint">REST API Reference for DescribeAcmeEndpoint Operation</seealso>
        public virtual Task<DescribeAcmeEndpointResponse> DescribeAcmeEndpointAsync(DescribeAcmeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAcmeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcmeEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAcmeEndpointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAcmeExternalAccountBinding

        internal virtual DescribeAcmeExternalAccountBindingResponse DescribeAcmeExternalAccountBinding(DescribeAcmeExternalAccountBindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAcmeExternalAccountBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcmeExternalAccountBindingResponseUnmarshaller.Instance;

            return Invoke<DescribeAcmeExternalAccountBindingResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed metadata about the specified external account binding, including
        /// the associated IAM role, expiration time, and usage history.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcmeExternalAccountBinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAcmeExternalAccountBinding service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeAcmeExternalAccountBinding">REST API Reference for DescribeAcmeExternalAccountBinding Operation</seealso>
        public virtual Task<DescribeAcmeExternalAccountBindingResponse> DescribeAcmeExternalAccountBindingAsync(DescribeAcmeExternalAccountBindingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAcmeExternalAccountBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcmeExternalAccountBindingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAcmeExternalAccountBindingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeCertificate

        internal virtual DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificateResponse>(request, options);
        }


        /// <summary>
        /// Returns detailed metadata about the specified ACM certificate.
        /// 
        ///  
        /// <para>
        /// If you have just created a certificate using the <c>RequestCertificate</c> action,
        /// there is a delay of several seconds before you can retrieve information about it.
        /// </para>
        /// </summary>
        /// <param name="certificateArn">The Amazon Resource Name (ARN) of the ACM certificate. The ARN must have the following form:  <c>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</c>  For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs)</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual Task<DescribeCertificateResponse> DescribeCertificateAsync(string certificateArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeCertificateRequest();
            request.CertificateArn = certificateArn;
            return DescribeCertificateAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns detailed metadata about the specified ACM certificate.
        /// 
        ///  
        /// <para>
        /// If you have just created a certificate using the <c>RequestCertificate</c> action,
        /// there is a delay of several seconds before you can retrieve information about it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual Task<DescribeCertificateResponse> DescribeCertificateAsync(DescribeCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCertificateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportCertificate

        internal virtual ExportCertificateResponse ExportCertificate(ExportCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportCertificateResponseUnmarshaller.Instance;

            return Invoke<ExportCertificateResponse>(request, options);
        }



        /// <summary>
        /// Exports a private certificate issued by a private certificate authority (CA) or a
        /// public certificate for use anywhere. The exported file contains the certificate, the
        /// certificate chain, and the encrypted private key associated with the public key that
        /// is embedded in the certificate. For security, you must assign a passphrase for the
        /// private key when exporting it. 
        /// 
        ///  
        /// <para>
        /// For information about exporting and formatting a certificate using the ACM console
        /// or CLI, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/export-private.html">Export
        /// a private certificate</a> and <a href="https://docs.aws.amazon.com/acm/latest/userguide/export-public-certificate">Export
        /// a public certificate</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// ACM public certificates created prior to June 17, 2025 cannot be exported.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ExportCertificate">REST API Reference for ExportCertificate Operation</seealso>
        public virtual Task<ExportCertificateResponse> ExportCertificateAsync(ExportCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<ExportCertificateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAccountConfiguration

        internal virtual GetAccountConfigurationResponse GetAccountConfiguration(GetAccountConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetAccountConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Returns the account configuration options associated with an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountConfiguration service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetAccountConfiguration">REST API Reference for GetAccountConfiguration Operation</seealso>
        public virtual Task<GetAccountConfigurationResponse> GetAccountConfigurationAsync(GetAccountConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAcmeExternalAccountBindingCredentials

        internal virtual GetAcmeExternalAccountBindingCredentialsResponse GetAcmeExternalAccountBindingCredentials(GetAcmeExternalAccountBindingCredentialsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAcmeExternalAccountBindingCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAcmeExternalAccountBindingCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetAcmeExternalAccountBindingCredentialsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the key ID and MAC key credentials for an external account binding. These
        /// credentials are used by ACME clients during account registration to bind to the endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAcmeExternalAccountBindingCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAcmeExternalAccountBindingCredentials service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetAcmeExternalAccountBindingCredentials">REST API Reference for GetAcmeExternalAccountBindingCredentials Operation</seealso>
        public virtual Task<GetAcmeExternalAccountBindingCredentialsResponse> GetAcmeExternalAccountBindingCredentialsAsync(GetAcmeExternalAccountBindingCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAcmeExternalAccountBindingCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAcmeExternalAccountBindingCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAcmeExternalAccountBindingCredentialsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCertificate

        internal virtual GetCertificateResponse GetCertificate(GetCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCertificateResponseUnmarshaller.Instance;

            return Invoke<GetCertificateResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a certificate and its certificate chain. The certificate may be either a
        /// public or private certificate issued using the ACM <c>RequestCertificate</c> action,
        /// or a certificate imported into ACM using the <c>ImportCertificate</c> action. The
        /// chain consists of the certificate of the issuing CA and the intermediate certificates
        /// of any other subordinate CAs. All of the certificates are base64 encoded. You can
        /// use <a href="https://wiki.openssl.org/index.php/Command_Line_Utilities">OpenSSL</a>
        /// to decode the certificates and inspect individual fields.
        /// </summary>
        /// <param name="certificateArn">String that contains a certificate ARN in the following format:  <c>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</c>  For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs)</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        public virtual Task<GetCertificateResponse> GetCertificateAsync(string certificateArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetCertificateRequest();
            request.CertificateArn = certificateArn;
            return GetCertificateAsync(request, cancellationToken);
        }



        /// <summary>
        /// Retrieves a certificate and its certificate chain. The certificate may be either a
        /// public or private certificate issued using the ACM <c>RequestCertificate</c> action,
        /// or a certificate imported into ACM using the <c>ImportCertificate</c> action. The
        /// chain consists of the certificate of the issuing CA and the intermediate certificates
        /// of any other subordinate CAs. All of the certificates are base64 encoded. You can
        /// use <a href="https://wiki.openssl.org/index.php/Command_Line_Utilities">OpenSSL</a>
        /// to decode the certificates and inspect individual fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        public virtual Task<GetCertificateResponse> GetCertificateAsync(GetCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<GetCertificateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ImportCertificate

        internal virtual ImportCertificateResponse ImportCertificate(ImportCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return Invoke<ImportCertificateResponse>(request, options);
        }



        /// <summary>
        /// Imports a certificate into Certificate Manager (ACM) to use with services that are
        /// integrated with ACM. Note that <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-services.html">integrated
        /// services</a> allow only certificate types and keys they support to be associated with
        /// their resources. Further, their support differs depending on whether the certificate
        /// is imported into IAM or into ACM. For more information, see the documentation for
        /// each service. For more information about importing certificates into ACM, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
        /// Certificates</a> in the <i>Certificate Manager User Guide</i>. 
        /// 
        ///  <note> 
        /// <para>
        /// ACM does not provide <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
        /// renewal</a> for certificates that you import.
        /// </para>
        ///  </note> 
        /// <para>
        /// Note the following guidelines when importing third party certificates:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must enter the private key that matches the certificate you are importing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The private key must be unencrypted. You cannot import a private key that is protected
        /// by a password or a passphrase.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The private key must be no larger than 5 KB (5,120 bytes).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The certificate, private key, and certificate chain must be PEM-encoded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The current time must be between the <c>Not Before</c> and <c>Not After</c> certificate
        /// fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Issuer</c> field must not be empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The OCSP authority URL, if present, must not exceed 1000 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To import a new certificate, omit the <c>CertificateArn</c> argument. Include this
        /// argument only when you want to replace a previously imported certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you import a certificate by using the CLI, you must specify the certificate,
        /// the certificate chain, and the private key by their file names preceded by <c>fileb://</c>.
        /// For example, you can specify a certificate saved in the <c>C:\temp</c> folder as <c>fileb://C:\temp\certificate_to_import.pem</c>.
        /// If you are making an HTTP or HTTPS Query request, include these arguments as BLOBs.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you import a certificate by using an SDK, you must specify the certificate, the
        /// certificate chain, and the private key files in the manner required by the programming
        /// language you're using. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cryptographic algorithm of an imported certificate must match the algorithm of
        /// the signing CA. For example, if the signing CA key type is RSA, then the certificate
        /// key type must also be RSA.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation returns the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the imported certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <c>aws:</c>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        public virtual Task<ImportCertificateResponse> ImportCertificateAsync(ImportCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<ImportCertificateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAcmeAccounts

        internal virtual ListAcmeAccountsResponse ListAcmeAccounts(ListAcmeAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAcmeAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcmeAccountsResponseUnmarshaller.Instance;

            return Invoke<ListAcmeAccountsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of ACME accounts registered with the specified ACME endpoint. ACME
        /// accounts are created when clients use external account binding credentials to register.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAcmeAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAcmeAccounts service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListAcmeAccounts">REST API Reference for ListAcmeAccounts Operation</seealso>
        public virtual Task<ListAcmeAccountsResponse> ListAcmeAccountsAsync(ListAcmeAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAcmeAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcmeAccountsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAcmeAccountsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAcmeDomainValidations

        internal virtual ListAcmeDomainValidationsResponse ListAcmeDomainValidations(ListAcmeDomainValidationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAcmeDomainValidationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcmeDomainValidationsResponseUnmarshaller.Instance;

            return Invoke<ListAcmeDomainValidationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of domain validations for the specified ACME endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAcmeDomainValidations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAcmeDomainValidations service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListAcmeDomainValidations">REST API Reference for ListAcmeDomainValidations Operation</seealso>
        public virtual Task<ListAcmeDomainValidationsResponse> ListAcmeDomainValidationsAsync(ListAcmeDomainValidationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAcmeDomainValidationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcmeDomainValidationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAcmeDomainValidationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAcmeEndpoints

        internal virtual ListAcmeEndpointsResponse ListAcmeEndpoints(ListAcmeEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAcmeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcmeEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListAcmeEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of ACME endpoints in your account. Use this operation to view all
        /// configured ACME endpoints and their current status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAcmeEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAcmeEndpoints service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListAcmeEndpoints">REST API Reference for ListAcmeEndpoints Operation</seealso>
        public virtual Task<ListAcmeEndpointsResponse> ListAcmeEndpointsAsync(ListAcmeEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAcmeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcmeEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAcmeEndpointsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAcmeExternalAccountBindings

        internal virtual ListAcmeExternalAccountBindingsResponse ListAcmeExternalAccountBindings(ListAcmeExternalAccountBindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAcmeExternalAccountBindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcmeExternalAccountBindingsResponseUnmarshaller.Instance;

            return Invoke<ListAcmeExternalAccountBindingsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of external account bindings for the specified ACME endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAcmeExternalAccountBindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAcmeExternalAccountBindings service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListAcmeExternalAccountBindings">REST API Reference for ListAcmeExternalAccountBindings Operation</seealso>
        public virtual Task<ListAcmeExternalAccountBindingsResponse> ListAcmeExternalAccountBindingsAsync(ListAcmeExternalAccountBindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAcmeExternalAccountBindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcmeExternalAccountBindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAcmeExternalAccountBindingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCertificates

        internal virtual ListCertificatesResponse ListCertificates()
        {
            return ListCertificates(new ListCertificatesRequest());
        }
        internal virtual ListCertificatesResponse ListCertificates(ListCertificatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListCertificatesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of certificate ARNs and domain names. You can request that only certificates
        /// that match a specific status be listed. You can also filter by specific attributes
        /// of the certificate. Default filtering returns only <c>RSA_2048</c> certificates. For
        /// more information, see <a>Filters</a>.
        /// 
        ///  <note> 
        /// <para>
        /// By default, this action does not return certificates with a <c>CertificateKeyPairOrigin</c>
        /// of <c>ACME</c>. To include ACME certificates, specify <c>ACME</c> in the <c>CertificateKeyPairOrigins</c>
        /// filter.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArgsException">
        /// One or more of request parameters specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual Task<ListCertificatesResponse> ListCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListCertificatesAsync(new ListCertificatesRequest(), cancellationToken);
        }



        /// <summary>
        /// Retrieves a list of certificate ARNs and domain names. You can request that only certificates
        /// that match a specific status be listed. You can also filter by specific attributes
        /// of the certificate. Default filtering returns only <c>RSA_2048</c> certificates. For
        /// more information, see <a>Filters</a>.
        /// 
        ///  <note> 
        /// <para>
        /// By default, this action does not return certificates with a <c>CertificateKeyPairOrigin</c>
        /// of <c>ACME</c>. To include ACME certificates, specify <c>ACME</c> in the <c>CertificateKeyPairOrigins</c>
        /// filter.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArgsException">
        /// One or more of request parameters specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCertificatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForCertificate

        internal virtual ListTagsForCertificateResponse ListTagsForCertificate(ListTagsForCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForCertificateResponseUnmarshaller.Instance;

            return Invoke<ListTagsForCertificateResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags that have been applied to the ACM certificate. Use the certificate's
        /// Amazon Resource Name (ARN) to specify the certificate. To add a tag to an ACM certificate,
        /// use the <a>AddTagsToCertificate</a> action. To delete a tag, use the <a>RemoveTagsFromCertificate</a>
        /// action. 
        /// 
        ///  <note> 
        /// <para>
        /// This action applies only to the <c>certificate</c> resource type. For all other ACM
        /// resource types, use <a>ListTagsForResource</a> instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListTagsForCertificate">REST API Reference for ListTagsForCertificate Operation</seealso>
        public virtual Task<ListTagsForCertificateResponse> ListTagsForCertificateAsync(ListTagsForCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForCertificateResponse>(request, options, cancellationToken);
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
        /// Lists the tags associated with an ACM resource.
        /// 
        ///  <note> 
        /// <para>
        /// Use this action for all ACM resource types except the <c>certificate</c> resource
        /// type. For certificate resources, use <a>ListTagsForCertificate</a> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// To add one or more tags, use the <a>TagResource</a> action. To remove one or more
        /// tags, use the <a>UntagResource</a> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutAccountConfiguration

        internal virtual PutAccountConfigurationResponse PutAccountConfiguration(PutAccountConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutAccountConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Adds or modifies account-level configurations in ACM. 
        /// 
        ///  
        /// <para>
        /// The supported configuration option is <c>DaysBeforeExpiry</c>. This option specifies
        /// the number of days prior to certificate expiration when ACM starts generating <c>EventBridge</c>
        /// events. ACM sends one event per day per certificate until the certificate expires.
        /// By default, accounts receive events starting 45 days before certificate expiration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountConfiguration service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/PutAccountConfiguration">REST API Reference for PutAccountConfiguration Operation</seealso>
        public virtual Task<PutAccountConfigurationResponse> PutAccountConfigurationAsync(PutAccountConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutAccountConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveTagsFromCertificate

        internal virtual RemoveTagsFromCertificateResponse RemoveTagsFromCertificate(RemoveTagsFromCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromCertificateResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromCertificateResponse>(request, options);
        }



        /// <summary>
        /// Remove one or more tags from an ACM certificate. A tag consists of a key-value pair.
        /// If you do not specify the value portion of the tag when calling this function, the
        /// tag will be removed regardless of value. If you specify a value, the tag is removed
        /// only if it is associated with the specified value. 
        /// 
        ///  <note> 
        /// <para>
        /// This action applies only to the <c>certificate</c> resource type. For all other ACM
        /// resource types, use <a>UntagResource</a> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// To add tags to a certificate, use the <a>AddTagsToCertificate</a> action. To view
        /// all of the tags that have been applied to a specific ACM certificate, use the <a>ListTagsForCertificate</a>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <c>aws:</c>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RemoveTagsFromCertificate">REST API Reference for RemoveTagsFromCertificate Operation</seealso>
        public virtual Task<RemoveTagsFromCertificateResponse> RemoveTagsFromCertificateAsync(RemoveTagsFromCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromCertificateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RenewCertificate

        internal virtual RenewCertificateResponse RenewCertificate(RenewCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RenewCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenewCertificateResponseUnmarshaller.Instance;

            return Invoke<RenewCertificateResponse>(request, options);
        }



        /// <summary>
        /// Renews an <a href="https://docs.aws.amazon.com/acm/latest/userguide/managed-renewal.html">eligible
        /// ACM certificate</a>. In order to renew your Amazon Web Services Private CA certificates
        /// with ACM, you must first <a href="https://docs.aws.amazon.com/privateca/latest/userguide/assign-permissions.html#PcaPermissions">grant
        /// the ACM service principal permission to do so</a>. For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/managed-renewal.html">Testing
        /// Managed Renewal</a> in the ACM User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenewCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RenewCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RenewCertificate">REST API Reference for RenewCertificate Operation</seealso>
        public virtual Task<RenewCertificateResponse> RenewCertificateAsync(RenewCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RenewCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenewCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<RenewCertificateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RequestCertificate

        internal virtual RequestCertificateResponse RequestCertificate(RequestCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RequestCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestCertificateResponseUnmarshaller.Instance;

            return Invoke<RequestCertificateResponse>(request, options);
        }


        /// <summary>
        /// Requests an ACM certificate for use with other Amazon Web Services services. To request
        /// an ACM certificate, you must specify a fully qualified domain name (FQDN) in the <c>DomainName</c>
        /// parameter. You can also specify additional FQDNs in the <c>SubjectAlternativeNames</c>
        /// parameter. 
        /// 
        ///  
        /// <para>
        /// If you are requesting a private certificate, domain validation is not required. If
        /// you are requesting a public certificate, each domain name that you specify must be
        /// validated to verify that you own or control the domain. You can use <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-dns.html">DNS
        /// validation</a> or <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-email.html">email
        /// validation</a>. We recommend that you use DNS validation.
        /// </para>
        ///  <note> 
        /// <para>
        /// ACM behavior differs from the <a href="https://datatracker.ietf.org/doc/html/rfc6125#appendix-B.2">RFC
        /// 6125</a> specification of the certificate validation process. ACM first checks for
        /// a Subject Alternative Name, and, if it finds one, ignores the common name (CN).
        /// </para>
        ///  </note> 
        /// <para>
        /// After successful completion of the <c>RequestCertificate</c> action, there is a delay
        /// of several seconds before you can retrieve information about the new certificate.
        /// </para>
        /// </summary>
        /// <param name="domainName">Fully qualified domain name (FQDN), such as www.example.com, that you want to secure with an ACM certificate. Use an asterisk (*) to create a wildcard certificate that protects several sites in the same domain. For example, *.example.com protects www.example.com, site.example.com, and images.example.com.  In compliance with <a href="https://datatracker.ietf.org/doc/html/rfc5280">RFC 5280</a>, the length of the domain name (technically, the Common Name) that you provide cannot exceed 64 octets (characters), including periods. To add a longer domain name, specify it in the Subject Alternative Name field, which supports names up to 253 octets in length. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <c>aws:</c>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        public virtual Task<RequestCertificateResponse> RequestCertificateAsync(string domainName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RequestCertificateRequest();
            request.DomainName = domainName;
            return RequestCertificateAsync(request, cancellationToken);
        }



        /// <summary>
        /// Requests an ACM certificate for use with other Amazon Web Services services. To request
        /// an ACM certificate, you must specify a fully qualified domain name (FQDN) in the <c>DomainName</c>
        /// parameter. You can also specify additional FQDNs in the <c>SubjectAlternativeNames</c>
        /// parameter. 
        /// 
        ///  
        /// <para>
        /// If you are requesting a private certificate, domain validation is not required. If
        /// you are requesting a public certificate, each domain name that you specify must be
        /// validated to verify that you own or control the domain. You can use <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-dns.html">DNS
        /// validation</a> or <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-email.html">email
        /// validation</a>. We recommend that you use DNS validation.
        /// </para>
        ///  <note> 
        /// <para>
        /// ACM behavior differs from the <a href="https://datatracker.ietf.org/doc/html/rfc6125#appendix-B.2">RFC
        /// 6125</a> specification of the certificate validation process. ACM first checks for
        /// a Subject Alternative Name, and, if it finds one, ignores the common name (CN).
        /// </para>
        ///  </note> 
        /// <para>
        /// After successful completion of the <c>RequestCertificate</c> action, there is a delay
        /// of several seconds before you can retrieve information about the new certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidParameterException">
        /// An input parameter was invalid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <c>aws:</c>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TagPolicyException">
        /// A specified tag did not comply with an existing tag policy and was rejected.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        public virtual Task<RequestCertificateResponse> RequestCertificateAsync(RequestCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RequestCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<RequestCertificateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ResendValidationEmail

        internal virtual ResendValidationEmailResponse ResendValidationEmail(ResendValidationEmailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResendValidationEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendValidationEmailResponseUnmarshaller.Instance;

            return Invoke<ResendValidationEmailResponse>(request, options);
        }



        /// <summary>
        /// Resends the email that requests domain ownership validation. The domain owner or an
        /// authorized representative must approve the ACM certificate before it can be issued.
        /// The certificate can be approved by clicking a link in the mail to navigate to the
        /// Amazon certificate approval website and then clicking <b>I Approve</b>. However, the
        /// validation email can be blocked by spam filters. Therefore, if you do not receive
        /// the original mail, you can request that the mail be resent within 72 hours of requesting
        /// the ACM certificate. If more than 72 hours have elapsed since your original request
        /// or since your last attempt to resend validation mail, you must request a new certificate.
        /// For more information about setting up your contact email addresses, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/setup-email.html">Configure
        /// Email for your Domain</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendValidationEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResendValidationEmail service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidStateException">
        /// Processing has reached an invalid state.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ResendValidationEmail">REST API Reference for ResendValidationEmail Operation</seealso>
        public virtual Task<ResendValidationEmailResponse> ResendValidationEmailAsync(ResendValidationEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResendValidationEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendValidationEmailResponseUnmarshaller.Instance;

            return InvokeAsync<ResendValidationEmailResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RevokeAcmeAccount

        internal virtual RevokeAcmeAccountResponse RevokeAcmeAccount(RevokeAcmeAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeAcmeAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeAcmeAccountResponseUnmarshaller.Instance;

            return Invoke<RevokeAcmeAccountResponse>(request, options);
        }



        /// <summary>
        /// Revokes an ACME account, preventing it from requesting or revoking certificates. This
        /// operation is irreversible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeAcmeAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeAcmeAccount service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RevokeAcmeAccount">REST API Reference for RevokeAcmeAccount Operation</seealso>
        public virtual Task<RevokeAcmeAccountResponse> RevokeAcmeAccountAsync(RevokeAcmeAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeAcmeAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeAcmeAccountResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeAcmeAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RevokeAcmeExternalAccountBinding

        internal virtual RevokeAcmeExternalAccountBindingResponse RevokeAcmeExternalAccountBinding(RevokeAcmeExternalAccountBindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeAcmeExternalAccountBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeAcmeExternalAccountBindingResponseUnmarshaller.Instance;

            return Invoke<RevokeAcmeExternalAccountBindingResponse>(request, options);
        }



        /// <summary>
        /// Revokes an external account binding, preventing new ACME accounts from being registered
        /// using this binding. Existing ACME accounts that were previously registered using the
        /// binding are not affected and must be revoked separately.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeAcmeExternalAccountBinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeAcmeExternalAccountBinding service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RevokeAcmeExternalAccountBinding">REST API Reference for RevokeAcmeExternalAccountBinding Operation</seealso>
        public virtual Task<RevokeAcmeExternalAccountBindingResponse> RevokeAcmeExternalAccountBindingAsync(RevokeAcmeExternalAccountBindingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeAcmeExternalAccountBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeAcmeExternalAccountBindingResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeAcmeExternalAccountBindingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RevokeCertificate

        internal virtual RevokeCertificateResponse RevokeCertificate(RevokeCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeCertificateResponseUnmarshaller.Instance;

            return Invoke<RevokeCertificateResponse>(request, options);
        }



        /// <summary>
        /// Revokes a public ACM certificate. You can only revoke certificates that have been
        /// previously exported.
        /// 
        ///  <important> 
        /// <para>
        /// Once a certificate is revoked, you cannot reuse the certificate. Revoking a certificate
        /// is permanent.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another Amazon Web Services service in the caller's account.
        /// Remove the association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RevokeCertificate">REST API Reference for RevokeCertificate Operation</seealso>
        public virtual Task<RevokeCertificateResponse> RevokeCertificateAsync(RevokeCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeCertificateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchCertificates

        internal virtual SearchCertificatesResponse SearchCertificates(SearchCertificatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchCertificatesResponseUnmarshaller.Instance;

            return Invoke<SearchCertificatesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of certificates matching search criteria. You can filter certificates
        /// by X.509 attributes and ACM specific properties like certificate status, type and
        /// renewal eligibility. This operation provides more flexible filtering than <a>ListCertificates</a>
        /// by supporting complex filter statements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchCertificates service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/SearchCertificates">REST API Reference for SearchCertificates Operation</seealso>
        public virtual Task<SearchCertificatesResponse> SearchCertificatesAsync(SearchCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchCertificatesResponse>(request, options, cancellationToken);
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
        /// Adds one or more tags to an ACM resource. Tags are labels that you can use to identify
        /// and organize your Amazon Web Services resources. Each tag consists of a <c>key</c>
        /// and an optional <c>value</c>.
        /// 
        ///  <note> 
        /// <para>
        /// Use this action for all ACM resource types except the <c>certificate</c> resource
        /// type. For certificate resources, use <a>AddTagsToCertificate</a> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// To remove one or more tags, use the <a>UntagResource</a> action. To view all of the
        /// tags that have been applied to a resource, use the <a>ListTagsForResource</a> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from an ACM resource.
        /// 
        ///  <note> 
        /// <para>
        /// Use this action for all ACM resource types except the <c>certificate</c> resource
        /// type. For certificate resources, use <a>RemoveTagsFromCertificate</a> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// To add one or more tags, use the <a>TagResource</a> action. To view all of the tags
        /// that have been applied to a resource, use the <a>ListTagsForResource</a> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAcmeDomainValidation

        internal virtual UpdateAcmeDomainValidationResponse UpdateAcmeDomainValidation(UpdateAcmeDomainValidationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAcmeDomainValidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAcmeDomainValidationResponseUnmarshaller.Instance;

            return Invoke<UpdateAcmeDomainValidationResponse>(request, options);
        }



        /// <summary>
        /// Updates the prevalidation configuration of an existing domain validation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAcmeDomainValidation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAcmeDomainValidation service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/UpdateAcmeDomainValidation">REST API Reference for UpdateAcmeDomainValidation Operation</seealso>
        public virtual Task<UpdateAcmeDomainValidationResponse> UpdateAcmeDomainValidationAsync(UpdateAcmeDomainValidationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAcmeDomainValidationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAcmeDomainValidationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAcmeDomainValidationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAcmeEndpoint

        internal virtual UpdateAcmeEndpointResponse UpdateAcmeEndpoint(UpdateAcmeEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAcmeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAcmeEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateAcmeEndpointResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of an existing ACME endpoint. You can change the authorization
        /// behavior, contact requirement, or certificate authority settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAcmeEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAcmeEndpoint service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have access required to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ConflictException">
        /// You are trying to update a resource or configuration that is already being created
        /// or updated. Wait for the previous operation to finish and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ThrottlingException">
        /// The request was denied because it exceeded a quota.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/UpdateAcmeEndpoint">REST API Reference for UpdateAcmeEndpoint Operation</seealso>
        public virtual Task<UpdateAcmeEndpointResponse> UpdateAcmeEndpointAsync(UpdateAcmeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAcmeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAcmeEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAcmeEndpointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCertificateOptions

        internal virtual UpdateCertificateOptionsResponse UpdateCertificateOptions(UpdateCertificateOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCertificateOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCertificateOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateCertificateOptionsResponse>(request, options);
        }



        /// <summary>
        /// Updates a certificate. You can use this function to specify whether to export your
        /// certificate. Certificate transparency logging opt-out is no longer available. For
        /// more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-concepts.html#concept-transparency">Certificate
        /// Transparency Logging</a> and <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-exportable-certificates.html">Certificate
        /// Manager Exportable Managed Certificates</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificateOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCertificateOptions service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidStateException">
        /// Processing has reached an invalid state.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ValidationException">
        /// The supplied input failed to satisfy constraints of an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/UpdateCertificateOptions">REST API Reference for UpdateCertificateOptions Operation</seealso>
        public virtual Task<UpdateCertificateOptionsResponse> UpdateCertificateOptionsAsync(UpdateCertificateOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCertificateOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCertificateOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCertificateOptionsResponse>(request, options, cancellationToken);
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