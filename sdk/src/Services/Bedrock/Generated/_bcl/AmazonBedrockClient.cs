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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Bedrock.Model;
using Amazon.Bedrock.Model.Internal.MarshallTransformations;
using Amazon.Bedrock.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Bedrock
{
    /// <summary>
    /// <para>Implementation for accessing Bedrock</para>
    ///
    /// Describes the API operations for creating, managing, fine-turning, and evaluating
    /// Amazon Bedrock models.
    /// </summary>
    public partial class AmazonBedrockClient : AmazonServiceClient, IAmazonBedrock
    {
        private static IServiceMetadata serviceMetadata = new AmazonBedrockMetadata();
        private IBedrockPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBedrockPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BedrockPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonBedrockClient with the credentials loaded from the application's
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
        public AmazonBedrockClient()
            : base(new AmazonBedrockConfig()) { }

        /// <summary>
        /// Constructs AmazonBedrockClient with the credentials loaded from the application's
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
        public AmazonBedrockClient(RegionEndpoint region)
            : base(new AmazonBedrockConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBedrockClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBedrockClient Configuration Object</param>
        public AmazonBedrockClient(AmazonBedrockConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBedrockClient(AWSCredentials credentials)
            : this(credentials, new AmazonBedrockConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBedrockConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Credentials and an
        /// AmazonBedrockClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBedrockClient Configuration Object</param>
        public AmazonBedrockClient(AWSCredentials credentials, AmazonBedrockConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBedrockClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBedrockClient Configuration Object</param>
        public AmazonBedrockClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBedrockConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBedrockClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBedrockClient Configuration Object</param>
        public AmazonBedrockClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBedrockConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockAuthSchemeHandler());
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


        #region  BatchDeleteEvaluationJob


        /// <summary>
        /// Deletes a batch of evaluation jobs. An evaluation job can only be deleted if it has
        /// following status <c>FAILED</c>, <c>COMPLETED</c>, and <c>STOPPED</c>. You can request
        /// up to 25 model evaluation jobs be deleted in a single request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteEvaluationJob service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteEvaluationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/BatchDeleteEvaluationJob">REST API Reference for BatchDeleteEvaluationJob Operation</seealso>
        public virtual BatchDeleteEvaluationJobResponse BatchDeleteEvaluationJob(BatchDeleteEvaluationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteEvaluationJobResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteEvaluationJobResponse>(request, options);
        }


        /// <summary>
        /// Deletes a batch of evaluation jobs. An evaluation job can only be deleted if it has
        /// following status <c>FAILED</c>, <c>COMPLETED</c>, and <c>STOPPED</c>. You can request
        /// up to 25 model evaluation jobs be deleted in a single request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteEvaluationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteEvaluationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/BatchDeleteEvaluationJob">REST API Reference for BatchDeleteEvaluationJob Operation</seealso>
        public virtual Task<BatchDeleteEvaluationJobResponse> BatchDeleteEvaluationJobAsync(BatchDeleteEvaluationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteEvaluationJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDeleteEvaluationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelAutomatedReasoningPolicyBuildWorkflow


        /// <summary>
        /// Cancels a running Automated Reasoning policy build workflow. This stops the policy
        /// generation process and prevents further processing of the source documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelAutomatedReasoningPolicyBuildWorkflow service method.</param>
        /// 
        /// <returns>The response from the CancelAutomatedReasoningPolicyBuildWorkflow service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CancelAutomatedReasoningPolicyBuildWorkflow">REST API Reference for CancelAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual CancelAutomatedReasoningPolicyBuildWorkflowResponse CancelAutomatedReasoningPolicyBuildWorkflow(CancelAutomatedReasoningPolicyBuildWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;

            return Invoke<CancelAutomatedReasoningPolicyBuildWorkflowResponse>(request, options);
        }


        /// <summary>
        /// Cancels a running Automated Reasoning policy build workflow. This stops the policy
        /// generation process and prevents further processing of the source documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelAutomatedReasoningPolicyBuildWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelAutomatedReasoningPolicyBuildWorkflow service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CancelAutomatedReasoningPolicyBuildWorkflow">REST API Reference for CancelAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual Task<CancelAutomatedReasoningPolicyBuildWorkflowResponse> CancelAutomatedReasoningPolicyBuildWorkflowAsync(CancelAutomatedReasoningPolicyBuildWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelAutomatedReasoningPolicyBuildWorkflowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAutomatedReasoningPolicy


        /// <summary>
        /// Creates an Automated Reasoning policy for Amazon Bedrock Guardrails. Automated Reasoning
        /// policies use mathematical techniques to detect hallucinations, suggest corrections,
        /// and highlight unstated assumptions in the responses of your GenAI application.
        /// 
        ///  
        /// <para>
        /// To create a policy, you upload a source document that describes the rules that you're
        /// encoding. Automated Reasoning extracts important concepts from the source document
        /// that will become variables in the policy and infers policy rules.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomatedReasoningPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateAutomatedReasoningPolicy service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateAutomatedReasoningPolicy">REST API Reference for CreateAutomatedReasoningPolicy Operation</seealso>
        public virtual CreateAutomatedReasoningPolicyResponse CreateAutomatedReasoningPolicy(CreateAutomatedReasoningPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomatedReasoningPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateAutomatedReasoningPolicyResponse>(request, options);
        }


        /// <summary>
        /// Creates an Automated Reasoning policy for Amazon Bedrock Guardrails. Automated Reasoning
        /// policies use mathematical techniques to detect hallucinations, suggest corrections,
        /// and highlight unstated assumptions in the responses of your GenAI application.
        /// 
        ///  
        /// <para>
        /// To create a policy, you upload a source document that describes the rules that you're
        /// encoding. Automated Reasoning extracts important concepts from the source document
        /// that will become variables in the policy and infers policy rules.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomatedReasoningPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAutomatedReasoningPolicy service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateAutomatedReasoningPolicy">REST API Reference for CreateAutomatedReasoningPolicy Operation</seealso>
        public virtual Task<CreateAutomatedReasoningPolicyResponse> CreateAutomatedReasoningPolicyAsync(CreateAutomatedReasoningPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomatedReasoningPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAutomatedReasoningPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAutomatedReasoningPolicyTestCase


        /// <summary>
        /// Creates a test for an Automated Reasoning policy. Tests validate that your policy
        /// works as expected by providing sample inputs and expected outcomes. Use tests to verify
        /// policy behavior before deploying to production.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomatedReasoningPolicyTestCase service method.</param>
        /// 
        /// <returns>The response from the CreateAutomatedReasoningPolicyTestCase service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateAutomatedReasoningPolicyTestCase">REST API Reference for CreateAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual CreateAutomatedReasoningPolicyTestCaseResponse CreateAutomatedReasoningPolicyTestCase(CreateAutomatedReasoningPolicyTestCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;

            return Invoke<CreateAutomatedReasoningPolicyTestCaseResponse>(request, options);
        }


        /// <summary>
        /// Creates a test for an Automated Reasoning policy. Tests validate that your policy
        /// works as expected by providing sample inputs and expected outcomes. Use tests to verify
        /// policy behavior before deploying to production.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomatedReasoningPolicyTestCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAutomatedReasoningPolicyTestCase service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateAutomatedReasoningPolicyTestCase">REST API Reference for CreateAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual Task<CreateAutomatedReasoningPolicyTestCaseResponse> CreateAutomatedReasoningPolicyTestCaseAsync(CreateAutomatedReasoningPolicyTestCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAutomatedReasoningPolicyTestCaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAutomatedReasoningPolicyVersion


        /// <summary>
        /// Creates a new version of an existing Automated Reasoning policy. This allows you to
        /// iterate on your policy rules while maintaining previous versions for rollback or comparison
        /// purposes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomatedReasoningPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the CreateAutomatedReasoningPolicyVersion service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateAutomatedReasoningPolicyVersion">REST API Reference for CreateAutomatedReasoningPolicyVersion Operation</seealso>
        public virtual CreateAutomatedReasoningPolicyVersionResponse CreateAutomatedReasoningPolicyVersion(CreateAutomatedReasoningPolicyVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomatedReasoningPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomatedReasoningPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<CreateAutomatedReasoningPolicyVersionResponse>(request, options);
        }


        /// <summary>
        /// Creates a new version of an existing Automated Reasoning policy. This allows you to
        /// iterate on your policy rules while maintaining previous versions for rollback or comparison
        /// purposes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomatedReasoningPolicyVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAutomatedReasoningPolicyVersion service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateAutomatedReasoningPolicyVersion">REST API Reference for CreateAutomatedReasoningPolicyVersion Operation</seealso>
        public virtual Task<CreateAutomatedReasoningPolicyVersionResponse> CreateAutomatedReasoningPolicyVersionAsync(CreateAutomatedReasoningPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomatedReasoningPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomatedReasoningPolicyVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAutomatedReasoningPolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomModel


        /// <summary>
        /// Creates a new custom model in Amazon Bedrock. After the model is active, you can use
        /// it for inference.
        /// 
        ///  
        /// <para>
        /// To use the model for inference, you must purchase Provisioned Throughput for it. You
        /// can't use On-demand inference with these custom models. For more information about
        /// Provisioned Throughput, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a>.
        /// </para>
        ///  
        /// <para>
        /// The model appears in <c>ListCustomModels</c> with a <c>customizationType</c> of <c>imported</c>.
        /// To track the status of the new model, you use the <c>GetCustomModel</c> API operation.
        /// The model can be in the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Creating</c> - Initial state during validation and registration
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Active</c> - Model is ready for use in inference
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - Creation process encountered an error
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetCustomModel.html">GetCustomModel</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListCustomModels.html">ListCustomModels</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModel.html">DeleteCustomModel</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomModel service method.</param>
        /// 
        /// <returns>The response from the CreateCustomModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateCustomModel">REST API Reference for CreateCustomModel Operation</seealso>
        public virtual CreateCustomModelResponse CreateCustomModel(CreateCustomModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomModelResponseUnmarshaller.Instance;

            return Invoke<CreateCustomModelResponse>(request, options);
        }


        /// <summary>
        /// Creates a new custom model in Amazon Bedrock. After the model is active, you can use
        /// it for inference.
        /// 
        ///  
        /// <para>
        /// To use the model for inference, you must purchase Provisioned Throughput for it. You
        /// can't use On-demand inference with these custom models. For more information about
        /// Provisioned Throughput, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a>.
        /// </para>
        ///  
        /// <para>
        /// The model appears in <c>ListCustomModels</c> with a <c>customizationType</c> of <c>imported</c>.
        /// To track the status of the new model, you use the <c>GetCustomModel</c> API operation.
        /// The model can be in the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Creating</c> - Initial state during validation and registration
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Active</c> - Model is ready for use in inference
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - Creation process encountered an error
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetCustomModel.html">GetCustomModel</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListCustomModels.html">ListCustomModels</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModel.html">DeleteCustomModel</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateCustomModel">REST API Reference for CreateCustomModel Operation</seealso>
        public virtual Task<CreateCustomModelResponse> CreateCustomModelAsync(CreateCustomModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCustomModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomModelDeployment


        /// <summary>
        /// Deploys a custom model for on-demand inference in Amazon Bedrock. After you deploy
        /// your custom model, you use the deployment's Amazon Resource Name (ARN) as the <c>modelId</c>
        /// parameter when you submit prompts and generate responses with model inference.
        /// 
        ///  
        /// <para>
        ///  For more information about setting up on-demand inference for custom models, see
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-use.html">Set
        /// up inference for a custom model</a>. 
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to the <c>CreateCustomModelDeployment</c> operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetCustomModelDeployment.html">GetCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListCustomModelDeployments.html">ListCustomModelDeployments</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModelDeployment.html">DeleteCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomModelDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateCustomModelDeployment service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateCustomModelDeployment">REST API Reference for CreateCustomModelDeployment Operation</seealso>
        public virtual CreateCustomModelDeploymentResponse CreateCustomModelDeployment(CreateCustomModelDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomModelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomModelDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateCustomModelDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Deploys a custom model for on-demand inference in Amazon Bedrock. After you deploy
        /// your custom model, you use the deployment's Amazon Resource Name (ARN) as the <c>modelId</c>
        /// parameter when you submit prompts and generate responses with model inference.
        /// 
        ///  
        /// <para>
        ///  For more information about setting up on-demand inference for custom models, see
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-use.html">Set
        /// up inference for a custom model</a>. 
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to the <c>CreateCustomModelDeployment</c> operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetCustomModelDeployment.html">GetCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListCustomModelDeployments.html">ListCustomModelDeployments</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModelDeployment.html">DeleteCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomModelDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomModelDeployment service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateCustomModelDeployment">REST API Reference for CreateCustomModelDeployment Operation</seealso>
        public virtual Task<CreateCustomModelDeploymentResponse> CreateCustomModelDeploymentAsync(CreateCustomModelDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomModelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomModelDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCustomModelDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEvaluationJob


        /// <summary>
        /// Creates an evaluation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEvaluationJob service method.</param>
        /// 
        /// <returns>The response from the CreateEvaluationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateEvaluationJob">REST API Reference for CreateEvaluationJob Operation</seealso>
        public virtual CreateEvaluationJobResponse CreateEvaluationJob(CreateEvaluationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEvaluationJobResponseUnmarshaller.Instance;

            return Invoke<CreateEvaluationJobResponse>(request, options);
        }


        /// <summary>
        /// Creates an evaluation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEvaluationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEvaluationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateEvaluationJob">REST API Reference for CreateEvaluationJob Operation</seealso>
        public virtual Task<CreateEvaluationJobResponse> CreateEvaluationJobAsync(CreateEvaluationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEvaluationJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEvaluationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFoundationModelAgreement


        /// <summary>
        /// Request a model access agreement for the specified model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFoundationModelAgreement service method.</param>
        /// 
        /// <returns>The response from the CreateFoundationModelAgreement service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateFoundationModelAgreement">REST API Reference for CreateFoundationModelAgreement Operation</seealso>
        public virtual CreateFoundationModelAgreementResponse CreateFoundationModelAgreement(CreateFoundationModelAgreementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFoundationModelAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFoundationModelAgreementResponseUnmarshaller.Instance;

            return Invoke<CreateFoundationModelAgreementResponse>(request, options);
        }


        /// <summary>
        /// Request a model access agreement for the specified model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFoundationModelAgreement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFoundationModelAgreement service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateFoundationModelAgreement">REST API Reference for CreateFoundationModelAgreement Operation</seealso>
        public virtual Task<CreateFoundationModelAgreementResponse> CreateFoundationModelAgreementAsync(CreateFoundationModelAgreementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFoundationModelAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFoundationModelAgreementResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFoundationModelAgreementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGuardrail


        /// <summary>
        /// Creates a guardrail to block topics and to implement safeguards for your generative
        /// AI applications.
        /// 
        ///  
        /// <para>
        /// You can configure the following policies in a guardrail to avoid undesirable and harmful
        /// content, filter out denied topics and words, and remove sensitive information for
        /// privacy protection.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Content filters</b> - Adjust filter strengths to block input prompts or model
        /// responses containing harmful content.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Denied topics</b> - Define a set of topics that are undesirable in the context
        /// of your application. These topics will be blocked if detected in user queries or model
        /// responses.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Word filters</b> - Configure filters to block undesirable words, phrases, and
        /// profanity. Such words can include offensive terms, competitor names etc.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Sensitive information filters</b> - Block or mask sensitive information such as
        /// personally identifiable information (PII) or custom regex in user inputs and model
        /// responses.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In addition to the above policies, you can also configure the messages to be returned
        /// to the user if a user input or model response is in violation of the policies defined
        /// in the guardrail.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails.html">Amazon
        /// Bedrock Guardrails</a> in the <i>Amazon Bedrock User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGuardrail service method.</param>
        /// 
        /// <returns>The response from the CreateGuardrail service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateGuardrail">REST API Reference for CreateGuardrail Operation</seealso>
        public virtual CreateGuardrailResponse CreateGuardrail(CreateGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGuardrailResponseUnmarshaller.Instance;

            return Invoke<CreateGuardrailResponse>(request, options);
        }


        /// <summary>
        /// Creates a guardrail to block topics and to implement safeguards for your generative
        /// AI applications.
        /// 
        ///  
        /// <para>
        /// You can configure the following policies in a guardrail to avoid undesirable and harmful
        /// content, filter out denied topics and words, and remove sensitive information for
        /// privacy protection.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Content filters</b> - Adjust filter strengths to block input prompts or model
        /// responses containing harmful content.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Denied topics</b> - Define a set of topics that are undesirable in the context
        /// of your application. These topics will be blocked if detected in user queries or model
        /// responses.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Word filters</b> - Configure filters to block undesirable words, phrases, and
        /// profanity. Such words can include offensive terms, competitor names etc.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Sensitive information filters</b> - Block or mask sensitive information such as
        /// personally identifiable information (PII) or custom regex in user inputs and model
        /// responses.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In addition to the above policies, you can also configure the messages to be returned
        /// to the user if a user input or model response is in violation of the policies defined
        /// in the guardrail.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails.html">Amazon
        /// Bedrock Guardrails</a> in the <i>Amazon Bedrock User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGuardrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGuardrail service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateGuardrail">REST API Reference for CreateGuardrail Operation</seealso>
        public virtual Task<CreateGuardrailResponse> CreateGuardrailAsync(CreateGuardrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGuardrailResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateGuardrailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGuardrailVersion


        /// <summary>
        /// Creates a version of the guardrail. Use this API to create a snapshot of the guardrail
        /// when you are satisfied with a configuration, or to compare the configuration with
        /// another version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGuardrailVersion service method.</param>
        /// 
        /// <returns>The response from the CreateGuardrailVersion service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateGuardrailVersion">REST API Reference for CreateGuardrailVersion Operation</seealso>
        public virtual CreateGuardrailVersionResponse CreateGuardrailVersion(CreateGuardrailVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGuardrailVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGuardrailVersionResponseUnmarshaller.Instance;

            return Invoke<CreateGuardrailVersionResponse>(request, options);
        }


        /// <summary>
        /// Creates a version of the guardrail. Use this API to create a snapshot of the guardrail
        /// when you are satisfied with a configuration, or to compare the configuration with
        /// another version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGuardrailVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGuardrailVersion service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateGuardrailVersion">REST API Reference for CreateGuardrailVersion Operation</seealso>
        public virtual Task<CreateGuardrailVersionResponse> CreateGuardrailVersionAsync(CreateGuardrailVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGuardrailVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGuardrailVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateGuardrailVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInferenceProfile


        /// <summary>
        /// Creates an application inference profile to track metrics and costs when invoking
        /// a model. To create an application inference profile for a foundation model in one
        /// region, specify the ARN of the model in that region. To create an application inference
        /// profile for a foundation model across multiple regions, specify the ARN of the system-defined
        /// inference profile that contains the regions that you want to route requests to. For
        /// more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
        /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
        /// Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInferenceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateInferenceProfile service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateInferenceProfile">REST API Reference for CreateInferenceProfile Operation</seealso>
        public virtual CreateInferenceProfileResponse CreateInferenceProfile(CreateInferenceProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInferenceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInferenceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateInferenceProfileResponse>(request, options);
        }


        /// <summary>
        /// Creates an application inference profile to track metrics and costs when invoking
        /// a model. To create an application inference profile for a foundation model in one
        /// region, specify the ARN of the model in that region. To create an application inference
        /// profile for a foundation model across multiple regions, specify the ARN of the system-defined
        /// inference profile that contains the regions that you want to route requests to. For
        /// more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
        /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
        /// Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInferenceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInferenceProfile service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateInferenceProfile">REST API Reference for CreateInferenceProfile Operation</seealso>
        public virtual Task<CreateInferenceProfileResponse> CreateInferenceProfileAsync(CreateInferenceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInferenceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInferenceProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateInferenceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMarketplaceModelEndpoint


        /// <summary>
        /// Creates an endpoint for a model from Amazon Bedrock Marketplace. The endpoint is hosted
        /// by Amazon SageMaker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMarketplaceModelEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateMarketplaceModelEndpoint">REST API Reference for CreateMarketplaceModelEndpoint Operation</seealso>
        public virtual CreateMarketplaceModelEndpointResponse CreateMarketplaceModelEndpoint(CreateMarketplaceModelEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateMarketplaceModelEndpointResponse>(request, options);
        }


        /// <summary>
        /// Creates an endpoint for a model from Amazon Bedrock Marketplace. The endpoint is hosted
        /// by Amazon SageMaker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMarketplaceModelEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateMarketplaceModelEndpoint">REST API Reference for CreateMarketplaceModelEndpoint Operation</seealso>
        public virtual Task<CreateMarketplaceModelEndpointResponse> CreateMarketplaceModelEndpointAsync(CreateMarketplaceModelEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMarketplaceModelEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMarketplaceModelEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModelCopyJob


        /// <summary>
        /// Copies a model to another region so that it can be used there. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/copy-model.html">Copy
        /// models to be used in other regions</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelCopyJob service method.</param>
        /// 
        /// <returns>The response from the CreateModelCopyJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelCopyJob">REST API Reference for CreateModelCopyJob Operation</seealso>
        public virtual CreateModelCopyJobResponse CreateModelCopyJob(CreateModelCopyJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelCopyJobResponseUnmarshaller.Instance;

            return Invoke<CreateModelCopyJobResponse>(request, options);
        }


        /// <summary>
        /// Copies a model to another region so that it can be used there. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/copy-model.html">Copy
        /// models to be used in other regions</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelCopyJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelCopyJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelCopyJob">REST API Reference for CreateModelCopyJob Operation</seealso>
        public virtual Task<CreateModelCopyJobResponse> CreateModelCopyJobAsync(CreateModelCopyJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelCopyJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateModelCopyJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModelCustomizationJob


        /// <summary>
        /// Creates a fine-tuning job to customize a base model.
        /// 
        ///  
        /// <para>
        /// You specify the base foundation model and the location of the training data. After
        /// the model-customization job completes successfully, your custom model resource will
        /// be ready to use. Amazon Bedrock returns validation loss metrics and output generations
        /// after the job completes. 
        /// </para>
        ///  
        /// <para>
        /// For information on the format of training and validation data, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-prepare.html">Prepare
        /// the datasets</a>.
        /// </para>
        ///  
        /// <para>
        ///  Model-customization jobs are asynchronous and the completion time depends on the
        /// base model and the training/validation data size. To monitor a job, use the <c>GetModelCustomizationJob</c>
        /// operation to retrieve the job status.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelCustomizationJob service method.</param>
        /// 
        /// <returns>The response from the CreateModelCustomizationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelCustomizationJob">REST API Reference for CreateModelCustomizationJob Operation</seealso>
        public virtual CreateModelCustomizationJobResponse CreateModelCustomizationJob(CreateModelCustomizationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelCustomizationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelCustomizationJobResponseUnmarshaller.Instance;

            return Invoke<CreateModelCustomizationJobResponse>(request, options);
        }


        /// <summary>
        /// Creates a fine-tuning job to customize a base model.
        /// 
        ///  
        /// <para>
        /// You specify the base foundation model and the location of the training data. After
        /// the model-customization job completes successfully, your custom model resource will
        /// be ready to use. Amazon Bedrock returns validation loss metrics and output generations
        /// after the job completes. 
        /// </para>
        ///  
        /// <para>
        /// For information on the format of training and validation data, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-prepare.html">Prepare
        /// the datasets</a>.
        /// </para>
        ///  
        /// <para>
        ///  Model-customization jobs are asynchronous and the completion time depends on the
        /// base model and the training/validation data size. To monitor a job, use the <c>GetModelCustomizationJob</c>
        /// operation to retrieve the job status.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelCustomizationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelCustomizationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelCustomizationJob">REST API Reference for CreateModelCustomizationJob Operation</seealso>
        public virtual Task<CreateModelCustomizationJobResponse> CreateModelCustomizationJobAsync(CreateModelCustomizationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelCustomizationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelCustomizationJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateModelCustomizationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModelImportJob


        /// <summary>
        /// Creates a model import job to import model that you have customized in other environments,
        /// such as Amazon SageMaker. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
        /// a customized model</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateModelImportJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelImportJob">REST API Reference for CreateModelImportJob Operation</seealso>
        public virtual CreateModelImportJobResponse CreateModelImportJob(CreateModelImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateModelImportJobResponse>(request, options);
        }


        /// <summary>
        /// Creates a model import job to import model that you have customized in other environments,
        /// such as Amazon SageMaker. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
        /// a customized model</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelImportJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelImportJob">REST API Reference for CreateModelImportJob Operation</seealso>
        public virtual Task<CreateModelImportJobResponse> CreateModelImportJobAsync(CreateModelImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelImportJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateModelImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModelInvocationJob


        /// <summary>
        /// Creates a batch inference job to invoke a model on multiple prompts. Format your data
        /// according to <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-data">Format
        /// your inference data</a> and upload it to an Amazon S3 bucket. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference.html">Process
        /// multiple prompts with batch inference</a>.
        /// 
        ///  
        /// <para>
        /// The response returns a <c>jobArn</c> that you can use to stop or get details about
        /// the job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelInvocationJob service method.</param>
        /// 
        /// <returns>The response from the CreateModelInvocationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelInvocationJob">REST API Reference for CreateModelInvocationJob Operation</seealso>
        public virtual CreateModelInvocationJobResponse CreateModelInvocationJob(CreateModelInvocationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelInvocationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelInvocationJobResponseUnmarshaller.Instance;

            return Invoke<CreateModelInvocationJobResponse>(request, options);
        }


        /// <summary>
        /// Creates a batch inference job to invoke a model on multiple prompts. Format your data
        /// according to <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-data">Format
        /// your inference data</a> and upload it to an Amazon S3 bucket. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference.html">Process
        /// multiple prompts with batch inference</a>.
        /// 
        ///  
        /// <para>
        /// The response returns a <c>jobArn</c> that you can use to stop or get details about
        /// the job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelInvocationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelInvocationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelInvocationJob">REST API Reference for CreateModelInvocationJob Operation</seealso>
        public virtual Task<CreateModelInvocationJobResponse> CreateModelInvocationJobAsync(CreateModelInvocationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelInvocationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelInvocationJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateModelInvocationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePromptRouter


        /// <summary>
        /// Creates a prompt router that manages the routing of requests between multiple foundation
        /// models based on the routing criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePromptRouter service method.</param>
        /// 
        /// <returns>The response from the CreatePromptRouter service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreatePromptRouter">REST API Reference for CreatePromptRouter Operation</seealso>
        public virtual CreatePromptRouterResponse CreatePromptRouter(CreatePromptRouterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePromptRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePromptRouterResponseUnmarshaller.Instance;

            return Invoke<CreatePromptRouterResponse>(request, options);
        }


        /// <summary>
        /// Creates a prompt router that manages the routing of requests between multiple foundation
        /// models based on the routing criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePromptRouter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePromptRouter service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreatePromptRouter">REST API Reference for CreatePromptRouter Operation</seealso>
        public virtual Task<CreatePromptRouterResponse> CreatePromptRouterAsync(CreatePromptRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePromptRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePromptRouterResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePromptRouterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProvisionedModelThroughput


        /// <summary>
        /// Creates dedicated throughput for a base or custom model with the model units and for
        /// the duration that you specify. For pricing details, see <a href="http://aws.amazon.com/bedrock/pricing/">Amazon
        /// Bedrock Pricing</a>. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisionedModelThroughput service method.</param>
        /// 
        /// <returns>The response from the CreateProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateProvisionedModelThroughput">REST API Reference for CreateProvisionedModelThroughput Operation</seealso>
        public virtual CreateProvisionedModelThroughputResponse CreateProvisionedModelThroughput(CreateProvisionedModelThroughputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisionedModelThroughputResponseUnmarshaller.Instance;

            return Invoke<CreateProvisionedModelThroughputResponse>(request, options);
        }


        /// <summary>
        /// Creates dedicated throughput for a base or custom model with the model units and for
        /// the duration that you specify. For pricing details, see <a href="http://aws.amazon.com/bedrock/pricing/">Amazon
        /// Bedrock Pricing</a>. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisionedModelThroughput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateProvisionedModelThroughput">REST API Reference for CreateProvisionedModelThroughput Operation</seealso>
        public virtual Task<CreateProvisionedModelThroughputResponse> CreateProvisionedModelThroughputAsync(CreateProvisionedModelThroughputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisionedModelThroughputResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProvisionedModelThroughputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAutomatedReasoningPolicy


        /// <summary>
        /// Deletes an Automated Reasoning policy or policy version. This operation is idempotent.
        /// If you delete a policy more than once, each call succeeds. Deleting a policy removes
        /// it permanently and cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomatedReasoningPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAutomatedReasoningPolicy service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteAutomatedReasoningPolicy">REST API Reference for DeleteAutomatedReasoningPolicy Operation</seealso>
        public virtual DeleteAutomatedReasoningPolicyResponse DeleteAutomatedReasoningPolicy(DeleteAutomatedReasoningPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomatedReasoningPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteAutomatedReasoningPolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes an Automated Reasoning policy or policy version. This operation is idempotent.
        /// If you delete a policy more than once, each call succeeds. Deleting a policy removes
        /// it permanently and cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomatedReasoningPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAutomatedReasoningPolicy service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteAutomatedReasoningPolicy">REST API Reference for DeleteAutomatedReasoningPolicy Operation</seealso>
        public virtual Task<DeleteAutomatedReasoningPolicyResponse> DeleteAutomatedReasoningPolicyAsync(DeleteAutomatedReasoningPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomatedReasoningPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAutomatedReasoningPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAutomatedReasoningPolicyBuildWorkflow


        /// <summary>
        /// Deletes an Automated Reasoning policy build workflow and its associated artifacts.
        /// This permanently removes the workflow history and any generated assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomatedReasoningPolicyBuildWorkflow service method.</param>
        /// 
        /// <returns>The response from the DeleteAutomatedReasoningPolicyBuildWorkflow service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteAutomatedReasoningPolicyBuildWorkflow">REST API Reference for DeleteAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual DeleteAutomatedReasoningPolicyBuildWorkflowResponse DeleteAutomatedReasoningPolicyBuildWorkflow(DeleteAutomatedReasoningPolicyBuildWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteAutomatedReasoningPolicyBuildWorkflowResponse>(request, options);
        }


        /// <summary>
        /// Deletes an Automated Reasoning policy build workflow and its associated artifacts.
        /// This permanently removes the workflow history and any generated assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomatedReasoningPolicyBuildWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAutomatedReasoningPolicyBuildWorkflow service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteAutomatedReasoningPolicyBuildWorkflow">REST API Reference for DeleteAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual Task<DeleteAutomatedReasoningPolicyBuildWorkflowResponse> DeleteAutomatedReasoningPolicyBuildWorkflowAsync(DeleteAutomatedReasoningPolicyBuildWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAutomatedReasoningPolicyBuildWorkflowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAutomatedReasoningPolicyTestCase


        /// <summary>
        /// Deletes an Automated Reasoning policy test. This operation is idempotent; if you delete
        /// a test more than once, each call succeeds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomatedReasoningPolicyTestCase service method.</param>
        /// 
        /// <returns>The response from the DeleteAutomatedReasoningPolicyTestCase service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteAutomatedReasoningPolicyTestCase">REST API Reference for DeleteAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual DeleteAutomatedReasoningPolicyTestCaseResponse DeleteAutomatedReasoningPolicyTestCase(DeleteAutomatedReasoningPolicyTestCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;

            return Invoke<DeleteAutomatedReasoningPolicyTestCaseResponse>(request, options);
        }


        /// <summary>
        /// Deletes an Automated Reasoning policy test. This operation is idempotent; if you delete
        /// a test more than once, each call succeeds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomatedReasoningPolicyTestCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAutomatedReasoningPolicyTestCase service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteAutomatedReasoningPolicyTestCase">REST API Reference for DeleteAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual Task<DeleteAutomatedReasoningPolicyTestCaseResponse> DeleteAutomatedReasoningPolicyTestCaseAsync(DeleteAutomatedReasoningPolicyTestCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAutomatedReasoningPolicyTestCaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomModel


        /// <summary>
        /// Deletes a custom model that you created earlier. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomModel service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteCustomModel">REST API Reference for DeleteCustomModel Operation</seealso>
        public virtual DeleteCustomModelResponse DeleteCustomModel(DeleteCustomModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomModelResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomModelResponse>(request, options);
        }


        /// <summary>
        /// Deletes a custom model that you created earlier. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteCustomModel">REST API Reference for DeleteCustomModel Operation</seealso>
        public virtual Task<DeleteCustomModelResponse> DeleteCustomModelAsync(DeleteCustomModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCustomModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomModelDeployment


        /// <summary>
        /// Deletes a custom model deployment. This operation stops the deployment and removes
        /// it from your account. After deletion, the deployment ARN can no longer be used for
        /// inference requests.
        /// 
        ///  
        /// <para>
        /// The following actions are related to the <c>DeleteCustomModelDeployment</c> operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateCustomModelDeployment.html">CreateCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetCustomModelDeployment.html">GetCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListCustomModelDeployments.html">ListCustomModelDeployments</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomModelDeployment service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomModelDeployment service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteCustomModelDeployment">REST API Reference for DeleteCustomModelDeployment Operation</seealso>
        public virtual DeleteCustomModelDeploymentResponse DeleteCustomModelDeployment(DeleteCustomModelDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomModelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomModelDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomModelDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Deletes a custom model deployment. This operation stops the deployment and removes
        /// it from your account. After deletion, the deployment ARN can no longer be used for
        /// inference requests.
        /// 
        ///  
        /// <para>
        /// The following actions are related to the <c>DeleteCustomModelDeployment</c> operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateCustomModelDeployment.html">CreateCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetCustomModelDeployment.html">GetCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListCustomModelDeployments.html">ListCustomModelDeployments</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomModelDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomModelDeployment service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteCustomModelDeployment">REST API Reference for DeleteCustomModelDeployment Operation</seealso>
        public virtual Task<DeleteCustomModelDeploymentResponse> DeleteCustomModelDeploymentAsync(DeleteCustomModelDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomModelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomModelDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCustomModelDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFoundationModelAgreement


        /// <summary>
        /// Delete the model access agreement for the specified model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFoundationModelAgreement service method.</param>
        /// 
        /// <returns>The response from the DeleteFoundationModelAgreement service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteFoundationModelAgreement">REST API Reference for DeleteFoundationModelAgreement Operation</seealso>
        public virtual DeleteFoundationModelAgreementResponse DeleteFoundationModelAgreement(DeleteFoundationModelAgreementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFoundationModelAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFoundationModelAgreementResponseUnmarshaller.Instance;

            return Invoke<DeleteFoundationModelAgreementResponse>(request, options);
        }


        /// <summary>
        /// Delete the model access agreement for the specified model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFoundationModelAgreement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFoundationModelAgreement service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteFoundationModelAgreement">REST API Reference for DeleteFoundationModelAgreement Operation</seealso>
        public virtual Task<DeleteFoundationModelAgreementResponse> DeleteFoundationModelAgreementAsync(DeleteFoundationModelAgreementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFoundationModelAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFoundationModelAgreementResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFoundationModelAgreementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGuardrail


        /// <summary>
        /// Deletes a guardrail.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// To delete a guardrail, only specify the ARN of the guardrail in the <c>guardrailIdentifier</c>
        /// field. If you delete a guardrail, all of its versions will be deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete a version of a guardrail, specify the ARN of the guardrail in the <c>guardrailIdentifier</c>
        /// field and the version in the <c>guardrailVersion</c> field.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGuardrail service method.</param>
        /// 
        /// <returns>The response from the DeleteGuardrail service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteGuardrail">REST API Reference for DeleteGuardrail Operation</seealso>
        public virtual DeleteGuardrailResponse DeleteGuardrail(DeleteGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGuardrailResponseUnmarshaller.Instance;

            return Invoke<DeleteGuardrailResponse>(request, options);
        }


        /// <summary>
        /// Deletes a guardrail.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// To delete a guardrail, only specify the ARN of the guardrail in the <c>guardrailIdentifier</c>
        /// field. If you delete a guardrail, all of its versions will be deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete a version of a guardrail, specify the ARN of the guardrail in the <c>guardrailIdentifier</c>
        /// field and the version in the <c>guardrailVersion</c> field.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGuardrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGuardrail service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteGuardrail">REST API Reference for DeleteGuardrail Operation</seealso>
        public virtual Task<DeleteGuardrailResponse> DeleteGuardrailAsync(DeleteGuardrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGuardrailResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteGuardrailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteImportedModel


        /// <summary>
        /// Deletes a custom model that you imported earlier. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
        /// a customized model</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportedModel service method.</param>
        /// 
        /// <returns>The response from the DeleteImportedModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteImportedModel">REST API Reference for DeleteImportedModel Operation</seealso>
        public virtual DeleteImportedModelResponse DeleteImportedModel(DeleteImportedModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImportedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImportedModelResponseUnmarshaller.Instance;

            return Invoke<DeleteImportedModelResponse>(request, options);
        }


        /// <summary>
        /// Deletes a custom model that you imported earlier. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
        /// a customized model</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportedModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteImportedModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteImportedModel">REST API Reference for DeleteImportedModel Operation</seealso>
        public virtual Task<DeleteImportedModelResponse> DeleteImportedModelAsync(DeleteImportedModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImportedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImportedModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteImportedModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInferenceProfile


        /// <summary>
        /// Deletes an application inference profile. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
        /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
        /// Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInferenceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteInferenceProfile service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteInferenceProfile">REST API Reference for DeleteInferenceProfile Operation</seealso>
        public virtual DeleteInferenceProfileResponse DeleteInferenceProfile(DeleteInferenceProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInferenceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInferenceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteInferenceProfileResponse>(request, options);
        }


        /// <summary>
        /// Deletes an application inference profile. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
        /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
        /// Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInferenceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInferenceProfile service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteInferenceProfile">REST API Reference for DeleteInferenceProfile Operation</seealso>
        public virtual Task<DeleteInferenceProfileResponse> DeleteInferenceProfileAsync(DeleteInferenceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInferenceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInferenceProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteInferenceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMarketplaceModelEndpoint


        /// <summary>
        /// Deletes an endpoint for a model from Amazon Bedrock Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMarketplaceModelEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteMarketplaceModelEndpoint">REST API Reference for DeleteMarketplaceModelEndpoint Operation</seealso>
        public virtual DeleteMarketplaceModelEndpointResponse DeleteMarketplaceModelEndpoint(DeleteMarketplaceModelEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteMarketplaceModelEndpointResponse>(request, options);
        }


        /// <summary>
        /// Deletes an endpoint for a model from Amazon Bedrock Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMarketplaceModelEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteMarketplaceModelEndpoint">REST API Reference for DeleteMarketplaceModelEndpoint Operation</seealso>
        public virtual Task<DeleteMarketplaceModelEndpointResponse> DeleteMarketplaceModelEndpointAsync(DeleteMarketplaceModelEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMarketplaceModelEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMarketplaceModelEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModelInvocationLoggingConfiguration


        /// <summary>
        /// Delete the invocation logging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelInvocationLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteModelInvocationLoggingConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteModelInvocationLoggingConfiguration">REST API Reference for DeleteModelInvocationLoggingConfiguration Operation</seealso>
        public virtual DeleteModelInvocationLoggingConfigurationResponse DeleteModelInvocationLoggingConfiguration(DeleteModelInvocationLoggingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteModelInvocationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelInvocationLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteModelInvocationLoggingConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Delete the invocation logging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelInvocationLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelInvocationLoggingConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteModelInvocationLoggingConfiguration">REST API Reference for DeleteModelInvocationLoggingConfiguration Operation</seealso>
        public virtual Task<DeleteModelInvocationLoggingConfigurationResponse> DeleteModelInvocationLoggingConfigurationAsync(DeleteModelInvocationLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteModelInvocationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelInvocationLoggingConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteModelInvocationLoggingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePromptRouter


        /// <summary>
        /// Deletes a specified prompt router. This action cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePromptRouter service method.</param>
        /// 
        /// <returns>The response from the DeletePromptRouter service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeletePromptRouter">REST API Reference for DeletePromptRouter Operation</seealso>
        public virtual DeletePromptRouterResponse DeletePromptRouter(DeletePromptRouterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePromptRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePromptRouterResponseUnmarshaller.Instance;

            return Invoke<DeletePromptRouterResponse>(request, options);
        }


        /// <summary>
        /// Deletes a specified prompt router. This action cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePromptRouter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePromptRouter service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeletePromptRouter">REST API Reference for DeletePromptRouter Operation</seealso>
        public virtual Task<DeletePromptRouterResponse> DeletePromptRouterAsync(DeletePromptRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePromptRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePromptRouterResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePromptRouterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProvisionedModelThroughput


        /// <summary>
        /// Deletes a Provisioned Throughput. You can't delete a Provisioned Throughput before
        /// the commitment term is over. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedModelThroughput service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteProvisionedModelThroughput">REST API Reference for DeleteProvisionedModelThroughput Operation</seealso>
        public virtual DeleteProvisionedModelThroughputResponse DeleteProvisionedModelThroughput(DeleteProvisionedModelThroughputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisionedModelThroughputResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisionedModelThroughputResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Provisioned Throughput. You can't delete a Provisioned Throughput before
        /// the commitment term is over. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedModelThroughput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteProvisionedModelThroughput">REST API Reference for DeleteProvisionedModelThroughput Operation</seealso>
        public virtual Task<DeleteProvisionedModelThroughputResponse> DeleteProvisionedModelThroughputAsync(DeleteProvisionedModelThroughputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisionedModelThroughputResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProvisionedModelThroughputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterMarketplaceModelEndpoint


        /// <summary>
        /// Deregisters an endpoint for a model from Amazon Bedrock Marketplace. This operation
        /// removes the endpoint's association with Amazon Bedrock but does not delete the underlying
        /// Amazon SageMaker endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterMarketplaceModelEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeregisterMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeregisterMarketplaceModelEndpoint">REST API Reference for DeregisterMarketplaceModelEndpoint Operation</seealso>
        public virtual DeregisterMarketplaceModelEndpointResponse DeregisterMarketplaceModelEndpoint(DeregisterMarketplaceModelEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return Invoke<DeregisterMarketplaceModelEndpointResponse>(request, options);
        }


        /// <summary>
        /// Deregisters an endpoint for a model from Amazon Bedrock Marketplace. This operation
        /// removes the endpoint's association with Amazon Bedrock but does not delete the underlying
        /// Amazon SageMaker endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterMarketplaceModelEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeregisterMarketplaceModelEndpoint">REST API Reference for DeregisterMarketplaceModelEndpoint Operation</seealso>
        public virtual Task<DeregisterMarketplaceModelEndpointResponse> DeregisterMarketplaceModelEndpointAsync(DeregisterMarketplaceModelEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterMarketplaceModelEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeregisterMarketplaceModelEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportAutomatedReasoningPolicyVersion


        /// <summary>
        /// Exports the policy definition for an Automated Reasoning policy version. Returns the
        /// complete policy definition including rules, variables, and custom variable types in
        /// a structured format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportAutomatedReasoningPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the ExportAutomatedReasoningPolicyVersion service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ExportAutomatedReasoningPolicyVersion">REST API Reference for ExportAutomatedReasoningPolicyVersion Operation</seealso>
        public virtual ExportAutomatedReasoningPolicyVersionResponse ExportAutomatedReasoningPolicyVersion(ExportAutomatedReasoningPolicyVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportAutomatedReasoningPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportAutomatedReasoningPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<ExportAutomatedReasoningPolicyVersionResponse>(request, options);
        }


        /// <summary>
        /// Exports the policy definition for an Automated Reasoning policy version. Returns the
        /// complete policy definition including rules, variables, and custom variable types in
        /// a structured format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportAutomatedReasoningPolicyVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportAutomatedReasoningPolicyVersion service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ExportAutomatedReasoningPolicyVersion">REST API Reference for ExportAutomatedReasoningPolicyVersion Operation</seealso>
        public virtual Task<ExportAutomatedReasoningPolicyVersionResponse> ExportAutomatedReasoningPolicyVersionAsync(ExportAutomatedReasoningPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportAutomatedReasoningPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportAutomatedReasoningPolicyVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExportAutomatedReasoningPolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAutomatedReasoningPolicy


        /// <summary>
        /// Retrieves details about an Automated Reasoning policy or policy version. Returns information
        /// including the policy definition, metadata, and timestamps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicy service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicy service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicy">REST API Reference for GetAutomatedReasoningPolicy Operation</seealso>
        public virtual GetAutomatedReasoningPolicyResponse GetAutomatedReasoningPolicy(GetAutomatedReasoningPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyResponseUnmarshaller.Instance;

            return Invoke<GetAutomatedReasoningPolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves details about an Automated Reasoning policy or policy version. Returns information
        /// including the policy definition, metadata, and timestamps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicy service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicy">REST API Reference for GetAutomatedReasoningPolicy Operation</seealso>
        public virtual Task<GetAutomatedReasoningPolicyResponse> GetAutomatedReasoningPolicyAsync(GetAutomatedReasoningPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAutomatedReasoningPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAutomatedReasoningPolicyAnnotations


        /// <summary>
        /// Retrieves the current annotations for an Automated Reasoning policy build workflow.
        /// Annotations contain corrections to the rules, variables and types to be applied to
        /// the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyAnnotations service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyAnnotations service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyAnnotations">REST API Reference for GetAutomatedReasoningPolicyAnnotations Operation</seealso>
        public virtual GetAutomatedReasoningPolicyAnnotationsResponse GetAutomatedReasoningPolicyAnnotations(GetAutomatedReasoningPolicyAnnotationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyAnnotationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyAnnotationsResponseUnmarshaller.Instance;

            return Invoke<GetAutomatedReasoningPolicyAnnotationsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the current annotations for an Automated Reasoning policy build workflow.
        /// Annotations contain corrections to the rules, variables and types to be applied to
        /// the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyAnnotations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyAnnotations service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyAnnotations">REST API Reference for GetAutomatedReasoningPolicyAnnotations Operation</seealso>
        public virtual Task<GetAutomatedReasoningPolicyAnnotationsResponse> GetAutomatedReasoningPolicyAnnotationsAsync(GetAutomatedReasoningPolicyAnnotationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyAnnotationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyAnnotationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAutomatedReasoningPolicyAnnotationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAutomatedReasoningPolicyBuildWorkflow


        /// <summary>
        /// Retrieves detailed information about an Automated Reasoning policy build workflow,
        /// including its status, configuration, and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyBuildWorkflow service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyBuildWorkflow service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyBuildWorkflow">REST API Reference for GetAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual GetAutomatedReasoningPolicyBuildWorkflowResponse GetAutomatedReasoningPolicyBuildWorkflow(GetAutomatedReasoningPolicyBuildWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetAutomatedReasoningPolicyBuildWorkflowResponse>(request, options);
        }


        /// <summary>
        /// Retrieves detailed information about an Automated Reasoning policy build workflow,
        /// including its status, configuration, and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyBuildWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyBuildWorkflow service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyBuildWorkflow">REST API Reference for GetAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual Task<GetAutomatedReasoningPolicyBuildWorkflowResponse> GetAutomatedReasoningPolicyBuildWorkflowAsync(GetAutomatedReasoningPolicyBuildWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAutomatedReasoningPolicyBuildWorkflowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAutomatedReasoningPolicyBuildWorkflowResultAssets


        /// <summary>
        /// Retrieves the resulting assets from a completed Automated Reasoning policy build workflow,
        /// including build logs, quality reports, and generated policy artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyBuildWorkflowResultAssets service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyBuildWorkflowResultAssets service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyBuildWorkflowResultAssets">REST API Reference for GetAutomatedReasoningPolicyBuildWorkflowResultAssets Operation</seealso>
        public virtual GetAutomatedReasoningPolicyBuildWorkflowResultAssetsResponse GetAutomatedReasoningPolicyBuildWorkflowResultAssets(GetAutomatedReasoningPolicyBuildWorkflowResultAssetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyBuildWorkflowResultAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyBuildWorkflowResultAssetsResponseUnmarshaller.Instance;

            return Invoke<GetAutomatedReasoningPolicyBuildWorkflowResultAssetsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the resulting assets from a completed Automated Reasoning policy build workflow,
        /// including build logs, quality reports, and generated policy artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyBuildWorkflowResultAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyBuildWorkflowResultAssets service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyBuildWorkflowResultAssets">REST API Reference for GetAutomatedReasoningPolicyBuildWorkflowResultAssets Operation</seealso>
        public virtual Task<GetAutomatedReasoningPolicyBuildWorkflowResultAssetsResponse> GetAutomatedReasoningPolicyBuildWorkflowResultAssetsAsync(GetAutomatedReasoningPolicyBuildWorkflowResultAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyBuildWorkflowResultAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyBuildWorkflowResultAssetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAutomatedReasoningPolicyBuildWorkflowResultAssetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAutomatedReasoningPolicyNextScenario


        /// <summary>
        /// Retrieves the next test scenario for validating an Automated Reasoning policy. This
        /// is used during the interactive policy refinement process to test policy behavior.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyNextScenario service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyNextScenario service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyNextScenario">REST API Reference for GetAutomatedReasoningPolicyNextScenario Operation</seealso>
        public virtual GetAutomatedReasoningPolicyNextScenarioResponse GetAutomatedReasoningPolicyNextScenario(GetAutomatedReasoningPolicyNextScenarioRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyNextScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyNextScenarioResponseUnmarshaller.Instance;

            return Invoke<GetAutomatedReasoningPolicyNextScenarioResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the next test scenario for validating an Automated Reasoning policy. This
        /// is used during the interactive policy refinement process to test policy behavior.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyNextScenario service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyNextScenario service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyNextScenario">REST API Reference for GetAutomatedReasoningPolicyNextScenario Operation</seealso>
        public virtual Task<GetAutomatedReasoningPolicyNextScenarioResponse> GetAutomatedReasoningPolicyNextScenarioAsync(GetAutomatedReasoningPolicyNextScenarioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyNextScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyNextScenarioResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAutomatedReasoningPolicyNextScenarioResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAutomatedReasoningPolicyTestCase


        /// <summary>
        /// Retrieves details about a specific Automated Reasoning policy test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyTestCase service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyTestCase service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyTestCase">REST API Reference for GetAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual GetAutomatedReasoningPolicyTestCaseResponse GetAutomatedReasoningPolicyTestCase(GetAutomatedReasoningPolicyTestCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;

            return Invoke<GetAutomatedReasoningPolicyTestCaseResponse>(request, options);
        }


        /// <summary>
        /// Retrieves details about a specific Automated Reasoning policy test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyTestCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyTestCase service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyTestCase">REST API Reference for GetAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual Task<GetAutomatedReasoningPolicyTestCaseResponse> GetAutomatedReasoningPolicyTestCaseAsync(GetAutomatedReasoningPolicyTestCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAutomatedReasoningPolicyTestCaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAutomatedReasoningPolicyTestResult


        /// <summary>
        /// Retrieves the test result for a specific Automated Reasoning policy test. Returns
        /// detailed validation findings and execution status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyTestResult service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyTestResult service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyTestResult">REST API Reference for GetAutomatedReasoningPolicyTestResult Operation</seealso>
        public virtual GetAutomatedReasoningPolicyTestResultResponse GetAutomatedReasoningPolicyTestResult(GetAutomatedReasoningPolicyTestResultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyTestResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyTestResultResponseUnmarshaller.Instance;

            return Invoke<GetAutomatedReasoningPolicyTestResultResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the test result for a specific Automated Reasoning policy test. Returns
        /// detailed validation findings and execution status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyTestResult service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyTestResult service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyTestResult">REST API Reference for GetAutomatedReasoningPolicyTestResult Operation</seealso>
        public virtual Task<GetAutomatedReasoningPolicyTestResultResponse> GetAutomatedReasoningPolicyTestResultAsync(GetAutomatedReasoningPolicyTestResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyTestResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyTestResultResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAutomatedReasoningPolicyTestResultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCustomModel


        /// <summary>
        /// Get the properties associated with a Amazon Bedrock custom model that you have created.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomModel service method.</param>
        /// 
        /// <returns>The response from the GetCustomModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetCustomModel">REST API Reference for GetCustomModel Operation</seealso>
        public virtual GetCustomModelResponse GetCustomModel(GetCustomModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCustomModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomModelResponseUnmarshaller.Instance;

            return Invoke<GetCustomModelResponse>(request, options);
        }


        /// <summary>
        /// Get the properties associated with a Amazon Bedrock custom model that you have created.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCustomModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetCustomModel">REST API Reference for GetCustomModel Operation</seealso>
        public virtual Task<GetCustomModelResponse> GetCustomModelAsync(GetCustomModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCustomModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCustomModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCustomModelDeployment


        /// <summary>
        /// Retrieves information about a custom model deployment, including its status, configuration,
        /// and metadata. Use this operation to monitor the deployment status and retrieve details
        /// needed for inference requests.
        /// 
        ///  
        /// <para>
        /// The following actions are related to the <c>GetCustomModelDeployment</c> operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateCustomModelDeployment.html">CreateCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListCustomModelDeployments.html">ListCustomModelDeployments</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModelDeployment.html">DeleteCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomModelDeployment service method.</param>
        /// 
        /// <returns>The response from the GetCustomModelDeployment service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetCustomModelDeployment">REST API Reference for GetCustomModelDeployment Operation</seealso>
        public virtual GetCustomModelDeploymentResponse GetCustomModelDeployment(GetCustomModelDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCustomModelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomModelDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetCustomModelDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a custom model deployment, including its status, configuration,
        /// and metadata. Use this operation to monitor the deployment status and retrieve details
        /// needed for inference requests.
        /// 
        ///  
        /// <para>
        /// The following actions are related to the <c>GetCustomModelDeployment</c> operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateCustomModelDeployment.html">CreateCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListCustomModelDeployments.html">ListCustomModelDeployments</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModelDeployment.html">DeleteCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomModelDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCustomModelDeployment service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetCustomModelDeployment">REST API Reference for GetCustomModelDeployment Operation</seealso>
        public virtual Task<GetCustomModelDeploymentResponse> GetCustomModelDeploymentAsync(GetCustomModelDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCustomModelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomModelDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCustomModelDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEvaluationJob


        /// <summary>
        /// Gets information about an evaluation job, such as the status of the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvaluationJob service method.</param>
        /// 
        /// <returns>The response from the GetEvaluationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetEvaluationJob">REST API Reference for GetEvaluationJob Operation</seealso>
        public virtual GetEvaluationJobResponse GetEvaluationJob(GetEvaluationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvaluationJobResponseUnmarshaller.Instance;

            return Invoke<GetEvaluationJobResponse>(request, options);
        }


        /// <summary>
        /// Gets information about an evaluation job, such as the status of the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvaluationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEvaluationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetEvaluationJob">REST API Reference for GetEvaluationJob Operation</seealso>
        public virtual Task<GetEvaluationJobResponse> GetEvaluationJobAsync(GetEvaluationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvaluationJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEvaluationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFoundationModel


        /// <summary>
        /// Get details about a Amazon Bedrock foundation model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFoundationModel service method.</param>
        /// 
        /// <returns>The response from the GetFoundationModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetFoundationModel">REST API Reference for GetFoundationModel Operation</seealso>
        public virtual GetFoundationModelResponse GetFoundationModel(GetFoundationModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFoundationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFoundationModelResponseUnmarshaller.Instance;

            return Invoke<GetFoundationModelResponse>(request, options);
        }


        /// <summary>
        /// Get details about a Amazon Bedrock foundation model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFoundationModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFoundationModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetFoundationModel">REST API Reference for GetFoundationModel Operation</seealso>
        public virtual Task<GetFoundationModelResponse> GetFoundationModelAsync(GetFoundationModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFoundationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFoundationModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFoundationModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFoundationModelAvailability


        /// <summary>
        /// Get information about the Foundation model availability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFoundationModelAvailability service method.</param>
        /// 
        /// <returns>The response from the GetFoundationModelAvailability service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetFoundationModelAvailability">REST API Reference for GetFoundationModelAvailability Operation</seealso>
        public virtual GetFoundationModelAvailabilityResponse GetFoundationModelAvailability(GetFoundationModelAvailabilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFoundationModelAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFoundationModelAvailabilityResponseUnmarshaller.Instance;

            return Invoke<GetFoundationModelAvailabilityResponse>(request, options);
        }


        /// <summary>
        /// Get information about the Foundation model availability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFoundationModelAvailability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFoundationModelAvailability service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetFoundationModelAvailability">REST API Reference for GetFoundationModelAvailability Operation</seealso>
        public virtual Task<GetFoundationModelAvailabilityResponse> GetFoundationModelAvailabilityAsync(GetFoundationModelAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFoundationModelAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFoundationModelAvailabilityResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFoundationModelAvailabilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGuardrail


        /// <summary>
        /// Gets details about a guardrail. If you don't specify a version, the response returns
        /// details for the <c>DRAFT</c> version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGuardrail service method.</param>
        /// 
        /// <returns>The response from the GetGuardrail service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetGuardrail">REST API Reference for GetGuardrail Operation</seealso>
        public virtual GetGuardrailResponse GetGuardrail(GetGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGuardrailResponseUnmarshaller.Instance;

            return Invoke<GetGuardrailResponse>(request, options);
        }


        /// <summary>
        /// Gets details about a guardrail. If you don't specify a version, the response returns
        /// details for the <c>DRAFT</c> version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGuardrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGuardrail service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetGuardrail">REST API Reference for GetGuardrail Operation</seealso>
        public virtual Task<GetGuardrailResponse> GetGuardrailAsync(GetGuardrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGuardrailResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetGuardrailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetImportedModel


        /// <summary>
        /// Gets properties associated with a customized model you imported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportedModel service method.</param>
        /// 
        /// <returns>The response from the GetImportedModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetImportedModel">REST API Reference for GetImportedModel Operation</seealso>
        public virtual GetImportedModelResponse GetImportedModel(GetImportedModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportedModelResponseUnmarshaller.Instance;

            return Invoke<GetImportedModelResponse>(request, options);
        }


        /// <summary>
        /// Gets properties associated with a customized model you imported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportedModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImportedModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetImportedModel">REST API Reference for GetImportedModel Operation</seealso>
        public virtual Task<GetImportedModelResponse> GetImportedModelAsync(GetImportedModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportedModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetImportedModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInferenceProfile


        /// <summary>
        /// Gets information about an inference profile. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
        /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
        /// Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInferenceProfile service method.</param>
        /// 
        /// <returns>The response from the GetInferenceProfile service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetInferenceProfile">REST API Reference for GetInferenceProfile Operation</seealso>
        public virtual GetInferenceProfileResponse GetInferenceProfile(GetInferenceProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInferenceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInferenceProfileResponseUnmarshaller.Instance;

            return Invoke<GetInferenceProfileResponse>(request, options);
        }


        /// <summary>
        /// Gets information about an inference profile. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
        /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
        /// Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInferenceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInferenceProfile service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetInferenceProfile">REST API Reference for GetInferenceProfile Operation</seealso>
        public virtual Task<GetInferenceProfileResponse> GetInferenceProfileAsync(GetInferenceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInferenceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInferenceProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInferenceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMarketplaceModelEndpoint


        /// <summary>
        /// Retrieves details about a specific endpoint for a model from Amazon Bedrock Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMarketplaceModelEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetMarketplaceModelEndpoint">REST API Reference for GetMarketplaceModelEndpoint Operation</seealso>
        public virtual GetMarketplaceModelEndpointResponse GetMarketplaceModelEndpoint(GetMarketplaceModelEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return Invoke<GetMarketplaceModelEndpointResponse>(request, options);
        }


        /// <summary>
        /// Retrieves details about a specific endpoint for a model from Amazon Bedrock Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMarketplaceModelEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetMarketplaceModelEndpoint">REST API Reference for GetMarketplaceModelEndpoint Operation</seealso>
        public virtual Task<GetMarketplaceModelEndpointResponse> GetMarketplaceModelEndpointAsync(GetMarketplaceModelEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMarketplaceModelEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMarketplaceModelEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetModelCopyJob


        /// <summary>
        /// Retrieves information about a model copy job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/copy-model.html">Copy
        /// models to be used in other regions</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelCopyJob service method.</param>
        /// 
        /// <returns>The response from the GetModelCopyJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelCopyJob">REST API Reference for GetModelCopyJob Operation</seealso>
        public virtual GetModelCopyJobResponse GetModelCopyJob(GetModelCopyJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelCopyJobResponseUnmarshaller.Instance;

            return Invoke<GetModelCopyJobResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a model copy job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/copy-model.html">Copy
        /// models to be used in other regions</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelCopyJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModelCopyJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelCopyJob">REST API Reference for GetModelCopyJob Operation</seealso>
        public virtual Task<GetModelCopyJobResponse> GetModelCopyJobAsync(GetModelCopyJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelCopyJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetModelCopyJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetModelCustomizationJob


        /// <summary>
        /// Retrieves the properties associated with a model-customization job, including the
        /// status of the job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelCustomizationJob service method.</param>
        /// 
        /// <returns>The response from the GetModelCustomizationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelCustomizationJob">REST API Reference for GetModelCustomizationJob Operation</seealso>
        public virtual GetModelCustomizationJobResponse GetModelCustomizationJob(GetModelCustomizationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelCustomizationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelCustomizationJobResponseUnmarshaller.Instance;

            return Invoke<GetModelCustomizationJobResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the properties associated with a model-customization job, including the
        /// status of the job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelCustomizationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModelCustomizationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelCustomizationJob">REST API Reference for GetModelCustomizationJob Operation</seealso>
        public virtual Task<GetModelCustomizationJobResponse> GetModelCustomizationJobAsync(GetModelCustomizationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelCustomizationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelCustomizationJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetModelCustomizationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetModelImportJob


        /// <summary>
        /// Retrieves the properties associated with import model job, including the status of
        /// the job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
        /// a customized model</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelImportJob service method.</param>
        /// 
        /// <returns>The response from the GetModelImportJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelImportJob">REST API Reference for GetModelImportJob Operation</seealso>
        public virtual GetModelImportJobResponse GetModelImportJob(GetModelImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelImportJobResponseUnmarshaller.Instance;

            return Invoke<GetModelImportJobResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the properties associated with import model job, including the status of
        /// the job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
        /// a customized model</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModelImportJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelImportJob">REST API Reference for GetModelImportJob Operation</seealso>
        public virtual Task<GetModelImportJobResponse> GetModelImportJobAsync(GetModelImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelImportJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetModelImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetModelInvocationJob


        /// <summary>
        /// Gets details about a batch inference job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-monitor">Monitor
        /// batch inference jobs</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelInvocationJob service method.</param>
        /// 
        /// <returns>The response from the GetModelInvocationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelInvocationJob">REST API Reference for GetModelInvocationJob Operation</seealso>
        public virtual GetModelInvocationJobResponse GetModelInvocationJob(GetModelInvocationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelInvocationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelInvocationJobResponseUnmarshaller.Instance;

            return Invoke<GetModelInvocationJobResponse>(request, options);
        }


        /// <summary>
        /// Gets details about a batch inference job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-monitor">Monitor
        /// batch inference jobs</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelInvocationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModelInvocationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelInvocationJob">REST API Reference for GetModelInvocationJob Operation</seealso>
        public virtual Task<GetModelInvocationJobResponse> GetModelInvocationJobAsync(GetModelInvocationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelInvocationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelInvocationJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetModelInvocationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetModelInvocationLoggingConfiguration


        /// <summary>
        /// Get the current configuration values for model invocation logging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelInvocationLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetModelInvocationLoggingConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelInvocationLoggingConfiguration">REST API Reference for GetModelInvocationLoggingConfiguration Operation</seealso>
        public virtual GetModelInvocationLoggingConfigurationResponse GetModelInvocationLoggingConfiguration(GetModelInvocationLoggingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelInvocationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelInvocationLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetModelInvocationLoggingConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Get the current configuration values for model invocation logging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelInvocationLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModelInvocationLoggingConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelInvocationLoggingConfiguration">REST API Reference for GetModelInvocationLoggingConfiguration Operation</seealso>
        public virtual Task<GetModelInvocationLoggingConfigurationResponse> GetModelInvocationLoggingConfigurationAsync(GetModelInvocationLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelInvocationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelInvocationLoggingConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetModelInvocationLoggingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPromptRouter


        /// <summary>
        /// Retrieves details about a prompt router.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPromptRouter service method.</param>
        /// 
        /// <returns>The response from the GetPromptRouter service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetPromptRouter">REST API Reference for GetPromptRouter Operation</seealso>
        public virtual GetPromptRouterResponse GetPromptRouter(GetPromptRouterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPromptRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPromptRouterResponseUnmarshaller.Instance;

            return Invoke<GetPromptRouterResponse>(request, options);
        }


        /// <summary>
        /// Retrieves details about a prompt router.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPromptRouter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPromptRouter service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetPromptRouter">REST API Reference for GetPromptRouter Operation</seealso>
        public virtual Task<GetPromptRouterResponse> GetPromptRouterAsync(GetPromptRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPromptRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPromptRouterResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPromptRouterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetProvisionedModelThroughput


        /// <summary>
        /// Returns details for a Provisioned Throughput. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProvisionedModelThroughput service method.</param>
        /// 
        /// <returns>The response from the GetProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetProvisionedModelThroughput">REST API Reference for GetProvisionedModelThroughput Operation</seealso>
        public virtual GetProvisionedModelThroughputResponse GetProvisionedModelThroughput(GetProvisionedModelThroughputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProvisionedModelThroughputResponseUnmarshaller.Instance;

            return Invoke<GetProvisionedModelThroughputResponse>(request, options);
        }


        /// <summary>
        /// Returns details for a Provisioned Throughput. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProvisionedModelThroughput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetProvisionedModelThroughput">REST API Reference for GetProvisionedModelThroughput Operation</seealso>
        public virtual Task<GetProvisionedModelThroughputResponse> GetProvisionedModelThroughputAsync(GetProvisionedModelThroughputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProvisionedModelThroughputResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetProvisionedModelThroughputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUseCaseForModelAccess


        /// <summary>
        /// Get usecase for model access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUseCaseForModelAccess service method.</param>
        /// 
        /// <returns>The response from the GetUseCaseForModelAccess service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetUseCaseForModelAccess">REST API Reference for GetUseCaseForModelAccess Operation</seealso>
        public virtual GetUseCaseForModelAccessResponse GetUseCaseForModelAccess(GetUseCaseForModelAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUseCaseForModelAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUseCaseForModelAccessResponseUnmarshaller.Instance;

            return Invoke<GetUseCaseForModelAccessResponse>(request, options);
        }


        /// <summary>
        /// Get usecase for model access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUseCaseForModelAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUseCaseForModelAccess service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetUseCaseForModelAccess">REST API Reference for GetUseCaseForModelAccess Operation</seealso>
        public virtual Task<GetUseCaseForModelAccessResponse> GetUseCaseForModelAccessAsync(GetUseCaseForModelAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUseCaseForModelAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUseCaseForModelAccessResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetUseCaseForModelAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAutomatedReasoningPolicies


        /// <summary>
        /// Lists all Automated Reasoning policies in your account, with optional filtering by
        /// policy ARN. This helps you manage and discover existing policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAutomatedReasoningPolicies service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicies">REST API Reference for ListAutomatedReasoningPolicies Operation</seealso>
        public virtual ListAutomatedReasoningPoliciesResponse ListAutomatedReasoningPolicies(ListAutomatedReasoningPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAutomatedReasoningPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Lists all Automated Reasoning policies in your account, with optional filtering by
        /// policy ARN. This helps you manage and discover existing policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomatedReasoningPolicies service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicies">REST API Reference for ListAutomatedReasoningPolicies Operation</seealso>
        public virtual Task<ListAutomatedReasoningPoliciesResponse> ListAutomatedReasoningPoliciesAsync(ListAutomatedReasoningPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPoliciesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAutomatedReasoningPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAutomatedReasoningPolicyBuildWorkflows


        /// <summary>
        /// Lists all build workflows for an Automated Reasoning policy, showing the history of
        /// policy creation and modification attempts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicyBuildWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListAutomatedReasoningPolicyBuildWorkflows service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicyBuildWorkflows">REST API Reference for ListAutomatedReasoningPolicyBuildWorkflows Operation</seealso>
        public virtual ListAutomatedReasoningPolicyBuildWorkflowsResponse ListAutomatedReasoningPolicyBuildWorkflows(ListAutomatedReasoningPolicyBuildWorkflowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPolicyBuildWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPolicyBuildWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListAutomatedReasoningPolicyBuildWorkflowsResponse>(request, options);
        }


        /// <summary>
        /// Lists all build workflows for an Automated Reasoning policy, showing the history of
        /// policy creation and modification attempts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicyBuildWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomatedReasoningPolicyBuildWorkflows service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicyBuildWorkflows">REST API Reference for ListAutomatedReasoningPolicyBuildWorkflows Operation</seealso>
        public virtual Task<ListAutomatedReasoningPolicyBuildWorkflowsResponse> ListAutomatedReasoningPolicyBuildWorkflowsAsync(ListAutomatedReasoningPolicyBuildWorkflowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPolicyBuildWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPolicyBuildWorkflowsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAutomatedReasoningPolicyBuildWorkflowsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAutomatedReasoningPolicyTestCases


        /// <summary>
        /// Lists tests for an Automated Reasoning policy. We recommend using pagination to ensure
        /// that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicyTestCases service method.</param>
        /// 
        /// <returns>The response from the ListAutomatedReasoningPolicyTestCases service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicyTestCases">REST API Reference for ListAutomatedReasoningPolicyTestCases Operation</seealso>
        public virtual ListAutomatedReasoningPolicyTestCasesResponse ListAutomatedReasoningPolicyTestCases(ListAutomatedReasoningPolicyTestCasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPolicyTestCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPolicyTestCasesResponseUnmarshaller.Instance;

            return Invoke<ListAutomatedReasoningPolicyTestCasesResponse>(request, options);
        }


        /// <summary>
        /// Lists tests for an Automated Reasoning policy. We recommend using pagination to ensure
        /// that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicyTestCases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomatedReasoningPolicyTestCases service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicyTestCases">REST API Reference for ListAutomatedReasoningPolicyTestCases Operation</seealso>
        public virtual Task<ListAutomatedReasoningPolicyTestCasesResponse> ListAutomatedReasoningPolicyTestCasesAsync(ListAutomatedReasoningPolicyTestCasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPolicyTestCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPolicyTestCasesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAutomatedReasoningPolicyTestCasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAutomatedReasoningPolicyTestResults


        /// <summary>
        /// Lists test results for an Automated Reasoning policy, showing how the policy performed
        /// against various test scenarios and validation checks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicyTestResults service method.</param>
        /// 
        /// <returns>The response from the ListAutomatedReasoningPolicyTestResults service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicyTestResults">REST API Reference for ListAutomatedReasoningPolicyTestResults Operation</seealso>
        public virtual ListAutomatedReasoningPolicyTestResultsResponse ListAutomatedReasoningPolicyTestResults(ListAutomatedReasoningPolicyTestResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPolicyTestResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPolicyTestResultsResponseUnmarshaller.Instance;

            return Invoke<ListAutomatedReasoningPolicyTestResultsResponse>(request, options);
        }


        /// <summary>
        /// Lists test results for an Automated Reasoning policy, showing how the policy performed
        /// against various test scenarios and validation checks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicyTestResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomatedReasoningPolicyTestResults service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicyTestResults">REST API Reference for ListAutomatedReasoningPolicyTestResults Operation</seealso>
        public virtual Task<ListAutomatedReasoningPolicyTestResultsResponse> ListAutomatedReasoningPolicyTestResultsAsync(ListAutomatedReasoningPolicyTestResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPolicyTestResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPolicyTestResultsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAutomatedReasoningPolicyTestResultsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCustomModelDeployments


        /// <summary>
        /// Lists custom model deployments in your account. You can filter the results by creation
        /// time, name, status, and associated model. Use this operation to manage and monitor
        /// your custom model deployments.
        /// 
        ///  
        /// <para>
        /// We recommend using pagination to ensure that the operation returns quickly and successfully.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to the <c>ListCustomModelDeployments</c> operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateCustomModelDeployment.html">CreateCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetCustomModelDeployment.html">GetCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModelDeployment.html">DeleteCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomModelDeployments service method.</param>
        /// 
        /// <returns>The response from the ListCustomModelDeployments service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListCustomModelDeployments">REST API Reference for ListCustomModelDeployments Operation</seealso>
        public virtual ListCustomModelDeploymentsResponse ListCustomModelDeployments(ListCustomModelDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomModelDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomModelDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListCustomModelDeploymentsResponse>(request, options);
        }


        /// <summary>
        /// Lists custom model deployments in your account. You can filter the results by creation
        /// time, name, status, and associated model. Use this operation to manage and monitor
        /// your custom model deployments.
        /// 
        ///  
        /// <para>
        /// We recommend using pagination to ensure that the operation returns quickly and successfully.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to the <c>ListCustomModelDeployments</c> operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateCustomModelDeployment.html">CreateCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetCustomModelDeployment.html">GetCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModelDeployment.html">DeleteCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomModelDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomModelDeployments service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListCustomModelDeployments">REST API Reference for ListCustomModelDeployments Operation</seealso>
        public virtual Task<ListCustomModelDeploymentsResponse> ListCustomModelDeploymentsAsync(ListCustomModelDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomModelDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomModelDeploymentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCustomModelDeploymentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCustomModels


        /// <summary>
        /// Returns a list of the custom models that you have created with the <c>CreateModelCustomizationJob</c>
        /// operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomModels service method.</param>
        /// 
        /// <returns>The response from the ListCustomModels service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListCustomModels">REST API Reference for ListCustomModels Operation</seealso>
        public virtual ListCustomModelsResponse ListCustomModels(ListCustomModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomModelsResponseUnmarshaller.Instance;

            return Invoke<ListCustomModelsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the custom models that you have created with the <c>CreateModelCustomizationJob</c>
        /// operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomModels service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListCustomModels">REST API Reference for ListCustomModels Operation</seealso>
        public virtual Task<ListCustomModelsResponse> ListCustomModelsAsync(ListCustomModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomModelsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCustomModelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEvaluationJobs


        /// <summary>
        /// Lists all existing evaluation jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEvaluationJobs service method.</param>
        /// 
        /// <returns>The response from the ListEvaluationJobs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListEvaluationJobs">REST API Reference for ListEvaluationJobs Operation</seealso>
        public virtual ListEvaluationJobsResponse ListEvaluationJobs(ListEvaluationJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEvaluationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEvaluationJobsResponseUnmarshaller.Instance;

            return Invoke<ListEvaluationJobsResponse>(request, options);
        }


        /// <summary>
        /// Lists all existing evaluation jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEvaluationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEvaluationJobs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListEvaluationJobs">REST API Reference for ListEvaluationJobs Operation</seealso>
        public virtual Task<ListEvaluationJobsResponse> ListEvaluationJobsAsync(ListEvaluationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEvaluationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEvaluationJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEvaluationJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFoundationModelAgreementOffers


        /// <summary>
        /// Get the offers associated with the specified model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFoundationModelAgreementOffers service method.</param>
        /// 
        /// <returns>The response from the ListFoundationModelAgreementOffers service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListFoundationModelAgreementOffers">REST API Reference for ListFoundationModelAgreementOffers Operation</seealso>
        public virtual ListFoundationModelAgreementOffersResponse ListFoundationModelAgreementOffers(ListFoundationModelAgreementOffersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFoundationModelAgreementOffersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFoundationModelAgreementOffersResponseUnmarshaller.Instance;

            return Invoke<ListFoundationModelAgreementOffersResponse>(request, options);
        }


        /// <summary>
        /// Get the offers associated with the specified model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFoundationModelAgreementOffers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFoundationModelAgreementOffers service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListFoundationModelAgreementOffers">REST API Reference for ListFoundationModelAgreementOffers Operation</seealso>
        public virtual Task<ListFoundationModelAgreementOffersResponse> ListFoundationModelAgreementOffersAsync(ListFoundationModelAgreementOffersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFoundationModelAgreementOffersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFoundationModelAgreementOffersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFoundationModelAgreementOffersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFoundationModels


        /// <summary>
        /// Lists Amazon Bedrock foundation models that you can use. You can filter the results
        /// with the request parameters. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/foundation-models.html">Foundation
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFoundationModels service method.</param>
        /// 
        /// <returns>The response from the ListFoundationModels service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListFoundationModels">REST API Reference for ListFoundationModels Operation</seealso>
        public virtual ListFoundationModelsResponse ListFoundationModels(ListFoundationModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFoundationModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFoundationModelsResponseUnmarshaller.Instance;

            return Invoke<ListFoundationModelsResponse>(request, options);
        }


        /// <summary>
        /// Lists Amazon Bedrock foundation models that you can use. You can filter the results
        /// with the request parameters. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/foundation-models.html">Foundation
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFoundationModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFoundationModels service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListFoundationModels">REST API Reference for ListFoundationModels Operation</seealso>
        public virtual Task<ListFoundationModelsResponse> ListFoundationModelsAsync(ListFoundationModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFoundationModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFoundationModelsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFoundationModelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGuardrails


        /// <summary>
        /// Lists details about all the guardrails in an account. To list the <c>DRAFT</c> version
        /// of all your guardrails, don't specify the <c>guardrailIdentifier</c> field. To list
        /// all versions of a guardrail, specify the ARN of the guardrail in the <c>guardrailIdentifier</c>
        /// field.
        /// 
        ///  
        /// <para>
        /// You can set the maximum number of results to return in a response in the <c>maxResults</c>
        /// field. If there are more results than the number you set, the response returns a <c>nextToken</c>
        /// that you can send in another <c>ListGuardrails</c> request to see the next batch of
        /// results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGuardrails service method.</param>
        /// 
        /// <returns>The response from the ListGuardrails service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListGuardrails">REST API Reference for ListGuardrails Operation</seealso>
        public virtual ListGuardrailsResponse ListGuardrails(ListGuardrailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGuardrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGuardrailsResponseUnmarshaller.Instance;

            return Invoke<ListGuardrailsResponse>(request, options);
        }


        /// <summary>
        /// Lists details about all the guardrails in an account. To list the <c>DRAFT</c> version
        /// of all your guardrails, don't specify the <c>guardrailIdentifier</c> field. To list
        /// all versions of a guardrail, specify the ARN of the guardrail in the <c>guardrailIdentifier</c>
        /// field.
        /// 
        ///  
        /// <para>
        /// You can set the maximum number of results to return in a response in the <c>maxResults</c>
        /// field. If there are more results than the number you set, the response returns a <c>nextToken</c>
        /// that you can send in another <c>ListGuardrails</c> request to see the next batch of
        /// results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGuardrails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGuardrails service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListGuardrails">REST API Reference for ListGuardrails Operation</seealso>
        public virtual Task<ListGuardrailsResponse> ListGuardrailsAsync(ListGuardrailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGuardrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGuardrailsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListGuardrailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListImportedModels


        /// <summary>
        /// Returns a list of models you've imported. You can filter the results to return based
        /// on one or more criteria. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
        /// a customized model</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportedModels service method.</param>
        /// 
        /// <returns>The response from the ListImportedModels service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListImportedModels">REST API Reference for ListImportedModels Operation</seealso>
        public virtual ListImportedModelsResponse ListImportedModels(ListImportedModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportedModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportedModelsResponseUnmarshaller.Instance;

            return Invoke<ListImportedModelsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of models you've imported. You can filter the results to return based
        /// on one or more criteria. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
        /// a customized model</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportedModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImportedModels service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListImportedModels">REST API Reference for ListImportedModels Operation</seealso>
        public virtual Task<ListImportedModelsResponse> ListImportedModelsAsync(ListImportedModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportedModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportedModelsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListImportedModelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInferenceProfiles


        /// <summary>
        /// Returns a list of inference profiles that you can use. For more information, see <a
        /// href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
        /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
        /// Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListInferenceProfiles service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListInferenceProfiles">REST API Reference for ListInferenceProfiles Operation</seealso>
        public virtual ListInferenceProfilesResponse ListInferenceProfiles(ListInferenceProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInferenceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceProfilesResponseUnmarshaller.Instance;

            return Invoke<ListInferenceProfilesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of inference profiles that you can use. For more information, see <a
        /// href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
        /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
        /// Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInferenceProfiles service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListInferenceProfiles">REST API Reference for ListInferenceProfiles Operation</seealso>
        public virtual Task<ListInferenceProfilesResponse> ListInferenceProfilesAsync(ListInferenceProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInferenceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceProfilesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListInferenceProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMarketplaceModelEndpoints


        /// <summary>
        /// Lists the endpoints for models from Amazon Bedrock Marketplace in your Amazon Web
        /// Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMarketplaceModelEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListMarketplaceModelEndpoints service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListMarketplaceModelEndpoints">REST API Reference for ListMarketplaceModelEndpoints Operation</seealso>
        public virtual ListMarketplaceModelEndpointsResponse ListMarketplaceModelEndpoints(ListMarketplaceModelEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMarketplaceModelEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMarketplaceModelEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListMarketplaceModelEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Lists the endpoints for models from Amazon Bedrock Marketplace in your Amazon Web
        /// Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMarketplaceModelEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMarketplaceModelEndpoints service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListMarketplaceModelEndpoints">REST API Reference for ListMarketplaceModelEndpoints Operation</seealso>
        public virtual Task<ListMarketplaceModelEndpointsResponse> ListMarketplaceModelEndpointsAsync(ListMarketplaceModelEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMarketplaceModelEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMarketplaceModelEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMarketplaceModelEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModelCopyJobs


        /// <summary>
        /// Returns a list of model copy jobs that you have submitted. You can filter the jobs
        /// to return based on one or more criteria. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/copy-model.html">Copy
        /// models to be used in other regions</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelCopyJobs service method.</param>
        /// 
        /// <returns>The response from the ListModelCopyJobs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelCopyJobs">REST API Reference for ListModelCopyJobs Operation</seealso>
        public virtual ListModelCopyJobsResponse ListModelCopyJobs(ListModelCopyJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelCopyJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelCopyJobsResponseUnmarshaller.Instance;

            return Invoke<ListModelCopyJobsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of model copy jobs that you have submitted. You can filter the jobs
        /// to return based on one or more criteria. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/copy-model.html">Copy
        /// models to be used in other regions</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelCopyJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelCopyJobs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelCopyJobs">REST API Reference for ListModelCopyJobs Operation</seealso>
        public virtual Task<ListModelCopyJobsResponse> ListModelCopyJobsAsync(ListModelCopyJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelCopyJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelCopyJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListModelCopyJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModelCustomizationJobs


        /// <summary>
        /// Returns a list of model customization jobs that you have submitted. You can filter
        /// the jobs to return based on one or more criteria.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelCustomizationJobs service method.</param>
        /// 
        /// <returns>The response from the ListModelCustomizationJobs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelCustomizationJobs">REST API Reference for ListModelCustomizationJobs Operation</seealso>
        public virtual ListModelCustomizationJobsResponse ListModelCustomizationJobs(ListModelCustomizationJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelCustomizationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelCustomizationJobsResponseUnmarshaller.Instance;

            return Invoke<ListModelCustomizationJobsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of model customization jobs that you have submitted. You can filter
        /// the jobs to return based on one or more criteria.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelCustomizationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelCustomizationJobs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelCustomizationJobs">REST API Reference for ListModelCustomizationJobs Operation</seealso>
        public virtual Task<ListModelCustomizationJobsResponse> ListModelCustomizationJobsAsync(ListModelCustomizationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelCustomizationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelCustomizationJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListModelCustomizationJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModelImportJobs


        /// <summary>
        /// Returns a list of import jobs you've submitted. You can filter the results to return
        /// based on one or more criteria. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
        /// a customized model</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListModelImportJobs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelImportJobs">REST API Reference for ListModelImportJobs Operation</seealso>
        public virtual ListModelImportJobsResponse ListModelImportJobs(ListModelImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListModelImportJobsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of import jobs you've submitted. You can filter the results to return
        /// based on one or more criteria. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
        /// a customized model</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelImportJobs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelImportJobs">REST API Reference for ListModelImportJobs Operation</seealso>
        public virtual Task<ListModelImportJobsResponse> ListModelImportJobsAsync(ListModelImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelImportJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListModelImportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModelInvocationJobs


        /// <summary>
        /// Lists all batch inference jobs in the account. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-view.html">View
        /// details about a batch inference job</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelInvocationJobs service method.</param>
        /// 
        /// <returns>The response from the ListModelInvocationJobs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelInvocationJobs">REST API Reference for ListModelInvocationJobs Operation</seealso>
        public virtual ListModelInvocationJobsResponse ListModelInvocationJobs(ListModelInvocationJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelInvocationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelInvocationJobsResponseUnmarshaller.Instance;

            return Invoke<ListModelInvocationJobsResponse>(request, options);
        }


        /// <summary>
        /// Lists all batch inference jobs in the account. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-view.html">View
        /// details about a batch inference job</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelInvocationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelInvocationJobs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelInvocationJobs">REST API Reference for ListModelInvocationJobs Operation</seealso>
        public virtual Task<ListModelInvocationJobsResponse> ListModelInvocationJobsAsync(ListModelInvocationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelInvocationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelInvocationJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListModelInvocationJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPromptRouters


        /// <summary>
        /// Retrieves a list of prompt routers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPromptRouters service method.</param>
        /// 
        /// <returns>The response from the ListPromptRouters service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListPromptRouters">REST API Reference for ListPromptRouters Operation</seealso>
        public virtual ListPromptRoutersResponse ListPromptRouters(ListPromptRoutersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPromptRoutersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPromptRoutersResponseUnmarshaller.Instance;

            return Invoke<ListPromptRoutersResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of prompt routers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPromptRouters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPromptRouters service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListPromptRouters">REST API Reference for ListPromptRouters Operation</seealso>
        public virtual Task<ListPromptRoutersResponse> ListPromptRoutersAsync(ListPromptRoutersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPromptRoutersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPromptRoutersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPromptRoutersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProvisionedModelThroughputs


        /// <summary>
        /// Lists the Provisioned Throughputs in the account. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedModelThroughputs service method.</param>
        /// 
        /// <returns>The response from the ListProvisionedModelThroughputs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListProvisionedModelThroughputs">REST API Reference for ListProvisionedModelThroughputs Operation</seealso>
        public virtual ListProvisionedModelThroughputsResponse ListProvisionedModelThroughputs(ListProvisionedModelThroughputsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProvisionedModelThroughputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedModelThroughputsResponseUnmarshaller.Instance;

            return Invoke<ListProvisionedModelThroughputsResponse>(request, options);
        }


        /// <summary>
        /// Lists the Provisioned Throughputs in the account. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedModelThroughputs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProvisionedModelThroughputs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListProvisionedModelThroughputs">REST API Reference for ListProvisionedModelThroughputs Operation</seealso>
        public virtual Task<ListProvisionedModelThroughputsResponse> ListProvisionedModelThroughputsAsync(ListProvisionedModelThroughputsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProvisionedModelThroughputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedModelThroughputsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProvisionedModelThroughputsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List the tags associated with the specified resource.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// List the tags associated with the specified resource.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutModelInvocationLoggingConfiguration


        /// <summary>
        /// Set the configuration values for model invocation logging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutModelInvocationLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutModelInvocationLoggingConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/PutModelInvocationLoggingConfiguration">REST API Reference for PutModelInvocationLoggingConfiguration Operation</seealso>
        public virtual PutModelInvocationLoggingConfigurationResponse PutModelInvocationLoggingConfiguration(PutModelInvocationLoggingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutModelInvocationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutModelInvocationLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutModelInvocationLoggingConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Set the configuration values for model invocation logging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutModelInvocationLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutModelInvocationLoggingConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/PutModelInvocationLoggingConfiguration">REST API Reference for PutModelInvocationLoggingConfiguration Operation</seealso>
        public virtual Task<PutModelInvocationLoggingConfigurationResponse> PutModelInvocationLoggingConfigurationAsync(PutModelInvocationLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutModelInvocationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutModelInvocationLoggingConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutModelInvocationLoggingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutUseCaseForModelAccess


        /// <summary>
        /// Put usecase for model access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUseCaseForModelAccess service method.</param>
        /// 
        /// <returns>The response from the PutUseCaseForModelAccess service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/PutUseCaseForModelAccess">REST API Reference for PutUseCaseForModelAccess Operation</seealso>
        public virtual PutUseCaseForModelAccessResponse PutUseCaseForModelAccess(PutUseCaseForModelAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutUseCaseForModelAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUseCaseForModelAccessResponseUnmarshaller.Instance;

            return Invoke<PutUseCaseForModelAccessResponse>(request, options);
        }


        /// <summary>
        /// Put usecase for model access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUseCaseForModelAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutUseCaseForModelAccess service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/PutUseCaseForModelAccess">REST API Reference for PutUseCaseForModelAccess Operation</seealso>
        public virtual Task<PutUseCaseForModelAccessResponse> PutUseCaseForModelAccessAsync(PutUseCaseForModelAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutUseCaseForModelAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUseCaseForModelAccessResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutUseCaseForModelAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterMarketplaceModelEndpoint


        /// <summary>
        /// Registers an existing Amazon SageMaker endpoint with Amazon Bedrock Marketplace, allowing
        /// it to be used with Amazon Bedrock APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterMarketplaceModelEndpoint service method.</param>
        /// 
        /// <returns>The response from the RegisterMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/RegisterMarketplaceModelEndpoint">REST API Reference for RegisterMarketplaceModelEndpoint Operation</seealso>
        public virtual RegisterMarketplaceModelEndpointResponse RegisterMarketplaceModelEndpoint(RegisterMarketplaceModelEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return Invoke<RegisterMarketplaceModelEndpointResponse>(request, options);
        }


        /// <summary>
        /// Registers an existing Amazon SageMaker endpoint with Amazon Bedrock Marketplace, allowing
        /// it to be used with Amazon Bedrock APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterMarketplaceModelEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/RegisterMarketplaceModelEndpoint">REST API Reference for RegisterMarketplaceModelEndpoint Operation</seealso>
        public virtual Task<RegisterMarketplaceModelEndpointResponse> RegisterMarketplaceModelEndpointAsync(RegisterMarketplaceModelEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterMarketplaceModelEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterMarketplaceModelEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartAutomatedReasoningPolicyBuildWorkflow


        /// <summary>
        /// Starts a new build workflow for an Automated Reasoning policy. This initiates the
        /// process of analyzing source documents and generating policy rules, variables, and
        /// types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutomatedReasoningPolicyBuildWorkflow service method.</param>
        /// 
        /// <returns>The response from the StartAutomatedReasoningPolicyBuildWorkflow service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StartAutomatedReasoningPolicyBuildWorkflow">REST API Reference for StartAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual StartAutomatedReasoningPolicyBuildWorkflowResponse StartAutomatedReasoningPolicyBuildWorkflow(StartAutomatedReasoningPolicyBuildWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;

            return Invoke<StartAutomatedReasoningPolicyBuildWorkflowResponse>(request, options);
        }


        /// <summary>
        /// Starts a new build workflow for an Automated Reasoning policy. This initiates the
        /// process of analyzing source documents and generating policy rules, variables, and
        /// types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutomatedReasoningPolicyBuildWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAutomatedReasoningPolicyBuildWorkflow service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StartAutomatedReasoningPolicyBuildWorkflow">REST API Reference for StartAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual Task<StartAutomatedReasoningPolicyBuildWorkflowResponse> StartAutomatedReasoningPolicyBuildWorkflowAsync(StartAutomatedReasoningPolicyBuildWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartAutomatedReasoningPolicyBuildWorkflowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartAutomatedReasoningPolicyTestWorkflow


        /// <summary>
        /// Initiates a test workflow to validate Automated Reasoning policy tests. The workflow
        /// executes the specified tests against the policy and generates validation results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutomatedReasoningPolicyTestWorkflow service method.</param>
        /// 
        /// <returns>The response from the StartAutomatedReasoningPolicyTestWorkflow service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StartAutomatedReasoningPolicyTestWorkflow">REST API Reference for StartAutomatedReasoningPolicyTestWorkflow Operation</seealso>
        public virtual StartAutomatedReasoningPolicyTestWorkflowResponse StartAutomatedReasoningPolicyTestWorkflow(StartAutomatedReasoningPolicyTestWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAutomatedReasoningPolicyTestWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutomatedReasoningPolicyTestWorkflowResponseUnmarshaller.Instance;

            return Invoke<StartAutomatedReasoningPolicyTestWorkflowResponse>(request, options);
        }


        /// <summary>
        /// Initiates a test workflow to validate Automated Reasoning policy tests. The workflow
        /// executes the specified tests against the policy and generates validation results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutomatedReasoningPolicyTestWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAutomatedReasoningPolicyTestWorkflow service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StartAutomatedReasoningPolicyTestWorkflow">REST API Reference for StartAutomatedReasoningPolicyTestWorkflow Operation</seealso>
        public virtual Task<StartAutomatedReasoningPolicyTestWorkflowResponse> StartAutomatedReasoningPolicyTestWorkflowAsync(StartAutomatedReasoningPolicyTestWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAutomatedReasoningPolicyTestWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutomatedReasoningPolicyTestWorkflowResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartAutomatedReasoningPolicyTestWorkflowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopEvaluationJob


        /// <summary>
        /// Stops an evaluation job that is current being created or running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEvaluationJob service method.</param>
        /// 
        /// <returns>The response from the StopEvaluationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopEvaluationJob">REST API Reference for StopEvaluationJob Operation</seealso>
        public virtual StopEvaluationJobResponse StopEvaluationJob(StopEvaluationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEvaluationJobResponseUnmarshaller.Instance;

            return Invoke<StopEvaluationJobResponse>(request, options);
        }


        /// <summary>
        /// Stops an evaluation job that is current being created or running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEvaluationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopEvaluationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopEvaluationJob">REST API Reference for StopEvaluationJob Operation</seealso>
        public virtual Task<StopEvaluationJobResponse> StopEvaluationJobAsync(StopEvaluationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEvaluationJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopEvaluationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopModelCustomizationJob


        /// <summary>
        /// Stops an active model customization job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopModelCustomizationJob service method.</param>
        /// 
        /// <returns>The response from the StopModelCustomizationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopModelCustomizationJob">REST API Reference for StopModelCustomizationJob Operation</seealso>
        public virtual StopModelCustomizationJobResponse StopModelCustomizationJob(StopModelCustomizationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopModelCustomizationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopModelCustomizationJobResponseUnmarshaller.Instance;

            return Invoke<StopModelCustomizationJobResponse>(request, options);
        }


        /// <summary>
        /// Stops an active model customization job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopModelCustomizationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopModelCustomizationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopModelCustomizationJob">REST API Reference for StopModelCustomizationJob Operation</seealso>
        public virtual Task<StopModelCustomizationJobResponse> StopModelCustomizationJobAsync(StopModelCustomizationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopModelCustomizationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopModelCustomizationJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopModelCustomizationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopModelInvocationJob


        /// <summary>
        /// Stops a batch inference job. You're only charged for tokens that were already processed.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-stop.html">Stop
        /// a batch inference job</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopModelInvocationJob service method.</param>
        /// 
        /// <returns>The response from the StopModelInvocationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopModelInvocationJob">REST API Reference for StopModelInvocationJob Operation</seealso>
        public virtual StopModelInvocationJobResponse StopModelInvocationJob(StopModelInvocationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopModelInvocationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopModelInvocationJobResponseUnmarshaller.Instance;

            return Invoke<StopModelInvocationJobResponse>(request, options);
        }


        /// <summary>
        /// Stops a batch inference job. You're only charged for tokens that were already processed.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-stop.html">Stop
        /// a batch inference job</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopModelInvocationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopModelInvocationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopModelInvocationJob">REST API Reference for StopModelInvocationJob Operation</seealso>
        public virtual Task<StopModelInvocationJobResponse> StopModelInvocationJobAsync(StopModelInvocationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopModelInvocationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopModelInvocationJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopModelInvocationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associate tags with a resource. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Associate tags with a resource. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Remove one or more tags from a resource. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Remove one or more tags from a resource. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAutomatedReasoningPolicy


        /// <summary>
        /// Updates an existing Automated Reasoning policy with new rules, variables, or configuration.
        /// This creates a new version of the policy while preserving the previous version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedReasoningPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAutomatedReasoningPolicy service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateAutomatedReasoningPolicy">REST API Reference for UpdateAutomatedReasoningPolicy Operation</seealso>
        public virtual UpdateAutomatedReasoningPolicyResponse UpdateAutomatedReasoningPolicy(UpdateAutomatedReasoningPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomatedReasoningPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateAutomatedReasoningPolicyResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing Automated Reasoning policy with new rules, variables, or configuration.
        /// This creates a new version of the policy while preserving the previous version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedReasoningPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAutomatedReasoningPolicy service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateAutomatedReasoningPolicy">REST API Reference for UpdateAutomatedReasoningPolicy Operation</seealso>
        public virtual Task<UpdateAutomatedReasoningPolicyResponse> UpdateAutomatedReasoningPolicyAsync(UpdateAutomatedReasoningPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomatedReasoningPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAutomatedReasoningPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAutomatedReasoningPolicyAnnotations


        /// <summary>
        /// Updates the annotations for an Automated Reasoning policy build workflow. This allows
        /// you to modify extracted rules, variables, and types before finalizing the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedReasoningPolicyAnnotations service method.</param>
        /// 
        /// <returns>The response from the UpdateAutomatedReasoningPolicyAnnotations service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateAutomatedReasoningPolicyAnnotations">REST API Reference for UpdateAutomatedReasoningPolicyAnnotations Operation</seealso>
        public virtual UpdateAutomatedReasoningPolicyAnnotationsResponse UpdateAutomatedReasoningPolicyAnnotations(UpdateAutomatedReasoningPolicyAnnotationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomatedReasoningPolicyAnnotationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomatedReasoningPolicyAnnotationsResponseUnmarshaller.Instance;

            return Invoke<UpdateAutomatedReasoningPolicyAnnotationsResponse>(request, options);
        }


        /// <summary>
        /// Updates the annotations for an Automated Reasoning policy build workflow. This allows
        /// you to modify extracted rules, variables, and types before finalizing the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedReasoningPolicyAnnotations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAutomatedReasoningPolicyAnnotations service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateAutomatedReasoningPolicyAnnotations">REST API Reference for UpdateAutomatedReasoningPolicyAnnotations Operation</seealso>
        public virtual Task<UpdateAutomatedReasoningPolicyAnnotationsResponse> UpdateAutomatedReasoningPolicyAnnotationsAsync(UpdateAutomatedReasoningPolicyAnnotationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomatedReasoningPolicyAnnotationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomatedReasoningPolicyAnnotationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAutomatedReasoningPolicyAnnotationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAutomatedReasoningPolicyTestCase


        /// <summary>
        /// Updates an existing Automated Reasoning policy test. You can modify the content, query,
        /// expected result, and confidence threshold.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedReasoningPolicyTestCase service method.</param>
        /// 
        /// <returns>The response from the UpdateAutomatedReasoningPolicyTestCase service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateAutomatedReasoningPolicyTestCase">REST API Reference for UpdateAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual UpdateAutomatedReasoningPolicyTestCaseResponse UpdateAutomatedReasoningPolicyTestCase(UpdateAutomatedReasoningPolicyTestCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;

            return Invoke<UpdateAutomatedReasoningPolicyTestCaseResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing Automated Reasoning policy test. You can modify the content, query,
        /// expected result, and confidence threshold.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedReasoningPolicyTestCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAutomatedReasoningPolicyTestCase service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateAutomatedReasoningPolicyTestCase">REST API Reference for UpdateAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual Task<UpdateAutomatedReasoningPolicyTestCaseResponse> UpdateAutomatedReasoningPolicyTestCaseAsync(UpdateAutomatedReasoningPolicyTestCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAutomatedReasoningPolicyTestCaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGuardrail


        /// <summary>
        /// Updates a guardrail with the values you specify.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Specify a <c>name</c> and optional <c>description</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify messages for when the guardrail successfully blocks a prompt or a model response
        /// in the <c>blockedInputMessaging</c> and <c>blockedOutputsMessaging</c> fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify topics for the guardrail to deny in the <c>topicPolicyConfig</c> object. Each
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailTopicConfig.html">GuardrailTopicConfig</a>
        /// object in the <c>topicsConfig</c> list pertains to one topic.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Give a <c>name</c> and <c>description</c> so that the guardrail can properly identify
        /// the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <c>DENY</c> in the <c>type</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Provide up to five prompts that you would categorize as belonging to the
        /// topic in the <c>examples</c> list.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Specify filter strengths for the harmful categories defined in Amazon Bedrock in the
        /// <c>contentPolicyConfig</c> object. Each <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailContentFilterConfig.html">GuardrailContentFilterConfig</a>
        /// object in the <c>filtersConfig</c> list pertains to a harmful category. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails-content-filters">Content
        /// filters</a>. For more information about the fields in a content filter, see <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailContentFilterConfig.html">GuardrailContentFilterConfig</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the category in the <c>type</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify the strength of the filter for prompts in the <c>inputStrength</c> field and
        /// for model responses in the <c>strength</c> field of the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailContentFilterConfig.html">GuardrailContentFilterConfig</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// (Optional) For security, include the ARN of a KMS key in the <c>kmsKeyId</c> field.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGuardrail service method.</param>
        /// 
        /// <returns>The response from the UpdateGuardrail service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateGuardrail">REST API Reference for UpdateGuardrail Operation</seealso>
        public virtual UpdateGuardrailResponse UpdateGuardrail(UpdateGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGuardrailResponseUnmarshaller.Instance;

            return Invoke<UpdateGuardrailResponse>(request, options);
        }


        /// <summary>
        /// Updates a guardrail with the values you specify.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Specify a <c>name</c> and optional <c>description</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify messages for when the guardrail successfully blocks a prompt or a model response
        /// in the <c>blockedInputMessaging</c> and <c>blockedOutputsMessaging</c> fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify topics for the guardrail to deny in the <c>topicPolicyConfig</c> object. Each
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailTopicConfig.html">GuardrailTopicConfig</a>
        /// object in the <c>topicsConfig</c> list pertains to one topic.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Give a <c>name</c> and <c>description</c> so that the guardrail can properly identify
        /// the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <c>DENY</c> in the <c>type</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Provide up to five prompts that you would categorize as belonging to the
        /// topic in the <c>examples</c> list.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Specify filter strengths for the harmful categories defined in Amazon Bedrock in the
        /// <c>contentPolicyConfig</c> object. Each <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailContentFilterConfig.html">GuardrailContentFilterConfig</a>
        /// object in the <c>filtersConfig</c> list pertains to a harmful category. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails-content-filters">Content
        /// filters</a>. For more information about the fields in a content filter, see <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailContentFilterConfig.html">GuardrailContentFilterConfig</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the category in the <c>type</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify the strength of the filter for prompts in the <c>inputStrength</c> field and
        /// for model responses in the <c>strength</c> field of the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailContentFilterConfig.html">GuardrailContentFilterConfig</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// (Optional) For security, include the ARN of a KMS key in the <c>kmsKeyId</c> field.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGuardrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGuardrail service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateGuardrail">REST API Reference for UpdateGuardrail Operation</seealso>
        public virtual Task<UpdateGuardrailResponse> UpdateGuardrailAsync(UpdateGuardrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGuardrailResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateGuardrailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMarketplaceModelEndpoint


        /// <summary>
        /// Updates the configuration of an existing endpoint for a model from Amazon Bedrock
        /// Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMarketplaceModelEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateMarketplaceModelEndpoint">REST API Reference for UpdateMarketplaceModelEndpoint Operation</seealso>
        public virtual UpdateMarketplaceModelEndpointResponse UpdateMarketplaceModelEndpoint(UpdateMarketplaceModelEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateMarketplaceModelEndpointResponse>(request, options);
        }


        /// <summary>
        /// Updates the configuration of an existing endpoint for a model from Amazon Bedrock
        /// Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMarketplaceModelEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateMarketplaceModelEndpoint">REST API Reference for UpdateMarketplaceModelEndpoint Operation</seealso>
        public virtual Task<UpdateMarketplaceModelEndpointResponse> UpdateMarketplaceModelEndpointAsync(UpdateMarketplaceModelEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMarketplaceModelEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateMarketplaceModelEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProvisionedModelThroughput


        /// <summary>
        /// Updates the name or associated model for a Provisioned Throughput. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedModelThroughput service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateProvisionedModelThroughput">REST API Reference for UpdateProvisionedModelThroughput Operation</seealso>
        public virtual UpdateProvisionedModelThroughputResponse UpdateProvisionedModelThroughput(UpdateProvisionedModelThroughputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisionedModelThroughputResponseUnmarshaller.Instance;

            return Invoke<UpdateProvisionedModelThroughputResponse>(request, options);
        }


        /// <summary>
        /// Updates the name or associated model for a Provisioned Throughput. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedModelThroughput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateProvisionedModelThroughput">REST API Reference for UpdateProvisionedModelThroughput Operation</seealso>
        public virtual Task<UpdateProvisionedModelThroughputResponse> UpdateProvisionedModelThroughputAsync(UpdateProvisionedModelThroughputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisionedModelThroughputResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProvisionedModelThroughputResponse>(request, options, cancellationToken);
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