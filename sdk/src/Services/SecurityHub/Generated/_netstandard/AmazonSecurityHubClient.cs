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
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SecurityHub
{
    /// <summary>
    /// <para>Implementation for accessing SecurityHub</para>
    ///
    /// Security Hub provides you with a comprehensive view of your security state in Amazon
    /// Web Services and helps you assess your Amazon Web Services environment against security
    /// industry standards and best practices.
    /// 
    ///  
    /// <para>
    /// Security Hub collects security data across Amazon Web Services accounts, Amazon Web
    /// Services services, and supported third-party products and helps you analyze your security
    /// trends and identify the highest priority security issues.
    /// </para>
    ///  
    /// <para>
    /// To help you manage the security state of your organization, Security Hub supports
    /// multiple security standards. These include the Amazon Web Services Foundational Security
    /// Best Practices (FSBP) standard developed by Amazon Web Services, and external compliance
    /// frameworks such as the Center for Internet Security (CIS), the Payment Card Industry
    /// Data Security Standard (PCI DSS), and the National Institute of Standards and Technology
    /// (NIST). Each standard includes several security controls, each of which represents
    /// a security best practice. Security Hub runs checks against security controls and generates
    /// control findings to help you assess your compliance against security best practices.
    /// </para>
    ///  
    /// <para>
    /// In addition to generating control findings, Security Hub also receives findings from
    /// other Amazon Web Services services, such as Amazon GuardDuty and Amazon Inspector,
    /// and supported third-party products. This gives you a single pane of glass into a variety
    /// of security-related issues. You can also send Security Hub findings to other Amazon
    /// Web Services services and supported third-party products.
    /// </para>
    ///  
    /// <para>
    /// Security Hub offers automation features that help you triage and remediate security
    /// issues. For example, you can use automation rules to automatically update critical
    /// findings when a security check fails. You can also leverage the integration with Amazon
    /// EventBridge to trigger automatic responses to specific findings.
    /// </para>
    ///  
    /// <para>
    /// This guide, the <i>Security Hub API Reference</i>, provides information about the
    /// Security Hub API. This includes supported resources, HTTP methods, parameters, and
    /// schemas. If you're new to Security Hub, you might find it helpful to also review the
    /// <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/what-is-securityhub.html">
    /// <i>Security Hub User Guide</i> </a>. The user guide explains key concepts and provides
    /// procedures that demonstrate how to use Security Hub features. It also provides information
    /// about topics such as integrating Security Hub with other Amazon Web Services services.
    /// </para>
    ///  
    /// <para>
    /// In addition to interacting with Security Hub by making calls to the Security Hub API,
    /// you can use a current version of an Amazon Web Services command line tool or SDK.
    /// Amazon Web Services provides tools and SDKs that consist of libraries and sample code
    /// for various languages and platforms, such as PowerShell, Java, Go, Python, C++, and
    /// .NET. These tools and SDKs provide convenient, programmatic access to Security Hub
    /// and other Amazon Web Services services . They also handle tasks such as signing requests,
    /// managing errors, and retrying requests automatically. For information about installing
    /// and using the Amazon Web Services tools and SDKs, see <a href="http://aws.amazon.com/developer/tools/">Tools
    /// to Build on Amazon Web Services</a>.
    /// </para>
    ///  
    /// <para>
    /// With the exception of operations that are related to central configuration, Security
    /// Hub API requests are executed only in the Amazon Web Services Region that is currently
    /// active or in the specific Amazon Web Services Region that you specify in your request.
    /// Any configuration or settings change that results from the operation is applied only
    /// to that Region. To make the same change in other Regions, call the same API operation
    /// in each Region in which you want to apply the change. When you use central configuration,
    /// API requests for enabling Security Hub, standards, and controls are executed in the
    /// home Region and all linked Regions. For a list of central configuration operations,
    /// see the <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/central-configuration-intro.html#central-configuration-concepts">Central
    /// configuration terms and concepts</a> section of the <i>Security Hub User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The following throttling limits apply to Security Hub API operations.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>BatchEnableStandards</c> - <c>RateLimit</c> of 1 request per second. <c>BurstLimit</c>
    /// of 1 request per second.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GetFindings</c> - <c>RateLimit</c> of 3 requests per second. <c>BurstLimit</c>
    /// of 6 requests per second.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>BatchImportFindings</c> - <c>RateLimit</c> of 10 requests per second. <c>BurstLimit</c>
    /// of 30 requests per second.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>BatchUpdateFindings</c> - <c>RateLimit</c> of 10 requests per second. <c>BurstLimit</c>
    /// of 30 requests per second.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UpdateStandardsControl</c> - <c>RateLimit</c> of 1 request per second. <c>BurstLimit</c>
    /// of 5 requests per second.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// All other operations - <c>RateLimit</c> of 10 requests per second. <c>BurstLimit</c>
    /// of 30 requests per second.
    /// </para>
    ///  </li> </ul>
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
            : base(new AmazonSecurityHubConfig()) { }

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
            : base(new AmazonSecurityHubConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
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
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSecurityHubEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSecurityHubAuthSchemeHandler());
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

        internal virtual AcceptAdministratorInvitationResponse AcceptAdministratorInvitation(AcceptAdministratorInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptAdministratorInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptAdministratorInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptAdministratorInvitationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// We recommend using Organizations instead of Security Hub invitations to manage your
        /// member accounts. For information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-accounts-orgs.html">Managing
        /// Security Hub administrator and member accounts with Organizations</a> in the <i>Security
        /// Hub User Guide</i>.
        /// </para>
        ///  </note> 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptAdministratorInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptAdministratorInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptAdministratorInvitationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AcceptInvitation

        [Obsolete("This API has been deprecated, use AcceptAdministratorInvitation API instead.")]
        internal virtual AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptInvitationResponse>(request, options);
        }



        /// <summary>
        /// This method is deprecated. Instead, use <c>AcceptAdministratorInvitation</c>.
        /// 
        ///  
        /// <para>
        /// The Security Hub console continues to use <c>AcceptInvitation</c>. It will eventually
        /// change to use <c>AcceptAdministratorInvitation</c>. Any IAM policies that specifically
        /// control access to this function must continue to use <c>AcceptInvitation</c>. You
        /// should also add <c>AcceptAdministratorInvitation</c> to your policies to ensure that
        /// the correct permissions are in place after the console begins to use <c>AcceptAdministratorInvitation</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptInvitationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeleteAutomationRules

        internal virtual BatchDeleteAutomationRulesResponse BatchDeleteAutomationRules(BatchDeleteAutomationRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteAutomationRulesResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteAutomationRulesResponse>(request, options);
        }



        /// <summary>
        /// Deletes one or more automation rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteAutomationRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteAutomationRules service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchDeleteAutomationRules">REST API Reference for BatchDeleteAutomationRules Operation</seealso>
        public virtual Task<BatchDeleteAutomationRulesResponse> BatchDeleteAutomationRulesAsync(BatchDeleteAutomationRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteAutomationRulesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteAutomationRulesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDisableStandards

        internal virtual BatchDisableStandardsResponse BatchDisableStandards(BatchDisableStandardsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisableStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisableStandardsResponseUnmarshaller.Instance;

            return Invoke<BatchDisableStandardsResponse>(request, options);
        }



        /// <summary>
        /// Disables the standards specified by the provided <c>StandardsSubscriptionArns</c>.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchDisableStandards">REST API Reference for BatchDisableStandards Operation</seealso>
        public virtual Task<BatchDisableStandardsResponse> BatchDisableStandardsAsync(BatchDisableStandardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisableStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisableStandardsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDisableStandardsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchEnableStandards

        internal virtual BatchEnableStandardsResponse BatchEnableStandards(BatchEnableStandardsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchEnableStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchEnableStandardsResponseUnmarshaller.Instance;

            return Invoke<BatchEnableStandardsResponse>(request, options);
        }



        /// <summary>
        /// Enables the standards specified by the provided <c>StandardsArn</c>. To obtain the
        /// ARN for a standard, use the <c>DescribeStandards</c> operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchEnableStandards">REST API Reference for BatchEnableStandards Operation</seealso>
        public virtual Task<BatchEnableStandardsResponse> BatchEnableStandardsAsync(BatchEnableStandardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchEnableStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchEnableStandardsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchEnableStandardsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetAutomationRules

        internal virtual BatchGetAutomationRulesResponse BatchGetAutomationRules(BatchGetAutomationRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAutomationRulesResponseUnmarshaller.Instance;

            return Invoke<BatchGetAutomationRulesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of details for automation rules based on rule Amazon Resource Names
        /// (ARNs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAutomationRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetAutomationRules service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchGetAutomationRules">REST API Reference for BatchGetAutomationRules Operation</seealso>
        public virtual Task<BatchGetAutomationRulesResponse> BatchGetAutomationRulesAsync(BatchGetAutomationRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAutomationRulesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetAutomationRulesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetConfigurationPolicyAssociations

        internal virtual BatchGetConfigurationPolicyAssociationsResponse BatchGetConfigurationPolicyAssociations(BatchGetConfigurationPolicyAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetConfigurationPolicyAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetConfigurationPolicyAssociationsResponseUnmarshaller.Instance;

            return Invoke<BatchGetConfigurationPolicyAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Returns associations between an Security Hub configuration and a batch of target
        /// accounts, organizational units, or the root. Only the Security Hub delegated administrator
        /// can invoke this operation from the home Region. A configuration can refer to a configuration
        /// policy or to a self-managed configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetConfigurationPolicyAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetConfigurationPolicyAssociations service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchGetConfigurationPolicyAssociations">REST API Reference for BatchGetConfigurationPolicyAssociations Operation</seealso>
        public virtual Task<BatchGetConfigurationPolicyAssociationsResponse> BatchGetConfigurationPolicyAssociationsAsync(BatchGetConfigurationPolicyAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetConfigurationPolicyAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetConfigurationPolicyAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetConfigurationPolicyAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetSecurityControls

        internal virtual BatchGetSecurityControlsResponse BatchGetSecurityControls(BatchGetSecurityControlsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetSecurityControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSecurityControlsResponseUnmarshaller.Instance;

            return Invoke<BatchGetSecurityControlsResponse>(request, options);
        }



        /// <summary>
        /// Provides details about a batch of security controls for the current Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSecurityControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetSecurityControls service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchGetSecurityControls">REST API Reference for BatchGetSecurityControls Operation</seealso>
        public virtual Task<BatchGetSecurityControlsResponse> BatchGetSecurityControlsAsync(BatchGetSecurityControlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetSecurityControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSecurityControlsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetSecurityControlsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetStandardsControlAssociations

        internal virtual BatchGetStandardsControlAssociationsResponse BatchGetStandardsControlAssociations(BatchGetStandardsControlAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetStandardsControlAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetStandardsControlAssociationsResponseUnmarshaller.Instance;

            return Invoke<BatchGetStandardsControlAssociationsResponse>(request, options);
        }



        /// <summary>
        /// For a batch of security controls and standards, identifies whether each control is
        /// currently enabled or disabled in a standard. 
        /// 
        ///  
        /// <para>
        ///  Calls to this operation return a <c>RESOURCE_NOT_FOUND_EXCEPTION</c> error when the
        /// standard subscription for the association has a <c>NOT_READY_FOR_UPDATES</c> value
        /// for <c>StandardsControlsUpdatable</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetStandardsControlAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetStandardsControlAssociations service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchGetStandardsControlAssociations">REST API Reference for BatchGetStandardsControlAssociations Operation</seealso>
        public virtual Task<BatchGetStandardsControlAssociationsResponse> BatchGetStandardsControlAssociationsAsync(BatchGetStandardsControlAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetStandardsControlAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetStandardsControlAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetStandardsControlAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchImportFindings

        internal virtual BatchImportFindingsResponse BatchImportFindings(BatchImportFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        ///  <c>BatchImportFindings</c> must be called by one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The Amazon Web Services account that is associated with a finding if you are using
        /// the <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-custom-providers.html#securityhub-custom-providers-bfi-reqs">default
        /// product ARN</a> or are a partner sending findings from within a customer's Amazon
        /// Web Services account. In these cases, the identifier of the account that you are calling
        /// <c>BatchImportFindings</c> from needs to be the same as the <c>AwsAccountId</c> attribute
        /// for the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon Web Services account that Security Hub has allow-listed for an official
        /// partner integration. In this case, you can call <c>BatchImportFindings</c> from the
        /// allow-listed account and send findings from different customer accounts in the same
        /// batch.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The maximum allowed size for a finding is 240 Kb. An error is returned for any finding
        /// larger than 240 Kb.
        /// </para>
        ///  
        /// <para>
        /// After a finding is created, <c>BatchImportFindings</c> cannot be used to update the
        /// following finding fields and objects, which Security Hub customers use to manage their
        /// investigation workflow.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Note</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UserDefinedFields</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VerificationState</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Workflow</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Finding providers also should not use <c>BatchImportFindings</c> to update the following
        /// attributes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Confidence</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Criticality</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RelatedFindings</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Severity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Types</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Instead, finding providers use <c>FindingProviderFields</c> to provide values for
        /// these attributes.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchImportFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchImportFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchImportFindingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchUpdateAutomationRules

        internal virtual BatchUpdateAutomationRulesResponse BatchUpdateAutomationRules(BatchUpdateAutomationRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateAutomationRulesResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateAutomationRulesResponse>(request, options);
        }



        /// <summary>
        /// Updates one or more automation rules based on rule Amazon Resource Names (ARNs) and
        /// input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateAutomationRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateAutomationRules service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchUpdateAutomationRules">REST API Reference for BatchUpdateAutomationRules Operation</seealso>
        public virtual Task<BatchUpdateAutomationRulesResponse> BatchUpdateAutomationRulesAsync(BatchUpdateAutomationRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateAutomationRulesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUpdateAutomationRulesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchUpdateFindings

        internal virtual BatchUpdateFindingsResponse BatchUpdateFindings(BatchUpdateFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateFindingsResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateFindingsResponse>(request, options);
        }



        /// <summary>
        /// Used by Security Hub customers to update information about their investigation into
        /// one or more findings. Requested by administrator accounts or member accounts. Administrator
        /// accounts can update findings for their account and their member accounts. A member
        /// account can update findings only for their own account. Administrator and member accounts
        /// can use this operation to update the following fields and objects for one or more
        /// findings: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>Confidence</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Criticality</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Note</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RelatedFindings</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Severity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Types</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UserDefinedFields</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VerificationState</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Workflow</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If you use this operation to update a finding, your updates don’t affect the value
        /// for the <c>UpdatedAt</c> field of the finding. Also note that it can take several
        /// minutes for Security Hub to process your request and update each finding specified
        /// in the request. 
        /// </para>
        ///  
        /// <para>
        ///  You can configure IAM policies to restrict access to fields and field values. For
        /// example, you might not want member accounts to be able to suppress findings or change
        /// the finding severity. For more information see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/finding-update-batchupdatefindings.html#batchupdatefindings-configure-access">Configuring
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUpdateFindingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchUpdateFindingsV2

        internal virtual BatchUpdateFindingsV2Response BatchUpdateFindingsV2(BatchUpdateFindingsV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateFindingsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateFindingsV2ResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateFindingsV2Response>(request, options);
        }



        /// <summary>
        /// Used by customers to update information about their investigation into a finding.
        /// Requested by delegated administrator accounts or member accounts. Delegated administrator
        /// accounts can update findings for their account and their member accounts. Member accounts
        /// can update findings for their account. <c>BatchUpdateFindings</c> and <c>BatchUpdateFindingV2</c>
        /// both use <c>securityhub:BatchUpdateFindings</c> in the <c>Action</c> element of an
        /// IAM policy statement. You must have permission to perform the <c>securityhub:BatchUpdateFindings</c>
        /// action. Updates from <c>BatchUpdateFindingsV2</c> don't affect the value of f<c>inding_info.modified_time</c>,
        /// <c>finding_info.modified_time_dt</c>, <c>time</c>, <c>time_dt for a finding</c>. This
        /// API is in private preview and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateFindingsV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateFindingsV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchUpdateFindingsV2">REST API Reference for BatchUpdateFindingsV2 Operation</seealso>
        public virtual Task<BatchUpdateFindingsV2Response> BatchUpdateFindingsV2Async(BatchUpdateFindingsV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateFindingsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateFindingsV2ResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUpdateFindingsV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchUpdateStandardsControlAssociations

        internal virtual BatchUpdateStandardsControlAssociationsResponse BatchUpdateStandardsControlAssociations(BatchUpdateStandardsControlAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateStandardsControlAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateStandardsControlAssociationsResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateStandardsControlAssociationsResponse>(request, options);
        }



        /// <summary>
        /// For a batch of security controls and standards, this operation updates the enablement
        /// status of a control in a standard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateStandardsControlAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateStandardsControlAssociations service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchUpdateStandardsControlAssociations">REST API Reference for BatchUpdateStandardsControlAssociations Operation</seealso>
        public virtual Task<BatchUpdateStandardsControlAssociationsResponse> BatchUpdateStandardsControlAssociationsAsync(BatchUpdateStandardsControlAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateStandardsControlAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateStandardsControlAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUpdateStandardsControlAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ConnectorRegistrationsV2

        internal virtual ConnectorRegistrationsV2Response ConnectorRegistrationsV2(ConnectorRegistrationsV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConnectorRegistrationsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectorRegistrationsV2ResponseUnmarshaller.Instance;

            return Invoke<ConnectorRegistrationsV2Response>(request, options);
        }



        /// <summary>
        /// Grants permission to complete the authorization based on input parameters. This API
        /// is in preview release and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConnectorRegistrationsV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConnectorRegistrationsV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ConnectorRegistrationsV2">REST API Reference for ConnectorRegistrationsV2 Operation</seealso>
        public virtual Task<ConnectorRegistrationsV2Response> ConnectorRegistrationsV2Async(ConnectorRegistrationsV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConnectorRegistrationsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectorRegistrationsV2ResponseUnmarshaller.Instance;

            return InvokeAsync<ConnectorRegistrationsV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateActionTarget

        internal virtual CreateActionTargetResponse CreateActionTarget(CreateActionTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateActionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateActionTargetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateActionTargetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAggregatorV2

        internal virtual CreateAggregatorV2Response CreateAggregatorV2(CreateAggregatorV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAggregatorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAggregatorV2ResponseUnmarshaller.Instance;

            return Invoke<CreateAggregatorV2Response>(request, options);
        }



        /// <summary>
        /// Enables aggregation across Amazon Web Services Regions. This API is in private preview
        /// and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAggregatorV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAggregatorV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateAggregatorV2">REST API Reference for CreateAggregatorV2 Operation</seealso>
        public virtual Task<CreateAggregatorV2Response> CreateAggregatorV2Async(CreateAggregatorV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAggregatorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAggregatorV2ResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAggregatorV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAutomationRule

        internal virtual CreateAutomationRuleResponse CreateAutomationRule(CreateAutomationRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomationRuleResponseUnmarshaller.Instance;

            return Invoke<CreateAutomationRuleResponse>(request, options);
        }



        /// <summary>
        /// Creates an automation rule based on input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAutomationRule service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateAutomationRule">REST API Reference for CreateAutomationRule Operation</seealso>
        public virtual Task<CreateAutomationRuleResponse> CreateAutomationRuleAsync(CreateAutomationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomationRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAutomationRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAutomationRuleV2

        internal virtual CreateAutomationRuleV2Response CreateAutomationRuleV2(CreateAutomationRuleV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomationRuleV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomationRuleV2ResponseUnmarshaller.Instance;

            return Invoke<CreateAutomationRuleV2Response>(request, options);
        }



        /// <summary>
        /// Creates a V2 automation rule. This API is in private preview and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomationRuleV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAutomationRuleV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateAutomationRuleV2">REST API Reference for CreateAutomationRuleV2 Operation</seealso>
        public virtual Task<CreateAutomationRuleV2Response> CreateAutomationRuleV2Async(CreateAutomationRuleV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomationRuleV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomationRuleV2ResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAutomationRuleV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConfigurationPolicy

        internal virtual CreateConfigurationPolicyResponse CreateConfigurationPolicy(CreateConfigurationPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates a configuration policy with the defined configuration. Only the Security
        /// Hub delegated administrator can invoke this operation from the home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfigurationPolicy service method, as returned by SecurityHub.</returns>
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
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateConfigurationPolicy">REST API Reference for CreateConfigurationPolicy Operation</seealso>
        public virtual Task<CreateConfigurationPolicyResponse> CreateConfigurationPolicyAsync(CreateConfigurationPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConnectorV2

        internal virtual CreateConnectorV2Response CreateConnectorV2(CreateConnectorV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorV2ResponseUnmarshaller.Instance;

            return Invoke<CreateConnectorV2Response>(request, options);
        }



        /// <summary>
        /// Grants permission to create a connectorV2 based on input parameters. This API is in
        /// preview release and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectorV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnectorV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateConnectorV2">REST API Reference for CreateConnectorV2 Operation</seealso>
        public virtual Task<CreateConnectorV2Response> CreateConnectorV2Async(CreateConnectorV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorV2ResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectorV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFindingAggregator

        internal virtual CreateFindingAggregatorResponse CreateFindingAggregator(CreateFindingAggregatorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFindingAggregatorResponseUnmarshaller.Instance;

            return Invoke<CreateFindingAggregatorResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// The <i>aggregation Region</i> is now called the <i>home Region</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Used to enable cross-Region aggregation. This operation can be invoked from the home
        /// Region only.
        /// </para>
        ///  
        /// <para>
        /// For information about how cross-Region aggregation works, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/finding-aggregation.html">Understanding
        /// cross-Region aggregation in Security Hub</a> in the <i>Security Hub User Guide</i>.
        /// 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFindingAggregatorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFindingAggregatorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateInsight

        internal virtual CreateInsightResponse CreateInsight(CreateInsightRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// To group the related findings in the insight, use the <c>GroupByAttribute</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInsightResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInsightResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMembers

        internal virtual CreateMembersResponse CreateMembers(CreateMembersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        ///  <c>CreateMembers</c> is always used to add accounts that are not organization members.
        /// </para>
        ///  
        /// <para>
        /// For accounts that are managed using Organizations, <c>CreateMembers</c> is only used
        /// in the following cases:
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
        /// Security Hub, you can use the <c>EnableSecurityHub</c> operation.
        /// </para>
        ///  
        /// <para>
        /// For accounts that are not organization members, you create the account association
        /// and then send an invitation to the member account. To send the invitation, you use
        /// the <c>InviteMembers</c> operation. If the account owner accepts the invitation, the
        /// account becomes a member account in Security Hub.
        /// </para>
        ///  
        /// <para>
        /// Accounts that are managed using Organizations don't receive an invitation. They automatically
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
        /// To remove the association between the administrator and member accounts, use the <c>DisassociateFromMasterAccount</c>
        /// or <c>DisassociateMembers</c> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMembers service method, as returned by SecurityHub.</returns>
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
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        public virtual Task<CreateMembersResponse> CreateMembersAsync(CreateMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembersResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMembersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTicketV2

        internal virtual CreateTicketV2Response CreateTicketV2(CreateTicketV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTicketV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTicketV2ResponseUnmarshaller.Instance;

            return Invoke<CreateTicketV2Response>(request, options);
        }



        /// <summary>
        /// Grants permission to create a ticket in the chosen ITSM based on finding information
        /// for the provided finding metadata UID. This API is in preview release and subject
        /// to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTicketV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTicketV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateTicketV2">REST API Reference for CreateTicketV2 Operation</seealso>
        public virtual Task<CreateTicketV2Response> CreateTicketV2Async(CreateTicketV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTicketV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTicketV2ResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTicketV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeclineInvitations

        internal virtual DeclineInvitationsResponse DeclineInvitations(DeclineInvitationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeclineInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;

            return Invoke<DeclineInvitationsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// We recommend using Organizations instead of Security Hub invitations to manage your
        /// member accounts. For information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-accounts-orgs.html">Managing
        /// Security Hub administrator and member accounts with Organizations</a> in the <i>Security
        /// Hub User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Declines invitations to become a Security Hub member account.
        /// </para>
        ///  
        /// <para>
        /// A prospective member account uses this operation to decline an invitation to become
        /// a member.
        /// </para>
        ///  
        /// <para>
        /// Only member accounts that aren't part of an Amazon Web Services organization should
        /// use this operation. Organization accounts don't receive invitations.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeclineInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeclineInvitationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteActionTarget

        internal virtual DeleteActionTargetResponse DeleteActionTarget(DeleteActionTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteActionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteActionTargetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteActionTargetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAggregatorV2

        internal virtual DeleteAggregatorV2Response DeleteAggregatorV2(DeleteAggregatorV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAggregatorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAggregatorV2ResponseUnmarshaller.Instance;

            return Invoke<DeleteAggregatorV2Response>(request, options);
        }



        /// <summary>
        /// Deletes the Aggregator V2. This API is in private preview and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAggregatorV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAggregatorV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteAggregatorV2">REST API Reference for DeleteAggregatorV2 Operation</seealso>
        public virtual Task<DeleteAggregatorV2Response> DeleteAggregatorV2Async(DeleteAggregatorV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAggregatorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAggregatorV2ResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAggregatorV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAutomationRuleV2

        internal virtual DeleteAutomationRuleV2Response DeleteAutomationRuleV2(DeleteAutomationRuleV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomationRuleV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomationRuleV2ResponseUnmarshaller.Instance;

            return Invoke<DeleteAutomationRuleV2Response>(request, options);
        }



        /// <summary>
        /// Deletes a V2 automation rule. This API is in private preview and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomationRuleV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAutomationRuleV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteAutomationRuleV2">REST API Reference for DeleteAutomationRuleV2 Operation</seealso>
        public virtual Task<DeleteAutomationRuleV2Response> DeleteAutomationRuleV2Async(DeleteAutomationRuleV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomationRuleV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomationRuleV2ResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAutomationRuleV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConfigurationPolicy

        internal virtual DeleteConfigurationPolicyResponse DeleteConfigurationPolicy(DeleteConfigurationPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes a configuration policy. Only the Security Hub delegated administrator can
        /// invoke this operation from the home Region. For the deletion to succeed, you must
        /// first disassociate a configuration policy from target accounts, organizational units,
        /// or the root by invoking the <c>StartConfigurationPolicyDisassociation</c> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationPolicy service method, as returned by SecurityHub.</returns>
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
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteConfigurationPolicy">REST API Reference for DeleteConfigurationPolicy Operation</seealso>
        public virtual Task<DeleteConfigurationPolicyResponse> DeleteConfigurationPolicyAsync(DeleteConfigurationPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConnectorV2

        internal virtual DeleteConnectorV2Response DeleteConnectorV2(DeleteConnectorV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorV2ResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectorV2Response>(request, options);
        }



        /// <summary>
        /// Grants permission to delete a connectorV2. This API is in preview release and subject
        /// to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectorV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnectorV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteConnectorV2">REST API Reference for DeleteConnectorV2 Operation</seealso>
        public virtual Task<DeleteConnectorV2Response> DeleteConnectorV2Async(DeleteConnectorV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorV2ResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConnectorV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFindingAggregator

        internal virtual DeleteFindingAggregatorResponse DeleteFindingAggregator(DeleteFindingAggregatorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFindingAggregatorResponseUnmarshaller.Instance;

            return Invoke<DeleteFindingAggregatorResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// The <i>aggregation Region</i> is now called the <i>home Region</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes a finding aggregator. When you delete the finding aggregator, you stop cross-Region
        /// aggregation. Finding replication stops occurring from the linked Regions to the home
        /// Region.
        /// </para>
        ///  
        /// <para>
        /// When you stop cross-Region aggregation, findings that were already replicated and
        /// sent to the home Region are still visible from the home Region. However, new findings
        /// and finding updates are no longer replicated and sent to the home Region. 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFindingAggregatorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFindingAggregatorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteInsight

        internal virtual DeleteInsightResponse DeleteInsight(DeleteInsightRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInsightResponseUnmarshaller.Instance;

            return Invoke<DeleteInsightResponse>(request, options);
        }



        /// <summary>
        /// Deletes the insight specified by the <c>InsightArn</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInsightResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInsightResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteInvitations

        internal virtual DeleteInvitationsResponse DeleteInvitations(DeleteInvitationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;

            return Invoke<DeleteInvitationsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// We recommend using Organizations instead of Security Hub invitations to manage your
        /// member accounts. For information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-accounts-orgs.html">Managing
        /// Security Hub administrator and member accounts with Organizations</a> in the <i>Security
        /// Hub User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes invitations to become a Security Hub member account.
        /// </para>
        ///  
        /// <para>
        /// A Security Hub administrator account can use this operation to delete invitations
        /// sent to one or more prospective member accounts.
        /// </para>
        ///  
        /// <para>
        /// This operation is only used to delete invitations that are sent to prospective member
        /// accounts that aren't part of an Amazon Web Services organization. Organization accounts
        /// don't receive invitations.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInvitationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMembers

        internal virtual DeleteMembersResponse DeleteMembers(DeleteMembersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembersResponseUnmarshaller.Instance;

            return Invoke<DeleteMembersResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified member accounts from Security Hub.
        /// 
        ///  
        /// <para>
        /// You can invoke this API only to delete accounts that became members through invitation.
        /// You can't invoke this API to delete accounts that belong to an Organizations organization.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembersResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMembersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeActionTargets

        internal virtual DescribeActionTargetsResponse DescribeActionTargets(DescribeActionTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeActionTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActionTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeActionTargetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeHub

        internal virtual DescribeHubResponse DescribeHub(DescribeHubRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHubResponseUnmarshaller.Instance;

            return Invoke<DescribeHubResponse>(request, options);
        }



        /// <summary>
        /// Returns details about the Hub resource in your account, including the <c>HubArn</c>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHubResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHubResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeOrganizationConfiguration

        internal virtual DescribeOrganizationConfigurationResponse DescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the way your organization is configured in Security Hub.
        /// Only the Security Hub administrator account can invoke this operation.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrganizationConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeProducts

        internal virtual DescribeProductsResponse DescribeProducts(DescribeProductsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// If you don't provide an integration ARN, then the results include all of the available
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProductsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeProductsV2

        internal virtual DescribeProductsV2Response DescribeProductsV2(DescribeProductsV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProductsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductsV2ResponseUnmarshaller.Instance;

            return Invoke<DescribeProductsV2Response>(request, options);
        }



        /// <summary>
        /// Gets information about the product integration. This API is in private preview and
        /// subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductsV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProductsV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeProductsV2">REST API Reference for DescribeProductsV2 Operation</seealso>
        public virtual Task<DescribeProductsV2Response> DescribeProductsV2Async(DescribeProductsV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProductsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductsV2ResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProductsV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSecurityHubV2

        internal virtual DescribeSecurityHubV2Response DescribeSecurityHubV2(DescribeSecurityHubV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSecurityHubV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityHubV2ResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityHubV2Response>(request, options);
        }



        /// <summary>
        /// Returns details about the service resource in your account. This API is in private
        /// preview and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityHubV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityHubV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeSecurityHubV2">REST API Reference for DescribeSecurityHubV2 Operation</seealso>
        public virtual Task<DescribeSecurityHubV2Response> DescribeSecurityHubV2Async(DescribeSecurityHubV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSecurityHubV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityHubV2ResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSecurityHubV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStandards

        internal virtual DescribeStandardsResponse DescribeStandards(DescribeStandardsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStandardsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStandardsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStandardsControls

        internal virtual DescribeStandardsControlsResponse DescribeStandardsControls(DescribeStandardsControlsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        ///  
        /// <para>
        /// This operation returns an empty list for standard subscriptions where <c>StandardsControlsUpdatable</c>
        /// has value <c>NOT_READY_FOR_UPDATES</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStandardsControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStandardsControlsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStandardsControlsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisableImportFindingsForProduct

        internal virtual DisableImportFindingsForProductResponse DisableImportFindingsForProduct(DisableImportFindingsForProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableImportFindingsForProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableImportFindingsForProductResponseUnmarshaller.Instance;

            return InvokeAsync<DisableImportFindingsForProductResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisableOrganizationAdminAccount

        internal virtual DisableOrganizationAdminAccountResponse DisableOrganizationAdminAccount(DisableOrganizationAdminAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        public virtual Task<DisableOrganizationAdminAccountResponse> DisableOrganizationAdminAccountAsync(DisableOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableOrganizationAdminAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DisableOrganizationAdminAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisableSecurityHub

        internal virtual DisableSecurityHubResponse DisableSecurityHub(DisableSecurityHubRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableSecurityHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSecurityHubResponseUnmarshaller.Instance;

            return Invoke<DisableSecurityHubResponse>(request, options);
        }



        /// <summary>
        /// Disables Security Hub in your account only in the current Amazon Web Services Region.
        /// To disable Security Hub in all Regions, you must submit one request per Region where
        /// you have enabled Security Hub.
        /// 
        ///  
        /// <para>
        /// You can't disable Security Hub in an account that is currently the Security Hub administrator.
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
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableSecurityHub">REST API Reference for DisableSecurityHub Operation</seealso>
        public virtual Task<DisableSecurityHubResponse> DisableSecurityHubAsync(DisableSecurityHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableSecurityHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSecurityHubResponseUnmarshaller.Instance;

            return InvokeAsync<DisableSecurityHubResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisableSecurityHubV2

        internal virtual DisableSecurityHubV2Response DisableSecurityHubV2(DisableSecurityHubV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableSecurityHubV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSecurityHubV2ResponseUnmarshaller.Instance;

            return Invoke<DisableSecurityHubV2Response>(request, options);
        }



        /// <summary>
        /// Disable the service for the current Amazon Web Services Region or specified Amazon
        /// Web Services Region. This API is in private preview and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSecurityHubV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableSecurityHubV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableSecurityHubV2">REST API Reference for DisableSecurityHubV2 Operation</seealso>
        public virtual Task<DisableSecurityHubV2Response> DisableSecurityHubV2Async(DisableSecurityHubV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableSecurityHubV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSecurityHubV2ResponseUnmarshaller.Instance;

            return InvokeAsync<DisableSecurityHubV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateFromAdministratorAccount

        internal virtual DisassociateFromAdministratorAccountResponse DisassociateFromAdministratorAccount(DisassociateFromAdministratorAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateFromAdministratorAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromAdministratorAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateFromAdministratorAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateFromMasterAccount

        [Obsolete("This API has been deprecated, use DisassociateFromAdministratorAccount API instead.")]
        internal virtual DisassociateFromMasterAccountResponse DisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateFromMasterAccountResponse>(request, options);
        }



        /// <summary>
        /// This method is deprecated. Instead, use <c>DisassociateFromAdministratorAccount</c>.
        /// 
        ///  
        /// <para>
        /// The Security Hub console continues to use <c>DisassociateFromMasterAccount</c>. It
        /// will eventually change to use <c>DisassociateFromAdministratorAccount</c>. Any IAM
        /// policies that specifically control access to this function must continue to use <c>DisassociateFromMasterAccount</c>.
        /// You should also add <c>DisassociateFromAdministratorAccount</c> to your policies to
        /// ensure that the correct permissions are in place after the console begins to use <c>DisassociateFromAdministratorAccount</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateFromMasterAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateMembers

        internal virtual DisassociateMembersResponse DisassociateMembers(DisassociateMembersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        public virtual Task<DisassociateMembersResponse> DisassociateMembersAsync(DisassociateMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMembersResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateMembersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EnableImportFindingsForProduct

        internal virtual EnableImportFindingsForProductResponse EnableImportFindingsForProduct(EnableImportFindingsForProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableImportFindingsForProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableImportFindingsForProductResponseUnmarshaller.Instance;

            return InvokeAsync<EnableImportFindingsForProductResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EnableOrganizationAdminAccount

        internal virtual EnableOrganizationAdminAccountResponse EnableOrganizationAdminAccount(EnableOrganizationAdminAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        public virtual Task<EnableOrganizationAdminAccountResponse> EnableOrganizationAdminAccountAsync(EnableOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableOrganizationAdminAccountResponseUnmarshaller.Instance;

            return InvokeAsync<EnableOrganizationAdminAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EnableSecurityHub

        internal virtual EnableSecurityHubResponse EnableSecurityHub(EnableSecurityHubRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// When you use the <c>EnableSecurityHub</c> operation to enable Security Hub, you also
        /// automatically enable the following standards:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Center for Internet Security (CIS) Amazon Web Services Foundations Benchmark v1.2.0
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Foundational Security Best Practices
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Other standards are not automatically enabled. 
        /// </para>
        ///  
        /// <para>
        /// To opt out of automatically enabled standards, set <c>EnableDefaultStandards</c> to
        /// <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// After you enable Security Hub, to enable a standard, use the <c>BatchEnableStandards</c>
        /// operation. To disable a standard, use the <c>BatchDisableStandards</c> operation.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableSecurityHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSecurityHubResponseUnmarshaller.Instance;

            return InvokeAsync<EnableSecurityHubResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EnableSecurityHubV2

        internal virtual EnableSecurityHubV2Response EnableSecurityHubV2(EnableSecurityHubV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableSecurityHubV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSecurityHubV2ResponseUnmarshaller.Instance;

            return Invoke<EnableSecurityHubV2Response>(request, options);
        }



        /// <summary>
        /// Enables the service in account for the current Amazon Web Services Region or specified
        /// Amazon Web Services Region. This API is in private preview and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSecurityHubV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableSecurityHubV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableSecurityHubV2">REST API Reference for EnableSecurityHubV2 Operation</seealso>
        public virtual Task<EnableSecurityHubV2Response> EnableSecurityHubV2Async(EnableSecurityHubV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableSecurityHubV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSecurityHubV2ResponseUnmarshaller.Instance;

            return InvokeAsync<EnableSecurityHubV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAdministratorAccount

        internal virtual GetAdministratorAccountResponse GetAdministratorAccount(GetAdministratorAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAdministratorAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdministratorAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetAdministratorAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAggregatorV2

        internal virtual GetAggregatorV2Response GetAggregatorV2(GetAggregatorV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAggregatorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregatorV2ResponseUnmarshaller.Instance;

            return Invoke<GetAggregatorV2Response>(request, options);
        }



        /// <summary>
        /// Returns the configuration of the specified Aggregator V2. This API is in private preview
        /// and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAggregatorV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAggregatorV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetAggregatorV2">REST API Reference for GetAggregatorV2 Operation</seealso>
        public virtual Task<GetAggregatorV2Response> GetAggregatorV2Async(GetAggregatorV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAggregatorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregatorV2ResponseUnmarshaller.Instance;

            return InvokeAsync<GetAggregatorV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAutomationRuleV2

        internal virtual GetAutomationRuleV2Response GetAutomationRuleV2(GetAutomationRuleV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomationRuleV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomationRuleV2ResponseUnmarshaller.Instance;

            return Invoke<GetAutomationRuleV2Response>(request, options);
        }



        /// <summary>
        /// Returns an automation rule for the V2 service. This API is in private preview and
        /// subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationRuleV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutomationRuleV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetAutomationRuleV2">REST API Reference for GetAutomationRuleV2 Operation</seealso>
        public virtual Task<GetAutomationRuleV2Response> GetAutomationRuleV2Async(GetAutomationRuleV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomationRuleV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomationRuleV2ResponseUnmarshaller.Instance;

            return InvokeAsync<GetAutomationRuleV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConfigurationPolicy

        internal virtual GetConfigurationPolicyResponse GetConfigurationPolicy(GetConfigurationPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationPolicyResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationPolicyResponse>(request, options);
        }



        /// <summary>
        /// Provides information about a configuration policy. Only the Security Hub delegated
        /// administrator can invoke this operation from the home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfigurationPolicy service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetConfigurationPolicy">REST API Reference for GetConfigurationPolicy Operation</seealso>
        public virtual Task<GetConfigurationPolicyResponse> GetConfigurationPolicyAsync(GetConfigurationPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigurationPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConfigurationPolicyAssociation

        internal virtual GetConfigurationPolicyAssociationResponse GetConfigurationPolicyAssociation(GetConfigurationPolicyAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationPolicyAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationPolicyAssociationResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationPolicyAssociationResponse>(request, options);
        }



        /// <summary>
        /// Returns the association between a configuration and a target account, organizational
        /// unit, or the root. The configuration can be a configuration policy or self-managed
        /// behavior. Only the Security Hub delegated administrator can invoke this operation
        /// from the home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationPolicyAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfigurationPolicyAssociation service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetConfigurationPolicyAssociation">REST API Reference for GetConfigurationPolicyAssociation Operation</seealso>
        public virtual Task<GetConfigurationPolicyAssociationResponse> GetConfigurationPolicyAssociationAsync(GetConfigurationPolicyAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationPolicyAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationPolicyAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigurationPolicyAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConnectorV2

        internal virtual GetConnectorV2Response GetConnectorV2(GetConnectorV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorV2ResponseUnmarshaller.Instance;

            return Invoke<GetConnectorV2Response>(request, options);
        }



        /// <summary>
        /// Grants permission to retrieve details for a connectorV2 based on connector id. This
        /// API is in preview release and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectorV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectorV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetConnectorV2">REST API Reference for GetConnectorV2 Operation</seealso>
        public virtual Task<GetConnectorV2Response> GetConnectorV2Async(GetConnectorV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorV2ResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectorV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEnabledStandards

        internal virtual GetEnabledStandardsResponse GetEnabledStandards(GetEnabledStandardsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnabledStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnabledStandardsResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnabledStandardsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFindingAggregator

        internal virtual GetFindingAggregatorResponse GetFindingAggregator(GetFindingAggregatorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingAggregatorResponseUnmarshaller.Instance;

            return Invoke<GetFindingAggregatorResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// The <i>aggregation Region</i> is now called the <i>home Region</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the current configuration in the calling account for cross-Region aggregation.
        /// A finding aggregator is a resource that establishes the home Region and any linked
        /// Regions.
        /// </para>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingAggregatorResponseUnmarshaller.Instance;

            return InvokeAsync<GetFindingAggregatorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFindingHistory

        internal virtual GetFindingHistoryResponse GetFindingHistory(GetFindingHistoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingHistoryResponseUnmarshaller.Instance;

            return Invoke<GetFindingHistoryResponse>(request, options);
        }



        /// <summary>
        /// Returns the history of a Security Hub finding. The history includes changes made
        /// to any fields in the Amazon Web Services Security Finding Format (ASFF) except top-level
        /// timestamp fields, such as the <c>CreatedAt</c> and <c>UpdatedAt</c> fields. 
        /// 
        ///  
        /// <para>
        /// This operation might return fewer results than the maximum number of results (<c>MaxResults</c>)
        /// specified in a request, even when more results are available. If this occurs, the
        /// response includes a <c>NextToken</c> value, which you should use to retrieve the next
        /// set of results in the response. The presence of a <c>NextToken</c> value in a response
        /// doesn't necessarily indicate that the results are incomplete. However, you should
        /// continue to specify a <c>NextToken</c> value until you receive a response that doesn't
        /// include this value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindingHistory service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindingHistory">REST API Reference for GetFindingHistory Operation</seealso>
        public virtual Task<GetFindingHistoryResponse> GetFindingHistoryAsync(GetFindingHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetFindingHistoryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFindings

        internal virtual GetFindingsResponse GetFindings(GetFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsResponseUnmarshaller.Instance;

            return Invoke<GetFindingsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of findings that match the specified criteria.
        /// 
        ///  
        /// <para>
        /// If cross-Region aggregation is enabled, then when you call <c>GetFindings</c> from
        /// the home Region, the results include all of the matching findings from both the home
        /// Region and linked Regions.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetFindingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFindingStatisticsV2

        internal virtual GetFindingStatisticsV2Response GetFindingStatisticsV2(GetFindingStatisticsV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingStatisticsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingStatisticsV2ResponseUnmarshaller.Instance;

            return Invoke<GetFindingStatisticsV2Response>(request, options);
        }



        /// <summary>
        /// Returns aggregated statistical data about findings. <c>GetFindingStatisticsV2</c>
        /// use <c>securityhub:GetAdhocInsightResults</c> in the <c>Action</c> element of an IAM
        /// policy statement. You must have permission to perform the <c>s</c> action. This API
        /// is in private preview and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingStatisticsV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindingStatisticsV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindingStatisticsV2">REST API Reference for GetFindingStatisticsV2 Operation</seealso>
        public virtual Task<GetFindingStatisticsV2Response> GetFindingStatisticsV2Async(GetFindingStatisticsV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingStatisticsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingStatisticsV2ResponseUnmarshaller.Instance;

            return InvokeAsync<GetFindingStatisticsV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFindingsV2

        internal virtual GetFindingsV2Response GetFindingsV2(GetFindingsV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsV2ResponseUnmarshaller.Instance;

            return Invoke<GetFindingsV2Response>(request, options);
        }



        /// <summary>
        /// Return a list of findings that match the specified criteria. <c>GetFindings</c> and
        /// <c>GetFindingsV2</c> both use <c>securityhub:GetFindings</c> in the <c>Action</c>
        /// element of an IAM policy statement. You must have permission to perform the <c>securityhub:GetFindings</c>
        /// action. This API is in private preview and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindingsV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindingsV2">REST API Reference for GetFindingsV2 Operation</seealso>
        public virtual Task<GetFindingsV2Response> GetFindingsV2Async(GetFindingsV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsV2ResponseUnmarshaller.Instance;

            return InvokeAsync<GetFindingsV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetInsightResults

        internal virtual GetInsightResultsResponse GetInsightResults(GetInsightResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInsightResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightResultsResponseUnmarshaller.Instance;

            return InvokeAsync<GetInsightResultsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetInsights

        internal virtual GetInsightsResponse GetInsights(GetInsightsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightsResponseUnmarshaller.Instance;

            return InvokeAsync<GetInsightsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetInvitationsCount

        internal virtual GetInvitationsCountResponse GetInvitationsCount(GetInvitationsCountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInvitationsCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;

            return Invoke<GetInvitationsCountResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// We recommend using Organizations instead of Security Hub invitations to manage your
        /// member accounts. For information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-accounts-orgs.html">Managing
        /// Security Hub administrator and member accounts with Organizations</a> in the <i>Security
        /// Hub User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the count of all Security Hub membership invitations that were sent to the
        /// calling member account, not including the currently accepted invitation. 
        /// </para>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInvitationsCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetInvitationsCountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMasterAccount

        [Obsolete("This API has been deprecated, use GetAdministratorAccount API instead.")]
        internal virtual GetMasterAccountResponse GetMasterAccount(GetMasterAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMasterAccountResponseUnmarshaller.Instance;

            return Invoke<GetMasterAccountResponse>(request, options);
        }



        /// <summary>
        /// This method is deprecated. Instead, use <c>GetAdministratorAccount</c>.
        /// 
        ///  
        /// <para>
        /// The Security Hub console continues to use <c>GetMasterAccount</c>. It will eventually
        /// change to use <c>GetAdministratorAccount</c>. Any IAM policies that specifically control
        /// access to this function must continue to use <c>GetMasterAccount</c>. You should also
        /// add <c>GetAdministratorAccount</c> to your policies to ensure that the correct permissions
        /// are in place after the console begins to use <c>GetAdministratorAccount</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMasterAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetMasterAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMembers

        internal virtual GetMembersResponse GetMembers(GetMembersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembersResponseUnmarshaller.Instance;

            return InvokeAsync<GetMembersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourcesStatisticsV2

        internal virtual GetResourcesStatisticsV2Response GetResourcesStatisticsV2(GetResourcesStatisticsV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcesStatisticsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcesStatisticsV2ResponseUnmarshaller.Instance;

            return Invoke<GetResourcesStatisticsV2Response>(request, options);
        }



        /// <summary>
        /// Retrieves statistical information about Amazon Web Services resources and their associated
        /// security findings. This API is in private preview and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcesStatisticsV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcesStatisticsV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetResourcesStatisticsV2">REST API Reference for GetResourcesStatisticsV2 Operation</seealso>
        public virtual Task<GetResourcesStatisticsV2Response> GetResourcesStatisticsV2Async(GetResourcesStatisticsV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcesStatisticsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcesStatisticsV2ResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcesStatisticsV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourcesV2

        internal virtual GetResourcesV2Response GetResourcesV2(GetResourcesV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcesV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcesV2ResponseUnmarshaller.Instance;

            return Invoke<GetResourcesV2Response>(request, options);
        }



        /// <summary>
        /// Returns a list of resources. This API is in private preview and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcesV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcesV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetResourcesV2">REST API Reference for GetResourcesV2 Operation</seealso>
        public virtual Task<GetResourcesV2Response> GetResourcesV2Async(GetResourcesV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcesV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcesV2ResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcesV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSecurityControlDefinition

        internal virtual GetSecurityControlDefinitionResponse GetSecurityControlDefinition(GetSecurityControlDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSecurityControlDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityControlDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetSecurityControlDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the definition of a security control. The definition includes the control
        /// title, description, Region availability, parameter definitions, and other details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityControlDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSecurityControlDefinition service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetSecurityControlDefinition">REST API Reference for GetSecurityControlDefinition Operation</seealso>
        public virtual Task<GetSecurityControlDefinitionResponse> GetSecurityControlDefinitionAsync(GetSecurityControlDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSecurityControlDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityControlDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSecurityControlDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  InviteMembers

        internal virtual InviteMembersResponse InviteMembers(InviteMembersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InviteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InviteMembersResponseUnmarshaller.Instance;

            return Invoke<InviteMembersResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// We recommend using Organizations instead of Security Hub invitations to manage your
        /// member accounts. For information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-accounts-orgs.html">Managing
        /// Security Hub administrator and member accounts with Organizations</a> in the <i>Security
        /// Hub User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Invites other Amazon Web Services accounts to become member accounts for the Security
        /// Hub administrator account that the invitation is sent from.
        /// </para>
        ///  
        /// <para>
        /// This operation is only used to invite accounts that don't belong to an Amazon Web
        /// Services organization. Organization accounts don't receive invitations.
        /// </para>
        ///  
        /// <para>
        /// Before you can use this action to invite a member, you must first use the <c>CreateMembers</c>
        /// action to create the member account in Security Hub.
        /// </para>
        ///  
        /// <para>
        /// When the account owner enables Security Hub and accepts the invitation to become a
        /// member account, the administrator account can view the findings generated in the member
        /// account.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InviteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InviteMembersResponseUnmarshaller.Instance;

            return InvokeAsync<InviteMembersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAggregatorsV2

        internal virtual ListAggregatorsV2Response ListAggregatorsV2(ListAggregatorsV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAggregatorsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAggregatorsV2ResponseUnmarshaller.Instance;

            return Invoke<ListAggregatorsV2Response>(request, options);
        }



        /// <summary>
        /// Retrieves a list of V2 aggregators. This API is in private preview and subject to
        /// change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAggregatorsV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAggregatorsV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListAggregatorsV2">REST API Reference for ListAggregatorsV2 Operation</seealso>
        public virtual Task<ListAggregatorsV2Response> ListAggregatorsV2Async(ListAggregatorsV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAggregatorsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAggregatorsV2ResponseUnmarshaller.Instance;

            return InvokeAsync<ListAggregatorsV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAutomationRules

        internal virtual ListAutomationRulesResponse ListAutomationRules(ListAutomationRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationRulesResponseUnmarshaller.Instance;

            return Invoke<ListAutomationRulesResponse>(request, options);
        }



        /// <summary>
        /// A list of automation rules and their metadata for the calling account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomationRules service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListAutomationRules">REST API Reference for ListAutomationRules Operation</seealso>
        public virtual Task<ListAutomationRulesResponse> ListAutomationRulesAsync(ListAutomationRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAutomationRulesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAutomationRulesV2

        internal virtual ListAutomationRulesV2Response ListAutomationRulesV2(ListAutomationRulesV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationRulesV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationRulesV2ResponseUnmarshaller.Instance;

            return Invoke<ListAutomationRulesV2Response>(request, options);
        }



        /// <summary>
        /// Returns a list of automation rules and metadata for the calling account. This API
        /// is in private preview and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRulesV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomationRulesV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListAutomationRulesV2">REST API Reference for ListAutomationRulesV2 Operation</seealso>
        public virtual Task<ListAutomationRulesV2Response> ListAutomationRulesV2Async(ListAutomationRulesV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationRulesV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationRulesV2ResponseUnmarshaller.Instance;

            return InvokeAsync<ListAutomationRulesV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConfigurationPolicies

        internal virtual ListConfigurationPoliciesResponse ListConfigurationPolicies(ListConfigurationPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Lists the configuration policies that the Security Hub delegated administrator has
        /// created for your organization. Only the delegated administrator can invoke this operation
        /// from the home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurationPolicies service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListConfigurationPolicies">REST API Reference for ListConfigurationPolicies Operation</seealso>
        public virtual Task<ListConfigurationPoliciesResponse> ListConfigurationPoliciesAsync(ListConfigurationPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConfigurationPolicyAssociations

        internal virtual ListConfigurationPolicyAssociationsResponse ListConfigurationPolicyAssociations(ListConfigurationPolicyAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationPolicyAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationPolicyAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationPolicyAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Provides information about the associations for your configuration policies and self-managed
        /// behavior. Only the Security Hub delegated administrator can invoke this operation
        /// from the home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationPolicyAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurationPolicyAssociations service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListConfigurationPolicyAssociations">REST API Reference for ListConfigurationPolicyAssociations Operation</seealso>
        public virtual Task<ListConfigurationPolicyAssociationsResponse> ListConfigurationPolicyAssociationsAsync(ListConfigurationPolicyAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationPolicyAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationPolicyAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationPolicyAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConnectorsV2

        internal virtual ListConnectorsV2Response ListConnectorsV2(ListConnectorsV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorsV2ResponseUnmarshaller.Instance;

            return Invoke<ListConnectorsV2Response>(request, options);
        }



        /// <summary>
        /// Grants permission to retrieve a list of connectorsV2 and their metadata for the calling
        /// account. This API is in preview release and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectorsV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnectorsV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListConnectorsV2">REST API Reference for ListConnectorsV2 Operation</seealso>
        public virtual Task<ListConnectorsV2Response> ListConnectorsV2Async(ListConnectorsV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorsV2ResponseUnmarshaller.Instance;

            return InvokeAsync<ListConnectorsV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEnabledProductsForImport

        internal virtual ListEnabledProductsForImportResponse ListEnabledProductsForImport(ListEnabledProductsForImportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnabledProductsForImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnabledProductsForImportResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnabledProductsForImportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFindingAggregators

        internal virtual ListFindingAggregatorsResponse ListFindingAggregators(ListFindingAggregatorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFindingAggregatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingAggregatorsResponseUnmarshaller.Instance;

            return Invoke<ListFindingAggregatorsResponse>(request, options);
        }



        /// <summary>
        /// If cross-Region aggregation is enabled, then <c>ListFindingAggregators</c> returns
        /// the Amazon Resource Name (ARN) of the finding aggregator. You can run this operation
        /// from any Amazon Web Services Region.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFindingAggregatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingAggregatorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFindingAggregatorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListInvitations

        internal virtual ListInvitationsResponse ListInvitations(ListInvitationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return Invoke<ListInvitationsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// We recommend using Organizations instead of Security Hub invitations to manage your
        /// member accounts. For information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-accounts-orgs.html">Managing
        /// Security Hub administrator and member accounts with Organizations</a> in the <i>Security
        /// Hub User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Lists all Security Hub membership invitations that were sent to the calling account.
        /// </para>
        ///  
        /// <para>
        /// Only accounts that are managed by invitation can use this operation. Accounts that
        /// are managed using the integration with Organizations don't receive invitations.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInvitationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMembers

        internal virtual ListMembersResponse ListMembers(ListMembersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return InvokeAsync<ListMembersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListOrganizationAdminAccounts

        internal virtual ListOrganizationAdminAccountsResponse ListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationAdminAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationAdminAccountsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOrganizationAdminAccountsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSecurityControlDefinitions

        internal virtual ListSecurityControlDefinitionsResponse ListSecurityControlDefinitions(ListSecurityControlDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSecurityControlDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityControlDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListSecurityControlDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the security controls that apply to a specified standard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityControlDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityControlDefinitions service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListSecurityControlDefinitions">REST API Reference for ListSecurityControlDefinitions Operation</seealso>
        public virtual Task<ListSecurityControlDefinitionsResponse> ListSecurityControlDefinitionsAsync(ListSecurityControlDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSecurityControlDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityControlDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSecurityControlDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStandardsControlAssociations

        internal virtual ListStandardsControlAssociationsResponse ListStandardsControlAssociations(ListStandardsControlAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStandardsControlAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStandardsControlAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListStandardsControlAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Specifies whether a control is currently enabled or disabled in each enabled standard
        /// in the calling account. 
        /// 
        ///  
        /// <para>
        /// This operation omits standards control associations for standard subscriptions where
        /// <c>StandardsControlsUpdatable</c> has value <c>NOT_READY_FOR_UPDATES</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStandardsControlAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStandardsControlAssociations service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListStandardsControlAssociations">REST API Reference for ListStandardsControlAssociations Operation</seealso>
        public virtual Task<ListStandardsControlAssociationsResponse> ListStandardsControlAssociationsAsync(ListStandardsControlAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStandardsControlAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStandardsControlAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStandardsControlAssociationsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartConfigurationPolicyAssociation

        internal virtual StartConfigurationPolicyAssociationResponse StartConfigurationPolicyAssociation(StartConfigurationPolicyAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartConfigurationPolicyAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationPolicyAssociationResponseUnmarshaller.Instance;

            return Invoke<StartConfigurationPolicyAssociationResponse>(request, options);
        }



        /// <summary>
        /// Associates a target account, organizational unit, or the root with a specified configuration.
        /// The target can be associated with a configuration policy or self-managed behavior.
        /// Only the Security Hub delegated administrator can invoke this operation from the home
        /// Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationPolicyAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartConfigurationPolicyAssociation service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/StartConfigurationPolicyAssociation">REST API Reference for StartConfigurationPolicyAssociation Operation</seealso>
        public virtual Task<StartConfigurationPolicyAssociationResponse> StartConfigurationPolicyAssociationAsync(StartConfigurationPolicyAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartConfigurationPolicyAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationPolicyAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<StartConfigurationPolicyAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartConfigurationPolicyDisassociation

        internal virtual StartConfigurationPolicyDisassociationResponse StartConfigurationPolicyDisassociation(StartConfigurationPolicyDisassociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartConfigurationPolicyDisassociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationPolicyDisassociationResponseUnmarshaller.Instance;

            return Invoke<StartConfigurationPolicyDisassociationResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a target account, organizational unit, or the root from a specified
        /// configuration. When you disassociate a configuration from its target, the target inherits
        /// the configuration of the closest parent. If there’s no configuration to inherit, the
        /// target retains its settings but becomes a self-managed account. A target can be disassociated
        /// from a configuration policy or self-managed behavior. Only the Security Hub delegated
        /// administrator can invoke this operation from the home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationPolicyDisassociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartConfigurationPolicyDisassociation service method, as returned by SecurityHub.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/StartConfigurationPolicyDisassociation">REST API Reference for StartConfigurationPolicyDisassociation Operation</seealso>
        public virtual Task<StartConfigurationPolicyDisassociationResponse> StartConfigurationPolicyDisassociationAsync(StartConfigurationPolicyDisassociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartConfigurationPolicyDisassociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationPolicyDisassociationResponseUnmarshaller.Instance;

            return InvokeAsync<StartConfigurationPolicyDisassociationResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateActionTarget

        internal virtual UpdateActionTargetResponse UpdateActionTarget(UpdateActionTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateActionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateActionTargetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateActionTargetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAggregatorV2

        internal virtual UpdateAggregatorV2Response UpdateAggregatorV2(UpdateAggregatorV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAggregatorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAggregatorV2ResponseUnmarshaller.Instance;

            return Invoke<UpdateAggregatorV2Response>(request, options);
        }



        /// <summary>
        /// Udpates the configuration for the Aggregator V2. This API is in private preview and
        /// subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAggregatorV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAggregatorV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateAggregatorV2">REST API Reference for UpdateAggregatorV2 Operation</seealso>
        public virtual Task<UpdateAggregatorV2Response> UpdateAggregatorV2Async(UpdateAggregatorV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAggregatorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAggregatorV2ResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAggregatorV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAutomationRuleV2

        internal virtual UpdateAutomationRuleV2Response UpdateAutomationRuleV2(UpdateAutomationRuleV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomationRuleV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomationRuleV2ResponseUnmarshaller.Instance;

            return Invoke<UpdateAutomationRuleV2Response>(request, options);
        }



        /// <summary>
        /// Updates a V2 automation rule. This API is in private preview and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomationRuleV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAutomationRuleV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateAutomationRuleV2">REST API Reference for UpdateAutomationRuleV2 Operation</seealso>
        public virtual Task<UpdateAutomationRuleV2Response> UpdateAutomationRuleV2Async(UpdateAutomationRuleV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomationRuleV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomationRuleV2ResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAutomationRuleV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConfigurationPolicy

        internal virtual UpdateConfigurationPolicyResponse UpdateConfigurationPolicy(UpdateConfigurationPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationPolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates a configuration policy. Only the Security Hub delegated administrator can
        /// invoke this operation from the home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfigurationPolicy service method, as returned by SecurityHub.</returns>
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
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateConfigurationPolicy">REST API Reference for UpdateConfigurationPolicy Operation</seealso>
        public virtual Task<UpdateConfigurationPolicyResponse> UpdateConfigurationPolicyAsync(UpdateConfigurationPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConnectorV2

        internal virtual UpdateConnectorV2Response UpdateConnectorV2(UpdateConnectorV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorV2ResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectorV2Response>(request, options);
        }



        /// <summary>
        /// Grants permission to update a connectorV2 based on its id and input parameters. This
        /// API is in preview release and subject to change.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectorV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnectorV2 service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ConflictException">
        /// The request causes conflict with the current state of the service resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalServerException">
        /// The request has failed due to an internal failure of the service.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ValidationException">
        /// The request has failed validation because it's missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateConnectorV2">REST API Reference for UpdateConnectorV2 Operation</seealso>
        public virtual Task<UpdateConnectorV2Response> UpdateConnectorV2Async(UpdateConnectorV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectorV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorV2ResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConnectorV2Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFindingAggregator

        internal virtual UpdateFindingAggregatorResponse UpdateFindingAggregator(UpdateFindingAggregatorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingAggregatorResponseUnmarshaller.Instance;

            return Invoke<UpdateFindingAggregatorResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// The <i>aggregation Region</i> is now called the <i>home Region</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates cross-Region aggregation settings. You can use this operation to update the
        /// Region linking mode and the list of included or excluded Amazon Web Services Regions.
        /// However, you can't use this operation to change the home Region.
        /// </para>
        ///  
        /// <para>
        /// You can invoke this operation from the current home Region only. 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingAggregatorResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFindingAggregatorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFindings

        internal virtual UpdateFindingsResponse UpdateFindings(UpdateFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingsResponseUnmarshaller.Instance;

            return Invoke<UpdateFindingsResponse>(request, options);
        }



        /// <summary>
        /// <c>UpdateFindings</c> is a deprecated operation. Instead of <c>UpdateFindings</c>,
        /// use the <c>BatchUpdateFindings</c> operation.
        /// 
        ///  
        /// <para>
        /// The <c>UpdateFindings</c> operation updates the <c>Note</c> and <c>RecordState</c>
        /// of the Security Hub aggregated findings that the filter attributes specify. Any member
        /// account that can view the finding can also see the update to the finding.
        /// </para>
        ///  
        /// <para>
        /// Finding updates made with <c>UpdateFindings</c> aren't persisted if the same finding
        /// is later updated by the finding provider through the <c>BatchImportFindings</c> operation.
        /// In addition, Security Hub doesn't record updates made with <c>UpdateFindings</c> in
        /// the finding history.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFindingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateInsight

        internal virtual UpdateInsightResponse UpdateInsight(UpdateInsightRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInsightResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateInsightResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateOrganizationConfiguration

        internal virtual UpdateOrganizationConfigurationResponse UpdateOrganizationConfiguration(UpdateOrganizationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateOrganizationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of your organization in Security Hub. Only the Security
        /// Hub administrator account can invoke this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOrganizationConfiguration service method, as returned by SecurityHub.</returns>
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
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        public virtual Task<UpdateOrganizationConfigurationResponse> UpdateOrganizationConfigurationAsync(UpdateOrganizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOrganizationConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSecurityControl

        internal virtual UpdateSecurityControlResponse UpdateSecurityControl(UpdateSecurityControlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSecurityControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityControlResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityControlResponse>(request, options);
        }



        /// <summary>
        /// Updates the properties of a security control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSecurityControl service method, as returned by SecurityHub.</returns>
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
        /// <exception cref="Amazon.SecurityHub.Model.ResourceInUseException">
        /// The request was rejected because it conflicts with the resource's availability. For
        /// example, you tried to update a security control that's currently in the <c>UPDATING</c>
        /// state.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateSecurityControl">REST API Reference for UpdateSecurityControl Operation</seealso>
        public virtual Task<UpdateSecurityControlResponse> UpdateSecurityControlAsync(UpdateSecurityControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSecurityControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityControlResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSecurityControlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSecurityHubConfiguration

        internal virtual UpdateSecurityHubConfigurationResponse UpdateSecurityHubConfiguration(UpdateSecurityHubConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateSecurityHubConfiguration">REST API Reference for UpdateSecurityHubConfiguration Operation</seealso>
        public virtual Task<UpdateSecurityHubConfigurationResponse> UpdateSecurityHubConfigurationAsync(UpdateSecurityHubConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSecurityHubConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityHubConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSecurityHubConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateStandardsControl

        internal virtual UpdateStandardsControlResponse UpdateStandardsControl(UpdateStandardsControlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStandardsControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStandardsControlResponseUnmarshaller.Instance;

            return Invoke<UpdateStandardsControlResponse>(request, options);
        }



        /// <summary>
        /// Used to control whether an individual security standard control is enabled or disabled.
        /// 
        ///  
        /// <para>
        /// Calls to this operation return a <c>RESOURCE_NOT_FOUND_EXCEPTION</c> error when the
        /// standard subscription for the control has <c>StandardsControlsUpdatable</c> value
        /// <c>NOT_READY_FOR_UPDATES</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStandardsControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStandardsControl service method, as returned by SecurityHub.</returns>
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
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateStandardsControl">REST API Reference for UpdateStandardsControl Operation</seealso>
        public virtual Task<UpdateStandardsControlResponse> UpdateStandardsControlAsync(UpdateStandardsControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStandardsControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStandardsControlResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStandardsControlResponse>(request, options, cancellationToken);
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