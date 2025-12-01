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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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

        /// <summary>
        /// Accepts a connection invitation from another partner, establishing a formal partnership
        /// connection between the two parties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptConnectionInvitation service method.</param>
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
        public virtual AcceptConnectionInvitationResponse AcceptConnectionInvitation(AcceptConnectionInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptConnectionInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptConnectionInvitationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptConnectionInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptConnectionInvitation operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptConnectionInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/AcceptConnectionInvitation">REST API Reference for AcceptConnectionInvitation Operation</seealso>
        public virtual IAsyncResult BeginAcceptConnectionInvitation(AcceptConnectionInvitationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptConnectionInvitationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptConnectionInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptConnectionInvitation.</param>
        /// 
        /// <returns>Returns a  AcceptConnectionInvitationResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/AcceptConnectionInvitation">REST API Reference for AcceptConnectionInvitation Operation</seealso>
        public virtual AcceptConnectionInvitationResponse EndAcceptConnectionInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptConnectionInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateAwsTrainingCertificationEmailDomain

        /// <summary>
        /// Associates an email domain with AWS training and certification for the partner account,
        /// enabling automatic verification of employee certifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAwsTrainingCertificationEmailDomain service method.</param>
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
        public virtual AssociateAwsTrainingCertificationEmailDomainResponse AssociateAwsTrainingCertificationEmailDomain(AssociateAwsTrainingCertificationEmailDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAwsTrainingCertificationEmailDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAwsTrainingCertificationEmailDomainResponseUnmarshaller.Instance;

            return Invoke<AssociateAwsTrainingCertificationEmailDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAwsTrainingCertificationEmailDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAwsTrainingCertificationEmailDomain operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAwsTrainingCertificationEmailDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/AssociateAwsTrainingCertificationEmailDomain">REST API Reference for AssociateAwsTrainingCertificationEmailDomain Operation</seealso>
        public virtual IAsyncResult BeginAssociateAwsTrainingCertificationEmailDomain(AssociateAwsTrainingCertificationEmailDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAwsTrainingCertificationEmailDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAwsTrainingCertificationEmailDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAwsTrainingCertificationEmailDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAwsTrainingCertificationEmailDomain.</param>
        /// 
        /// <returns>Returns a  AssociateAwsTrainingCertificationEmailDomainResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/AssociateAwsTrainingCertificationEmailDomain">REST API Reference for AssociateAwsTrainingCertificationEmailDomain Operation</seealso>
        public virtual AssociateAwsTrainingCertificationEmailDomainResponse EndAssociateAwsTrainingCertificationEmailDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateAwsTrainingCertificationEmailDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelConnection

        /// <summary>
        /// Cancels an existing connection between partners, terminating the partnership relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConnection service method.</param>
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
        public virtual CancelConnectionResponse CancelConnection(CancelConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelConnectionResponseUnmarshaller.Instance;

            return Invoke<CancelConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelConnection operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CancelConnection">REST API Reference for CancelConnection Operation</seealso>
        public virtual IAsyncResult BeginCancelConnection(CancelConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelConnection.</param>
        /// 
        /// <returns>Returns a  CancelConnectionResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CancelConnection">REST API Reference for CancelConnection Operation</seealso>
        public virtual CancelConnectionResponse EndCancelConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelConnectionInvitation

        /// <summary>
        /// Cancels a pending connection invitation before it has been accepted or rejected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConnectionInvitation service method.</param>
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
        public virtual CancelConnectionInvitationResponse CancelConnectionInvitation(CancelConnectionInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelConnectionInvitationResponseUnmarshaller.Instance;

            return Invoke<CancelConnectionInvitationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelConnectionInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelConnectionInvitation operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelConnectionInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CancelConnectionInvitation">REST API Reference for CancelConnectionInvitation Operation</seealso>
        public virtual IAsyncResult BeginCancelConnectionInvitation(CancelConnectionInvitationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelConnectionInvitationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelConnectionInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelConnectionInvitation.</param>
        /// 
        /// <returns>Returns a  CancelConnectionInvitationResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CancelConnectionInvitation">REST API Reference for CancelConnectionInvitation Operation</seealso>
        public virtual CancelConnectionInvitationResponse EndCancelConnectionInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelConnectionInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelProfileUpdateTask

        /// <summary>
        /// Cancels an in-progress profile update task, stopping any pending changes to the partner
        /// profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelProfileUpdateTask service method.</param>
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
        public virtual CancelProfileUpdateTaskResponse CancelProfileUpdateTask(CancelProfileUpdateTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelProfileUpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelProfileUpdateTaskResponseUnmarshaller.Instance;

            return Invoke<CancelProfileUpdateTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelProfileUpdateTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelProfileUpdateTask operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelProfileUpdateTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CancelProfileUpdateTask">REST API Reference for CancelProfileUpdateTask Operation</seealso>
        public virtual IAsyncResult BeginCancelProfileUpdateTask(CancelProfileUpdateTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelProfileUpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelProfileUpdateTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelProfileUpdateTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelProfileUpdateTask.</param>
        /// 
        /// <returns>Returns a  CancelProfileUpdateTaskResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CancelProfileUpdateTask">REST API Reference for CancelProfileUpdateTask Operation</seealso>
        public virtual CancelProfileUpdateTaskResponse EndCancelProfileUpdateTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelProfileUpdateTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConnectionInvitation

        /// <summary>
        /// Creates a new connection invitation to establish a partnership with another organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectionInvitation service method.</param>
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
        public virtual CreateConnectionInvitationResponse CreateConnectionInvitation(CreateConnectionInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionInvitationResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionInvitationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnectionInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectionInvitation operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnectionInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CreateConnectionInvitation">REST API Reference for CreateConnectionInvitation Operation</seealso>
        public virtual IAsyncResult BeginCreateConnectionInvitation(CreateConnectionInvitationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionInvitationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnectionInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnectionInvitation.</param>
        /// 
        /// <returns>Returns a  CreateConnectionInvitationResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CreateConnectionInvitation">REST API Reference for CreateConnectionInvitation Operation</seealso>
        public virtual CreateConnectionInvitationResponse EndCreateConnectionInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConnectionInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePartner

        /// <summary>
        /// Creates a new partner account in the AWS Partner Network with the specified details
        /// and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartner service method.</param>
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
        public virtual CreatePartnerResponse CreatePartner(CreatePartnerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartnerResponseUnmarshaller.Instance;

            return Invoke<CreatePartnerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePartner operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePartner operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePartner
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CreatePartner">REST API Reference for CreatePartner Operation</seealso>
        public virtual IAsyncResult BeginCreatePartner(CreatePartnerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartnerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePartner operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePartner.</param>
        /// 
        /// <returns>Returns a  CreatePartnerResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CreatePartner">REST API Reference for CreatePartner Operation</seealso>
        public virtual CreatePartnerResponse EndCreatePartner(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePartnerResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateAwsTrainingCertificationEmailDomain

        /// <summary>
        /// Removes the association between an email domain and AWS training and certification
        /// for the partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAwsTrainingCertificationEmailDomain service method.</param>
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
        public virtual DisassociateAwsTrainingCertificationEmailDomainResponse DisassociateAwsTrainingCertificationEmailDomain(DisassociateAwsTrainingCertificationEmailDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAwsTrainingCertificationEmailDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAwsTrainingCertificationEmailDomainResponseUnmarshaller.Instance;

            return Invoke<DisassociateAwsTrainingCertificationEmailDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAwsTrainingCertificationEmailDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAwsTrainingCertificationEmailDomain operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAwsTrainingCertificationEmailDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/DisassociateAwsTrainingCertificationEmailDomain">REST API Reference for DisassociateAwsTrainingCertificationEmailDomain Operation</seealso>
        public virtual IAsyncResult BeginDisassociateAwsTrainingCertificationEmailDomain(DisassociateAwsTrainingCertificationEmailDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAwsTrainingCertificationEmailDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAwsTrainingCertificationEmailDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAwsTrainingCertificationEmailDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAwsTrainingCertificationEmailDomain.</param>
        /// 
        /// <returns>Returns a  DisassociateAwsTrainingCertificationEmailDomainResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/DisassociateAwsTrainingCertificationEmailDomain">REST API Reference for DisassociateAwsTrainingCertificationEmailDomain Operation</seealso>
        public virtual DisassociateAwsTrainingCertificationEmailDomainResponse EndDisassociateAwsTrainingCertificationEmailDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateAwsTrainingCertificationEmailDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAllianceLeadContact

        /// <summary>
        /// Retrieves the alliance lead contact information for a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAllianceLeadContact service method.</param>
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
        public virtual GetAllianceLeadContactResponse GetAllianceLeadContact(GetAllianceLeadContactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAllianceLeadContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAllianceLeadContactResponseUnmarshaller.Instance;

            return Invoke<GetAllianceLeadContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAllianceLeadContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAllianceLeadContact operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAllianceLeadContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetAllianceLeadContact">REST API Reference for GetAllianceLeadContact Operation</seealso>
        public virtual IAsyncResult BeginGetAllianceLeadContact(GetAllianceLeadContactRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAllianceLeadContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAllianceLeadContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAllianceLeadContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAllianceLeadContact.</param>
        /// 
        /// <returns>Returns a  GetAllianceLeadContactResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetAllianceLeadContact">REST API Reference for GetAllianceLeadContact Operation</seealso>
        public virtual GetAllianceLeadContactResponse EndGetAllianceLeadContact(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAllianceLeadContactResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnection

        /// <summary>
        /// Retrieves detailed information about a specific connection between partners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
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
        public virtual GetConnectionResponse GetConnection(GetConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return Invoke<GetConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnection operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual IAsyncResult BeginGetConnection(GetConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnection.</param>
        /// 
        /// <returns>Returns a  GetConnectionResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual GetConnectionResponse EndGetConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnectionInvitation

        /// <summary>
        /// Retrieves detailed information about a specific connection invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionInvitation service method.</param>
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
        public virtual GetConnectionInvitationResponse GetConnectionInvitation(GetConnectionInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionInvitationResponseUnmarshaller.Instance;

            return Invoke<GetConnectionInvitationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectionInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionInvitation operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectionInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetConnectionInvitation">REST API Reference for GetConnectionInvitation Operation</seealso>
        public virtual IAsyncResult BeginGetConnectionInvitation(GetConnectionInvitationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionInvitationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectionInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectionInvitation.</param>
        /// 
        /// <returns>Returns a  GetConnectionInvitationResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetConnectionInvitation">REST API Reference for GetConnectionInvitation Operation</seealso>
        public virtual GetConnectionInvitationResponse EndGetConnectionInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectionInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnectionPreferences

        /// <summary>
        /// Retrieves the connection preferences for a partner account, including access settings
        /// and exclusions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionPreferences service method.</param>
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
        public virtual GetConnectionPreferencesResponse GetConnectionPreferences(GetConnectionPreferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionPreferencesResponseUnmarshaller.Instance;

            return Invoke<GetConnectionPreferencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectionPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionPreferences operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectionPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetConnectionPreferences">REST API Reference for GetConnectionPreferences Operation</seealso>
        public virtual IAsyncResult BeginGetConnectionPreferences(GetConnectionPreferencesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionPreferencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectionPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectionPreferences.</param>
        /// 
        /// <returns>Returns a  GetConnectionPreferencesResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetConnectionPreferences">REST API Reference for GetConnectionPreferences Operation</seealso>
        public virtual GetConnectionPreferencesResponse EndGetConnectionPreferences(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectionPreferencesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPartner

        /// <summary>
        /// Retrieves detailed information about a specific partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartner service method.</param>
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
        public virtual GetPartnerResponse GetPartner(GetPartnerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartnerResponseUnmarshaller.Instance;

            return Invoke<GetPartnerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPartner operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartner operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPartner
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetPartner">REST API Reference for GetPartner Operation</seealso>
        public virtual IAsyncResult BeginGetPartner(GetPartnerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPartnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartnerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPartner operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPartner.</param>
        /// 
        /// <returns>Returns a  GetPartnerResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetPartner">REST API Reference for GetPartner Operation</seealso>
        public virtual GetPartnerResponse EndGetPartner(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPartnerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProfileUpdateTask

        /// <summary>
        /// Retrieves information about a specific profile update task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileUpdateTask service method.</param>
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
        public virtual GetProfileUpdateTaskResponse GetProfileUpdateTask(GetProfileUpdateTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileUpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileUpdateTaskResponseUnmarshaller.Instance;

            return Invoke<GetProfileUpdateTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProfileUpdateTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProfileUpdateTask operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProfileUpdateTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetProfileUpdateTask">REST API Reference for GetProfileUpdateTask Operation</seealso>
        public virtual IAsyncResult BeginGetProfileUpdateTask(GetProfileUpdateTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileUpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileUpdateTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProfileUpdateTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProfileUpdateTask.</param>
        /// 
        /// <returns>Returns a  GetProfileUpdateTaskResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetProfileUpdateTask">REST API Reference for GetProfileUpdateTask Operation</seealso>
        public virtual GetProfileUpdateTaskResponse EndGetProfileUpdateTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProfileUpdateTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProfileVisibility

        /// <summary>
        /// Retrieves the visibility settings for a partner profile, determining who can see the
        /// profile information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileVisibility service method.</param>
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
        public virtual GetProfileVisibilityResponse GetProfileVisibility(GetProfileVisibilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileVisibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileVisibilityResponseUnmarshaller.Instance;

            return Invoke<GetProfileVisibilityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProfileVisibility operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProfileVisibility operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProfileVisibility
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetProfileVisibility">REST API Reference for GetProfileVisibility Operation</seealso>
        public virtual IAsyncResult BeginGetProfileVisibility(GetProfileVisibilityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileVisibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileVisibilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProfileVisibility operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProfileVisibility.</param>
        /// 
        /// <returns>Returns a  GetProfileVisibilityResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetProfileVisibility">REST API Reference for GetProfileVisibility Operation</seealso>
        public virtual GetProfileVisibilityResponse EndGetProfileVisibility(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProfileVisibilityResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConnectionInvitations

        /// <summary>
        /// Lists connection invitations for the partner account, with optional filtering by status,
        /// type, and other criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectionInvitations service method.</param>
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
        public virtual ListConnectionInvitationsResponse ListConnectionInvitations(ListConnectionInvitationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionInvitationsResponseUnmarshaller.Instance;

            return Invoke<ListConnectionInvitationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnectionInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnectionInvitations operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnectionInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListConnectionInvitations">REST API Reference for ListConnectionInvitations Operation</seealso>
        public virtual IAsyncResult BeginListConnectionInvitations(ListConnectionInvitationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionInvitationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnectionInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnectionInvitations.</param>
        /// 
        /// <returns>Returns a  ListConnectionInvitationsResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListConnectionInvitations">REST API Reference for ListConnectionInvitations Operation</seealso>
        public virtual ListConnectionInvitationsResponse EndListConnectionInvitations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConnectionInvitationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConnections

        /// <summary>
        /// Lists active connections for the partner account, with optional filtering by connection
        /// type and participant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
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
        public virtual ListConnectionsResponse ListConnections(ListConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListConnectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnections operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListConnections">REST API Reference for ListConnections Operation</seealso>
        public virtual IAsyncResult BeginListConnections(ListConnectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnections.</param>
        /// 
        /// <returns>Returns a  ListConnectionsResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListConnections">REST API Reference for ListConnections Operation</seealso>
        public virtual ListConnectionsResponse EndListConnections(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConnectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPartners

        /// <summary>
        /// Lists partner accounts in the catalog, providing a summary view of all partners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartners service method.</param>
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
        public virtual ListPartnersResponse ListPartners(ListPartnersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPartnersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnersResponseUnmarshaller.Instance;

            return Invoke<ListPartnersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPartners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPartners operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPartners
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListPartners">REST API Reference for ListPartners Operation</seealso>
        public virtual IAsyncResult BeginListPartners(ListPartnersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPartnersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPartners operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPartners.</param>
        /// 
        /// <returns>Returns a  ListPartnersResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListPartners">REST API Reference for ListPartners Operation</seealso>
        public virtual ListPartnersResponse EndListPartners(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPartnersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags associated with a specific AWS Partner Central Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutAllianceLeadContact

        /// <summary>
        /// Creates or updates the alliance lead contact information for a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAllianceLeadContact service method.</param>
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
        public virtual PutAllianceLeadContactResponse PutAllianceLeadContact(PutAllianceLeadContactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAllianceLeadContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAllianceLeadContactResponseUnmarshaller.Instance;

            return Invoke<PutAllianceLeadContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAllianceLeadContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAllianceLeadContact operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAllianceLeadContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/PutAllianceLeadContact">REST API Reference for PutAllianceLeadContact Operation</seealso>
        public virtual IAsyncResult BeginPutAllianceLeadContact(PutAllianceLeadContactRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAllianceLeadContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAllianceLeadContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAllianceLeadContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAllianceLeadContact.</param>
        /// 
        /// <returns>Returns a  PutAllianceLeadContactResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/PutAllianceLeadContact">REST API Reference for PutAllianceLeadContact Operation</seealso>
        public virtual PutAllianceLeadContactResponse EndPutAllianceLeadContact(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAllianceLeadContactResponse>(asyncResult);
        }

        #endregion
        
        #region  PutProfileVisibility

        /// <summary>
        /// Sets the visibility level for a partner profile, controlling who can view the profile
        /// information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProfileVisibility service method.</param>
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
        public virtual PutProfileVisibilityResponse PutProfileVisibility(PutProfileVisibilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProfileVisibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProfileVisibilityResponseUnmarshaller.Instance;

            return Invoke<PutProfileVisibilityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutProfileVisibility operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutProfileVisibility operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutProfileVisibility
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/PutProfileVisibility">REST API Reference for PutProfileVisibility Operation</seealso>
        public virtual IAsyncResult BeginPutProfileVisibility(PutProfileVisibilityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProfileVisibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProfileVisibilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutProfileVisibility operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutProfileVisibility.</param>
        /// 
        /// <returns>Returns a  PutProfileVisibilityResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/PutProfileVisibility">REST API Reference for PutProfileVisibility Operation</seealso>
        public virtual PutProfileVisibilityResponse EndPutProfileVisibility(IAsyncResult asyncResult)
        {
            return EndInvoke<PutProfileVisibilityResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectConnectionInvitation

        /// <summary>
        /// Rejects a connection invitation from another partner, declining the partnership request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectConnectionInvitation service method.</param>
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
        public virtual RejectConnectionInvitationResponse RejectConnectionInvitation(RejectConnectionInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectConnectionInvitationResponseUnmarshaller.Instance;

            return Invoke<RejectConnectionInvitationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectConnectionInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectConnectionInvitation operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectConnectionInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/RejectConnectionInvitation">REST API Reference for RejectConnectionInvitation Operation</seealso>
        public virtual IAsyncResult BeginRejectConnectionInvitation(RejectConnectionInvitationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectConnectionInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectConnectionInvitationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectConnectionInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectConnectionInvitation.</param>
        /// 
        /// <returns>Returns a  RejectConnectionInvitationResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/RejectConnectionInvitation">REST API Reference for RejectConnectionInvitation Operation</seealso>
        public virtual RejectConnectionInvitationResponse EndRejectConnectionInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectConnectionInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  SendEmailVerificationCode

        /// <summary>
        /// Sends an email verification code to the specified email address for account verification
        /// purposes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmailVerificationCode service method.</param>
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
        public virtual SendEmailVerificationCodeResponse SendEmailVerificationCode(SendEmailVerificationCodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendEmailVerificationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEmailVerificationCodeResponseUnmarshaller.Instance;

            return Invoke<SendEmailVerificationCodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendEmailVerificationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendEmailVerificationCode operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendEmailVerificationCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/SendEmailVerificationCode">REST API Reference for SendEmailVerificationCode Operation</seealso>
        public virtual IAsyncResult BeginSendEmailVerificationCode(SendEmailVerificationCodeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendEmailVerificationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendEmailVerificationCodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendEmailVerificationCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendEmailVerificationCode.</param>
        /// 
        /// <returns>Returns a  SendEmailVerificationCodeResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/SendEmailVerificationCode">REST API Reference for SendEmailVerificationCode Operation</seealso>
        public virtual SendEmailVerificationCodeResponse EndSendEmailVerificationCode(IAsyncResult asyncResult)
        {
            return EndInvoke<SendEmailVerificationCodeResponse>(asyncResult);
        }

        #endregion
        
        #region  StartProfileUpdateTask

        /// <summary>
        /// Initiates a profile update task to modify partner profile information asynchronously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProfileUpdateTask service method.</param>
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
        public virtual StartProfileUpdateTaskResponse StartProfileUpdateTask(StartProfileUpdateTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartProfileUpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProfileUpdateTaskResponseUnmarshaller.Instance;

            return Invoke<StartProfileUpdateTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartProfileUpdateTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartProfileUpdateTask operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartProfileUpdateTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/StartProfileUpdateTask">REST API Reference for StartProfileUpdateTask Operation</seealso>
        public virtual IAsyncResult BeginStartProfileUpdateTask(StartProfileUpdateTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartProfileUpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProfileUpdateTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartProfileUpdateTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartProfileUpdateTask.</param>
        /// 
        /// <returns>Returns a  StartProfileUpdateTaskResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/StartProfileUpdateTask">REST API Reference for StartProfileUpdateTask Operation</seealso>
        public virtual StartProfileUpdateTaskResponse EndStartProfileUpdateTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StartProfileUpdateTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or updates tags for a specified AWS Partner Central Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes specified tags from an AWS Partner Central Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConnectionPreferences

        /// <summary>
        /// Updates the connection preferences for a partner account, modifying access settings
        /// and exclusions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionPreferences service method.</param>
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
        public virtual UpdateConnectionPreferencesResponse UpdateConnectionPreferences(UpdateConnectionPreferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionPreferencesResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectionPreferencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnectionPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionPreferences operation on AmazonPartnerCentralAccountClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnectionPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/UpdateConnectionPreferences">REST API Reference for UpdateConnectionPreferences Operation</seealso>
        public virtual IAsyncResult BeginUpdateConnectionPreferences(UpdateConnectionPreferencesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionPreferencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnectionPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnectionPreferences.</param>
        /// 
        /// <returns>Returns a  UpdateConnectionPreferencesResult from PartnerCentralAccount.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/UpdateConnectionPreferences">REST API Reference for UpdateConnectionPreferences Operation</seealso>
        public virtual UpdateConnectionPreferencesResponse EndUpdateConnectionPreferences(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConnectionPreferencesResponse>(asyncResult);
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