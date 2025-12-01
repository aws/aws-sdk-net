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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.PartnerCentralAccount.Model;
using Amazon.PartnerCentralAccount.Model.Internal.MarshallTransformations;
using Amazon.PartnerCentralAccount.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.PartnerCentralAccount
{
    /// <summary>
    /// <para>Implementation for accessing PartnerCentralAccount</para>
    ///
    /// AWS Partner Central Account service provides APIs for managing partner accounts, connections,
    /// and profiles within the AWS Partner Network. This service enables partners to create
    /// and manage their partner profiles, establish connections with other partners, and
    /// maintain their account information.
    /// </summary>
    public partial class AmazonPartnerCentralAccountClient : AmazonServiceClient, IAmazonPartnerCentralAccount
    {
        private static IServiceMetadata serviceMetadata = new AmazonPartnerCentralAccountMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonPartnerCentralAccountClient with the credentials loaded from the application's
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
        public AmazonPartnerCentralAccountClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPartnerCentralAccountConfig()) { }

        /// <summary>
        /// Constructs AmazonPartnerCentralAccountClient with the credentials loaded from the application's
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
        public AmazonPartnerCentralAccountClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPartnerCentralAccountConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPartnerCentralAccountClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPartnerCentralAccountClient Configuration Object</param>
        public AmazonPartnerCentralAccountClient(AmazonPartnerCentralAccountConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonPartnerCentralAccountClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPartnerCentralAccountClient(AWSCredentials credentials)
            : this(credentials, new AmazonPartnerCentralAccountConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralAccountClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralAccountClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPartnerCentralAccountConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralAccountClient with AWS Credentials and an
        /// AmazonPartnerCentralAccountClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPartnerCentralAccountClient Configuration Object</param>
        public AmazonPartnerCentralAccountClient(AWSCredentials credentials, AmazonPartnerCentralAccountConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPartnerCentralAccountClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPartnerCentralAccountConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralAccountClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPartnerCentralAccountConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralAccountClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPartnerCentralAccountClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPartnerCentralAccountClient Configuration Object</param>
        public AmazonPartnerCentralAccountClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPartnerCentralAccountConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPartnerCentralAccountClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPartnerCentralAccountConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralAccountClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPartnerCentralAccountConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralAccountClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPartnerCentralAccountClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPartnerCentralAccountClient Configuration Object</param>
        public AmazonPartnerCentralAccountClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPartnerCentralAccountConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IPartnerCentralAccountPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPartnerCentralAccountPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PartnerCentralAccountPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPartnerCentralAccountEndpointResolver());
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


        #region  AcceptConnectionInvitation

        internal virtual AcceptConnectionInvitationResponse AcceptConnectionInvitation(AcceptConnectionInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptConnectionInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptConnectionInvitationResponse>(request, options);
        }



        /// <summary>
        /// Accepts a connection invitation from another partner, establishing a formal partnership
        /// connection between the two parties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptConnectionInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptConnectionInvitation service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/AcceptConnectionInvitation">REST API Reference for AcceptConnectionInvitation Operation</seealso>
        public virtual Task<AcceptConnectionInvitationResponse> AcceptConnectionInvitationAsync(AcceptConnectionInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptConnectionInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptConnectionInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateAwsTrainingCertificationEmailDomain

        internal virtual AssociateAwsTrainingCertificationEmailDomainResponse AssociateAwsTrainingCertificationEmailDomain(AssociateAwsTrainingCertificationEmailDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAwsTrainingCertificationEmailDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAwsTrainingCertificationEmailDomainResponseUnmarshaller.Instance;

            return Invoke<AssociateAwsTrainingCertificationEmailDomainResponse>(request, options);
        }



        /// <summary>
        /// Associates an email domain with AWS training and certification for the partner account,
        /// enabling automatic verification of employee certifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAwsTrainingCertificationEmailDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAwsTrainingCertificationEmailDomain service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/AssociateAwsTrainingCertificationEmailDomain">REST API Reference for AssociateAwsTrainingCertificationEmailDomain Operation</seealso>
        public virtual Task<AssociateAwsTrainingCertificationEmailDomainResponse> AssociateAwsTrainingCertificationEmailDomainAsync(AssociateAwsTrainingCertificationEmailDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAwsTrainingCertificationEmailDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAwsTrainingCertificationEmailDomainResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAwsTrainingCertificationEmailDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelConnection

        internal virtual CancelConnectionResponse CancelConnection(CancelConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelConnectionResponseUnmarshaller.Instance;

            return Invoke<CancelConnectionResponse>(request, options);
        }



        /// <summary>
        /// Cancels an existing connection between partners, terminating the partnership relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelConnection service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CancelConnection">REST API Reference for CancelConnection Operation</seealso>
        public virtual Task<CancelConnectionResponse> CancelConnectionAsync(CancelConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelConnectionInvitation

        internal virtual CancelConnectionInvitationResponse CancelConnectionInvitation(CancelConnectionInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelConnectionInvitationResponseUnmarshaller.Instance;

            return Invoke<CancelConnectionInvitationResponse>(request, options);
        }



        /// <summary>
        /// Cancels a pending connection invitation before it has been accepted or rejected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConnectionInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelConnectionInvitation service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CancelConnectionInvitation">REST API Reference for CancelConnectionInvitation Operation</seealso>
        public virtual Task<CancelConnectionInvitationResponse> CancelConnectionInvitationAsync(CancelConnectionInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelConnectionInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<CancelConnectionInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelProfileUpdateTask

        internal virtual CancelProfileUpdateTaskResponse CancelProfileUpdateTask(CancelProfileUpdateTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelProfileUpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelProfileUpdateTaskResponseUnmarshaller.Instance;

            return Invoke<CancelProfileUpdateTaskResponse>(request, options);
        }



        /// <summary>
        /// Cancels an in-progress profile update task, stopping any pending changes to the partner
        /// profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelProfileUpdateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelProfileUpdateTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CancelProfileUpdateTask">REST API Reference for CancelProfileUpdateTask Operation</seealso>
        public virtual Task<CancelProfileUpdateTaskResponse> CancelProfileUpdateTaskAsync(CancelProfileUpdateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelProfileUpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelProfileUpdateTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelProfileUpdateTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConnectionInvitation

        internal virtual CreateConnectionInvitationResponse CreateConnectionInvitation(CreateConnectionInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionInvitationResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionInvitationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new connection invitation to establish a partnership with another organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectionInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnectionInvitation service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CreateConnectionInvitation">REST API Reference for CreateConnectionInvitation Operation</seealso>
        public virtual Task<CreateConnectionInvitationResponse> CreateConnectionInvitationAsync(CreateConnectionInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectionInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePartner

        internal virtual CreatePartnerResponse CreatePartner(CreatePartnerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartnerResponseUnmarshaller.Instance;

            return Invoke<CreatePartnerResponse>(request, options);
        }



        /// <summary>
        /// Creates a new partner account in the AWS Partner Network with the specified details
        /// and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartner service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePartner service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CreatePartner">REST API Reference for CreatePartner Operation</seealso>
        public virtual Task<CreatePartnerResponse> CreatePartnerAsync(CreatePartnerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartnerResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePartnerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateAwsTrainingCertificationEmailDomain

        internal virtual DisassociateAwsTrainingCertificationEmailDomainResponse DisassociateAwsTrainingCertificationEmailDomain(DisassociateAwsTrainingCertificationEmailDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAwsTrainingCertificationEmailDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAwsTrainingCertificationEmailDomainResponseUnmarshaller.Instance;

            return Invoke<DisassociateAwsTrainingCertificationEmailDomainResponse>(request, options);
        }



        /// <summary>
        /// Removes the association between an email domain and AWS training and certification
        /// for the partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAwsTrainingCertificationEmailDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAwsTrainingCertificationEmailDomain service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/DisassociateAwsTrainingCertificationEmailDomain">REST API Reference for DisassociateAwsTrainingCertificationEmailDomain Operation</seealso>
        public virtual Task<DisassociateAwsTrainingCertificationEmailDomainResponse> DisassociateAwsTrainingCertificationEmailDomainAsync(DisassociateAwsTrainingCertificationEmailDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAwsTrainingCertificationEmailDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAwsTrainingCertificationEmailDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateAwsTrainingCertificationEmailDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAllianceLeadContact

        internal virtual GetAllianceLeadContactResponse GetAllianceLeadContact(GetAllianceLeadContactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAllianceLeadContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAllianceLeadContactResponseUnmarshaller.Instance;

            return Invoke<GetAllianceLeadContactResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the alliance lead contact information for a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAllianceLeadContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAllianceLeadContact service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetAllianceLeadContact">REST API Reference for GetAllianceLeadContact Operation</seealso>
        public virtual Task<GetAllianceLeadContactResponse> GetAllianceLeadContactAsync(GetAllianceLeadContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAllianceLeadContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAllianceLeadContactResponseUnmarshaller.Instance;

            return InvokeAsync<GetAllianceLeadContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConnection

        internal virtual GetConnectionResponse GetConnection(GetConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return Invoke<GetConnectionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information about a specific connection between partners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConnectionInvitation

        internal virtual GetConnectionInvitationResponse GetConnectionInvitation(GetConnectionInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionInvitationResponseUnmarshaller.Instance;

            return Invoke<GetConnectionInvitationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information about a specific connection invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectionInvitation service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetConnectionInvitation">REST API Reference for GetConnectionInvitation Operation</seealso>
        public virtual Task<GetConnectionInvitationResponse> GetConnectionInvitationAsync(GetConnectionInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectionInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConnectionPreferences

        internal virtual GetConnectionPreferencesResponse GetConnectionPreferences(GetConnectionPreferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionPreferencesResponseUnmarshaller.Instance;

            return Invoke<GetConnectionPreferencesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the connection preferences for a partner account, including access settings
        /// and exclusions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectionPreferences service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetConnectionPreferences">REST API Reference for GetConnectionPreferences Operation</seealso>
        public virtual Task<GetConnectionPreferencesResponse> GetConnectionPreferencesAsync(GetConnectionPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionPreferencesResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectionPreferencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPartner

        internal virtual GetPartnerResponse GetPartner(GetPartnerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartnerResponseUnmarshaller.Instance;

            return Invoke<GetPartnerResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information about a specific partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartner service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPartner service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetPartner">REST API Reference for GetPartner Operation</seealso>
        public virtual Task<GetPartnerResponse> GetPartnerAsync(GetPartnerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartnerResponseUnmarshaller.Instance;

            return InvokeAsync<GetPartnerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetProfileUpdateTask

        internal virtual GetProfileUpdateTaskResponse GetProfileUpdateTask(GetProfileUpdateTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileUpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileUpdateTaskResponseUnmarshaller.Instance;

            return Invoke<GetProfileUpdateTaskResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a specific profile update task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileUpdateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfileUpdateTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetProfileUpdateTask">REST API Reference for GetProfileUpdateTask Operation</seealso>
        public virtual Task<GetProfileUpdateTaskResponse> GetProfileUpdateTaskAsync(GetProfileUpdateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileUpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileUpdateTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetProfileUpdateTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetProfileVisibility

        internal virtual GetProfileVisibilityResponse GetProfileVisibility(GetProfileVisibilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileVisibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileVisibilityResponseUnmarshaller.Instance;

            return Invoke<GetProfileVisibilityResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the visibility settings for a partner profile, determining who can see the
        /// profile information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileVisibility service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfileVisibility service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetProfileVisibility">REST API Reference for GetProfileVisibility Operation</seealso>
        public virtual Task<GetProfileVisibilityResponse> GetProfileVisibilityAsync(GetProfileVisibilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileVisibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileVisibilityResponseUnmarshaller.Instance;

            return InvokeAsync<GetProfileVisibilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConnectionInvitations

        internal virtual ListConnectionInvitationsResponse ListConnectionInvitations(ListConnectionInvitationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionInvitationsResponseUnmarshaller.Instance;

            return Invoke<ListConnectionInvitationsResponse>(request, options);
        }



        /// <summary>
        /// Lists connection invitations for the partner account, with optional filtering by status,
        /// type, and other criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectionInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnectionInvitations service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListConnectionInvitations">REST API Reference for ListConnectionInvitations Operation</seealso>
        public virtual Task<ListConnectionInvitationsResponse> ListConnectionInvitationsAsync(ListConnectionInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConnectionInvitationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConnections

        internal virtual ListConnectionsResponse ListConnections(ListConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Lists active connections for the partner account, with optional filtering by connection
        /// type and participant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListConnections">REST API Reference for ListConnections Operation</seealso>
        public virtual Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPartners

        internal virtual ListPartnersResponse ListPartners(ListPartnersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPartnersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnersResponseUnmarshaller.Instance;

            return Invoke<ListPartnersResponse>(request, options);
        }



        /// <summary>
        /// Lists partner accounts in the catalog, providing a summary view of all partners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartners service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPartners service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListPartners">REST API Reference for ListPartners Operation</seealso>
        public virtual Task<ListPartnersResponse> ListPartnersAsync(ListPartnersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPartnersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnersResponseUnmarshaller.Instance;

            return InvokeAsync<ListPartnersResponse>(request, options, cancellationToken);
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
        /// Lists all tags associated with a specific AWS Partner Central Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAllianceLeadContact

        internal virtual PutAllianceLeadContactResponse PutAllianceLeadContact(PutAllianceLeadContactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAllianceLeadContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAllianceLeadContactResponseUnmarshaller.Instance;

            return Invoke<PutAllianceLeadContactResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates the alliance lead contact information for a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAllianceLeadContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAllianceLeadContact service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/PutAllianceLeadContact">REST API Reference for PutAllianceLeadContact Operation</seealso>
        public virtual Task<PutAllianceLeadContactResponse> PutAllianceLeadContactAsync(PutAllianceLeadContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAllianceLeadContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAllianceLeadContactResponseUnmarshaller.Instance;

            return InvokeAsync<PutAllianceLeadContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutProfileVisibility

        internal virtual PutProfileVisibilityResponse PutProfileVisibility(PutProfileVisibilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProfileVisibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProfileVisibilityResponseUnmarshaller.Instance;

            return Invoke<PutProfileVisibilityResponse>(request, options);
        }



        /// <summary>
        /// Sets the visibility level for a partner profile, controlling who can view the profile
        /// information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProfileVisibility service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutProfileVisibility service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/PutProfileVisibility">REST API Reference for PutProfileVisibility Operation</seealso>
        public virtual Task<PutProfileVisibilityResponse> PutProfileVisibilityAsync(PutProfileVisibilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProfileVisibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProfileVisibilityResponseUnmarshaller.Instance;

            return InvokeAsync<PutProfileVisibilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectConnectionInvitation

        internal virtual RejectConnectionInvitationResponse RejectConnectionInvitation(RejectConnectionInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectConnectionInvitationResponseUnmarshaller.Instance;

            return Invoke<RejectConnectionInvitationResponse>(request, options);
        }



        /// <summary>
        /// Rejects a connection invitation from another partner, declining the partnership request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectConnectionInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectConnectionInvitation service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/RejectConnectionInvitation">REST API Reference for RejectConnectionInvitation Operation</seealso>
        public virtual Task<RejectConnectionInvitationResponse> RejectConnectionInvitationAsync(RejectConnectionInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectConnectionInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<RejectConnectionInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendEmailVerificationCode

        internal virtual SendEmailVerificationCodeResponse SendEmailVerificationCode(SendEmailVerificationCodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendEmailVerificationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEmailVerificationCodeResponseUnmarshaller.Instance;

            return Invoke<SendEmailVerificationCodeResponse>(request, options);
        }



        /// <summary>
        /// Sends an email verification code to the specified email address for account verification
        /// purposes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmailVerificationCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendEmailVerificationCode service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/SendEmailVerificationCode">REST API Reference for SendEmailVerificationCode Operation</seealso>
        public virtual Task<SendEmailVerificationCodeResponse> SendEmailVerificationCodeAsync(SendEmailVerificationCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendEmailVerificationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEmailVerificationCodeResponseUnmarshaller.Instance;

            return InvokeAsync<SendEmailVerificationCodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartProfileUpdateTask

        internal virtual StartProfileUpdateTaskResponse StartProfileUpdateTask(StartProfileUpdateTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartProfileUpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProfileUpdateTaskResponseUnmarshaller.Instance;

            return Invoke<StartProfileUpdateTaskResponse>(request, options);
        }



        /// <summary>
        /// Initiates a profile update task to modify partner profile information asynchronously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProfileUpdateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartProfileUpdateTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/StartProfileUpdateTask">REST API Reference for StartProfileUpdateTask Operation</seealso>
        public virtual Task<StartProfileUpdateTaskResponse> StartProfileUpdateTaskAsync(StartProfileUpdateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartProfileUpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProfileUpdateTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartProfileUpdateTaskResponse>(request, options, cancellationToken);
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
        /// Adds or updates tags for a specified AWS Partner Central Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes specified tags from an AWS Partner Central Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConnectionPreferences

        internal virtual UpdateConnectionPreferencesResponse UpdateConnectionPreferences(UpdateConnectionPreferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionPreferencesResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectionPreferencesResponse>(request, options);
        }



        /// <summary>
        /// Updates the connection preferences for a partner account, modifying access settings
        /// and exclusions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnectionPreferences service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/UpdateConnectionPreferences">REST API Reference for UpdateConnectionPreferences Operation</seealso>
        public virtual Task<UpdateConnectionPreferencesResponse> UpdateConnectionPreferencesAsync(UpdateConnectionPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionPreferencesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConnectionPreferencesResponse>(request, options, cancellationToken);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonPartnerCentralAccountEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}