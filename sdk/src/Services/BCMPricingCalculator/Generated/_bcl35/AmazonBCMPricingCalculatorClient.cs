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
using System.Collections.Generic;
using System.Net;

using Amazon.BCMPricingCalculator.Model;
using Amazon.BCMPricingCalculator.Model.Internal.MarshallTransformations;
using Amazon.BCMPricingCalculator.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBCMPricingCalculatorConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBCMPricingCalculatorConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBCMPricingCalculatorEndpointResolver());
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
        public virtual BatchCreateBillScenarioCommitmentModificationResponse BatchCreateBillScenarioCommitmentModification(BatchCreateBillScenarioCommitmentModificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateBillScenarioCommitmentModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateBillScenarioCommitmentModificationResponseUnmarshaller.Instance;

            return Invoke<BatchCreateBillScenarioCommitmentModificationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateBillScenarioCommitmentModification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateBillScenarioCommitmentModification operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateBillScenarioCommitmentModification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateBillScenarioCommitmentModification">REST API Reference for BatchCreateBillScenarioCommitmentModification Operation</seealso>
        public virtual IAsyncResult BeginBatchCreateBillScenarioCommitmentModification(BatchCreateBillScenarioCommitmentModificationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateBillScenarioCommitmentModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateBillScenarioCommitmentModificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateBillScenarioCommitmentModification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateBillScenarioCommitmentModification.</param>
        /// 
        /// <returns>Returns a  BatchCreateBillScenarioCommitmentModificationResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateBillScenarioCommitmentModification">REST API Reference for BatchCreateBillScenarioCommitmentModification Operation</seealso>
        public virtual BatchCreateBillScenarioCommitmentModificationResponse EndBatchCreateBillScenarioCommitmentModification(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreateBillScenarioCommitmentModificationResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchCreateBillScenarioUsageModification

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
        public virtual BatchCreateBillScenarioUsageModificationResponse BatchCreateBillScenarioUsageModification(BatchCreateBillScenarioUsageModificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateBillScenarioUsageModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateBillScenarioUsageModificationResponseUnmarshaller.Instance;

            return Invoke<BatchCreateBillScenarioUsageModificationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateBillScenarioUsageModification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateBillScenarioUsageModification operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateBillScenarioUsageModification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateBillScenarioUsageModification">REST API Reference for BatchCreateBillScenarioUsageModification Operation</seealso>
        public virtual IAsyncResult BeginBatchCreateBillScenarioUsageModification(BatchCreateBillScenarioUsageModificationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateBillScenarioUsageModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateBillScenarioUsageModificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateBillScenarioUsageModification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateBillScenarioUsageModification.</param>
        /// 
        /// <returns>Returns a  BatchCreateBillScenarioUsageModificationResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateBillScenarioUsageModification">REST API Reference for BatchCreateBillScenarioUsageModification Operation</seealso>
        public virtual BatchCreateBillScenarioUsageModificationResponse EndBatchCreateBillScenarioUsageModification(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreateBillScenarioUsageModificationResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchCreateWorkloadEstimateUsage

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
        public virtual BatchCreateWorkloadEstimateUsageResponse BatchCreateWorkloadEstimateUsage(BatchCreateWorkloadEstimateUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return Invoke<BatchCreateWorkloadEstimateUsageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateWorkloadEstimateUsage operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateWorkloadEstimateUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateWorkloadEstimateUsage">REST API Reference for BatchCreateWorkloadEstimateUsage Operation</seealso>
        public virtual IAsyncResult BeginBatchCreateWorkloadEstimateUsage(BatchCreateWorkloadEstimateUsageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateWorkloadEstimateUsage.</param>
        /// 
        /// <returns>Returns a  BatchCreateWorkloadEstimateUsageResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateWorkloadEstimateUsage">REST API Reference for BatchCreateWorkloadEstimateUsage Operation</seealso>
        public virtual BatchCreateWorkloadEstimateUsageResponse EndBatchCreateWorkloadEstimateUsage(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreateWorkloadEstimateUsageResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteBillScenarioCommitmentModification

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
        public virtual BatchDeleteBillScenarioCommitmentModificationResponse BatchDeleteBillScenarioCommitmentModification(BatchDeleteBillScenarioCommitmentModificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteBillScenarioCommitmentModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteBillScenarioCommitmentModificationResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteBillScenarioCommitmentModificationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteBillScenarioCommitmentModification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBillScenarioCommitmentModification operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteBillScenarioCommitmentModification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioCommitmentModification">REST API Reference for BatchDeleteBillScenarioCommitmentModification Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteBillScenarioCommitmentModification(BatchDeleteBillScenarioCommitmentModificationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteBillScenarioCommitmentModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteBillScenarioCommitmentModificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteBillScenarioCommitmentModification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteBillScenarioCommitmentModification.</param>
        /// 
        /// <returns>Returns a  BatchDeleteBillScenarioCommitmentModificationResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioCommitmentModification">REST API Reference for BatchDeleteBillScenarioCommitmentModification Operation</seealso>
        public virtual BatchDeleteBillScenarioCommitmentModificationResponse EndBatchDeleteBillScenarioCommitmentModification(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteBillScenarioCommitmentModificationResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteBillScenarioUsageModification

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
        public virtual BatchDeleteBillScenarioUsageModificationResponse BatchDeleteBillScenarioUsageModification(BatchDeleteBillScenarioUsageModificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteBillScenarioUsageModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteBillScenarioUsageModificationResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteBillScenarioUsageModificationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteBillScenarioUsageModification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBillScenarioUsageModification operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteBillScenarioUsageModification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioUsageModification">REST API Reference for BatchDeleteBillScenarioUsageModification Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteBillScenarioUsageModification(BatchDeleteBillScenarioUsageModificationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteBillScenarioUsageModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteBillScenarioUsageModificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteBillScenarioUsageModification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteBillScenarioUsageModification.</param>
        /// 
        /// <returns>Returns a  BatchDeleteBillScenarioUsageModificationResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioUsageModification">REST API Reference for BatchDeleteBillScenarioUsageModification Operation</seealso>
        public virtual BatchDeleteBillScenarioUsageModificationResponse EndBatchDeleteBillScenarioUsageModification(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteBillScenarioUsageModificationResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteWorkloadEstimateUsage

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
        public virtual BatchDeleteWorkloadEstimateUsageResponse BatchDeleteWorkloadEstimateUsage(BatchDeleteWorkloadEstimateUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteWorkloadEstimateUsageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteWorkloadEstimateUsage operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteWorkloadEstimateUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteWorkloadEstimateUsage">REST API Reference for BatchDeleteWorkloadEstimateUsage Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteWorkloadEstimateUsage(BatchDeleteWorkloadEstimateUsageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteWorkloadEstimateUsage.</param>
        /// 
        /// <returns>Returns a  BatchDeleteWorkloadEstimateUsageResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteWorkloadEstimateUsage">REST API Reference for BatchDeleteWorkloadEstimateUsage Operation</seealso>
        public virtual BatchDeleteWorkloadEstimateUsageResponse EndBatchDeleteWorkloadEstimateUsage(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteWorkloadEstimateUsageResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdateBillScenarioCommitmentModification

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
        public virtual BatchUpdateBillScenarioCommitmentModificationResponse BatchUpdateBillScenarioCommitmentModification(BatchUpdateBillScenarioCommitmentModificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateBillScenarioCommitmentModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateBillScenarioCommitmentModificationResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateBillScenarioCommitmentModificationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateBillScenarioCommitmentModification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateBillScenarioCommitmentModification operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateBillScenarioCommitmentModification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioCommitmentModification">REST API Reference for BatchUpdateBillScenarioCommitmentModification Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateBillScenarioCommitmentModification(BatchUpdateBillScenarioCommitmentModificationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateBillScenarioCommitmentModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateBillScenarioCommitmentModificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateBillScenarioCommitmentModification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateBillScenarioCommitmentModification.</param>
        /// 
        /// <returns>Returns a  BatchUpdateBillScenarioCommitmentModificationResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioCommitmentModification">REST API Reference for BatchUpdateBillScenarioCommitmentModification Operation</seealso>
        public virtual BatchUpdateBillScenarioCommitmentModificationResponse EndBatchUpdateBillScenarioCommitmentModification(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateBillScenarioCommitmentModificationResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdateBillScenarioUsageModification

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
        public virtual BatchUpdateBillScenarioUsageModificationResponse BatchUpdateBillScenarioUsageModification(BatchUpdateBillScenarioUsageModificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateBillScenarioUsageModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateBillScenarioUsageModificationResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateBillScenarioUsageModificationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateBillScenarioUsageModification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateBillScenarioUsageModification operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateBillScenarioUsageModification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioUsageModification">REST API Reference for BatchUpdateBillScenarioUsageModification Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateBillScenarioUsageModification(BatchUpdateBillScenarioUsageModificationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateBillScenarioUsageModificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateBillScenarioUsageModificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateBillScenarioUsageModification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateBillScenarioUsageModification.</param>
        /// 
        /// <returns>Returns a  BatchUpdateBillScenarioUsageModificationResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioUsageModification">REST API Reference for BatchUpdateBillScenarioUsageModification Operation</seealso>
        public virtual BatchUpdateBillScenarioUsageModificationResponse EndBatchUpdateBillScenarioUsageModification(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateBillScenarioUsageModificationResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdateWorkloadEstimateUsage

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
        public virtual BatchUpdateWorkloadEstimateUsageResponse BatchUpdateWorkloadEstimateUsage(BatchUpdateWorkloadEstimateUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateWorkloadEstimateUsageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateWorkloadEstimateUsage operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateWorkloadEstimateUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateWorkloadEstimateUsage">REST API Reference for BatchUpdateWorkloadEstimateUsage Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateWorkloadEstimateUsage(BatchUpdateWorkloadEstimateUsageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateWorkloadEstimateUsage.</param>
        /// 
        /// <returns>Returns a  BatchUpdateWorkloadEstimateUsageResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateWorkloadEstimateUsage">REST API Reference for BatchUpdateWorkloadEstimateUsage Operation</seealso>
        public virtual BatchUpdateWorkloadEstimateUsageResponse EndBatchUpdateWorkloadEstimateUsage(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateWorkloadEstimateUsageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBillEstimate

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
        public virtual CreateBillEstimateResponse CreateBillEstimate(CreateBillEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillEstimateResponseUnmarshaller.Instance;

            return Invoke<CreateBillEstimateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBillEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBillEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateBillEstimate">REST API Reference for CreateBillEstimate Operation</seealso>
        public virtual IAsyncResult BeginCreateBillEstimate(CreateBillEstimateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillEstimateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBillEstimate.</param>
        /// 
        /// <returns>Returns a  CreateBillEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateBillEstimate">REST API Reference for CreateBillEstimate Operation</seealso>
        public virtual CreateBillEstimateResponse EndCreateBillEstimate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBillEstimateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBillScenario

        /// <summary>
        /// Creates a new bill scenario to model potential changes to Amazon Web Services usage
        /// and costs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillScenario service method.</param>
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
        public virtual CreateBillScenarioResponse CreateBillScenario(CreateBillScenarioRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillScenarioResponseUnmarshaller.Instance;

            return Invoke<CreateBillScenarioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBillScenario operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBillScenario operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBillScenario
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateBillScenario">REST API Reference for CreateBillScenario Operation</seealso>
        public virtual IAsyncResult BeginCreateBillScenario(CreateBillScenarioRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillScenarioResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBillScenario operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBillScenario.</param>
        /// 
        /// <returns>Returns a  CreateBillScenarioResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateBillScenario">REST API Reference for CreateBillScenario Operation</seealso>
        public virtual CreateBillScenarioResponse EndCreateBillScenario(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBillScenarioResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkloadEstimate

        /// <summary>
        /// Creates a new workload estimate to model costs for a specific workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadEstimate service method.</param>
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
        public virtual CreateWorkloadEstimateResponse CreateWorkloadEstimate(CreateWorkloadEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkloadEstimateResponseUnmarshaller.Instance;

            return Invoke<CreateWorkloadEstimateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkloadEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateWorkloadEstimate">REST API Reference for CreateWorkloadEstimate Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkloadEstimate(CreateWorkloadEstimateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkloadEstimateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkloadEstimate.</param>
        /// 
        /// <returns>Returns a  CreateWorkloadEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateWorkloadEstimate">REST API Reference for CreateWorkloadEstimate Operation</seealso>
        public virtual CreateWorkloadEstimateResponse EndCreateWorkloadEstimate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkloadEstimateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBillEstimate

        /// <summary>
        /// Deletes an existing bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillEstimate service method.</param>
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
        public virtual DeleteBillEstimateResponse DeleteBillEstimate(DeleteBillEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillEstimateResponseUnmarshaller.Instance;

            return Invoke<DeleteBillEstimateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBillEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteBillEstimate">REST API Reference for DeleteBillEstimate Operation</seealso>
        public virtual IAsyncResult BeginDeleteBillEstimate(DeleteBillEstimateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillEstimateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBillEstimate.</param>
        /// 
        /// <returns>Returns a  DeleteBillEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteBillEstimate">REST API Reference for DeleteBillEstimate Operation</seealso>
        public virtual DeleteBillEstimateResponse EndDeleteBillEstimate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBillEstimateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBillScenario

        /// <summary>
        /// Deletes an existing bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillScenario service method.</param>
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
        public virtual DeleteBillScenarioResponse DeleteBillScenario(DeleteBillScenarioRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillScenarioResponseUnmarshaller.Instance;

            return Invoke<DeleteBillScenarioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBillScenario operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillScenario operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBillScenario
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteBillScenario">REST API Reference for DeleteBillScenario Operation</seealso>
        public virtual IAsyncResult BeginDeleteBillScenario(DeleteBillScenarioRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillScenarioResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBillScenario operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBillScenario.</param>
        /// 
        /// <returns>Returns a  DeleteBillScenarioResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteBillScenario">REST API Reference for DeleteBillScenario Operation</seealso>
        public virtual DeleteBillScenarioResponse EndDeleteBillScenario(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBillScenarioResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorkloadEstimate

        /// <summary>
        /// Deletes an existing workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadEstimate service method.</param>
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
        public virtual DeleteWorkloadEstimateResponse DeleteWorkloadEstimate(DeleteWorkloadEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkloadEstimateResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkloadEstimateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkloadEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteWorkloadEstimate">REST API Reference for DeleteWorkloadEstimate Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorkloadEstimate(DeleteWorkloadEstimateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkloadEstimateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkloadEstimate.</param>
        /// 
        /// <returns>Returns a  DeleteWorkloadEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteWorkloadEstimate">REST API Reference for DeleteWorkloadEstimate Operation</seealso>
        public virtual DeleteWorkloadEstimateResponse EndDeleteWorkloadEstimate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkloadEstimateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBillEstimate

        /// <summary>
        /// Retrieves details of a specific bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillEstimate service method.</param>
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
        public virtual GetBillEstimateResponse GetBillEstimate(GetBillEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillEstimateResponseUnmarshaller.Instance;

            return Invoke<GetBillEstimateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBillEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBillEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetBillEstimate">REST API Reference for GetBillEstimate Operation</seealso>
        public virtual IAsyncResult BeginGetBillEstimate(GetBillEstimateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillEstimateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBillEstimate.</param>
        /// 
        /// <returns>Returns a  GetBillEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetBillEstimate">REST API Reference for GetBillEstimate Operation</seealso>
        public virtual GetBillEstimateResponse EndGetBillEstimate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBillEstimateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBillScenario

        /// <summary>
        /// Retrieves details of a specific bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillScenario service method.</param>
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
        public virtual GetBillScenarioResponse GetBillScenario(GetBillScenarioRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillScenarioResponseUnmarshaller.Instance;

            return Invoke<GetBillScenarioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBillScenario operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBillScenario operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBillScenario
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetBillScenario">REST API Reference for GetBillScenario Operation</seealso>
        public virtual IAsyncResult BeginGetBillScenario(GetBillScenarioRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillScenarioResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBillScenario operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBillScenario.</param>
        /// 
        /// <returns>Returns a  GetBillScenarioResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetBillScenario">REST API Reference for GetBillScenario Operation</seealso>
        public virtual GetBillScenarioResponse EndGetBillScenario(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBillScenarioResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPreferences

        /// <summary>
        /// Retrieves the current preferences for Pricing Calculator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPreferences service method.</param>
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
        public virtual GetPreferencesResponse GetPreferences(GetPreferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPreferencesResponseUnmarshaller.Instance;

            return Invoke<GetPreferencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPreferences operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetPreferences">REST API Reference for GetPreferences Operation</seealso>
        public virtual IAsyncResult BeginGetPreferences(GetPreferencesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPreferencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPreferences.</param>
        /// 
        /// <returns>Returns a  GetPreferencesResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetPreferences">REST API Reference for GetPreferences Operation</seealso>
        public virtual GetPreferencesResponse EndGetPreferences(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPreferencesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorkloadEstimate

        /// <summary>
        /// Retrieves details of a specific workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadEstimate service method.</param>
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
        public virtual GetWorkloadEstimateResponse GetWorkloadEstimate(GetWorkloadEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadEstimateResponseUnmarshaller.Instance;

            return Invoke<GetWorkloadEstimateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkloadEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetWorkloadEstimate">REST API Reference for GetWorkloadEstimate Operation</seealso>
        public virtual IAsyncResult BeginGetWorkloadEstimate(GetWorkloadEstimateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadEstimateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkloadEstimate.</param>
        /// 
        /// <returns>Returns a  GetWorkloadEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetWorkloadEstimate">REST API Reference for GetWorkloadEstimate Operation</seealso>
        public virtual GetWorkloadEstimateResponse EndGetWorkloadEstimate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkloadEstimateResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBillEstimateCommitments

        /// <summary>
        /// Lists the commitments associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateCommitments service method.</param>
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
        public virtual ListBillEstimateCommitmentsResponse ListBillEstimateCommitments(ListBillEstimateCommitmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateCommitmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateCommitmentsResponseUnmarshaller.Instance;

            return Invoke<ListBillEstimateCommitmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillEstimateCommitments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateCommitments operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillEstimateCommitments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateCommitments">REST API Reference for ListBillEstimateCommitments Operation</seealso>
        public virtual IAsyncResult BeginListBillEstimateCommitments(ListBillEstimateCommitmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateCommitmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateCommitmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillEstimateCommitments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillEstimateCommitments.</param>
        /// 
        /// <returns>Returns a  ListBillEstimateCommitmentsResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateCommitments">REST API Reference for ListBillEstimateCommitments Operation</seealso>
        public virtual ListBillEstimateCommitmentsResponse EndListBillEstimateCommitments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBillEstimateCommitmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBillEstimateInputCommitmentModifications

        /// <summary>
        /// Lists the input commitment modifications associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateInputCommitmentModifications service method.</param>
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
        public virtual ListBillEstimateInputCommitmentModificationsResponse ListBillEstimateInputCommitmentModifications(ListBillEstimateInputCommitmentModificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateInputCommitmentModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateInputCommitmentModificationsResponseUnmarshaller.Instance;

            return Invoke<ListBillEstimateInputCommitmentModificationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillEstimateInputCommitmentModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateInputCommitmentModifications operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillEstimateInputCommitmentModifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateInputCommitmentModifications">REST API Reference for ListBillEstimateInputCommitmentModifications Operation</seealso>
        public virtual IAsyncResult BeginListBillEstimateInputCommitmentModifications(ListBillEstimateInputCommitmentModificationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateInputCommitmentModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateInputCommitmentModificationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillEstimateInputCommitmentModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillEstimateInputCommitmentModifications.</param>
        /// 
        /// <returns>Returns a  ListBillEstimateInputCommitmentModificationsResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateInputCommitmentModifications">REST API Reference for ListBillEstimateInputCommitmentModifications Operation</seealso>
        public virtual ListBillEstimateInputCommitmentModificationsResponse EndListBillEstimateInputCommitmentModifications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBillEstimateInputCommitmentModificationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBillEstimateInputUsageModifications

        /// <summary>
        /// Lists the input usage modifications associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateInputUsageModifications service method.</param>
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
        public virtual ListBillEstimateInputUsageModificationsResponse ListBillEstimateInputUsageModifications(ListBillEstimateInputUsageModificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateInputUsageModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateInputUsageModificationsResponseUnmarshaller.Instance;

            return Invoke<ListBillEstimateInputUsageModificationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillEstimateInputUsageModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateInputUsageModifications operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillEstimateInputUsageModifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateInputUsageModifications">REST API Reference for ListBillEstimateInputUsageModifications Operation</seealso>
        public virtual IAsyncResult BeginListBillEstimateInputUsageModifications(ListBillEstimateInputUsageModificationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateInputUsageModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateInputUsageModificationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillEstimateInputUsageModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillEstimateInputUsageModifications.</param>
        /// 
        /// <returns>Returns a  ListBillEstimateInputUsageModificationsResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateInputUsageModifications">REST API Reference for ListBillEstimateInputUsageModifications Operation</seealso>
        public virtual ListBillEstimateInputUsageModificationsResponse EndListBillEstimateInputUsageModifications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBillEstimateInputUsageModificationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBillEstimateLineItems

        /// <summary>
        /// Lists the line items associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateLineItems service method.</param>
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
        public virtual ListBillEstimateLineItemsResponse ListBillEstimateLineItems(ListBillEstimateLineItemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateLineItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateLineItemsResponseUnmarshaller.Instance;

            return Invoke<ListBillEstimateLineItemsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillEstimateLineItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateLineItems operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillEstimateLineItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateLineItems">REST API Reference for ListBillEstimateLineItems Operation</seealso>
        public virtual IAsyncResult BeginListBillEstimateLineItems(ListBillEstimateLineItemsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimateLineItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimateLineItemsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillEstimateLineItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillEstimateLineItems.</param>
        /// 
        /// <returns>Returns a  ListBillEstimateLineItemsResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateLineItems">REST API Reference for ListBillEstimateLineItems Operation</seealso>
        public virtual ListBillEstimateLineItemsResponse EndListBillEstimateLineItems(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBillEstimateLineItemsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBillEstimates

        /// <summary>
        /// Lists all bill estimates for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimates service method.</param>
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
        public virtual ListBillEstimatesResponse ListBillEstimates(ListBillEstimatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimatesResponseUnmarshaller.Instance;

            return Invoke<ListBillEstimatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillEstimates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimates operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillEstimates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimates">REST API Reference for ListBillEstimates Operation</seealso>
        public virtual IAsyncResult BeginListBillEstimates(ListBillEstimatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillEstimatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillEstimatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillEstimates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillEstimates.</param>
        /// 
        /// <returns>Returns a  ListBillEstimatesResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimates">REST API Reference for ListBillEstimates Operation</seealso>
        public virtual ListBillEstimatesResponse EndListBillEstimates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBillEstimatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBillScenarioCommitmentModifications

        /// <summary>
        /// Lists the commitment modifications associated with a bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarioCommitmentModifications service method.</param>
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
        public virtual ListBillScenarioCommitmentModificationsResponse ListBillScenarioCommitmentModifications(ListBillScenarioCommitmentModificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillScenarioCommitmentModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillScenarioCommitmentModificationsResponseUnmarshaller.Instance;

            return Invoke<ListBillScenarioCommitmentModificationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillScenarioCommitmentModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarioCommitmentModifications operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillScenarioCommitmentModifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarioCommitmentModifications">REST API Reference for ListBillScenarioCommitmentModifications Operation</seealso>
        public virtual IAsyncResult BeginListBillScenarioCommitmentModifications(ListBillScenarioCommitmentModificationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillScenarioCommitmentModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillScenarioCommitmentModificationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillScenarioCommitmentModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillScenarioCommitmentModifications.</param>
        /// 
        /// <returns>Returns a  ListBillScenarioCommitmentModificationsResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarioCommitmentModifications">REST API Reference for ListBillScenarioCommitmentModifications Operation</seealso>
        public virtual ListBillScenarioCommitmentModificationsResponse EndListBillScenarioCommitmentModifications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBillScenarioCommitmentModificationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBillScenarios

        /// <summary>
        /// Lists all bill scenarios for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarios service method.</param>
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
        public virtual ListBillScenariosResponse ListBillScenarios(ListBillScenariosRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillScenariosRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillScenariosResponseUnmarshaller.Instance;

            return Invoke<ListBillScenariosResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillScenarios operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarios operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillScenarios
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarios">REST API Reference for ListBillScenarios Operation</seealso>
        public virtual IAsyncResult BeginListBillScenarios(ListBillScenariosRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillScenariosRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillScenariosResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillScenarios operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillScenarios.</param>
        /// 
        /// <returns>Returns a  ListBillScenariosResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarios">REST API Reference for ListBillScenarios Operation</seealso>
        public virtual ListBillScenariosResponse EndListBillScenarios(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBillScenariosResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBillScenarioUsageModifications

        /// <summary>
        /// Lists the usage modifications associated with a bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarioUsageModifications service method.</param>
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
        public virtual ListBillScenarioUsageModificationsResponse ListBillScenarioUsageModifications(ListBillScenarioUsageModificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillScenarioUsageModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillScenarioUsageModificationsResponseUnmarshaller.Instance;

            return Invoke<ListBillScenarioUsageModificationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillScenarioUsageModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarioUsageModifications operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillScenarioUsageModifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarioUsageModifications">REST API Reference for ListBillScenarioUsageModifications Operation</seealso>
        public virtual IAsyncResult BeginListBillScenarioUsageModifications(ListBillScenarioUsageModificationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillScenarioUsageModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillScenarioUsageModificationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillScenarioUsageModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillScenarioUsageModifications.</param>
        /// 
        /// <returns>Returns a  ListBillScenarioUsageModificationsResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarioUsageModifications">REST API Reference for ListBillScenarioUsageModifications Operation</seealso>
        public virtual ListBillScenarioUsageModificationsResponse EndListBillScenarioUsageModifications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBillScenarioUsageModificationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags associated with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWorkloadEstimates

        /// <summary>
        /// Lists all workload estimates for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadEstimates service method.</param>
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
        public virtual ListWorkloadEstimatesResponse ListWorkloadEstimates(ListWorkloadEstimatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadEstimatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadEstimatesResponseUnmarshaller.Instance;

            return Invoke<ListWorkloadEstimatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkloadEstimates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadEstimates operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkloadEstimates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListWorkloadEstimates">REST API Reference for ListWorkloadEstimates Operation</seealso>
        public virtual IAsyncResult BeginListWorkloadEstimates(ListWorkloadEstimatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadEstimatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadEstimatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkloadEstimates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkloadEstimates.</param>
        /// 
        /// <returns>Returns a  ListWorkloadEstimatesResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListWorkloadEstimates">REST API Reference for ListWorkloadEstimates Operation</seealso>
        public virtual ListWorkloadEstimatesResponse EndListWorkloadEstimates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkloadEstimatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWorkloadEstimateUsage

        /// <summary>
        /// Lists the usage associated with a workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadEstimateUsage service method.</param>
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
        public virtual ListWorkloadEstimateUsageResponse ListWorkloadEstimateUsage(ListWorkloadEstimateUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return Invoke<ListWorkloadEstimateUsageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadEstimateUsage operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkloadEstimateUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListWorkloadEstimateUsage">REST API Reference for ListWorkloadEstimateUsage Operation</seealso>
        public virtual IAsyncResult BeginListWorkloadEstimateUsage(ListWorkloadEstimateUsageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadEstimateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadEstimateUsageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkloadEstimateUsage.</param>
        /// 
        /// <returns>Returns a  ListWorkloadEstimateUsageResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListWorkloadEstimateUsage">REST API Reference for ListWorkloadEstimateUsage Operation</seealso>
        public virtual ListWorkloadEstimateUsageResponse EndListWorkloadEstimateUsage(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkloadEstimateUsageResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds one or more tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBillEstimate

        /// <summary>
        /// Updates an existing bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillEstimate service method.</param>
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
        public virtual UpdateBillEstimateResponse UpdateBillEstimate(UpdateBillEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillEstimateResponseUnmarshaller.Instance;

            return Invoke<UpdateBillEstimateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBillEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateBillEstimate">REST API Reference for UpdateBillEstimate Operation</seealso>
        public virtual IAsyncResult BeginUpdateBillEstimate(UpdateBillEstimateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBillEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillEstimateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBillEstimate.</param>
        /// 
        /// <returns>Returns a  UpdateBillEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateBillEstimate">REST API Reference for UpdateBillEstimate Operation</seealso>
        public virtual UpdateBillEstimateResponse EndUpdateBillEstimate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBillEstimateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBillScenario

        /// <summary>
        /// Updates an existing bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillScenario service method.</param>
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
        public virtual UpdateBillScenarioResponse UpdateBillScenario(UpdateBillScenarioRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillScenarioResponseUnmarshaller.Instance;

            return Invoke<UpdateBillScenarioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBillScenario operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillScenario operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBillScenario
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateBillScenario">REST API Reference for UpdateBillScenario Operation</seealso>
        public virtual IAsyncResult BeginUpdateBillScenario(UpdateBillScenarioRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBillScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillScenarioResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBillScenario operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBillScenario.</param>
        /// 
        /// <returns>Returns a  UpdateBillScenarioResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateBillScenario">REST API Reference for UpdateBillScenario Operation</seealso>
        public virtual UpdateBillScenarioResponse EndUpdateBillScenario(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBillScenarioResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePreferences

        /// <summary>
        /// Updates the preferences for Pricing Calculator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreferences service method.</param>
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
        public virtual UpdatePreferencesResponse UpdatePreferences(UpdatePreferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePreferencesResponseUnmarshaller.Instance;

            return Invoke<UpdatePreferencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreferences operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdatePreferences">REST API Reference for UpdatePreferences Operation</seealso>
        public virtual IAsyncResult BeginUpdatePreferences(UpdatePreferencesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePreferencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePreferences.</param>
        /// 
        /// <returns>Returns a  UpdatePreferencesResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdatePreferences">REST API Reference for UpdatePreferences Operation</seealso>
        public virtual UpdatePreferencesResponse EndUpdatePreferences(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePreferencesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorkloadEstimate

        /// <summary>
        /// Updates an existing workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadEstimate service method.</param>
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
        public virtual UpdateWorkloadEstimateResponse UpdateWorkloadEstimate(UpdateWorkloadEstimateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkloadEstimateResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkloadEstimateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkloadEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateWorkloadEstimate">REST API Reference for UpdateWorkloadEstimate Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkloadEstimate(UpdateWorkloadEstimateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkloadEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkloadEstimateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkloadEstimate.</param>
        /// 
        /// <returns>Returns a  UpdateWorkloadEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateWorkloadEstimate">REST API Reference for UpdateWorkloadEstimate Operation</seealso>
        public virtual UpdateWorkloadEstimateResponse EndUpdateWorkloadEstimate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkloadEstimateResponse>(asyncResult);
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
            var resolver = new AmazonBCMPricingCalculatorEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}