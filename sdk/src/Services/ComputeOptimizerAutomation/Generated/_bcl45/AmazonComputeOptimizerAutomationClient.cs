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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ComputeOptimizerAutomation.Model;
using Amazon.ComputeOptimizerAutomation.Model.Internal.MarshallTransformations;
using Amazon.ComputeOptimizerAutomation.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ComputeOptimizerAutomation
{
    /// <summary>
    /// <para>Implementation for accessing ComputeOptimizerAutomation</para>
    ///
    /// Automation is a feature within Amazon Web Services Compute Optimizer that enables
    /// you to apply optimization recommendations to your Amazon Web Services resources, reducing
    /// costs and improving performance. You can apply recommended actions directly or create
    /// automation rules that implement recommendations on a recurring schedule when they
    /// match your specified criteria. With automation rules, set criteria such as Amazon
    /// Web Services Region and Resource Tags to target specific geographies and workloads.
    /// Configure rules to run daily, weekly, or monthly, and Compute Optimizer continuously
    /// evaluates new recommendations against your criteria. Track automation events over
    /// time, examine detailed step history, estimate savings achieved, and reverse actions
    /// directly from Compute Optimizer when needed.
    /// </summary>
    public partial class AmazonComputeOptimizerAutomationClient : AmazonServiceClient, IAmazonComputeOptimizerAutomation
    {
        private static IServiceMetadata serviceMetadata = new AmazonComputeOptimizerAutomationMetadata();
        private IComputeOptimizerAutomationPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IComputeOptimizerAutomationPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ComputeOptimizerAutomationPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonComputeOptimizerAutomationClient with the credentials loaded from the application's
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
        public AmazonComputeOptimizerAutomationClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonComputeOptimizerAutomationConfig()) { }

        /// <summary>
        /// Constructs AmazonComputeOptimizerAutomationClient with the credentials loaded from the application's
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
        public AmazonComputeOptimizerAutomationClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonComputeOptimizerAutomationConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonComputeOptimizerAutomationClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonComputeOptimizerAutomationClient Configuration Object</param>
        public AmazonComputeOptimizerAutomationClient(AmazonComputeOptimizerAutomationConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

        /// <summary>
        /// Constructs AmazonComputeOptimizerAutomationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonComputeOptimizerAutomationClient(AWSCredentials credentials)
            : this(credentials, new AmazonComputeOptimizerAutomationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerAutomationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComputeOptimizerAutomationClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonComputeOptimizerAutomationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerAutomationClient with AWS Credentials and an
        /// AmazonComputeOptimizerAutomationClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonComputeOptimizerAutomationClient Configuration Object</param>
        public AmazonComputeOptimizerAutomationClient(AWSCredentials credentials, AmazonComputeOptimizerAutomationConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerAutomationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonComputeOptimizerAutomationClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonComputeOptimizerAutomationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerAutomationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComputeOptimizerAutomationClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonComputeOptimizerAutomationConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerAutomationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonComputeOptimizerAutomationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonComputeOptimizerAutomationClient Configuration Object</param>
        public AmazonComputeOptimizerAutomationClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonComputeOptimizerAutomationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerAutomationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonComputeOptimizerAutomationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonComputeOptimizerAutomationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerAutomationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComputeOptimizerAutomationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonComputeOptimizerAutomationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerAutomationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonComputeOptimizerAutomationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonComputeOptimizerAutomationClient Configuration Object</param>
        public AmazonComputeOptimizerAutomationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonComputeOptimizerAutomationConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonComputeOptimizerAutomationEndpointResolver());
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


        #region  AssociateAccounts


        /// <summary>
        /// Associates one or more member accounts with your organization's management account,
        /// enabling centralized implementation of optimization actions across those accounts.
        /// Once associated, the management account (or a delegated administrator) can apply recommended
        /// actions to the member account. When you associate a member account, its organization
        /// rule mode is automatically set to "Any allowed," which permits the management account
        /// to create Automation rules that automatically apply actions to that account. If the
        /// member account has not previously enabled the Automation feature, the association
        /// process automatically enables it.
        /// 
        ///  <note> 
        /// <para>
        /// Only the management account or a delegated administrator can perform this action.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAccounts service method.</param>
        /// 
        /// <returns>The response from the AssociateAccounts service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.NotManagementAccountException">
        /// The operation can only be performed by a management account.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/AssociateAccounts">REST API Reference for AssociateAccounts Operation</seealso>
        public virtual AssociateAccountsResponse AssociateAccounts(AssociateAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAccountsResponseUnmarshaller.Instance;

            return Invoke<AssociateAccountsResponse>(request, options);
        }


        /// <summary>
        /// Associates one or more member accounts with your organization's management account,
        /// enabling centralized implementation of optimization actions across those accounts.
        /// Once associated, the management account (or a delegated administrator) can apply recommended
        /// actions to the member account. When you associate a member account, its organization
        /// rule mode is automatically set to "Any allowed," which permits the management account
        /// to create Automation rules that automatically apply actions to that account. If the
        /// member account has not previously enabled the Automation feature, the association
        /// process automatically enables it.
        /// 
        ///  <note> 
        /// <para>
        /// Only the management account or a delegated administrator can perform this action.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAccounts service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.NotManagementAccountException">
        /// The operation can only be performed by a management account.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/AssociateAccounts">REST API Reference for AssociateAccounts Operation</seealso>
        public virtual Task<AssociateAccountsResponse> AssociateAccountsAsync(AssociateAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAccountsResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateAccountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAutomationRule


        /// <summary>
        /// Creates a new automation rule to apply recommended actions to resources based on
        /// specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomationRule service method.</param>
        /// 
        /// <returns>The response from the CreateAutomationRule service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceQuotaExceededException">
        /// The request would exceed service quotas.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/CreateAutomationRule">REST API Reference for CreateAutomationRule Operation</seealso>
        public virtual CreateAutomationRuleResponse CreateAutomationRule(CreateAutomationRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomationRuleResponseUnmarshaller.Instance;

            return Invoke<CreateAutomationRuleResponse>(request, options);
        }


        /// <summary>
        /// Creates a new automation rule to apply recommended actions to resources based on
        /// specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAutomationRule service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceQuotaExceededException">
        /// The request would exceed service quotas.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/CreateAutomationRule">REST API Reference for CreateAutomationRule Operation</seealso>
        public virtual Task<CreateAutomationRuleResponse> CreateAutomationRuleAsync(CreateAutomationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomationRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAutomationRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAutomationRule


        /// <summary>
        /// Deletes an existing automation rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomationRule service method.</param>
        /// 
        /// <returns>The response from the DeleteAutomationRule service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/DeleteAutomationRule">REST API Reference for DeleteAutomationRule Operation</seealso>
        public virtual DeleteAutomationRuleResponse DeleteAutomationRule(DeleteAutomationRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomationRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteAutomationRuleResponse>(request, options);
        }


        /// <summary>
        /// Deletes an existing automation rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAutomationRule service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/DeleteAutomationRule">REST API Reference for DeleteAutomationRule Operation</seealso>
        public virtual Task<DeleteAutomationRuleResponse> DeleteAutomationRuleAsync(DeleteAutomationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomationRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAutomationRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateAccounts


        /// <summary>
        /// Disassociates member accounts from your organization's management account, removing
        /// centralized automation capabilities. Once disassociated, organization rules no longer
        /// apply to the member account, and the management account (or delegated administrator)
        /// cannot create Automation rules for that account. 
        /// 
        ///  <note> 
        /// <para>
        /// Only the management account or a delegated administrator can perform this action.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAccounts service method.</param>
        /// 
        /// <returns>The response from the DisassociateAccounts service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.NotManagementAccountException">
        /// The operation can only be performed by a management account.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/DisassociateAccounts">REST API Reference for DisassociateAccounts Operation</seealso>
        public virtual DisassociateAccountsResponse DisassociateAccounts(DisassociateAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAccountsResponseUnmarshaller.Instance;

            return Invoke<DisassociateAccountsResponse>(request, options);
        }


        /// <summary>
        /// Disassociates member accounts from your organization's management account, removing
        /// centralized automation capabilities. Once disassociated, organization rules no longer
        /// apply to the member account, and the management account (or delegated administrator)
        /// cannot create Automation rules for that account. 
        /// 
        ///  <note> 
        /// <para>
        /// Only the management account or a delegated administrator can perform this action.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAccounts service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.NotManagementAccountException">
        /// The operation can only be performed by a management account.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/DisassociateAccounts">REST API Reference for DisassociateAccounts Operation</seealso>
        public virtual Task<DisassociateAccountsResponse> DisassociateAccountsAsync(DisassociateAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAccountsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateAccountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAutomationEvent


        /// <summary>
        /// Retrieves details about a specific automation event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationEvent service method.</param>
        /// 
        /// <returns>The response from the GetAutomationEvent service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/GetAutomationEvent">REST API Reference for GetAutomationEvent Operation</seealso>
        public virtual GetAutomationEventResponse GetAutomationEvent(GetAutomationEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomationEventResponseUnmarshaller.Instance;

            return Invoke<GetAutomationEventResponse>(request, options);
        }


        /// <summary>
        /// Retrieves details about a specific automation event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutomationEvent service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/GetAutomationEvent">REST API Reference for GetAutomationEvent Operation</seealso>
        public virtual Task<GetAutomationEventResponse> GetAutomationEventAsync(GetAutomationEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomationEventResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAutomationEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAutomationRule


        /// <summary>
        /// Retrieves details about a specific automation rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationRule service method.</param>
        /// 
        /// <returns>The response from the GetAutomationRule service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/GetAutomationRule">REST API Reference for GetAutomationRule Operation</seealso>
        public virtual GetAutomationRuleResponse GetAutomationRule(GetAutomationRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomationRuleResponseUnmarshaller.Instance;

            return Invoke<GetAutomationRuleResponse>(request, options);
        }


        /// <summary>
        /// Retrieves details about a specific automation rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutomationRule service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/GetAutomationRule">REST API Reference for GetAutomationRule Operation</seealso>
        public virtual Task<GetAutomationRuleResponse> GetAutomationRuleAsync(GetAutomationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomationRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAutomationRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEnrollmentConfiguration


        /// <summary>
        /// Retrieves the current enrollment configuration for Compute Optimizer Automation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnrollmentConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetEnrollmentConfiguration service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/GetEnrollmentConfiguration">REST API Reference for GetEnrollmentConfiguration Operation</seealso>
        public virtual GetEnrollmentConfigurationResponse GetEnrollmentConfiguration(GetEnrollmentConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnrollmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnrollmentConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetEnrollmentConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the current enrollment configuration for Compute Optimizer Automation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnrollmentConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnrollmentConfiguration service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/GetEnrollmentConfiguration">REST API Reference for GetEnrollmentConfiguration Operation</seealso>
        public virtual Task<GetEnrollmentConfigurationResponse> GetEnrollmentConfigurationAsync(GetEnrollmentConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnrollmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnrollmentConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEnrollmentConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccounts


        /// <summary>
        /// Lists the accounts in your organization that are enrolled in Compute Optimizer and
        /// whether they have enabled Automation. 
        /// 
        ///  <note> 
        /// <para>
        /// Only the management account or a delegated administrator can perform this action.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts service method.</param>
        /// 
        /// <returns>The response from the ListAccounts service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.NotManagementAccountException">
        /// The operation can only be performed by a management account.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        public virtual ListAccountsResponse ListAccounts(ListAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsResponseUnmarshaller.Instance;

            return Invoke<ListAccountsResponse>(request, options);
        }


        /// <summary>
        /// Lists the accounts in your organization that are enrolled in Compute Optimizer and
        /// whether they have enabled Automation. 
        /// 
        ///  <note> 
        /// <para>
        /// Only the management account or a delegated administrator can perform this action.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccounts service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.NotManagementAccountException">
        /// The operation can only be performed by a management account.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        public virtual Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAutomationEvents


        /// <summary>
        /// Lists automation events based on specified filters. You can retrieve events that were
        /// created within the past year.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationEvents service method.</param>
        /// 
        /// <returns>The response from the ListAutomationEvents service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationEvents">REST API Reference for ListAutomationEvents Operation</seealso>
        public virtual ListAutomationEventsResponse ListAutomationEvents(ListAutomationEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationEventsResponseUnmarshaller.Instance;

            return Invoke<ListAutomationEventsResponse>(request, options);
        }


        /// <summary>
        /// Lists automation events based on specified filters. You can retrieve events that were
        /// created within the past year.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomationEvents service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationEvents">REST API Reference for ListAutomationEvents Operation</seealso>
        public virtual Task<ListAutomationEventsResponse> ListAutomationEventsAsync(ListAutomationEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAutomationEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAutomationEventSteps


        /// <summary>
        /// Lists the steps for a specific automation event. You can only list steps for events
        /// created within the past year.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationEventSteps service method.</param>
        /// 
        /// <returns>The response from the ListAutomationEventSteps service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationEventSteps">REST API Reference for ListAutomationEventSteps Operation</seealso>
        public virtual ListAutomationEventStepsResponse ListAutomationEventSteps(ListAutomationEventStepsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationEventStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationEventStepsResponseUnmarshaller.Instance;

            return Invoke<ListAutomationEventStepsResponse>(request, options);
        }


        /// <summary>
        /// Lists the steps for a specific automation event. You can only list steps for events
        /// created within the past year.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationEventSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomationEventSteps service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationEventSteps">REST API Reference for ListAutomationEventSteps Operation</seealso>
        public virtual Task<ListAutomationEventStepsResponse> ListAutomationEventStepsAsync(ListAutomationEventStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationEventStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationEventStepsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAutomationEventStepsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAutomationEventSummaries


        /// <summary>
        /// Provides a summary of automation events based on specified filters. Only events created
        /// within the past year will be included in the summary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationEventSummaries service method.</param>
        /// 
        /// <returns>The response from the ListAutomationEventSummaries service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationEventSummaries">REST API Reference for ListAutomationEventSummaries Operation</seealso>
        public virtual ListAutomationEventSummariesResponse ListAutomationEventSummaries(ListAutomationEventSummariesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationEventSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationEventSummariesResponseUnmarshaller.Instance;

            return Invoke<ListAutomationEventSummariesResponse>(request, options);
        }


        /// <summary>
        /// Provides a summary of automation events based on specified filters. Only events created
        /// within the past year will be included in the summary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationEventSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomationEventSummaries service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationEventSummaries">REST API Reference for ListAutomationEventSummaries Operation</seealso>
        public virtual Task<ListAutomationEventSummariesResponse> ListAutomationEventSummariesAsync(ListAutomationEventSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationEventSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationEventSummariesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAutomationEventSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAutomationRulePreview


        /// <summary>
        /// Returns a preview of the recommended actions that match your Automation rule's configuration
        /// and criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRulePreview service method.</param>
        /// 
        /// <returns>The response from the ListAutomationRulePreview service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationRulePreview">REST API Reference for ListAutomationRulePreview Operation</seealso>
        public virtual ListAutomationRulePreviewResponse ListAutomationRulePreview(ListAutomationRulePreviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationRulePreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationRulePreviewResponseUnmarshaller.Instance;

            return Invoke<ListAutomationRulePreviewResponse>(request, options);
        }


        /// <summary>
        /// Returns a preview of the recommended actions that match your Automation rule's configuration
        /// and criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRulePreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomationRulePreview service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationRulePreview">REST API Reference for ListAutomationRulePreview Operation</seealso>
        public virtual Task<ListAutomationRulePreviewResponse> ListAutomationRulePreviewAsync(ListAutomationRulePreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationRulePreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationRulePreviewResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAutomationRulePreviewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAutomationRulePreviewSummaries


        /// <summary>
        /// Returns a summary of the recommended actions that match your rule preview configuration
        /// and criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRulePreviewSummaries service method.</param>
        /// 
        /// <returns>The response from the ListAutomationRulePreviewSummaries service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationRulePreviewSummaries">REST API Reference for ListAutomationRulePreviewSummaries Operation</seealso>
        public virtual ListAutomationRulePreviewSummariesResponse ListAutomationRulePreviewSummaries(ListAutomationRulePreviewSummariesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationRulePreviewSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationRulePreviewSummariesResponseUnmarshaller.Instance;

            return Invoke<ListAutomationRulePreviewSummariesResponse>(request, options);
        }


        /// <summary>
        /// Returns a summary of the recommended actions that match your rule preview configuration
        /// and criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRulePreviewSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomationRulePreviewSummaries service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationRulePreviewSummaries">REST API Reference for ListAutomationRulePreviewSummaries Operation</seealso>
        public virtual Task<ListAutomationRulePreviewSummariesResponse> ListAutomationRulePreviewSummariesAsync(ListAutomationRulePreviewSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationRulePreviewSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationRulePreviewSummariesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAutomationRulePreviewSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAutomationRules


        /// <summary>
        /// Lists the automation rules that match specified filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRules service method.</param>
        /// 
        /// <returns>The response from the ListAutomationRules service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationRules">REST API Reference for ListAutomationRules Operation</seealso>
        public virtual ListAutomationRulesResponse ListAutomationRules(ListAutomationRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationRulesResponseUnmarshaller.Instance;

            return Invoke<ListAutomationRulesResponse>(request, options);
        }


        /// <summary>
        /// Lists the automation rules that match specified filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomationRules service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationRules">REST API Reference for ListAutomationRules Operation</seealso>
        public virtual Task<ListAutomationRulesResponse> ListAutomationRulesAsync(ListAutomationRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomationRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAutomationRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecommendedActions


        /// <summary>
        /// Lists the recommended actions based that match specified filters. 
        /// 
        ///  <note> 
        /// <para>
        /// Management accounts and delegated administrators can retrieve recommended actions
        /// that include associated member accounts. You can associate a member account using
        /// <c>AssociateAccounts</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendedActions service method.</param>
        /// 
        /// <returns>The response from the ListRecommendedActions service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListRecommendedActions">REST API Reference for ListRecommendedActions Operation</seealso>
        public virtual ListRecommendedActionsResponse ListRecommendedActions(ListRecommendedActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendedActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendedActionsResponseUnmarshaller.Instance;

            return Invoke<ListRecommendedActionsResponse>(request, options);
        }


        /// <summary>
        /// Lists the recommended actions based that match specified filters. 
        /// 
        ///  <note> 
        /// <para>
        /// Management accounts and delegated administrators can retrieve recommended actions
        /// that include associated member accounts. You can associate a member account using
        /// <c>AssociateAccounts</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendedActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendedActions service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListRecommendedActions">REST API Reference for ListRecommendedActions Operation</seealso>
        public virtual Task<ListRecommendedActionsResponse> ListRecommendedActionsAsync(ListRecommendedActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendedActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendedActionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRecommendedActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecommendedActionSummaries


        /// <summary>
        /// Provides a summary of recommended actions based on specified filters. 
        /// 
        ///  <note> 
        /// <para>
        /// Management accounts and delegated administrators can retrieve recommended actions
        /// that include associated member accounts. You can associate a member account using
        /// <c>AssociateAccounts</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendedActionSummaries service method.</param>
        /// 
        /// <returns>The response from the ListRecommendedActionSummaries service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListRecommendedActionSummaries">REST API Reference for ListRecommendedActionSummaries Operation</seealso>
        public virtual ListRecommendedActionSummariesResponse ListRecommendedActionSummaries(ListRecommendedActionSummariesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendedActionSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendedActionSummariesResponseUnmarshaller.Instance;

            return Invoke<ListRecommendedActionSummariesResponse>(request, options);
        }


        /// <summary>
        /// Provides a summary of recommended actions based on specified filters. 
        /// 
        ///  <note> 
        /// <para>
        /// Management accounts and delegated administrators can retrieve recommended actions
        /// that include associated member accounts. You can associate a member account using
        /// <c>AssociateAccounts</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendedActionSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendedActionSummaries service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListRecommendedActionSummaries">REST API Reference for ListRecommendedActionSummaries Operation</seealso>
        public virtual Task<ListRecommendedActionSummariesResponse> ListRecommendedActionSummariesAsync(ListRecommendedActionSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendedActionSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendedActionSummariesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRecommendedActionSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RollbackAutomationEvent


        /// <summary>
        /// Initiates a rollback for a completed automation event. 
        /// 
        ///  <note> 
        /// <para>
        /// Management accounts and delegated administrators can only initiate a rollback for
        /// events belonging to associated member accounts. You can associate a member account
        /// using <c>AssociateAccounts</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RollbackAutomationEvent service method.</param>
        /// 
        /// <returns>The response from the RollbackAutomationEvent service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/RollbackAutomationEvent">REST API Reference for RollbackAutomationEvent Operation</seealso>
        public virtual RollbackAutomationEventResponse RollbackAutomationEvent(RollbackAutomationEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RollbackAutomationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RollbackAutomationEventResponseUnmarshaller.Instance;

            return Invoke<RollbackAutomationEventResponse>(request, options);
        }


        /// <summary>
        /// Initiates a rollback for a completed automation event. 
        /// 
        ///  <note> 
        /// <para>
        /// Management accounts and delegated administrators can only initiate a rollback for
        /// events belonging to associated member accounts. You can associate a member account
        /// using <c>AssociateAccounts</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RollbackAutomationEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RollbackAutomationEvent service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/RollbackAutomationEvent">REST API Reference for RollbackAutomationEvent Operation</seealso>
        public virtual Task<RollbackAutomationEventResponse> RollbackAutomationEventAsync(RollbackAutomationEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RollbackAutomationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RollbackAutomationEventResponseUnmarshaller.Instance;
            
            return InvokeAsync<RollbackAutomationEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartAutomationEvent


        /// <summary>
        /// Initiates a one-time, on-demand automation for the specified recommended action.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// Management accounts and delegated administrators can only initiate recommended actions
        /// for associated member accounts. You can associate a member account using <c>AssociateAccounts</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutomationEvent service method.</param>
        /// 
        /// <returns>The response from the StartAutomationEvent service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceQuotaExceededException">
        /// The request would exceed service quotas.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/StartAutomationEvent">REST API Reference for StartAutomationEvent Operation</seealso>
        public virtual StartAutomationEventResponse StartAutomationEvent(StartAutomationEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAutomationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutomationEventResponseUnmarshaller.Instance;

            return Invoke<StartAutomationEventResponse>(request, options);
        }


        /// <summary>
        /// Initiates a one-time, on-demand automation for the specified recommended action.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// Management accounts and delegated administrators can only initiate recommended actions
        /// for associated member accounts. You can associate a member account using <c>AssociateAccounts</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutomationEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAutomationEvent service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceQuotaExceededException">
        /// The request would exceed service quotas.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/StartAutomationEvent">REST API Reference for StartAutomationEvent Operation</seealso>
        public virtual Task<StartAutomationEventResponse> StartAutomationEventAsync(StartAutomationEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAutomationEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutomationEventResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartAutomationEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAutomationRule


        /// <summary>
        /// Updates an existing automation rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomationRule service method.</param>
        /// 
        /// <returns>The response from the UpdateAutomationRule service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/UpdateAutomationRule">REST API Reference for UpdateAutomationRule Operation</seealso>
        public virtual UpdateAutomationRuleResponse UpdateAutomationRule(UpdateAutomationRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomationRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateAutomationRuleResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing automation rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAutomationRule service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/UpdateAutomationRule">REST API Reference for UpdateAutomationRule Operation</seealso>
        public virtual Task<UpdateAutomationRuleResponse> UpdateAutomationRuleAsync(UpdateAutomationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomationRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomationRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAutomationRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnrollmentConfiguration


        /// <summary>
        /// Updates your account’s Compute Optimizer Automation enrollment configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnrollmentConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateEnrollmentConfiguration service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.NotManagementAccountException">
        /// The operation can only be performed by a management account.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/UpdateEnrollmentConfiguration">REST API Reference for UpdateEnrollmentConfiguration Operation</seealso>
        public virtual UpdateEnrollmentConfigurationResponse UpdateEnrollmentConfiguration(UpdateEnrollmentConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnrollmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnrollmentConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateEnrollmentConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates your account’s Compute Optimizer Automation enrollment configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnrollmentConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnrollmentConfiguration service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.NotManagementAccountException">
        /// The operation can only be performed by a management account.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/UpdateEnrollmentConfiguration">REST API Reference for UpdateEnrollmentConfiguration Operation</seealso>
        public virtual Task<UpdateEnrollmentConfigurationResponse> UpdateEnrollmentConfigurationAsync(UpdateEnrollmentConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnrollmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnrollmentConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEnrollmentConfigurationResponse>(request, options, cancellationToken);
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
            var resolver = new AmazonComputeOptimizerAutomationEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}