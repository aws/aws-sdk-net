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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.BCMPricingCalculator.Model;
using Amazon.BCMPricingCalculator.Model.Internal.MarshallTransformations;
using Amazon.BCMPricingCalculator.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.BCMPricingCalculator
{
    /// <summary>
    /// <para>Implementation for accessing BCMPricingCalculator</para>
    ///
    /// You can use the Pricing Calculator API to programmatically create estimates for your
    /// planned cloud use. You can model usage and commitments such as Savings Plans and Reserved
    /// Instances, and generate estimated costs using your discounts and benefit sharing preferences.
    /// 
    /// 
    ///  
    /// <para>
    /// The Pricing Calculator API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>https://bcm-pricing-calculator.us-east-1.api.aws</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonBCMPricingCalculatorClient : AmazonServiceClient, IAmazonBCMPricingCalculator
    {
        private static IServiceMetadata serviceMetadata = new AmazonBCMPricingCalculatorMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonBCMPricingCalculatorClient with the credentials loaded from the application's
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
        public AmazonBCMPricingCalculatorClient()
            : base(new AmazonBCMPricingCalculatorConfig()) { }

        /// <summary>
        /// Constructs AmazonBCMPricingCalculatorClient with the credentials loaded from the application's
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
        public AmazonBCMPricingCalculatorClient(RegionEndpoint region)
            : base(new AmazonBCMPricingCalculatorConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBCMPricingCalculatorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBCMPricingCalculatorClient Configuration Object</param>
        public AmazonBCMPricingCalculatorClient(AmazonBCMPricingCalculatorConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonBCMPricingCalculatorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBCMPricingCalculatorClient(AWSCredentials credentials)
            : this(credentials, new AmazonBCMPricingCalculatorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBCMPricingCalculatorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBCMPricingCalculatorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBCMPricingCalculatorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBCMPricingCalculatorClient with AWS Credentials and an
        /// AmazonBCMPricingCalculatorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBCMPricingCalculatorClient Configuration Object</param>
        public AmazonBCMPricingCalculatorClient(AWSCredentials credentials, AmazonBCMPricingCalculatorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBCMPricingCalculatorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBCMPricingCalculatorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBCMPricingCalculatorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBCMPricingCalculatorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBCMPricingCalculatorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBCMPricingCalculatorConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBCMPricingCalculatorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBCMPricingCalculatorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBCMPricingCalculatorClient Configuration Object</param>
        public AmazonBCMPricingCalculatorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBCMPricingCalculatorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBCMPricingCalculatorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBCMPricingCalculatorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBCMPricingCalculatorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBCMPricingCalculatorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBCMPricingCalculatorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBCMPricingCalculatorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBCMPricingCalculatorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBCMPricingCalculatorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBCMPricingCalculatorClient Configuration Object</param>
        public AmazonBCMPricingCalculatorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBCMPricingCalculatorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IBCMPricingCalculatorPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBCMPricingCalculatorPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BCMPricingCalculatorPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBCMPricingCalculatorEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBCMPricingCalculatorAuthSchemeHandler());
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


        #region  BatchCreateBillScenarioCommitmentModification

        internal virtual BatchCreateBillScenarioCommitmentModificationResponse BatchCreateBillScenarioCommitmentModification(BatchCreateBillScenarioCommitmentModificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateBillScenarioCommitmentModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateBillScenarioCommitmentModificationResponseUnmarshaller.Instance;

            return Invoke<BatchCreateBillScenarioCommitmentModificationResponse>(request, options);
        }



        /// <summary>
        /// Create Compute Savings Plans, EC2 Instance Savings Plans, or EC2 Reserved Instances
        /// commitments that you want to model in a Bill Scenario. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchCreateBillScenarioCommitmentModification</c> operation doesn't have its
        /// own IAM permission. To authorize this operation for Amazon Web Services principals,
        /// include the permission <c>bcm-pricing-calculator:CreateBillScenarioCommitmentModification</c>
        /// in your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateBillScenarioCommitmentModification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateBillScenarioCommitmentModification service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateBillScenarioCommitmentModification">REST API Reference for BatchCreateBillScenarioCommitmentModification Operation</seealso>
        public virtual Task<BatchCreateBillScenarioCommitmentModificationResponse> BatchCreateBillScenarioCommitmentModificationAsync(BatchCreateBillScenarioCommitmentModificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateBillScenarioCommitmentModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateBillScenarioCommitmentModificationResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCreateBillScenarioCommitmentModificationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchCreateBillScenarioUsageModification

        internal virtual BatchCreateBillScenarioUsageModificationResponse BatchCreateBillScenarioUsageModification(BatchCreateBillScenarioUsageModificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateBillScenarioUsageModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateBillScenarioUsageModificationResponseUnmarshaller.Instance;

            return Invoke<BatchCreateBillScenarioUsageModificationResponse>(request, options);
        }



        /// <summary>
        /// Create Amazon Web Services service usage that you want to model in a Bill Scenario.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchCreateBillScenarioUsageModification</c> operation doesn't have its own
        /// IAM permission. To authorize this operation for Amazon Web Services principals, include
        /// the permission <c>bcm-pricing-calculator:CreateBillScenarioUsageModification</c> in
        /// your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateBillScenarioUsageModification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateBillScenarioUsageModification service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateBillScenarioUsageModification">REST API Reference for BatchCreateBillScenarioUsageModification Operation</seealso>
        public virtual Task<BatchCreateBillScenarioUsageModificationResponse> BatchCreateBillScenarioUsageModificationAsync(BatchCreateBillScenarioUsageModificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateBillScenarioUsageModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateBillScenarioUsageModificationResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCreateBillScenarioUsageModificationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchCreateWorkloadEstimateUsage

        internal virtual BatchCreateWorkloadEstimateUsageResponse BatchCreateWorkloadEstimateUsage(BatchCreateWorkloadEstimateUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return Invoke<BatchCreateWorkloadEstimateUsageResponse>(request, options);
        }



        /// <summary>
        /// Create Amazon Web Services service usage that you want to model in a Workload Estimate.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchCreateWorkloadEstimateUsage</c> operation doesn't have its own IAM permission.
        /// To authorize this operation for Amazon Web Services principals, include the permission
        /// <c>bcm-pricing-calculator:CreateWorkloadEstimateUsage</c> in your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateWorkloadEstimateUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateWorkloadEstimateUsage service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateWorkloadEstimateUsage">REST API Reference for BatchCreateWorkloadEstimateUsage Operation</seealso>
        public virtual Task<BatchCreateWorkloadEstimateUsageResponse> BatchCreateWorkloadEstimateUsageAsync(BatchCreateWorkloadEstimateUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCreateWorkloadEstimateUsageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeleteBillScenarioCommitmentModification

        internal virtual BatchDeleteBillScenarioCommitmentModificationResponse BatchDeleteBillScenarioCommitmentModification(BatchDeleteBillScenarioCommitmentModificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteBillScenarioCommitmentModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteBillScenarioCommitmentModificationResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteBillScenarioCommitmentModificationResponse>(request, options);
        }



        /// <summary>
        /// Delete commitment that you have created in a Bill Scenario. You can only delete a
        /// commitment that you had added and cannot model deletion (or removal) of a existing
        /// commitment. If you want model deletion of an existing commitment, see the negate <a
        /// href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BillScenarioCommitmentModificationAction.html">
        /// BillScenarioCommitmentModificationAction</a> of <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BatchCreateBillScenarioUsageModification.html">
        /// BatchCreateBillScenarioCommitmentModification</a> operation. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchDeleteBillScenarioCommitmentModification</c> operation doesn't have its
        /// own IAM permission. To authorize this operation for Amazon Web Services principals,
        /// include the permission <c>bcm-pricing-calculator:DeleteBillScenarioCommitmentModification</c>
        /// in your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBillScenarioCommitmentModification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteBillScenarioCommitmentModification service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioCommitmentModification">REST API Reference for BatchDeleteBillScenarioCommitmentModification Operation</seealso>
        public virtual Task<BatchDeleteBillScenarioCommitmentModificationResponse> BatchDeleteBillScenarioCommitmentModificationAsync(BatchDeleteBillScenarioCommitmentModificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteBillScenarioCommitmentModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteBillScenarioCommitmentModificationResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteBillScenarioCommitmentModificationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeleteBillScenarioUsageModification

        internal virtual BatchDeleteBillScenarioUsageModificationResponse BatchDeleteBillScenarioUsageModification(BatchDeleteBillScenarioUsageModificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteBillScenarioUsageModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteBillScenarioUsageModificationResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteBillScenarioUsageModificationResponse>(request, options);
        }



        /// <summary>
        /// Delete usage that you have created in a Bill Scenario. You can only delete usage
        /// that you had added and cannot model deletion (or removal) of a existing usage. If
        /// you want model removal of an existing usage, see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BatchUpdateBillScenarioUsageModification.html">
        /// BatchUpdateBillScenarioUsageModification</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchDeleteBillScenarioUsageModification</c> operation doesn't have its own
        /// IAM permission. To authorize this operation for Amazon Web Services principals, include
        /// the permission <c>bcm-pricing-calculator:DeleteBillScenarioUsageModification</c> in
        /// your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBillScenarioUsageModification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteBillScenarioUsageModification service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioUsageModification">REST API Reference for BatchDeleteBillScenarioUsageModification Operation</seealso>
        public virtual Task<BatchDeleteBillScenarioUsageModificationResponse> BatchDeleteBillScenarioUsageModificationAsync(BatchDeleteBillScenarioUsageModificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteBillScenarioUsageModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteBillScenarioUsageModificationResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteBillScenarioUsageModificationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeleteWorkloadEstimateUsage

        internal virtual BatchDeleteWorkloadEstimateUsageResponse BatchDeleteWorkloadEstimateUsage(BatchDeleteWorkloadEstimateUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteWorkloadEstimateUsageResponse>(request, options);
        }



        /// <summary>
        /// Delete usage that you have created in a Workload estimate. You can only delete usage
        /// that you had added and cannot model deletion (or removal) of a existing usage. If
        /// you want model removal of an existing usage, see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BatchUpdateWorkloadEstimateUsage.html">
        /// BatchUpdateWorkloadEstimateUsage</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchDeleteWorkloadEstimateUsage</c> operation doesn't have its own IAM permission.
        /// To authorize this operation for Amazon Web Services principals, include the permission
        /// <c>bcm-pricing-calculator:DeleteWorkloadEstimateUsage</c> in your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteWorkloadEstimateUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteWorkloadEstimateUsage service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteWorkloadEstimateUsage">REST API Reference for BatchDeleteWorkloadEstimateUsage Operation</seealso>
        public virtual Task<BatchDeleteWorkloadEstimateUsageResponse> BatchDeleteWorkloadEstimateUsageAsync(BatchDeleteWorkloadEstimateUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteWorkloadEstimateUsageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchUpdateBillScenarioCommitmentModification

        internal virtual BatchUpdateBillScenarioCommitmentModificationResponse BatchUpdateBillScenarioCommitmentModification(BatchUpdateBillScenarioCommitmentModificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateBillScenarioCommitmentModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateBillScenarioCommitmentModificationResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateBillScenarioCommitmentModificationResponse>(request, options);
        }



        /// <summary>
        /// Update a newly added or existing commitment. You can update the commitment group
        /// based on a commitment ID and a Bill scenario ID. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchUpdateBillScenarioCommitmentModification</c> operation doesn't have its
        /// own IAM permission. To authorize this operation for Amazon Web Services principals,
        /// include the permission <c>bcm-pricing-calculator:UpdateBillScenarioCommitmentModification</c>
        /// in your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateBillScenarioCommitmentModification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateBillScenarioCommitmentModification service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioCommitmentModification">REST API Reference for BatchUpdateBillScenarioCommitmentModification Operation</seealso>
        public virtual Task<BatchUpdateBillScenarioCommitmentModificationResponse> BatchUpdateBillScenarioCommitmentModificationAsync(BatchUpdateBillScenarioCommitmentModificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateBillScenarioCommitmentModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateBillScenarioCommitmentModificationResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUpdateBillScenarioCommitmentModificationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchUpdateBillScenarioUsageModification

        internal virtual BatchUpdateBillScenarioUsageModificationResponse BatchUpdateBillScenarioUsageModification(BatchUpdateBillScenarioUsageModificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateBillScenarioUsageModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateBillScenarioUsageModificationResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateBillScenarioUsageModificationResponse>(request, options);
        }



        /// <summary>
        /// Update a newly added or existing usage lines. You can update the usage amounts, usage
        /// hour, and usage group based on a usage ID and a Bill scenario ID. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchUpdateBillScenarioUsageModification</c> operation doesn't have its own
        /// IAM permission. To authorize this operation for Amazon Web Services principals, include
        /// the permission <c>bcm-pricing-calculator:UpdateBillScenarioUsageModification</c> in
        /// your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateBillScenarioUsageModification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateBillScenarioUsageModification service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioUsageModification">REST API Reference for BatchUpdateBillScenarioUsageModification Operation</seealso>
        public virtual Task<BatchUpdateBillScenarioUsageModificationResponse> BatchUpdateBillScenarioUsageModificationAsync(BatchUpdateBillScenarioUsageModificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateBillScenarioUsageModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateBillScenarioUsageModificationResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUpdateBillScenarioUsageModificationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchUpdateWorkloadEstimateUsage

        internal virtual BatchUpdateWorkloadEstimateUsageResponse BatchUpdateWorkloadEstimateUsage(BatchUpdateWorkloadEstimateUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateWorkloadEstimateUsageResponse>(request, options);
        }



        /// <summary>
        /// Update a newly added or existing usage lines. You can update the usage amounts and
        /// usage group based on a usage ID and a Workload estimate ID. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchUpdateWorkloadEstimateUsage</c> operation doesn't have its own IAM permission.
        /// To authorize this operation for Amazon Web Services principals, include the permission
        /// <c>bcm-pricing-calculator:UpdateWorkloadEstimateUsage</c> in your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateWorkloadEstimateUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateWorkloadEstimateUsage service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateWorkloadEstimateUsage">REST API Reference for BatchUpdateWorkloadEstimateUsage Operation</seealso>
        public virtual Task<BatchUpdateWorkloadEstimateUsageResponse> BatchUpdateWorkloadEstimateUsageAsync(BatchUpdateWorkloadEstimateUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUpdateWorkloadEstimateUsageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateBillEstimate

        internal virtual CreateBillEstimateResponse CreateBillEstimate(CreateBillEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillEstimateResponseUnmarshaller.Instance;

            return Invoke<CreateBillEstimateResponse>(request, options);
        }



        /// <summary>
        /// Create a Bill estimate from a Bill scenario. In the Bill scenario you can model usage
        /// addition, usage changes, and usage removal. You can also model commitment addition
        /// and commitment removal. After all changes in a Bill scenario is made satisfactorily,
        /// you can call this API with a Bill scenario ID to generate the Bill estimate. Bill
        /// estimate calculates the pre-tax cost for your consolidated billing family, incorporating
        /// all modeled usage and commitments alongside existing usage and commitments from your
        /// most recent completed anniversary bill, with any applicable discounts applied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBillEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateBillEstimate">REST API Reference for CreateBillEstimate Operation</seealso>
        public virtual Task<CreateBillEstimateResponse> CreateBillEstimateAsync(CreateBillEstimateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillEstimateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBillEstimateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateBillScenario

        internal virtual CreateBillScenarioResponse CreateBillScenario(CreateBillScenarioRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillScenarioResponseUnmarshaller.Instance;

            return Invoke<CreateBillScenarioResponse>(request, options);
        }



        /// <summary>
        /// Creates a new bill scenario to model potential changes to Amazon Web Services usage
        /// and costs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillScenario service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBillScenario service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateBillScenario">REST API Reference for CreateBillScenario Operation</seealso>
        public virtual Task<CreateBillScenarioResponse> CreateBillScenarioAsync(CreateBillScenarioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillScenarioResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBillScenarioResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWorkloadEstimate

        internal virtual CreateWorkloadEstimateResponse CreateWorkloadEstimate(CreateWorkloadEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkloadEstimateResponseUnmarshaller.Instance;

            return Invoke<CreateWorkloadEstimateResponse>(request, options);
        }



        /// <summary>
        /// Creates a new workload estimate to model costs for a specific workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkloadEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateWorkloadEstimate">REST API Reference for CreateWorkloadEstimate Operation</seealso>
        public virtual Task<CreateWorkloadEstimateResponse> CreateWorkloadEstimateAsync(CreateWorkloadEstimateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkloadEstimateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkloadEstimateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteBillEstimate

        internal virtual DeleteBillEstimateResponse DeleteBillEstimate(DeleteBillEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillEstimateResponseUnmarshaller.Instance;

            return Invoke<DeleteBillEstimateResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBillEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteBillEstimate">REST API Reference for DeleteBillEstimate Operation</seealso>
        public virtual Task<DeleteBillEstimateResponse> DeleteBillEstimateAsync(DeleteBillEstimateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillEstimateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBillEstimateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteBillScenario

        internal virtual DeleteBillScenarioResponse DeleteBillScenario(DeleteBillScenarioRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillScenarioResponseUnmarshaller.Instance;

            return Invoke<DeleteBillScenarioResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillScenario service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBillScenario service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteBillScenario">REST API Reference for DeleteBillScenario Operation</seealso>
        public virtual Task<DeleteBillScenarioResponse> DeleteBillScenarioAsync(DeleteBillScenarioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillScenarioResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBillScenarioResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWorkloadEstimate

        internal virtual DeleteWorkloadEstimateResponse DeleteWorkloadEstimate(DeleteWorkloadEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkloadEstimateResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkloadEstimateResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkloadEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteWorkloadEstimate">REST API Reference for DeleteWorkloadEstimate Operation</seealso>
        public virtual Task<DeleteWorkloadEstimateResponse> DeleteWorkloadEstimateAsync(DeleteWorkloadEstimateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkloadEstimateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkloadEstimateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetBillEstimate

        internal virtual GetBillEstimateResponse GetBillEstimate(GetBillEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillEstimateResponseUnmarshaller.Instance;

            return Invoke<GetBillEstimateResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details of a specific bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBillEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetBillEstimate">REST API Reference for GetBillEstimate Operation</seealso>
        public virtual Task<GetBillEstimateResponse> GetBillEstimateAsync(GetBillEstimateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillEstimateResponseUnmarshaller.Instance;

            return InvokeAsync<GetBillEstimateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetBillScenario

        internal virtual GetBillScenarioResponse GetBillScenario(GetBillScenarioRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillScenarioResponseUnmarshaller.Instance;

            return Invoke<GetBillScenarioResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details of a specific bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillScenario service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBillScenario service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetBillScenario">REST API Reference for GetBillScenario Operation</seealso>
        public virtual Task<GetBillScenarioResponse> GetBillScenarioAsync(GetBillScenarioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillScenarioResponseUnmarshaller.Instance;

            return InvokeAsync<GetBillScenarioResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPreferences

        internal virtual GetPreferencesResponse GetPreferences(GetPreferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPreferencesResponseUnmarshaller.Instance;

            return Invoke<GetPreferencesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current preferences for Pricing Calculator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPreferences service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetPreferences">REST API Reference for GetPreferences Operation</seealso>
        public virtual Task<GetPreferencesResponse> GetPreferencesAsync(GetPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPreferencesResponseUnmarshaller.Instance;

            return InvokeAsync<GetPreferencesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorkloadEstimate

        internal virtual GetWorkloadEstimateResponse GetWorkloadEstimate(GetWorkloadEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadEstimateResponseUnmarshaller.Instance;

            return Invoke<GetWorkloadEstimateResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details of a specific workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkloadEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetWorkloadEstimate">REST API Reference for GetWorkloadEstimate Operation</seealso>
        public virtual Task<GetWorkloadEstimateResponse> GetWorkloadEstimateAsync(GetWorkloadEstimateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadEstimateResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkloadEstimateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBillEstimateCommitments

        internal virtual ListBillEstimateCommitmentsResponse ListBillEstimateCommitments(ListBillEstimateCommitmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateCommitmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateCommitmentsResponseUnmarshaller.Instance;

            return Invoke<ListBillEstimateCommitmentsResponse>(request, options);
        }



        /// <summary>
        /// Lists the commitments associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateCommitments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBillEstimateCommitments service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateCommitments">REST API Reference for ListBillEstimateCommitments Operation</seealso>
        public virtual Task<ListBillEstimateCommitmentsResponse> ListBillEstimateCommitmentsAsync(ListBillEstimateCommitmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateCommitmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateCommitmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBillEstimateCommitmentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBillEstimateInputCommitmentModifications

        internal virtual ListBillEstimateInputCommitmentModificationsResponse ListBillEstimateInputCommitmentModifications(ListBillEstimateInputCommitmentModificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateInputCommitmentModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateInputCommitmentModificationsResponseUnmarshaller.Instance;

            return Invoke<ListBillEstimateInputCommitmentModificationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the input commitment modifications associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateInputCommitmentModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBillEstimateInputCommitmentModifications service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateInputCommitmentModifications">REST API Reference for ListBillEstimateInputCommitmentModifications Operation</seealso>
        public virtual Task<ListBillEstimateInputCommitmentModificationsResponse> ListBillEstimateInputCommitmentModificationsAsync(ListBillEstimateInputCommitmentModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateInputCommitmentModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateInputCommitmentModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBillEstimateInputCommitmentModificationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBillEstimateInputUsageModifications

        internal virtual ListBillEstimateInputUsageModificationsResponse ListBillEstimateInputUsageModifications(ListBillEstimateInputUsageModificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateInputUsageModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateInputUsageModificationsResponseUnmarshaller.Instance;

            return Invoke<ListBillEstimateInputUsageModificationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the input usage modifications associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateInputUsageModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBillEstimateInputUsageModifications service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateInputUsageModifications">REST API Reference for ListBillEstimateInputUsageModifications Operation</seealso>
        public virtual Task<ListBillEstimateInputUsageModificationsResponse> ListBillEstimateInputUsageModificationsAsync(ListBillEstimateInputUsageModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateInputUsageModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateInputUsageModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBillEstimateInputUsageModificationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBillEstimateLineItems

        internal virtual ListBillEstimateLineItemsResponse ListBillEstimateLineItems(ListBillEstimateLineItemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateLineItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateLineItemsResponseUnmarshaller.Instance;

            return Invoke<ListBillEstimateLineItemsResponse>(request, options);
        }



        /// <summary>
        /// Lists the line items associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateLineItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBillEstimateLineItems service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateLineItems">REST API Reference for ListBillEstimateLineItems Operation</seealso>
        public virtual Task<ListBillEstimateLineItemsResponse> ListBillEstimateLineItemsAsync(ListBillEstimateLineItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateLineItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateLineItemsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBillEstimateLineItemsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBillEstimates

        internal virtual ListBillEstimatesResponse ListBillEstimates(ListBillEstimatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimatesResponseUnmarshaller.Instance;

            return Invoke<ListBillEstimatesResponse>(request, options);
        }



        /// <summary>
        /// Lists all bill estimates for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBillEstimates service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimates">REST API Reference for ListBillEstimates Operation</seealso>
        public virtual Task<ListBillEstimatesResponse> ListBillEstimatesAsync(ListBillEstimatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListBillEstimatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBillScenarioCommitmentModifications

        internal virtual ListBillScenarioCommitmentModificationsResponse ListBillScenarioCommitmentModifications(ListBillScenarioCommitmentModificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillScenarioCommitmentModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillScenarioCommitmentModificationsResponseUnmarshaller.Instance;

            return Invoke<ListBillScenarioCommitmentModificationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the commitment modifications associated with a bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarioCommitmentModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBillScenarioCommitmentModifications service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarioCommitmentModifications">REST API Reference for ListBillScenarioCommitmentModifications Operation</seealso>
        public virtual Task<ListBillScenarioCommitmentModificationsResponse> ListBillScenarioCommitmentModificationsAsync(ListBillScenarioCommitmentModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillScenarioCommitmentModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillScenarioCommitmentModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBillScenarioCommitmentModificationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBillScenarios

        internal virtual ListBillScenariosResponse ListBillScenarios(ListBillScenariosRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillScenariosRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillScenariosResponseUnmarshaller.Instance;

            return Invoke<ListBillScenariosResponse>(request, options);
        }



        /// <summary>
        /// Lists all bill scenarios for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarios service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBillScenarios service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarios">REST API Reference for ListBillScenarios Operation</seealso>
        public virtual Task<ListBillScenariosResponse> ListBillScenariosAsync(ListBillScenariosRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillScenariosRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillScenariosResponseUnmarshaller.Instance;

            return InvokeAsync<ListBillScenariosResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBillScenarioUsageModifications

        internal virtual ListBillScenarioUsageModificationsResponse ListBillScenarioUsageModifications(ListBillScenarioUsageModificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillScenarioUsageModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillScenarioUsageModificationsResponseUnmarshaller.Instance;

            return Invoke<ListBillScenarioUsageModificationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the usage modifications associated with a bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarioUsageModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBillScenarioUsageModifications service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarioUsageModifications">REST API Reference for ListBillScenarioUsageModifications Operation</seealso>
        public virtual Task<ListBillScenarioUsageModificationsResponse> ListBillScenarioUsageModificationsAsync(ListBillScenarioUsageModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillScenarioUsageModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillScenarioUsageModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBillScenarioUsageModificationsResponse>(request, options, cancellationToken);
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
        /// Lists all tags associated with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorkloadEstimates

        internal virtual ListWorkloadEstimatesResponse ListWorkloadEstimates(ListWorkloadEstimatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadEstimatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadEstimatesResponseUnmarshaller.Instance;

            return Invoke<ListWorkloadEstimatesResponse>(request, options);
        }



        /// <summary>
        /// Lists all workload estimates for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadEstimates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkloadEstimates service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListWorkloadEstimates">REST API Reference for ListWorkloadEstimates Operation</seealso>
        public virtual Task<ListWorkloadEstimatesResponse> ListWorkloadEstimatesAsync(ListWorkloadEstimatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadEstimatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadEstimatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkloadEstimatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorkloadEstimateUsage

        internal virtual ListWorkloadEstimateUsageResponse ListWorkloadEstimateUsage(ListWorkloadEstimateUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return Invoke<ListWorkloadEstimateUsageResponse>(request, options);
        }



        /// <summary>
        /// Lists the usage associated with a workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadEstimateUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkloadEstimateUsage service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListWorkloadEstimateUsage">REST API Reference for ListWorkloadEstimateUsage Operation</seealso>
        public virtual Task<ListWorkloadEstimateUsageResponse> ListWorkloadEstimateUsageAsync(ListWorkloadEstimateUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkloadEstimateUsageResponse>(request, options, cancellationToken);
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
        /// Adds one or more tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBillEstimate

        internal virtual UpdateBillEstimateResponse UpdateBillEstimate(UpdateBillEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillEstimateResponseUnmarshaller.Instance;

            return Invoke<UpdateBillEstimateResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBillEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateBillEstimate">REST API Reference for UpdateBillEstimate Operation</seealso>
        public virtual Task<UpdateBillEstimateResponse> UpdateBillEstimateAsync(UpdateBillEstimateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillEstimateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBillEstimateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBillScenario

        internal virtual UpdateBillScenarioResponse UpdateBillScenario(UpdateBillScenarioRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillScenarioResponseUnmarshaller.Instance;

            return Invoke<UpdateBillScenarioResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillScenario service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBillScenario service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateBillScenario">REST API Reference for UpdateBillScenario Operation</seealso>
        public virtual Task<UpdateBillScenarioResponse> UpdateBillScenarioAsync(UpdateBillScenarioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillScenarioResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBillScenarioResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePreferences

        internal virtual UpdatePreferencesResponse UpdatePreferences(UpdatePreferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePreferencesResponseUnmarshaller.Instance;

            return Invoke<UpdatePreferencesResponse>(request, options);
        }



        /// <summary>
        /// Updates the preferences for Pricing Calculator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePreferences service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdatePreferences">REST API Reference for UpdatePreferences Operation</seealso>
        public virtual Task<UpdatePreferencesResponse> UpdatePreferencesAsync(UpdatePreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePreferencesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePreferencesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateWorkloadEstimate

        internal virtual UpdateWorkloadEstimateResponse UpdateWorkloadEstimate(UpdateWorkloadEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkloadEstimateResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkloadEstimateResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkloadEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateWorkloadEstimate">REST API Reference for UpdateWorkloadEstimate Operation</seealso>
        public virtual Task<UpdateWorkloadEstimateResponse> UpdateWorkloadEstimateAsync(UpdateWorkloadEstimateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkloadEstimateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkloadEstimateResponse>(request, options, cancellationToken);
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