/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.SecurityHub.Model;
using Amazon.SecurityHub.Model.Internal.MarshallTransformations;
using Amazon.SecurityHub.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecurityHub
{
    /// <summary>
    /// Implementation for accessing SecurityHub
    ///
    /// AWS Security Hub provides you with a comprehensive view of your security state within
    /// AWS and your compliance with the security industry standards and best practices. Security
    /// Hub collects security data from across AWS accounts, services, and supported third-party
    /// partners and helps you analyze your security trends and identify the highest priority
    /// security issues. For more information, see <a href="">AWS Security Hub User Guide</a>.
    /// </summary>
    public partial class AmazonSecurityHubClient : AmazonServiceClient, IAmazonSecurityHub
    {
        private static IServiceMetadata serviceMetadata = new AmazonSecurityHubMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonSecurityHubClient with the credentials loaded from the application's
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
        public AmazonSecurityHubClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecurityHubConfig()) { }

        /// <summary>
        /// Constructs AmazonSecurityHubClient with the credentials loaded from the application's
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
        public AmazonSecurityHubClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecurityHubConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSecurityHubClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSecurityHubClient Configuration Object</param>
        public AmazonSecurityHubClient(AmazonSecurityHubConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonSecurityHubClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSecurityHubClient(AWSCredentials credentials)
            : this(credentials, new AmazonSecurityHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityHubClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityHubClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSecurityHubConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityHubClient with AWS Credentials and an
        /// AmazonSecurityHubClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSecurityHubClient Configuration Object</param>
        public AmazonSecurityHubClient(AWSCredentials credentials, AmazonSecurityHubConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSecurityHubClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityHubClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityHubConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityHubClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityHubClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSecurityHubClient Configuration Object</param>
        public AmazonSecurityHubClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecurityHubConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSecurityHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityHubConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityHubClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityHubClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSecurityHubClient Configuration Object</param>
        public AmazonSecurityHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSecurityHubConfig clientConfig)
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

        
        #region  AcceptInvitation


        /// <summary>
        /// Accepts the invitation to be monitored by a master SecurityHub account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        public virtual AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request)
        {
            var marshaller = AcceptInvitationRequestMarshaller.Instance;
            var unmarshaller = AcceptInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptInvitationRequest,AcceptInvitationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        public virtual Task<AcceptInvitationResponse> AcceptInvitationAsync(AcceptInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AcceptInvitationRequestMarshaller.Instance;
            var unmarshaller = AcceptInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptInvitationRequest,AcceptInvitationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchDisableStandards


        /// <summary>
        /// Disables the standards specified by the standards subscription ARNs. In the context
        /// of Security Hub, supported standards (for example, CIS AWS Foundations) are automated
        /// and continuous checks that help determine your compliance status against security
        /// industry (including AWS) best practices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisableStandards service method.</param>
        /// 
        /// <returns>The response from the BatchDisableStandards service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchDisableStandards">REST API Reference for BatchDisableStandards Operation</seealso>
        public virtual BatchDisableStandardsResponse BatchDisableStandards(BatchDisableStandardsRequest request)
        {
            var marshaller = BatchDisableStandardsRequestMarshaller.Instance;
            var unmarshaller = BatchDisableStandardsResponseUnmarshaller.Instance;

            return Invoke<BatchDisableStandardsRequest,BatchDisableStandardsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisableStandards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisableStandards operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchDisableStandards">REST API Reference for BatchDisableStandards Operation</seealso>
        public virtual Task<BatchDisableStandardsResponse> BatchDisableStandardsAsync(BatchDisableStandardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchDisableStandardsRequestMarshaller.Instance;
            var unmarshaller = BatchDisableStandardsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDisableStandardsRequest,BatchDisableStandardsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchEnableStandards


        /// <summary>
        /// Enables the standards specified by the standards ARNs. In the context of Security
        /// Hub, supported standards (for example, CIS AWS Foundations) are automated and continuous
        /// checks that help determine your compliance status against security industry (including
        /// AWS) best practices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchEnableStandards service method.</param>
        /// 
        /// <returns>The response from the BatchEnableStandards service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchEnableStandards">REST API Reference for BatchEnableStandards Operation</seealso>
        public virtual BatchEnableStandardsResponse BatchEnableStandards(BatchEnableStandardsRequest request)
        {
            var marshaller = BatchEnableStandardsRequestMarshaller.Instance;
            var unmarshaller = BatchEnableStandardsResponseUnmarshaller.Instance;

            return Invoke<BatchEnableStandardsRequest,BatchEnableStandardsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchEnableStandards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchEnableStandards operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchEnableStandards">REST API Reference for BatchEnableStandards Operation</seealso>
        public virtual Task<BatchEnableStandardsResponse> BatchEnableStandardsAsync(BatchEnableStandardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchEnableStandardsRequestMarshaller.Instance;
            var unmarshaller = BatchEnableStandardsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchEnableStandardsRequest,BatchEnableStandardsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchImportFindings


        /// <summary>
        /// Imports security findings that are generated by the integrated third-party products
        /// into Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchImportFindings service method.</param>
        /// 
        /// <returns>The response from the BatchImportFindings service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchImportFindings">REST API Reference for BatchImportFindings Operation</seealso>
        public virtual BatchImportFindingsResponse BatchImportFindings(BatchImportFindingsRequest request)
        {
            var marshaller = BatchImportFindingsRequestMarshaller.Instance;
            var unmarshaller = BatchImportFindingsResponseUnmarshaller.Instance;

            return Invoke<BatchImportFindingsRequest,BatchImportFindingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchImportFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchImportFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchImportFindings">REST API Reference for BatchImportFindings Operation</seealso>
        public virtual Task<BatchImportFindingsResponse> BatchImportFindingsAsync(BatchImportFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchImportFindingsRequestMarshaller.Instance;
            var unmarshaller = BatchImportFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchImportFindingsRequest,BatchImportFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateInsight


        /// <summary>
        /// Creates an insight, which is a consolidation of findings that identifies a security
        /// area that requires attention or intervention.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInsight service method.</param>
        /// 
        /// <returns>The response from the CreateInsight service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateInsight">REST API Reference for CreateInsight Operation</seealso>
        public virtual CreateInsightResponse CreateInsight(CreateInsightRequest request)
        {
            var marshaller = CreateInsightRequestMarshaller.Instance;
            var unmarshaller = CreateInsightResponseUnmarshaller.Instance;

            return Invoke<CreateInsightRequest,CreateInsightResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInsight operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInsight operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateInsight">REST API Reference for CreateInsight Operation</seealso>
        public virtual Task<CreateInsightResponse> CreateInsightAsync(CreateInsightRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateInsightRequestMarshaller.Instance;
            var unmarshaller = CreateInsightResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInsightRequest,CreateInsightResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateMembers


        /// <summary>
        /// Creates member Security Hub accounts in the current AWS account (which becomes the
        /// master Security Hub account) that has Security Hub enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers service method.</param>
        /// 
        /// <returns>The response from the CreateMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        public virtual CreateMembersResponse CreateMembers(CreateMembersRequest request)
        {
            var marshaller = CreateMembersRequestMarshaller.Instance;
            var unmarshaller = CreateMembersResponseUnmarshaller.Instance;

            return Invoke<CreateMembersRequest,CreateMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        public virtual Task<CreateMembersResponse> CreateMembersAsync(CreateMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateMembersRequestMarshaller.Instance;
            var unmarshaller = CreateMembersResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMembersRequest,CreateMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeclineInvitations


        /// <summary>
        /// Declines invitations that are sent to this AWS account (invitee) by the AWS accounts
        /// (inviters) that are specified by the account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations service method.</param>
        /// 
        /// <returns>The response from the DeclineInvitations service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        public virtual DeclineInvitationsResponse DeclineInvitations(DeclineInvitationsRequest request)
        {
            var marshaller = DeclineInvitationsRequestMarshaller.Instance;
            var unmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;

            return Invoke<DeclineInvitationsRequest,DeclineInvitationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeclineInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        public virtual Task<DeclineInvitationsResponse> DeclineInvitationsAsync(DeclineInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeclineInvitationsRequestMarshaller.Instance;
            var unmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeclineInvitationsRequest,DeclineInvitationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteInsight


        /// <summary>
        /// Deletes an insight that is specified by the insight ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInsight service method.</param>
        /// 
        /// <returns>The response from the DeleteInsight service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInsight">REST API Reference for DeleteInsight Operation</seealso>
        public virtual DeleteInsightResponse DeleteInsight(DeleteInsightRequest request)
        {
            var marshaller = DeleteInsightRequestMarshaller.Instance;
            var unmarshaller = DeleteInsightResponseUnmarshaller.Instance;

            return Invoke<DeleteInsightRequest,DeleteInsightResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInsight operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInsight operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInsight">REST API Reference for DeleteInsight Operation</seealso>
        public virtual Task<DeleteInsightResponse> DeleteInsightAsync(DeleteInsightRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteInsightRequestMarshaller.Instance;
            var unmarshaller = DeleteInsightResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInsightRequest,DeleteInsightResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteInvitations


        /// <summary>
        /// Deletes invitations that are sent to this AWS account (invitee) by the AWS accounts
        /// (inviters) that are specified by their account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations service method.</param>
        /// 
        /// <returns>The response from the DeleteInvitations service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        public virtual DeleteInvitationsResponse DeleteInvitations(DeleteInvitationsRequest request)
        {
            var marshaller = DeleteInvitationsRequestMarshaller.Instance;
            var unmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;

            return Invoke<DeleteInvitationsRequest,DeleteInvitationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        public virtual Task<DeleteInvitationsResponse> DeleteInvitationsAsync(DeleteInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteInvitationsRequestMarshaller.Instance;
            var unmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInvitationsRequest,DeleteInvitationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteMembers


        /// <summary>
        /// Deletes the Security Hub member accounts that are specified by the account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers service method.</param>
        /// 
        /// <returns>The response from the DeleteMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        public virtual DeleteMembersResponse DeleteMembers(DeleteMembersRequest request)
        {
            var marshaller = DeleteMembersRequestMarshaller.Instance;
            var unmarshaller = DeleteMembersResponseUnmarshaller.Instance;

            return Invoke<DeleteMembersRequest,DeleteMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        public virtual Task<DeleteMembersResponse> DeleteMembersAsync(DeleteMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteMembersRequestMarshaller.Instance;
            var unmarshaller = DeleteMembersResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMembersRequest,DeleteMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableImportFindingsForProduct


        /// <summary>
        /// Stops you from being able to import findings generated by integrated third-party providers
        /// into Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableImportFindingsForProduct service method.</param>
        /// 
        /// <returns>The response from the DisableImportFindingsForProduct service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableImportFindingsForProduct">REST API Reference for DisableImportFindingsForProduct Operation</seealso>
        public virtual DisableImportFindingsForProductResponse DisableImportFindingsForProduct(DisableImportFindingsForProductRequest request)
        {
            var marshaller = DisableImportFindingsForProductRequestMarshaller.Instance;
            var unmarshaller = DisableImportFindingsForProductResponseUnmarshaller.Instance;

            return Invoke<DisableImportFindingsForProductRequest,DisableImportFindingsForProductResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableImportFindingsForProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableImportFindingsForProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableImportFindingsForProduct">REST API Reference for DisableImportFindingsForProduct Operation</seealso>
        public virtual Task<DisableImportFindingsForProductResponse> DisableImportFindingsForProductAsync(DisableImportFindingsForProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisableImportFindingsForProductRequestMarshaller.Instance;
            var unmarshaller = DisableImportFindingsForProductResponseUnmarshaller.Instance;

            return InvokeAsync<DisableImportFindingsForProductRequest,DisableImportFindingsForProductResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableSecurityHub


        /// <summary>
        /// Disables the AWS Security Hub Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSecurityHub service method.</param>
        /// 
        /// <returns>The response from the DisableSecurityHub service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableSecurityHub">REST API Reference for DisableSecurityHub Operation</seealso>
        public virtual DisableSecurityHubResponse DisableSecurityHub(DisableSecurityHubRequest request)
        {
            var marshaller = DisableSecurityHubRequestMarshaller.Instance;
            var unmarshaller = DisableSecurityHubResponseUnmarshaller.Instance;

            return Invoke<DisableSecurityHubRequest,DisableSecurityHubResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableSecurityHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSecurityHub operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableSecurityHub">REST API Reference for DisableSecurityHub Operation</seealso>
        public virtual Task<DisableSecurityHubResponse> DisableSecurityHubAsync(DisableSecurityHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisableSecurityHubRequestMarshaller.Instance;
            var unmarshaller = DisableSecurityHubResponseUnmarshaller.Instance;

            return InvokeAsync<DisableSecurityHubRequest,DisableSecurityHubResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateFromMasterAccount


        /// <summary>
        /// Disassociates the current Security Hub member account from its master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateFromMasterAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        public virtual DisassociateFromMasterAccountResponse DisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request)
        {
            var marshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            var unmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateFromMasterAccountRequest,DisassociateFromMasterAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFromMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        public virtual Task<DisassociateFromMasterAccountResponse> DisassociateFromMasterAccountAsync(DisassociateFromMasterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            var unmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateFromMasterAccountRequest,DisassociateFromMasterAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMembers


        /// <summary>
        /// Disassociates the Security Hub member accounts that are specified by the account IDs
        /// from their master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers service method.</param>
        /// 
        /// <returns>The response from the DisassociateMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        public virtual DisassociateMembersResponse DisassociateMembers(DisassociateMembersRequest request)
        {
            var marshaller = DisassociateMembersRequestMarshaller.Instance;
            var unmarshaller = DisassociateMembersResponseUnmarshaller.Instance;

            return Invoke<DisassociateMembersRequest,DisassociateMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        public virtual Task<DisassociateMembersResponse> DisassociateMembersAsync(DisassociateMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateMembersRequestMarshaller.Instance;
            var unmarshaller = DisassociateMembersResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateMembersRequest,DisassociateMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableImportFindingsForProduct


        /// <summary>
        /// Enables you to import findings generated by integrated third-party providers into
        /// Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableImportFindingsForProduct service method.</param>
        /// 
        /// <returns>The response from the EnableImportFindingsForProduct service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableImportFindingsForProduct">REST API Reference for EnableImportFindingsForProduct Operation</seealso>
        public virtual EnableImportFindingsForProductResponse EnableImportFindingsForProduct(EnableImportFindingsForProductRequest request)
        {
            var marshaller = EnableImportFindingsForProductRequestMarshaller.Instance;
            var unmarshaller = EnableImportFindingsForProductResponseUnmarshaller.Instance;

            return Invoke<EnableImportFindingsForProductRequest,EnableImportFindingsForProductResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableImportFindingsForProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableImportFindingsForProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableImportFindingsForProduct">REST API Reference for EnableImportFindingsForProduct Operation</seealso>
        public virtual Task<EnableImportFindingsForProductResponse> EnableImportFindingsForProductAsync(EnableImportFindingsForProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableImportFindingsForProductRequestMarshaller.Instance;
            var unmarshaller = EnableImportFindingsForProductResponseUnmarshaller.Instance;

            return InvokeAsync<EnableImportFindingsForProductRequest,EnableImportFindingsForProductResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableSecurityHub


        /// <summary>
        /// Enables the AWS Security Hub service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSecurityHub service method.</param>
        /// 
        /// <returns>The response from the EnableSecurityHub service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableSecurityHub">REST API Reference for EnableSecurityHub Operation</seealso>
        public virtual EnableSecurityHubResponse EnableSecurityHub(EnableSecurityHubRequest request)
        {
            var marshaller = EnableSecurityHubRequestMarshaller.Instance;
            var unmarshaller = EnableSecurityHubResponseUnmarshaller.Instance;

            return Invoke<EnableSecurityHubRequest,EnableSecurityHubResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSecurityHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSecurityHub operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableSecurityHub">REST API Reference for EnableSecurityHub Operation</seealso>
        public virtual Task<EnableSecurityHubResponse> EnableSecurityHubAsync(EnableSecurityHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableSecurityHubRequestMarshaller.Instance;
            var unmarshaller = EnableSecurityHubResponseUnmarshaller.Instance;

            return InvokeAsync<EnableSecurityHubRequest,EnableSecurityHubResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetEnabledStandards


        /// <summary>
        /// Lists and describes enabled standards.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledStandards service method.</param>
        /// 
        /// <returns>The response from the GetEnabledStandards service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetEnabledStandards">REST API Reference for GetEnabledStandards Operation</seealso>
        public virtual GetEnabledStandardsResponse GetEnabledStandards(GetEnabledStandardsRequest request)
        {
            var marshaller = GetEnabledStandardsRequestMarshaller.Instance;
            var unmarshaller = GetEnabledStandardsResponseUnmarshaller.Instance;

            return Invoke<GetEnabledStandardsRequest,GetEnabledStandardsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnabledStandards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledStandards operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetEnabledStandards">REST API Reference for GetEnabledStandards Operation</seealso>
        public virtual Task<GetEnabledStandardsResponse> GetEnabledStandardsAsync(GetEnabledStandardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetEnabledStandardsRequestMarshaller.Instance;
            var unmarshaller = GetEnabledStandardsResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnabledStandardsRequest,GetEnabledStandardsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFindings


        /// <summary>
        /// Lists and describes Security Hub-aggregated findings that are specified by filter
        /// attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
        /// 
        /// <returns>The response from the GetFindings service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindings">REST API Reference for GetFindings Operation</seealso>
        public virtual GetFindingsResponse GetFindings(GetFindingsRequest request)
        {
            var marshaller = GetFindingsRequestMarshaller.Instance;
            var unmarshaller = GetFindingsResponseUnmarshaller.Instance;

            return Invoke<GetFindingsRequest,GetFindingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindings">REST API Reference for GetFindings Operation</seealso>
        public virtual Task<GetFindingsResponse> GetFindingsAsync(GetFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetFindingsRequestMarshaller.Instance;
            var unmarshaller = GetFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetFindingsRequest,GetFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetInsightResults


        /// <summary>
        /// Lists the results of the Security Hub insight specified by the insight ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightResults service method.</param>
        /// 
        /// <returns>The response from the GetInsightResults service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsightResults">REST API Reference for GetInsightResults Operation</seealso>
        public virtual GetInsightResultsResponse GetInsightResults(GetInsightResultsRequest request)
        {
            var marshaller = GetInsightResultsRequestMarshaller.Instance;
            var unmarshaller = GetInsightResultsResponseUnmarshaller.Instance;

            return Invoke<GetInsightResultsRequest,GetInsightResultsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInsightResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInsightResults operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsightResults">REST API Reference for GetInsightResults Operation</seealso>
        public virtual Task<GetInsightResultsResponse> GetInsightResultsAsync(GetInsightResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetInsightResultsRequestMarshaller.Instance;
            var unmarshaller = GetInsightResultsResponseUnmarshaller.Instance;

            return InvokeAsync<GetInsightResultsRequest,GetInsightResultsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetInsights


        /// <summary>
        /// Lists and describes insights that are specified by insight ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsights service method.</param>
        /// 
        /// <returns>The response from the GetInsights service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsights">REST API Reference for GetInsights Operation</seealso>
        public virtual GetInsightsResponse GetInsights(GetInsightsRequest request)
        {
            var marshaller = GetInsightsRequestMarshaller.Instance;
            var unmarshaller = GetInsightsResponseUnmarshaller.Instance;

            return Invoke<GetInsightsRequest,GetInsightsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInsights operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInsights operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsights">REST API Reference for GetInsights Operation</seealso>
        public virtual Task<GetInsightsResponse> GetInsightsAsync(GetInsightsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetInsightsRequestMarshaller.Instance;
            var unmarshaller = GetInsightsResponseUnmarshaller.Instance;

            return InvokeAsync<GetInsightsRequest,GetInsightsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetInvitationsCount


        /// <summary>
        /// Returns the count of all Security Hub membership invitations that were sent to the
        /// current member account, not including the currently accepted invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount service method.</param>
        /// 
        /// <returns>The response from the GetInvitationsCount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        public virtual GetInvitationsCountResponse GetInvitationsCount(GetInvitationsCountRequest request)
        {
            var marshaller = GetInvitationsCountRequestMarshaller.Instance;
            var unmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;

            return Invoke<GetInvitationsCountRequest,GetInvitationsCountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvitationsCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        public virtual Task<GetInvitationsCountResponse> GetInvitationsCountAsync(GetInvitationsCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetInvitationsCountRequestMarshaller.Instance;
            var unmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetInvitationsCountRequest,GetInvitationsCountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMasterAccount


        /// <summary>
        /// Provides the details for the Security Hub master account to the current member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount service method.</param>
        /// 
        /// <returns>The response from the GetMasterAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        public virtual GetMasterAccountResponse GetMasterAccount(GetMasterAccountRequest request)
        {
            var marshaller = GetMasterAccountRequestMarshaller.Instance;
            var unmarshaller = GetMasterAccountResponseUnmarshaller.Instance;

            return Invoke<GetMasterAccountRequest,GetMasterAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        public virtual Task<GetMasterAccountResponse> GetMasterAccountAsync(GetMasterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetMasterAccountRequestMarshaller.Instance;
            var unmarshaller = GetMasterAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetMasterAccountRequest,GetMasterAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMembers


        /// <summary>
        /// Returns the details on the Security Hub member accounts that are specified by the
        /// account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembers service method.</param>
        /// 
        /// <returns>The response from the GetMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMembers">REST API Reference for GetMembers Operation</seealso>
        public virtual GetMembersResponse GetMembers(GetMembersRequest request)
        {
            var marshaller = GetMembersRequestMarshaller.Instance;
            var unmarshaller = GetMembersResponseUnmarshaller.Instance;

            return Invoke<GetMembersRequest,GetMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMembers">REST API Reference for GetMembers Operation</seealso>
        public virtual Task<GetMembersResponse> GetMembersAsync(GetMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetMembersRequestMarshaller.Instance;
            var unmarshaller = GetMembersResponseUnmarshaller.Instance;

            return InvokeAsync<GetMembersRequest,GetMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InviteMembers


        /// <summary>
        /// Invites other AWS accounts to enable Security Hub and become Security Hub member accounts.
        /// When an account accepts the invitation and becomes a member account, the master account
        /// can view Security Hub findings of the member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers service method.</param>
        /// 
        /// <returns>The response from the InviteMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        public virtual InviteMembersResponse InviteMembers(InviteMembersRequest request)
        {
            var marshaller = InviteMembersRequestMarshaller.Instance;
            var unmarshaller = InviteMembersResponseUnmarshaller.Instance;

            return Invoke<InviteMembersRequest,InviteMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InviteMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        public virtual Task<InviteMembersResponse> InviteMembersAsync(InviteMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = InviteMembersRequestMarshaller.Instance;
            var unmarshaller = InviteMembersResponseUnmarshaller.Instance;

            return InvokeAsync<InviteMembersRequest,InviteMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListEnabledProductsForImport


        /// <summary>
        /// Lists all Security Hub-integrated third-party findings providers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledProductsForImport service method.</param>
        /// 
        /// <returns>The response from the ListEnabledProductsForImport service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListEnabledProductsForImport">REST API Reference for ListEnabledProductsForImport Operation</seealso>
        public virtual ListEnabledProductsForImportResponse ListEnabledProductsForImport(ListEnabledProductsForImportRequest request)
        {
            var marshaller = ListEnabledProductsForImportRequestMarshaller.Instance;
            var unmarshaller = ListEnabledProductsForImportResponseUnmarshaller.Instance;

            return Invoke<ListEnabledProductsForImportRequest,ListEnabledProductsForImportResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnabledProductsForImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledProductsForImport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListEnabledProductsForImport">REST API Reference for ListEnabledProductsForImport Operation</seealso>
        public virtual Task<ListEnabledProductsForImportResponse> ListEnabledProductsForImportAsync(ListEnabledProductsForImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListEnabledProductsForImportRequestMarshaller.Instance;
            var unmarshaller = ListEnabledProductsForImportResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnabledProductsForImportRequest,ListEnabledProductsForImportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListInvitations


        /// <summary>
        /// Lists all Security Hub membership invitations that were sent to the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual ListInvitationsResponse ListInvitations(ListInvitationsRequest request)
        {
            var marshaller = ListInvitationsRequestMarshaller.Instance;
            var unmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return Invoke<ListInvitationsRequest,ListInvitationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual Task<ListInvitationsResponse> ListInvitationsAsync(ListInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListInvitationsRequestMarshaller.Instance;
            var unmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInvitationsRequest,ListInvitationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListMembers


        /// <summary>
        /// Lists details about all member accounts for the current Security Hub master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual ListMembersResponse ListMembers(ListMembersRequest request)
        {
            var marshaller = ListMembersRequestMarshaller.Instance;
            var unmarshaller = ListMembersResponseUnmarshaller.Instance;

            return Invoke<ListMembersRequest,ListMembersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListMembersRequestMarshaller.Instance;
            var unmarshaller = ListMembersResponseUnmarshaller.Instance;

            return InvokeAsync<ListMembersRequest,ListMembersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateFindings


        /// <summary>
        /// Updates the AWS Security Hub-aggregated findings specified by the filter attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindings service method.</param>
        /// 
        /// <returns>The response from the UpdateFindings service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateFindings">REST API Reference for UpdateFindings Operation</seealso>
        public virtual UpdateFindingsResponse UpdateFindings(UpdateFindingsRequest request)
        {
            var marshaller = UpdateFindingsRequestMarshaller.Instance;
            var unmarshaller = UpdateFindingsResponseUnmarshaller.Instance;

            return Invoke<UpdateFindingsRequest,UpdateFindingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateFindings">REST API Reference for UpdateFindings Operation</seealso>
        public virtual Task<UpdateFindingsResponse> UpdateFindingsAsync(UpdateFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateFindingsRequestMarshaller.Instance;
            var unmarshaller = UpdateFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFindingsRequest,UpdateFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateInsight


        /// <summary>
        /// Updates the AWS Security Hub insight specified by the insight ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInsight service method.</param>
        /// 
        /// <returns>The response from the UpdateInsight service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because the specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateInsight">REST API Reference for UpdateInsight Operation</seealso>
        public virtual UpdateInsightResponse UpdateInsight(UpdateInsightRequest request)
        {
            var marshaller = UpdateInsightRequestMarshaller.Instance;
            var unmarshaller = UpdateInsightResponseUnmarshaller.Instance;

            return Invoke<UpdateInsightRequest,UpdateInsightResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInsight operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInsight operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateInsight">REST API Reference for UpdateInsight Operation</seealso>
        public virtual Task<UpdateInsightResponse> UpdateInsightAsync(UpdateInsightRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateInsightRequestMarshaller.Instance;
            var unmarshaller = UpdateInsightResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateInsightRequest,UpdateInsightResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}