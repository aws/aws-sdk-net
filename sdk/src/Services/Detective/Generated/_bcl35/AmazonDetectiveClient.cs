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
    /// We replaced the term "master account" with the term "administrator account." An administrator
    /// account is used to centrally manage multiple accounts. In the case of Detective, the
    /// administrator account manages the accounts in their behavior graph.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonDetectiveClient : AmazonServiceClient, IAmazonDetective
    {
        private static IServiceMetadata serviceMetadata = new AmazonDetectiveMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        /// The member account status in the graph must be <code>INVITED</code>.
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
        /// Initiates the asynchronous execution of the AcceptInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        public virtual IAsyncResult BeginAcceptInvitation(AcceptInvitationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptInvitationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptInvitation.</param>
        /// 
        /// <returns>Returns a  AcceptInvitationResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        public virtual AcceptInvitationResponse EndAcceptInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptInvitationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the BatchGetGraphMemberDatasources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetGraphMemberDatasources operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetGraphMemberDatasources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/BatchGetGraphMemberDatasources">REST API Reference for BatchGetGraphMemberDatasources Operation</seealso>
        public virtual IAsyncResult BeginBatchGetGraphMemberDatasources(BatchGetGraphMemberDatasourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetGraphMemberDatasourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetGraphMemberDatasourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetGraphMemberDatasources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetGraphMemberDatasources.</param>
        /// 
        /// <returns>Returns a  BatchGetGraphMemberDatasourcesResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/BatchGetGraphMemberDatasources">REST API Reference for BatchGetGraphMemberDatasources Operation</seealso>
        public virtual BatchGetGraphMemberDatasourcesResponse EndBatchGetGraphMemberDatasources(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetGraphMemberDatasourcesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the BatchGetMembershipDatasources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMembershipDatasources operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetMembershipDatasources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/BatchGetMembershipDatasources">REST API Reference for BatchGetMembershipDatasources Operation</seealso>
        public virtual IAsyncResult BeginBatchGetMembershipDatasources(BatchGetMembershipDatasourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetMembershipDatasourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetMembershipDatasourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetMembershipDatasources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetMembershipDatasources.</param>
        /// 
        /// <returns>Returns a  BatchGetMembershipDatasourcesResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/BatchGetMembershipDatasources">REST API Reference for BatchGetMembershipDatasources Operation</seealso>
        public virtual BatchGetMembershipDatasourcesResponse EndBatchGetMembershipDatasources(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetMembershipDatasourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGraph

        /// <summary>
        /// Creates a new behavior graph for the calling account, and sets that account as the
        /// administrator account. This operation is called by the account that is enabling Detective.
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
        /// An account can only be the administrator account for one behavior graph within a Region.
        /// If the same account calls <code>CreateGraph</code> with the same administrator account,
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
        /// The request would cause the number of member accounts in the behavior graph to exceed
        /// the maximum allowed. A behavior graph cannot have more than 1200 member accounts.
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
        public virtual CreateGraphResponse CreateGraph(CreateGraphRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphResponseUnmarshaller.Instance;

            return Invoke<CreateGraphResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGraph operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGraph
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/CreateGraph">REST API Reference for CreateGraph Operation</seealso>
        public virtual IAsyncResult BeginCreateGraph(CreateGraphRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGraph.</param>
        /// 
        /// <returns>Returns a  CreateGraphResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/CreateGraph">REST API Reference for CreateGraph Operation</seealso>
        public virtual CreateGraphResponse EndCreateGraph(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGraphResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMembers

        /// <summary>
        /// <code>CreateMembers</code> is used to send invitations to accounts. For the organization
        /// behavior graph, the Detective administrator account uses <code>CreateMembers</code>
        /// to enable organization accounts as member accounts.
        /// 
        ///  
        /// <para>
        /// For invited accounts, <code>CreateMembers</code> sends a request to invite the specified
        /// Amazon Web Services accounts to be member accounts in the behavior graph. This operation
        /// can only be called by the administrator account for a behavior graph. 
        /// </para>
        ///  
        /// <para>
        ///  <code>CreateMembers</code> verifies the accounts and then invites the verified accounts.
        /// The administrator can optionally specify to not send invitation emails to the member
        /// accounts. This would be used when the administrator manages their member accounts
        /// centrally.
        /// </para>
        ///  
        /// <para>
        /// For organization accounts in the organization behavior graph, <code>CreateMembers</code>
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
        /// The accounts that <code>CreateMembers</code> was able to process. For invited accounts,
        /// includes member accounts that are being verified, that have passed verification and
        /// are to be invited, and that have failed verification. For organization accounts in
        /// the organization behavior graph, includes accounts that can be enabled and that cannot
        /// be enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The accounts that <code>CreateMembers</code> was unable to process. This list includes
        /// accounts that were already invited to be member accounts in the behavior graph.
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
        /// The request would cause the number of member accounts in the behavior graph to exceed
        /// the maximum allowed. A behavior graph cannot have more than 1200 member accounts.
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
        public virtual CreateMembersResponse CreateMembers(CreateMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembersResponseUnmarshaller.Instance;

            return Invoke<CreateMembersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        public virtual IAsyncResult BeginCreateMembers(CreateMembersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMembers.</param>
        /// 
        /// <returns>Returns a  CreateMembersResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        public virtual CreateMembersResponse EndCreateMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGraph

        /// <summary>
        /// Disables the specified behavior graph and queues it to be deleted. This operation
        /// removes the behavior graph from each member account's list of behavior graphs.
        /// 
        ///  
        /// <para>
        ///  <code>DeleteGraph</code> can only be called by the administrator account for a behavior
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
        /// Initiates the asynchronous execution of the DeleteGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraph operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGraph
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DeleteGraph">REST API Reference for DeleteGraph Operation</seealso>
        public virtual IAsyncResult BeginDeleteGraph(DeleteGraphRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGraph.</param>
        /// 
        /// <returns>Returns a  DeleteGraphResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DeleteGraph">REST API Reference for DeleteGraph Operation</seealso>
        public virtual DeleteGraphResponse EndDeleteGraph(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGraphResponse>(asyncResult);
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
        /// are not enabled as member accounts are not included in the <code>ListMembers</code>
        /// results for the organization behavior graph.
        /// </para>
        ///  
        /// <para>
        /// An administrator account cannot use <code>DeleteMembers</code> to remove their own
        /// account from the behavior graph. To disable a behavior graph, the administrator account
        /// uses the <code>DeleteGraph</code> API method.
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
        /// Initiates the asynchronous execution of the DeleteMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        public virtual IAsyncResult BeginDeleteMembers(DeleteMembersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMembers.</param>
        /// 
        /// <returns>Returns a  DeleteMembersResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        public virtual DeleteMembersResponse EndDeleteMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMembersResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrganizationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrganizationConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeOrganizationConfigurationResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        public virtual DescribeOrganizationConfigurationResponse EndDescribeOrganizationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOrganizationConfigurationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DisableOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationAdminAccount operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableOrganizationAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        public virtual IAsyncResult BeginDisableOrganizationAdminAccount(DisableOrganizationAdminAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableOrganizationAdminAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableOrganizationAdminAccount.</param>
        /// 
        /// <returns>Returns a  DisableOrganizationAdminAccountResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        public virtual DisableOrganizationAdminAccountResponse EndDisableOrganizationAdminAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableOrganizationAdminAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateMembership

        /// <summary>
        /// Removes the member account from the specified behavior graph. This operation can only
        /// be called by an invited member account that has the <code>ENABLED</code> status.
        /// 
        ///  
        /// <para>
        ///  <code>DisassociateMembership</code> cannot be called by an organization account in
        /// the organization behavior graph. For the organization behavior graph, the Detective
        /// administrator account determines which organization accounts to enable or disable
        /// as member accounts.
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
        /// Initiates the asynchronous execution of the DisassociateMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembership operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DisassociateMembership">REST API Reference for DisassociateMembership Operation</seealso>
        public virtual IAsyncResult BeginDisassociateMembership(DisassociateMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMembership.</param>
        /// 
        /// <returns>Returns a  DisassociateMembershipResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DisassociateMembership">REST API Reference for DisassociateMembership Operation</seealso>
        public virtual DisassociateMembershipResponse EndDisassociateMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateMembershipResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the EnableOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationAdminAccount operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableOrganizationAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        public virtual IAsyncResult BeginEnableOrganizationAdminAccount(EnableOrganizationAdminAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableOrganizationAdminAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableOrganizationAdminAccount.</param>
        /// 
        /// <returns>Returns a  EnableOrganizationAdminAccountResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        public virtual EnableOrganizationAdminAccountResponse EndEnableOrganizationAdminAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableOrganizationAdminAccountResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMembers operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/GetMembers">REST API Reference for GetMembers Operation</seealso>
        public virtual IAsyncResult BeginGetMembers(GetMembersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMembers.</param>
        /// 
        /// <returns>Returns a  GetMembersResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/GetMembers">REST API Reference for GetMembers Operation</seealso>
        public virtual GetMembersResponse EndGetMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMembersResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListDatasourcePackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasourcePackages operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasourcePackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListDatasourcePackages">REST API Reference for ListDatasourcePackages Operation</seealso>
        public virtual IAsyncResult BeginListDatasourcePackages(ListDatasourcePackagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasourcePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasourcePackagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasourcePackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasourcePackages.</param>
        /// 
        /// <returns>Returns a  ListDatasourcePackagesResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListDatasourcePackages">REST API Reference for ListDatasourcePackages Operation</seealso>
        public virtual ListDatasourcePackagesResponse EndListDatasourcePackages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatasourcePackagesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListGraphs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGraphs operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGraphs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListGraphs">REST API Reference for ListGraphs Operation</seealso>
        public virtual IAsyncResult BeginListGraphs(ListGraphsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGraphsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGraphs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGraphs.</param>
        /// 
        /// <returns>Returns a  ListGraphsResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListGraphs">REST API Reference for ListGraphs Operation</seealso>
        public virtual ListGraphsResponse EndListGraphs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGraphsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual IAsyncResult BeginListInvitations(ListInvitationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvitations.</param>
        /// 
        /// <returns>Returns a  ListInvitationsResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual ListInvitationsResponse EndListInvitations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInvitationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMembers operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual IAsyncResult BeginListMembers(ListMembersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMembers.</param>
        /// 
        /// <returns>Returns a  ListMembersResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual ListMembersResponse EndListMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMembersResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListOrganizationAdminAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationAdminAccounts operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizationAdminAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
        public virtual IAsyncResult BeginListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationAdminAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationAdminAccountsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizationAdminAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizationAdminAccounts.</param>
        /// 
        /// <returns>Returns a  ListOrganizationAdminAccountsResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
        public virtual ListOrganizationAdminAccountsResponse EndListOrganizationAdminAccounts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOrganizationAdminAccountsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectInvitation

        /// <summary>
        /// Rejects an invitation to contribute the account data to a behavior graph. This operation
        /// must be called by an invited member account that has the <code>INVITED</code> status.
        /// 
        ///  
        /// <para>
        ///  <code>RejectInvitation</code> cannot be called by an organization account in the
        /// organization behavior graph. In the organization behavior graph, organization accounts
        /// do not receive an invitation.
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
        /// Initiates the asynchronous execution of the RejectInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectInvitation operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/RejectInvitation">REST API Reference for RejectInvitation Operation</seealso>
        public virtual IAsyncResult BeginRejectInvitation(RejectInvitationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectInvitationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectInvitation.</param>
        /// 
        /// <returns>Returns a  RejectInvitationResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/RejectInvitation">REST API Reference for RejectInvitation Operation</seealso>
        public virtual RejectInvitationResponse EndRejectInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMonitoringMember

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
        /// The request would cause the number of member accounts in the behavior graph to exceed
        /// the maximum allowed. A behavior graph cannot have more than 1200 member accounts.
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
        public virtual StartMonitoringMemberResponse StartMonitoringMember(StartMonitoringMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMonitoringMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMonitoringMemberResponseUnmarshaller.Instance;

            return Invoke<StartMonitoringMemberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMonitoringMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringMember operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMonitoringMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/StartMonitoringMember">REST API Reference for StartMonitoringMember Operation</seealso>
        public virtual IAsyncResult BeginStartMonitoringMember(StartMonitoringMemberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMonitoringMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMonitoringMemberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMonitoringMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMonitoringMember.</param>
        /// 
        /// <returns>Returns a  StartMonitoringMemberResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/StartMonitoringMember">REST API Reference for StartMonitoringMember Operation</seealso>
        public virtual StartMonitoringMemberResponse EndStartMonitoringMember(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMonitoringMemberResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
        /// The request would cause the number of member accounts in the behavior graph to exceed
        /// the maximum allowed. A behavior graph cannot have more than 1200 member accounts.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/UpdateDatasourcePackages">REST API Reference for UpdateDatasourcePackages Operation</seealso>
        public virtual UpdateDatasourcePackagesResponse UpdateDatasourcePackages(UpdateDatasourcePackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasourcePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasourcePackagesResponseUnmarshaller.Instance;

            return Invoke<UpdateDatasourcePackagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDatasourcePackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatasourcePackages operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDatasourcePackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/UpdateDatasourcePackages">REST API Reference for UpdateDatasourcePackages Operation</seealso>
        public virtual IAsyncResult BeginUpdateDatasourcePackages(UpdateDatasourcePackagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasourcePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasourcePackagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDatasourcePackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDatasourcePackages.</param>
        /// 
        /// <returns>Returns a  UpdateDatasourcePackagesResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/UpdateDatasourcePackages">REST API Reference for UpdateDatasourcePackages Operation</seealso>
        public virtual UpdateDatasourcePackagesResponse EndUpdateDatasourcePackages(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDatasourcePackagesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration operation on AmazonDetectiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOrganizationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateOrganizationConfiguration(UpdateOrganizationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOrganizationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateOrganizationConfigurationResult from Detective.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        public virtual UpdateOrganizationConfigurationResponse EndUpdateOrganizationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateOrganizationConfigurationResponse>(asyncResult);
        }

        #endregion
        
    }
}