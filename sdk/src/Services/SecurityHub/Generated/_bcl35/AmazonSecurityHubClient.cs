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
using System.Collections.Generic;
using System.Net;

using Amazon.SecurityHub.Model;
using Amazon.SecurityHub.Model.Internal.MarshallTransformations;
using Amazon.SecurityHub.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
        /// Initiates the asynchronous execution of the AcceptAdministratorInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptAdministratorInvitation operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptAdministratorInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/AcceptAdministratorInvitation">REST API Reference for AcceptAdministratorInvitation Operation</seealso>
        public virtual IAsyncResult BeginAcceptAdministratorInvitation(AcceptAdministratorInvitationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptAdministratorInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptAdministratorInvitationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptAdministratorInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptAdministratorInvitation.</param>
        /// 
        /// <returns>Returns a  AcceptAdministratorInvitationResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/AcceptAdministratorInvitation">REST API Reference for AcceptAdministratorInvitation Operation</seealso>
        public virtual AcceptAdministratorInvitationResponse EndAcceptAdministratorInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptAdministratorInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  AcceptInvitation

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
        /// Initiates the asynchronous execution of the AcceptInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        [Obsolete("This API has been deprecated, use AcceptAdministratorInvitation API instead.")]
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
        /// <returns>Returns a  AcceptInvitationResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        [Obsolete("This API has been deprecated, use AcceptAdministratorInvitation API instead.")]
        public virtual AcceptInvitationResponse EndAcceptInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteAutomationRules

        /// <summary>
        /// Deletes one or more automation rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteAutomationRules service method.</param>
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
        public virtual BatchDeleteAutomationRulesResponse BatchDeleteAutomationRules(BatchDeleteAutomationRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteAutomationRulesResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteAutomationRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteAutomationRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteAutomationRules operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteAutomationRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchDeleteAutomationRules">REST API Reference for BatchDeleteAutomationRules Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteAutomationRules(BatchDeleteAutomationRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteAutomationRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteAutomationRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteAutomationRules.</param>
        /// 
        /// <returns>Returns a  BatchDeleteAutomationRulesResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchDeleteAutomationRules">REST API Reference for BatchDeleteAutomationRules Operation</seealso>
        public virtual BatchDeleteAutomationRulesResponse EndBatchDeleteAutomationRules(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteAutomationRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDisableStandards

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
        public virtual BatchDisableStandardsResponse BatchDisableStandards(BatchDisableStandardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisableStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisableStandardsResponseUnmarshaller.Instance;

            return Invoke<BatchDisableStandardsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisableStandards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisableStandards operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisableStandards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchDisableStandards">REST API Reference for BatchDisableStandards Operation</seealso>
        public virtual IAsyncResult BeginBatchDisableStandards(BatchDisableStandardsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisableStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisableStandardsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisableStandards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisableStandards.</param>
        /// 
        /// <returns>Returns a  BatchDisableStandardsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchDisableStandards">REST API Reference for BatchDisableStandards Operation</seealso>
        public virtual BatchDisableStandardsResponse EndBatchDisableStandards(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDisableStandardsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchEnableStandards

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
        public virtual BatchEnableStandardsResponse BatchEnableStandards(BatchEnableStandardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchEnableStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchEnableStandardsResponseUnmarshaller.Instance;

            return Invoke<BatchEnableStandardsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchEnableStandards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchEnableStandards operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchEnableStandards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchEnableStandards">REST API Reference for BatchEnableStandards Operation</seealso>
        public virtual IAsyncResult BeginBatchEnableStandards(BatchEnableStandardsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchEnableStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchEnableStandardsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchEnableStandards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchEnableStandards.</param>
        /// 
        /// <returns>Returns a  BatchEnableStandardsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchEnableStandards">REST API Reference for BatchEnableStandards Operation</seealso>
        public virtual BatchEnableStandardsResponse EndBatchEnableStandards(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchEnableStandardsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetAutomationRules

        /// <summary>
        /// Retrieves a list of details for automation rules based on rule Amazon Resource Names
        /// (ARNs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAutomationRules service method.</param>
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
        public virtual BatchGetAutomationRulesResponse BatchGetAutomationRules(BatchGetAutomationRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAutomationRulesResponseUnmarshaller.Instance;

            return Invoke<BatchGetAutomationRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetAutomationRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAutomationRules operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetAutomationRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchGetAutomationRules">REST API Reference for BatchGetAutomationRules Operation</seealso>
        public virtual IAsyncResult BeginBatchGetAutomationRules(BatchGetAutomationRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAutomationRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetAutomationRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetAutomationRules.</param>
        /// 
        /// <returns>Returns a  BatchGetAutomationRulesResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchGetAutomationRules">REST API Reference for BatchGetAutomationRules Operation</seealso>
        public virtual BatchGetAutomationRulesResponse EndBatchGetAutomationRules(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetAutomationRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetConfigurationPolicyAssociations

        /// <summary>
        /// Returns associations between an Security Hub configuration and a batch of target
        /// accounts, organizational units, or the root. Only the Security Hub delegated administrator
        /// can invoke this operation from the home Region. A configuration can refer to a configuration
        /// policy or to a self-managed configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetConfigurationPolicyAssociations service method.</param>
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
        public virtual BatchGetConfigurationPolicyAssociationsResponse BatchGetConfigurationPolicyAssociations(BatchGetConfigurationPolicyAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetConfigurationPolicyAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetConfigurationPolicyAssociationsResponseUnmarshaller.Instance;

            return Invoke<BatchGetConfigurationPolicyAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetConfigurationPolicyAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetConfigurationPolicyAssociations operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetConfigurationPolicyAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchGetConfigurationPolicyAssociations">REST API Reference for BatchGetConfigurationPolicyAssociations Operation</seealso>
        public virtual IAsyncResult BeginBatchGetConfigurationPolicyAssociations(BatchGetConfigurationPolicyAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetConfigurationPolicyAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetConfigurationPolicyAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetConfigurationPolicyAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetConfigurationPolicyAssociations.</param>
        /// 
        /// <returns>Returns a  BatchGetConfigurationPolicyAssociationsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchGetConfigurationPolicyAssociations">REST API Reference for BatchGetConfigurationPolicyAssociations Operation</seealso>
        public virtual BatchGetConfigurationPolicyAssociationsResponse EndBatchGetConfigurationPolicyAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetConfigurationPolicyAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetSecurityControls

        /// <summary>
        /// Provides details about a batch of security controls for the current Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSecurityControls service method.</param>
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
        public virtual BatchGetSecurityControlsResponse BatchGetSecurityControls(BatchGetSecurityControlsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetSecurityControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSecurityControlsResponseUnmarshaller.Instance;

            return Invoke<BatchGetSecurityControlsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetSecurityControls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSecurityControls operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetSecurityControls
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchGetSecurityControls">REST API Reference for BatchGetSecurityControls Operation</seealso>
        public virtual IAsyncResult BeginBatchGetSecurityControls(BatchGetSecurityControlsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetSecurityControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSecurityControlsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetSecurityControls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetSecurityControls.</param>
        /// 
        /// <returns>Returns a  BatchGetSecurityControlsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchGetSecurityControls">REST API Reference for BatchGetSecurityControls Operation</seealso>
        public virtual BatchGetSecurityControlsResponse EndBatchGetSecurityControls(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetSecurityControlsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetStandardsControlAssociations

        /// <summary>
        /// For a batch of security controls and standards, identifies whether each control is
        /// currently enabled or disabled in a standard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetStandardsControlAssociations service method.</param>
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
        public virtual BatchGetStandardsControlAssociationsResponse BatchGetStandardsControlAssociations(BatchGetStandardsControlAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetStandardsControlAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetStandardsControlAssociationsResponseUnmarshaller.Instance;

            return Invoke<BatchGetStandardsControlAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetStandardsControlAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetStandardsControlAssociations operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetStandardsControlAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchGetStandardsControlAssociations">REST API Reference for BatchGetStandardsControlAssociations Operation</seealso>
        public virtual IAsyncResult BeginBatchGetStandardsControlAssociations(BatchGetStandardsControlAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetStandardsControlAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetStandardsControlAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetStandardsControlAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetStandardsControlAssociations.</param>
        /// 
        /// <returns>Returns a  BatchGetStandardsControlAssociationsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchGetStandardsControlAssociations">REST API Reference for BatchGetStandardsControlAssociations Operation</seealso>
        public virtual BatchGetStandardsControlAssociationsResponse EndBatchGetStandardsControlAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetStandardsControlAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchImportFindings

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
        /// Initiates the asynchronous execution of the BatchImportFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchImportFindings operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchImportFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchImportFindings">REST API Reference for BatchImportFindings Operation</seealso>
        public virtual IAsyncResult BeginBatchImportFindings(BatchImportFindingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchImportFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchImportFindingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchImportFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchImportFindings.</param>
        /// 
        /// <returns>Returns a  BatchImportFindingsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchImportFindings">REST API Reference for BatchImportFindings Operation</seealso>
        public virtual BatchImportFindingsResponse EndBatchImportFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchImportFindingsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdateAutomationRules

        /// <summary>
        /// Updates one or more automation rules based on rule Amazon Resource Names (ARNs) and
        /// input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateAutomationRules service method.</param>
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
        public virtual BatchUpdateAutomationRulesResponse BatchUpdateAutomationRules(BatchUpdateAutomationRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateAutomationRulesResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateAutomationRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateAutomationRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateAutomationRules operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateAutomationRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchUpdateAutomationRules">REST API Reference for BatchUpdateAutomationRules Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateAutomationRules(BatchUpdateAutomationRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateAutomationRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateAutomationRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateAutomationRules.</param>
        /// 
        /// <returns>Returns a  BatchUpdateAutomationRulesResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchUpdateAutomationRules">REST API Reference for BatchUpdateAutomationRules Operation</seealso>
        public virtual BatchUpdateAutomationRulesResponse EndBatchUpdateAutomationRules(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateAutomationRulesResponse>(asyncResult);
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
        /// Updates from <c>BatchUpdateFindings</c> don't affect the value of <c>UpdatedAt</c>
        /// for a finding.
        /// </para>
        ///  
        /// <para>
        /// Administrator and member accounts can use <c>BatchUpdateFindings</c> to update the
        /// following finding fields and objects.
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
        /// Initiates the asynchronous execution of the BatchUpdateFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateFindings operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchUpdateFindings">REST API Reference for BatchUpdateFindings Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateFindings(BatchUpdateFindingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateFindingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateFindings.</param>
        /// 
        /// <returns>Returns a  BatchUpdateFindingsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchUpdateFindings">REST API Reference for BatchUpdateFindings Operation</seealso>
        public virtual BatchUpdateFindingsResponse EndBatchUpdateFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateFindingsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdateStandardsControlAssociations

        /// <summary>
        /// For a batch of security controls and standards, this operation updates the enablement
        /// status of a control in a standard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateStandardsControlAssociations service method.</param>
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
        public virtual BatchUpdateStandardsControlAssociationsResponse BatchUpdateStandardsControlAssociations(BatchUpdateStandardsControlAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateStandardsControlAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateStandardsControlAssociationsResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateStandardsControlAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateStandardsControlAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateStandardsControlAssociations operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateStandardsControlAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchUpdateStandardsControlAssociations">REST API Reference for BatchUpdateStandardsControlAssociations Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateStandardsControlAssociations(BatchUpdateStandardsControlAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateStandardsControlAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateStandardsControlAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateStandardsControlAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateStandardsControlAssociations.</param>
        /// 
        /// <returns>Returns a  BatchUpdateStandardsControlAssociationsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchUpdateStandardsControlAssociations">REST API Reference for BatchUpdateStandardsControlAssociations Operation</seealso>
        public virtual BatchUpdateStandardsControlAssociationsResponse EndBatchUpdateStandardsControlAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateStandardsControlAssociationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateActionTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateActionTarget operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateActionTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateActionTarget">REST API Reference for CreateActionTarget Operation</seealso>
        public virtual IAsyncResult BeginCreateActionTarget(CreateActionTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateActionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateActionTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateActionTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateActionTarget.</param>
        /// 
        /// <returns>Returns a  CreateActionTargetResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateActionTarget">REST API Reference for CreateActionTarget Operation</seealso>
        public virtual CreateActionTargetResponse EndCreateActionTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateActionTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAutomationRule

        /// <summary>
        /// Creates an automation rule based on input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomationRule service method.</param>
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
        public virtual CreateAutomationRuleResponse CreateAutomationRule(CreateAutomationRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAutomationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomationRuleResponseUnmarshaller.Instance;

            return Invoke<CreateAutomationRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutomationRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomationRule operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAutomationRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateAutomationRule">REST API Reference for CreateAutomationRule Operation</seealso>
        public virtual IAsyncResult BeginCreateAutomationRule(CreateAutomationRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAutomationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomationRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAutomationRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAutomationRule.</param>
        /// 
        /// <returns>Returns a  CreateAutomationRuleResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateAutomationRule">REST API Reference for CreateAutomationRule Operation</seealso>
        public virtual CreateAutomationRuleResponse EndCreateAutomationRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAutomationRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConfigurationPolicy

        /// <summary>
        /// Creates a configuration policy with the defined configuration. Only the Security
        /// Hub delegated administrator can invoke this operation from the home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationPolicy service method.</param>
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
        public virtual CreateConfigurationPolicyResponse CreateConfigurationPolicy(CreateConfigurationPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationPolicy operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateConfigurationPolicy">REST API Reference for CreateConfigurationPolicy Operation</seealso>
        public virtual IAsyncResult BeginCreateConfigurationPolicy(CreateConfigurationPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationPolicy.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationPolicyResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateConfigurationPolicy">REST API Reference for CreateConfigurationPolicy Operation</seealso>
        public virtual CreateConfigurationPolicyResponse EndCreateConfigurationPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfigurationPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFindingAggregator

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
        /// Initiates the asynchronous execution of the CreateFindingAggregator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingAggregator operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFindingAggregator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateFindingAggregator">REST API Reference for CreateFindingAggregator Operation</seealso>
        public virtual IAsyncResult BeginCreateFindingAggregator(CreateFindingAggregatorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFindingAggregatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFindingAggregator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFindingAggregator.</param>
        /// 
        /// <returns>Returns a  CreateFindingAggregatorResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateFindingAggregator">REST API Reference for CreateFindingAggregator Operation</seealso>
        public virtual CreateFindingAggregatorResponse EndCreateFindingAggregator(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFindingAggregatorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInsight

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
        /// Initiates the asynchronous execution of the CreateInsight operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInsight operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInsight
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateInsight">REST API Reference for CreateInsight Operation</seealso>
        public virtual IAsyncResult BeginCreateInsight(CreateInsightRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInsightResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInsight operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInsight.</param>
        /// 
        /// <returns>Returns a  CreateInsightResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateInsight">REST API Reference for CreateInsight Operation</seealso>
        public virtual CreateInsightResponse EndCreateInsight(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInsightResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
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
        /// <returns>Returns a  CreateMembersResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        public virtual CreateMembersResponse EndCreateMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  DeclineInvitations

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
        /// Initiates the asynchronous execution of the DeclineInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeclineInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        public virtual IAsyncResult BeginDeclineInvitations(DeclineInvitationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeclineInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeclineInvitationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeclineInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeclineInvitations.</param>
        /// 
        /// <returns>Returns a  DeclineInvitationsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        public virtual DeclineInvitationsResponse EndDeclineInvitations(IAsyncResult asyncResult)
        {
            return EndInvoke<DeclineInvitationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteActionTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteActionTarget operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteActionTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteActionTarget">REST API Reference for DeleteActionTarget Operation</seealso>
        public virtual IAsyncResult BeginDeleteActionTarget(DeleteActionTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteActionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteActionTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteActionTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteActionTarget.</param>
        /// 
        /// <returns>Returns a  DeleteActionTargetResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteActionTarget">REST API Reference for DeleteActionTarget Operation</seealso>
        public virtual DeleteActionTargetResponse EndDeleteActionTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteActionTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfigurationPolicy

        /// <summary>
        /// Deletes a configuration policy. Only the Security Hub delegated administrator can
        /// invoke this operation from the home Region. For the deletion to succeed, you must
        /// first disassociate a configuration policy from target accounts, organizational units,
        /// or the root by invoking the <c>StartConfigurationPolicyDisassociation</c> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationPolicy service method.</param>
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
        public virtual DeleteConfigurationPolicyResponse DeleteConfigurationPolicy(DeleteConfigurationPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationPolicy operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteConfigurationPolicy">REST API Reference for DeleteConfigurationPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfigurationPolicy(DeleteConfigurationPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationPolicyResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteConfigurationPolicy">REST API Reference for DeleteConfigurationPolicy Operation</seealso>
        public virtual DeleteConfigurationPolicyResponse EndDeleteConfigurationPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfigurationPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFindingAggregator

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
        /// Initiates the asynchronous execution of the DeleteFindingAggregator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFindingAggregator operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFindingAggregator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteFindingAggregator">REST API Reference for DeleteFindingAggregator Operation</seealso>
        public virtual IAsyncResult BeginDeleteFindingAggregator(DeleteFindingAggregatorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFindingAggregatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFindingAggregator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFindingAggregator.</param>
        /// 
        /// <returns>Returns a  DeleteFindingAggregatorResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteFindingAggregator">REST API Reference for DeleteFindingAggregator Operation</seealso>
        public virtual DeleteFindingAggregatorResponse EndDeleteFindingAggregator(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFindingAggregatorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInsight

        /// <summary>
        /// Deletes the insight specified by the <c>InsightArn</c>.
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
        /// Initiates the asynchronous execution of the DeleteInsight operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInsight operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInsight
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInsight">REST API Reference for DeleteInsight Operation</seealso>
        public virtual IAsyncResult BeginDeleteInsight(DeleteInsightRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInsightResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInsight operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInsight.</param>
        /// 
        /// <returns>Returns a  DeleteInsightResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInsight">REST API Reference for DeleteInsight Operation</seealso>
        public virtual DeleteInsightResponse EndDeleteInsight(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInsightResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInvitations

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
        /// Initiates the asynchronous execution of the DeleteInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        public virtual IAsyncResult BeginDeleteInvitations(DeleteInvitationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvitationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInvitations.</param>
        /// 
        /// <returns>Returns a  DeleteInvitationsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        public virtual DeleteInvitationsResponse EndDeleteInvitations(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInvitationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMembers

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
        /// Initiates the asynchronous execution of the DeleteMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
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
        /// <returns>Returns a  DeleteMembersResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        public virtual DeleteMembersResponse EndDeleteMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMembersResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeActionTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActionTargets operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeActionTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeActionTargets">REST API Reference for DescribeActionTargets Operation</seealso>
        public virtual IAsyncResult BeginDescribeActionTargets(DescribeActionTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActionTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActionTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeActionTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeActionTargets.</param>
        /// 
        /// <returns>Returns a  DescribeActionTargetsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeActionTargets">REST API Reference for DescribeActionTargets Operation</seealso>
        public virtual DescribeActionTargetsResponse EndDescribeActionTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeActionTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHub

        /// <summary>
        /// Returns details about the Hub resource in your account, including the <c>HubArn</c>
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
        /// Initiates the asynchronous execution of the DescribeHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHub operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHub
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeHub">REST API Reference for DescribeHub Operation</seealso>
        public virtual IAsyncResult BeginDescribeHub(DescribeHubRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHubResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHub operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHub.</param>
        /// 
        /// <returns>Returns a  DescribeHubResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeHub">REST API Reference for DescribeHub Operation</seealso>
        public virtual DescribeHubResponse EndDescribeHub(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHubResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOrganizationConfiguration

        /// <summary>
        /// Returns information about the way your organization is configured in Security Hub.
        /// Only the Security Hub administrator account can invoke this operation.
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
        /// Initiates the asynchronous execution of the DescribeOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrganizationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
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
        /// <returns>Returns a  DescribeOrganizationConfigurationResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        public virtual DescribeOrganizationConfigurationResponse EndDescribeOrganizationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOrganizationConfigurationResponse>(asyncResult);
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
        /// If you don't provide an integration ARN, then the results include all of the available
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
        /// Initiates the asynchronous execution of the DescribeProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProducts operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProducts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeProducts">REST API Reference for DescribeProducts Operation</seealso>
        public virtual IAsyncResult BeginDescribeProducts(DescribeProductsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProductsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProducts.</param>
        /// 
        /// <returns>Returns a  DescribeProductsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeProducts">REST API Reference for DescribeProducts Operation</seealso>
        public virtual DescribeProductsResponse EndDescribeProducts(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProductsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeStandards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStandards operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStandards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeStandards">REST API Reference for DescribeStandards Operation</seealso>
        public virtual IAsyncResult BeginDescribeStandards(DescribeStandardsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStandardsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStandards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStandards.</param>
        /// 
        /// <returns>Returns a  DescribeStandardsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeStandards">REST API Reference for DescribeStandards Operation</seealso>
        public virtual DescribeStandardsResponse EndDescribeStandards(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStandardsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeStandardsControls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStandardsControls operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStandardsControls
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeStandardsControls">REST API Reference for DescribeStandardsControls Operation</seealso>
        public virtual IAsyncResult BeginDescribeStandardsControls(DescribeStandardsControlsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStandardsControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStandardsControlsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStandardsControls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStandardsControls.</param>
        /// 
        /// <returns>Returns a  DescribeStandardsControlsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeStandardsControls">REST API Reference for DescribeStandardsControls Operation</seealso>
        public virtual DescribeStandardsControlsResponse EndDescribeStandardsControls(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStandardsControlsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DisableImportFindingsForProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableImportFindingsForProduct operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableImportFindingsForProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableImportFindingsForProduct">REST API Reference for DisableImportFindingsForProduct Operation</seealso>
        public virtual IAsyncResult BeginDisableImportFindingsForProduct(DisableImportFindingsForProductRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableImportFindingsForProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableImportFindingsForProductResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableImportFindingsForProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableImportFindingsForProduct.</param>
        /// 
        /// <returns>Returns a  DisableImportFindingsForProductResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableImportFindingsForProduct">REST API Reference for DisableImportFindingsForProduct Operation</seealso>
        public virtual DisableImportFindingsForProductResponse EndDisableImportFindingsForProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableImportFindingsForProductResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationAdminAccount operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableOrganizationAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
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
        /// <returns>Returns a  DisableOrganizationAdminAccountResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        public virtual DisableOrganizationAdminAccountResponse EndDisableOrganizationAdminAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableOrganizationAdminAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableSecurityHub

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
        public virtual DisableSecurityHubResponse DisableSecurityHub(DisableSecurityHubRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSecurityHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSecurityHubResponseUnmarshaller.Instance;

            return Invoke<DisableSecurityHubResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableSecurityHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSecurityHub operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableSecurityHub
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableSecurityHub">REST API Reference for DisableSecurityHub Operation</seealso>
        public virtual IAsyncResult BeginDisableSecurityHub(DisableSecurityHubRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSecurityHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSecurityHubResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableSecurityHub operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableSecurityHub.</param>
        /// 
        /// <returns>Returns a  DisableSecurityHubResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableSecurityHub">REST API Reference for DisableSecurityHub Operation</seealso>
        public virtual DisableSecurityHubResponse EndDisableSecurityHub(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableSecurityHubResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DisassociateFromAdministratorAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromAdministratorAccount operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFromAdministratorAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateFromAdministratorAccount">REST API Reference for DisassociateFromAdministratorAccount Operation</seealso>
        public virtual IAsyncResult BeginDisassociateFromAdministratorAccount(DisassociateFromAdministratorAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFromAdministratorAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromAdministratorAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFromAdministratorAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFromAdministratorAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateFromAdministratorAccountResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateFromAdministratorAccount">REST API Reference for DisassociateFromAdministratorAccount Operation</seealso>
        public virtual DisassociateFromAdministratorAccountResponse EndDisassociateFromAdministratorAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateFromAdministratorAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateFromMasterAccount

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
        /// Initiates the asynchronous execution of the DisassociateFromMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFromMasterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        [Obsolete("This API has been deprecated, use DisassociateFromAdministratorAccount API instead.")]
        public virtual IAsyncResult BeginDisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFromMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromMasterAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFromMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFromMasterAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateFromMasterAccountResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        [Obsolete("This API has been deprecated, use DisassociateFromAdministratorAccount API instead.")]
        public virtual DisassociateFromMasterAccountResponse EndDisassociateFromMasterAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateFromMasterAccountResponse>(asyncResult);
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
        public virtual DisassociateMembersResponse DisassociateMembers(DisassociateMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMembersResponseUnmarshaller.Instance;

            return Invoke<DisassociateMembersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        public virtual IAsyncResult BeginDisassociateMembers(DisassociateMembersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMembersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMembers.</param>
        /// 
        /// <returns>Returns a  DisassociateMembersResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        public virtual DisassociateMembersResponse EndDisassociateMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateMembersResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the EnableImportFindingsForProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableImportFindingsForProduct operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableImportFindingsForProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableImportFindingsForProduct">REST API Reference for EnableImportFindingsForProduct Operation</seealso>
        public virtual IAsyncResult BeginEnableImportFindingsForProduct(EnableImportFindingsForProductRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableImportFindingsForProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableImportFindingsForProductResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableImportFindingsForProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableImportFindingsForProduct.</param>
        /// 
        /// <returns>Returns a  EnableImportFindingsForProductResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableImportFindingsForProduct">REST API Reference for EnableImportFindingsForProduct Operation</seealso>
        public virtual EnableImportFindingsForProductResponse EndEnableImportFindingsForProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableImportFindingsForProductResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationAdminAccount operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableOrganizationAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
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
        /// <returns>Returns a  EnableOrganizationAdminAccountResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        public virtual EnableOrganizationAdminAccountResponse EndEnableOrganizationAdminAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableOrganizationAdminAccountResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the EnableSecurityHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSecurityHub operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableSecurityHub
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableSecurityHub">REST API Reference for EnableSecurityHub Operation</seealso>
        public virtual IAsyncResult BeginEnableSecurityHub(EnableSecurityHubRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSecurityHubRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSecurityHubResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableSecurityHub operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableSecurityHub.</param>
        /// 
        /// <returns>Returns a  EnableSecurityHubResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableSecurityHub">REST API Reference for EnableSecurityHub Operation</seealso>
        public virtual EnableSecurityHubResponse EndEnableSecurityHub(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableSecurityHubResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetAdministratorAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAdministratorAccount operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAdministratorAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetAdministratorAccount">REST API Reference for GetAdministratorAccount Operation</seealso>
        public virtual IAsyncResult BeginGetAdministratorAccount(GetAdministratorAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAdministratorAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdministratorAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAdministratorAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAdministratorAccount.</param>
        /// 
        /// <returns>Returns a  GetAdministratorAccountResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetAdministratorAccount">REST API Reference for GetAdministratorAccount Operation</seealso>
        public virtual GetAdministratorAccountResponse EndGetAdministratorAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAdministratorAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfigurationPolicy

        /// <summary>
        /// Provides information about a configuration policy. Only the Security Hub delegated
        /// administrator can invoke this operation from the home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationPolicy service method.</param>
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
        public virtual GetConfigurationPolicyResponse GetConfigurationPolicy(GetConfigurationPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationPolicyResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationPolicy operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfigurationPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetConfigurationPolicy">REST API Reference for GetConfigurationPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetConfigurationPolicy(GetConfigurationPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfigurationPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfigurationPolicy.</param>
        /// 
        /// <returns>Returns a  GetConfigurationPolicyResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetConfigurationPolicy">REST API Reference for GetConfigurationPolicy Operation</seealso>
        public virtual GetConfigurationPolicyResponse EndGetConfigurationPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfigurationPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfigurationPolicyAssociation

        /// <summary>
        /// Returns the association between a configuration and a target account, organizational
        /// unit, or the root. The configuration can be a configuration policy or self-managed
        /// behavior. Only the Security Hub delegated administrator can invoke this operation
        /// from the home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationPolicyAssociation service method.</param>
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
        public virtual GetConfigurationPolicyAssociationResponse GetConfigurationPolicyAssociation(GetConfigurationPolicyAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigurationPolicyAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationPolicyAssociationResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationPolicyAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationPolicyAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationPolicyAssociation operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfigurationPolicyAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetConfigurationPolicyAssociation">REST API Reference for GetConfigurationPolicyAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetConfigurationPolicyAssociation(GetConfigurationPolicyAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigurationPolicyAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationPolicyAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfigurationPolicyAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfigurationPolicyAssociation.</param>
        /// 
        /// <returns>Returns a  GetConfigurationPolicyAssociationResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetConfigurationPolicyAssociation">REST API Reference for GetConfigurationPolicyAssociation Operation</seealso>
        public virtual GetConfigurationPolicyAssociationResponse EndGetConfigurationPolicyAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfigurationPolicyAssociationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetEnabledStandards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledStandards operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnabledStandards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetEnabledStandards">REST API Reference for GetEnabledStandards Operation</seealso>
        public virtual IAsyncResult BeginGetEnabledStandards(GetEnabledStandardsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnabledStandardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnabledStandardsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnabledStandards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnabledStandards.</param>
        /// 
        /// <returns>Returns a  GetEnabledStandardsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetEnabledStandards">REST API Reference for GetEnabledStandards Operation</seealso>
        public virtual GetEnabledStandardsResponse EndGetEnabledStandards(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnabledStandardsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFindingAggregator

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
        /// Initiates the asynchronous execution of the GetFindingAggregator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindingAggregator operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindingAggregator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindingAggregator">REST API Reference for GetFindingAggregator Operation</seealso>
        public virtual IAsyncResult BeginGetFindingAggregator(GetFindingAggregatorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingAggregatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindingAggregator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindingAggregator.</param>
        /// 
        /// <returns>Returns a  GetFindingAggregatorResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindingAggregator">REST API Reference for GetFindingAggregator Operation</seealso>
        public virtual GetFindingAggregatorResponse EndGetFindingAggregator(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFindingAggregatorResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFindingHistory

        /// <summary>
        /// Returns history for a Security Hub finding in the last 90 days. The history includes
        /// changes made to any fields in the Amazon Web Services Security Finding Format (ASFF).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingHistory service method.</param>
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
        public virtual GetFindingHistoryResponse GetFindingHistory(GetFindingHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingHistoryResponseUnmarshaller.Instance;

            return Invoke<GetFindingHistoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindingHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindingHistory operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindingHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindingHistory">REST API Reference for GetFindingHistory Operation</seealso>
        public virtual IAsyncResult BeginGetFindingHistory(GetFindingHistoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingHistoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindingHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindingHistory.</param>
        /// 
        /// <returns>Returns a  GetFindingHistoryResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindingHistory">REST API Reference for GetFindingHistory Operation</seealso>
        public virtual GetFindingHistoryResponse EndGetFindingHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFindingHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFindings

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
        /// Initiates the asynchronous execution of the GetFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindings operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindings">REST API Reference for GetFindings Operation</seealso>
        public virtual IAsyncResult BeginGetFindings(GetFindingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindings.</param>
        /// 
        /// <returns>Returns a  GetFindingsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindings">REST API Reference for GetFindings Operation</seealso>
        public virtual GetFindingsResponse EndGetFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFindingsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetInsightResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInsightResults operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInsightResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsightResults">REST API Reference for GetInsightResults Operation</seealso>
        public virtual IAsyncResult BeginGetInsightResults(GetInsightResultsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightResultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInsightResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInsightResults.</param>
        /// 
        /// <returns>Returns a  GetInsightResultsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsightResults">REST API Reference for GetInsightResults Operation</seealso>
        public virtual GetInsightResultsResponse EndGetInsightResults(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInsightResultsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetInsights operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInsights operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInsights
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsights">REST API Reference for GetInsights Operation</seealso>
        public virtual IAsyncResult BeginGetInsights(GetInsightsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInsights operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInsights.</param>
        /// 
        /// <returns>Returns a  GetInsightsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsights">REST API Reference for GetInsights Operation</seealso>
        public virtual GetInsightsResponse EndGetInsights(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInsightsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInvitationsCount

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
        /// Initiates the asynchronous execution of the GetInvitationsCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvitationsCount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        public virtual IAsyncResult BeginGetInvitationsCount(GetInvitationsCountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInvitationsCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvitationsCountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvitationsCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvitationsCount.</param>
        /// 
        /// <returns>Returns a  GetInvitationsCountResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        public virtual GetInvitationsCountResponse EndGetInvitationsCount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInvitationsCountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMasterAccount

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
        /// Initiates the asynchronous execution of the GetMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMasterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        [Obsolete("This API has been deprecated, use GetAdministratorAccount API instead.")]
        public virtual IAsyncResult BeginGetMasterAccount(GetMasterAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMasterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMasterAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMasterAccount.</param>
        /// 
        /// <returns>Returns a  GetMasterAccountResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        [Obsolete("This API has been deprecated, use GetAdministratorAccount API instead.")]
        public virtual GetMasterAccountResponse EndGetMasterAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMasterAccountResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMembers operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMembers">REST API Reference for GetMembers Operation</seealso>
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
        /// <returns>Returns a  GetMembersResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMembers">REST API Reference for GetMembers Operation</seealso>
        public virtual GetMembersResponse EndGetMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSecurityControlDefinition

        /// <summary>
        /// Retrieves the definition of a security control. The definition includes the control
        /// title, description, Region availability, parameter definitions, and other details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityControlDefinition service method.</param>
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
        public virtual GetSecurityControlDefinitionResponse GetSecurityControlDefinition(GetSecurityControlDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityControlDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityControlDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetSecurityControlDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSecurityControlDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityControlDefinition operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSecurityControlDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetSecurityControlDefinition">REST API Reference for GetSecurityControlDefinition Operation</seealso>
        public virtual IAsyncResult BeginGetSecurityControlDefinition(GetSecurityControlDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityControlDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityControlDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSecurityControlDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSecurityControlDefinition.</param>
        /// 
        /// <returns>Returns a  GetSecurityControlDefinitionResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetSecurityControlDefinition">REST API Reference for GetSecurityControlDefinition Operation</seealso>
        public virtual GetSecurityControlDefinitionResponse EndGetSecurityControlDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSecurityControlDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  InviteMembers

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
        /// Initiates the asynchronous execution of the InviteMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInviteMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        public virtual IAsyncResult BeginInviteMembers(InviteMembersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InviteMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InviteMembersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InviteMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInviteMembers.</param>
        /// 
        /// <returns>Returns a  InviteMembersResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        public virtual InviteMembersResponse EndInviteMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<InviteMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAutomationRules

        /// <summary>
        /// A list of automation rules and their metadata for the calling account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRules service method.</param>
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
        public virtual ListAutomationRulesResponse ListAutomationRules(ListAutomationRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationRulesResponseUnmarshaller.Instance;

            return Invoke<ListAutomationRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutomationRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRules operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutomationRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListAutomationRules">REST API Reference for ListAutomationRules Operation</seealso>
        public virtual IAsyncResult BeginListAutomationRules(ListAutomationRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutomationRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutomationRules.</param>
        /// 
        /// <returns>Returns a  ListAutomationRulesResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListAutomationRules">REST API Reference for ListAutomationRules Operation</seealso>
        public virtual ListAutomationRulesResponse EndListAutomationRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAutomationRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfigurationPolicies

        /// <summary>
        /// Lists the configuration policies that the Security Hub delegated administrator has
        /// created for your organization. Only the delegated administrator can invoke this operation
        /// from the home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationPolicies service method.</param>
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
        public virtual ListConfigurationPoliciesResponse ListConfigurationPolicies(ListConfigurationPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationPolicies operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListConfigurationPolicies">REST API Reference for ListConfigurationPolicies Operation</seealso>
        public virtual IAsyncResult BeginListConfigurationPolicies(ListConfigurationPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationPolicies.</param>
        /// 
        /// <returns>Returns a  ListConfigurationPoliciesResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListConfigurationPolicies">REST API Reference for ListConfigurationPolicies Operation</seealso>
        public virtual ListConfigurationPoliciesResponse EndListConfigurationPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfigurationPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfigurationPolicyAssociations

        /// <summary>
        /// Provides information about the associations for your configuration policies and self-managed
        /// behavior. Only the Security Hub delegated administrator can invoke this operation
        /// from the home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationPolicyAssociations service method.</param>
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
        public virtual ListConfigurationPolicyAssociationsResponse ListConfigurationPolicyAssociations(ListConfigurationPolicyAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationPolicyAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationPolicyAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationPolicyAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationPolicyAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationPolicyAssociations operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationPolicyAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListConfigurationPolicyAssociations">REST API Reference for ListConfigurationPolicyAssociations Operation</seealso>
        public virtual IAsyncResult BeginListConfigurationPolicyAssociations(ListConfigurationPolicyAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfigurationPolicyAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationPolicyAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationPolicyAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationPolicyAssociations.</param>
        /// 
        /// <returns>Returns a  ListConfigurationPolicyAssociationsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListConfigurationPolicyAssociations">REST API Reference for ListConfigurationPolicyAssociations Operation</seealso>
        public virtual ListConfigurationPolicyAssociationsResponse EndListConfigurationPolicyAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfigurationPolicyAssociationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListEnabledProductsForImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledProductsForImport operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnabledProductsForImport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListEnabledProductsForImport">REST API Reference for ListEnabledProductsForImport Operation</seealso>
        public virtual IAsyncResult BeginListEnabledProductsForImport(ListEnabledProductsForImportRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnabledProductsForImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnabledProductsForImportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnabledProductsForImport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnabledProductsForImport.</param>
        /// 
        /// <returns>Returns a  ListEnabledProductsForImportResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListEnabledProductsForImport">REST API Reference for ListEnabledProductsForImport Operation</seealso>
        public virtual ListEnabledProductsForImportResponse EndListEnabledProductsForImport(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnabledProductsForImportResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFindingAggregators

        /// <summary>
        /// If cross-Region aggregation is enabled, then <c>ListFindingAggregators</c> returns
        /// the Amazon Resource Name (ARN) of the finding aggregator. You can run this operation
        /// from any Amazon Web Services Region.
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
        /// Initiates the asynchronous execution of the ListFindingAggregators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindingAggregators operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFindingAggregators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListFindingAggregators">REST API Reference for ListFindingAggregators Operation</seealso>
        public virtual IAsyncResult BeginListFindingAggregators(ListFindingAggregatorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingAggregatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingAggregatorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFindingAggregators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFindingAggregators.</param>
        /// 
        /// <returns>Returns a  ListFindingAggregatorsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListFindingAggregators">REST API Reference for ListFindingAggregators Operation</seealso>
        public virtual ListFindingAggregatorsResponse EndListFindingAggregators(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFindingAggregatorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInvitations

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
        /// Initiates the asynchronous execution of the ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
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
        /// <returns>Returns a  ListInvitationsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        public virtual ListInvitationsResponse EndListInvitations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInvitationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMembers operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListMembers">REST API Reference for ListMembers Operation</seealso>
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
        /// <returns>Returns a  ListMembersResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual ListMembersResponse EndListMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMembersResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListOrganizationAdminAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationAdminAccounts operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizationAdminAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
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
        /// <returns>Returns a  ListOrganizationAdminAccountsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
        public virtual ListOrganizationAdminAccountsResponse EndListOrganizationAdminAccounts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOrganizationAdminAccountsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSecurityControlDefinitions

        /// <summary>
        /// Lists all of the security controls that apply to a specified standard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityControlDefinitions service method.</param>
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
        public virtual ListSecurityControlDefinitionsResponse ListSecurityControlDefinitions(ListSecurityControlDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityControlDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityControlDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListSecurityControlDefinitionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecurityControlDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityControlDefinitions operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSecurityControlDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListSecurityControlDefinitions">REST API Reference for ListSecurityControlDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListSecurityControlDefinitions(ListSecurityControlDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityControlDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityControlDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSecurityControlDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSecurityControlDefinitions.</param>
        /// 
        /// <returns>Returns a  ListSecurityControlDefinitionsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListSecurityControlDefinitions">REST API Reference for ListSecurityControlDefinitions Operation</seealso>
        public virtual ListSecurityControlDefinitionsResponse EndListSecurityControlDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSecurityControlDefinitionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStandardsControlAssociations

        /// <summary>
        /// Specifies whether a control is currently enabled or disabled in each enabled standard
        /// in the calling account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStandardsControlAssociations service method.</param>
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
        public virtual ListStandardsControlAssociationsResponse ListStandardsControlAssociations(ListStandardsControlAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStandardsControlAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStandardsControlAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListStandardsControlAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStandardsControlAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStandardsControlAssociations operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStandardsControlAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListStandardsControlAssociations">REST API Reference for ListStandardsControlAssociations Operation</seealso>
        public virtual IAsyncResult BeginListStandardsControlAssociations(ListStandardsControlAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStandardsControlAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStandardsControlAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStandardsControlAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStandardsControlAssociations.</param>
        /// 
        /// <returns>Returns a  ListStandardsControlAssociationsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListStandardsControlAssociations">REST API Reference for ListStandardsControlAssociations Operation</seealso>
        public virtual ListStandardsControlAssociationsResponse EndListStandardsControlAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStandardsControlAssociationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartConfigurationPolicyAssociation

        /// <summary>
        /// Associates a target account, organizational unit, or the root with a specified configuration.
        /// The target can be associated with a configuration policy or self-managed behavior.
        /// Only the Security Hub delegated administrator can invoke this operation from the home
        /// Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationPolicyAssociation service method.</param>
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
        public virtual StartConfigurationPolicyAssociationResponse StartConfigurationPolicyAssociation(StartConfigurationPolicyAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigurationPolicyAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationPolicyAssociationResponseUnmarshaller.Instance;

            return Invoke<StartConfigurationPolicyAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartConfigurationPolicyAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationPolicyAssociation operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartConfigurationPolicyAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/StartConfigurationPolicyAssociation">REST API Reference for StartConfigurationPolicyAssociation Operation</seealso>
        public virtual IAsyncResult BeginStartConfigurationPolicyAssociation(StartConfigurationPolicyAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigurationPolicyAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationPolicyAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartConfigurationPolicyAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartConfigurationPolicyAssociation.</param>
        /// 
        /// <returns>Returns a  StartConfigurationPolicyAssociationResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/StartConfigurationPolicyAssociation">REST API Reference for StartConfigurationPolicyAssociation Operation</seealso>
        public virtual StartConfigurationPolicyAssociationResponse EndStartConfigurationPolicyAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<StartConfigurationPolicyAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartConfigurationPolicyDisassociation

        /// <summary>
        /// Disassociates a target account, organizational unit, or the root from a specified
        /// configuration. When you disassociate a configuration from its target, the target inherits
        /// the configuration of the closest parent. If there’s no configuration to inherit, the
        /// target retains its settings but becomes a self-managed account. A target can be disassociated
        /// from a configuration policy or self-managed behavior. Only the Security Hub delegated
        /// administrator can invoke this operation from the home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationPolicyDisassociation service method.</param>
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
        public virtual StartConfigurationPolicyDisassociationResponse StartConfigurationPolicyDisassociation(StartConfigurationPolicyDisassociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigurationPolicyDisassociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationPolicyDisassociationResponseUnmarshaller.Instance;

            return Invoke<StartConfigurationPolicyDisassociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartConfigurationPolicyDisassociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationPolicyDisassociation operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartConfigurationPolicyDisassociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/StartConfigurationPolicyDisassociation">REST API Reference for StartConfigurationPolicyDisassociation Operation</seealso>
        public virtual IAsyncResult BeginStartConfigurationPolicyDisassociation(StartConfigurationPolicyDisassociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigurationPolicyDisassociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationPolicyDisassociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartConfigurationPolicyDisassociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartConfigurationPolicyDisassociation.</param>
        /// 
        /// <returns>Returns a  StartConfigurationPolicyDisassociationResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/StartConfigurationPolicyDisassociation">REST API Reference for StartConfigurationPolicyDisassociation Operation</seealso>
        public virtual StartConfigurationPolicyDisassociationResponse EndStartConfigurationPolicyDisassociation(IAsyncResult asyncResult)
        {
            return EndInvoke<StartConfigurationPolicyDisassociationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateActionTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateActionTarget operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateActionTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateActionTarget">REST API Reference for UpdateActionTarget Operation</seealso>
        public virtual IAsyncResult BeginUpdateActionTarget(UpdateActionTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateActionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateActionTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateActionTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateActionTarget.</param>
        /// 
        /// <returns>Returns a  UpdateActionTargetResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateActionTarget">REST API Reference for UpdateActionTarget Operation</seealso>
        public virtual UpdateActionTargetResponse EndUpdateActionTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateActionTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConfigurationPolicy

        /// <summary>
        /// Updates a configuration policy. Only the Security Hub delegated administrator can
        /// invoke this operation from the home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationPolicy service method.</param>
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
        public virtual UpdateConfigurationPolicyResponse UpdateConfigurationPolicy(UpdateConfigurationPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationPolicy operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateConfigurationPolicy">REST API Reference for UpdateConfigurationPolicy Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfigurationPolicy(UpdateConfigurationPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationPolicyResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateConfigurationPolicy">REST API Reference for UpdateConfigurationPolicy Operation</seealso>
        public virtual UpdateConfigurationPolicyResponse EndUpdateConfigurationPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfigurationPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFindingAggregator

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
        /// Initiates the asynchronous execution of the UpdateFindingAggregator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingAggregator operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFindingAggregator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateFindingAggregator">REST API Reference for UpdateFindingAggregator Operation</seealso>
        public virtual IAsyncResult BeginUpdateFindingAggregator(UpdateFindingAggregatorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFindingAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingAggregatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFindingAggregator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFindingAggregator.</param>
        /// 
        /// <returns>Returns a  UpdateFindingAggregatorResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateFindingAggregator">REST API Reference for UpdateFindingAggregator Operation</seealso>
        public virtual UpdateFindingAggregatorResponse EndUpdateFindingAggregator(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFindingAggregatorResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFindings

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
        /// Initiates the asynchronous execution of the UpdateFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindings operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateFindings">REST API Reference for UpdateFindings Operation</seealso>
        public virtual IAsyncResult BeginUpdateFindings(UpdateFindingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFindings.</param>
        /// 
        /// <returns>Returns a  UpdateFindingsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateFindings">REST API Reference for UpdateFindings Operation</seealso>
        public virtual UpdateFindingsResponse EndUpdateFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFindingsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateInsight operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInsight operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInsight
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateInsight">REST API Reference for UpdateInsight Operation</seealso>
        public virtual IAsyncResult BeginUpdateInsight(UpdateInsightRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInsightResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInsight operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInsight.</param>
        /// 
        /// <returns>Returns a  UpdateInsightResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateInsight">REST API Reference for UpdateInsight Operation</seealso>
        public virtual UpdateInsightResponse EndUpdateInsight(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInsightResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateOrganizationConfiguration

        /// <summary>
        /// Updates the configuration of your organization in Security Hub. Only the Security
        /// Hub administrator account can invoke this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOrganizationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
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
        /// <returns>Returns a  UpdateOrganizationConfigurationResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        public virtual UpdateOrganizationConfigurationResponse EndUpdateOrganizationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateOrganizationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSecurityControl

        /// <summary>
        /// Updates the properties of a security control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityControl service method.</param>
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
        public virtual UpdateSecurityControlResponse UpdateSecurityControl(UpdateSecurityControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityControlResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityControlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurityControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityControl operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSecurityControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateSecurityControl">REST API Reference for UpdateSecurityControl Operation</seealso>
        public virtual IAsyncResult BeginUpdateSecurityControl(UpdateSecurityControlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityControlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSecurityControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSecurityControl.</param>
        /// 
        /// <returns>Returns a  UpdateSecurityControlResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateSecurityControl">REST API Reference for UpdateSecurityControl Operation</seealso>
        public virtual UpdateSecurityControlResponse EndUpdateSecurityControl(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSecurityControlResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSecurityHubConfiguration

        /// <summary>
        /// Updates configuration options for Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityHubConfiguration service method.</param>
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
        public virtual UpdateSecurityHubConfigurationResponse UpdateSecurityHubConfiguration(UpdateSecurityHubConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityHubConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityHubConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityHubConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurityHubConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityHubConfiguration operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSecurityHubConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateSecurityHubConfiguration">REST API Reference for UpdateSecurityHubConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateSecurityHubConfiguration(UpdateSecurityHubConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityHubConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityHubConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSecurityHubConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSecurityHubConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateSecurityHubConfigurationResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateSecurityHubConfiguration">REST API Reference for UpdateSecurityHubConfiguration Operation</seealso>
        public virtual UpdateSecurityHubConfigurationResponse EndUpdateSecurityHubConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSecurityHubConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStandardsControl

        /// <summary>
        /// Used to control whether an individual security standard control is enabled or disabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStandardsControl service method.</param>
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
        public virtual UpdateStandardsControlResponse UpdateStandardsControl(UpdateStandardsControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStandardsControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStandardsControlResponseUnmarshaller.Instance;

            return Invoke<UpdateStandardsControlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStandardsControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStandardsControl operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStandardsControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateStandardsControl">REST API Reference for UpdateStandardsControl Operation</seealso>
        public virtual IAsyncResult BeginUpdateStandardsControl(UpdateStandardsControlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStandardsControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStandardsControlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStandardsControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStandardsControl.</param>
        /// 
        /// <returns>Returns a  UpdateStandardsControlResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateStandardsControl">REST API Reference for UpdateStandardsControl Operation</seealso>
        public virtual UpdateStandardsControlResponse EndUpdateStandardsControl(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStandardsControlResponse>(asyncResult);
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
            var resolver = new AmazonSecurityHubEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}