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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

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
    /// Security Hub provides you with a comprehensive view of the security state of your
    /// Amazon Web Services environment and resources. It also provides you with the readiness
    /// status of your environment based on controls from supported security standards. Security
    /// Hub collects security data from Amazon Web Services accounts, services, and integrated
    /// third-party products and helps you analyze security trends in your environment to
    /// identify the highest priority security issues. For more information about Security
    /// Hub, see the <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/what-is-securityhub.html">
    /// <i>Security HubUser Guide</i> </a>.
    /// 
    ///  
    /// <para>
    /// When you use operations in the Security Hub API, the requests are executed only in
    /// the Amazon Web Services Region that is currently active or in the specific Amazon
    /// Web Services Region that you specify in your request. Any configuration or settings
    /// change that results from the operation is applied only to that Region. To make the
    /// same change in other Regions, execute the same command for each Region to apply the
    /// change to.
    /// </para>
    ///  
    /// <para>
    /// For example, if your Region is set to <code>us-west-2</code>, when you use <code>CreateMembers</code>
    /// to add a member account to Security Hub, the association of the member account with
    /// the administrator account is created only in the <code>us-west-2</code> Region. Security
    /// Hub must be enabled for the member account in the same Region that the invitation
    /// was sent from.
    /// </para>
    ///  
    /// <para>
    /// The following throttling limits apply to using Security Hub API operations.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>BatchEnableStandards</code> - <code>RateLimit</code> of 1 request per second,
    /// <code>BurstLimit</code> of 1 request per second.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>GetFindings</code> - <code>RateLimit</code> of 3 requests per second. <code>BurstLimit</code>
    /// of 6 requests per second.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>BatchImportFindings</code> - <code>RateLimit</code> of 10 requests per second.
    /// <code>BurstLimit</code> of 30 requests per second.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>BatchUpdateFindings</code> - <code>RateLimit</code> of 10 requests per second.
    /// <code>BurstLimit</code> of 30 requests per second.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateStandardsControl</code> - <code>RateLimit</code> of 1 request per second,
    /// <code>BurstLimit</code> of 5 requests per second.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// All other operations - <code>RateLimit</code> of 10 requests per second. <code>BurstLimit</code>
    /// of 30 requests per second.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonSecurityHubClient : AmazonServiceClient, IAmazonSecurityHub
    {
        private static IServiceMetadata serviceMetadata = new AmazonSecurityHubMetadata();
        private ISecurityHubPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISecurityHubPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SecurityHubPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSecurityHubEndpointResolver());
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


        #region  AcceptAdministratorInvitation


        /// <summary>
        /// Accepts the invitation to be a member account and be monitored by the Security Hub
        /// administrator account that the invitation was sent from.
        /// 
        ///  
        /// <para>
        /// This operation is only used by member accounts that are not added through Organizations.
        /// </para>
        ///  
        /// <para>
        /// When the member account accepts the invitation, permission is granted to the administrator
        /// account to view findings generated in the member account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptAdministratorInvitation service method.</param>
        /// 
        /// <returns>The response from the AcceptAdministratorInvitation service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/AcceptAdministratorInvitation">REST API Reference for AcceptAdministratorInvitation Operation</seealso>
        public virtual AcceptAdministratorInvitationResponse AcceptAdministratorInvitation(AcceptAdministratorInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptAdministratorInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptAdministratorInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptAdministratorInvitationResponse>(request, options);
        }


        /// <summary>
        /// Accepts the invitation to be a member account and be monitored by the Security Hub
        /// administrator account that the invitation was sent from.
        /// 
        ///  
        /// <para>
        /// This operation is only used by member accounts that are not added through Organizations.
        /// </para>
        ///  
        /// <para>
        /// When the member account accepts the invitation, permission is granted to the administrator
        /// account to view findings generated in the member account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptAdministratorInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptAdministratorInvitation service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/AcceptAdministratorInvitation">REST API Reference for AcceptAdministratorInvitation Operation</seealso>
        public virtual Task<AcceptAdministratorInvitationResponse> AcceptAdministratorInvitationAsync(AcceptAdministratorInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptAdministratorInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptAdministratorInvitationResponseUnmarshaller.Instance;
            
            return InvokeAsync<AcceptAdministratorInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AcceptInvitation


        /// <summary>
        /// This method is deprecated. Instead, use <code>AcceptAdministratorInvitation</code>.
        /// 
        ///  
        /// <para>
        /// The Security Hub console continues to use <code>AcceptInvitation</code>. It will eventually
        /// change to use <code>AcceptAdministratorInvitation</code>. Any IAM policies that specifically
        /// control access to this function must continue to use <code>AcceptInvitation</code>.
        /// You should also add <code>AcceptAdministratorInvitation</code> to your policies to
        /// ensure that the correct permissions are in place after the console begins to use <code>AcceptAdministratorInvitation</code>.
        /// </para>
        ///  
        /// <para>
        /// Accepts the invitation to be a member account and be monitored by the Security Hub
        /// administrator account that the invitation was sent from.
        /// </para>
        ///  
        /// <para>
        /// This operation is only used by member accounts that are not added through Organizations.
        /// </para>
        ///  
        /// <para>
        /// When the member account accepts the invitation, permission is granted to the administrator
        /// account to view findings generated in the member account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        [Obsolete("This API has been deprecated, use AcceptAdministratorInvitation API instead.")]
        public virtual AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptInvitationResponse>(request, options);
        }


        /// <summary>
        /// This method is deprecated. Instead, use <code>AcceptAdministratorInvitation</code>.
        /// 
        ///  
        /// <para>
        /// The Security Hub console continues to use <code>AcceptInvitation</code>. It will eventually
        /// change to use <code>AcceptAdministratorInvitation</code>. Any IAM policies that specifically
        /// control access to this function must continue to use <code>AcceptInvitation</code>.
        /// You should also add <code>AcceptAdministratorInvitation</code> to your policies to
        /// ensure that the correct permissions are in place after the console begins to use <code>AcceptAdministratorInvitation</code>.
        /// </para>
        ///  
        /// <para>
        /// Accepts the invitation to be a member account and be monitored by the Security Hub
        /// administrator account that the invitation was sent from.
        /// </para>
        ///  
        /// <para>
        /// This operation is only used by member accounts that are not added through Organizations.
        /// </para>
        ///  
        /// <para>
        /// When the member account accepts the invitation, permission is granted to the administrator
        /// account to view findings generated in the member account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        [Obsolete("This API has been deprecated, use AcceptAdministratorInvitation API instead.")]
        public virtual Task<AcceptInvitationResponse> AcceptInvitationAsync(AcceptInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptInvitationResponseUnmarshaller.Instance;
            
            return InvokeAsync<AcceptInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDisableStandards


        /// <summary>
        /// Disables the standards specified by the provided <code>StandardsSubscriptionArns</code>.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-standards.html">Security
        /// Standards</a> section of the <i>Security Hub User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisableStandards service method.</param>
        /// 
        /// <returns>The response from the BatchDisableStandards service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchDisableStandards">REST API Reference for BatchDisableStandards Operation</seealso>
        public virtual BatchDisableStandardsResponse BatchDisableStandards(BatchDisableStandardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisableStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisableStandardsResponseUnmarshaller.Instance;

            return Invoke<BatchDisableStandardsResponse>(request, options);
        }


        /// <summary>
        /// Disables the standards specified by the provided <code>StandardsSubscriptionArns</code>.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-standards.html">Security
        /// Standards</a> section of the <i>Security Hub User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisableStandards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDisableStandards service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchDisableStandards">REST API Reference for BatchDisableStandards Operation</seealso>
        public virtual Task<BatchDisableStandardsResponse> BatchDisableStandardsAsync(BatchDisableStandardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisableStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisableStandardsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDisableStandardsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchEnableStandards


        /// <summary>
        /// Enables the standards specified by the provided <code>StandardsArn</code>. To obtain
        /// the ARN for a standard, use the <code>DescribeStandards</code> operation.
        /// 
        ///  
        /// <para>
        /// For more information, see the <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-standards.html">Security
        /// Standards</a> section of the <i>Security Hub User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchEnableStandards service method.</param>
        /// 
        /// <returns>The response from the BatchEnableStandards service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchEnableStandards">REST API Reference for BatchEnableStandards Operation</seealso>
        public virtual BatchEnableStandardsResponse BatchEnableStandards(BatchEnableStandardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchEnableStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchEnableStandardsResponseUnmarshaller.Instance;

            return Invoke<BatchEnableStandardsResponse>(request, options);
        }


        /// <summary>
        /// Enables the standards specified by the provided <code>StandardsArn</code>. To obtain
        /// the ARN for a standard, use the <code>DescribeStandards</code> operation.
        /// 
        ///  
        /// <para>
        /// For more information, see the <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-standards.html">Security
        /// Standards</a> section of the <i>Security Hub User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchEnableStandards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchEnableStandards service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchEnableStandards">REST API Reference for BatchEnableStandards Operation</seealso>
        public virtual Task<BatchEnableStandardsResponse> BatchEnableStandardsAsync(BatchEnableStandardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchEnableStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchEnableStandardsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchEnableStandardsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchImportFindings


        /// <summary>
        /// Imports security findings generated by a finding provider into Security Hub. This
        /// action is requested by the finding provider to import its findings into Security Hub.
        /// 
        ///  
        /// <para>
        ///  <code>BatchImportFindings</code> must be called by one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The Amazon Web Services account that is associated with a finding if you are using
        /// the <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-custom-providers.html#securityhub-custom-providers-bfi-reqs">default
        /// product ARN</a> or are a partner sending findings from within a customer's Amazon
        /// Web Services account. In these cases, the identifier of the account that you are calling
        /// <code>BatchImportFindings</code> from needs to be the same as the <code>AwsAccountId</code>
        /// attribute for the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon Web Services account that Security Hub has allow-listed for an official
        /// partner integration. In this case, you can call <code>BatchImportFindings</code> from
        /// the allow-listed account and send findings from different customer accounts in the
        /// same batch.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The maximum allowed size for a finding is 240 Kb. An error is returned for any finding
        /// larger than 240 Kb.
        /// </para>
        ///  
        /// <para>
        /// After a finding is created, <code>BatchImportFindings</code> cannot be used to update
        /// the following finding fields and objects, which Security Hub customers use to manage
        /// their investigation workflow.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Note</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UserDefinedFields</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VerificationState</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Workflow</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Finding providers also should not use <code>BatchImportFindings</code> to update the
        /// following attributes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Confidence</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Criticality</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RelatedFindings</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Severity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Types</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Instead, finding providers use <code>FindingProviderFields</code> to provide values
        /// for these attributes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchImportFindings service method.</param>
        /// 
        /// <returns>The response from the BatchImportFindings service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchImportFindings">REST API Reference for BatchImportFindings Operation</seealso>
        public virtual BatchImportFindingsResponse BatchImportFindings(BatchImportFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchImportFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchImportFindingsResponseUnmarshaller.Instance;

            return Invoke<BatchImportFindingsResponse>(request, options);
        }


        /// <summary>
        /// Imports security findings generated by a finding provider into Security Hub. This
        /// action is requested by the finding provider to import its findings into Security Hub.
        /// 
        ///  
        /// <para>
        ///  <code>BatchImportFindings</code> must be called by one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The Amazon Web Services account that is associated with a finding if you are using
        /// the <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-custom-providers.html#securityhub-custom-providers-bfi-reqs">default
        /// product ARN</a> or are a partner sending findings from within a customer's Amazon
        /// Web Services account. In these cases, the identifier of the account that you are calling
        /// <code>BatchImportFindings</code> from needs to be the same as the <code>AwsAccountId</code>
        /// attribute for the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon Web Services account that Security Hub has allow-listed for an official
        /// partner integration. In this case, you can call <code>BatchImportFindings</code> from
        /// the allow-listed account and send findings from different customer accounts in the
        /// same batch.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The maximum allowed size for a finding is 240 Kb. An error is returned for any finding
        /// larger than 240 Kb.
        /// </para>
        ///  
        /// <para>
        /// After a finding is created, <code>BatchImportFindings</code> cannot be used to update
        /// the following finding fields and objects, which Security Hub customers use to manage
        /// their investigation workflow.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Note</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UserDefinedFields</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VerificationState</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Workflow</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Finding providers also should not use <code>BatchImportFindings</code> to update the
        /// following attributes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Confidence</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Criticality</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RelatedFindings</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Severity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Types</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Instead, finding providers use <code>FindingProviderFields</code> to provide values
        /// for these attributes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchImportFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchImportFindings service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchImportFindings">REST API Reference for BatchImportFindings Operation</seealso>
        public virtual Task<BatchImportFindingsResponse> BatchImportFindingsAsync(BatchImportFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchImportFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchImportFindingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchImportFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchUpdateFindings


        /// <summary>
        /// Used by Security Hub customers to update information about their investigation into
        /// a finding. Requested by administrator accounts or member accounts. Administrator accounts
        /// can update findings for their account and their member accounts. Member accounts can
        /// update findings for their account.
        /// 
        ///  
        /// <para>
        /// Updates from <code>BatchUpdateFindings</code> do not affect the value of <code>UpdatedAt</code>
        /// for a finding.
        /// </para>
        ///  
        /// <para>
        /// Administrator and member accounts can use <code>BatchUpdateFindings</code> to update
        /// the following finding fields and objects.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Confidence</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Criticality</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Note</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RelatedFindings</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Severity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Types</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UserDefinedFields</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VerificationState</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Workflow</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can configure IAM policies to restrict access to fields and field values. For
        /// example, you might not want member accounts to be able to suppress findings or change
        /// the finding severity. See <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/finding-update-batchupdatefindings.html#batchupdatefindings-configure-access">Configuring
        /// access to BatchUpdateFindings</a> in the <i>Security Hub User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateFindings service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateFindings service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchUpdateFindings">REST API Reference for BatchUpdateFindings Operation</seealso>
        public virtual BatchUpdateFindingsResponse BatchUpdateFindings(BatchUpdateFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateFindingsResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateFindingsResponse>(request, options);
        }


        /// <summary>
        /// Used by Security Hub customers to update information about their investigation into
        /// a finding. Requested by administrator accounts or member accounts. Administrator accounts
        /// can update findings for their account and their member accounts. Member accounts can
        /// update findings for their account.
        /// 
        ///  
        /// <para>
        /// Updates from <code>BatchUpdateFindings</code> do not affect the value of <code>UpdatedAt</code>
        /// for a finding.
        /// </para>
        ///  
        /// <para>
        /// Administrator and member accounts can use <code>BatchUpdateFindings</code> to update
        /// the following finding fields and objects.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Confidence</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Criticality</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Note</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RelatedFindings</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Severity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Types</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UserDefinedFields</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VerificationState</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Workflow</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can configure IAM policies to restrict access to fields and field values. For
        /// example, you might not want member accounts to be able to suppress findings or change
        /// the finding severity. See <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/finding-update-batchupdatefindings.html#batchupdatefindings-configure-access">Configuring
        /// access to BatchUpdateFindings</a> in the <i>Security Hub User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateFindings service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchUpdateFindings">REST API Reference for BatchUpdateFindings Operation</seealso>
        public virtual Task<BatchUpdateFindingsResponse> BatchUpdateFindingsAsync(BatchUpdateFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateFindingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchUpdateFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateActionTarget


        /// <summary>
        /// Creates a custom action target in Security Hub.
        /// 
        ///  
        /// <para>
        /// You can use custom actions on findings and insights in Security Hub to trigger target
        /// actions in Amazon CloudWatch Events.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateActionTarget service method.</param>
        /// 
        /// <returns>The response from the CreateActionTarget service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateActionTarget">REST API Reference for CreateActionTarget Operation</seealso>
        public virtual CreateActionTargetResponse CreateActionTarget(CreateActionTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateActionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateActionTargetResponseUnmarshaller.Instance;

            return Invoke<CreateActionTargetResponse>(request, options);
        }


        /// <summary>
        /// Creates a custom action target in Security Hub.
        /// 
        ///  
        /// <para>
        /// You can use custom actions on findings and insights in Security Hub to trigger target
        /// actions in Amazon CloudWatch Events.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateActionTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateActionTarget service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateActionTarget">REST API Reference for CreateActionTarget Operation</seealso>
        public virtual Task<CreateActionTargetResponse> CreateActionTargetAsync(CreateActionTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateActionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateActionTargetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateActionTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFindingAggregator


        /// <summary>
        /// Used to enable finding aggregation. Must be called from the aggregation Region.
        /// 
        ///  
        /// <para>
        /// For more details about cross-Region replication, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/finding-aggregation.html">Configuring
        /// finding aggregation</a> in the <i>Security Hub User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingAggregator service method.</param>
        /// 
        /// <returns>The response from the CreateFindingAggregator service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateFindingAggregator">REST API Reference for CreateFindingAggregator Operation</seealso>
        public virtual CreateFindingAggregatorResponse CreateFindingAggregator(CreateFindingAggregatorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFindingAggregatorResponseUnmarshaller.Instance;

            return Invoke<CreateFindingAggregatorResponse>(request, options);
        }


        /// <summary>
        /// Used to enable finding aggregation. Must be called from the aggregation Region.
        /// 
        ///  
        /// <para>
        /// For more details about cross-Region replication, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/finding-aggregation.html">Configuring
        /// finding aggregation</a> in the <i>Security Hub User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingAggregator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFindingAggregator service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateFindingAggregator">REST API Reference for CreateFindingAggregator Operation</seealso>
        public virtual Task<CreateFindingAggregatorResponse> CreateFindingAggregatorAsync(CreateFindingAggregatorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFindingAggregatorResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFindingAggregatorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInsight


        /// <summary>
        /// Creates a custom insight in Security Hub. An insight is a consolidation of findings
        /// that relate to a security issue that requires attention or remediation.
        /// 
        ///  
        /// <para>
        /// To group the related findings in the insight, use the <code>GroupByAttribute</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInsight service method.</param>
        /// 
        /// <returns>The response from the CreateInsight service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateInsight">REST API Reference for CreateInsight Operation</seealso>
        public virtual CreateInsightResponse CreateInsight(CreateInsightRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInsightResponseUnmarshaller.Instance;

            return Invoke<CreateInsightResponse>(request, options);
        }


        /// <summary>
        /// Creates a custom insight in Security Hub. An insight is a consolidation of findings
        /// that relate to a security issue that requires attention or remediation.
        /// 
        ///  
        /// <para>
        /// To group the related findings in the insight, use the <code>GroupByAttribute</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInsight service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInsight service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateInsight">REST API Reference for CreateInsight Operation</seealso>
        public virtual Task<CreateInsightResponse> CreateInsightAsync(CreateInsightRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInsightResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateInsightResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMembers


        /// <summary>
        /// Creates a member association in Security Hub between the specified accounts and the
        /// account used to make the request, which is the administrator account. If you are integrated
        /// with Organizations, then the administrator account is designated by the organization
        /// management account.
        /// 
        ///  
        /// <para>
        ///  <code>CreateMembers</code> is always used to add accounts that are not organization
        /// members.
        /// </para>
        ///  
        /// <para>
        /// For accounts that are managed using Organizations, <code>CreateMembers</code> is only
        /// used in the following cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Security Hub is not configured to automatically add new organization accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The account was disassociated or deleted in Security Hub.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This action can only be used by an account that has Security Hub enabled. To enable
        /// Security Hub, you can use the <code>EnableSecurityHub</code> operation.
        /// </para>
        ///  
        /// <para>
        /// For accounts that are not organization members, you create the account association
        /// and then send an invitation to the member account. To send the invitation, you use
        /// the <code>InviteMembers</code> operation. If the account owner accepts the invitation,
        /// the account becomes a member account in Security Hub.
        /// </para>
        ///  
        /// <para>
        /// Accounts that are managed using Organizations do not receive an invitation. They automatically
        /// become a member account in Security Hub.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the organization account does not have Security Hub enabled, then Security Hub
        /// and the default standards are automatically enabled. Note that Security Hub cannot
        /// be enabled automatically for the organization management account. The organization
        /// management account must enable Security Hub before the administrator account enables
        /// it as a member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For organization accounts that already have Security Hub enabled, Security Hub does
        /// not make any other changes to those accounts. It does not change their enabled standards
        /// or controls.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A permissions policy is added that permits the administrator account to view the findings
        /// generated in the member account.
        /// </para>
        ///  
        /// <para>
        /// To remove the association between the administrator and member accounts, use the <code>DisassociateFromMasterAccount</code>
        /// or <code>DisassociateMembers</code> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers service method.</param>
        /// 
        /// <returns>The response from the CreateMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        public virtual CreateMembersResponse CreateMembers(CreateMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembersResponseUnmarshaller.Instance;

            return Invoke<CreateMembersResponse>(request, options);
        }


        /// <summary>
        /// Creates a member association in Security Hub between the specified accounts and the
        /// account used to make the request, which is the administrator account. If you are integrated
        /// with Organizations, then the administrator account is designated by the organization
        /// management account.
        /// 
        ///  
        /// <para>
        ///  <code>CreateMembers</code> is always used to add accounts that are not organization
        /// members.
        /// </para>
        ///  
        /// <para>
        /// For accounts that are managed using Organizations, <code>CreateMembers</code> is only
        /// used in the following cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Security Hub is not configured to automatically add new organization accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The account was disassociated or deleted in Security Hub.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This action can only be used by an account that has Security Hub enabled. To enable
        /// Security Hub, you can use the <code>EnableSecurityHub</code> operation.
        /// </para>
        ///  
        /// <para>
        /// For accounts that are not organization members, you create the account association
        /// and then send an invitation to the member account. To send the invitation, you use
        /// the <code>InviteMembers</code> operation. If the account owner accepts the invitation,
        /// the account becomes a member account in Security Hub.
        /// </para>
        ///  
        /// <para>
        /// Accounts that are managed using Organizations do not receive an invitation. They automatically
        /// become a member account in Security Hub.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the organization account does not have Security Hub enabled, then Security Hub
        /// and the default standards are automatically enabled. Note that Security Hub cannot
        /// be enabled automatically for the organization management account. The organization
        /// management account must enable Security Hub before the administrator account enables
        /// it as a member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For organization accounts that already have Security Hub enabled, Security Hub does
        /// not make any other changes to those accounts. It does not change their enabled standards
        /// or controls.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A permissions policy is added that permits the administrator account to view the findings
        /// generated in the member account.
        /// </para>
        ///  
        /// <para>
        /// To remove the association between the administrator and member accounts, use the <code>DisassociateFromMasterAccount</code>
        /// or <code>DisassociateMembers</code> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        public virtual Task<CreateMembersResponse> CreateMembersAsync(CreateMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembersResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeclineInvitations


        /// <summary>
        /// Declines invitations to become a member account.
        /// 
        ///  
        /// <para>
        /// This operation is only used by accounts that are not part of an organization. Organization
        /// accounts do not receive invitations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations service method.</param>
        /// 
        /// <returns>The response from the DeclineInvitations service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        public virtual DeclineInvitationsResponse DeclineInvitations(DeclineInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeclineInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;

            return Invoke<DeclineInvitationsResponse>(request, options);
        }


        /// <summary>
        /// Declines invitations to become a member account.
        /// 
        ///  
        /// <para>
        /// This operation is only used by accounts that are not part of an organization. Organization
        /// accounts do not receive invitations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeclineInvitations service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        public virtual Task<DeclineInvitationsResponse> DeclineInvitationsAsync(DeclineInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeclineInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeclineInvitationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteActionTarget


        /// <summary>
        /// Deletes a custom action target from Security Hub.
        /// 
        ///  
        /// <para>
        /// Deleting a custom action target does not affect any findings or insights that were
        /// already sent to Amazon CloudWatch Events using the custom action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteActionTarget service method.</param>
        /// 
        /// <returns>The response from the DeleteActionTarget service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteActionTarget">REST API Reference for DeleteActionTarget Operation</seealso>
        public virtual DeleteActionTargetResponse DeleteActionTarget(DeleteActionTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteActionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteActionTargetResponseUnmarshaller.Instance;

            return Invoke<DeleteActionTargetResponse>(request, options);
        }


        /// <summary>
        /// Deletes a custom action target from Security Hub.
        /// 
        ///  
        /// <para>
        /// Deleting a custom action target does not affect any findings or insights that were
        /// already sent to Amazon CloudWatch Events using the custom action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteActionTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteActionTarget service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteActionTarget">REST API Reference for DeleteActionTarget Operation</seealso>
        public virtual Task<DeleteActionTargetResponse> DeleteActionTargetAsync(DeleteActionTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteActionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteActionTargetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteActionTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFindingAggregator


        /// <summary>
        /// Deletes a finding aggregator. When you delete the finding aggregator, you stop finding
        /// aggregation.
        /// 
        ///  
        /// <para>
        /// When you stop finding aggregation, findings that were already aggregated to the aggregation
        /// Region are still visible from the aggregation Region. New findings and finding updates
        /// are not aggregated. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFindingAggregator service method.</param>
        /// 
        /// <returns>The response from the DeleteFindingAggregator service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteFindingAggregator">REST API Reference for DeleteFindingAggregator Operation</seealso>
        public virtual DeleteFindingAggregatorResponse DeleteFindingAggregator(DeleteFindingAggregatorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFindingAggregatorResponseUnmarshaller.Instance;

            return Invoke<DeleteFindingAggregatorResponse>(request, options);
        }


        /// <summary>
        /// Deletes a finding aggregator. When you delete the finding aggregator, you stop finding
        /// aggregation.
        /// 
        ///  
        /// <para>
        /// When you stop finding aggregation, findings that were already aggregated to the aggregation
        /// Region are still visible from the aggregation Region. New findings and finding updates
        /// are not aggregated. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFindingAggregator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFindingAggregator service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteFindingAggregator">REST API Reference for DeleteFindingAggregator Operation</seealso>
        public virtual Task<DeleteFindingAggregatorResponse> DeleteFindingAggregatorAsync(DeleteFindingAggregatorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFindingAggregatorResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFindingAggregatorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInsight


        /// <summary>
        /// Deletes the insight specified by the <code>InsightArn</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInsight service method.</param>
        /// 
        /// <returns>The response from the DeleteInsight service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInsight">REST API Reference for DeleteInsight Operation</seealso>
        public virtual DeleteInsightResponse DeleteInsight(DeleteInsightRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInsightResponseUnmarshaller.Instance;

            return Invoke<DeleteInsightResponse>(request, options);
        }


        /// <summary>
        /// Deletes the insight specified by the <code>InsightArn</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInsight service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInsight service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInsight">REST API Reference for DeleteInsight Operation</seealso>
        public virtual Task<DeleteInsightResponse> DeleteInsightAsync(DeleteInsightRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInsightResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteInsightResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInvitations


        /// <summary>
        /// Deletes invitations received by the Amazon Web Services account to become a member
        /// account.
        /// 
        ///  
        /// <para>
        /// This operation is only used by accounts that are not part of an organization. Organization
        /// accounts do not receive invitations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations service method.</param>
        /// 
        /// <returns>The response from the DeleteInvitations service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        public virtual DeleteInvitationsResponse DeleteInvitations(DeleteInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;

            return Invoke<DeleteInvitationsResponse>(request, options);
        }


        /// <summary>
        /// Deletes invitations received by the Amazon Web Services account to become a member
        /// account.
        /// 
        ///  
        /// <para>
        /// This operation is only used by accounts that are not part of an organization. Organization
        /// accounts do not receive invitations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInvitations service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        public virtual Task<DeleteInvitationsResponse> DeleteInvitationsAsync(DeleteInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteInvitationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMembers


        /// <summary>
        /// Deletes the specified member accounts from Security Hub.
        /// 
        ///  
        /// <para>
        /// Can be used to delete member accounts that belong to an organization as well as member
        /// accounts that were invited manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers service method.</param>
        /// 
        /// <returns>The response from the DeleteMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        public virtual DeleteMembersResponse DeleteMembers(DeleteMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembersResponseUnmarshaller.Instance;

            return Invoke<DeleteMembersResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified member accounts from Security Hub.
        /// 
        ///  
        /// <para>
        /// Can be used to delete member accounts that belong to an organization as well as member
        /// accounts that were invited manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        public virtual Task<DeleteMembersResponse> DeleteMembersAsync(DeleteMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeActionTargets


        /// <summary>
        /// Returns a list of the custom action targets in Security Hub in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActionTargets service method.</param>
        /// 
        /// <returns>The response from the DescribeActionTargets service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeActionTargets">REST API Reference for DescribeActionTargets Operation</seealso>
        public virtual DescribeActionTargetsResponse DescribeActionTargets(DescribeActionTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActionTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActionTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeActionTargetsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the custom action targets in Security Hub in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActionTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeActionTargets service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeActionTargets">REST API Reference for DescribeActionTargets Operation</seealso>
        public virtual Task<DescribeActionTargetsResponse> DescribeActionTargetsAsync(DescribeActionTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActionTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActionTargetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeActionTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHub


        /// <summary>
        /// Returns details about the Hub resource in your account, including the <code>HubArn</code>
        /// and the time when you enabled Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHub service method.</param>
        /// 
        /// <returns>The response from the DescribeHub service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeHub">REST API Reference for DescribeHub Operation</seealso>
        public virtual DescribeHubResponse DescribeHub(DescribeHubRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHubResponseUnmarshaller.Instance;

            return Invoke<DescribeHubResponse>(request, options);
        }


        /// <summary>
        /// Returns details about the Hub resource in your account, including the <code>HubArn</code>
        /// and the time when you enabled Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHub service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHub service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeHub">REST API Reference for DescribeHub Operation</seealso>
        public virtual Task<DescribeHubResponse> DescribeHubAsync(DescribeHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHubResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeHubResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrganizationConfiguration


        /// <summary>
        /// Returns information about the Organizations configuration for Security Hub. Can only
        /// be called from a Security Hub administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfiguration service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        public virtual DescribeOrganizationConfigurationResponse DescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the Organizations configuration for Security Hub. Can only
        /// be called from a Security Hub administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfiguration service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        public virtual Task<DescribeOrganizationConfigurationResponse> DescribeOrganizationConfigurationAsync(DescribeOrganizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeOrganizationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProducts


        /// <summary>
        /// Returns information about product integrations in Security Hub.
        /// 
        ///  
        /// <para>
        /// You can optionally provide an integration ARN. If you provide an integration ARN,
        /// then the results only include that integration.
        /// </para>
        ///  
        /// <para>
        /// If you do not provide an integration ARN, then the results include all of the available
        /// product integrations. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProducts service method.</param>
        /// 
        /// <returns>The response from the DescribeProducts service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeProducts">REST API Reference for DescribeProducts Operation</seealso>
        public virtual DescribeProductsResponse DescribeProducts(DescribeProductsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductsResponseUnmarshaller.Instance;

            return Invoke<DescribeProductsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about product integrations in Security Hub.
        /// 
        ///  
        /// <para>
        /// You can optionally provide an integration ARN. If you provide an integration ARN,
        /// then the results only include that integration.
        /// </para>
        ///  
        /// <para>
        /// If you do not provide an integration ARN, then the results include all of the available
        /// product integrations. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProducts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProducts service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeProducts">REST API Reference for DescribeProducts Operation</seealso>
        public virtual Task<DescribeProductsResponse> DescribeProductsAsync(DescribeProductsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProductsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStandards


        /// <summary>
        /// Returns a list of the available standards in Security Hub.
        /// 
        ///  
        /// <para>
        /// For each standard, the results include the standard ARN, the name, and a description.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStandards service method.</param>
        /// 
        /// <returns>The response from the DescribeStandards service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeStandards">REST API Reference for DescribeStandards Operation</seealso>
        public virtual DescribeStandardsResponse DescribeStandards(DescribeStandardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStandardsResponseUnmarshaller.Instance;

            return Invoke<DescribeStandardsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the available standards in Security Hub.
        /// 
        ///  
        /// <para>
        /// For each standard, the results include the standard ARN, the name, and a description.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStandards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStandards service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeStandards">REST API Reference for DescribeStandards Operation</seealso>
        public virtual Task<DescribeStandardsResponse> DescribeStandardsAsync(DescribeStandardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStandardsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeStandardsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStandardsControls


        /// <summary>
        /// Returns a list of security standards controls.
        /// 
        ///  
        /// <para>
        /// For each control, the results include information about whether it is currently enabled,
        /// the severity, and a link to remediation information.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStandardsControls service method.</param>
        /// 
        /// <returns>The response from the DescribeStandardsControls service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeStandardsControls">REST API Reference for DescribeStandardsControls Operation</seealso>
        public virtual DescribeStandardsControlsResponse DescribeStandardsControls(DescribeStandardsControlsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStandardsControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStandardsControlsResponseUnmarshaller.Instance;

            return Invoke<DescribeStandardsControlsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of security standards controls.
        /// 
        ///  
        /// <para>
        /// For each control, the results include information about whether it is currently enabled,
        /// the severity, and a link to remediation information.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStandardsControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStandardsControls service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeStandardsControls">REST API Reference for DescribeStandardsControls Operation</seealso>
        public virtual Task<DescribeStandardsControlsResponse> DescribeStandardsControlsAsync(DescribeStandardsControlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStandardsControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStandardsControlsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeStandardsControlsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableImportFindingsForProduct


        /// <summary>
        /// Disables the integration of the specified product with Security Hub. After the integration
        /// is disabled, findings from that product are no longer sent to Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableImportFindingsForProduct service method.</param>
        /// 
        /// <returns>The response from the DisableImportFindingsForProduct service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableImportFindingsForProduct">REST API Reference for DisableImportFindingsForProduct Operation</seealso>
        public virtual DisableImportFindingsForProductResponse DisableImportFindingsForProduct(DisableImportFindingsForProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableImportFindingsForProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableImportFindingsForProductResponseUnmarshaller.Instance;

            return Invoke<DisableImportFindingsForProductResponse>(request, options);
        }


        /// <summary>
        /// Disables the integration of the specified product with Security Hub. After the integration
        /// is disabled, findings from that product are no longer sent to Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableImportFindingsForProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableImportFindingsForProduct service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableImportFindingsForProduct">REST API Reference for DisableImportFindingsForProduct Operation</seealso>
        public virtual Task<DisableImportFindingsForProductResponse> DisableImportFindingsForProductAsync(DisableImportFindingsForProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableImportFindingsForProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableImportFindingsForProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableImportFindingsForProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableOrganizationAdminAccount


        /// <summary>
        /// Disables a Security Hub administrator account. Can only be called by the organization
        /// management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the DisableOrganizationAdminAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        public virtual DisableOrganizationAdminAccountResponse DisableOrganizationAdminAccount(DisableOrganizationAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableOrganizationAdminAccountResponseUnmarshaller.Instance;

            return Invoke<DisableOrganizationAdminAccountResponse>(request, options);
        }


        /// <summary>
        /// Disables a Security Hub administrator account. Can only be called by the organization
        /// management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableOrganizationAdminAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        public virtual Task<DisableOrganizationAdminAccountResponse> DisableOrganizationAdminAccountAsync(DisableOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableOrganizationAdminAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableOrganizationAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableSecurityHub


        /// <summary>
        /// Disables Security Hub in your account only in the current Region. To disable Security
        /// Hub in all Regions, you must submit one request per Region where you have enabled
        /// Security Hub.
        /// 
        ///  
        /// <para>
        /// When you disable Security Hub for an administrator account, it doesn't disable Security
        /// Hub for any associated member accounts.
        /// </para>
        ///  
        /// <para>
        /// When you disable Security Hub, your existing findings and insights and any Security
        /// Hub configuration settings are deleted after 90 days and cannot be recovered. Any
        /// standards that were enabled are disabled, and your administrator and member account
        /// associations are removed.
        /// </para>
        ///  
        /// <para>
        /// If you want to save your existing findings, you must export them before you disable
        /// Security Hub.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSecurityHub service method.</param>
        /// 
        /// <returns>The response from the DisableSecurityHub service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableSecurityHub">REST API Reference for DisableSecurityHub Operation</seealso>
        public virtual DisableSecurityHubResponse DisableSecurityHub(DisableSecurityHubRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSecurityHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSecurityHubResponseUnmarshaller.Instance;

            return Invoke<DisableSecurityHubResponse>(request, options);
        }


        /// <summary>
        /// Disables Security Hub in your account only in the current Region. To disable Security
        /// Hub in all Regions, you must submit one request per Region where you have enabled
        /// Security Hub.
        /// 
        ///  
        /// <para>
        /// When you disable Security Hub for an administrator account, it doesn't disable Security
        /// Hub for any associated member accounts.
        /// </para>
        ///  
        /// <para>
        /// When you disable Security Hub, your existing findings and insights and any Security
        /// Hub configuration settings are deleted after 90 days and cannot be recovered. Any
        /// standards that were enabled are disabled, and your administrator and member account
        /// associations are removed.
        /// </para>
        ///  
        /// <para>
        /// If you want to save your existing findings, you must export them before you disable
        /// Security Hub.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSecurityHub service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableSecurityHub service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableSecurityHub">REST API Reference for DisableSecurityHub Operation</seealso>
        public virtual Task<DisableSecurityHubResponse> DisableSecurityHubAsync(DisableSecurityHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSecurityHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSecurityHubResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableSecurityHubResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateFromAdministratorAccount


        /// <summary>
        /// Disassociates the current Security Hub member account from the associated administrator
        /// account.
        /// 
        ///  
        /// <para>
        /// This operation is only used by accounts that are not part of an organization. For
        /// organization accounts, only the administrator account can disassociate a member account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromAdministratorAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateFromAdministratorAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateFromAdministratorAccount">REST API Reference for DisassociateFromAdministratorAccount Operation</seealso>
        public virtual DisassociateFromAdministratorAccountResponse DisassociateFromAdministratorAccount(DisassociateFromAdministratorAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFromAdministratorAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromAdministratorAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateFromAdministratorAccountResponse>(request, options);
        }


        /// <summary>
        /// Disassociates the current Security Hub member account from the associated administrator
        /// account.
        /// 
        ///  
        /// <para>
        /// This operation is only used by accounts that are not part of an organization. For
        /// organization accounts, only the administrator account can disassociate a member account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromAdministratorAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateFromAdministratorAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateFromAdministratorAccount">REST API Reference for DisassociateFromAdministratorAccount Operation</seealso>
        public virtual Task<DisassociateFromAdministratorAccountResponse> DisassociateFromAdministratorAccountAsync(DisassociateFromAdministratorAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFromAdministratorAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromAdministratorAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateFromAdministratorAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateFromMasterAccount


        /// <summary>
        /// This method is deprecated. Instead, use <code>DisassociateFromAdministratorAccount</code>.
        /// 
        ///  
        /// <para>
        /// The Security Hub console continues to use <code>DisassociateFromMasterAccount</code>.
        /// It will eventually change to use <code>DisassociateFromAdministratorAccount</code>.
        /// Any IAM policies that specifically control access to this function must continue to
        /// use <code>DisassociateFromMasterAccount</code>. You should also add <code>DisassociateFromAdministratorAccount</code>
        /// to your policies to ensure that the correct permissions are in place after the console
        /// begins to use <code>DisassociateFromAdministratorAccount</code>.
        /// </para>
        ///  
        /// <para>
        /// Disassociates the current Security Hub member account from the associated administrator
        /// account.
        /// </para>
        ///  
        /// <para>
        /// This operation is only used by accounts that are not part of an organization. For
        /// organization accounts, only the administrator account can disassociate a member account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateFromMasterAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        [Obsolete("This API has been deprecated, use DisassociateFromAdministratorAccount API instead.")]
        public virtual DisassociateFromMasterAccountResponse DisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateFromMasterAccountResponse>(request, options);
        }


        /// <summary>
        /// This method is deprecated. Instead, use <code>DisassociateFromAdministratorAccount</code>.
        /// 
        ///  
        /// <para>
        /// The Security Hub console continues to use <code>DisassociateFromMasterAccount</code>.
        /// It will eventually change to use <code>DisassociateFromAdministratorAccount</code>.
        /// Any IAM policies that specifically control access to this function must continue to
        /// use <code>DisassociateFromMasterAccount</code>. You should also add <code>DisassociateFromAdministratorAccount</code>
        /// to your policies to ensure that the correct permissions are in place after the console
        /// begins to use <code>DisassociateFromAdministratorAccount</code>.
        /// </para>
        ///  
        /// <para>
        /// Disassociates the current Security Hub member account from the associated administrator
        /// account.
        /// </para>
        ///  
        /// <para>
        /// This operation is only used by accounts that are not part of an organization. For
        /// organization accounts, only the administrator account can disassociate a member account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateFromMasterAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        [Obsolete("This API has been deprecated, use DisassociateFromAdministratorAccount API instead.")]
        public virtual Task<DisassociateFromMasterAccountResponse> DisassociateFromMasterAccountAsync(DisassociateFromMasterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateFromMasterAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMembers


        /// <summary>
        /// Disassociates the specified member accounts from the associated administrator account.
        /// 
        ///  
        /// <para>
        /// Can be used to disassociate both accounts that are managed using Organizations and
        /// accounts that were invited manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers service method.</param>
        /// 
        /// <returns>The response from the DisassociateMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        public virtual DisassociateMembersResponse DisassociateMembers(DisassociateMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMembersResponseUnmarshaller.Instance;

            return Invoke<DisassociateMembersResponse>(request, options);
        }


        /// <summary>
        /// Disassociates the specified member accounts from the associated administrator account.
        /// 
        ///  
        /// <para>
        /// Can be used to disassociate both accounts that are managed using Organizations and
        /// accounts that were invited manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        public virtual Task<DisassociateMembersResponse> DisassociateMembersAsync(DisassociateMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMembersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableImportFindingsForProduct


        /// <summary>
        /// Enables the integration of a partner product with Security Hub. Integrated products
        /// send findings to Security Hub.
        /// 
        ///  
        /// <para>
        /// When you enable a product integration, a permissions policy that grants permission
        /// for the product to send findings to Security Hub is applied.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableImportFindingsForProduct service method.</param>
        /// 
        /// <returns>The response from the EnableImportFindingsForProduct service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableImportFindingsForProduct">REST API Reference for EnableImportFindingsForProduct Operation</seealso>
        public virtual EnableImportFindingsForProductResponse EnableImportFindingsForProduct(EnableImportFindingsForProductRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableImportFindingsForProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableImportFindingsForProductResponseUnmarshaller.Instance;

            return Invoke<EnableImportFindingsForProductResponse>(request, options);
        }


        /// <summary>
        /// Enables the integration of a partner product with Security Hub. Integrated products
        /// send findings to Security Hub.
        /// 
        ///  
        /// <para>
        /// When you enable a product integration, a permissions policy that grants permission
        /// for the product to send findings to Security Hub is applied.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableImportFindingsForProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableImportFindingsForProduct service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableImportFindingsForProduct">REST API Reference for EnableImportFindingsForProduct Operation</seealso>
        public virtual Task<EnableImportFindingsForProductResponse> EnableImportFindingsForProductAsync(EnableImportFindingsForProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableImportFindingsForProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableImportFindingsForProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableImportFindingsForProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableOrganizationAdminAccount


        /// <summary>
        /// Designates the Security Hub administrator account for an organization. Can only be
        /// called by the organization management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the EnableOrganizationAdminAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        public virtual EnableOrganizationAdminAccountResponse EnableOrganizationAdminAccount(EnableOrganizationAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableOrganizationAdminAccountResponseUnmarshaller.Instance;

            return Invoke<EnableOrganizationAdminAccountResponse>(request, options);
        }


        /// <summary>
        /// Designates the Security Hub administrator account for an organization. Can only be
        /// called by the organization management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableOrganizationAdminAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        public virtual Task<EnableOrganizationAdminAccountResponse> EnableOrganizationAdminAccountAsync(EnableOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableOrganizationAdminAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableOrganizationAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableSecurityHub


        /// <summary>
        /// Enables Security Hub for your account in the current Region or the Region you specify
        /// in the request.
        /// 
        ///  
        /// <para>
        /// When you enable Security Hub, you grant to Security Hub the permissions necessary
        /// to gather findings from other services that are integrated with Security Hub.
        /// </para>
        ///  
        /// <para>
        /// When you use the <code>EnableSecurityHub</code> operation to enable Security Hub,
        /// you also automatically enable the following standards.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CIS Amazon Web Services Foundations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Foundational Security Best Practices
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You do not enable the Payment Card Industry Data Security Standard (PCI DSS) standard.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To not enable the automatically enabled standards, set <code>EnableDefaultStandards</code>
        /// to <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// After you enable Security Hub, to enable a standard, use the <code>BatchEnableStandards</code>
        /// operation. To disable a standard, use the <code>BatchDisableStandards</code> operation.
        /// </para>
        ///  
        /// <para>
        /// To learn more, see the <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-settingup.html">setup
        /// information</a> in the <i>Security Hub User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSecurityHub service method.</param>
        /// 
        /// <returns>The response from the EnableSecurityHub service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableSecurityHub">REST API Reference for EnableSecurityHub Operation</seealso>
        public virtual EnableSecurityHubResponse EnableSecurityHub(EnableSecurityHubRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSecurityHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSecurityHubResponseUnmarshaller.Instance;

            return Invoke<EnableSecurityHubResponse>(request, options);
        }


        /// <summary>
        /// Enables Security Hub for your account in the current Region or the Region you specify
        /// in the request.
        /// 
        ///  
        /// <para>
        /// When you enable Security Hub, you grant to Security Hub the permissions necessary
        /// to gather findings from other services that are integrated with Security Hub.
        /// </para>
        ///  
        /// <para>
        /// When you use the <code>EnableSecurityHub</code> operation to enable Security Hub,
        /// you also automatically enable the following standards.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CIS Amazon Web Services Foundations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Foundational Security Best Practices
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You do not enable the Payment Card Industry Data Security Standard (PCI DSS) standard.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To not enable the automatically enabled standards, set <code>EnableDefaultStandards</code>
        /// to <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// After you enable Security Hub, to enable a standard, use the <code>BatchEnableStandards</code>
        /// operation. To disable a standard, use the <code>BatchDisableStandards</code> operation.
        /// </para>
        ///  
        /// <para>
        /// To learn more, see the <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-settingup.html">setup
        /// information</a> in the <i>Security Hub User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSecurityHub service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableSecurityHub service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableSecurityHub">REST API Reference for EnableSecurityHub Operation</seealso>
        public virtual Task<EnableSecurityHubResponse> EnableSecurityHubAsync(EnableSecurityHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSecurityHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSecurityHubResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableSecurityHubResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAdministratorAccount


        /// <summary>
        /// Provides the details for the Security Hub administrator account for the current member
        /// account.
        /// 
        ///  
        /// <para>
        /// Can be used by both member accounts that are managed using Organizations and accounts
        /// that were invited manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdministratorAccount service method.</param>
        /// 
        /// <returns>The response from the GetAdministratorAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetAdministratorAccount">REST API Reference for GetAdministratorAccount Operation</seealso>
        public virtual GetAdministratorAccountResponse GetAdministratorAccount(GetAdministratorAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAdministratorAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdministratorAccountResponseUnmarshaller.Instance;

            return Invoke<GetAdministratorAccountResponse>(request, options);
        }


        /// <summary>
        /// Provides the details for the Security Hub administrator account for the current member
        /// account.
        /// 
        ///  
        /// <para>
        /// Can be used by both member accounts that are managed using Organizations and accounts
        /// that were invited manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdministratorAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAdministratorAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetAdministratorAccount">REST API Reference for GetAdministratorAccount Operation</seealso>
        public virtual Task<GetAdministratorAccountResponse> GetAdministratorAccountAsync(GetAdministratorAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAdministratorAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdministratorAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAdministratorAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEnabledStandards


        /// <summary>
        /// Returns a list of the standards that are currently enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledStandards service method.</param>
        /// 
        /// <returns>The response from the GetEnabledStandards service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetEnabledStandards">REST API Reference for GetEnabledStandards Operation</seealso>
        public virtual GetEnabledStandardsResponse GetEnabledStandards(GetEnabledStandardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnabledStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnabledStandardsResponseUnmarshaller.Instance;

            return Invoke<GetEnabledStandardsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the standards that are currently enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledStandards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnabledStandards service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetEnabledStandards">REST API Reference for GetEnabledStandards Operation</seealso>
        public virtual Task<GetEnabledStandardsResponse> GetEnabledStandardsAsync(GetEnabledStandardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnabledStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnabledStandardsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEnabledStandardsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFindingAggregator


        /// <summary>
        /// Returns the current finding aggregation configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingAggregator service method.</param>
        /// 
        /// <returns>The response from the GetFindingAggregator service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindingAggregator">REST API Reference for GetFindingAggregator Operation</seealso>
        public virtual GetFindingAggregatorResponse GetFindingAggregator(GetFindingAggregatorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingAggregatorResponseUnmarshaller.Instance;

            return Invoke<GetFindingAggregatorResponse>(request, options);
        }


        /// <summary>
        /// Returns the current finding aggregation configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingAggregator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindingAggregator service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindingAggregator">REST API Reference for GetFindingAggregator Operation</seealso>
        public virtual Task<GetFindingAggregatorResponse> GetFindingAggregatorAsync(GetFindingAggregatorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingAggregatorResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFindingAggregatorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFindings


        /// <summary>
        /// Returns a list of findings that match the specified criteria.
        /// 
        ///  
        /// <para>
        /// If finding aggregation is enabled, then when you call <code>GetFindings</code> from
        /// the aggregation Region, the results include all of the matching findings from both
        /// the aggregation Region and the linked Regions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
        /// 
        /// <returns>The response from the GetFindings service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindings">REST API Reference for GetFindings Operation</seealso>
        public virtual GetFindingsResponse GetFindings(GetFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsResponseUnmarshaller.Instance;

            return Invoke<GetFindingsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of findings that match the specified criteria.
        /// 
        ///  
        /// <para>
        /// If finding aggregation is enabled, then when you call <code>GetFindings</code> from
        /// the aggregation Region, the results include all of the matching findings from both
        /// the aggregation Region and the linked Regions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindings service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindings">REST API Reference for GetFindings Operation</seealso>
        public virtual Task<GetFindingsResponse> GetFindingsAsync(GetFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFindingsResponse>(request, options, cancellationToken);
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
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsightResults">REST API Reference for GetInsightResults Operation</seealso>
        public virtual GetInsightResultsResponse GetInsightResults(GetInsightResultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightResultsResponseUnmarshaller.Instance;

            return Invoke<GetInsightResultsResponse>(request, options);
        }


        /// <summary>
        /// Lists the results of the Security Hub insight specified by the insight ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInsightResults service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsightResults">REST API Reference for GetInsightResults Operation</seealso>
        public virtual Task<GetInsightResultsResponse> GetInsightResultsAsync(GetInsightResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightResultsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInsightResultsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInsights


        /// <summary>
        /// Lists and describes insights for the specified insight ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsights service method.</param>
        /// 
        /// <returns>The response from the GetInsights service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsights">REST API Reference for GetInsights Operation</seealso>
        public virtual GetInsightsResponse GetInsights(GetInsightsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightsResponseUnmarshaller.Instance;

            return Invoke<GetInsightsResponse>(request, options);
        }


        /// <summary>
        /// Lists and describes insights for the specified insight ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsights service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInsights service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsights">REST API Reference for GetInsights Operation</seealso>
        public virtual Task<GetInsightsResponse> GetInsightsAsync(GetInsightsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInsightsResponse>(request, options, cancellationToken);
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
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        public virtual GetInvitationsCountResponse GetInvitationsCount(GetInvitationsCountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInvitationsCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;

            return Invoke<GetInvitationsCountResponse>(request, options);
        }


        /// <summary>
        /// Returns the count of all Security Hub membership invitations that were sent to the
        /// current member account, not including the currently accepted invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInvitationsCount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        public virtual Task<GetInvitationsCountResponse> GetInvitationsCountAsync(GetInvitationsCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInvitationsCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInvitationsCountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMasterAccount


        /// <summary>
        /// This method is deprecated. Instead, use <code>GetAdministratorAccount</code>.
        /// 
        ///  
        /// <para>
        /// The Security Hub console continues to use <code>GetMasterAccount</code>. It will eventually
        /// change to use <code>GetAdministratorAccount</code>. Any IAM policies that specifically
        /// control access to this function must continue to use <code>GetMasterAccount</code>.
        /// You should also add <code>GetAdministratorAccount</code> to your policies to ensure
        /// that the correct permissions are in place after the console begins to use <code>GetAdministratorAccount</code>.
        /// </para>
        ///  
        /// <para>
        /// Provides the details for the Security Hub administrator account for the current member
        /// account.
        /// </para>
        ///  
        /// <para>
        /// Can be used by both member accounts that are managed using Organizations and accounts
        /// that were invited manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount service method.</param>
        /// 
        /// <returns>The response from the GetMasterAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        [Obsolete("This API has been deprecated, use GetAdministratorAccount API instead.")]
        public virtual GetMasterAccountResponse GetMasterAccount(GetMasterAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMasterAccountResponseUnmarshaller.Instance;

            return Invoke<GetMasterAccountResponse>(request, options);
        }


        /// <summary>
        /// This method is deprecated. Instead, use <code>GetAdministratorAccount</code>.
        /// 
        ///  
        /// <para>
        /// The Security Hub console continues to use <code>GetMasterAccount</code>. It will eventually
        /// change to use <code>GetAdministratorAccount</code>. Any IAM policies that specifically
        /// control access to this function must continue to use <code>GetMasterAccount</code>.
        /// You should also add <code>GetAdministratorAccount</code> to your policies to ensure
        /// that the correct permissions are in place after the console begins to use <code>GetAdministratorAccount</code>.
        /// </para>
        ///  
        /// <para>
        /// Provides the details for the Security Hub administrator account for the current member
        /// account.
        /// </para>
        ///  
        /// <para>
        /// Can be used by both member accounts that are managed using Organizations and accounts
        /// that were invited manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMasterAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        [Obsolete("This API has been deprecated, use GetAdministratorAccount API instead.")]
        public virtual Task<GetMasterAccountResponse> GetMasterAccountAsync(GetMasterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMasterAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMasterAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMembers


        /// <summary>
        /// Returns the details for the Security Hub member accounts for the specified account
        /// IDs.
        /// 
        ///  
        /// <para>
        /// An administrator account can be either the delegated Security Hub administrator account
        /// for an organization or an administrator account that enabled Security Hub manually.
        /// </para>
        ///  
        /// <para>
        /// The results include both member accounts that are managed using Organizations and
        /// accounts that were invited manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembers service method.</param>
        /// 
        /// <returns>The response from the GetMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMembers">REST API Reference for GetMembers Operation</seealso>
        public virtual GetMembersResponse GetMembers(GetMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembersResponseUnmarshaller.Instance;

            return Invoke<GetMembersResponse>(request, options);
        }


        /// <summary>
        /// Returns the details for the Security Hub member accounts for the specified account
        /// IDs.
        /// 
        ///  
        /// <para>
        /// An administrator account can be either the delegated Security Hub administrator account
        /// for an organization or an administrator account that enabled Security Hub manually.
        /// </para>
        ///  
        /// <para>
        /// The results include both member accounts that are managed using Organizations and
        /// accounts that were invited manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMembers">REST API Reference for GetMembers Operation</seealso>
        public virtual Task<GetMembersResponse> GetMembersAsync(GetMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembersResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InviteMembers


        /// <summary>
        /// Invites other Amazon Web Services accounts to become member accounts for the Security
        /// Hub administrator account that the invitation is sent from.
        /// 
        ///  
        /// <para>
        /// This operation is only used to invite accounts that do not belong to an organization.
        /// Organization accounts do not receive invitations.
        /// </para>
        ///  
        /// <para>
        /// Before you can use this action to invite a member, you must first use the <code>CreateMembers</code>
        /// action to create the member account in Security Hub.
        /// </para>
        ///  
        /// <para>
        /// When the account owner enables Security Hub and accepts the invitation to become a
        /// member account, the administrator account can view the findings generated from the
        /// member account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers service method.</param>
        /// 
        /// <returns>The response from the InviteMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        public virtual InviteMembersResponse InviteMembers(InviteMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InviteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InviteMembersResponseUnmarshaller.Instance;

            return Invoke<InviteMembersResponse>(request, options);
        }


        /// <summary>
        /// Invites other Amazon Web Services accounts to become member accounts for the Security
        /// Hub administrator account that the invitation is sent from.
        /// 
        ///  
        /// <para>
        /// This operation is only used to invite accounts that do not belong to an organization.
        /// Organization accounts do not receive invitations.
        /// </para>
        ///  
        /// <para>
        /// Before you can use this action to invite a member, you must first use the <code>CreateMembers</code>
        /// action to create the member account in Security Hub.
        /// </para>
        ///  
        /// <para>
        /// When the account owner enables Security Hub and accepts the invitation to become a
        /// member account, the administrator account can view the findings generated from the
        /// member account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InviteMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        public virtual Task<InviteMembersResponse> InviteMembersAsync(InviteMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InviteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InviteMembersResponseUnmarshaller.Instance;
            
            return InvokeAsync<InviteMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnabledProductsForImport


        /// <summary>
        /// Lists all findings-generating solutions (products) that you are subscribed to receive
        /// findings from in Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledProductsForImport service method.</param>
        /// 
        /// <returns>The response from the ListEnabledProductsForImport service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListEnabledProductsForImport">REST API Reference for ListEnabledProductsForImport Operation</seealso>
        public virtual ListEnabledProductsForImportResponse ListEnabledProductsForImport(ListEnabledProductsForImportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnabledProductsForImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnabledProductsForImportResponseUnmarshaller.Instance;

            return Invoke<ListEnabledProductsForImportResponse>(request, options);
        }


        /// <summary>
        /// Lists all findings-generating solutions (products) that you are subscribed to receive
        /// findings from in Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledProductsForImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnabledProductsForImport service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListEnabledProductsForImport">REST API Reference for ListEnabledProductsForImport Operation</seealso>
        public virtual Task<ListEnabledProductsForImportResponse> ListEnabledProductsForImportAsync(ListEnabledProductsForImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnabledProductsForImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnabledProductsForImportResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEnabledProductsForImportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFindingAggregators


        /// <summary>
        /// If finding aggregation is enabled, then <code>ListFindingAggregators</code> returns
        /// the ARN of the finding aggregator. You can run this operation from any Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingAggregators service method.</param>
        /// 
        /// <returns>The response from the ListFindingAggregators service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListFindingAggregators">REST API Reference for ListFindingAggregators Operation</seealso>
        public virtual ListFindingAggregatorsResponse ListFindingAggregators(ListFindingAggregatorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingAggregatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingAggregatorsResponseUnmarshaller.Instance;

            return Invoke<ListFindingAggregatorsResponse>(request, options);
        }


        /// <summary>
        /// If finding aggregation is enabled, then <code>ListFindingAggregators</code> returns
        /// the ARN of the finding aggregator. You can run this operation from any Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingAggregators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindingAggregators service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListFindingAggregators">REST API Reference for ListFindingAggregators Operation</seealso>
        public virtual Task<ListFindingAggregatorsResponse> ListFindingAggregatorsAsync(ListFindingAggregatorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingAggregatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingAggregatorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFindingAggregatorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInvitations


        /// <summary>
        /// Lists all Security Hub membership invitations that were sent to the current Amazon
        /// Web Services account.
        /// 
        ///  
        /// <para>
        /// This operation is only used by accounts that are managed by invitation. Accounts that
        /// are managed using the integration with Organizations do not receive invitations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual ListInvitationsResponse ListInvitations(ListInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return Invoke<ListInvitationsResponse>(request, options);
        }


        /// <summary>
        /// Lists all Security Hub membership invitations that were sent to the current Amazon
        /// Web Services account.
        /// 
        ///  
        /// <para>
        /// This operation is only used by accounts that are managed by invitation. Accounts that
        /// are managed using the integration with Organizations do not receive invitations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
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
        /// Lists details about all member accounts for the current Security Hub administrator
        /// account.
        /// 
        ///  
        /// <para>
        /// The results include both member accounts that belong to an organization and member
        /// accounts that were invited manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual ListMembersResponse ListMembers(ListMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return Invoke<ListMembersResponse>(request, options);
        }


        /// <summary>
        /// Lists details about all member accounts for the current Security Hub administrator
        /// account.
        /// 
        ///  
        /// <para>
        /// The results include both member accounts that belong to an organization and member
        /// accounts that were invited manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListMembers">REST API Reference for ListMembers Operation</seealso>
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
        /// Lists the Security Hub administrator accounts. Can only be called by the organization
        /// management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationAdminAccounts service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationAdminAccounts service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
        public virtual ListOrganizationAdminAccountsResponse ListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationAdminAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationAdminAccountsResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationAdminAccountsResponse>(request, options);
        }


        /// <summary>
        /// Lists the Security Hub administrator accounts. Can only be called by the organization
        /// management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationAdminAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationAdminAccounts service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
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
        /// Returns a list of tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds one or more tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateActionTarget


        /// <summary>
        /// Updates the name and description of a custom action target in Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateActionTarget service method.</param>
        /// 
        /// <returns>The response from the UpdateActionTarget service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateActionTarget">REST API Reference for UpdateActionTarget Operation</seealso>
        public virtual UpdateActionTargetResponse UpdateActionTarget(UpdateActionTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateActionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateActionTargetResponseUnmarshaller.Instance;

            return Invoke<UpdateActionTargetResponse>(request, options);
        }


        /// <summary>
        /// Updates the name and description of a custom action target in Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateActionTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateActionTarget service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateActionTarget">REST API Reference for UpdateActionTarget Operation</seealso>
        public virtual Task<UpdateActionTargetResponse> UpdateActionTargetAsync(UpdateActionTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateActionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateActionTargetResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateActionTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFindingAggregator


        /// <summary>
        /// Updates the finding aggregation configuration. Used to update the Region linking mode
        /// and the list of included or excluded Regions. You cannot use <code>UpdateFindingAggregator</code>
        /// to change the aggregation Region.
        /// 
        ///  
        /// <para>
        /// You must run <code>UpdateFindingAggregator</code> from the current aggregation Region.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingAggregator service method.</param>
        /// 
        /// <returns>The response from the UpdateFindingAggregator service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateFindingAggregator">REST API Reference for UpdateFindingAggregator Operation</seealso>
        public virtual UpdateFindingAggregatorResponse UpdateFindingAggregator(UpdateFindingAggregatorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingAggregatorResponseUnmarshaller.Instance;

            return Invoke<UpdateFindingAggregatorResponse>(request, options);
        }


        /// <summary>
        /// Updates the finding aggregation configuration. Used to update the Region linking mode
        /// and the list of included or excluded Regions. You cannot use <code>UpdateFindingAggregator</code>
        /// to change the aggregation Region.
        /// 
        ///  
        /// <para>
        /// You must run <code>UpdateFindingAggregator</code> from the current aggregation Region.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingAggregator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFindingAggregator service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateFindingAggregator">REST API Reference for UpdateFindingAggregator Operation</seealso>
        public virtual Task<UpdateFindingAggregatorResponse> UpdateFindingAggregatorAsync(UpdateFindingAggregatorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingAggregatorResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFindingAggregatorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFindings


        /// <summary>
        /// <code>UpdateFindings</code> is deprecated. Instead of <code>UpdateFindings</code>,
        /// use <code>BatchUpdateFindings</code>.
        /// 
        ///  
        /// <para>
        /// Updates the <code>Note</code> and <code>RecordState</code> of the Security Hub-aggregated
        /// findings that the filter attributes specify. Any member account that can view the
        /// finding also sees the update to the finding.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindings service method.</param>
        /// 
        /// <returns>The response from the UpdateFindings service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateFindings">REST API Reference for UpdateFindings Operation</seealso>
        public virtual UpdateFindingsResponse UpdateFindings(UpdateFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingsResponseUnmarshaller.Instance;

            return Invoke<UpdateFindingsResponse>(request, options);
        }


        /// <summary>
        /// <code>UpdateFindings</code> is deprecated. Instead of <code>UpdateFindings</code>,
        /// use <code>BatchUpdateFindings</code>.
        /// 
        ///  
        /// <para>
        /// Updates the <code>Note</code> and <code>RecordState</code> of the Security Hub-aggregated
        /// findings that the filter attributes specify. Any member account that can view the
        /// finding also sees the update to the finding.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFindings service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateFindings">REST API Reference for UpdateFindings Operation</seealso>
        public virtual Task<UpdateFindingsResponse> UpdateFindingsAsync(UpdateFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateInsight


        /// <summary>
        /// Updates the Security Hub insight identified by the specified insight ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInsight service method.</param>
        /// 
        /// <returns>The response from the UpdateInsight service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateInsight">REST API Reference for UpdateInsight Operation</seealso>
        public virtual UpdateInsightResponse UpdateInsight(UpdateInsightRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInsightResponseUnmarshaller.Instance;

            return Invoke<UpdateInsightResponse>(request, options);
        }


        /// <summary>
        /// Updates the Security Hub insight identified by the specified insight ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInsight service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInsight service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateInsight">REST API Reference for UpdateInsight Operation</seealso>
        public virtual Task<UpdateInsightResponse> UpdateInsightAsync(UpdateInsightRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInsightResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateInsightResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateOrganizationConfiguration


        /// <summary>
        /// Used to update the configuration related to Organizations. Can only be called from
        /// a Security Hub administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateOrganizationConfiguration service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        public virtual UpdateOrganizationConfigurationResponse UpdateOrganizationConfiguration(UpdateOrganizationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateOrganizationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Used to update the configuration related to Organizations. Can only be called from
        /// a Security Hub administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOrganizationConfiguration service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        public virtual Task<UpdateOrganizationConfigurationResponse> UpdateOrganizationConfigurationAsync(UpdateOrganizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateOrganizationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSecurityHubConfiguration


        /// <summary>
        /// Updates configuration options for Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityHubConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateSecurityHubConfiguration service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateSecurityHubConfiguration">REST API Reference for UpdateSecurityHubConfiguration Operation</seealso>
        public virtual UpdateSecurityHubConfigurationResponse UpdateSecurityHubConfiguration(UpdateSecurityHubConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityHubConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityHubConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityHubConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates configuration options for Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityHubConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSecurityHubConfiguration service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account or throttling limits. The error code describes the limit
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateSecurityHubConfiguration">REST API Reference for UpdateSecurityHubConfiguration Operation</seealso>
        public virtual Task<UpdateSecurityHubConfigurationResponse> UpdateSecurityHubConfigurationAsync(UpdateSecurityHubConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityHubConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityHubConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSecurityHubConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStandardsControl


        /// <summary>
        /// Used to control whether an individual security standard control is enabled or disabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStandardsControl service method.</param>
        /// 
        /// <returns>The response from the UpdateStandardsControl service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateStandardsControl">REST API Reference for UpdateStandardsControl Operation</seealso>
        public virtual UpdateStandardsControlResponse UpdateStandardsControl(UpdateStandardsControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStandardsControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStandardsControlResponseUnmarshaller.Instance;

            return Invoke<UpdateStandardsControlResponse>(request, options);
        }


        /// <summary>
        /// Used to control whether an individual security standard control is enabled or disabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStandardsControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStandardsControl service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// The account doesn't have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateStandardsControl">REST API Reference for UpdateStandardsControl Operation</seealso>
        public virtual Task<UpdateStandardsControlResponse> UpdateStandardsControlAsync(UpdateStandardsControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStandardsControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStandardsControlResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateStandardsControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}