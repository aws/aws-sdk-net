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

#pragma warning disable CS1570
namespace Amazon.Detective
{
    /// <summary>
    /// <para>Implementation for accessing Detective</para>
    ///
    /// Detective uses machine learning and purpose-built visualizations to help you to analyze
    /// and investigate security issues across your Amazon Web Services (Amazon Web Services)
    /// workloads. Detective automatically extracts time-based events such as login attempts,
    /// API calls, and network traffic from CloudTrail and Amazon Virtual Private Cloud (Amazon
    /// VPC) flow logs. It also extracts findings detected by Amazon GuardDuty.
    /// 
    ///  
    /// <para>
    /// The Detective API primarily supports the creation and management of behavior graphs.
    /// A behavior graph contains the extracted data from a set of member accounts, and is
    /// created and managed by an administrator account.
    /// </para>
    ///  
    /// <para>
    /// To add a member account to the behavior graph, the administrator account sends an
    /// invitation to the account. When the account accepts the invitation, it becomes a member
    /// account in the behavior graph.
    /// </para>
    ///  
    /// <para>
    /// Detective is also integrated with Organizations. The organization management account
    /// designates the Detective administrator account for the organization. That account
    /// becomes the administrator account for the organization behavior graph. The Detective
    /// administrator account is also the delegated administrator account for Detective in
    /// Organizations.
    /// </para>
    ///  
    /// <para>
    /// The Detective administrator account can enable any organization account as a member
    /// account in the organization behavior graph. The organization accounts do not receive
    /// invitations. The Detective administrator account can also invite other accounts to
    /// the organization behavior graph.
    /// </para>
    ///  
    /// <para>
    /// Every behavior graph is specific to a Region. You can only use the API to manage behavior
    /// graphs that belong to the Region that is associated with the currently selected endpoint.
    /// </para>
    ///  
    /// <para>
    /// The administrator account for a behavior graph can use the Detective API to do the
    /// following:
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
    ///  </li> <li> 
    /// <para>
    /// Apply tags to a behavior graph.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The organization management account can use the Detective API to select the delegated
    /// administrator for Detective.
    /// </para>
    ///  
    /// <para>
    /// The Detective administrator account for an organization can use the Detective API
    /// to do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Perform all of the functions of an administrator account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Determine whether to automatically enable new organization accounts as member accounts
    /// in the organization behavior graph.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// An invited member account can use the Detective API to do the following:
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
    ///  <note> 
    /// <para>
    /// We replaced the term "master account" with the term "administrator account". An administrator
    /// account is used to centrally manage multiple accounts. In the case of Detective, the
    /// administrator account manages the accounts in their behavior graph.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonDetectiveClient : AmazonServiceClient, IAmazonDetective
    {
        private static IServiceMetadata serviceMetadata = new AmazonDetectiveMetadata();
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDetectiveEndpointResolver());
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
        /// Accepts an invitation for the member account to contribute data to a behavior graph.
        /// This operation can only be called by an invited member account. 
        /// 
        ///  
        /// <para>
        /// The request provides the ARN of behavior graph.
        /// </para>
        ///  
        /// <para>
        /// The member account status in the graph must be <c>INVITED</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
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
        public virtual AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request)
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
        /// The member account status in the graph must be <c>INVITED</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
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
        
        #region  BatchGetGraphMemberDatasources


        /// <summary>
        /// Gets data source package information for the behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetGraphMemberDatasources service method.</param>
        /// 
        /// <returns>The response from the BatchGetGraphMemberDatasources service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/BatchGetGraphMemberDatasources">REST API Reference for BatchGetGraphMemberDatasources Operation</seealso>
        public virtual BatchGetGraphMemberDatasourcesResponse BatchGetGraphMemberDatasources(BatchGetGraphMemberDatasourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetGraphMemberDatasourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetGraphMemberDatasourcesResponseUnmarshaller.Instance;

            return Invoke<BatchGetGraphMemberDatasourcesResponse>(request, options);
        }


        /// <summary>
        /// Gets data source package information for the behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetGraphMemberDatasources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetGraphMemberDatasources service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/BatchGetGraphMemberDatasources">REST API Reference for BatchGetGraphMemberDatasources Operation</seealso>
        public virtual Task<BatchGetGraphMemberDatasourcesResponse> BatchGetGraphMemberDatasourcesAsync(BatchGetGraphMemberDatasourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetGraphMemberDatasourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetGraphMemberDatasourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetGraphMemberDatasourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetMembershipDatasources


        /// <summary>
        /// Gets information on the data source package history for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMembershipDatasources service method.</param>
        /// 
        /// <returns>The response from the BatchGetMembershipDatasources service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/BatchGetMembershipDatasources">REST API Reference for BatchGetMembershipDatasources Operation</seealso>
        public virtual BatchGetMembershipDatasourcesResponse BatchGetMembershipDatasources(BatchGetMembershipDatasourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetMembershipDatasourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetMembershipDatasourcesResponseUnmarshaller.Instance;

            return Invoke<BatchGetMembershipDatasourcesResponse>(request, options);
        }


        /// <summary>
        /// Gets information on the data source package history for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMembershipDatasources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetMembershipDatasources service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/BatchGetMembershipDatasources">REST API Reference for BatchGetMembershipDatasources Operation</seealso>
        public virtual Task<BatchGetMembershipDatasourcesResponse> BatchGetMembershipDatasourcesAsync(BatchGetMembershipDatasourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetMembershipDatasourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetMembershipDatasourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetMembershipDatasourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGraph


        /// <summary>
        /// Creates a new behavior graph for the calling account, and sets that account as the
        /// administrator account. This operation is called by the account that is enabling Detective.
        /// 
        ///  
        /// <para>
        /// The operation also enables Detective for the calling account in the currently selected
        /// Region. It returns the ARN of the new behavior graph.
        /// </para>
        ///  
        /// <para>
        ///  <c>CreateGraph</c> triggers a process to create the corresponding data tables for
        /// the new behavior graph.
        /// </para>
        ///  
        /// <para>
        /// An account can only be the administrator account for one behavior graph within a Region.
        /// If the same account calls <c>CreateGraph</c> with the same administrator account,
        /// it always returns the same behavior graph ARN. It does not create a new behavior graph.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraph service method.</param>
        /// 
        /// <returns>The response from the CreateGraph service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
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
        /// This request cannot be completed if it would cause the number of member accounts in
        /// the behavior graph to exceed the maximum allowed. A behavior graph cannot have more
        /// than 1,200 member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This request cannot be completed if the current volume ingested is above the limit
        /// of 10 TB per day. Detective will not allow you to add additional member accounts.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/CreateGraph">REST API Reference for CreateGraph Operation</seealso>
        public virtual CreateGraphResponse CreateGraph(CreateGraphRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphResponseUnmarshaller.Instance;

            return Invoke<CreateGraphResponse>(request, options);
        }


        /// <summary>
        /// Creates a new behavior graph for the calling account, and sets that account as the
        /// administrator account. This operation is called by the account that is enabling Detective.
        /// 
        ///  
        /// <para>
        /// The operation also enables Detective for the calling account in the currently selected
        /// Region. It returns the ARN of the new behavior graph.
        /// </para>
        ///  
        /// <para>
        ///  <c>CreateGraph</c> triggers a process to create the corresponding data tables for
        /// the new behavior graph.
        /// </para>
        ///  
        /// <para>
        /// An account can only be the administrator account for one behavior graph within a Region.
        /// If the same account calls <c>CreateGraph</c> with the same administrator account,
        /// it always returns the same behavior graph ARN. It does not create a new behavior graph.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGraph service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
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
        /// This request cannot be completed if it would cause the number of member accounts in
        /// the behavior graph to exceed the maximum allowed. A behavior graph cannot have more
        /// than 1,200 member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This request cannot be completed if the current volume ingested is above the limit
        /// of 10 TB per day. Detective will not allow you to add additional member accounts.
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


        /// <summary>
        /// <c>CreateMembers</c> is used to send invitations to accounts. For the organization
        /// behavior graph, the Detective administrator account uses <c>CreateMembers</c> to enable
        /// organization accounts as member accounts.
        /// 
        ///  
        /// <para>
        /// For invited accounts, <c>CreateMembers</c> sends a request to invite the specified
        /// Amazon Web Services accounts to be member accounts in the behavior graph. This operation
        /// can only be called by the administrator account for a behavior graph. 
        /// </para>
        ///  
        /// <para>
        ///  <c>CreateMembers</c> verifies the accounts and then invites the verified accounts.
        /// The administrator can optionally specify to not send invitation emails to the member
        /// accounts. This would be used when the administrator manages their member accounts
        /// centrally.
        /// </para>
        ///  
        /// <para>
        /// For organization accounts in the organization behavior graph, <c>CreateMembers</c>
        /// attempts to enable the accounts. The organization accounts do not receive invitations.
        /// </para>
        ///  
        /// <para>
        /// The request provides the behavior graph ARN and the list of accounts to invite or
        /// to enable.
        /// </para>
        ///  
        /// <para>
        /// The response separates the requested accounts into two lists:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The accounts that <c>CreateMembers</c> was able to process. For invited accounts,
        /// includes member accounts that are being verified, that have passed verification and
        /// are to be invited, and that have failed verification. For organization accounts in
        /// the organization behavior graph, includes accounts that can be enabled and that cannot
        /// be enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The accounts that <c>CreateMembers</c> was unable to process. This list includes accounts
        /// that were already invited to be member accounts in the behavior graph.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers service method.</param>
        /// 
        /// <returns>The response from the CreateMembers service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// This request cannot be completed if it would cause the number of member accounts in
        /// the behavior graph to exceed the maximum allowed. A behavior graph cannot have more
        /// than 1,200 member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This request cannot be completed if the current volume ingested is above the limit
        /// of 10 TB per day. Detective will not allow you to add additional member accounts.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        public virtual CreateMembersResponse CreateMembers(CreateMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembersResponseUnmarshaller.Instance;

            return Invoke<CreateMembersResponse>(request, options);
        }


        /// <summary>
        /// <c>CreateMembers</c> is used to send invitations to accounts. For the organization
        /// behavior graph, the Detective administrator account uses <c>CreateMembers</c> to enable
        /// organization accounts as member accounts.
        /// 
        ///  
        /// <para>
        /// For invited accounts, <c>CreateMembers</c> sends a request to invite the specified
        /// Amazon Web Services accounts to be member accounts in the behavior graph. This operation
        /// can only be called by the administrator account for a behavior graph. 
        /// </para>
        ///  
        /// <para>
        ///  <c>CreateMembers</c> verifies the accounts and then invites the verified accounts.
        /// The administrator can optionally specify to not send invitation emails to the member
        /// accounts. This would be used when the administrator manages their member accounts
        /// centrally.
        /// </para>
        ///  
        /// <para>
        /// For organization accounts in the organization behavior graph, <c>CreateMembers</c>
        /// attempts to enable the accounts. The organization accounts do not receive invitations.
        /// </para>
        ///  
        /// <para>
        /// The request provides the behavior graph ARN and the list of accounts to invite or
        /// to enable.
        /// </para>
        ///  
        /// <para>
        /// The response separates the requested accounts into two lists:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The accounts that <c>CreateMembers</c> was able to process. For invited accounts,
        /// includes member accounts that are being verified, that have passed verification and
        /// are to be invited, and that have failed verification. For organization accounts in
        /// the organization behavior graph, includes accounts that can be enabled and that cannot
        /// be enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The accounts that <c>CreateMembers</c> was unable to process. This list includes accounts
        /// that were already invited to be member accounts in the behavior graph.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMembers service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// This request cannot be completed if it would cause the number of member accounts in
        /// the behavior graph to exceed the maximum allowed. A behavior graph cannot have more
        /// than 1,200 member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This request cannot be completed if the current volume ingested is above the limit
        /// of 10 TB per day. Detective will not allow you to add additional member accounts.
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


        /// <summary>
        /// Disables the specified behavior graph and queues it to be deleted. This operation
        /// removes the behavior graph from each member account's list of behavior graphs.
        /// 
        ///  
        /// <para>
        ///  <c>DeleteGraph</c> can only be called by the administrator account for a behavior
        /// graph.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraph service method.</param>
        /// 
        /// <returns>The response from the DeleteGraph service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DeleteGraph">REST API Reference for DeleteGraph Operation</seealso>
        public virtual DeleteGraphResponse DeleteGraph(DeleteGraphRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphResponseUnmarshaller.Instance;

            return Invoke<DeleteGraphResponse>(request, options);
        }


        /// <summary>
        /// Disables the specified behavior graph and queues it to be deleted. This operation
        /// removes the behavior graph from each member account's list of behavior graphs.
        /// 
        ///  
        /// <para>
        ///  <c>DeleteGraph</c> can only be called by the administrator account for a behavior
        /// graph.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGraph service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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


        /// <summary>
        /// Removes the specified member accounts from the behavior graph. The removed accounts
        /// no longer contribute data to the behavior graph. This operation can only be called
        /// by the administrator account for the behavior graph.
        /// 
        ///  
        /// <para>
        /// For invited accounts, the removed accounts are deleted from the list of accounts in
        /// the behavior graph. To restore the account, the administrator account must send another
        /// invitation.
        /// </para>
        ///  
        /// <para>
        /// For organization accounts in the organization behavior graph, the Detective administrator
        /// account can always enable the organization account again. Organization accounts that
        /// are not enabled as member accounts are not included in the <c>ListMembers</c> results
        /// for the organization behavior graph.
        /// </para>
        ///  
        /// <para>
        /// An administrator account cannot use <c>DeleteMembers</c> to remove their own account
        /// from the behavior graph. To disable a behavior graph, the administrator account uses
        /// the <c>DeleteGraph</c> API method.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers service method.</param>
        /// 
        /// <returns>The response from the DeleteMembers service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
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
        public virtual DeleteMembersResponse DeleteMembers(DeleteMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembersResponseUnmarshaller.Instance;

            return Invoke<DeleteMembersResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified member accounts from the behavior graph. The removed accounts
        /// no longer contribute data to the behavior graph. This operation can only be called
        /// by the administrator account for the behavior graph.
        /// 
        ///  
        /// <para>
        /// For invited accounts, the removed accounts are deleted from the list of accounts in
        /// the behavior graph. To restore the account, the administrator account must send another
        /// invitation.
        /// </para>
        ///  
        /// <para>
        /// For organization accounts in the organization behavior graph, the Detective administrator
        /// account can always enable the organization account again. Organization accounts that
        /// are not enabled as member accounts are not included in the <c>ListMembers</c> results
        /// for the organization behavior graph.
        /// </para>
        ///  
        /// <para>
        /// An administrator account cannot use <c>DeleteMembers</c> to remove their own account
        /// from the behavior graph. To disable a behavior graph, the administrator account uses
        /// the <c>DeleteGraph</c> API method.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMembers service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
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
        
        #region  DescribeOrganizationConfiguration


        /// <summary>
        /// Returns information about the configuration for the organization behavior graph. Currently
        /// indicates whether to automatically enable new organization accounts as member accounts.
        /// 
        ///  
        /// <para>
        /// Can only be called by the Detective administrator account for the organization. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfiguration service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        public virtual DescribeOrganizationConfigurationResponse DescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the configuration for the organization behavior graph. Currently
        /// indicates whether to automatically enable new organization accounts as member accounts.
        /// 
        ///  
        /// <para>
        /// Can only be called by the Detective administrator account for the organization. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfiguration service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        public virtual Task<DescribeOrganizationConfigurationResponse> DescribeOrganizationConfigurationAsync(DescribeOrganizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeOrganizationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableOrganizationAdminAccount


        /// <summary>
        /// Removes the Detective administrator account in the current Region. Deletes the organization
        /// behavior graph.
        /// 
        ///  
        /// <para>
        /// Can only be called by the organization management account.
        /// </para>
        ///  
        /// <para>
        /// Removing the Detective administrator account does not affect the delegated administrator
        /// account for Detective in Organizations.
        /// </para>
        ///  
        /// <para>
        /// To remove the delegated administrator account in Organizations, use the Organizations
        /// API. Removing the delegated administrator account also removes the Detective administrator
        /// account in all Regions, except for Regions where the Detective administrator account
        /// is the organization management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the DisableOrganizationAdminAccount service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        public virtual DisableOrganizationAdminAccountResponse DisableOrganizationAdminAccount(DisableOrganizationAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableOrganizationAdminAccountResponseUnmarshaller.Instance;

            return Invoke<DisableOrganizationAdminAccountResponse>(request, options);
        }


        /// <summary>
        /// Removes the Detective administrator account in the current Region. Deletes the organization
        /// behavior graph.
        /// 
        ///  
        /// <para>
        /// Can only be called by the organization management account.
        /// </para>
        ///  
        /// <para>
        /// Removing the Detective administrator account does not affect the delegated administrator
        /// account for Detective in Organizations.
        /// </para>
        ///  
        /// <para>
        /// To remove the delegated administrator account in Organizations, use the Organizations
        /// API. Removing the delegated administrator account also removes the Detective administrator
        /// account in all Regions, except for Regions where the Detective administrator account
        /// is the organization management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableOrganizationAdminAccount service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        public virtual Task<DisableOrganizationAdminAccountResponse> DisableOrganizationAdminAccountAsync(DisableOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableOrganizationAdminAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableOrganizationAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMembership


        /// <summary>
        /// Removes the member account from the specified behavior graph. This operation can only
        /// be called by an invited member account that has the <c>ENABLED</c> status.
        /// 
        ///  
        /// <para>
        ///  <c>DisassociateMembership</c> cannot be called by an organization account in the
        /// organization behavior graph. For the organization behavior graph, the Detective administrator
        /// account determines which organization accounts to enable or disable as member accounts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembership service method.</param>
        /// 
        /// <returns>The response from the DisassociateMembership service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
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
        public virtual DisassociateMembershipResponse DisassociateMembership(DisassociateMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMembershipResponseUnmarshaller.Instance;

            return Invoke<DisassociateMembershipResponse>(request, options);
        }


        /// <summary>
        /// Removes the member account from the specified behavior graph. This operation can only
        /// be called by an invited member account that has the <c>ENABLED</c> status.
        /// 
        ///  
        /// <para>
        ///  <c>DisassociateMembership</c> cannot be called by an organization account in the
        /// organization behavior graph. For the organization behavior graph, the Detective administrator
        /// account determines which organization accounts to enable or disable as member accounts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMembership service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
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
        
        #region  EnableOrganizationAdminAccount


        /// <summary>
        /// Designates the Detective administrator account for the organization in the current
        /// Region.
        /// 
        ///  
        /// <para>
        /// If the account does not have Detective enabled, then enables Detective for that account
        /// and creates a new behavior graph.
        /// </para>
        ///  
        /// <para>
        /// Can only be called by the organization management account.
        /// </para>
        ///  
        /// <para>
        /// If the organization has a delegated administrator account in Organizations, then the
        /// Detective administrator account must be either the delegated administrator account
        /// or the organization management account.
        /// </para>
        ///  
        /// <para>
        /// If the organization does not have a delegated administrator account in Organizations,
        /// then you can choose any account in the organization. If you choose an account other
        /// than the organization management account, Detective calls Organizations to make that
        /// account the delegated administrator account for Detective. The organization management
        /// account cannot be the delegated administrator account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the EnableOrganizationAdminAccount service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        public virtual EnableOrganizationAdminAccountResponse EnableOrganizationAdminAccount(EnableOrganizationAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableOrganizationAdminAccountResponseUnmarshaller.Instance;

            return Invoke<EnableOrganizationAdminAccountResponse>(request, options);
        }


        /// <summary>
        /// Designates the Detective administrator account for the organization in the current
        /// Region.
        /// 
        ///  
        /// <para>
        /// If the account does not have Detective enabled, then enables Detective for that account
        /// and creates a new behavior graph.
        /// </para>
        ///  
        /// <para>
        /// Can only be called by the organization management account.
        /// </para>
        ///  
        /// <para>
        /// If the organization has a delegated administrator account in Organizations, then the
        /// Detective administrator account must be either the delegated administrator account
        /// or the organization management account.
        /// </para>
        ///  
        /// <para>
        /// If the organization does not have a delegated administrator account in Organizations,
        /// then you can choose any account in the organization. If you choose an account other
        /// than the organization management account, Detective calls Organizations to make that
        /// account the delegated administrator account for Detective. The organization management
        /// account cannot be the delegated administrator account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableOrganizationAdminAccount service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        public virtual Task<EnableOrganizationAdminAccountResponse> EnableOrganizationAdminAccountAsync(EnableOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableOrganizationAdminAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableOrganizationAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInvestigation


        /// <summary>
        /// Detective investigations lets you investigate IAM users and IAM roles using indicators
        /// of compromise. An indicator of compromise (IOC) is an artifact observed in or on a
        /// network, system, or environment that can (with a high level of confidence) identify
        /// malicious activity or a security incident. <c>GetInvestigation</c> returns the investigation
        /// results of an investigation for a behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvestigation service method.</param>
        /// 
        /// <returns>The response from the GetInvestigation service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/GetInvestigation">REST API Reference for GetInvestigation Operation</seealso>
        public virtual GetInvestigationResponse GetInvestigation(GetInvestigationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInvestigationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvestigationResponseUnmarshaller.Instance;

            return Invoke<GetInvestigationResponse>(request, options);
        }


        /// <summary>
        /// Detective investigations lets you investigate IAM users and IAM roles using indicators
        /// of compromise. An indicator of compromise (IOC) is an artifact observed in or on a
        /// network, system, or environment that can (with a high level of confidence) identify
        /// malicious activity or a security incident. <c>GetInvestigation</c> returns the investigation
        /// results of an investigation for a behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvestigation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInvestigation service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/GetInvestigation">REST API Reference for GetInvestigation Operation</seealso>
        public virtual Task<GetInvestigationResponse> GetInvestigationAsync(GetInvestigationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInvestigationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvestigationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInvestigationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMembers


        /// <summary>
        /// Returns the membership details for specified member accounts for a behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembers service method.</param>
        /// 
        /// <returns>The response from the GetMembers service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/GetMembers">REST API Reference for GetMembers Operation</seealso>
        public virtual GetMembersResponse GetMembers(GetMembersRequest request)
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
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/GetMembers">REST API Reference for GetMembers Operation</seealso>
        public virtual Task<GetMembersResponse> GetMembersAsync(GetMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembersResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDatasourcePackages


        /// <summary>
        /// Lists data source packages in the behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasourcePackages service method.</param>
        /// 
        /// <returns>The response from the ListDatasourcePackages service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListDatasourcePackages">REST API Reference for ListDatasourcePackages Operation</seealso>
        public virtual ListDatasourcePackagesResponse ListDatasourcePackages(ListDatasourcePackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasourcePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasourcePackagesResponseUnmarshaller.Instance;

            return Invoke<ListDatasourcePackagesResponse>(request, options);
        }


        /// <summary>
        /// Lists data source packages in the behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasourcePackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasourcePackages service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListDatasourcePackages">REST API Reference for ListDatasourcePackages Operation</seealso>
        public virtual Task<ListDatasourcePackagesResponse> ListDatasourcePackagesAsync(ListDatasourcePackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasourcePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasourcePackagesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDatasourcePackagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGraphs


        /// <summary>
        /// Returns the list of behavior graphs that the calling account is an administrator account
        /// of. This operation can only be called by an administrator account.
        /// 
        ///  
        /// <para>
        /// Because an account can currently only be the administrator of one behavior graph within
        /// a Region, the results always contain a single behavior graph.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGraphs service method.</param>
        /// 
        /// <returns>The response from the ListGraphs service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListGraphs">REST API Reference for ListGraphs Operation</seealso>
        public virtual ListGraphsResponse ListGraphs(ListGraphsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGraphsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphsResponseUnmarshaller.Instance;

            return Invoke<ListGraphsResponse>(request, options);
        }


        /// <summary>
        /// Returns the list of behavior graphs that the calling account is an administrator account
        /// of. This operation can only be called by an administrator account.
        /// 
        ///  
        /// <para>
        /// Because an account can currently only be the administrator of one behavior graph within
        /// a Region, the results always contain a single behavior graph.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGraphs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGraphs service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
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
        
        #region  ListIndicators


        /// <summary>
        /// Gets the indicators from an investigation. You can use the information from the indicators
        /// to determine if an IAM user and/or IAM role is involved in an unusual activity that
        /// could indicate malicious behavior and its impact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndicators service method.</param>
        /// 
        /// <returns>The response from the ListIndicators service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListIndicators">REST API Reference for ListIndicators Operation</seealso>
        public virtual ListIndicatorsResponse ListIndicators(ListIndicatorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndicatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndicatorsResponseUnmarshaller.Instance;

            return Invoke<ListIndicatorsResponse>(request, options);
        }


        /// <summary>
        /// Gets the indicators from an investigation. You can use the information from the indicators
        /// to determine if an IAM user and/or IAM role is involved in an unusual activity that
        /// could indicate malicious behavior and its impact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndicators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIndicators service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListIndicators">REST API Reference for ListIndicators Operation</seealso>
        public virtual Task<ListIndicatorsResponse> ListIndicatorsAsync(ListIndicatorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndicatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndicatorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListIndicatorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInvestigations


        /// <summary>
        /// Detective investigations lets you investigate IAM users and IAM roles using indicators
        /// of compromise. An indicator of compromise (IOC) is an artifact observed in or on a
        /// network, system, or environment that can (with a high level of confidence) identify
        /// malicious activity or a security incident. <c>ListInvestigations</c> lists all active
        /// Detective investigations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvestigations service method.</param>
        /// 
        /// <returns>The response from the ListInvestigations service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListInvestigations">REST API Reference for ListInvestigations Operation</seealso>
        public virtual ListInvestigationsResponse ListInvestigations(ListInvestigationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvestigationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvestigationsResponseUnmarshaller.Instance;

            return Invoke<ListInvestigationsResponse>(request, options);
        }


        /// <summary>
        /// Detective investigations lets you investigate IAM users and IAM roles using indicators
        /// of compromise. An indicator of compromise (IOC) is an artifact observed in or on a
        /// network, system, or environment that can (with a high level of confidence) identify
        /// malicious activity or a security incident. <c>ListInvestigations</c> lists all active
        /// Detective investigations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvestigations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInvestigations service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListInvestigations">REST API Reference for ListInvestigations Operation</seealso>
        public virtual Task<ListInvestigationsResponse> ListInvestigationsAsync(ListInvestigationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvestigationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvestigationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListInvestigationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInvitations


        /// <summary>
        /// Retrieves the list of open and accepted behavior graph invitations for the member
        /// account. This operation can only be called by an invited member account.
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
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual ListInvitationsResponse ListInvitations(ListInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return Invoke<ListInvitationsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the list of open and accepted behavior graph invitations for the member
        /// account. This operation can only be called by an invited member account.
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
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
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


        /// <summary>
        /// Retrieves the list of member accounts for a behavior graph.
        /// 
        ///  
        /// <para>
        /// For invited accounts, the results do not include member accounts that were removed
        /// from the behavior graph.
        /// </para>
        ///  
        /// <para>
        /// For the organization behavior graph, the results do not include organization accounts
        /// that the Detective administrator account has not enabled as member accounts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual ListMembersResponse ListMembers(ListMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return Invoke<ListMembersResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the list of member accounts for a behavior graph.
        /// 
        ///  
        /// <para>
        /// For invited accounts, the results do not include member accounts that were removed
        /// from the behavior graph.
        /// </para>
        ///  
        /// <para>
        /// For the organization behavior graph, the results do not include organization accounts
        /// that the Detective administrator account has not enabled as member accounts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOrganizationAdminAccounts


        /// <summary>
        /// Returns information about the Detective administrator account for an organization.
        /// Can only be called by the organization management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationAdminAccounts service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationAdminAccounts service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
        public virtual ListOrganizationAdminAccountsResponse ListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationAdminAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationAdminAccountsResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationAdminAccountsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the Detective administrator account for an organization.
        /// Can only be called by the organization management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationAdminAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationAdminAccounts service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
        public virtual Task<ListOrganizationAdminAccountsResponse> ListOrganizationAdminAccountsAsync(ListOrganizationAdminAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationAdminAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationAdminAccountsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOrganizationAdminAccountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns the tag values that are assigned to a behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Returns the tag values that are assigned to a behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectInvitation


        /// <summary>
        /// Rejects an invitation to contribute the account data to a behavior graph. This operation
        /// must be called by an invited member account that has the <c>INVITED</c> status.
        /// 
        ///  
        /// <para>
        ///  <c>RejectInvitation</c> cannot be called by an organization account in the organization
        /// behavior graph. In the organization behavior graph, organization accounts do not receive
        /// an invitation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectInvitation service method.</param>
        /// 
        /// <returns>The response from the RejectInvitation service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
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
        public virtual RejectInvitationResponse RejectInvitation(RejectInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectInvitationResponseUnmarshaller.Instance;

            return Invoke<RejectInvitationResponse>(request, options);
        }


        /// <summary>
        /// Rejects an invitation to contribute the account data to a behavior graph. This operation
        /// must be called by an invited member account that has the <c>INVITED</c> status.
        /// 
        ///  
        /// <para>
        ///  <c>RejectInvitation</c> cannot be called by an organization account in the organization
        /// behavior graph. In the organization behavior graph, organization accounts do not receive
        /// an invitation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectInvitation service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
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
        
        #region  StartInvestigation


        /// <summary>
        /// Detective investigations lets you investigate IAM users and IAM roles using indicators
        /// of compromise. An indicator of compromise (IOC) is an artifact observed in or on a
        /// network, system, or environment that can (with a high level of confidence) identify
        /// malicious activity or a security incident. <c>StartInvestigation</c> initiates an
        /// investigation on an entity in a behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInvestigation service method.</param>
        /// 
        /// <returns>The response from the StartInvestigation service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/StartInvestigation">REST API Reference for StartInvestigation Operation</seealso>
        public virtual StartInvestigationResponse StartInvestigation(StartInvestigationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInvestigationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInvestigationResponseUnmarshaller.Instance;

            return Invoke<StartInvestigationResponse>(request, options);
        }


        /// <summary>
        /// Detective investigations lets you investigate IAM users and IAM roles using indicators
        /// of compromise. An indicator of compromise (IOC) is an artifact observed in or on a
        /// network, system, or environment that can (with a high level of confidence) identify
        /// malicious activity or a security incident. <c>StartInvestigation</c> initiates an
        /// investigation on an entity in a behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInvestigation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartInvestigation service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/StartInvestigation">REST API Reference for StartInvestigation Operation</seealso>
        public virtual Task<StartInvestigationResponse> StartInvestigationAsync(StartInvestigationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInvestigationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInvestigationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartInvestigationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMonitoringMember


        /// <summary>
        /// Sends a request to enable data ingest for a member account that has a status of <c>ACCEPTED_BUT_DISABLED</c>.
        /// 
        ///  
        /// <para>
        /// For valid member accounts, the status is updated as follows.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If Detective enabled the member account, then the new status is <c>ENABLED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If Detective cannot enable the member account, the status remains <c>ACCEPTED_BUT_DISABLED</c>.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringMember service method.</param>
        /// 
        /// <returns>The response from the StartMonitoringMember service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
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
        /// This request cannot be completed if it would cause the number of member accounts in
        /// the behavior graph to exceed the maximum allowed. A behavior graph cannot have more
        /// than 1,200 member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This request cannot be completed if the current volume ingested is above the limit
        /// of 10 TB per day. Detective will not allow you to add additional member accounts.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/StartMonitoringMember">REST API Reference for StartMonitoringMember Operation</seealso>
        public virtual StartMonitoringMemberResponse StartMonitoringMember(StartMonitoringMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMonitoringMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMonitoringMemberResponseUnmarshaller.Instance;

            return Invoke<StartMonitoringMemberResponse>(request, options);
        }


        /// <summary>
        /// Sends a request to enable data ingest for a member account that has a status of <c>ACCEPTED_BUT_DISABLED</c>.
        /// 
        ///  
        /// <para>
        /// For valid member accounts, the status is updated as follows.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If Detective enabled the member account, then the new status is <c>ENABLED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If Detective cannot enable the member account, the status remains <c>ACCEPTED_BUT_DISABLED</c>.
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
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
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
        /// This request cannot be completed if it would cause the number of member accounts in
        /// the behavior graph to exceed the maximum allowed. A behavior graph cannot have more
        /// than 1,200 member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This request cannot be completed if the current volume ingested is above the limit
        /// of 10 TB per day. Detective will not allow you to add additional member accounts.
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
        
        #region  TagResource


        /// <summary>
        /// Applies tag values to a behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Applies tag values to a behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from a behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDatasourcePackages


        /// <summary>
        /// Starts a data source packages for the behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatasourcePackages service method.</param>
        /// 
        /// <returns>The response from the UpdateDatasourcePackages service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// This request cannot be completed if it would cause the number of member accounts in
        /// the behavior graph to exceed the maximum allowed. A behavior graph cannot have more
        /// than 1,200 member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This request cannot be completed if the current volume ingested is above the limit
        /// of 10 TB per day. Detective will not allow you to add additional member accounts.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/UpdateDatasourcePackages">REST API Reference for UpdateDatasourcePackages Operation</seealso>
        public virtual UpdateDatasourcePackagesResponse UpdateDatasourcePackages(UpdateDatasourcePackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasourcePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasourcePackagesResponseUnmarshaller.Instance;

            return Invoke<UpdateDatasourcePackagesResponse>(request, options);
        }


        /// <summary>
        /// Starts a data source packages for the behavior graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatasourcePackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDatasourcePackages service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
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
        /// This request cannot be completed if it would cause the number of member accounts in
        /// the behavior graph to exceed the maximum allowed. A behavior graph cannot have more
        /// than 1,200 member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This request cannot be completed if the current volume ingested is above the limit
        /// of 10 TB per day. Detective will not allow you to add additional member accounts.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/UpdateDatasourcePackages">REST API Reference for UpdateDatasourcePackages Operation</seealso>
        public virtual Task<UpdateDatasourcePackagesResponse> UpdateDatasourcePackagesAsync(UpdateDatasourcePackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasourcePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasourcePackagesResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDatasourcePackagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateInvestigationState


        /// <summary>
        /// Updates the state of an investigation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInvestigationState service method.</param>
        /// 
        /// <returns>The response from the UpdateInvestigationState service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/UpdateInvestigationState">REST API Reference for UpdateInvestigationState Operation</seealso>
        public virtual UpdateInvestigationStateResponse UpdateInvestigationState(UpdateInvestigationStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInvestigationStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInvestigationStateResponseUnmarshaller.Instance;

            return Invoke<UpdateInvestigationStateResponse>(request, options);
        }


        /// <summary>
        /// Updates the state of an investigation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInvestigationState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInvestigationState service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/UpdateInvestigationState">REST API Reference for UpdateInvestigationState Operation</seealso>
        public virtual Task<UpdateInvestigationStateResponse> UpdateInvestigationStateAsync(UpdateInvestigationStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInvestigationStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInvestigationStateResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateInvestigationStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateOrganizationConfiguration


        /// <summary>
        /// Updates the configuration for the Organizations integration in the current Region.
        /// Can only be called by the Detective administrator account for the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateOrganizationConfiguration service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        public virtual UpdateOrganizationConfigurationResponse UpdateOrganizationConfiguration(UpdateOrganizationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateOrganizationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates the configuration for the Organizations integration in the current Region.
        /// Can only be called by the Detective administrator account for the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOrganizationConfiguration service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.AccessDeniedException">
        /// The request issuer does not have permission to access this resource or perform this
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.TooManyRequestsException">
        /// The request cannot be completed because too many other requests are occurring at the
        /// same time.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        public virtual Task<UpdateOrganizationConfigurationResponse> UpdateOrganizationConfigurationAsync(UpdateOrganizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateOrganizationConfigurationResponse>(request, options, cancellationToken);
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
            var resolver = new AmazonDetectiveEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}