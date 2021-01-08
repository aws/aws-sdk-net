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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Detective.Model;
using Amazon.Detective.Model.Internal.MarshallTransformations;
using Amazon.Detective.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Detective
{
    /// <summary>
    /// Implementation for accessing Detective
    ///
    /// Detective uses machine learning and purpose-built visualizations to help you analyze
    /// and investigate security issues across your Amazon Web Services (AWS) workloads. Detective
    /// automatically extracts time-based events such as login attempts, API calls, and network
    /// traffic from AWS CloudTrail and Amazon Virtual Private Cloud (Amazon VPC) flow logs.
    /// It also extracts findings detected by Amazon GuardDuty.
    /// 
    ///  
    /// <para>
    /// The Detective API primarily supports the creation and management of behavior graphs.
    /// A behavior graph contains the extracted data from a set of member accounts, and is
    /// created and managed by a master account.
    /// </para>
    ///  
    /// <para>
    /// Every behavior graph is specific to a Region. You can only use the API to manage graphs
    /// that belong to the Region that is associated with the currently selected endpoint.
    /// </para>
    ///  
    /// <para>
    /// A Detective master account can use the Detective API to do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Enable and disable Detective. Enabling Detective creates a new behavior graph.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// View the list of member accounts in a behavior graph.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Add member accounts to a behavior graph.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Remove member accounts from a behavior graph.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// A member account can use the Detective API to do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// View the list of behavior graphs that they are invited to.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Accept an invitation to contribute to a behavior graph.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Decline an invitation to contribute to a behavior graph.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Remove their account from a behavior graph.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// All API actions are logged as CloudTrail events. See <a href="https://docs.aws.amazon.com/detective/latest/adminguide/logging-using-cloudtrail.html">Logging
    /// Detective API Calls with CloudTrail</a>.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonDetectiveClient : AmazonServiceClient, IAmazonDetective
    {
        private static IServiceMetadata serviceMetadata = new AmazonDetectiveMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonDetectiveClient with the credentials loaded from the application's
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
        public AmazonDetectiveClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDetectiveConfig()) { }

        /// <summary>
        /// Constructs AmazonDetectiveClient with the credentials loaded from the application's
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
        public AmazonDetectiveClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDetectiveConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDetectiveClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDetectiveClient Configuration Object</param>
        public AmazonDetectiveClient(AmazonDetectiveConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonDetectiveClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDetectiveClient(AWSCredentials credentials)
            : this(credentials, new AmazonDetectiveConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDetectiveClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDetectiveClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDetectiveConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDetectiveClient with AWS Credentials and an
        /// AmazonDetectiveClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDetectiveClient Configuration Object</param>
        public AmazonDetectiveClient(AWSCredentials credentials, AmazonDetectiveConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDetectiveClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDetectiveClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDetectiveConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDetectiveClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDetectiveClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDetectiveConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDetectiveClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDetectiveClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDetectiveClient Configuration Object</param>
        public AmazonDetectiveClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDetectiveConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDetectiveClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDetectiveClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDetectiveConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDetectiveClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDetectiveClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDetectiveConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDetectiveClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDetectiveClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDetectiveClient Configuration Object</param>
        public AmazonDetectiveClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDetectiveConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IDetectivePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDetectivePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DetectivePaginatorFactory(this);
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


        #region  AcceptInvitation

        internal virtual AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptInvitationResponse>(request, options);
        }



        /// <summary>
        /// Accepts an invitation for the member account to contribute data to a behavior graph.
        /// This operation can only be called by an invited member account. 
        /// 
        ///  
        /// <para>
        /// The request provides the ARN of behavior graph.
        /// </para>
        ///  
        /// <para>
        /// The member account status in the graph must be <code>INVITED</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.ConflictException">
        /// The request attempted an invalid action.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        public virtual Task<AcceptInvitationResponse> AcceptInvitationAsync(AcceptInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGraph

        internal virtual CreateGraphResponse CreateGraph(CreateGraphRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphResponseUnmarshaller.Instance;

            return Invoke<CreateGraphResponse>(request, options);
        }



        /// <summary>
        /// Creates a new behavior graph for the calling account, and sets that account as the
        /// master account. This operation is called by the account that is enabling Detective.
        /// 
        ///  
        /// <para>
        /// Before you try to enable Detective, make sure that your account has been enrolled
        /// in Amazon GuardDuty for at least 48 hours. If you do not meet this requirement, you
        /// cannot enable Detective. If you do meet the GuardDuty prerequisite, then when you
        /// make the request to enable Detective, it checks whether your data volume is within
        /// the Detective quota. If it exceeds the quota, then you cannot enable Detective. 
        /// </para>
        ///  
        /// <para>
        /// The operation also enables Detective for the calling account in the currently selected
        /// Region. It returns the ARN of the new behavior graph.
        /// </para>
        ///  
        /// <para>
        ///  <code>CreateGraph</code> triggers a process to create the corresponding data tables
        /// for the new behavior graph.
        /// </para>
        ///  
        /// <para>
        /// An account can only be the master account for one behavior graph within a Region.
        /// If the same account calls <code>CreateGraph</code> with the same master account, it
        /// always returns the same behavior graph ARN. It does not create a new behavior graph.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGraph service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.ConflictException">
        /// The request attempted an invalid action.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ServiceQuotaExceededException">
        /// This request cannot be completed for one of the following reasons.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The request would cause the number of member accounts in the behavior graph to exceed
        /// the maximum allowed. A behavior graph cannot have more than 1000 member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The request would cause the data rate for the behavior graph to exceed the maximum
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Detective is unable to verify the data rate for the member account. This is usually
        /// because the member account is not enrolled in Amazon GuardDuty. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/CreateGraph">REST API Reference for CreateGraph Operation</seealso>
        public virtual Task<CreateGraphResponse> CreateGraphAsync(CreateGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGraphResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMembers

        internal virtual CreateMembersResponse CreateMembers(CreateMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembersResponseUnmarshaller.Instance;

            return Invoke<CreateMembersResponse>(request, options);
        }



        /// <summary>
        /// Sends a request to invite the specified AWS accounts to be member accounts in the
        /// behavior graph. This operation can only be called by the master account for a behavior
        /// graph. 
        /// 
        ///  
        /// <para>
        ///  <code>CreateMembers</code> verifies the accounts and then sends invitations to the
        /// verified accounts.
        /// </para>
        ///  
        /// <para>
        /// The request provides the behavior graph ARN and the list of accounts to invite.
        /// </para>
        ///  
        /// <para>
        /// The response separates the requested accounts into two lists:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The accounts that <code>CreateMembers</code> was able to start the verification for.
        /// This list includes member accounts that are being verified, that have passed verification
        /// and are being sent an invitation, and that have failed verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The accounts that <code>CreateMembers</code> was unable to process. This list includes
        /// accounts that were already invited to be member accounts in the behavior graph.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMembers service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ServiceQuotaExceededException">
        /// This request cannot be completed for one of the following reasons.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The request would cause the number of member accounts in the behavior graph to exceed
        /// the maximum allowed. A behavior graph cannot have more than 1000 member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The request would cause the data rate for the behavior graph to exceed the maximum
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Detective is unable to verify the data rate for the member account. This is usually
        /// because the member account is not enrolled in Amazon GuardDuty. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        public virtual Task<CreateMembersResponse> CreateMembersAsync(CreateMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembersResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGraph

        internal virtual DeleteGraphResponse DeleteGraph(DeleteGraphRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphResponseUnmarshaller.Instance;

            return Invoke<DeleteGraphResponse>(request, options);
        }



        /// <summary>
        /// Disables the specified behavior graph and queues it to be deleted. This operation
        /// removes the graph from each member account's list of behavior graphs.
        /// 
        ///  
        /// <para>
        ///  <code>DeleteGraph</code> can only be called by the master account for a behavior
        /// graph.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGraph service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DeleteGraph">REST API Reference for DeleteGraph Operation</seealso>
        public virtual Task<DeleteGraphResponse> DeleteGraphAsync(DeleteGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGraphResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMembers

        internal virtual DeleteMembersResponse DeleteMembers(DeleteMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembersResponseUnmarshaller.Instance;

            return Invoke<DeleteMembersResponse>(request, options);
        }



        /// <summary>
        /// Deletes one or more member accounts from the master account behavior graph. This operation
        /// can only be called by a Detective master account. That account cannot use <code>DeleteMembers</code>
        /// to delete their own account from the behavior graph. To disable a behavior graph,
        /// the master account uses the <code>DeleteGraph</code> API method.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMembers service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.ConflictException">
        /// The request attempted an invalid action.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        public virtual Task<DeleteMembersResponse> DeleteMembersAsync(DeleteMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembersResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMembership

        internal virtual DisassociateMembershipResponse DisassociateMembership(DisassociateMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMembershipResponseUnmarshaller.Instance;

            return Invoke<DisassociateMembershipResponse>(request, options);
        }



        /// <summary>
        /// Removes the member account from the specified behavior graph. This operation can only
        /// be called by a member account that has the <code>ENABLED</code> status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMembership service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.ConflictException">
        /// The request attempted an invalid action.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DisassociateMembership">REST API Reference for DisassociateMembership Operation</seealso>
        public virtual Task<DisassociateMembershipResponse> DisassociateMembershipAsync(DisassociateMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMembers

        internal virtual GetMembersResponse GetMembers(GetMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembersResponseUnmarshaller.Instance;

            return Invoke<GetMembersResponse>(request, options);
        }



        /// <summary>
        /// Returns the membership details for specified member accounts for a behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMembers service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/GetMembers">REST API Reference for GetMembers Operation</seealso>
        public virtual Task<GetMembersResponse> GetMembersAsync(GetMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembersResponseUnmarshaller.Instance;

            return InvokeAsync<GetMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGraphs

        internal virtual ListGraphsResponse ListGraphs(ListGraphsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGraphsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphsResponseUnmarshaller.Instance;

            return Invoke<ListGraphsResponse>(request, options);
        }



        /// <summary>
        /// Returns the list of behavior graphs that the calling account is a master of. This
        /// operation can only be called by a master account.
        /// 
        ///  
        /// <para>
        /// Because an account can currently only be the master of one behavior graph within a
        /// Region, the results always contain a single graph.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGraphs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGraphs service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListGraphs">REST API Reference for ListGraphs Operation</seealso>
        public virtual Task<ListGraphsResponse> ListGraphsAsync(ListGraphsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGraphsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGraphsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInvitations

        internal virtual ListInvitationsResponse ListInvitations(ListInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return Invoke<ListInvitationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the list of open and accepted behavior graph invitations for the member
        /// account. This operation can only be called by a member account.
        /// 
        ///  
        /// <para>
        /// Open invitations are invitations that the member account has not responded to.
        /// </para>
        ///  
        /// <para>
        /// The results do not include behavior graphs for which the member account declined the
        /// invitation. The results also do not include behavior graphs that the member account
        /// resigned from or was removed from.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual Task<ListInvitationsResponse> ListInvitationsAsync(ListInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInvitationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMembers

        internal virtual ListMembersResponse ListMembers(ListMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return Invoke<ListMembersResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the list of member accounts for a behavior graph. Does not return member
        /// accounts that were removed from the behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return InvokeAsync<ListMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectInvitation

        internal virtual RejectInvitationResponse RejectInvitation(RejectInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectInvitationResponseUnmarshaller.Instance;

            return Invoke<RejectInvitationResponse>(request, options);
        }



        /// <summary>
        /// Rejects an invitation to contribute the account data to a behavior graph. This operation
        /// must be called by a member account that has the <code>INVITED</code> status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectInvitation service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.ConflictException">
        /// The request attempted an invalid action.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/RejectInvitation">REST API Reference for RejectInvitation Operation</seealso>
        public virtual Task<RejectInvitationResponse> RejectInvitationAsync(RejectInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<RejectInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMonitoringMember

        internal virtual StartMonitoringMemberResponse StartMonitoringMember(StartMonitoringMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMonitoringMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMonitoringMemberResponseUnmarshaller.Instance;

            return Invoke<StartMonitoringMemberResponse>(request, options);
        }



        /// <summary>
        /// Sends a request to enable data ingest for a member account that has a status of <code>ACCEPTED_BUT_DISABLED</code>.
        /// 
        ///  
        /// <para>
        /// For valid member accounts, the status is updated as follows.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If Detective enabled the member account, then the new status is <code>ENABLED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If Detective cannot enable the member account, the status remains <code>ACCEPTED_BUT_DISABLED</code>.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMonitoringMember service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.ConflictException">
        /// The request attempted an invalid action.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ServiceQuotaExceededException">
        /// This request cannot be completed for one of the following reasons.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The request would cause the number of member accounts in the behavior graph to exceed
        /// the maximum allowed. A behavior graph cannot have more than 1000 member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The request would cause the data rate for the behavior graph to exceed the maximum
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Detective is unable to verify the data rate for the member account. This is usually
        /// because the member account is not enrolled in Amazon GuardDuty. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/StartMonitoringMember">REST API Reference for StartMonitoringMember Operation</seealso>
        public virtual Task<StartMonitoringMemberResponse> StartMonitoringMemberAsync(StartMonitoringMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMonitoringMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMonitoringMemberResponseUnmarshaller.Instance;

            return InvokeAsync<StartMonitoringMemberResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}